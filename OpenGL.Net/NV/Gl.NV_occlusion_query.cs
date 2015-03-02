
// Copyright (C) 2015 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_PIXEL_COUNTER_BITS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_occlusion_query")]
		public const int PIXEL_COUNTER_BITS_NV = 0x8864;

		/// <summary>
		/// Value of GL_CURRENT_OCCLUSION_QUERY_ID_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_occlusion_query")]
		public const int CURRENT_OCCLUSION_QUERY_ID_NV = 0x8865;

		/// <summary>
		/// Value of GL_PIXEL_COUNT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_occlusion_query")]
		public const int PIXEL_COUNT_NV = 0x8866;

		/// <summary>
		/// Value of GL_PIXEL_COUNT_AVAILABLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_occlusion_query")]
		public const int PIXEL_COUNT_AVAILABLE_NV = 0x8867;

		/// <summary>
		/// Binding for glGenOcclusionQueriesNV.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GenOcclusionQueriesNV(Int32 n, UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglGenOcclusionQueriesNV != null, "pglGenOcclusionQueriesNV not implemented");
					Delegates.pglGenOcclusionQueriesNV(n, p_ids);
					CallLog("glGenOcclusionQueriesNV({0}, {1})", n, ids);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteOcclusionQueriesNV.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void DeleteOcclusionQueriesNV(Int32 n, UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglDeleteOcclusionQueriesNV != null, "pglDeleteOcclusionQueriesNV not implemented");
					Delegates.pglDeleteOcclusionQueriesNV(n, p_ids);
					CallLog("glDeleteOcclusionQueriesNV({0}, {1})", n, ids);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIsOcclusionQueryNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static bool IsOcclusionQueryNV(UInt32 id)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsOcclusionQueryNV != null, "pglIsOcclusionQueryNV not implemented");
			retValue = Delegates.pglIsOcclusionQueryNV(id);
			CallLog("glIsOcclusionQueryNV({0}) = {1}", id, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glBeginOcclusionQueryNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void BeginOcclusionQueryNV(UInt32 id)
		{
			Debug.Assert(Delegates.pglBeginOcclusionQueryNV != null, "pglBeginOcclusionQueryNV not implemented");
			Delegates.pglBeginOcclusionQueryNV(id);
			CallLog("glBeginOcclusionQueryNV({0})", id);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEndOcclusionQueryNV.
		/// </summary>
		public static void EndOcclusionQueryNV()
		{
			Debug.Assert(Delegates.pglEndOcclusionQueryNV != null, "pglEndOcclusionQueryNV not implemented");
			Delegates.pglEndOcclusionQueryNV();
			CallLog("glEndOcclusionQueryNV()");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetOcclusionQueryivNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetOcclusionQueryNV(UInt32 id, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetOcclusionQueryivNV != null, "pglGetOcclusionQueryivNV not implemented");
					Delegates.pglGetOcclusionQueryivNV(id, pname, p_params);
					CallLog("glGetOcclusionQueryivNV({0}, {1}, {2})", id, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetOcclusionQueryuivNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GetOcclusionQueryuivNV(UInt32 id, int pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetOcclusionQueryuivNV != null, "pglGetOcclusionQueryuivNV not implemented");
					Delegates.pglGetOcclusionQueryuivNV(id, pname, p_params);
					CallLog("glGetOcclusionQueryuivNV({0}, {1}, {2})", id, pname, @params);
				}
			}
			DebugCheckErrors();
		}

	}

}
