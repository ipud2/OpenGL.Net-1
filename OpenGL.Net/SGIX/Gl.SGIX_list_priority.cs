
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
		/// [GL] Value of GL_LIST_PRIORITY_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_list_priority")]
		public const int LIST_PRIORITY_SGIX = 0x8182;

		/// <summary>
		/// [GL] glGetListParameterfvSGIX: Binding for glGetListParameterfvSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ListParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_list_priority")]
		public static void GetListParameterSGIX(UInt32 list, ListParameterName pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetListParameterfvSGIX != null, "pglGetListParameterfvSGIX not implemented");
					Delegates.pglGetListParameterfvSGIX(list, (Int32)pname, p_params);
					LogCommand("glGetListParameterfvSGIX", null, list, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetListParameterivSGIX: Binding for glGetListParameterivSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ListParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_list_priority")]
		public static void GetListParameterSGIX(UInt32 list, ListParameterName pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetListParameterivSGIX != null, "pglGetListParameterivSGIX not implemented");
					Delegates.pglGetListParameterivSGIX(list, (Int32)pname, p_params);
					LogCommand("glGetListParameterivSGIX", null, list, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glListParameterfSGIX: Binding for glListParameterfSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ListParameterName"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_list_priority")]
		public static void ListParameterSGIX(UInt32 list, ListParameterName pname, float param)
		{
			Debug.Assert(Delegates.pglListParameterfSGIX != null, "pglListParameterfSGIX not implemented");
			Delegates.pglListParameterfSGIX(list, (Int32)pname, param);
			LogCommand("glListParameterfSGIX", null, list, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glListParameterfvSGIX: Binding for glListParameterfvSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ListParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_list_priority")]
		public static void ListParameterSGIX(UInt32 list, ListParameterName pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglListParameterfvSGIX != null, "pglListParameterfvSGIX not implemented");
					Delegates.pglListParameterfvSGIX(list, (Int32)pname, p_params);
					LogCommand("glListParameterfvSGIX", null, list, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glListParameteriSGIX: Binding for glListParameteriSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ListParameterName"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_list_priority")]
		public static void ListParameterSGIX(UInt32 list, ListParameterName pname, Int32 param)
		{
			Debug.Assert(Delegates.pglListParameteriSGIX != null, "pglListParameteriSGIX not implemented");
			Delegates.pglListParameteriSGIX(list, (Int32)pname, param);
			LogCommand("glListParameteriSGIX", null, list, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glListParameterivSGIX: Binding for glListParameterivSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ListParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_list_priority")]
		public static void ListParameterSGIX(UInt32 list, ListParameterName pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglListParameterivSGIX != null, "pglListParameterivSGIX not implemented");
					Delegates.pglListParameterivSGIX(list, (Int32)pname, p_params);
					LogCommand("glListParameterivSGIX", null, list, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetListParameterfvSGIX", ExactSpelling = true)]
			internal extern static unsafe void glGetListParameterfvSGIX(UInt32 list, Int32 pname, float* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetListParameterivSGIX", ExactSpelling = true)]
			internal extern static unsafe void glGetListParameterivSGIX(UInt32 list, Int32 pname, Int32* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glListParameterfSGIX", ExactSpelling = true)]
			internal extern static void glListParameterfSGIX(UInt32 list, Int32 pname, float param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glListParameterfvSGIX", ExactSpelling = true)]
			internal extern static unsafe void glListParameterfvSGIX(UInt32 list, Int32 pname, float* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glListParameteriSGIX", ExactSpelling = true)]
			internal extern static void glListParameteriSGIX(UInt32 list, Int32 pname, Int32 param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glListParameterivSGIX", ExactSpelling = true)]
			internal extern static unsafe void glListParameterivSGIX(UInt32 list, Int32 pname, Int32* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_SGIX_list_priority")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetListParameterfvSGIX(UInt32 list, Int32 pname, float* @params);

			[RequiredByFeature("GL_SGIX_list_priority")]
			[ThreadStatic]
			internal static glGetListParameterfvSGIX pglGetListParameterfvSGIX;

			[RequiredByFeature("GL_SGIX_list_priority")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetListParameterivSGIX(UInt32 list, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_SGIX_list_priority")]
			[ThreadStatic]
			internal static glGetListParameterivSGIX pglGetListParameterivSGIX;

			[RequiredByFeature("GL_SGIX_list_priority")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glListParameterfSGIX(UInt32 list, Int32 pname, float param);

			[RequiredByFeature("GL_SGIX_list_priority")]
			[ThreadStatic]
			internal static glListParameterfSGIX pglListParameterfSGIX;

			[RequiredByFeature("GL_SGIX_list_priority")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glListParameterfvSGIX(UInt32 list, Int32 pname, float* @params);

			[RequiredByFeature("GL_SGIX_list_priority")]
			[ThreadStatic]
			internal static glListParameterfvSGIX pglListParameterfvSGIX;

			[RequiredByFeature("GL_SGIX_list_priority")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glListParameteriSGIX(UInt32 list, Int32 pname, Int32 param);

			[RequiredByFeature("GL_SGIX_list_priority")]
			[ThreadStatic]
			internal static glListParameteriSGIX pglListParameteriSGIX;

			[RequiredByFeature("GL_SGIX_list_priority")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glListParameterivSGIX(UInt32 list, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_SGIX_list_priority")]
			[ThreadStatic]
			internal static glListParameterivSGIX pglListParameterivSGIX;

		}
	}

}
