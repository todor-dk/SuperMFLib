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
    /// Alpha-blends a static bitmap image with the video displayed by the <c>Enhanced Video Renderer</c>
    /// (EVR). 
    /// <para/>
    /// The EVR mixer implements this interface. To get a pointer to the interface, call 
    /// <see cref="IMFGetService.GetService"/>. The service identifier GUID is MR_VIDEO_MIXER_SERVICE. Call
    /// <strong>GetService</strong> on any of the following objects: 
    /// <para/>
    /// If you implement a custom mixer for the EVR, the mixer can optionally expose this interface as a
    /// service.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/4DA4BDB9-857B-40C9-B910-04A099A23AB5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4DA4BDB9-857B-40C9-B910-04A099A23AB5(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("814C7B20-0FDB-4eec-AF8F-F957C8F69EDC")]
    public interface IMFVideoMixerBitmap
    {
        /// <summary>
        /// Sets a bitmap image for the enhanced video renderer (EVR) to alpha-blend with the video.
        /// </summary>
        /// <param name="pBmpParms">
        /// Pointer to an <see cref="EVR.MFVideoAlphaBitmap"/> structure that contains information about the
        /// bitmap, the source and destination rectangles, the color key, and other information. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>The blending parameters defined in the <em>pBmpParms</em> structure are not valid. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetAlphaBitmap(
        ///   [in]  const MFVideoAlphaBitmap *pBmpParms
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A70E6734-BF49-4DEA-8BF6-917B8465CC78(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A70E6734-BF49-4DEA-8BF6-917B8465CC78(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetAlphaBitmap(
            [In, MarshalAs(UnmanagedType.LPStruct)] MFVideoAlphaBitmap pBmpParms);

        /// <summary>
        /// Removes the current bitmap and releases any resources associated with it.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_NOT_INITIALIZED</strong></term><description>No bitmap is currently set.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT ClearAlphaBitmap();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/79A0F24C-9388-4C64-885F-5D04E671669E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/79A0F24C-9388-4C64-885F-5D04E671669E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ClearAlphaBitmap();

        /// <summary>
        /// Updates the current alpha-blending settings, including the source and destination rectangles, the
        /// color key, and other information. You can update some or all of the blending parameters.
        /// </summary>
        /// <param name="pBmpParms">
        /// Pointer to an <see cref="EVR.MFVideoAlphaBitmapParams"/> structure that contains the blending
        /// parameters. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>The blending parameters defined in the <em>pBmpParms</em> structure are not valid. </description></item>
        /// <item><term><strong>MF_E_NOT_INITIALIZED</strong></term><description>No bitmap is currently set. You must call <see cref="EVR.IMFVideoMixerBitmap.SetAlphaBitmap"/> to set a bitmap. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT UpdateAlphaBitmapParameters(
        ///   [in]  const MFVideoAlphaBitmapParams *pBmpParms
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/369BF934-B0A0-44B2-BEA2-E8575404D36D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/369BF934-B0A0-44B2-BEA2-E8575404D36D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int UpdateAlphaBitmapParameters(
            [In] MFVideoAlphaBitmapParams pBmpParms);

        /// <summary>
        /// Retrieves the current settings that the enhanced video renderer (EVR) uses to alpha-blend the
        /// bitmap with the video.
        /// </summary>
        /// <param name="pBmpParms">
        /// Pointer to an <see cref="EVR.MFVideoAlphaBitmapParams"/> structure that receives the current
        /// blending parameters. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_NOT_INITIALIZED</strong></term><description>No bitmap is currently set. You must call <see cref="EVR.IMFVideoMixerBitmap.SetAlphaBitmap"/> to set a bitmap. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetAlphaBitmapParameters(
        ///   [out]  MFVideoAlphaBitmapParams *pBmpParms
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0361E340-9DE7-47F3-80FD-61D5E914D44E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0361E340-9DE7-47F3-80FD-61D5E914D44E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetAlphaBitmapParameters(
            [Out] MFVideoAlphaBitmapParams pBmpParms);
    }

}
