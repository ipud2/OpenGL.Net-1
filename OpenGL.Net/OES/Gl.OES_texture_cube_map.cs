
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
		/// [GL] Value of GL_TEXTURE_GEN_STR_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public const int TEXTURE_GEN_STR_OES = 0x8D60;

		/// <summary>
		/// [GL] glTexGenfOES: Binding for glTexGenfOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:TextureCoordName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureGenParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public static void TexGenOES(TextureCoordName coord, TextureGenParameter pname, float param)
		{
			Debug.Assert(Delegates.pglTexGenfOES != null, "pglTexGenfOES not implemented");
			Delegates.pglTexGenfOES((Int32)coord, (Int32)pname, param);
			LogCommand("glTexGenfOES", null, coord, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTexGenfvOES: Binding for glTexGenfvOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:TextureCoordName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureGenParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public static void TexGenOES(TextureCoordName coord, TextureGenParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGenfvOES != null, "pglTexGenfvOES not implemented");
					Delegates.pglTexGenfvOES((Int32)coord, (Int32)pname, p_params);
					LogCommand("glTexGenfvOES", null, coord, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTexGeniOES: Binding for glTexGeniOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:TextureCoordName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureGenParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public static void TexGenOES(TextureCoordName coord, TextureGenParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexGeniOES != null, "pglTexGeniOES not implemented");
			Delegates.pglTexGeniOES((Int32)coord, (Int32)pname, param);
			LogCommand("glTexGeniOES", null, coord, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTexGenivOES: Binding for glTexGenivOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:TextureCoordName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureGenParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public static void TexGenOES(TextureCoordName coord, TextureGenParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGenivOES != null, "pglTexGenivOES not implemented");
					Delegates.pglTexGenivOES((Int32)coord, (Int32)pname, p_params);
					LogCommand("glTexGenivOES", null, coord, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetTexGenfvOES: Binding for glGetTexGenfvOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:TextureCoordName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureGenParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public static void GetTexGenOES(TextureCoordName coord, TextureGenParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGenfvOES != null, "pglGetTexGenfvOES not implemented");
					Delegates.pglGetTexGenfvOES((Int32)coord, (Int32)pname, p_params);
					LogCommand("glGetTexGenfvOES", null, coord, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetTexGenivOES: Binding for glGetTexGenivOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:TextureCoordName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureGenParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public static void GetTexGenOES(TextureCoordName coord, TextureGenParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGenivOES != null, "pglGetTexGenivOES not implemented");
					Delegates.pglGetTexGenivOES((Int32)coord, (Int32)pname, p_params);
					LogCommand("glGetTexGenivOES", null, coord, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexGenfOES", ExactSpelling = true)]
			internal extern static void glTexGenfOES(Int32 coord, Int32 pname, float param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexGenfvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexGenfvOES(Int32 coord, Int32 pname, float* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexGeniOES", ExactSpelling = true)]
			internal extern static void glTexGeniOES(Int32 coord, Int32 pname, Int32 param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexGenivOES", ExactSpelling = true)]
			internal extern static unsafe void glTexGenivOES(Int32 coord, Int32 pname, Int32* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetTexGenfvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetTexGenfvOES(Int32 coord, Int32 pname, float* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetTexGenivOES", ExactSpelling = true)]
			internal extern static unsafe void glGetTexGenivOES(Int32 coord, Int32 pname, Int32* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glTexGenfOES(Int32 coord, Int32 pname, float param);

			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			[ThreadStatic]
			internal static glTexGenfOES pglTexGenfOES;

			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTexGenfvOES(Int32 coord, Int32 pname, float* @params);

			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			[ThreadStatic]
			internal static glTexGenfvOES pglTexGenfvOES;

			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glTexGeniOES(Int32 coord, Int32 pname, Int32 param);

			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			[ThreadStatic]
			internal static glTexGeniOES pglTexGeniOES;

			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTexGenivOES(Int32 coord, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			[ThreadStatic]
			internal static glTexGenivOES pglTexGenivOES;

			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetTexGenfvOES(Int32 coord, Int32 pname, float* @params);

			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			[ThreadStatic]
			internal static glGetTexGenfvOES pglGetTexGenfvOES;

			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetTexGenivOES(Int32 coord, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			[ThreadStatic]
			internal static glGetTexGenivOES pglGetTexGenivOES;

		}
	}

}
