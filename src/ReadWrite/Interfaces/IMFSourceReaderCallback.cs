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
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation.ReadWrite
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Callback interface for the Microsoft Media Foundation source reader.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FFF8B6E6-5D56-4301-B3CE-F3FF49398593(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FFF8B6E6-5D56-4301-B3CE-F3FF49398593(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("deec8d99-fa1d-4d82-84c2-2c8969944867")]
    public interface IMFSourceReaderCallback
    {
        /// <summary>
        /// Called when the <see cref="ReadWrite.IMFSourceReader.ReadSample"/> method completes. 
        /// </summary>
        /// <param name="hrStatus">
        /// The status code. If an error occurred while processing the next sample, this parameter contains the
        /// error code. 
        /// </param>
        /// <param name="dwStreamIndex">
        /// The zero-based index of the stream that delivered the sample.
        /// </param>
        /// <param name="dwStreamFlags">
        /// A bitwise <strong>OR</strong> of zero or more flags from the 
        /// <see cref="ReadWrite.MF_SOURCE_READER_FLAG"/> enumeration. 
        /// </param>
        /// <param name="llTimestamp">
        /// The time stamp of the sample, or the time of the stream event indicated in <em>dwStreamFlags</em>.
        /// The time is given in 100-nanosecond units. 
        /// </param>
        /// <param name="pSample">
        /// A pointer to the <see cref="IMFSample"/> interface of a media sample. This parameter might be 
        /// <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// Returns an <strong>HRESULT</strong> value. Currently, the source reader ignores the return value. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnReadSample(
        ///   [in]  HRESULT hrStatus,
        ///   [in]  DWORD dwStreamIndex,
        ///   [in]  DWORD dwStreamFlags,
        ///   [in]  LONGLONG llTimestamp,
        ///   [in]  IMFSample *pSample
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1F334B49-D297-478D-A037-2FC53A75ED52(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1F334B49-D297-478D-A037-2FC53A75ED52(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int OnReadSample(
            int hrStatus,
            int dwStreamIndex,
            MF_SOURCE_READER_FLAG dwStreamFlags,
            long llTimestamp,
            IMFSample pSample
        );

        /// <summary>
        /// Called when the <see cref="ReadWrite.IMFSourceReader.Flush"/> method completes. 
        /// </summary>
        /// <param name="dwStreamIndex">
        /// The index of the stream that was flushed, or <strong>MF_SOURCE_READER_ALL_STREAMS</strong> if all
        /// streams were flushed. 
        /// </param>
        /// <returns>
        /// Returns an <strong>HRESULT</strong> value. Currently, the source reader ignores the return value. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnFlush(
        ///   DWORD dwStreamIndex
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A8273B0A-A75A-453F-BB42-38D554E44262(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A8273B0A-A75A-453F-BB42-38D554E44262(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int OnFlush(
            int dwStreamIndex
        );

        /// <summary>
        /// Called when the source reader receives certain events from the media source.
        /// </summary>
        /// <param name="dwStreamIndex">
        /// For stream events, the value is the zero-based index of the stream that sent the event. For source
        /// events, the value is <strong>MF_SOURCE_READER_MEDIASOURCE</strong>. 
        /// </param>
        /// <param name="pEvent">
        /// A pointer to the <see cref="IMFMediaEvent"/> interface of the event. 
        /// </param>
        /// <returns>
        /// Returns an <strong>HRESULT</strong> value. Currently, the source reader ignores the return value. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnEvent(
        ///   [in]  DWORD dwStreamIndex,
        ///   [in]  IMFMediaEvent *pEvent
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CBE85D0F-26A1-4526-BFE6-B6183812A271(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CBE85D0F-26A1-4526-BFE6-B6183812A271(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int OnEvent(
            int dwStreamIndex,
            IMFMediaEvent pEvent
        );
    }

#endif

}
