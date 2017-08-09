
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
		/// [GL] Value of GL_DATA_BUFFER_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_name_gen_delete")]
		public const int DATA_BUFFER_AMD = 0x9151;

		/// <summary>
		/// [GL] Value of GL_PERFORMANCE_MONITOR_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_name_gen_delete")]
		public const int PERFORMANCE_MONITOR_AMD = 0x9152;

		/// <summary>
		/// [GL] Value of GL_SAMPLER_OBJECT_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_name_gen_delete")]
		public const int SAMPLER_OBJECT_AMD = 0x9155;

		/// <summary>
		/// [GL] glGenNamesAMD: Binding for glGenNamesAMD.
		/// </summary>
		/// <param name="identifier">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="names">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_name_gen_delete")]
		public static void GenNameAMD(Int32 identifier, UInt32[] names)
		{
			unsafe {
				fixed (UInt32* p_names = names)
				{
					Debug.Assert(Delegates.pglGenNamesAMD != null, "pglGenNamesAMD not implemented");
					Delegates.pglGenNamesAMD(identifier, (UInt32)names.Length, p_names);
					LogCommand("glGenNamesAMD", null, identifier, names.Length, names					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGenNamesAMD: Binding for glGenNamesAMD.
		/// </summary>
		/// <param name="identifier">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_name_gen_delete")]
		public static UInt32 GenNameAMD(Int32 identifier)
		{
			UInt32[] retValue = new UInt32[1];
			GenNameAMD(identifier, retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// [GL] glDeleteNamesAMD: Binding for glDeleteNamesAMD.
		/// </summary>
		/// <param name="identifier">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="names">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_name_gen_delete")]
		public static void DeleteNameAMD(Int32 identifier, UInt32[] names)
		{
			unsafe {
				fixed (UInt32* p_names = names)
				{
					Debug.Assert(Delegates.pglDeleteNamesAMD != null, "pglDeleteNamesAMD not implemented");
					Delegates.pglDeleteNamesAMD(identifier, (UInt32)names.Length, p_names);
					LogCommand("glDeleteNamesAMD", null, identifier, names.Length, names					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glIsNameAMD: Binding for glIsNameAMD.
		/// </summary>
		/// <param name="identifier">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_name_gen_delete")]
		public static bool IsNameAMD(Int32 identifier, UInt32 name)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsNameAMD != null, "pglIsNameAMD not implemented");
			retValue = Delegates.pglIsNameAMD(identifier, name);
			LogCommand("glIsNameAMD", retValue, identifier, name			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGenNamesAMD", ExactSpelling = true)]
			internal extern static unsafe void glGenNamesAMD(Int32 identifier, UInt32 num, UInt32* names);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glDeleteNamesAMD", ExactSpelling = true)]
			internal extern static unsafe void glDeleteNamesAMD(Int32 identifier, UInt32 num, UInt32* names);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glIsNameAMD", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.U1)]
			internal extern static bool glIsNameAMD(Int32 identifier, UInt32 name);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_AMD_name_gen_delete")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGenNamesAMD(Int32 identifier, UInt32 num, UInt32* names);

			[RequiredByFeature("GL_AMD_name_gen_delete")]
			[ThreadStatic]
			internal static glGenNamesAMD pglGenNamesAMD;

			[RequiredByFeature("GL_AMD_name_gen_delete")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glDeleteNamesAMD(Int32 identifier, UInt32 num, UInt32* names);

			[RequiredByFeature("GL_AMD_name_gen_delete")]
			[ThreadStatic]
			internal static glDeleteNamesAMD pglDeleteNamesAMD;

			[RequiredByFeature("GL_AMD_name_gen_delete")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate bool glIsNameAMD(Int32 identifier, UInt32 name);

			[RequiredByFeature("GL_AMD_name_gen_delete")]
			[ThreadStatic]
			internal static glIsNameAMD pglIsNameAMD;

		}
	}

}
