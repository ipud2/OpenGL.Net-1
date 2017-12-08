
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
		/// [GL] Value of GL_MAX_GEOMETRY_PROGRAM_INVOCATIONS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_program5")]
		public const int MAX_GEOMETRY_PROGRAM_INVOCATIONS_NV = 0x8E5A;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_PROGRAM_INTERPOLATION_OFFSET_BITS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_program5")]
		public const int FRAGMENT_PROGRAM_INTERPOLATION_OFFSET_BITS_NV = 0x8E5D;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_SUBROUTINE_PARAMETERS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_program5")]
		public const int MAX_PROGRAM_SUBROUTINE_PARAMETERS_NV = 0x8F44;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_SUBROUTINE_NUM_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_program5")]
		public const int MAX_PROGRAM_SUBROUTINE_NUM_NV = 0x8F45;

		/// <summary>
		/// [GL] glProgramSubroutineParametersuivNV: Binding for glProgramSubroutineParametersuivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program5")]
		public static void ProgramSubroutineParametersNV(int target, uint[] @params)
		{
			unsafe {
				fixed (uint* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramSubroutineParametersuivNV != null, "pglProgramSubroutineParametersuivNV not implemented");
					Delegates.pglProgramSubroutineParametersuivNV(target, @params.Length, p_params);
					LogCommand("glProgramSubroutineParametersuivNV", null, target, @params.Length, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetProgramSubroutineParameteruivNV: Binding for glGetProgramSubroutineParameteruivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program5")]
		public static void GetProgramSubroutineParameterNV(int target, uint index, [Out] uint[] param)
		{
			unsafe {
				fixed (uint* p_param = param)
				{
					Debug.Assert(Delegates.pglGetProgramSubroutineParameteruivNV != null, "pglGetProgramSubroutineParameteruivNV not implemented");
					Delegates.pglGetProgramSubroutineParameteruivNV(target, index, p_param);
					LogCommand("glGetProgramSubroutineParameteruivNV", null, target, index, param					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_gpu_program5")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramSubroutineParametersuivNV(int target, int count, uint* @params);

			[RequiredByFeature("GL_NV_gpu_program5")]
			[ThreadStatic]
			internal static glProgramSubroutineParametersuivNV pglProgramSubroutineParametersuivNV;

			[RequiredByFeature("GL_NV_gpu_program5")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramSubroutineParameteruivNV(int target, uint index, uint* param);

			[RequiredByFeature("GL_NV_gpu_program5")]
			[ThreadStatic]
			internal static glGetProgramSubroutineParameteruivNV pglGetProgramSubroutineParameteruivNV;

		}
	}

}
