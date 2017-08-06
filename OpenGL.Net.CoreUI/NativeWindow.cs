﻿
// Copyright (c) 2017 Luca Piccioni
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

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace OpenGL.CoreUI
{
	/// <summary>
	/// Native window abstract implementation.
	/// </summary>
	public abstract class NativeWindow : IDisposable
	{
		#region Platform Handles

		/// <summary>
		/// Get the display handle associated this instance.
		/// </summary>
		public abstract IntPtr Display { get; }

		/// <summary>
		/// Get the native window handle.
		/// </summary>
		public abstract IntPtr Handle { get; }

		/// <summary>
		/// Run the event loop for this NativeWindow.
		/// </summary>
		public abstract void Run();

		#endregion

		#region Design Properties - Context Attributes

		/// <summary>
		/// Get or set the version to be requested to the OpenGL driver.
		/// </summary>
		public KhronosVersion ContextVersion { get; set; }

		/// <summary>
		/// Profile permission.
		/// </summary>
		public enum ProfileType
		{
			/// <summary>
			/// Requires the core profile
			/// </summary>
			Core,

			/// <summary>
			/// Requires the compatibility profile.
			/// </summary>
			Compatibility,

			/// <summary>
			/// Embedded profile (OpenGL ES).
			/// </summary>
			Embedded,

			/// <summary>
			/// Security Critical (OpenGL SC 2).
			/// </summary>
			SecurityCritical2,
		}

		/// <summary>
		/// Get or set the permission to create a debug context.
		/// </summary>
		public ProfileType ContextProfile
		{
			get { return (_ProfileType); }
			set { _ProfileType = value; }
		}

		/// <summary>
		/// The permission to create a debug context.
		/// </summary>
		private ProfileType _ProfileType = ProfileType.Compatibility;

		/// <summary>
		/// Attribute permission.
		/// </summary>
		public enum AttributePermission
		{
			/// <summary>
			/// Requires the attribute. Throw an error is not supported.
			/// </summary>
			Required,

			/// <summary>
			/// Enable the attribute to be set, if supported.
			/// </summary>
			Enabled,

			/// <summary>
			/// Requires the attrbute to be set, but only when a debugger is attached.
			/// </summary>
			EnabledInDebugger,

			/// <summary>
			/// Do not specify the attribute.
			/// </summary>
			DonCare
		}

		/// <summary>
		/// Get or set the permission to create a debug context.
		/// </summary>
		public AttributePermission DebugContext
		{
			get { return (_DebugContextBit); }
			set { _DebugContextBit = value; }
		}

		/// <summary>
		/// The permission to create a debug context.
		/// </summary>
		private AttributePermission _DebugContextBit = AttributePermission.EnabledInDebugger;

		/// <summary>
		/// Get or set the permission to create a forward compatible context.
		/// </summary>
		public AttributePermission ForwardCompatibleContext
		{
			get { return (_ForwardCompatibleContextBit); }
			set { _ForwardCompatibleContextBit = value; }
		}

		/// <summary>
		/// The permission to create a debug context.
		/// </summary>
		private AttributePermission _ForwardCompatibleContextBit = AttributePermission.DonCare;

		/// <summary>
		/// Get or set the permission to create a robust context.
		/// </summary>
		public AttributePermission RobustContext
		{
			get { return (_RobustContextBit); }
			set { _RobustContextBit = value; }
		}

		/// <summary>
		/// The permission to create a robust context.
		/// </summary>
		private AttributePermission _RobustContextBit = AttributePermission.DonCare;

		#endregion

		#region Design Properties - Framebuffer

		/// <summary>
		/// Get or set the OpenGL minimum color buffer bits.
		/// </summary>
		public uint ColorBits
		{
			get { return (_ColorBits); }
			set
			{
				_ColorBits = value;
			}
		}

		/// <summary>
		/// The OpenGL color buffer bits.
		/// </summary>
		private uint _ColorBits = 24;

		/// <summary>
		/// Get or set the OpenGL minimum depth buffer bits.
		/// </summary>
		public uint DepthBits
		{
			get { return (_DepthBits); }
			set
			{
				_DepthBits = value;
			}
		}

		/// <summary>
		/// The OpenGL depth buffer bits.
		/// </summary>
		private uint _DepthBits;

		/// <summary>
		/// Get or set the OpenGL minimum stencil buffer bits.
		/// </summary>
		public uint StencilBits
		{
			get { return (_StencilBits); }
			set
			{
				_StencilBits = value;
			}
		}

		/// <summary>
		/// The OpenGL stencil buffer bits.
		/// </summary>
		private uint _StencilBits;

		/// <summary>
		/// Get or set the OpenGL minimum multisample buffer "bits".
		/// </summary>
		public uint MultisampleBits
		{
			get { return (_MultisampleBits); }
			set
			{
				_MultisampleBits = value;
			}
		}

		/// <summary>
		/// The OpenGL multisample buffer bits.
		/// </summary>
		private uint _MultisampleBits;

		/// <summary>
		/// Get or set the OpenGL double buffering flag.
		/// </summary>
		public bool DoubleBuffer
		{
			get { return (_DoubleBuffer); }
			set
			{
				_DoubleBuffer = value;
			}
		}

		/// <summary>
		/// The OpenGL double buffering flag.
		/// </summary>
		private bool _DoubleBuffer = true;
		
		/// <summary>
		/// Get or set the OpenGL swap buffers interval. Integer specifing the minimum number of video frames that
		/// are displayed before a buffer swap will occur. Considered only if (WGL|GLX)_EXT_swap_control is supported:
		/// set to 1 to enable V-Sync or set to 0 to disable V-Sync. If the (WGL|GLX)_EXT_swap_control_tear is
		/// supported, set to -1 to enable adaptive V-Sync.
		/// </summary>
		public int SwapInterval
		{
			get { return (_SwapInterval); }
			set { _SwapInterval = value; }
		}

		/// <summary>
		/// The OpenGL swap buffers interval.
		/// </summary>
		private int _SwapInterval = 1;

		/// <summary>
		/// The <see cref="DevicePixelFormat"/> describing the minimum pixel format required by this NativeWindow.
		/// </summary>
		protected DevicePixelFormat WindowPixelFormat
		{
			get
			{
				DevicePixelFormat controlReqFormat = new DevicePixelFormat();

				controlReqFormat.RgbaUnsigned = true;
				controlReqFormat.RenderWindow = true;

				controlReqFormat.ColorBits = (int)ColorBits;
				controlReqFormat.DepthBits = (int)DepthBits;
				controlReqFormat.StencilBits = (int)StencilBits;
				controlReqFormat.MultisampleBits = (int)MultisampleBits;
				controlReqFormat.DoubleBuffer = DoubleBuffer && (_ProfileType != ProfileType.Embedded);     // DB not yet managed using ANGLE

				return (controlReqFormat);
			}
		}

		#endregion

		#region Device Context

		/// <summary>
		/// Create the device context and set the pixel format.
		/// </summary>
		/// <param name="displayHandle">
		/// A <see cref="IntPtr"/> that specifies the handle of the display of <paramref name="windowHandle"/>.
		/// </param>
		/// <param name="windowHandle">
		/// A <see cref="IntPtr"/> that specifies the handle of the window.
		/// </param>
		protected void CreateDeviceContext(IntPtr displayHandle, IntPtr windowHandle)
		{
			CreateDeviceContext(displayHandle, windowHandle, WindowPixelFormat);
		}

		/// <summary>
		/// Create the device context and set the pixel format.
		/// </summary>
		private void CreateDeviceContext(IntPtr displayHandle, IntPtr windowHandle, DevicePixelFormat controlReqFormat)
		{
			#region Support ES/SC API

			switch (_ProfileType) {
				case ProfileType.Embedded:
					DeviceContext.DefaultApi = KhronosVersion.ApiGles2;
					break;
				case ProfileType.SecurityCritical2:
					DeviceContext.DefaultApi = KhronosVersion.ApiGlsc2;
					break;
			}

			#endregion

			#region Create device context

			_DeviceContext = DeviceContext.Create(displayHandle, windowHandle);
			_DeviceContext.IncRef();

			#endregion

			#region Set pixel format

			DevicePixelFormatCollection pixelFormats = _DeviceContext.PixelsFormats;
			List<DevicePixelFormat> matchingPixelFormats = pixelFormats.Choose(controlReqFormat);

			if ((matchingPixelFormats.Count == 0) && controlReqFormat.MultisampleBits > 0) {
				// Try to select the maximum multisample configuration
				int multisampleBits = 0;

				pixelFormats.ForEach(delegate (DevicePixelFormat item) { multisampleBits = Math.Max(multisampleBits, item.MultisampleBits); });

				controlReqFormat.MultisampleBits = multisampleBits;

				matchingPixelFormats = pixelFormats.Choose(controlReqFormat);
			}

			if ((matchingPixelFormats.Count == 0) && controlReqFormat.DoubleBuffer) {
				// Try single buffered pixel formats
				controlReqFormat.DoubleBuffer = false;

				matchingPixelFormats = pixelFormats.Choose(controlReqFormat);
				if (matchingPixelFormats.Count == 0)
					throw new InvalidOperationException(String.Format("unable to find a suitable pixel format: {0}", pixelFormats.GuessChooseError(controlReqFormat)));
			} else if (matchingPixelFormats.Count == 0)
				throw new InvalidOperationException(String.Format("unable to find a suitable pixel format: {0}", pixelFormats.GuessChooseError(controlReqFormat)));

			_DeviceContext.SetPixelFormat(matchingPixelFormats[0]);

			#endregion

			#region Set V-Sync

			if (Gl.PlatformExtensions.SwapControl) {
				int swapInterval = SwapInterval;

				// Mask value in case it is not supported
				if (!Gl.PlatformExtensions.SwapControlTear && swapInterval == -1)
					swapInterval = 1;

				_DeviceContext.SwapInterval(swapInterval);
			}

			#endregion
		}

		// <summary>
		/// Destroy the device context.
		/// </summary>
		protected void DestroyDeviceContext()
		{
			if (_DeviceContext != null) {
				_DeviceContext.Dispose();
				_DeviceContext = null;
			}
		}

		/// <summary>
		/// Swap device buffers.
		/// </summary>
		protected void SwapBuffers()
		{
			_DeviceContext.SwapBuffers();
		}
		
		/// <summary>
		/// The device context.
		/// </summary>
		private DeviceContext _DeviceContext;

		#endregion

		#region Render Context

		/// <summary>
		/// Create the NativeWindow context, eventually shared with others.
		/// </summary>
		protected void CreateDesktopContext()
		{
			if (_RenderContext != IntPtr.Zero)
				throw new InvalidOperationException("context already created");

			IntPtr sharingContext = IntPtr.Zero;
			bool shareResources = false;

			if (shareResources) {
				List<IntPtr> sharingContextes;

				if (_SharingGroups.TryGetValue(ContextSharingGroup, out sharingContextes))
					sharingContext = sharingContextes.Count > 0 ? sharingContextes[0] : IntPtr.Zero;
				else
					_SharingGroups.Add(ContextSharingGroup, new List<IntPtr>());
			}

			if (Gl.PlatformExtensions.CreateContext_ARB) {
				List<int> attributes = new List<int>();
				uint contextProfile = 0, contextFlags = 0;
				bool debuggerAttached = Debugger.IsAttached;

				#region WGL_ARB_create_context|GLX_ARB_create_context

				// The default values for WGL_CONTEXT_MAJOR_VERSION_ARB and WGL_CONTEXT_MINOR_VERSION_ARB are 1 and 0 respectively. In this
				// case, implementations will typically return the most recent version of OpenGL they support which is backwards compatible with OpenGL 1.0
				// (e.g. 3.0, 3.1 + GL_ARB_compatibility, or 3.2 compatibility profile) [from WGL_ARB_create_context spec]
				Debug.Assert(Wgl.CONTEXT_MAJOR_VERSION_ARB == Glx.CONTEXT_MAJOR_VERSION_ARB);
				Debug.Assert(Wgl.CONTEXT_MINOR_VERSION_ARB == Glx.CONTEXT_MINOR_VERSION_ARB);
				if (ContextVersion != null) {
					attributes.AddRange(new int[] {
						Wgl.CONTEXT_MAJOR_VERSION_ARB, ContextVersion.Major,
						Wgl.CONTEXT_MINOR_VERSION_ARB, ContextVersion.Minor
					});
				} else {
					// Note: this shouldn't be necessary since defaults are defined. However, on certains drivers this arguments are
					// required for specifying CONTEXT_FLAGS_ARB and CONTEXT_PROFILE_MASK_ARB attributes:
					// - Required by NVIDIA 266.72 on GeForce GT 540M on Windows 7 x64
					attributes.AddRange(new int[] {
						Wgl.CONTEXT_MAJOR_VERSION_ARB, 1,
						Wgl.CONTEXT_MINOR_VERSION_ARB, 0
					});
				}

				if ((_DebugContextBit == AttributePermission.Enabled) || (debuggerAttached && _DebugContextBit == AttributePermission.EnabledInDebugger)) {
					Debug.Assert(Wgl.CONTEXT_DEBUG_BIT_ARB == Glx.CONTEXT_DEBUG_BIT_ARB);
					contextFlags |= Wgl.CONTEXT_DEBUG_BIT_ARB;
				}

				if ((_ForwardCompatibleContextBit == AttributePermission.Enabled) || (debuggerAttached && _ForwardCompatibleContextBit == AttributePermission.EnabledInDebugger)) {
					Debug.Assert(Wgl.CONTEXT_FORWARD_COMPATIBLE_BIT_ARB == Glx.CONTEXT_FORWARD_COMPATIBLE_BIT_ARB);
					contextFlags |= Wgl.CONTEXT_FORWARD_COMPATIBLE_BIT_ARB;
				}

				#endregion

				#region WGL_ARB_create_context_profile|GLX_ARB_create_context_profile

				if (Gl.PlatformExtensions.CreateContextProfile_ARB) {

					switch (_ProfileType) {
						case ProfileType.Core:
							Debug.Assert(Wgl.CONTEXT_CORE_PROFILE_BIT_ARB == Glx.CONTEXT_CORE_PROFILE_BIT_ARB);
							contextProfile |= Wgl.CONTEXT_CORE_PROFILE_BIT_ARB;
							break;
						case ProfileType.Compatibility:
							Debug.Assert(Wgl.CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB == Glx.CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB);
							contextProfile |= Wgl.CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB;
							break;
					}
				}

				#endregion

				#region WGL_ARB_create_context_robustness|GLX_ARB_create_context_robustness

				if (Gl.PlatformExtensions.CreateContextRobustness_ARB) {

					if ((_RobustContextBit == AttributePermission.Enabled) || (debuggerAttached && _RobustContextBit == AttributePermission.EnabledInDebugger)) {
						Debug.Assert(Wgl.CONTEXT_ROBUST_ACCESS_BIT_ARB == Glx.CONTEXT_ROBUST_ACCESS_BIT_ARB);
						contextFlags |= Wgl.CONTEXT_ROBUST_ACCESS_BIT_ARB;
					}

				}

				#endregion

				Debug.Assert(Wgl.CONTEXT_FLAGS_ARB == Glx.CONTEXT_FLAGS_ARB);
				if (contextFlags != 0)
					attributes.AddRange(new int[] { Wgl.CONTEXT_FLAGS_ARB, unchecked((int)contextFlags) });

				Debug.Assert(Wgl.CONTEXT_PROFILE_MASK_ARB == Glx.CONTEXT_PROFILE_MASK_ARB);
				Debug.Assert(contextProfile == 0 || Gl.PlatformExtensions.CreateContextProfile_ARB);
				if (contextProfile != 0)
					attributes.AddRange(new int[] { Wgl.CONTEXT_PROFILE_MASK_ARB, unchecked((int)contextProfile) });

				attributes.Add(0);

				if ((_RenderContext = _DeviceContext.CreateContextAttrib(sharingContext, attributes.ToArray())) == IntPtr.Zero)
					throw new InvalidOperationException(String.Format("unable to create render context ({0})", Gl.GetError()));
			} else {
				// Create OpenGL context using compatibility profile
				if ((_RenderContext = _DeviceContext.CreateContext(sharingContext)) == IntPtr.Zero)
					throw new InvalidOperationException("unable to create render context");
			}

			// Allow other GlControl instances to reuse this GlControl context
			if (shareResources) {
				if (_SharingWindows.ContainsKey(ContextSharingGroup))
					throw new InvalidOperationException(String.Format("another GlControl has created sharing group {0}", ContextSharingGroup));
				_SharingWindows.Add(ContextSharingGroup, this);
			}

			// Allow other GlControl instances to share resources with this context
			if (shareResources == true) {
				List<IntPtr> sharingContextes;

				// Get the list previously created
				_SharingGroups.TryGetValue(ContextSharingGroup, out sharingContextes);
				// ...and register this context among the others
				sharingContextes.Add(_RenderContext);
			}
		}

		/// <summary>
		/// Delete the NativeWindow context.
		/// </summary>
		protected void DeleteContext()
		{
			// Remove this context from the sharing group
			if (ContextSharing == ContextSharingOption.OwnContext && ContextSharingGroup != null) {
				List<IntPtr> sharingContextes;

				// Get the list previously created
				_SharingGroups.TryGetValue(ContextSharingGroup, out sharingContextes);
				// Remove this context
				bool res = sharingContextes.Remove(_RenderContext);
				Debug.Assert(res);
			}

			// Delete OpenGL context
			if (_RenderContext != IntPtr.Zero) {
				_DeviceContext.DeleteContext(_RenderContext);
				_RenderContext = IntPtr.Zero;
			}
		}

		/// <summary>
		/// Make the GlControl context current.
		/// </summary>
		protected void MakeCurrentContext()
		{
			// Make context current
			if (_DeviceContext.MakeCurrent(_RenderContext) == false)
				throw new InvalidOperationException("unable to make context current");
		}

		/// <summary>
		/// The OpenGL context created on this GlControl.
		/// </summary>
		protected IntPtr _RenderContext;

		/// <summary>
		/// The <see cref="NativeWindow"/> that owns <see cref="_RenderContext"/>.
		/// </summary>
		private NativeWindow _SharingWindow;

		#endregion

		#region Render Context Shadring

		/// <summary>
		/// Context sharing options.
		/// </summary>
		public enum ContextSharingOption
		{
			/// <summary>
			/// Create its own context.
			/// </summary>
			OwnContext,

			/// <summary>
			/// Do not create its own context, but reuse the first one created by application.
			/// </summary>
			SingleContext,
		}

		/// <summary>
		/// Get or set the context sharing option.
		/// </summary>
		public ContextSharingOption ContextSharing
		{
			get { return (_ContextSharing); }
			set
			{
				if (_RenderContext != IntPtr.Zero)
					throw new InvalidOperationException("read-only property");
				_ContextSharing = value;
			}
		}

		/// <summary>
		/// The context sharing option.
		/// </summary>
		private ContextSharingOption _ContextSharing = ContextSharingOption.OwnContext;

		/// <summary>
		/// Get or set a tag for defining sharing groups.
		/// </summary>
		public string ContextSharingGroup
		{
			get { return (_ContextSharingGroup); }
			set
			{
				if (_RenderContext != IntPtr.Zero)
					throw new InvalidOperationException("read-only property");
				_ContextSharingGroup = value;
			}
		}

		/// <summary>
		/// A tag for defining sharing groups.
		/// </summary>
		private string _ContextSharingGroup;

		/// <summary>
		/// Map group names with the contextes sharing resources.
		/// </summary>
		private static readonly Dictionary<string, List<IntPtr>> _SharingGroups = new Dictionary<string, List<IntPtr>>();

		/// <summary>
		/// 
		/// </summary>
		private static readonly Dictionary<string, NativeWindow> _SharingWindows = new Dictionary<string, NativeWindow>();

		#endregion

		#region Abstract Interface

		/// <summary>
		/// Create the NativeWindow.
		/// </summary>
		/// <param name="x">
		/// A <see cref="Int32"/> that specifies the X coordinate of the window, in pixels.
		/// </param>
		/// <param name="y">
		/// A <see cref="Int32"/> that specifies the Y coordinate of the window, in pixels.
		/// </param>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specifies the window width, in pixels.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specifies the window height, in pixels.
		/// </param>
		public abstract void Create(int x, int y, uint width, uint height);

		/// <summary>
		/// The NativeWindow width of the client area, in pixels.
		/// </summary>
		public abstract uint Width { get; }

		/// <summary>
		/// The NativeWindow height of the client area, in pixels.
		/// </summary>
		public abstract uint Height { get; }

		/// <summary>
		/// Show the native window.
		/// </summary>
		public abstract void Show();

		/// <summary>
		/// Hide the native window.
		/// </summary>
		public abstract void Hide();

		#endregion

		#region Events

		/// <summary>
		/// Event raised on control creation time, allow user to allocate resource on control.
		/// </summary>
		public event EventHandler<NativeWindowEventArgs> ContextCreated;

		/// <summary>
		/// Raise the event <see cref="ContextCreated"/>.
		/// </summary>
		protected virtual void OnContextCreated()
		{
			ContextCreated?.Invoke(this, new NativeWindowEventArgs(_DeviceContext, _RenderContext));
		}

		/// <summary>
		/// Event raised on control disposition time, allow user to dispose resources on control.
		/// </summary>
		public event EventHandler<NativeWindowEventArgs> ContextDestroying;

		/// <summary>
		/// Raise the event <see cref="ContextDestroying"/>.
		/// </summary>
		protected virtual void OnContextDestroying()
		{
			ContextDestroying?.Invoke(this, new NativeWindowEventArgs(_DeviceContext, _RenderContext));
		}

		/// <summary>
		/// Event raised on control render time, allow user to draw on control.
		/// </summary>
		public event EventHandler<NativeWindowEventArgs> Render;

		/// <summary>
		/// Raise the event <see cref="Render"/>.
		/// </summary>
		protected virtual void OnRender()
		{
			Render?.Invoke(this, new NativeWindowEventArgs(_DeviceContext, _RenderContext));
		}

		/// <summary>
		/// Event raised on control render time, allow user to update resources. It is executed AFTER the <see cref="Render"/>
		/// event.
		/// </summary>
		public event EventHandler<NativeWindowEventArgs> ContextUpdate;

		/// <summary>
		/// Raise the event <see cref="ContextUpdate"/>.
		/// </summary>
		protected virtual void OnContextUpdate()
		{
			ContextUpdate?.Invoke(this, new NativeWindowEventArgs(_DeviceContext, _RenderContext));
		}

		#endregion

		#region Factory

		/// <summary>
		/// Create a <see cref="NativeWindow"/> for the current platform.
		/// </summary>
		/// <returns>
		/// It returns a <see cref="NativeWindow"/> implementation for the current platform.
		/// </returns>
		/// <exception cref="NotSupportedException">
		/// Exception thrown if the current platform is not supported (no native window backend implemented).
		/// </exception>
		public static NativeWindow Create()
		{
			switch (OpenGL.Platform.CurrentPlatformId) {
				case OpenGL.Platform.Id.WindowsNT:
					return (new NativeWindowWinNT());
				default:
					throw new NotSupportedException();
			}
		}

		#endregion

		#region IDisposable Implementation

		/// <summary>
		/// Finalizer.
		/// </summary>
		~NativeWindow()
		{
			Dispose(false);
		}

		/// <summary>
		/// Get whether this instance has been disposed.
		/// </summary>
		public bool IsDisposed { get { return (_Disposed); } }

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="System.Boolean"/> indicating whether the disposition is requested explictly.
		/// </param>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing) {
				// Mark as disposed
				_Disposed = true;
			}
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		
		/// <summary>
		/// Disposed state.
		/// </summary>
		private bool _Disposed;

		#endregion
	}
}
