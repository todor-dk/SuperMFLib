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
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Controls preferences for video deinterlacing.
    /// <para/>
    /// The default video mixer for the <c>Enhanced Video Renderer</c> (EVR) implements this interface. 
    /// <para/>
    /// To get a pointer to the interface, call <see cref="IMFGetService.GetService"/> on any of the
    /// following objects, using the <strong>MR_VIDEO_MIXER_SERVICE</strong> service identifier: 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A238B050-101D-4B8A-9479-984B889823F4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A238B050-101D-4B8A-9479-984B889823F4(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("8459616D-966E-4930-B658-54FA7E5A16D3")]
    internal interface IMFVideoMixerControl2 : IMFVideoMixerControl
    {
        #region IMFVideoMixerControl methods

        /// <summary>
        /// Sets the z-order of a video stream.
        /// </summary>
        /// <param name="dwStreamID">Identifier of the stream. For the EVR media sink, the stream identifier is defined when the
        /// <see cref="IMFMediaSink.AddStreamSink" /> method is called. For the DirectShow EVR filter, the
        /// stream identifier corresponds to the pin index. The reference stream is always stream 0.</param>
        /// <param name="dwZ">Z-order value. The z-order of the reference stream must be zero. The maximum z-order value is the
        /// number of streams minus one.</param>
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
        /// [in]  DWORD dwStreamID,
        /// [in]  DWORD dwZ
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/6187724A-6345-4FEB-90A0-097B6D21180F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6187724A-6345-4FEB-90A0-097B6D21180F(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetStreamZOrder(
            [In] int dwStreamID,
            [In] int dwZ
            );

        /// <summary>
        /// Retrieves the z-order of a video stream.
        /// </summary>
        /// <param name="dwStreamID">Identifier of the stream. For the EVR media sink, the stream identifier is defined when the
        /// <see cref="IMFMediaSink.AddStreamSink" /> method is called. For the DirectShow EVR filter, the
        /// stream identifier corresponds to the pin index. The reference stream is always stream 0.</param>
        /// <param name="pdwZ">Receives the z-order value.</param>
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
        /// [in]   DWORD dwStreamID,
        /// [out]  DWORD *pdwZ
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/9E0BA97C-C960-4E26-A89C-EA1A4E91E907(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9E0BA97C-C960-4E26-A89C-EA1A4E91E907(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetStreamZOrder(
            [In] int dwStreamID,
            out int pdwZ
            );

        /// <summary>
        /// Sets the position of a video stream within the composition rectangle. 
        /// </summary>
        /// <param name="dwStreamID">Identifier of the stream. For the EVR media sink, the stream identifier is defined when the
        /// <see cref="IMFMediaSink.AddStreamSink" /> method is called. For the DirectShow EVR filter, the
        /// stream identifier corresponds to the pin index. The reference stream is always stream 0.</param>
        /// <param name="pnrcOutput">Pointer to an <see cref="EVR.MFVideoNormalizedRect" /> structure that defines the bounding rectangle
        /// for the video stream.</param>
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
        /// [in]  DWORD dwStreamID,
        /// [in]  const MFVideoNormalizedRect *pnrcOutput
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/7075B8CF-2106-4B13-ABC7-8AEDAE18BB62(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7075B8CF-2106-4B13-ABC7-8AEDAE18BB62(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetStreamOutputRect(
            [In] int dwStreamID,
            [In] MFVideoNormalizedRect pnrcOutput
            );

        /// <summary>
        /// Retrieves the position of a video stream within the composition rectangle.
        /// </summary>
        /// <param name="dwStreamID">The identifier of the stream. For the EVR media sink, the stream identifier is defined when the
        /// <see cref="IMFMediaSink.AddStreamSink" /> method is called. For the DirectShow EVR filter, the
        /// stream identifier corresponds to the pin index. The reference stream is always stream 0.</param>
        /// <param name="pnrcOutput">Pointer to an <see cref="EVR.MFVideoNormalizedRect" /> structure that receives the bounding
        /// rectangle, in normalized coordinates.</param>
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
        /// [in]   DWORD dwStreamID,
        /// [out]  MFVideoNormalizedRect *pnrcOutput
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/6DE631CD-F85E-4F53-B14C-8CA3CD65B719(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6DE631CD-F85E-4F53-B14C-8CA3CD65B719(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetStreamOutputRect(
            [In] int dwStreamID,
            [Out, MarshalAs(UnmanagedType.LPStruct)] MFVideoNormalizedRect pnrcOutput
            );

        #endregion

        /// <summary>
        /// Sets the preferences for video deinterlacing.
        /// </summary>
        /// <param name="dwMixFlags">
        /// Bitwise <strong>OR</strong> of zero or more flags from the <see cref="EVR.MFVideoMixPrefs"/>
        /// enumeration. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetMixingPrefs(
        ///   [in]  DWORD dwMixFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AE8FA85A-BDAE-4FBF-B9D4-A987EB1C4C41(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AE8FA85A-BDAE-4FBF-B9D4-A987EB1C4C41(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetMixingPrefs(
            [In] MFVideoMixPrefs dwMixFlags
        );

        /// <summary>
        /// Gets the current preferences for video deinterlacing.
        /// </summary>
        /// <param name="pdwMixFlags">
        /// Receives a bitwise <strong>OR</strong> of zero or more flags from the 
        /// <see cref="EVR.MFVideoMixPrefs"/> enumeration. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetMixingPrefs(
        ///   [out]  DWORD *pdwMixFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4EC03DB2-9E7F-4A11-8D69-7654391A33D8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4EC03DB2-9E7F-4A11-8D69-7654391A33D8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMixingPrefs(
            out MFVideoMixPrefs pdwMixFlags
        );
    }

#endif

}
