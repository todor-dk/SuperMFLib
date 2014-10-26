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
using System.Runtime.InteropServices.ComTypes;
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

using MediaFoundation.EVR;

namespace MediaFoundation.MFPlayer
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
    /// Applications should use the <c>Media Session</c> for playback. 
    /// <para/>
    /// Contains methods to play media files.
    /// <para/>
    /// The MFPlay player object exposes this interface. To get a pointer to this interface, call 
    /// <see cref="MFExtern.MFPCreateMediaPlayer"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FA57D465-1EE9-4F7A-9BE8-66A6D73F65E8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FA57D465-1EE9-4F7A-9BE8-66A6D73F65E8(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Obsolete("Applications should use the Media Session for playback.")]
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("A714590A-58AF-430a-85BF-44F5EC838D85")]
    public interface IMFPMediaPlayer
    {
        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Starts playback.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_SHUTDOWN</strong></strong></term><description>The object's <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT Play();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/24D6E8A0-D910-46F9-8172-DFCB68C4F364(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/24D6E8A0-D910-46F9-8172-DFCB68C4F364(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Play();

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Pauses playback. While playback is paused, the most recent video frame is displayed, and audio is
        /// silent.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_SHUTDOWN</strong></strong></term><description>The object's <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT Pause();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F6BF6896-6ED6-4135-A01D-F875BFDC72F4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F6BF6896-6ED6-4135-A01D-F875BFDC72F4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Pause();

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Stops playback.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The object's <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT Stop();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1CFA41C7-209E-4C18-A204-563EDE29C7C6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1CFA41C7-209E-4C18-A204-563EDE29C7C6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Stop();

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Steps forward one video frame.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>Cannot frame step. Reasons for this error code include:<para>* There is no media item queued for playback.</para><para>* The current media item does not contain video.</para></description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The object's <c>Shutdown</c> method was called. </description></item>
        /// <item><term><strong>MF_E_UNSUPPORTED_RATE</strong></term><description>The media source does not support frame stepping, or the current playback rate is negative.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT FrameStep();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B7965965-2FBC-4494-9368-7D9699E4092A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B7965965-2FBC-4494-9368-7D9699E4092A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int FrameStep();

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Sets the playback position.
        /// </summary>
        /// <param name="guidPositionType">
        /// Unit of time for the playback position. The following value is defined.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>MFP_POSITIONTYPE_100NS</strong></term><description>100-nanosecond units. The value of <em>pvPositionValue</em> must be a <strong>LARGE_INTEGER</strong>. <para>* Variant type ( <strong>vt</strong>): <strong>VT_I8</strong></para><para>* Variant member: <strong>hVal</strong></para></description></item>
        /// </list>
        /// </param>
        /// <param name="pvPositionValue">
        /// New playback position. The meaning and data type of this parameter are indicated by the <em>
        /// guidPositionType</em> parameter. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>E_INVALIDARG</strong></strong></term><description>Invalid argument.</description></item>
        /// <item><term><strong><strong>HRESULT_FROM_WIN32( ERROR_SEEK )</strong></strong></term><description>The value of <em>pvPositionValue</em> is not valid. </description></item>
        /// <item><term><strong><strong>MF_E_INVALIDREQUEST</strong></strong></term><description>No media item has been queued.</description></item>
        /// <item><term><strong><strong>MF_E_SHUTDOWN</strong></strong></term><description>The object's <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetPosition(
        ///   [in]  REFGUID guidPositionType,
        ///   [in]  const PROPVARIANT *pvPositionValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D8665C3B-E0DA-4A6F-A61B-38D507D1E78A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D8665C3B-E0DA-4A6F-A61B-38D507D1E78A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetPosition(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidPositionType,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant pvPositionValue
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets the current playback position.
        /// </summary>
        /// <param name="guidPositionType">
        /// Specifies the unit of time for the playback position. The following value is defined.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong><strong>MFP_POSITIONTYPE_100NS</strong></strong></term><description>100-nanosecond units. The value returned in <em>pvPositionValue</em> is a <strong>LARGE_INTEGER</strong>. <para>* Variant type ( <strong>vt</strong>): <strong>VT_I8</strong></para><para>* Variant member: <strong>hVal</strong></para></description></item>
        /// </list>
        /// </param>
        /// <param name="pvPositionValue">
        /// Pointer to a <strong>PROPVARIANT</strong> that receives the playback position. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>E_INVALIDARG</strong></strong></term><description>Invalid argument.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDREQUEST</strong></strong></term><description>No media item has been queued.</description></item>
        /// <item><term><strong><strong>MF_E_SHUTDOWN</strong></strong></term><description>The object's <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetPosition(
        ///   [in]   REFGUID guidPositionType,
        ///   [out]  PROPVARIANT *pvPositionValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E3401C66-0DC7-46EF-9A38-088D605A3038(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E3401C66-0DC7-46EF-9A38-088D605A3038(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetPosition(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidPositionType,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pvPositionValue
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets the playback duration of the current media item.
        /// </summary>
        /// <param name="guidPositionType">
        /// Specifies the unit of time for the duration. The following value is defined.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong><strong>MFP_POSITIONTYPE_100NS</strong></strong></term><description>100-nanosecond units. The value returned in <em>pvDurationValue</em> is a <strong>ULARGE_INTEGER</strong>. <para>* Variant type ( <strong>vt</strong>): <strong>VT_UI8</strong></para><para>* Variant member: <strong>uhVal</strong></para></description></item>
        /// </list>
        /// </param>
        /// <param name="pvPositionValue">The pv position value.</param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>The media source does not have a duration. This error can occur with a live source, such as a video camera.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>There is no current media item.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetDuration(
        ///   [in]   REFGUID guidPositionType,
        ///   [out]  PROPVARIANT *pvDurationValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7D201035-6946-4A46-BC66-B9E78006A04A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7D201035-6946-4A46-BC66-B9E78006A04A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetDuration(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidPositionType,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pvPositionValue
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Sets the playback rate.
        /// </summary>
        /// <param name="flRate">
        /// Playback rate. The playback rate is expressed as a ratio of the current rate to the normal rate.
        /// For example, <strong>1.0</strong> indicates normal playback speed, <strong>0.5</strong> indicates
        /// half speed, and <strong>2.0</strong> indicates twice speed. Positive values indicate forward
        /// playback, and negative values indicate reverse playback. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_OUT_OF_RANGE</strong></strong></term><description>The <em>flRate</em> parameter is zero. </description></item>
        /// <item><term><strong><strong>MF_E_SHUTDOWN</strong></strong></term><description>The object's <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetRate(
        ///   [in]  float flRate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7E9D4A0D-B61F-47D9-AF47-D8A07CD728F6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7E9D4A0D-B61F-47D9-AF47-D8A07CD728F6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetRate(
            float flRate
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets the current playback rate.
        /// </summary>
        /// <param name="pflRate">
        /// Receives the playback rate. The playback rate is expressed as a ratio of the current rate to the
        /// normal rate. For example, 1.0 indicates normal playback, 0.5 indicates half speed, and 2.0
        /// indicates twice speed. Positive values indicate forward playback, and negative values indicate
        /// reverse playback.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetRate(
        ///   [out]  float *pflRate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/51257361-0362-43C4-8ACA-81FD49BE8482(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/51257361-0362-43C4-8ACA-81FD49BE8482(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetRate(
            out float pflRate
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets the range of supported playback rates.
        /// </summary>
        /// <param name="fForwardDirection">
        /// Specify <strong>TRUE</strong> to get the playback rates for forward playback. Specify <strong>FALSE
        /// </strong> to get the rates for reverse playback. 
        /// </param>
        /// <param name="pflSlowestRate">
        /// Receives the slowest supported rate.
        /// </param>
        /// <param name="pflFastestRate">
        /// Receives the fastest supported rate.
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_UNSUPPORTED_RATE</strong></strong></term><description>The current media item does not support playback in the requested direction (either forward or reverse).</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetSupportedRates(
        ///   [in]   BOOL fForwardDirection,
        ///   [out]  float *pflSlowestRate,
        ///   [out]  float *pflFastestRate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E0E738E4-B8E4-41DA-8B74-74CE06F17274(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E0E738E4-B8E4-41DA-8B74-74CE06F17274(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetSupportedRates(
            [MarshalAs(UnmanagedType.Bool)] bool fForwardDirection,
            out float pflSlowestRate,
            out float pflFastestRate
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets the current playback state of the MFPlay player object.
        /// </summary>
        /// <param name="peState">
        /// Receives the playback state, as a member of the <see cref="MFPlayer.MFP_MEDIAPLAYER_STATE"/>
        /// enumeration. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetState(
        ///   [out]  MFP_MEDIAPLAYER_STATE *peState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/072C5E93-B3CE-469C-8235-3E9C63BD77E3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/072C5E93-B3CE-469C-8235-3E9C63BD77E3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetState(
            out MFP_MEDIAPLAYER_STATE peState
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Creates a media item from a URL.
        /// </summary>
        /// <param name="pwszURL">
        /// Null-terminated string that contains the URL of a media file.
        /// </param>
        /// <param name="fSync">
        /// If <strong>TRUE</strong>, the method blocks until it completes. If <strong>FALSE</strong>, the
        /// method does not block and completes asynchronously. 
        /// </param>
        /// <param name="dwUserData">
        /// Application-defined value to store in the media item. To retrieve this value from the media item,
        /// call <see cref="MFPlayer.IMFPMediaItem.GetUserData"/>. 
        /// </param>
        /// <param name="ppMediaItem">
        /// Receives a pointer to the <see cref="MFPlayer.IMFPMediaItem"/> interface. The caller must release
        /// the interface. If <em>fSync</em> is <strong>TRUE</strong>, this parameter must be a valid pointer.
        /// If <em>bSync</em> is <strong>FALSE</strong>, this parameter must be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>E_INVALIDARG</strong></strong></term><description>Invalid argument.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDREQUEST</strong></strong></term><description>Invalid request. This error can occur when <em>fSync</em> is <strong>FALSE</strong> and the application did not provide a callback interface. See Remarks. </description></item>
        /// <item><term><strong><strong>MF_E_SHUTDOWN</strong></strong></term><description>The object's <c>Shutdown</c> method was called. </description></item>
        /// <item><term><strong><strong>MF_E_UNSUPPORTED_SCHEME</strong></strong></term><description>Unsupported protocol. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT CreateMediaItemFromURL(
        ///   [in]   LPCWSTR pwszURL,
        ///   [in]   BOOL fSync,
        ///   [in]   DWORD_PTR dwUserData,
        ///   [out]  IMFPMediaItem **ppMediaItem
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7DC2A7F3-81B4-46C6-B45E-44C6A20AFC6B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7DC2A7F3-81B4-46C6-B45E-44C6A20AFC6B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateMediaItemFromURL(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszURL,
            [MarshalAs(UnmanagedType.Bool)] bool fSync,
            IntPtr dwUserData,
            out IMFPMediaItem ppMediaItem
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Creates a media item from an object.
        /// </summary>
        /// <param name="pIUnknownObj">
        /// A pointer to the object's <strong>IUnknown</strong> interface. See Remarks. 
        /// </param>
        /// <param name="fSync">
        /// If <strong>TRUE</strong>, the method blocks until it completes. If <strong>FALSE</strong>, the
        /// method does not block and completes asynchronously. 
        /// </param>
        /// <param name="dwUserData">
        /// Application-defined value to store in the media item. To retrieve this value from the media item,
        /// call <see cref="MFPlayer.IMFPMediaItem.GetUserData"/>. 
        /// </param>
        /// <param name="ppMediaItem">
        /// Receives a pointer to the <see cref="MFPlayer.IMFPMediaItem"/> interface. The caller must release
        /// the interface. If <em>fSync</em> is <strong>TRUE</strong>, this parameter must be a valid pointer.
        /// If <em>bSync</em> is <strong>FALSE</strong>, this parameter must be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>E_INVALIDARG</strong></strong></term><description>Invalid argument.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDREQUEST</strong></strong></term><description>Invalid request. This error can occur when <em>fSync</em> is <strong>FALSE</strong> and the application did not provide a callback interface. See Remarks. </description></item>
        /// <item><term><strong><strong>MF_E_SHUTDOWN</strong></strong></term><description>The object's <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT CreateMediaItemFromObject(
        ///   [in]   IUnknown *pIUnknownObj,
        ///   [in]   BOOL fSync,
        ///   [in]   DWORD_PTR dwUserData,
        ///   [out]  IMFPMediaItem **ppMediaItem
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D647DF89-B874-448E-AE41-EE3BCB55521F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D647DF89-B874-448E-AE41-EE3BCB55521F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateMediaItemFromObject(
            [MarshalAs(UnmanagedType.IUnknown)] object pIUnknownObj,
            [MarshalAs(UnmanagedType.Bool)] bool fSync,
            IntPtr dwUserData,
            out IMFPMediaItem ppMediaItem
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Queues a media item for playback.
        /// </summary>
        /// <param name="pIMFPMediaItem">
        /// Pointer to the <see cref="MFPlayer.IMFPMediaItem"/> interface of the media item. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>E_INVALIDARG</strong></strong></term><description>Invalid argument.</description></item>
        /// <item><term><strong><strong>MF_E_DRM_UNSUPPORTED</strong></strong></term><description>The media item contains protected content. MFPlay currently does not support protected content.</description></item>
        /// <item><term><strong><strong>MF_E_NO_AUDIO_PLAYBACK_DEVICE</strong></strong></term><description>No audio playback device was found. This error can occur if the media source contains audio, but no audio playback devices are available on the system.</description></item>
        /// <item><term><strong><strong>MF_E_SHUTDOWN</strong></strong></term><description>The object's <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetMediaItem(
        ///   [in]  IMFPMediaItem *pIMFPMediaItem
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C792A024-C4F8-4E0B-9720-259D1DC28EE8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C792A024-C4F8-4E0B-9720-259D1DC28EE8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetMediaItem(
            IMFPMediaItem pIMFPMediaItem
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Clears the current media item.
        /// <para/>
        /// <strong>Note</strong> This method is currently not implemented. 
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT ClearMediaItem();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2C2B23AB-B282-445F-A5A0-4291EE6F22BA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2C2B23AB-B282-445F-A5A0-4291EE6F22BA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ClearMediaItem();

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets a pointer to the current media item.
        /// </summary>
        /// <param name="ppIMFPMediaItem">
        /// Receives a pointer to the media item's <see cref="MFPlayer.IMFPMediaItem"/> interface. The caller
        /// must release the interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>E_FAIL</strong></strong></term><description>There is no current media item.</description></item>
        /// <item><term><strong><strong>MF_E_NOT_FOUND</strong></strong></term><description>There is no current media item.</description></item>
        /// <item><term><strong><strong>MF_E_SHUTDOWN</strong></strong></term><description>The object's <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetMediaItem(
        ///   [out]  IMFPMediaItem **ppIMFPMediaItem
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9593092D-BD50-4FF6-A283-F5A0AB1E6FC0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9593092D-BD50-4FF6-A283-F5A0AB1E6FC0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMediaItem(
            out IMFPMediaItem ppIMFPMediaItem
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets the current audio volume.
        /// </summary>
        /// <param name="pflVolume">
        /// Receives the audio volume. Volume is expressed as an attenuation level, where 0.0 indicates silence
        /// and 1.0 indicates full volume (no attenuation).
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetVolume(
        ///   [out]  float *pflVolume
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/08BF0BB3-4EE2-4229-9F41-64924C6122C9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/08BF0BB3-4EE2-4229-9F41-64924C6122C9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetVolume(
            out float pflVolume
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Sets the audio volume.
        /// </summary>
        /// <param name="flVolume">
        /// The volume level. Volume is expressed as an attenuation level, where 0.0 indicates silence and 1.0
        /// indicates full volume (no attenuation).
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_OUT_OF_RANGE</strong></term><description>The <em>flVolume</em> parameter is invalid. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetVolume(
        ///   [in]  float flVolume
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FEEE2812-7C7E-4C27-86BE-8F7316854222(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FEEE2812-7C7E-4C27-86BE-8F7316854222(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetVolume(
            float flVolume
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets the current audio balance.
        /// </summary>
        /// <param name="pflBalance">
        /// Receives the balance. The value can be any number in the following range (inclusive).
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>-1.0</term><description>The left channel is at full volume; the right channel is silent.</description></item>
        /// <item><term>+1.0</term><description>The right channel is at full volume; the left channel is silent.</description></item>
        /// </list>
        /// <para/>
        /// If the value is zero, the left and right channels are at equal volumes. The default value is zero.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetBalance(
        ///   [out]  float *pflBalance
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/27DEEB41-5347-4A6D-BFD4-4E4444540651(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/27DEEB41-5347-4A6D-BFD4-4E4444540651(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetBalance(
            out float pflBalance
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Sets the audio balance.
        /// </summary>
        /// <param name="flBalance">
        /// The audio balance. The value can be any number in the following range (inclusive).
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>-1.0</strong></term><description>The left channel is at full volume; the right channel is silent.</description></item>
        /// <item><term><strong>+1.0</strong></term><description>The right channel is at full volume; the left channel is silent.</description></item>
        /// </list>
        /// <para/>
        /// If the value is zero, the left and right channels are at equal volumes. The default value is zero.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_OUT_OF_RANGE</strong></strong></term><description>The <em>flBalance</em> parameter is invalid. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetBalance(
        ///   [in]  float flBalance
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CB95D037-54B4-4686-B8E6-5B960998D361(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CB95D037-54B4-4686-B8E6-5B960998D361(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetBalance(
            float flBalance
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Queries whether the audio is muted.
        /// </summary>
        /// <param name="pfMute">
        /// Receives the value <strong>TRUE</strong> if the audio is muted, or <strong>FALSE</strong>
        /// otherwise. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetMute(
        ///   [out]  BOOL *pfMute
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2A628608-37EA-48F3-AED4-0344D47EDE9F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2A628608-37EA-48F3-AED4-0344D47EDE9F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMute(
            [MarshalAs(UnmanagedType.Bool)] out bool pfMute
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Mutes or unmutes the audio.
        /// </summary>
        /// <param name="fMute">
        /// Specify <strong>TRUE</strong> to mute the audio, or <strong>FALSE</strong> to unmute the audio. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetMute(
        ///   BOOL fMute
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/81E2FB76-A125-4665-9AA5-8971410EE554(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/81E2FB76-A125-4665-9AA5-8971410EE554(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetMute(
            [MarshalAs(UnmanagedType.Bool)] bool fMute
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets the size and aspect ratio of the video. These values are computed before any scaling is done
        /// to fit the video into the destination window.
        /// </summary>
        /// <param name="pszVideo">
        /// Receives the size of the video, in pixels. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="pszARVideo">
        /// Receives the picture aspect ratio of the video. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDREQUEST</strong></strong></term><description>The current media item does not contain video.</description></item>
        /// <item><term><strong><strong>MF_E_SHUTDOWN</strong></strong></term><description>The object's <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetNativeVideoSize(
        ///   [out]  SIZE *pszVideo,
        ///   [out]  SIZE *pszARVideo
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6F0F09FB-D41C-4662-A20C-2A1D04B39DF5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6F0F09FB-D41C-4662-A20C-2A1D04B39DF5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetNativeVideoSize(
            out MFSize pszVideo,
            out MFSize pszARVideo
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets the range of video sizes that can be displayed without significantly degrading performance or
        /// image quality.
        /// </summary>
        /// <param name="pszMin">
        /// Receives the minimum size that is preferable. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="pszMax">
        /// Receives the maximum size that is preferable. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDREQUEST</strong></strong></term><description>The current media item does not contain video.</description></item>
        /// <item><term><strong><strong>MF_E_SHUTDOWN</strong></strong></term><description>The object's <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetIdealVideoSize(
        ///   [out]  SIZE *pszMin,
        ///   [out]  SIZE *pszMax
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E6835852-10F0-4453-A22A-A567457BD7C5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E6835852-10F0-4453-A22A-A567457BD7C5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetIdealVideoSize(
            out MFSize pszMin,
            out MFSize pszMax
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Sets the video source rectangle.
        /// <para/>
        /// MFPlay clips the video to this rectangle and stretches the rectangle to fill the video window.
        /// </summary>
        /// <param name="pnrcSource">
        /// Pointer to an <see cref="EVR.MFVideoNormalizedRect"/> structure that specifies the source
        /// rectangle. This rectangle defines which portion of the video is displayed. It is specified in
        /// normalized coordinates, which are defined as follows: 
        /// <para/>
        /// <para>* The upper-left corner of the video image is (0, 0).</para><para>* The lower-right corner of
        /// the video image is (1, 1).</para>
        /// <para/>
        /// To display the entire image, set the source rectangle to {0, 0, 1, 1}. This is the default value.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The current media item does not contain video.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The object's <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetVideoSourceRect(
        ///   [in]  const MFVideoNormalizedRect *pnrcSource
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C95D724F-40A9-43C5-B81A-8505EDA516F7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C95D724F-40A9-43C5-B81A-8505EDA516F7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetVideoSourceRect(
            [In] MFVideoNormalizedRect pnrcSource
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets the video source rectangle.
        /// </summary>
        /// <param name="pnrcSource">
        /// Pointer to an <see cref="EVR.MFVideoNormalizedRect"/> structure that specifies the source
        /// rectangle. This rectangle defines which portion of the video is displayed. It is specified in
        /// normalized coordinates, which are defined as follows: 
        /// <para/>
        /// <para>* The upper-left corner of the video image is (0, 0).</para><para>* The lower-right corner of
        /// the video image is (1, 1).</para>
        /// <para/>
        /// If the source rectangle is {0, 0, 1, 1}, the entire image is displayed. This is the default value.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDREQUEST</strong></strong></term><description>The current media item does not contain video.</description></item>
        /// <item><term><strong><strong>MF_E_SHUTDOWN</strong></strong></term><description>The object's <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetVideoSourceRect(
        ///   [out]  MFVideoNormalizedRect *pnrcSource
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3B72ECE3-F573-42E1-948C-443C793E5BA4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3B72ECE3-F573-42E1-948C-443C793E5BA4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetVideoSourceRect(
            out MFVideoNormalizedRect pnrcSource
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Specifies whether the aspect ratio of the video is preserved during playback.
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
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDREQUEST</strong></strong></term><description>The current media item does not contain video.</description></item>
        /// <item><term><strong><strong>MF_E_SHUTDOWN</strong></strong></term><description>The object's <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// void SetAspectRatioMode(
        ///   [in]  DWORD dwAspectRatioMode
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B100A422-548F-4C38-AFEB-4D4C1D9A9140(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B100A422-548F-4C38-AFEB-4D4C1D9A9140(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetAspectRatioMode(
            MFVideoAspectRatioMode dwAspectRatioMode
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets the current aspect-ratio correction mode. This mode controls whether the aspect ratio of the
        /// video is preserved during playback.
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
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The current media item does not contain video.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The object's <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetAspectRatioMode(
        ///   [out]  DWORD *pdwAspectRatioMode
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EAEB20D2-D547-4F88-A69F-7C3F46FE95FF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EAEB20D2-D547-4F88-A69F-7C3F46FE95FF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetAspectRatioMode(
            out MFVideoAspectRatioMode pdwAspectRatioMode
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets the window where the video is displayed.
        /// </summary>
        /// <param name="phwndVideo">
        /// Receives a handle to the application window where the video is displayed.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetVideoWindow(
        ///   [out]  HWND *phwndVideo
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/313E3A87-3DAD-4CFB-AD37-1018CB03A707(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/313E3A87-3DAD-4CFB-AD37-1018CB03A707(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetVideoWindow(
            out IntPtr phwndVideo
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Updates the video frame.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDREQUEST</strong></strong></term><description>The current media item does not contain video.</description></item>
        /// <item><term><strong><strong>MF_E_SHUTDOWN</strong></strong></term><description>The object's <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT UpdateVideo();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DE583E74-B31B-407E-AF4B-C36649E1CA84(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DE583E74-B31B-407E-AF4B-C36649E1CA84(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int UpdateVideo();

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Sets the color for the video border. The border color is used to letterbox the video.
        /// </summary>
        /// <param name="Clr">
        /// Specifies the border color as a <strong>COLORREF</strong> value. Use the <strong>RGB</strong> macro
        /// to create this value. The default value is black. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDREQUEST</strong></strong></term><description>The current media item does not contain video.</description></item>
        /// <item><term><strong>M <strong>F_E_SHUTDOWN</strong></strong></term><description>The object's <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetBorderColor(
        ///   [in]  COLORREF Clr
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F66B671D-0C7D-4261-8210-05F2D2F8D9A5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F66B671D-0C7D-4261-8210-05F2D2F8D9A5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetBorderColor(
            Color Clr
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets the current color of the video border. The border color is used to letterbox the video.
        /// </summary>
        /// <param name="pClr">
        /// Receives the border color as a <strong>COLORREF</strong> value. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The current media item does not contain video.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The object's <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetBorderColor(
        ///   [out]  COLORREF *pClr
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A07BACBD-3D45-4733-A506-3C54EC10B634(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A07BACBD-3D45-4733-A506-3C54EC10B634(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetBorderColor(
            out Color pClr
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Applies an audio or video effect to playback.
        /// </summary>
        /// <param name="pEffect">
        /// Pointer to the <strong>IUnknown</strong> interface for one of the following: 
        /// <para/>
        /// <para>* A Media Foundation transform (MFT) that implements the effect. MFTs expose the 
        /// <see cref="Transform.IMFTransform"/> interface. </para><para>* An activation object that creates an
        /// MFT. Activation objects expose the <see cref="IMFActivate"/> interface. </para>
        /// </param>
        /// <param name="fOptional">
        /// Specifies whether the effect is optional.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong><strong>TRUE</strong></strong></term><description>The effect is optional. If the MFPlay player object cannot add the effect, it ignores the effect and  continues playback.</description></item>
        /// <item><term><strong><strong>FALSE</strong></strong></term><description>If the MFPlay player object cannot add the effect, a playback error occurs.</description></item>
        /// </list>
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDINDEX</strong></strong></term><description>This effect was already added.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT InsertEffect(
        ///   [in]  IUnknown *pEffect,
        ///   [in]  BOOL fOptional
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2689EE46-5CFE-4616-850C-EB5AEF340DAA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2689EE46-5CFE-4616-850C-EB5AEF340DAA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int InsertEffect(
            [MarshalAs(UnmanagedType.IUnknown)] object pEffect,
            [MarshalAs(UnmanagedType.Bool)] bool fOptional
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Removes an effect that was added with the <see cref="MFPlayer.IMFPMediaPlayer.InsertEffect"/>
        /// method. 
        /// </summary>
        /// <param name="pEffect">
        /// Pointer to the <strong>IUnknown</strong> interface of the effect object. Use the same pointer that
        /// you passed to the <c>InsertEffect</c> method. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_NOT_FOUND</strong></term><description>The effect was not found.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT RemoveEffect(
        ///   [in]  IUnknown *pEffect
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CA8507B9-C6C5-4E17-9C18-3EC1514DE897(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CA8507B9-C6C5-4E17-9C18-3EC1514DE897(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RemoveEffect(
            [MarshalAs(UnmanagedType.IUnknown)] object pEffect
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Removes all effects that were added with the <see cref="MFPlayer.IMFPMediaPlayer.InsertEffect"/>
        /// method. 
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT RemoveAllEffects();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8745714C-315C-4183-86A2-7C189328DFE6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8745714C-315C-4183-86A2-7C189328DFE6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RemoveAllEffects();

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Shuts down the MFPlay player object and releases any resources the object is using.
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT Shutdown();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C56B07B5-F595-4933-9AF6-868FC8938849(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C56B07B5-F595-4933-9AF6-868FC8938849(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Shutdown();
    }

#endif

}
