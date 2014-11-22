#region license

/*
MediaFoundationLib - Provide access to MediaFoundation interfaces via .NET
Copyright (C) 2007
http://mfnet.sourceforge.net

This library is free software; you can redistribute it and/or
modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation; either
version 2.1 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public
License along with this library; if not, write to the Free Software
Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/

#endregion

using System;
using System.Runtime.InteropServices;

using MediaFoundation;
using MediaFoundation.Misc;
using MediaFoundation.Transform;
using System.Drawing;

namespace MediaFoundation.EVR
{


    /// <summary>
    /// Controls how the <c>Enhanced Video Renderer</c> (EVR) displays video. 
    /// <para/>
    /// The EVR presenter implements this interface. To get a pointer to the interface, call 
    /// <see cref="IMFGetService.GetService"/>. The service identifier is GUID MR_VIDEO_RENDER_SERVICE.
    /// Call <strong>GetService</strong> on any of the following objects: 
    /// <para/>
    /// If you implement a custom presenter for the EVR, the presenter can optionally expose this interface
    /// as a service.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/DB9B4663-9240-484F-8C47-CB1F5DAA238D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DB9B4663-9240-484F-8C47-CB1F5DAA238D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("A490B1E4-AB84-4D31-A1B2-181E03B1077A"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFVideoDisplayControl
    {
        /// <summary>
        /// Gets the size and aspect ratio of the video, prior to any stretching by the video renderer. 
        /// </summary>
        /// <param name="pszVideo">
        /// Receives the size of the native video rectangle. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="pszARVideo">
        /// Receives the aspect ratio of the video. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_POINTER</strong></term><description>At least one of the parameters must be non- <strong>NULL</strong>. </description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The video renderer has been shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetNativeVideoSize(
        ///   [in, out]  SIZE *pszVideo,
        ///   [in, out]  SIZE *pszARVideo
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/12630035-DD07-44BD-98F7-79974C9CC58B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/12630035-DD07-44BD-98F7-79974C9CC58B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetNativeVideoSize(
            [Out] MFSize pszVideo,
            [Out] MFSize pszARVideo
            );

        /// <summary>
        /// Gets the range of sizes that the enhanced video renderer (EVR) can display without significantly
        /// degrading performance or image quality. 
        /// </summary>
        /// <param name="pszMin">
        /// Receives the minimum ideal size. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="pszMax">
        /// Receives the maximum ideal size. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_POINTER</strong></term><description>At least one parameter must be non- <strong>NULL</strong>. </description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The video renderer has been shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetIdealVideoSize(
        ///   [in, out]  SIZE *pszMin,
        ///   [in, out]  SIZE *pszMax
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C580778B-FE7C-4C62-9BCD-8A5FDE370B9D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C580778B-FE7C-4C62-9BCD-8A5FDE370B9D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetIdealVideoSize(
            [Out] MFSize pszMin,
            [Out] MFSize pszMax
            );

        /// <summary>
        /// Sets the source and destination rectangles for the video.
        /// </summary>
        /// <param name="pnrcSource">
        /// Pointer to an <see cref="EVR.MFVideoNormalizedRect"/> structure that specifies the source
        /// rectangle. This parameter can be <strong>NULL</strong>. If this parameter is <strong>NULL</strong>,
        /// the source rectangle does not change. 
        /// </param>
        /// <param name="prcDest">
        /// Specifies the destination rectangle. This parameter can be <strong>NULL</strong>. If this parameter
        /// is <strong>NULL</strong>, the destination rectangle does not change. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_POINTER</strong></term><description>At least one parameter must be non- <strong>NULL</strong>. </description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The video renderer has been shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetVideoPosition(
        ///   [in]  const MFVideoNormalizedRect *pnrcSource,
        ///   [in]  const LPRECT prcDest
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5DC789B7-E206-4F1D-A0B2-12CB98CE4184(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5DC789B7-E206-4F1D-A0B2-12CB98CE4184(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetVideoPosition(
            [In] MFVideoNormalizedRect pnrcSource,
            [In] MFRect prcDest
            );

        /// <summary>
        /// Gets the source and destination rectangles for the video. 
        /// </summary>
        /// <param name="pnrcSource">
        /// Pointer to an <see cref="EVR.MFVideoNormalizedRect"/> structure that receives the source rectangle.
        /// </param>
        /// <param name="prcDest">
        /// Receives the current destination rectangle.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_POINTER</strong></term><description>One or more required parameters are <strong>NULL</strong>. </description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The video renderer has been shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetVideoPosition(
        ///   [out]  MFVideoNormalizedRect *pnrcSource,
        ///   [out]  LPRECT prcDest
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/59C2E914-CC15-4534-976C-A760FF97F6AE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/59C2E914-CC15-4534-976C-A760FF97F6AE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetVideoPosition(
            [Out] MFVideoNormalizedRect pnrcSource,
            [Out] MFRect prcDest
            );

        /// <summary>
        /// Specifies how the enhanced video renderer (EVR) handles the aspect ratio of the source video.
        /// </summary>
        /// <param name="dwAspectRatioMode">
        /// Bitwise <strong>OR</strong> of one or more flags from the <see cref="EVR.MFVideoAspectRatioMode"/>
        /// enumeration. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>Invalid flags.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The video renderer has been shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetAspectRatioMode(
        ///   [in]  DWORD dwAspectRatioMode
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DD49A110-1C11-4ECA-9E7B-6021F3BDD397(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DD49A110-1C11-4ECA-9E7B-6021F3BDD397(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetAspectRatioMode(
            [In] MFVideoAspectRatioMode dwAspectRatioMode
            );

        /// <summary>
        /// Queries how the enhanced video renderer (EVR) handles the aspect ratio of the source video. 
        /// </summary>
        /// <param name="pdwAspectRatioMode">
        /// Receives a bitwise <strong>OR</strong> of one or more flags from the 
        /// <see cref="EVR.MFVideoAspectRatioMode"/> enumeration. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The video renderer has been shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetAspectRatioMode(
        ///   [out]  DWORD *pdwAspectRatioMode
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B5E81F80-E5C9-4ECF-8F10-D52A0533F086(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B5E81F80-E5C9-4ECF-8F10-D52A0533F086(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetAspectRatioMode(
            out MFVideoAspectRatioMode pdwAspectRatioMode
            );

        /// <summary>
        /// Sets the clipping window for the video.
        /// </summary>
        /// <param name="hwndVideo">
        /// Handle to the window where the enhanced video renderer (EVR) will draw the video.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description><em>hwndVideo</em> does not specify a valid window. </description></item>
        /// <item><term><strong>S_FALSE</strong></term><description>DWM thumbnails were not enabled/disabled.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetVideoWindow(
        ///   [in]  HWND hwndVideo
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/50BC345C-EE44-4174-9B1A-E406041096B5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/50BC345C-EE44-4174-9B1A-E406041096B5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetVideoWindow(
            [In] IntPtr hwndVideo
            );

        /// <summary>
        /// Gets the clipping window for the video. 
        /// </summary>
        /// <param name="phwndVideo">
        /// Receives a handle to the window where the enhanced video renderer (EVR) will draw the video.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The video renderer has been shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetVideoWindow(
        ///   [out]  HWND *phwndVideo
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0B2B6B61-A2C5-4EFD-AC40-962B0C2AE9C5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0B2B6B61-A2C5-4EFD-AC40-962B0C2AE9C5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetVideoWindow(
            out IntPtr phwndVideo
            );

        /// <summary>
        /// Repaints the current video frame. Call this method whenever the application receives a WM_PAINT
        /// message.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The EVR cannot repaint the frame at this time. This error can occur while the EVR is switching between full-screen and windowed mode. The caller can safely ignore this error.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The video renderer has been shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT RepaintVideo();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C8051883-2A48-4CA4-A7D2-C90D0D451CD2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C8051883-2A48-4CA4-A7D2-C90D0D451CD2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RepaintVideo();

        /// <summary>
        /// Gets a copy of the current image being displayed by the video renderer. 
        /// </summary>
        /// <param name="pBih">
        /// Pointer to a <strong>BITMAPINFOHEADER</strong> structure that receives a description of the bitmap.
        /// Set the <strong>biSize</strong> member of the structure to <c>sizeof(BITMAPINFOHEADER)</c>
        /// before calling the method. 
        /// </param>
        /// <param name="pDib">
        /// Receives a pointer to a buffer that contains a packed Windows device-independent bitmap (DIB). The
        /// caller must free the memory for the bitmap by calling <c>CoTaskMemFree</c>. 
        /// </param>
        /// <param name="pcbDib">
        /// Receives the size of the buffer returned in <em>pDib</em>, in bytes. 
        /// </param>
        /// <param name="pTimeStamp">
        /// Receives the time stamp of the captured image.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_LICENSE_INCORRECT_RIGHTS</strong></term><description>The content is protected and the license does not permit capturing the image.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The video renderer has been shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetCurrentImage(
        ///   [in, out]  BITMAPINFOHEADER *pBih,
        ///   [out]      BYTE **pDib,
        ///   [out]      DWORD *pcbDib,
        ///   [in, out]  LONGLONG *pTimeStamp
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/25EC4C23-04DD-4E18-9CC1-DE9E57271E8F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/25EC4C23-04DD-4E18-9CC1-DE9E57271E8F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetCurrentImage(
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BMMarshaler))] BitmapInfoHeader pBih,
            out IntPtr pDib,
            out int pcbDib,
            out long pTimeStamp
            );

        /// <summary>
        /// Sets the border color for the video.
        /// </summary>
        /// <param name="Clr">
        /// Specifies the border color as a <strong>COLORREF</strong> value. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The video renderer has been shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetBorderColor(
        ///   [in]  COLORREF Clr
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4A3647A8-4789-4F18-979B-4A9EE1CE7B71(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4A3647A8-4789-4F18-979B-4A9EE1CE7B71(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetBorderColor(
            [In] int Clr
            );

        /// <summary>
        /// Gets the border color for the video. 
        /// </summary>
        /// <param name="pClr">
        /// Receives the border color, as a <strong>COLORREF</strong> value. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The video renderer has been shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetBorderColor(
        ///   [out]  COLORREF *pClr
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1B65B793-D06D-4D7F-A19F-0068DD7F2E44(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1B65B793-D06D-4D7F-A19F-0068DD7F2E44(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetBorderColor(
            out int pClr
            );

        /// <summary>
        /// Sets various preferences related to video rendering.
        /// </summary>
        /// <param name="dwRenderFlags">
        /// Bitwise <strong>OR</strong> of zero or more flags from the <see cref="EVR.MFVideoRenderPrefs"/>
        /// enumeration. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>Invalid flags.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The video renderer has been shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetRenderingPrefs(
        ///   [in]  DWORD dwRenderFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7603AAF8-1671-4B35-BEE5-335F656DE3C5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7603AAF8-1671-4B35-BEE5-335F656DE3C5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetRenderingPrefs(
            [In] MFVideoRenderPrefs dwRenderFlags
            );

        /// <summary>
        /// Gets various video rendering settings. 
        /// </summary>
        /// <param name="pdwRenderFlags">
        /// Receives a bitwise <strong>OR</strong> of zero or more flags from the 
        /// <see cref="EVR.MFVideoRenderPrefs"/> enumeration. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The video renderer has been shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetRenderingPrefs(
        ///   [out]  DWORD *pdwRenderFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9A5BD1D6-E604-4798-AF29-AD0C1931B651(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9A5BD1D6-E604-4798-AF29-AD0C1931B651(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetRenderingPrefs(
            out MFVideoRenderPrefs pdwRenderFlags
            );

        /// <summary>
        /// [This API is not supported and may be altered or unavailable in the future. ]
        /// <para/>
        /// Sets or unsets full-screen rendering mode.
        /// <para/>
        /// To implement full-screen playback, an application should simply resize the video window to cover
        /// the entire area of the monitor. Also set the window to be a topmost window, so that the application
        /// receives all mouse-click messages. For more information about topmost windows, see the
        /// documentation for the <c>SetWindowPos</c> function. 
        /// </summary>
        /// <param name="fFullscreen">
        /// If <strong>TRUE</strong>, the enhanced video renderer (EVR) uses full-screen mode. If <strong>FALSE
        /// </strong>, the EVR draws the video in the application-provided clipping window. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description> The video renderer has been shut down. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetFullscreen(
        ///   [in]  BOOL fFullscreen
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/95C85FB2-9267-477F-AA47-1C050CCC1BDD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/95C85FB2-9267-477F-AA47-1C050CCC1BDD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetFullscreen(
            [In, MarshalAs(UnmanagedType.Bool)] bool fFullscreen
            );

        /// <summary>
        /// Queries whether the enhanced video renderer (EVR) is currently in full-screen mode. 
        /// </summary>
        /// <param name="pfFullscreen">
        /// Receives a Boolean value. If <strong>TRUE</strong>, the EVR is in full-screen mode. If <strong>
        /// FALSE</strong>, the EVR will display the video inside the application-provided clipping window. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The EVR is currently switching between full-screen and windowed mode.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetFullscreen(
        ///   [out]  BOOL *pfFullscreen
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EE564655-BE8A-46F7-9682-ACF3B38D056A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EE564655-BE8A-46F7-9682-ACF3B38D056A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetFullscreen(
            [MarshalAs(UnmanagedType.Bool)] out bool pfFullscreen
            );
    }

}
