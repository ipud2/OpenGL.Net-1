
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
	public partial class Wgl
	{
		/// <summary>
		/// [WGL] wglJoinSwapGroupNV: Binding for wglJoinSwapGroupNV.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="group">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_swap_group")]
		public static bool JoinSwapGroupNV(IntPtr hDC, UInt32 group)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglJoinSwapGroupNV != null, "pwglJoinSwapGroupNV not implemented");
			retValue = Delegates.pwglJoinSwapGroupNV(hDC, group);
			LogCommand("wglJoinSwapGroupNV", retValue, hDC, group			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglBindSwapBarrierNV: Binding for wglBindSwapBarrierNV.
		/// </summary>
		/// <param name="group">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="barrier">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_swap_group")]
		public static bool BindSwapBarrierNV(UInt32 group, UInt32 barrier)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglBindSwapBarrierNV != null, "pwglBindSwapBarrierNV not implemented");
			retValue = Delegates.pwglBindSwapBarrierNV(group, barrier);
			LogCommand("wglBindSwapBarrierNV", retValue, group, barrier			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglQuerySwapGroupNV: Binding for wglQuerySwapGroupNV.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="group">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="barrier">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_swap_group")]
		public static bool QuerySwapGroupNV(IntPtr hDC, UInt32[] group, UInt32[] barrier)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_group = group)
				fixed (UInt32* p_barrier = barrier)
				{
					Debug.Assert(Delegates.pwglQuerySwapGroupNV != null, "pwglQuerySwapGroupNV not implemented");
					retValue = Delegates.pwglQuerySwapGroupNV(hDC, p_group, p_barrier);
					LogCommand("wglQuerySwapGroupNV", retValue, hDC, group, barrier					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglQueryMaxSwapGroupsNV: Binding for wglQueryMaxSwapGroupsNV.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="maxGroups">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="maxBarriers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_swap_group")]
		public static bool QueryMaxSwapGroupsNV(IntPtr hDC, UInt32[] maxGroups, UInt32[] maxBarriers)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_maxGroups = maxGroups)
				fixed (UInt32* p_maxBarriers = maxBarriers)
				{
					Debug.Assert(Delegates.pwglQueryMaxSwapGroupsNV != null, "pwglQueryMaxSwapGroupsNV not implemented");
					retValue = Delegates.pwglQueryMaxSwapGroupsNV(hDC, p_maxGroups, p_maxBarriers);
					LogCommand("wglQueryMaxSwapGroupsNV", retValue, hDC, maxGroups, maxBarriers					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglQueryFrameCountNV: Binding for wglQueryFrameCountNV.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_swap_group")]
		public static bool QueryFrameCountNV(IntPtr hDC, UInt32[] count)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_count = count)
				{
					Debug.Assert(Delegates.pwglQueryFrameCountNV != null, "pwglQueryFrameCountNV not implemented");
					retValue = Delegates.pwglQueryFrameCountNV(hDC, p_count);
					LogCommand("wglQueryFrameCountNV", retValue, hDC, count					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglResetFrameCountNV: Binding for wglResetFrameCountNV.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_swap_group")]
		public static bool ResetFrameCountNV(IntPtr hDC)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglResetFrameCountNV != null, "pwglResetFrameCountNV not implemented");
			retValue = Delegates.pwglResetFrameCountNV(hDC);
			LogCommand("wglResetFrameCountNV", retValue, hDC			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglJoinSwapGroupNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglJoinSwapGroupNV(IntPtr hDC, UInt32 group);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglBindSwapBarrierNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static bool wglBindSwapBarrierNV(UInt32 group, UInt32 barrier);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglQuerySwapGroupNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQuerySwapGroupNV(IntPtr hDC, UInt32* group, UInt32* barrier);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglQueryMaxSwapGroupsNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQueryMaxSwapGroupsNV(IntPtr hDC, UInt32* maxGroups, UInt32* maxBarriers);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglQueryFrameCountNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQueryFrameCountNV(IntPtr hDC, UInt32* count);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglResetFrameCountNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglResetFrameCountNV(IntPtr hDC);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_NV_swap_group")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglJoinSwapGroupNV(IntPtr hDC, UInt32 group);

			[RequiredByFeature("WGL_NV_swap_group")]
			[ThreadStatic]
			internal static wglJoinSwapGroupNV pwglJoinSwapGroupNV;

			[RequiredByFeature("WGL_NV_swap_group")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate bool wglBindSwapBarrierNV(UInt32 group, UInt32 barrier);

			[RequiredByFeature("WGL_NV_swap_group")]
			[ThreadStatic]
			internal static wglBindSwapBarrierNV pwglBindSwapBarrierNV;

			[RequiredByFeature("WGL_NV_swap_group")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglQuerySwapGroupNV(IntPtr hDC, UInt32* group, UInt32* barrier);

			[RequiredByFeature("WGL_NV_swap_group")]
			[ThreadStatic]
			internal static wglQuerySwapGroupNV pwglQuerySwapGroupNV;

			[RequiredByFeature("WGL_NV_swap_group")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglQueryMaxSwapGroupsNV(IntPtr hDC, UInt32* maxGroups, UInt32* maxBarriers);

			[RequiredByFeature("WGL_NV_swap_group")]
			[ThreadStatic]
			internal static wglQueryMaxSwapGroupsNV pwglQueryMaxSwapGroupsNV;

			[RequiredByFeature("WGL_NV_swap_group")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglQueryFrameCountNV(IntPtr hDC, UInt32* count);

			[RequiredByFeature("WGL_NV_swap_group")]
			[ThreadStatic]
			internal static wglQueryFrameCountNV pwglQueryFrameCountNV;

			[RequiredByFeature("WGL_NV_swap_group")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglResetFrameCountNV(IntPtr hDC);

			[RequiredByFeature("WGL_NV_swap_group")]
			[ThreadStatic]
			internal static wglResetFrameCountNV pwglResetFrameCountNV;

		}
	}

}
