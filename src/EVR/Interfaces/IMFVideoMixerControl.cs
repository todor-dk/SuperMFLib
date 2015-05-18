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

namespace MediaFoundation.EVR.Interfaces
{
#if NOT_IN_USE

    /// <summary>
    /// Controls how the <c>Enhanced Video Renderer</c> (EVR) mixes video substreams. Applications can use
    /// this interface to control video mixing during playback. 
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
    /// <a href="http://msdn.microsoft.com/en-US/library/8B5F54E3-C6DA-4201-857A-9C718AD911DB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8B5F54E3-C6DA-4201-857A-9C718AD911DB(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("A5C6C53F-C202-4AA5-9695-175BA8C508A5")]
    internal interface IMFVideoMixerControl
    {
        /// <summary>
        /// Sets the z-order of a video stream.
        /// </summary>
        /// <param name="dwStreamID">
        /// Identifier of the stream. For the EVR media sink, the stream identifier is defined when the 
        /// <see cref="IMFMediaSink.AddStreamSink"/> method is called. For the DirectShow EVR filter, the
        /// stream identifier corresponds to the pin index. The reference stream is always stream 0. 
        /// </param>
        /// <param name="dwZ">
        /// Z-order value. The z-order of the reference stream must be zero. The maximum z-order value is the
        /// number of streams minus one.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>The value of <em>dwZ</em> is larger than the maximum z-order value. </description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>Invalid z-order for this stream. For the reference stream, <em>dwZ</em> must be zero. For all other streams, <em>dwZ</em> must be greater than zero. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description>Invalid stream identifier.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetStreamZOrder(
        ///   [in]  DWORD dwStreamID,
        ///   [in]  DWORD dwZ
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6187724A-6345-4FEB-90A0-097B6D21180F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6187724A-6345-4FEB-90A0-097B6D21180F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetStreamZOrder(
            [In] int dwStreamID,
            [In] int dwZ
            );

        /// <summary>
        /// Retrieves the z-order of a video stream.
        /// </summary>
        /// <param name="dwStreamID">
        /// Identifier of the stream. For the EVR media sink, the stream identifier is defined when the 
        /// <see cref="IMFMediaSink.AddStreamSink"/> method is called. For the DirectShow EVR filter, the
        /// stream identifier corresponds to the pin index. The reference stream is always stream 0. 
        /// </param>
        /// <param name="pdwZ">
        /// Receives the z-order value.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description>Invalid stream identifier.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStreamZOrder(
        ///   [in]   DWORD dwStreamID,
        ///   [out]  DWORD *pdwZ
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9E0BA97C-C960-4E26-A89C-EA1A4E91E907(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9E0BA97C-C960-4E26-A89C-EA1A4E91E907(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStreamZOrder(
            [In] int dwStreamID,
            out int pdwZ
            );

        /// <summary>
        /// Sets the position of a video stream within the composition rectangle. 
        /// </summary>
        /// <param name="dwStreamID">
        /// Identifier of the stream. For the EVR media sink, the stream identifier is defined when the 
        /// <see cref="IMFMediaSink.AddStreamSink"/> method is called. For the DirectShow EVR filter, the
        /// stream identifier corresponds to the pin index. The reference stream is always stream 0. 
        /// </param>
        /// <param name="pnrcOutput">
        /// Pointer to an <see cref="EVR.MFVideoNormalizedRect"/> structure that defines the bounding rectangle
        /// for the video stream. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description> The coordinates of the bounding rectangle given in <em>pnrcOutput</em> are not valid. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description> Invalid stream identifier. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetStreamOutputRect(
        ///   [in]  DWORD dwStreamID,
        ///   [in]  const MFVideoNormalizedRect *pnrcOutput
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7075B8CF-2106-4B13-ABC7-8AEDAE18BB62(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7075B8CF-2106-4B13-ABC7-8AEDAE18BB62(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetStreamOutputRect(
            [In] int dwStreamID,
            [In] MFVideoNormalizedRect pnrcOutput
            );

        /// <summary>
        /// Retrieves the position of a video stream within the composition rectangle.
        /// </summary>
        /// <param name="dwStreamID">
        /// The identifier of the stream. For the EVR media sink, the stream identifier is defined when the 
        /// <see cref="IMFMediaSink.AddStreamSink"/> method is called. For the DirectShow EVR filter, the
        /// stream identifier corresponds to the pin index. The reference stream is always stream 0. 
        /// </param>
        /// <param name="pnrcOutput">
        /// Pointer to an <see cref="EVR.MFVideoNormalizedRect"/> structure that receives the bounding
        /// rectangle, in normalized coordinates. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description>Invalid stream identifier.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStreamOutputRect(
        ///   [in]   DWORD dwStreamID,
        ///   [out]  MFVideoNormalizedRect *pnrcOutput
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6DE631CD-F85E-4F53-B14C-8CA3CD65B719(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6DE631CD-F85E-4F53-B14C-8CA3CD65B719(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStreamOutputRect(
            [In] int dwStreamID,
            [Out, MarshalAs(UnmanagedType.LPStruct)] MFVideoNormalizedRect pnrcOutput
            );
    }

#endif
}
