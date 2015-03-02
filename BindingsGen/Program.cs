
// Copyright (C) 2015 Luca Piccioni
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

using BindingsGen.GLSpecs;

namespace BindingsGen
{
	class Program
	{
		/// <summary>
		/// Application entry point.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			RegistryContext ctx;
			RegistryProcessor glRegistryProcessor;

			ExtensionIndices.Touch();
			RegistryDocumentation.Touch();

			// OpenGL
			if (false) {
				ctx = new RegistryContext("Gl", Path.Combine(BasePath, "GLSpecs/gl.xml"));
				glRegistryProcessor = new RegistryProcessor(ctx.Registry);
				GenerateCommandsAndEnums(glRegistryProcessor, ctx);
			}

			// OpenGL for Windows
			ctx = new RegistryContext("Wgl", Path.Combine(BasePath, "GLSpecs/wgl.xml"));
			glRegistryProcessor = new RegistryProcessor(ctx.Registry);
			GenerateCommandsAndEnums(glRegistryProcessor, ctx);
		}

        internal static readonly string BasePath = "../../../";

		private static void GenerateCommands(RegistryProcessor glRegistryProcessor, RegistryContext ctx)
		{
			List<Command> commands = ctx.Registry.Commands;
			Dictionary<string, bool> serializedCommands = new Dictionary<string, bool>(commands.Count);

			foreach (IFeature feature in ctx.Registry.AllFeatures(ctx)) {
				List<Command> featureCommands = new List<Command>();

				foreach (FeatureCommand featureCommand in feature.Requirements) {
					if (featureCommand.Api != null && featureCommand.Api != "gl")
						continue;

					foreach (FeatureCommand.Item featureCommandItem in featureCommand.Commands) {
						Command command = ctx.Registry.GetCommand(featureCommandItem.Name);

						Debug.Assert(command != null);
						if (serializedCommands.ContainsKey(command.Prototype.Name))
							continue;

						serializedCommands.Add(command.Prototype.Name, true);
						featureCommands.Add(command);
					}
				}

				if (featureCommands.Count == 0)
					continue;

				glRegistryProcessor.GenerateCommands(ctx, GetFeatureFilePath(feature, ctx), delegate(RegistryContext cctx, SourceStreamWriter sw)
				{
					foreach (Command command in featureCommands) {
						command.GenerateImplementations(sw, cctx);
						sw.WriteLine();
					}
				});
			}

			glRegistryProcessor.GenerateCommandsImports(ctx, Path.Combine(BasePath, "OpenGL.NET/GlFunctsDelegates.cs"), null);
			glRegistryProcessor.GenerateCommandsDelegates(ctx, Path.Combine(BasePath, "OpenGL.NET/GlFunctsPointers.cs"), null);
		}

		private static void GenerateCommandsAndEnums(RegistryProcessor glRegistryProcessor, RegistryContext ctx)
		{
			Dictionary<string, bool> serializedCommands = new Dictionary<string, bool>();
			Dictionary<string, bool> serializedEnums = new Dictionary<string, bool>();

			glRegistryProcessor.GenerateStronglyTypedEnums(ctx, Path.Combine(BasePath, String.Format("OpenGL.NET/{0}.Enums.cs", ctx.Class)), null);
			glRegistryProcessor.GenerateCommandsImports(ctx, Path.Combine(BasePath, String.Format("OpenGL.NET/{0}.Delegates.cs", ctx.Class)), null);
			glRegistryProcessor.GenerateCommandsDelegates(ctx, Path.Combine(BasePath, String.Format("OpenGL.NET/{0}.Imports.cs", ctx.Class)), null);

			#region By features and extensions

			foreach (IFeature feature in ctx.Registry.AllFeatures(ctx))
			{
				List<Command> featureCommands = new List<Command>();
				List<Enumerant> featureEnums = new List<Enumerant>();

				foreach (FeatureCommand featureCommand in feature.Requirements)
				{
					if (featureCommand.Api != null && featureCommand.Api != ctx.Class.ToLower())
						continue;

					foreach (FeatureCommand.Item featureCommandItem in featureCommand.Commands) {
						Command command = ctx.Registry.GetCommand(featureCommandItem.Name);

						Debug.Assert(command != null);
						if (serializedCommands.ContainsKey(command.Prototype.Name))
							continue;

						serializedCommands.Add(command.Prototype.Name, true);
						featureCommands.Add(command);
					}

					foreach (FeatureCommand.Item featureEnumItem in featureCommand.Enums) {
						Enumerant enumerant = ctx.Registry.GetGlEnumerant(featureEnumItem.Name);

						Debug.Assert(enumerant != null);
						if (serializedEnums.ContainsKey(enumerant.Name))
							continue;

						serializedEnums.Add(enumerant.Name, true);
						featureEnums.Add(enumerant);
					}
				}

				if ((featureCommands.Count == 0) && (featureEnums.Count == 0))
					continue;

				glRegistryProcessor.GenerateCommands(ctx, GetFeatureFilePath(feature, ctx), delegate(RegistryContext cctx, SourceStreamWriter sw)
				{
					foreach (Enumerant enumerant in featureEnums)
					{
						enumerant.GenerateSource(sw);
						sw.WriteLine();
					}

					foreach (Command command in featureCommands)
					{
						command.GenerateImplementations(sw, cctx);
						sw.WriteLine();
					}
				});
			}

			#endregion

			List<Command> orphanCommands = new List<Command>();
			List<Enumerant> orphanEnums = new List<Enumerant>();

			foreach (Command command in ctx.Registry.Commands) {
				if (serializedCommands.ContainsKey(command.Prototype.Name))
					continue;

				orphanCommands.Add(command);
			}

			foreach (Enumerant enumerant in ctx.Registry.Enumerants) {
				if (serializedEnums.ContainsKey(enumerant.Name))
					continue;

				orphanEnums.Add(enumerant);
			}

			if ((orphanCommands.Count != 0) || (orphanEnums.Count != 0)) {
				glRegistryProcessor.GenerateCommands(ctx, Path.Combine(BasePath, String.Format("OpenGL.NET/{0}.Orphans.cs", ctx.Class)), delegate(RegistryContext cctx, SourceStreamWriter sw)
				{
					foreach (Enumerant enumerant in orphanEnums)
					{
						enumerant.GenerateSource(sw);
						sw.WriteLine();
					}

					foreach (Command command in orphanCommands)
					{
						command.GenerateImplementations(sw, cctx);
						sw.WriteLine();
					}
				});
			}
		}

		private static string GetFeatureFilePath(IFeature feature, RegistryContext ctx)
		{
			string path = String.Format("OpenGL.NET/{0}.{1}.cs", ctx.Class, feature.Name.Substring(ctx.Class.Length + 1));
			string featureName = feature.Name.Substring(ctx.Class.Length + 1);
			int separatorIndex = featureName.IndexOf('_');

			if (separatorIndex >= 0) {
				string ext = featureName.Substring(0, separatorIndex);

				if (ctx.ExtensionsDictionary.HasWord(ext)) {
					string extensionDir = Path.Combine(BasePath, String.Format("OpenGL.NET/{0}", ext));
					if (!Directory.Exists(extensionDir))
						Directory.CreateDirectory(extensionDir);
					path = String.Format("OpenGL.NET/{2}/{0}.{1}.cs", ctx.Class, featureName, ext);
				}
			}

			return (Path.Combine(BasePath, path));
		}
	}
}
