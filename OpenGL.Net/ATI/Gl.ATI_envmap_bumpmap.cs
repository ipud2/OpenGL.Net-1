
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
		/// [GL] Value of GL_BUMP_ROT_MATRIX_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public const int BUMP_ROT_MATRIX_ATI = 0x8775;

		/// <summary>
		/// [GL] Value of GL_BUMP_ROT_MATRIX_SIZE_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public const int BUMP_ROT_MATRIX_SIZE_ATI = 0x8776;

		/// <summary>
		/// [GL] Value of GL_BUMP_NUM_TEX_UNITS_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public const int BUMP_NUM_TEX_UNITS_ATI = 0x8777;

		/// <summary>
		/// [GL] Value of GL_BUMP_TEX_UNITS_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public const int BUMP_TEX_UNITS_ATI = 0x8778;

		/// <summary>
		/// [GL] Value of GL_DUDV_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public const int DUDV_ATI = 0x8779;

		/// <summary>
		/// [GL] Value of GL_DU8DV8_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public const int DU8DV8_ATI = 0x877A;

		/// <summary>
		/// [GL] Value of GL_BUMP_ENVMAP_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public const int BUMP_ENVMAP_ATI = 0x877B;

		/// <summary>
		/// [GL] Value of GL_BUMP_TARGET_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public const int BUMP_TARGET_ATI = 0x877C;

		/// <summary>
		/// [GL] glTexBumpParameterivATI: Binding for glTexBumpParameterivATI.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public static void TexBumpParameterATI(Int32 pname, Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglTexBumpParameterivATI != null, "pglTexBumpParameterivATI not implemented");
					Delegates.pglTexBumpParameterivATI(pname, p_param);
					LogCommand("glTexBumpParameterivATI", null, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTexBumpParameterfvATI: Binding for glTexBumpParameterfvATI.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public static void TexBumpParameterATI(Int32 pname, float[] param)
		{
			unsafe {
				fixed (float* p_param = param)
				{
					Debug.Assert(Delegates.pglTexBumpParameterfvATI != null, "pglTexBumpParameterfvATI not implemented");
					Delegates.pglTexBumpParameterfvATI(pname, p_param);
					LogCommand("glTexBumpParameterfvATI", null, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetTexBumpParameterivATI: Binding for glGetTexBumpParameterivATI.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public static void GetTexBumpParameterATI(Int32 pname, [Out] Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglGetTexBumpParameterivATI != null, "pglGetTexBumpParameterivATI not implemented");
					Delegates.pglGetTexBumpParameterivATI(pname, p_param);
					LogCommand("glGetTexBumpParameterivATI", null, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetTexBumpParameterfvATI: Binding for glGetTexBumpParameterfvATI.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_envmap_bumpmap")]
		public static void GetTexBumpParameterATI(Int32 pname, [Out] float[] param)
		{
			unsafe {
				fixed (float* p_param = param)
				{
					Debug.Assert(Delegates.pglGetTexBumpParameterfvATI != null, "pglGetTexBumpParameterfvATI not implemented");
					Delegates.pglGetTexBumpParameterfvATI(pname, p_param);
					LogCommand("glGetTexBumpParameterfvATI", null, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexBumpParameterivATI", ExactSpelling = true)]
			internal extern static unsafe void glTexBumpParameterivATI(Int32 pname, Int32* param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexBumpParameterfvATI", ExactSpelling = true)]
			internal extern static unsafe void glTexBumpParameterfvATI(Int32 pname, float* param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetTexBumpParameterivATI", ExactSpelling = true)]
			internal extern static unsafe void glGetTexBumpParameterivATI(Int32 pname, Int32* param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetTexBumpParameterfvATI", ExactSpelling = true)]
			internal extern static unsafe void glGetTexBumpParameterfvATI(Int32 pname, float* param);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ATI_envmap_bumpmap")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTexBumpParameterivATI(Int32 pname, Int32* param);

			[RequiredByFeature("GL_ATI_envmap_bumpmap")]
			[ThreadStatic]
			internal static glTexBumpParameterivATI pglTexBumpParameterivATI;

			[RequiredByFeature("GL_ATI_envmap_bumpmap")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTexBumpParameterfvATI(Int32 pname, float* param);

			[RequiredByFeature("GL_ATI_envmap_bumpmap")]
			[ThreadStatic]
			internal static glTexBumpParameterfvATI pglTexBumpParameterfvATI;

			[RequiredByFeature("GL_ATI_envmap_bumpmap")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetTexBumpParameterivATI(Int32 pname, Int32* param);

			[RequiredByFeature("GL_ATI_envmap_bumpmap")]
			[ThreadStatic]
			internal static glGetTexBumpParameterivATI pglGetTexBumpParameterivATI;

			[RequiredByFeature("GL_ATI_envmap_bumpmap")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetTexBumpParameterfvATI(Int32 pname, float* param);

			[RequiredByFeature("GL_ATI_envmap_bumpmap")]
			[ThreadStatic]
			internal static glGetTexBumpParameterfvATI pglGetTexBumpParameterfvATI;

		}
	}

}
