
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
		/// [GL] Value of GL_SYNC_X11_FENCE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_x11_sync_object")]
		public const int SYNC_X11_FENCE_EXT = 0x90E1;

		/// <summary>
		/// [GL] glImportSyncEXT: Binding for glImportSyncEXT.
		/// </summary>
		/// <param name="external_sync_type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="external_sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_x11_sync_object")]
		public static Int32 ImportSyncEXT(Int32 external_sync_type, IntPtr external_sync, UInt32 flags)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglImportSyncEXT != null, "pglImportSyncEXT not implemented");
			retValue = Delegates.pglImportSyncEXT(external_sync_type, external_sync, flags);
			LogCommand("glImportSyncEXT", retValue, external_sync_type, external_sync, flags			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glImportSyncEXT", ExactSpelling = true)]
			internal extern static unsafe Int32 glImportSyncEXT(Int32 external_sync_type, IntPtr external_sync, UInt32 flags);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_x11_sync_object")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate Int32 glImportSyncEXT(Int32 external_sync_type, IntPtr external_sync, UInt32 flags);

			[RequiredByFeature("GL_EXT_x11_sync_object")]
			[ThreadStatic]
			internal static glImportSyncEXT pglImportSyncEXT;

		}
	}

}
