
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
	public partial class Egl
	{
		/// <summary>
		/// [EGL] Value of EGL_STREAM_BIT_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream_producer_eglsurface")]
		[Log(BitmaskName = "EGLSurfaceTypeMask")]
		public const int STREAM_BIT_KHR = 0x0800;

		/// <summary>
		/// [EGL] eglCreateStreamProducerSurfaceKHR: Binding for eglCreateStreamProducerSurfaceKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_producer_eglsurface")]
		public static IntPtr CreateStreamProducerSurfaceKHR(IntPtr dpy, IntPtr config, IntPtr stream, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateStreamProducerSurfaceKHR != null, "peglCreateStreamProducerSurfaceKHR not implemented");
					retValue = Delegates.peglCreateStreamProducerSurfaceKHR(dpy, config, stream, p_attrib_list);
					LogCommand("eglCreateStreamProducerSurfaceKHR", retValue, dpy, config, stream, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglCreateStreamProducerSurfaceKHR", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateStreamProducerSurfaceKHR(IntPtr dpy, IntPtr config, IntPtr stream, int* attrib_list);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_KHR_stream_producer_eglsurface")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr eglCreateStreamProducerSurfaceKHR(IntPtr dpy, IntPtr config, IntPtr stream, int* attrib_list);

			[RequiredByFeature("EGL_KHR_stream_producer_eglsurface")]
			internal static eglCreateStreamProducerSurfaceKHR peglCreateStreamProducerSurfaceKHR;

		}
	}

}
