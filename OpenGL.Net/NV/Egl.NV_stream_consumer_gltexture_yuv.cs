
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
		/// [EGL] Value of EGL_YUV_PLANE0_TEXTURE_UNIT_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_consumer_gltexture_yuv")]
		public const int YUV_PLANE0_TEXTURE_UNIT_NV = 0x332C;

		/// <summary>
		/// [EGL] Value of EGL_YUV_PLANE1_TEXTURE_UNIT_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_consumer_gltexture_yuv")]
		public const int YUV_PLANE1_TEXTURE_UNIT_NV = 0x332D;

		/// <summary>
		/// [EGL] Value of EGL_YUV_PLANE2_TEXTURE_UNIT_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_consumer_gltexture_yuv")]
		public const int YUV_PLANE2_TEXTURE_UNIT_NV = 0x332E;

		/// <summary>
		/// [EGL] eglStreamConsumerGLTextureExternalAttribsNV: Binding for eglStreamConsumerGLTextureExternalAttribsNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_stream_consumer_gltexture_yuv")]
		public static bool StreamConsumerGLTextureExternalAttribsNV(IntPtr dpy, IntPtr stream, IntPtr[] attrib_list)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglStreamConsumerGLTextureExternalAttribsNV != null, "peglStreamConsumerGLTextureExternalAttribsNV not implemented");
					retValue = Delegates.peglStreamConsumerGLTextureExternalAttribsNV(dpy, stream, p_attrib_list);
					LogCommand("eglStreamConsumerGLTextureExternalAttribsNV", retValue, dpy, stream, attrib_list					);
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
			[DllImport(Library, EntryPoint = "eglStreamConsumerGLTextureExternalAttribsNV", ExactSpelling = true)]
			internal extern static unsafe bool eglStreamConsumerGLTextureExternalAttribsNV(IntPtr dpy, IntPtr stream, IntPtr* attrib_list);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_NV_stream_consumer_gltexture_yuv")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglStreamConsumerGLTextureExternalAttribsNV(IntPtr dpy, IntPtr stream, IntPtr* attrib_list);

			[RequiredByFeature("EGL_NV_stream_consumer_gltexture_yuv")]
			internal static eglStreamConsumerGLTextureExternalAttribsNV peglStreamConsumerGLTextureExternalAttribsNV;

		}
	}

}
