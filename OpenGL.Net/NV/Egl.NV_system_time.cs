
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
		/// [EGL] eglGetSystemTimeFrequencyNV: Binding for eglGetSystemTimeFrequencyNV.
		/// </summary>
		[RequiredByFeature("EGL_NV_system_time")]
		public static UInt64 GetSystemTimeFrequencyNV()
		{
			UInt64 retValue;

			Debug.Assert(Delegates.peglGetSystemTimeFrequencyNV != null, "peglGetSystemTimeFrequencyNV not implemented");
			retValue = Delegates.peglGetSystemTimeFrequencyNV();
			LogCommand("eglGetSystemTimeFrequencyNV", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglGetSystemTimeNV: Binding for eglGetSystemTimeNV.
		/// </summary>
		[RequiredByFeature("EGL_NV_system_time")]
		public static UInt64 GetSystemTimeNV()
		{
			UInt64 retValue;

			Debug.Assert(Delegates.peglGetSystemTimeNV != null, "peglGetSystemTimeNV not implemented");
			retValue = Delegates.peglGetSystemTimeNV();
			LogCommand("eglGetSystemTimeNV", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglGetSystemTimeFrequencyNV", ExactSpelling = true)]
			internal extern static UInt64 eglGetSystemTimeFrequencyNV();

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglGetSystemTimeNV", ExactSpelling = true)]
			internal extern static UInt64 eglGetSystemTimeNV();

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_NV_system_time")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate UInt64 eglGetSystemTimeFrequencyNV();

			[RequiredByFeature("EGL_NV_system_time")]
			internal static eglGetSystemTimeFrequencyNV peglGetSystemTimeFrequencyNV;

			[RequiredByFeature("EGL_NV_system_time")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate UInt64 eglGetSystemTimeNV();

			[RequiredByFeature("EGL_NV_system_time")]
			internal static eglGetSystemTimeNV peglGetSystemTimeNV;

		}
	}

}
