
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
		/// [EGL] Value of EGL_DEFAULT_DISPLAY symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_4")]
		public const int DEFAULT_DISPLAY = 0;

		/// <summary>
		/// [EGL] Value of EGL_MULTISAMPLE_RESOLVE_BOX_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_4")]
		[Log(BitmaskName = "EGLSurfaceTypeMask")]
		public const int MULTISAMPLE_RESOLVE_BOX_BIT = 0x0200;

		/// <summary>
		/// <para>
		/// [EGL] Egl.QuerySurface: Returns the filter used when resolving the multisample buffer. The filter may be either 
		/// Egl.MULTISAMPLE_RESOLVE_DEFAULT or Egl.MULTISAMPLE_RESOLVE_BOX, as described for Egl.SurfaceAttrib.
		/// </para>
		/// <para>
		/// [EGL] Egl.SurfaceAttrib: Specifies the filter to use when resolving the multisample buffer (this may occur when swapping 
		/// or copying the surface, or when changing the client API context bound to the surface). A value of 
		/// Egl.MULTISAMPLE_RESOLVE_DEFAULT chooses the default implementation-defined filtering method, while 
		/// Egl.MULTISAMPLE_RESOLVE_BOX chooses a one-pixel wide box filter placing equal weighting on all multisample values. The 
		/// initial value of Egl.MULTISAMPLE_RESOLVE is Egl.MULTISAMPLE_RESOLVE_DEFAULT.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_4")]
		public const int MULTISAMPLE_RESOLVE = 0x3099;

		/// <summary>
		/// [EGL] Value of EGL_MULTISAMPLE_RESOLVE_DEFAULT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_4")]
		public const int MULTISAMPLE_RESOLVE_DEFAULT = 0x309A;

		/// <summary>
		/// [EGL] Value of EGL_MULTISAMPLE_RESOLVE_BOX symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_4")]
		public const int MULTISAMPLE_RESOLVE_BOX = 0x309B;

		/// <summary>
		/// [EGL] Value of EGL_OPENGL_API symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_4")]
		public const int OPENGL_API = 0x30A2;

		/// <summary>
		/// [EGL] Value of EGL_OPENGL_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_4")]
		[Log(BitmaskName = "EGLRenderableTypeMask")]
		public const int OPENGL_BIT = 0x0008;

		/// <summary>
		/// [EGL] Value of EGL_SWAP_BEHAVIOR_PRESERVED_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_4")]
		[Log(BitmaskName = "EGLSurfaceTypeMask")]
		public const int SWAP_BEHAVIOR_PRESERVED_BIT = 0x0400;

		/// <summary>
		/// [EGL] eglGetCurrentContext: return the current EGL rendering context
		/// </summary>
		/// <seealso cref="Egl.CreateContext"/>
		/// <seealso cref="Egl.MakeCurrent"/>
		[RequiredByFeature("EGL_VERSION_1_4")]
		public static IntPtr GetCurrentContext()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglGetCurrentContext != null, "peglGetCurrentContext not implemented");
			retValue = Delegates.peglGetCurrentContext();
			LogCommand("eglGetCurrentContext", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglGetCurrentContext", ExactSpelling = true)]
			internal extern static IntPtr eglGetCurrentContext();

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_VERSION_1_4")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate IntPtr eglGetCurrentContext();

			[RequiredByFeature("EGL_VERSION_1_4")]
			internal static eglGetCurrentContext peglGetCurrentContext;

		}
	}

}
