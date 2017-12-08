
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

using Khronos;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] glRenderbufferStorageMultisampleAPPLE: Binding for glRenderbufferStorageMultisampleAPPLE.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:RenderbufferTarget"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:InternalFormat"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
		public static void RenderbufferStorageMultisampleAPPLE(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageMultisampleAPPLE != null, "pglRenderbufferStorageMultisampleAPPLE not implemented");
			Delegates.pglRenderbufferStorageMultisampleAPPLE((int)target, samples, (int)internalformat, width, height);
			LogCommand("glRenderbufferStorageMultisampleAPPLE", null, target, samples, internalformat, width, height			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glResolveMultisampleFramebufferAPPLE: Binding for glResolveMultisampleFramebufferAPPLE.
		/// </summary>
		[RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
		public static void ResolveMultisampleFramebufferAPPLE()
		{
			Debug.Assert(Delegates.pglResolveMultisampleFramebufferAPPLE != null, "pglResolveMultisampleFramebufferAPPLE not implemented");
			Delegates.pglResolveMultisampleFramebufferAPPLE();
			LogCommand("glResolveMultisampleFramebufferAPPLE", null			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRenderbufferStorageMultisampleAPPLE(int target, int samples, int internalformat, int width, int height);

			[RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
			[ThreadStatic]
			internal static glRenderbufferStorageMultisampleAPPLE pglRenderbufferStorageMultisampleAPPLE;

			[RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glResolveMultisampleFramebufferAPPLE();

			[RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
			[ThreadStatic]
			internal static glResolveMultisampleFramebufferAPPLE pglResolveMultisampleFramebufferAPPLE;

		}
	}

}
