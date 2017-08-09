
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_MAX_SHADER_COMPILER_THREADS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_parallel_shader_compile", Api = "gl|glcore")]
		public const int MAX_SHADER_COMPILER_THREADS_ARB = 0x91B0;

		/// <summary>
		/// [GL] Value of GL_COMPLETION_STATUS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_parallel_shader_compile", Api = "gl|glcore")]
		public const int COMPLETION_STATUS_ARB = 0x91B1;

		/// <summary>
		/// [GL] glMaxShaderCompilerThreadsARB: Binding for glMaxShaderCompilerThreadsARB.
		/// </summary>
		/// <param name="count">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_parallel_shader_compile", Api = "gl|glcore")]
		public static void MaxShaderCompilerThreadsARB(UInt32 count)
		{
			Debug.Assert(Delegates.pglMaxShaderCompilerThreadsARB != null, "pglMaxShaderCompilerThreadsARB not implemented");
			Delegates.pglMaxShaderCompilerThreadsARB(count);
			LogCommand("glMaxShaderCompilerThreadsARB", null, count			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glMaxShaderCompilerThreadsARB", ExactSpelling = true)]
			internal extern static void glMaxShaderCompilerThreadsARB(UInt32 count);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ARB_parallel_shader_compile", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glMaxShaderCompilerThreadsARB(UInt32 count);

			[RequiredByFeature("GL_ARB_parallel_shader_compile", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glMaxShaderCompilerThreadsARB pglMaxShaderCompilerThreadsARB;

		}
	}

}
