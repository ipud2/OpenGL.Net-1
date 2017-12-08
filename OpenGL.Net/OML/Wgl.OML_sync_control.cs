
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
	public partial class Wgl
	{
		/// <summary>
		/// [WGL] wglGetSyncValuesOML: Binding for wglGetSyncValuesOML.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="ust">
		/// A <see cref="T:long[]"/>.
		/// </param>
		/// <param name="msc">
		/// A <see cref="T:long[]"/>.
		/// </param>
		/// <param name="sbc">
		/// A <see cref="T:long[]"/>.
		/// </param>
		[RequiredByFeature("WGL_OML_sync_control")]
		public static bool GetSyncValuesOML(IntPtr hdc, [Out] long[] ust, [Out] long[] msc, [Out] long[] sbc)
		{
			bool retValue;

			unsafe {
				fixed (long* p_ust = ust)
				fixed (long* p_msc = msc)
				fixed (long* p_sbc = sbc)
				{
					Debug.Assert(Delegates.pwglGetSyncValuesOML != null, "pwglGetSyncValuesOML not implemented");
					retValue = Delegates.pwglGetSyncValuesOML(hdc, p_ust, p_msc, p_sbc);
					LogCommand("wglGetSyncValuesOML", retValue, hdc, ust, msc, sbc					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglGetMscRateOML: Binding for wglGetMscRateOML.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="numerator">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="denominator">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_OML_sync_control")]
		public static bool GetMscRateOML(IntPtr hdc, [Out] int[] numerator, [Out] int[] denominator)
		{
			bool retValue;

			unsafe {
				fixed (int* p_numerator = numerator)
				fixed (int* p_denominator = denominator)
				{
					Debug.Assert(Delegates.pwglGetMscRateOML != null, "pwglGetMscRateOML not implemented");
					retValue = Delegates.pwglGetMscRateOML(hdc, p_numerator, p_denominator);
					LogCommand("wglGetMscRateOML", retValue, hdc, numerator, denominator					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglSwapBuffersMscOML: Binding for wglSwapBuffersMscOML.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="target_msc">
		/// A <see cref="T:long"/>.
		/// </param>
		/// <param name="divisor">
		/// A <see cref="T:long"/>.
		/// </param>
		/// <param name="remainder">
		/// A <see cref="T:long"/>.
		/// </param>
		[RequiredByFeature("WGL_OML_sync_control")]
		public static long SwapBuffersMscOML(IntPtr hdc, long target_msc, long divisor, long remainder)
		{
			long retValue;

			Debug.Assert(Delegates.pwglSwapBuffersMscOML != null, "pwglSwapBuffersMscOML not implemented");
			retValue = Delegates.pwglSwapBuffersMscOML(hdc, target_msc, divisor, remainder);
			LogCommand("wglSwapBuffersMscOML", retValue, hdc, target_msc, divisor, remainder			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglSwapLayerBuffersMscOML: Binding for wglSwapLayerBuffersMscOML.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="fuPlanes">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="target_msc">
		/// A <see cref="T:long"/>.
		/// </param>
		/// <param name="divisor">
		/// A <see cref="T:long"/>.
		/// </param>
		/// <param name="remainder">
		/// A <see cref="T:long"/>.
		/// </param>
		[RequiredByFeature("WGL_OML_sync_control")]
		public static long SwapLayerBuffersMscOML(IntPtr hdc, int fuPlanes, long target_msc, long divisor, long remainder)
		{
			long retValue;

			Debug.Assert(Delegates.pwglSwapLayerBuffersMscOML != null, "pwglSwapLayerBuffersMscOML not implemented");
			retValue = Delegates.pwglSwapLayerBuffersMscOML(hdc, fuPlanes, target_msc, divisor, remainder);
			LogCommand("wglSwapLayerBuffersMscOML", retValue, hdc, fuPlanes, target_msc, divisor, remainder			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglWaitForMscOML: Binding for wglWaitForMscOML.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="target_msc">
		/// A <see cref="T:long"/>.
		/// </param>
		/// <param name="divisor">
		/// A <see cref="T:long"/>.
		/// </param>
		/// <param name="remainder">
		/// A <see cref="T:long"/>.
		/// </param>
		/// <param name="ust">
		/// A <see cref="T:long[]"/>.
		/// </param>
		/// <param name="msc">
		/// A <see cref="T:long[]"/>.
		/// </param>
		/// <param name="sbc">
		/// A <see cref="T:long[]"/>.
		/// </param>
		[RequiredByFeature("WGL_OML_sync_control")]
		public static bool WaitForMscOML(IntPtr hdc, long target_msc, long divisor, long remainder, long[] ust, long[] msc, long[] sbc)
		{
			bool retValue;

			unsafe {
				fixed (long* p_ust = ust)
				fixed (long* p_msc = msc)
				fixed (long* p_sbc = sbc)
				{
					Debug.Assert(Delegates.pwglWaitForMscOML != null, "pwglWaitForMscOML not implemented");
					retValue = Delegates.pwglWaitForMscOML(hdc, target_msc, divisor, remainder, p_ust, p_msc, p_sbc);
					LogCommand("wglWaitForMscOML", retValue, hdc, target_msc, divisor, remainder, ust, msc, sbc					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglWaitForSbcOML: Binding for wglWaitForSbcOML.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="target_sbc">
		/// A <see cref="T:long"/>.
		/// </param>
		/// <param name="ust">
		/// A <see cref="T:long[]"/>.
		/// </param>
		/// <param name="msc">
		/// A <see cref="T:long[]"/>.
		/// </param>
		/// <param name="sbc">
		/// A <see cref="T:long[]"/>.
		/// </param>
		[RequiredByFeature("WGL_OML_sync_control")]
		public static bool WaitForSbcOML(IntPtr hdc, long target_sbc, long[] ust, long[] msc, long[] sbc)
		{
			bool retValue;

			unsafe {
				fixed (long* p_ust = ust)
				fixed (long* p_msc = msc)
				fixed (long* p_sbc = sbc)
				{
					Debug.Assert(Delegates.pwglWaitForSbcOML != null, "pwglWaitForSbcOML not implemented");
					retValue = Delegates.pwglWaitForSbcOML(hdc, target_sbc, p_ust, p_msc, p_sbc);
					LogCommand("wglWaitForSbcOML", retValue, hdc, target_sbc, ust, msc, sbc					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_OML_sync_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetSyncValuesOML(IntPtr hdc, long* ust, long* msc, long* sbc);

			[RequiredByFeature("WGL_OML_sync_control")]
			internal static wglGetSyncValuesOML pwglGetSyncValuesOML;

			[RequiredByFeature("WGL_OML_sync_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetMscRateOML(IntPtr hdc, int* numerator, int* denominator);

			[RequiredByFeature("WGL_OML_sync_control")]
			internal static wglGetMscRateOML pwglGetMscRateOML;

			[RequiredByFeature("WGL_OML_sync_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate long wglSwapBuffersMscOML(IntPtr hdc, long target_msc, long divisor, long remainder);

			[RequiredByFeature("WGL_OML_sync_control")]
			internal static wglSwapBuffersMscOML pwglSwapBuffersMscOML;

			[RequiredByFeature("WGL_OML_sync_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate long wglSwapLayerBuffersMscOML(IntPtr hdc, int fuPlanes, long target_msc, long divisor, long remainder);

			[RequiredByFeature("WGL_OML_sync_control")]
			internal static wglSwapLayerBuffersMscOML pwglSwapLayerBuffersMscOML;

			[RequiredByFeature("WGL_OML_sync_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglWaitForMscOML(IntPtr hdc, long target_msc, long divisor, long remainder, long* ust, long* msc, long* sbc);

			[RequiredByFeature("WGL_OML_sync_control")]
			internal static wglWaitForMscOML pwglWaitForMscOML;

			[RequiredByFeature("WGL_OML_sync_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglWaitForSbcOML(IntPtr hdc, long target_sbc, long* ust, long* msc, long* sbc);

			[RequiredByFeature("WGL_OML_sync_control")]
			internal static wglWaitForSbcOML pwglWaitForSbcOML;

		}
	}

}
