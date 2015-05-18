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
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation.dxvahd.Interfaces
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Represents a Microsoft DirectX Video Acceleration High Definition (DXVA-HD) video processor. 
    /// <para/>
    /// To get a pointer to this interface, call the 
    /// <see cref="dxvahd.IDXVAHD_Device.CreateVideoProcessor"/> method. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/CBFACFF5-1CBB-4296-8242-C06B43FC95AF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CBFACFF5-1CBB-4296-8242-C06B43FC95AF(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("95f4edf4-6e03-4cd7-be1b-3075d665aa52"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IDXVAHD_VideoProcessor
    {
        /// <summary>
        /// Sets a state parameter for a blit operation by a Microsoft DirectX Video Acceleration High
        /// Definition (DXVA-HD) device.
        /// </summary>
        /// <param name="State">
        /// The state parameter to set, specified as a member of the <see cref="dxvahd.DXVAHD_BLT_STATE"/>
        /// enumeration. 
        /// </param>
        /// <param name="DataSize">
        /// The size, in bytes, of the buffer pointed to by <em>pData</em>. 
        /// </param>
        /// <param name="pData">
        /// A pointer to a buffer that contains the state data. The meaning of the data depends on the <em>
        /// State</em> parameter. Each state has a corresponding data structure; for more information, see 
        /// <see cref="dxvahd.DXVAHD_BLT_STATE"/>. The caller allocates the buffer and fills in the parameter
        /// data before calling this method. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetVideoProcessBltState(
        ///   [in]  DXVAHD_BLT_STATE State,
        ///   [in]  UINT DataSize,
        ///   [in]  const void *pData
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/ADC08662-7977-402D-9EB1-505333550FC8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/ADC08662-7977-402D-9EB1-505333550FC8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetVideoProcessBltState(
            DXVAHD_BLT_STATE State,
            int DataSize,
            IntPtr pData
            );

        /// <summary>
        /// Gets the value of a state parameter for blit operations performed by a Microsoft DirectX Video
        /// Acceleration High Definition (DXVA-HD) device.
        /// </summary>
        /// <param name="State">
        /// The state parameter to query, specified as a member of the <see cref="dxvahd.DXVAHD_BLT_STATE"/>
        /// enumeration. 
        /// </param>
        /// <param name="DataSize">
        /// The size, in bytes, of the buffer pointed to by <em>pData</em>. 
        /// </param>
        /// <param name="pData">
        /// A pointer to a buffer allocated by the caller. The method copies the state data into the buffer.
        /// The buffer must be large enough to hold the data structure that corresponds to the state parameter.
        /// For more information, see <see cref="dxvahd.DXVAHD_BLT_STATE"/>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetVideoProcessBltState(
        ///   [in]   DXVAHD_BLT_STATE State,
        ///   [in]   UINT DataSize,
        ///   [out]  void *pData
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5FDB0D39-7A64-41FD-8F70-4085DDBC7EBC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5FDB0D39-7A64-41FD-8F70-4085DDBC7EBC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetVideoProcessBltState(
            DXVAHD_BLT_STATE State,
            int DataSize,
            IntPtr pData
            );

        /// <summary>
        /// Sets a state parameter for an input stream on a  Microsoft DirectX Video Acceleration High
        /// Definition (DXVA-HD) device.
        /// </summary>
        /// <param name="StreamNumber">
        /// The zero-based index of the input stream. To get the maximum number of streams, call 
        /// <see cref="dxvahd.IDXVAHD_Device.GetVideoProcessorDeviceCaps"/> and check the <strong>
        /// MaxStreamStates</strong> member of the <see cref="dxvahd.DXVAHD_VPDEVCAPS"/> structure. 
        /// </param>
        /// <param name="State">
        /// The state parameter to set, specified as a member of the <see cref="dxvahd.DXVAHD_STREAM_STATE"/>
        /// enumeration. 
        /// </param>
        /// <param name="DataSize">
        /// The size, in bytes, of the buffer pointed to by <em>pData</em>. 
        /// </param>
        /// <param name="pData">
        /// A pointer to a buffer that contains the state data. The meaning of the data depends on the <em>
        /// State</em> parameter. Each state has a corresponding data structure; for more information, see 
        /// <see cref="dxvahd.DXVAHD_STREAM_STATE"/>. The caller allocates the buffer and fills in the
        /// parameter data before calling this method. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetVideoProcessStreamState(
        ///   [in]  UINT StreamNumber,
        ///   [in]  DXVAHD_STREAM_STATE State,
        ///   [in]  UINT DataSize,
        ///   [in]  const void *pData
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/40A8444F-576E-40FF-804E-0912812F0EE6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/40A8444F-576E-40FF-804E-0912812F0EE6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetVideoProcessStreamState(
            int StreamNumber,
            DXVAHD_STREAM_STATE State,
            int DataSize,
            IntPtr pData
            );

        /// <summary>
        /// Gets the value of a state parameter for an input stream on a  Microsoft DirectX Video Acceleration
        /// High Definition (DXVA-HD) device.
        /// </summary>
        /// <param name="StreamNumber">
        /// The zero-based index of the input stream. To get the maximum number of streams, call 
        /// <see cref="dxvahd.IDXVAHD_Device.GetVideoProcessorDeviceCaps"/> and check the <strong>
        /// MaxStreamStates</strong> member of the <see cref="dxvahd.DXVAHD_VPDEVCAPS"/> structure. 
        /// </param>
        /// <param name="State">
        /// The state parameter to query, specified as a member of the <see cref="dxvahd.DXVAHD_STREAM_STATE"/>
        /// enumeration. 
        /// </param>
        /// <param name="DataSize">
        /// The size, in bytes, of the buffer pointed to by <em>pData</em>. 
        /// </param>
        /// <param name="pData">
        /// A pointer to a buffer allocated by the caller. The method copies the state data into the buffer.
        /// The buffer must be large enough to hold the data structure that corresponds to the state parameter.
        /// For more information, see <see cref="dxvahd.DXVAHD_STREAM_STATE"/>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetVideoProcessStreamState(
        ///   [in]   UINT StreamNumber,
        ///   [in]   DXVAHD_STREAM_STATE State,
        ///   [in]   UINT DataSize,
        ///   [out]  void *pData
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1CEEAE95-D67D-4F11-B815-F4EEF517E7CE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1CEEAE95-D67D-4F11-B815-F4EEF517E7CE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetVideoProcessStreamState(
            int StreamNumber,
            DXVAHD_STREAM_STATE State,
            int DataSize,
            IntPtr pData
            );

        /// <summary>
        /// Performs a video processing blit on one or more input samples and writes the result to a Microsoft
        /// Direct3D surface.
        /// </summary>
        /// <param name="pOutputSurface">
        /// A pointer to the <strong>IDirect3DSurface9</strong> interface of a Direct3D surface. The output of
        /// the video processing operation will be written to this surface. The following surface types can be
        /// used: 
        /// <para/>
        /// <para>* A video surface of type <strong>DXVAHD_SURFACE_TYPE_VIDEO_OUTPUT</strong>. See 
        /// <see cref="dxvahd.IDXVAHD_Device.CreateVideoSurface"/>. </para><para>* A render-target surface or
        /// texture surface created with D3DUSAGE_RENDERTARGET usage.</para><para>* A swap chain.</para><para>*
        /// A swap chain with overlay support ( <strong>D3DSWAPEFFECT_OVERLAY</strong>). </para>
        /// </param>
        /// <param name="OutputFrame">
        /// Frame number of the output video frame, indexed from zero.
        /// </param>
        /// <param name="StreamCount">
        /// Number of input streams to process. 
        /// </param>
        /// <param name="pStreams">
        /// Pointer to an array of <see cref="dxvahd.DXVAHD_STREAM_DATA"/> structures that contain information
        /// about the input streams. The caller allocates the array and fills in each structure. The number of
        /// elements in the array is given in the <em>StreamCount</em> parameter. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT VideoProcessBltHD(
        ///   [in]  IDirect3DSurface9 *pOutputSurface,
        ///   [in]  UINT OutputFrame,
        ///   [in]  UINT StreamCount,
        ///   [in]  const DXVAHD_STREAM_DATA *pStreams
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/59C4DEEE-4EF2-4ABA-8188-989904055E70(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/59C4DEEE-4EF2-4ABA-8188-989904055E70(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int VideoProcessBltHD(
            IDirect3DSurface9 pOutputSurface,
            int OutputFrame,
            int StreamCount,
            DXVAHD_STREAM_DATA[] pStreams
            );
    }

#endif

}
