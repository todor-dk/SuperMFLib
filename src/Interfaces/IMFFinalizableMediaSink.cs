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
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

using MediaFoundation.Misc;
using MediaFoundation;
using System.Drawing;

namespace MediaFoundation
{


    /// <summary>
    /// Optionally supported by media sinks to perform required tasks before shutdown. This interface is
    /// typically exposed by archive sinks—that is, media sinks that write to a file. It is used to perform
    /// tasks such as flushing data to disk or updating a file header.
    /// <para/>
    /// To get a pointer to this interface, call <strong>QueryInterface</strong> on the media sink. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/E60C2773-F2FC-469E-A698-036390CBED16(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E60C2773-F2FC-469E-A698-036390CBED16(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("EAECB74A-9A50-42CE-9541-6A7F57AA4AD7"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFFinalizableMediaSink : IMFMediaSink
    {
        #region IMFMediaSink methods

        /// <summary>
        /// Gets the characteristics of the media sink.
        /// </summary>
        /// <param name="pdwCharacteristics">
        /// Receives a bitwise <strong>OR</strong> of zero or more flags. The following flags are defined: 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong><strong>MEDIASINK_FIXED_STREAMS</strong></strong>0x00000001</term><description> The media sink has a fixed number of streams. It does not support the <see cref="IMFMediaSink.AddStreamSink"/> and <see cref="IMFMediaSink.RemoveStreamSink"/> methods. This flag is a hint to the application. </description></item>
        /// <item><term><strong><strong>MEDIASINK_CANNOT_MATCH_CLOCK</strong></strong>0x00000002</term><description>The media sink cannot match rates with an external clock.For best results, this media sink should be used as the time source for the presentation clock. If any other time source is used, the media sink cannot match rates with the clock, with poor results (for example, glitching).This flag should be used sparingly, because it limits how the pipeline can be configured.For more information about the presentation clock, see <c>Presentation Clock</c>. </description></item>
        /// <item><term><strong><strong>MEDIASINK_RATELESS</strong></strong>0x00000004</term><description>The media sink is rateless. It consumes samples as quickly as possible, and does not synchronize itself to a presentation clock.Most archiving sinks are rateless.</description></item>
        /// <item><term><strong><strong>MEDIASINK_CLOCK_REQUIRED</strong></strong>0x00000008</term><description>The media sink requires a presentation clock. The presentation clock is set by calling the media sink's <see cref="IMFMediaSink.SetPresentationClock"/> method. This flag is obsolete, because all media sinks must support the <c>SetPresentationClock</c> method, even if the media sink ignores the clock (as in a rateless media sink). </description></item>
        /// <item><term><strong><strong>MEDIASINK_CAN_PREROLL</strong></strong>0x00000010</term><description> The media sink can accept preroll samples before the presentation clock starts. The media sink exposes the <see cref="IMFMediaSinkPreroll"/> interface. </description></item>
        /// <item><term><strong><strong>MEDIASINK_REQUIRE_REFERENCE_MEDIATYPE</strong></strong>0x00000020</term><description>The first stream sink (index 0) is a reference stream. The reference stream must have a media type before the media types can be set on the other stream sinks.</description></item>
        /// </list>
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong><strong>MF_E_SHUTDOWN</strong></strong></term><description> The media sink's <c>Shutdown</c> method has been called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetCharacteristics(
        ///   [out]  DWORD *pdwCharacteristics
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A7E8E2AF-8B10-47F5-8B09-A7147ACE5BA1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A7E8E2AF-8B10-47F5-8B09-A7147ACE5BA1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetCharacteristics(
            out MFMediaSinkCharacteristics pdwCharacteristics);

        /// <summary>
        /// Adds a new stream sink to the media sink.
        /// </summary>
        /// <param name="dwStreamSinkIdentifier">
        /// Identifier for the new stream. The value is arbitrary but must be unique.
        /// </param>
        /// <param name="pMediaType">
        /// Pointer to the <see cref="IMFMediaType"/> interface, specifying the media type for the stream. This
        /// parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="ppStreamSink">
        /// Receives a pointer to the new stream sink's <see cref="IMFStreamSink"/> interface. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description>The specified stream identifier is not valid.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The media sink's <c>Shutdown</c> method has been called. </description></item>
        /// <item><term><strong>MF_E_STREAMSINK_EXISTS</strong></term><description>There is already a stream sink with the same stream identifier.</description></item>
        /// <item><term><strong>MF_E_STREAMSINKS_FIXED</strong></term><description>This media sink has a fixed set of stream sinks. New stream sinks cannot be added.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT AddStreamSink(
        ///   [in]   DWORD dwStreamSinkIdentifier,
        ///   [in]   IMFMediaType *pMediaType,
        ///   [out]  IMFStreamSink **ppStreamSink
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1B05EF87-5559-4310-942C-54AB113EB42D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1B05EF87-5559-4310-942C-54AB113EB42D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int AddStreamSink(
            [In] int dwStreamSinkIdentifier,
            [In, MarshalAs(UnmanagedType.Interface)] IMFMediaType pMediaType,
            [MarshalAs(UnmanagedType.Interface)] out IMFStreamSink ppStreamSink
            );

        /// <summary>
        /// Removes a stream sink from the media sink.
        /// </summary>
        /// <param name="dwStreamSinkIdentifier">
        /// Identifier of the stream to remove. The stream identifier is defined when you call 
        /// <see cref="IMFMediaSink.AddStreamSink"/> to add the stream sink. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>This particular stream sink cannot be removed.</description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description>The stream number is not valid.</description></item>
        /// <item><term><strong>MF_E_NOT_INITIALIZED</strong></term><description>The media sink has not been initialized.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The media sink's <c>Shutdown</c> method has been called. </description></item>
        /// <item><term><strong>MF_E_STREAMSINKS_FIXED</strong></term><description>This media sink has a fixed set of stream sinks. Stream sinks cannot be removed.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT RemoveStreamSink(
        ///   [in]  DWORD dwStreamSinkIdentifier
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F99EE960-7FEA-4867-BC24-D7E1D6FCAFA5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F99EE960-7FEA-4867-BC24-D7E1D6FCAFA5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int RemoveStreamSink(
            [In] int dwStreamSinkIdentifier
            );

        /// <summary>
        /// Gets the number of stream sinks on this media sink.
        /// </summary>
        /// <param name="pcStreamSinkCount">
        /// Receives the number of stream sinks.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The media sink's <c>Shutdown</c> method has been called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStreamSinkCount(
        ///   [out]  DWORD *pcStreamSinkCount
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BF4B5713-586C-4B12-80A1-4452EEC63E32(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BF4B5713-586C-4B12-80A1-4452EEC63E32(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetStreamSinkCount(
            out int pcStreamSinkCount
            );

        /// <summary>
        /// Gets a stream sink, specified by index.
        /// </summary>
        /// <param name="dwIndex">
        /// Zero-based index of the stream. To get the number of streams, call 
        /// <see cref="IMFMediaSink.GetStreamSinkCount"/>. 
        /// </param>
        /// <param name="ppStreamSink">
        /// Receives a pointer to the stream's <see cref="IMFStreamSink"/> interface. The caller must release
        /// the interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDINDEX</strong></term><description>Invalid index.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The media sink's <c>Shutdown</c> method has been called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStreamSinkByIndex(
        ///   [in]   DWORD dwIndex,
        ///   [out]  IMFStreamSink **ppStreamSink
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/01604801-1566-410C-B23A-0568C7298868(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/01604801-1566-410C-B23A-0568C7298868(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetStreamSinkByIndex(
            [In] int dwIndex,
            [MarshalAs(UnmanagedType.Interface)] out IMFStreamSink ppStreamSink
            );

        /// <summary>
        /// Gets a stream sink, specified by stream identifier.
        /// </summary>
        /// <param name="dwStreamSinkIdentifier">
        /// Stream identifier of the stream sink.
        /// </param>
        /// <param name="ppStreamSink">
        /// Receives a pointer to the stream's <see cref="IMFStreamSink"/> interface. The caller must release
        /// the interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description>The stream identifier is not valid.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The media sink's <c>Shutdown</c> method has been called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStreamSinkById(
        ///   [in]   DWORD dwStreamSinkIdentifier,
        ///   [out]  IMFStreamSink **ppStreamSink
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/267A8EFC-6743-48CA-A1C4-DA82F3770419(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/267A8EFC-6743-48CA-A1C4-DA82F3770419(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetStreamSinkById(
            [In] int dwStreamSinkIdentifier,
            [MarshalAs(UnmanagedType.Interface)] out IMFStreamSink ppStreamSink
            );

        /// <summary>
        /// Sets the presentation clock on the media sink.
        /// </summary>
        /// <param name="pPresentationClock">
        /// Pointer to the <see cref="IMFPresentationClock"/> interface of the presentation clock, or <strong>
        /// NULL</strong>. If the value is <strong>NULL</strong>, the media sink stops listening to the
        /// presentaton clock that was previously set, if any. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_CLOCK_NO_TIME_SOURCE</strong></term><description>The presentation clock does not have a time source. Call <c>SetTimeSource</c> on the presentation clock. </description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The media sink's <c>Shutdown</c> method has been called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetPresentationClock(
        ///   [in]  IMFPresentationClock *pPresentationClock
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/844FC3B3-B56E-4048-B589-E24457BCC419(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/844FC3B3-B56E-4048-B589-E24457BCC419(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int SetPresentationClock(
            [In, MarshalAs(UnmanagedType.Interface)] IMFPresentationClock pPresentationClock
            );

        /// <summary>
        /// Gets the presentation clock that was set on the media sink.
        /// </summary>
        /// <param name="ppPresentationClock">
        /// Receives a pointer to the presentation clock's <see cref="IMFPresentationClock"/> interface. The
        /// caller must release the interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_NO_CLOCK</strong></term><description>No clock has been set. To set the presentation clock, call <see cref="IMFMediaSink.SetPresentationClock"/>. </description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The media sink's <c>Shutdown</c> method has been called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetPresentationClock(
        ///   [out]  IMFPresentationClock **ppPresentationClock
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FFA6A7B5-CD79-4C45-A5E3-9D133FFC89A6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FFA6A7B5-CD79-4C45-A5E3-9D133FFC89A6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetPresentationClock(
            [MarshalAs(UnmanagedType.Interface)] out IMFPresentationClock ppPresentationClock
            );

        /// <summary>
        /// Shuts down the media sink and releases the resources it is using.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The media sink was shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Shutdown();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/ACDA4E37-2DD0-4322-90FC-8F48D6842054(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/ACDA4E37-2DD0-4322-90FC-8F48D6842054(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int Shutdown();

        #endregion

        /// <summary>
        /// Notifies the media sink to asynchronously take any steps it needs to finish its tasks.
        /// </summary>
        /// <param name="pCallback">
        /// Pointer to the <see cref="IMFAsyncCallback"/> interface of an asynchronous object. The caller must
        /// implement this interface. 
        /// </param>
        /// <param name="pUnkState">The p unk state.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT BeginFinalize(
        ///   [in]  IMFAsyncCallback *pCallback,
        ///   [in]  IUnknown *punkState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FBCB7722-BA64-40A6-9C43-26A6B8DCE7F6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FBCB7722-BA64-40A6-9C43-26A6B8DCE7F6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int BeginFinalize(
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnkState
            );

        /// <summary>
        /// Completes an asynchronous finalize operation.
        /// </summary>
        /// <param name="pResult">
        /// Pointer to the <see cref="IMFAsyncResult"/> interface. Pass in the same pointer that your callback
        /// object received in the <see cref="IMFAsyncCallback.Invoke"/> method. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT EndFinalize(
        ///   [in]  IMFAsyncResult *pResult
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1B2A9B24-69DA-41C7-8379-3F3D066D2582(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1B2A9B24-69DA-41C7-8379-3F3D066D2582(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EndFinalize(
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncResult pResult
            );
    }

}
