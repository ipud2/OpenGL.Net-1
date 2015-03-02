
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
		/// specify whether front- or back-facing facets can be culled
		/// </summary>
		/// <param name="mode">
		/// Specifies whether front- or back-facing facets are candidates for culling. Symbolic constants GL_FRONT, GL_BACK, and 
		/// GL_FRONT_AND_BACKare accepted. The initial value is GL_BACK. 
		/// </param>
		/// <remarks>
		/// glCullFace specifies whether front- or back-facing facets are culled (as specified by mode) when facet culling is 
		/// enabled.Facet culling is initially disabled. To enable and disable facet culling, call the glEnable and glDisable 
		/// commandswith the argument GL_CULL_FACE. Facets include triangles, quadrilaterals, polygons, and rectangles. 
		/// glFrontFace specifies which of the clockwise and counterclockwise facets are front-facing and back-facing. See 
		/// glFrontFace.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glIsEnabled with argument GL_CULL_FACE 
		/// - glGet with argument GL_CULL_FACE_MODE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.FrontFace"/>
		public static void CullFace(int mode)
		{
			Debug.Assert(Delegates.pglCullFace != null, "pglCullFace not implemented");
			Delegates.pglCullFace(mode);
			CallLog("glCullFace({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify whether front- or back-facing facets can be culled
		/// </summary>
		/// <param name="mode">
		/// Specifies whether front- or back-facing facets are candidates for culling. Symbolic constants GL_FRONT, GL_BACK, and 
		/// GL_FRONT_AND_BACKare accepted. The initial value is GL_BACK. 
		/// </param>
		/// <remarks>
		/// glCullFace specifies whether front- or back-facing facets are culled (as specified by mode) when facet culling is 
		/// enabled.Facet culling is initially disabled. To enable and disable facet culling, call the glEnable and glDisable 
		/// commandswith the argument GL_CULL_FACE. Facets include triangles, quadrilaterals, polygons, and rectangles. 
		/// glFrontFace specifies which of the clockwise and counterclockwise facets are front-facing and back-facing. See 
		/// glFrontFace.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glIsEnabled with argument GL_CULL_FACE 
		/// - glGet with argument GL_CULL_FACE_MODE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.FrontFace"/>
		public static void CullFace(CullFaceMode mode)
		{
			Debug.Assert(Delegates.pglCullFace != null, "pglCullFace not implemented");
			Delegates.pglCullFace((int)mode);
			CallLog("glCullFace({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// define front- and back-facing polygons
		/// </summary>
		/// <param name="mode">
		/// Specifies the orientation of front-facing polygons. GL_CW and GL_CCW are accepted. The initial value is GL_CCW. 
		/// </param>
		/// <remarks>
		/// In a scene composed entirely of opaque closed surfaces, back-facing polygons are never visible. Eliminating these 
		/// invisiblepolygons has the obvious benefit of speeding up the rendering of the image. To enable and disable elimination 
		/// ofback-facing polygons, call glEnable and glDisable with argument GL_CULL_FACE. 
		/// The projection of a polygon to window coordinates is said to have clockwise winding if an imaginary object following the 
		/// pathfrom its first vertex, its second vertex, and so on, to its last vertex, and finally back to its first vertex, moves 
		/// ina clockwise direction about the interior of the polygon. The polygon's winding is said to be counterclockwise if the 
		/// imaginaryobject following the same path moves in a counterclockwise direction about the interior of the polygon. 
		/// glFrontFacespecifies whether polygons with clockwise winding in window coordinates, or counterclockwise winding in 
		/// windowcoordinates, are taken to be front-facing. Passing GL_CCW to mode selects counterclockwise polygons as 
		/// front-facing;GL_CW selects clockwise polygons as front-facing. By default, counterclockwise polygons are taken to be 
		/// front-facing.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_FRONT_FACE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CullFace"/>
		public static void FrontFace(int mode)
		{
			Debug.Assert(Delegates.pglFrontFace != null, "pglFrontFace not implemented");
			Delegates.pglFrontFace(mode);
			CallLog("glFrontFace({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// define front- and back-facing polygons
		/// </summary>
		/// <param name="mode">
		/// Specifies the orientation of front-facing polygons. GL_CW and GL_CCW are accepted. The initial value is GL_CCW. 
		/// </param>
		/// <remarks>
		/// In a scene composed entirely of opaque closed surfaces, back-facing polygons are never visible. Eliminating these 
		/// invisiblepolygons has the obvious benefit of speeding up the rendering of the image. To enable and disable elimination 
		/// ofback-facing polygons, call glEnable and glDisable with argument GL_CULL_FACE. 
		/// The projection of a polygon to window coordinates is said to have clockwise winding if an imaginary object following the 
		/// pathfrom its first vertex, its second vertex, and so on, to its last vertex, and finally back to its first vertex, moves 
		/// ina clockwise direction about the interior of the polygon. The polygon's winding is said to be counterclockwise if the 
		/// imaginaryobject following the same path moves in a counterclockwise direction about the interior of the polygon. 
		/// glFrontFacespecifies whether polygons with clockwise winding in window coordinates, or counterclockwise winding in 
		/// windowcoordinates, are taken to be front-facing. Passing GL_CCW to mode selects counterclockwise polygons as 
		/// front-facing;GL_CW selects clockwise polygons as front-facing. By default, counterclockwise polygons are taken to be 
		/// front-facing.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not an accepted value. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_FRONT_FACE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CullFace"/>
		public static void FrontFace(FrontFaceDirection mode)
		{
			Debug.Assert(Delegates.pglFrontFace != null, "pglFrontFace not implemented");
			Delegates.pglFrontFace((int)mode);
			CallLog("glFrontFace({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify implementation-specific hints
		/// </summary>
		/// <param name="target">
		/// Specifies a symbolic constant indicating the behavior to be controlled. GL_LINE_SMOOTH_HINT, GL_POLYGON_SMOOTH_HINT, 
		/// GL_TEXTURE_COMPRESSION_HINT,and GL_FRAGMENT_SHADER_DERIVATIVE_HINT are accepted. 
		/// </param>
		/// <param name="mode">
		/// Specifies a symbolic constant indicating the desired behavior. GL_FASTEST, GL_NICEST, and GL_DONT_CARE are accepted. 
		/// </param>
		/// <remarks>
		/// Certain aspects of GL behavior, when there is room for interpretation, can be controlled with hints. A hint is specified 
		/// withtwo arguments. target is a symbolic constant indicating the behavior to be controlled, and mode is another symbolic 
		/// constantindicating the desired behavior. The initial value for each target is GL_DONT_CARE. mode can be one of the 
		/// following:
		/// Though the implementation aspects that can be hinted are well defined, the interpretation of the hints depends on the 
		/// implementation.The hint aspects that can be specified with target, along with suggested semantics, are as follows: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if either target or mode is not an accepted value. 
		/// </para>
		/// </remarks>
		public static void Hint(int target, int mode)
		{
			Debug.Assert(Delegates.pglHint != null, "pglHint not implemented");
			Delegates.pglHint(target, mode);
			CallLog("glHint({0}, {1})", target, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify implementation-specific hints
		/// </summary>
		/// <param name="target">
		/// Specifies a symbolic constant indicating the behavior to be controlled. GL_LINE_SMOOTH_HINT, GL_POLYGON_SMOOTH_HINT, 
		/// GL_TEXTURE_COMPRESSION_HINT,and GL_FRAGMENT_SHADER_DERIVATIVE_HINT are accepted. 
		/// </param>
		/// <param name="mode">
		/// Specifies a symbolic constant indicating the desired behavior. GL_FASTEST, GL_NICEST, and GL_DONT_CARE are accepted. 
		/// </param>
		/// <remarks>
		/// Certain aspects of GL behavior, when there is room for interpretation, can be controlled with hints. A hint is specified 
		/// withtwo arguments. target is a symbolic constant indicating the behavior to be controlled, and mode is another symbolic 
		/// constantindicating the desired behavior. The initial value for each target is GL_DONT_CARE. mode can be one of the 
		/// following:
		/// Though the implementation aspects that can be hinted are well defined, the interpretation of the hints depends on the 
		/// implementation.The hint aspects that can be specified with target, along with suggested semantics, are as follows: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if either target or mode is not an accepted value. 
		/// </para>
		/// </remarks>
		public static void Hint(HintTarget target, HintMode mode)
		{
			Debug.Assert(Delegates.pglHint != null, "pglHint not implemented");
			Delegates.pglHint((int)target, (int)mode);
			CallLog("glHint({0}, {1})", target, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the width of rasterized lines
		/// </summary>
		/// <param name="width">
		/// Specifies the width of rasterized lines. The initial value is 1. 
		/// </param>
		/// <remarks>
		/// glLineWidth specifies the rasterized width of both aliased and antialiased lines. Using a line width other than 1 has 
		/// differenteffects, depending on whether line antialiasing is enabled. To enable and disable line antialiasing, call 
		/// glEnableand glDisable with argument GL_LINE_SMOOTH. Line antialiasing is initially disabled. 
		/// If line antialiasing is disabled, the actual width is determined by rounding the supplied width to the nearest integer. 
		/// (Ifthe rounding results in the value 0, it is as if the line width were 1.) If Δx&gt;=Δy, i pixels are filled in each 
		/// columnthat is rasterized, where i is the rounded value of width. Otherwise, i pixels are filled in each row that is 
		/// rasterized.
		/// If antialiasing is enabled, line rasterization produces a fragment for each pixel square that intersects the region 
		/// lyingwithin the rectangle having width equal to the current line width, length equal to the actual length of the line, 
		/// andcentered on the mathematical line segment. The coverage value for each fragment is the window coordinate area of the 
		/// intersectionof the rectangular region with the corresponding pixel square. This value is saved and used in the final 
		/// rasterizationstep. 
		/// Not all widths can be supported when line antialiasing is enabled. If an unsupported width is requested, the nearest 
		/// supportedwidth is used. Only width 1 is guaranteed to be supported; others depend on the implementation. Likewise, there 
		/// isa range for aliased line widths as well. To query the range of supported widths and the size difference between 
		/// supportedwidths within the range, call glGet with arguments GL_ALIASED_LINE_WIDTH_RANGE, GL_SMOOTH_LINE_WIDTH_RANGE, and 
		/// GL_SMOOTH_LINE_WIDTH_GRANULARITY.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if width is less than or equal to 0. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_LINE_WIDTH 
		/// - glGet with argument GL_ALIASED_LINE_WIDTH_RANGE 
		/// - glGet with argument GL_SMOOTH_LINE_WIDTH_RANGE 
		/// - glGet with argument GL_SMOOTH_LINE_WIDTH_GRANULARITY 
		/// - glIsEnabled with argument GL_LINE_SMOOTH 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Enable"/>
		public static void LineWidth(float width)
		{
			Debug.Assert(Delegates.pglLineWidth != null, "pglLineWidth not implemented");
			Delegates.pglLineWidth(width);
			CallLog("glLineWidth({0})", width);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the diameter of rasterized points
		/// </summary>
		/// <param name="size">
		/// Specifies the diameter of rasterized points. The initial value is 1. 
		/// </param>
		/// <remarks>
		/// glPointSize specifies the rasterized diameter of points. If point size mode is disabled (see glEnable with parameter 
		/// GL_PROGRAM_POINT_SIZE),this value will be used to rasterize points. Otherwise, the value written to the shading language 
		/// built-invariable gl_PointSize will be used. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if size is less than or equal to 0. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_POINT_SIZE_RANGE 
		/// - glGet with argument GL_POINT_SIZE_GRANULARITY 
		/// - glGet with argument GL_POINT_SIZE 
		/// - glGet with argument GL_POINT_FADE_THRESHOLD_SIZE 
		/// - glIsEnabled with argument GL_PROGRAM_POINT_SIZE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.PointParameter"/>
		public static void PointSize(float size)
		{
			Debug.Assert(Delegates.pglPointSize != null, "pglPointSize not implemented");
			Delegates.pglPointSize(size);
			CallLog("glPointSize({0})", size);
			DebugCheckErrors();
		}

		/// <summary>
		/// select a polygon rasterization mode
		/// </summary>
		/// <param name="face">
		/// Specifies the polygons that mode applies to. Must be GL_FRONT_AND_BACK for front- and back-facing polygons. 
		/// </param>
		/// <param name="mode">
		/// Specifies how polygons will be rasterized. Accepted values are GL_POINT, GL_LINE, and GL_FILL. The initial value is 
		/// GL_FILLfor both front- and back-facing polygons. 
		/// </param>
		/// <remarks>
		/// glPolygonMode controls the interpretation of polygons for rasterization. face describes which polygons mode applies to: 
		/// bothfront and back-facing polygons (GL_FRONT_AND_BACK). The polygon mode affects only the final rasterization of 
		/// polygons.In particular, a polygon's vertices are lit and the polygon is clipped and possibly culled before these modes 
		/// areapplied. 
		/// Three modes are defined and can be specified in mode: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if either face or mode is not an accepted value. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_POLYGON_MODE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LineWidth"/>
		/// <seealso cref="Gl.PointSize"/>
		public static void PolygonMode(int face, int mode)
		{
			Debug.Assert(Delegates.pglPolygonMode != null, "pglPolygonMode not implemented");
			Delegates.pglPolygonMode(face, mode);
			CallLog("glPolygonMode({0}, {1})", face, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// select a polygon rasterization mode
		/// </summary>
		/// <param name="face">
		/// Specifies the polygons that mode applies to. Must be GL_FRONT_AND_BACK for front- and back-facing polygons. 
		/// </param>
		/// <param name="mode">
		/// Specifies how polygons will be rasterized. Accepted values are GL_POINT, GL_LINE, and GL_FILL. The initial value is 
		/// GL_FILLfor both front- and back-facing polygons. 
		/// </param>
		/// <remarks>
		/// glPolygonMode controls the interpretation of polygons for rasterization. face describes which polygons mode applies to: 
		/// bothfront and back-facing polygons (GL_FRONT_AND_BACK). The polygon mode affects only the final rasterization of 
		/// polygons.In particular, a polygon's vertices are lit and the polygon is clipped and possibly culled before these modes 
		/// areapplied. 
		/// Three modes are defined and can be specified in mode: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if either face or mode is not an accepted value. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_POLYGON_MODE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LineWidth"/>
		/// <seealso cref="Gl.PointSize"/>
		public static void PolygonMode(MaterialFace face, PolygonMode mode)
		{
			Debug.Assert(Delegates.pglPolygonMode != null, "pglPolygonMode not implemented");
			Delegates.pglPolygonMode((int)face, (int)mode);
			CallLog("glPolygonMode({0}, {1})", face, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// define the scissor box
		/// </summary>
		/// <param name="x">
		/// Specify the lower left corner of the scissor box. Initially (0, 0). 
		/// </param>
		/// <param name="y">
		/// Specify the lower left corner of the scissor box. Initially (0, 0). 
		/// </param>
		/// <param name="width">
		/// Specify the width and height of the scissor box. When a GL context is first attached to a window, width and height are 
		/// setto the dimensions of that window. 
		/// </param>
		/// <param name="height">
		/// Specify the width and height of the scissor box. When a GL context is first attached to a window, width and height are 
		/// setto the dimensions of that window. 
		/// </param>
		/// <remarks>
		/// glScissor defines a rectangle, called the scissor box, in window coordinates. The first two arguments, x and y, specify 
		/// thelower left corner of the box. width and height specify the width and height of the box. 
		/// To enable and disable the scissor test, call glEnable and glDisable with argument GL_SCISSOR_TEST. The test is initially 
		/// disabled.While the test is enabled, only pixels that lie within the scissor box can be modified by drawing commands. 
		/// Windowcoordinates have integer values at the shared corners of frame buffer pixels. glScissor(0,0,1,1) allows 
		/// modificationof only the lower left pixel in the window, and glScissor(0,0,0,0) doesn't allow modification of any pixels 
		/// inthe window. 
		/// When the scissor test is disabled, it is as though the scissor box includes the entire window. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if either width or height is negative. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_SCISSOR_BOX 
		/// - glIsEnabled with argument GL_SCISSOR_TEST 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Viewport"/>
		public static void Scissor(Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglScissor != null, "pglScissor not implemented");
			Delegates.pglScissor(x, y, width, height);
			CallLog("glScissor({0}, {1}, {2}, {3})", x, y, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either <see cref="Gl.TEXTURE_1D"/>, <see cref="Gl.TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_3D"/>,or <see cref="Gl.TEXTURE_CUBE_MAP"/>. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// <seecref="Gl.TEXTURE_MIN_FILTER"/>, <see cref="Gl.TEXTURE_MAG_FILTER"/>, <see cref="Gl.TEXTURE_MIN_LOD"/>, <see 
		/// cref="Gl.TEXTURE_MAX_LOD"/>,<see cref="Gl.TEXTURE_BASE_LEVEL"/>, <see cref="Gl.TEXTURE_MAX_LEVEL"/>, <see 
		/// cref="Gl.TEXTURE_WRAP_S"/>,<see cref="Gl.TEXTURE_WRAP_T"/>, <see cref="Gl.TEXTURE_WRAP_R"/>, <see 
		/// cref="Gl.TEXTURE_PRIORITY"/>,<see cref="Gl.TEXTURE_COMPARE_MODE"/>, <see cref="Gl.TEXTURE_COMPARE_FUNC"/>, <see 
		/// cref="Gl.DEPTH_TEXTURE_MODE"/>,or <see cref="Gl.GENERATE_MIPMAP"/>. 
		/// </param>
		/// <param name="param">
		/// Specifies the value of <paramref name="pname"/>. 
		/// </param>
		/// <remarks>
		/// Texture mapping is a technique that applies an image onto an object's surface as if the image were a decal or cellophane 
		/// shrink-wrap.The image is created in texture space, with an (s, t) coordinate system. A texture is a one- or 
		/// two-dimensionalimage and a set of parameters that determine how samples are derived from the image. 
		/// <see cref="Gl.TexParameter"/> assigns the value or values in <paramref name="params"/> to the texture parameter 
		/// specifiedas <paramref name="pname"/>. <paramref name="target"/> defines the target texture, either <see 
		/// cref="Gl.TEXTURE_1D"/>,<see cref="Gl.TEXTURE_2D"/>, or <see cref="Gl.TEXTURE_3D"/>. The following symbols are accepted 
		/// in<paramref name="pname"/>: 
		///  
		///  
		///  
		///  
		///  
		///  
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> or <paramref name="pname"/> is not one of the 
		///   accepteddefined values. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="params"/> should have a defined constant value (based on 
		///   thevalue of <paramref name="pname"/>) and does not. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexParameter"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexParameter 
		/// - Gl.GetTexLevelParameter 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PrioritizeTextures"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexParameter(int target, int pname, float param)
		{
			Debug.Assert(Delegates.pglTexParameterf != null, "pglTexParameterf not implemented");
			Delegates.pglTexParameterf(target, pname, param);
			CallLog("glTexParameterf({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either <see cref="Gl.TEXTURE_1D"/>, <see cref="Gl.TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_3D"/>,or <see cref="Gl.TEXTURE_CUBE_MAP"/>. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// <seecref="Gl.TEXTURE_MIN_FILTER"/>, <see cref="Gl.TEXTURE_MAG_FILTER"/>, <see cref="Gl.TEXTURE_MIN_LOD"/>, <see 
		/// cref="Gl.TEXTURE_MAX_LOD"/>,<see cref="Gl.TEXTURE_BASE_LEVEL"/>, <see cref="Gl.TEXTURE_MAX_LEVEL"/>, <see 
		/// cref="Gl.TEXTURE_WRAP_S"/>,<see cref="Gl.TEXTURE_WRAP_T"/>, <see cref="Gl.TEXTURE_WRAP_R"/>, <see 
		/// cref="Gl.TEXTURE_PRIORITY"/>,<see cref="Gl.TEXTURE_COMPARE_MODE"/>, <see cref="Gl.TEXTURE_COMPARE_FUNC"/>, <see 
		/// cref="Gl.DEPTH_TEXTURE_MODE"/>,or <see cref="Gl.GENERATE_MIPMAP"/>. 
		/// </param>
		/// <param name="param">
		/// Specifies the value of <paramref name="pname"/>. 
		/// </param>
		/// <remarks>
		/// Texture mapping is a technique that applies an image onto an object's surface as if the image were a decal or cellophane 
		/// shrink-wrap.The image is created in texture space, with an (s, t) coordinate system. A texture is a one- or 
		/// two-dimensionalimage and a set of parameters that determine how samples are derived from the image. 
		/// <see cref="Gl.TexParameter"/> assigns the value or values in <paramref name="params"/> to the texture parameter 
		/// specifiedas <paramref name="pname"/>. <paramref name="target"/> defines the target texture, either <see 
		/// cref="Gl.TEXTURE_1D"/>,<see cref="Gl.TEXTURE_2D"/>, or <see cref="Gl.TEXTURE_3D"/>. The following symbols are accepted 
		/// in<paramref name="pname"/>: 
		///  
		///  
		///  
		///  
		///  
		///  
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> or <paramref name="pname"/> is not one of the 
		///   accepteddefined values. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="params"/> should have a defined constant value (based on 
		///   thevalue of <paramref name="pname"/>) and does not. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexParameter"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexParameter 
		/// - Gl.GetTexLevelParameter 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PrioritizeTextures"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexParameter(TextureTarget target, TextureParameterName pname, float param)
		{
			Debug.Assert(Delegates.pglTexParameterf != null, "pglTexParameterf not implemented");
			Delegates.pglTexParameterf((int)target, (int)pname, param);
			CallLog("glTexParameterf({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either <see cref="Gl.TEXTURE_1D"/>, <see cref="Gl.TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_3D"/>,or <see cref="Gl.TEXTURE_CUBE_MAP"/>. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// <seecref="Gl.TEXTURE_MIN_FILTER"/>, <see cref="Gl.TEXTURE_MAG_FILTER"/>, <see cref="Gl.TEXTURE_MIN_LOD"/>, <see 
		/// cref="Gl.TEXTURE_MAX_LOD"/>,<see cref="Gl.TEXTURE_BASE_LEVEL"/>, <see cref="Gl.TEXTURE_MAX_LEVEL"/>, <see 
		/// cref="Gl.TEXTURE_WRAP_S"/>,<see cref="Gl.TEXTURE_WRAP_T"/>, <see cref="Gl.TEXTURE_WRAP_R"/>, <see 
		/// cref="Gl.TEXTURE_PRIORITY"/>,<see cref="Gl.TEXTURE_COMPARE_MODE"/>, <see cref="Gl.TEXTURE_COMPARE_FUNC"/>, <see 
		/// cref="Gl.DEPTH_TEXTURE_MODE"/>,or <see cref="Gl.GENERATE_MIPMAP"/>. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// Texture mapping is a technique that applies an image onto an object's surface as if the image were a decal or cellophane 
		/// shrink-wrap.The image is created in texture space, with an (s, t) coordinate system. A texture is a one- or 
		/// two-dimensionalimage and a set of parameters that determine how samples are derived from the image. 
		/// <see cref="Gl.TexParameter"/> assigns the value or values in <paramref name="params"/> to the texture parameter 
		/// specifiedas <paramref name="pname"/>. <paramref name="target"/> defines the target texture, either <see 
		/// cref="Gl.TEXTURE_1D"/>,<see cref="Gl.TEXTURE_2D"/>, or <see cref="Gl.TEXTURE_3D"/>. The following symbols are accepted 
		/// in<paramref name="pname"/>: 
		///  
		///  
		///  
		///  
		///  
		///  
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> or <paramref name="pname"/> is not one of the 
		///   accepteddefined values. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="params"/> should have a defined constant value (based on 
		///   thevalue of <paramref name="pname"/>) and does not. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexParameter"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexParameter 
		/// - Gl.GetTexLevelParameter 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PrioritizeTextures"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexParameter(int target, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterfv != null, "pglTexParameterfv not implemented");
					Delegates.pglTexParameterfv(target, pname, p_params);
					CallLog("glTexParameterfv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either <see cref="Gl.TEXTURE_1D"/>, <see cref="Gl.TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_3D"/>,or <see cref="Gl.TEXTURE_CUBE_MAP"/>. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// <seecref="Gl.TEXTURE_MIN_FILTER"/>, <see cref="Gl.TEXTURE_MAG_FILTER"/>, <see cref="Gl.TEXTURE_MIN_LOD"/>, <see 
		/// cref="Gl.TEXTURE_MAX_LOD"/>,<see cref="Gl.TEXTURE_BASE_LEVEL"/>, <see cref="Gl.TEXTURE_MAX_LEVEL"/>, <see 
		/// cref="Gl.TEXTURE_WRAP_S"/>,<see cref="Gl.TEXTURE_WRAP_T"/>, <see cref="Gl.TEXTURE_WRAP_R"/>, <see 
		/// cref="Gl.TEXTURE_PRIORITY"/>,<see cref="Gl.TEXTURE_COMPARE_MODE"/>, <see cref="Gl.TEXTURE_COMPARE_FUNC"/>, <see 
		/// cref="Gl.DEPTH_TEXTURE_MODE"/>,or <see cref="Gl.GENERATE_MIPMAP"/>. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// Texture mapping is a technique that applies an image onto an object's surface as if the image were a decal or cellophane 
		/// shrink-wrap.The image is created in texture space, with an (s, t) coordinate system. A texture is a one- or 
		/// two-dimensionalimage and a set of parameters that determine how samples are derived from the image. 
		/// <see cref="Gl.TexParameter"/> assigns the value or values in <paramref name="params"/> to the texture parameter 
		/// specifiedas <paramref name="pname"/>. <paramref name="target"/> defines the target texture, either <see 
		/// cref="Gl.TEXTURE_1D"/>,<see cref="Gl.TEXTURE_2D"/>, or <see cref="Gl.TEXTURE_3D"/>. The following symbols are accepted 
		/// in<paramref name="pname"/>: 
		///  
		///  
		///  
		///  
		///  
		///  
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> or <paramref name="pname"/> is not one of the 
		///   accepteddefined values. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="params"/> should have a defined constant value (based on 
		///   thevalue of <paramref name="pname"/>) and does not. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexParameter"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexParameter 
		/// - Gl.GetTexLevelParameter 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PrioritizeTextures"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexParameter(TextureTarget target, TextureParameterName pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterfv != null, "pglTexParameterfv not implemented");
					Delegates.pglTexParameterfv((int)target, (int)pname, p_params);
					CallLog("glTexParameterfv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either <see cref="Gl.TEXTURE_1D"/>, <see cref="Gl.TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_3D"/>,or <see cref="Gl.TEXTURE_CUBE_MAP"/>. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// <seecref="Gl.TEXTURE_MIN_FILTER"/>, <see cref="Gl.TEXTURE_MAG_FILTER"/>, <see cref="Gl.TEXTURE_MIN_LOD"/>, <see 
		/// cref="Gl.TEXTURE_MAX_LOD"/>,<see cref="Gl.TEXTURE_BASE_LEVEL"/>, <see cref="Gl.TEXTURE_MAX_LEVEL"/>, <see 
		/// cref="Gl.TEXTURE_WRAP_S"/>,<see cref="Gl.TEXTURE_WRAP_T"/>, <see cref="Gl.TEXTURE_WRAP_R"/>, <see 
		/// cref="Gl.TEXTURE_PRIORITY"/>,<see cref="Gl.TEXTURE_COMPARE_MODE"/>, <see cref="Gl.TEXTURE_COMPARE_FUNC"/>, <see 
		/// cref="Gl.DEPTH_TEXTURE_MODE"/>,or <see cref="Gl.GENERATE_MIPMAP"/>. 
		/// </param>
		/// <param name="param">
		/// Specifies the value of <paramref name="pname"/>. 
		/// </param>
		/// <remarks>
		/// Texture mapping is a technique that applies an image onto an object's surface as if the image were a decal or cellophane 
		/// shrink-wrap.The image is created in texture space, with an (s, t) coordinate system. A texture is a one- or 
		/// two-dimensionalimage and a set of parameters that determine how samples are derived from the image. 
		/// <see cref="Gl.TexParameter"/> assigns the value or values in <paramref name="params"/> to the texture parameter 
		/// specifiedas <paramref name="pname"/>. <paramref name="target"/> defines the target texture, either <see 
		/// cref="Gl.TEXTURE_1D"/>,<see cref="Gl.TEXTURE_2D"/>, or <see cref="Gl.TEXTURE_3D"/>. The following symbols are accepted 
		/// in<paramref name="pname"/>: 
		///  
		///  
		///  
		///  
		///  
		///  
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> or <paramref name="pname"/> is not one of the 
		///   accepteddefined values. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="params"/> should have a defined constant value (based on 
		///   thevalue of <paramref name="pname"/>) and does not. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexParameter"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexParameter 
		/// - Gl.GetTexLevelParameter 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PrioritizeTextures"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexParameter(int target, int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexParameteri != null, "pglTexParameteri not implemented");
			Delegates.pglTexParameteri(target, pname, param);
			CallLog("glTexParameteri({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either <see cref="Gl.TEXTURE_1D"/>, <see cref="Gl.TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_3D"/>,or <see cref="Gl.TEXTURE_CUBE_MAP"/>. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// <seecref="Gl.TEXTURE_MIN_FILTER"/>, <see cref="Gl.TEXTURE_MAG_FILTER"/>, <see cref="Gl.TEXTURE_MIN_LOD"/>, <see 
		/// cref="Gl.TEXTURE_MAX_LOD"/>,<see cref="Gl.TEXTURE_BASE_LEVEL"/>, <see cref="Gl.TEXTURE_MAX_LEVEL"/>, <see 
		/// cref="Gl.TEXTURE_WRAP_S"/>,<see cref="Gl.TEXTURE_WRAP_T"/>, <see cref="Gl.TEXTURE_WRAP_R"/>, <see 
		/// cref="Gl.TEXTURE_PRIORITY"/>,<see cref="Gl.TEXTURE_COMPARE_MODE"/>, <see cref="Gl.TEXTURE_COMPARE_FUNC"/>, <see 
		/// cref="Gl.DEPTH_TEXTURE_MODE"/>,or <see cref="Gl.GENERATE_MIPMAP"/>. 
		/// </param>
		/// <param name="param">
		/// Specifies the value of <paramref name="pname"/>. 
		/// </param>
		/// <remarks>
		/// Texture mapping is a technique that applies an image onto an object's surface as if the image were a decal or cellophane 
		/// shrink-wrap.The image is created in texture space, with an (s, t) coordinate system. A texture is a one- or 
		/// two-dimensionalimage and a set of parameters that determine how samples are derived from the image. 
		/// <see cref="Gl.TexParameter"/> assigns the value or values in <paramref name="params"/> to the texture parameter 
		/// specifiedas <paramref name="pname"/>. <paramref name="target"/> defines the target texture, either <see 
		/// cref="Gl.TEXTURE_1D"/>,<see cref="Gl.TEXTURE_2D"/>, or <see cref="Gl.TEXTURE_3D"/>. The following symbols are accepted 
		/// in<paramref name="pname"/>: 
		///  
		///  
		///  
		///  
		///  
		///  
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> or <paramref name="pname"/> is not one of the 
		///   accepteddefined values. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="params"/> should have a defined constant value (based on 
		///   thevalue of <paramref name="pname"/>) and does not. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexParameter"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexParameter 
		/// - Gl.GetTexLevelParameter 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PrioritizeTextures"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexParameter(TextureTarget target, TextureParameterName pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexParameteri != null, "pglTexParameteri not implemented");
			Delegates.pglTexParameteri((int)target, (int)pname, param);
			CallLog("glTexParameteri({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either <see cref="Gl.TEXTURE_1D"/>, <see cref="Gl.TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_3D"/>,or <see cref="Gl.TEXTURE_CUBE_MAP"/>. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// <seecref="Gl.TEXTURE_MIN_FILTER"/>, <see cref="Gl.TEXTURE_MAG_FILTER"/>, <see cref="Gl.TEXTURE_MIN_LOD"/>, <see 
		/// cref="Gl.TEXTURE_MAX_LOD"/>,<see cref="Gl.TEXTURE_BASE_LEVEL"/>, <see cref="Gl.TEXTURE_MAX_LEVEL"/>, <see 
		/// cref="Gl.TEXTURE_WRAP_S"/>,<see cref="Gl.TEXTURE_WRAP_T"/>, <see cref="Gl.TEXTURE_WRAP_R"/>, <see 
		/// cref="Gl.TEXTURE_PRIORITY"/>,<see cref="Gl.TEXTURE_COMPARE_MODE"/>, <see cref="Gl.TEXTURE_COMPARE_FUNC"/>, <see 
		/// cref="Gl.DEPTH_TEXTURE_MODE"/>,or <see cref="Gl.GENERATE_MIPMAP"/>. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// Texture mapping is a technique that applies an image onto an object's surface as if the image were a decal or cellophane 
		/// shrink-wrap.The image is created in texture space, with an (s, t) coordinate system. A texture is a one- or 
		/// two-dimensionalimage and a set of parameters that determine how samples are derived from the image. 
		/// <see cref="Gl.TexParameter"/> assigns the value or values in <paramref name="params"/> to the texture parameter 
		/// specifiedas <paramref name="pname"/>. <paramref name="target"/> defines the target texture, either <see 
		/// cref="Gl.TEXTURE_1D"/>,<see cref="Gl.TEXTURE_2D"/>, or <see cref="Gl.TEXTURE_3D"/>. The following symbols are accepted 
		/// in<paramref name="pname"/>: 
		///  
		///  
		///  
		///  
		///  
		///  
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> or <paramref name="pname"/> is not one of the 
		///   accepteddefined values. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="params"/> should have a defined constant value (based on 
		///   thevalue of <paramref name="pname"/>) and does not. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexParameter"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexParameter 
		/// - Gl.GetTexLevelParameter 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PrioritizeTextures"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexParameter(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameteriv != null, "pglTexParameteriv not implemented");
					Delegates.pglTexParameteriv(target, pname, p_params);
					CallLog("glTexParameteriv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either <see cref="Gl.TEXTURE_1D"/>, <see cref="Gl.TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_3D"/>,or <see cref="Gl.TEXTURE_CUBE_MAP"/>. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// <seecref="Gl.TEXTURE_MIN_FILTER"/>, <see cref="Gl.TEXTURE_MAG_FILTER"/>, <see cref="Gl.TEXTURE_MIN_LOD"/>, <see 
		/// cref="Gl.TEXTURE_MAX_LOD"/>,<see cref="Gl.TEXTURE_BASE_LEVEL"/>, <see cref="Gl.TEXTURE_MAX_LEVEL"/>, <see 
		/// cref="Gl.TEXTURE_WRAP_S"/>,<see cref="Gl.TEXTURE_WRAP_T"/>, <see cref="Gl.TEXTURE_WRAP_R"/>, <see 
		/// cref="Gl.TEXTURE_PRIORITY"/>,<see cref="Gl.TEXTURE_COMPARE_MODE"/>, <see cref="Gl.TEXTURE_COMPARE_FUNC"/>, <see 
		/// cref="Gl.DEPTH_TEXTURE_MODE"/>,or <see cref="Gl.GENERATE_MIPMAP"/>. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// Texture mapping is a technique that applies an image onto an object's surface as if the image were a decal or cellophane 
		/// shrink-wrap.The image is created in texture space, with an (s, t) coordinate system. A texture is a one- or 
		/// two-dimensionalimage and a set of parameters that determine how samples are derived from the image. 
		/// <see cref="Gl.TexParameter"/> assigns the value or values in <paramref name="params"/> to the texture parameter 
		/// specifiedas <paramref name="pname"/>. <paramref name="target"/> defines the target texture, either <see 
		/// cref="Gl.TEXTURE_1D"/>,<see cref="Gl.TEXTURE_2D"/>, or <see cref="Gl.TEXTURE_3D"/>. The following symbols are accepted 
		/// in<paramref name="pname"/>: 
		///  
		///  
		///  
		///  
		///  
		///  
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> or <paramref name="pname"/> is not one of the 
		///   accepteddefined values. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="params"/> should have a defined constant value (based on 
		///   thevalue of <paramref name="pname"/>) and does not. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexParameter"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexParameter 
		/// - Gl.GetTexLevelParameter 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PrioritizeTextures"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexParameter(TextureTarget target, TextureParameterName pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameteriv != null, "pglTexParameteriv not implemented");
					Delegates.pglTexParameteriv((int)target, (int)pname, p_params);
					CallLog("glTexParameteriv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a one-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_1D"/> or <see cref="Gl.PROXY_TEXTURE_1D"/>. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images 
		/// thatare at least 64 texels wide. The height of the 1D texture image is 1. 
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.RED"/>,<see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>,<see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: <see cref="Gl.UNSIGNED_BYTE"/>, 
		/// <seecref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>,<see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>,<see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <seecref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>,<see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <seecref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enableand disable one-dimensional texturing, call Gl.Enable and Gl.Disable with argument <see cref="Gl.TEXTURE_1D"/>. 
		/// Texture images are defined with <see cref="Gl.TexImage1D"/>. The arguments describe the parameters of the texture image, 
		/// suchas width, width of the border, level-of-detail number (see Gl.TexParameter), and the internal resolution and format 
		/// usedto store the image. The last three arguments describe how the image is represented in memory; they are identical to 
		/// thepixel formats used for Gl.DrawPixels. 
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_TEXTURE_1D"/>, no data is read from <paramref name="data"/>, but all 
		/// ofthe texture image state is recalculated, checked for consistency, and checked against the implementation's 
		/// capabilities.If the implementation cannot handle a texture of the requested texture size, it sets all of the image state 
		/// to0, but does not generate an error (see Gl.GetError). To query for an entire mipmap array, use an image array level 
		/// greaterthan or equal to 1. 
		/// If <paramref name="target"/> is <see cref="Gl.TEXTURE_1D"/>, data is read from <paramref name="data"/> as a sequence of 
		/// signedor unsigned bytes, shorts, or longs, or single-precision floating-point values, depending on <paramref 
		/// name="type"/>.These values are grouped into sets of one, two, three, or four values, depending on <paramref 
		/// name="format"/>,to form elements. If <paramref name="type"/> is <see cref="Gl.BITMAP"/>, the data is considered as a 
		/// stringof unsigned bytes (and <paramref name="format"/> must be <see cref="Gl.COLOR_INDEX"/>). Each data byte is treated 
		/// aseight 1-bit elements, with bit ordering determined by <see cref="Gl.UNPACK_LSB_FIRST"/> (see Gl.PixelStore). 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// atexture image is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store. 
		/// The first element corresponds to the left end of the texture array. Subsequent elements progress left-to-right through 
		/// theremaining texels in the texture array. The final element corresponds to the right end of the texture array. 
		/// <paramref name="format"/> determines the composition of each element in <paramref name="data"/>. It can assume one of 
		/// thesesymbolic values: 
		/// Refer to the Gl.DrawPixels reference page for a description of the acceptable values for the <paramref name="type"/> 
		/// parameter.
		/// If an application wants to store the texture at a certain resolution or in a certain format, it can request the 
		/// resolutionand format with <paramref name="internalFormat"/>. The GL will choose an internal representation that closely 
		/// approximatesthat requested by <paramref name="internalFormat"/>, but it may not match exactly. (The representations 
		/// specifiedby <see cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.RGB"/>, and <see 
		/// cref="Gl.RGBA"/>must match exactly. The numeric values 1, 2, 3, and 4 may also be used to specify the above 
		/// representations.)
		/// If the <paramref name="internalFormat"/> parameter is one of the generic compressed formats, <see 
		/// cref="Gl.COMPRESSED_ALPHA"/>,<see cref="Gl.COMPRESSED_INTENSITY"/>, <see cref="Gl.COMPRESSED_LUMINANCE"/>, <see 
		/// cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>,<see cref="Gl.COMPRESSED_RGB"/>, or <see cref="Gl.COMPRESSED_RGBA"/>, the GL will 
		/// replacethe internal format with the symbolic constant for a specific internal format and compress the texture before 
		/// storage.If no corresponding internal format is available, or the GL can not compress that image for any reason, the 
		/// internalformat is instead replaced with a corresponding base internal format. 
		/// If the <paramref name="internalFormat"/> parameter is <see cref="Gl.SRGB"/>, <see cref="Gl.SRGB8"/>, <see 
		/// cref="Gl.SRGB_ALPHA"/>,<see cref="Gl.SRGB8_ALPHA8"/>, <see cref="Gl.SLUMINANCE"/>, <see cref="Gl.SLUMINANCE8"/>, <see 
		/// cref="Gl.SLUMINANCE_ALPHA"/>,or <see cref="Gl.SLUMINANCE8_ALPHA8"/>, the texture is treated as if the red, green, blue, 
		/// orluminance components are encoded in the sRGB color space. Any alpha component is left unchanged. The conversion from 
		/// thesRGB encoded component cs to a linear component cl is: 
		/// cl={cs12.92ifcs≤0.04045(cs+0.0551.055)2.4ifcs&gt;0.04045 
		/// Assume cs is the sRGB component in the range [0,1]. 
		/// Use the <see cref="Gl.PROXY_TEXTURE_1D"/> target to try out a resolution and format. The implementation will update and 
		/// recomputeits best match for the requested storage resolution and format. To then query this state, call 
		/// Gl.GetTexLevelParameter.If the texture cannot be accommodated, texture state is set to 0. 
		/// A one-component texture image uses only the red component of the RGBA color from <paramref name="data"/>. A 
		/// two-componentimage uses the R and A values. A three-component image uses the R, G, and B values. A four-component image 
		/// usesall of the RGBA components. 
		/// Depth textures can be treated as LUMINANCE, INTENSITY or ALPHA textures during texture filtering and 
		/// application. Image-basedshadowing can be enabled by comparing texture r coordinates to depth texture values to generate 
		/// aboolean result. See Gl.TexParameter for details on texture comparison. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.TEXTURE_1D"/> or <see 
		///   cref="Gl.PROXY_TEXTURE_1D"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not an accepted format constant. Format 
		///   constantsother than <see cref="Gl.STENCIL_INDEX"/> are accepted. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not a type constant. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is <see cref="Gl.BITMAP"/> and <paramref 
		///   name="format"/>is not <see cref="Gl.COLOR_INDEX"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0. 
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the 
		///   returnedvalue of <see cref="Gl.MAX_TEXTURE_SIZE"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="internalFormat"/> is not 1, 2, 3, 4, or one of the 
		///   acceptedresolution and format symbolic constants. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than 0 or greater than 2 + <see 
		///   cref="Gl.MAX_TEXTURE_SIZE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if non-power-of-two textures are not supported and the <paramref 
		///   name="width"/>cannot be represented as 2n+2⁡border for some integer value of n. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="border"/> is not 0 or 1. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>,<see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or <see 
		///   cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>and <paramref name="format"/> is not <see cref="Gl.RGB"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, 
		///   <seecref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, <see 
		///   cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>,<see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is <see cref="Gl.DEPTH_COMPONENT"/> and 
		///   <paramrefname="internalFormat"/> is not <see cref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.DEPTH_COMPONENT16"/>, <see 
		///   cref="Gl.DEPTH_COMPONENT24"/>,or <see cref="Gl.DEPTH_COMPONENT32"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="internalFormat"/> is <see 
		///   cref="Gl.DEPTH_COMPONENT"/>,<see cref="Gl.DEPTH_COMPONENT16"/>, <see cref="Gl.DEPTH_COMPONENT24"/>, or <see 
		///   cref="Gl.DEPTH_COMPONENT32"/>,and <paramref name="format"/> is not <see cref="Gl.DEPTH_COMPONENT"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the data would be unpacked from the buffer object such that the memory reads 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   neededto store in memory a datum indicated by <paramref name="type"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexImage1D"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexImage 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_1D"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void TexImage1D(int target, Int32 level, Int32 internalformat, Int32 width, Int32 border, int format, int type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexImage1D != null, "pglTexImage1D not implemented");
			Delegates.pglTexImage1D(target, level, internalformat, width, border, format, type, pixels);
			CallLog("glTexImage1D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, internalformat, width, border, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a one-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_1D"/> or <see cref="Gl.PROXY_TEXTURE_1D"/>. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images 
		/// thatare at least 64 texels wide. The height of the 1D texture image is 1. 
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.RED"/>,<see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>,<see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: <see cref="Gl.UNSIGNED_BYTE"/>, 
		/// <seecref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>,<see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>,<see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <seecref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>,<see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <seecref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enableand disable one-dimensional texturing, call Gl.Enable and Gl.Disable with argument <see cref="Gl.TEXTURE_1D"/>. 
		/// Texture images are defined with <see cref="Gl.TexImage1D"/>. The arguments describe the parameters of the texture image, 
		/// suchas width, width of the border, level-of-detail number (see Gl.TexParameter), and the internal resolution and format 
		/// usedto store the image. The last three arguments describe how the image is represented in memory; they are identical to 
		/// thepixel formats used for Gl.DrawPixels. 
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_TEXTURE_1D"/>, no data is read from <paramref name="data"/>, but all 
		/// ofthe texture image state is recalculated, checked for consistency, and checked against the implementation's 
		/// capabilities.If the implementation cannot handle a texture of the requested texture size, it sets all of the image state 
		/// to0, but does not generate an error (see Gl.GetError). To query for an entire mipmap array, use an image array level 
		/// greaterthan or equal to 1. 
		/// If <paramref name="target"/> is <see cref="Gl.TEXTURE_1D"/>, data is read from <paramref name="data"/> as a sequence of 
		/// signedor unsigned bytes, shorts, or longs, or single-precision floating-point values, depending on <paramref 
		/// name="type"/>.These values are grouped into sets of one, two, three, or four values, depending on <paramref 
		/// name="format"/>,to form elements. If <paramref name="type"/> is <see cref="Gl.BITMAP"/>, the data is considered as a 
		/// stringof unsigned bytes (and <paramref name="format"/> must be <see cref="Gl.COLOR_INDEX"/>). Each data byte is treated 
		/// aseight 1-bit elements, with bit ordering determined by <see cref="Gl.UNPACK_LSB_FIRST"/> (see Gl.PixelStore). 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// atexture image is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store. 
		/// The first element corresponds to the left end of the texture array. Subsequent elements progress left-to-right through 
		/// theremaining texels in the texture array. The final element corresponds to the right end of the texture array. 
		/// <paramref name="format"/> determines the composition of each element in <paramref name="data"/>. It can assume one of 
		/// thesesymbolic values: 
		/// Refer to the Gl.DrawPixels reference page for a description of the acceptable values for the <paramref name="type"/> 
		/// parameter.
		/// If an application wants to store the texture at a certain resolution or in a certain format, it can request the 
		/// resolutionand format with <paramref name="internalFormat"/>. The GL will choose an internal representation that closely 
		/// approximatesthat requested by <paramref name="internalFormat"/>, but it may not match exactly. (The representations 
		/// specifiedby <see cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.RGB"/>, and <see 
		/// cref="Gl.RGBA"/>must match exactly. The numeric values 1, 2, 3, and 4 may also be used to specify the above 
		/// representations.)
		/// If the <paramref name="internalFormat"/> parameter is one of the generic compressed formats, <see 
		/// cref="Gl.COMPRESSED_ALPHA"/>,<see cref="Gl.COMPRESSED_INTENSITY"/>, <see cref="Gl.COMPRESSED_LUMINANCE"/>, <see 
		/// cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>,<see cref="Gl.COMPRESSED_RGB"/>, or <see cref="Gl.COMPRESSED_RGBA"/>, the GL will 
		/// replacethe internal format with the symbolic constant for a specific internal format and compress the texture before 
		/// storage.If no corresponding internal format is available, or the GL can not compress that image for any reason, the 
		/// internalformat is instead replaced with a corresponding base internal format. 
		/// If the <paramref name="internalFormat"/> parameter is <see cref="Gl.SRGB"/>, <see cref="Gl.SRGB8"/>, <see 
		/// cref="Gl.SRGB_ALPHA"/>,<see cref="Gl.SRGB8_ALPHA8"/>, <see cref="Gl.SLUMINANCE"/>, <see cref="Gl.SLUMINANCE8"/>, <see 
		/// cref="Gl.SLUMINANCE_ALPHA"/>,or <see cref="Gl.SLUMINANCE8_ALPHA8"/>, the texture is treated as if the red, green, blue, 
		/// orluminance components are encoded in the sRGB color space. Any alpha component is left unchanged. The conversion from 
		/// thesRGB encoded component cs to a linear component cl is: 
		/// cl={cs12.92ifcs≤0.04045(cs+0.0551.055)2.4ifcs&gt;0.04045 
		/// Assume cs is the sRGB component in the range [0,1]. 
		/// Use the <see cref="Gl.PROXY_TEXTURE_1D"/> target to try out a resolution and format. The implementation will update and 
		/// recomputeits best match for the requested storage resolution and format. To then query this state, call 
		/// Gl.GetTexLevelParameter.If the texture cannot be accommodated, texture state is set to 0. 
		/// A one-component texture image uses only the red component of the RGBA color from <paramref name="data"/>. A 
		/// two-componentimage uses the R and A values. A three-component image uses the R, G, and B values. A four-component image 
		/// usesall of the RGBA components. 
		/// Depth textures can be treated as LUMINANCE, INTENSITY or ALPHA textures during texture filtering and 
		/// application. Image-basedshadowing can be enabled by comparing texture r coordinates to depth texture values to generate 
		/// aboolean result. See Gl.TexParameter for details on texture comparison. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.TEXTURE_1D"/> or <see 
		///   cref="Gl.PROXY_TEXTURE_1D"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not an accepted format constant. Format 
		///   constantsother than <see cref="Gl.STENCIL_INDEX"/> are accepted. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not a type constant. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is <see cref="Gl.BITMAP"/> and <paramref 
		///   name="format"/>is not <see cref="Gl.COLOR_INDEX"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0. 
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the 
		///   returnedvalue of <see cref="Gl.MAX_TEXTURE_SIZE"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="internalFormat"/> is not 1, 2, 3, 4, or one of the 
		///   acceptedresolution and format symbolic constants. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than 0 or greater than 2 + <see 
		///   cref="Gl.MAX_TEXTURE_SIZE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if non-power-of-two textures are not supported and the <paramref 
		///   name="width"/>cannot be represented as 2n+2⁡border for some integer value of n. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="border"/> is not 0 or 1. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>,<see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or <see 
		///   cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>and <paramref name="format"/> is not <see cref="Gl.RGB"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, 
		///   <seecref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, <see 
		///   cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>,<see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is <see cref="Gl.DEPTH_COMPONENT"/> and 
		///   <paramrefname="internalFormat"/> is not <see cref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.DEPTH_COMPONENT16"/>, <see 
		///   cref="Gl.DEPTH_COMPONENT24"/>,or <see cref="Gl.DEPTH_COMPONENT32"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="internalFormat"/> is <see 
		///   cref="Gl.DEPTH_COMPONENT"/>,<see cref="Gl.DEPTH_COMPONENT16"/>, <see cref="Gl.DEPTH_COMPONENT24"/>, or <see 
		///   cref="Gl.DEPTH_COMPONENT32"/>,and <paramref name="format"/> is not <see cref="Gl.DEPTH_COMPONENT"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the data would be unpacked from the buffer object such that the memory reads 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   neededto store in memory a datum indicated by <paramref name="type"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexImage1D"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexImage 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_1D"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void TexImage1D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexImage1D != null, "pglTexImage1D not implemented");
			Delegates.pglTexImage1D((int)target, level, internalformat, width, border, (int)format, (int)type, pixels);
			CallLog("glTexImage1D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, internalformat, width, border, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a one-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_1D"/> or <see cref="Gl.PROXY_TEXTURE_1D"/>. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images 
		/// thatare at least 64 texels wide. The height of the 1D texture image is 1. 
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.RED"/>,<see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>,<see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: <see cref="Gl.UNSIGNED_BYTE"/>, 
		/// <seecref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>,<see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>,<see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <seecref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>,<see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <seecref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enableand disable one-dimensional texturing, call Gl.Enable and Gl.Disable with argument <see cref="Gl.TEXTURE_1D"/>. 
		/// Texture images are defined with <see cref="Gl.TexImage1D"/>. The arguments describe the parameters of the texture image, 
		/// suchas width, width of the border, level-of-detail number (see Gl.TexParameter), and the internal resolution and format 
		/// usedto store the image. The last three arguments describe how the image is represented in memory; they are identical to 
		/// thepixel formats used for Gl.DrawPixels. 
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_TEXTURE_1D"/>, no data is read from <paramref name="data"/>, but all 
		/// ofthe texture image state is recalculated, checked for consistency, and checked against the implementation's 
		/// capabilities.If the implementation cannot handle a texture of the requested texture size, it sets all of the image state 
		/// to0, but does not generate an error (see Gl.GetError). To query for an entire mipmap array, use an image array level 
		/// greaterthan or equal to 1. 
		/// If <paramref name="target"/> is <see cref="Gl.TEXTURE_1D"/>, data is read from <paramref name="data"/> as a sequence of 
		/// signedor unsigned bytes, shorts, or longs, or single-precision floating-point values, depending on <paramref 
		/// name="type"/>.These values are grouped into sets of one, two, three, or four values, depending on <paramref 
		/// name="format"/>,to form elements. If <paramref name="type"/> is <see cref="Gl.BITMAP"/>, the data is considered as a 
		/// stringof unsigned bytes (and <paramref name="format"/> must be <see cref="Gl.COLOR_INDEX"/>). Each data byte is treated 
		/// aseight 1-bit elements, with bit ordering determined by <see cref="Gl.UNPACK_LSB_FIRST"/> (see Gl.PixelStore). 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// atexture image is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store. 
		/// The first element corresponds to the left end of the texture array. Subsequent elements progress left-to-right through 
		/// theremaining texels in the texture array. The final element corresponds to the right end of the texture array. 
		/// <paramref name="format"/> determines the composition of each element in <paramref name="data"/>. It can assume one of 
		/// thesesymbolic values: 
		/// Refer to the Gl.DrawPixels reference page for a description of the acceptable values for the <paramref name="type"/> 
		/// parameter.
		/// If an application wants to store the texture at a certain resolution or in a certain format, it can request the 
		/// resolutionand format with <paramref name="internalFormat"/>. The GL will choose an internal representation that closely 
		/// approximatesthat requested by <paramref name="internalFormat"/>, but it may not match exactly. (The representations 
		/// specifiedby <see cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.RGB"/>, and <see 
		/// cref="Gl.RGBA"/>must match exactly. The numeric values 1, 2, 3, and 4 may also be used to specify the above 
		/// representations.)
		/// If the <paramref name="internalFormat"/> parameter is one of the generic compressed formats, <see 
		/// cref="Gl.COMPRESSED_ALPHA"/>,<see cref="Gl.COMPRESSED_INTENSITY"/>, <see cref="Gl.COMPRESSED_LUMINANCE"/>, <see 
		/// cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>,<see cref="Gl.COMPRESSED_RGB"/>, or <see cref="Gl.COMPRESSED_RGBA"/>, the GL will 
		/// replacethe internal format with the symbolic constant for a specific internal format and compress the texture before 
		/// storage.If no corresponding internal format is available, or the GL can not compress that image for any reason, the 
		/// internalformat is instead replaced with a corresponding base internal format. 
		/// If the <paramref name="internalFormat"/> parameter is <see cref="Gl.SRGB"/>, <see cref="Gl.SRGB8"/>, <see 
		/// cref="Gl.SRGB_ALPHA"/>,<see cref="Gl.SRGB8_ALPHA8"/>, <see cref="Gl.SLUMINANCE"/>, <see cref="Gl.SLUMINANCE8"/>, <see 
		/// cref="Gl.SLUMINANCE_ALPHA"/>,or <see cref="Gl.SLUMINANCE8_ALPHA8"/>, the texture is treated as if the red, green, blue, 
		/// orluminance components are encoded in the sRGB color space. Any alpha component is left unchanged. The conversion from 
		/// thesRGB encoded component cs to a linear component cl is: 
		/// cl={cs12.92ifcs≤0.04045(cs+0.0551.055)2.4ifcs&gt;0.04045 
		/// Assume cs is the sRGB component in the range [0,1]. 
		/// Use the <see cref="Gl.PROXY_TEXTURE_1D"/> target to try out a resolution and format. The implementation will update and 
		/// recomputeits best match for the requested storage resolution and format. To then query this state, call 
		/// Gl.GetTexLevelParameter.If the texture cannot be accommodated, texture state is set to 0. 
		/// A one-component texture image uses only the red component of the RGBA color from <paramref name="data"/>. A 
		/// two-componentimage uses the R and A values. A three-component image uses the R, G, and B values. A four-component image 
		/// usesall of the RGBA components. 
		/// Depth textures can be treated as LUMINANCE, INTENSITY or ALPHA textures during texture filtering and 
		/// application. Image-basedshadowing can be enabled by comparing texture r coordinates to depth texture values to generate 
		/// aboolean result. See Gl.TexParameter for details on texture comparison. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.TEXTURE_1D"/> or <see 
		///   cref="Gl.PROXY_TEXTURE_1D"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> is not an accepted format constant. Format 
		///   constantsother than <see cref="Gl.STENCIL_INDEX"/> are accepted. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not a type constant. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is <see cref="Gl.BITMAP"/> and <paramref 
		///   name="format"/>is not <see cref="Gl.COLOR_INDEX"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0. 
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the 
		///   returnedvalue of <see cref="Gl.MAX_TEXTURE_SIZE"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="internalFormat"/> is not 1, 2, 3, 4, or one of the 
		///   acceptedresolution and format symbolic constants. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> is less than 0 or greater than 2 + <see 
		///   cref="Gl.MAX_TEXTURE_SIZE"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if non-power-of-two textures are not supported and the <paramref 
		///   name="width"/>cannot be represented as 2n+2⁡border for some integer value of n. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="border"/> is not 0 or 1. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>,<see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or <see 
		///   cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>and <paramref name="format"/> is not <see cref="Gl.RGB"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, 
		///   <seecref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, <see 
		///   cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>,<see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is <see cref="Gl.DEPTH_COMPONENT"/> and 
		///   <paramrefname="internalFormat"/> is not <see cref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.DEPTH_COMPONENT16"/>, <see 
		///   cref="Gl.DEPTH_COMPONENT24"/>,or <see cref="Gl.DEPTH_COMPONENT32"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="internalFormat"/> is <see 
		///   cref="Gl.DEPTH_COMPONENT"/>,<see cref="Gl.DEPTH_COMPONENT16"/>, <see cref="Gl.DEPTH_COMPONENT24"/>, or <see 
		///   cref="Gl.DEPTH_COMPONENT32"/>,and <paramref name="format"/> is not <see cref="Gl.DEPTH_COMPONENT"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the data would be unpacked from the buffer object such that the memory reads 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   neededto store in memory a datum indicated by <paramref name="type"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexImage1D"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexImage 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_1D"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void TexImage1D(int target, Int32 level, Int32 internalformat, Int32 width, Int32 border, int format, int type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexImage1D(target, level, internalformat, width, border, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// specify a two-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_2D"/>, <see cref="Gl.PROXY_TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>, or <see 
		/// cref="Gl.PROXY_TEXTURE_CUBE_MAP"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images 
		/// thatare at least 64 texels wide. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2m+2⁡border for some integer m. All implementations support texture images 
		/// thatare at least 64 texels high. 
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.RED"/>,<see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>,<see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: <see cref="Gl.UNSIGNED_BYTE"/>, 
		/// <seecref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>,<see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>,<see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <seecref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>,<see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <seecref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enableand disable two-dimensional texturing, call Gl.Enable and Gl.Disable with argument <see cref="Gl.TEXTURE_2D"/>. To 
		/// enableand disable texturing using cube-mapped texture, call Gl.Enable and Gl.Disable with argument <see 
		/// cref="Gl.TEXTURE_CUBE_MAP"/>.
		/// To define texture images, call <see cref="Gl.TexImage2D"/>. The arguments describe the parameters of the texture image, 
		/// suchas height, width, width of the border, level-of-detail number (see Gl.TexParameter), and number of color components 
		/// provided.The last three arguments describe how the image is represented in memory; they are identical to the pixel 
		/// formatsused for Gl.DrawPixels. 
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_TEXTURE_2D"/> or <see cref="Gl.PROXY_TEXTURE_CUBE_MAP"/>, no data is 
		/// readfrom <paramref name="data"/>, but all of the texture image state is recalculated, checked for consistency, and 
		/// checkedagainst the implementation's capabilities. If the implementation cannot handle a texture of the requested texture 
		/// size,it sets all of the image state to 0, but does not generate an error (see Gl.GetError). To query for an entire 
		/// mipmaparray, use an image array level greater than or equal to 1. 
		/// If <paramref name="target"/> is <see cref="Gl.TEXTURE_2D"/>, or one of the <see cref="Gl.TEXTURE_CUBE_MAP"/> targets, 
		/// datais read from <paramref name="data"/> as a sequence of signed or unsigned bytes, shorts, or longs, or 
		/// single-precisionfloating-point values, depending on <paramref name="type"/>. These values are grouped into sets of one, 
		/// two,three, or four values, depending on <paramref name="format"/>, to form elements. If <paramref name="type"/> is <see 
		/// cref="Gl.BITMAP"/>,the data is considered as a string of unsigned bytes (and <paramref name="format"/> must be <see 
		/// cref="Gl.COLOR_INDEX"/>).Each data byte is treated as eight 1-bit elements, with bit ordering determined by <see 
		/// cref="Gl.UNPACK_LSB_FIRST"/>(see Gl.PixelStore). 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// atexture image is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store. 
		/// The first element corresponds to the lower left corner of the texture image. Subsequent elements progress left-to-right 
		/// throughthe remaining texels in the lowest row of the texture image, and then in successively higher rows of the texture 
		/// image.The final element corresponds to the upper right corner of the texture image. 
		/// <paramref name="format"/> determines the composition of each element in <paramref name="data"/>. It can assume one of 
		/// thesesymbolic values: 
		/// Refer to the Gl.DrawPixels reference page for a description of the acceptable values for the <paramref name="type"/> 
		/// parameter.
		/// If an application wants to store the texture at a certain resolution or in a certain format, it can request the 
		/// resolutionand format with <paramref name="internalFormat"/>. The GL will choose an internal representation that closely 
		/// approximatesthat requested by <paramref name="internalFormat"/>, but it may not match exactly. (The representations 
		/// specifiedby <see cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.RGB"/>, and <see 
		/// cref="Gl.RGBA"/>must match exactly. The numeric values 1, 2, 3, and 4 may also be used to specify the above 
		/// representations.)
		/// If the <paramref name="internalFormat"/> parameter is one of the generic compressed formats, <see 
		/// cref="Gl.COMPRESSED_ALPHA"/>,<see cref="Gl.COMPRESSED_INTENSITY"/>, <see cref="Gl.COMPRESSED_LUMINANCE"/>, <see 
		/// cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>,<see cref="Gl.COMPRESSED_RGB"/>, or <see cref="Gl.COMPRESSED_RGBA"/>, the GL will 
		/// replacethe internal format with the symbolic constant for a specific internal format and compress the texture before 
		/// storage.If no corresponding internal format is available, or the GL can not compress that image for any reason, the 
		/// internalformat is instead replaced with a corresponding base internal format. 
		/// If the <paramref name="internalFormat"/> parameter is <see cref="Gl.SRGB"/>, <see cref="Gl.SRGB8"/>, <see 
		/// cref="Gl.SRGB_ALPHA"/>,<see cref="Gl.SRGB8_ALPHA8"/>, <see cref="Gl.SLUMINANCE"/>, <see cref="Gl.SLUMINANCE8"/>, <see 
		/// cref="Gl.SLUMINANCE_ALPHA"/>,or <see cref="Gl.SLUMINANCE8_ALPHA8"/>, the texture is treated as if the red, green, blue, 
		/// orluminance components are encoded in the sRGB color space. Any alpha component is left unchanged. The conversion from 
		/// thesRGB encoded component cs to a linear component cl is: 
		/// cl={cs12.92ifcs≤0.04045(cs+0.0551.055)2.4ifcs&gt;0.04045 
		/// Assume cs is the sRGB component in the range [0,1]. 
		/// Use the <see cref="Gl.PROXY_TEXTURE_2D"/> or <see cref="Gl.PROXY_TEXTURE_CUBE_MAP"/> target to try out a resolution and 
		/// format.The implementation will update and recompute its best match for the requested storage resolution and format. To 
		/// thenquery this state, call Gl.GetTexLevelParameter. If the texture cannot be accommodated, texture state is set to 0. 
		/// A one-component texture image uses only the red component of the RGBA color extracted from <paramref name="data"/>. A 
		/// two-componentimage uses the R and A values. A three-component image uses the R, G, and B values. A four-component image 
		/// usesall of the RGBA components. 
		/// Depth textures can be treated as LUMINANCE, INTENSITY or ALPHA textures during texture filtering and 
		/// application. Image-basedshadowing can be enabled by comparing texture r coordinates to depth texture values to generate 
		/// aboolean result. See Gl.TexParameter for details on texture comparison. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.TEXTURE_2D"/>, <see 
		///   cref="Gl.PROXY_TEXTURE_2D"/>,<see cref="Gl.PROXY_TEXTURE_CUBE_MAP"/>, <see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>, <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>,<see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>, <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>,<see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>, or <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is one of the six cube map 2D image targets and 
		///   thewidth and height parameters are not equal. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not a type constant. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is <see cref="Gl.BITMAP"/> and <paramref 
		///   name="format"/>is not <see cref="Gl.COLOR_INDEX"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> or <paramref name="height"/> is less than 0 or 
		///   greaterthan 2 + <see cref="Gl.MAX_TEXTURE_SIZE"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0. 
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the 
		///   returnedvalue of <see cref="Gl.MAX_TEXTURE_SIZE"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="internalFormat"/> is not 1, 2, 3, 4, or one of the 
		///   acceptedresolution and format symbolic constants. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> or <paramref name="height"/> is less than 0 or 
		///   greaterthan 2 + <see cref="Gl.MAX_TEXTURE_SIZE"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if non-power-of-two textures are not supported and the <paramref 
		///   name="width"/>or <paramref name="height"/> cannot be represented as 2k+2⁡border for some integer value of k. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="border"/> is not 0 or 1. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>,<see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or <see 
		///   cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>and <paramref name="format"/> is not <see cref="Gl.RGB"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, 
		///   <seecref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, <see 
		///   cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>,<see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="target"/> is not <see cref="Gl.TEXTURE_2D"/> or <see 
		///   cref="Gl.PROXY_TEXTURE_2D"/>and <paramref name="internalFormat"/> is <see cref="Gl.DEPTH_COMPONENT"/>, <see 
		///   cref="Gl.DEPTH_COMPONENT16"/>,<see cref="Gl.DEPTH_COMPONENT24"/>, or <see cref="Gl.DEPTH_COMPONENT32"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is <see cref="Gl.DEPTH_COMPONENT"/> and 
		///   <paramrefname="internalFormat"/> is not <see cref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.DEPTH_COMPONENT16"/>, <see 
		///   cref="Gl.DEPTH_COMPONENT24"/>,or <see cref="Gl.DEPTH_COMPONENT32"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="internalFormat"/> is <see 
		///   cref="Gl.DEPTH_COMPONENT"/>,<see cref="Gl.DEPTH_COMPONENT16"/>, <see cref="Gl.DEPTH_COMPONENT24"/>, or <see 
		///   cref="Gl.DEPTH_COMPONENT32"/>,and <paramref name="format"/> is not <see cref="Gl.DEPTH_COMPONENT"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the data would be unpacked from the buffer object such that the memory reads 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   neededto store in memory a datum indicated by <paramref name="type"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexImage2D"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexImage 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_2D"/> or <see cref="Gl.TEXTURE_CUBE_MAP"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void TexImage2D(int target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, int format, int type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexImage2D != null, "pglTexImage2D not implemented");
			Delegates.pglTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
			CallLog("glTexImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, internalformat, width, height, border, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a two-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_2D"/>, <see cref="Gl.PROXY_TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>, or <see 
		/// cref="Gl.PROXY_TEXTURE_CUBE_MAP"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images 
		/// thatare at least 64 texels wide. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2m+2⁡border for some integer m. All implementations support texture images 
		/// thatare at least 64 texels high. 
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.RED"/>,<see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>,<see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: <see cref="Gl.UNSIGNED_BYTE"/>, 
		/// <seecref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>,<see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>,<see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <seecref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>,<see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <seecref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enableand disable two-dimensional texturing, call Gl.Enable and Gl.Disable with argument <see cref="Gl.TEXTURE_2D"/>. To 
		/// enableand disable texturing using cube-mapped texture, call Gl.Enable and Gl.Disable with argument <see 
		/// cref="Gl.TEXTURE_CUBE_MAP"/>.
		/// To define texture images, call <see cref="Gl.TexImage2D"/>. The arguments describe the parameters of the texture image, 
		/// suchas height, width, width of the border, level-of-detail number (see Gl.TexParameter), and number of color components 
		/// provided.The last three arguments describe how the image is represented in memory; they are identical to the pixel 
		/// formatsused for Gl.DrawPixels. 
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_TEXTURE_2D"/> or <see cref="Gl.PROXY_TEXTURE_CUBE_MAP"/>, no data is 
		/// readfrom <paramref name="data"/>, but all of the texture image state is recalculated, checked for consistency, and 
		/// checkedagainst the implementation's capabilities. If the implementation cannot handle a texture of the requested texture 
		/// size,it sets all of the image state to 0, but does not generate an error (see Gl.GetError). To query for an entire 
		/// mipmaparray, use an image array level greater than or equal to 1. 
		/// If <paramref name="target"/> is <see cref="Gl.TEXTURE_2D"/>, or one of the <see cref="Gl.TEXTURE_CUBE_MAP"/> targets, 
		/// datais read from <paramref name="data"/> as a sequence of signed or unsigned bytes, shorts, or longs, or 
		/// single-precisionfloating-point values, depending on <paramref name="type"/>. These values are grouped into sets of one, 
		/// two,three, or four values, depending on <paramref name="format"/>, to form elements. If <paramref name="type"/> is <see 
		/// cref="Gl.BITMAP"/>,the data is considered as a string of unsigned bytes (and <paramref name="format"/> must be <see 
		/// cref="Gl.COLOR_INDEX"/>).Each data byte is treated as eight 1-bit elements, with bit ordering determined by <see 
		/// cref="Gl.UNPACK_LSB_FIRST"/>(see Gl.PixelStore). 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// atexture image is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store. 
		/// The first element corresponds to the lower left corner of the texture image. Subsequent elements progress left-to-right 
		/// throughthe remaining texels in the lowest row of the texture image, and then in successively higher rows of the texture 
		/// image.The final element corresponds to the upper right corner of the texture image. 
		/// <paramref name="format"/> determines the composition of each element in <paramref name="data"/>. It can assume one of 
		/// thesesymbolic values: 
		/// Refer to the Gl.DrawPixels reference page for a description of the acceptable values for the <paramref name="type"/> 
		/// parameter.
		/// If an application wants to store the texture at a certain resolution or in a certain format, it can request the 
		/// resolutionand format with <paramref name="internalFormat"/>. The GL will choose an internal representation that closely 
		/// approximatesthat requested by <paramref name="internalFormat"/>, but it may not match exactly. (The representations 
		/// specifiedby <see cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.RGB"/>, and <see 
		/// cref="Gl.RGBA"/>must match exactly. The numeric values 1, 2, 3, and 4 may also be used to specify the above 
		/// representations.)
		/// If the <paramref name="internalFormat"/> parameter is one of the generic compressed formats, <see 
		/// cref="Gl.COMPRESSED_ALPHA"/>,<see cref="Gl.COMPRESSED_INTENSITY"/>, <see cref="Gl.COMPRESSED_LUMINANCE"/>, <see 
		/// cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>,<see cref="Gl.COMPRESSED_RGB"/>, or <see cref="Gl.COMPRESSED_RGBA"/>, the GL will 
		/// replacethe internal format with the symbolic constant for a specific internal format and compress the texture before 
		/// storage.If no corresponding internal format is available, or the GL can not compress that image for any reason, the 
		/// internalformat is instead replaced with a corresponding base internal format. 
		/// If the <paramref name="internalFormat"/> parameter is <see cref="Gl.SRGB"/>, <see cref="Gl.SRGB8"/>, <see 
		/// cref="Gl.SRGB_ALPHA"/>,<see cref="Gl.SRGB8_ALPHA8"/>, <see cref="Gl.SLUMINANCE"/>, <see cref="Gl.SLUMINANCE8"/>, <see 
		/// cref="Gl.SLUMINANCE_ALPHA"/>,or <see cref="Gl.SLUMINANCE8_ALPHA8"/>, the texture is treated as if the red, green, blue, 
		/// orluminance components are encoded in the sRGB color space. Any alpha component is left unchanged. The conversion from 
		/// thesRGB encoded component cs to a linear component cl is: 
		/// cl={cs12.92ifcs≤0.04045(cs+0.0551.055)2.4ifcs&gt;0.04045 
		/// Assume cs is the sRGB component in the range [0,1]. 
		/// Use the <see cref="Gl.PROXY_TEXTURE_2D"/> or <see cref="Gl.PROXY_TEXTURE_CUBE_MAP"/> target to try out a resolution and 
		/// format.The implementation will update and recompute its best match for the requested storage resolution and format. To 
		/// thenquery this state, call Gl.GetTexLevelParameter. If the texture cannot be accommodated, texture state is set to 0. 
		/// A one-component texture image uses only the red component of the RGBA color extracted from <paramref name="data"/>. A 
		/// two-componentimage uses the R and A values. A three-component image uses the R, G, and B values. A four-component image 
		/// usesall of the RGBA components. 
		/// Depth textures can be treated as LUMINANCE, INTENSITY or ALPHA textures during texture filtering and 
		/// application. Image-basedshadowing can be enabled by comparing texture r coordinates to depth texture values to generate 
		/// aboolean result. See Gl.TexParameter for details on texture comparison. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.TEXTURE_2D"/>, <see 
		///   cref="Gl.PROXY_TEXTURE_2D"/>,<see cref="Gl.PROXY_TEXTURE_CUBE_MAP"/>, <see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>, <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>,<see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>, <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>,<see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>, or <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is one of the six cube map 2D image targets and 
		///   thewidth and height parameters are not equal. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not a type constant. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is <see cref="Gl.BITMAP"/> and <paramref 
		///   name="format"/>is not <see cref="Gl.COLOR_INDEX"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> or <paramref name="height"/> is less than 0 or 
		///   greaterthan 2 + <see cref="Gl.MAX_TEXTURE_SIZE"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0. 
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the 
		///   returnedvalue of <see cref="Gl.MAX_TEXTURE_SIZE"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="internalFormat"/> is not 1, 2, 3, 4, or one of the 
		///   acceptedresolution and format symbolic constants. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> or <paramref name="height"/> is less than 0 or 
		///   greaterthan 2 + <see cref="Gl.MAX_TEXTURE_SIZE"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if non-power-of-two textures are not supported and the <paramref 
		///   name="width"/>or <paramref name="height"/> cannot be represented as 2k+2⁡border for some integer value of k. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="border"/> is not 0 or 1. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>,<see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or <see 
		///   cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>and <paramref name="format"/> is not <see cref="Gl.RGB"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, 
		///   <seecref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, <see 
		///   cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>,<see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="target"/> is not <see cref="Gl.TEXTURE_2D"/> or <see 
		///   cref="Gl.PROXY_TEXTURE_2D"/>and <paramref name="internalFormat"/> is <see cref="Gl.DEPTH_COMPONENT"/>, <see 
		///   cref="Gl.DEPTH_COMPONENT16"/>,<see cref="Gl.DEPTH_COMPONENT24"/>, or <see cref="Gl.DEPTH_COMPONENT32"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is <see cref="Gl.DEPTH_COMPONENT"/> and 
		///   <paramrefname="internalFormat"/> is not <see cref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.DEPTH_COMPONENT16"/>, <see 
		///   cref="Gl.DEPTH_COMPONENT24"/>,or <see cref="Gl.DEPTH_COMPONENT32"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="internalFormat"/> is <see 
		///   cref="Gl.DEPTH_COMPONENT"/>,<see cref="Gl.DEPTH_COMPONENT16"/>, <see cref="Gl.DEPTH_COMPONENT24"/>, or <see 
		///   cref="Gl.DEPTH_COMPONENT32"/>,and <paramref name="format"/> is not <see cref="Gl.DEPTH_COMPONENT"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the data would be unpacked from the buffer object such that the memory reads 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   neededto store in memory a datum indicated by <paramref name="type"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexImage2D"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexImage 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_2D"/> or <see cref="Gl.TEXTURE_CUBE_MAP"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void TexImage2D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexImage2D != null, "pglTexImage2D not implemented");
			Delegates.pglTexImage2D((int)target, level, internalformat, width, height, border, (int)format, (int)type, pixels);
			CallLog("glTexImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, internalformat, width, height, border, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a two-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_2D"/>, <see cref="Gl.PROXY_TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>, or <see 
		/// cref="Gl.PROXY_TEXTURE_CUBE_MAP"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images 
		/// thatare at least 64 texels wide. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2m+2⁡border for some integer m. All implementations support texture images 
		/// thatare at least 64 texels high. 
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.RED"/>,<see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>,<see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: <see cref="Gl.UNSIGNED_BYTE"/>, 
		/// <seecref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>,<see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>,<see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <seecref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>,<see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <seecref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enableand disable two-dimensional texturing, call Gl.Enable and Gl.Disable with argument <see cref="Gl.TEXTURE_2D"/>. To 
		/// enableand disable texturing using cube-mapped texture, call Gl.Enable and Gl.Disable with argument <see 
		/// cref="Gl.TEXTURE_CUBE_MAP"/>.
		/// To define texture images, call <see cref="Gl.TexImage2D"/>. The arguments describe the parameters of the texture image, 
		/// suchas height, width, width of the border, level-of-detail number (see Gl.TexParameter), and number of color components 
		/// provided.The last three arguments describe how the image is represented in memory; they are identical to the pixel 
		/// formatsused for Gl.DrawPixels. 
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_TEXTURE_2D"/> or <see cref="Gl.PROXY_TEXTURE_CUBE_MAP"/>, no data is 
		/// readfrom <paramref name="data"/>, but all of the texture image state is recalculated, checked for consistency, and 
		/// checkedagainst the implementation's capabilities. If the implementation cannot handle a texture of the requested texture 
		/// size,it sets all of the image state to 0, but does not generate an error (see Gl.GetError). To query for an entire 
		/// mipmaparray, use an image array level greater than or equal to 1. 
		/// If <paramref name="target"/> is <see cref="Gl.TEXTURE_2D"/>, or one of the <see cref="Gl.TEXTURE_CUBE_MAP"/> targets, 
		/// datais read from <paramref name="data"/> as a sequence of signed or unsigned bytes, shorts, or longs, or 
		/// single-precisionfloating-point values, depending on <paramref name="type"/>. These values are grouped into sets of one, 
		/// two,three, or four values, depending on <paramref name="format"/>, to form elements. If <paramref name="type"/> is <see 
		/// cref="Gl.BITMAP"/>,the data is considered as a string of unsigned bytes (and <paramref name="format"/> must be <see 
		/// cref="Gl.COLOR_INDEX"/>).Each data byte is treated as eight 1-bit elements, with bit ordering determined by <see 
		/// cref="Gl.UNPACK_LSB_FIRST"/>(see Gl.PixelStore). 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// atexture image is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store. 
		/// The first element corresponds to the lower left corner of the texture image. Subsequent elements progress left-to-right 
		/// throughthe remaining texels in the lowest row of the texture image, and then in successively higher rows of the texture 
		/// image.The final element corresponds to the upper right corner of the texture image. 
		/// <paramref name="format"/> determines the composition of each element in <paramref name="data"/>. It can assume one of 
		/// thesesymbolic values: 
		/// Refer to the Gl.DrawPixels reference page for a description of the acceptable values for the <paramref name="type"/> 
		/// parameter.
		/// If an application wants to store the texture at a certain resolution or in a certain format, it can request the 
		/// resolutionand format with <paramref name="internalFormat"/>. The GL will choose an internal representation that closely 
		/// approximatesthat requested by <paramref name="internalFormat"/>, but it may not match exactly. (The representations 
		/// specifiedby <see cref="Gl.LUMINANCE"/>, <see cref="Gl.LUMINANCE_ALPHA"/>, <see cref="Gl.RGB"/>, and <see 
		/// cref="Gl.RGBA"/>must match exactly. The numeric values 1, 2, 3, and 4 may also be used to specify the above 
		/// representations.)
		/// If the <paramref name="internalFormat"/> parameter is one of the generic compressed formats, <see 
		/// cref="Gl.COMPRESSED_ALPHA"/>,<see cref="Gl.COMPRESSED_INTENSITY"/>, <see cref="Gl.COMPRESSED_LUMINANCE"/>, <see 
		/// cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>,<see cref="Gl.COMPRESSED_RGB"/>, or <see cref="Gl.COMPRESSED_RGBA"/>, the GL will 
		/// replacethe internal format with the symbolic constant for a specific internal format and compress the texture before 
		/// storage.If no corresponding internal format is available, or the GL can not compress that image for any reason, the 
		/// internalformat is instead replaced with a corresponding base internal format. 
		/// If the <paramref name="internalFormat"/> parameter is <see cref="Gl.SRGB"/>, <see cref="Gl.SRGB8"/>, <see 
		/// cref="Gl.SRGB_ALPHA"/>,<see cref="Gl.SRGB8_ALPHA8"/>, <see cref="Gl.SLUMINANCE"/>, <see cref="Gl.SLUMINANCE8"/>, <see 
		/// cref="Gl.SLUMINANCE_ALPHA"/>,or <see cref="Gl.SLUMINANCE8_ALPHA8"/>, the texture is treated as if the red, green, blue, 
		/// orluminance components are encoded in the sRGB color space. Any alpha component is left unchanged. The conversion from 
		/// thesRGB encoded component cs to a linear component cl is: 
		/// cl={cs12.92ifcs≤0.04045(cs+0.0551.055)2.4ifcs&gt;0.04045 
		/// Assume cs is the sRGB component in the range [0,1]. 
		/// Use the <see cref="Gl.PROXY_TEXTURE_2D"/> or <see cref="Gl.PROXY_TEXTURE_CUBE_MAP"/> target to try out a resolution and 
		/// format.The implementation will update and recompute its best match for the requested storage resolution and format. To 
		/// thenquery this state, call Gl.GetTexLevelParameter. If the texture cannot be accommodated, texture state is set to 0. 
		/// A one-component texture image uses only the red component of the RGBA color extracted from <paramref name="data"/>. A 
		/// two-componentimage uses the R and A values. A three-component image uses the R, G, and B values. A four-component image 
		/// usesall of the RGBA components. 
		/// Depth textures can be treated as LUMINANCE, INTENSITY or ALPHA textures during texture filtering and 
		/// application. Image-basedshadowing can be enabled by comparing texture r coordinates to depth texture values to generate 
		/// aboolean result. See Gl.TexParameter for details on texture comparison. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not <see cref="Gl.TEXTURE_2D"/>, <see 
		///   cref="Gl.PROXY_TEXTURE_2D"/>,<see cref="Gl.PROXY_TEXTURE_CUBE_MAP"/>, <see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>, <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>,<see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>, <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>,<see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>, or <see 
		///   cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is one of the six cube map 2D image targets and 
		///   thewidth and height parameters are not equal. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not a type constant. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is <see cref="Gl.BITMAP"/> and <paramref 
		///   name="format"/>is not <see cref="Gl.COLOR_INDEX"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> or <paramref name="height"/> is less than 0 or 
		///   greaterthan 2 + <see cref="Gl.MAX_TEXTURE_SIZE"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0. 
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the 
		///   returnedvalue of <see cref="Gl.MAX_TEXTURE_SIZE"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="internalFormat"/> is not 1, 2, 3, 4, or one of the 
		///   acceptedresolution and format symbolic constants. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> or <paramref name="height"/> is less than 0 or 
		///   greaterthan 2 + <see cref="Gl.MAX_TEXTURE_SIZE"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if non-power-of-two textures are not supported and the <paramref 
		///   name="width"/>or <paramref name="height"/> cannot be represented as 2k+2⁡border for some integer value of k. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="border"/> is not 0 or 1. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>,<see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or <see 
		///   cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>and <paramref name="format"/> is not <see cref="Gl.RGB"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, 
		///   <seecref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, <see 
		///   cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>,<see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="target"/> is not <see cref="Gl.TEXTURE_2D"/> or <see 
		///   cref="Gl.PROXY_TEXTURE_2D"/>and <paramref name="internalFormat"/> is <see cref="Gl.DEPTH_COMPONENT"/>, <see 
		///   cref="Gl.DEPTH_COMPONENT16"/>,<see cref="Gl.DEPTH_COMPONENT24"/>, or <see cref="Gl.DEPTH_COMPONENT32"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is <see cref="Gl.DEPTH_COMPONENT"/> and 
		///   <paramrefname="internalFormat"/> is not <see cref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.DEPTH_COMPONENT16"/>, <see 
		///   cref="Gl.DEPTH_COMPONENT24"/>,or <see cref="Gl.DEPTH_COMPONENT32"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="internalFormat"/> is <see 
		///   cref="Gl.DEPTH_COMPONENT"/>,<see cref="Gl.DEPTH_COMPONENT16"/>, <see cref="Gl.DEPTH_COMPONENT24"/>, or <see 
		///   cref="Gl.DEPTH_COMPONENT32"/>,and <paramref name="format"/> is not <see cref="Gl.DEPTH_COMPONENT"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the data would be unpacked from the buffer object such that the memory reads 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   neededto store in memory a datum indicated by <paramref name="type"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexImage2D"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexImage 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_2D"/> or <see cref="Gl.TEXTURE_CUBE_MAP"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void TexImage2D(int target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, int format, int type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexImage2D(target, level, internalformat, width, height, border, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// specify which color buffers are to be drawn into
		/// </summary>
		/// <param name="buf">
		/// For default framebuffer, the argument specifies up to four color buffers to be drawn into. Symbolic constants GL_NONE, 
		/// GL_FRONT_LEFT,GL_FRONT_RIGHT, GL_BACK_LEFT, GL_BACK_RIGHT, GL_FRONT, GL_BACK, GL_LEFT, GL_RIGHT, and GL_FRONT_AND_BACK 
		/// areaccepted. The initial value is GL_FRONT for single-buffered contexts, and GL_BACK for double-buffered contexts. For 
		/// framebufferobjects, GL_COLOR_ATTACHMENT$m$ and GL_NONE enums are accepted, where $m$ is a value between 0 and 
		/// GL_MAX_COLOR_ATTACHMENTS.
		/// </param>
		/// <remarks>
		/// When colors are written to the frame buffer, they are written into the color buffers specified by glDrawBuffer. One of 
		/// thefollowing values can be used for default framebuffer: 
		/// If more than one color buffer is selected for drawing, then blending or logical operations are computed and applied 
		/// independentlyfor each color buffer and can produce different results in each buffer. 
		/// Monoscopic contexts include only left buffers, and stereoscopic contexts include both left and right buffers. Likewise, 
		/// single-bufferedcontexts include only front buffers, and double-buffered contexts include both front and back buffers. 
		/// Thecontext is selected at GL initialization. 
		/// For framebuffer objects, GL_COLOR_ATTACHMENT$m$ and GL_NONE enums are accepted, where $m$ is a value between 0 and 
		/// GL_MAX_COLOR_ATTACHMENTS.glDrawBuffer will set the draw buffer for fragment colors other than zero to GL_NONE. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION error is generated by glNamedFramebufferDrawBuffer if framebuffer is not zero or the name of an 
		///   existingframebuffer object. 
		/// - GL_INVALID_ENUM is generated if buf is not an accepted value. 
		/// - GL_INVALID_OPERATION is generated if the default framebuffer is affected and none of the buffers indicated by buf 
		///   exists.
		/// - GL_INVALID_OPERATION is generated if a framebuffer object is affected and buf is not equal to GL_NONE or 
		///   GL_COLOR_ATTACHMENT$m$,where $m$ is a value between 0 and GL_MAX_COLOR_ATTACHMENTS. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_DRAW_BUFFER 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DrawBuffers"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		public static void DrawBuffer(int buf)
		{
			Debug.Assert(Delegates.pglDrawBuffer != null, "pglDrawBuffer not implemented");
			Delegates.pglDrawBuffer(buf);
			CallLog("glDrawBuffer({0})", buf);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify which color buffers are to be drawn into
		/// </summary>
		/// <param name="buf">
		/// For default framebuffer, the argument specifies up to four color buffers to be drawn into. Symbolic constants GL_NONE, 
		/// GL_FRONT_LEFT,GL_FRONT_RIGHT, GL_BACK_LEFT, GL_BACK_RIGHT, GL_FRONT, GL_BACK, GL_LEFT, GL_RIGHT, and GL_FRONT_AND_BACK 
		/// areaccepted. The initial value is GL_FRONT for single-buffered contexts, and GL_BACK for double-buffered contexts. For 
		/// framebufferobjects, GL_COLOR_ATTACHMENT$m$ and GL_NONE enums are accepted, where $m$ is a value between 0 and 
		/// GL_MAX_COLOR_ATTACHMENTS.
		/// </param>
		/// <remarks>
		/// When colors are written to the frame buffer, they are written into the color buffers specified by glDrawBuffer. One of 
		/// thefollowing values can be used for default framebuffer: 
		/// If more than one color buffer is selected for drawing, then blending or logical operations are computed and applied 
		/// independentlyfor each color buffer and can produce different results in each buffer. 
		/// Monoscopic contexts include only left buffers, and stereoscopic contexts include both left and right buffers. Likewise, 
		/// single-bufferedcontexts include only front buffers, and double-buffered contexts include both front and back buffers. 
		/// Thecontext is selected at GL initialization. 
		/// For framebuffer objects, GL_COLOR_ATTACHMENT$m$ and GL_NONE enums are accepted, where $m$ is a value between 0 and 
		/// GL_MAX_COLOR_ATTACHMENTS.glDrawBuffer will set the draw buffer for fragment colors other than zero to GL_NONE. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION error is generated by glNamedFramebufferDrawBuffer if framebuffer is not zero or the name of an 
		///   existingframebuffer object. 
		/// - GL_INVALID_ENUM is generated if buf is not an accepted value. 
		/// - GL_INVALID_OPERATION is generated if the default framebuffer is affected and none of the buffers indicated by buf 
		///   exists.
		/// - GL_INVALID_OPERATION is generated if a framebuffer object is affected and buf is not equal to GL_NONE or 
		///   GL_COLOR_ATTACHMENT$m$,where $m$ is a value between 0 and GL_MAX_COLOR_ATTACHMENTS. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_DRAW_BUFFER 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DrawBuffers"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		public static void DrawBuffer(DrawBufferMode buf)
		{
			Debug.Assert(Delegates.pglDrawBuffer != null, "pglDrawBuffer not implemented");
			Delegates.pglDrawBuffer((int)buf);
			CallLog("glDrawBuffer({0})", buf);
			DebugCheckErrors();
		}

		/// <summary>
		/// clear buffers to preset values
		/// </summary>
		/// <param name="mask">
		/// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are GL_COLOR_BUFFER_BIT, 
		/// GL_DEPTH_BUFFER_BIT,and GL_STENCIL_BUFFER_BIT. 
		/// </param>
		/// <remarks>
		/// glClear sets the bitplane area of the window to values previously selected by glClearColor, glClearDepth, and 
		/// glClearStencil.Multiple color buffers can be cleared simultaneously by selecting more than one buffer at a time using 
		/// glDrawBuffer.
		/// The pixel ownership test, the scissor test, dithering, and the buffer writemasks affect the operation of glClear. The 
		/// scissorbox bounds the cleared region. Alpha function, blend function, logical operation, stenciling, texture mapping, 
		/// anddepth-buffering are ignored by glClear. 
		/// glClear takes a single argument that is the bitwise OR of several values indicating which buffer is to be cleared. 
		/// The values are as follows: 
		/// The value to which each buffer is cleared depends on the setting of the clear value for that buffer. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if any bit other than the three defined bits is set in mask. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_DEPTH_CLEAR_VALUE 
		/// - glGet with argument GL_COLOR_CLEAR_VALUE 
		/// - glGet with argument GL_STENCIL_CLEAR_VALUE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DepthMask"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.StencilMask"/>
		public static void Clear(uint mask)
		{
			Debug.Assert(Delegates.pglClear != null, "pglClear not implemented");
			Delegates.pglClear(mask);
			CallLog("glClear({0})", mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// clear buffers to preset values
		/// </summary>
		/// <param name="mask">
		/// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are GL_COLOR_BUFFER_BIT, 
		/// GL_DEPTH_BUFFER_BIT,and GL_STENCIL_BUFFER_BIT. 
		/// </param>
		/// <remarks>
		/// glClear sets the bitplane area of the window to values previously selected by glClearColor, glClearDepth, and 
		/// glClearStencil.Multiple color buffers can be cleared simultaneously by selecting more than one buffer at a time using 
		/// glDrawBuffer.
		/// The pixel ownership test, the scissor test, dithering, and the buffer writemasks affect the operation of glClear. The 
		/// scissorbox bounds the cleared region. Alpha function, blend function, logical operation, stenciling, texture mapping, 
		/// anddepth-buffering are ignored by glClear. 
		/// glClear takes a single argument that is the bitwise OR of several values indicating which buffer is to be cleared. 
		/// The values are as follows: 
		/// The value to which each buffer is cleared depends on the setting of the clear value for that buffer. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if any bit other than the three defined bits is set in mask. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_DEPTH_CLEAR_VALUE 
		/// - glGet with argument GL_COLOR_CLEAR_VALUE 
		/// - glGet with argument GL_STENCIL_CLEAR_VALUE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DepthMask"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.StencilMask"/>
		public static void Clear(ClearBufferMask mask)
		{
			Debug.Assert(Delegates.pglClear != null, "pglClear not implemented");
			Delegates.pglClear((uint)mask);
			CallLog("glClear({0})", mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify clear values for the color buffers
		/// </summary>
		/// <param name="red">
		/// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0. 
		/// </param>
		/// <param name="green">
		/// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0. 
		/// </param>
		/// <param name="blue">
		/// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0. 
		/// </param>
		/// <param name="alpha">
		/// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0. 
		/// </param>
		/// <remarks>
		/// glClearColor specifies the red, green, blue, and alpha values used by glClear to clear the color buffers. Values 
		/// specifiedby glClearColor are clamped to the range 01. 
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_COLOR_CLEAR_VALUE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.removedTypes"/>
		public static void ClearColor(float red, float green, float blue, float alpha)
		{
			Debug.Assert(Delegates.pglClearColor != null, "pglClearColor not implemented");
			Delegates.pglClearColor(red, green, blue, alpha);
			CallLog("glClearColor({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the clear value for the stencil buffer
		/// </summary>
		/// <param name="s">
		/// Specifies the index used when the stencil buffer is cleared. The initial value is 0. 
		/// </param>
		/// <remarks>
		/// glClearStencil specifies the index used by glClear to clear the stencil buffer. s is masked with 2m-1, where m is the 
		/// numberof bits in the stencil buffer. 
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_STENCIL_CLEAR_VALUE 
		/// - glGet with argument GL_STENCIL_BITS 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
		public static void ClearStencil(Int32 s)
		{
			Debug.Assert(Delegates.pglClearStencil != null, "pglClearStencil not implemented");
			Delegates.pglClearStencil(s);
			CallLog("glClearStencil({0})", s);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the clear value for the depth buffer
		/// </summary>
		/// <param name="depth">
		/// Specifies the depth value used when the depth buffer is cleared. The initial value is 1. 
		/// </param>
		/// <remarks>
		/// glClearDepth specifies the depth value used by glClear to clear the depth buffer. Values specified by glClearDepth are 
		/// clampedto the range 01. 
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_DEPTH_CLEAR_VALUE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.removedTypes"/>
		public static void ClearDepth(double depth)
		{
			Debug.Assert(Delegates.pglClearDepth != null, "pglClearDepth not implemented");
			Delegates.pglClearDepth(depth);
			CallLog("glClearDepth({0})", depth);
			DebugCheckErrors();
		}

		/// <summary>
		/// control the front and back writing of individual bits in the stencil planes
		/// </summary>
		/// <param name="mask">
		/// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 
		/// 1's.
		/// </param>
		/// <remarks>
		/// glStencilMask controls the writing of individual bits in the stencil planes. The least significant n bits of mask, where 
		/// nis the number of bits in the stencil buffer, specify a mask. Where a 1 appears in the mask, it's possible to write to 
		/// thecorresponding bit in the stencil buffer. Where a 0 appears, the corresponding bit is write-protected. Initially, all 
		/// bitsare enabled for writing. 
		/// There can be two separate mask writemasks; one affects back-facing polygons, and the other affects front-facing polygons 
		/// aswell as other non-polygon primitives. glStencilMask sets both front and back stencil writemasks to the same values. 
		/// UseglStencilMaskSeparate to set front and back stencil writemasks to different values. 
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_STENCIL_WRITEMASK, GL_STENCIL_BACK_WRITEMASK, or GL_STENCIL_BITS 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DepthMask"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
		public static void StencilMask(UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilMask != null, "pglStencilMask not implemented");
			Delegates.pglStencilMask(mask);
			CallLog("glStencilMask({0})", mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// enable and disable writing of frame buffer color components
		/// </summary>
		/// <param name="red">
		/// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, 
		/// indicatingthat the color components are written. 
		/// </param>
		/// <param name="green">
		/// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, 
		/// indicatingthat the color components are written. 
		/// </param>
		/// <param name="blue">
		/// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, 
		/// indicatingthat the color components are written. 
		/// </param>
		/// <param name="alpha">
		/// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, 
		/// indicatingthat the color components are written. 
		/// </param>
		/// <remarks>
		/// glColorMask and glColorMaski specify whether the individual color components in the frame buffer can or cannot be 
		/// written.glColorMaski sets the mask for a specific draw buffer, whereas glColorMask sets the mask for all draw buffers. 
		/// Ifred is GL_FALSE, for example, no change is made to the red component of any pixel in any of the color buffers, 
		/// regardlessof the drawing operation attempted. 
		/// Changes to individual bits of components cannot be controlled. Rather, changes are either enabled or disabled for entire 
		/// colorcomponents. 
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_COLOR_WRITEMASK 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.DepthMask"/>
		/// <seealso cref="Gl.StencilMask"/>
		public static void ColorMask(bool red, bool green, bool blue, bool alpha)
		{
			Debug.Assert(Delegates.pglColorMask != null, "pglColorMask not implemented");
			Delegates.pglColorMask(red, green, blue, alpha);
			CallLog("glColorMask({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// enable or disable writing into the depth buffer
		/// </summary>
		/// <param name="flag">
		/// Specifies whether the depth buffer is enabled for writing. If flag is GL_FALSE, depth buffer writing is disabled. 
		/// Otherwise,it is enabled. Initially, depth buffer writing is enabled. 
		/// </param>
		/// <remarks>
		/// glDepthMask specifies whether the depth buffer is enabled for writing. If flag is GL_FALSE, depth buffer writing is 
		/// disabled.Otherwise, it is enabled. Initially, depth buffer writing is enabled. 
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_DEPTH_WRITEMASK 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.DepthRange"/>
		/// <seealso cref="Gl.StencilMask"/>
		public static void DepthMask(bool flag)
		{
			Debug.Assert(Delegates.pglDepthMask != null, "pglDepthMask not implemented");
			Delegates.pglDepthMask(flag);
			CallLog("glDepthMask({0})", flag);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDisable.
		/// </summary>
		/// <param name="cap">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Disable(int cap)
		{
			Debug.Assert(Delegates.pglDisable != null, "pglDisable not implemented");
			Delegates.pglDisable(cap);
			CallLog("glDisable({0})", cap);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDisable.
		/// </summary>
		/// <param name="cap">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Disable(EnableCap cap)
		{
			Debug.Assert(Delegates.pglDisable != null, "pglDisable not implemented");
			Delegates.pglDisable((int)cap);
			CallLog("glDisable({0})", cap);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEnable.
		/// </summary>
		/// <param name="cap">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Enable(int cap)
		{
			Debug.Assert(Delegates.pglEnable != null, "pglEnable not implemented");
			Delegates.pglEnable(cap);
			CallLog("glEnable({0})", cap);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEnable.
		/// </summary>
		/// <param name="cap">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Enable(EnableCap cap)
		{
			Debug.Assert(Delegates.pglEnable != null, "pglEnable not implemented");
			Delegates.pglEnable((int)cap);
			CallLog("glEnable({0})", cap);
			DebugCheckErrors();
		}

		/// <summary>
		/// block until all GL execution is complete
		/// </summary>
		/// <remarks>
		/// glFinish does not return until the effects of all previously called GL commands are complete. Such effects include all 
		/// changesto GL state, all changes to connection state, and all changes to the frame buffer contents. 
		/// </remarks>
		/// <seealso cref="Gl.Flush"/>
		public static void Finish()
		{
			Debug.Assert(Delegates.pglFinish != null, "pglFinish not implemented");
			Delegates.pglFinish();
			CallLog("glFinish()");
			DebugCheckErrors();
		}

		/// <summary>
		/// force execution of GL commands in finite time
		/// </summary>
		/// <remarks>
		/// Different GL implementations buffer commands in several different locations, including network buffers and the graphics 
		/// acceleratoritself. glFlush empties all of these buffers, causing all issued commands to be executed as quickly as they 
		/// areaccepted by the actual rendering engine. Though this execution may not be completed in any particular time period, it 
		/// doescomplete in finite time. 
		/// Because any GL program might be executed over a network, or on an accelerator that buffers commands, all programs should 
		/// callglFlush whenever they count on having all of their previously issued commands completed. For example, call glFlush 
		/// beforewaiting for user input that depends on the generated image. 
		/// </remarks>
		/// <seealso cref="Gl.Finish"/>
		public static void Flush()
		{
			Debug.Assert(Delegates.pglFlush != null, "pglFlush not implemented");
			Delegates.pglFlush();
			CallLog("glFlush()");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify pixel arithmetic
		/// </summary>
		/// <param name="sfactor">
		/// Specifies how the red, green, blue, and alpha source blending factors are computed. The following symbolic constants are 
		/// accepted:<see cref="Gl.ZERO"/>, <see cref="Gl.ONE"/>, <see cref="Gl.SRC_COLOR"/>, <see cref="Gl.ONE_MINUS_SRC_COLOR"/>, 
		/// <seecref="Gl.DST_COLOR"/>, <see cref="Gl.ONE_MINUS_DST_COLOR"/>, <see cref="Gl.SRC_ALPHA"/>, <see 
		/// cref="Gl.ONE_MINUS_SRC_ALPHA"/>,<see cref="Gl.DST_ALPHA"/>, <see cref="Gl.ONE_MINUS_DST_ALPHA"/>, <see 
		/// cref="Gl.CONSTANT_COLOR"/>,<see cref="Gl.ONE_MINUS_CONSTANT_COLOR"/>, <see cref="Gl.CONSTANT_ALPHA"/>, <see 
		/// cref="Gl.ONE_MINUS_CONSTANT_ALPHA"/>,and <see cref="Gl.SRC_ALPHA_SATURATE"/>. The initial value is <see cref="Gl.ONE"/>. 
		/// </param>
		/// <param name="dfactor">
		/// Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic 
		/// constantsare accepted: <see cref="Gl.ZERO"/>, <see cref="Gl.ONE"/>, <see cref="Gl.SRC_COLOR"/>, <see 
		/// cref="Gl.ONE_MINUS_SRC_COLOR"/>,<see cref="Gl.DST_COLOR"/>, <see cref="Gl.ONE_MINUS_DST_COLOR"/>, <see 
		/// cref="Gl.SRC_ALPHA"/>,<see cref="Gl.ONE_MINUS_SRC_ALPHA"/>, <see cref="Gl.DST_ALPHA"/>, <see 
		/// cref="Gl.ONE_MINUS_DST_ALPHA"/>.<see cref="Gl.CONSTANT_COLOR"/>, <see cref="Gl.ONE_MINUS_CONSTANT_COLOR"/>, <see 
		/// cref="Gl.CONSTANT_ALPHA"/>,and <see cref="Gl.ONE_MINUS_CONSTANT_ALPHA"/>. The initial value is <see cref="Gl.ZERO"/>. 
		/// </param>
		/// <remarks>
		/// In RGBA mode, pixels can be drawn using a function that blends the incoming (source) RGBA values with the RGBA values 
		/// thatare already in the frame buffer (the destination values). Blending is initially disabled. Use Gl.Enable and 
		/// Gl.Disablewith argument <see cref="Gl.BLEND"/> to enable and disable blending. 
		/// <see cref="Gl.BlendFunc"/> defines the operation of blending when it is enabled. <paramref name="sfactor"/> specifies 
		/// whichmethod is used to scale the source color components. <paramref name="dfactor"/> specifies which method is used to 
		/// scalethe destination color components. The possible methods are described in the following table. Each method defines 
		/// fourscale factors, one each for red, green, blue, and alpha. In the table and in subsequent equations, source and 
		/// destinationcolor components are referred to as RsGsBsAs and RdGdBdAd. The color specified by Gl.BlendColor is referred 
		/// toas RcGcBcAc. They are understood to have integer values between 0 and kRkGkBkA, where 
		/// @htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: k sub c = 2 sup {m sub c} - 1:--><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">k</mml:mi><mml:mi
		/// mathvariant="italic">c</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:mrow><mml:msup><mml:mn>2</mml:mn><mml:mfencedopen="" 
		/// close=""><mml:msub><mml:mimathvariant="italic">m</mml:mi><mml:mi 
		/// mathvariant="italic">c</mml:mi></mml:msub></mml:mfenced></mml:msup><mml:mo>-</mml:mo><mml:mn>1</mml:mn></mml:mrow></mml:mrow></mml:math></inlineequation>
		/// @endhtmlonly
		/// and mRmGmBmA is the number of red, green, blue, and alpha bitplanes. 
		/// Source and destination scale factors are referred to as sRsGsBsA and dRdGdBdA. The scale factors described in the table, 
		/// denotedfRfGfBfA, represent either source or destination factors. All scale factors have range 01. 
		///  
		/// In the table, 
		/// @htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: i = min (A sub s , k sub A - A sub d ) / k sub 
		/// A:--><mml:mrow><mml:mimathvariant="italic">i</mml:mi><mml:mo>=</mml:mo><mml:mfrac><mml:mrow><mml:mi 
		/// mathvariant="italic">min</mml:mi><mml:mo>⁡</mml:mo><mml:mfencedopen="(" close=")"><mml:msub><mml:mi 
		/// mathvariant="italic">A</mml:mi><mml:mimathvariant="italic">s</mml:mi></mml:msub><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">k</mml:mi><mml:mimathvariant="italic">A</mml:mi></mml:msub><mml:mo>-</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">A</mml:mi><mml:mi
		/// mathvariant="italic">d</mml:mi></mml:msub></mml:mrow></mml:mfenced></mml:mrow><mml:msub><mml:mi
		/// mathvariant="italic">k</mml:mi><mml:mi
		/// mathvariant="italic">A</mml:mi></mml:msub></mml:mfrac></mml:mrow></mml:math></inlineequation>@endhtmlonly 
		/// To determine the blended RGBA values of a pixel when drawing in RGBA mode, the system uses the following equations: 
		/// @htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: R sub d = min ( k sub R, R sub s s sub R + R sub d d sub R 
		/// ):--><mml:mrow><mml:msub><mml:mimathvariant="italic">R</mml:mi><mml:mi 
		/// mathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:mrow><mml:mi
		/// mathvariant="italic">min</mml:mi><mml:mo>⁡</mml:mo><mml:mfencedopen="(" close=")"><mml:msub><mml:mi 
		/// mathvariant="italic">k</mml:mi><mml:mimathvariant="italic">R</mml:mi></mml:msub><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">R</mml:mi><mml:mimathvariant="italic">s</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">s</mml:mi><mml:mimathvariant="italic">R</mml:mi></mml:msub><mml:mo>+</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">R</mml:mi><mml:mimathvariant="italic">d</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">d</mml:mi><mml:mi
		/// mathvariant="italic">R</mml:mi></mml:msub></mml:mrow></mml:mfenced></mml:mrow></mml:mrow></mml:math></inlineequation>
		/// @endhtmlonly@htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: G sub d = min ( k sub G, G sub s s sub G + G sub d d sub G 
		/// ):--><mml:mrow><mml:msub><mml:mimathvariant="italic">G</mml:mi><mml:mi 
		/// mathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:mrow><mml:mi
		/// mathvariant="italic">min</mml:mi><mml:mo>⁡</mml:mo><mml:mfencedopen="(" close=")"><mml:msub><mml:mi 
		/// mathvariant="italic">k</mml:mi><mml:mimathvariant="italic">G</mml:mi></mml:msub><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">G</mml:mi><mml:mimathvariant="italic">s</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">s</mml:mi><mml:mimathvariant="italic">G</mml:mi></mml:msub><mml:mo>+</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">G</mml:mi><mml:mimathvariant="italic">d</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">d</mml:mi><mml:mi
		/// mathvariant="italic">G</mml:mi></mml:msub></mml:mrow></mml:mfenced></mml:mrow></mml:mrow></mml:math></inlineequation>
		/// @endhtmlonly@htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: B sub d = min ( k sub B, B sub s s sub B + B sub d d sub B 
		/// ):--><mml:mrow><mml:msub><mml:mimathvariant="italic">B</mml:mi><mml:mi 
		/// mathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:mrow><mml:mi
		/// mathvariant="italic">min</mml:mi><mml:mo>⁡</mml:mo><mml:mfencedopen="(" close=")"><mml:msub><mml:mi 
		/// mathvariant="italic">k</mml:mi><mml:mimathvariant="italic">B</mml:mi></mml:msub><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">B</mml:mi><mml:mimathvariant="italic">s</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">s</mml:mi><mml:mimathvariant="italic">B</mml:mi></mml:msub><mml:mo>+</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">B</mml:mi><mml:mimathvariant="italic">d</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">d</mml:mi><mml:mi
		/// mathvariant="italic">B</mml:mi></mml:msub></mml:mrow></mml:mfenced></mml:mrow></mml:mrow></mml:math></inlineequation>
		/// @endhtmlonly@htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: A sub d = min ( k sub A, A sub s s sub A + A sub d d sub A 
		/// ):--><mml:mrow><mml:msub><mml:mimathvariant="italic">A</mml:mi><mml:mi 
		/// mathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:mrow><mml:mi
		/// mathvariant="italic">min</mml:mi><mml:mo>⁡</mml:mo><mml:mfencedopen="(" close=")"><mml:msub><mml:mi 
		/// mathvariant="italic">k</mml:mi><mml:mimathvariant="italic">A</mml:mi></mml:msub><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">A</mml:mi><mml:mimathvariant="italic">s</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">s</mml:mi><mml:mimathvariant="italic">A</mml:mi></mml:msub><mml:mo>+</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">A</mml:mi><mml:mimathvariant="italic">d</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">d</mml:mi><mml:mi
		/// mathvariant="italic">A</mml:mi></mml:msub></mml:mrow></mml:mfenced></mml:mrow></mml:mrow></mml:math></inlineequation>
		/// @endhtmlonly
		/// Despite the apparent precision of the above equations, blending arithmetic is not exactly specified, because blending 
		/// operateswith imprecise integer color values. However, a blend factor that should be equal to 1 is guaranteed not to 
		/// modifyits multiplicand, and a blend factor equal to 0 reduces its multiplicand to 0. For example, when <paramref 
		/// name="sfactor"/>is <see cref="Gl.SRC_ALPHA"/>, <paramref name="dfactor"/> is <see cref="Gl.ONE_MINUS_SRC_ALPHA"/>, and 
		/// Asis equal to kA, the equations reduce to simple replacement: 
		/// @htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: R sub d = R sub s:--><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">R</mml:mi><mml:mimathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">R</mml:mi><mml:mimathvariant="italic">s</mml:mi></mml:msub></mml:mrow></mml:math></inlineequation> 
		/// @endhtmlonly@htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: G sub d = G sub s:--><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">G</mml:mi><mml:mimathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">G</mml:mi><mml:mimathvariant="italic">s</mml:mi></mml:msub></mml:mrow></mml:math></inlineequation> 
		/// @endhtmlonly@htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: B sub d = B sub s:--><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">B</mml:mi><mml:mimathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">B</mml:mi><mml:mimathvariant="italic">s</mml:mi></mml:msub></mml:mrow></mml:math></inlineequation> 
		/// @endhtmlonly@htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: A sub d = A sub s:--><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">A</mml:mi><mml:mimathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">A</mml:mi><mml:mimathvariant="italic">s</mml:mi></mml:msub></mml:mrow></mml:math></inlineequation> 
		/// @endhtmlonly
		///  
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if either <paramref name="sfactor"/> or <paramref name="dfactor"/> is not an 
		///   acceptedvalue. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.BlendFunc"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.BLEND_SRC"/> 
		/// - Gl.Get with argument <see cref="Gl.BLEND_DST"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.BLEND"/> 
		/// -  
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.AlphaFunc"/>
		/// <seealso cref="Gl.BlendColor"/>
		/// <seealso cref="Gl.BlendEquation"/>
		/// <seealso cref="Gl.BlendFuncSeparate"/>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFunc"/>
		public static void BlendFunc(int sfactor, int dfactor)
		{
			Debug.Assert(Delegates.pglBlendFunc != null, "pglBlendFunc not implemented");
			Delegates.pglBlendFunc(sfactor, dfactor);
			CallLog("glBlendFunc({0}, {1})", sfactor, dfactor);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify pixel arithmetic
		/// </summary>
		/// <param name="sfactor">
		/// Specifies how the red, green, blue, and alpha source blending factors are computed. The following symbolic constants are 
		/// accepted:<see cref="Gl.ZERO"/>, <see cref="Gl.ONE"/>, <see cref="Gl.SRC_COLOR"/>, <see cref="Gl.ONE_MINUS_SRC_COLOR"/>, 
		/// <seecref="Gl.DST_COLOR"/>, <see cref="Gl.ONE_MINUS_DST_COLOR"/>, <see cref="Gl.SRC_ALPHA"/>, <see 
		/// cref="Gl.ONE_MINUS_SRC_ALPHA"/>,<see cref="Gl.DST_ALPHA"/>, <see cref="Gl.ONE_MINUS_DST_ALPHA"/>, <see 
		/// cref="Gl.CONSTANT_COLOR"/>,<see cref="Gl.ONE_MINUS_CONSTANT_COLOR"/>, <see cref="Gl.CONSTANT_ALPHA"/>, <see 
		/// cref="Gl.ONE_MINUS_CONSTANT_ALPHA"/>,and <see cref="Gl.SRC_ALPHA_SATURATE"/>. The initial value is <see cref="Gl.ONE"/>. 
		/// </param>
		/// <param name="dfactor">
		/// Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic 
		/// constantsare accepted: <see cref="Gl.ZERO"/>, <see cref="Gl.ONE"/>, <see cref="Gl.SRC_COLOR"/>, <see 
		/// cref="Gl.ONE_MINUS_SRC_COLOR"/>,<see cref="Gl.DST_COLOR"/>, <see cref="Gl.ONE_MINUS_DST_COLOR"/>, <see 
		/// cref="Gl.SRC_ALPHA"/>,<see cref="Gl.ONE_MINUS_SRC_ALPHA"/>, <see cref="Gl.DST_ALPHA"/>, <see 
		/// cref="Gl.ONE_MINUS_DST_ALPHA"/>.<see cref="Gl.CONSTANT_COLOR"/>, <see cref="Gl.ONE_MINUS_CONSTANT_COLOR"/>, <see 
		/// cref="Gl.CONSTANT_ALPHA"/>,and <see cref="Gl.ONE_MINUS_CONSTANT_ALPHA"/>. The initial value is <see cref="Gl.ZERO"/>. 
		/// </param>
		/// <remarks>
		/// In RGBA mode, pixels can be drawn using a function that blends the incoming (source) RGBA values with the RGBA values 
		/// thatare already in the frame buffer (the destination values). Blending is initially disabled. Use Gl.Enable and 
		/// Gl.Disablewith argument <see cref="Gl.BLEND"/> to enable and disable blending. 
		/// <see cref="Gl.BlendFunc"/> defines the operation of blending when it is enabled. <paramref name="sfactor"/> specifies 
		/// whichmethod is used to scale the source color components. <paramref name="dfactor"/> specifies which method is used to 
		/// scalethe destination color components. The possible methods are described in the following table. Each method defines 
		/// fourscale factors, one each for red, green, blue, and alpha. In the table and in subsequent equations, source and 
		/// destinationcolor components are referred to as RsGsBsAs and RdGdBdAd. The color specified by Gl.BlendColor is referred 
		/// toas RcGcBcAc. They are understood to have integer values between 0 and kRkGkBkA, where 
		/// @htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: k sub c = 2 sup {m sub c} - 1:--><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">k</mml:mi><mml:mi
		/// mathvariant="italic">c</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:mrow><mml:msup><mml:mn>2</mml:mn><mml:mfencedopen="" 
		/// close=""><mml:msub><mml:mimathvariant="italic">m</mml:mi><mml:mi 
		/// mathvariant="italic">c</mml:mi></mml:msub></mml:mfenced></mml:msup><mml:mo>-</mml:mo><mml:mn>1</mml:mn></mml:mrow></mml:mrow></mml:math></inlineequation>
		/// @endhtmlonly
		/// and mRmGmBmA is the number of red, green, blue, and alpha bitplanes. 
		/// Source and destination scale factors are referred to as sRsGsBsA and dRdGdBdA. The scale factors described in the table, 
		/// denotedfRfGfBfA, represent either source or destination factors. All scale factors have range 01. 
		///  
		/// In the table, 
		/// @htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: i = min (A sub s , k sub A - A sub d ) / k sub 
		/// A:--><mml:mrow><mml:mimathvariant="italic">i</mml:mi><mml:mo>=</mml:mo><mml:mfrac><mml:mrow><mml:mi 
		/// mathvariant="italic">min</mml:mi><mml:mo>⁡</mml:mo><mml:mfencedopen="(" close=")"><mml:msub><mml:mi 
		/// mathvariant="italic">A</mml:mi><mml:mimathvariant="italic">s</mml:mi></mml:msub><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">k</mml:mi><mml:mimathvariant="italic">A</mml:mi></mml:msub><mml:mo>-</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">A</mml:mi><mml:mi
		/// mathvariant="italic">d</mml:mi></mml:msub></mml:mrow></mml:mfenced></mml:mrow><mml:msub><mml:mi
		/// mathvariant="italic">k</mml:mi><mml:mi
		/// mathvariant="italic">A</mml:mi></mml:msub></mml:mfrac></mml:mrow></mml:math></inlineequation>@endhtmlonly 
		/// To determine the blended RGBA values of a pixel when drawing in RGBA mode, the system uses the following equations: 
		/// @htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: R sub d = min ( k sub R, R sub s s sub R + R sub d d sub R 
		/// ):--><mml:mrow><mml:msub><mml:mimathvariant="italic">R</mml:mi><mml:mi 
		/// mathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:mrow><mml:mi
		/// mathvariant="italic">min</mml:mi><mml:mo>⁡</mml:mo><mml:mfencedopen="(" close=")"><mml:msub><mml:mi 
		/// mathvariant="italic">k</mml:mi><mml:mimathvariant="italic">R</mml:mi></mml:msub><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">R</mml:mi><mml:mimathvariant="italic">s</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">s</mml:mi><mml:mimathvariant="italic">R</mml:mi></mml:msub><mml:mo>+</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">R</mml:mi><mml:mimathvariant="italic">d</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">d</mml:mi><mml:mi
		/// mathvariant="italic">R</mml:mi></mml:msub></mml:mrow></mml:mfenced></mml:mrow></mml:mrow></mml:math></inlineequation>
		/// @endhtmlonly@htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: G sub d = min ( k sub G, G sub s s sub G + G sub d d sub G 
		/// ):--><mml:mrow><mml:msub><mml:mimathvariant="italic">G</mml:mi><mml:mi 
		/// mathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:mrow><mml:mi
		/// mathvariant="italic">min</mml:mi><mml:mo>⁡</mml:mo><mml:mfencedopen="(" close=")"><mml:msub><mml:mi 
		/// mathvariant="italic">k</mml:mi><mml:mimathvariant="italic">G</mml:mi></mml:msub><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">G</mml:mi><mml:mimathvariant="italic">s</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">s</mml:mi><mml:mimathvariant="italic">G</mml:mi></mml:msub><mml:mo>+</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">G</mml:mi><mml:mimathvariant="italic">d</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">d</mml:mi><mml:mi
		/// mathvariant="italic">G</mml:mi></mml:msub></mml:mrow></mml:mfenced></mml:mrow></mml:mrow></mml:math></inlineequation>
		/// @endhtmlonly@htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: B sub d = min ( k sub B, B sub s s sub B + B sub d d sub B 
		/// ):--><mml:mrow><mml:msub><mml:mimathvariant="italic">B</mml:mi><mml:mi 
		/// mathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:mrow><mml:mi
		/// mathvariant="italic">min</mml:mi><mml:mo>⁡</mml:mo><mml:mfencedopen="(" close=")"><mml:msub><mml:mi 
		/// mathvariant="italic">k</mml:mi><mml:mimathvariant="italic">B</mml:mi></mml:msub><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">B</mml:mi><mml:mimathvariant="italic">s</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">s</mml:mi><mml:mimathvariant="italic">B</mml:mi></mml:msub><mml:mo>+</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">B</mml:mi><mml:mimathvariant="italic">d</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">d</mml:mi><mml:mi
		/// mathvariant="italic">B</mml:mi></mml:msub></mml:mrow></mml:mfenced></mml:mrow></mml:mrow></mml:math></inlineequation>
		/// @endhtmlonly@htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: A sub d = min ( k sub A, A sub s s sub A + A sub d d sub A 
		/// ):--><mml:mrow><mml:msub><mml:mimathvariant="italic">A</mml:mi><mml:mi 
		/// mathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:mrow><mml:mi
		/// mathvariant="italic">min</mml:mi><mml:mo>⁡</mml:mo><mml:mfencedopen="(" close=")"><mml:msub><mml:mi 
		/// mathvariant="italic">k</mml:mi><mml:mimathvariant="italic">A</mml:mi></mml:msub><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">A</mml:mi><mml:mimathvariant="italic">s</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">s</mml:mi><mml:mimathvariant="italic">A</mml:mi></mml:msub><mml:mo>+</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">A</mml:mi><mml:mimathvariant="italic">d</mml:mi></mml:msub><mml:mo>⁢</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">d</mml:mi><mml:mi
		/// mathvariant="italic">A</mml:mi></mml:msub></mml:mrow></mml:mfenced></mml:mrow></mml:mrow></mml:math></inlineequation>
		/// @endhtmlonly
		/// Despite the apparent precision of the above equations, blending arithmetic is not exactly specified, because blending 
		/// operateswith imprecise integer color values. However, a blend factor that should be equal to 1 is guaranteed not to 
		/// modifyits multiplicand, and a blend factor equal to 0 reduces its multiplicand to 0. For example, when <paramref 
		/// name="sfactor"/>is <see cref="Gl.SRC_ALPHA"/>, <paramref name="dfactor"/> is <see cref="Gl.ONE_MINUS_SRC_ALPHA"/>, and 
		/// Asis equal to kA, the equations reduce to simple replacement: 
		/// @htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: R sub d = R sub s:--><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">R</mml:mi><mml:mimathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">R</mml:mi><mml:mimathvariant="italic">s</mml:mi></mml:msub></mml:mrow></mml:math></inlineequation> 
		/// @endhtmlonly@htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: G sub d = G sub s:--><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">G</mml:mi><mml:mimathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">G</mml:mi><mml:mimathvariant="italic">s</mml:mi></mml:msub></mml:mrow></mml:math></inlineequation> 
		/// @endhtmlonly@htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: B sub d = B sub s:--><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">B</mml:mi><mml:mimathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">B</mml:mi><mml:mimathvariant="italic">s</mml:mi></mml:msub></mml:mrow></mml:math></inlineequation> 
		/// @endhtmlonly@htmlonly <inlineequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: A sub d = A sub s:--><mml:mrow><mml:msub><mml:mi 
		/// mathvariant="italic">A</mml:mi><mml:mimathvariant="italic">d</mml:mi></mml:msub><mml:mo>=</mml:mo><mml:msub><mml:mi 
		/// mathvariant="italic">A</mml:mi><mml:mimathvariant="italic">s</mml:mi></mml:msub></mml:mrow></mml:math></inlineequation> 
		/// @endhtmlonly
		///  
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if either <paramref name="sfactor"/> or <paramref name="dfactor"/> is not an 
		///   acceptedvalue. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.BlendFunc"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.BLEND_SRC"/> 
		/// - Gl.Get with argument <see cref="Gl.BLEND_DST"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.BLEND"/> 
		/// -  
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.AlphaFunc"/>
		/// <seealso cref="Gl.BlendColor"/>
		/// <seealso cref="Gl.BlendEquation"/>
		/// <seealso cref="Gl.BlendFuncSeparate"/>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFunc"/>
		public static void BlendFunc(BlendingFactorSrc sfactor, BlendingFactorDest dfactor)
		{
			Debug.Assert(Delegates.pglBlendFunc != null, "pglBlendFunc not implemented");
			Delegates.pglBlendFunc((int)sfactor, (int)dfactor);
			CallLog("glBlendFunc({0}, {1})", sfactor, dfactor);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a logical pixel operation for rendering
		/// </summary>
		/// <param name="opcode">
		/// Specifies a symbolic constant that selects a logical operation. The following symbols are accepted: GL_CLEAR, GL_SET, 
		/// GL_COPY,GL_COPY_INVERTED, GL_NOOP, GL_INVERT, GL_AND, GL_NAND, GL_OR, GL_NOR, GL_XOR, GL_EQUIV, GL_AND_REVERSE, 
		/// GL_AND_INVERTED,GL_OR_REVERSE, and GL_OR_INVERTED. The initial value is GL_COPY. 
		/// </param>
		/// <remarks>
		/// glLogicOp specifies a logical operation that, when enabled, is applied between the incoming RGBA color and the RGBA 
		/// colorat the corresponding location in the frame buffer. To enable or disable the logical operation, call glEnable and 
		/// glDisableusing the symbolic constant GL_COLOR_LOGIC_OP. The initial value is disabled. 
		///  
		/// opcode is a symbolic constant chosen from the list above. In the explanation of the logical operations, s represents the 
		/// incomingcolor and d represents the color in the frame buffer. Standard C-language operators are used. As these bitwise 
		/// operatorssuggest, the logical operation is applied independently to each bit pair of the source and destination colors. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if opcode is not an accepted value. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_LOGIC_OP_MODE. 
		/// - glIsEnabled with argument GL_COLOR_LOGIC_OP. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.StencilOp"/>
		public static void LogicOp(int opcode)
		{
			Debug.Assert(Delegates.pglLogicOp != null, "pglLogicOp not implemented");
			Delegates.pglLogicOp(opcode);
			CallLog("glLogicOp({0})", opcode);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a logical pixel operation for rendering
		/// </summary>
		/// <param name="opcode">
		/// Specifies a symbolic constant that selects a logical operation. The following symbols are accepted: GL_CLEAR, GL_SET, 
		/// GL_COPY,GL_COPY_INVERTED, GL_NOOP, GL_INVERT, GL_AND, GL_NAND, GL_OR, GL_NOR, GL_XOR, GL_EQUIV, GL_AND_REVERSE, 
		/// GL_AND_INVERTED,GL_OR_REVERSE, and GL_OR_INVERTED. The initial value is GL_COPY. 
		/// </param>
		/// <remarks>
		/// glLogicOp specifies a logical operation that, when enabled, is applied between the incoming RGBA color and the RGBA 
		/// colorat the corresponding location in the frame buffer. To enable or disable the logical operation, call glEnable and 
		/// glDisableusing the symbolic constant GL_COLOR_LOGIC_OP. The initial value is disabled. 
		///  
		/// opcode is a symbolic constant chosen from the list above. In the explanation of the logical operations, s represents the 
		/// incomingcolor and d represents the color in the frame buffer. Standard C-language operators are used. As these bitwise 
		/// operatorssuggest, the logical operation is applied independently to each bit pair of the source and destination colors. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if opcode is not an accepted value. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_LOGIC_OP_MODE. 
		/// - glIsEnabled with argument GL_COLOR_LOGIC_OP. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.StencilOp"/>
		public static void LogicOp(LogicOp opcode)
		{
			Debug.Assert(Delegates.pglLogicOp != null, "pglLogicOp not implemented");
			Delegates.pglLogicOp((int)opcode);
			CallLog("glLogicOp({0})", opcode);
			DebugCheckErrors();
		}

		/// <summary>
		/// set front and back function and reference value for stencil testing
		/// </summary>
		/// <param name="func">
		/// Specifies the test function. Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, 
		/// GL_EQUAL,GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS. 
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The 
		/// initialvalue is all 1's. 
		/// </param>
		/// <remarks>
		/// Stenciling, like depth-buffering, enables and disables drawing on a per-pixel basis. Stencil planes are first drawn into 
		/// usingGL drawing primitives, then geometry and images are rendered using the stencil planes to mask out portions of the 
		/// screen.Stenciling is typically used in multipass rendering algorithms to achieve special effects, such as decals, 
		/// outlining,and constructive solid geometry rendering. 
		/// The stencil test conditionally eliminates a pixel based on the outcome of a comparison between the reference value and 
		/// thevalue in the stencil buffer. To enable and disable the test, call glEnable and glDisable with argument 
		/// GL_STENCIL_TEST.To specify actions based on the outcome of the stencil test, call glStencilOp or glStencilOpSeparate. 
		/// There can be two separate sets of func, ref, and mask parameters; one affects back-facing polygons, and the other 
		/// affectsfront-facing polygons as well as other non-polygon primitives. glStencilFunc sets both front and back stencil 
		/// stateto the same values. Use glStencilFuncSeparate to set front and back stencil state to different values. 
		/// func is a symbolic constant that determines the stencil comparison function. It accepts one of eight values, shown in 
		/// thefollowing list. ref is an integer reference value that is used in the stencil comparison. It is clamped to the range 
		/// 02n-1,where n is the number of bitplanes in the stencil buffer. mask is bitwise ANDed with both the reference value and 
		/// thestored stencil value, with the ANDed values participating in the comparison. 
		/// If stencil represents the value stored in the corresponding stencil buffer location, the following list shows the effect 
		/// ofeach comparison function that can be specified by func. Only if the comparison succeeds is the pixel passed through to 
		/// thenext stage in the rasterization process (see glStencilOp). All tests treat stencil values as unsigned integers in the 
		/// range02n-1, where n is the number of bitplanes in the stencil buffer. 
		/// The following values are accepted by func: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if func is not one of the eight accepted values. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_STENCIL_FUNC, GL_STENCIL_VALUE_MASK, GL_STENCIL_REF, GL_STENCIL_BACK_FUNC, 
		///   GL_STENCIL_BACK_VALUE_MASK,GL_STENCIL_BACK_REF, or GL_STENCIL_BITS 
		/// - glIsEnabled with argument GL_STENCIL_TEST 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
		public static void StencilFunc(int func, Int32 @ref, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilFunc != null, "pglStencilFunc not implemented");
			Delegates.pglStencilFunc(func, @ref, mask);
			CallLog("glStencilFunc({0}, {1}, {2})", func, @ref, mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// set front and back function and reference value for stencil testing
		/// </summary>
		/// <param name="func">
		/// Specifies the test function. Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, 
		/// GL_EQUAL,GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS. 
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The 
		/// initialvalue is all 1's. 
		/// </param>
		/// <remarks>
		/// Stenciling, like depth-buffering, enables and disables drawing on a per-pixel basis. Stencil planes are first drawn into 
		/// usingGL drawing primitives, then geometry and images are rendered using the stencil planes to mask out portions of the 
		/// screen.Stenciling is typically used in multipass rendering algorithms to achieve special effects, such as decals, 
		/// outlining,and constructive solid geometry rendering. 
		/// The stencil test conditionally eliminates a pixel based on the outcome of a comparison between the reference value and 
		/// thevalue in the stencil buffer. To enable and disable the test, call glEnable and glDisable with argument 
		/// GL_STENCIL_TEST.To specify actions based on the outcome of the stencil test, call glStencilOp or glStencilOpSeparate. 
		/// There can be two separate sets of func, ref, and mask parameters; one affects back-facing polygons, and the other 
		/// affectsfront-facing polygons as well as other non-polygon primitives. glStencilFunc sets both front and back stencil 
		/// stateto the same values. Use glStencilFuncSeparate to set front and back stencil state to different values. 
		/// func is a symbolic constant that determines the stencil comparison function. It accepts one of eight values, shown in 
		/// thefollowing list. ref is an integer reference value that is used in the stencil comparison. It is clamped to the range 
		/// 02n-1,where n is the number of bitplanes in the stencil buffer. mask is bitwise ANDed with both the reference value and 
		/// thestored stencil value, with the ANDed values participating in the comparison. 
		/// If stencil represents the value stored in the corresponding stencil buffer location, the following list shows the effect 
		/// ofeach comparison function that can be specified by func. Only if the comparison succeeds is the pixel passed through to 
		/// thenext stage in the rasterization process (see glStencilOp). All tests treat stencil values as unsigned integers in the 
		/// range02n-1, where n is the number of bitplanes in the stencil buffer. 
		/// The following values are accepted by func: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if func is not one of the eight accepted values. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_STENCIL_FUNC, GL_STENCIL_VALUE_MASK, GL_STENCIL_REF, GL_STENCIL_BACK_FUNC, 
		///   GL_STENCIL_BACK_VALUE_MASK,GL_STENCIL_BACK_REF, or GL_STENCIL_BITS 
		/// - glIsEnabled with argument GL_STENCIL_TEST 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
		public static void StencilFunc(StencilFunction func, Int32 @ref, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilFunc != null, "pglStencilFunc not implemented");
			Delegates.pglStencilFunc((int)func, @ref, mask);
			CallLog("glStencilFunc({0}, {1}, {2})", func, @ref, mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// set front and back stencil test actions
		/// </summary>
		/// <param name="fail">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="zfail">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="zpass">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// Stenciling, like depth-buffering, enables and disables drawing on a per-pixel basis. You draw into the stencil planes 
		/// usingGL drawing primitives, then render geometry and images, using the stencil planes to mask out portions of the 
		/// screen.Stenciling is typically used in multipass rendering algorithms to achieve special effects, such as decals, 
		/// outlining,and constructive solid geometry rendering. 
		/// The stencil test conditionally eliminates a pixel based on the outcome of a comparison between the value in the stencil 
		/// bufferand a reference value. To enable and disable the test, call glEnable and glDisable with argument GL_STENCIL_TEST; 
		/// tocontrol it, call glStencilFunc or glStencilFuncSeparate. 
		/// There can be two separate sets of sfail, dpfail, and dppass parameters; one affects back-facing polygons, and the other 
		/// affectsfront-facing polygons as well as other non-polygon primitives. glStencilOp sets both front and back stencil state 
		/// tothe same values. Use glStencilOpSeparate to set front and back stencil state to different values. 
		/// glStencilOp takes three arguments that indicate what happens to the stored stencil value while stenciling is enabled. If 
		/// thestencil test fails, no change is made to the pixel's color or depth buffers, and sfail specifies what happens to the 
		/// stencilbuffer contents. The following eight actions are possible. 
		/// Stencil buffer values are treated as unsigned integers. When incremented and decremented, values are clamped to 0 and 
		/// 2n-1,where n is the value returned by querying GL_STENCIL_BITS. 
		/// The other two arguments to glStencilOp specify stencil buffer actions that depend on whether subsequent depth buffer 
		/// testssucceed (dppass) or fail (dpfail) (see glDepthFunc). The actions are specified using the same eight symbolic 
		/// constantsas sfail. Note that dpfail is ignored when there is no depth buffer, or when the depth buffer is not enabled. 
		/// Inthese cases, sfail and dppass specify stencil action when the stencil test fails and passes, respectively. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if sfail, dpfail, or dppass is any value other than the defined constant values. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_STENCIL_FAIL, GL_STENCIL_PASS_DEPTH_PASS, GL_STENCIL_PASS_DEPTH_FAIL, GL_STENCIL_BACK_FAIL, 
		///   GL_STENCIL_BACK_PASS_DEPTH_PASS,GL_STENCIL_BACK_PASS_DEPTH_FAIL, or GL_STENCIL_BITS 
		/// - glIsEnabled with argument GL_STENCIL_TEST 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
		public static void StencilOp(int fail, int zfail, int zpass)
		{
			Debug.Assert(Delegates.pglStencilOp != null, "pglStencilOp not implemented");
			Delegates.pglStencilOp(fail, zfail, zpass);
			CallLog("glStencilOp({0}, {1}, {2})", fail, zfail, zpass);
			DebugCheckErrors();
		}

		/// <summary>
		/// set front and back stencil test actions
		/// </summary>
		/// <param name="fail">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="zfail">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="zpass">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// Stenciling, like depth-buffering, enables and disables drawing on a per-pixel basis. You draw into the stencil planes 
		/// usingGL drawing primitives, then render geometry and images, using the stencil planes to mask out portions of the 
		/// screen.Stenciling is typically used in multipass rendering algorithms to achieve special effects, such as decals, 
		/// outlining,and constructive solid geometry rendering. 
		/// The stencil test conditionally eliminates a pixel based on the outcome of a comparison between the value in the stencil 
		/// bufferand a reference value. To enable and disable the test, call glEnable and glDisable with argument GL_STENCIL_TEST; 
		/// tocontrol it, call glStencilFunc or glStencilFuncSeparate. 
		/// There can be two separate sets of sfail, dpfail, and dppass parameters; one affects back-facing polygons, and the other 
		/// affectsfront-facing polygons as well as other non-polygon primitives. glStencilOp sets both front and back stencil state 
		/// tothe same values. Use glStencilOpSeparate to set front and back stencil state to different values. 
		/// glStencilOp takes three arguments that indicate what happens to the stored stencil value while stenciling is enabled. If 
		/// thestencil test fails, no change is made to the pixel's color or depth buffers, and sfail specifies what happens to the 
		/// stencilbuffer contents. The following eight actions are possible. 
		/// Stencil buffer values are treated as unsigned integers. When incremented and decremented, values are clamped to 0 and 
		/// 2n-1,where n is the value returned by querying GL_STENCIL_BITS. 
		/// The other two arguments to glStencilOp specify stencil buffer actions that depend on whether subsequent depth buffer 
		/// testssucceed (dppass) or fail (dpfail) (see glDepthFunc). The actions are specified using the same eight symbolic 
		/// constantsas sfail. Note that dpfail is ignored when there is no depth buffer, or when the depth buffer is not enabled. 
		/// Inthese cases, sfail and dppass specify stencil action when the stencil test fails and passes, respectively. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if sfail, dpfail, or dppass is any value other than the defined constant values. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_STENCIL_FAIL, GL_STENCIL_PASS_DEPTH_PASS, GL_STENCIL_PASS_DEPTH_FAIL, GL_STENCIL_BACK_FAIL, 
		///   GL_STENCIL_BACK_PASS_DEPTH_PASS,GL_STENCIL_BACK_PASS_DEPTH_FAIL, or GL_STENCIL_BITS 
		/// - glIsEnabled with argument GL_STENCIL_TEST 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
		public static void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass)
		{
			Debug.Assert(Delegates.pglStencilOp != null, "pglStencilOp not implemented");
			Delegates.pglStencilOp((int)fail, (int)zfail, (int)zpass);
			CallLog("glStencilOp({0}, {1}, {2})", fail, zfail, zpass);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the value used for depth buffer comparisons
		/// </summary>
		/// <param name="func">
		/// Specifies the depth comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, 
		/// GL_NOTEQUAL,GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_LESS. 
		/// </param>
		/// <remarks>
		/// glDepthFunc specifies the function used to compare each incoming pixel depth value with the depth value present in the 
		/// depthbuffer. The comparison is performed only if depth testing is enabled. (See glEnable and glDisable of 
		/// GL_DEPTH_TEST.)
		/// func specifies the conditions under which the pixel will be drawn. The comparison functions are as follows: 
		/// The initial value of func is GL_LESS. Initially, depth testing is disabled. If depth testing is disabled or if no depth 
		/// bufferexists, it is as if the depth test always passes. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if func is not an accepted value. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_DEPTH_FUNC 
		/// - glIsEnabled with argument GL_DEPTH_TEST 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DepthRange"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.PolygonOffset"/>
		public static void DepthFunc(int func)
		{
			Debug.Assert(Delegates.pglDepthFunc != null, "pglDepthFunc not implemented");
			Delegates.pglDepthFunc(func);
			CallLog("glDepthFunc({0})", func);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the value used for depth buffer comparisons
		/// </summary>
		/// <param name="func">
		/// Specifies the depth comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, 
		/// GL_NOTEQUAL,GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_LESS. 
		/// </param>
		/// <remarks>
		/// glDepthFunc specifies the function used to compare each incoming pixel depth value with the depth value present in the 
		/// depthbuffer. The comparison is performed only if depth testing is enabled. (See glEnable and glDisable of 
		/// GL_DEPTH_TEST.)
		/// func specifies the conditions under which the pixel will be drawn. The comparison functions are as follows: 
		/// The initial value of func is GL_LESS. Initially, depth testing is disabled. If depth testing is disabled or if no depth 
		/// bufferexists, it is as if the depth test always passes. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if func is not an accepted value. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_DEPTH_FUNC 
		/// - glIsEnabled with argument GL_DEPTH_TEST 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DepthRange"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.PolygonOffset"/>
		public static void DepthFunc(DepthFunction func)
		{
			Debug.Assert(Delegates.pglDepthFunc != null, "pglDepthFunc not implemented");
			Delegates.pglDepthFunc((int)func);
			CallLog("glDepthFunc({0})", func);
			DebugCheckErrors();
		}

		/// <summary>
		/// set pixel storage modes
		/// </summary>
		/// <param name="pname">
		/// Specifies the symbolic name of the parameter to be set. Six values affect the packing of pixel data into memory: <see 
		/// cref="Gl.PACK_SWAP_BYTES"/>,<see cref="Gl.PACK_LSB_FIRST"/>, <see cref="Gl.PACK_ROW_LENGTH"/>, <see 
		/// cref="Gl.PACK_IMAGE_HEIGHT"/>,<see cref="Gl.PACK_SKIP_PIXELS"/>, <see cref="Gl.PACK_SKIP_ROWS"/>, <see 
		/// cref="Gl.PACK_SKIP_IMAGES"/>,and <see cref="Gl.PACK_ALIGNMENT"/>. Six more affect the unpacking of pixel data from 
		/// memory:<see cref="Gl.UNPACK_SWAP_BYTES"/>, <see cref="Gl.UNPACK_LSB_FIRST"/>, <see cref="Gl.UNPACK_ROW_LENGTH"/>, <see 
		/// cref="Gl.UNPACK_IMAGE_HEIGHT"/>,<see cref="Gl.UNPACK_SKIP_PIXELS"/>, <see cref="Gl.UNPACK_SKIP_ROWS"/>, <see 
		/// cref="Gl.UNPACK_SKIP_IMAGES"/>,and <see cref="Gl.UNPACK_ALIGNMENT"/>. 
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> is set to. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.PixelStore"/> sets pixel storage modes that affect the operation of subsequent Gl.DrawPixels and 
		/// Gl.ReadPixelsas well as the unpacking of polygon stipple patterns (see Gl.PolygonStipple), bitmaps (see Gl.Bitmap), 
		/// texturepatterns (see Gl.TexImage1D, Gl.TexImage2D, Gl.TexImage3D, Gl.TexSubImage1D, Gl.TexSubImage2D, Gl.TexSubImage3D). 
		/// Additionally,if the ARB_imaging extension is supported, pixel storage modes affect convolution filters (see 
		/// Gl.ConvolutionFilter1D,Gl.ConvolutionFilter2D, and Gl.SeparableFilter2D, color table (see Gl.ColorTable, and 
		/// Gl.ColorSubTable,and unpacking histogram (See Gl.Histogram), and minmax (See Gl.Minmax) data. 
		/// <paramref name="pname"/> is a symbolic constant indicating the parameter to be set, and <paramref name="param"/> is the 
		/// newvalue. Six of the twelve storage parameters affect how pixel data is returned to client memory. They are as follows: 
		/// The other six of the twelve storage parameters affect how pixel data is read from client memory. These values are 
		/// significantfor Gl.DrawPixels, Gl.TexImage1D, Gl.TexImage2D, Gl.TexImage3D, Gl.TexSubImage1D, Gl.TexSubImage2D, 
		/// Gl.TexSubImage3D,Gl.Bitmap, and Gl.PolygonStipple. 
		/// Additionally, if the ARB_imaging extension is supported, Gl.ColorTable, Gl.ColorSubTable, Gl.ConvolutionFilter1D, 
		/// Gl.ConvolutionFilter2D,and Gl.SeparableFilter2D. They are as follows: 
		/// The following table gives the type, initial value, and range of valid values for each storage parameter that can be set 
		/// with<see cref="Gl.PixelStore"/>. 
		///  
		/// <see cref="Gl.PixelStoref"/> can be used to set any pixel store parameter. If the parameter type is boolean, then if 
		/// <paramrefname="param"/> is 0, the parameter is false; otherwise it is set to true. If <paramref name="pname"/> is a 
		/// integertype parameter, <paramref name="param"/> is rounded to the nearest integer. 
		/// Likewise, <see cref="Gl.PixelStorei"/> can also be used to set any of the pixel store parameters. Boolean parameters are 
		/// setto false if <paramref name="param"/> is 0 and true otherwise. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if a negative row length, pixel skip, or row skip value is specified, or if 
		///   alignmentis specified as other than 1, 2, 4, or 8. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.PixelStore"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.PACK_SWAP_BYTES"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_LSB_FIRST"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_ROW_LENGTH"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_IMAGE_HEIGHT"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_SKIP_ROWS"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_SKIP_PIXELS"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_SKIP_IMAGES"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_ALIGNMENT"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_SWAP_BYTES"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_LSB_FIRST"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_ROW_LENGTH"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_IMAGE_HEIGHT"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_SKIP_ROWS"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_SKIP_PIXELS"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_SKIP_IMAGES"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_ALIGNMENT"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.PolygonStipple"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void PixelStore(int pname, float param)
		{
			Debug.Assert(Delegates.pglPixelStoref != null, "pglPixelStoref not implemented");
			Delegates.pglPixelStoref(pname, param);
			CallLog("glPixelStoref({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set pixel storage modes
		/// </summary>
		/// <param name="pname">
		/// Specifies the symbolic name of the parameter to be set. Six values affect the packing of pixel data into memory: <see 
		/// cref="Gl.PACK_SWAP_BYTES"/>,<see cref="Gl.PACK_LSB_FIRST"/>, <see cref="Gl.PACK_ROW_LENGTH"/>, <see 
		/// cref="Gl.PACK_IMAGE_HEIGHT"/>,<see cref="Gl.PACK_SKIP_PIXELS"/>, <see cref="Gl.PACK_SKIP_ROWS"/>, <see 
		/// cref="Gl.PACK_SKIP_IMAGES"/>,and <see cref="Gl.PACK_ALIGNMENT"/>. Six more affect the unpacking of pixel data from 
		/// memory:<see cref="Gl.UNPACK_SWAP_BYTES"/>, <see cref="Gl.UNPACK_LSB_FIRST"/>, <see cref="Gl.UNPACK_ROW_LENGTH"/>, <see 
		/// cref="Gl.UNPACK_IMAGE_HEIGHT"/>,<see cref="Gl.UNPACK_SKIP_PIXELS"/>, <see cref="Gl.UNPACK_SKIP_ROWS"/>, <see 
		/// cref="Gl.UNPACK_SKIP_IMAGES"/>,and <see cref="Gl.UNPACK_ALIGNMENT"/>. 
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> is set to. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.PixelStore"/> sets pixel storage modes that affect the operation of subsequent Gl.DrawPixels and 
		/// Gl.ReadPixelsas well as the unpacking of polygon stipple patterns (see Gl.PolygonStipple), bitmaps (see Gl.Bitmap), 
		/// texturepatterns (see Gl.TexImage1D, Gl.TexImage2D, Gl.TexImage3D, Gl.TexSubImage1D, Gl.TexSubImage2D, Gl.TexSubImage3D). 
		/// Additionally,if the ARB_imaging extension is supported, pixel storage modes affect convolution filters (see 
		/// Gl.ConvolutionFilter1D,Gl.ConvolutionFilter2D, and Gl.SeparableFilter2D, color table (see Gl.ColorTable, and 
		/// Gl.ColorSubTable,and unpacking histogram (See Gl.Histogram), and minmax (See Gl.Minmax) data. 
		/// <paramref name="pname"/> is a symbolic constant indicating the parameter to be set, and <paramref name="param"/> is the 
		/// newvalue. Six of the twelve storage parameters affect how pixel data is returned to client memory. They are as follows: 
		/// The other six of the twelve storage parameters affect how pixel data is read from client memory. These values are 
		/// significantfor Gl.DrawPixels, Gl.TexImage1D, Gl.TexImage2D, Gl.TexImage3D, Gl.TexSubImage1D, Gl.TexSubImage2D, 
		/// Gl.TexSubImage3D,Gl.Bitmap, and Gl.PolygonStipple. 
		/// Additionally, if the ARB_imaging extension is supported, Gl.ColorTable, Gl.ColorSubTable, Gl.ConvolutionFilter1D, 
		/// Gl.ConvolutionFilter2D,and Gl.SeparableFilter2D. They are as follows: 
		/// The following table gives the type, initial value, and range of valid values for each storage parameter that can be set 
		/// with<see cref="Gl.PixelStore"/>. 
		///  
		/// <see cref="Gl.PixelStoref"/> can be used to set any pixel store parameter. If the parameter type is boolean, then if 
		/// <paramrefname="param"/> is 0, the parameter is false; otherwise it is set to true. If <paramref name="pname"/> is a 
		/// integertype parameter, <paramref name="param"/> is rounded to the nearest integer. 
		/// Likewise, <see cref="Gl.PixelStorei"/> can also be used to set any of the pixel store parameters. Boolean parameters are 
		/// setto false if <paramref name="param"/> is 0 and true otherwise. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if a negative row length, pixel skip, or row skip value is specified, or if 
		///   alignmentis specified as other than 1, 2, 4, or 8. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.PixelStore"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.PACK_SWAP_BYTES"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_LSB_FIRST"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_ROW_LENGTH"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_IMAGE_HEIGHT"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_SKIP_ROWS"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_SKIP_PIXELS"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_SKIP_IMAGES"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_ALIGNMENT"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_SWAP_BYTES"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_LSB_FIRST"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_ROW_LENGTH"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_IMAGE_HEIGHT"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_SKIP_ROWS"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_SKIP_PIXELS"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_SKIP_IMAGES"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_ALIGNMENT"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.PolygonStipple"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void PixelStore(PixelStoreParameter pname, float param)
		{
			Debug.Assert(Delegates.pglPixelStoref != null, "pglPixelStoref not implemented");
			Delegates.pglPixelStoref((int)pname, param);
			CallLog("glPixelStoref({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set pixel storage modes
		/// </summary>
		/// <param name="pname">
		/// Specifies the symbolic name of the parameter to be set. Six values affect the packing of pixel data into memory: <see 
		/// cref="Gl.PACK_SWAP_BYTES"/>,<see cref="Gl.PACK_LSB_FIRST"/>, <see cref="Gl.PACK_ROW_LENGTH"/>, <see 
		/// cref="Gl.PACK_IMAGE_HEIGHT"/>,<see cref="Gl.PACK_SKIP_PIXELS"/>, <see cref="Gl.PACK_SKIP_ROWS"/>, <see 
		/// cref="Gl.PACK_SKIP_IMAGES"/>,and <see cref="Gl.PACK_ALIGNMENT"/>. Six more affect the unpacking of pixel data from 
		/// memory:<see cref="Gl.UNPACK_SWAP_BYTES"/>, <see cref="Gl.UNPACK_LSB_FIRST"/>, <see cref="Gl.UNPACK_ROW_LENGTH"/>, <see 
		/// cref="Gl.UNPACK_IMAGE_HEIGHT"/>,<see cref="Gl.UNPACK_SKIP_PIXELS"/>, <see cref="Gl.UNPACK_SKIP_ROWS"/>, <see 
		/// cref="Gl.UNPACK_SKIP_IMAGES"/>,and <see cref="Gl.UNPACK_ALIGNMENT"/>. 
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> is set to. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.PixelStore"/> sets pixel storage modes that affect the operation of subsequent Gl.DrawPixels and 
		/// Gl.ReadPixelsas well as the unpacking of polygon stipple patterns (see Gl.PolygonStipple), bitmaps (see Gl.Bitmap), 
		/// texturepatterns (see Gl.TexImage1D, Gl.TexImage2D, Gl.TexImage3D, Gl.TexSubImage1D, Gl.TexSubImage2D, Gl.TexSubImage3D). 
		/// Additionally,if the ARB_imaging extension is supported, pixel storage modes affect convolution filters (see 
		/// Gl.ConvolutionFilter1D,Gl.ConvolutionFilter2D, and Gl.SeparableFilter2D, color table (see Gl.ColorTable, and 
		/// Gl.ColorSubTable,and unpacking histogram (See Gl.Histogram), and minmax (See Gl.Minmax) data. 
		/// <paramref name="pname"/> is a symbolic constant indicating the parameter to be set, and <paramref name="param"/> is the 
		/// newvalue. Six of the twelve storage parameters affect how pixel data is returned to client memory. They are as follows: 
		/// The other six of the twelve storage parameters affect how pixel data is read from client memory. These values are 
		/// significantfor Gl.DrawPixels, Gl.TexImage1D, Gl.TexImage2D, Gl.TexImage3D, Gl.TexSubImage1D, Gl.TexSubImage2D, 
		/// Gl.TexSubImage3D,Gl.Bitmap, and Gl.PolygonStipple. 
		/// Additionally, if the ARB_imaging extension is supported, Gl.ColorTable, Gl.ColorSubTable, Gl.ConvolutionFilter1D, 
		/// Gl.ConvolutionFilter2D,and Gl.SeparableFilter2D. They are as follows: 
		/// The following table gives the type, initial value, and range of valid values for each storage parameter that can be set 
		/// with<see cref="Gl.PixelStore"/>. 
		///  
		/// <see cref="Gl.PixelStoref"/> can be used to set any pixel store parameter. If the parameter type is boolean, then if 
		/// <paramrefname="param"/> is 0, the parameter is false; otherwise it is set to true. If <paramref name="pname"/> is a 
		/// integertype parameter, <paramref name="param"/> is rounded to the nearest integer. 
		/// Likewise, <see cref="Gl.PixelStorei"/> can also be used to set any of the pixel store parameters. Boolean parameters are 
		/// setto false if <paramref name="param"/> is 0 and true otherwise. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if a negative row length, pixel skip, or row skip value is specified, or if 
		///   alignmentis specified as other than 1, 2, 4, or 8. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.PixelStore"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.PACK_SWAP_BYTES"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_LSB_FIRST"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_ROW_LENGTH"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_IMAGE_HEIGHT"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_SKIP_ROWS"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_SKIP_PIXELS"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_SKIP_IMAGES"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_ALIGNMENT"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_SWAP_BYTES"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_LSB_FIRST"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_ROW_LENGTH"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_IMAGE_HEIGHT"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_SKIP_ROWS"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_SKIP_PIXELS"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_SKIP_IMAGES"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_ALIGNMENT"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.PolygonStipple"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void PixelStore(int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglPixelStorei != null, "pglPixelStorei not implemented");
			Delegates.pglPixelStorei(pname, param);
			CallLog("glPixelStorei({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set pixel storage modes
		/// </summary>
		/// <param name="pname">
		/// Specifies the symbolic name of the parameter to be set. Six values affect the packing of pixel data into memory: <see 
		/// cref="Gl.PACK_SWAP_BYTES"/>,<see cref="Gl.PACK_LSB_FIRST"/>, <see cref="Gl.PACK_ROW_LENGTH"/>, <see 
		/// cref="Gl.PACK_IMAGE_HEIGHT"/>,<see cref="Gl.PACK_SKIP_PIXELS"/>, <see cref="Gl.PACK_SKIP_ROWS"/>, <see 
		/// cref="Gl.PACK_SKIP_IMAGES"/>,and <see cref="Gl.PACK_ALIGNMENT"/>. Six more affect the unpacking of pixel data from 
		/// memory:<see cref="Gl.UNPACK_SWAP_BYTES"/>, <see cref="Gl.UNPACK_LSB_FIRST"/>, <see cref="Gl.UNPACK_ROW_LENGTH"/>, <see 
		/// cref="Gl.UNPACK_IMAGE_HEIGHT"/>,<see cref="Gl.UNPACK_SKIP_PIXELS"/>, <see cref="Gl.UNPACK_SKIP_ROWS"/>, <see 
		/// cref="Gl.UNPACK_SKIP_IMAGES"/>,and <see cref="Gl.UNPACK_ALIGNMENT"/>. 
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> is set to. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.PixelStore"/> sets pixel storage modes that affect the operation of subsequent Gl.DrawPixels and 
		/// Gl.ReadPixelsas well as the unpacking of polygon stipple patterns (see Gl.PolygonStipple), bitmaps (see Gl.Bitmap), 
		/// texturepatterns (see Gl.TexImage1D, Gl.TexImage2D, Gl.TexImage3D, Gl.TexSubImage1D, Gl.TexSubImage2D, Gl.TexSubImage3D). 
		/// Additionally,if the ARB_imaging extension is supported, pixel storage modes affect convolution filters (see 
		/// Gl.ConvolutionFilter1D,Gl.ConvolutionFilter2D, and Gl.SeparableFilter2D, color table (see Gl.ColorTable, and 
		/// Gl.ColorSubTable,and unpacking histogram (See Gl.Histogram), and minmax (See Gl.Minmax) data. 
		/// <paramref name="pname"/> is a symbolic constant indicating the parameter to be set, and <paramref name="param"/> is the 
		/// newvalue. Six of the twelve storage parameters affect how pixel data is returned to client memory. They are as follows: 
		/// The other six of the twelve storage parameters affect how pixel data is read from client memory. These values are 
		/// significantfor Gl.DrawPixels, Gl.TexImage1D, Gl.TexImage2D, Gl.TexImage3D, Gl.TexSubImage1D, Gl.TexSubImage2D, 
		/// Gl.TexSubImage3D,Gl.Bitmap, and Gl.PolygonStipple. 
		/// Additionally, if the ARB_imaging extension is supported, Gl.ColorTable, Gl.ColorSubTable, Gl.ConvolutionFilter1D, 
		/// Gl.ConvolutionFilter2D,and Gl.SeparableFilter2D. They are as follows: 
		/// The following table gives the type, initial value, and range of valid values for each storage parameter that can be set 
		/// with<see cref="Gl.PixelStore"/>. 
		///  
		/// <see cref="Gl.PixelStoref"/> can be used to set any pixel store parameter. If the parameter type is boolean, then if 
		/// <paramrefname="param"/> is 0, the parameter is false; otherwise it is set to true. If <paramref name="pname"/> is a 
		/// integertype parameter, <paramref name="param"/> is rounded to the nearest integer. 
		/// Likewise, <see cref="Gl.PixelStorei"/> can also be used to set any of the pixel store parameters. Boolean parameters are 
		/// setto false if <paramref name="param"/> is 0 and true otherwise. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if a negative row length, pixel skip, or row skip value is specified, or if 
		///   alignmentis specified as other than 1, 2, 4, or 8. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.PixelStore"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.PACK_SWAP_BYTES"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_LSB_FIRST"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_ROW_LENGTH"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_IMAGE_HEIGHT"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_SKIP_ROWS"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_SKIP_PIXELS"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_SKIP_IMAGES"/> 
		/// - Gl.Get with argument <see cref="Gl.PACK_ALIGNMENT"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_SWAP_BYTES"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_LSB_FIRST"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_ROW_LENGTH"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_IMAGE_HEIGHT"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_SKIP_ROWS"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_SKIP_PIXELS"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_SKIP_IMAGES"/> 
		/// - Gl.Get with argument <see cref="Gl.UNPACK_ALIGNMENT"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.PolygonStipple"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void PixelStore(PixelStoreParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglPixelStorei != null, "pglPixelStorei not implemented");
			Delegates.pglPixelStorei((int)pname, param);
			CallLog("glPixelStorei({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// select a color buffer source for pixels
		/// </summary>
		/// <param name="src">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// glReadBuffer specifies a color buffer as the source for subsequent glReadPixels, glCopyTexImage1D, glCopyTexImage2D, 
		/// glCopyTexSubImage1D,glCopyTexSubImage2D, and glCopyTexSubImage3D commands. mode accepts one of twelve or more predefined 
		/// values.In a fully configured system, GL_FRONT, GL_LEFT, and GL_FRONT_LEFT all name the front left buffer, GL_FRONT_RIGHT 
		/// andGL_RIGHT name the front right buffer, and GL_BACK_LEFT and GL_BACK name the back left buffer. Further more, the 
		/// constantsGL_COLOR_ATTACHMENTi may be used to indicate the ith color attachment where i ranges from zero to the value of 
		/// GL_MAX_COLOR_ATTACHMENTSminus one. 
		/// Nonstereo double-buffered configurations have only a front left and a back left buffer. Single-buffered configurations 
		/// havea front left and a front right buffer if stereo, and only a front left buffer if nonstereo. It is an error to 
		/// specifya nonexistent buffer to glReadBuffer. 
		/// mode is initially GL_FRONT in single-buffered configurations and GL_BACK in double-buffered configurations. 
		/// For glReadBuffer, the target framebuffer object is that bound to GL_READ_FRAMEBUFFER. For glNamedFramebufferReadBuffer, 
		/// framebuffermust either be zero or the name of the target framebuffer object. If framebuffer is zero, then the default 
		/// readframebuffer is affected. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not one of the twelve (or more) accepted values. 
		/// - GL_INVALID_OPERATION is generated if mode specifies a buffer that does not exist. 
		/// - GL_INVALID_OPERATION is generated by glNamedFramebufferReadBuffer if framebuffer is not zero or the name of an existing 
		///   framebufferobject. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_READ_BUFFER 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		public static void ReadBuffer(int src)
		{
			Debug.Assert(Delegates.pglReadBuffer != null, "pglReadBuffer not implemented");
			Delegates.pglReadBuffer(src);
			CallLog("glReadBuffer({0})", src);
			DebugCheckErrors();
		}

		/// <summary>
		/// select a color buffer source for pixels
		/// </summary>
		/// <param name="src">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// glReadBuffer specifies a color buffer as the source for subsequent glReadPixels, glCopyTexImage1D, glCopyTexImage2D, 
		/// glCopyTexSubImage1D,glCopyTexSubImage2D, and glCopyTexSubImage3D commands. mode accepts one of twelve or more predefined 
		/// values.In a fully configured system, GL_FRONT, GL_LEFT, and GL_FRONT_LEFT all name the front left buffer, GL_FRONT_RIGHT 
		/// andGL_RIGHT name the front right buffer, and GL_BACK_LEFT and GL_BACK name the back left buffer. Further more, the 
		/// constantsGL_COLOR_ATTACHMENTi may be used to indicate the ith color attachment where i ranges from zero to the value of 
		/// GL_MAX_COLOR_ATTACHMENTSminus one. 
		/// Nonstereo double-buffered configurations have only a front left and a back left buffer. Single-buffered configurations 
		/// havea front left and a front right buffer if stereo, and only a front left buffer if nonstereo. It is an error to 
		/// specifya nonexistent buffer to glReadBuffer. 
		/// mode is initially GL_FRONT in single-buffered configurations and GL_BACK in double-buffered configurations. 
		/// For glReadBuffer, the target framebuffer object is that bound to GL_READ_FRAMEBUFFER. For glNamedFramebufferReadBuffer, 
		/// framebuffermust either be zero or the name of the target framebuffer object. If framebuffer is zero, then the default 
		/// readframebuffer is affected. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not one of the twelve (or more) accepted values. 
		/// - GL_INVALID_OPERATION is generated if mode specifies a buffer that does not exist. 
		/// - GL_INVALID_OPERATION is generated by glNamedFramebufferReadBuffer if framebuffer is not zero or the name of an existing 
		///   framebufferobject. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_READ_BUFFER 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		public static void ReadBuffer(ReadBufferMode src)
		{
			Debug.Assert(Delegates.pglReadBuffer != null, "pglReadBuffer not implemented");
			Delegates.pglReadBuffer((int)src);
			CallLog("glReadBuffer({0})", src);
			DebugCheckErrors();
		}

		/// <summary>
		/// read a block of pixels from the frame buffer
		/// </summary>
		/// <param name="x">
		/// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left 
		/// cornerof a rectangular block of pixels. 
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left 
		/// cornerof a rectangular block of pixels. 
		/// </param>
		/// <param name="width">
		/// Specify the dimensions of the pixel rectangle. <paramref name="width"/> and <paramref name="height"/> of one correspond 
		/// toa single pixel. 
		/// </param>
		/// <param name="height">
		/// Specify the dimensions of the pixel rectangle. <paramref name="width"/> and <paramref name="height"/> of one correspond 
		/// toa single pixel. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.STENCIL_INDEX"/>,<see cref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see 
		/// cref="Gl.BLUE"/>,<see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see 
		/// cref="Gl.BGRA"/>,<see cref="Gl.LUMINANCE"/>, and <see cref="Gl.LUMINANCE_ALPHA"/>. 
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. Must be one of <see cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.BYTE"/>, <see 
		/// cref="Gl.BITMAP"/>,<see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_INT"/>, <see 
		/// cref="Gl.INT"/>,<see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, 
		/// <seecref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, 
		/// <seecref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, <see 
		/// cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>,<see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.ReadPixels"/> returns pixel data from the frame buffer, starting with the pixel whose lower left corner is 
		/// atlocation (<paramref name="x"/>, <paramref name="y"/>), into client memory starting at location <paramref 
		/// name="data"/>.Several parameters control the processing of the pixel data before it is placed into client memory. These 
		/// parametersare set with three commands: Gl.PixelStore, Gl.PixelTransfer, and Gl.PixelMap. This reference page describes 
		/// theeffects on <see cref="Gl.ReadPixels"/> of most, but not all of the parameters specified by these three commands. 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_PACK_BUFFER"/> target (see Gl.BindBuffer) while a 
		/// blockof pixels is requested, <paramref name="data"/> is treated as a byte offset into the buffer object's data store 
		/// ratherthan a pointer to client memory. 
		/// When the ARB_imaging extension is supported, the pixel data may be processed by additional operations including color 
		/// tablelookup, color matrix transformations, convolutions, histograms, and minimum and maximum pixel value computations. 
		/// <see cref="Gl.ReadPixels"/> returns values from each pixel with lower left corner at x+iy+j for 0&lt;=i&lt;width and 
		/// 0&lt;=j&lt;height.This pixel is said to be the ith pixel in the jth row. Pixels are returned in row order from the 
		/// lowestto the highest row, left to right in each row. 
		/// <paramref name="format"/> specifies the format for the returned pixel values; accepted values are: 
		/// The shift, scale, bias, and lookup factors just described are all specified by Gl.PixelTransfer. The lookup table 
		/// contentsthemselves are specified by Gl.PixelMap. 
		/// Finally, the indices or components are converted to the proper format, as specified by <paramref name="type"/>. If 
		/// <paramrefname="format"/> is <see cref="Gl.COLOR_INDEX"/> or <see cref="Gl.STENCIL_INDEX"/> and <paramref name="type"/> 
		/// isnot <see cref="Gl.FLOAT"/>, each index is masked with the mask value given in the following table. If <paramref 
		/// name="type"/>is <see cref="Gl.FLOAT"/>, then each integer index is converted to single-precision floating-point format. 
		/// If <paramref name="format"/> is <see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see 
		/// cref="Gl.ALPHA"/>,<see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see 
		/// cref="Gl.LUMINANCE"/>,or <see cref="Gl.LUMINANCE_ALPHA"/> and <paramref name="type"/> is not <see cref="Gl.FLOAT"/>, 
		/// eachcomponent is multiplied by the multiplier shown in the following table. If type is <see cref="Gl.FLOAT"/>, then each 
		/// componentis passed as is (or converted to the client's single-precision floating-point format if it is different from 
		/// theone used by the GL). 
		///  
		/// Return values are placed in memory as follows. If <paramref name="format"/> is <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.STENCIL_INDEX"/>,<see cref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see 
		/// cref="Gl.BLUE"/>,<see cref="Gl.ALPHA"/>, or <see cref="Gl.LUMINANCE"/>, a single value is returned and the data for the 
		/// ithpixel in the jth row is placed in location j⁢width+i. <see cref="Gl.RGB"/> and <see cref="Gl.BGR"/> return three 
		/// values,<see cref="Gl.RGBA"/> and <see cref="Gl.BGRA"/> return four values, and <see cref="Gl.LUMINANCE_ALPHA"/> returns 
		/// twovalues for each pixel, with all values corresponding to a single pixel occupying contiguous space in <paramref 
		/// name="data"/>.Storage parameters set by Gl.PixelStore, such as <see cref="Gl.PACK_LSB_FIRST"/> and <see 
		/// cref="Gl.PACK_SWAP_BYTES"/>,affect the way that data is written into memory. See Gl.PixelStore for a description. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> or <paramref name="type"/> is not an accepted 
		///   value.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is <see cref="Gl.BITMAP"/> and <paramref 
		///   name="format"/>is not <see cref="Gl.COLOR_INDEX"/> or <see cref="Gl.STENCIL_INDEX"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if either <paramref name="width"/> or <paramref name="height"/> is negative. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is <see cref="Gl.COLOR_INDEX"/> and the 
		///   colorbuffers store RGBA color components. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is <see cref="Gl.STENCIL_INDEX"/> and there 
		///   isno stencil buffer. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is <see cref="Gl.DEPTH_COMPONENT"/> and 
		///   thereis no depth buffer. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>,<see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or <see 
		///   cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>and <paramref name="format"/> is not <see cref="Gl.RGB"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, 
		///   <seecref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, <see 
		///   cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>,<see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - The formats <see cref="Gl.BGR"/>, and <see cref="Gl.BGRA"/> and types <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		///   cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>,<see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		///   <seecref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>,<see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <seecref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>are available only if the GL version is 1.2 or greater. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/>target and the data would be packed to the buffer object such that the memory writes 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/>target and <paramref name="data"/> is not evenly divisible into the number of bytes needed 
		///   tostore in memory a datum indicated by <paramref name="type"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ReadPixels"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.INDEX_MODE"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_PACK_BUFFER_BINDING"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		public static void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, int format, int type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglReadPixels != null, "pglReadPixels not implemented");
			Delegates.pglReadPixels(x, y, width, height, format, type, pixels);
			CallLog("glReadPixels({0}, {1}, {2}, {3}, {4}, {5}, {6})", x, y, width, height, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// read a block of pixels from the frame buffer
		/// </summary>
		/// <param name="x">
		/// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left 
		/// cornerof a rectangular block of pixels. 
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left 
		/// cornerof a rectangular block of pixels. 
		/// </param>
		/// <param name="width">
		/// Specify the dimensions of the pixel rectangle. <paramref name="width"/> and <paramref name="height"/> of one correspond 
		/// toa single pixel. 
		/// </param>
		/// <param name="height">
		/// Specify the dimensions of the pixel rectangle. <paramref name="width"/> and <paramref name="height"/> of one correspond 
		/// toa single pixel. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.STENCIL_INDEX"/>,<see cref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see 
		/// cref="Gl.BLUE"/>,<see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see 
		/// cref="Gl.BGRA"/>,<see cref="Gl.LUMINANCE"/>, and <see cref="Gl.LUMINANCE_ALPHA"/>. 
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. Must be one of <see cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.BYTE"/>, <see 
		/// cref="Gl.BITMAP"/>,<see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_INT"/>, <see 
		/// cref="Gl.INT"/>,<see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, 
		/// <seecref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, 
		/// <seecref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, <see 
		/// cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>,<see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.ReadPixels"/> returns pixel data from the frame buffer, starting with the pixel whose lower left corner is 
		/// atlocation (<paramref name="x"/>, <paramref name="y"/>), into client memory starting at location <paramref 
		/// name="data"/>.Several parameters control the processing of the pixel data before it is placed into client memory. These 
		/// parametersare set with three commands: Gl.PixelStore, Gl.PixelTransfer, and Gl.PixelMap. This reference page describes 
		/// theeffects on <see cref="Gl.ReadPixels"/> of most, but not all of the parameters specified by these three commands. 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_PACK_BUFFER"/> target (see Gl.BindBuffer) while a 
		/// blockof pixels is requested, <paramref name="data"/> is treated as a byte offset into the buffer object's data store 
		/// ratherthan a pointer to client memory. 
		/// When the ARB_imaging extension is supported, the pixel data may be processed by additional operations including color 
		/// tablelookup, color matrix transformations, convolutions, histograms, and minimum and maximum pixel value computations. 
		/// <see cref="Gl.ReadPixels"/> returns values from each pixel with lower left corner at x+iy+j for 0&lt;=i&lt;width and 
		/// 0&lt;=j&lt;height.This pixel is said to be the ith pixel in the jth row. Pixels are returned in row order from the 
		/// lowestto the highest row, left to right in each row. 
		/// <paramref name="format"/> specifies the format for the returned pixel values; accepted values are: 
		/// The shift, scale, bias, and lookup factors just described are all specified by Gl.PixelTransfer. The lookup table 
		/// contentsthemselves are specified by Gl.PixelMap. 
		/// Finally, the indices or components are converted to the proper format, as specified by <paramref name="type"/>. If 
		/// <paramrefname="format"/> is <see cref="Gl.COLOR_INDEX"/> or <see cref="Gl.STENCIL_INDEX"/> and <paramref name="type"/> 
		/// isnot <see cref="Gl.FLOAT"/>, each index is masked with the mask value given in the following table. If <paramref 
		/// name="type"/>is <see cref="Gl.FLOAT"/>, then each integer index is converted to single-precision floating-point format. 
		/// If <paramref name="format"/> is <see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see 
		/// cref="Gl.ALPHA"/>,<see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see 
		/// cref="Gl.LUMINANCE"/>,or <see cref="Gl.LUMINANCE_ALPHA"/> and <paramref name="type"/> is not <see cref="Gl.FLOAT"/>, 
		/// eachcomponent is multiplied by the multiplier shown in the following table. If type is <see cref="Gl.FLOAT"/>, then each 
		/// componentis passed as is (or converted to the client's single-precision floating-point format if it is different from 
		/// theone used by the GL). 
		///  
		/// Return values are placed in memory as follows. If <paramref name="format"/> is <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.STENCIL_INDEX"/>,<see cref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see 
		/// cref="Gl.BLUE"/>,<see cref="Gl.ALPHA"/>, or <see cref="Gl.LUMINANCE"/>, a single value is returned and the data for the 
		/// ithpixel in the jth row is placed in location j⁢width+i. <see cref="Gl.RGB"/> and <see cref="Gl.BGR"/> return three 
		/// values,<see cref="Gl.RGBA"/> and <see cref="Gl.BGRA"/> return four values, and <see cref="Gl.LUMINANCE_ALPHA"/> returns 
		/// twovalues for each pixel, with all values corresponding to a single pixel occupying contiguous space in <paramref 
		/// name="data"/>.Storage parameters set by Gl.PixelStore, such as <see cref="Gl.PACK_LSB_FIRST"/> and <see 
		/// cref="Gl.PACK_SWAP_BYTES"/>,affect the way that data is written into memory. See Gl.PixelStore for a description. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> or <paramref name="type"/> is not an accepted 
		///   value.
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is <see cref="Gl.BITMAP"/> and <paramref 
		///   name="format"/>is not <see cref="Gl.COLOR_INDEX"/> or <see cref="Gl.STENCIL_INDEX"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if either <paramref name="width"/> or <paramref name="height"/> is negative. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is <see cref="Gl.COLOR_INDEX"/> and the 
		///   colorbuffers store RGBA color components. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is <see cref="Gl.STENCIL_INDEX"/> and there 
		///   isno stencil buffer. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is <see cref="Gl.DEPTH_COMPONENT"/> and 
		///   thereis no depth buffer. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>,<see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or <see 
		///   cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>and <paramref name="format"/> is not <see cref="Gl.RGB"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, 
		///   <seecref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, <see 
		///   cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>,<see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - The formats <see cref="Gl.BGR"/>, and <see cref="Gl.BGRA"/> and types <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		///   cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>,<see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		///   <seecref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		///   cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>,<see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		///   <seecref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>are available only if the GL version is 1.2 or greater. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/>target and the data would be packed to the buffer object such that the memory writes 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/>target and <paramref name="data"/> is not evenly divisible into the number of bytes needed 
		///   tostore in memory a datum indicated by <paramref name="type"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ReadPixels"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.INDEX_MODE"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_PACK_BUFFER_BINDING"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		public static void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglReadPixels != null, "pglReadPixels not implemented");
			Delegates.pglReadPixels(x, y, width, height, (int)format, (int)type, pixels);
			CallLog("glReadPixels({0}, {1}, {2}, {3}, {4}, {5}, {6})", x, y, width, height, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// areaccepted. 
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter. 
		/// </param>
		/// <remarks>
		/// These commands return values for simple state variables in GL. pname is a symbolic constant indicating the state 
		/// variableto be returned, and data is a pointer to an array of the indicated type in which to place the returned data. 
		/// Type conversion is performed if data has a different type than the state variable value being requested. If 
		/// glGetBooleanvis called, a floating-point (or integer) value is converted to GL_FALSE if and only if it is 0.0 (or 0). 
		/// Otherwise,it is converted to GL_TRUE. If glGetIntegerv is called, boolean values are returned as GL_TRUE or GL_FALSE, 
		/// andmost floating-point values are rounded to the nearest integer value. Floating-point colors and normals, however, are 
		/// returnedwith a linear mapping that maps 1.0 to the most positive representable integer value and -1.0 to the most 
		/// negativerepresentable integer value. If glGetFloatv or glGetDoublev is called, boolean values are returned as GL_TRUE or 
		/// GL_FALSE,and integer values are converted to floating-point values. 
		/// The following symbolic constants are accepted by pname: 
		/// Many of the boolean parameters can also be queried more easily using glIsEnabled. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_VALUE is generated on any of glGetBooleani_v, glGetIntegeri_v, or glGetInteger64i_v if index is outside of 
		///   thevalid range for the indexed state target. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		public static void GetBoolean(int pname, bool[] data)
		{
			unsafe {
				fixed (bool* p_data = data)
				{
					Debug.Assert(Delegates.pglGetBooleanv != null, "pglGetBooleanv not implemented");
					Delegates.pglGetBooleanv(pname, p_data);
					CallLog("glGetBooleanv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// areaccepted. 
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter. 
		/// </param>
		/// <remarks>
		/// These commands return values for simple state variables in GL. pname is a symbolic constant indicating the state 
		/// variableto be returned, and data is a pointer to an array of the indicated type in which to place the returned data. 
		/// Type conversion is performed if data has a different type than the state variable value being requested. If 
		/// glGetBooleanvis called, a floating-point (or integer) value is converted to GL_FALSE if and only if it is 0.0 (or 0). 
		/// Otherwise,it is converted to GL_TRUE. If glGetIntegerv is called, boolean values are returned as GL_TRUE or GL_FALSE, 
		/// andmost floating-point values are rounded to the nearest integer value. Floating-point colors and normals, however, are 
		/// returnedwith a linear mapping that maps 1.0 to the most positive representable integer value and -1.0 to the most 
		/// negativerepresentable integer value. If glGetFloatv or glGetDoublev is called, boolean values are returned as GL_TRUE or 
		/// GL_FALSE,and integer values are converted to floating-point values. 
		/// The following symbolic constants are accepted by pname: 
		/// Many of the boolean parameters can also be queried more easily using glIsEnabled. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_VALUE is generated on any of glGetBooleani_v, glGetIntegeri_v, or glGetInteger64i_v if index is outside of 
		///   thevalid range for the indexed state target. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		public static void GetBoolean(GetPName pname, bool[] data)
		{
			unsafe {
				fixed (bool* p_data = data)
				{
					Debug.Assert(Delegates.pglGetBooleanv != null, "pglGetBooleanv not implemented");
					Delegates.pglGetBooleanv((int)pname, p_data);
					CallLog("glGetBooleanv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// areaccepted. 
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter. 
		/// </param>
		/// <remarks>
		/// These commands return values for simple state variables in GL. pname is a symbolic constant indicating the state 
		/// variableto be returned, and data is a pointer to an array of the indicated type in which to place the returned data. 
		/// Type conversion is performed if data has a different type than the state variable value being requested. If 
		/// glGetBooleanvis called, a floating-point (or integer) value is converted to GL_FALSE if and only if it is 0.0 (or 0). 
		/// Otherwise,it is converted to GL_TRUE. If glGetIntegerv is called, boolean values are returned as GL_TRUE or GL_FALSE, 
		/// andmost floating-point values are rounded to the nearest integer value. Floating-point colors and normals, however, are 
		/// returnedwith a linear mapping that maps 1.0 to the most positive representable integer value and -1.0 to the most 
		/// negativerepresentable integer value. If glGetFloatv or glGetDoublev is called, boolean values are returned as GL_TRUE or 
		/// GL_FALSE,and integer values are converted to floating-point values. 
		/// The following symbolic constants are accepted by pname: 
		/// Many of the boolean parameters can also be queried more easily using glIsEnabled. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_VALUE is generated on any of glGetBooleani_v, glGetIntegeri_v, or glGetInteger64i_v if index is outside of 
		///   thevalid range for the indexed state target. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		public static void GetDouble(int pname, double[] data)
		{
			unsafe {
				fixed (double* p_data = data)
				{
					Debug.Assert(Delegates.pglGetDoublev != null, "pglGetDoublev not implemented");
					Delegates.pglGetDoublev(pname, p_data);
					CallLog("glGetDoublev({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// areaccepted. 
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter. 
		/// </param>
		/// <remarks>
		/// These commands return values for simple state variables in GL. pname is a symbolic constant indicating the state 
		/// variableto be returned, and data is a pointer to an array of the indicated type in which to place the returned data. 
		/// Type conversion is performed if data has a different type than the state variable value being requested. If 
		/// glGetBooleanvis called, a floating-point (or integer) value is converted to GL_FALSE if and only if it is 0.0 (or 0). 
		/// Otherwise,it is converted to GL_TRUE. If glGetIntegerv is called, boolean values are returned as GL_TRUE or GL_FALSE, 
		/// andmost floating-point values are rounded to the nearest integer value. Floating-point colors and normals, however, are 
		/// returnedwith a linear mapping that maps 1.0 to the most positive representable integer value and -1.0 to the most 
		/// negativerepresentable integer value. If glGetFloatv or glGetDoublev is called, boolean values are returned as GL_TRUE or 
		/// GL_FALSE,and integer values are converted to floating-point values. 
		/// The following symbolic constants are accepted by pname: 
		/// Many of the boolean parameters can also be queried more easily using glIsEnabled. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_VALUE is generated on any of glGetBooleani_v, glGetIntegeri_v, or glGetInteger64i_v if index is outside of 
		///   thevalid range for the indexed state target. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		public static void GetDouble(GetPName pname, double[] data)
		{
			unsafe {
				fixed (double* p_data = data)
				{
					Debug.Assert(Delegates.pglGetDoublev != null, "pglGetDoublev not implemented");
					Delegates.pglGetDoublev((int)pname, p_data);
					CallLog("glGetDoublev({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return error information
		/// </summary>
		/// <remarks>
		/// glGetError returns the value of the error flag. Each detectable error is assigned a numeric code and symbolic name. When 
		/// anerror occurs, the error flag is set to the appropriate error code value. No other errors are recorded until glGetError 
		/// iscalled, the error code is returned, and the flag is reset to GL_NO_ERROR. If a call to glGetError returns GL_NO_ERROR, 
		/// therehas been no detectable error since the last call to glGetError, or since the GL was initialized. 
		/// To allow for distributed implementations, there may be several error flags. If any single error flag has recorded an 
		/// error,the value of that flag is returned and that flag is reset to GL_NO_ERROR when glGetError is called. If more than 
		/// oneflag has recorded an error, glGetError returns and clears an arbitrary error flag value. Thus, glGetError should 
		/// alwaysbe called in a loop, until it returns GL_NO_ERROR, if all error flags are to be reset. 
		/// Initially, all error flags are set to GL_NO_ERROR. 
		/// The following errors are currently defined: 
		/// When an error flag is set, results of a GL operation are undefined only if GL_OUT_OF_MEMORY has occurred. In all other 
		/// cases,the command generating the error is ignored and has no effect on the GL state or frame buffer contents. If the 
		/// generatingcommand returns a value, it returns 0. If glGetError itself generates an error, it returns 0. 
		/// </remarks>
		public static ErrorCode GetError()
		{
			ErrorCode retValue;

			Debug.Assert(Delegates.pglGetError != null, "pglGetError not implemented");
			retValue = (ErrorCode)Delegates.pglGetError();
			CallLog("glGetError() = {0}", retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// areaccepted. 
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter. 
		/// </param>
		/// <remarks>
		/// These commands return values for simple state variables in GL. pname is a symbolic constant indicating the state 
		/// variableto be returned, and data is a pointer to an array of the indicated type in which to place the returned data. 
		/// Type conversion is performed if data has a different type than the state variable value being requested. If 
		/// glGetBooleanvis called, a floating-point (or integer) value is converted to GL_FALSE if and only if it is 0.0 (or 0). 
		/// Otherwise,it is converted to GL_TRUE. If glGetIntegerv is called, boolean values are returned as GL_TRUE or GL_FALSE, 
		/// andmost floating-point values are rounded to the nearest integer value. Floating-point colors and normals, however, are 
		/// returnedwith a linear mapping that maps 1.0 to the most positive representable integer value and -1.0 to the most 
		/// negativerepresentable integer value. If glGetFloatv or glGetDoublev is called, boolean values are returned as GL_TRUE or 
		/// GL_FALSE,and integer values are converted to floating-point values. 
		/// The following symbolic constants are accepted by pname: 
		/// Many of the boolean parameters can also be queried more easily using glIsEnabled. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_VALUE is generated on any of glGetBooleani_v, glGetIntegeri_v, or glGetInteger64i_v if index is outside of 
		///   thevalid range for the indexed state target. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		public static void GetFloat(int pname, float[] data)
		{
			unsafe {
				fixed (float* p_data = data)
				{
					Debug.Assert(Delegates.pglGetFloatv != null, "pglGetFloatv not implemented");
					Delegates.pglGetFloatv(pname, p_data);
					CallLog("glGetFloatv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// areaccepted. 
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter. 
		/// </param>
		/// <remarks>
		/// These commands return values for simple state variables in GL. pname is a symbolic constant indicating the state 
		/// variableto be returned, and data is a pointer to an array of the indicated type in which to place the returned data. 
		/// Type conversion is performed if data has a different type than the state variable value being requested. If 
		/// glGetBooleanvis called, a floating-point (or integer) value is converted to GL_FALSE if and only if it is 0.0 (or 0). 
		/// Otherwise,it is converted to GL_TRUE. If glGetIntegerv is called, boolean values are returned as GL_TRUE or GL_FALSE, 
		/// andmost floating-point values are rounded to the nearest integer value. Floating-point colors and normals, however, are 
		/// returnedwith a linear mapping that maps 1.0 to the most positive representable integer value and -1.0 to the most 
		/// negativerepresentable integer value. If glGetFloatv or glGetDoublev is called, boolean values are returned as GL_TRUE or 
		/// GL_FALSE,and integer values are converted to floating-point values. 
		/// The following symbolic constants are accepted by pname: 
		/// Many of the boolean parameters can also be queried more easily using glIsEnabled. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_VALUE is generated on any of glGetBooleani_v, glGetIntegeri_v, or glGetInteger64i_v if index is outside of 
		///   thevalid range for the indexed state target. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		public static void GetFloat(GetPName pname, float[] data)
		{
			unsafe {
				fixed (float* p_data = data)
				{
					Debug.Assert(Delegates.pglGetFloatv != null, "pglGetFloatv not implemented");
					Delegates.pglGetFloatv((int)pname, p_data);
					CallLog("glGetFloatv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// areaccepted. 
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter. 
		/// </param>
		/// <remarks>
		/// These commands return values for simple state variables in GL. pname is a symbolic constant indicating the state 
		/// variableto be returned, and data is a pointer to an array of the indicated type in which to place the returned data. 
		/// Type conversion is performed if data has a different type than the state variable value being requested. If 
		/// glGetBooleanvis called, a floating-point (or integer) value is converted to GL_FALSE if and only if it is 0.0 (or 0). 
		/// Otherwise,it is converted to GL_TRUE. If glGetIntegerv is called, boolean values are returned as GL_TRUE or GL_FALSE, 
		/// andmost floating-point values are rounded to the nearest integer value. Floating-point colors and normals, however, are 
		/// returnedwith a linear mapping that maps 1.0 to the most positive representable integer value and -1.0 to the most 
		/// negativerepresentable integer value. If glGetFloatv or glGetDoublev is called, boolean values are returned as GL_TRUE or 
		/// GL_FALSE,and integer values are converted to floating-point values. 
		/// The following symbolic constants are accepted by pname: 
		/// Many of the boolean parameters can also be queried more easily using glIsEnabled. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_VALUE is generated on any of glGetBooleani_v, glGetIntegeri_v, or glGetInteger64i_v if index is outside of 
		///   thevalid range for the indexed state target. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		public static void GetInteger(int pname, Int32[] data)
		{
			unsafe {
				fixed (Int32* p_data = data)
				{
					Debug.Assert(Delegates.pglGetIntegerv != null, "pglGetIntegerv not implemented");
					Delegates.pglGetIntegerv(pname, p_data);
					CallLog("glGetIntegerv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// areaccepted. 
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter. 
		/// </param>
		/// <remarks>
		/// These commands return values for simple state variables in GL. pname is a symbolic constant indicating the state 
		/// variableto be returned, and data is a pointer to an array of the indicated type in which to place the returned data. 
		/// Type conversion is performed if data has a different type than the state variable value being requested. If 
		/// glGetBooleanvis called, a floating-point (or integer) value is converted to GL_FALSE if and only if it is 0.0 (or 0). 
		/// Otherwise,it is converted to GL_TRUE. If glGetIntegerv is called, boolean values are returned as GL_TRUE or GL_FALSE, 
		/// andmost floating-point values are rounded to the nearest integer value. Floating-point colors and normals, however, are 
		/// returnedwith a linear mapping that maps 1.0 to the most positive representable integer value and -1.0 to the most 
		/// negativerepresentable integer value. If glGetFloatv or glGetDoublev is called, boolean values are returned as GL_TRUE or 
		/// GL_FALSE,and integer values are converted to floating-point values. 
		/// The following symbolic constants are accepted by pname: 
		/// Many of the boolean parameters can also be queried more easily using glIsEnabled. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_VALUE is generated on any of glGetBooleani_v, glGetIntegeri_v, or glGetInteger64i_v if index is outside of 
		///   thevalid range for the indexed state target. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		public static void GetInteger(GetPName pname, Int32[] data)
		{
			unsafe {
				fixed (Int32* p_data = data)
				{
					Debug.Assert(Delegates.pglGetIntegerv != null, "pglGetIntegerv not implemented");
					Delegates.pglGetIntegerv((int)pname, p_data);
					CallLog("glGetIntegerv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return a string describing the current GL connection
		/// </summary>
		/// <param name="name">
		/// Specifies a symbolic constant, one of GL_VENDOR, GL_RENDERER, GL_VERSION, or GL_SHADING_LANGUAGE_VERSION. Additionally, 
		/// glGetStringiaccepts the GL_EXTENSIONS token. 
		/// </param>
		/// <remarks>
		/// glGetString returns a pointer to a static string describing some aspect of the current GL connection. name can be one of 
		/// thefollowing: 
		/// glGetStringi returns a pointer to a static string indexed by index. name can be one of the following: 
		/// Strings GL_VENDOR and GL_RENDERER together uniquely specify a platform. They do not change from release to release and 
		/// shouldbe used by platform-recognition algorithms. 
		/// The GL_VERSION and GL_SHADING_LANGUAGE_VERSION strings begin with a version number. The version number uses one of these 
		/// forms:
		/// major_number.minor_numbermajor_number.minor_number.release_number 
		/// Vendor-specific information may follow the version number. Its format depends on the implementation, but a space always 
		/// separatesthe version number and the vendor-specific information. 
		/// All strings are null-terminated. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if name is not an accepted value. 
		/// - GL_INVALID_VALUE is generated by glGetStringi if index is outside the valid range for indexed state name. 
		/// </para>
		/// </remarks>
		public static String GetString(int name)
		{
			String retValue;

			Debug.Assert(Delegates.pglGetString != null, "pglGetString not implemented");
			retValue = (String)Marshal.PtrToStringAnsi(Delegates.pglGetString(name));
			CallLog("glGetString({0}) = {1}", name, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// return a string describing the current GL connection
		/// </summary>
		/// <param name="name">
		/// Specifies a symbolic constant, one of GL_VENDOR, GL_RENDERER, GL_VERSION, or GL_SHADING_LANGUAGE_VERSION. Additionally, 
		/// glGetStringiaccepts the GL_EXTENSIONS token. 
		/// </param>
		/// <remarks>
		/// glGetString returns a pointer to a static string describing some aspect of the current GL connection. name can be one of 
		/// thefollowing: 
		/// glGetStringi returns a pointer to a static string indexed by index. name can be one of the following: 
		/// Strings GL_VENDOR and GL_RENDERER together uniquely specify a platform. They do not change from release to release and 
		/// shouldbe used by platform-recognition algorithms. 
		/// The GL_VERSION and GL_SHADING_LANGUAGE_VERSION strings begin with a version number. The version number uses one of these 
		/// forms:
		/// major_number.minor_numbermajor_number.minor_number.release_number 
		/// Vendor-specific information may follow the version number. Its format depends on the implementation, but a space always 
		/// separatesthe version number and the vendor-specific information. 
		/// All strings are null-terminated. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if name is not an accepted value. 
		/// - GL_INVALID_VALUE is generated by glGetStringi if index is outside the valid range for indexed state name. 
		/// </para>
		/// </remarks>
		public static String GetString(StringName name)
		{
			String retValue;

			Debug.Assert(Delegates.pglGetString != null, "pglGetString not implemented");
			retValue = (String)Marshal.PtrToStringAnsi(Delegates.pglGetString((int)name));
			CallLog("glGetString({0}) = {1}", name, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// return a texture image
		/// </summary>
		/// <param name="target">
		/// Specifies which texture is to be obtained. <see cref="Gl.TEXTURE_1D"/>, <see cref="Gl.TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_3D"/>,<see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>,and <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/> are accepted. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reductionimage. 
		/// </param>
		/// <param name="format">
		/// Specifies a pixel format for the returned data. The supported formats are <see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, 
		/// <seecref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see 
		/// cref="Gl.BGRA"/>,<see cref="Gl.LUMINANCE"/>, and <see cref="Gl.LUMINANCE_ALPHA"/>. 
		/// </param>
		/// <param name="type">
		/// Specifies a pixel type for the returned data. The supported types are <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>,<see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_INT"/>, <see 
		/// cref="Gl.INT"/>,<see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, 
		/// <seecref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, 
		/// <seecref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, <see 
		/// cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>,<see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.GetTexImage"/> returns a texture image into <paramref name="img"/>. <paramref name="target"/> specifies 
		/// whetherthe desired texture image is one specified by Gl.TexImage1D (<see cref="Gl.TEXTURE_1D"/>), Gl.TexImage2D (<see 
		/// cref="Gl.TEXTURE_2D"/>or any of <see cref="Gl.TEXTURE_CUBE_MAP_*"/>), or Gl.TexImage3D (<see cref="Gl.TEXTURE_3D"/>). 
		/// <paramrefname="level"/> specifies the level-of-detail number of the desired image. <paramref name="format"/> and 
		/// <paramrefname="type"/> specify the format and type of the desired image array. See the reference pages Gl.TexImage1D and 
		/// Gl.DrawPixelsfor a description of the acceptable values for the <paramref name="format"/> and <paramref name="type"/> 
		/// parameters,respectively. 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_PACK_BUFFER"/> target (see Gl.BindBuffer) while a 
		/// textureimage is requested, <paramref name="img"/> is treated as a byte offset into the buffer object's data store. 
		/// To understand the operation of <see cref="Gl.GetTexImage"/>, consider the selected internal four-component texture image 
		/// tobe an RGBA color buffer the size of the image. The semantics of <see cref="Gl.GetTexImage"/> are then identical to 
		/// thoseof Gl.ReadPixels, with the exception that no pixel transfer operations are performed, when called with the same 
		/// <paramrefname="format"/> and <paramref name="type"/>, with x and y set to 0, width set to the width of the texture image 
		/// (includingborder if one was specified), and height set to 1 for 1D images, or to the height of the texture image 
		/// (includingborder if one was specified) for 2D images. Because the internal texture image is an RGBA image, pixel formats 
		/// <seecref="Gl.COLOR_INDEX"/>, <see cref="Gl.STENCIL_INDEX"/>, and <see cref="Gl.DEPTH_COMPONENT"/> are not accepted, and 
		/// pixeltype <see cref="Gl.BITMAP"/> is not accepted. 
		/// If the selected texture image does not contain four components, the following mappings are applied. Single-component 
		/// texturesare treated as RGBA buffers with red set to the single-component value, green set to 0, blue set to 0, and alpha 
		/// setto 1. Two-component textures are treated as RGBA buffers with red set to the value of component zero, alpha set to 
		/// thevalue of component one, and green and blue set to 0. Finally, three-component textures are treated as RGBA buffers 
		/// withred set to component zero, green set to component one, blue set to component two, and alpha set to 1. 
		/// To determine the required size of <paramref name="img"/>, use Gl.GetTexLevelParameter to determine the dimensions of the 
		/// internaltexture image, then scale the required number of pixels by the storage required for each pixel, based on 
		/// <paramrefname="format"/> and <paramref name="type"/>. Be sure to take the pixel storage parameters into account, 
		/// especially<see cref="Gl.PACK_ALIGNMENT"/>. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/>, <paramref name="format"/>, or <paramref 
		///   name="type"/>is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0. 
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the 
		///   returnedvalue of <see cref="Gl.MAX_TEXTURE_SIZE"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is returned if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>,<see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or <see 
		///   cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>and <paramref name="format"/> is not <see cref="Gl.RGB"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is returned if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, 
		///   <seecref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, <see 
		///   cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>,<see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>,and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> or <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/>target and the data would be packed to the buffer object such that the memory writes 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/>target and <paramref name="img"/> is not evenly divisible into the number of bytes needed 
		///   tostore in memory a datum indicated by <paramref name="type"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetTexImage"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexLevelParameter with argument <see cref="Gl.TEXTURE_WIDTH"/> 
		/// - Gl.GetTexLevelParameter with argument <see cref="Gl.TEXTURE_HEIGHT"/> 
		/// - Gl.GetTexLevelParameter with argument <see cref="Gl.TEXTURE_BORDER"/> 
		/// - Gl.GetTexLevelParameter with argument <see cref="Gl.TEXTURE_INTERNAL_FORMAT"/> 
		/// - Gl.Get with arguments <see cref="Gl.PACK_ALIGNMENT"/> and others 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_PACK_BUFFER_BINDING"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void GetTexImage(int target, Int32 level, int format, int type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetTexImage != null, "pglGetTexImage not implemented");
			Delegates.pglGetTexImage(target, level, format, type, pixels);
			CallLog("glGetTexImage({0}, {1}, {2}, {3}, {4})", target, level, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// return a texture image
		/// </summary>
		/// <param name="target">
		/// Specifies which texture is to be obtained. <see cref="Gl.TEXTURE_1D"/>, <see cref="Gl.TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_3D"/>,<see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>,and <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/> are accepted. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reductionimage. 
		/// </param>
		/// <param name="format">
		/// Specifies a pixel format for the returned data. The supported formats are <see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, 
		/// <seecref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see 
		/// cref="Gl.BGRA"/>,<see cref="Gl.LUMINANCE"/>, and <see cref="Gl.LUMINANCE_ALPHA"/>. 
		/// </param>
		/// <param name="type">
		/// Specifies a pixel type for the returned data. The supported types are <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>,<see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_INT"/>, <see 
		/// cref="Gl.INT"/>,<see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, 
		/// <seecref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, 
		/// <seecref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, <see 
		/// cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>,<see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.GetTexImage"/> returns a texture image into <paramref name="img"/>. <paramref name="target"/> specifies 
		/// whetherthe desired texture image is one specified by Gl.TexImage1D (<see cref="Gl.TEXTURE_1D"/>), Gl.TexImage2D (<see 
		/// cref="Gl.TEXTURE_2D"/>or any of <see cref="Gl.TEXTURE_CUBE_MAP_*"/>), or Gl.TexImage3D (<see cref="Gl.TEXTURE_3D"/>). 
		/// <paramrefname="level"/> specifies the level-of-detail number of the desired image. <paramref name="format"/> and 
		/// <paramrefname="type"/> specify the format and type of the desired image array. See the reference pages Gl.TexImage1D and 
		/// Gl.DrawPixelsfor a description of the acceptable values for the <paramref name="format"/> and <paramref name="type"/> 
		/// parameters,respectively. 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_PACK_BUFFER"/> target (see Gl.BindBuffer) while a 
		/// textureimage is requested, <paramref name="img"/> is treated as a byte offset into the buffer object's data store. 
		/// To understand the operation of <see cref="Gl.GetTexImage"/>, consider the selected internal four-component texture image 
		/// tobe an RGBA color buffer the size of the image. The semantics of <see cref="Gl.GetTexImage"/> are then identical to 
		/// thoseof Gl.ReadPixels, with the exception that no pixel transfer operations are performed, when called with the same 
		/// <paramrefname="format"/> and <paramref name="type"/>, with x and y set to 0, width set to the width of the texture image 
		/// (includingborder if one was specified), and height set to 1 for 1D images, or to the height of the texture image 
		/// (includingborder if one was specified) for 2D images. Because the internal texture image is an RGBA image, pixel formats 
		/// <seecref="Gl.COLOR_INDEX"/>, <see cref="Gl.STENCIL_INDEX"/>, and <see cref="Gl.DEPTH_COMPONENT"/> are not accepted, and 
		/// pixeltype <see cref="Gl.BITMAP"/> is not accepted. 
		/// If the selected texture image does not contain four components, the following mappings are applied. Single-component 
		/// texturesare treated as RGBA buffers with red set to the single-component value, green set to 0, blue set to 0, and alpha 
		/// setto 1. Two-component textures are treated as RGBA buffers with red set to the value of component zero, alpha set to 
		/// thevalue of component one, and green and blue set to 0. Finally, three-component textures are treated as RGBA buffers 
		/// withred set to component zero, green set to component one, blue set to component two, and alpha set to 1. 
		/// To determine the required size of <paramref name="img"/>, use Gl.GetTexLevelParameter to determine the dimensions of the 
		/// internaltexture image, then scale the required number of pixels by the storage required for each pixel, based on 
		/// <paramrefname="format"/> and <paramref name="type"/>. Be sure to take the pixel storage parameters into account, 
		/// especially<see cref="Gl.PACK_ALIGNMENT"/>. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/>, <paramref name="format"/>, or <paramref 
		///   name="type"/>is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="level"/> is less than 0. 
		/// - <see cref="Gl.INVALID_VALUE"/> may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the 
		///   returnedvalue of <see cref="Gl.MAX_TEXTURE_SIZE"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is returned if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>,<see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or <see 
		///   cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>and <paramref name="format"/> is not <see cref="Gl.RGB"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is returned if <paramref name="type"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, 
		///   <seecref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, <see 
		///   cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>,<see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>,and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> or <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/>target and the data would be packed to the buffer object such that the memory writes 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/>target and <paramref name="img"/> is not evenly divisible into the number of bytes needed 
		///   tostore in memory a datum indicated by <paramref name="type"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetTexImage"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexLevelParameter with argument <see cref="Gl.TEXTURE_WIDTH"/> 
		/// - Gl.GetTexLevelParameter with argument <see cref="Gl.TEXTURE_HEIGHT"/> 
		/// - Gl.GetTexLevelParameter with argument <see cref="Gl.TEXTURE_BORDER"/> 
		/// - Gl.GetTexLevelParameter with argument <see cref="Gl.TEXTURE_INTERNAL_FORMAT"/> 
		/// - Gl.Get with arguments <see cref="Gl.PACK_ALIGNMENT"/> and others 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_PACK_BUFFER_BINDING"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void GetTexImage(TextureTarget target, Int32 level, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetTexImage != null, "pglGetTexImage not implemented");
			Delegates.pglGetTexImage((int)target, level, (int)format, (int)type, pixels);
			CallLog("glGetTexImage({0}, {1}, {2}, {3}, {4})", target, level, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexParameterfv, glGetTexParameteriv, glGetTexParameterIiv, 
		/// andglGetTexParameterIuiv functions. GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, 
		/// GL_TEXTURE_2D_MULTISAMPLE,GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_RECTANGLE, and 
		/// GL_TEXTURE_CUBE_MAP_ARRAYare accepted. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL,GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT,GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL,GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G,GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER,GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S,GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// glGetTexParameter and glGetTextureParameter return in params the value or values of the texture parameter specified as 
		/// pname.target defines the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D_ARRAY,GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, or 
		/// GL_TEXTURE_2D_MULTISAMPLE_ARRAYspecify one-, two-, or three-dimensional, one-dimensional array, two-dimensional array, 
		/// rectangle,cube-mapped or cube-mapped array, two-dimensional multisample, or two-dimensional multisample array texturing, 
		/// respectively.pname accepts the same symbols as glTexParameter, with the same interpretations: 
		/// In addition to the parameters that may be set with glTexParameter, glGetTexParameter and glGetTextureParameter accept 
		/// thefollowing read-only parameters: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_ENUM error is generated by glGetTexParameter if the effective target is not one of the accepted texture 
		///   targets.
		/// - GL_INVALID_OPERATION is generated by glGetTextureParameter* if texture is not the name of an existing texture object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TextureParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureStorage1D"/>
		/// <seealso cref="Gl.TextureStorage2D"/>
		/// <seealso cref="Gl.TextureStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		public static void GetTexParameter(int target, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterfv != null, "pglGetTexParameterfv not implemented");
					Delegates.pglGetTexParameterfv(target, pname, p_params);
					CallLog("glGetTexParameterfv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexParameterfv, glGetTexParameteriv, glGetTexParameterIiv, 
		/// andglGetTexParameterIuiv functions. GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, 
		/// GL_TEXTURE_2D_MULTISAMPLE,GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_RECTANGLE, and 
		/// GL_TEXTURE_CUBE_MAP_ARRAYare accepted. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL,GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT,GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL,GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G,GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER,GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S,GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// glGetTexParameter and glGetTextureParameter return in params the value or values of the texture parameter specified as 
		/// pname.target defines the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D_ARRAY,GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, or 
		/// GL_TEXTURE_2D_MULTISAMPLE_ARRAYspecify one-, two-, or three-dimensional, one-dimensional array, two-dimensional array, 
		/// rectangle,cube-mapped or cube-mapped array, two-dimensional multisample, or two-dimensional multisample array texturing, 
		/// respectively.pname accepts the same symbols as glTexParameter, with the same interpretations: 
		/// In addition to the parameters that may be set with glTexParameter, glGetTexParameter and glGetTextureParameter accept 
		/// thefollowing read-only parameters: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_ENUM error is generated by glGetTexParameter if the effective target is not one of the accepted texture 
		///   targets.
		/// - GL_INVALID_OPERATION is generated by glGetTextureParameter* if texture is not the name of an existing texture object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TextureParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureStorage1D"/>
		/// <seealso cref="Gl.TextureStorage2D"/>
		/// <seealso cref="Gl.TextureStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		public static void GetTexParameter(TextureTarget target, GetTextureParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterfv != null, "pglGetTexParameterfv not implemented");
					Delegates.pglGetTexParameterfv((int)target, (int)pname, p_params);
					CallLog("glGetTexParameterfv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexParameterfv, glGetTexParameteriv, glGetTexParameterIiv, 
		/// andglGetTexParameterIuiv functions. GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, 
		/// GL_TEXTURE_2D_MULTISAMPLE,GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_RECTANGLE, and 
		/// GL_TEXTURE_CUBE_MAP_ARRAYare accepted. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL,GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT,GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL,GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G,GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER,GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S,GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetTexParameter and glGetTextureParameter return in params the value or values of the texture parameter specified as 
		/// pname.target defines the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D_ARRAY,GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, or 
		/// GL_TEXTURE_2D_MULTISAMPLE_ARRAYspecify one-, two-, or three-dimensional, one-dimensional array, two-dimensional array, 
		/// rectangle,cube-mapped or cube-mapped array, two-dimensional multisample, or two-dimensional multisample array texturing, 
		/// respectively.pname accepts the same symbols as glTexParameter, with the same interpretations: 
		/// In addition to the parameters that may be set with glTexParameter, glGetTexParameter and glGetTextureParameter accept 
		/// thefollowing read-only parameters: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_ENUM error is generated by glGetTexParameter if the effective target is not one of the accepted texture 
		///   targets.
		/// - GL_INVALID_OPERATION is generated by glGetTextureParameter* if texture is not the name of an existing texture object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TextureParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureStorage1D"/>
		/// <seealso cref="Gl.TextureStorage2D"/>
		/// <seealso cref="Gl.TextureStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		public static void GetTexParameter(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameteriv != null, "pglGetTexParameteriv not implemented");
					Delegates.pglGetTexParameteriv(target, pname, p_params);
					CallLog("glGetTexParameteriv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexParameterfv, glGetTexParameteriv, glGetTexParameterIiv, 
		/// andglGetTexParameterIuiv functions. GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, 
		/// GL_TEXTURE_2D_MULTISAMPLE,GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_RECTANGLE, and 
		/// GL_TEXTURE_CUBE_MAP_ARRAYare accepted. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL,GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT,GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL,GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G,GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER,GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S,GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetTexParameter and glGetTextureParameter return in params the value or values of the texture parameter specified as 
		/// pname.target defines the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D_ARRAY,GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, or 
		/// GL_TEXTURE_2D_MULTISAMPLE_ARRAYspecify one-, two-, or three-dimensional, one-dimensional array, two-dimensional array, 
		/// rectangle,cube-mapped or cube-mapped array, two-dimensional multisample, or two-dimensional multisample array texturing, 
		/// respectively.pname accepts the same symbols as glTexParameter, with the same interpretations: 
		/// In addition to the parameters that may be set with glTexParameter, glGetTexParameter and glGetTextureParameter accept 
		/// thefollowing read-only parameters: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_ENUM error is generated by glGetTexParameter if the effective target is not one of the accepted texture 
		///   targets.
		/// - GL_INVALID_OPERATION is generated by glGetTextureParameter* if texture is not the name of an existing texture object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TextureParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureStorage1D"/>
		/// <seealso cref="Gl.TextureStorage2D"/>
		/// <seealso cref="Gl.TextureStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		public static void GetTexParameter(TextureTarget target, GetTextureParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameteriv != null, "pglGetTexParameteriv not implemented");
					Delegates.pglGetTexParameteriv((int)target, (int)pname, p_params);
					CallLog("glGetTexParameteriv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values for a specific level of detail
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexLevelParameterfv and glGetTexLevelParameteriv functions. 
		/// Mustbe one of the following values: GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D_ARRAY,GL_TEXTURE_RECTANGLE, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_X,GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_PROXY_TEXTURE_1D, 
		/// GL_PROXY_TEXTURE_2D,GL_PROXY_TEXTURE_3D, GL_PROXY_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_2D_ARRAY, 
		/// GL_PROXY_TEXTURE_RECTANGLE,GL_PROXY_TEXTURE_2D_MULTISAMPLE, GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// GL_PROXY_TEXTURE_CUBE_MAP,or GL_TEXTURE_BUFFER. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reductionimage. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, 
		/// GL_TEXTURE_INTERNAL_FORMAT,GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, 
		/// GL_TEXTURE_DEPTH_SIZE,GL_TEXTURE_COMPRESSED, GL_TEXTURE_COMPRESSED_IMAGE_SIZE, and GL_TEXTURE_BUFFER_OFFSET are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// glGetTexLevelParameterfv, glGetTexLevelParameteriv, glGetTextureLevelParameterfv and glGetTextureLevelParameteriv return 
		/// inparams texture parameter values for a specific level-of-detail value, specified as level. For the first two functions, 
		/// targetdefines the target texture, either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_PROXY_TEXTURE_1D, 
		/// GL_PROXY_TEXTURE_2D,GL_PROXY_TEXTURE_3D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_Y,GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Z,or GL_PROXY_TEXTURE_CUBE_MAP. The remaining two take a texture argument which specifies 
		/// thename of the texture object. 
		/// GL_MAX_TEXTURE_SIZE, and GL_MAX_3D_TEXTURE_SIZE are not really descriptive enough. It has to report the largest square 
		/// textureimage that can be accommodated with mipmaps but a long skinny texture, or a texture without mipmaps may easily 
		/// fitin texture memory. The proxy targets allow the user to more accurately query whether the GL can accommodate a texture 
		/// ofa given configuration. If the texture cannot be accommodated, the texture state variables, which may be queried with 
		/// glGetTexLevelParameterand glGetTextureLevelParameter, are set to 0. If the texture can be accommodated, the texture 
		/// statevalues will be set as they would be set for a non-proxy target. 
		/// pname specifies the texture parameter whose value or values will be returned. 
		/// The accepted parameter names are as follows: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glGetTextureLevelParameterfv and glGetTextureLevelParameteriv functions if texture 
		///   isnot the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated by glGetTexLevelParameterfv and glGetTexLevelParameteriv functions if target or pname is 
		///   notan accepted value. 
		/// - GL_INVALID_VALUE is generated if level is less than 0. 
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if target is GL_TEXTURE_BUFFER and level is not zero. 
		/// - GL_INVALID_OPERATION is generated if GL_TEXTURE_COMPRESSED_IMAGE_SIZE is queried on texture images with an uncompressed 
		///   internalformat or on proxy targets. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void GetTexLevelParameter(int target, Int32 level, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexLevelParameterfv != null, "pglGetTexLevelParameterfv not implemented");
					Delegates.pglGetTexLevelParameterfv(target, level, pname, p_params);
					CallLog("glGetTexLevelParameterfv({0}, {1}, {2}, {3})", target, level, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values for a specific level of detail
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexLevelParameterfv and glGetTexLevelParameteriv functions. 
		/// Mustbe one of the following values: GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D_ARRAY,GL_TEXTURE_RECTANGLE, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_X,GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_PROXY_TEXTURE_1D, 
		/// GL_PROXY_TEXTURE_2D,GL_PROXY_TEXTURE_3D, GL_PROXY_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_2D_ARRAY, 
		/// GL_PROXY_TEXTURE_RECTANGLE,GL_PROXY_TEXTURE_2D_MULTISAMPLE, GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// GL_PROXY_TEXTURE_CUBE_MAP,or GL_TEXTURE_BUFFER. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reductionimage. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, 
		/// GL_TEXTURE_INTERNAL_FORMAT,GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, 
		/// GL_TEXTURE_DEPTH_SIZE,GL_TEXTURE_COMPRESSED, GL_TEXTURE_COMPRESSED_IMAGE_SIZE, and GL_TEXTURE_BUFFER_OFFSET are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// glGetTexLevelParameterfv, glGetTexLevelParameteriv, glGetTextureLevelParameterfv and glGetTextureLevelParameteriv return 
		/// inparams texture parameter values for a specific level-of-detail value, specified as level. For the first two functions, 
		/// targetdefines the target texture, either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_PROXY_TEXTURE_1D, 
		/// GL_PROXY_TEXTURE_2D,GL_PROXY_TEXTURE_3D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_Y,GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Z,or GL_PROXY_TEXTURE_CUBE_MAP. The remaining two take a texture argument which specifies 
		/// thename of the texture object. 
		/// GL_MAX_TEXTURE_SIZE, and GL_MAX_3D_TEXTURE_SIZE are not really descriptive enough. It has to report the largest square 
		/// textureimage that can be accommodated with mipmaps but a long skinny texture, or a texture without mipmaps may easily 
		/// fitin texture memory. The proxy targets allow the user to more accurately query whether the GL can accommodate a texture 
		/// ofa given configuration. If the texture cannot be accommodated, the texture state variables, which may be queried with 
		/// glGetTexLevelParameterand glGetTextureLevelParameter, are set to 0. If the texture can be accommodated, the texture 
		/// statevalues will be set as they would be set for a non-proxy target. 
		/// pname specifies the texture parameter whose value or values will be returned. 
		/// The accepted parameter names are as follows: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glGetTextureLevelParameterfv and glGetTextureLevelParameteriv functions if texture 
		///   isnot the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated by glGetTexLevelParameterfv and glGetTexLevelParameteriv functions if target or pname is 
		///   notan accepted value. 
		/// - GL_INVALID_VALUE is generated if level is less than 0. 
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if target is GL_TEXTURE_BUFFER and level is not zero. 
		/// - GL_INVALID_OPERATION is generated if GL_TEXTURE_COMPRESSED_IMAGE_SIZE is queried on texture images with an uncompressed 
		///   internalformat or on proxy targets. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void GetTexLevelParameter(TextureTarget target, Int32 level, GetTextureParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexLevelParameterfv != null, "pglGetTexLevelParameterfv not implemented");
					Delegates.pglGetTexLevelParameterfv((int)target, level, (int)pname, p_params);
					CallLog("glGetTexLevelParameterfv({0}, {1}, {2}, {3})", target, level, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values for a specific level of detail
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexLevelParameterfv and glGetTexLevelParameteriv functions. 
		/// Mustbe one of the following values: GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D_ARRAY,GL_TEXTURE_RECTANGLE, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_X,GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_PROXY_TEXTURE_1D, 
		/// GL_PROXY_TEXTURE_2D,GL_PROXY_TEXTURE_3D, GL_PROXY_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_2D_ARRAY, 
		/// GL_PROXY_TEXTURE_RECTANGLE,GL_PROXY_TEXTURE_2D_MULTISAMPLE, GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// GL_PROXY_TEXTURE_CUBE_MAP,or GL_TEXTURE_BUFFER. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reductionimage. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, 
		/// GL_TEXTURE_INTERNAL_FORMAT,GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, 
		/// GL_TEXTURE_DEPTH_SIZE,GL_TEXTURE_COMPRESSED, GL_TEXTURE_COMPRESSED_IMAGE_SIZE, and GL_TEXTURE_BUFFER_OFFSET are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetTexLevelParameterfv, glGetTexLevelParameteriv, glGetTextureLevelParameterfv and glGetTextureLevelParameteriv return 
		/// inparams texture parameter values for a specific level-of-detail value, specified as level. For the first two functions, 
		/// targetdefines the target texture, either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_PROXY_TEXTURE_1D, 
		/// GL_PROXY_TEXTURE_2D,GL_PROXY_TEXTURE_3D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_Y,GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Z,or GL_PROXY_TEXTURE_CUBE_MAP. The remaining two take a texture argument which specifies 
		/// thename of the texture object. 
		/// GL_MAX_TEXTURE_SIZE, and GL_MAX_3D_TEXTURE_SIZE are not really descriptive enough. It has to report the largest square 
		/// textureimage that can be accommodated with mipmaps but a long skinny texture, or a texture without mipmaps may easily 
		/// fitin texture memory. The proxy targets allow the user to more accurately query whether the GL can accommodate a texture 
		/// ofa given configuration. If the texture cannot be accommodated, the texture state variables, which may be queried with 
		/// glGetTexLevelParameterand glGetTextureLevelParameter, are set to 0. If the texture can be accommodated, the texture 
		/// statevalues will be set as they would be set for a non-proxy target. 
		/// pname specifies the texture parameter whose value or values will be returned. 
		/// The accepted parameter names are as follows: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glGetTextureLevelParameterfv and glGetTextureLevelParameteriv functions if texture 
		///   isnot the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated by glGetTexLevelParameterfv and glGetTexLevelParameteriv functions if target or pname is 
		///   notan accepted value. 
		/// - GL_INVALID_VALUE is generated if level is less than 0. 
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if target is GL_TEXTURE_BUFFER and level is not zero. 
		/// - GL_INVALID_OPERATION is generated if GL_TEXTURE_COMPRESSED_IMAGE_SIZE is queried on texture images with an uncompressed 
		///   internalformat or on proxy targets. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void GetTexLevelParameter(int target, Int32 level, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexLevelParameteriv != null, "pglGetTexLevelParameteriv not implemented");
					Delegates.pglGetTexLevelParameteriv(target, level, pname, p_params);
					CallLog("glGetTexLevelParameteriv({0}, {1}, {2}, {3})", target, level, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values for a specific level of detail
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexLevelParameterfv and glGetTexLevelParameteriv functions. 
		/// Mustbe one of the following values: GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D_ARRAY,GL_TEXTURE_RECTANGLE, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_X,GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_PROXY_TEXTURE_1D, 
		/// GL_PROXY_TEXTURE_2D,GL_PROXY_TEXTURE_3D, GL_PROXY_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_2D_ARRAY, 
		/// GL_PROXY_TEXTURE_RECTANGLE,GL_PROXY_TEXTURE_2D_MULTISAMPLE, GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// GL_PROXY_TEXTURE_CUBE_MAP,or GL_TEXTURE_BUFFER. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reductionimage. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, 
		/// GL_TEXTURE_INTERNAL_FORMAT,GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, 
		/// GL_TEXTURE_DEPTH_SIZE,GL_TEXTURE_COMPRESSED, GL_TEXTURE_COMPRESSED_IMAGE_SIZE, and GL_TEXTURE_BUFFER_OFFSET are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetTexLevelParameterfv, glGetTexLevelParameteriv, glGetTextureLevelParameterfv and glGetTextureLevelParameteriv return 
		/// inparams texture parameter values for a specific level-of-detail value, specified as level. For the first two functions, 
		/// targetdefines the target texture, either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_PROXY_TEXTURE_1D, 
		/// GL_PROXY_TEXTURE_2D,GL_PROXY_TEXTURE_3D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_Y,GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Z,or GL_PROXY_TEXTURE_CUBE_MAP. The remaining two take a texture argument which specifies 
		/// thename of the texture object. 
		/// GL_MAX_TEXTURE_SIZE, and GL_MAX_3D_TEXTURE_SIZE are not really descriptive enough. It has to report the largest square 
		/// textureimage that can be accommodated with mipmaps but a long skinny texture, or a texture without mipmaps may easily 
		/// fitin texture memory. The proxy targets allow the user to more accurately query whether the GL can accommodate a texture 
		/// ofa given configuration. If the texture cannot be accommodated, the texture state variables, which may be queried with 
		/// glGetTexLevelParameterand glGetTextureLevelParameter, are set to 0. If the texture can be accommodated, the texture 
		/// statevalues will be set as they would be set for a non-proxy target. 
		/// pname specifies the texture parameter whose value or values will be returned. 
		/// The accepted parameter names are as follows: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glGetTextureLevelParameterfv and glGetTextureLevelParameteriv functions if texture 
		///   isnot the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated by glGetTexLevelParameterfv and glGetTexLevelParameteriv functions if target or pname is 
		///   notan accepted value. 
		/// - GL_INVALID_VALUE is generated if level is less than 0. 
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if target is GL_TEXTURE_BUFFER and level is not zero. 
		/// - GL_INVALID_OPERATION is generated if GL_TEXTURE_COMPRESSED_IMAGE_SIZE is queried on texture images with an uncompressed 
		///   internalformat or on proxy targets. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void GetTexLevelParameter(TextureTarget target, Int32 level, GetTextureParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexLevelParameteriv != null, "pglGetTexLevelParameteriv not implemented");
					Delegates.pglGetTexLevelParameteriv((int)target, level, (int)pname, p_params);
					CallLog("glGetTexLevelParameteriv({0}, {1}, {2}, {3})", target, level, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// test whether a capability is enabled
		/// </summary>
		/// <param name="cap">
		/// Specifies a symbolic constant indicating a GL capability. 
		/// </param>
		/// <remarks>
		/// glIsEnabled returns GL_TRUE if cap is an enabled capability and returns GL_FALSE otherwise. Boolean states that are 
		/// indexedmay be tested with glIsEnabledi. For glIsEnabledi, index specifies the index of the capability to test. index 
		/// mustbe between zero and the count of indexed capabilities for cap. Initially all capabilities except GL_DITHER are 
		/// disabled;GL_DITHER is initially enabled. 
		/// The following capabilities are accepted for cap: 
		///  
		///  
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if cap is not an accepted value. 
		/// - GL_INVALID_VALUE is generated by glIsEnabledi if index is outside the valid range for the indexed state cap. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Disable"/>
		/// <seealso cref="Gl.Get"/>
		public static bool IsEnabled(int cap)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsEnabled != null, "pglIsEnabled not implemented");
			retValue = Delegates.pglIsEnabled(cap);
			CallLog("glIsEnabled({0}) = {1}", cap, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// test whether a capability is enabled
		/// </summary>
		/// <param name="cap">
		/// Specifies a symbolic constant indicating a GL capability. 
		/// </param>
		/// <remarks>
		/// glIsEnabled returns GL_TRUE if cap is an enabled capability and returns GL_FALSE otherwise. Boolean states that are 
		/// indexedmay be tested with glIsEnabledi. For glIsEnabledi, index specifies the index of the capability to test. index 
		/// mustbe between zero and the count of indexed capabilities for cap. Initially all capabilities except GL_DITHER are 
		/// disabled;GL_DITHER is initially enabled. 
		/// The following capabilities are accepted for cap: 
		///  
		///  
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if cap is not an accepted value. 
		/// - GL_INVALID_VALUE is generated by glIsEnabledi if index is outside the valid range for the indexed state cap. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Disable"/>
		/// <seealso cref="Gl.Get"/>
		public static bool IsEnabled(EnableCap cap)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsEnabled != null, "pglIsEnabled not implemented");
			retValue = Delegates.pglIsEnabled((int)cap);
			CallLog("glIsEnabled({0}) = {1}", cap, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// specify mapping of depth values from normalized device coordinates to window coordinates
		/// </summary>
		/// <param name="near">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="far">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// After clipping and division by w, depth coordinates range from -1 to 1, corresponding to the near and far clipping 
		/// planes.glDepthRange specifies a linear mapping of the normalized depth coordinates in this range to window depth 
		/// coordinates.Regardless of the actual depth buffer implementation, window coordinate depth values are treated as though 
		/// theyrange from 0 through 1 (like color components). Thus, the values accepted by glDepthRange are both clamped to this 
		/// rangebefore they are accepted. 
		/// The setting of (0,1) maps the near plane to 0 and the far plane to 1. With this mapping, the depth buffer range is fully 
		/// utilized.
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_DEPTH_RANGE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.PolygonOffset"/>
		/// <seealso cref="Gl.Viewport"/>
		/// <seealso cref="Gl.removedTypes"/>
		public static void DepthRange(double near, double far)
		{
			Debug.Assert(Delegates.pglDepthRange != null, "pglDepthRange not implemented");
			Delegates.pglDepthRange(near, far);
			CallLog("glDepthRange({0}, {1})", near, far);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the viewport
		/// </summary>
		/// <param name="x">
		/// Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0). 
		/// </param>
		/// <param name="y">
		/// Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0). 
		/// </param>
		/// <param name="width">
		/// Specify the width and height of the viewport. When a GL context is first attached to a window, <paramref name="width"/> 
		/// and<paramref name="height"/> are set to the dimensions of that window. 
		/// </param>
		/// <param name="height">
		/// Specify the width and height of the viewport. When a GL context is first attached to a window, <paramref name="width"/> 
		/// and<paramref name="height"/> are set to the dimensions of that window. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.Viewport"/> specifies the affine transformation of x and y from normalized device coordinates to window 
		/// coordinates.Let xndynd be normalized device coordinates. Then the window coordinates xwyw are computed as follows: 
		/// xw=xnd+1⁢width2+x 
		/// yw=ynd+1⁢height2+y 
		/// Viewport width and height are silently clamped to a range that depends on the implementation. To query this range, call 
		/// Gl.Getwith argument <see cref="Gl.MAX_VIEWPORT_DIMS"/>. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if either <paramref name="width"/> or <paramref name="height"/> is negative. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Viewport"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.VIEWPORT"/> 
		/// - Gl.Get with argument <see cref="Gl.MAX_VIEWPORT_DIMS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DepthRange"/>
		public static void Viewport(Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglViewport != null, "pglViewport not implemented");
			Delegates.pglViewport(x, y, width, height);
			CallLog("glViewport({0}, {1}, {2}, {3})", x, y, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNewList.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void NewList(UInt32 list, int mode)
		{
			Debug.Assert(Delegates.pglNewList != null, "pglNewList not implemented");
			Delegates.pglNewList(list, mode);
			CallLog("glNewList({0}, {1})", list, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNewList.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void NewList(UInt32 list, ListMode mode)
		{
			Debug.Assert(Delegates.pglNewList != null, "pglNewList not implemented");
			Delegates.pglNewList(list, (int)mode);
			CallLog("glNewList({0}, {1})", list, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEndList.
		/// </summary>
		/// <remarks>
		/// </remarks>
		public static void EndList()
		{
			Debug.Assert(Delegates.pglEndList != null, "pglEndList not implemented");
			Delegates.pglEndList();
			CallLog("glEndList()");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCallList.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void CallList(UInt32 list)
		{
			Debug.Assert(Delegates.pglCallList != null, "pglCallList not implemented");
			Delegates.pglCallList(list);
			CallLog("glCallList({0})", list);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCallLists.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="lists">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void CallLists(Int32 n, int type, IntPtr lists)
		{
			Debug.Assert(Delegates.pglCallLists != null, "pglCallLists not implemented");
			Delegates.pglCallLists(n, type, lists);
			CallLog("glCallLists({0}, {1}, {2})", n, type, lists);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCallLists.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="lists">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void CallLists(Int32 n, ListNameType type, IntPtr lists)
		{
			Debug.Assert(Delegates.pglCallLists != null, "pglCallLists not implemented");
			Delegates.pglCallLists(n, (int)type, lists);
			CallLog("glCallLists({0}, {1}, {2})", n, type, lists);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCallLists.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="lists">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void CallLists(Int32 n, int type, Object lists)
		{
			GCHandle pin_lists = GCHandle.Alloc(lists, GCHandleType.Pinned);
			try {
				CallLists(n, type, pin_lists.AddrOfPinnedObject());
			} finally {
				pin_lists.Free();
			}
		}

		/// <summary>
		/// Binding for glDeleteLists.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="range">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void DeleteLists(UInt32 list, Int32 range)
		{
			Debug.Assert(Delegates.pglDeleteLists != null, "pglDeleteLists not implemented");
			Delegates.pglDeleteLists(list, range);
			CallLog("glDeleteLists({0}, {1})", list, range);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenLists.
		/// </summary>
		/// <param name="range">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static UInt32 GenLists(Int32 range)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglGenLists != null, "pglGenLists not implemented");
			retValue = Delegates.pglGenLists(range);
			CallLog("glGenLists({0}) = {1}", range, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glListBase.
		/// </summary>
		/// <param name="base">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ListBase(UInt32 @base)
		{
			Debug.Assert(Delegates.pglListBase != null, "pglListBase not implemented");
			Delegates.pglListBase(@base);
			CallLog("glListBase({0})", @base);
			DebugCheckErrors();
		}

		/// <summary>
		/// delimit the vertices of a primitive or a group of like primitives
		/// </summary>
		/// <param name="mode">
		/// Specifies the primitive or primitives that will be created from vertices presented between <see cref="Gl.Begin"/> and 
		/// thesubsequent Gl\.End. Ten symbolic constants are accepted: <see cref="Gl.POINTS"/>, <see cref="Gl.LINES"/>, <see 
		/// cref="Gl.LINE_STRIP"/>,<see cref="Gl.LINE_LOOP"/>, <see cref="Gl.TRIANGLES"/>, <see cref="Gl.TRIANGLE_STRIP"/>, <see 
		/// cref="Gl.TRIANGLE_FAN"/>,<see cref="Gl.QUADS"/>, <see cref="Gl.QUAD_STRIP"/>, and <see cref="Gl.POLYGON"/>. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.Begin"/> and Gl.End delimit the vertices that define a primitive or a group of like primitives. <see 
		/// cref="Gl.Begin"/>accepts a single argument that specifies in which of ten ways the vertices are interpreted. Taking n as 
		/// aninteger count starting at one, and N as the total number of vertices specified, the interpretations are as follows: 
		/// Only a subset of GL commands can be used between <see cref="Gl.Begin"/> and Gl.End. The commands are Gl.Vertex, 
		/// Gl.Color,Gl.SecondaryColor, Gl.Index, Gl.Normal, Gl.FogCoord, Gl.TexCoord, Gl.MultiTexCoord, Gl.VertexAttrib, 
		/// Gl.EvalCoord,Gl.EvalPoint, Gl.ArrayElement, Gl.Material, and Gl.EdgeFlag. Also, it is acceptable to use Gl.CallList or 
		/// Gl.CallListsto execute display lists that include only the preceding commands. If any other GL command is executed 
		/// between<see cref="Gl.Begin"/> and Gl.End, the error flag is set and the command is ignored. 
		/// Regardless of the value chosen for <paramref name="mode"/>, there is no limit to the number of vertices that can be 
		/// definedbetween <see cref="Gl.Begin"/> and Gl.End. Lines, triangles, quadrilaterals, and polygons that are incompletely 
		/// specifiedare not drawn. Incomplete specification results when either too few vertices are provided to specify even a 
		/// singleprimitive or when an incorrect multiple of vertices is specified. The incomplete primitive is ignored; the rest 
		/// aredrawn. 
		/// The minimum specification of vertices for each primitive is as follows: 1 for a point, 2 for a line, 3 for a triangle, 4 
		/// fora quadrilateral, and 3 for a polygon. Modes that require a certain multiple of vertices are <see cref="Gl.LINES"/> 
		/// (2),<see cref="Gl.TRIANGLES"/> (3), <see cref="Gl.QUADS"/> (4), and <see cref="Gl.QUAD_STRIP"/> (2). 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="mode"/> is set to an unaccepted value. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Begin"/> is executed between a <see cref="Gl.Begin"/> 
		///   andthe corresponding execution of Gl.End. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if Gl.End is executed without being preceded by a <see 
		///   cref="Gl.Begin"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a command other than Gl.Vertex, Gl.Color, Gl.SecondaryColor, 
		///   Gl.Index,Gl.Normal, Gl.FogCoord, Gl.TexCoord, Gl.MultiTexCoord, Gl.VertexAttrib, Gl.EvalCoord, Gl.EvalPoint, 
		///   Gl.ArrayElement,Gl.Material, Gl.EdgeFlag, Gl.CallList, or Gl.CallLists is executed between the execution of <see 
		///   cref="Gl.Begin"/>and the corresponding execution Gl.End. 
		/// - Execution of Gl.EnableClientState, Gl.DisableClientState, Gl.EdgeFlagPointer, Gl.FogCoordPointer, Gl.TexCoordPointer, 
		///   Gl.ColorPointer,Gl.SecondaryColorPointer, Gl.IndexPointer, Gl.NormalPointer, Gl.VertexPointer, Gl.VertexAttribPointer, 
		///   Gl.InterleavedArrays,or Gl.PixelStore is not allowed after a call to <see cref="Gl.Begin"/> and before the corresponding 
		///   callto Gl.End, but an error may or may not be generated. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.CallLists"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		public static void Begin(int mode)
		{
			Debug.Assert(Delegates.pglBegin != null, "pglBegin not implemented");
			Delegates.pglBegin(mode);
			CallLog("glBegin({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// delimit the vertices of a primitive or a group of like primitives
		/// </summary>
		/// <param name="mode">
		/// Specifies the primitive or primitives that will be created from vertices presented between <see cref="Gl.Begin"/> and 
		/// thesubsequent Gl\.End. Ten symbolic constants are accepted: <see cref="Gl.POINTS"/>, <see cref="Gl.LINES"/>, <see 
		/// cref="Gl.LINE_STRIP"/>,<see cref="Gl.LINE_LOOP"/>, <see cref="Gl.TRIANGLES"/>, <see cref="Gl.TRIANGLE_STRIP"/>, <see 
		/// cref="Gl.TRIANGLE_FAN"/>,<see cref="Gl.QUADS"/>, <see cref="Gl.QUAD_STRIP"/>, and <see cref="Gl.POLYGON"/>. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.Begin"/> and Gl.End delimit the vertices that define a primitive or a group of like primitives. <see 
		/// cref="Gl.Begin"/>accepts a single argument that specifies in which of ten ways the vertices are interpreted. Taking n as 
		/// aninteger count starting at one, and N as the total number of vertices specified, the interpretations are as follows: 
		/// Only a subset of GL commands can be used between <see cref="Gl.Begin"/> and Gl.End. The commands are Gl.Vertex, 
		/// Gl.Color,Gl.SecondaryColor, Gl.Index, Gl.Normal, Gl.FogCoord, Gl.TexCoord, Gl.MultiTexCoord, Gl.VertexAttrib, 
		/// Gl.EvalCoord,Gl.EvalPoint, Gl.ArrayElement, Gl.Material, and Gl.EdgeFlag. Also, it is acceptable to use Gl.CallList or 
		/// Gl.CallListsto execute display lists that include only the preceding commands. If any other GL command is executed 
		/// between<see cref="Gl.Begin"/> and Gl.End, the error flag is set and the command is ignored. 
		/// Regardless of the value chosen for <paramref name="mode"/>, there is no limit to the number of vertices that can be 
		/// definedbetween <see cref="Gl.Begin"/> and Gl.End. Lines, triangles, quadrilaterals, and polygons that are incompletely 
		/// specifiedare not drawn. Incomplete specification results when either too few vertices are provided to specify even a 
		/// singleprimitive or when an incorrect multiple of vertices is specified. The incomplete primitive is ignored; the rest 
		/// aredrawn. 
		/// The minimum specification of vertices for each primitive is as follows: 1 for a point, 2 for a line, 3 for a triangle, 4 
		/// fora quadrilateral, and 3 for a polygon. Modes that require a certain multiple of vertices are <see cref="Gl.LINES"/> 
		/// (2),<see cref="Gl.TRIANGLES"/> (3), <see cref="Gl.QUADS"/> (4), and <see cref="Gl.QUAD_STRIP"/> (2). 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="mode"/> is set to an unaccepted value. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Begin"/> is executed between a <see cref="Gl.Begin"/> 
		///   andthe corresponding execution of Gl.End. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if Gl.End is executed without being preceded by a <see 
		///   cref="Gl.Begin"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a command other than Gl.Vertex, Gl.Color, Gl.SecondaryColor, 
		///   Gl.Index,Gl.Normal, Gl.FogCoord, Gl.TexCoord, Gl.MultiTexCoord, Gl.VertexAttrib, Gl.EvalCoord, Gl.EvalPoint, 
		///   Gl.ArrayElement,Gl.Material, Gl.EdgeFlag, Gl.CallList, or Gl.CallLists is executed between the execution of <see 
		///   cref="Gl.Begin"/>and the corresponding execution Gl.End. 
		/// - Execution of Gl.EnableClientState, Gl.DisableClientState, Gl.EdgeFlagPointer, Gl.FogCoordPointer, Gl.TexCoordPointer, 
		///   Gl.ColorPointer,Gl.SecondaryColorPointer, Gl.IndexPointer, Gl.NormalPointer, Gl.VertexPointer, Gl.VertexAttribPointer, 
		///   Gl.InterleavedArrays,or Gl.PixelStore is not allowed after a call to <see cref="Gl.Begin"/> and before the corresponding 
		///   callto Gl.End, but an error may or may not be generated. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.CallLists"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		public static void Begin(PrimitiveType mode)
		{
			Debug.Assert(Delegates.pglBegin != null, "pglBegin not implemented");
			Delegates.pglBegin((int)mode);
			CallLog("glBegin({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// draw a bitmap
		/// </summary>
		/// <param name="width">
		/// Specify the pixel width and height of the bitmap image. 
		/// </param>
		/// <param name="height">
		/// Specify the pixel width and height of the bitmap image. 
		/// </param>
		/// <param name="xorig">
		/// Specify the location of the origin in the bitmap image. The origin is measured from the lower left corner of the bitmap, 
		/// withright and up being the positive axes. 
		/// </param>
		/// <param name="yorig">
		/// Specify the location of the origin in the bitmap image. The origin is measured from the lower left corner of the bitmap, 
		/// withright and up being the positive axes. 
		/// </param>
		/// <param name="xmove">
		/// Specify the x and y offsets to be added to the current raster position after the bitmap is drawn. 
		/// </param>
		/// <param name="ymove">
		/// Specify the x and y offsets to be added to the current raster position after the bitmap is drawn. 
		/// </param>
		/// <param name="bitmap">
		/// Specifies the address of the bitmap image. 
		/// </param>
		/// <remarks>
		/// A bitmap is a binary image. When drawn, the bitmap is positioned relative to the current raster position, and frame 
		/// bufferpixels corresponding to 1's in the bitmap are written using the current raster color or index. Frame buffer pixels 
		/// correspondingto 0's in the bitmap are not modified. 
		/// <see cref="Gl.Bitmap"/> takes seven arguments. The first pair specifies the width and height of the bitmap image. The 
		/// secondpair specifies the location of the bitmap origin relative to the lower left corner of the bitmap image. The third 
		/// pairof arguments specifies x and y offsets to be added to the current raster position after the bitmap has been drawn. 
		/// Thefinal argument is a pointer to the bitmap image itself. 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// abitmap image is specified, <paramref name="bitmap"/> is treated as a byte offset into the buffer object's data store. 
		/// The bitmap image is interpreted like image data for the Gl.DrawPixels command, with <paramref name="width"/> and 
		/// <paramrefname="height"/> corresponding to the width and height arguments of that command, and with type set to <see 
		/// cref="Gl.BITMAP"/>and format set to <see cref="Gl.COLOR_INDEX"/>. Modes specified using Gl.PixelStore affect the 
		/// interpretationof bitmap image data; modes specified using Gl.PixelTransfer do not. 
		/// If the current raster position is invalid, <see cref="Gl.Bitmap"/> is ignored. Otherwise, the lower left corner of the 
		/// bitmapimage is positioned at the window coordinates 
		/// xw=xr-xo 
		/// yw=yr-yo 
		/// where xryr is the raster position and xoyo is the bitmap origin. Fragments are then generated for each pixel 
		/// correspondingto a 1 (one) in the bitmap image. These fragments are generated using the current raster z coordinate, 
		/// coloror color index, and current raster texture coordinates. They are then treated just as if they had been generated by 
		/// apoint, line, or polygon, including texture mapping, fogging, and all per-fragment operations such as alpha and depth 
		/// testing.
		/// After the bitmap has been drawn, the x and y coordinates of the current raster position are offset by <paramref 
		/// name="xmove"/>and <paramref name="ymove"/>. No change is made to the z coordinate of the current raster position, or to 
		/// thecurrent raster color, texture coordinates, or index. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="width"/> or <paramref name="height"/> is negative. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the data would be unpacked from the buffer object such that the memory reads 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Bitmap"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/> 
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_COLOR"/> 
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_SECONDARY_COLOR"/> 
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_DISTANCE"/> 
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_INDEX"/> 
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_TEXTURE_COORDS"/> 
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.WindowPos"/>
		public static void Bitmap(Int32 width, Int32 height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap)
		{
			unsafe {
				fixed (byte* p_bitmap = bitmap)
				{
					Debug.Assert(Delegates.pglBitmap != null, "pglBitmap not implemented");
					Delegates.pglBitmap(width, height, xorig, yorig, xmove, ymove, p_bitmap);
					CallLog("glBitmap({0}, {1}, {2}, {3}, {4}, {5}, {6})", width, height, xorig, yorig, xmove, ymove, bitmap);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor3b.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color3(sbyte red, sbyte green, sbyte blue)
		{
			Debug.Assert(Delegates.pglColor3b != null, "pglColor3b not implemented");
			Delegates.pglColor3b(red, green, blue);
			CallLog("glColor3b({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor3bv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color3(sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3bv != null, "pglColor3bv not implemented");
					Delegates.pglColor3bv(p_v);
					CallLog("glColor3bv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor3d.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color3(double red, double green, double blue)
		{
			Debug.Assert(Delegates.pglColor3d != null, "pglColor3d not implemented");
			Delegates.pglColor3d(red, green, blue);
			CallLog("glColor3d({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor3dv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3dv != null, "pglColor3dv not implemented");
					Delegates.pglColor3dv(p_v);
					CallLog("glColor3dv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor3f.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color3(float red, float green, float blue)
		{
			Debug.Assert(Delegates.pglColor3f != null, "pglColor3f not implemented");
			Delegates.pglColor3f(red, green, blue);
			CallLog("glColor3f({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor3fv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3fv != null, "pglColor3fv not implemented");
					Delegates.pglColor3fv(p_v);
					CallLog("glColor3fv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor3i.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color3(Int32 red, Int32 green, Int32 blue)
		{
			Debug.Assert(Delegates.pglColor3i != null, "pglColor3i not implemented");
			Delegates.pglColor3i(red, green, blue);
			CallLog("glColor3i({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor3iv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3iv != null, "pglColor3iv not implemented");
					Delegates.pglColor3iv(p_v);
					CallLog("glColor3iv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor3s.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color3(Int16 red, Int16 green, Int16 blue)
		{
			Debug.Assert(Delegates.pglColor3s != null, "pglColor3s not implemented");
			Delegates.pglColor3s(red, green, blue);
			CallLog("glColor3s({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor3sv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3sv != null, "pglColor3sv not implemented");
					Delegates.pglColor3sv(p_v);
					CallLog("glColor3sv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor3ub.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color3(byte red, byte green, byte blue)
		{
			Debug.Assert(Delegates.pglColor3ub != null, "pglColor3ub not implemented");
			Delegates.pglColor3ub(red, green, blue);
			CallLog("glColor3ub({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor3ubv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color3(byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3ubv != null, "pglColor3ubv not implemented");
					Delegates.pglColor3ubv(p_v);
					CallLog("glColor3ubv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor3ui.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color3(UInt32 red, UInt32 green, UInt32 blue)
		{
			Debug.Assert(Delegates.pglColor3ui != null, "pglColor3ui not implemented");
			Delegates.pglColor3ui(red, green, blue);
			CallLog("glColor3ui({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor3uiv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color3(UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3uiv != null, "pglColor3uiv not implemented");
					Delegates.pglColor3uiv(p_v);
					CallLog("glColor3uiv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor3us.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color3(UInt16 red, UInt16 green, UInt16 blue)
		{
			Debug.Assert(Delegates.pglColor3us != null, "pglColor3us not implemented");
			Delegates.pglColor3us(red, green, blue);
			CallLog("glColor3us({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor3usv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color3(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3usv != null, "pglColor3usv not implemented");
					Delegates.pglColor3usv(p_v);
					CallLog("glColor3usv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor4b.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color4(sbyte red, sbyte green, sbyte blue, sbyte alpha)
		{
			Debug.Assert(Delegates.pglColor4b != null, "pglColor4b not implemented");
			Delegates.pglColor4b(red, green, blue, alpha);
			CallLog("glColor4b({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor4bv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color4(sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4bv != null, "pglColor4bv not implemented");
					Delegates.pglColor4bv(p_v);
					CallLog("glColor4bv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor4d.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color4(double red, double green, double blue, double alpha)
		{
			Debug.Assert(Delegates.pglColor4d != null, "pglColor4d not implemented");
			Delegates.pglColor4d(red, green, blue, alpha);
			CallLog("glColor4d({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor4dv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color4(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4dv != null, "pglColor4dv not implemented");
					Delegates.pglColor4dv(p_v);
					CallLog("glColor4dv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor4f.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color4(float red, float green, float blue, float alpha)
		{
			Debug.Assert(Delegates.pglColor4f != null, "pglColor4f not implemented");
			Delegates.pglColor4f(red, green, blue, alpha);
			CallLog("glColor4f({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor4fv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color4(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4fv != null, "pglColor4fv not implemented");
					Delegates.pglColor4fv(p_v);
					CallLog("glColor4fv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor4i.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color4(Int32 red, Int32 green, Int32 blue, Int32 alpha)
		{
			Debug.Assert(Delegates.pglColor4i != null, "pglColor4i not implemented");
			Delegates.pglColor4i(red, green, blue, alpha);
			CallLog("glColor4i({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor4iv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color4(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4iv != null, "pglColor4iv not implemented");
					Delegates.pglColor4iv(p_v);
					CallLog("glColor4iv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor4s.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color4(Int16 red, Int16 green, Int16 blue, Int16 alpha)
		{
			Debug.Assert(Delegates.pglColor4s != null, "pglColor4s not implemented");
			Delegates.pglColor4s(red, green, blue, alpha);
			CallLog("glColor4s({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor4sv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color4(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4sv != null, "pglColor4sv not implemented");
					Delegates.pglColor4sv(p_v);
					CallLog("glColor4sv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor4ub.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color4(byte red, byte green, byte blue, byte alpha)
		{
			Debug.Assert(Delegates.pglColor4ub != null, "pglColor4ub not implemented");
			Delegates.pglColor4ub(red, green, blue, alpha);
			CallLog("glColor4ub({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor4ubv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color4(byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4ubv != null, "pglColor4ubv not implemented");
					Delegates.pglColor4ubv(p_v);
					CallLog("glColor4ubv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor4ui.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color4(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha)
		{
			Debug.Assert(Delegates.pglColor4ui != null, "pglColor4ui not implemented");
			Delegates.pglColor4ui(red, green, blue, alpha);
			CallLog("glColor4ui({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor4uiv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color4(UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4uiv != null, "pglColor4uiv not implemented");
					Delegates.pglColor4uiv(p_v);
					CallLog("glColor4uiv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor4us.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color4(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha)
		{
			Debug.Assert(Delegates.pglColor4us != null, "pglColor4us not implemented");
			Delegates.pglColor4us(red, green, blue, alpha);
			CallLog("glColor4us({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor4usv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Color4(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4usv != null, "pglColor4usv not implemented");
					Delegates.pglColor4usv(p_v);
					CallLog("glColor4usv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEdgeFlag.
		/// </summary>
		/// <param name="flag">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void EdgeFlag(bool flag)
		{
			Debug.Assert(Delegates.pglEdgeFlag != null, "pglEdgeFlag not implemented");
			Delegates.pglEdgeFlag(flag);
			CallLog("glEdgeFlag({0})", flag);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEdgeFlagv.
		/// </summary>
		/// <param name="flag">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void EdgeFlag(bool[] flag)
		{
			unsafe {
				fixed (bool* p_flag = flag)
				{
					Debug.Assert(Delegates.pglEdgeFlagv != null, "pglEdgeFlagv not implemented");
					Delegates.pglEdgeFlagv(p_flag);
					CallLog("glEdgeFlagv({0})", flag);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// delimit the vertices of a primitive or a group of like primitives
		/// </summary>
		/// <remarks>
		/// <see cref="Gl.Begin"/> and Gl.End delimit the vertices that define a primitive or a group of like primitives. <see 
		/// cref="Gl.Begin"/>accepts a single argument that specifies in which of ten ways the vertices are interpreted. Taking n as 
		/// aninteger count starting at one, and N as the total number of vertices specified, the interpretations are as follows: 
		/// Only a subset of GL commands can be used between <see cref="Gl.Begin"/> and Gl.End. The commands are Gl.Vertex, 
		/// Gl.Color,Gl.SecondaryColor, Gl.Index, Gl.Normal, Gl.FogCoord, Gl.TexCoord, Gl.MultiTexCoord, Gl.VertexAttrib, 
		/// Gl.EvalCoord,Gl.EvalPoint, Gl.ArrayElement, Gl.Material, and Gl.EdgeFlag. Also, it is acceptable to use Gl.CallList or 
		/// Gl.CallListsto execute display lists that include only the preceding commands. If any other GL command is executed 
		/// between<see cref="Gl.Begin"/> and Gl.End, the error flag is set and the command is ignored. 
		/// Regardless of the value chosen for <paramref name="mode"/>, there is no limit to the number of vertices that can be 
		/// definedbetween <see cref="Gl.Begin"/> and Gl.End. Lines, triangles, quadrilaterals, and polygons that are incompletely 
		/// specifiedare not drawn. Incomplete specification results when either too few vertices are provided to specify even a 
		/// singleprimitive or when an incorrect multiple of vertices is specified. The incomplete primitive is ignored; the rest 
		/// aredrawn. 
		/// The minimum specification of vertices for each primitive is as follows: 1 for a point, 2 for a line, 3 for a triangle, 4 
		/// fora quadrilateral, and 3 for a polygon. Modes that require a certain multiple of vertices are <see cref="Gl.LINES"/> 
		/// (2),<see cref="Gl.TRIANGLES"/> (3), <see cref="Gl.QUADS"/> (4), and <see cref="Gl.QUAD_STRIP"/> (2). 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="mode"/> is set to an unaccepted value. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Begin"/> is executed between a <see cref="Gl.Begin"/> 
		///   andthe corresponding execution of Gl.End. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if Gl.End is executed without being preceded by a <see 
		///   cref="Gl.Begin"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a command other than Gl.Vertex, Gl.Color, Gl.SecondaryColor, 
		///   Gl.Index,Gl.Normal, Gl.FogCoord, Gl.TexCoord, Gl.MultiTexCoord, Gl.VertexAttrib, Gl.EvalCoord, Gl.EvalPoint, 
		///   Gl.ArrayElement,Gl.Material, Gl.EdgeFlag, Gl.CallList, or Gl.CallLists is executed between the execution of <see 
		///   cref="Gl.Begin"/>and the corresponding execution Gl.End. 
		/// - Execution of Gl.EnableClientState, Gl.DisableClientState, Gl.EdgeFlagPointer, Gl.FogCoordPointer, Gl.TexCoordPointer, 
		///   Gl.ColorPointer,Gl.SecondaryColorPointer, Gl.IndexPointer, Gl.NormalPointer, Gl.VertexPointer, Gl.VertexAttribPointer, 
		///   Gl.InterleavedArrays,or Gl.PixelStore is not allowed after a call to <see cref="Gl.Begin"/> and before the corresponding 
		///   callto Gl.End, but an error may or may not be generated. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.CallLists"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		public static void End()
		{
			Debug.Assert(Delegates.pglEnd != null, "pglEnd not implemented");
			Delegates.pglEnd();
			CallLog("glEnd()");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIndexd.
		/// </summary>
		/// <param name="c">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Index(double c)
		{
			Debug.Assert(Delegates.pglIndexd != null, "pglIndexd not implemented");
			Delegates.pglIndexd(c);
			CallLog("glIndexd({0})", c);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIndexdv.
		/// </summary>
		/// <param name="c">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Index(double[] c)
		{
			unsafe {
				fixed (double* p_c = c)
				{
					Debug.Assert(Delegates.pglIndexdv != null, "pglIndexdv not implemented");
					Delegates.pglIndexdv(p_c);
					CallLog("glIndexdv({0})", c);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIndexf.
		/// </summary>
		/// <param name="c">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Index(float c)
		{
			Debug.Assert(Delegates.pglIndexf != null, "pglIndexf not implemented");
			Delegates.pglIndexf(c);
			CallLog("glIndexf({0})", c);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIndexfv.
		/// </summary>
		/// <param name="c">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Index(float[] c)
		{
			unsafe {
				fixed (float* p_c = c)
				{
					Debug.Assert(Delegates.pglIndexfv != null, "pglIndexfv not implemented");
					Delegates.pglIndexfv(p_c);
					CallLog("glIndexfv({0})", c);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIndexi.
		/// </summary>
		/// <param name="c">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Index(Int32 c)
		{
			Debug.Assert(Delegates.pglIndexi != null, "pglIndexi not implemented");
			Delegates.pglIndexi(c);
			CallLog("glIndexi({0})", c);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIndexiv.
		/// </summary>
		/// <param name="c">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Index(Int32[] c)
		{
			unsafe {
				fixed (Int32* p_c = c)
				{
					Debug.Assert(Delegates.pglIndexiv != null, "pglIndexiv not implemented");
					Delegates.pglIndexiv(p_c);
					CallLog("glIndexiv({0})", c);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIndexs.
		/// </summary>
		/// <param name="c">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Index(Int16 c)
		{
			Debug.Assert(Delegates.pglIndexs != null, "pglIndexs not implemented");
			Delegates.pglIndexs(c);
			CallLog("glIndexs({0})", c);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIndexsv.
		/// </summary>
		/// <param name="c">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Index(Int16[] c)
		{
			unsafe {
				fixed (Int16* p_c = c)
				{
					Debug.Assert(Delegates.pglIndexsv != null, "pglIndexsv not implemented");
					Delegates.pglIndexsv(p_c);
					CallLog("glIndexsv({0})", c);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNormal3b.
		/// </summary>
		/// <param name="nx">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Normal3(sbyte nx, sbyte ny, sbyte nz)
		{
			Debug.Assert(Delegates.pglNormal3b != null, "pglNormal3b not implemented");
			Delegates.pglNormal3b(nx, ny, nz);
			CallLog("glNormal3b({0}, {1}, {2})", nx, ny, nz);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNormal3bv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Normal3(sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3bv != null, "pglNormal3bv not implemented");
					Delegates.pglNormal3bv(p_v);
					CallLog("glNormal3bv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNormal3d.
		/// </summary>
		/// <param name="nx">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Normal3(double nx, double ny, double nz)
		{
			Debug.Assert(Delegates.pglNormal3d != null, "pglNormal3d not implemented");
			Delegates.pglNormal3d(nx, ny, nz);
			CallLog("glNormal3d({0}, {1}, {2})", nx, ny, nz);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNormal3dv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Normal3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3dv != null, "pglNormal3dv not implemented");
					Delegates.pglNormal3dv(p_v);
					CallLog("glNormal3dv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNormal3f.
		/// </summary>
		/// <param name="nx">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Normal3(float nx, float ny, float nz)
		{
			Debug.Assert(Delegates.pglNormal3f != null, "pglNormal3f not implemented");
			Delegates.pglNormal3f(nx, ny, nz);
			CallLog("glNormal3f({0}, {1}, {2})", nx, ny, nz);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNormal3fv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Normal3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3fv != null, "pglNormal3fv not implemented");
					Delegates.pglNormal3fv(p_v);
					CallLog("glNormal3fv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNormal3i.
		/// </summary>
		/// <param name="nx">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Normal3(Int32 nx, Int32 ny, Int32 nz)
		{
			Debug.Assert(Delegates.pglNormal3i != null, "pglNormal3i not implemented");
			Delegates.pglNormal3i(nx, ny, nz);
			CallLog("glNormal3i({0}, {1}, {2})", nx, ny, nz);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNormal3iv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Normal3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3iv != null, "pglNormal3iv not implemented");
					Delegates.pglNormal3iv(p_v);
					CallLog("glNormal3iv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNormal3s.
		/// </summary>
		/// <param name="nx">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Normal3(Int16 nx, Int16 ny, Int16 nz)
		{
			Debug.Assert(Delegates.pglNormal3s != null, "pglNormal3s not implemented");
			Delegates.pglNormal3s(nx, ny, nz);
			CallLog("glNormal3s({0}, {1}, {2})", nx, ny, nz);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNormal3sv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Normal3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3sv != null, "pglNormal3sv not implemented");
					Delegates.pglNormal3sv(p_v);
					CallLog("glNormal3sv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos2d.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos2(double x, double y)
		{
			Debug.Assert(Delegates.pglRasterPos2d != null, "pglRasterPos2d not implemented");
			Delegates.pglRasterPos2d(x, y);
			CallLog("glRasterPos2d({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos2dv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos2(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos2dv != null, "pglRasterPos2dv not implemented");
					Delegates.pglRasterPos2dv(p_v);
					CallLog("glRasterPos2dv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos2f.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos2(float x, float y)
		{
			Debug.Assert(Delegates.pglRasterPos2f != null, "pglRasterPos2f not implemented");
			Delegates.pglRasterPos2f(x, y);
			CallLog("glRasterPos2f({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos2fv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos2(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos2fv != null, "pglRasterPos2fv not implemented");
					Delegates.pglRasterPos2fv(p_v);
					CallLog("glRasterPos2fv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos2i.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos2(Int32 x, Int32 y)
		{
			Debug.Assert(Delegates.pglRasterPos2i != null, "pglRasterPos2i not implemented");
			Delegates.pglRasterPos2i(x, y);
			CallLog("glRasterPos2i({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos2iv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos2(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos2iv != null, "pglRasterPos2iv not implemented");
					Delegates.pglRasterPos2iv(p_v);
					CallLog("glRasterPos2iv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos2s.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos2(Int16 x, Int16 y)
		{
			Debug.Assert(Delegates.pglRasterPos2s != null, "pglRasterPos2s not implemented");
			Delegates.pglRasterPos2s(x, y);
			CallLog("glRasterPos2s({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos2sv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos2(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos2sv != null, "pglRasterPos2sv not implemented");
					Delegates.pglRasterPos2sv(p_v);
					CallLog("glRasterPos2sv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos3d.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos3(double x, double y, double z)
		{
			Debug.Assert(Delegates.pglRasterPos3d != null, "pglRasterPos3d not implemented");
			Delegates.pglRasterPos3d(x, y, z);
			CallLog("glRasterPos3d({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos3dv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos3dv != null, "pglRasterPos3dv not implemented");
					Delegates.pglRasterPos3dv(p_v);
					CallLog("glRasterPos3dv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos3f.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos3(float x, float y, float z)
		{
			Debug.Assert(Delegates.pglRasterPos3f != null, "pglRasterPos3f not implemented");
			Delegates.pglRasterPos3f(x, y, z);
			CallLog("glRasterPos3f({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos3fv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos3fv != null, "pglRasterPos3fv not implemented");
					Delegates.pglRasterPos3fv(p_v);
					CallLog("glRasterPos3fv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos3i.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos3(Int32 x, Int32 y, Int32 z)
		{
			Debug.Assert(Delegates.pglRasterPos3i != null, "pglRasterPos3i not implemented");
			Delegates.pglRasterPos3i(x, y, z);
			CallLog("glRasterPos3i({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos3iv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos3iv != null, "pglRasterPos3iv not implemented");
					Delegates.pglRasterPos3iv(p_v);
					CallLog("glRasterPos3iv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos3s.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos3(Int16 x, Int16 y, Int16 z)
		{
			Debug.Assert(Delegates.pglRasterPos3s != null, "pglRasterPos3s not implemented");
			Delegates.pglRasterPos3s(x, y, z);
			CallLog("glRasterPos3s({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos3sv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos3sv != null, "pglRasterPos3sv not implemented");
					Delegates.pglRasterPos3sv(p_v);
					CallLog("glRasterPos3sv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos4d.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos4(double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglRasterPos4d != null, "pglRasterPos4d not implemented");
			Delegates.pglRasterPos4d(x, y, z, w);
			CallLog("glRasterPos4d({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos4dv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos4(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos4dv != null, "pglRasterPos4dv not implemented");
					Delegates.pglRasterPos4dv(p_v);
					CallLog("glRasterPos4dv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos4f.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos4(float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglRasterPos4f != null, "pglRasterPos4f not implemented");
			Delegates.pglRasterPos4f(x, y, z, w);
			CallLog("glRasterPos4f({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos4fv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos4(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos4fv != null, "pglRasterPos4fv not implemented");
					Delegates.pglRasterPos4fv(p_v);
					CallLog("glRasterPos4fv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos4i.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos4(Int32 x, Int32 y, Int32 z, Int32 w)
		{
			Debug.Assert(Delegates.pglRasterPos4i != null, "pglRasterPos4i not implemented");
			Delegates.pglRasterPos4i(x, y, z, w);
			CallLog("glRasterPos4i({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos4iv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos4(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos4iv != null, "pglRasterPos4iv not implemented");
					Delegates.pglRasterPos4iv(p_v);
					CallLog("glRasterPos4iv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos4s.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos4(Int16 x, Int16 y, Int16 z, Int16 w)
		{
			Debug.Assert(Delegates.pglRasterPos4s != null, "pglRasterPos4s not implemented");
			Delegates.pglRasterPos4s(x, y, z, w);
			CallLog("glRasterPos4s({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRasterPos4sv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void RasterPos4(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos4sv != null, "pglRasterPos4sv not implemented");
					Delegates.pglRasterPos4sv(p_v);
					CallLog("glRasterPos4sv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRectd.
		/// </summary>
		/// <param name="x1">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y1">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="x2">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y2">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Rect(double x1, double y1, double x2, double y2)
		{
			Debug.Assert(Delegates.pglRectd != null, "pglRectd not implemented");
			Delegates.pglRectd(x1, y1, x2, y2);
			CallLog("glRectd({0}, {1}, {2}, {3})", x1, y1, x2, y2);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRectdv.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Rect(double[] v1, double[] v2)
		{
			unsafe {
				fixed (double* p_v1 = v1)
				fixed (double* p_v2 = v2)
				{
					Debug.Assert(Delegates.pglRectdv != null, "pglRectdv not implemented");
					Delegates.pglRectdv(p_v1, p_v2);
					CallLog("glRectdv({0}, {1})", v1, v2);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRectf.
		/// </summary>
		/// <param name="x1">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y1">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="x2">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y2">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Rect(float x1, float y1, float x2, float y2)
		{
			Debug.Assert(Delegates.pglRectf != null, "pglRectf not implemented");
			Delegates.pglRectf(x1, y1, x2, y2);
			CallLog("glRectf({0}, {1}, {2}, {3})", x1, y1, x2, y2);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRectfv.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Rect(float[] v1, float[] v2)
		{
			unsafe {
				fixed (float* p_v1 = v1)
				fixed (float* p_v2 = v2)
				{
					Debug.Assert(Delegates.pglRectfv != null, "pglRectfv not implemented");
					Delegates.pglRectfv(p_v1, p_v2);
					CallLog("glRectfv({0}, {1})", v1, v2);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRecti.
		/// </summary>
		/// <param name="x1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x2">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y2">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Rect(Int32 x1, Int32 y1, Int32 x2, Int32 y2)
		{
			Debug.Assert(Delegates.pglRecti != null, "pglRecti not implemented");
			Delegates.pglRecti(x1, y1, x2, y2);
			CallLog("glRecti({0}, {1}, {2}, {3})", x1, y1, x2, y2);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRectiv.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Rect(Int32[] v1, Int32[] v2)
		{
			unsafe {
				fixed (Int32* p_v1 = v1)
				fixed (Int32* p_v2 = v2)
				{
					Debug.Assert(Delegates.pglRectiv != null, "pglRectiv not implemented");
					Delegates.pglRectiv(p_v1, p_v2);
					CallLog("glRectiv({0}, {1})", v1, v2);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRects.
		/// </summary>
		/// <param name="x1">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y1">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="x2">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y2">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Rect(Int16 x1, Int16 y1, Int16 x2, Int16 y2)
		{
			Debug.Assert(Delegates.pglRects != null, "pglRects not implemented");
			Delegates.pglRects(x1, y1, x2, y2);
			CallLog("glRects({0}, {1}, {2}, {3})", x1, y1, x2, y2);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRectsv.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Rect(Int16[] v1, Int16[] v2)
		{
			unsafe {
				fixed (Int16* p_v1 = v1)
				fixed (Int16* p_v2 = v2)
				{
					Debug.Assert(Delegates.pglRectsv != null, "pglRectsv not implemented");
					Delegates.pglRectsv(p_v1, p_v2);
					CallLog("glRectsv({0}, {1})", v1, v2);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord1d.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord1(double s)
		{
			Debug.Assert(Delegates.pglTexCoord1d != null, "pglTexCoord1d not implemented");
			Delegates.pglTexCoord1d(s);
			CallLog("glTexCoord1d({0})", s);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord1dv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord1(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord1dv != null, "pglTexCoord1dv not implemented");
					Delegates.pglTexCoord1dv(p_v);
					CallLog("glTexCoord1dv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord1f.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord1(float s)
		{
			Debug.Assert(Delegates.pglTexCoord1f != null, "pglTexCoord1f not implemented");
			Delegates.pglTexCoord1f(s);
			CallLog("glTexCoord1f({0})", s);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord1fv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord1(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord1fv != null, "pglTexCoord1fv not implemented");
					Delegates.pglTexCoord1fv(p_v);
					CallLog("glTexCoord1fv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord1i.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord1(Int32 s)
		{
			Debug.Assert(Delegates.pglTexCoord1i != null, "pglTexCoord1i not implemented");
			Delegates.pglTexCoord1i(s);
			CallLog("glTexCoord1i({0})", s);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord1iv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord1(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord1iv != null, "pglTexCoord1iv not implemented");
					Delegates.pglTexCoord1iv(p_v);
					CallLog("glTexCoord1iv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord1s.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord1(Int16 s)
		{
			Debug.Assert(Delegates.pglTexCoord1s != null, "pglTexCoord1s not implemented");
			Delegates.pglTexCoord1s(s);
			CallLog("glTexCoord1s({0})", s);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord1sv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord1(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord1sv != null, "pglTexCoord1sv not implemented");
					Delegates.pglTexCoord1sv(p_v);
					CallLog("glTexCoord1sv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord2d.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord2(double s, double t)
		{
			Debug.Assert(Delegates.pglTexCoord2d != null, "pglTexCoord2d not implemented");
			Delegates.pglTexCoord2d(s, t);
			CallLog("glTexCoord2d({0}, {1})", s, t);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord2dv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord2(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2dv != null, "pglTexCoord2dv not implemented");
					Delegates.pglTexCoord2dv(p_v);
					CallLog("glTexCoord2dv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord2f.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord2(float s, float t)
		{
			Debug.Assert(Delegates.pglTexCoord2f != null, "pglTexCoord2f not implemented");
			Delegates.pglTexCoord2f(s, t);
			CallLog("glTexCoord2f({0}, {1})", s, t);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord2fv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord2(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2fv != null, "pglTexCoord2fv not implemented");
					Delegates.pglTexCoord2fv(p_v);
					CallLog("glTexCoord2fv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord2i.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord2(Int32 s, Int32 t)
		{
			Debug.Assert(Delegates.pglTexCoord2i != null, "pglTexCoord2i not implemented");
			Delegates.pglTexCoord2i(s, t);
			CallLog("glTexCoord2i({0}, {1})", s, t);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord2iv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord2(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2iv != null, "pglTexCoord2iv not implemented");
					Delegates.pglTexCoord2iv(p_v);
					CallLog("glTexCoord2iv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord2s.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord2(Int16 s, Int16 t)
		{
			Debug.Assert(Delegates.pglTexCoord2s != null, "pglTexCoord2s not implemented");
			Delegates.pglTexCoord2s(s, t);
			CallLog("glTexCoord2s({0}, {1})", s, t);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord2sv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord2(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2sv != null, "pglTexCoord2sv not implemented");
					Delegates.pglTexCoord2sv(p_v);
					CallLog("glTexCoord2sv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord3d.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord3(double s, double t, double r)
		{
			Debug.Assert(Delegates.pglTexCoord3d != null, "pglTexCoord3d not implemented");
			Delegates.pglTexCoord3d(s, t, r);
			CallLog("glTexCoord3d({0}, {1}, {2})", s, t, r);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord3dv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord3dv != null, "pglTexCoord3dv not implemented");
					Delegates.pglTexCoord3dv(p_v);
					CallLog("glTexCoord3dv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord3f.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord3(float s, float t, float r)
		{
			Debug.Assert(Delegates.pglTexCoord3f != null, "pglTexCoord3f not implemented");
			Delegates.pglTexCoord3f(s, t, r);
			CallLog("glTexCoord3f({0}, {1}, {2})", s, t, r);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord3fv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord3fv != null, "pglTexCoord3fv not implemented");
					Delegates.pglTexCoord3fv(p_v);
					CallLog("glTexCoord3fv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord3i.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord3(Int32 s, Int32 t, Int32 r)
		{
			Debug.Assert(Delegates.pglTexCoord3i != null, "pglTexCoord3i not implemented");
			Delegates.pglTexCoord3i(s, t, r);
			CallLog("glTexCoord3i({0}, {1}, {2})", s, t, r);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord3iv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord3iv != null, "pglTexCoord3iv not implemented");
					Delegates.pglTexCoord3iv(p_v);
					CallLog("glTexCoord3iv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord3s.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord3(Int16 s, Int16 t, Int16 r)
		{
			Debug.Assert(Delegates.pglTexCoord3s != null, "pglTexCoord3s not implemented");
			Delegates.pglTexCoord3s(s, t, r);
			CallLog("glTexCoord3s({0}, {1}, {2})", s, t, r);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord3sv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord3sv != null, "pglTexCoord3sv not implemented");
					Delegates.pglTexCoord3sv(p_v);
					CallLog("glTexCoord3sv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord4d.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord4(double s, double t, double r, double q)
		{
			Debug.Assert(Delegates.pglTexCoord4d != null, "pglTexCoord4d not implemented");
			Delegates.pglTexCoord4d(s, t, r, q);
			CallLog("glTexCoord4d({0}, {1}, {2}, {3})", s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord4dv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord4(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord4dv != null, "pglTexCoord4dv not implemented");
					Delegates.pglTexCoord4dv(p_v);
					CallLog("glTexCoord4dv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord4f.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord4(float s, float t, float r, float q)
		{
			Debug.Assert(Delegates.pglTexCoord4f != null, "pglTexCoord4f not implemented");
			Delegates.pglTexCoord4f(s, t, r, q);
			CallLog("glTexCoord4f({0}, {1}, {2}, {3})", s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord4fv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord4(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord4fv != null, "pglTexCoord4fv not implemented");
					Delegates.pglTexCoord4fv(p_v);
					CallLog("glTexCoord4fv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord4i.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord4(Int32 s, Int32 t, Int32 r, Int32 q)
		{
			Debug.Assert(Delegates.pglTexCoord4i != null, "pglTexCoord4i not implemented");
			Delegates.pglTexCoord4i(s, t, r, q);
			CallLog("glTexCoord4i({0}, {1}, {2}, {3})", s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord4iv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord4(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord4iv != null, "pglTexCoord4iv not implemented");
					Delegates.pglTexCoord4iv(p_v);
					CallLog("glTexCoord4iv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord4s.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord4(Int16 s, Int16 t, Int16 r, Int16 q)
		{
			Debug.Assert(Delegates.pglTexCoord4s != null, "pglTexCoord4s not implemented");
			Delegates.pglTexCoord4s(s, t, r, q);
			CallLog("glTexCoord4s({0}, {1}, {2}, {3})", s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord4sv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void TexCoord4(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord4sv != null, "pglTexCoord4sv not implemented");
					Delegates.pglTexCoord4sv(p_v);
					CallLog("glTexCoord4sv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex2d.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex2(double x, double y)
		{
			Debug.Assert(Delegates.pglVertex2d != null, "pglVertex2d not implemented");
			Delegates.pglVertex2d(x, y);
			CallLog("glVertex2d({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex2dv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex2(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex2dv != null, "pglVertex2dv not implemented");
					Delegates.pglVertex2dv(p_v);
					CallLog("glVertex2dv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex2f.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex2(float x, float y)
		{
			Debug.Assert(Delegates.pglVertex2f != null, "pglVertex2f not implemented");
			Delegates.pglVertex2f(x, y);
			CallLog("glVertex2f({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex2fv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex2(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex2fv != null, "pglVertex2fv not implemented");
					Delegates.pglVertex2fv(p_v);
					CallLog("glVertex2fv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex2i.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex2(Int32 x, Int32 y)
		{
			Debug.Assert(Delegates.pglVertex2i != null, "pglVertex2i not implemented");
			Delegates.pglVertex2i(x, y);
			CallLog("glVertex2i({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex2iv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex2(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex2iv != null, "pglVertex2iv not implemented");
					Delegates.pglVertex2iv(p_v);
					CallLog("glVertex2iv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex2s.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex2(Int16 x, Int16 y)
		{
			Debug.Assert(Delegates.pglVertex2s != null, "pglVertex2s not implemented");
			Delegates.pglVertex2s(x, y);
			CallLog("glVertex2s({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex2sv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex2(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex2sv != null, "pglVertex2sv not implemented");
					Delegates.pglVertex2sv(p_v);
					CallLog("glVertex2sv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex3d.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex3(double x, double y, double z)
		{
			Debug.Assert(Delegates.pglVertex3d != null, "pglVertex3d not implemented");
			Delegates.pglVertex3d(x, y, z);
			CallLog("glVertex3d({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex3dv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex3dv != null, "pglVertex3dv not implemented");
					Delegates.pglVertex3dv(p_v);
					CallLog("glVertex3dv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex3f.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex3(float x, float y, float z)
		{
			Debug.Assert(Delegates.pglVertex3f != null, "pglVertex3f not implemented");
			Delegates.pglVertex3f(x, y, z);
			CallLog("glVertex3f({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex3fv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex3fv != null, "pglVertex3fv not implemented");
					Delegates.pglVertex3fv(p_v);
					CallLog("glVertex3fv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex3i.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex3(Int32 x, Int32 y, Int32 z)
		{
			Debug.Assert(Delegates.pglVertex3i != null, "pglVertex3i not implemented");
			Delegates.pglVertex3i(x, y, z);
			CallLog("glVertex3i({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex3iv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex3iv != null, "pglVertex3iv not implemented");
					Delegates.pglVertex3iv(p_v);
					CallLog("glVertex3iv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex3s.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex3(Int16 x, Int16 y, Int16 z)
		{
			Debug.Assert(Delegates.pglVertex3s != null, "pglVertex3s not implemented");
			Delegates.pglVertex3s(x, y, z);
			CallLog("glVertex3s({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex3sv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex3sv != null, "pglVertex3sv not implemented");
					Delegates.pglVertex3sv(p_v);
					CallLog("glVertex3sv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex4d.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex4(double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglVertex4d != null, "pglVertex4d not implemented");
			Delegates.pglVertex4d(x, y, z, w);
			CallLog("glVertex4d({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex4dv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex4(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex4dv != null, "pglVertex4dv not implemented");
					Delegates.pglVertex4dv(p_v);
					CallLog("glVertex4dv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex4f.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex4(float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglVertex4f != null, "pglVertex4f not implemented");
			Delegates.pglVertex4f(x, y, z, w);
			CallLog("glVertex4f({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex4fv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex4(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex4fv != null, "pglVertex4fv not implemented");
					Delegates.pglVertex4fv(p_v);
					CallLog("glVertex4fv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex4i.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex4(Int32 x, Int32 y, Int32 z, Int32 w)
		{
			Debug.Assert(Delegates.pglVertex4i != null, "pglVertex4i not implemented");
			Delegates.pglVertex4i(x, y, z, w);
			CallLog("glVertex4i({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex4iv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex4(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex4iv != null, "pglVertex4iv not implemented");
					Delegates.pglVertex4iv(p_v);
					CallLog("glVertex4iv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex4s.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex4(Int16 x, Int16 y, Int16 z, Int16 w)
		{
			Debug.Assert(Delegates.pglVertex4s != null, "pglVertex4s not implemented");
			Delegates.pglVertex4s(x, y, z, w);
			CallLog("glVertex4s({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex4sv.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Vertex4(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex4sv != null, "pglVertex4sv not implemented");
					Delegates.pglVertex4sv(p_v);
					CallLog("glVertex4sv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glClipPlane.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ClipPlane(int plane, double[] equation)
		{
			unsafe {
				fixed (double* p_equation = equation)
				{
					Debug.Assert(Delegates.pglClipPlane != null, "pglClipPlane not implemented");
					Delegates.pglClipPlane(plane, p_equation);
					CallLog("glClipPlane({0}, {1})", plane, equation);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glClipPlane.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ClipPlane(ClipPlaneName plane, double[] equation)
		{
			unsafe {
				fixed (double* p_equation = equation)
				{
					Debug.Assert(Delegates.pglClipPlane != null, "pglClipPlane not implemented");
					Delegates.pglClipPlane((int)plane, p_equation);
					CallLog("glClipPlane({0}, {1})", plane, equation);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorMaterial.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ColorMaterial(int face, int mode)
		{
			Debug.Assert(Delegates.pglColorMaterial != null, "pglColorMaterial not implemented");
			Delegates.pglColorMaterial(face, mode);
			CallLog("glColorMaterial({0}, {1})", face, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorMaterial.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ColorMaterial(MaterialFace face, ColorMaterialParameter mode)
		{
			Debug.Assert(Delegates.pglColorMaterial != null, "pglColorMaterial not implemented");
			Delegates.pglColorMaterial((int)face, (int)mode);
			CallLog("glColorMaterial({0}, {1})", face, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. <see cref="Gl.FOG_MODE"/>, <see cref="Gl.FOG_DENSITY"/>, <see 
		/// cref="Gl.FOG_START"/>,<see cref="Gl.FOG_END"/>, <see cref="Gl.FOG_INDEX"/>, and <see cref="Gl.FOG_COORD_SRC"/> are 
		/// accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> will be set to. 
		/// </param>
		/// <remarks>
		/// Fog is initially disabled. While enabled, fog affects rasterized geometry, bitmaps, and pixel blocks, but not buffer 
		/// clearoperations. To enable and disable fog, call Gl.Enable and Gl.Disable with argument <see cref="Gl.FOG"/>. 
		/// <see cref="Gl.Fog"/> assigns the value or values in <paramref name="params"/> to the fog parameter specified by 
		/// <paramrefname="pname"/>. The following values are accepted for <paramref name="pname"/>: 
		/// Fog blends a fog color with each rasterized pixel fragment's post-texturing color using a blending factor f. Factor f is 
		/// computedin one of three ways, depending on the fog mode. Let c be either the distance in eye coordinate from the origin 
		/// (inthe case that the <see cref="Gl.FOG_COORD_SRC"/> is <see cref="Gl.FRAGMENT_DEPTH"/>) or the current fog coordinate 
		/// (inthe case that <see cref="Gl.FOG_COORD_SRC"/> is <see cref="Gl.FOG_COORD"/>). The equation for <see cref="Gl.LINEAR"/> 
		/// fogis f=end-cend-start 
		/// The equation for <see cref="Gl.EXP"/> fog is f=e-density·c 
		/// The equation for <see cref="Gl.EXP2"/> fog is f=e-density·c2 
		/// Regardless of the fog mode, f is clamped to the range 01 after it is computed. Then, if the GL is in RGBA color mode, 
		/// thefragment's red, green, and blue colors, represented by Cr, are replaced by 
		/// Cr″=f×Cr+1-f×Cf 
		/// Fog does not affect a fragment's alpha component. 
		/// In color index mode, the fragment's color index ir is replaced by 
		/// ir″=ir+1-f×if 
		///  
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not an accepted value, or if <paramref 
		///   name="pname"/>is <see cref="Gl.FOG_MODE"/> and <paramref name="params"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="pname"/> is <see cref="Gl.FOG_DENSITY"/> and <paramref 
		///   name="params"/>is negative. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Fog"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.FOG"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_COLOR"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_INDEX"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_DENSITY"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_START"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_END"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_MODE"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Enable"/>
		public static void Fog(int pname, float param)
		{
			Debug.Assert(Delegates.pglFogf != null, "pglFogf not implemented");
			Delegates.pglFogf(pname, param);
			CallLog("glFogf({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. <see cref="Gl.FOG_MODE"/>, <see cref="Gl.FOG_DENSITY"/>, <see 
		/// cref="Gl.FOG_START"/>,<see cref="Gl.FOG_END"/>, <see cref="Gl.FOG_INDEX"/>, and <see cref="Gl.FOG_COORD_SRC"/> are 
		/// accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> will be set to. 
		/// </param>
		/// <remarks>
		/// Fog is initially disabled. While enabled, fog affects rasterized geometry, bitmaps, and pixel blocks, but not buffer 
		/// clearoperations. To enable and disable fog, call Gl.Enable and Gl.Disable with argument <see cref="Gl.FOG"/>. 
		/// <see cref="Gl.Fog"/> assigns the value or values in <paramref name="params"/> to the fog parameter specified by 
		/// <paramrefname="pname"/>. The following values are accepted for <paramref name="pname"/>: 
		/// Fog blends a fog color with each rasterized pixel fragment's post-texturing color using a blending factor f. Factor f is 
		/// computedin one of three ways, depending on the fog mode. Let c be either the distance in eye coordinate from the origin 
		/// (inthe case that the <see cref="Gl.FOG_COORD_SRC"/> is <see cref="Gl.FRAGMENT_DEPTH"/>) or the current fog coordinate 
		/// (inthe case that <see cref="Gl.FOG_COORD_SRC"/> is <see cref="Gl.FOG_COORD"/>). The equation for <see cref="Gl.LINEAR"/> 
		/// fogis f=end-cend-start 
		/// The equation for <see cref="Gl.EXP"/> fog is f=e-density·c 
		/// The equation for <see cref="Gl.EXP2"/> fog is f=e-density·c2 
		/// Regardless of the fog mode, f is clamped to the range 01 after it is computed. Then, if the GL is in RGBA color mode, 
		/// thefragment's red, green, and blue colors, represented by Cr, are replaced by 
		/// Cr″=f×Cr+1-f×Cf 
		/// Fog does not affect a fragment's alpha component. 
		/// In color index mode, the fragment's color index ir is replaced by 
		/// ir″=ir+1-f×if 
		///  
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not an accepted value, or if <paramref 
		///   name="pname"/>is <see cref="Gl.FOG_MODE"/> and <paramref name="params"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="pname"/> is <see cref="Gl.FOG_DENSITY"/> and <paramref 
		///   name="params"/>is negative. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Fog"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.FOG"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_COLOR"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_INDEX"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_DENSITY"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_START"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_END"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_MODE"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Enable"/>
		public static void Fog(FogParameter pname, float param)
		{
			Debug.Assert(Delegates.pglFogf != null, "pglFogf not implemented");
			Delegates.pglFogf((int)pname, param);
			CallLog("glFogf({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. <see cref="Gl.FOG_MODE"/>, <see cref="Gl.FOG_DENSITY"/>, <see 
		/// cref="Gl.FOG_START"/>,<see cref="Gl.FOG_END"/>, <see cref="Gl.FOG_INDEX"/>, and <see cref="Gl.FOG_COORD_SRC"/> are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// Fog is initially disabled. While enabled, fog affects rasterized geometry, bitmaps, and pixel blocks, but not buffer 
		/// clearoperations. To enable and disable fog, call Gl.Enable and Gl.Disable with argument <see cref="Gl.FOG"/>. 
		/// <see cref="Gl.Fog"/> assigns the value or values in <paramref name="params"/> to the fog parameter specified by 
		/// <paramrefname="pname"/>. The following values are accepted for <paramref name="pname"/>: 
		/// Fog blends a fog color with each rasterized pixel fragment's post-texturing color using a blending factor f. Factor f is 
		/// computedin one of three ways, depending on the fog mode. Let c be either the distance in eye coordinate from the origin 
		/// (inthe case that the <see cref="Gl.FOG_COORD_SRC"/> is <see cref="Gl.FRAGMENT_DEPTH"/>) or the current fog coordinate 
		/// (inthe case that <see cref="Gl.FOG_COORD_SRC"/> is <see cref="Gl.FOG_COORD"/>). The equation for <see cref="Gl.LINEAR"/> 
		/// fogis f=end-cend-start 
		/// The equation for <see cref="Gl.EXP"/> fog is f=e-density·c 
		/// The equation for <see cref="Gl.EXP2"/> fog is f=e-density·c2 
		/// Regardless of the fog mode, f is clamped to the range 01 after it is computed. Then, if the GL is in RGBA color mode, 
		/// thefragment's red, green, and blue colors, represented by Cr, are replaced by 
		/// Cr″=f×Cr+1-f×Cf 
		/// Fog does not affect a fragment's alpha component. 
		/// In color index mode, the fragment's color index ir is replaced by 
		/// ir″=ir+1-f×if 
		///  
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not an accepted value, or if <paramref 
		///   name="pname"/>is <see cref="Gl.FOG_MODE"/> and <paramref name="params"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="pname"/> is <see cref="Gl.FOG_DENSITY"/> and <paramref 
		///   name="params"/>is negative. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Fog"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.FOG"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_COLOR"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_INDEX"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_DENSITY"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_START"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_END"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_MODE"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Enable"/>
		public static void Fog(int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglFogfv != null, "pglFogfv not implemented");
					Delegates.pglFogfv(pname, p_params);
					CallLog("glFogfv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. <see cref="Gl.FOG_MODE"/>, <see cref="Gl.FOG_DENSITY"/>, <see 
		/// cref="Gl.FOG_START"/>,<see cref="Gl.FOG_END"/>, <see cref="Gl.FOG_INDEX"/>, and <see cref="Gl.FOG_COORD_SRC"/> are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// Fog is initially disabled. While enabled, fog affects rasterized geometry, bitmaps, and pixel blocks, but not buffer 
		/// clearoperations. To enable and disable fog, call Gl.Enable and Gl.Disable with argument <see cref="Gl.FOG"/>. 
		/// <see cref="Gl.Fog"/> assigns the value or values in <paramref name="params"/> to the fog parameter specified by 
		/// <paramrefname="pname"/>. The following values are accepted for <paramref name="pname"/>: 
		/// Fog blends a fog color with each rasterized pixel fragment's post-texturing color using a blending factor f. Factor f is 
		/// computedin one of three ways, depending on the fog mode. Let c be either the distance in eye coordinate from the origin 
		/// (inthe case that the <see cref="Gl.FOG_COORD_SRC"/> is <see cref="Gl.FRAGMENT_DEPTH"/>) or the current fog coordinate 
		/// (inthe case that <see cref="Gl.FOG_COORD_SRC"/> is <see cref="Gl.FOG_COORD"/>). The equation for <see cref="Gl.LINEAR"/> 
		/// fogis f=end-cend-start 
		/// The equation for <see cref="Gl.EXP"/> fog is f=e-density·c 
		/// The equation for <see cref="Gl.EXP2"/> fog is f=e-density·c2 
		/// Regardless of the fog mode, f is clamped to the range 01 after it is computed. Then, if the GL is in RGBA color mode, 
		/// thefragment's red, green, and blue colors, represented by Cr, are replaced by 
		/// Cr″=f×Cr+1-f×Cf 
		/// Fog does not affect a fragment's alpha component. 
		/// In color index mode, the fragment's color index ir is replaced by 
		/// ir″=ir+1-f×if 
		///  
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not an accepted value, or if <paramref 
		///   name="pname"/>is <see cref="Gl.FOG_MODE"/> and <paramref name="params"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="pname"/> is <see cref="Gl.FOG_DENSITY"/> and <paramref 
		///   name="params"/>is negative. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Fog"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.FOG"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_COLOR"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_INDEX"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_DENSITY"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_START"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_END"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_MODE"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Enable"/>
		public static void Fog(FogParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglFogfv != null, "pglFogfv not implemented");
					Delegates.pglFogfv((int)pname, p_params);
					CallLog("glFogfv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. <see cref="Gl.FOG_MODE"/>, <see cref="Gl.FOG_DENSITY"/>, <see 
		/// cref="Gl.FOG_START"/>,<see cref="Gl.FOG_END"/>, <see cref="Gl.FOG_INDEX"/>, and <see cref="Gl.FOG_COORD_SRC"/> are 
		/// accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> will be set to. 
		/// </param>
		/// <remarks>
		/// Fog is initially disabled. While enabled, fog affects rasterized geometry, bitmaps, and pixel blocks, but not buffer 
		/// clearoperations. To enable and disable fog, call Gl.Enable and Gl.Disable with argument <see cref="Gl.FOG"/>. 
		/// <see cref="Gl.Fog"/> assigns the value or values in <paramref name="params"/> to the fog parameter specified by 
		/// <paramrefname="pname"/>. The following values are accepted for <paramref name="pname"/>: 
		/// Fog blends a fog color with each rasterized pixel fragment's post-texturing color using a blending factor f. Factor f is 
		/// computedin one of three ways, depending on the fog mode. Let c be either the distance in eye coordinate from the origin 
		/// (inthe case that the <see cref="Gl.FOG_COORD_SRC"/> is <see cref="Gl.FRAGMENT_DEPTH"/>) or the current fog coordinate 
		/// (inthe case that <see cref="Gl.FOG_COORD_SRC"/> is <see cref="Gl.FOG_COORD"/>). The equation for <see cref="Gl.LINEAR"/> 
		/// fogis f=end-cend-start 
		/// The equation for <see cref="Gl.EXP"/> fog is f=e-density·c 
		/// The equation for <see cref="Gl.EXP2"/> fog is f=e-density·c2 
		/// Regardless of the fog mode, f is clamped to the range 01 after it is computed. Then, if the GL is in RGBA color mode, 
		/// thefragment's red, green, and blue colors, represented by Cr, are replaced by 
		/// Cr″=f×Cr+1-f×Cf 
		/// Fog does not affect a fragment's alpha component. 
		/// In color index mode, the fragment's color index ir is replaced by 
		/// ir″=ir+1-f×if 
		///  
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not an accepted value, or if <paramref 
		///   name="pname"/>is <see cref="Gl.FOG_MODE"/> and <paramref name="params"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="pname"/> is <see cref="Gl.FOG_DENSITY"/> and <paramref 
		///   name="params"/>is negative. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Fog"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.FOG"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_COLOR"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_INDEX"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_DENSITY"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_START"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_END"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_MODE"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Enable"/>
		public static void Fog(int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglFogi != null, "pglFogi not implemented");
			Delegates.pglFogi(pname, param);
			CallLog("glFogi({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. <see cref="Gl.FOG_MODE"/>, <see cref="Gl.FOG_DENSITY"/>, <see 
		/// cref="Gl.FOG_START"/>,<see cref="Gl.FOG_END"/>, <see cref="Gl.FOG_INDEX"/>, and <see cref="Gl.FOG_COORD_SRC"/> are 
		/// accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> will be set to. 
		/// </param>
		/// <remarks>
		/// Fog is initially disabled. While enabled, fog affects rasterized geometry, bitmaps, and pixel blocks, but not buffer 
		/// clearoperations. To enable and disable fog, call Gl.Enable and Gl.Disable with argument <see cref="Gl.FOG"/>. 
		/// <see cref="Gl.Fog"/> assigns the value or values in <paramref name="params"/> to the fog parameter specified by 
		/// <paramrefname="pname"/>. The following values are accepted for <paramref name="pname"/>: 
		/// Fog blends a fog color with each rasterized pixel fragment's post-texturing color using a blending factor f. Factor f is 
		/// computedin one of three ways, depending on the fog mode. Let c be either the distance in eye coordinate from the origin 
		/// (inthe case that the <see cref="Gl.FOG_COORD_SRC"/> is <see cref="Gl.FRAGMENT_DEPTH"/>) or the current fog coordinate 
		/// (inthe case that <see cref="Gl.FOG_COORD_SRC"/> is <see cref="Gl.FOG_COORD"/>). The equation for <see cref="Gl.LINEAR"/> 
		/// fogis f=end-cend-start 
		/// The equation for <see cref="Gl.EXP"/> fog is f=e-density·c 
		/// The equation for <see cref="Gl.EXP2"/> fog is f=e-density·c2 
		/// Regardless of the fog mode, f is clamped to the range 01 after it is computed. Then, if the GL is in RGBA color mode, 
		/// thefragment's red, green, and blue colors, represented by Cr, are replaced by 
		/// Cr″=f×Cr+1-f×Cf 
		/// Fog does not affect a fragment's alpha component. 
		/// In color index mode, the fragment's color index ir is replaced by 
		/// ir″=ir+1-f×if 
		///  
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not an accepted value, or if <paramref 
		///   name="pname"/>is <see cref="Gl.FOG_MODE"/> and <paramref name="params"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="pname"/> is <see cref="Gl.FOG_DENSITY"/> and <paramref 
		///   name="params"/>is negative. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Fog"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.FOG"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_COLOR"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_INDEX"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_DENSITY"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_START"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_END"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_MODE"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Enable"/>
		public static void Fog(FogParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglFogi != null, "pglFogi not implemented");
			Delegates.pglFogi((int)pname, param);
			CallLog("glFogi({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. <see cref="Gl.FOG_MODE"/>, <see cref="Gl.FOG_DENSITY"/>, <see 
		/// cref="Gl.FOG_START"/>,<see cref="Gl.FOG_END"/>, <see cref="Gl.FOG_INDEX"/>, and <see cref="Gl.FOG_COORD_SRC"/> are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// Fog is initially disabled. While enabled, fog affects rasterized geometry, bitmaps, and pixel blocks, but not buffer 
		/// clearoperations. To enable and disable fog, call Gl.Enable and Gl.Disable with argument <see cref="Gl.FOG"/>. 
		/// <see cref="Gl.Fog"/> assigns the value or values in <paramref name="params"/> to the fog parameter specified by 
		/// <paramrefname="pname"/>. The following values are accepted for <paramref name="pname"/>: 
		/// Fog blends a fog color with each rasterized pixel fragment's post-texturing color using a blending factor f. Factor f is 
		/// computedin one of three ways, depending on the fog mode. Let c be either the distance in eye coordinate from the origin 
		/// (inthe case that the <see cref="Gl.FOG_COORD_SRC"/> is <see cref="Gl.FRAGMENT_DEPTH"/>) or the current fog coordinate 
		/// (inthe case that <see cref="Gl.FOG_COORD_SRC"/> is <see cref="Gl.FOG_COORD"/>). The equation for <see cref="Gl.LINEAR"/> 
		/// fogis f=end-cend-start 
		/// The equation for <see cref="Gl.EXP"/> fog is f=e-density·c 
		/// The equation for <see cref="Gl.EXP2"/> fog is f=e-density·c2 
		/// Regardless of the fog mode, f is clamped to the range 01 after it is computed. Then, if the GL is in RGBA color mode, 
		/// thefragment's red, green, and blue colors, represented by Cr, are replaced by 
		/// Cr″=f×Cr+1-f×Cf 
		/// Fog does not affect a fragment's alpha component. 
		/// In color index mode, the fragment's color index ir is replaced by 
		/// ir″=ir+1-f×if 
		///  
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not an accepted value, or if <paramref 
		///   name="pname"/>is <see cref="Gl.FOG_MODE"/> and <paramref name="params"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="pname"/> is <see cref="Gl.FOG_DENSITY"/> and <paramref 
		///   name="params"/>is negative. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Fog"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.FOG"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_COLOR"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_INDEX"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_DENSITY"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_START"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_END"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_MODE"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Enable"/>
		public static void Fog(int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglFogiv != null, "pglFogiv not implemented");
					Delegates.pglFogiv(pname, p_params);
					CallLog("glFogiv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. <see cref="Gl.FOG_MODE"/>, <see cref="Gl.FOG_DENSITY"/>, <see 
		/// cref="Gl.FOG_START"/>,<see cref="Gl.FOG_END"/>, <see cref="Gl.FOG_INDEX"/>, and <see cref="Gl.FOG_COORD_SRC"/> are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// Fog is initially disabled. While enabled, fog affects rasterized geometry, bitmaps, and pixel blocks, but not buffer 
		/// clearoperations. To enable and disable fog, call Gl.Enable and Gl.Disable with argument <see cref="Gl.FOG"/>. 
		/// <see cref="Gl.Fog"/> assigns the value or values in <paramref name="params"/> to the fog parameter specified by 
		/// <paramrefname="pname"/>. The following values are accepted for <paramref name="pname"/>: 
		/// Fog blends a fog color with each rasterized pixel fragment's post-texturing color using a blending factor f. Factor f is 
		/// computedin one of three ways, depending on the fog mode. Let c be either the distance in eye coordinate from the origin 
		/// (inthe case that the <see cref="Gl.FOG_COORD_SRC"/> is <see cref="Gl.FRAGMENT_DEPTH"/>) or the current fog coordinate 
		/// (inthe case that <see cref="Gl.FOG_COORD_SRC"/> is <see cref="Gl.FOG_COORD"/>). The equation for <see cref="Gl.LINEAR"/> 
		/// fogis f=end-cend-start 
		/// The equation for <see cref="Gl.EXP"/> fog is f=e-density·c 
		/// The equation for <see cref="Gl.EXP2"/> fog is f=e-density·c2 
		/// Regardless of the fog mode, f is clamped to the range 01 after it is computed. Then, if the GL is in RGBA color mode, 
		/// thefragment's red, green, and blue colors, represented by Cr, are replaced by 
		/// Cr″=f×Cr+1-f×Cf 
		/// Fog does not affect a fragment's alpha component. 
		/// In color index mode, the fragment's color index ir is replaced by 
		/// ir″=ir+1-f×if 
		///  
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="pname"/> is not an accepted value, or if <paramref 
		///   name="pname"/>is <see cref="Gl.FOG_MODE"/> and <paramref name="params"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="pname"/> is <see cref="Gl.FOG_DENSITY"/> and <paramref 
		///   name="params"/>is negative. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Fog"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.FOG"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_COLOR"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_INDEX"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_DENSITY"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_START"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_END"/> 
		/// - Gl.Get with argument <see cref="Gl.FOG_MODE"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Enable"/>
		public static void Fog(FogParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglFogiv != null, "pglFogiv not implemented");
					Delegates.pglFogiv((int)pname, p_params);
					CallLog("glFogiv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightf.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Light(int light, int pname, float param)
		{
			Debug.Assert(Delegates.pglLightf != null, "pglLightf not implemented");
			Delegates.pglLightf(light, pname, param);
			CallLog("glLightf({0}, {1}, {2})", light, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightf.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Light(LightName light, LightParameter pname, float param)
		{
			Debug.Assert(Delegates.pglLightf != null, "pglLightf not implemented");
			Delegates.pglLightf((int)light, (int)pname, param);
			CallLog("glLightf({0}, {1}, {2})", light, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightfv.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Light(int light, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightfv != null, "pglLightfv not implemented");
					Delegates.pglLightfv(light, pname, p_params);
					CallLog("glLightfv({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightfv.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Light(LightName light, LightParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightfv != null, "pglLightfv not implemented");
					Delegates.pglLightfv((int)light, (int)pname, p_params);
					CallLog("glLightfv({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLighti.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Light(int light, int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglLighti != null, "pglLighti not implemented");
			Delegates.pglLighti(light, pname, param);
			CallLog("glLighti({0}, {1}, {2})", light, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLighti.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Light(LightName light, LightParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglLighti != null, "pglLighti not implemented");
			Delegates.pglLighti((int)light, (int)pname, param);
			CallLog("glLighti({0}, {1}, {2})", light, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightiv.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Light(int light, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightiv != null, "pglLightiv not implemented");
					Delegates.pglLightiv(light, pname, p_params);
					CallLog("glLightiv({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightiv.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Light(LightName light, LightParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightiv != null, "pglLightiv not implemented");
					Delegates.pglLightiv((int)light, (int)pname, p_params);
					CallLog("glLightiv({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightModelf.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void LightModel(int pname, float param)
		{
			Debug.Assert(Delegates.pglLightModelf != null, "pglLightModelf not implemented");
			Delegates.pglLightModelf(pname, param);
			CallLog("glLightModelf({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightModelf.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void LightModel(LightModelParameter pname, float param)
		{
			Debug.Assert(Delegates.pglLightModelf != null, "pglLightModelf not implemented");
			Delegates.pglLightModelf((int)pname, param);
			CallLog("glLightModelf({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightModelfv.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void LightModel(int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightModelfv != null, "pglLightModelfv not implemented");
					Delegates.pglLightModelfv(pname, p_params);
					CallLog("glLightModelfv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightModelfv.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void LightModel(LightModelParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightModelfv != null, "pglLightModelfv not implemented");
					Delegates.pglLightModelfv((int)pname, p_params);
					CallLog("glLightModelfv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightModeli.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void LightModel(int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglLightModeli != null, "pglLightModeli not implemented");
			Delegates.pglLightModeli(pname, param);
			CallLog("glLightModeli({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightModeli.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void LightModel(LightModelParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglLightModeli != null, "pglLightModeli not implemented");
			Delegates.pglLightModeli((int)pname, param);
			CallLog("glLightModeli({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightModeliv.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void LightModel(int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightModeliv != null, "pglLightModeliv not implemented");
					Delegates.pglLightModeliv(pname, p_params);
					CallLog("glLightModeliv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightModeliv.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void LightModel(LightModelParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightModeliv != null, "pglLightModeliv not implemented");
					Delegates.pglLightModeliv((int)pname, p_params);
					CallLog("glLightModeliv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the line stipple pattern
		/// </summary>
		/// <param name="factor">
		/// Specifies a multiplier for each bit in the line stipple pattern. If <paramref name="factor"/> is 3, for example, each 
		/// bitin the pattern is used three times before the next bit in the pattern is used. <paramref name="factor"/> is clamped 
		/// tothe range [1, 256] and defaults to 1. 
		/// </param>
		/// <param name="pattern">
		/// Specifies a 16-bit integer whose bit pattern determines which fragments of a line will be drawn when the line is 
		/// rasterized.Bit zero is used first; the default pattern is all 1's. 
		/// </param>
		/// <remarks>
		/// Line stippling masks out certain fragments produced by rasterization; those fragments will not be drawn. The masking is 
		/// achievedby using three parameters: the 16-bit line stipple pattern <paramref name="pattern"/>, the repeat count 
		/// <paramrefname="factor"/>, and an integer stipple counter s. 
		/// Counter s is reset to 0 whenever Gl.Begin is called and before each line segment of a Gl.Begin(<see 
		/// cref="Gl.LINES"/>)/Gl.Endsequence is generated. It is incremented after each fragment of a unit width aliased line 
		/// segmentis generated or after each i fragments of an i width line segment are generated. The i fragments associated with 
		/// counts are masked out if 
		/// <paramref name="pattern"/> bit sfactor%16 
		/// is 0, otherwise these fragments are sent to the frame buffer. Bit zero of <paramref name="pattern"/> is the least 
		/// significantbit. 
		/// Antialiased lines are treated as a sequence of 1×width rectangles for purposes of stippling. Whether rectangle s is 
		/// rasterizedor not depends on the fragment rule described for aliased lines, counting rectangles rather than groups of 
		/// fragments.
		/// To enable and disable line stippling, call Gl.Enable and Gl.Disable with argument <see cref="Gl.LINE_STIPPLE"/>. When 
		/// enabled,the line stipple pattern is applied as described above. When disabled, it is as if the pattern were all 1's. 
		/// Initially,line stippling is disabled. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.LineStipple"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.LINE_STIPPLE_PATTERN"/> 
		/// - Gl.Get with argument <see cref="Gl.LINE_STIPPLE_REPEAT"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.LINE_STIPPLE"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LineWidth"/>
		/// <seealso cref="Gl.PolygonStipple"/>
		public static void LineStipple(Int32 factor, UInt16 pattern)
		{
			Debug.Assert(Delegates.pglLineStipple != null, "pglLineStipple not implemented");
			Delegates.pglLineStipple(factor, pattern);
			CallLog("glLineStipple({0}, {1})", factor, pattern);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMaterialf.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Material(int face, int pname, float param)
		{
			Debug.Assert(Delegates.pglMaterialf != null, "pglMaterialf not implemented");
			Delegates.pglMaterialf(face, pname, param);
			CallLog("glMaterialf({0}, {1}, {2})", face, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMaterialf.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Material(MaterialFace face, MaterialParameter pname, float param)
		{
			Debug.Assert(Delegates.pglMaterialf != null, "pglMaterialf not implemented");
			Delegates.pglMaterialf((int)face, (int)pname, param);
			CallLog("glMaterialf({0}, {1}, {2})", face, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMaterialfv.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Material(int face, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglMaterialfv != null, "pglMaterialfv not implemented");
					Delegates.pglMaterialfv(face, pname, p_params);
					CallLog("glMaterialfv({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMaterialfv.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Material(MaterialFace face, MaterialParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglMaterialfv != null, "pglMaterialfv not implemented");
					Delegates.pglMaterialfv((int)face, (int)pname, p_params);
					CallLog("glMaterialfv({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMateriali.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Material(int face, int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglMateriali != null, "pglMateriali not implemented");
			Delegates.pglMateriali(face, pname, param);
			CallLog("glMateriali({0}, {1}, {2})", face, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMateriali.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Material(MaterialFace face, MaterialParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglMateriali != null, "pglMateriali not implemented");
			Delegates.pglMateriali((int)face, (int)pname, param);
			CallLog("glMateriali({0}, {1}, {2})", face, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMaterialiv.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Material(int face, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglMaterialiv != null, "pglMaterialiv not implemented");
					Delegates.pglMaterialiv(face, pname, p_params);
					CallLog("glMaterialiv({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMaterialiv.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Material(MaterialFace face, MaterialParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglMaterialiv != null, "pglMaterialiv not implemented");
					Delegates.pglMaterialiv((int)face, (int)pname, p_params);
					CallLog("glMaterialiv({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the polygon stippling pattern
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <remarks>
		/// Polygon stippling, like line stippling (see Gl.LineStipple), masks out certain fragments produced by rasterization, 
		/// creatinga pattern. Stippling is independent of polygon antialiasing. 
		/// <paramref name="pattern"/> is a pointer to a 32×32 stipple pattern that is stored in memory just like the pixel data 
		/// suppliedto a Gl.DrawPixels call with height and width both equal to 32, a pixel format of <see cref="Gl.COLOR_INDEX"/>, 
		/// anddata type of <see cref="Gl.BITMAP"/>. That is, the stipple pattern is represented as a 32×32 array of 1-bit color 
		/// indicespacked in unsigned bytes. Gl.PixelStore parameters like <see cref="Gl.UNPACK_SWAP_BYTES"/> and <see 
		/// cref="Gl.UNPACK_LSB_FIRST"/>affect the assembling of the bits into a stipple pattern. Pixel transfer operations (shift, 
		/// offset,pixel map) are not applied to the stipple image, however. 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// astipple pattern is specified, <paramref name="pattern"/> is treated as a byte offset into the buffer object's data 
		/// store.
		/// To enable and disable polygon stippling, call Gl.Enable and Gl.Disable with argument <see cref="Gl.POLYGON_STIPPLE"/>. 
		/// Polygonstippling is initially disabled. If it's enabled, a rasterized polygon fragment with window coordinates xw and yw 
		/// issent to the next stage of the GL if and only if the (xw%32)th bit in the (yw%32)th row of the stipple pattern is 1 
		/// (one).When polygon stippling is disabled, it is as if the stipple pattern consists of all 1's. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the data would be unpacked from the buffer object such that the memory reads 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.PolygonStipple"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetPolygonStipple 
		/// - Gl.IsEnabled with argument <see cref="Gl.POLYGON_STIPPLE"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.LineStipple"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		public static void PolygonStipple(byte[] mask)
		{
			unsafe {
				fixed (byte* p_mask = mask)
				{
					Debug.Assert(Delegates.pglPolygonStipple != null, "pglPolygonStipple not implemented");
					Delegates.pglPolygonStipple(p_mask);
					CallLog("glPolygonStipple({0})", mask);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// select flat or smooth shading
		/// </summary>
		/// <param name="mode">
		/// Specifies a symbolic value representing a shading technique. Accepted values are <see cref="Gl.FLAT"/> and <see 
		/// cref="Gl.SMOOTH"/>.The initial value is <see cref="Gl.SMOOTH"/>. 
		/// </param>
		/// <remarks>
		/// GL primitives can have either flat or smooth shading. Smooth shading, the default, causes the computed colors of 
		/// verticesto be interpolated as the primitive is rasterized, typically assigning different colors to each resulting pixel 
		/// fragment.Flat shading selects the computed color of just one vertex and assigns it to all the pixel fragments generated 
		/// byrasterizing a single primitive. In either case, the computed color of a vertex is the result of lighting if lighting 
		/// isenabled, or it is the current color at the time the vertex was specified if lighting is disabled. 
		/// Flat and smooth shading are indistinguishable for points. Starting when Gl.Begin is issued and counting vertices and 
		/// primitivesfrom 1, the GL gives each flat-shaded line segment i the computed color of vertex i+1, its second vertex. 
		/// Countingsimilarly from 1, the GL gives each flat-shaded polygon the computed color of the vertex listed in the following 
		/// table.This is the last vertex to specify the polygon in all cases except single polygons, where the first vertex 
		/// specifiesthe flat-shaded color. 
		///  
		/// Flat and smooth shading are specified by <see cref="Gl.ShadeModel"/> with <paramref name="mode"/> set to <see 
		/// cref="Gl.FLAT"/>and <see cref="Gl.SMOOTH"/>, respectively. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="mode"/> is any value other than <see cref="Gl.FLAT"/> or 
		///   <seecref="Gl.SMOOTH"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ShadeModel"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.SHADE_MODEL"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		public static void ShadeModel(int mode)
		{
			Debug.Assert(Delegates.pglShadeModel != null, "pglShadeModel not implemented");
			Delegates.pglShadeModel(mode);
			CallLog("glShadeModel({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// select flat or smooth shading
		/// </summary>
		/// <param name="mode">
		/// Specifies a symbolic value representing a shading technique. Accepted values are <see cref="Gl.FLAT"/> and <see 
		/// cref="Gl.SMOOTH"/>.The initial value is <see cref="Gl.SMOOTH"/>. 
		/// </param>
		/// <remarks>
		/// GL primitives can have either flat or smooth shading. Smooth shading, the default, causes the computed colors of 
		/// verticesto be interpolated as the primitive is rasterized, typically assigning different colors to each resulting pixel 
		/// fragment.Flat shading selects the computed color of just one vertex and assigns it to all the pixel fragments generated 
		/// byrasterizing a single primitive. In either case, the computed color of a vertex is the result of lighting if lighting 
		/// isenabled, or it is the current color at the time the vertex was specified if lighting is disabled. 
		/// Flat and smooth shading are indistinguishable for points. Starting when Gl.Begin is issued and counting vertices and 
		/// primitivesfrom 1, the GL gives each flat-shaded line segment i the computed color of vertex i+1, its second vertex. 
		/// Countingsimilarly from 1, the GL gives each flat-shaded polygon the computed color of the vertex listed in the following 
		/// table.This is the last vertex to specify the polygon in all cases except single polygons, where the first vertex 
		/// specifiesthe flat-shaded color. 
		///  
		/// Flat and smooth shading are specified by <see cref="Gl.ShadeModel"/> with <paramref name="mode"/> set to <see 
		/// cref="Gl.FLAT"/>and <see cref="Gl.SMOOTH"/>, respectively. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="mode"/> is any value other than <see cref="Gl.FLAT"/> or 
		///   <seecref="Gl.SMOOTH"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.ShadeModel"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.SHADE_MODEL"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		public static void ShadeModel(ShadingModel mode)
		{
			Debug.Assert(Delegates.pglShadeModel != null, "pglShadeModel not implemented");
			Delegates.pglShadeModel((int)mode);
			CallLog("glShadeModel({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be <see cref="Gl.TEXTURE_ENV"/>, <see cref="Gl.TEXTURE_FILTER_CONTROL"/> or <see 
		/// cref="Gl.POINT_SPRITE"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either <see 
		/// cref="Gl.TEXTURE_ENV_MODE"/>,<see cref="Gl.TEXTURE_LOD_BIAS"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>,<see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, <see cref="Gl.SRC2_RGB"/>, <see 
		/// cref="Gl.SRC0_ALPHA"/>,<see cref="Gl.SRC1_ALPHA"/>, <see cref="Gl.SRC2_ALPHA"/>, <see cref="Gl.OPERAND0_RGB"/>, <see 
		/// cref="Gl.OPERAND1_RGB"/>,<see cref="Gl.OPERAND2_RGB"/>, <see cref="Gl.OPERAND0_ALPHA"/>, <see 
		/// cref="Gl.OPERAND1_ALPHA"/>,<see cref="Gl.OPERAND2_ALPHA"/>, <see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, or 
		/// <seecref="Gl.COORD_REPLACE"/>. 
		/// </param>
		/// <param name="param">
		/// Specifies a single symbolic constant, one of <see cref="Gl.ADD"/>, <see cref="Gl.ADD_SIGNED"/>, <see 
		/// cref="Gl.INTERPOLATE"/>,<see cref="Gl.MODULATE"/>, <see cref="Gl.DECAL"/>, <see cref="Gl.BLEND"/>, <see 
		/// cref="Gl.REPLACE"/>,<see cref="Gl.SUBTRACT"/>, <see cref="Gl.COMBINE"/>, <see cref="Gl.TEXTURE"/>, <see 
		/// cref="Gl.CONSTANT"/>,<see cref="Gl.PRIMARY_COLOR"/>, <see cref="Gl.PREVIOUS"/>, <see cref="Gl.SRC_COLOR"/>, <see 
		/// cref="Gl.ONE_MINUS_SRC_COLOR"/>,<see cref="Gl.SRC_ALPHA"/>, <see cref="Gl.ONE_MINUS_SRC_ALPHA"/>, a single boolean value 
		/// forthe point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, 
		/// or1.0, 2.0, or 4.0 when specifying the <see cref="Gl.RGB_SCALE"/> or <see cref="Gl.ALPHA_SCALE"/>. 
		/// </param>
		/// <remarks>
		/// A texture environment specifies how texture values are interpreted when a fragment is textured. When <paramref 
		/// name="target"/>is <see cref="Gl.TEXTURE_FILTER_CONTROL"/>, <paramref name="pname"/> must be <see 
		/// cref="Gl.TEXTURE_LOD_BIAS"/>.When <paramref name="target"/> is <see cref="Gl.TEXTURE_ENV"/>, <paramref name="pname"/> 
		/// canbe <see cref="Gl.TEXTURE_ENV_MODE"/>, <see cref="Gl.TEXTURE_ENV_COLOR"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>,<see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, <see cref="Gl.SRC0_RGB"/>, <see 
		/// cref="Gl.SRC1_RGB"/>,<see cref="Gl.SRC2_RGB"/>, <see cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, or <see 
		/// cref="Gl.SRC2_ALPHA"/>.
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_MODE"/>, then <paramref name="params"/> is (or points to) the 
		/// symbolicname of a texture function. Six texture functions may be specified: <see cref="Gl.ADD"/>, <see 
		/// cref="Gl.MODULATE"/>,<see cref="Gl.DECAL"/>, <see cref="Gl.BLEND"/>, <see cref="Gl.REPLACE"/>, or <see 
		/// cref="Gl.COMBINE"/>.
		/// The following table shows the correspondence of filtered texture values Rt, Gt, Bt, At, Lt, It to texture source 
		/// components.Cs and As are used by the texture functions described below. 
		///  
		/// A texture function acts on the fragment to be textured using the texture image value that applies to the fragment (see 
		/// Gl.TexParameter)and produces an RGBA color for that fragment. The following table shows how the RGBA color is produced 
		/// foreach of the first five texture functions that can be chosen. C is a triple of color values (RGB) and A is the 
		/// associatedalpha value. RGBA values extracted from a texture image are in the range [0,1]. The subscript p refers to the 
		/// colorcomputed from the previous texture stage (or the incoming fragment if processing texture stage 0), the subscript s 
		/// tothe texture source color, the subscript c to the texture environment color, and the subscript v indicates a value 
		/// producedby the texture function. 
		///  
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_MODE"/>, and <paramref name="params"/> is <see 
		/// cref="Gl.COMBINE"/>,the form of the texture function depends on the values of <see cref="Gl.COMBINE_RGB"/> and <see 
		/// cref="Gl.COMBINE_ALPHA"/>.
		/// The following describes how the texture sources, as specified by <see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, 
		/// <seecref="Gl.SRC2_RGB"/>, <see cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, and <see cref="Gl.SRC2_ALPHA"/>, are 
		/// combinedto produce a final texture color. In the following tables, <see cref="Gl.SRC0_c"/> is represented by Arg0, <see 
		/// cref="Gl.SRC1_c"/>is represented by Arg1, and <see cref="Gl.SRC2_c"/> is represented by Arg2. 
		/// <see cref="Gl.COMBINE_RGB"/> accepts any of <see cref="Gl.REPLACE"/>, <see cref="Gl.MODULATE"/>, <see cref="Gl.ADD"/>, 
		/// <seecref="Gl.ADD_SIGNED"/>, <see cref="Gl.INTERPOLATE"/>, <see cref="Gl.SUBTRACT"/>, <see cref="Gl.DOT3_RGB"/>, or <see 
		/// cref="Gl.DOT3_RGBA"/>.
		///  
		/// The scalar results for <see cref="Gl.DOT3_RGB"/> and <see cref="Gl.DOT3_RGBA"/> are placed into each of the 3 (RGB) or 4 
		/// (RGBA)components on output. 
		/// Likewise, <see cref="Gl.COMBINE_ALPHA"/> accepts any of <see cref="Gl.REPLACE"/>, <see cref="Gl.MODULATE"/>, <see 
		/// cref="Gl.ADD"/>,<see cref="Gl.ADD_SIGNED"/>, <see cref="Gl.INTERPOLATE"/>, or <see cref="Gl.SUBTRACT"/>. The following 
		/// tabledescribes how alpha values are combined: 
		///  
		/// In the following tables, the value Cs represents the color sampled from the currently bound texture, Cc represents the 
		/// constanttexture-environment color, Cf represents the primary color of the incoming fragment, and Cp represents the color 
		/// computedfrom the previous texture stage or Cf if processing texture stage 0. Likewise, As, Ac, Af, and Ap represent the 
		/// respectivealpha values. 
		/// The following table describes the values assigned to Arg0, Arg1, and Arg2 based upon the RGB sources and operands: 
		///  
		/// For <see cref="Gl.TEXTUREn"/> sources, Cs and As represent the color and alpha, respectively, produced from texture 
		/// stagen. 
		/// The follow table describes the values assigned to Arg0, Arg1, and Arg2 based upon the alpha sources and operands: 
		///  
		/// The RGB and alpha results of the texture function are multipled by the values of <see cref="Gl.RGB_SCALE"/> and <see 
		/// cref="Gl.ALPHA_SCALE"/>,respectively, and clamped to the range 01. 
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_COLOR"/>, <paramref name="params"/> is a pointer to an array 
		/// thatholds an RGBA color consisting of four values. Integer color components are interpreted linearly such that the most 
		/// positiveinteger maps to 1.0, and the most negative integer maps to -1.0. The values are clamped to the range [0,1] when 
		/// theyare specified. Cc takes these four values. 
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_LOD_BIAS"/>, the value specified is added to the texture 
		/// level-of-detailparameter, that selects which mipmap, or mipmaps depending upon the selected <see 
		/// cref="Gl.TEXTURE_MIN_FILTER"/>,will be sampled. 
		/// <see cref="Gl.TEXTURE_ENV_MODE"/> defaults to <see cref="Gl.MODULATE"/> and <see cref="Gl.TEXTURE_ENV_COLOR"/> defaults 
		/// to(0, 0, 0, 0). 
		/// If <paramref name="target"/> is <see cref="Gl.POINT_SPRITE"/> and <paramref name="pname"/> is <see 
		/// cref="Gl.COORD_REPLACE"/>,the boolean value specified is used to either enable or disable point sprite texture 
		/// coordinatereplacement. The default value is <see cref="Gl.FALSE"/>. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="target"/> or <paramref name="pname"/> is not one of the 
		///   accepteddefined values, or when <paramref name="params"/> should have a defined constant value (based on the value of 
		///   <paramrefname="pname"/>) and does not. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if the <paramref name="params"/> value for <see cref="Gl.RGB_SCALE"/> or 
		///   <seecref="Gl.ALPHA_SCALE"/> are not one of 1.0, 2.0, or 4.0. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexEnv"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexEnv 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexEnv(int target, int pname, float param)
		{
			Debug.Assert(Delegates.pglTexEnvf != null, "pglTexEnvf not implemented");
			Delegates.pglTexEnvf(target, pname, param);
			CallLog("glTexEnvf({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be <see cref="Gl.TEXTURE_ENV"/>, <see cref="Gl.TEXTURE_FILTER_CONTROL"/> or <see 
		/// cref="Gl.POINT_SPRITE"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either <see 
		/// cref="Gl.TEXTURE_ENV_MODE"/>,<see cref="Gl.TEXTURE_LOD_BIAS"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>,<see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, <see cref="Gl.SRC2_RGB"/>, <see 
		/// cref="Gl.SRC0_ALPHA"/>,<see cref="Gl.SRC1_ALPHA"/>, <see cref="Gl.SRC2_ALPHA"/>, <see cref="Gl.OPERAND0_RGB"/>, <see 
		/// cref="Gl.OPERAND1_RGB"/>,<see cref="Gl.OPERAND2_RGB"/>, <see cref="Gl.OPERAND0_ALPHA"/>, <see 
		/// cref="Gl.OPERAND1_ALPHA"/>,<see cref="Gl.OPERAND2_ALPHA"/>, <see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, or 
		/// <seecref="Gl.COORD_REPLACE"/>. 
		/// </param>
		/// <param name="param">
		/// Specifies a single symbolic constant, one of <see cref="Gl.ADD"/>, <see cref="Gl.ADD_SIGNED"/>, <see 
		/// cref="Gl.INTERPOLATE"/>,<see cref="Gl.MODULATE"/>, <see cref="Gl.DECAL"/>, <see cref="Gl.BLEND"/>, <see 
		/// cref="Gl.REPLACE"/>,<see cref="Gl.SUBTRACT"/>, <see cref="Gl.COMBINE"/>, <see cref="Gl.TEXTURE"/>, <see 
		/// cref="Gl.CONSTANT"/>,<see cref="Gl.PRIMARY_COLOR"/>, <see cref="Gl.PREVIOUS"/>, <see cref="Gl.SRC_COLOR"/>, <see 
		/// cref="Gl.ONE_MINUS_SRC_COLOR"/>,<see cref="Gl.SRC_ALPHA"/>, <see cref="Gl.ONE_MINUS_SRC_ALPHA"/>, a single boolean value 
		/// forthe point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, 
		/// or1.0, 2.0, or 4.0 when specifying the <see cref="Gl.RGB_SCALE"/> or <see cref="Gl.ALPHA_SCALE"/>. 
		/// </param>
		/// <remarks>
		/// A texture environment specifies how texture values are interpreted when a fragment is textured. When <paramref 
		/// name="target"/>is <see cref="Gl.TEXTURE_FILTER_CONTROL"/>, <paramref name="pname"/> must be <see 
		/// cref="Gl.TEXTURE_LOD_BIAS"/>.When <paramref name="target"/> is <see cref="Gl.TEXTURE_ENV"/>, <paramref name="pname"/> 
		/// canbe <see cref="Gl.TEXTURE_ENV_MODE"/>, <see cref="Gl.TEXTURE_ENV_COLOR"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>,<see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, <see cref="Gl.SRC0_RGB"/>, <see 
		/// cref="Gl.SRC1_RGB"/>,<see cref="Gl.SRC2_RGB"/>, <see cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, or <see 
		/// cref="Gl.SRC2_ALPHA"/>.
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_MODE"/>, then <paramref name="params"/> is (or points to) the 
		/// symbolicname of a texture function. Six texture functions may be specified: <see cref="Gl.ADD"/>, <see 
		/// cref="Gl.MODULATE"/>,<see cref="Gl.DECAL"/>, <see cref="Gl.BLEND"/>, <see cref="Gl.REPLACE"/>, or <see 
		/// cref="Gl.COMBINE"/>.
		/// The following table shows the correspondence of filtered texture values Rt, Gt, Bt, At, Lt, It to texture source 
		/// components.Cs and As are used by the texture functions described below. 
		///  
		/// A texture function acts on the fragment to be textured using the texture image value that applies to the fragment (see 
		/// Gl.TexParameter)and produces an RGBA color for that fragment. The following table shows how the RGBA color is produced 
		/// foreach of the first five texture functions that can be chosen. C is a triple of color values (RGB) and A is the 
		/// associatedalpha value. RGBA values extracted from a texture image are in the range [0,1]. The subscript p refers to the 
		/// colorcomputed from the previous texture stage (or the incoming fragment if processing texture stage 0), the subscript s 
		/// tothe texture source color, the subscript c to the texture environment color, and the subscript v indicates a value 
		/// producedby the texture function. 
		///  
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_MODE"/>, and <paramref name="params"/> is <see 
		/// cref="Gl.COMBINE"/>,the form of the texture function depends on the values of <see cref="Gl.COMBINE_RGB"/> and <see 
		/// cref="Gl.COMBINE_ALPHA"/>.
		/// The following describes how the texture sources, as specified by <see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, 
		/// <seecref="Gl.SRC2_RGB"/>, <see cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, and <see cref="Gl.SRC2_ALPHA"/>, are 
		/// combinedto produce a final texture color. In the following tables, <see cref="Gl.SRC0_c"/> is represented by Arg0, <see 
		/// cref="Gl.SRC1_c"/>is represented by Arg1, and <see cref="Gl.SRC2_c"/> is represented by Arg2. 
		/// <see cref="Gl.COMBINE_RGB"/> accepts any of <see cref="Gl.REPLACE"/>, <see cref="Gl.MODULATE"/>, <see cref="Gl.ADD"/>, 
		/// <seecref="Gl.ADD_SIGNED"/>, <see cref="Gl.INTERPOLATE"/>, <see cref="Gl.SUBTRACT"/>, <see cref="Gl.DOT3_RGB"/>, or <see 
		/// cref="Gl.DOT3_RGBA"/>.
		///  
		/// The scalar results for <see cref="Gl.DOT3_RGB"/> and <see cref="Gl.DOT3_RGBA"/> are placed into each of the 3 (RGB) or 4 
		/// (RGBA)components on output. 
		/// Likewise, <see cref="Gl.COMBINE_ALPHA"/> accepts any of <see cref="Gl.REPLACE"/>, <see cref="Gl.MODULATE"/>, <see 
		/// cref="Gl.ADD"/>,<see cref="Gl.ADD_SIGNED"/>, <see cref="Gl.INTERPOLATE"/>, or <see cref="Gl.SUBTRACT"/>. The following 
		/// tabledescribes how alpha values are combined: 
		///  
		/// In the following tables, the value Cs represents the color sampled from the currently bound texture, Cc represents the 
		/// constanttexture-environment color, Cf represents the primary color of the incoming fragment, and Cp represents the color 
		/// computedfrom the previous texture stage or Cf if processing texture stage 0. Likewise, As, Ac, Af, and Ap represent the 
		/// respectivealpha values. 
		/// The following table describes the values assigned to Arg0, Arg1, and Arg2 based upon the RGB sources and operands: 
		///  
		/// For <see cref="Gl.TEXTUREn"/> sources, Cs and As represent the color and alpha, respectively, produced from texture 
		/// stagen. 
		/// The follow table describes the values assigned to Arg0, Arg1, and Arg2 based upon the alpha sources and operands: 
		///  
		/// The RGB and alpha results of the texture function are multipled by the values of <see cref="Gl.RGB_SCALE"/> and <see 
		/// cref="Gl.ALPHA_SCALE"/>,respectively, and clamped to the range 01. 
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_COLOR"/>, <paramref name="params"/> is a pointer to an array 
		/// thatholds an RGBA color consisting of four values. Integer color components are interpreted linearly such that the most 
		/// positiveinteger maps to 1.0, and the most negative integer maps to -1.0. The values are clamped to the range [0,1] when 
		/// theyare specified. Cc takes these four values. 
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_LOD_BIAS"/>, the value specified is added to the texture 
		/// level-of-detailparameter, that selects which mipmap, or mipmaps depending upon the selected <see 
		/// cref="Gl.TEXTURE_MIN_FILTER"/>,will be sampled. 
		/// <see cref="Gl.TEXTURE_ENV_MODE"/> defaults to <see cref="Gl.MODULATE"/> and <see cref="Gl.TEXTURE_ENV_COLOR"/> defaults 
		/// to(0, 0, 0, 0). 
		/// If <paramref name="target"/> is <see cref="Gl.POINT_SPRITE"/> and <paramref name="pname"/> is <see 
		/// cref="Gl.COORD_REPLACE"/>,the boolean value specified is used to either enable or disable point sprite texture 
		/// coordinatereplacement. The default value is <see cref="Gl.FALSE"/>. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="target"/> or <paramref name="pname"/> is not one of the 
		///   accepteddefined values, or when <paramref name="params"/> should have a defined constant value (based on the value of 
		///   <paramrefname="pname"/>) and does not. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if the <paramref name="params"/> value for <see cref="Gl.RGB_SCALE"/> or 
		///   <seecref="Gl.ALPHA_SCALE"/> are not one of 1.0, 2.0, or 4.0. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexEnv"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexEnv 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, float param)
		{
			Debug.Assert(Delegates.pglTexEnvf != null, "pglTexEnvf not implemented");
			Delegates.pglTexEnvf((int)target, (int)pname, param);
			CallLog("glTexEnvf({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be <see cref="Gl.TEXTURE_ENV"/>, <see cref="Gl.TEXTURE_FILTER_CONTROL"/> or <see 
		/// cref="Gl.POINT_SPRITE"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either <see 
		/// cref="Gl.TEXTURE_ENV_MODE"/>,<see cref="Gl.TEXTURE_LOD_BIAS"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>,<see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, <see cref="Gl.SRC2_RGB"/>, <see 
		/// cref="Gl.SRC0_ALPHA"/>,<see cref="Gl.SRC1_ALPHA"/>, <see cref="Gl.SRC2_ALPHA"/>, <see cref="Gl.OPERAND0_RGB"/>, <see 
		/// cref="Gl.OPERAND1_RGB"/>,<see cref="Gl.OPERAND2_RGB"/>, <see cref="Gl.OPERAND0_ALPHA"/>, <see 
		/// cref="Gl.OPERAND1_ALPHA"/>,<see cref="Gl.OPERAND2_ALPHA"/>, <see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, or 
		/// <seecref="Gl.COORD_REPLACE"/>. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// A texture environment specifies how texture values are interpreted when a fragment is textured. When <paramref 
		/// name="target"/>is <see cref="Gl.TEXTURE_FILTER_CONTROL"/>, <paramref name="pname"/> must be <see 
		/// cref="Gl.TEXTURE_LOD_BIAS"/>.When <paramref name="target"/> is <see cref="Gl.TEXTURE_ENV"/>, <paramref name="pname"/> 
		/// canbe <see cref="Gl.TEXTURE_ENV_MODE"/>, <see cref="Gl.TEXTURE_ENV_COLOR"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>,<see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, <see cref="Gl.SRC0_RGB"/>, <see 
		/// cref="Gl.SRC1_RGB"/>,<see cref="Gl.SRC2_RGB"/>, <see cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, or <see 
		/// cref="Gl.SRC2_ALPHA"/>.
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_MODE"/>, then <paramref name="params"/> is (or points to) the 
		/// symbolicname of a texture function. Six texture functions may be specified: <see cref="Gl.ADD"/>, <see 
		/// cref="Gl.MODULATE"/>,<see cref="Gl.DECAL"/>, <see cref="Gl.BLEND"/>, <see cref="Gl.REPLACE"/>, or <see 
		/// cref="Gl.COMBINE"/>.
		/// The following table shows the correspondence of filtered texture values Rt, Gt, Bt, At, Lt, It to texture source 
		/// components.Cs and As are used by the texture functions described below. 
		///  
		/// A texture function acts on the fragment to be textured using the texture image value that applies to the fragment (see 
		/// Gl.TexParameter)and produces an RGBA color for that fragment. The following table shows how the RGBA color is produced 
		/// foreach of the first five texture functions that can be chosen. C is a triple of color values (RGB) and A is the 
		/// associatedalpha value. RGBA values extracted from a texture image are in the range [0,1]. The subscript p refers to the 
		/// colorcomputed from the previous texture stage (or the incoming fragment if processing texture stage 0), the subscript s 
		/// tothe texture source color, the subscript c to the texture environment color, and the subscript v indicates a value 
		/// producedby the texture function. 
		///  
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_MODE"/>, and <paramref name="params"/> is <see 
		/// cref="Gl.COMBINE"/>,the form of the texture function depends on the values of <see cref="Gl.COMBINE_RGB"/> and <see 
		/// cref="Gl.COMBINE_ALPHA"/>.
		/// The following describes how the texture sources, as specified by <see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, 
		/// <seecref="Gl.SRC2_RGB"/>, <see cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, and <see cref="Gl.SRC2_ALPHA"/>, are 
		/// combinedto produce a final texture color. In the following tables, <see cref="Gl.SRC0_c"/> is represented by Arg0, <see 
		/// cref="Gl.SRC1_c"/>is represented by Arg1, and <see cref="Gl.SRC2_c"/> is represented by Arg2. 
		/// <see cref="Gl.COMBINE_RGB"/> accepts any of <see cref="Gl.REPLACE"/>, <see cref="Gl.MODULATE"/>, <see cref="Gl.ADD"/>, 
		/// <seecref="Gl.ADD_SIGNED"/>, <see cref="Gl.INTERPOLATE"/>, <see cref="Gl.SUBTRACT"/>, <see cref="Gl.DOT3_RGB"/>, or <see 
		/// cref="Gl.DOT3_RGBA"/>.
		///  
		/// The scalar results for <see cref="Gl.DOT3_RGB"/> and <see cref="Gl.DOT3_RGBA"/> are placed into each of the 3 (RGB) or 4 
		/// (RGBA)components on output. 
		/// Likewise, <see cref="Gl.COMBINE_ALPHA"/> accepts any of <see cref="Gl.REPLACE"/>, <see cref="Gl.MODULATE"/>, <see 
		/// cref="Gl.ADD"/>,<see cref="Gl.ADD_SIGNED"/>, <see cref="Gl.INTERPOLATE"/>, or <see cref="Gl.SUBTRACT"/>. The following 
		/// tabledescribes how alpha values are combined: 
		///  
		/// In the following tables, the value Cs represents the color sampled from the currently bound texture, Cc represents the 
		/// constanttexture-environment color, Cf represents the primary color of the incoming fragment, and Cp represents the color 
		/// computedfrom the previous texture stage or Cf if processing texture stage 0. Likewise, As, Ac, Af, and Ap represent the 
		/// respectivealpha values. 
		/// The following table describes the values assigned to Arg0, Arg1, and Arg2 based upon the RGB sources and operands: 
		///  
		/// For <see cref="Gl.TEXTUREn"/> sources, Cs and As represent the color and alpha, respectively, produced from texture 
		/// stagen. 
		/// The follow table describes the values assigned to Arg0, Arg1, and Arg2 based upon the alpha sources and operands: 
		///  
		/// The RGB and alpha results of the texture function are multipled by the values of <see cref="Gl.RGB_SCALE"/> and <see 
		/// cref="Gl.ALPHA_SCALE"/>,respectively, and clamped to the range 01. 
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_COLOR"/>, <paramref name="params"/> is a pointer to an array 
		/// thatholds an RGBA color consisting of four values. Integer color components are interpreted linearly such that the most 
		/// positiveinteger maps to 1.0, and the most negative integer maps to -1.0. The values are clamped to the range [0,1] when 
		/// theyare specified. Cc takes these four values. 
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_LOD_BIAS"/>, the value specified is added to the texture 
		/// level-of-detailparameter, that selects which mipmap, or mipmaps depending upon the selected <see 
		/// cref="Gl.TEXTURE_MIN_FILTER"/>,will be sampled. 
		/// <see cref="Gl.TEXTURE_ENV_MODE"/> defaults to <see cref="Gl.MODULATE"/> and <see cref="Gl.TEXTURE_ENV_COLOR"/> defaults 
		/// to(0, 0, 0, 0). 
		/// If <paramref name="target"/> is <see cref="Gl.POINT_SPRITE"/> and <paramref name="pname"/> is <see 
		/// cref="Gl.COORD_REPLACE"/>,the boolean value specified is used to either enable or disable point sprite texture 
		/// coordinatereplacement. The default value is <see cref="Gl.FALSE"/>. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="target"/> or <paramref name="pname"/> is not one of the 
		///   accepteddefined values, or when <paramref name="params"/> should have a defined constant value (based on the value of 
		///   <paramrefname="pname"/>) and does not. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if the <paramref name="params"/> value for <see cref="Gl.RGB_SCALE"/> or 
		///   <seecref="Gl.ALPHA_SCALE"/> are not one of 1.0, 2.0, or 4.0. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexEnv"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexEnv 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexEnv(int target, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexEnvfv != null, "pglTexEnvfv not implemented");
					Delegates.pglTexEnvfv(target, pname, p_params);
					CallLog("glTexEnvfv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be <see cref="Gl.TEXTURE_ENV"/>, <see cref="Gl.TEXTURE_FILTER_CONTROL"/> or <see 
		/// cref="Gl.POINT_SPRITE"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either <see 
		/// cref="Gl.TEXTURE_ENV_MODE"/>,<see cref="Gl.TEXTURE_LOD_BIAS"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>,<see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, <see cref="Gl.SRC2_RGB"/>, <see 
		/// cref="Gl.SRC0_ALPHA"/>,<see cref="Gl.SRC1_ALPHA"/>, <see cref="Gl.SRC2_ALPHA"/>, <see cref="Gl.OPERAND0_RGB"/>, <see 
		/// cref="Gl.OPERAND1_RGB"/>,<see cref="Gl.OPERAND2_RGB"/>, <see cref="Gl.OPERAND0_ALPHA"/>, <see 
		/// cref="Gl.OPERAND1_ALPHA"/>,<see cref="Gl.OPERAND2_ALPHA"/>, <see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, or 
		/// <seecref="Gl.COORD_REPLACE"/>. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// A texture environment specifies how texture values are interpreted when a fragment is textured. When <paramref 
		/// name="target"/>is <see cref="Gl.TEXTURE_FILTER_CONTROL"/>, <paramref name="pname"/> must be <see 
		/// cref="Gl.TEXTURE_LOD_BIAS"/>.When <paramref name="target"/> is <see cref="Gl.TEXTURE_ENV"/>, <paramref name="pname"/> 
		/// canbe <see cref="Gl.TEXTURE_ENV_MODE"/>, <see cref="Gl.TEXTURE_ENV_COLOR"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>,<see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, <see cref="Gl.SRC0_RGB"/>, <see 
		/// cref="Gl.SRC1_RGB"/>,<see cref="Gl.SRC2_RGB"/>, <see cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, or <see 
		/// cref="Gl.SRC2_ALPHA"/>.
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_MODE"/>, then <paramref name="params"/> is (or points to) the 
		/// symbolicname of a texture function. Six texture functions may be specified: <see cref="Gl.ADD"/>, <see 
		/// cref="Gl.MODULATE"/>,<see cref="Gl.DECAL"/>, <see cref="Gl.BLEND"/>, <see cref="Gl.REPLACE"/>, or <see 
		/// cref="Gl.COMBINE"/>.
		/// The following table shows the correspondence of filtered texture values Rt, Gt, Bt, At, Lt, It to texture source 
		/// components.Cs and As are used by the texture functions described below. 
		///  
		/// A texture function acts on the fragment to be textured using the texture image value that applies to the fragment (see 
		/// Gl.TexParameter)and produces an RGBA color for that fragment. The following table shows how the RGBA color is produced 
		/// foreach of the first five texture functions that can be chosen. C is a triple of color values (RGB) and A is the 
		/// associatedalpha value. RGBA values extracted from a texture image are in the range [0,1]. The subscript p refers to the 
		/// colorcomputed from the previous texture stage (or the incoming fragment if processing texture stage 0), the subscript s 
		/// tothe texture source color, the subscript c to the texture environment color, and the subscript v indicates a value 
		/// producedby the texture function. 
		///  
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_MODE"/>, and <paramref name="params"/> is <see 
		/// cref="Gl.COMBINE"/>,the form of the texture function depends on the values of <see cref="Gl.COMBINE_RGB"/> and <see 
		/// cref="Gl.COMBINE_ALPHA"/>.
		/// The following describes how the texture sources, as specified by <see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, 
		/// <seecref="Gl.SRC2_RGB"/>, <see cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, and <see cref="Gl.SRC2_ALPHA"/>, are 
		/// combinedto produce a final texture color. In the following tables, <see cref="Gl.SRC0_c"/> is represented by Arg0, <see 
		/// cref="Gl.SRC1_c"/>is represented by Arg1, and <see cref="Gl.SRC2_c"/> is represented by Arg2. 
		/// <see cref="Gl.COMBINE_RGB"/> accepts any of <see cref="Gl.REPLACE"/>, <see cref="Gl.MODULATE"/>, <see cref="Gl.ADD"/>, 
		/// <seecref="Gl.ADD_SIGNED"/>, <see cref="Gl.INTERPOLATE"/>, <see cref="Gl.SUBTRACT"/>, <see cref="Gl.DOT3_RGB"/>, or <see 
		/// cref="Gl.DOT3_RGBA"/>.
		///  
		/// The scalar results for <see cref="Gl.DOT3_RGB"/> and <see cref="Gl.DOT3_RGBA"/> are placed into each of the 3 (RGB) or 4 
		/// (RGBA)components on output. 
		/// Likewise, <see cref="Gl.COMBINE_ALPHA"/> accepts any of <see cref="Gl.REPLACE"/>, <see cref="Gl.MODULATE"/>, <see 
		/// cref="Gl.ADD"/>,<see cref="Gl.ADD_SIGNED"/>, <see cref="Gl.INTERPOLATE"/>, or <see cref="Gl.SUBTRACT"/>. The following 
		/// tabledescribes how alpha values are combined: 
		///  
		/// In the following tables, the value Cs represents the color sampled from the currently bound texture, Cc represents the 
		/// constanttexture-environment color, Cf represents the primary color of the incoming fragment, and Cp represents the color 
		/// computedfrom the previous texture stage or Cf if processing texture stage 0. Likewise, As, Ac, Af, and Ap represent the 
		/// respectivealpha values. 
		/// The following table describes the values assigned to Arg0, Arg1, and Arg2 based upon the RGB sources and operands: 
		///  
		/// For <see cref="Gl.TEXTUREn"/> sources, Cs and As represent the color and alpha, respectively, produced from texture 
		/// stagen. 
		/// The follow table describes the values assigned to Arg0, Arg1, and Arg2 based upon the alpha sources and operands: 
		///  
		/// The RGB and alpha results of the texture function are multipled by the values of <see cref="Gl.RGB_SCALE"/> and <see 
		/// cref="Gl.ALPHA_SCALE"/>,respectively, and clamped to the range 01. 
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_COLOR"/>, <paramref name="params"/> is a pointer to an array 
		/// thatholds an RGBA color consisting of four values. Integer color components are interpreted linearly such that the most 
		/// positiveinteger maps to 1.0, and the most negative integer maps to -1.0. The values are clamped to the range [0,1] when 
		/// theyare specified. Cc takes these four values. 
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_LOD_BIAS"/>, the value specified is added to the texture 
		/// level-of-detailparameter, that selects which mipmap, or mipmaps depending upon the selected <see 
		/// cref="Gl.TEXTURE_MIN_FILTER"/>,will be sampled. 
		/// <see cref="Gl.TEXTURE_ENV_MODE"/> defaults to <see cref="Gl.MODULATE"/> and <see cref="Gl.TEXTURE_ENV_COLOR"/> defaults 
		/// to(0, 0, 0, 0). 
		/// If <paramref name="target"/> is <see cref="Gl.POINT_SPRITE"/> and <paramref name="pname"/> is <see 
		/// cref="Gl.COORD_REPLACE"/>,the boolean value specified is used to either enable or disable point sprite texture 
		/// coordinatereplacement. The default value is <see cref="Gl.FALSE"/>. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="target"/> or <paramref name="pname"/> is not one of the 
		///   accepteddefined values, or when <paramref name="params"/> should have a defined constant value (based on the value of 
		///   <paramrefname="pname"/>) and does not. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if the <paramref name="params"/> value for <see cref="Gl.RGB_SCALE"/> or 
		///   <seecref="Gl.ALPHA_SCALE"/> are not one of 1.0, 2.0, or 4.0. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexEnv"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexEnv 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexEnvfv != null, "pglTexEnvfv not implemented");
					Delegates.pglTexEnvfv((int)target, (int)pname, p_params);
					CallLog("glTexEnvfv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be <see cref="Gl.TEXTURE_ENV"/>, <see cref="Gl.TEXTURE_FILTER_CONTROL"/> or <see 
		/// cref="Gl.POINT_SPRITE"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either <see 
		/// cref="Gl.TEXTURE_ENV_MODE"/>,<see cref="Gl.TEXTURE_LOD_BIAS"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>,<see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, <see cref="Gl.SRC2_RGB"/>, <see 
		/// cref="Gl.SRC0_ALPHA"/>,<see cref="Gl.SRC1_ALPHA"/>, <see cref="Gl.SRC2_ALPHA"/>, <see cref="Gl.OPERAND0_RGB"/>, <see 
		/// cref="Gl.OPERAND1_RGB"/>,<see cref="Gl.OPERAND2_RGB"/>, <see cref="Gl.OPERAND0_ALPHA"/>, <see 
		/// cref="Gl.OPERAND1_ALPHA"/>,<see cref="Gl.OPERAND2_ALPHA"/>, <see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, or 
		/// <seecref="Gl.COORD_REPLACE"/>. 
		/// </param>
		/// <param name="param">
		/// Specifies a single symbolic constant, one of <see cref="Gl.ADD"/>, <see cref="Gl.ADD_SIGNED"/>, <see 
		/// cref="Gl.INTERPOLATE"/>,<see cref="Gl.MODULATE"/>, <see cref="Gl.DECAL"/>, <see cref="Gl.BLEND"/>, <see 
		/// cref="Gl.REPLACE"/>,<see cref="Gl.SUBTRACT"/>, <see cref="Gl.COMBINE"/>, <see cref="Gl.TEXTURE"/>, <see 
		/// cref="Gl.CONSTANT"/>,<see cref="Gl.PRIMARY_COLOR"/>, <see cref="Gl.PREVIOUS"/>, <see cref="Gl.SRC_COLOR"/>, <see 
		/// cref="Gl.ONE_MINUS_SRC_COLOR"/>,<see cref="Gl.SRC_ALPHA"/>, <see cref="Gl.ONE_MINUS_SRC_ALPHA"/>, a single boolean value 
		/// forthe point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, 
		/// or1.0, 2.0, or 4.0 when specifying the <see cref="Gl.RGB_SCALE"/> or <see cref="Gl.ALPHA_SCALE"/>. 
		/// </param>
		/// <remarks>
		/// A texture environment specifies how texture values are interpreted when a fragment is textured. When <paramref 
		/// name="target"/>is <see cref="Gl.TEXTURE_FILTER_CONTROL"/>, <paramref name="pname"/> must be <see 
		/// cref="Gl.TEXTURE_LOD_BIAS"/>.When <paramref name="target"/> is <see cref="Gl.TEXTURE_ENV"/>, <paramref name="pname"/> 
		/// canbe <see cref="Gl.TEXTURE_ENV_MODE"/>, <see cref="Gl.TEXTURE_ENV_COLOR"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>,<see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, <see cref="Gl.SRC0_RGB"/>, <see 
		/// cref="Gl.SRC1_RGB"/>,<see cref="Gl.SRC2_RGB"/>, <see cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, or <see 
		/// cref="Gl.SRC2_ALPHA"/>.
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_MODE"/>, then <paramref name="params"/> is (or points to) the 
		/// symbolicname of a texture function. Six texture functions may be specified: <see cref="Gl.ADD"/>, <see 
		/// cref="Gl.MODULATE"/>,<see cref="Gl.DECAL"/>, <see cref="Gl.BLEND"/>, <see cref="Gl.REPLACE"/>, or <see 
		/// cref="Gl.COMBINE"/>.
		/// The following table shows the correspondence of filtered texture values Rt, Gt, Bt, At, Lt, It to texture source 
		/// components.Cs and As are used by the texture functions described below. 
		///  
		/// A texture function acts on the fragment to be textured using the texture image value that applies to the fragment (see 
		/// Gl.TexParameter)and produces an RGBA color for that fragment. The following table shows how the RGBA color is produced 
		/// foreach of the first five texture functions that can be chosen. C is a triple of color values (RGB) and A is the 
		/// associatedalpha value. RGBA values extracted from a texture image are in the range [0,1]. The subscript p refers to the 
		/// colorcomputed from the previous texture stage (or the incoming fragment if processing texture stage 0), the subscript s 
		/// tothe texture source color, the subscript c to the texture environment color, and the subscript v indicates a value 
		/// producedby the texture function. 
		///  
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_MODE"/>, and <paramref name="params"/> is <see 
		/// cref="Gl.COMBINE"/>,the form of the texture function depends on the values of <see cref="Gl.COMBINE_RGB"/> and <see 
		/// cref="Gl.COMBINE_ALPHA"/>.
		/// The following describes how the texture sources, as specified by <see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, 
		/// <seecref="Gl.SRC2_RGB"/>, <see cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, and <see cref="Gl.SRC2_ALPHA"/>, are 
		/// combinedto produce a final texture color. In the following tables, <see cref="Gl.SRC0_c"/> is represented by Arg0, <see 
		/// cref="Gl.SRC1_c"/>is represented by Arg1, and <see cref="Gl.SRC2_c"/> is represented by Arg2. 
		/// <see cref="Gl.COMBINE_RGB"/> accepts any of <see cref="Gl.REPLACE"/>, <see cref="Gl.MODULATE"/>, <see cref="Gl.ADD"/>, 
		/// <seecref="Gl.ADD_SIGNED"/>, <see cref="Gl.INTERPOLATE"/>, <see cref="Gl.SUBTRACT"/>, <see cref="Gl.DOT3_RGB"/>, or <see 
		/// cref="Gl.DOT3_RGBA"/>.
		///  
		/// The scalar results for <see cref="Gl.DOT3_RGB"/> and <see cref="Gl.DOT3_RGBA"/> are placed into each of the 3 (RGB) or 4 
		/// (RGBA)components on output. 
		/// Likewise, <see cref="Gl.COMBINE_ALPHA"/> accepts any of <see cref="Gl.REPLACE"/>, <see cref="Gl.MODULATE"/>, <see 
		/// cref="Gl.ADD"/>,<see cref="Gl.ADD_SIGNED"/>, <see cref="Gl.INTERPOLATE"/>, or <see cref="Gl.SUBTRACT"/>. The following 
		/// tabledescribes how alpha values are combined: 
		///  
		/// In the following tables, the value Cs represents the color sampled from the currently bound texture, Cc represents the 
		/// constanttexture-environment color, Cf represents the primary color of the incoming fragment, and Cp represents the color 
		/// computedfrom the previous texture stage or Cf if processing texture stage 0. Likewise, As, Ac, Af, and Ap represent the 
		/// respectivealpha values. 
		/// The following table describes the values assigned to Arg0, Arg1, and Arg2 based upon the RGB sources and operands: 
		///  
		/// For <see cref="Gl.TEXTUREn"/> sources, Cs and As represent the color and alpha, respectively, produced from texture 
		/// stagen. 
		/// The follow table describes the values assigned to Arg0, Arg1, and Arg2 based upon the alpha sources and operands: 
		///  
		/// The RGB and alpha results of the texture function are multipled by the values of <see cref="Gl.RGB_SCALE"/> and <see 
		/// cref="Gl.ALPHA_SCALE"/>,respectively, and clamped to the range 01. 
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_COLOR"/>, <paramref name="params"/> is a pointer to an array 
		/// thatholds an RGBA color consisting of four values. Integer color components are interpreted linearly such that the most 
		/// positiveinteger maps to 1.0, and the most negative integer maps to -1.0. The values are clamped to the range [0,1] when 
		/// theyare specified. Cc takes these four values. 
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_LOD_BIAS"/>, the value specified is added to the texture 
		/// level-of-detailparameter, that selects which mipmap, or mipmaps depending upon the selected <see 
		/// cref="Gl.TEXTURE_MIN_FILTER"/>,will be sampled. 
		/// <see cref="Gl.TEXTURE_ENV_MODE"/> defaults to <see cref="Gl.MODULATE"/> and <see cref="Gl.TEXTURE_ENV_COLOR"/> defaults 
		/// to(0, 0, 0, 0). 
		/// If <paramref name="target"/> is <see cref="Gl.POINT_SPRITE"/> and <paramref name="pname"/> is <see 
		/// cref="Gl.COORD_REPLACE"/>,the boolean value specified is used to either enable or disable point sprite texture 
		/// coordinatereplacement. The default value is <see cref="Gl.FALSE"/>. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="target"/> or <paramref name="pname"/> is not one of the 
		///   accepteddefined values, or when <paramref name="params"/> should have a defined constant value (based on the value of 
		///   <paramrefname="pname"/>) and does not. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if the <paramref name="params"/> value for <see cref="Gl.RGB_SCALE"/> or 
		///   <seecref="Gl.ALPHA_SCALE"/> are not one of 1.0, 2.0, or 4.0. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexEnv"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexEnv 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexEnv(int target, int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexEnvi != null, "pglTexEnvi not implemented");
			Delegates.pglTexEnvi(target, pname, param);
			CallLog("glTexEnvi({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be <see cref="Gl.TEXTURE_ENV"/>, <see cref="Gl.TEXTURE_FILTER_CONTROL"/> or <see 
		/// cref="Gl.POINT_SPRITE"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either <see 
		/// cref="Gl.TEXTURE_ENV_MODE"/>,<see cref="Gl.TEXTURE_LOD_BIAS"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>,<see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, <see cref="Gl.SRC2_RGB"/>, <see 
		/// cref="Gl.SRC0_ALPHA"/>,<see cref="Gl.SRC1_ALPHA"/>, <see cref="Gl.SRC2_ALPHA"/>, <see cref="Gl.OPERAND0_RGB"/>, <see 
		/// cref="Gl.OPERAND1_RGB"/>,<see cref="Gl.OPERAND2_RGB"/>, <see cref="Gl.OPERAND0_ALPHA"/>, <see 
		/// cref="Gl.OPERAND1_ALPHA"/>,<see cref="Gl.OPERAND2_ALPHA"/>, <see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, or 
		/// <seecref="Gl.COORD_REPLACE"/>. 
		/// </param>
		/// <param name="param">
		/// Specifies a single symbolic constant, one of <see cref="Gl.ADD"/>, <see cref="Gl.ADD_SIGNED"/>, <see 
		/// cref="Gl.INTERPOLATE"/>,<see cref="Gl.MODULATE"/>, <see cref="Gl.DECAL"/>, <see cref="Gl.BLEND"/>, <see 
		/// cref="Gl.REPLACE"/>,<see cref="Gl.SUBTRACT"/>, <see cref="Gl.COMBINE"/>, <see cref="Gl.TEXTURE"/>, <see 
		/// cref="Gl.CONSTANT"/>,<see cref="Gl.PRIMARY_COLOR"/>, <see cref="Gl.PREVIOUS"/>, <see cref="Gl.SRC_COLOR"/>, <see 
		/// cref="Gl.ONE_MINUS_SRC_COLOR"/>,<see cref="Gl.SRC_ALPHA"/>, <see cref="Gl.ONE_MINUS_SRC_ALPHA"/>, a single boolean value 
		/// forthe point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, 
		/// or1.0, 2.0, or 4.0 when specifying the <see cref="Gl.RGB_SCALE"/> or <see cref="Gl.ALPHA_SCALE"/>. 
		/// </param>
		/// <remarks>
		/// A texture environment specifies how texture values are interpreted when a fragment is textured. When <paramref 
		/// name="target"/>is <see cref="Gl.TEXTURE_FILTER_CONTROL"/>, <paramref name="pname"/> must be <see 
		/// cref="Gl.TEXTURE_LOD_BIAS"/>.When <paramref name="target"/> is <see cref="Gl.TEXTURE_ENV"/>, <paramref name="pname"/> 
		/// canbe <see cref="Gl.TEXTURE_ENV_MODE"/>, <see cref="Gl.TEXTURE_ENV_COLOR"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>,<see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, <see cref="Gl.SRC0_RGB"/>, <see 
		/// cref="Gl.SRC1_RGB"/>,<see cref="Gl.SRC2_RGB"/>, <see cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, or <see 
		/// cref="Gl.SRC2_ALPHA"/>.
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_MODE"/>, then <paramref name="params"/> is (or points to) the 
		/// symbolicname of a texture function. Six texture functions may be specified: <see cref="Gl.ADD"/>, <see 
		/// cref="Gl.MODULATE"/>,<see cref="Gl.DECAL"/>, <see cref="Gl.BLEND"/>, <see cref="Gl.REPLACE"/>, or <see 
		/// cref="Gl.COMBINE"/>.
		/// The following table shows the correspondence of filtered texture values Rt, Gt, Bt, At, Lt, It to texture source 
		/// components.Cs and As are used by the texture functions described below. 
		///  
		/// A texture function acts on the fragment to be textured using the texture image value that applies to the fragment (see 
		/// Gl.TexParameter)and produces an RGBA color for that fragment. The following table shows how the RGBA color is produced 
		/// foreach of the first five texture functions that can be chosen. C is a triple of color values (RGB) and A is the 
		/// associatedalpha value. RGBA values extracted from a texture image are in the range [0,1]. The subscript p refers to the 
		/// colorcomputed from the previous texture stage (or the incoming fragment if processing texture stage 0), the subscript s 
		/// tothe texture source color, the subscript c to the texture environment color, and the subscript v indicates a value 
		/// producedby the texture function. 
		///  
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_MODE"/>, and <paramref name="params"/> is <see 
		/// cref="Gl.COMBINE"/>,the form of the texture function depends on the values of <see cref="Gl.COMBINE_RGB"/> and <see 
		/// cref="Gl.COMBINE_ALPHA"/>.
		/// The following describes how the texture sources, as specified by <see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, 
		/// <seecref="Gl.SRC2_RGB"/>, <see cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, and <see cref="Gl.SRC2_ALPHA"/>, are 
		/// combinedto produce a final texture color. In the following tables, <see cref="Gl.SRC0_c"/> is represented by Arg0, <see 
		/// cref="Gl.SRC1_c"/>is represented by Arg1, and <see cref="Gl.SRC2_c"/> is represented by Arg2. 
		/// <see cref="Gl.COMBINE_RGB"/> accepts any of <see cref="Gl.REPLACE"/>, <see cref="Gl.MODULATE"/>, <see cref="Gl.ADD"/>, 
		/// <seecref="Gl.ADD_SIGNED"/>, <see cref="Gl.INTERPOLATE"/>, <see cref="Gl.SUBTRACT"/>, <see cref="Gl.DOT3_RGB"/>, or <see 
		/// cref="Gl.DOT3_RGBA"/>.
		///  
		/// The scalar results for <see cref="Gl.DOT3_RGB"/> and <see cref="Gl.DOT3_RGBA"/> are placed into each of the 3 (RGB) or 4 
		/// (RGBA)components on output. 
		/// Likewise, <see cref="Gl.COMBINE_ALPHA"/> accepts any of <see cref="Gl.REPLACE"/>, <see cref="Gl.MODULATE"/>, <see 
		/// cref="Gl.ADD"/>,<see cref="Gl.ADD_SIGNED"/>, <see cref="Gl.INTERPOLATE"/>, or <see cref="Gl.SUBTRACT"/>. The following 
		/// tabledescribes how alpha values are combined: 
		///  
		/// In the following tables, the value Cs represents the color sampled from the currently bound texture, Cc represents the 
		/// constanttexture-environment color, Cf represents the primary color of the incoming fragment, and Cp represents the color 
		/// computedfrom the previous texture stage or Cf if processing texture stage 0. Likewise, As, Ac, Af, and Ap represent the 
		/// respectivealpha values. 
		/// The following table describes the values assigned to Arg0, Arg1, and Arg2 based upon the RGB sources and operands: 
		///  
		/// For <see cref="Gl.TEXTUREn"/> sources, Cs and As represent the color and alpha, respectively, produced from texture 
		/// stagen. 
		/// The follow table describes the values assigned to Arg0, Arg1, and Arg2 based upon the alpha sources and operands: 
		///  
		/// The RGB and alpha results of the texture function are multipled by the values of <see cref="Gl.RGB_SCALE"/> and <see 
		/// cref="Gl.ALPHA_SCALE"/>,respectively, and clamped to the range 01. 
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_COLOR"/>, <paramref name="params"/> is a pointer to an array 
		/// thatholds an RGBA color consisting of four values. Integer color components are interpreted linearly such that the most 
		/// positiveinteger maps to 1.0, and the most negative integer maps to -1.0. The values are clamped to the range [0,1] when 
		/// theyare specified. Cc takes these four values. 
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_LOD_BIAS"/>, the value specified is added to the texture 
		/// level-of-detailparameter, that selects which mipmap, or mipmaps depending upon the selected <see 
		/// cref="Gl.TEXTURE_MIN_FILTER"/>,will be sampled. 
		/// <see cref="Gl.TEXTURE_ENV_MODE"/> defaults to <see cref="Gl.MODULATE"/> and <see cref="Gl.TEXTURE_ENV_COLOR"/> defaults 
		/// to(0, 0, 0, 0). 
		/// If <paramref name="target"/> is <see cref="Gl.POINT_SPRITE"/> and <paramref name="pname"/> is <see 
		/// cref="Gl.COORD_REPLACE"/>,the boolean value specified is used to either enable or disable point sprite texture 
		/// coordinatereplacement. The default value is <see cref="Gl.FALSE"/>. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="target"/> or <paramref name="pname"/> is not one of the 
		///   accepteddefined values, or when <paramref name="params"/> should have a defined constant value (based on the value of 
		///   <paramrefname="pname"/>) and does not. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if the <paramref name="params"/> value for <see cref="Gl.RGB_SCALE"/> or 
		///   <seecref="Gl.ALPHA_SCALE"/> are not one of 1.0, 2.0, or 4.0. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexEnv"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexEnv 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexEnvi != null, "pglTexEnvi not implemented");
			Delegates.pglTexEnvi((int)target, (int)pname, param);
			CallLog("glTexEnvi({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be <see cref="Gl.TEXTURE_ENV"/>, <see cref="Gl.TEXTURE_FILTER_CONTROL"/> or <see 
		/// cref="Gl.POINT_SPRITE"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either <see 
		/// cref="Gl.TEXTURE_ENV_MODE"/>,<see cref="Gl.TEXTURE_LOD_BIAS"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>,<see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, <see cref="Gl.SRC2_RGB"/>, <see 
		/// cref="Gl.SRC0_ALPHA"/>,<see cref="Gl.SRC1_ALPHA"/>, <see cref="Gl.SRC2_ALPHA"/>, <see cref="Gl.OPERAND0_RGB"/>, <see 
		/// cref="Gl.OPERAND1_RGB"/>,<see cref="Gl.OPERAND2_RGB"/>, <see cref="Gl.OPERAND0_ALPHA"/>, <see 
		/// cref="Gl.OPERAND1_ALPHA"/>,<see cref="Gl.OPERAND2_ALPHA"/>, <see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, or 
		/// <seecref="Gl.COORD_REPLACE"/>. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// A texture environment specifies how texture values are interpreted when a fragment is textured. When <paramref 
		/// name="target"/>is <see cref="Gl.TEXTURE_FILTER_CONTROL"/>, <paramref name="pname"/> must be <see 
		/// cref="Gl.TEXTURE_LOD_BIAS"/>.When <paramref name="target"/> is <see cref="Gl.TEXTURE_ENV"/>, <paramref name="pname"/> 
		/// canbe <see cref="Gl.TEXTURE_ENV_MODE"/>, <see cref="Gl.TEXTURE_ENV_COLOR"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>,<see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, <see cref="Gl.SRC0_RGB"/>, <see 
		/// cref="Gl.SRC1_RGB"/>,<see cref="Gl.SRC2_RGB"/>, <see cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, or <see 
		/// cref="Gl.SRC2_ALPHA"/>.
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_MODE"/>, then <paramref name="params"/> is (or points to) the 
		/// symbolicname of a texture function. Six texture functions may be specified: <see cref="Gl.ADD"/>, <see 
		/// cref="Gl.MODULATE"/>,<see cref="Gl.DECAL"/>, <see cref="Gl.BLEND"/>, <see cref="Gl.REPLACE"/>, or <see 
		/// cref="Gl.COMBINE"/>.
		/// The following table shows the correspondence of filtered texture values Rt, Gt, Bt, At, Lt, It to texture source 
		/// components.Cs and As are used by the texture functions described below. 
		///  
		/// A texture function acts on the fragment to be textured using the texture image value that applies to the fragment (see 
		/// Gl.TexParameter)and produces an RGBA color for that fragment. The following table shows how the RGBA color is produced 
		/// foreach of the first five texture functions that can be chosen. C is a triple of color values (RGB) and A is the 
		/// associatedalpha value. RGBA values extracted from a texture image are in the range [0,1]. The subscript p refers to the 
		/// colorcomputed from the previous texture stage (or the incoming fragment if processing texture stage 0), the subscript s 
		/// tothe texture source color, the subscript c to the texture environment color, and the subscript v indicates a value 
		/// producedby the texture function. 
		///  
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_MODE"/>, and <paramref name="params"/> is <see 
		/// cref="Gl.COMBINE"/>,the form of the texture function depends on the values of <see cref="Gl.COMBINE_RGB"/> and <see 
		/// cref="Gl.COMBINE_ALPHA"/>.
		/// The following describes how the texture sources, as specified by <see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, 
		/// <seecref="Gl.SRC2_RGB"/>, <see cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, and <see cref="Gl.SRC2_ALPHA"/>, are 
		/// combinedto produce a final texture color. In the following tables, <see cref="Gl.SRC0_c"/> is represented by Arg0, <see 
		/// cref="Gl.SRC1_c"/>is represented by Arg1, and <see cref="Gl.SRC2_c"/> is represented by Arg2. 
		/// <see cref="Gl.COMBINE_RGB"/> accepts any of <see cref="Gl.REPLACE"/>, <see cref="Gl.MODULATE"/>, <see cref="Gl.ADD"/>, 
		/// <seecref="Gl.ADD_SIGNED"/>, <see cref="Gl.INTERPOLATE"/>, <see cref="Gl.SUBTRACT"/>, <see cref="Gl.DOT3_RGB"/>, or <see 
		/// cref="Gl.DOT3_RGBA"/>.
		///  
		/// The scalar results for <see cref="Gl.DOT3_RGB"/> and <see cref="Gl.DOT3_RGBA"/> are placed into each of the 3 (RGB) or 4 
		/// (RGBA)components on output. 
		/// Likewise, <see cref="Gl.COMBINE_ALPHA"/> accepts any of <see cref="Gl.REPLACE"/>, <see cref="Gl.MODULATE"/>, <see 
		/// cref="Gl.ADD"/>,<see cref="Gl.ADD_SIGNED"/>, <see cref="Gl.INTERPOLATE"/>, or <see cref="Gl.SUBTRACT"/>. The following 
		/// tabledescribes how alpha values are combined: 
		///  
		/// In the following tables, the value Cs represents the color sampled from the currently bound texture, Cc represents the 
		/// constanttexture-environment color, Cf represents the primary color of the incoming fragment, and Cp represents the color 
		/// computedfrom the previous texture stage or Cf if processing texture stage 0. Likewise, As, Ac, Af, and Ap represent the 
		/// respectivealpha values. 
		/// The following table describes the values assigned to Arg0, Arg1, and Arg2 based upon the RGB sources and operands: 
		///  
		/// For <see cref="Gl.TEXTUREn"/> sources, Cs and As represent the color and alpha, respectively, produced from texture 
		/// stagen. 
		/// The follow table describes the values assigned to Arg0, Arg1, and Arg2 based upon the alpha sources and operands: 
		///  
		/// The RGB and alpha results of the texture function are multipled by the values of <see cref="Gl.RGB_SCALE"/> and <see 
		/// cref="Gl.ALPHA_SCALE"/>,respectively, and clamped to the range 01. 
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_COLOR"/>, <paramref name="params"/> is a pointer to an array 
		/// thatholds an RGBA color consisting of four values. Integer color components are interpreted linearly such that the most 
		/// positiveinteger maps to 1.0, and the most negative integer maps to -1.0. The values are clamped to the range [0,1] when 
		/// theyare specified. Cc takes these four values. 
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_LOD_BIAS"/>, the value specified is added to the texture 
		/// level-of-detailparameter, that selects which mipmap, or mipmaps depending upon the selected <see 
		/// cref="Gl.TEXTURE_MIN_FILTER"/>,will be sampled. 
		/// <see cref="Gl.TEXTURE_ENV_MODE"/> defaults to <see cref="Gl.MODULATE"/> and <see cref="Gl.TEXTURE_ENV_COLOR"/> defaults 
		/// to(0, 0, 0, 0). 
		/// If <paramref name="target"/> is <see cref="Gl.POINT_SPRITE"/> and <paramref name="pname"/> is <see 
		/// cref="Gl.COORD_REPLACE"/>,the boolean value specified is used to either enable or disable point sprite texture 
		/// coordinatereplacement. The default value is <see cref="Gl.FALSE"/>. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="target"/> or <paramref name="pname"/> is not one of the 
		///   accepteddefined values, or when <paramref name="params"/> should have a defined constant value (based on the value of 
		///   <paramrefname="pname"/>) and does not. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if the <paramref name="params"/> value for <see cref="Gl.RGB_SCALE"/> or 
		///   <seecref="Gl.ALPHA_SCALE"/> are not one of 1.0, 2.0, or 4.0. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexEnv"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexEnv 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexEnv(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexEnviv != null, "pglTexEnviv not implemented");
					Delegates.pglTexEnviv(target, pname, p_params);
					CallLog("glTexEnviv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be <see cref="Gl.TEXTURE_ENV"/>, <see cref="Gl.TEXTURE_FILTER_CONTROL"/> or <see 
		/// cref="Gl.POINT_SPRITE"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either <see 
		/// cref="Gl.TEXTURE_ENV_MODE"/>,<see cref="Gl.TEXTURE_LOD_BIAS"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>,<see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, <see cref="Gl.SRC2_RGB"/>, <see 
		/// cref="Gl.SRC0_ALPHA"/>,<see cref="Gl.SRC1_ALPHA"/>, <see cref="Gl.SRC2_ALPHA"/>, <see cref="Gl.OPERAND0_RGB"/>, <see 
		/// cref="Gl.OPERAND1_RGB"/>,<see cref="Gl.OPERAND2_RGB"/>, <see cref="Gl.OPERAND0_ALPHA"/>, <see 
		/// cref="Gl.OPERAND1_ALPHA"/>,<see cref="Gl.OPERAND2_ALPHA"/>, <see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, or 
		/// <seecref="Gl.COORD_REPLACE"/>. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// A texture environment specifies how texture values are interpreted when a fragment is textured. When <paramref 
		/// name="target"/>is <see cref="Gl.TEXTURE_FILTER_CONTROL"/>, <paramref name="pname"/> must be <see 
		/// cref="Gl.TEXTURE_LOD_BIAS"/>.When <paramref name="target"/> is <see cref="Gl.TEXTURE_ENV"/>, <paramref name="pname"/> 
		/// canbe <see cref="Gl.TEXTURE_ENV_MODE"/>, <see cref="Gl.TEXTURE_ENV_COLOR"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>,<see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, <see cref="Gl.SRC0_RGB"/>, <see 
		/// cref="Gl.SRC1_RGB"/>,<see cref="Gl.SRC2_RGB"/>, <see cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, or <see 
		/// cref="Gl.SRC2_ALPHA"/>.
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_MODE"/>, then <paramref name="params"/> is (or points to) the 
		/// symbolicname of a texture function. Six texture functions may be specified: <see cref="Gl.ADD"/>, <see 
		/// cref="Gl.MODULATE"/>,<see cref="Gl.DECAL"/>, <see cref="Gl.BLEND"/>, <see cref="Gl.REPLACE"/>, or <see 
		/// cref="Gl.COMBINE"/>.
		/// The following table shows the correspondence of filtered texture values Rt, Gt, Bt, At, Lt, It to texture source 
		/// components.Cs and As are used by the texture functions described below. 
		///  
		/// A texture function acts on the fragment to be textured using the texture image value that applies to the fragment (see 
		/// Gl.TexParameter)and produces an RGBA color for that fragment. The following table shows how the RGBA color is produced 
		/// foreach of the first five texture functions that can be chosen. C is a triple of color values (RGB) and A is the 
		/// associatedalpha value. RGBA values extracted from a texture image are in the range [0,1]. The subscript p refers to the 
		/// colorcomputed from the previous texture stage (or the incoming fragment if processing texture stage 0), the subscript s 
		/// tothe texture source color, the subscript c to the texture environment color, and the subscript v indicates a value 
		/// producedby the texture function. 
		///  
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_MODE"/>, and <paramref name="params"/> is <see 
		/// cref="Gl.COMBINE"/>,the form of the texture function depends on the values of <see cref="Gl.COMBINE_RGB"/> and <see 
		/// cref="Gl.COMBINE_ALPHA"/>.
		/// The following describes how the texture sources, as specified by <see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, 
		/// <seecref="Gl.SRC2_RGB"/>, <see cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, and <see cref="Gl.SRC2_ALPHA"/>, are 
		/// combinedto produce a final texture color. In the following tables, <see cref="Gl.SRC0_c"/> is represented by Arg0, <see 
		/// cref="Gl.SRC1_c"/>is represented by Arg1, and <see cref="Gl.SRC2_c"/> is represented by Arg2. 
		/// <see cref="Gl.COMBINE_RGB"/> accepts any of <see cref="Gl.REPLACE"/>, <see cref="Gl.MODULATE"/>, <see cref="Gl.ADD"/>, 
		/// <seecref="Gl.ADD_SIGNED"/>, <see cref="Gl.INTERPOLATE"/>, <see cref="Gl.SUBTRACT"/>, <see cref="Gl.DOT3_RGB"/>, or <see 
		/// cref="Gl.DOT3_RGBA"/>.
		///  
		/// The scalar results for <see cref="Gl.DOT3_RGB"/> and <see cref="Gl.DOT3_RGBA"/> are placed into each of the 3 (RGB) or 4 
		/// (RGBA)components on output. 
		/// Likewise, <see cref="Gl.COMBINE_ALPHA"/> accepts any of <see cref="Gl.REPLACE"/>, <see cref="Gl.MODULATE"/>, <see 
		/// cref="Gl.ADD"/>,<see cref="Gl.ADD_SIGNED"/>, <see cref="Gl.INTERPOLATE"/>, or <see cref="Gl.SUBTRACT"/>. The following 
		/// tabledescribes how alpha values are combined: 
		///  
		/// In the following tables, the value Cs represents the color sampled from the currently bound texture, Cc represents the 
		/// constanttexture-environment color, Cf represents the primary color of the incoming fragment, and Cp represents the color 
		/// computedfrom the previous texture stage or Cf if processing texture stage 0. Likewise, As, Ac, Af, and Ap represent the 
		/// respectivealpha values. 
		/// The following table describes the values assigned to Arg0, Arg1, and Arg2 based upon the RGB sources and operands: 
		///  
		/// For <see cref="Gl.TEXTUREn"/> sources, Cs and As represent the color and alpha, respectively, produced from texture 
		/// stagen. 
		/// The follow table describes the values assigned to Arg0, Arg1, and Arg2 based upon the alpha sources and operands: 
		///  
		/// The RGB and alpha results of the texture function are multipled by the values of <see cref="Gl.RGB_SCALE"/> and <see 
		/// cref="Gl.ALPHA_SCALE"/>,respectively, and clamped to the range 01. 
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_ENV_COLOR"/>, <paramref name="params"/> is a pointer to an array 
		/// thatholds an RGBA color consisting of four values. Integer color components are interpreted linearly such that the most 
		/// positiveinteger maps to 1.0, and the most negative integer maps to -1.0. The values are clamped to the range [0,1] when 
		/// theyare specified. Cc takes these four values. 
		/// If <paramref name="pname"/> is <see cref="Gl.TEXTURE_LOD_BIAS"/>, the value specified is added to the texture 
		/// level-of-detailparameter, that selects which mipmap, or mipmaps depending upon the selected <see 
		/// cref="Gl.TEXTURE_MIN_FILTER"/>,will be sampled. 
		/// <see cref="Gl.TEXTURE_ENV_MODE"/> defaults to <see cref="Gl.MODULATE"/> and <see cref="Gl.TEXTURE_ENV_COLOR"/> defaults 
		/// to(0, 0, 0, 0). 
		/// If <paramref name="target"/> is <see cref="Gl.POINT_SPRITE"/> and <paramref name="pname"/> is <see 
		/// cref="Gl.COORD_REPLACE"/>,the boolean value specified is used to either enable or disable point sprite texture 
		/// coordinatereplacement. The default value is <see cref="Gl.FALSE"/>. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="target"/> or <paramref name="pname"/> is not one of the 
		///   accepteddefined values, or when <paramref name="params"/> should have a defined constant value (based on the value of 
		///   <paramrefname="pname"/>) and does not. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if the <paramref name="params"/> value for <see cref="Gl.RGB_SCALE"/> or 
		///   <seecref="Gl.ALPHA_SCALE"/> are not one of 1.0, 2.0, or 4.0. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexEnv"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexEnv 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexEnviv != null, "pglTexEnviv not implemented");
					Delegates.pglTexEnviv((int)target, (int)pname, p_params);
					CallLog("glTexEnviv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>. 
		/// </param>
		/// <param name="param">
		/// Specifies a single-valued texture generation parameter, one of <see cref="Gl.OBJECT_LINEAR"/>, <see 
		/// cref="Gl.EYE_LINEAR"/>,<see cref="Gl.SPHERE_MAP"/>, <see cref="Gl.NORMAL_MAP"/>, or <see cref="Gl.REFLECTION_MAP"/>. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.TexGen"/> selects a texture-coordinate generation function or supplies coefficients for one of the 
		/// functions.<paramref name="coord"/> names one of the (s, t, r, q) texture coordinates; it must be one of the symbols <see 
		/// cref="Gl.S"/>,<see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see cref="Gl.Q"/>. <paramref name="pname"/> must be one of 
		/// threesymbolic constants: <see cref="Gl.TEXTURE_GEN_MODE"/>, <see cref="Gl.OBJECT_PLANE"/>, or <see 
		/// cref="Gl.EYE_PLANE"/>.If <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, then <paramref name="params"/> 
		/// choosesa mode, one of <see cref="Gl.OBJECT_LINEAR"/>, <see cref="Gl.EYE_LINEAR"/>, <see cref="Gl.SPHERE_MAP"/>, <see 
		/// cref="Gl.NORMAL_MAP"/>,or <see cref="Gl.REFLECTION_MAP"/>. If <paramref name="pname"/> is either <see 
		/// cref="Gl.OBJECT_PLANE"/>or <see cref="Gl.EYE_PLANE"/>, <paramref name="params"/> contains coefficients for the 
		/// correspondingtexture generation function. 
		/// If the texture generation function is <see cref="Gl.OBJECT_LINEAR"/>, the function 
		/// g=p1×xo+p2×yo+p3×zo+p4×wo 
		/// is used, where g is the value computed for the coordinate named in <paramref name="coord"/>, p1, p2, p3, and p4 are the 
		/// fourvalues supplied in <paramref name="params"/>, and xo, yo, zo, and wo are the object coordinates of the vertex. This 
		/// functioncan be used, for example, to texture-map terrain using sea level as a reference plane (defined by p1, p2, p3, 
		/// andp4). The altitude of a terrain vertex is computed by the <see cref="Gl.OBJECT_LINEAR"/> coordinate generation 
		/// functionas its distance from sea level; that altitude can then be used to index the texture image to map white snow onto 
		/// peaksand green grass onto foothills. 
		/// If the texture generation function is <see cref="Gl.EYE_LINEAR"/>, the function 
		/// g=p1″×xe+p2″×ye+p3″×ze+p4″×we 
		/// is used, where 
		/// p1″⁢p2″⁢p3″⁢p4″=p1⁢p2⁢p3⁢p4⁢M-1 
		/// and xe, ye, ze, and we are the eye coordinates of the vertex, p1, p2, p3, and p4 are the values supplied in <paramref 
		/// name="params"/>,and M is the modelview matrix when <see cref="Gl.TexGen"/> is invoked. If M is poorly conditioned or 
		/// singular,texture coordinates generated by the resulting function may be inaccurate or undefined. 
		/// Note that the values in <paramref name="params"/> define a reference plane in eye coordinates. The modelview matrix that 
		/// isapplied to them may not be the same one in effect when the polygon vertices are transformed. This function establishes 
		/// afield of texture coordinates that can produce dynamic contour lines on moving objects. 
		/// If the texture generation function is <see cref="Gl.SPHERE_MAP"/> and <paramref name="coord"/> is either <see 
		/// cref="Gl.S"/>or <see cref="Gl.T"/>, s and t texture coordinates are generated as follows. Let u be the unit vector 
		/// pointingfrom the origin to the polygon vertex (in eye coordinates). Let n sup prime be the current normal, after 
		/// transformationto eye coordinates. Let 
		/// f=fx⁢fy⁢fzT be the reflection vector such that 
		/// f=u-2⁢n″⁢n″T⁢u 
		/// Finally, let m=2⁢fx2+fy2+fz+12. Then the values assigned to the s and t texture coordinates are 
		/// s=fxm+12 
		/// t=fym+12 
		/// To enable or disable a texture-coordinate generation function, call Gl.Enable or Gl.Disable with one of the symbolic 
		/// texture-coordinatenames (<see cref="Gl.TEXTURE_GEN_S"/>, <see cref="Gl.TEXTURE_GEN_T"/>, <see cref="Gl.TEXTURE_GEN_R"/>, 
		/// or<see cref="Gl.TEXTURE_GEN_Q"/>) as the argument. When enabled, the specified texture coordinate is computed according 
		/// tothe generating function associated with that coordinate. When disabled, subsequent vertices take the specified texture 
		/// coordinatefrom the current set of texture coordinates. Initially, all texture generation functions are set to <see 
		/// cref="Gl.EYE_LINEAR"/>and are disabled. Both s plane equations are (1, 0, 0, 0), both t plane equations are (0, 1, 0, 
		/// 0),and all r and q plane equations are (0, 0, 0, 0). 
		/// When the ARB_multitexture extension is supported, <see cref="Gl.TexGen"/> sets the texture generation parameters for the 
		/// currentlyactive texture unit, selected with Gl.ActiveTexture. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted 
		///   definedvalue, or when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/> and <paramref name="params"/> is not 
		///   anaccepted defined value. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, <paramref 
		///   name="params"/>is <see cref="Gl.SPHERE_MAP"/>, and <paramref name="coord"/> is either <see cref="Gl.R"/> or <see 
		///   cref="Gl.Q"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexGen"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexGen 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_S"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_T"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_R"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_Q"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexGen(int coord, int pname, double param)
		{
			Debug.Assert(Delegates.pglTexGend != null, "pglTexGend not implemented");
			Delegates.pglTexGend(coord, pname, param);
			CallLog("glTexGend({0}, {1}, {2})", coord, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>. 
		/// </param>
		/// <param name="param">
		/// Specifies a single-valued texture generation parameter, one of <see cref="Gl.OBJECT_LINEAR"/>, <see 
		/// cref="Gl.EYE_LINEAR"/>,<see cref="Gl.SPHERE_MAP"/>, <see cref="Gl.NORMAL_MAP"/>, or <see cref="Gl.REFLECTION_MAP"/>. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.TexGen"/> selects a texture-coordinate generation function or supplies coefficients for one of the 
		/// functions.<paramref name="coord"/> names one of the (s, t, r, q) texture coordinates; it must be one of the symbols <see 
		/// cref="Gl.S"/>,<see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see cref="Gl.Q"/>. <paramref name="pname"/> must be one of 
		/// threesymbolic constants: <see cref="Gl.TEXTURE_GEN_MODE"/>, <see cref="Gl.OBJECT_PLANE"/>, or <see 
		/// cref="Gl.EYE_PLANE"/>.If <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, then <paramref name="params"/> 
		/// choosesa mode, one of <see cref="Gl.OBJECT_LINEAR"/>, <see cref="Gl.EYE_LINEAR"/>, <see cref="Gl.SPHERE_MAP"/>, <see 
		/// cref="Gl.NORMAL_MAP"/>,or <see cref="Gl.REFLECTION_MAP"/>. If <paramref name="pname"/> is either <see 
		/// cref="Gl.OBJECT_PLANE"/>or <see cref="Gl.EYE_PLANE"/>, <paramref name="params"/> contains coefficients for the 
		/// correspondingtexture generation function. 
		/// If the texture generation function is <see cref="Gl.OBJECT_LINEAR"/>, the function 
		/// g=p1×xo+p2×yo+p3×zo+p4×wo 
		/// is used, where g is the value computed for the coordinate named in <paramref name="coord"/>, p1, p2, p3, and p4 are the 
		/// fourvalues supplied in <paramref name="params"/>, and xo, yo, zo, and wo are the object coordinates of the vertex. This 
		/// functioncan be used, for example, to texture-map terrain using sea level as a reference plane (defined by p1, p2, p3, 
		/// andp4). The altitude of a terrain vertex is computed by the <see cref="Gl.OBJECT_LINEAR"/> coordinate generation 
		/// functionas its distance from sea level; that altitude can then be used to index the texture image to map white snow onto 
		/// peaksand green grass onto foothills. 
		/// If the texture generation function is <see cref="Gl.EYE_LINEAR"/>, the function 
		/// g=p1″×xe+p2″×ye+p3″×ze+p4″×we 
		/// is used, where 
		/// p1″⁢p2″⁢p3″⁢p4″=p1⁢p2⁢p3⁢p4⁢M-1 
		/// and xe, ye, ze, and we are the eye coordinates of the vertex, p1, p2, p3, and p4 are the values supplied in <paramref 
		/// name="params"/>,and M is the modelview matrix when <see cref="Gl.TexGen"/> is invoked. If M is poorly conditioned or 
		/// singular,texture coordinates generated by the resulting function may be inaccurate or undefined. 
		/// Note that the values in <paramref name="params"/> define a reference plane in eye coordinates. The modelview matrix that 
		/// isapplied to them may not be the same one in effect when the polygon vertices are transformed. This function establishes 
		/// afield of texture coordinates that can produce dynamic contour lines on moving objects. 
		/// If the texture generation function is <see cref="Gl.SPHERE_MAP"/> and <paramref name="coord"/> is either <see 
		/// cref="Gl.S"/>or <see cref="Gl.T"/>, s and t texture coordinates are generated as follows. Let u be the unit vector 
		/// pointingfrom the origin to the polygon vertex (in eye coordinates). Let n sup prime be the current normal, after 
		/// transformationto eye coordinates. Let 
		/// f=fx⁢fy⁢fzT be the reflection vector such that 
		/// f=u-2⁢n″⁢n″T⁢u 
		/// Finally, let m=2⁢fx2+fy2+fz+12. Then the values assigned to the s and t texture coordinates are 
		/// s=fxm+12 
		/// t=fym+12 
		/// To enable or disable a texture-coordinate generation function, call Gl.Enable or Gl.Disable with one of the symbolic 
		/// texture-coordinatenames (<see cref="Gl.TEXTURE_GEN_S"/>, <see cref="Gl.TEXTURE_GEN_T"/>, <see cref="Gl.TEXTURE_GEN_R"/>, 
		/// or<see cref="Gl.TEXTURE_GEN_Q"/>) as the argument. When enabled, the specified texture coordinate is computed according 
		/// tothe generating function associated with that coordinate. When disabled, subsequent vertices take the specified texture 
		/// coordinatefrom the current set of texture coordinates. Initially, all texture generation functions are set to <see 
		/// cref="Gl.EYE_LINEAR"/>and are disabled. Both s plane equations are (1, 0, 0, 0), both t plane equations are (0, 1, 0, 
		/// 0),and all r and q plane equations are (0, 0, 0, 0). 
		/// When the ARB_multitexture extension is supported, <see cref="Gl.TexGen"/> sets the texture generation parameters for the 
		/// currentlyactive texture unit, selected with Gl.ActiveTexture. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted 
		///   definedvalue, or when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/> and <paramref name="params"/> is not 
		///   anaccepted defined value. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, <paramref 
		///   name="params"/>is <see cref="Gl.SPHERE_MAP"/>, and <paramref name="coord"/> is either <see cref="Gl.R"/> or <see 
		///   cref="Gl.Q"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexGen"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexGen 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_S"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_T"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_R"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_Q"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, double param)
		{
			Debug.Assert(Delegates.pglTexGend != null, "pglTexGend not implemented");
			Delegates.pglTexGend((int)coord, (int)pname, param);
			CallLog("glTexGend({0}, {1}, {2})", coord, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.TexGen"/> selects a texture-coordinate generation function or supplies coefficients for one of the 
		/// functions.<paramref name="coord"/> names one of the (s, t, r, q) texture coordinates; it must be one of the symbols <see 
		/// cref="Gl.S"/>,<see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see cref="Gl.Q"/>. <paramref name="pname"/> must be one of 
		/// threesymbolic constants: <see cref="Gl.TEXTURE_GEN_MODE"/>, <see cref="Gl.OBJECT_PLANE"/>, or <see 
		/// cref="Gl.EYE_PLANE"/>.If <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, then <paramref name="params"/> 
		/// choosesa mode, one of <see cref="Gl.OBJECT_LINEAR"/>, <see cref="Gl.EYE_LINEAR"/>, <see cref="Gl.SPHERE_MAP"/>, <see 
		/// cref="Gl.NORMAL_MAP"/>,or <see cref="Gl.REFLECTION_MAP"/>. If <paramref name="pname"/> is either <see 
		/// cref="Gl.OBJECT_PLANE"/>or <see cref="Gl.EYE_PLANE"/>, <paramref name="params"/> contains coefficients for the 
		/// correspondingtexture generation function. 
		/// If the texture generation function is <see cref="Gl.OBJECT_LINEAR"/>, the function 
		/// g=p1×xo+p2×yo+p3×zo+p4×wo 
		/// is used, where g is the value computed for the coordinate named in <paramref name="coord"/>, p1, p2, p3, and p4 are the 
		/// fourvalues supplied in <paramref name="params"/>, and xo, yo, zo, and wo are the object coordinates of the vertex. This 
		/// functioncan be used, for example, to texture-map terrain using sea level as a reference plane (defined by p1, p2, p3, 
		/// andp4). The altitude of a terrain vertex is computed by the <see cref="Gl.OBJECT_LINEAR"/> coordinate generation 
		/// functionas its distance from sea level; that altitude can then be used to index the texture image to map white snow onto 
		/// peaksand green grass onto foothills. 
		/// If the texture generation function is <see cref="Gl.EYE_LINEAR"/>, the function 
		/// g=p1″×xe+p2″×ye+p3″×ze+p4″×we 
		/// is used, where 
		/// p1″⁢p2″⁢p3″⁢p4″=p1⁢p2⁢p3⁢p4⁢M-1 
		/// and xe, ye, ze, and we are the eye coordinates of the vertex, p1, p2, p3, and p4 are the values supplied in <paramref 
		/// name="params"/>,and M is the modelview matrix when <see cref="Gl.TexGen"/> is invoked. If M is poorly conditioned or 
		/// singular,texture coordinates generated by the resulting function may be inaccurate or undefined. 
		/// Note that the values in <paramref name="params"/> define a reference plane in eye coordinates. The modelview matrix that 
		/// isapplied to them may not be the same one in effect when the polygon vertices are transformed. This function establishes 
		/// afield of texture coordinates that can produce dynamic contour lines on moving objects. 
		/// If the texture generation function is <see cref="Gl.SPHERE_MAP"/> and <paramref name="coord"/> is either <see 
		/// cref="Gl.S"/>or <see cref="Gl.T"/>, s and t texture coordinates are generated as follows. Let u be the unit vector 
		/// pointingfrom the origin to the polygon vertex (in eye coordinates). Let n sup prime be the current normal, after 
		/// transformationto eye coordinates. Let 
		/// f=fx⁢fy⁢fzT be the reflection vector such that 
		/// f=u-2⁢n″⁢n″T⁢u 
		/// Finally, let m=2⁢fx2+fy2+fz+12. Then the values assigned to the s and t texture coordinates are 
		/// s=fxm+12 
		/// t=fym+12 
		/// To enable or disable a texture-coordinate generation function, call Gl.Enable or Gl.Disable with one of the symbolic 
		/// texture-coordinatenames (<see cref="Gl.TEXTURE_GEN_S"/>, <see cref="Gl.TEXTURE_GEN_T"/>, <see cref="Gl.TEXTURE_GEN_R"/>, 
		/// or<see cref="Gl.TEXTURE_GEN_Q"/>) as the argument. When enabled, the specified texture coordinate is computed according 
		/// tothe generating function associated with that coordinate. When disabled, subsequent vertices take the specified texture 
		/// coordinatefrom the current set of texture coordinates. Initially, all texture generation functions are set to <see 
		/// cref="Gl.EYE_LINEAR"/>and are disabled. Both s plane equations are (1, 0, 0, 0), both t plane equations are (0, 1, 0, 
		/// 0),and all r and q plane equations are (0, 0, 0, 0). 
		/// When the ARB_multitexture extension is supported, <see cref="Gl.TexGen"/> sets the texture generation parameters for the 
		/// currentlyactive texture unit, selected with Gl.ActiveTexture. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted 
		///   definedvalue, or when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/> and <paramref name="params"/> is not 
		///   anaccepted defined value. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, <paramref 
		///   name="params"/>is <see cref="Gl.SPHERE_MAP"/>, and <paramref name="coord"/> is either <see cref="Gl.R"/> or <see 
		///   cref="Gl.Q"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexGen"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexGen 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_S"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_T"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_R"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_Q"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexGen(int coord, int pname, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGendv != null, "pglTexGendv not implemented");
					Delegates.pglTexGendv(coord, pname, p_params);
					CallLog("glTexGendv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.TexGen"/> selects a texture-coordinate generation function or supplies coefficients for one of the 
		/// functions.<paramref name="coord"/> names one of the (s, t, r, q) texture coordinates; it must be one of the symbols <see 
		/// cref="Gl.S"/>,<see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see cref="Gl.Q"/>. <paramref name="pname"/> must be one of 
		/// threesymbolic constants: <see cref="Gl.TEXTURE_GEN_MODE"/>, <see cref="Gl.OBJECT_PLANE"/>, or <see 
		/// cref="Gl.EYE_PLANE"/>.If <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, then <paramref name="params"/> 
		/// choosesa mode, one of <see cref="Gl.OBJECT_LINEAR"/>, <see cref="Gl.EYE_LINEAR"/>, <see cref="Gl.SPHERE_MAP"/>, <see 
		/// cref="Gl.NORMAL_MAP"/>,or <see cref="Gl.REFLECTION_MAP"/>. If <paramref name="pname"/> is either <see 
		/// cref="Gl.OBJECT_PLANE"/>or <see cref="Gl.EYE_PLANE"/>, <paramref name="params"/> contains coefficients for the 
		/// correspondingtexture generation function. 
		/// If the texture generation function is <see cref="Gl.OBJECT_LINEAR"/>, the function 
		/// g=p1×xo+p2×yo+p3×zo+p4×wo 
		/// is used, where g is the value computed for the coordinate named in <paramref name="coord"/>, p1, p2, p3, and p4 are the 
		/// fourvalues supplied in <paramref name="params"/>, and xo, yo, zo, and wo are the object coordinates of the vertex. This 
		/// functioncan be used, for example, to texture-map terrain using sea level as a reference plane (defined by p1, p2, p3, 
		/// andp4). The altitude of a terrain vertex is computed by the <see cref="Gl.OBJECT_LINEAR"/> coordinate generation 
		/// functionas its distance from sea level; that altitude can then be used to index the texture image to map white snow onto 
		/// peaksand green grass onto foothills. 
		/// If the texture generation function is <see cref="Gl.EYE_LINEAR"/>, the function 
		/// g=p1″×xe+p2″×ye+p3″×ze+p4″×we 
		/// is used, where 
		/// p1″⁢p2″⁢p3″⁢p4″=p1⁢p2⁢p3⁢p4⁢M-1 
		/// and xe, ye, ze, and we are the eye coordinates of the vertex, p1, p2, p3, and p4 are the values supplied in <paramref 
		/// name="params"/>,and M is the modelview matrix when <see cref="Gl.TexGen"/> is invoked. If M is poorly conditioned or 
		/// singular,texture coordinates generated by the resulting function may be inaccurate or undefined. 
		/// Note that the values in <paramref name="params"/> define a reference plane in eye coordinates. The modelview matrix that 
		/// isapplied to them may not be the same one in effect when the polygon vertices are transformed. This function establishes 
		/// afield of texture coordinates that can produce dynamic contour lines on moving objects. 
		/// If the texture generation function is <see cref="Gl.SPHERE_MAP"/> and <paramref name="coord"/> is either <see 
		/// cref="Gl.S"/>or <see cref="Gl.T"/>, s and t texture coordinates are generated as follows. Let u be the unit vector 
		/// pointingfrom the origin to the polygon vertex (in eye coordinates). Let n sup prime be the current normal, after 
		/// transformationto eye coordinates. Let 
		/// f=fx⁢fy⁢fzT be the reflection vector such that 
		/// f=u-2⁢n″⁢n″T⁢u 
		/// Finally, let m=2⁢fx2+fy2+fz+12. Then the values assigned to the s and t texture coordinates are 
		/// s=fxm+12 
		/// t=fym+12 
		/// To enable or disable a texture-coordinate generation function, call Gl.Enable or Gl.Disable with one of the symbolic 
		/// texture-coordinatenames (<see cref="Gl.TEXTURE_GEN_S"/>, <see cref="Gl.TEXTURE_GEN_T"/>, <see cref="Gl.TEXTURE_GEN_R"/>, 
		/// or<see cref="Gl.TEXTURE_GEN_Q"/>) as the argument. When enabled, the specified texture coordinate is computed according 
		/// tothe generating function associated with that coordinate. When disabled, subsequent vertices take the specified texture 
		/// coordinatefrom the current set of texture coordinates. Initially, all texture generation functions are set to <see 
		/// cref="Gl.EYE_LINEAR"/>and are disabled. Both s plane equations are (1, 0, 0, 0), both t plane equations are (0, 1, 0, 
		/// 0),and all r and q plane equations are (0, 0, 0, 0). 
		/// When the ARB_multitexture extension is supported, <see cref="Gl.TexGen"/> sets the texture generation parameters for the 
		/// currentlyactive texture unit, selected with Gl.ActiveTexture. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted 
		///   definedvalue, or when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/> and <paramref name="params"/> is not 
		///   anaccepted defined value. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, <paramref 
		///   name="params"/>is <see cref="Gl.SPHERE_MAP"/>, and <paramref name="coord"/> is either <see cref="Gl.R"/> or <see 
		///   cref="Gl.Q"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexGen"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexGen 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_S"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_T"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_R"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_Q"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGendv != null, "pglTexGendv not implemented");
					Delegates.pglTexGendv((int)coord, (int)pname, p_params);
					CallLog("glTexGendv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>. 
		/// </param>
		/// <param name="param">
		/// Specifies a single-valued texture generation parameter, one of <see cref="Gl.OBJECT_LINEAR"/>, <see 
		/// cref="Gl.EYE_LINEAR"/>,<see cref="Gl.SPHERE_MAP"/>, <see cref="Gl.NORMAL_MAP"/>, or <see cref="Gl.REFLECTION_MAP"/>. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.TexGen"/> selects a texture-coordinate generation function or supplies coefficients for one of the 
		/// functions.<paramref name="coord"/> names one of the (s, t, r, q) texture coordinates; it must be one of the symbols <see 
		/// cref="Gl.S"/>,<see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see cref="Gl.Q"/>. <paramref name="pname"/> must be one of 
		/// threesymbolic constants: <see cref="Gl.TEXTURE_GEN_MODE"/>, <see cref="Gl.OBJECT_PLANE"/>, or <see 
		/// cref="Gl.EYE_PLANE"/>.If <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, then <paramref name="params"/> 
		/// choosesa mode, one of <see cref="Gl.OBJECT_LINEAR"/>, <see cref="Gl.EYE_LINEAR"/>, <see cref="Gl.SPHERE_MAP"/>, <see 
		/// cref="Gl.NORMAL_MAP"/>,or <see cref="Gl.REFLECTION_MAP"/>. If <paramref name="pname"/> is either <see 
		/// cref="Gl.OBJECT_PLANE"/>or <see cref="Gl.EYE_PLANE"/>, <paramref name="params"/> contains coefficients for the 
		/// correspondingtexture generation function. 
		/// If the texture generation function is <see cref="Gl.OBJECT_LINEAR"/>, the function 
		/// g=p1×xo+p2×yo+p3×zo+p4×wo 
		/// is used, where g is the value computed for the coordinate named in <paramref name="coord"/>, p1, p2, p3, and p4 are the 
		/// fourvalues supplied in <paramref name="params"/>, and xo, yo, zo, and wo are the object coordinates of the vertex. This 
		/// functioncan be used, for example, to texture-map terrain using sea level as a reference plane (defined by p1, p2, p3, 
		/// andp4). The altitude of a terrain vertex is computed by the <see cref="Gl.OBJECT_LINEAR"/> coordinate generation 
		/// functionas its distance from sea level; that altitude can then be used to index the texture image to map white snow onto 
		/// peaksand green grass onto foothills. 
		/// If the texture generation function is <see cref="Gl.EYE_LINEAR"/>, the function 
		/// g=p1″×xe+p2″×ye+p3″×ze+p4″×we 
		/// is used, where 
		/// p1″⁢p2″⁢p3″⁢p4″=p1⁢p2⁢p3⁢p4⁢M-1 
		/// and xe, ye, ze, and we are the eye coordinates of the vertex, p1, p2, p3, and p4 are the values supplied in <paramref 
		/// name="params"/>,and M is the modelview matrix when <see cref="Gl.TexGen"/> is invoked. If M is poorly conditioned or 
		/// singular,texture coordinates generated by the resulting function may be inaccurate or undefined. 
		/// Note that the values in <paramref name="params"/> define a reference plane in eye coordinates. The modelview matrix that 
		/// isapplied to them may not be the same one in effect when the polygon vertices are transformed. This function establishes 
		/// afield of texture coordinates that can produce dynamic contour lines on moving objects. 
		/// If the texture generation function is <see cref="Gl.SPHERE_MAP"/> and <paramref name="coord"/> is either <see 
		/// cref="Gl.S"/>or <see cref="Gl.T"/>, s and t texture coordinates are generated as follows. Let u be the unit vector 
		/// pointingfrom the origin to the polygon vertex (in eye coordinates). Let n sup prime be the current normal, after 
		/// transformationto eye coordinates. Let 
		/// f=fx⁢fy⁢fzT be the reflection vector such that 
		/// f=u-2⁢n″⁢n″T⁢u 
		/// Finally, let m=2⁢fx2+fy2+fz+12. Then the values assigned to the s and t texture coordinates are 
		/// s=fxm+12 
		/// t=fym+12 
		/// To enable or disable a texture-coordinate generation function, call Gl.Enable or Gl.Disable with one of the symbolic 
		/// texture-coordinatenames (<see cref="Gl.TEXTURE_GEN_S"/>, <see cref="Gl.TEXTURE_GEN_T"/>, <see cref="Gl.TEXTURE_GEN_R"/>, 
		/// or<see cref="Gl.TEXTURE_GEN_Q"/>) as the argument. When enabled, the specified texture coordinate is computed according 
		/// tothe generating function associated with that coordinate. When disabled, subsequent vertices take the specified texture 
		/// coordinatefrom the current set of texture coordinates. Initially, all texture generation functions are set to <see 
		/// cref="Gl.EYE_LINEAR"/>and are disabled. Both s plane equations are (1, 0, 0, 0), both t plane equations are (0, 1, 0, 
		/// 0),and all r and q plane equations are (0, 0, 0, 0). 
		/// When the ARB_multitexture extension is supported, <see cref="Gl.TexGen"/> sets the texture generation parameters for the 
		/// currentlyactive texture unit, selected with Gl.ActiveTexture. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted 
		///   definedvalue, or when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/> and <paramref name="params"/> is not 
		///   anaccepted defined value. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, <paramref 
		///   name="params"/>is <see cref="Gl.SPHERE_MAP"/>, and <paramref name="coord"/> is either <see cref="Gl.R"/> or <see 
		///   cref="Gl.Q"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexGen"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexGen 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_S"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_T"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_R"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_Q"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexGen(int coord, int pname, float param)
		{
			Debug.Assert(Delegates.pglTexGenf != null, "pglTexGenf not implemented");
			Delegates.pglTexGenf(coord, pname, param);
			CallLog("glTexGenf({0}, {1}, {2})", coord, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>. 
		/// </param>
		/// <param name="param">
		/// Specifies a single-valued texture generation parameter, one of <see cref="Gl.OBJECT_LINEAR"/>, <see 
		/// cref="Gl.EYE_LINEAR"/>,<see cref="Gl.SPHERE_MAP"/>, <see cref="Gl.NORMAL_MAP"/>, or <see cref="Gl.REFLECTION_MAP"/>. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.TexGen"/> selects a texture-coordinate generation function or supplies coefficients for one of the 
		/// functions.<paramref name="coord"/> names one of the (s, t, r, q) texture coordinates; it must be one of the symbols <see 
		/// cref="Gl.S"/>,<see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see cref="Gl.Q"/>. <paramref name="pname"/> must be one of 
		/// threesymbolic constants: <see cref="Gl.TEXTURE_GEN_MODE"/>, <see cref="Gl.OBJECT_PLANE"/>, or <see 
		/// cref="Gl.EYE_PLANE"/>.If <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, then <paramref name="params"/> 
		/// choosesa mode, one of <see cref="Gl.OBJECT_LINEAR"/>, <see cref="Gl.EYE_LINEAR"/>, <see cref="Gl.SPHERE_MAP"/>, <see 
		/// cref="Gl.NORMAL_MAP"/>,or <see cref="Gl.REFLECTION_MAP"/>. If <paramref name="pname"/> is either <see 
		/// cref="Gl.OBJECT_PLANE"/>or <see cref="Gl.EYE_PLANE"/>, <paramref name="params"/> contains coefficients for the 
		/// correspondingtexture generation function. 
		/// If the texture generation function is <see cref="Gl.OBJECT_LINEAR"/>, the function 
		/// g=p1×xo+p2×yo+p3×zo+p4×wo 
		/// is used, where g is the value computed for the coordinate named in <paramref name="coord"/>, p1, p2, p3, and p4 are the 
		/// fourvalues supplied in <paramref name="params"/>, and xo, yo, zo, and wo are the object coordinates of the vertex. This 
		/// functioncan be used, for example, to texture-map terrain using sea level as a reference plane (defined by p1, p2, p3, 
		/// andp4). The altitude of a terrain vertex is computed by the <see cref="Gl.OBJECT_LINEAR"/> coordinate generation 
		/// functionas its distance from sea level; that altitude can then be used to index the texture image to map white snow onto 
		/// peaksand green grass onto foothills. 
		/// If the texture generation function is <see cref="Gl.EYE_LINEAR"/>, the function 
		/// g=p1″×xe+p2″×ye+p3″×ze+p4″×we 
		/// is used, where 
		/// p1″⁢p2″⁢p3″⁢p4″=p1⁢p2⁢p3⁢p4⁢M-1 
		/// and xe, ye, ze, and we are the eye coordinates of the vertex, p1, p2, p3, and p4 are the values supplied in <paramref 
		/// name="params"/>,and M is the modelview matrix when <see cref="Gl.TexGen"/> is invoked. If M is poorly conditioned or 
		/// singular,texture coordinates generated by the resulting function may be inaccurate or undefined. 
		/// Note that the values in <paramref name="params"/> define a reference plane in eye coordinates. The modelview matrix that 
		/// isapplied to them may not be the same one in effect when the polygon vertices are transformed. This function establishes 
		/// afield of texture coordinates that can produce dynamic contour lines on moving objects. 
		/// If the texture generation function is <see cref="Gl.SPHERE_MAP"/> and <paramref name="coord"/> is either <see 
		/// cref="Gl.S"/>or <see cref="Gl.T"/>, s and t texture coordinates are generated as follows. Let u be the unit vector 
		/// pointingfrom the origin to the polygon vertex (in eye coordinates). Let n sup prime be the current normal, after 
		/// transformationto eye coordinates. Let 
		/// f=fx⁢fy⁢fzT be the reflection vector such that 
		/// f=u-2⁢n″⁢n″T⁢u 
		/// Finally, let m=2⁢fx2+fy2+fz+12. Then the values assigned to the s and t texture coordinates are 
		/// s=fxm+12 
		/// t=fym+12 
		/// To enable or disable a texture-coordinate generation function, call Gl.Enable or Gl.Disable with one of the symbolic 
		/// texture-coordinatenames (<see cref="Gl.TEXTURE_GEN_S"/>, <see cref="Gl.TEXTURE_GEN_T"/>, <see cref="Gl.TEXTURE_GEN_R"/>, 
		/// or<see cref="Gl.TEXTURE_GEN_Q"/>) as the argument. When enabled, the specified texture coordinate is computed according 
		/// tothe generating function associated with that coordinate. When disabled, subsequent vertices take the specified texture 
		/// coordinatefrom the current set of texture coordinates. Initially, all texture generation functions are set to <see 
		/// cref="Gl.EYE_LINEAR"/>and are disabled. Both s plane equations are (1, 0, 0, 0), both t plane equations are (0, 1, 0, 
		/// 0),and all r and q plane equations are (0, 0, 0, 0). 
		/// When the ARB_multitexture extension is supported, <see cref="Gl.TexGen"/> sets the texture generation parameters for the 
		/// currentlyactive texture unit, selected with Gl.ActiveTexture. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted 
		///   definedvalue, or when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/> and <paramref name="params"/> is not 
		///   anaccepted defined value. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, <paramref 
		///   name="params"/>is <see cref="Gl.SPHERE_MAP"/>, and <paramref name="coord"/> is either <see cref="Gl.R"/> or <see 
		///   cref="Gl.Q"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexGen"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexGen 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_S"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_T"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_R"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_Q"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, float param)
		{
			Debug.Assert(Delegates.pglTexGenf != null, "pglTexGenf not implemented");
			Delegates.pglTexGenf((int)coord, (int)pname, param);
			CallLog("glTexGenf({0}, {1}, {2})", coord, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.TexGen"/> selects a texture-coordinate generation function or supplies coefficients for one of the 
		/// functions.<paramref name="coord"/> names one of the (s, t, r, q) texture coordinates; it must be one of the symbols <see 
		/// cref="Gl.S"/>,<see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see cref="Gl.Q"/>. <paramref name="pname"/> must be one of 
		/// threesymbolic constants: <see cref="Gl.TEXTURE_GEN_MODE"/>, <see cref="Gl.OBJECT_PLANE"/>, or <see 
		/// cref="Gl.EYE_PLANE"/>.If <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, then <paramref name="params"/> 
		/// choosesa mode, one of <see cref="Gl.OBJECT_LINEAR"/>, <see cref="Gl.EYE_LINEAR"/>, <see cref="Gl.SPHERE_MAP"/>, <see 
		/// cref="Gl.NORMAL_MAP"/>,or <see cref="Gl.REFLECTION_MAP"/>. If <paramref name="pname"/> is either <see 
		/// cref="Gl.OBJECT_PLANE"/>or <see cref="Gl.EYE_PLANE"/>, <paramref name="params"/> contains coefficients for the 
		/// correspondingtexture generation function. 
		/// If the texture generation function is <see cref="Gl.OBJECT_LINEAR"/>, the function 
		/// g=p1×xo+p2×yo+p3×zo+p4×wo 
		/// is used, where g is the value computed for the coordinate named in <paramref name="coord"/>, p1, p2, p3, and p4 are the 
		/// fourvalues supplied in <paramref name="params"/>, and xo, yo, zo, and wo are the object coordinates of the vertex. This 
		/// functioncan be used, for example, to texture-map terrain using sea level as a reference plane (defined by p1, p2, p3, 
		/// andp4). The altitude of a terrain vertex is computed by the <see cref="Gl.OBJECT_LINEAR"/> coordinate generation 
		/// functionas its distance from sea level; that altitude can then be used to index the texture image to map white snow onto 
		/// peaksand green grass onto foothills. 
		/// If the texture generation function is <see cref="Gl.EYE_LINEAR"/>, the function 
		/// g=p1″×xe+p2″×ye+p3″×ze+p4″×we 
		/// is used, where 
		/// p1″⁢p2″⁢p3″⁢p4″=p1⁢p2⁢p3⁢p4⁢M-1 
		/// and xe, ye, ze, and we are the eye coordinates of the vertex, p1, p2, p3, and p4 are the values supplied in <paramref 
		/// name="params"/>,and M is the modelview matrix when <see cref="Gl.TexGen"/> is invoked. If M is poorly conditioned or 
		/// singular,texture coordinates generated by the resulting function may be inaccurate or undefined. 
		/// Note that the values in <paramref name="params"/> define a reference plane in eye coordinates. The modelview matrix that 
		/// isapplied to them may not be the same one in effect when the polygon vertices are transformed. This function establishes 
		/// afield of texture coordinates that can produce dynamic contour lines on moving objects. 
		/// If the texture generation function is <see cref="Gl.SPHERE_MAP"/> and <paramref name="coord"/> is either <see 
		/// cref="Gl.S"/>or <see cref="Gl.T"/>, s and t texture coordinates are generated as follows. Let u be the unit vector 
		/// pointingfrom the origin to the polygon vertex (in eye coordinates). Let n sup prime be the current normal, after 
		/// transformationto eye coordinates. Let 
		/// f=fx⁢fy⁢fzT be the reflection vector such that 
		/// f=u-2⁢n″⁢n″T⁢u 
		/// Finally, let m=2⁢fx2+fy2+fz+12. Then the values assigned to the s and t texture coordinates are 
		/// s=fxm+12 
		/// t=fym+12 
		/// To enable or disable a texture-coordinate generation function, call Gl.Enable or Gl.Disable with one of the symbolic 
		/// texture-coordinatenames (<see cref="Gl.TEXTURE_GEN_S"/>, <see cref="Gl.TEXTURE_GEN_T"/>, <see cref="Gl.TEXTURE_GEN_R"/>, 
		/// or<see cref="Gl.TEXTURE_GEN_Q"/>) as the argument. When enabled, the specified texture coordinate is computed according 
		/// tothe generating function associated with that coordinate. When disabled, subsequent vertices take the specified texture 
		/// coordinatefrom the current set of texture coordinates. Initially, all texture generation functions are set to <see 
		/// cref="Gl.EYE_LINEAR"/>and are disabled. Both s plane equations are (1, 0, 0, 0), both t plane equations are (0, 1, 0, 
		/// 0),and all r and q plane equations are (0, 0, 0, 0). 
		/// When the ARB_multitexture extension is supported, <see cref="Gl.TexGen"/> sets the texture generation parameters for the 
		/// currentlyactive texture unit, selected with Gl.ActiveTexture. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted 
		///   definedvalue, or when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/> and <paramref name="params"/> is not 
		///   anaccepted defined value. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, <paramref 
		///   name="params"/>is <see cref="Gl.SPHERE_MAP"/>, and <paramref name="coord"/> is either <see cref="Gl.R"/> or <see 
		///   cref="Gl.Q"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexGen"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexGen 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_S"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_T"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_R"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_Q"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexGen(int coord, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGenfv != null, "pglTexGenfv not implemented");
					Delegates.pglTexGenfv(coord, pname, p_params);
					CallLog("glTexGenfv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.TexGen"/> selects a texture-coordinate generation function or supplies coefficients for one of the 
		/// functions.<paramref name="coord"/> names one of the (s, t, r, q) texture coordinates; it must be one of the symbols <see 
		/// cref="Gl.S"/>,<see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see cref="Gl.Q"/>. <paramref name="pname"/> must be one of 
		/// threesymbolic constants: <see cref="Gl.TEXTURE_GEN_MODE"/>, <see cref="Gl.OBJECT_PLANE"/>, or <see 
		/// cref="Gl.EYE_PLANE"/>.If <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, then <paramref name="params"/> 
		/// choosesa mode, one of <see cref="Gl.OBJECT_LINEAR"/>, <see cref="Gl.EYE_LINEAR"/>, <see cref="Gl.SPHERE_MAP"/>, <see 
		/// cref="Gl.NORMAL_MAP"/>,or <see cref="Gl.REFLECTION_MAP"/>. If <paramref name="pname"/> is either <see 
		/// cref="Gl.OBJECT_PLANE"/>or <see cref="Gl.EYE_PLANE"/>, <paramref name="params"/> contains coefficients for the 
		/// correspondingtexture generation function. 
		/// If the texture generation function is <see cref="Gl.OBJECT_LINEAR"/>, the function 
		/// g=p1×xo+p2×yo+p3×zo+p4×wo 
		/// is used, where g is the value computed for the coordinate named in <paramref name="coord"/>, p1, p2, p3, and p4 are the 
		/// fourvalues supplied in <paramref name="params"/>, and xo, yo, zo, and wo are the object coordinates of the vertex. This 
		/// functioncan be used, for example, to texture-map terrain using sea level as a reference plane (defined by p1, p2, p3, 
		/// andp4). The altitude of a terrain vertex is computed by the <see cref="Gl.OBJECT_LINEAR"/> coordinate generation 
		/// functionas its distance from sea level; that altitude can then be used to index the texture image to map white snow onto 
		/// peaksand green grass onto foothills. 
		/// If the texture generation function is <see cref="Gl.EYE_LINEAR"/>, the function 
		/// g=p1″×xe+p2″×ye+p3″×ze+p4″×we 
		/// is used, where 
		/// p1″⁢p2″⁢p3″⁢p4″=p1⁢p2⁢p3⁢p4⁢M-1 
		/// and xe, ye, ze, and we are the eye coordinates of the vertex, p1, p2, p3, and p4 are the values supplied in <paramref 
		/// name="params"/>,and M is the modelview matrix when <see cref="Gl.TexGen"/> is invoked. If M is poorly conditioned or 
		/// singular,texture coordinates generated by the resulting function may be inaccurate or undefined. 
		/// Note that the values in <paramref name="params"/> define a reference plane in eye coordinates. The modelview matrix that 
		/// isapplied to them may not be the same one in effect when the polygon vertices are transformed. This function establishes 
		/// afield of texture coordinates that can produce dynamic contour lines on moving objects. 
		/// If the texture generation function is <see cref="Gl.SPHERE_MAP"/> and <paramref name="coord"/> is either <see 
		/// cref="Gl.S"/>or <see cref="Gl.T"/>, s and t texture coordinates are generated as follows. Let u be the unit vector 
		/// pointingfrom the origin to the polygon vertex (in eye coordinates). Let n sup prime be the current normal, after 
		/// transformationto eye coordinates. Let 
		/// f=fx⁢fy⁢fzT be the reflection vector such that 
		/// f=u-2⁢n″⁢n″T⁢u 
		/// Finally, let m=2⁢fx2+fy2+fz+12. Then the values assigned to the s and t texture coordinates are 
		/// s=fxm+12 
		/// t=fym+12 
		/// To enable or disable a texture-coordinate generation function, call Gl.Enable or Gl.Disable with one of the symbolic 
		/// texture-coordinatenames (<see cref="Gl.TEXTURE_GEN_S"/>, <see cref="Gl.TEXTURE_GEN_T"/>, <see cref="Gl.TEXTURE_GEN_R"/>, 
		/// or<see cref="Gl.TEXTURE_GEN_Q"/>) as the argument. When enabled, the specified texture coordinate is computed according 
		/// tothe generating function associated with that coordinate. When disabled, subsequent vertices take the specified texture 
		/// coordinatefrom the current set of texture coordinates. Initially, all texture generation functions are set to <see 
		/// cref="Gl.EYE_LINEAR"/>and are disabled. Both s plane equations are (1, 0, 0, 0), both t plane equations are (0, 1, 0, 
		/// 0),and all r and q plane equations are (0, 0, 0, 0). 
		/// When the ARB_multitexture extension is supported, <see cref="Gl.TexGen"/> sets the texture generation parameters for the 
		/// currentlyactive texture unit, selected with Gl.ActiveTexture. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted 
		///   definedvalue, or when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/> and <paramref name="params"/> is not 
		///   anaccepted defined value. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, <paramref 
		///   name="params"/>is <see cref="Gl.SPHERE_MAP"/>, and <paramref name="coord"/> is either <see cref="Gl.R"/> or <see 
		///   cref="Gl.Q"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexGen"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexGen 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_S"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_T"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_R"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_Q"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGenfv != null, "pglTexGenfv not implemented");
					Delegates.pglTexGenfv((int)coord, (int)pname, p_params);
					CallLog("glTexGenfv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>. 
		/// </param>
		/// <param name="param">
		/// Specifies a single-valued texture generation parameter, one of <see cref="Gl.OBJECT_LINEAR"/>, <see 
		/// cref="Gl.EYE_LINEAR"/>,<see cref="Gl.SPHERE_MAP"/>, <see cref="Gl.NORMAL_MAP"/>, or <see cref="Gl.REFLECTION_MAP"/>. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.TexGen"/> selects a texture-coordinate generation function or supplies coefficients for one of the 
		/// functions.<paramref name="coord"/> names one of the (s, t, r, q) texture coordinates; it must be one of the symbols <see 
		/// cref="Gl.S"/>,<see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see cref="Gl.Q"/>. <paramref name="pname"/> must be one of 
		/// threesymbolic constants: <see cref="Gl.TEXTURE_GEN_MODE"/>, <see cref="Gl.OBJECT_PLANE"/>, or <see 
		/// cref="Gl.EYE_PLANE"/>.If <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, then <paramref name="params"/> 
		/// choosesa mode, one of <see cref="Gl.OBJECT_LINEAR"/>, <see cref="Gl.EYE_LINEAR"/>, <see cref="Gl.SPHERE_MAP"/>, <see 
		/// cref="Gl.NORMAL_MAP"/>,or <see cref="Gl.REFLECTION_MAP"/>. If <paramref name="pname"/> is either <see 
		/// cref="Gl.OBJECT_PLANE"/>or <see cref="Gl.EYE_PLANE"/>, <paramref name="params"/> contains coefficients for the 
		/// correspondingtexture generation function. 
		/// If the texture generation function is <see cref="Gl.OBJECT_LINEAR"/>, the function 
		/// g=p1×xo+p2×yo+p3×zo+p4×wo 
		/// is used, where g is the value computed for the coordinate named in <paramref name="coord"/>, p1, p2, p3, and p4 are the 
		/// fourvalues supplied in <paramref name="params"/>, and xo, yo, zo, and wo are the object coordinates of the vertex. This 
		/// functioncan be used, for example, to texture-map terrain using sea level as a reference plane (defined by p1, p2, p3, 
		/// andp4). The altitude of a terrain vertex is computed by the <see cref="Gl.OBJECT_LINEAR"/> coordinate generation 
		/// functionas its distance from sea level; that altitude can then be used to index the texture image to map white snow onto 
		/// peaksand green grass onto foothills. 
		/// If the texture generation function is <see cref="Gl.EYE_LINEAR"/>, the function 
		/// g=p1″×xe+p2″×ye+p3″×ze+p4″×we 
		/// is used, where 
		/// p1″⁢p2″⁢p3″⁢p4″=p1⁢p2⁢p3⁢p4⁢M-1 
		/// and xe, ye, ze, and we are the eye coordinates of the vertex, p1, p2, p3, and p4 are the values supplied in <paramref 
		/// name="params"/>,and M is the modelview matrix when <see cref="Gl.TexGen"/> is invoked. If M is poorly conditioned or 
		/// singular,texture coordinates generated by the resulting function may be inaccurate or undefined. 
		/// Note that the values in <paramref name="params"/> define a reference plane in eye coordinates. The modelview matrix that 
		/// isapplied to them may not be the same one in effect when the polygon vertices are transformed. This function establishes 
		/// afield of texture coordinates that can produce dynamic contour lines on moving objects. 
		/// If the texture generation function is <see cref="Gl.SPHERE_MAP"/> and <paramref name="coord"/> is either <see 
		/// cref="Gl.S"/>or <see cref="Gl.T"/>, s and t texture coordinates are generated as follows. Let u be the unit vector 
		/// pointingfrom the origin to the polygon vertex (in eye coordinates). Let n sup prime be the current normal, after 
		/// transformationto eye coordinates. Let 
		/// f=fx⁢fy⁢fzT be the reflection vector such that 
		/// f=u-2⁢n″⁢n″T⁢u 
		/// Finally, let m=2⁢fx2+fy2+fz+12. Then the values assigned to the s and t texture coordinates are 
		/// s=fxm+12 
		/// t=fym+12 
		/// To enable or disable a texture-coordinate generation function, call Gl.Enable or Gl.Disable with one of the symbolic 
		/// texture-coordinatenames (<see cref="Gl.TEXTURE_GEN_S"/>, <see cref="Gl.TEXTURE_GEN_T"/>, <see cref="Gl.TEXTURE_GEN_R"/>, 
		/// or<see cref="Gl.TEXTURE_GEN_Q"/>) as the argument. When enabled, the specified texture coordinate is computed according 
		/// tothe generating function associated with that coordinate. When disabled, subsequent vertices take the specified texture 
		/// coordinatefrom the current set of texture coordinates. Initially, all texture generation functions are set to <see 
		/// cref="Gl.EYE_LINEAR"/>and are disabled. Both s plane equations are (1, 0, 0, 0), both t plane equations are (0, 1, 0, 
		/// 0),and all r and q plane equations are (0, 0, 0, 0). 
		/// When the ARB_multitexture extension is supported, <see cref="Gl.TexGen"/> sets the texture generation parameters for the 
		/// currentlyactive texture unit, selected with Gl.ActiveTexture. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted 
		///   definedvalue, or when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/> and <paramref name="params"/> is not 
		///   anaccepted defined value. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, <paramref 
		///   name="params"/>is <see cref="Gl.SPHERE_MAP"/>, and <paramref name="coord"/> is either <see cref="Gl.R"/> or <see 
		///   cref="Gl.Q"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexGen"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexGen 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_S"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_T"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_R"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_Q"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexGen(int coord, int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexGeni != null, "pglTexGeni not implemented");
			Delegates.pglTexGeni(coord, pname, param);
			CallLog("glTexGeni({0}, {1}, {2})", coord, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>. 
		/// </param>
		/// <param name="param">
		/// Specifies a single-valued texture generation parameter, one of <see cref="Gl.OBJECT_LINEAR"/>, <see 
		/// cref="Gl.EYE_LINEAR"/>,<see cref="Gl.SPHERE_MAP"/>, <see cref="Gl.NORMAL_MAP"/>, or <see cref="Gl.REFLECTION_MAP"/>. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.TexGen"/> selects a texture-coordinate generation function or supplies coefficients for one of the 
		/// functions.<paramref name="coord"/> names one of the (s, t, r, q) texture coordinates; it must be one of the symbols <see 
		/// cref="Gl.S"/>,<see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see cref="Gl.Q"/>. <paramref name="pname"/> must be one of 
		/// threesymbolic constants: <see cref="Gl.TEXTURE_GEN_MODE"/>, <see cref="Gl.OBJECT_PLANE"/>, or <see 
		/// cref="Gl.EYE_PLANE"/>.If <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, then <paramref name="params"/> 
		/// choosesa mode, one of <see cref="Gl.OBJECT_LINEAR"/>, <see cref="Gl.EYE_LINEAR"/>, <see cref="Gl.SPHERE_MAP"/>, <see 
		/// cref="Gl.NORMAL_MAP"/>,or <see cref="Gl.REFLECTION_MAP"/>. If <paramref name="pname"/> is either <see 
		/// cref="Gl.OBJECT_PLANE"/>or <see cref="Gl.EYE_PLANE"/>, <paramref name="params"/> contains coefficients for the 
		/// correspondingtexture generation function. 
		/// If the texture generation function is <see cref="Gl.OBJECT_LINEAR"/>, the function 
		/// g=p1×xo+p2×yo+p3×zo+p4×wo 
		/// is used, where g is the value computed for the coordinate named in <paramref name="coord"/>, p1, p2, p3, and p4 are the 
		/// fourvalues supplied in <paramref name="params"/>, and xo, yo, zo, and wo are the object coordinates of the vertex. This 
		/// functioncan be used, for example, to texture-map terrain using sea level as a reference plane (defined by p1, p2, p3, 
		/// andp4). The altitude of a terrain vertex is computed by the <see cref="Gl.OBJECT_LINEAR"/> coordinate generation 
		/// functionas its distance from sea level; that altitude can then be used to index the texture image to map white snow onto 
		/// peaksand green grass onto foothills. 
		/// If the texture generation function is <see cref="Gl.EYE_LINEAR"/>, the function 
		/// g=p1″×xe+p2″×ye+p3″×ze+p4″×we 
		/// is used, where 
		/// p1″⁢p2″⁢p3″⁢p4″=p1⁢p2⁢p3⁢p4⁢M-1 
		/// and xe, ye, ze, and we are the eye coordinates of the vertex, p1, p2, p3, and p4 are the values supplied in <paramref 
		/// name="params"/>,and M is the modelview matrix when <see cref="Gl.TexGen"/> is invoked. If M is poorly conditioned or 
		/// singular,texture coordinates generated by the resulting function may be inaccurate or undefined. 
		/// Note that the values in <paramref name="params"/> define a reference plane in eye coordinates. The modelview matrix that 
		/// isapplied to them may not be the same one in effect when the polygon vertices are transformed. This function establishes 
		/// afield of texture coordinates that can produce dynamic contour lines on moving objects. 
		/// If the texture generation function is <see cref="Gl.SPHERE_MAP"/> and <paramref name="coord"/> is either <see 
		/// cref="Gl.S"/>or <see cref="Gl.T"/>, s and t texture coordinates are generated as follows. Let u be the unit vector 
		/// pointingfrom the origin to the polygon vertex (in eye coordinates). Let n sup prime be the current normal, after 
		/// transformationto eye coordinates. Let 
		/// f=fx⁢fy⁢fzT be the reflection vector such that 
		/// f=u-2⁢n″⁢n″T⁢u 
		/// Finally, let m=2⁢fx2+fy2+fz+12. Then the values assigned to the s and t texture coordinates are 
		/// s=fxm+12 
		/// t=fym+12 
		/// To enable or disable a texture-coordinate generation function, call Gl.Enable or Gl.Disable with one of the symbolic 
		/// texture-coordinatenames (<see cref="Gl.TEXTURE_GEN_S"/>, <see cref="Gl.TEXTURE_GEN_T"/>, <see cref="Gl.TEXTURE_GEN_R"/>, 
		/// or<see cref="Gl.TEXTURE_GEN_Q"/>) as the argument. When enabled, the specified texture coordinate is computed according 
		/// tothe generating function associated with that coordinate. When disabled, subsequent vertices take the specified texture 
		/// coordinatefrom the current set of texture coordinates. Initially, all texture generation functions are set to <see 
		/// cref="Gl.EYE_LINEAR"/>and are disabled. Both s plane equations are (1, 0, 0, 0), both t plane equations are (0, 1, 0, 
		/// 0),and all r and q plane equations are (0, 0, 0, 0). 
		/// When the ARB_multitexture extension is supported, <see cref="Gl.TexGen"/> sets the texture generation parameters for the 
		/// currentlyactive texture unit, selected with Gl.ActiveTexture. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted 
		///   definedvalue, or when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/> and <paramref name="params"/> is not 
		///   anaccepted defined value. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, <paramref 
		///   name="params"/>is <see cref="Gl.SPHERE_MAP"/>, and <paramref name="coord"/> is either <see cref="Gl.R"/> or <see 
		///   cref="Gl.Q"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexGen"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexGen 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_S"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_T"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_R"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_Q"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexGeni != null, "pglTexGeni not implemented");
			Delegates.pglTexGeni((int)coord, (int)pname, param);
			CallLog("glTexGeni({0}, {1}, {2})", coord, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.TexGen"/> selects a texture-coordinate generation function or supplies coefficients for one of the 
		/// functions.<paramref name="coord"/> names one of the (s, t, r, q) texture coordinates; it must be one of the symbols <see 
		/// cref="Gl.S"/>,<see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see cref="Gl.Q"/>. <paramref name="pname"/> must be one of 
		/// threesymbolic constants: <see cref="Gl.TEXTURE_GEN_MODE"/>, <see cref="Gl.OBJECT_PLANE"/>, or <see 
		/// cref="Gl.EYE_PLANE"/>.If <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, then <paramref name="params"/> 
		/// choosesa mode, one of <see cref="Gl.OBJECT_LINEAR"/>, <see cref="Gl.EYE_LINEAR"/>, <see cref="Gl.SPHERE_MAP"/>, <see 
		/// cref="Gl.NORMAL_MAP"/>,or <see cref="Gl.REFLECTION_MAP"/>. If <paramref name="pname"/> is either <see 
		/// cref="Gl.OBJECT_PLANE"/>or <see cref="Gl.EYE_PLANE"/>, <paramref name="params"/> contains coefficients for the 
		/// correspondingtexture generation function. 
		/// If the texture generation function is <see cref="Gl.OBJECT_LINEAR"/>, the function 
		/// g=p1×xo+p2×yo+p3×zo+p4×wo 
		/// is used, where g is the value computed for the coordinate named in <paramref name="coord"/>, p1, p2, p3, and p4 are the 
		/// fourvalues supplied in <paramref name="params"/>, and xo, yo, zo, and wo are the object coordinates of the vertex. This 
		/// functioncan be used, for example, to texture-map terrain using sea level as a reference plane (defined by p1, p2, p3, 
		/// andp4). The altitude of a terrain vertex is computed by the <see cref="Gl.OBJECT_LINEAR"/> coordinate generation 
		/// functionas its distance from sea level; that altitude can then be used to index the texture image to map white snow onto 
		/// peaksand green grass onto foothills. 
		/// If the texture generation function is <see cref="Gl.EYE_LINEAR"/>, the function 
		/// g=p1″×xe+p2″×ye+p3″×ze+p4″×we 
		/// is used, where 
		/// p1″⁢p2″⁢p3″⁢p4″=p1⁢p2⁢p3⁢p4⁢M-1 
		/// and xe, ye, ze, and we are the eye coordinates of the vertex, p1, p2, p3, and p4 are the values supplied in <paramref 
		/// name="params"/>,and M is the modelview matrix when <see cref="Gl.TexGen"/> is invoked. If M is poorly conditioned or 
		/// singular,texture coordinates generated by the resulting function may be inaccurate or undefined. 
		/// Note that the values in <paramref name="params"/> define a reference plane in eye coordinates. The modelview matrix that 
		/// isapplied to them may not be the same one in effect when the polygon vertices are transformed. This function establishes 
		/// afield of texture coordinates that can produce dynamic contour lines on moving objects. 
		/// If the texture generation function is <see cref="Gl.SPHERE_MAP"/> and <paramref name="coord"/> is either <see 
		/// cref="Gl.S"/>or <see cref="Gl.T"/>, s and t texture coordinates are generated as follows. Let u be the unit vector 
		/// pointingfrom the origin to the polygon vertex (in eye coordinates). Let n sup prime be the current normal, after 
		/// transformationto eye coordinates. Let 
		/// f=fx⁢fy⁢fzT be the reflection vector such that 
		/// f=u-2⁢n″⁢n″T⁢u 
		/// Finally, let m=2⁢fx2+fy2+fz+12. Then the values assigned to the s and t texture coordinates are 
		/// s=fxm+12 
		/// t=fym+12 
		/// To enable or disable a texture-coordinate generation function, call Gl.Enable or Gl.Disable with one of the symbolic 
		/// texture-coordinatenames (<see cref="Gl.TEXTURE_GEN_S"/>, <see cref="Gl.TEXTURE_GEN_T"/>, <see cref="Gl.TEXTURE_GEN_R"/>, 
		/// or<see cref="Gl.TEXTURE_GEN_Q"/>) as the argument. When enabled, the specified texture coordinate is computed according 
		/// tothe generating function associated with that coordinate. When disabled, subsequent vertices take the specified texture 
		/// coordinatefrom the current set of texture coordinates. Initially, all texture generation functions are set to <see 
		/// cref="Gl.EYE_LINEAR"/>and are disabled. Both s plane equations are (1, 0, 0, 0), both t plane equations are (0, 1, 0, 
		/// 0),and all r and q plane equations are (0, 0, 0, 0). 
		/// When the ARB_multitexture extension is supported, <see cref="Gl.TexGen"/> sets the texture generation parameters for the 
		/// currentlyactive texture unit, selected with Gl.ActiveTexture. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted 
		///   definedvalue, or when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/> and <paramref name="params"/> is not 
		///   anaccepted defined value. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, <paramref 
		///   name="params"/>is <see cref="Gl.SPHERE_MAP"/>, and <paramref name="coord"/> is either <see cref="Gl.R"/> or <see 
		///   cref="Gl.Q"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexGen"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexGen 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_S"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_T"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_R"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_Q"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexGen(int coord, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGeniv != null, "pglTexGeniv not implemented");
					Delegates.pglTexGeniv(coord, pname, p_params);
					CallLog("glTexGeniv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.TexGen"/> selects a texture-coordinate generation function or supplies coefficients for one of the 
		/// functions.<paramref name="coord"/> names one of the (s, t, r, q) texture coordinates; it must be one of the symbols <see 
		/// cref="Gl.S"/>,<see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see cref="Gl.Q"/>. <paramref name="pname"/> must be one of 
		/// threesymbolic constants: <see cref="Gl.TEXTURE_GEN_MODE"/>, <see cref="Gl.OBJECT_PLANE"/>, or <see 
		/// cref="Gl.EYE_PLANE"/>.If <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, then <paramref name="params"/> 
		/// choosesa mode, one of <see cref="Gl.OBJECT_LINEAR"/>, <see cref="Gl.EYE_LINEAR"/>, <see cref="Gl.SPHERE_MAP"/>, <see 
		/// cref="Gl.NORMAL_MAP"/>,or <see cref="Gl.REFLECTION_MAP"/>. If <paramref name="pname"/> is either <see 
		/// cref="Gl.OBJECT_PLANE"/>or <see cref="Gl.EYE_PLANE"/>, <paramref name="params"/> contains coefficients for the 
		/// correspondingtexture generation function. 
		/// If the texture generation function is <see cref="Gl.OBJECT_LINEAR"/>, the function 
		/// g=p1×xo+p2×yo+p3×zo+p4×wo 
		/// is used, where g is the value computed for the coordinate named in <paramref name="coord"/>, p1, p2, p3, and p4 are the 
		/// fourvalues supplied in <paramref name="params"/>, and xo, yo, zo, and wo are the object coordinates of the vertex. This 
		/// functioncan be used, for example, to texture-map terrain using sea level as a reference plane (defined by p1, p2, p3, 
		/// andp4). The altitude of a terrain vertex is computed by the <see cref="Gl.OBJECT_LINEAR"/> coordinate generation 
		/// functionas its distance from sea level; that altitude can then be used to index the texture image to map white snow onto 
		/// peaksand green grass onto foothills. 
		/// If the texture generation function is <see cref="Gl.EYE_LINEAR"/>, the function 
		/// g=p1″×xe+p2″×ye+p3″×ze+p4″×we 
		/// is used, where 
		/// p1″⁢p2″⁢p3″⁢p4″=p1⁢p2⁢p3⁢p4⁢M-1 
		/// and xe, ye, ze, and we are the eye coordinates of the vertex, p1, p2, p3, and p4 are the values supplied in <paramref 
		/// name="params"/>,and M is the modelview matrix when <see cref="Gl.TexGen"/> is invoked. If M is poorly conditioned or 
		/// singular,texture coordinates generated by the resulting function may be inaccurate or undefined. 
		/// Note that the values in <paramref name="params"/> define a reference plane in eye coordinates. The modelview matrix that 
		/// isapplied to them may not be the same one in effect when the polygon vertices are transformed. This function establishes 
		/// afield of texture coordinates that can produce dynamic contour lines on moving objects. 
		/// If the texture generation function is <see cref="Gl.SPHERE_MAP"/> and <paramref name="coord"/> is either <see 
		/// cref="Gl.S"/>or <see cref="Gl.T"/>, s and t texture coordinates are generated as follows. Let u be the unit vector 
		/// pointingfrom the origin to the polygon vertex (in eye coordinates). Let n sup prime be the current normal, after 
		/// transformationto eye coordinates. Let 
		/// f=fx⁢fy⁢fzT be the reflection vector such that 
		/// f=u-2⁢n″⁢n″T⁢u 
		/// Finally, let m=2⁢fx2+fy2+fz+12. Then the values assigned to the s and t texture coordinates are 
		/// s=fxm+12 
		/// t=fym+12 
		/// To enable or disable a texture-coordinate generation function, call Gl.Enable or Gl.Disable with one of the symbolic 
		/// texture-coordinatenames (<see cref="Gl.TEXTURE_GEN_S"/>, <see cref="Gl.TEXTURE_GEN_T"/>, <see cref="Gl.TEXTURE_GEN_R"/>, 
		/// or<see cref="Gl.TEXTURE_GEN_Q"/>) as the argument. When enabled, the specified texture coordinate is computed according 
		/// tothe generating function associated with that coordinate. When disabled, subsequent vertices take the specified texture 
		/// coordinatefrom the current set of texture coordinates. Initially, all texture generation functions are set to <see 
		/// cref="Gl.EYE_LINEAR"/>and are disabled. Both s plane equations are (1, 0, 0, 0), both t plane equations are (0, 1, 0, 
		/// 0),and all r and q plane equations are (0, 0, 0, 0). 
		/// When the ARB_multitexture extension is supported, <see cref="Gl.TexGen"/> sets the texture generation parameters for the 
		/// currentlyactive texture unit, selected with Gl.ActiveTexture. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted 
		///   definedvalue, or when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/> and <paramref name="params"/> is not 
		///   anaccepted defined value. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated when <paramref name="pname"/> is <see cref="Gl.TEXTURE_GEN_MODE"/>, <paramref 
		///   name="params"/>is <see cref="Gl.SPHERE_MAP"/>, and <paramref name="coord"/> is either <see cref="Gl.R"/> or <see 
		///   cref="Gl.Q"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.TexGen"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetTexGen 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_S"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_T"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_R"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_GEN_Q"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGeniv != null, "pglTexGeniv not implemented");
					Delegates.pglTexGeniv((int)coord, (int)pname, p_params);
					CallLog("glTexGeniv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFeedbackBuffer.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void FeedbackBuffer(Int32 size, int type, float[] buffer)
		{
			unsafe {
				fixed (float* p_buffer = buffer)
				{
					Debug.Assert(Delegates.pglFeedbackBuffer != null, "pglFeedbackBuffer not implemented");
					Delegates.pglFeedbackBuffer(size, type, p_buffer);
					CallLog("glFeedbackBuffer({0}, {1}, {2})", size, type, buffer);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFeedbackBuffer.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void FeedbackBuffer(Int32 size, FeedbackType type, float[] buffer)
		{
			unsafe {
				fixed (float* p_buffer = buffer)
				{
					Debug.Assert(Delegates.pglFeedbackBuffer != null, "pglFeedbackBuffer not implemented");
					Delegates.pglFeedbackBuffer(size, (int)type, p_buffer);
					CallLog("glFeedbackBuffer({0}, {1}, {2})", size, type, buffer);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSelectBuffer.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void SelectBuffer(Int32 size, UInt32[] buffer)
		{
			unsafe {
				fixed (UInt32* p_buffer = buffer)
				{
					Debug.Assert(Delegates.pglSelectBuffer != null, "pglSelectBuffer not implemented");
					Delegates.pglSelectBuffer(size, p_buffer);
					CallLog("glSelectBuffer({0}, {1})", size, buffer);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRenderMode.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static Int32 RenderMode(int mode)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglRenderMode != null, "pglRenderMode not implemented");
			retValue = Delegates.pglRenderMode(mode);
			CallLog("glRenderMode({0}) = {1}", mode, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glRenderMode.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static Int32 RenderMode(RenderingMode mode)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglRenderMode != null, "pglRenderMode not implemented");
			retValue = Delegates.pglRenderMode((int)mode);
			CallLog("glRenderMode({0}) = {1}", mode, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glInitNames.
		/// </summary>
		/// <remarks>
		/// </remarks>
		public static void InitName()
		{
			Debug.Assert(Delegates.pglInitNames != null, "pglInitNames not implemented");
			Delegates.pglInitNames();
			CallLog("glInitNames()");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLoadName.
		/// </summary>
		/// <param name="name">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void LoadName(UInt32 name)
		{
			Debug.Assert(Delegates.pglLoadName != null, "pglLoadName not implemented");
			Delegates.pglLoadName(name);
			CallLog("glLoadName({0})", name);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPassThrough.
		/// </summary>
		/// <param name="token">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void PassThrough(float token)
		{
			Debug.Assert(Delegates.pglPassThrough != null, "pglPassThrough not implemented");
			Delegates.pglPassThrough(token);
			CallLog("glPassThrough({0})", token);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPopName.
		/// </summary>
		/// <remarks>
		/// </remarks>
		public static void PopName()
		{
			Debug.Assert(Delegates.pglPopName != null, "pglPopName not implemented");
			Delegates.pglPopName();
			CallLog("glPopName()");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPushName.
		/// </summary>
		/// <param name="name">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void PushName(UInt32 name)
		{
			Debug.Assert(Delegates.pglPushName != null, "pglPushName not implemented");
			Delegates.pglPushName(name);
			CallLog("glPushName({0})", name);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glClearAccum.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ClearAccum(float red, float green, float blue, float alpha)
		{
			Debug.Assert(Delegates.pglClearAccum != null, "pglClearAccum not implemented");
			Delegates.pglClearAccum(red, green, blue, alpha);
			CallLog("glClearAccum({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glClearIndex.
		/// </summary>
		/// <param name="c">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void ClearIndex(float c)
		{
			Debug.Assert(Delegates.pglClearIndex != null, "pglClearIndex not implemented");
			Delegates.pglClearIndex(c);
			CallLog("glClearIndex({0})", c);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIndexMask.
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void IndexMask(UInt32 mask)
		{
			Debug.Assert(Delegates.pglIndexMask != null, "pglIndexMask not implemented");
			Delegates.pglIndexMask(mask);
			CallLog("glIndexMask({0})", mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glAccum.
		/// </summary>
		/// <param name="op">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Accum(int op, float value)
		{
			Debug.Assert(Delegates.pglAccum != null, "pglAccum not implemented");
			Delegates.pglAccum(op, value);
			CallLog("glAccum({0}, {1})", op, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glAccum.
		/// </summary>
		/// <param name="op">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Accum(AccumOp op, float value)
		{
			Debug.Assert(Delegates.pglAccum != null, "pglAccum not implemented");
			Delegates.pglAccum((int)op, value);
			CallLog("glAccum({0}, {1})", op, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPopAttrib.
		/// </summary>
		/// <remarks>
		/// </remarks>
		public static void PopAttrib()
		{
			Debug.Assert(Delegates.pglPopAttrib != null, "pglPopAttrib not implemented");
			Delegates.pglPopAttrib();
			CallLog("glPopAttrib()");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPushAttrib.
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void PushAttrib(uint mask)
		{
			Debug.Assert(Delegates.pglPushAttrib != null, "pglPushAttrib not implemented");
			Delegates.pglPushAttrib(mask);
			CallLog("glPushAttrib({0})", mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPushAttrib.
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void PushAttrib(AttribMask mask)
		{
			Debug.Assert(Delegates.pglPushAttrib != null, "pglPushAttrib not implemented");
			Delegates.pglPushAttrib((uint)mask);
			CallLog("glPushAttrib({0})", mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// define a one-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants <see cref="Gl.MAP1_VERTEX_3"/>, 
		/// <seecref="Gl.MAP1_VERTEX_4"/>, <see cref="Gl.MAP1_INDEX"/>, <see cref="Gl.MAP1_COLOR_4"/>, <see cref="Gl.MAP1_NORMAL"/>, 
		/// <seecref="Gl.MAP1_TEXTURE_COORD_1"/>, <see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see cref="Gl.MAP1_TEXTURE_COORD_3"/>, and 
		/// <seecref="Gl.MAP1_TEXTURE_COORD_4"/> are accepted. 
		/// </param>
		/// <param name="u1">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord1, to u^, the variable that is evaluated by the equations 
		/// specifiedby this command. 
		/// </param>
		/// <param name="u2">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord1, to u^, the variable that is evaluated by the equations 
		/// specifiedby this command. 
		/// </param>
		/// <param name="stride">
		/// Specifies the number of floats or doubles between the beginning of one control point and the beginning of the next one 
		/// inthe data structure referenced in <paramref name="points"/>. This allows control points to be embedded in arbitrary 
		/// datastructures. The only constraint is that the values for a particular control point must occupy contiguous memory 
		/// locations.
		/// </param>
		/// <param name="order">
		/// Specifies the number of control points. Must be positive. 
		/// </param>
		/// <param name="points">
		/// Specifies a pointer to the array of control points. 
		/// </param>
		/// <remarks>
		/// Evaluators provide a way to use polynomial or rational polynomial mapping to produce vertices, normals, texture 
		/// coordinates,and colors. The values produced by an evaluator are sent to further stages of GL processing just as if they 
		/// hadbeen presented using Gl.Vertex, Gl.Normal, Gl.TexCoord, and Gl.Color commands, except that the generated values do 
		/// notupdate the current normal, texture coordinates, or color. 
		/// All polynomial or rational polynomial splines of any degree (up to the maximum degree supported by the GL 
		/// implementation)can be described using evaluators. These include almost all splines used in computer graphics: B-splines, 
		/// Beziercurves, Hermite splines, and so on. 
		/// Evaluators define curves based on Bernstein polynomials. Define p⁡u^ as 
		/// p⁡u^=Σi=0nBin⁡u^⁢Ri 
		///  
		/// where Ri is a control point and Bin⁡u^ is the ith Bernstein polynomial of degree n (<paramref name="order"/> = n+1): 
		/// Bin⁡u^=ni⁢u^i⁢1-u^n-i 
		/// Recall that 
		/// 00==1 and n0==1 
		/// <see cref="Gl.Map1"/> is used to define the basis and to specify what kind of values are produced. Once defined, a map 
		/// canbe enabled and disabled by calling Gl.Enable and Gl.Disable with the map name, one of the nine predefined values for 
		/// <paramrefname="target"/> described below. Gl.EvalCoord1 evaluates the one-dimensional maps that are enabled. When 
		/// Gl.EvalCoord1presents a value u, the Bernstein functions are evaluated using u^, where u^=u-u1u2-u1 
		/// <paramref name="target"/> is a symbolic constant that indicates what kind of control points are provided in <paramref 
		/// name="points"/>,and what output is generated when the map is evaluated. It can assume one of nine predefined values: 
		/// <paramref name="stride"/>, <paramref name="order"/>, and <paramref name="points"/> define the array addressing for 
		/// accessingthe control points. <paramref name="points"/> is the location of the first control point, which occupies one, 
		/// two,three, or four contiguous memory locations, depending on which map is being defined. <paramref name="order"/> is the 
		/// numberof control points in the array. <paramref name="stride"/> specifies how many float or double locations to advance 
		/// theinternal memory pointer to reach the next control point. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="u1"/> is equal to <paramref name="u2"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="stride"/> is less than the number of values in a control 
		///   point.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="order"/> is less than 1 or greater than the return value 
		///   of<see cref="Gl.MAX_EVAL_ORDER"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Map1"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Map1"/> is called and the value of <see 
		///   cref="Gl.ACTIVE_TEXTURE"/>is not <see cref="Gl.TEXTURE0"/>. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetMap 
		/// - Gl.Get with argument <see cref="Gl.MAX_EVAL_ORDER"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_4"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void Map1(int target, double u1, double u2, Int32 stride, Int32 order, double[] points)
		{
			unsafe {
				fixed (double* p_points = points)
				{
					Debug.Assert(Delegates.pglMap1d != null, "pglMap1d not implemented");
					Delegates.pglMap1d(target, u1, u2, stride, order, p_points);
					CallLog("glMap1d({0}, {1}, {2}, {3}, {4}, {5})", target, u1, u2, stride, order, points);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define a one-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants <see cref="Gl.MAP1_VERTEX_3"/>, 
		/// <seecref="Gl.MAP1_VERTEX_4"/>, <see cref="Gl.MAP1_INDEX"/>, <see cref="Gl.MAP1_COLOR_4"/>, <see cref="Gl.MAP1_NORMAL"/>, 
		/// <seecref="Gl.MAP1_TEXTURE_COORD_1"/>, <see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see cref="Gl.MAP1_TEXTURE_COORD_3"/>, and 
		/// <seecref="Gl.MAP1_TEXTURE_COORD_4"/> are accepted. 
		/// </param>
		/// <param name="u1">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord1, to u^, the variable that is evaluated by the equations 
		/// specifiedby this command. 
		/// </param>
		/// <param name="u2">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord1, to u^, the variable that is evaluated by the equations 
		/// specifiedby this command. 
		/// </param>
		/// <param name="stride">
		/// Specifies the number of floats or doubles between the beginning of one control point and the beginning of the next one 
		/// inthe data structure referenced in <paramref name="points"/>. This allows control points to be embedded in arbitrary 
		/// datastructures. The only constraint is that the values for a particular control point must occupy contiguous memory 
		/// locations.
		/// </param>
		/// <param name="order">
		/// Specifies the number of control points. Must be positive. 
		/// </param>
		/// <param name="points">
		/// Specifies a pointer to the array of control points. 
		/// </param>
		/// <remarks>
		/// Evaluators provide a way to use polynomial or rational polynomial mapping to produce vertices, normals, texture 
		/// coordinates,and colors. The values produced by an evaluator are sent to further stages of GL processing just as if they 
		/// hadbeen presented using Gl.Vertex, Gl.Normal, Gl.TexCoord, and Gl.Color commands, except that the generated values do 
		/// notupdate the current normal, texture coordinates, or color. 
		/// All polynomial or rational polynomial splines of any degree (up to the maximum degree supported by the GL 
		/// implementation)can be described using evaluators. These include almost all splines used in computer graphics: B-splines, 
		/// Beziercurves, Hermite splines, and so on. 
		/// Evaluators define curves based on Bernstein polynomials. Define p⁡u^ as 
		/// p⁡u^=Σi=0nBin⁡u^⁢Ri 
		///  
		/// where Ri is a control point and Bin⁡u^ is the ith Bernstein polynomial of degree n (<paramref name="order"/> = n+1): 
		/// Bin⁡u^=ni⁢u^i⁢1-u^n-i 
		/// Recall that 
		/// 00==1 and n0==1 
		/// <see cref="Gl.Map1"/> is used to define the basis and to specify what kind of values are produced. Once defined, a map 
		/// canbe enabled and disabled by calling Gl.Enable and Gl.Disable with the map name, one of the nine predefined values for 
		/// <paramrefname="target"/> described below. Gl.EvalCoord1 evaluates the one-dimensional maps that are enabled. When 
		/// Gl.EvalCoord1presents a value u, the Bernstein functions are evaluated using u^, where u^=u-u1u2-u1 
		/// <paramref name="target"/> is a symbolic constant that indicates what kind of control points are provided in <paramref 
		/// name="points"/>,and what output is generated when the map is evaluated. It can assume one of nine predefined values: 
		/// <paramref name="stride"/>, <paramref name="order"/>, and <paramref name="points"/> define the array addressing for 
		/// accessingthe control points. <paramref name="points"/> is the location of the first control point, which occupies one, 
		/// two,three, or four contiguous memory locations, depending on which map is being defined. <paramref name="order"/> is the 
		/// numberof control points in the array. <paramref name="stride"/> specifies how many float or double locations to advance 
		/// theinternal memory pointer to reach the next control point. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="u1"/> is equal to <paramref name="u2"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="stride"/> is less than the number of values in a control 
		///   point.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="order"/> is less than 1 or greater than the return value 
		///   of<see cref="Gl.MAX_EVAL_ORDER"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Map1"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Map1"/> is called and the value of <see 
		///   cref="Gl.ACTIVE_TEXTURE"/>is not <see cref="Gl.TEXTURE0"/>. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetMap 
		/// - Gl.Get with argument <see cref="Gl.MAX_EVAL_ORDER"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_4"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void Map1(MapTarget target, double u1, double u2, Int32 stride, Int32 order, double[] points)
		{
			unsafe {
				fixed (double* p_points = points)
				{
					Debug.Assert(Delegates.pglMap1d != null, "pglMap1d not implemented");
					Delegates.pglMap1d((int)target, u1, u2, stride, order, p_points);
					CallLog("glMap1d({0}, {1}, {2}, {3}, {4}, {5})", target, u1, u2, stride, order, points);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define a one-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants <see cref="Gl.MAP1_VERTEX_3"/>, 
		/// <seecref="Gl.MAP1_VERTEX_4"/>, <see cref="Gl.MAP1_INDEX"/>, <see cref="Gl.MAP1_COLOR_4"/>, <see cref="Gl.MAP1_NORMAL"/>, 
		/// <seecref="Gl.MAP1_TEXTURE_COORD_1"/>, <see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see cref="Gl.MAP1_TEXTURE_COORD_3"/>, and 
		/// <seecref="Gl.MAP1_TEXTURE_COORD_4"/> are accepted. 
		/// </param>
		/// <param name="u1">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord1, to u^, the variable that is evaluated by the equations 
		/// specifiedby this command. 
		/// </param>
		/// <param name="u2">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord1, to u^, the variable that is evaluated by the equations 
		/// specifiedby this command. 
		/// </param>
		/// <param name="stride">
		/// Specifies the number of floats or doubles between the beginning of one control point and the beginning of the next one 
		/// inthe data structure referenced in <paramref name="points"/>. This allows control points to be embedded in arbitrary 
		/// datastructures. The only constraint is that the values for a particular control point must occupy contiguous memory 
		/// locations.
		/// </param>
		/// <param name="order">
		/// Specifies the number of control points. Must be positive. 
		/// </param>
		/// <param name="points">
		/// Specifies a pointer to the array of control points. 
		/// </param>
		/// <remarks>
		/// Evaluators provide a way to use polynomial or rational polynomial mapping to produce vertices, normals, texture 
		/// coordinates,and colors. The values produced by an evaluator are sent to further stages of GL processing just as if they 
		/// hadbeen presented using Gl.Vertex, Gl.Normal, Gl.TexCoord, and Gl.Color commands, except that the generated values do 
		/// notupdate the current normal, texture coordinates, or color. 
		/// All polynomial or rational polynomial splines of any degree (up to the maximum degree supported by the GL 
		/// implementation)can be described using evaluators. These include almost all splines used in computer graphics: B-splines, 
		/// Beziercurves, Hermite splines, and so on. 
		/// Evaluators define curves based on Bernstein polynomials. Define p⁡u^ as 
		/// p⁡u^=Σi=0nBin⁡u^⁢Ri 
		///  
		/// where Ri is a control point and Bin⁡u^ is the ith Bernstein polynomial of degree n (<paramref name="order"/> = n+1): 
		/// Bin⁡u^=ni⁢u^i⁢1-u^n-i 
		/// Recall that 
		/// 00==1 and n0==1 
		/// <see cref="Gl.Map1"/> is used to define the basis and to specify what kind of values are produced. Once defined, a map 
		/// canbe enabled and disabled by calling Gl.Enable and Gl.Disable with the map name, one of the nine predefined values for 
		/// <paramrefname="target"/> described below. Gl.EvalCoord1 evaluates the one-dimensional maps that are enabled. When 
		/// Gl.EvalCoord1presents a value u, the Bernstein functions are evaluated using u^, where u^=u-u1u2-u1 
		/// <paramref name="target"/> is a symbolic constant that indicates what kind of control points are provided in <paramref 
		/// name="points"/>,and what output is generated when the map is evaluated. It can assume one of nine predefined values: 
		/// <paramref name="stride"/>, <paramref name="order"/>, and <paramref name="points"/> define the array addressing for 
		/// accessingthe control points. <paramref name="points"/> is the location of the first control point, which occupies one, 
		/// two,three, or four contiguous memory locations, depending on which map is being defined. <paramref name="order"/> is the 
		/// numberof control points in the array. <paramref name="stride"/> specifies how many float or double locations to advance 
		/// theinternal memory pointer to reach the next control point. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="u1"/> is equal to <paramref name="u2"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="stride"/> is less than the number of values in a control 
		///   point.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="order"/> is less than 1 or greater than the return value 
		///   of<see cref="Gl.MAX_EVAL_ORDER"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Map1"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Map1"/> is called and the value of <see 
		///   cref="Gl.ACTIVE_TEXTURE"/>is not <see cref="Gl.TEXTURE0"/>. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetMap 
		/// - Gl.Get with argument <see cref="Gl.MAX_EVAL_ORDER"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_4"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void Map1(int target, float u1, float u2, Int32 stride, Int32 order, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglMap1f != null, "pglMap1f not implemented");
					Delegates.pglMap1f(target, u1, u2, stride, order, p_points);
					CallLog("glMap1f({0}, {1}, {2}, {3}, {4}, {5})", target, u1, u2, stride, order, points);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define a one-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants <see cref="Gl.MAP1_VERTEX_3"/>, 
		/// <seecref="Gl.MAP1_VERTEX_4"/>, <see cref="Gl.MAP1_INDEX"/>, <see cref="Gl.MAP1_COLOR_4"/>, <see cref="Gl.MAP1_NORMAL"/>, 
		/// <seecref="Gl.MAP1_TEXTURE_COORD_1"/>, <see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see cref="Gl.MAP1_TEXTURE_COORD_3"/>, and 
		/// <seecref="Gl.MAP1_TEXTURE_COORD_4"/> are accepted. 
		/// </param>
		/// <param name="u1">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord1, to u^, the variable that is evaluated by the equations 
		/// specifiedby this command. 
		/// </param>
		/// <param name="u2">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord1, to u^, the variable that is evaluated by the equations 
		/// specifiedby this command. 
		/// </param>
		/// <param name="stride">
		/// Specifies the number of floats or doubles between the beginning of one control point and the beginning of the next one 
		/// inthe data structure referenced in <paramref name="points"/>. This allows control points to be embedded in arbitrary 
		/// datastructures. The only constraint is that the values for a particular control point must occupy contiguous memory 
		/// locations.
		/// </param>
		/// <param name="order">
		/// Specifies the number of control points. Must be positive. 
		/// </param>
		/// <param name="points">
		/// Specifies a pointer to the array of control points. 
		/// </param>
		/// <remarks>
		/// Evaluators provide a way to use polynomial or rational polynomial mapping to produce vertices, normals, texture 
		/// coordinates,and colors. The values produced by an evaluator are sent to further stages of GL processing just as if they 
		/// hadbeen presented using Gl.Vertex, Gl.Normal, Gl.TexCoord, and Gl.Color commands, except that the generated values do 
		/// notupdate the current normal, texture coordinates, or color. 
		/// All polynomial or rational polynomial splines of any degree (up to the maximum degree supported by the GL 
		/// implementation)can be described using evaluators. These include almost all splines used in computer graphics: B-splines, 
		/// Beziercurves, Hermite splines, and so on. 
		/// Evaluators define curves based on Bernstein polynomials. Define p⁡u^ as 
		/// p⁡u^=Σi=0nBin⁡u^⁢Ri 
		///  
		/// where Ri is a control point and Bin⁡u^ is the ith Bernstein polynomial of degree n (<paramref name="order"/> = n+1): 
		/// Bin⁡u^=ni⁢u^i⁢1-u^n-i 
		/// Recall that 
		/// 00==1 and n0==1 
		/// <see cref="Gl.Map1"/> is used to define the basis and to specify what kind of values are produced. Once defined, a map 
		/// canbe enabled and disabled by calling Gl.Enable and Gl.Disable with the map name, one of the nine predefined values for 
		/// <paramrefname="target"/> described below. Gl.EvalCoord1 evaluates the one-dimensional maps that are enabled. When 
		/// Gl.EvalCoord1presents a value u, the Bernstein functions are evaluated using u^, where u^=u-u1u2-u1 
		/// <paramref name="target"/> is a symbolic constant that indicates what kind of control points are provided in <paramref 
		/// name="points"/>,and what output is generated when the map is evaluated. It can assume one of nine predefined values: 
		/// <paramref name="stride"/>, <paramref name="order"/>, and <paramref name="points"/> define the array addressing for 
		/// accessingthe control points. <paramref name="points"/> is the location of the first control point, which occupies one, 
		/// two,three, or four contiguous memory locations, depending on which map is being defined. <paramref name="order"/> is the 
		/// numberof control points in the array. <paramref name="stride"/> specifies how many float or double locations to advance 
		/// theinternal memory pointer to reach the next control point. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="u1"/> is equal to <paramref name="u2"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="stride"/> is less than the number of values in a control 
		///   point.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="order"/> is less than 1 or greater than the return value 
		///   of<see cref="Gl.MAX_EVAL_ORDER"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Map1"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Map1"/> is called and the value of <see 
		///   cref="Gl.ACTIVE_TEXTURE"/>is not <see cref="Gl.TEXTURE0"/>. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetMap 
		/// - Gl.Get with argument <see cref="Gl.MAX_EVAL_ORDER"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_4"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void Map1(MapTarget target, float u1, float u2, Int32 stride, Int32 order, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglMap1f != null, "pglMap1f not implemented");
					Delegates.pglMap1f((int)target, u1, u2, stride, order, p_points);
					CallLog("glMap1f({0}, {1}, {2}, {3}, {4}, {5})", target, u1, u2, stride, order, points);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define a two-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants <see cref="Gl.MAP2_VERTEX_3"/>, 
		/// <seecref="Gl.MAP2_VERTEX_4"/>, <see cref="Gl.MAP2_INDEX"/>, <see cref="Gl.MAP2_COLOR_4"/>, <see cref="Gl.MAP2_NORMAL"/>, 
		/// <seecref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see cref="Gl.MAP2_TEXTURE_COORD_3"/>, and 
		/// <seecref="Gl.MAP2_TEXTURE_COORD_4"/> are accepted. 
		/// </param>
		/// <param name="u1">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord2, to u^, one of the two variables that are evaluated by the 
		/// equationsspecified by this command. Initially, <paramref name="u1"/> is 0 and <paramref name="u2"/> is 1. 
		/// </param>
		/// <param name="u2">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord2, to u^, one of the two variables that are evaluated by the 
		/// equationsspecified by this command. Initially, <paramref name="u1"/> is 0 and <paramref name="u2"/> is 1. 
		/// </param>
		/// <param name="ustride">
		/// Specifies the number of floats or doubles between the beginning of control point Rij and the beginning of control point 
		/// Ri+1⁢j,where i and j are the u and v control point indices, respectively. This allows control points to be embedded in 
		/// arbitrarydata structures. The only constraint is that the values for a particular control point must occupy contiguous 
		/// memorylocations. The initial value of <paramref name="ustride"/> is 0. 
		/// </param>
		/// <param name="uorder">
		/// Specifies the dimension of the control point array in the u axis. Must be positive. The initial value is 1. 
		/// </param>
		/// <param name="v1">
		/// Specify a linear mapping of v, as presented to Gl\.EvalCoord2, to v^, one of the two variables that are evaluated by the 
		/// equationsspecified by this command. Initially, <paramref name="v1"/> is 0 and <paramref name="v2"/> is 1. 
		/// </param>
		/// <param name="v2">
		/// Specify a linear mapping of v, as presented to Gl\.EvalCoord2, to v^, one of the two variables that are evaluated by the 
		/// equationsspecified by this command. Initially, <paramref name="v1"/> is 0 and <paramref name="v2"/> is 1. 
		/// </param>
		/// <param name="vstride">
		/// Specifies the number of floats or doubles between the beginning of control point Rij and the beginning of control point 
		/// Ri⁡j+1,where i and j are the u and v control point indices, respectively. This allows control points to be embedded in 
		/// arbitrarydata structures. The only constraint is that the values for a particular control point must occupy contiguous 
		/// memorylocations. The initial value of <paramref name="vstride"/> is 0. 
		/// </param>
		/// <param name="vorder">
		/// Specifies the dimension of the control point array in the v axis. Must be positive. The initial value is 1. 
		/// </param>
		/// <param name="points">
		/// Specifies a pointer to the array of control points. 
		/// </param>
		/// <remarks>
		/// Evaluators provide a way to use polynomial or rational polynomial mapping to produce vertices, normals, texture 
		/// coordinates,and colors. The values produced by an evaluator are sent on to further stages of GL processing just as if 
		/// theyhad been presented using Gl.Vertex, Gl.Normal, Gl.TexCoord, and Gl.Color commands, except that the generated values 
		/// donot update the current normal, texture coordinates, or color. 
		/// All polynomial or rational polynomial splines of any degree (up to the maximum degree supported by the GL 
		/// implementation)can be described using evaluators. These include almost all surfaces used in computer graphics, including 
		/// B-splinesurfaces, NURBS surfaces, Bezier surfaces, and so on. 
		/// Evaluators define surfaces based on bivariate Bernstein polynomials. Define p⁡u^v^ as 
		/// p⁡u^v^=Σi=0nΣj=0mBin⁡u^⁢Bjm⁡v^⁢Rij 
		///  
		/// where Rij is a control point, Bin⁡u^ is the ith Bernstein polynomial of degree n (<paramref name="uorder"/> = n+1) 
		/// Bin⁡u^=ni⁢u^i⁢1-u^n-i 
		/// and Bjm⁡v^ is the jth Bernstein polynomial of degree m (<paramref name="vorder"/> = m+1) 
		/// Bjm⁡v^=mj⁢v^j⁢1-v^m-j 
		/// Recall that 00==1 and n0==1 
		/// <see cref="Gl.Map2"/> is used to define the basis and to specify what kind of values are produced. Once defined, a map 
		/// canbe enabled and disabled by calling Gl.Enable and Gl.Disable with the map name, one of the nine predefined values for 
		/// <paramrefname="target"/>, described below. When Gl.EvalCoord2 presents values u and v, the bivariate Bernstein 
		/// polynomialsare evaluated using u^ and v^, where 
		/// u^=u-u1u2-u1 
		/// v^=v-v1v2-v1 
		/// <paramref name="target"/> is a symbolic constant that indicates what kind of control points are provided in <paramref 
		/// name="points"/>,and what output is generated when the map is evaluated. It can assume one of nine predefined values: 
		/// <paramref name="ustride"/>, <paramref name="uorder"/>, <paramref name="vstride"/>, <paramref name="vorder"/>, and 
		/// <paramrefname="points"/> define the array addressing for accessing the control points. <paramref name="points"/> is the 
		/// locationof the first control point, which occupies one, two, three, or four contiguous memory locations, depending on 
		/// whichmap is being defined. There are uorder×vorder control points in the array. <paramref name="ustride"/> specifies how 
		/// manyfloat or double locations are skipped to advance the internal memory pointer from control point Ri⁢j to control 
		/// pointRi+1⁢j. <paramref name="vstride"/> specifies how many float or double locations are skipped to advance the internal 
		/// memorypointer from control point Ri⁢j to control point Ri⁡j+1. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="u1"/> is equal to <paramref name="u2"/>, or if <paramref 
		///   name="v1"/>is equal to <paramref name="v2"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if either <paramref name="ustride"/> or <paramref name="vstride"/> is less 
		///   thanthe number of values in a control point. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if either <paramref name="uorder"/> or <paramref name="vorder"/> is less 
		///   than1 or greater than the return value of <see cref="Gl.MAX_EVAL_ORDER"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Map2"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Map2"/> is called and the value of <see 
		///   cref="Gl.ACTIVE_TEXTURE"/>is not <see cref="Gl.TEXTURE0"/>. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetMap 
		/// - Gl.Get with argument <see cref="Gl.MAX_EVAL_ORDER"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_4"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void Map2(int target, double u1, double u2, Int32 ustride, Int32 uorder, double v1, double v2, Int32 vstride, Int32 vorder, double[] points)
		{
			unsafe {
				fixed (double* p_points = points)
				{
					Debug.Assert(Delegates.pglMap2d != null, "pglMap2d not implemented");
					Delegates.pglMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, p_points);
					CallLog("glMap2d({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define a two-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants <see cref="Gl.MAP2_VERTEX_3"/>, 
		/// <seecref="Gl.MAP2_VERTEX_4"/>, <see cref="Gl.MAP2_INDEX"/>, <see cref="Gl.MAP2_COLOR_4"/>, <see cref="Gl.MAP2_NORMAL"/>, 
		/// <seecref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see cref="Gl.MAP2_TEXTURE_COORD_3"/>, and 
		/// <seecref="Gl.MAP2_TEXTURE_COORD_4"/> are accepted. 
		/// </param>
		/// <param name="u1">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord2, to u^, one of the two variables that are evaluated by the 
		/// equationsspecified by this command. Initially, <paramref name="u1"/> is 0 and <paramref name="u2"/> is 1. 
		/// </param>
		/// <param name="u2">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord2, to u^, one of the two variables that are evaluated by the 
		/// equationsspecified by this command. Initially, <paramref name="u1"/> is 0 and <paramref name="u2"/> is 1. 
		/// </param>
		/// <param name="ustride">
		/// Specifies the number of floats or doubles between the beginning of control point Rij and the beginning of control point 
		/// Ri+1⁢j,where i and j are the u and v control point indices, respectively. This allows control points to be embedded in 
		/// arbitrarydata structures. The only constraint is that the values for a particular control point must occupy contiguous 
		/// memorylocations. The initial value of <paramref name="ustride"/> is 0. 
		/// </param>
		/// <param name="uorder">
		/// Specifies the dimension of the control point array in the u axis. Must be positive. The initial value is 1. 
		/// </param>
		/// <param name="v1">
		/// Specify a linear mapping of v, as presented to Gl\.EvalCoord2, to v^, one of the two variables that are evaluated by the 
		/// equationsspecified by this command. Initially, <paramref name="v1"/> is 0 and <paramref name="v2"/> is 1. 
		/// </param>
		/// <param name="v2">
		/// Specify a linear mapping of v, as presented to Gl\.EvalCoord2, to v^, one of the two variables that are evaluated by the 
		/// equationsspecified by this command. Initially, <paramref name="v1"/> is 0 and <paramref name="v2"/> is 1. 
		/// </param>
		/// <param name="vstride">
		/// Specifies the number of floats or doubles between the beginning of control point Rij and the beginning of control point 
		/// Ri⁡j+1,where i and j are the u and v control point indices, respectively. This allows control points to be embedded in 
		/// arbitrarydata structures. The only constraint is that the values for a particular control point must occupy contiguous 
		/// memorylocations. The initial value of <paramref name="vstride"/> is 0. 
		/// </param>
		/// <param name="vorder">
		/// Specifies the dimension of the control point array in the v axis. Must be positive. The initial value is 1. 
		/// </param>
		/// <param name="points">
		/// Specifies a pointer to the array of control points. 
		/// </param>
		/// <remarks>
		/// Evaluators provide a way to use polynomial or rational polynomial mapping to produce vertices, normals, texture 
		/// coordinates,and colors. The values produced by an evaluator are sent on to further stages of GL processing just as if 
		/// theyhad been presented using Gl.Vertex, Gl.Normal, Gl.TexCoord, and Gl.Color commands, except that the generated values 
		/// donot update the current normal, texture coordinates, or color. 
		/// All polynomial or rational polynomial splines of any degree (up to the maximum degree supported by the GL 
		/// implementation)can be described using evaluators. These include almost all surfaces used in computer graphics, including 
		/// B-splinesurfaces, NURBS surfaces, Bezier surfaces, and so on. 
		/// Evaluators define surfaces based on bivariate Bernstein polynomials. Define p⁡u^v^ as 
		/// p⁡u^v^=Σi=0nΣj=0mBin⁡u^⁢Bjm⁡v^⁢Rij 
		///  
		/// where Rij is a control point, Bin⁡u^ is the ith Bernstein polynomial of degree n (<paramref name="uorder"/> = n+1) 
		/// Bin⁡u^=ni⁢u^i⁢1-u^n-i 
		/// and Bjm⁡v^ is the jth Bernstein polynomial of degree m (<paramref name="vorder"/> = m+1) 
		/// Bjm⁡v^=mj⁢v^j⁢1-v^m-j 
		/// Recall that 00==1 and n0==1 
		/// <see cref="Gl.Map2"/> is used to define the basis and to specify what kind of values are produced. Once defined, a map 
		/// canbe enabled and disabled by calling Gl.Enable and Gl.Disable with the map name, one of the nine predefined values for 
		/// <paramrefname="target"/>, described below. When Gl.EvalCoord2 presents values u and v, the bivariate Bernstein 
		/// polynomialsare evaluated using u^ and v^, where 
		/// u^=u-u1u2-u1 
		/// v^=v-v1v2-v1 
		/// <paramref name="target"/> is a symbolic constant that indicates what kind of control points are provided in <paramref 
		/// name="points"/>,and what output is generated when the map is evaluated. It can assume one of nine predefined values: 
		/// <paramref name="ustride"/>, <paramref name="uorder"/>, <paramref name="vstride"/>, <paramref name="vorder"/>, and 
		/// <paramrefname="points"/> define the array addressing for accessing the control points. <paramref name="points"/> is the 
		/// locationof the first control point, which occupies one, two, three, or four contiguous memory locations, depending on 
		/// whichmap is being defined. There are uorder×vorder control points in the array. <paramref name="ustride"/> specifies how 
		/// manyfloat or double locations are skipped to advance the internal memory pointer from control point Ri⁢j to control 
		/// pointRi+1⁢j. <paramref name="vstride"/> specifies how many float or double locations are skipped to advance the internal 
		/// memorypointer from control point Ri⁢j to control point Ri⁡j+1. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="u1"/> is equal to <paramref name="u2"/>, or if <paramref 
		///   name="v1"/>is equal to <paramref name="v2"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if either <paramref name="ustride"/> or <paramref name="vstride"/> is less 
		///   thanthe number of values in a control point. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if either <paramref name="uorder"/> or <paramref name="vorder"/> is less 
		///   than1 or greater than the return value of <see cref="Gl.MAX_EVAL_ORDER"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Map2"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Map2"/> is called and the value of <see 
		///   cref="Gl.ACTIVE_TEXTURE"/>is not <see cref="Gl.TEXTURE0"/>. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetMap 
		/// - Gl.Get with argument <see cref="Gl.MAX_EVAL_ORDER"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_4"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void Map2(MapTarget target, double u1, double u2, Int32 ustride, Int32 uorder, double v1, double v2, Int32 vstride, Int32 vorder, double[] points)
		{
			unsafe {
				fixed (double* p_points = points)
				{
					Debug.Assert(Delegates.pglMap2d != null, "pglMap2d not implemented");
					Delegates.pglMap2d((int)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, p_points);
					CallLog("glMap2d({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define a two-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants <see cref="Gl.MAP2_VERTEX_3"/>, 
		/// <seecref="Gl.MAP2_VERTEX_4"/>, <see cref="Gl.MAP2_INDEX"/>, <see cref="Gl.MAP2_COLOR_4"/>, <see cref="Gl.MAP2_NORMAL"/>, 
		/// <seecref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see cref="Gl.MAP2_TEXTURE_COORD_3"/>, and 
		/// <seecref="Gl.MAP2_TEXTURE_COORD_4"/> are accepted. 
		/// </param>
		/// <param name="u1">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord2, to u^, one of the two variables that are evaluated by the 
		/// equationsspecified by this command. Initially, <paramref name="u1"/> is 0 and <paramref name="u2"/> is 1. 
		/// </param>
		/// <param name="u2">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord2, to u^, one of the two variables that are evaluated by the 
		/// equationsspecified by this command. Initially, <paramref name="u1"/> is 0 and <paramref name="u2"/> is 1. 
		/// </param>
		/// <param name="ustride">
		/// Specifies the number of floats or doubles between the beginning of control point Rij and the beginning of control point 
		/// Ri+1⁢j,where i and j are the u and v control point indices, respectively. This allows control points to be embedded in 
		/// arbitrarydata structures. The only constraint is that the values for a particular control point must occupy contiguous 
		/// memorylocations. The initial value of <paramref name="ustride"/> is 0. 
		/// </param>
		/// <param name="uorder">
		/// Specifies the dimension of the control point array in the u axis. Must be positive. The initial value is 1. 
		/// </param>
		/// <param name="v1">
		/// Specify a linear mapping of v, as presented to Gl\.EvalCoord2, to v^, one of the two variables that are evaluated by the 
		/// equationsspecified by this command. Initially, <paramref name="v1"/> is 0 and <paramref name="v2"/> is 1. 
		/// </param>
		/// <param name="v2">
		/// Specify a linear mapping of v, as presented to Gl\.EvalCoord2, to v^, one of the two variables that are evaluated by the 
		/// equationsspecified by this command. Initially, <paramref name="v1"/> is 0 and <paramref name="v2"/> is 1. 
		/// </param>
		/// <param name="vstride">
		/// Specifies the number of floats or doubles between the beginning of control point Rij and the beginning of control point 
		/// Ri⁡j+1,where i and j are the u and v control point indices, respectively. This allows control points to be embedded in 
		/// arbitrarydata structures. The only constraint is that the values for a particular control point must occupy contiguous 
		/// memorylocations. The initial value of <paramref name="vstride"/> is 0. 
		/// </param>
		/// <param name="vorder">
		/// Specifies the dimension of the control point array in the v axis. Must be positive. The initial value is 1. 
		/// </param>
		/// <param name="points">
		/// Specifies a pointer to the array of control points. 
		/// </param>
		/// <remarks>
		/// Evaluators provide a way to use polynomial or rational polynomial mapping to produce vertices, normals, texture 
		/// coordinates,and colors. The values produced by an evaluator are sent on to further stages of GL processing just as if 
		/// theyhad been presented using Gl.Vertex, Gl.Normal, Gl.TexCoord, and Gl.Color commands, except that the generated values 
		/// donot update the current normal, texture coordinates, or color. 
		/// All polynomial or rational polynomial splines of any degree (up to the maximum degree supported by the GL 
		/// implementation)can be described using evaluators. These include almost all surfaces used in computer graphics, including 
		/// B-splinesurfaces, NURBS surfaces, Bezier surfaces, and so on. 
		/// Evaluators define surfaces based on bivariate Bernstein polynomials. Define p⁡u^v^ as 
		/// p⁡u^v^=Σi=0nΣj=0mBin⁡u^⁢Bjm⁡v^⁢Rij 
		///  
		/// where Rij is a control point, Bin⁡u^ is the ith Bernstein polynomial of degree n (<paramref name="uorder"/> = n+1) 
		/// Bin⁡u^=ni⁢u^i⁢1-u^n-i 
		/// and Bjm⁡v^ is the jth Bernstein polynomial of degree m (<paramref name="vorder"/> = m+1) 
		/// Bjm⁡v^=mj⁢v^j⁢1-v^m-j 
		/// Recall that 00==1 and n0==1 
		/// <see cref="Gl.Map2"/> is used to define the basis and to specify what kind of values are produced. Once defined, a map 
		/// canbe enabled and disabled by calling Gl.Enable and Gl.Disable with the map name, one of the nine predefined values for 
		/// <paramrefname="target"/>, described below. When Gl.EvalCoord2 presents values u and v, the bivariate Bernstein 
		/// polynomialsare evaluated using u^ and v^, where 
		/// u^=u-u1u2-u1 
		/// v^=v-v1v2-v1 
		/// <paramref name="target"/> is a symbolic constant that indicates what kind of control points are provided in <paramref 
		/// name="points"/>,and what output is generated when the map is evaluated. It can assume one of nine predefined values: 
		/// <paramref name="ustride"/>, <paramref name="uorder"/>, <paramref name="vstride"/>, <paramref name="vorder"/>, and 
		/// <paramrefname="points"/> define the array addressing for accessing the control points. <paramref name="points"/> is the 
		/// locationof the first control point, which occupies one, two, three, or four contiguous memory locations, depending on 
		/// whichmap is being defined. There are uorder×vorder control points in the array. <paramref name="ustride"/> specifies how 
		/// manyfloat or double locations are skipped to advance the internal memory pointer from control point Ri⁢j to control 
		/// pointRi+1⁢j. <paramref name="vstride"/> specifies how many float or double locations are skipped to advance the internal 
		/// memorypointer from control point Ri⁢j to control point Ri⁡j+1. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="u1"/> is equal to <paramref name="u2"/>, or if <paramref 
		///   name="v1"/>is equal to <paramref name="v2"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if either <paramref name="ustride"/> or <paramref name="vstride"/> is less 
		///   thanthe number of values in a control point. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if either <paramref name="uorder"/> or <paramref name="vorder"/> is less 
		///   than1 or greater than the return value of <see cref="Gl.MAX_EVAL_ORDER"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Map2"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Map2"/> is called and the value of <see 
		///   cref="Gl.ACTIVE_TEXTURE"/>is not <see cref="Gl.TEXTURE0"/>. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetMap 
		/// - Gl.Get with argument <see cref="Gl.MAX_EVAL_ORDER"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_4"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void Map2(int target, float u1, float u2, Int32 ustride, Int32 uorder, float v1, float v2, Int32 vstride, Int32 vorder, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglMap2f != null, "pglMap2f not implemented");
					Delegates.pglMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, p_points);
					CallLog("glMap2f({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define a two-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants <see cref="Gl.MAP2_VERTEX_3"/>, 
		/// <seecref="Gl.MAP2_VERTEX_4"/>, <see cref="Gl.MAP2_INDEX"/>, <see cref="Gl.MAP2_COLOR_4"/>, <see cref="Gl.MAP2_NORMAL"/>, 
		/// <seecref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see cref="Gl.MAP2_TEXTURE_COORD_3"/>, and 
		/// <seecref="Gl.MAP2_TEXTURE_COORD_4"/> are accepted. 
		/// </param>
		/// <param name="u1">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord2, to u^, one of the two variables that are evaluated by the 
		/// equationsspecified by this command. Initially, <paramref name="u1"/> is 0 and <paramref name="u2"/> is 1. 
		/// </param>
		/// <param name="u2">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord2, to u^, one of the two variables that are evaluated by the 
		/// equationsspecified by this command. Initially, <paramref name="u1"/> is 0 and <paramref name="u2"/> is 1. 
		/// </param>
		/// <param name="ustride">
		/// Specifies the number of floats or doubles between the beginning of control point Rij and the beginning of control point 
		/// Ri+1⁢j,where i and j are the u and v control point indices, respectively. This allows control points to be embedded in 
		/// arbitrarydata structures. The only constraint is that the values for a particular control point must occupy contiguous 
		/// memorylocations. The initial value of <paramref name="ustride"/> is 0. 
		/// </param>
		/// <param name="uorder">
		/// Specifies the dimension of the control point array in the u axis. Must be positive. The initial value is 1. 
		/// </param>
		/// <param name="v1">
		/// Specify a linear mapping of v, as presented to Gl\.EvalCoord2, to v^, one of the two variables that are evaluated by the 
		/// equationsspecified by this command. Initially, <paramref name="v1"/> is 0 and <paramref name="v2"/> is 1. 
		/// </param>
		/// <param name="v2">
		/// Specify a linear mapping of v, as presented to Gl\.EvalCoord2, to v^, one of the two variables that are evaluated by the 
		/// equationsspecified by this command. Initially, <paramref name="v1"/> is 0 and <paramref name="v2"/> is 1. 
		/// </param>
		/// <param name="vstride">
		/// Specifies the number of floats or doubles between the beginning of control point Rij and the beginning of control point 
		/// Ri⁡j+1,where i and j are the u and v control point indices, respectively. This allows control points to be embedded in 
		/// arbitrarydata structures. The only constraint is that the values for a particular control point must occupy contiguous 
		/// memorylocations. The initial value of <paramref name="vstride"/> is 0. 
		/// </param>
		/// <param name="vorder">
		/// Specifies the dimension of the control point array in the v axis. Must be positive. The initial value is 1. 
		/// </param>
		/// <param name="points">
		/// Specifies a pointer to the array of control points. 
		/// </param>
		/// <remarks>
		/// Evaluators provide a way to use polynomial or rational polynomial mapping to produce vertices, normals, texture 
		/// coordinates,and colors. The values produced by an evaluator are sent on to further stages of GL processing just as if 
		/// theyhad been presented using Gl.Vertex, Gl.Normal, Gl.TexCoord, and Gl.Color commands, except that the generated values 
		/// donot update the current normal, texture coordinates, or color. 
		/// All polynomial or rational polynomial splines of any degree (up to the maximum degree supported by the GL 
		/// implementation)can be described using evaluators. These include almost all surfaces used in computer graphics, including 
		/// B-splinesurfaces, NURBS surfaces, Bezier surfaces, and so on. 
		/// Evaluators define surfaces based on bivariate Bernstein polynomials. Define p⁡u^v^ as 
		/// p⁡u^v^=Σi=0nΣj=0mBin⁡u^⁢Bjm⁡v^⁢Rij 
		///  
		/// where Rij is a control point, Bin⁡u^ is the ith Bernstein polynomial of degree n (<paramref name="uorder"/> = n+1) 
		/// Bin⁡u^=ni⁢u^i⁢1-u^n-i 
		/// and Bjm⁡v^ is the jth Bernstein polynomial of degree m (<paramref name="vorder"/> = m+1) 
		/// Bjm⁡v^=mj⁢v^j⁢1-v^m-j 
		/// Recall that 00==1 and n0==1 
		/// <see cref="Gl.Map2"/> is used to define the basis and to specify what kind of values are produced. Once defined, a map 
		/// canbe enabled and disabled by calling Gl.Enable and Gl.Disable with the map name, one of the nine predefined values for 
		/// <paramrefname="target"/>, described below. When Gl.EvalCoord2 presents values u and v, the bivariate Bernstein 
		/// polynomialsare evaluated using u^ and v^, where 
		/// u^=u-u1u2-u1 
		/// v^=v-v1v2-v1 
		/// <paramref name="target"/> is a symbolic constant that indicates what kind of control points are provided in <paramref 
		/// name="points"/>,and what output is generated when the map is evaluated. It can assume one of nine predefined values: 
		/// <paramref name="ustride"/>, <paramref name="uorder"/>, <paramref name="vstride"/>, <paramref name="vorder"/>, and 
		/// <paramrefname="points"/> define the array addressing for accessing the control points. <paramref name="points"/> is the 
		/// locationof the first control point, which occupies one, two, three, or four contiguous memory locations, depending on 
		/// whichmap is being defined. There are uorder×vorder control points in the array. <paramref name="ustride"/> specifies how 
		/// manyfloat or double locations are skipped to advance the internal memory pointer from control point Ri⁢j to control 
		/// pointRi+1⁢j. <paramref name="vstride"/> specifies how many float or double locations are skipped to advance the internal 
		/// memorypointer from control point Ri⁢j to control point Ri⁡j+1. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="target"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="u1"/> is equal to <paramref name="u2"/>, or if <paramref 
		///   name="v1"/>is equal to <paramref name="v2"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if either <paramref name="ustride"/> or <paramref name="vstride"/> is less 
		///   thanthe number of values in a control point. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if either <paramref name="uorder"/> or <paramref name="vorder"/> is less 
		///   than1 or greater than the return value of <see cref="Gl.MAX_EVAL_ORDER"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Map2"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Map2"/> is called and the value of <see 
		///   cref="Gl.ACTIVE_TEXTURE"/>is not <see cref="Gl.TEXTURE0"/>. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetMap 
		/// - Gl.Get with argument <see cref="Gl.MAX_EVAL_ORDER"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_4"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void Map2(MapTarget target, float u1, float u2, Int32 ustride, Int32 uorder, float v1, float v2, Int32 vstride, Int32 vorder, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglMap2f != null, "pglMap2f not implemented");
					Delegates.pglMap2f((int)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, p_points);
					CallLog("glMap2f({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define a one- or two-dimensional mesh
		/// </summary>
		/// <param name="un">
		/// Specifies the number of partitions in the grid range interval [<paramref name="u1"/>, <paramref name="u2"/>]. Must be 
		/// positive.
		/// </param>
		/// <param name="u1">
		/// Specify the mappings for integer grid domain values i=0 and i=un. 
		/// </param>
		/// <param name="u2">
		/// Specify the mappings for integer grid domain values i=0 and i=un. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MapGrid"/> and Gl.EvalMesh are used together to efficiently generate and evaluate a series of 
		/// evenly-spacedmap domain values. Gl.EvalMesh steps through the integer domain of a one- or two-dimensional grid, whose 
		/// rangeis the domain of the evaluation maps specified by Gl.Map1 and Gl.Map2. 
		/// <see cref="Gl.MapGrid1"/> and <see cref="Gl.MapGrid2"/> specify the linear grid mappings between the i (or i and j) 
		/// integergrid coordinates, to the u (or u and v) floating-point evaluation map coordinates. See Gl.Map1 and Gl.Map2 for 
		/// detailsof how u and v coordinates are evaluated. 
		/// <see cref="Gl.MapGrid1"/> specifies a single linear mapping such that integer grid coordinate 0 maps exactly to 
		/// <paramrefname="u1"/>, and integer grid coordinate <paramref name="un"/> maps exactly to <paramref name="u2"/>. All other 
		/// integergrid coordinates i are mapped so that 
		/// u=i⁡u2-u1un+u1 
		/// <see cref="Gl.MapGrid2"/> specifies two such linear mappings. One maps integer grid coordinate i=0 exactly to <paramref 
		/// name="u1"/>,and integer grid coordinate i=un exactly to <paramref name="u2"/>. The other maps integer grid coordinate 
		/// j=0exactly to <paramref name="v1"/>, and integer grid coordinate j=vn exactly to <paramref name="v2"/>. Other integer 
		/// gridcoordinates i and j are mapped such that 
		/// u=i⁡u2-u1un+u1 
		/// v=j⁡v2-v1vn+v1 
		/// The mappings specified by <see cref="Gl.MapGrid"/> are used identically by Gl.EvalMesh and Gl.EvalPoint. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if either <paramref name="un"/> or <paramref name="vn"/> is not positive. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.MapGrid"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MAP1_GRID_DOMAIN"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP2_GRID_DOMAIN"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP1_GRID_SEGMENTS"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP2_GRID_SEGMENTS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		public static void MapGrid1(Int32 un, double u1, double u2)
		{
			Debug.Assert(Delegates.pglMapGrid1d != null, "pglMapGrid1d not implemented");
			Delegates.pglMapGrid1d(un, u1, u2);
			CallLog("glMapGrid1d({0}, {1}, {2})", un, u1, u2);
			DebugCheckErrors();
		}

		/// <summary>
		/// define a one- or two-dimensional mesh
		/// </summary>
		/// <param name="un">
		/// Specifies the number of partitions in the grid range interval [<paramref name="u1"/>, <paramref name="u2"/>]. Must be 
		/// positive.
		/// </param>
		/// <param name="u1">
		/// Specify the mappings for integer grid domain values i=0 and i=un. 
		/// </param>
		/// <param name="u2">
		/// Specify the mappings for integer grid domain values i=0 and i=un. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MapGrid"/> and Gl.EvalMesh are used together to efficiently generate and evaluate a series of 
		/// evenly-spacedmap domain values. Gl.EvalMesh steps through the integer domain of a one- or two-dimensional grid, whose 
		/// rangeis the domain of the evaluation maps specified by Gl.Map1 and Gl.Map2. 
		/// <see cref="Gl.MapGrid1"/> and <see cref="Gl.MapGrid2"/> specify the linear grid mappings between the i (or i and j) 
		/// integergrid coordinates, to the u (or u and v) floating-point evaluation map coordinates. See Gl.Map1 and Gl.Map2 for 
		/// detailsof how u and v coordinates are evaluated. 
		/// <see cref="Gl.MapGrid1"/> specifies a single linear mapping such that integer grid coordinate 0 maps exactly to 
		/// <paramrefname="u1"/>, and integer grid coordinate <paramref name="un"/> maps exactly to <paramref name="u2"/>. All other 
		/// integergrid coordinates i are mapped so that 
		/// u=i⁡u2-u1un+u1 
		/// <see cref="Gl.MapGrid2"/> specifies two such linear mappings. One maps integer grid coordinate i=0 exactly to <paramref 
		/// name="u1"/>,and integer grid coordinate i=un exactly to <paramref name="u2"/>. The other maps integer grid coordinate 
		/// j=0exactly to <paramref name="v1"/>, and integer grid coordinate j=vn exactly to <paramref name="v2"/>. Other integer 
		/// gridcoordinates i and j are mapped such that 
		/// u=i⁡u2-u1un+u1 
		/// v=j⁡v2-v1vn+v1 
		/// The mappings specified by <see cref="Gl.MapGrid"/> are used identically by Gl.EvalMesh and Gl.EvalPoint. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if either <paramref name="un"/> or <paramref name="vn"/> is not positive. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.MapGrid"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MAP1_GRID_DOMAIN"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP2_GRID_DOMAIN"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP1_GRID_SEGMENTS"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP2_GRID_SEGMENTS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		public static void MapGrid1(Int32 un, float u1, float u2)
		{
			Debug.Assert(Delegates.pglMapGrid1f != null, "pglMapGrid1f not implemented");
			Delegates.pglMapGrid1f(un, u1, u2);
			CallLog("glMapGrid1f({0}, {1}, {2})", un, u1, u2);
			DebugCheckErrors();
		}

		/// <summary>
		/// define a one- or two-dimensional mesh
		/// </summary>
		/// <param name="un">
		/// Specifies the number of partitions in the grid range interval [<paramref name="u1"/>, <paramref name="u2"/>]. Must be 
		/// positive.
		/// </param>
		/// <param name="u1">
		/// Specify the mappings for integer grid domain values i=0 and i=un. 
		/// </param>
		/// <param name="u2">
		/// Specify the mappings for integer grid domain values i=0 and i=un. 
		/// </param>
		/// <param name="vn">
		/// Specifies the number of partitions in the grid range interval [<paramref name="v1"/>, <paramref name="v2"/>] (<see 
		/// cref="Gl.MapGrid2"/>only). 
		/// </param>
		/// <param name="v1">
		/// Specify the mappings for integer grid domain values j=0 and j=vn (<see cref="Gl.MapGrid2"/> only). 
		/// </param>
		/// <param name="v2">
		/// Specify the mappings for integer grid domain values j=0 and j=vn (<see cref="Gl.MapGrid2"/> only). 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MapGrid"/> and Gl.EvalMesh are used together to efficiently generate and evaluate a series of 
		/// evenly-spacedmap domain values. Gl.EvalMesh steps through the integer domain of a one- or two-dimensional grid, whose 
		/// rangeis the domain of the evaluation maps specified by Gl.Map1 and Gl.Map2. 
		/// <see cref="Gl.MapGrid1"/> and <see cref="Gl.MapGrid2"/> specify the linear grid mappings between the i (or i and j) 
		/// integergrid coordinates, to the u (or u and v) floating-point evaluation map coordinates. See Gl.Map1 and Gl.Map2 for 
		/// detailsof how u and v coordinates are evaluated. 
		/// <see cref="Gl.MapGrid1"/> specifies a single linear mapping such that integer grid coordinate 0 maps exactly to 
		/// <paramrefname="u1"/>, and integer grid coordinate <paramref name="un"/> maps exactly to <paramref name="u2"/>. All other 
		/// integergrid coordinates i are mapped so that 
		/// u=i⁡u2-u1un+u1 
		/// <see cref="Gl.MapGrid2"/> specifies two such linear mappings. One maps integer grid coordinate i=0 exactly to <paramref 
		/// name="u1"/>,and integer grid coordinate i=un exactly to <paramref name="u2"/>. The other maps integer grid coordinate 
		/// j=0exactly to <paramref name="v1"/>, and integer grid coordinate j=vn exactly to <paramref name="v2"/>. Other integer 
		/// gridcoordinates i and j are mapped such that 
		/// u=i⁡u2-u1un+u1 
		/// v=j⁡v2-v1vn+v1 
		/// The mappings specified by <see cref="Gl.MapGrid"/> are used identically by Gl.EvalMesh and Gl.EvalPoint. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if either <paramref name="un"/> or <paramref name="vn"/> is not positive. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.MapGrid"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MAP1_GRID_DOMAIN"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP2_GRID_DOMAIN"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP1_GRID_SEGMENTS"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP2_GRID_SEGMENTS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		public static void MapGrid2(Int32 un, double u1, double u2, Int32 vn, double v1, double v2)
		{
			Debug.Assert(Delegates.pglMapGrid2d != null, "pglMapGrid2d not implemented");
			Delegates.pglMapGrid2d(un, u1, u2, vn, v1, v2);
			CallLog("glMapGrid2d({0}, {1}, {2}, {3}, {4}, {5})", un, u1, u2, vn, v1, v2);
			DebugCheckErrors();
		}

		/// <summary>
		/// define a one- or two-dimensional mesh
		/// </summary>
		/// <param name="un">
		/// Specifies the number of partitions in the grid range interval [<paramref name="u1"/>, <paramref name="u2"/>]. Must be 
		/// positive.
		/// </param>
		/// <param name="u1">
		/// Specify the mappings for integer grid domain values i=0 and i=un. 
		/// </param>
		/// <param name="u2">
		/// Specify the mappings for integer grid domain values i=0 and i=un. 
		/// </param>
		/// <param name="vn">
		/// Specifies the number of partitions in the grid range interval [<paramref name="v1"/>, <paramref name="v2"/>] (<see 
		/// cref="Gl.MapGrid2"/>only). 
		/// </param>
		/// <param name="v1">
		/// Specify the mappings for integer grid domain values j=0 and j=vn (<see cref="Gl.MapGrid2"/> only). 
		/// </param>
		/// <param name="v2">
		/// Specify the mappings for integer grid domain values j=0 and j=vn (<see cref="Gl.MapGrid2"/> only). 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MapGrid"/> and Gl.EvalMesh are used together to efficiently generate and evaluate a series of 
		/// evenly-spacedmap domain values. Gl.EvalMesh steps through the integer domain of a one- or two-dimensional grid, whose 
		/// rangeis the domain of the evaluation maps specified by Gl.Map1 and Gl.Map2. 
		/// <see cref="Gl.MapGrid1"/> and <see cref="Gl.MapGrid2"/> specify the linear grid mappings between the i (or i and j) 
		/// integergrid coordinates, to the u (or u and v) floating-point evaluation map coordinates. See Gl.Map1 and Gl.Map2 for 
		/// detailsof how u and v coordinates are evaluated. 
		/// <see cref="Gl.MapGrid1"/> specifies a single linear mapping such that integer grid coordinate 0 maps exactly to 
		/// <paramrefname="u1"/>, and integer grid coordinate <paramref name="un"/> maps exactly to <paramref name="u2"/>. All other 
		/// integergrid coordinates i are mapped so that 
		/// u=i⁡u2-u1un+u1 
		/// <see cref="Gl.MapGrid2"/> specifies two such linear mappings. One maps integer grid coordinate i=0 exactly to <paramref 
		/// name="u1"/>,and integer grid coordinate i=un exactly to <paramref name="u2"/>. The other maps integer grid coordinate 
		/// j=0exactly to <paramref name="v1"/>, and integer grid coordinate j=vn exactly to <paramref name="v2"/>. Other integer 
		/// gridcoordinates i and j are mapped such that 
		/// u=i⁡u2-u1un+u1 
		/// v=j⁡v2-v1vn+v1 
		/// The mappings specified by <see cref="Gl.MapGrid"/> are used identically by Gl.EvalMesh and Gl.EvalPoint. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if either <paramref name="un"/> or <paramref name="vn"/> is not positive. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.MapGrid"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MAP1_GRID_DOMAIN"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP2_GRID_DOMAIN"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP1_GRID_SEGMENTS"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP2_GRID_SEGMENTS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		public static void MapGrid2(Int32 un, float u1, float u2, Int32 vn, float v1, float v2)
		{
			Debug.Assert(Delegates.pglMapGrid2f != null, "pglMapGrid2f not implemented");
			Delegates.pglMapGrid2f(un, u1, u2, vn, v1, v2);
			CallLog("glMapGrid2f({0}, {1}, {2}, {3}, {4}, {5})", un, u1, u2, vn, v1, v2);
			DebugCheckErrors();
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.EvalCoord1"/> evaluates enabled one-dimensional maps at argument <paramref name="u"/>. <see 
		/// cref="Gl.EvalCoord2"/>does the same for two-dimensional maps using two domain values, <paramref name="u"/> and <paramref 
		/// name="v"/>.To define a map, call Gl.Map1 and Gl.Map2; to enable and disable it, call Gl.Enable and Gl.Disable. 
		/// When one of the <see cref="Gl.EvalCoord"/> commands is issued, all currently enabled maps of the indicated dimension are 
		/// evaluated.Then, for each enabled map, it is as if the corresponding GL command had been issued with the computed value. 
		/// Thatis, if <see cref="Gl.MAP1_INDEX"/> or <see cref="Gl.MAP2_INDEX"/> is enabled, a Gl.Index command is simulated. If 
		/// <seecref="Gl.MAP1_COLOR_4"/> or <see cref="Gl.MAP2_COLOR_4"/> is enabled, a Gl.Color command is simulated. If <see 
		/// cref="Gl.MAP1_NORMAL"/>or <see cref="Gl.MAP2_NORMAL"/> is enabled, a normal vector is produced, and if any of <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_1"/>,<see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see cref="Gl.MAP1_TEXTURE_COORD_3"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_4"/>,<see cref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_3"/>,or <see cref="Gl.MAP2_TEXTURE_COORD_4"/> is enabled, then an appropriate Gl.TexCoord 
		/// commandis simulated. 
		/// For color, color index, normal, and texture coordinates the GL uses evaluated values instead of current values for those 
		/// evaluationsthat are enabled, and current values otherwise, However, the evaluated values do not update the current 
		/// values.Thus, if Gl.Vertex commands are interspersed with <see cref="Gl.EvalCoord"/> commands, the color, normal, and 
		/// texturecoordinates associated with the Gl.Vertex commands are not affected by the values generated by the <see 
		/// cref="Gl.EvalCoord"/>commands, but only by the most recent Gl.Color, Gl.Index, Gl.Normal, and Gl.TexCoord commands. 
		/// No commands are issued for maps that are not enabled. If more than one texture evaluation is enabled for a particular 
		/// dimension(for example, <see cref="Gl.MAP2_TEXTURE_COORD_1"/> and <see cref="Gl.MAP2_TEXTURE_COORD_2"/>), then only the 
		/// evaluationof the map that produces the larger number of coordinates (in this case, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_2"/>)is carried out. <see cref="Gl.MAP1_VERTEX_4"/> overrides <see 
		/// cref="Gl.MAP1_VERTEX_3"/>,and <see cref="Gl.MAP2_VERTEX_4"/> overrides <see cref="Gl.MAP2_VERTEX_3"/>, in the same 
		/// manner.If neither a three- nor a four-component vertex map is enabled for the specified dimension, the <see 
		/// cref="Gl.EvalCoord"/>command is ignored. 
		/// If you have enabled automatic normal generation, by calling Gl.Enable with argument <see cref="Gl.AUTO_NORMAL"/>, <see 
		/// cref="Gl.EvalCoord2"/>generates surface normals analytically, regardless of the contents or enabling of the <see 
		/// cref="Gl.MAP2_NORMAL"/>map. Let 
		/// m=∂p∂u×∂p∂v 
		/// Then the generated normal n is n=mm 
		/// If automatic normal generation is disabled, the corresponding normal map <see cref="Gl.MAP2_NORMAL"/>, if enabled, is 
		/// usedto produce a normal. If neither automatic normal generation nor a normal map is enabled, no normal is generated for 
		/// <seecref="Gl.EvalCoord2"/> commands. 
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.AUTO_NORMAL"/> 
		/// - Gl.GetMap 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void EvalCoord1(double u)
		{
			Debug.Assert(Delegates.pglEvalCoord1d != null, "pglEvalCoord1d not implemented");
			Delegates.pglEvalCoord1d(u);
			CallLog("glEvalCoord1d({0})", u);
			DebugCheckErrors();
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.EvalCoord1"/> evaluates enabled one-dimensional maps at argument <paramref name="u"/>. <see 
		/// cref="Gl.EvalCoord2"/>does the same for two-dimensional maps using two domain values, <paramref name="u"/> and <paramref 
		/// name="v"/>.To define a map, call Gl.Map1 and Gl.Map2; to enable and disable it, call Gl.Enable and Gl.Disable. 
		/// When one of the <see cref="Gl.EvalCoord"/> commands is issued, all currently enabled maps of the indicated dimension are 
		/// evaluated.Then, for each enabled map, it is as if the corresponding GL command had been issued with the computed value. 
		/// Thatis, if <see cref="Gl.MAP1_INDEX"/> or <see cref="Gl.MAP2_INDEX"/> is enabled, a Gl.Index command is simulated. If 
		/// <seecref="Gl.MAP1_COLOR_4"/> or <see cref="Gl.MAP2_COLOR_4"/> is enabled, a Gl.Color command is simulated. If <see 
		/// cref="Gl.MAP1_NORMAL"/>or <see cref="Gl.MAP2_NORMAL"/> is enabled, a normal vector is produced, and if any of <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_1"/>,<see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see cref="Gl.MAP1_TEXTURE_COORD_3"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_4"/>,<see cref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_3"/>,or <see cref="Gl.MAP2_TEXTURE_COORD_4"/> is enabled, then an appropriate Gl.TexCoord 
		/// commandis simulated. 
		/// For color, color index, normal, and texture coordinates the GL uses evaluated values instead of current values for those 
		/// evaluationsthat are enabled, and current values otherwise, However, the evaluated values do not update the current 
		/// values.Thus, if Gl.Vertex commands are interspersed with <see cref="Gl.EvalCoord"/> commands, the color, normal, and 
		/// texturecoordinates associated with the Gl.Vertex commands are not affected by the values generated by the <see 
		/// cref="Gl.EvalCoord"/>commands, but only by the most recent Gl.Color, Gl.Index, Gl.Normal, and Gl.TexCoord commands. 
		/// No commands are issued for maps that are not enabled. If more than one texture evaluation is enabled for a particular 
		/// dimension(for example, <see cref="Gl.MAP2_TEXTURE_COORD_1"/> and <see cref="Gl.MAP2_TEXTURE_COORD_2"/>), then only the 
		/// evaluationof the map that produces the larger number of coordinates (in this case, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_2"/>)is carried out. <see cref="Gl.MAP1_VERTEX_4"/> overrides <see 
		/// cref="Gl.MAP1_VERTEX_3"/>,and <see cref="Gl.MAP2_VERTEX_4"/> overrides <see cref="Gl.MAP2_VERTEX_3"/>, in the same 
		/// manner.If neither a three- nor a four-component vertex map is enabled for the specified dimension, the <see 
		/// cref="Gl.EvalCoord"/>command is ignored. 
		/// If you have enabled automatic normal generation, by calling Gl.Enable with argument <see cref="Gl.AUTO_NORMAL"/>, <see 
		/// cref="Gl.EvalCoord2"/>generates surface normals analytically, regardless of the contents or enabling of the <see 
		/// cref="Gl.MAP2_NORMAL"/>map. Let 
		/// m=∂p∂u×∂p∂v 
		/// Then the generated normal n is n=mm 
		/// If automatic normal generation is disabled, the corresponding normal map <see cref="Gl.MAP2_NORMAL"/>, if enabled, is 
		/// usedto produce a normal. If neither automatic normal generation nor a normal map is enabled, no normal is generated for 
		/// <seecref="Gl.EvalCoord2"/> commands. 
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.AUTO_NORMAL"/> 
		/// - Gl.GetMap 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void EvalCoord1(double[] u)
		{
			unsafe {
				fixed (double* p_u = u)
				{
					Debug.Assert(Delegates.pglEvalCoord1dv != null, "pglEvalCoord1dv not implemented");
					Delegates.pglEvalCoord1dv(p_u);
					CallLog("glEvalCoord1dv({0})", u);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.EvalCoord1"/> evaluates enabled one-dimensional maps at argument <paramref name="u"/>. <see 
		/// cref="Gl.EvalCoord2"/>does the same for two-dimensional maps using two domain values, <paramref name="u"/> and <paramref 
		/// name="v"/>.To define a map, call Gl.Map1 and Gl.Map2; to enable and disable it, call Gl.Enable and Gl.Disable. 
		/// When one of the <see cref="Gl.EvalCoord"/> commands is issued, all currently enabled maps of the indicated dimension are 
		/// evaluated.Then, for each enabled map, it is as if the corresponding GL command had been issued with the computed value. 
		/// Thatis, if <see cref="Gl.MAP1_INDEX"/> or <see cref="Gl.MAP2_INDEX"/> is enabled, a Gl.Index command is simulated. If 
		/// <seecref="Gl.MAP1_COLOR_4"/> or <see cref="Gl.MAP2_COLOR_4"/> is enabled, a Gl.Color command is simulated. If <see 
		/// cref="Gl.MAP1_NORMAL"/>or <see cref="Gl.MAP2_NORMAL"/> is enabled, a normal vector is produced, and if any of <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_1"/>,<see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see cref="Gl.MAP1_TEXTURE_COORD_3"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_4"/>,<see cref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_3"/>,or <see cref="Gl.MAP2_TEXTURE_COORD_4"/> is enabled, then an appropriate Gl.TexCoord 
		/// commandis simulated. 
		/// For color, color index, normal, and texture coordinates the GL uses evaluated values instead of current values for those 
		/// evaluationsthat are enabled, and current values otherwise, However, the evaluated values do not update the current 
		/// values.Thus, if Gl.Vertex commands are interspersed with <see cref="Gl.EvalCoord"/> commands, the color, normal, and 
		/// texturecoordinates associated with the Gl.Vertex commands are not affected by the values generated by the <see 
		/// cref="Gl.EvalCoord"/>commands, but only by the most recent Gl.Color, Gl.Index, Gl.Normal, and Gl.TexCoord commands. 
		/// No commands are issued for maps that are not enabled. If more than one texture evaluation is enabled for a particular 
		/// dimension(for example, <see cref="Gl.MAP2_TEXTURE_COORD_1"/> and <see cref="Gl.MAP2_TEXTURE_COORD_2"/>), then only the 
		/// evaluationof the map that produces the larger number of coordinates (in this case, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_2"/>)is carried out. <see cref="Gl.MAP1_VERTEX_4"/> overrides <see 
		/// cref="Gl.MAP1_VERTEX_3"/>,and <see cref="Gl.MAP2_VERTEX_4"/> overrides <see cref="Gl.MAP2_VERTEX_3"/>, in the same 
		/// manner.If neither a three- nor a four-component vertex map is enabled for the specified dimension, the <see 
		/// cref="Gl.EvalCoord"/>command is ignored. 
		/// If you have enabled automatic normal generation, by calling Gl.Enable with argument <see cref="Gl.AUTO_NORMAL"/>, <see 
		/// cref="Gl.EvalCoord2"/>generates surface normals analytically, regardless of the contents or enabling of the <see 
		/// cref="Gl.MAP2_NORMAL"/>map. Let 
		/// m=∂p∂u×∂p∂v 
		/// Then the generated normal n is n=mm 
		/// If automatic normal generation is disabled, the corresponding normal map <see cref="Gl.MAP2_NORMAL"/>, if enabled, is 
		/// usedto produce a normal. If neither automatic normal generation nor a normal map is enabled, no normal is generated for 
		/// <seecref="Gl.EvalCoord2"/> commands. 
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.AUTO_NORMAL"/> 
		/// - Gl.GetMap 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void EvalCoord1(float u)
		{
			Debug.Assert(Delegates.pglEvalCoord1f != null, "pglEvalCoord1f not implemented");
			Delegates.pglEvalCoord1f(u);
			CallLog("glEvalCoord1f({0})", u);
			DebugCheckErrors();
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.EvalCoord1"/> evaluates enabled one-dimensional maps at argument <paramref name="u"/>. <see 
		/// cref="Gl.EvalCoord2"/>does the same for two-dimensional maps using two domain values, <paramref name="u"/> and <paramref 
		/// name="v"/>.To define a map, call Gl.Map1 and Gl.Map2; to enable and disable it, call Gl.Enable and Gl.Disable. 
		/// When one of the <see cref="Gl.EvalCoord"/> commands is issued, all currently enabled maps of the indicated dimension are 
		/// evaluated.Then, for each enabled map, it is as if the corresponding GL command had been issued with the computed value. 
		/// Thatis, if <see cref="Gl.MAP1_INDEX"/> or <see cref="Gl.MAP2_INDEX"/> is enabled, a Gl.Index command is simulated. If 
		/// <seecref="Gl.MAP1_COLOR_4"/> or <see cref="Gl.MAP2_COLOR_4"/> is enabled, a Gl.Color command is simulated. If <see 
		/// cref="Gl.MAP1_NORMAL"/>or <see cref="Gl.MAP2_NORMAL"/> is enabled, a normal vector is produced, and if any of <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_1"/>,<see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see cref="Gl.MAP1_TEXTURE_COORD_3"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_4"/>,<see cref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_3"/>,or <see cref="Gl.MAP2_TEXTURE_COORD_4"/> is enabled, then an appropriate Gl.TexCoord 
		/// commandis simulated. 
		/// For color, color index, normal, and texture coordinates the GL uses evaluated values instead of current values for those 
		/// evaluationsthat are enabled, and current values otherwise, However, the evaluated values do not update the current 
		/// values.Thus, if Gl.Vertex commands are interspersed with <see cref="Gl.EvalCoord"/> commands, the color, normal, and 
		/// texturecoordinates associated with the Gl.Vertex commands are not affected by the values generated by the <see 
		/// cref="Gl.EvalCoord"/>commands, but only by the most recent Gl.Color, Gl.Index, Gl.Normal, and Gl.TexCoord commands. 
		/// No commands are issued for maps that are not enabled. If more than one texture evaluation is enabled for a particular 
		/// dimension(for example, <see cref="Gl.MAP2_TEXTURE_COORD_1"/> and <see cref="Gl.MAP2_TEXTURE_COORD_2"/>), then only the 
		/// evaluationof the map that produces the larger number of coordinates (in this case, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_2"/>)is carried out. <see cref="Gl.MAP1_VERTEX_4"/> overrides <see 
		/// cref="Gl.MAP1_VERTEX_3"/>,and <see cref="Gl.MAP2_VERTEX_4"/> overrides <see cref="Gl.MAP2_VERTEX_3"/>, in the same 
		/// manner.If neither a three- nor a four-component vertex map is enabled for the specified dimension, the <see 
		/// cref="Gl.EvalCoord"/>command is ignored. 
		/// If you have enabled automatic normal generation, by calling Gl.Enable with argument <see cref="Gl.AUTO_NORMAL"/>, <see 
		/// cref="Gl.EvalCoord2"/>generates surface normals analytically, regardless of the contents or enabling of the <see 
		/// cref="Gl.MAP2_NORMAL"/>map. Let 
		/// m=∂p∂u×∂p∂v 
		/// Then the generated normal n is n=mm 
		/// If automatic normal generation is disabled, the corresponding normal map <see cref="Gl.MAP2_NORMAL"/>, if enabled, is 
		/// usedto produce a normal. If neither automatic normal generation nor a normal map is enabled, no normal is generated for 
		/// <seecref="Gl.EvalCoord2"/> commands. 
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.AUTO_NORMAL"/> 
		/// - Gl.GetMap 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void EvalCoord1(float[] u)
		{
			unsafe {
				fixed (float* p_u = u)
				{
					Debug.Assert(Delegates.pglEvalCoord1fv != null, "pglEvalCoord1fv not implemented");
					Delegates.pglEvalCoord1fv(p_u);
					CallLog("glEvalCoord1fv({0})", u);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <param name="v">
		/// Specifies a value that is the domain coordinate v to the basis function defined in a previous Gl\.Map2 command. This 
		/// argumentis not present in a <see cref="Gl.EvalCoord1"/> command. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.EvalCoord1"/> evaluates enabled one-dimensional maps at argument <paramref name="u"/>. <see 
		/// cref="Gl.EvalCoord2"/>does the same for two-dimensional maps using two domain values, <paramref name="u"/> and <paramref 
		/// name="v"/>.To define a map, call Gl.Map1 and Gl.Map2; to enable and disable it, call Gl.Enable and Gl.Disable. 
		/// When one of the <see cref="Gl.EvalCoord"/> commands is issued, all currently enabled maps of the indicated dimension are 
		/// evaluated.Then, for each enabled map, it is as if the corresponding GL command had been issued with the computed value. 
		/// Thatis, if <see cref="Gl.MAP1_INDEX"/> or <see cref="Gl.MAP2_INDEX"/> is enabled, a Gl.Index command is simulated. If 
		/// <seecref="Gl.MAP1_COLOR_4"/> or <see cref="Gl.MAP2_COLOR_4"/> is enabled, a Gl.Color command is simulated. If <see 
		/// cref="Gl.MAP1_NORMAL"/>or <see cref="Gl.MAP2_NORMAL"/> is enabled, a normal vector is produced, and if any of <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_1"/>,<see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see cref="Gl.MAP1_TEXTURE_COORD_3"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_4"/>,<see cref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_3"/>,or <see cref="Gl.MAP2_TEXTURE_COORD_4"/> is enabled, then an appropriate Gl.TexCoord 
		/// commandis simulated. 
		/// For color, color index, normal, and texture coordinates the GL uses evaluated values instead of current values for those 
		/// evaluationsthat are enabled, and current values otherwise, However, the evaluated values do not update the current 
		/// values.Thus, if Gl.Vertex commands are interspersed with <see cref="Gl.EvalCoord"/> commands, the color, normal, and 
		/// texturecoordinates associated with the Gl.Vertex commands are not affected by the values generated by the <see 
		/// cref="Gl.EvalCoord"/>commands, but only by the most recent Gl.Color, Gl.Index, Gl.Normal, and Gl.TexCoord commands. 
		/// No commands are issued for maps that are not enabled. If more than one texture evaluation is enabled for a particular 
		/// dimension(for example, <see cref="Gl.MAP2_TEXTURE_COORD_1"/> and <see cref="Gl.MAP2_TEXTURE_COORD_2"/>), then only the 
		/// evaluationof the map that produces the larger number of coordinates (in this case, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_2"/>)is carried out. <see cref="Gl.MAP1_VERTEX_4"/> overrides <see 
		/// cref="Gl.MAP1_VERTEX_3"/>,and <see cref="Gl.MAP2_VERTEX_4"/> overrides <see cref="Gl.MAP2_VERTEX_3"/>, in the same 
		/// manner.If neither a three- nor a four-component vertex map is enabled for the specified dimension, the <see 
		/// cref="Gl.EvalCoord"/>command is ignored. 
		/// If you have enabled automatic normal generation, by calling Gl.Enable with argument <see cref="Gl.AUTO_NORMAL"/>, <see 
		/// cref="Gl.EvalCoord2"/>generates surface normals analytically, regardless of the contents or enabling of the <see 
		/// cref="Gl.MAP2_NORMAL"/>map. Let 
		/// m=∂p∂u×∂p∂v 
		/// Then the generated normal n is n=mm 
		/// If automatic normal generation is disabled, the corresponding normal map <see cref="Gl.MAP2_NORMAL"/>, if enabled, is 
		/// usedto produce a normal. If neither automatic normal generation nor a normal map is enabled, no normal is generated for 
		/// <seecref="Gl.EvalCoord2"/> commands. 
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.AUTO_NORMAL"/> 
		/// - Gl.GetMap 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void EvalCoord2(double u, double v)
		{
			Debug.Assert(Delegates.pglEvalCoord2d != null, "pglEvalCoord2d not implemented");
			Delegates.pglEvalCoord2d(u, v);
			CallLog("glEvalCoord2d({0}, {1})", u, v);
			DebugCheckErrors();
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.EvalCoord1"/> evaluates enabled one-dimensional maps at argument <paramref name="u"/>. <see 
		/// cref="Gl.EvalCoord2"/>does the same for two-dimensional maps using two domain values, <paramref name="u"/> and <paramref 
		/// name="v"/>.To define a map, call Gl.Map1 and Gl.Map2; to enable and disable it, call Gl.Enable and Gl.Disable. 
		/// When one of the <see cref="Gl.EvalCoord"/> commands is issued, all currently enabled maps of the indicated dimension are 
		/// evaluated.Then, for each enabled map, it is as if the corresponding GL command had been issued with the computed value. 
		/// Thatis, if <see cref="Gl.MAP1_INDEX"/> or <see cref="Gl.MAP2_INDEX"/> is enabled, a Gl.Index command is simulated. If 
		/// <seecref="Gl.MAP1_COLOR_4"/> or <see cref="Gl.MAP2_COLOR_4"/> is enabled, a Gl.Color command is simulated. If <see 
		/// cref="Gl.MAP1_NORMAL"/>or <see cref="Gl.MAP2_NORMAL"/> is enabled, a normal vector is produced, and if any of <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_1"/>,<see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see cref="Gl.MAP1_TEXTURE_COORD_3"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_4"/>,<see cref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_3"/>,or <see cref="Gl.MAP2_TEXTURE_COORD_4"/> is enabled, then an appropriate Gl.TexCoord 
		/// commandis simulated. 
		/// For color, color index, normal, and texture coordinates the GL uses evaluated values instead of current values for those 
		/// evaluationsthat are enabled, and current values otherwise, However, the evaluated values do not update the current 
		/// values.Thus, if Gl.Vertex commands are interspersed with <see cref="Gl.EvalCoord"/> commands, the color, normal, and 
		/// texturecoordinates associated with the Gl.Vertex commands are not affected by the values generated by the <see 
		/// cref="Gl.EvalCoord"/>commands, but only by the most recent Gl.Color, Gl.Index, Gl.Normal, and Gl.TexCoord commands. 
		/// No commands are issued for maps that are not enabled. If more than one texture evaluation is enabled for a particular 
		/// dimension(for example, <see cref="Gl.MAP2_TEXTURE_COORD_1"/> and <see cref="Gl.MAP2_TEXTURE_COORD_2"/>), then only the 
		/// evaluationof the map that produces the larger number of coordinates (in this case, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_2"/>)is carried out. <see cref="Gl.MAP1_VERTEX_4"/> overrides <see 
		/// cref="Gl.MAP1_VERTEX_3"/>,and <see cref="Gl.MAP2_VERTEX_4"/> overrides <see cref="Gl.MAP2_VERTEX_3"/>, in the same 
		/// manner.If neither a three- nor a four-component vertex map is enabled for the specified dimension, the <see 
		/// cref="Gl.EvalCoord"/>command is ignored. 
		/// If you have enabled automatic normal generation, by calling Gl.Enable with argument <see cref="Gl.AUTO_NORMAL"/>, <see 
		/// cref="Gl.EvalCoord2"/>generates surface normals analytically, regardless of the contents or enabling of the <see 
		/// cref="Gl.MAP2_NORMAL"/>map. Let 
		/// m=∂p∂u×∂p∂v 
		/// Then the generated normal n is n=mm 
		/// If automatic normal generation is disabled, the corresponding normal map <see cref="Gl.MAP2_NORMAL"/>, if enabled, is 
		/// usedto produce a normal. If neither automatic normal generation nor a normal map is enabled, no normal is generated for 
		/// <seecref="Gl.EvalCoord2"/> commands. 
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.AUTO_NORMAL"/> 
		/// - Gl.GetMap 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void EvalCoord2(double[] u)
		{
			unsafe {
				fixed (double* p_u = u)
				{
					Debug.Assert(Delegates.pglEvalCoord2dv != null, "pglEvalCoord2dv not implemented");
					Delegates.pglEvalCoord2dv(p_u);
					CallLog("glEvalCoord2dv({0})", u);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <param name="v">
		/// Specifies a value that is the domain coordinate v to the basis function defined in a previous Gl\.Map2 command. This 
		/// argumentis not present in a <see cref="Gl.EvalCoord1"/> command. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.EvalCoord1"/> evaluates enabled one-dimensional maps at argument <paramref name="u"/>. <see 
		/// cref="Gl.EvalCoord2"/>does the same for two-dimensional maps using two domain values, <paramref name="u"/> and <paramref 
		/// name="v"/>.To define a map, call Gl.Map1 and Gl.Map2; to enable and disable it, call Gl.Enable and Gl.Disable. 
		/// When one of the <see cref="Gl.EvalCoord"/> commands is issued, all currently enabled maps of the indicated dimension are 
		/// evaluated.Then, for each enabled map, it is as if the corresponding GL command had been issued with the computed value. 
		/// Thatis, if <see cref="Gl.MAP1_INDEX"/> or <see cref="Gl.MAP2_INDEX"/> is enabled, a Gl.Index command is simulated. If 
		/// <seecref="Gl.MAP1_COLOR_4"/> or <see cref="Gl.MAP2_COLOR_4"/> is enabled, a Gl.Color command is simulated. If <see 
		/// cref="Gl.MAP1_NORMAL"/>or <see cref="Gl.MAP2_NORMAL"/> is enabled, a normal vector is produced, and if any of <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_1"/>,<see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see cref="Gl.MAP1_TEXTURE_COORD_3"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_4"/>,<see cref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_3"/>,or <see cref="Gl.MAP2_TEXTURE_COORD_4"/> is enabled, then an appropriate Gl.TexCoord 
		/// commandis simulated. 
		/// For color, color index, normal, and texture coordinates the GL uses evaluated values instead of current values for those 
		/// evaluationsthat are enabled, and current values otherwise, However, the evaluated values do not update the current 
		/// values.Thus, if Gl.Vertex commands are interspersed with <see cref="Gl.EvalCoord"/> commands, the color, normal, and 
		/// texturecoordinates associated with the Gl.Vertex commands are not affected by the values generated by the <see 
		/// cref="Gl.EvalCoord"/>commands, but only by the most recent Gl.Color, Gl.Index, Gl.Normal, and Gl.TexCoord commands. 
		/// No commands are issued for maps that are not enabled. If more than one texture evaluation is enabled for a particular 
		/// dimension(for example, <see cref="Gl.MAP2_TEXTURE_COORD_1"/> and <see cref="Gl.MAP2_TEXTURE_COORD_2"/>), then only the 
		/// evaluationof the map that produces the larger number of coordinates (in this case, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_2"/>)is carried out. <see cref="Gl.MAP1_VERTEX_4"/> overrides <see 
		/// cref="Gl.MAP1_VERTEX_3"/>,and <see cref="Gl.MAP2_VERTEX_4"/> overrides <see cref="Gl.MAP2_VERTEX_3"/>, in the same 
		/// manner.If neither a three- nor a four-component vertex map is enabled for the specified dimension, the <see 
		/// cref="Gl.EvalCoord"/>command is ignored. 
		/// If you have enabled automatic normal generation, by calling Gl.Enable with argument <see cref="Gl.AUTO_NORMAL"/>, <see 
		/// cref="Gl.EvalCoord2"/>generates surface normals analytically, regardless of the contents or enabling of the <see 
		/// cref="Gl.MAP2_NORMAL"/>map. Let 
		/// m=∂p∂u×∂p∂v 
		/// Then the generated normal n is n=mm 
		/// If automatic normal generation is disabled, the corresponding normal map <see cref="Gl.MAP2_NORMAL"/>, if enabled, is 
		/// usedto produce a normal. If neither automatic normal generation nor a normal map is enabled, no normal is generated for 
		/// <seecref="Gl.EvalCoord2"/> commands. 
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.AUTO_NORMAL"/> 
		/// - Gl.GetMap 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void EvalCoord2(float u, float v)
		{
			Debug.Assert(Delegates.pglEvalCoord2f != null, "pglEvalCoord2f not implemented");
			Delegates.pglEvalCoord2f(u, v);
			CallLog("glEvalCoord2f({0}, {1})", u, v);
			DebugCheckErrors();
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.EvalCoord1"/> evaluates enabled one-dimensional maps at argument <paramref name="u"/>. <see 
		/// cref="Gl.EvalCoord2"/>does the same for two-dimensional maps using two domain values, <paramref name="u"/> and <paramref 
		/// name="v"/>.To define a map, call Gl.Map1 and Gl.Map2; to enable and disable it, call Gl.Enable and Gl.Disable. 
		/// When one of the <see cref="Gl.EvalCoord"/> commands is issued, all currently enabled maps of the indicated dimension are 
		/// evaluated.Then, for each enabled map, it is as if the corresponding GL command had been issued with the computed value. 
		/// Thatis, if <see cref="Gl.MAP1_INDEX"/> or <see cref="Gl.MAP2_INDEX"/> is enabled, a Gl.Index command is simulated. If 
		/// <seecref="Gl.MAP1_COLOR_4"/> or <see cref="Gl.MAP2_COLOR_4"/> is enabled, a Gl.Color command is simulated. If <see 
		/// cref="Gl.MAP1_NORMAL"/>or <see cref="Gl.MAP2_NORMAL"/> is enabled, a normal vector is produced, and if any of <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_1"/>,<see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see cref="Gl.MAP1_TEXTURE_COORD_3"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_4"/>,<see cref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_3"/>,or <see cref="Gl.MAP2_TEXTURE_COORD_4"/> is enabled, then an appropriate Gl.TexCoord 
		/// commandis simulated. 
		/// For color, color index, normal, and texture coordinates the GL uses evaluated values instead of current values for those 
		/// evaluationsthat are enabled, and current values otherwise, However, the evaluated values do not update the current 
		/// values.Thus, if Gl.Vertex commands are interspersed with <see cref="Gl.EvalCoord"/> commands, the color, normal, and 
		/// texturecoordinates associated with the Gl.Vertex commands are not affected by the values generated by the <see 
		/// cref="Gl.EvalCoord"/>commands, but only by the most recent Gl.Color, Gl.Index, Gl.Normal, and Gl.TexCoord commands. 
		/// No commands are issued for maps that are not enabled. If more than one texture evaluation is enabled for a particular 
		/// dimension(for example, <see cref="Gl.MAP2_TEXTURE_COORD_1"/> and <see cref="Gl.MAP2_TEXTURE_COORD_2"/>), then only the 
		/// evaluationof the map that produces the larger number of coordinates (in this case, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_2"/>)is carried out. <see cref="Gl.MAP1_VERTEX_4"/> overrides <see 
		/// cref="Gl.MAP1_VERTEX_3"/>,and <see cref="Gl.MAP2_VERTEX_4"/> overrides <see cref="Gl.MAP2_VERTEX_3"/>, in the same 
		/// manner.If neither a three- nor a four-component vertex map is enabled for the specified dimension, the <see 
		/// cref="Gl.EvalCoord"/>command is ignored. 
		/// If you have enabled automatic normal generation, by calling Gl.Enable with argument <see cref="Gl.AUTO_NORMAL"/>, <see 
		/// cref="Gl.EvalCoord2"/>generates surface normals analytically, regardless of the contents or enabling of the <see 
		/// cref="Gl.MAP2_NORMAL"/>map. Let 
		/// m=∂p∂u×∂p∂v 
		/// Then the generated normal n is n=mm 
		/// If automatic normal generation is disabled, the corresponding normal map <see cref="Gl.MAP2_NORMAL"/>, if enabled, is 
		/// usedto produce a normal. If neither automatic normal generation nor a normal map is enabled, no normal is generated for 
		/// <seecref="Gl.EvalCoord2"/> commands. 
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP1_TEXTURE_COORD_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_VERTEX_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_INDEX"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_COLOR_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_NORMAL"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_1"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_2"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_3"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.MAP2_TEXTURE_COORD_4"/> 
		/// - Gl.IsEnabled with argument <see cref="Gl.AUTO_NORMAL"/> 
		/// - Gl.GetMap 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void EvalCoord2(float[] u)
		{
			unsafe {
				fixed (float* p_u = u)
				{
					Debug.Assert(Delegates.pglEvalCoord2fv != null, "pglEvalCoord2fv not implemented");
					Delegates.pglEvalCoord2fv(p_u);
					CallLog("glEvalCoord2fv({0})", u);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// compute a one- or two-dimensional grid of points or lines
		/// </summary>
		/// <param name="mode">
		/// In <see cref="Gl.EvalMesh1"/>, specifies whether to compute a one-dimensional mesh of points or lines. Symbolic 
		/// constants<see cref="Gl.POINT"/> and <see cref="Gl.LINE"/> are accepted. 
		/// </param>
		/// <param name="i1">
		/// Specify the first and last integer values for grid domain variable i. 
		/// </param>
		/// <param name="i2">
		/// Specify the first and last integer values for grid domain variable i. 
		/// </param>
		/// <remarks>
		/// Gl.MapGrid and <see cref="Gl.EvalMesh"/> are used in tandem to efficiently generate and evaluate a series of 
		/// evenly-spacedmap domain values. <see cref="Gl.EvalMesh"/> steps through the integer domain of a one- or two-dimensional 
		/// grid,whose range is the domain of the evaluation maps specified by Gl.Map1 and Gl.Map2. <paramref name="mode"/> 
		/// determineswhether the resulting vertices are connected as points, lines, or filled polygons. 
		/// In the one-dimensional case, <see cref="Gl.EvalMesh1"/>, the mesh is generated as if the following code fragment were 
		/// executed:
		/// @code glBegin( @endcode <paramref name="type"/> @code );for ( i = @endcode <paramref name="i1"/> @code ; i &lt;= 
		/// @endcode<paramref name="i2"/> @code ; i += 1 ) glEvalCoord1( @endcode i·Δu+u1 @code );glEnd(); @endcode where 
		/// Δu=u2-u1n 
		/// and n, u1, and u2 are the arguments to the most recent Gl.MapGrid1 command. type is <see cref="Gl.POINTS"/> if <paramref 
		/// name="mode"/>is <see cref="Gl.POINT"/>, or <see cref="Gl.LINES"/> if <paramref name="mode"/> is <see cref="Gl.LINE"/>. 
		/// The one absolute numeric requirement is that if i=n, then the value computed from i·Δu+u1 is exactly u2. 
		/// In the two-dimensional case, <see cref="Gl.EvalMesh2"/>, let .cp Δu=u2-u1n 
		/// Δv=v2-v1m 
		/// where n, u1, u2, m, v1, and v2 are the arguments to the most recent Gl.MapGrid2 command. Then, if <paramref 
		/// name="mode"/>is <see cref="Gl.FILL"/>, the <see cref="Gl.EvalMesh2"/> command is equivalent to: 
		/// @code for ( j = @endcode <paramref name="j1"/> @code ; j &lt; @endcode <paramref name="j2"/> @code ; j += 1 ) { glBegin( 
		/// GL_QUAD_STRIP); for ( i = @endcode <paramref name="i1"/> @code ; i &lt;= @endcode <paramref name="i2"/> @code ; i += 1 ) 
		/// {glEvalCoord2( @endcode i·Δu+u1,j·Δv+v1 @code ); glEvalCoord2( @endcode i·Δu+u1,j+1·Δv+v1 @code ); } glEnd();} @endcode 
		/// If <paramref name="mode"/> is <see cref="Gl.LINE"/>, then a call to <see cref="Gl.EvalMesh2"/> is equivalent to: 
		/// @code for ( j = @endcode <paramref name="j1"/> @code ; j &lt;= @endcode <paramref name="j2"/> @code ; j += 1 ) { 
		/// glBegin(GL_LINE_STRIP ); for ( i = @endcode <paramref name="i1"/> @code ; i &lt;= @endcode <paramref name="i2"/> @code ; 
		/// i+= 1 ) glEvalCoord2( @endcode i·Δu+u1,j·Δv+v1 @code ); glEnd();}for ( i = @endcode <paramref name="i1"/> @code ; i 
		/// &lt;=@endcode <paramref name="i2"/> @code ; i += 1 ) { glBegin( GL_LINE_STRIP ); for ( j = @endcode <paramref 
		/// name="j1"/>@code ; j &lt;= @endcode <paramref name="j1"/> @code ; j += 1 ) glEvalCoord2( @endcode i·Δu+u1,j·Δv+v1 @code 
		/// );glEnd();} @endcode 
		/// And finally, if <paramref name="mode"/> is <see cref="Gl.POINT"/>, then a call to <see cref="Gl.EvalMesh2"/> is 
		/// equivalentto: 
		/// @code glBegin( GL_POINTS );for ( j = @endcode <paramref name="j1"/> @code ; j &lt;= @endcode <paramref name="j2"/> @code 
		/// ;j += 1 ) for ( i = @endcode <paramref name="i1"/> @code ; i &lt;= @endcode <paramref name="i2"/> @code ; i += 1 ) 
		/// glEvalCoord2(@endcode i·Δu+u1,j·Δv+v1 @code );glEnd(); @endcode 
		/// In all three cases, the only absolute numeric requirements are that if i=n, then the value computed from i·Δu+u1 is 
		/// exactlyu2, and if j=m, then the value computed from j·Δv+v1 is exactly v2. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="mode"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.EvalMesh"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MAP1_GRID_DOMAIN"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP2_GRID_DOMAIN"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP1_GRID_SEGMENTS"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP2_GRID_SEGMENTS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		public static void EvalMesh1(int mode, Int32 i1, Int32 i2)
		{
			Debug.Assert(Delegates.pglEvalMesh1 != null, "pglEvalMesh1 not implemented");
			Delegates.pglEvalMesh1(mode, i1, i2);
			CallLog("glEvalMesh1({0}, {1}, {2})", mode, i1, i2);
			DebugCheckErrors();
		}

		/// <summary>
		/// compute a one- or two-dimensional grid of points or lines
		/// </summary>
		/// <param name="mode">
		/// In <see cref="Gl.EvalMesh1"/>, specifies whether to compute a one-dimensional mesh of points or lines. Symbolic 
		/// constants<see cref="Gl.POINT"/> and <see cref="Gl.LINE"/> are accepted. 
		/// </param>
		/// <param name="i1">
		/// Specify the first and last integer values for grid domain variable i. 
		/// </param>
		/// <param name="i2">
		/// Specify the first and last integer values for grid domain variable i. 
		/// </param>
		/// <remarks>
		/// Gl.MapGrid and <see cref="Gl.EvalMesh"/> are used in tandem to efficiently generate and evaluate a series of 
		/// evenly-spacedmap domain values. <see cref="Gl.EvalMesh"/> steps through the integer domain of a one- or two-dimensional 
		/// grid,whose range is the domain of the evaluation maps specified by Gl.Map1 and Gl.Map2. <paramref name="mode"/> 
		/// determineswhether the resulting vertices are connected as points, lines, or filled polygons. 
		/// In the one-dimensional case, <see cref="Gl.EvalMesh1"/>, the mesh is generated as if the following code fragment were 
		/// executed:
		/// @code glBegin( @endcode <paramref name="type"/> @code );for ( i = @endcode <paramref name="i1"/> @code ; i &lt;= 
		/// @endcode<paramref name="i2"/> @code ; i += 1 ) glEvalCoord1( @endcode i·Δu+u1 @code );glEnd(); @endcode where 
		/// Δu=u2-u1n 
		/// and n, u1, and u2 are the arguments to the most recent Gl.MapGrid1 command. type is <see cref="Gl.POINTS"/> if <paramref 
		/// name="mode"/>is <see cref="Gl.POINT"/>, or <see cref="Gl.LINES"/> if <paramref name="mode"/> is <see cref="Gl.LINE"/>. 
		/// The one absolute numeric requirement is that if i=n, then the value computed from i·Δu+u1 is exactly u2. 
		/// In the two-dimensional case, <see cref="Gl.EvalMesh2"/>, let .cp Δu=u2-u1n 
		/// Δv=v2-v1m 
		/// where n, u1, u2, m, v1, and v2 are the arguments to the most recent Gl.MapGrid2 command. Then, if <paramref 
		/// name="mode"/>is <see cref="Gl.FILL"/>, the <see cref="Gl.EvalMesh2"/> command is equivalent to: 
		/// @code for ( j = @endcode <paramref name="j1"/> @code ; j &lt; @endcode <paramref name="j2"/> @code ; j += 1 ) { glBegin( 
		/// GL_QUAD_STRIP); for ( i = @endcode <paramref name="i1"/> @code ; i &lt;= @endcode <paramref name="i2"/> @code ; i += 1 ) 
		/// {glEvalCoord2( @endcode i·Δu+u1,j·Δv+v1 @code ); glEvalCoord2( @endcode i·Δu+u1,j+1·Δv+v1 @code ); } glEnd();} @endcode 
		/// If <paramref name="mode"/> is <see cref="Gl.LINE"/>, then a call to <see cref="Gl.EvalMesh2"/> is equivalent to: 
		/// @code for ( j = @endcode <paramref name="j1"/> @code ; j &lt;= @endcode <paramref name="j2"/> @code ; j += 1 ) { 
		/// glBegin(GL_LINE_STRIP ); for ( i = @endcode <paramref name="i1"/> @code ; i &lt;= @endcode <paramref name="i2"/> @code ; 
		/// i+= 1 ) glEvalCoord2( @endcode i·Δu+u1,j·Δv+v1 @code ); glEnd();}for ( i = @endcode <paramref name="i1"/> @code ; i 
		/// &lt;=@endcode <paramref name="i2"/> @code ; i += 1 ) { glBegin( GL_LINE_STRIP ); for ( j = @endcode <paramref 
		/// name="j1"/>@code ; j &lt;= @endcode <paramref name="j1"/> @code ; j += 1 ) glEvalCoord2( @endcode i·Δu+u1,j·Δv+v1 @code 
		/// );glEnd();} @endcode 
		/// And finally, if <paramref name="mode"/> is <see cref="Gl.POINT"/>, then a call to <see cref="Gl.EvalMesh2"/> is 
		/// equivalentto: 
		/// @code glBegin( GL_POINTS );for ( j = @endcode <paramref name="j1"/> @code ; j &lt;= @endcode <paramref name="j2"/> @code 
		/// ;j += 1 ) for ( i = @endcode <paramref name="i1"/> @code ; i &lt;= @endcode <paramref name="i2"/> @code ; i += 1 ) 
		/// glEvalCoord2(@endcode i·Δu+u1,j·Δv+v1 @code );glEnd(); @endcode 
		/// In all three cases, the only absolute numeric requirements are that if i=n, then the value computed from i·Δu+u1 is 
		/// exactlyu2, and if j=m, then the value computed from j·Δv+v1 is exactly v2. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="mode"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.EvalMesh"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MAP1_GRID_DOMAIN"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP2_GRID_DOMAIN"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP1_GRID_SEGMENTS"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP2_GRID_SEGMENTS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		public static void EvalMesh1(MeshMode1 mode, Int32 i1, Int32 i2)
		{
			Debug.Assert(Delegates.pglEvalMesh1 != null, "pglEvalMesh1 not implemented");
			Delegates.pglEvalMesh1((int)mode, i1, i2);
			CallLog("glEvalMesh1({0}, {1}, {2})", mode, i1, i2);
			DebugCheckErrors();
		}

		/// <summary>
		/// generate and evaluate a single point in a mesh
		/// </summary>
		/// <param name="i">
		/// Specifies the integer value for grid domain variable i. 
		/// </param>
		/// <remarks>
		/// Gl.MapGrid and Gl.EvalMesh are used in tandem to efficiently generate and evaluate a series of evenly spaced map domain 
		/// values.<see cref="Gl.EvalPoint"/> can be used to evaluate a single grid point in the same gridspace that is traversed by 
		/// Gl.EvalMesh.Calling <see cref="Gl.EvalPoint1"/> is equivalent to calling @code glEvalCoord1( @endcode i·Δu+u1 @code ); 
		/// @endcodewhere Δu=u2-u1n 
		/// and n, u1, and u2 are the arguments to the most recent Gl.MapGrid1 command. The one absolute numeric requirement is that 
		/// ifi=n, then the value computed from i·Δu+u1 is exactly u2. 
		/// In the two-dimensional case, <see cref="Gl.EvalPoint2"/>, let 
		/// Δu=u2-u1n @htmlonly <informalequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: DELTA v = ( v sub 2 - v sub 1 ) / 
		/// m:--><mml:mrow><mml:mrow><mml:mo>Δ</mml:mo><mml:mi
		/// mathvariant="italic">v</mml:mi></mml:mrow><mml:mo>=</mml:mo><mml:mfrac><mml:mfencedopen="(" 
		/// close=")"><mml:mrow><mml:msub><mml:mi
		/// mathvariant="italic">v</mml:mi><mml:mn>2</mml:mn></mml:msub><mml:mo>-</mml:mo><mml:msub><mml:mi
		/// mathvariant="italic">v</mml:mi><mml:mn>1</mml:mn></mml:msub></mml:mrow></mml:mfenced><mml:mi
		/// mathvariant="italic">m</mml:mi></mml:mfrac></mml:mrow></mml:math></informalequation>@endhtmlonly 
		/// where n, u1, u2, m, v1, and v2 are the arguments to the most recent Gl.MapGrid2 command. Then the <see 
		/// cref="Gl.EvalPoint2"/>command is equivalent to calling @code glEvalCoord2( @endcode i·Δu+u1,j·Δv+v1 @code ); @endcode 
		/// Theonly absolute numeric requirements are that if i=n, then the value computed from i·Δu+u1 is exactly u2, and if j=m, 
		/// thenthe value computed from j·Δv+v1 is exactly v2. 
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MAP1_GRID_DOMAIN"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP2_GRID_DOMAIN"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP1_GRID_SEGMENTS"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP2_GRID_SEGMENTS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		public static void EvalPoint1(Int32 i)
		{
			Debug.Assert(Delegates.pglEvalPoint1 != null, "pglEvalPoint1 not implemented");
			Delegates.pglEvalPoint1(i);
			CallLog("glEvalPoint1({0})", i);
			DebugCheckErrors();
		}

		/// <summary>
		/// compute a one- or two-dimensional grid of points or lines
		/// </summary>
		/// <param name="mode">
		/// In <see cref="Gl.EvalMesh1"/>, specifies whether to compute a one-dimensional mesh of points or lines. Symbolic 
		/// constants<see cref="Gl.POINT"/> and <see cref="Gl.LINE"/> are accepted. 
		/// </param>
		/// <param name="i1">
		/// Specify the first and last integer values for grid domain variable i. 
		/// </param>
		/// <param name="i2">
		/// Specify the first and last integer values for grid domain variable i. 
		/// </param>
		/// <param name="j1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="j2">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// Gl.MapGrid and <see cref="Gl.EvalMesh"/> are used in tandem to efficiently generate and evaluate a series of 
		/// evenly-spacedmap domain values. <see cref="Gl.EvalMesh"/> steps through the integer domain of a one- or two-dimensional 
		/// grid,whose range is the domain of the evaluation maps specified by Gl.Map1 and Gl.Map2. <paramref name="mode"/> 
		/// determineswhether the resulting vertices are connected as points, lines, or filled polygons. 
		/// In the one-dimensional case, <see cref="Gl.EvalMesh1"/>, the mesh is generated as if the following code fragment were 
		/// executed:
		/// @code glBegin( @endcode <paramref name="type"/> @code );for ( i = @endcode <paramref name="i1"/> @code ; i &lt;= 
		/// @endcode<paramref name="i2"/> @code ; i += 1 ) glEvalCoord1( @endcode i·Δu+u1 @code );glEnd(); @endcode where 
		/// Δu=u2-u1n 
		/// and n, u1, and u2 are the arguments to the most recent Gl.MapGrid1 command. type is <see cref="Gl.POINTS"/> if <paramref 
		/// name="mode"/>is <see cref="Gl.POINT"/>, or <see cref="Gl.LINES"/> if <paramref name="mode"/> is <see cref="Gl.LINE"/>. 
		/// The one absolute numeric requirement is that if i=n, then the value computed from i·Δu+u1 is exactly u2. 
		/// In the two-dimensional case, <see cref="Gl.EvalMesh2"/>, let .cp Δu=u2-u1n 
		/// Δv=v2-v1m 
		/// where n, u1, u2, m, v1, and v2 are the arguments to the most recent Gl.MapGrid2 command. Then, if <paramref 
		/// name="mode"/>is <see cref="Gl.FILL"/>, the <see cref="Gl.EvalMesh2"/> command is equivalent to: 
		/// @code for ( j = @endcode <paramref name="j1"/> @code ; j &lt; @endcode <paramref name="j2"/> @code ; j += 1 ) { glBegin( 
		/// GL_QUAD_STRIP); for ( i = @endcode <paramref name="i1"/> @code ; i &lt;= @endcode <paramref name="i2"/> @code ; i += 1 ) 
		/// {glEvalCoord2( @endcode i·Δu+u1,j·Δv+v1 @code ); glEvalCoord2( @endcode i·Δu+u1,j+1·Δv+v1 @code ); } glEnd();} @endcode 
		/// If <paramref name="mode"/> is <see cref="Gl.LINE"/>, then a call to <see cref="Gl.EvalMesh2"/> is equivalent to: 
		/// @code for ( j = @endcode <paramref name="j1"/> @code ; j &lt;= @endcode <paramref name="j2"/> @code ; j += 1 ) { 
		/// glBegin(GL_LINE_STRIP ); for ( i = @endcode <paramref name="i1"/> @code ; i &lt;= @endcode <paramref name="i2"/> @code ; 
		/// i+= 1 ) glEvalCoord2( @endcode i·Δu+u1,j·Δv+v1 @code ); glEnd();}for ( i = @endcode <paramref name="i1"/> @code ; i 
		/// &lt;=@endcode <paramref name="i2"/> @code ; i += 1 ) { glBegin( GL_LINE_STRIP ); for ( j = @endcode <paramref 
		/// name="j1"/>@code ; j &lt;= @endcode <paramref name="j1"/> @code ; j += 1 ) glEvalCoord2( @endcode i·Δu+u1,j·Δv+v1 @code 
		/// );glEnd();} @endcode 
		/// And finally, if <paramref name="mode"/> is <see cref="Gl.POINT"/>, then a call to <see cref="Gl.EvalMesh2"/> is 
		/// equivalentto: 
		/// @code glBegin( GL_POINTS );for ( j = @endcode <paramref name="j1"/> @code ; j &lt;= @endcode <paramref name="j2"/> @code 
		/// ;j += 1 ) for ( i = @endcode <paramref name="i1"/> @code ; i &lt;= @endcode <paramref name="i2"/> @code ; i += 1 ) 
		/// glEvalCoord2(@endcode i·Δu+u1,j·Δv+v1 @code );glEnd(); @endcode 
		/// In all three cases, the only absolute numeric requirements are that if i=n, then the value computed from i·Δu+u1 is 
		/// exactlyu2, and if j=m, then the value computed from j·Δv+v1 is exactly v2. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="mode"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.EvalMesh"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MAP1_GRID_DOMAIN"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP2_GRID_DOMAIN"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP1_GRID_SEGMENTS"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP2_GRID_SEGMENTS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		public static void EvalMesh2(int mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2)
		{
			Debug.Assert(Delegates.pglEvalMesh2 != null, "pglEvalMesh2 not implemented");
			Delegates.pglEvalMesh2(mode, i1, i2, j1, j2);
			CallLog("glEvalMesh2({0}, {1}, {2}, {3}, {4})", mode, i1, i2, j1, j2);
			DebugCheckErrors();
		}

		/// <summary>
		/// compute a one- or two-dimensional grid of points or lines
		/// </summary>
		/// <param name="mode">
		/// In <see cref="Gl.EvalMesh1"/>, specifies whether to compute a one-dimensional mesh of points or lines. Symbolic 
		/// constants<see cref="Gl.POINT"/> and <see cref="Gl.LINE"/> are accepted. 
		/// </param>
		/// <param name="i1">
		/// Specify the first and last integer values for grid domain variable i. 
		/// </param>
		/// <param name="i2">
		/// Specify the first and last integer values for grid domain variable i. 
		/// </param>
		/// <param name="j1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="j2">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// Gl.MapGrid and <see cref="Gl.EvalMesh"/> are used in tandem to efficiently generate and evaluate a series of 
		/// evenly-spacedmap domain values. <see cref="Gl.EvalMesh"/> steps through the integer domain of a one- or two-dimensional 
		/// grid,whose range is the domain of the evaluation maps specified by Gl.Map1 and Gl.Map2. <paramref name="mode"/> 
		/// determineswhether the resulting vertices are connected as points, lines, or filled polygons. 
		/// In the one-dimensional case, <see cref="Gl.EvalMesh1"/>, the mesh is generated as if the following code fragment were 
		/// executed:
		/// @code glBegin( @endcode <paramref name="type"/> @code );for ( i = @endcode <paramref name="i1"/> @code ; i &lt;= 
		/// @endcode<paramref name="i2"/> @code ; i += 1 ) glEvalCoord1( @endcode i·Δu+u1 @code );glEnd(); @endcode where 
		/// Δu=u2-u1n 
		/// and n, u1, and u2 are the arguments to the most recent Gl.MapGrid1 command. type is <see cref="Gl.POINTS"/> if <paramref 
		/// name="mode"/>is <see cref="Gl.POINT"/>, or <see cref="Gl.LINES"/> if <paramref name="mode"/> is <see cref="Gl.LINE"/>. 
		/// The one absolute numeric requirement is that if i=n, then the value computed from i·Δu+u1 is exactly u2. 
		/// In the two-dimensional case, <see cref="Gl.EvalMesh2"/>, let .cp Δu=u2-u1n 
		/// Δv=v2-v1m 
		/// where n, u1, u2, m, v1, and v2 are the arguments to the most recent Gl.MapGrid2 command. Then, if <paramref 
		/// name="mode"/>is <see cref="Gl.FILL"/>, the <see cref="Gl.EvalMesh2"/> command is equivalent to: 
		/// @code for ( j = @endcode <paramref name="j1"/> @code ; j &lt; @endcode <paramref name="j2"/> @code ; j += 1 ) { glBegin( 
		/// GL_QUAD_STRIP); for ( i = @endcode <paramref name="i1"/> @code ; i &lt;= @endcode <paramref name="i2"/> @code ; i += 1 ) 
		/// {glEvalCoord2( @endcode i·Δu+u1,j·Δv+v1 @code ); glEvalCoord2( @endcode i·Δu+u1,j+1·Δv+v1 @code ); } glEnd();} @endcode 
		/// If <paramref name="mode"/> is <see cref="Gl.LINE"/>, then a call to <see cref="Gl.EvalMesh2"/> is equivalent to: 
		/// @code for ( j = @endcode <paramref name="j1"/> @code ; j &lt;= @endcode <paramref name="j2"/> @code ; j += 1 ) { 
		/// glBegin(GL_LINE_STRIP ); for ( i = @endcode <paramref name="i1"/> @code ; i &lt;= @endcode <paramref name="i2"/> @code ; 
		/// i+= 1 ) glEvalCoord2( @endcode i·Δu+u1,j·Δv+v1 @code ); glEnd();}for ( i = @endcode <paramref name="i1"/> @code ; i 
		/// &lt;=@endcode <paramref name="i2"/> @code ; i += 1 ) { glBegin( GL_LINE_STRIP ); for ( j = @endcode <paramref 
		/// name="j1"/>@code ; j &lt;= @endcode <paramref name="j1"/> @code ; j += 1 ) glEvalCoord2( @endcode i·Δu+u1,j·Δv+v1 @code 
		/// );glEnd();} @endcode 
		/// And finally, if <paramref name="mode"/> is <see cref="Gl.POINT"/>, then a call to <see cref="Gl.EvalMesh2"/> is 
		/// equivalentto: 
		/// @code glBegin( GL_POINTS );for ( j = @endcode <paramref name="j1"/> @code ; j &lt;= @endcode <paramref name="j2"/> @code 
		/// ;j += 1 ) for ( i = @endcode <paramref name="i1"/> @code ; i &lt;= @endcode <paramref name="i2"/> @code ; i += 1 ) 
		/// glEvalCoord2(@endcode i·Δu+u1,j·Δv+v1 @code );glEnd(); @endcode 
		/// In all three cases, the only absolute numeric requirements are that if i=n, then the value computed from i·Δu+u1 is 
		/// exactlyu2, and if j=m, then the value computed from j·Δv+v1 is exactly v2. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="mode"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.EvalMesh"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MAP1_GRID_DOMAIN"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP2_GRID_DOMAIN"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP1_GRID_SEGMENTS"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP2_GRID_SEGMENTS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		public static void EvalMesh2(MeshMode2 mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2)
		{
			Debug.Assert(Delegates.pglEvalMesh2 != null, "pglEvalMesh2 not implemented");
			Delegates.pglEvalMesh2((int)mode, i1, i2, j1, j2);
			CallLog("glEvalMesh2({0}, {1}, {2}, {3}, {4})", mode, i1, i2, j1, j2);
			DebugCheckErrors();
		}

		/// <summary>
		/// generate and evaluate a single point in a mesh
		/// </summary>
		/// <param name="i">
		/// Specifies the integer value for grid domain variable i. 
		/// </param>
		/// <param name="j">
		/// Specifies the integer value for grid domain variable j (<see cref="Gl.EvalPoint2"/> only). 
		/// </param>
		/// <remarks>
		/// Gl.MapGrid and Gl.EvalMesh are used in tandem to efficiently generate and evaluate a series of evenly spaced map domain 
		/// values.<see cref="Gl.EvalPoint"/> can be used to evaluate a single grid point in the same gridspace that is traversed by 
		/// Gl.EvalMesh.Calling <see cref="Gl.EvalPoint1"/> is equivalent to calling @code glEvalCoord1( @endcode i·Δu+u1 @code ); 
		/// @endcodewhere Δu=u2-u1n 
		/// and n, u1, and u2 are the arguments to the most recent Gl.MapGrid1 command. The one absolute numeric requirement is that 
		/// ifi=n, then the value computed from i·Δu+u1 is exactly u2. 
		/// In the two-dimensional case, <see cref="Gl.EvalPoint2"/>, let 
		/// Δu=u2-u1n @htmlonly <informalequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: DELTA v = ( v sub 2 - v sub 1 ) / 
		/// m:--><mml:mrow><mml:mrow><mml:mo>Δ</mml:mo><mml:mi
		/// mathvariant="italic">v</mml:mi></mml:mrow><mml:mo>=</mml:mo><mml:mfrac><mml:mfencedopen="(" 
		/// close=")"><mml:mrow><mml:msub><mml:mi
		/// mathvariant="italic">v</mml:mi><mml:mn>2</mml:mn></mml:msub><mml:mo>-</mml:mo><mml:msub><mml:mi
		/// mathvariant="italic">v</mml:mi><mml:mn>1</mml:mn></mml:msub></mml:mrow></mml:mfenced><mml:mi
		/// mathvariant="italic">m</mml:mi></mml:mfrac></mml:mrow></mml:math></informalequation>@endhtmlonly 
		/// where n, u1, u2, m, v1, and v2 are the arguments to the most recent Gl.MapGrid2 command. Then the <see 
		/// cref="Gl.EvalPoint2"/>command is equivalent to calling @code glEvalCoord2( @endcode i·Δu+u1,j·Δv+v1 @code ); @endcode 
		/// Theonly absolute numeric requirements are that if i=n, then the value computed from i·Δu+u1 is exactly u2, and if j=m, 
		/// thenthe value computed from j·Δv+v1 is exactly v2. 
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MAP1_GRID_DOMAIN"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP2_GRID_DOMAIN"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP1_GRID_SEGMENTS"/> 
		/// - Gl.Get with argument <see cref="Gl.MAP2_GRID_SEGMENTS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		public static void EvalPoint2(Int32 i, Int32 j)
		{
			Debug.Assert(Delegates.pglEvalPoint2 != null, "pglEvalPoint2 not implemented");
			Delegates.pglEvalPoint2(i, j);
			CallLog("glEvalPoint2({0}, {1})", i, j);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glAlphaFunc.
		/// </summary>
		/// <param name="func">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void AlphaFunc(int func, float @ref)
		{
			Debug.Assert(Delegates.pglAlphaFunc != null, "pglAlphaFunc not implemented");
			Delegates.pglAlphaFunc(func, @ref);
			CallLog("glAlphaFunc({0}, {1})", func, @ref);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glAlphaFunc.
		/// </summary>
		/// <param name="func">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void AlphaFunc(AlphaFunction func, float @ref)
		{
			Debug.Assert(Delegates.pglAlphaFunc != null, "pglAlphaFunc not implemented");
			Delegates.pglAlphaFunc((int)func, @ref);
			CallLog("glAlphaFunc({0}, {1})", func, @ref);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the pixel zoom factors
		/// </summary>
		/// <param name="xfactor">
		/// Specify the x and y zoom factors for pixel write operations. 
		/// </param>
		/// <param name="yfactor">
		/// Specify the x and y zoom factors for pixel write operations. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.PixelZoom"/> specifies values for the x and y zoom factors. During the execution of Gl.DrawPixels or 
		/// Gl.CopyPixels,if (xr, yr) is the current raster position, and a given element is in the mth row and nth column of the 
		/// pixelrectangle, then pixels whose centers are in the rectangle with corners at 
		/// (xr+n·xfactor, yr+m·yfactor) 
		/// (xr+n+1·xfactor, yr+m+1·yfactor) 
		/// are candidates for replacement. Any pixel whose center lies on the bottom or left edge of this rectangular region is 
		/// alsomodified. 
		/// Pixel zoom factors are not limited to positive values. Negative zoom factors reflect the resulting image about the 
		/// currentraster position. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.PixelZoom"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.ZOOM_X"/> 
		/// - Gl.Get with argument <see cref="Gl.ZOOM_Y"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawPixels"/>
		public static void PixelZoom(float xfactor, float yfactor)
		{
			Debug.Assert(Delegates.pglPixelZoom != null, "pglPixelZoom not implemented");
			Delegates.pglPixelZoom(xfactor, yfactor);
			CallLog("glPixelZoom({0}, {1})", xfactor, yfactor);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPixelTransferf.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void PixelTransfer(int pname, float param)
		{
			Debug.Assert(Delegates.pglPixelTransferf != null, "pglPixelTransferf not implemented");
			Delegates.pglPixelTransferf(pname, param);
			CallLog("glPixelTransferf({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPixelTransferf.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void PixelTransfer(PixelTransferParameter pname, float param)
		{
			Debug.Assert(Delegates.pglPixelTransferf != null, "pglPixelTransferf not implemented");
			Delegates.pglPixelTransferf((int)pname, param);
			CallLog("glPixelTransferf({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPixelTransferi.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void PixelTransfer(int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglPixelTransferi != null, "pglPixelTransferi not implemented");
			Delegates.pglPixelTransferi(pname, param);
			CallLog("glPixelTransferi({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPixelTransferi.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void PixelTransfer(PixelTransferParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglPixelTransferi != null, "pglPixelTransferi not implemented");
			Delegates.pglPixelTransferi((int)pname, param);
			CallLog("glPixelTransferi({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPixelMapfv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="mapsize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void PixelMap(int map, Int32 mapsize, float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapfv != null, "pglPixelMapfv not implemented");
					Delegates.pglPixelMapfv(map, mapsize, p_values);
					CallLog("glPixelMapfv({0}, {1}, {2})", map, mapsize, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPixelMapfv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="mapsize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void PixelMap(PixelMap map, Int32 mapsize, float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapfv != null, "pglPixelMapfv not implemented");
					Delegates.pglPixelMapfv((int)map, mapsize, p_values);
					CallLog("glPixelMapfv({0}, {1}, {2})", map, mapsize, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPixelMapuiv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="mapsize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void PixelMap(int map, Int32 mapsize, UInt32[] values)
		{
			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapuiv != null, "pglPixelMapuiv not implemented");
					Delegates.pglPixelMapuiv(map, mapsize, p_values);
					CallLog("glPixelMapuiv({0}, {1}, {2})", map, mapsize, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPixelMapuiv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="mapsize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void PixelMap(PixelMap map, Int32 mapsize, UInt32[] values)
		{
			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapuiv != null, "pglPixelMapuiv not implemented");
					Delegates.pglPixelMapuiv((int)map, mapsize, p_values);
					CallLog("glPixelMapuiv({0}, {1}, {2})", map, mapsize, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPixelMapusv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="mapsize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void PixelMap(int map, Int32 mapsize, UInt16[] values)
		{
			unsafe {
				fixed (UInt16* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapusv != null, "pglPixelMapusv not implemented");
					Delegates.pglPixelMapusv(map, mapsize, p_values);
					CallLog("glPixelMapusv({0}, {1}, {2})", map, mapsize, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPixelMapusv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="mapsize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void PixelMap(PixelMap map, Int32 mapsize, UInt16[] values)
		{
			unsafe {
				fixed (UInt16* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapusv != null, "pglPixelMapusv not implemented");
					Delegates.pglPixelMapusv((int)map, mapsize, p_values);
					CallLog("glPixelMapusv({0}, {1}, {2})", map, mapsize, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// copy pixels in the frame buffer
		/// </summary>
		/// <param name="x">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. 
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. 
		/// </param>
		/// <param name="width">
		/// Specify the dimensions of the rectangular region of pixels to be copied. Both must be nonnegative. 
		/// </param>
		/// <param name="height">
		/// Specify the dimensions of the rectangular region of pixels to be copied. Both must be nonnegative. 
		/// </param>
		/// <param name="type">
		/// Specifies whether color values, depth values, or stencil values are to be copied. Symbolic constants <see 
		/// cref="Gl.COLOR"/>,<see cref="Gl.DEPTH"/>, and <see cref="Gl.STENCIL"/> are accepted. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.CopyPixels"/> copies a screen-aligned rectangle of pixels from the specified frame buffer location to a 
		/// regionrelative to the current raster position. Its operation is well defined only if the entire pixel source region is 
		/// withinthe exposed portion of the window. Results of copies from outside the window, or from regions of the window that 
		/// arenot exposed, are hardware dependent and undefined. 
		/// <paramref name="x"/> and <paramref name="y"/> specify the window coordinates of the lower left corner of the rectangular 
		/// regionto be copied. <paramref name="width"/> and <paramref name="height"/> specify the dimensions of the rectangular 
		/// regionto be copied. Both <paramref name="width"/> and <paramref name="height"/> must not be negative. 
		/// Several parameters control the processing of the pixel data while it is being copied. These parameters are set with 
		/// threecommands: Gl.PixelTransfer, Gl.PixelMap, and Gl.PixelZoom. This reference page describes the effects on <see 
		/// cref="Gl.CopyPixels"/>of most, but not all, of the parameters specified by these three commands. 
		/// <see cref="Gl.CopyPixels"/> copies values from each pixel with the lower left-hand corner at x+iy+j for 0&lt;=i&lt;width 
		/// and0&lt;=j&lt;height. This pixel is said to be the ith pixel in the jth row. Pixels are copied in row order from the 
		/// lowestto the highest row, left to right in each row. 
		/// <paramref name="type"/> specifies whether color, depth, or stencil data is to be copied. The details of the transfer for 
		/// eachdata type are as follows: 
		/// The rasterization described thus far assumes pixel zoom factors of 1.0. If Gl.PixelZoom is used to change the x and y 
		/// pixelzoom factors, pixels are converted to fragments as follows. If xryr is the current raster position, and a given 
		/// pixelis in the ith location in the jth row of the source pixel rectangle, then fragments are generated for pixels whose 
		/// centersare in the rectangle with corners at 
		/// xr+zoomx⁢iyr+zoomy⁢j 
		/// and 
		/// xr+zoomx⁡i+1yr+zoomy⁡j+1 
		/// where zoomx is the value of <see cref="Gl.ZOOM_X"/> and zoomy is the value of <see cref="Gl.ZOOM_Y"/>. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if either <paramref name="width"/> or <paramref name="height"/> is negative. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is <see cref="Gl.DEPTH"/> and there is no 
		///   depthbuffer. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is <see cref="Gl.STENCIL"/> and there is no 
		///   stencilbuffer. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CopyPixels"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/> 
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.WindowPos"/>
		public static void CopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, int type)
		{
			Debug.Assert(Delegates.pglCopyPixels != null, "pglCopyPixels not implemented");
			Delegates.pglCopyPixels(x, y, width, height, type);
			CallLog("glCopyPixels({0}, {1}, {2}, {3}, {4})", x, y, width, height, type);
			DebugCheckErrors();
		}

		/// <summary>
		/// copy pixels in the frame buffer
		/// </summary>
		/// <param name="x">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. 
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied. 
		/// </param>
		/// <param name="width">
		/// Specify the dimensions of the rectangular region of pixels to be copied. Both must be nonnegative. 
		/// </param>
		/// <param name="height">
		/// Specify the dimensions of the rectangular region of pixels to be copied. Both must be nonnegative. 
		/// </param>
		/// <param name="type">
		/// Specifies whether color values, depth values, or stencil values are to be copied. Symbolic constants <see 
		/// cref="Gl.COLOR"/>,<see cref="Gl.DEPTH"/>, and <see cref="Gl.STENCIL"/> are accepted. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.CopyPixels"/> copies a screen-aligned rectangle of pixels from the specified frame buffer location to a 
		/// regionrelative to the current raster position. Its operation is well defined only if the entire pixel source region is 
		/// withinthe exposed portion of the window. Results of copies from outside the window, or from regions of the window that 
		/// arenot exposed, are hardware dependent and undefined. 
		/// <paramref name="x"/> and <paramref name="y"/> specify the window coordinates of the lower left corner of the rectangular 
		/// regionto be copied. <paramref name="width"/> and <paramref name="height"/> specify the dimensions of the rectangular 
		/// regionto be copied. Both <paramref name="width"/> and <paramref name="height"/> must not be negative. 
		/// Several parameters control the processing of the pixel data while it is being copied. These parameters are set with 
		/// threecommands: Gl.PixelTransfer, Gl.PixelMap, and Gl.PixelZoom. This reference page describes the effects on <see 
		/// cref="Gl.CopyPixels"/>of most, but not all, of the parameters specified by these three commands. 
		/// <see cref="Gl.CopyPixels"/> copies values from each pixel with the lower left-hand corner at x+iy+j for 0&lt;=i&lt;width 
		/// and0&lt;=j&lt;height. This pixel is said to be the ith pixel in the jth row. Pixels are copied in row order from the 
		/// lowestto the highest row, left to right in each row. 
		/// <paramref name="type"/> specifies whether color, depth, or stencil data is to be copied. The details of the transfer for 
		/// eachdata type are as follows: 
		/// The rasterization described thus far assumes pixel zoom factors of 1.0. If Gl.PixelZoom is used to change the x and y 
		/// pixelzoom factors, pixels are converted to fragments as follows. If xryr is the current raster position, and a given 
		/// pixelis in the ith location in the jth row of the source pixel rectangle, then fragments are generated for pixels whose 
		/// centersare in the rectangle with corners at 
		/// xr+zoomx⁢iyr+zoomy⁢j 
		/// and 
		/// xr+zoomx⁡i+1yr+zoomy⁡j+1 
		/// where zoomx is the value of <see cref="Gl.ZOOM_X"/> and zoomy is the value of <see cref="Gl.ZOOM_Y"/>. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is not an accepted value. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if either <paramref name="width"/> or <paramref name="height"/> is negative. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is <see cref="Gl.DEPTH"/> and there is no 
		///   depthbuffer. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="type"/> is <see cref="Gl.STENCIL"/> and there is no 
		///   stencilbuffer. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CopyPixels"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/> 
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.WindowPos"/>
		public static void CopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelCopyType type)
		{
			Debug.Assert(Delegates.pglCopyPixels != null, "pglCopyPixels not implemented");
			Delegates.pglCopyPixels(x, y, width, height, (int)type);
			CallLog("glCopyPixels({0}, {1}, {2}, {3}, {4})", x, y, width, height, type);
			DebugCheckErrors();
		}

		/// <summary>
		/// write a block of pixels to the frame buffer
		/// </summary>
		/// <param name="width">
		/// Specify the dimensions of the pixel rectangle to be written into the frame buffer. 
		/// </param>
		/// <param name="height">
		/// Specify the dimensions of the pixel rectangle to be written into the frame buffer. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. Symbolic constants <see cref="Gl.COLOR_INDEX"/>, <see cref="Gl.STENCIL_INDEX"/>, 
		/// <seecref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see 
		/// cref="Gl.BGRA"/>,<see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see 
		/// cref="Gl.LUMINANCE"/>,and <see cref="Gl.LUMINANCE_ALPHA"/> are accepted. 
		/// </param>
		/// <param name="type">
		/// Specifies the data type for <paramref name="data"/>. Symbolic constants <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>,<see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>,<see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>,<see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <seecref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>,<see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <seecref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>are accepted. 
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.DrawPixels"/> reads pixel data from memory and writes it into the frame buffer relative to the current 
		/// rasterposition, provided that the raster position is valid. Use Gl.RasterPos or Gl.WindowPos to set the current raster 
		/// position;use Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/> to determine if the specified raster 
		/// positionis valid, and Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/> to query the raster position. 
		/// Several parameters define the encoding of pixel data in memory and control the processing of the pixel data before it is 
		/// placedin the frame buffer. These parameters are set with four commands: Gl.PixelStore, Gl.PixelTransfer, Gl.PixelMap, 
		/// andGl.PixelZoom. This reference page describes the effects on <see cref="Gl.DrawPixels"/> of many, but not all, of the 
		/// parametersspecified by these four commands. 
		/// Data is read from <paramref name="data"/> as a sequence of signed or unsigned bytes, signed or unsigned shorts, signed 
		/// orunsigned integers, or single-precision floating-point values, depending on <paramref name="type"/>. When <paramref 
		/// name="type"/>is one of <see cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.BYTE"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see 
		/// cref="Gl.SHORT"/>,<see cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, or <see cref="Gl.FLOAT"/> each of these bytes, 
		/// shorts,integers, or floating-point values is interpreted as one color or depth component, or one index, depending on 
		/// <paramrefname="format"/>. When <paramref name="type"/> is one of <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_6_5"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see 
		/// cref="Gl.UNSIGNED_INT_8_8_8_8"/>,or <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, each unsigned value is interpreted as 
		/// containingall the components for a single pixel, with the color components arranged according to <paramref 
		/// name="format"/>.When <paramref name="type"/> is one of <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>,<see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, or <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>,each unsigned value is interpreted as containing all color components, specified 
		/// by<paramref name="format"/>, for a single pixel in a reversed order. Indices are always treated individually. Color 
		/// componentsare treated as groups of one, two, three, or four values, again based on <paramref name="format"/>. Both 
		/// individualindices and groups of components are referred to as pixels. If <paramref name="type"/> is <see 
		/// cref="Gl.BITMAP"/>,the data must be unsigned bytes, and <paramref name="format"/> must be either <see 
		/// cref="Gl.COLOR_INDEX"/>or <see cref="Gl.STENCIL_INDEX"/>. Each unsigned byte is treated as eight 1-bit pixels, with bit 
		/// orderingdetermined by <see cref="Gl.UNPACK_LSB_FIRST"/> (see Gl.PixelStore). 
		/// width×height pixels are read from memory, starting at location <paramref name="data"/>. By default, these pixels are 
		/// takenfrom adjacent memory locations, except that after all <paramref name="width"/> pixels are read, the read pointer is 
		/// advancedto the next four-byte boundary. The four-byte row alignment is specified by Gl.PixelStore with argument <see 
		/// cref="Gl.UNPACK_ALIGNMENT"/>,and it can be set to one, two, four, or eight bytes. Other pixel store parameters specify 
		/// differentread pointer advancements, both before the first pixel is read and after all <paramref name="width"/> pixels 
		/// areread. See the Gl.PixelStore reference page for details on these options. 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// ablock of pixels is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store. 
		/// The width×height pixels that are read from memory are each operated on in the same way, based on the values of several 
		/// parametersspecified by Gl.PixelTransfer and Gl.PixelMap. The details of these operations, as well as the target buffer 
		/// intowhich the pixels are drawn, are specific to the format of the pixels, as specified by <paramref name="format"/>. 
		/// <paramrefname="format"/> can assume one of 13 symbolic values: 
		/// The following table summarizes the meaning of the valid constants for the type parameter: 
		/// Type Corresponding Type <see cref="Gl.UNSIGNED_BYTE"/> unsigned 8-bit integer <see cref="Gl.BYTE"/> signed 8-bit integer 
		/// <seecref="Gl.BITMAP"/> single bits in unsigned 8-bit integers <see cref="Gl.UNSIGNED_SHORT"/> unsigned 16-bit integer 
		/// <seecref="Gl.SHORT"/> signed 16-bit integer <see cref="Gl.UNSIGNED_INT"/> unsigned 32-bit integer <see cref="Gl.INT"/> 
		/// 32-bitinteger <see cref="Gl.FLOAT"/> single-precision floating-point <see cref="Gl.UNSIGNED_BYTE_3_3_2"/> unsigned 8-bit 
		/// integer<see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/> unsigned 8-bit integer with reversed component ordering <see 
		/// cref="Gl.UNSIGNED_SHORT_5_6_5"/>unsigned 16-bit integer <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> unsigned 16-bit 
		/// integerwith reversed component ordering <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/> unsigned 16-bit integer <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>unsigned 16-bit integer with reversed component ordering <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>unsigned 16-bit integer <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/> unsigned 16-bit 
		/// integerwith reversed component ordering <see cref="Gl.UNSIGNED_INT_8_8_8_8"/> unsigned 32-bit integer <see 
		/// cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>unsigned 32-bit integer with reversed component ordering <see 
		/// cref="Gl.UNSIGNED_INT_10_10_10_2"/>unsigned 32-bit integer <see cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> unsigned 32-bit 
		/// integerwith reversed component ordering 
		///  
		/// The rasterization described so far assumes pixel zoom factors of 1. If Gl.PixelZoom is used to change the x and y pixel 
		/// zoomfactors, pixels are converted to fragments as follows. If xryr is the current raster position, and a given pixel is 
		/// inthe nth column and mth row of the pixel rectangle, then fragments are generated for pixels whose centers are in the 
		/// rectanglewith corners at 
		/// xr+zoomx⁢nyr+zoomy⁢m @htmlonly <informalequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: left ( x sub r + {zoom sub x} (n + 1), y sub r + {zoom sub y} ( 
		/// m+ 1 ) right ):--><mml:mfenced open="(" close=")"><mml:mrow><mml:msub><mml:mi mathvariant="italic">x</mml:mi><mml:mi 
		/// mathvariant="italic">r</mml:mi></mml:msub><mml:mo>+</mml:mo><mml:mrow><mml:mfencedopen="" close=""><mml:msub><mml:mi 
		/// mathvariant="italic">zoom</mml:mi><mml:mi
		/// mathvariant="italic">x</mml:mi></mml:msub></mml:mfenced><mml:mo>⁡</mml:mo><mml:mfencedopen="(" 
		/// close=")"><mml:mrow><mml:mi
		/// mathvariant="italic">n</mml:mi><mml:mo>+</mml:mo><mml:mn>1</mml:mn></mml:mrow></mml:mfenced></mml:mrow></mml:mrow><mml:mrow><mml:msub><mml:mi
		/// mathvariant="italic">y</mml:mi><mml:mimathvariant="italic">r</mml:mi></mml:msub><mml:mo>+</mml:mo><mml:mrow><mml:mfenced 
		/// open=""close=""><mml:msub><mml:mi mathvariant="italic">zoom</mml:mi><mml:mi 
		/// mathvariant="italic">y</mml:mi></mml:msub></mml:mfenced><mml:mo>⁡</mml:mo><mml:mfencedopen="(" 
		/// close=")"><mml:mrow><mml:mi
		/// mathvariant="italic">m</mml:mi><mml:mo>+</mml:mo><mml:mn>1</mml:mn></mml:mrow></mml:mfenced></mml:mrow></mml:mrow></mml:mfenced></mml:math></informalequation>
		/// @endhtmlonly
		/// where zoomx is the value of <see cref="Gl.ZOOM_X"/> and zoomy is the value of <see cref="Gl.ZOOM_Y"/>. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> or <paramref name="type"/> is not one of the 
		///   acceptedvalues. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is <see cref="Gl.BITMAP"/> and <paramref 
		///   name="format"/>is not either <see cref="Gl.COLOR_INDEX"/> or <see cref="Gl.STENCIL_INDEX"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if either <paramref name="width"/> or <paramref name="height"/> is negative. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is <see cref="Gl.STENCIL_INDEX"/> and there 
		///   isno stencil buffer. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is <see cref="Gl.RED"/>, <see 
		///   cref="Gl.GREEN"/>,<see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.RGBA"/>, <see 
		///   cref="Gl.BGR"/>,<see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, or <see cref="Gl.LUMINANCE_ALPHA"/>, and the GL is in 
		///   colorindex mode. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>,<see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or <see 
		///   cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>and <paramref name="format"/> is not <see cref="Gl.RGB"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, 
		///   <seecref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, <see 
		///   cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>,<see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the data would be unpacked from the buffer object such that the memory reads 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   neededto store in memory a datum indicated by <paramref name="type"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.DrawPixels"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/> 
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.AlphaFunc"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.WindowPos"/>
		public static void DrawPixels(Int32 width, Int32 height, int format, int type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglDrawPixels != null, "pglDrawPixels not implemented");
			Delegates.pglDrawPixels(width, height, format, type, pixels);
			CallLog("glDrawPixels({0}, {1}, {2}, {3}, {4})", width, height, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// write a block of pixels to the frame buffer
		/// </summary>
		/// <param name="width">
		/// Specify the dimensions of the pixel rectangle to be written into the frame buffer. 
		/// </param>
		/// <param name="height">
		/// Specify the dimensions of the pixel rectangle to be written into the frame buffer. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. Symbolic constants <see cref="Gl.COLOR_INDEX"/>, <see cref="Gl.STENCIL_INDEX"/>, 
		/// <seecref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see 
		/// cref="Gl.BGRA"/>,<see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see 
		/// cref="Gl.LUMINANCE"/>,and <see cref="Gl.LUMINANCE_ALPHA"/> are accepted. 
		/// </param>
		/// <param name="type">
		/// Specifies the data type for <paramref name="data"/>. Symbolic constants <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>,<see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>,<see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>,<see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <seecref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>,<see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <seecref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>are accepted. 
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.DrawPixels"/> reads pixel data from memory and writes it into the frame buffer relative to the current 
		/// rasterposition, provided that the raster position is valid. Use Gl.RasterPos or Gl.WindowPos to set the current raster 
		/// position;use Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/> to determine if the specified raster 
		/// positionis valid, and Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/> to query the raster position. 
		/// Several parameters define the encoding of pixel data in memory and control the processing of the pixel data before it is 
		/// placedin the frame buffer. These parameters are set with four commands: Gl.PixelStore, Gl.PixelTransfer, Gl.PixelMap, 
		/// andGl.PixelZoom. This reference page describes the effects on <see cref="Gl.DrawPixels"/> of many, but not all, of the 
		/// parametersspecified by these four commands. 
		/// Data is read from <paramref name="data"/> as a sequence of signed or unsigned bytes, signed or unsigned shorts, signed 
		/// orunsigned integers, or single-precision floating-point values, depending on <paramref name="type"/>. When <paramref 
		/// name="type"/>is one of <see cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.BYTE"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see 
		/// cref="Gl.SHORT"/>,<see cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, or <see cref="Gl.FLOAT"/> each of these bytes, 
		/// shorts,integers, or floating-point values is interpreted as one color or depth component, or one index, depending on 
		/// <paramrefname="format"/>. When <paramref name="type"/> is one of <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_6_5"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see 
		/// cref="Gl.UNSIGNED_INT_8_8_8_8"/>,or <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, each unsigned value is interpreted as 
		/// containingall the components for a single pixel, with the color components arranged according to <paramref 
		/// name="format"/>.When <paramref name="type"/> is one of <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>,<see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, or <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>,each unsigned value is interpreted as containing all color components, specified 
		/// by<paramref name="format"/>, for a single pixel in a reversed order. Indices are always treated individually. Color 
		/// componentsare treated as groups of one, two, three, or four values, again based on <paramref name="format"/>. Both 
		/// individualindices and groups of components are referred to as pixels. If <paramref name="type"/> is <see 
		/// cref="Gl.BITMAP"/>,the data must be unsigned bytes, and <paramref name="format"/> must be either <see 
		/// cref="Gl.COLOR_INDEX"/>or <see cref="Gl.STENCIL_INDEX"/>. Each unsigned byte is treated as eight 1-bit pixels, with bit 
		/// orderingdetermined by <see cref="Gl.UNPACK_LSB_FIRST"/> (see Gl.PixelStore). 
		/// width×height pixels are read from memory, starting at location <paramref name="data"/>. By default, these pixels are 
		/// takenfrom adjacent memory locations, except that after all <paramref name="width"/> pixels are read, the read pointer is 
		/// advancedto the next four-byte boundary. The four-byte row alignment is specified by Gl.PixelStore with argument <see 
		/// cref="Gl.UNPACK_ALIGNMENT"/>,and it can be set to one, two, four, or eight bytes. Other pixel store parameters specify 
		/// differentread pointer advancements, both before the first pixel is read and after all <paramref name="width"/> pixels 
		/// areread. See the Gl.PixelStore reference page for details on these options. 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// ablock of pixels is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store. 
		/// The width×height pixels that are read from memory are each operated on in the same way, based on the values of several 
		/// parametersspecified by Gl.PixelTransfer and Gl.PixelMap. The details of these operations, as well as the target buffer 
		/// intowhich the pixels are drawn, are specific to the format of the pixels, as specified by <paramref name="format"/>. 
		/// <paramrefname="format"/> can assume one of 13 symbolic values: 
		/// The following table summarizes the meaning of the valid constants for the type parameter: 
		/// Type Corresponding Type <see cref="Gl.UNSIGNED_BYTE"/> unsigned 8-bit integer <see cref="Gl.BYTE"/> signed 8-bit integer 
		/// <seecref="Gl.BITMAP"/> single bits in unsigned 8-bit integers <see cref="Gl.UNSIGNED_SHORT"/> unsigned 16-bit integer 
		/// <seecref="Gl.SHORT"/> signed 16-bit integer <see cref="Gl.UNSIGNED_INT"/> unsigned 32-bit integer <see cref="Gl.INT"/> 
		/// 32-bitinteger <see cref="Gl.FLOAT"/> single-precision floating-point <see cref="Gl.UNSIGNED_BYTE_3_3_2"/> unsigned 8-bit 
		/// integer<see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/> unsigned 8-bit integer with reversed component ordering <see 
		/// cref="Gl.UNSIGNED_SHORT_5_6_5"/>unsigned 16-bit integer <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> unsigned 16-bit 
		/// integerwith reversed component ordering <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/> unsigned 16-bit integer <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>unsigned 16-bit integer with reversed component ordering <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>unsigned 16-bit integer <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/> unsigned 16-bit 
		/// integerwith reversed component ordering <see cref="Gl.UNSIGNED_INT_8_8_8_8"/> unsigned 32-bit integer <see 
		/// cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>unsigned 32-bit integer with reversed component ordering <see 
		/// cref="Gl.UNSIGNED_INT_10_10_10_2"/>unsigned 32-bit integer <see cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> unsigned 32-bit 
		/// integerwith reversed component ordering 
		///  
		/// The rasterization described so far assumes pixel zoom factors of 1. If Gl.PixelZoom is used to change the x and y pixel 
		/// zoomfactors, pixels are converted to fragments as follows. If xryr is the current raster position, and a given pixel is 
		/// inthe nth column and mth row of the pixel rectangle, then fragments are generated for pixels whose centers are in the 
		/// rectanglewith corners at 
		/// xr+zoomx⁢nyr+zoomy⁢m @htmlonly <informalequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: left ( x sub r + {zoom sub x} (n + 1), y sub r + {zoom sub y} ( 
		/// m+ 1 ) right ):--><mml:mfenced open="(" close=")"><mml:mrow><mml:msub><mml:mi mathvariant="italic">x</mml:mi><mml:mi 
		/// mathvariant="italic">r</mml:mi></mml:msub><mml:mo>+</mml:mo><mml:mrow><mml:mfencedopen="" close=""><mml:msub><mml:mi 
		/// mathvariant="italic">zoom</mml:mi><mml:mi
		/// mathvariant="italic">x</mml:mi></mml:msub></mml:mfenced><mml:mo>⁡</mml:mo><mml:mfencedopen="(" 
		/// close=")"><mml:mrow><mml:mi
		/// mathvariant="italic">n</mml:mi><mml:mo>+</mml:mo><mml:mn>1</mml:mn></mml:mrow></mml:mfenced></mml:mrow></mml:mrow><mml:mrow><mml:msub><mml:mi
		/// mathvariant="italic">y</mml:mi><mml:mimathvariant="italic">r</mml:mi></mml:msub><mml:mo>+</mml:mo><mml:mrow><mml:mfenced 
		/// open=""close=""><mml:msub><mml:mi mathvariant="italic">zoom</mml:mi><mml:mi 
		/// mathvariant="italic">y</mml:mi></mml:msub></mml:mfenced><mml:mo>⁡</mml:mo><mml:mfencedopen="(" 
		/// close=")"><mml:mrow><mml:mi
		/// mathvariant="italic">m</mml:mi><mml:mo>+</mml:mo><mml:mn>1</mml:mn></mml:mrow></mml:mfenced></mml:mrow></mml:mrow></mml:mfenced></mml:math></informalequation>
		/// @endhtmlonly
		/// where zoomx is the value of <see cref="Gl.ZOOM_X"/> and zoomy is the value of <see cref="Gl.ZOOM_Y"/>. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> or <paramref name="type"/> is not one of the 
		///   acceptedvalues. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is <see cref="Gl.BITMAP"/> and <paramref 
		///   name="format"/>is not either <see cref="Gl.COLOR_INDEX"/> or <see cref="Gl.STENCIL_INDEX"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if either <paramref name="width"/> or <paramref name="height"/> is negative. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is <see cref="Gl.STENCIL_INDEX"/> and there 
		///   isno stencil buffer. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is <see cref="Gl.RED"/>, <see 
		///   cref="Gl.GREEN"/>,<see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.RGBA"/>, <see 
		///   cref="Gl.BGR"/>,<see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, or <see cref="Gl.LUMINANCE_ALPHA"/>, and the GL is in 
		///   colorindex mode. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>,<see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or <see 
		///   cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>and <paramref name="format"/> is not <see cref="Gl.RGB"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, 
		///   <seecref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, <see 
		///   cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>,<see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the data would be unpacked from the buffer object such that the memory reads 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   neededto store in memory a datum indicated by <paramref name="type"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.DrawPixels"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/> 
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.AlphaFunc"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.WindowPos"/>
		public static void DrawPixels(Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglDrawPixels != null, "pglDrawPixels not implemented");
			Delegates.pglDrawPixels(width, height, (int)format, (int)type, pixels);
			CallLog("glDrawPixels({0}, {1}, {2}, {3}, {4})", width, height, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// write a block of pixels to the frame buffer
		/// </summary>
		/// <param name="width">
		/// Specify the dimensions of the pixel rectangle to be written into the frame buffer. 
		/// </param>
		/// <param name="height">
		/// Specify the dimensions of the pixel rectangle to be written into the frame buffer. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. Symbolic constants <see cref="Gl.COLOR_INDEX"/>, <see cref="Gl.STENCIL_INDEX"/>, 
		/// <seecref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see 
		/// cref="Gl.BGRA"/>,<see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see 
		/// cref="Gl.LUMINANCE"/>,and <see cref="Gl.LUMINANCE_ALPHA"/> are accepted. 
		/// </param>
		/// <param name="type">
		/// Specifies the data type for <paramref name="data"/>. Symbolic constants <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>,<see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>,<see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>,<see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <seecref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>,<see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <seecref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>are accepted. 
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.DrawPixels"/> reads pixel data from memory and writes it into the frame buffer relative to the current 
		/// rasterposition, provided that the raster position is valid. Use Gl.RasterPos or Gl.WindowPos to set the current raster 
		/// position;use Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/> to determine if the specified raster 
		/// positionis valid, and Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/> to query the raster position. 
		/// Several parameters define the encoding of pixel data in memory and control the processing of the pixel data before it is 
		/// placedin the frame buffer. These parameters are set with four commands: Gl.PixelStore, Gl.PixelTransfer, Gl.PixelMap, 
		/// andGl.PixelZoom. This reference page describes the effects on <see cref="Gl.DrawPixels"/> of many, but not all, of the 
		/// parametersspecified by these four commands. 
		/// Data is read from <paramref name="data"/> as a sequence of signed or unsigned bytes, signed or unsigned shorts, signed 
		/// orunsigned integers, or single-precision floating-point values, depending on <paramref name="type"/>. When <paramref 
		/// name="type"/>is one of <see cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.BYTE"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see 
		/// cref="Gl.SHORT"/>,<see cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, or <see cref="Gl.FLOAT"/> each of these bytes, 
		/// shorts,integers, or floating-point values is interpreted as one color or depth component, or one index, depending on 
		/// <paramrefname="format"/>. When <paramref name="type"/> is one of <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_6_5"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see 
		/// cref="Gl.UNSIGNED_INT_8_8_8_8"/>,or <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, each unsigned value is interpreted as 
		/// containingall the components for a single pixel, with the color components arranged according to <paramref 
		/// name="format"/>.When <paramref name="type"/> is one of <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>,<see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, or <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>,each unsigned value is interpreted as containing all color components, specified 
		/// by<paramref name="format"/>, for a single pixel in a reversed order. Indices are always treated individually. Color 
		/// componentsare treated as groups of one, two, three, or four values, again based on <paramref name="format"/>. Both 
		/// individualindices and groups of components are referred to as pixels. If <paramref name="type"/> is <see 
		/// cref="Gl.BITMAP"/>,the data must be unsigned bytes, and <paramref name="format"/> must be either <see 
		/// cref="Gl.COLOR_INDEX"/>or <see cref="Gl.STENCIL_INDEX"/>. Each unsigned byte is treated as eight 1-bit pixels, with bit 
		/// orderingdetermined by <see cref="Gl.UNPACK_LSB_FIRST"/> (see Gl.PixelStore). 
		/// width×height pixels are read from memory, starting at location <paramref name="data"/>. By default, these pixels are 
		/// takenfrom adjacent memory locations, except that after all <paramref name="width"/> pixels are read, the read pointer is 
		/// advancedto the next four-byte boundary. The four-byte row alignment is specified by Gl.PixelStore with argument <see 
		/// cref="Gl.UNPACK_ALIGNMENT"/>,and it can be set to one, two, four, or eight bytes. Other pixel store parameters specify 
		/// differentread pointer advancements, both before the first pixel is read and after all <paramref name="width"/> pixels 
		/// areread. See the Gl.PixelStore reference page for details on these options. 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// ablock of pixels is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store. 
		/// The width×height pixels that are read from memory are each operated on in the same way, based on the values of several 
		/// parametersspecified by Gl.PixelTransfer and Gl.PixelMap. The details of these operations, as well as the target buffer 
		/// intowhich the pixels are drawn, are specific to the format of the pixels, as specified by <paramref name="format"/>. 
		/// <paramrefname="format"/> can assume one of 13 symbolic values: 
		/// The following table summarizes the meaning of the valid constants for the type parameter: 
		/// Type Corresponding Type <see cref="Gl.UNSIGNED_BYTE"/> unsigned 8-bit integer <see cref="Gl.BYTE"/> signed 8-bit integer 
		/// <seecref="Gl.BITMAP"/> single bits in unsigned 8-bit integers <see cref="Gl.UNSIGNED_SHORT"/> unsigned 16-bit integer 
		/// <seecref="Gl.SHORT"/> signed 16-bit integer <see cref="Gl.UNSIGNED_INT"/> unsigned 32-bit integer <see cref="Gl.INT"/> 
		/// 32-bitinteger <see cref="Gl.FLOAT"/> single-precision floating-point <see cref="Gl.UNSIGNED_BYTE_3_3_2"/> unsigned 8-bit 
		/// integer<see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/> unsigned 8-bit integer with reversed component ordering <see 
		/// cref="Gl.UNSIGNED_SHORT_5_6_5"/>unsigned 16-bit integer <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/> unsigned 16-bit 
		/// integerwith reversed component ordering <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/> unsigned 16-bit integer <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>unsigned 16-bit integer with reversed component ordering <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>unsigned 16-bit integer <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/> unsigned 16-bit 
		/// integerwith reversed component ordering <see cref="Gl.UNSIGNED_INT_8_8_8_8"/> unsigned 32-bit integer <see 
		/// cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>unsigned 32-bit integer with reversed component ordering <see 
		/// cref="Gl.UNSIGNED_INT_10_10_10_2"/>unsigned 32-bit integer <see cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> unsigned 32-bit 
		/// integerwith reversed component ordering 
		///  
		/// The rasterization described so far assumes pixel zoom factors of 1. If Gl.PixelZoom is used to change the x and y pixel 
		/// zoomfactors, pixels are converted to fragments as follows. If xryr is the current raster position, and a given pixel is 
		/// inthe nth column and mth row of the pixel rectangle, then fragments are generated for pixels whose centers are in the 
		/// rectanglewith corners at 
		/// xr+zoomx⁢nyr+zoomy⁢m @htmlonly <informalequation xmlns="http://docbook.org/ns/docbook"><mml:math 
		/// xmlns:mml="http://www.w3.org/1998/Math/MathML"><!--eqn: left ( x sub r + {zoom sub x} (n + 1), y sub r + {zoom sub y} ( 
		/// m+ 1 ) right ):--><mml:mfenced open="(" close=")"><mml:mrow><mml:msub><mml:mi mathvariant="italic">x</mml:mi><mml:mi 
		/// mathvariant="italic">r</mml:mi></mml:msub><mml:mo>+</mml:mo><mml:mrow><mml:mfencedopen="" close=""><mml:msub><mml:mi 
		/// mathvariant="italic">zoom</mml:mi><mml:mi
		/// mathvariant="italic">x</mml:mi></mml:msub></mml:mfenced><mml:mo>⁡</mml:mo><mml:mfencedopen="(" 
		/// close=")"><mml:mrow><mml:mi
		/// mathvariant="italic">n</mml:mi><mml:mo>+</mml:mo><mml:mn>1</mml:mn></mml:mrow></mml:mfenced></mml:mrow></mml:mrow><mml:mrow><mml:msub><mml:mi
		/// mathvariant="italic">y</mml:mi><mml:mimathvariant="italic">r</mml:mi></mml:msub><mml:mo>+</mml:mo><mml:mrow><mml:mfenced 
		/// open=""close=""><mml:msub><mml:mi mathvariant="italic">zoom</mml:mi><mml:mi 
		/// mathvariant="italic">y</mml:mi></mml:msub></mml:mfenced><mml:mo>⁡</mml:mo><mml:mfencedopen="(" 
		/// close=")"><mml:mrow><mml:mi
		/// mathvariant="italic">m</mml:mi><mml:mo>+</mml:mo><mml:mn>1</mml:mn></mml:mrow></mml:mfenced></mml:mrow></mml:mrow></mml:mfenced></mml:math></informalequation>
		/// @endhtmlonly
		/// where zoomx is the value of <see cref="Gl.ZOOM_X"/> and zoomy is the value of <see cref="Gl.ZOOM_Y"/>. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="format"/> or <paramref name="type"/> is not one of the 
		///   acceptedvalues. 
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="type"/> is <see cref="Gl.BITMAP"/> and <paramref 
		///   name="format"/>is not either <see cref="Gl.COLOR_INDEX"/> or <see cref="Gl.STENCIL_INDEX"/>. 
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if either <paramref name="width"/> or <paramref name="height"/> is negative. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is <see cref="Gl.STENCIL_INDEX"/> and there 
		///   isno stencil buffer. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is <see cref="Gl.RED"/>, <see 
		///   cref="Gl.GREEN"/>,<see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.RGBA"/>, <see 
		///   cref="Gl.BGR"/>,<see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, or <see cref="Gl.LUMINANCE_ALPHA"/>, and the GL is in 
		///   colorindex mode. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is one of <see 
		///   cref="Gl.UNSIGNED_BYTE_3_3_2"/>,<see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, or <see 
		///   cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>and <paramref name="format"/> is not <see cref="Gl.RGB"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <paramref name="format"/> is one of <see 
		///   cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>,<see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, 
		///   <seecref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, <see 
		///   cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>,<see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		///   cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>and <paramref name="format"/> is neither <see cref="Gl.RGBA"/> nor <see 
		///   cref="Gl.BGRA"/>.
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the data would be unpacked from the buffer object such that the memory reads 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and <paramref name="data"/> is not evenly divisible into the number of bytes 
		///   neededto store in memory a datum indicated by <paramref name="type"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.DrawPixels"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION"/> 
		/// - Gl.Get with argument <see cref="Gl.CURRENT_RASTER_POSITION_VALID"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.AlphaFunc"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.WindowPos"/>
		public static void DrawPixels(Int32 width, Int32 height, int format, int type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				DrawPixels(width, height, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Binding for glGetClipPlane.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetClipPlane(int plane, double[] equation)
		{
			unsafe {
				fixed (double* p_equation = equation)
				{
					Debug.Assert(Delegates.pglGetClipPlane != null, "pglGetClipPlane not implemented");
					Delegates.pglGetClipPlane(plane, p_equation);
					CallLog("glGetClipPlane({0}, {1})", plane, equation);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetClipPlane.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetClipPlane(ClipPlaneName plane, double[] equation)
		{
			unsafe {
				fixed (double* p_equation = equation)
				{
					Debug.Assert(Delegates.pglGetClipPlane != null, "pglGetClipPlane not implemented");
					Delegates.pglGetClipPlane((int)plane, p_equation);
					CallLog("glGetClipPlane({0}, {1})", plane, equation);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetLightfv.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetLight(int light, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightfv != null, "pglGetLightfv not implemented");
					Delegates.pglGetLightfv(light, pname, p_params);
					CallLog("glGetLightfv({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetLightfv.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetLight(LightName light, LightParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightfv != null, "pglGetLightfv not implemented");
					Delegates.pglGetLightfv((int)light, (int)pname, p_params);
					CallLog("glGetLightfv({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetLightiv.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetLight(int light, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightiv != null, "pglGetLightiv not implemented");
					Delegates.pglGetLightiv(light, pname, p_params);
					CallLog("glGetLightiv({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetLightiv.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetLight(LightName light, LightParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightiv != null, "pglGetLightiv not implemented");
					Delegates.pglGetLightiv((int)light, (int)pname, p_params);
					CallLog("glGetLightiv({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return evaluator parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the symbolic name of a map. Accepted values are <see cref="Gl.MAP1_COLOR_4"/>, <see cref="Gl.MAP1_INDEX"/>, 
		/// <seecref="Gl.MAP1_NORMAL"/>, <see cref="Gl.MAP1_TEXTURE_COORD_1"/>, <see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_3"/>,<see cref="Gl.MAP1_TEXTURE_COORD_4"/>, <see cref="Gl.MAP1_VERTEX_3"/>, <see 
		/// cref="Gl.MAP1_VERTEX_4"/>,<see cref="Gl.MAP2_COLOR_4"/>, <see cref="Gl.MAP2_INDEX"/>, <see cref="Gl.MAP2_NORMAL"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_1"/>,<see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see cref="Gl.MAP2_TEXTURE_COORD_3"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_4"/>,<see cref="Gl.MAP2_VERTEX_3"/>, and <see cref="Gl.MAP2_VERTEX_4"/>. 
		/// </param>
		/// <param name="query">
		/// Specifies which parameter to return. Symbolic names <see cref="Gl.COEFF"/>, <see cref="Gl.ORDER"/>, and <see 
		/// cref="Gl.DOMAIN"/>are accepted. 
		/// </param>
		/// <param name="v">
		/// Returns the requested data. 
		/// </param>
		/// <remarks>
		/// Gl.Map1 and Gl.Map2 define evaluators. <see cref="Gl.GetMap"/> returns evaluator parameters. <paramref name="target"/> 
		/// choosesa map, <paramref name="query"/> selects a specific parameter, and <paramref name="v"/> points to storage where 
		/// thevalues will be returned. 
		/// The acceptable values for the <paramref name="target"/> parameter are described in the Gl.Map1 and Gl.Map2 reference 
		/// pages.
		/// <paramref name="query"/> can assume the following values: 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if either <paramref name="target"/> or <paramref name="query"/> is not an 
		///   acceptedvalue. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetMap"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		public static void GetMap(int target, int query, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglGetMapdv != null, "pglGetMapdv not implemented");
					Delegates.pglGetMapdv(target, query, p_v);
					CallLog("glGetMapdv({0}, {1}, {2})", target, query, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return evaluator parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the symbolic name of a map. Accepted values are <see cref="Gl.MAP1_COLOR_4"/>, <see cref="Gl.MAP1_INDEX"/>, 
		/// <seecref="Gl.MAP1_NORMAL"/>, <see cref="Gl.MAP1_TEXTURE_COORD_1"/>, <see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_3"/>,<see cref="Gl.MAP1_TEXTURE_COORD_4"/>, <see cref="Gl.MAP1_VERTEX_3"/>, <see 
		/// cref="Gl.MAP1_VERTEX_4"/>,<see cref="Gl.MAP2_COLOR_4"/>, <see cref="Gl.MAP2_INDEX"/>, <see cref="Gl.MAP2_NORMAL"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_1"/>,<see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see cref="Gl.MAP2_TEXTURE_COORD_3"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_4"/>,<see cref="Gl.MAP2_VERTEX_3"/>, and <see cref="Gl.MAP2_VERTEX_4"/>. 
		/// </param>
		/// <param name="query">
		/// Specifies which parameter to return. Symbolic names <see cref="Gl.COEFF"/>, <see cref="Gl.ORDER"/>, and <see 
		/// cref="Gl.DOMAIN"/>are accepted. 
		/// </param>
		/// <param name="v">
		/// Returns the requested data. 
		/// </param>
		/// <remarks>
		/// Gl.Map1 and Gl.Map2 define evaluators. <see cref="Gl.GetMap"/> returns evaluator parameters. <paramref name="target"/> 
		/// choosesa map, <paramref name="query"/> selects a specific parameter, and <paramref name="v"/> points to storage where 
		/// thevalues will be returned. 
		/// The acceptable values for the <paramref name="target"/> parameter are described in the Gl.Map1 and Gl.Map2 reference 
		/// pages.
		/// <paramref name="query"/> can assume the following values: 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if either <paramref name="target"/> or <paramref name="query"/> is not an 
		///   acceptedvalue. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetMap"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		public static void GetMap(MapTarget target, GetMapQuery query, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglGetMapdv != null, "pglGetMapdv not implemented");
					Delegates.pglGetMapdv((int)target, (int)query, p_v);
					CallLog("glGetMapdv({0}, {1}, {2})", target, query, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return evaluator parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the symbolic name of a map. Accepted values are <see cref="Gl.MAP1_COLOR_4"/>, <see cref="Gl.MAP1_INDEX"/>, 
		/// <seecref="Gl.MAP1_NORMAL"/>, <see cref="Gl.MAP1_TEXTURE_COORD_1"/>, <see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_3"/>,<see cref="Gl.MAP1_TEXTURE_COORD_4"/>, <see cref="Gl.MAP1_VERTEX_3"/>, <see 
		/// cref="Gl.MAP1_VERTEX_4"/>,<see cref="Gl.MAP2_COLOR_4"/>, <see cref="Gl.MAP2_INDEX"/>, <see cref="Gl.MAP2_NORMAL"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_1"/>,<see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see cref="Gl.MAP2_TEXTURE_COORD_3"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_4"/>,<see cref="Gl.MAP2_VERTEX_3"/>, and <see cref="Gl.MAP2_VERTEX_4"/>. 
		/// </param>
		/// <param name="query">
		/// Specifies which parameter to return. Symbolic names <see cref="Gl.COEFF"/>, <see cref="Gl.ORDER"/>, and <see 
		/// cref="Gl.DOMAIN"/>are accepted. 
		/// </param>
		/// <param name="v">
		/// Returns the requested data. 
		/// </param>
		/// <remarks>
		/// Gl.Map1 and Gl.Map2 define evaluators. <see cref="Gl.GetMap"/> returns evaluator parameters. <paramref name="target"/> 
		/// choosesa map, <paramref name="query"/> selects a specific parameter, and <paramref name="v"/> points to storage where 
		/// thevalues will be returned. 
		/// The acceptable values for the <paramref name="target"/> parameter are described in the Gl.Map1 and Gl.Map2 reference 
		/// pages.
		/// <paramref name="query"/> can assume the following values: 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if either <paramref name="target"/> or <paramref name="query"/> is not an 
		///   acceptedvalue. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetMap"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		public static void GetMap(int target, int query, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglGetMapfv != null, "pglGetMapfv not implemented");
					Delegates.pglGetMapfv(target, query, p_v);
					CallLog("glGetMapfv({0}, {1}, {2})", target, query, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return evaluator parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the symbolic name of a map. Accepted values are <see cref="Gl.MAP1_COLOR_4"/>, <see cref="Gl.MAP1_INDEX"/>, 
		/// <seecref="Gl.MAP1_NORMAL"/>, <see cref="Gl.MAP1_TEXTURE_COORD_1"/>, <see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_3"/>,<see cref="Gl.MAP1_TEXTURE_COORD_4"/>, <see cref="Gl.MAP1_VERTEX_3"/>, <see 
		/// cref="Gl.MAP1_VERTEX_4"/>,<see cref="Gl.MAP2_COLOR_4"/>, <see cref="Gl.MAP2_INDEX"/>, <see cref="Gl.MAP2_NORMAL"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_1"/>,<see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see cref="Gl.MAP2_TEXTURE_COORD_3"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_4"/>,<see cref="Gl.MAP2_VERTEX_3"/>, and <see cref="Gl.MAP2_VERTEX_4"/>. 
		/// </param>
		/// <param name="query">
		/// Specifies which parameter to return. Symbolic names <see cref="Gl.COEFF"/>, <see cref="Gl.ORDER"/>, and <see 
		/// cref="Gl.DOMAIN"/>are accepted. 
		/// </param>
		/// <param name="v">
		/// Returns the requested data. 
		/// </param>
		/// <remarks>
		/// Gl.Map1 and Gl.Map2 define evaluators. <see cref="Gl.GetMap"/> returns evaluator parameters. <paramref name="target"/> 
		/// choosesa map, <paramref name="query"/> selects a specific parameter, and <paramref name="v"/> points to storage where 
		/// thevalues will be returned. 
		/// The acceptable values for the <paramref name="target"/> parameter are described in the Gl.Map1 and Gl.Map2 reference 
		/// pages.
		/// <paramref name="query"/> can assume the following values: 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if either <paramref name="target"/> or <paramref name="query"/> is not an 
		///   acceptedvalue. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetMap"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		public static void GetMap(MapTarget target, GetMapQuery query, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglGetMapfv != null, "pglGetMapfv not implemented");
					Delegates.pglGetMapfv((int)target, (int)query, p_v);
					CallLog("glGetMapfv({0}, {1}, {2})", target, query, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return evaluator parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the symbolic name of a map. Accepted values are <see cref="Gl.MAP1_COLOR_4"/>, <see cref="Gl.MAP1_INDEX"/>, 
		/// <seecref="Gl.MAP1_NORMAL"/>, <see cref="Gl.MAP1_TEXTURE_COORD_1"/>, <see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_3"/>,<see cref="Gl.MAP1_TEXTURE_COORD_4"/>, <see cref="Gl.MAP1_VERTEX_3"/>, <see 
		/// cref="Gl.MAP1_VERTEX_4"/>,<see cref="Gl.MAP2_COLOR_4"/>, <see cref="Gl.MAP2_INDEX"/>, <see cref="Gl.MAP2_NORMAL"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_1"/>,<see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see cref="Gl.MAP2_TEXTURE_COORD_3"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_4"/>,<see cref="Gl.MAP2_VERTEX_3"/>, and <see cref="Gl.MAP2_VERTEX_4"/>. 
		/// </param>
		/// <param name="query">
		/// Specifies which parameter to return. Symbolic names <see cref="Gl.COEFF"/>, <see cref="Gl.ORDER"/>, and <see 
		/// cref="Gl.DOMAIN"/>are accepted. 
		/// </param>
		/// <param name="v">
		/// Returns the requested data. 
		/// </param>
		/// <remarks>
		/// Gl.Map1 and Gl.Map2 define evaluators. <see cref="Gl.GetMap"/> returns evaluator parameters. <paramref name="target"/> 
		/// choosesa map, <paramref name="query"/> selects a specific parameter, and <paramref name="v"/> points to storage where 
		/// thevalues will be returned. 
		/// The acceptable values for the <paramref name="target"/> parameter are described in the Gl.Map1 and Gl.Map2 reference 
		/// pages.
		/// <paramref name="query"/> can assume the following values: 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if either <paramref name="target"/> or <paramref name="query"/> is not an 
		///   acceptedvalue. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetMap"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		public static void GetMap(int target, int query, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglGetMapiv != null, "pglGetMapiv not implemented");
					Delegates.pglGetMapiv(target, query, p_v);
					CallLog("glGetMapiv({0}, {1}, {2})", target, query, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return evaluator parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the symbolic name of a map. Accepted values are <see cref="Gl.MAP1_COLOR_4"/>, <see cref="Gl.MAP1_INDEX"/>, 
		/// <seecref="Gl.MAP1_NORMAL"/>, <see cref="Gl.MAP1_TEXTURE_COORD_1"/>, <see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_3"/>,<see cref="Gl.MAP1_TEXTURE_COORD_4"/>, <see cref="Gl.MAP1_VERTEX_3"/>, <see 
		/// cref="Gl.MAP1_VERTEX_4"/>,<see cref="Gl.MAP2_COLOR_4"/>, <see cref="Gl.MAP2_INDEX"/>, <see cref="Gl.MAP2_NORMAL"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_1"/>,<see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see cref="Gl.MAP2_TEXTURE_COORD_3"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_4"/>,<see cref="Gl.MAP2_VERTEX_3"/>, and <see cref="Gl.MAP2_VERTEX_4"/>. 
		/// </param>
		/// <param name="query">
		/// Specifies which parameter to return. Symbolic names <see cref="Gl.COEFF"/>, <see cref="Gl.ORDER"/>, and <see 
		/// cref="Gl.DOMAIN"/>are accepted. 
		/// </param>
		/// <param name="v">
		/// Returns the requested data. 
		/// </param>
		/// <remarks>
		/// Gl.Map1 and Gl.Map2 define evaluators. <see cref="Gl.GetMap"/> returns evaluator parameters. <paramref name="target"/> 
		/// choosesa map, <paramref name="query"/> selects a specific parameter, and <paramref name="v"/> points to storage where 
		/// thevalues will be returned. 
		/// The acceptable values for the <paramref name="target"/> parameter are described in the Gl.Map1 and Gl.Map2 reference 
		/// pages.
		/// <paramref name="query"/> can assume the following values: 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if either <paramref name="target"/> or <paramref name="query"/> is not an 
		///   acceptedvalue. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetMap"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		public static void GetMap(MapTarget target, GetMapQuery query, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglGetMapiv != null, "pglGetMapiv not implemented");
					Delegates.pglGetMapiv((int)target, (int)query, p_v);
					CallLog("glGetMapiv({0}, {1}, {2})", target, query, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetMaterialfv.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetMaterial(int face, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMaterialfv != null, "pglGetMaterialfv not implemented");
					Delegates.pglGetMaterialfv(face, pname, p_params);
					CallLog("glGetMaterialfv({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetMaterialfv.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetMaterial(MaterialFace face, MaterialParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMaterialfv != null, "pglGetMaterialfv not implemented");
					Delegates.pglGetMaterialfv((int)face, (int)pname, p_params);
					CallLog("glGetMaterialfv({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetMaterialiv.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetMaterial(int face, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMaterialiv != null, "pglGetMaterialiv not implemented");
					Delegates.pglGetMaterialiv(face, pname, p_params);
					CallLog("glGetMaterialiv({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetMaterialiv.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetMaterial(MaterialFace face, MaterialParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMaterialiv != null, "pglGetMaterialiv not implemented");
					Delegates.pglGetMaterialiv((int)face, (int)pname, p_params);
					CallLog("glGetMaterialiv({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetPixelMapfv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetPixelMap(int map, float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapfv != null, "pglGetPixelMapfv not implemented");
					Delegates.pglGetPixelMapfv(map, p_values);
					CallLog("glGetPixelMapfv({0}, {1})", map, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetPixelMapfv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetPixelMap(PixelMap map, float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapfv != null, "pglGetPixelMapfv not implemented");
					Delegates.pglGetPixelMapfv((int)map, p_values);
					CallLog("glGetPixelMapfv({0}, {1})", map, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetPixelMapuiv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetPixelMap(int map, UInt32[] values)
		{
			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapuiv != null, "pglGetPixelMapuiv not implemented");
					Delegates.pglGetPixelMapuiv(map, p_values);
					CallLog("glGetPixelMapuiv({0}, {1})", map, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetPixelMapuiv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetPixelMap(PixelMap map, UInt32[] values)
		{
			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapuiv != null, "pglGetPixelMapuiv not implemented");
					Delegates.pglGetPixelMapuiv((int)map, p_values);
					CallLog("glGetPixelMapuiv({0}, {1})", map, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetPixelMapusv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetPixelMap(int map, UInt16[] values)
		{
			unsafe {
				fixed (UInt16* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapusv != null, "pglGetPixelMapusv not implemented");
					Delegates.pglGetPixelMapusv(map, p_values);
					CallLog("glGetPixelMapusv({0}, {1})", map, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetPixelMapusv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetPixelMap(PixelMap map, UInt16[] values)
		{
			unsafe {
				fixed (UInt16* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapusv != null, "pglGetPixelMapusv not implemented");
					Delegates.pglGetPixelMapusv((int)map, p_values);
					CallLog("glGetPixelMapusv({0}, {1})", map, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the polygon stipple pattern
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.GetPolygonStipple"/> returns to <paramref name="pattern"/> a 32×32 polygon stipple pattern. The pattern is 
		/// packedinto memory as if Gl.ReadPixels with both height and width of 32, type of <see cref="Gl.BITMAP"/>, and format of 
		/// <seecref="Gl.COLOR_INDEX"/> were called, and the stipple pattern were stored in an internal 32×32 color index buffer. 
		/// UnlikeGl.ReadPixels, however, pixel transfer operations (shift, offset, pixel map) are not applied to the returned 
		/// stippleimage. 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_PACK_BUFFER"/> target (see Gl.BindBuffer) while a 
		/// polygonstipple pattern is requested, <paramref name="pattern"/> is treated as a byte offset into the buffer object's 
		/// datastore. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_PACK_BUFFER"/>target and the data would be packed to the buffer object such that the memory writes 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.GetPolygonStipple"/> is executed between the execution 
		///   ofGl.Begin and the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.PIXEL_PACK_BUFFER_BINDING"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PolygonStipple"/>
		/// <seealso cref="Gl.ReadPixels"/>
		public static void GetPolygonStipple(byte[] mask)
		{
			unsafe {
				fixed (byte* p_mask = mask)
				{
					Debug.Assert(Delegates.pglGetPolygonStipple != null, "pglGetPolygonStipple not implemented");
					Delegates.pglGetPolygonStipple(p_mask);
					CallLog("glGetPolygonStipple({0})", mask);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexEnvfv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetTexEnv(int target, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexEnvfv != null, "pglGetTexEnvfv not implemented");
					Delegates.pglGetTexEnvfv(target, pname, p_params);
					CallLog("glGetTexEnvfv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexEnvfv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetTexEnv(TextureEnvTarget target, TextureEnvParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexEnvfv != null, "pglGetTexEnvfv not implemented");
					Delegates.pglGetTexEnvfv((int)target, (int)pname, p_params);
					CallLog("glGetTexEnvfv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexEnviv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetTexEnv(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexEnviv != null, "pglGetTexEnviv not implemented");
					Delegates.pglGetTexEnviv(target, pname, p_params);
					CallLog("glGetTexEnviv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexEnviv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetTexEnv(TextureEnvTarget target, TextureEnvParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexEnviv != null, "pglGetTexEnviv not implemented");
					Delegates.pglGetTexEnviv((int)target, (int)pname, p_params);
					CallLog("glGetTexEnviv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexGendv.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetTexGen(int coord, int pname, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGendv != null, "pglGetTexGendv not implemented");
					Delegates.pglGetTexGendv(coord, pname, p_params);
					CallLog("glGetTexGendv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexGendv.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGendv != null, "pglGetTexGendv not implemented");
					Delegates.pglGetTexGendv((int)coord, (int)pname, p_params);
					CallLog("glGetTexGendv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexGenfv.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetTexGen(int coord, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGenfv != null, "pglGetTexGenfv not implemented");
					Delegates.pglGetTexGenfv(coord, pname, p_params);
					CallLog("glGetTexGenfv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexGenfv.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGenfv != null, "pglGetTexGenfv not implemented");
					Delegates.pglGetTexGenfv((int)coord, (int)pname, p_params);
					CallLog("glGetTexGenfv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexGeniv.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetTexGen(int coord, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGeniv != null, "pglGetTexGeniv not implemented");
					Delegates.pglGetTexGeniv(coord, pname, p_params);
					CallLog("glGetTexGeniv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexGeniv.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGeniv != null, "pglGetTexGeniv not implemented");
					Delegates.pglGetTexGeniv((int)coord, (int)pname, p_params);
					CallLog("glGetTexGeniv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIsList.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static bool IsList(UInt32 list)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsList != null, "pglIsList not implemented");
			retValue = Delegates.pglIsList(list);
			CallLog("glIsList({0}) = {1}", list, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// multiply the current matrix by a perspective matrix
		/// </summary>
		/// <param name="left">
		/// Specify the coordinates for the left and right vertical clipping planes. 
		/// </param>
		/// <param name="right">
		/// Specify the coordinates for the left and right vertical clipping planes. 
		/// </param>
		/// <param name="bottom">
		/// Specify the coordinates for the bottom and top horizontal clipping planes. 
		/// </param>
		/// <param name="top">
		/// Specify the coordinates for the bottom and top horizontal clipping planes. 
		/// </param>
		/// <param name="zNear">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="zFar">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.Frustum"/> describes a perspective matrix that produces a perspective projection. The current matrix (see 
		/// Gl.MatrixMode)is multiplied by this matrix and the result replaces the current matrix, as if Gl.MultMatrix were called 
		/// withthe following matrix as its argument: 
		///  
		/// 2⁢nearValright-left0A002⁢nearValtop-bottomB000CD00-10 
		/// A=right+leftright-left 
		/// B=top+bottomtop-bottom 
		/// C=-farVal+nearValfarVal-nearVal 
		/// D=-2⁢farVal⁢nearValfarVal-nearVal 
		///  
		/// Typically, the matrix mode is <see cref="Gl.PROJECTION"/>, and leftbottom-nearVal and righttop-nearVal specify the 
		/// pointson the near clipping plane that are mapped to the lower left and upper right corners of the window, assuming that 
		/// theeye is located at (0, 0, 0). -farVal specifies the location of the far clipping plane. Both <paramref 
		/// name="nearVal"/>and <paramref name="farVal"/> must be positive. 
		/// Use Gl.PushMatrix and Gl.PopMatrix to save and restore the current matrix stack. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="nearVal"/> or <paramref name="farVal"/> is not positive, 
		///   orif <paramref name="left"/> = <paramref name="right"/>, or <paramref name="bottom"/> = <paramref name="top"/>, or 
		///   <paramrefname="near"/> = <paramref name="far"/>. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Frustum"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MATRIX_MODE"/> 
		/// - Gl.Get with argument <see cref="Gl.MODELVIEW_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.PROJECTION_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.TEXTURE_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.COLOR_MATRIX"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Ortho"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Viewport"/>
		public static void Frustum(double left, double right, double bottom, double top, double zNear, double zFar)
		{
			Debug.Assert(Delegates.pglFrustum != null, "pglFrustum not implemented");
			Delegates.pglFrustum(left, right, bottom, top, zNear, zFar);
			CallLog("glFrustum({0}, {1}, {2}, {3}, {4}, {5})", left, right, bottom, top, zNear, zFar);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLoadIdentity.
		/// </summary>
		/// <remarks>
		/// </remarks>
		public static void LoadIdentity()
		{
			Debug.Assert(Delegates.pglLoadIdentity != null, "pglLoadIdentity not implemented");
			Delegates.pglLoadIdentity();
			CallLog("glLoadIdentity()");
			DebugCheckErrors();
		}

		/// <summary>
		/// replace the current matrix with the specified matrix
		/// </summary>
		/// <param name="m">
		/// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 column-major matrix. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.LoadMatrix"/> replaces the current matrix with the one whose elements are specified by <paramref 
		/// name="m"/>.The current matrix is the projection matrix, modelview matrix, or texture matrix, depending on the current 
		/// matrixmode (see Gl.MatrixMode). 
		/// The current matrix, M, defines a transformation of coordinates. For instance, assume M refers to the modelview matrix. 
		/// Ifv=v⁡0v⁡1v⁡2v⁡3 is the set of object coordinates of a vertex, and <paramref name="m"/> points to an array of 16 single- 
		/// ordouble-precision floating-point values m=m⁡0m⁡1...m⁡15, then the modelview transformation M⁡v does the following: 
		/// M⁡v=m⁡0m⁡4m⁡8m⁡12m⁡1m⁡5m⁡9m⁡13m⁡2m⁡6m⁡10m⁡14m⁡3m⁡7m⁡11m⁡15×v⁡0v⁡1v⁡2v⁡3 
		///  
		/// Projection and texture transformations are similarly defined. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.LoadMatrix"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MATRIX_MODE"/> 
		/// - Gl.Get with argument <see cref="Gl.COLOR_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.MODELVIEW_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.PROJECTION_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.TEXTURE_MATRIX"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		public static void LoadMatrix(float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadMatrixf != null, "pglLoadMatrixf not implemented");
					Delegates.pglLoadMatrixf(p_m);
					CallLog("glLoadMatrixf({0})", m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// replace the current matrix with the specified matrix
		/// </summary>
		/// <param name="m">
		/// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 column-major matrix. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.LoadMatrix"/> replaces the current matrix with the one whose elements are specified by <paramref 
		/// name="m"/>.The current matrix is the projection matrix, modelview matrix, or texture matrix, depending on the current 
		/// matrixmode (see Gl.MatrixMode). 
		/// The current matrix, M, defines a transformation of coordinates. For instance, assume M refers to the modelview matrix. 
		/// Ifv=v⁡0v⁡1v⁡2v⁡3 is the set of object coordinates of a vertex, and <paramref name="m"/> points to an array of 16 single- 
		/// ordouble-precision floating-point values m=m⁡0m⁡1...m⁡15, then the modelview transformation M⁡v does the following: 
		/// M⁡v=m⁡0m⁡4m⁡8m⁡12m⁡1m⁡5m⁡9m⁡13m⁡2m⁡6m⁡10m⁡14m⁡3m⁡7m⁡11m⁡15×v⁡0v⁡1v⁡2v⁡3 
		///  
		/// Projection and texture transformations are similarly defined. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.LoadMatrix"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MATRIX_MODE"/> 
		/// - Gl.Get with argument <see cref="Gl.COLOR_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.MODELVIEW_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.PROJECTION_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.TEXTURE_MATRIX"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		public static void LoadMatrix(double[] m)
		{
			unsafe {
				fixed (double* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadMatrixd != null, "pglLoadMatrixd not implemented");
					Delegates.pglLoadMatrixd(p_m);
					CallLog("glLoadMatrixd({0})", m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMatrixMode.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void MatrixMode(int mode)
		{
			Debug.Assert(Delegates.pglMatrixMode != null, "pglMatrixMode not implemented");
			Delegates.pglMatrixMode(mode);
			CallLog("glMatrixMode({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMatrixMode.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void MatrixMode(MatrixMode mode)
		{
			Debug.Assert(Delegates.pglMatrixMode != null, "pglMatrixMode not implemented");
			Delegates.pglMatrixMode((int)mode);
			CallLog("glMatrixMode({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// multiply the current matrix with the specified matrix
		/// </summary>
		/// <param name="m">
		/// Points to 16 consecutive values that are used as the elements of a 4×4 column-major matrix. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultMatrix"/> multiplies the current matrix with the one specified using <paramref name="m"/>, and 
		/// replacesthe current matrix with the product. 
		/// The current matrix is determined by the current matrix mode (see Gl.MatrixMode). It is either the projection matrix, 
		/// modelviewmatrix, or the texture matrix. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.MultMatrix"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MATRIX_MODE"/> 
		/// - Gl.Get with argument <see cref="Gl.COLOR_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.MODELVIEW_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.PROJECTION_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.TEXTURE_MATRIX"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.LoadTransposeMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		public static void MultMatrix(float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMultMatrixf != null, "pglMultMatrixf not implemented");
					Delegates.pglMultMatrixf(p_m);
					CallLog("glMultMatrixf({0})", m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// multiply the current matrix with the specified matrix
		/// </summary>
		/// <param name="m">
		/// Points to 16 consecutive values that are used as the elements of a 4×4 column-major matrix. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultMatrix"/> multiplies the current matrix with the one specified using <paramref name="m"/>, and 
		/// replacesthe current matrix with the product. 
		/// The current matrix is determined by the current matrix mode (see Gl.MatrixMode). It is either the projection matrix, 
		/// modelviewmatrix, or the texture matrix. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.MultMatrix"/> is executed between the execution of 
		///   Gl.Beginand the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MATRIX_MODE"/> 
		/// - Gl.Get with argument <see cref="Gl.COLOR_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.MODELVIEW_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.PROJECTION_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.TEXTURE_MATRIX"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.LoadTransposeMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		public static void MultMatrix(double[] m)
		{
			unsafe {
				fixed (double* p_m = m)
				{
					Debug.Assert(Delegates.pglMultMatrixd != null, "pglMultMatrixd not implemented");
					Delegates.pglMultMatrixd(p_m);
					CallLog("glMultMatrixd({0})", m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glOrtho.
		/// </summary>
		/// <param name="left">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="bottom">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="top">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="zNear">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="zFar">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Ortho(double left, double right, double bottom, double top, double zNear, double zFar)
		{
			Debug.Assert(Delegates.pglOrtho != null, "pglOrtho not implemented");
			Delegates.pglOrtho(left, right, bottom, top, zNear, zFar);
			CallLog("glOrtho({0}, {1}, {2}, {3}, {4}, {5})", left, right, bottom, top, zNear, zFar);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPopMatrix.
		/// </summary>
		/// <remarks>
		/// </remarks>
		public static void PopMatrix()
		{
			Debug.Assert(Delegates.pglPopMatrix != null, "pglPopMatrix not implemented");
			Delegates.pglPopMatrix();
			CallLog("glPopMatrix()");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPushMatrix.
		/// </summary>
		/// <remarks>
		/// </remarks>
		public static void PushMatrix()
		{
			Debug.Assert(Delegates.pglPushMatrix != null, "pglPushMatrix not implemented");
			Delegates.pglPushMatrix();
			CallLog("glPushMatrix()");
			DebugCheckErrors();
		}

		/// <summary>
		/// multiply the current matrix by a rotation matrix
		/// </summary>
		/// <param name="angle">
		/// Specifies the angle of rotation, in degrees. 
		/// </param>
		/// <param name="x">
		/// Specify the x, y, and z coordinates of a vector, respectively. 
		/// </param>
		/// <param name="y">
		/// Specify the x, y, and z coordinates of a vector, respectively. 
		/// </param>
		/// <param name="z">
		/// Specify the x, y, and z coordinates of a vector, respectively. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.Rotate"/> produces a rotation of <paramref name="angle"/> degrees around the vector xyz. The current 
		/// matrix(see Gl.MatrixMode) is multiplied by a rotation matrix with the product replacing the current matrix, as if 
		/// Gl.MultMatrixwere called with the following matrix as its argument: 
		/// x2⁡1-c+cx⁢y⁡1-c-z⁢sx⁢z⁡1-c+y⁢s0y⁢x⁡1-c+z⁢sy2⁡1-c+cy⁢z⁡1-c-x⁢s0x⁢z⁡1-c-y⁢sy⁢z⁡1-c+x⁢sz2⁡1-c+c00001 
		///  
		/// Where c=cos⁡angle, s=sin⁡angle, and xyz=1 (if not, the GL will normalize this vector). 
		///  
		///  
		/// If the matrix mode is either <see cref="Gl.MODELVIEW"/> or <see cref="Gl.PROJECTION"/>, all objects drawn after <see 
		/// cref="Gl.Rotate"/>is called are rotated. Use Gl.PushMatrix and Gl.PopMatrix to save and restore the unrotated coordinate 
		/// system.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Rotate"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MATRIX_MODE"/> 
		/// - Gl.Get with argument <see cref="Gl.COLOR_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.MODELVIEW_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.PROJECTION_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.TEXTURE_MATRIX"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Scale"/>
		/// <seealso cref="Gl.Translate"/>
		public static void Rotate(double angle, double x, double y, double z)
		{
			Debug.Assert(Delegates.pglRotated != null, "pglRotated not implemented");
			Delegates.pglRotated(angle, x, y, z);
			CallLog("glRotated({0}, {1}, {2}, {3})", angle, x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// multiply the current matrix by a rotation matrix
		/// </summary>
		/// <param name="angle">
		/// Specifies the angle of rotation, in degrees. 
		/// </param>
		/// <param name="x">
		/// Specify the x, y, and z coordinates of a vector, respectively. 
		/// </param>
		/// <param name="y">
		/// Specify the x, y, and z coordinates of a vector, respectively. 
		/// </param>
		/// <param name="z">
		/// Specify the x, y, and z coordinates of a vector, respectively. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.Rotate"/> produces a rotation of <paramref name="angle"/> degrees around the vector xyz. The current 
		/// matrix(see Gl.MatrixMode) is multiplied by a rotation matrix with the product replacing the current matrix, as if 
		/// Gl.MultMatrixwere called with the following matrix as its argument: 
		/// x2⁡1-c+cx⁢y⁡1-c-z⁢sx⁢z⁡1-c+y⁢s0y⁢x⁡1-c+z⁢sy2⁡1-c+cy⁢z⁡1-c-x⁢s0x⁢z⁡1-c-y⁢sy⁢z⁡1-c+x⁢sz2⁡1-c+c00001 
		///  
		/// Where c=cos⁡angle, s=sin⁡angle, and xyz=1 (if not, the GL will normalize this vector). 
		///  
		///  
		/// If the matrix mode is either <see cref="Gl.MODELVIEW"/> or <see cref="Gl.PROJECTION"/>, all objects drawn after <see 
		/// cref="Gl.Rotate"/>is called are rotated. Use Gl.PushMatrix and Gl.PopMatrix to save and restore the unrotated coordinate 
		/// system.
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.Rotate"/> is executed between the execution of Gl.Begin 
		///   andthe corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MATRIX_MODE"/> 
		/// - Gl.Get with argument <see cref="Gl.COLOR_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.MODELVIEW_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.PROJECTION_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.TEXTURE_MATRIX"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Scale"/>
		/// <seealso cref="Gl.Translate"/>
		public static void Rotate(float angle, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglRotatef != null, "pglRotatef not implemented");
			Delegates.pglRotatef(angle, x, y, z);
			CallLog("glRotatef({0}, {1}, {2}, {3})", angle, x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glScaled.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Scale(double x, double y, double z)
		{
			Debug.Assert(Delegates.pglScaled != null, "pglScaled not implemented");
			Delegates.pglScaled(x, y, z);
			CallLog("glScaled({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glScalef.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Scale(float x, float y, float z)
		{
			Debug.Assert(Delegates.pglScalef != null, "pglScalef not implemented");
			Delegates.pglScalef(x, y, z);
			CallLog("glScalef({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTranslated.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Translate(double x, double y, double z)
		{
			Debug.Assert(Delegates.pglTranslated != null, "pglTranslated not implemented");
			Delegates.pglTranslated(x, y, z);
			CallLog("glTranslated({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTranslatef.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		public static void Translate(float x, float y, float z)
		{
			Debug.Assert(Delegates.pglTranslatef != null, "pglTranslatef not implemented");
			Delegates.pglTranslatef(x, y, z);
			CallLog("glTranslatef({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

	}

}
