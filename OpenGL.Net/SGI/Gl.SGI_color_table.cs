
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
		/// [GL] glGetColorTableSGI: Binding for glGetColorTableSGI.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTarget"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_SGI_color_table")]
		public static void GetColorTableSGI(ColorTableTarget target, PixelFormat format, PixelType type, IntPtr table)
		{
			Debug.Assert(Delegates.pglGetColorTableSGI != null, "pglGetColorTableSGI not implemented");
			Delegates.pglGetColorTableSGI((Int32)target, (Int32)format, (Int32)type, table);
			LogCommand("glGetColorTableSGI", null, target, format, type, table			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetColorTableSGI: Binding for glGetColorTableSGI.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTarget"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_SGI_color_table")]
		public static void GetColorTableSGI(ColorTableTarget target, PixelFormat format, PixelType type, Object table)
		{
			GCHandle pin_table = GCHandle.Alloc(table, GCHandleType.Pinned);
			try {
				GetColorTableSGI(target, format, type, pin_table.AddrOfPinnedObject());
			} finally {
				pin_table.Free();
			}
		}

		/// <summary>
		/// [GL] glGetColorTableParameterfvSGI: Binding for glGetColorTableParameterfvSGI.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetColorTableParameterPNameSGI"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGI_color_table")]
		public static void GetColorTableParameterSGI(ColorTableTarget target, GetColorTableParameterPNameSGI pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetColorTableParameterfvSGI != null, "pglGetColorTableParameterfvSGI not implemented");
					Delegates.pglGetColorTableParameterfvSGI((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetColorTableParameterfvSGI", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetColorTableParameterivSGI: Binding for glGetColorTableParameterivSGI.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetColorTableParameterPNameSGI"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGI_color_table")]
		public static void GetColorTableParameterSGI(ColorTableTarget target, GetColorTableParameterPNameSGI pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetColorTableParameterivSGI != null, "pglGetColorTableParameterivSGI not implemented");
					Delegates.pglGetColorTableParameterivSGI((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetColorTableParameterivSGI", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetColorTableSGI", ExactSpelling = true)]
			internal extern static unsafe void glGetColorTableSGI(Int32 target, Int32 format, Int32 type, IntPtr table);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetColorTableParameterfvSGI", ExactSpelling = true)]
			internal extern static unsafe void glGetColorTableParameterfvSGI(Int32 target, Int32 pname, float* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetColorTableParameterivSGI", ExactSpelling = true)]
			internal extern static unsafe void glGetColorTableParameterivSGI(Int32 target, Int32 pname, Int32* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_SGI_color_table")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetColorTableSGI(Int32 target, Int32 format, Int32 type, IntPtr table);

			[RequiredByFeature("GL_SGI_color_table")]
			[ThreadStatic]
			internal static glGetColorTableSGI pglGetColorTableSGI;

			[RequiredByFeature("GL_SGI_color_table")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetColorTableParameterfvSGI(Int32 target, Int32 pname, float* @params);

			[RequiredByFeature("GL_SGI_color_table")]
			[ThreadStatic]
			internal static glGetColorTableParameterfvSGI pglGetColorTableParameterfvSGI;

			[RequiredByFeature("GL_SGI_color_table")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetColorTableParameterivSGI(Int32 target, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_SGI_color_table")]
			[ThreadStatic]
			internal static glGetColorTableParameterivSGI pglGetColorTableParameterivSGI;

		}
	}

}
