
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
		/// [GL] Value of GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_FAST_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_pixel_local_storage2", Api = "gles2")]
		public const int MAX_SHADER_COMBINED_LOCAL_STORAGE_FAST_SIZE_EXT = 0x9650;

		/// <summary>
		/// [GL] Value of GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_pixel_local_storage2", Api = "gles2")]
		public const int MAX_SHADER_COMBINED_LOCAL_STORAGE_SIZE_EXT = 0x9651;

		/// <summary>
		/// [GL] Value of GL_FRAMEBUFFER_INCOMPLETE_INSUFFICIENT_SHADER_COMBINED_LOCAL_STORAGE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_pixel_local_storage2", Api = "gles2")]
		public const int FRAMEBUFFER_INCOMPLETE_INSUFFICIENT_SHADER_COMBINED_LOCAL_STORAGE_EXT = 0x9652;

		/// <summary>
		/// [GL] glFramebufferPixelLocalStorageSizeEXT: Binding for glFramebufferPixelLocalStorageSizeEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_shader_pixel_local_storage2", Api = "gles2")]
		public static void FramebufferPixelLocalStorageSizeEXT(uint target, int size)
		{
			Debug.Assert(Delegates.pglFramebufferPixelLocalStorageSizeEXT != null, "pglFramebufferPixelLocalStorageSizeEXT not implemented");
			Delegates.pglFramebufferPixelLocalStorageSizeEXT(target, size);
			LogCommand("glFramebufferPixelLocalStorageSizeEXT", null, target, size			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetFramebufferPixelLocalStorageSizeEXT: Binding for glGetFramebufferPixelLocalStorageSizeEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_shader_pixel_local_storage2", Api = "gles2")]
		public static int GetFramebufferPixelLocalStorageSizeEXT(FramebufferTarget target)
		{
			int retValue;

			Debug.Assert(Delegates.pglGetFramebufferPixelLocalStorageSizeEXT != null, "pglGetFramebufferPixelLocalStorageSizeEXT not implemented");
			retValue = Delegates.pglGetFramebufferPixelLocalStorageSizeEXT((uint)target);
			LogCommand("glGetFramebufferPixelLocalStorageSizeEXT", retValue, target			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glClearPixelLocalStorageuiEXT: Binding for glClearPixelLocalStorageuiEXT.
		/// </summary>
		/// <param name="offset">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_shader_pixel_local_storage2", Api = "gles2")]
		public static void ClearPixelLocalStorageEXT(int offset, uint[] values)
		{
			unsafe {
				fixed (uint* p_values = values)
				{
					Debug.Assert(Delegates.pglClearPixelLocalStorageuiEXT != null, "pglClearPixelLocalStorageuiEXT not implemented");
					Delegates.pglClearPixelLocalStorageuiEXT(offset, values.Length, p_values);
					LogCommand("glClearPixelLocalStorageuiEXT", null, offset, values.Length, values					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_shader_pixel_local_storage2", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferPixelLocalStorageSizeEXT(uint target, int size);

			[RequiredByFeature("GL_EXT_shader_pixel_local_storage2", Api = "gles2")]
			[ThreadStatic]
			internal static glFramebufferPixelLocalStorageSizeEXT pglFramebufferPixelLocalStorageSizeEXT;

			[RequiredByFeature("GL_EXT_shader_pixel_local_storage2", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate int glGetFramebufferPixelLocalStorageSizeEXT(uint target);

			[RequiredByFeature("GL_EXT_shader_pixel_local_storage2", Api = "gles2")]
			[ThreadStatic]
			internal static glGetFramebufferPixelLocalStorageSizeEXT pglGetFramebufferPixelLocalStorageSizeEXT;

			[RequiredByFeature("GL_EXT_shader_pixel_local_storage2", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearPixelLocalStorageuiEXT(int offset, int n, uint* values);

			[RequiredByFeature("GL_EXT_shader_pixel_local_storage2", Api = "gles2")]
			[ThreadStatic]
			internal static glClearPixelLocalStorageuiEXT pglClearPixelLocalStorageuiEXT;

		}
	}

}
