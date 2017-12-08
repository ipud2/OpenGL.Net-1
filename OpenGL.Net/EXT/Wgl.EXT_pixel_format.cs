
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
		/// [WGL] Value of WGL_TRANSPARENT_VALUE_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int TRANSPARENT_VALUE_EXT = 0x200B;

		/// <summary>
		/// [WGL] wglGetPixelFormatAttribivEXT: Binding for wglGetPixelFormatAttribivEXT.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iPixelFormat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="iLayerPlane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="nAttributes">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="piAttributes">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="piValues">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public static bool GetPixelFormatAttribEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, [Out] int[] piAttributes, [Out] int[] piValues)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piAttributes = piAttributes)
				fixed (int* p_piValues = piValues)
				{
					Debug.Assert(Delegates.pwglGetPixelFormatAttribivEXT != null, "pwglGetPixelFormatAttribivEXT not implemented");
					retValue = Delegates.pwglGetPixelFormatAttribivEXT(hdc, iPixelFormat, iLayerPlane, nAttributes, p_piAttributes, p_piValues);
					LogCommand("wglGetPixelFormatAttribivEXT", retValue, hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, piValues					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglGetPixelFormatAttribfvEXT: Binding for wglGetPixelFormatAttribfvEXT.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iPixelFormat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="iLayerPlane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="nAttributes">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="piAttributes">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="pfValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public static bool GetPixelFormatAttribEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, [Out] int[] piAttributes, [Out] float[] pfValues)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piAttributes = piAttributes)
				fixed (float* p_pfValues = pfValues)
				{
					Debug.Assert(Delegates.pwglGetPixelFormatAttribfvEXT != null, "pwglGetPixelFormatAttribfvEXT not implemented");
					retValue = Delegates.pwglGetPixelFormatAttribfvEXT(hdc, iPixelFormat, iLayerPlane, nAttributes, p_piAttributes, p_pfValues);
					LogCommand("wglGetPixelFormatAttribfvEXT", retValue, hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, pfValues					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglChoosePixelFormatEXT: Binding for wglChoosePixelFormatEXT.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="piAttribIList">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="pfAttribFList">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="nMaxFormats">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="piFormats">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="nNumFormats">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public static bool ChoosePixelFormatEXT(IntPtr hdc, int[] piAttribIList, float[] pfAttribFList, uint nMaxFormats, int[] piFormats, uint[] nNumFormats)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piAttribIList = piAttribIList)
				fixed (float* p_pfAttribFList = pfAttribFList)
				fixed (int* p_piFormats = piFormats)
				fixed (uint* p_nNumFormats = nNumFormats)
				{
					Debug.Assert(Delegates.pwglChoosePixelFormatEXT != null, "pwglChoosePixelFormatEXT not implemented");
					retValue = Delegates.pwglChoosePixelFormatEXT(hdc, p_piAttribIList, p_pfAttribFList, nMaxFormats, p_piFormats, p_nNumFormats);
					LogCommand("wglChoosePixelFormatEXT", retValue, hdc, piAttribIList, pfAttribFList, nMaxFormats, piFormats, nNumFormats					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_EXT_pixel_format")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int* piAttributes, int* piValues);

			[RequiredByFeature("WGL_EXT_pixel_format")]
			internal static wglGetPixelFormatAttribivEXT pwglGetPixelFormatAttribivEXT;

			[RequiredByFeature("WGL_EXT_pixel_format")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int* piAttributes, float* pfValues);

			[RequiredByFeature("WGL_EXT_pixel_format")]
			internal static wglGetPixelFormatAttribfvEXT pwglGetPixelFormatAttribfvEXT;

			[RequiredByFeature("WGL_EXT_pixel_format")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglChoosePixelFormatEXT(IntPtr hdc, int* piAttribIList, float* pfAttribFList, uint nMaxFormats, int* piFormats, uint* nNumFormats);

			[RequiredByFeature("WGL_EXT_pixel_format")]
			internal static wglChoosePixelFormatEXT pwglChoosePixelFormatEXT;

		}
	}

}
