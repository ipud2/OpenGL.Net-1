
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
		/// [WGL] Value of WGL_GENLOCK_SOURCE_MULTIVIEW_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_genlock")]
		public const int GENLOCK_SOURCE_MULTIVIEW_I3D = 0x2044;

		/// <summary>
		/// [WGL] Value of WGL_GENLOCK_SOURCE_EXTERNAL_SYNC_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_genlock")]
		public const int GENLOCK_SOURCE_EXTERNAL_SYNC_I3D = 0x2045;

		/// <summary>
		/// [WGL] Value of WGL_GENLOCK_SOURCE_EXTERNAL_FIELD_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_genlock")]
		public const int GENLOCK_SOURCE_EXTERNAL_FIELD_I3D = 0x2046;

		/// <summary>
		/// [WGL] Value of WGL_GENLOCK_SOURCE_EXTERNAL_TTL_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_genlock")]
		public const int GENLOCK_SOURCE_EXTERNAL_TTL_I3D = 0x2047;

		/// <summary>
		/// [WGL] Value of WGL_GENLOCK_SOURCE_DIGITAL_SYNC_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_genlock")]
		public const int GENLOCK_SOURCE_DIGITAL_SYNC_I3D = 0x2048;

		/// <summary>
		/// [WGL] Value of WGL_GENLOCK_SOURCE_DIGITAL_FIELD_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_genlock")]
		public const int GENLOCK_SOURCE_DIGITAL_FIELD_I3D = 0x2049;

		/// <summary>
		/// [WGL] Value of WGL_GENLOCK_SOURCE_EDGE_FALLING_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_genlock")]
		public const int GENLOCK_SOURCE_EDGE_FALLING_I3D = 0x204A;

		/// <summary>
		/// [WGL] Value of WGL_GENLOCK_SOURCE_EDGE_RISING_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_genlock")]
		public const int GENLOCK_SOURCE_EDGE_RISING_I3D = 0x204B;

		/// <summary>
		/// [WGL] Value of WGL_GENLOCK_SOURCE_EDGE_BOTH_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_genlock")]
		public const int GENLOCK_SOURCE_EDGE_BOTH_I3D = 0x204C;

		/// <summary>
		/// [WGL] wglEnableGenlockI3D: Binding for wglEnableGenlockI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool EnableGenlockI3D(IntPtr hDC)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglEnableGenlockI3D != null, "pwglEnableGenlockI3D not implemented");
			retValue = Delegates.pwglEnableGenlockI3D(hDC);
			LogCommand("wglEnableGenlockI3D", retValue, hDC			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglDisableGenlockI3D: Binding for wglDisableGenlockI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool DisableGenlockI3D(IntPtr hDC)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDisableGenlockI3D != null, "pwglDisableGenlockI3D not implemented");
			retValue = Delegates.pwglDisableGenlockI3D(hDC);
			LogCommand("wglDisableGenlockI3D", retValue, hDC			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglIsEnabledGenlockI3D: Binding for wglIsEnabledGenlockI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pFlag">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool IsEnabledGenlockI3D(IntPtr hDC, [Out] bool[] pFlag)
		{
			bool retValue;

			unsafe {
				fixed (bool* p_pFlag = pFlag)
				{
					Debug.Assert(Delegates.pwglIsEnabledGenlockI3D != null, "pwglIsEnabledGenlockI3D not implemented");
					retValue = Delegates.pwglIsEnabledGenlockI3D(hDC, p_pFlag);
					LogCommand("wglIsEnabledGenlockI3D", retValue, hDC, pFlag					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglGenlockSourceI3D: Binding for wglGenlockSourceI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uSource">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool GenlockSourceI3D(IntPtr hDC, uint uSource)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglGenlockSourceI3D != null, "pwglGenlockSourceI3D not implemented");
			retValue = Delegates.pwglGenlockSourceI3D(hDC, uSource);
			LogCommand("wglGenlockSourceI3D", retValue, hDC, uSource			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglGetGenlockSourceI3D: Binding for wglGetGenlockSourceI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uSource">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool GetGenlockSourceI3D(IntPtr hDC, [Out] uint[] uSource)
		{
			bool retValue;

			unsafe {
				fixed (uint* p_uSource = uSource)
				{
					Debug.Assert(Delegates.pwglGetGenlockSourceI3D != null, "pwglGetGenlockSourceI3D not implemented");
					retValue = Delegates.pwglGetGenlockSourceI3D(hDC, p_uSource);
					LogCommand("wglGetGenlockSourceI3D", retValue, hDC, uSource					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglGenlockSourceEdgeI3D: Binding for wglGenlockSourceEdgeI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uEdge">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool GenlockSourceEdgeI3D(IntPtr hDC, uint uEdge)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglGenlockSourceEdgeI3D != null, "pwglGenlockSourceEdgeI3D not implemented");
			retValue = Delegates.pwglGenlockSourceEdgeI3D(hDC, uEdge);
			LogCommand("wglGenlockSourceEdgeI3D", retValue, hDC, uEdge			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglGetGenlockSourceEdgeI3D: Binding for wglGetGenlockSourceEdgeI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uEdge">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool GetGenlockSourceEdgeI3D(IntPtr hDC, [Out] uint[] uEdge)
		{
			bool retValue;

			unsafe {
				fixed (uint* p_uEdge = uEdge)
				{
					Debug.Assert(Delegates.pwglGetGenlockSourceEdgeI3D != null, "pwglGetGenlockSourceEdgeI3D not implemented");
					retValue = Delegates.pwglGetGenlockSourceEdgeI3D(hDC, p_uEdge);
					LogCommand("wglGetGenlockSourceEdgeI3D", retValue, hDC, uEdge					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglGenlockSampleRateI3D: Binding for wglGenlockSampleRateI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uRate">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool GenlockSampleRateI3D(IntPtr hDC, uint uRate)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglGenlockSampleRateI3D != null, "pwglGenlockSampleRateI3D not implemented");
			retValue = Delegates.pwglGenlockSampleRateI3D(hDC, uRate);
			LogCommand("wglGenlockSampleRateI3D", retValue, hDC, uRate			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglGetGenlockSampleRateI3D: Binding for wglGetGenlockSampleRateI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uRate">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool GetGenlockSampleRateI3D(IntPtr hDC, [Out] uint[] uRate)
		{
			bool retValue;

			unsafe {
				fixed (uint* p_uRate = uRate)
				{
					Debug.Assert(Delegates.pwglGetGenlockSampleRateI3D != null, "pwglGetGenlockSampleRateI3D not implemented");
					retValue = Delegates.pwglGetGenlockSampleRateI3D(hDC, p_uRate);
					LogCommand("wglGetGenlockSampleRateI3D", retValue, hDC, uRate					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglGenlockSourceDelayI3D: Binding for wglGenlockSourceDelayI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uDelay">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool GenlockSourceDelayI3D(IntPtr hDC, uint uDelay)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglGenlockSourceDelayI3D != null, "pwglGenlockSourceDelayI3D not implemented");
			retValue = Delegates.pwglGenlockSourceDelayI3D(hDC, uDelay);
			LogCommand("wglGenlockSourceDelayI3D", retValue, hDC, uDelay			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglGetGenlockSourceDelayI3D: Binding for wglGetGenlockSourceDelayI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uDelay">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool GetGenlockSourceDelayI3D(IntPtr hDC, [Out] uint[] uDelay)
		{
			bool retValue;

			unsafe {
				fixed (uint* p_uDelay = uDelay)
				{
					Debug.Assert(Delegates.pwglGetGenlockSourceDelayI3D != null, "pwglGetGenlockSourceDelayI3D not implemented");
					retValue = Delegates.pwglGetGenlockSourceDelayI3D(hDC, p_uDelay);
					LogCommand("wglGetGenlockSourceDelayI3D", retValue, hDC, uDelay					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglQueryGenlockMaxSourceDelayI3D: Binding for wglQueryGenlockMaxSourceDelayI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="uMaxLineDelay">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="uMaxPixelDelay">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_genlock")]
		public static bool QueryGenlockMaxSourceDelayI3D(IntPtr hDC, uint[] uMaxLineDelay, uint[] uMaxPixelDelay)
		{
			bool retValue;

			unsafe {
				fixed (uint* p_uMaxLineDelay = uMaxLineDelay)
				fixed (uint* p_uMaxPixelDelay = uMaxPixelDelay)
				{
					Debug.Assert(Delegates.pwglQueryGenlockMaxSourceDelayI3D != null, "pwglQueryGenlockMaxSourceDelayI3D not implemented");
					retValue = Delegates.pwglQueryGenlockMaxSourceDelayI3D(hDC, p_uMaxLineDelay, p_uMaxPixelDelay);
					LogCommand("wglQueryGenlockMaxSourceDelayI3D", retValue, hDC, uMaxLineDelay, uMaxPixelDelay					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_I3D_genlock")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglEnableGenlockI3D(IntPtr hDC);

			[RequiredByFeature("WGL_I3D_genlock")]
			internal static wglEnableGenlockI3D pwglEnableGenlockI3D;

			[RequiredByFeature("WGL_I3D_genlock")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDisableGenlockI3D(IntPtr hDC);

			[RequiredByFeature("WGL_I3D_genlock")]
			internal static wglDisableGenlockI3D pwglDisableGenlockI3D;

			[RequiredByFeature("WGL_I3D_genlock")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglIsEnabledGenlockI3D(IntPtr hDC, bool* pFlag);

			[RequiredByFeature("WGL_I3D_genlock")]
			internal static wglIsEnabledGenlockI3D pwglIsEnabledGenlockI3D;

			[RequiredByFeature("WGL_I3D_genlock")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGenlockSourceI3D(IntPtr hDC, uint uSource);

			[RequiredByFeature("WGL_I3D_genlock")]
			internal static wglGenlockSourceI3D pwglGenlockSourceI3D;

			[RequiredByFeature("WGL_I3D_genlock")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetGenlockSourceI3D(IntPtr hDC, uint* uSource);

			[RequiredByFeature("WGL_I3D_genlock")]
			internal static wglGetGenlockSourceI3D pwglGetGenlockSourceI3D;

			[RequiredByFeature("WGL_I3D_genlock")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGenlockSourceEdgeI3D(IntPtr hDC, uint uEdge);

			[RequiredByFeature("WGL_I3D_genlock")]
			internal static wglGenlockSourceEdgeI3D pwglGenlockSourceEdgeI3D;

			[RequiredByFeature("WGL_I3D_genlock")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetGenlockSourceEdgeI3D(IntPtr hDC, uint* uEdge);

			[RequiredByFeature("WGL_I3D_genlock")]
			internal static wglGetGenlockSourceEdgeI3D pwglGetGenlockSourceEdgeI3D;

			[RequiredByFeature("WGL_I3D_genlock")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGenlockSampleRateI3D(IntPtr hDC, uint uRate);

			[RequiredByFeature("WGL_I3D_genlock")]
			internal static wglGenlockSampleRateI3D pwglGenlockSampleRateI3D;

			[RequiredByFeature("WGL_I3D_genlock")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetGenlockSampleRateI3D(IntPtr hDC, uint* uRate);

			[RequiredByFeature("WGL_I3D_genlock")]
			internal static wglGetGenlockSampleRateI3D pwglGetGenlockSampleRateI3D;

			[RequiredByFeature("WGL_I3D_genlock")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGenlockSourceDelayI3D(IntPtr hDC, uint uDelay);

			[RequiredByFeature("WGL_I3D_genlock")]
			internal static wglGenlockSourceDelayI3D pwglGenlockSourceDelayI3D;

			[RequiredByFeature("WGL_I3D_genlock")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetGenlockSourceDelayI3D(IntPtr hDC, uint* uDelay);

			[RequiredByFeature("WGL_I3D_genlock")]
			internal static wglGetGenlockSourceDelayI3D pwglGetGenlockSourceDelayI3D;

			[RequiredByFeature("WGL_I3D_genlock")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglQueryGenlockMaxSourceDelayI3D(IntPtr hDC, uint* uMaxLineDelay, uint* uMaxPixelDelay);

			[RequiredByFeature("WGL_I3D_genlock")]
			internal static wglQueryGenlockMaxSourceDelayI3D pwglQueryGenlockMaxSourceDelayI3D;

		}
	}

}
