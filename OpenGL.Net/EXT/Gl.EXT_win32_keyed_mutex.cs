
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
		/// [GL] glAcquireKeyedMutexWin32EXT: Binding for glAcquireKeyedMutexWin32EXT.
		/// </summary>
		/// <param name="memory">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="key">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="timeout">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_win32_keyed_mutex", Api = "gl|gles2")]
		public static bool AcquireKeyedMutexWin32EXT(UInt32 memory, UInt64 key, UInt32 timeout)
		{
			bool retValue;

			Debug.Assert(Delegates.pglAcquireKeyedMutexWin32EXT != null, "pglAcquireKeyedMutexWin32EXT not implemented");
			retValue = Delegates.pglAcquireKeyedMutexWin32EXT(memory, key, timeout);
			LogCommand("glAcquireKeyedMutexWin32EXT", retValue, memory, key, timeout			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glReleaseKeyedMutexWin32EXT: Binding for glReleaseKeyedMutexWin32EXT.
		/// </summary>
		/// <param name="memory">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="key">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_win32_keyed_mutex", Api = "gl|gles2")]
		public static bool ReleaseKeyedEXT(UInt32 memory, UInt64 key)
		{
			bool retValue;

			Debug.Assert(Delegates.pglReleaseKeyedMutexWin32EXT != null, "pglReleaseKeyedMutexWin32EXT not implemented");
			retValue = Delegates.pglReleaseKeyedMutexWin32EXT(memory, key);
			LogCommand("glReleaseKeyedMutexWin32EXT", retValue, memory, key			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glAcquireKeyedMutexWin32EXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.U1)]
			internal extern static bool glAcquireKeyedMutexWin32EXT(UInt32 memory, UInt64 key, UInt32 timeout);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glReleaseKeyedMutexWin32EXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.U1)]
			internal extern static bool glReleaseKeyedMutexWin32EXT(UInt32 memory, UInt64 key);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_win32_keyed_mutex", Api = "gl|gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate bool glAcquireKeyedMutexWin32EXT(UInt32 memory, UInt64 key, UInt32 timeout);

			[RequiredByFeature("GL_EXT_win32_keyed_mutex", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glAcquireKeyedMutexWin32EXT pglAcquireKeyedMutexWin32EXT;

			[RequiredByFeature("GL_EXT_win32_keyed_mutex", Api = "gl|gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate bool glReleaseKeyedMutexWin32EXT(UInt32 memory, UInt64 key);

			[RequiredByFeature("GL_EXT_win32_keyed_mutex", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glReleaseKeyedMutexWin32EXT pglReleaseKeyedMutexWin32EXT;

		}
	}

}
