
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
		/// [GL] Value of GL_HANDLE_TYPE_OPAQUE_WIN32_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		public const int HANDLE_TYPE_OPAQUE_WIN32_EXT = 0x9587;

		/// <summary>
		/// [GL] Value of GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		public const int HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT = 0x9588;

		/// <summary>
		/// [GL] Value of GL_DEVICE_LUID_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		public const int DEVICE_LUID_EXT = 0x9599;

		/// <summary>
		/// [GL] Value of GL_DEVICE_NODE_MASK_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		public const int DEVICE_NODE_MASK_EXT = 0x959A;

		/// <summary>
		/// [GL] Value of GL_LUID_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		public const int LUID_SIZE_EXT = 8;

		/// <summary>
		/// [GL] Value of GL_HANDLE_TYPE_D3D12_FENCE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		public const int HANDLE_TYPE_D3D12_FENCE_EXT = 0x9594;

		/// <summary>
		/// [GL] Value of GL_D3D12_FENCE_VALUE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		public const int D3D12_FENCE_VALUE_EXT = 0x9595;

		/// <summary>
		/// [GL] glImportSemaphoreWin32HandleEXT: Binding for glImportSemaphoreWin32HandleEXT.
		/// </summary>
		/// <param name="semaphore">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="handleType">
		/// A <see cref="T:ExternalHandleType"/>.
		/// </param>
		/// <param name="handle">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		public static void ImportSemaphoreWin32HandleEXT(UInt32 semaphore, ExternalHandleType handleType, IntPtr handle)
		{
			Debug.Assert(Delegates.pglImportSemaphoreWin32HandleEXT != null, "pglImportSemaphoreWin32HandleEXT not implemented");
			Delegates.pglImportSemaphoreWin32HandleEXT(semaphore, (Int32)handleType, handle);
			LogCommand("glImportSemaphoreWin32HandleEXT", null, semaphore, handleType, handle			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glImportSemaphoreWin32NameEXT: Binding for glImportSemaphoreWin32NameEXT.
		/// </summary>
		/// <param name="semaphore">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="handleType">
		/// A <see cref="T:ExternalHandleType"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		public static void ImportSemaphoreWin32NameEXT(UInt32 semaphore, ExternalHandleType handleType, IntPtr name)
		{
			Debug.Assert(Delegates.pglImportSemaphoreWin32NameEXT != null, "pglImportSemaphoreWin32NameEXT not implemented");
			Delegates.pglImportSemaphoreWin32NameEXT(semaphore, (Int32)handleType, name);
			LogCommand("glImportSemaphoreWin32NameEXT", null, semaphore, handleType, name			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glImportSemaphoreWin32NameEXT: Binding for glImportSemaphoreWin32NameEXT.
		/// </summary>
		/// <param name="semaphore">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="handleType">
		/// A <see cref="T:ExternalHandleType"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		public static void ImportSemaphoreWin32NameEXT(UInt32 semaphore, ExternalHandleType handleType, Object name)
		{
			GCHandle pin_name = GCHandle.Alloc(name, GCHandleType.Pinned);
			try {
				ImportSemaphoreWin32NameEXT(semaphore, handleType, pin_name.AddrOfPinnedObject());
			} finally {
				pin_name.Free();
			}
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glImportSemaphoreWin32HandleEXT", ExactSpelling = true)]
			internal extern static unsafe void glImportSemaphoreWin32HandleEXT(UInt32 semaphore, Int32 handleType, IntPtr handle);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glImportSemaphoreWin32NameEXT", ExactSpelling = true)]
			internal extern static unsafe void glImportSemaphoreWin32NameEXT(UInt32 semaphore, Int32 handleType, IntPtr name);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glImportSemaphoreWin32HandleEXT(UInt32 semaphore, Int32 handleType, IntPtr handle);

			[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glImportSemaphoreWin32HandleEXT pglImportSemaphoreWin32HandleEXT;

			[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glImportSemaphoreWin32NameEXT(UInt32 semaphore, Int32 handleType, IntPtr name);

			[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glImportSemaphoreWin32NameEXT pglImportSemaphoreWin32NameEXT;

		}
	}

}
