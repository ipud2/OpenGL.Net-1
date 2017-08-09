
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
		/// [EGL] Value of EGL_SYNC_NEW_FRAME_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_sync")]
		public const int SYNC_NEW_FRAME_NV = 0x321F;

		/// <summary>
		/// [EGL] eglCreateStreamSyncNV: Binding for eglCreateStreamSyncNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_stream_sync")]
		public static IntPtr CreateStreamSyncNV(IntPtr dpy, IntPtr stream, uint type, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateStreamSyncNV != null, "peglCreateStreamSyncNV not implemented");
					retValue = Delegates.peglCreateStreamSyncNV(dpy, stream, type, p_attrib_list);
					LogCommand("eglCreateStreamSyncNV", retValue, dpy, stream, type, attrib_list					);
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
			[DllImport(Library, EntryPoint = "eglCreateStreamSyncNV", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateStreamSyncNV(IntPtr dpy, IntPtr stream, uint type, int* attrib_list);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_NV_stream_sync")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr eglCreateStreamSyncNV(IntPtr dpy, IntPtr stream, uint type, int* attrib_list);

			[RequiredByFeature("EGL_NV_stream_sync")]
			internal static eglCreateStreamSyncNV peglCreateStreamSyncNV;

		}
	}

}
