
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
	public partial class Wgl
	{
		/// <summary>
		/// [WGL] Value of WGL_CONTEXT_DEBUG_BIT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_create_context")]
		[Log(BitmaskName = "WGLContextFlagsMask")]
		public const uint CONTEXT_DEBUG_BIT_ARB = 0x00000001;

		/// <summary>
		/// [WGL] Value of WGL_CONTEXT_FORWARD_COMPATIBLE_BIT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_create_context")]
		[Log(BitmaskName = "WGLContextFlagsMask")]
		public const uint CONTEXT_FORWARD_COMPATIBLE_BIT_ARB = 0x00000002;

		/// <summary>
		/// [WGL] Value of WGL_CONTEXT_MAJOR_VERSION_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_create_context")]
		public const int CONTEXT_MAJOR_VERSION_ARB = 0x2091;

		/// <summary>
		/// [WGL] Value of WGL_CONTEXT_MINOR_VERSION_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_create_context")]
		public const int CONTEXT_MINOR_VERSION_ARB = 0x2092;

		/// <summary>
		/// [WGL] Value of WGL_CONTEXT_LAYER_PLANE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_create_context")]
		public const int CONTEXT_LAYER_PLANE_ARB = 0x2093;

		/// <summary>
		/// [WGL] Value of WGL_CONTEXT_FLAGS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_create_context")]
		public const int CONTEXT_FLAGS_ARB = 0x2094;

		/// <summary>
		/// [WGL] Value of ERROR_INVALID_VERSION_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_create_context")]
		public const int ERROR_INVALID_VERSION_ARB = 0x2095;

		/// <summary>
		/// [WGL] wglCreateContextAttribsARB: Binding for wglCreateContextAttribsARB.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hShareContext">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribList">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_create_context")]
		public static IntPtr CreateContextAttribsARB(IntPtr hDC, IntPtr hShareContext, int[] attribList)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attribList = attribList)
				{
					Debug.Assert(Delegates.pwglCreateContextAttribsARB != null, "pwglCreateContextAttribsARB not implemented");
					retValue = Delegates.pwglCreateContextAttribsARB(hDC, hShareContext, p_attribList);
					LogCommand("wglCreateContextAttribsARB", retValue, hDC, hShareContext, attribList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglCreateContextAttribsARB", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreateContextAttribsARB(IntPtr hDC, IntPtr hShareContext, int* attribList);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_ARB_create_context")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr wglCreateContextAttribsARB(IntPtr hDC, IntPtr hShareContext, int* attribList);

			[RequiredByFeature("WGL_ARB_create_context")]
			[ThreadStatic]
			internal static wglCreateContextAttribsARB pwglCreateContextAttribsARB;

		}
	}

}
