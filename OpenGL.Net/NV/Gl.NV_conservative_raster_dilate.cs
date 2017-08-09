
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
		/// [GL] Value of GL_CONSERVATIVE_RASTER_DILATE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster_dilate", Api = "gl|glcore")]
		public const int CONSERVATIVE_RASTER_DILATE_NV = 0x9379;

		/// <summary>
		/// [GL] Value of GL_CONSERVATIVE_RASTER_DILATE_RANGE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster_dilate", Api = "gl|glcore")]
		public const int CONSERVATIVE_RASTER_DILATE_RANGE_NV = 0x937A;

		/// <summary>
		/// [GL] Value of GL_CONSERVATIVE_RASTER_DILATE_GRANULARITY_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster_dilate", Api = "gl|glcore")]
		public const int CONSERVATIVE_RASTER_DILATE_GRANULARITY_NV = 0x937B;

		/// <summary>
		/// [GL] glConservativeRasterParameterfNV: Binding for glConservativeRasterParameterfNV.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_conservative_raster_dilate", Api = "gl|glcore")]
		public static void ConservativeRasterParameterfNV(Int32 pname, float value)
		{
			Debug.Assert(Delegates.pglConservativeRasterParameterfNV != null, "pglConservativeRasterParameterfNV not implemented");
			Delegates.pglConservativeRasterParameterfNV(pname, value);
			LogCommand("glConservativeRasterParameterfNV", null, pname, value			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glConservativeRasterParameterfNV", ExactSpelling = true)]
			internal extern static void glConservativeRasterParameterfNV(Int32 pname, float value);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_conservative_raster_dilate", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glConservativeRasterParameterfNV(Int32 pname, float value);

			[RequiredByFeature("GL_NV_conservative_raster_dilate", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glConservativeRasterParameterfNV pglConservativeRasterParameterfNV;

		}
	}

}
