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

using MediaFoundation.Misc;
using System.Drawing;
using MediaFoundation.Core.Enums;

namespace MediaFoundation.Core.Interfaces
{
    /// <summary>
    /// Represents a byte stream from some data source, which might be a local file, a network file, or
    /// some other source. The <strong>IMFByteStream</strong> interface supports the typical stream
    /// operations, such as reading, writing, and seeking.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/690035B7-2855-4714-938F-F8250EC70D24(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/690035B7-2855-4714-938F-F8250EC70D24(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport]
    [System.Security.SuppressUnmanagedCodeSecurity]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("AD4C1B00-4BF7-422F-9175-756693D9130D")]
    public interface IMFByteStream
    {
        /// <summary>
        /// Retrieves the characteristics of the byte stream.
        /// </summary>
        /// <param name="pdwCapabilities">
        /// Receives a bitwise <strong>OR</strong> of zero or more flags. The following flags are defined.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>MFBYTESTREAM_IS_READABLE</strong>0x00000001</term><description> The byte stream can be read. </description></item>
        /// <item><term><strong>MFBYTESTREAM_IS_WRITABLE</strong>0x00000002</term><description> The byte stream can be written to. </description></item>
        /// <item><term><strong>MFBYTESTREAM_IS_SEEKABLE</strong>0x00000004</term><description> The byte stream can be seeked. </description></item>
        /// <item><term><strong>MFBYTESTREAM_IS_REMOTE</strong>0x00000008</term><description> The byte stream is from a remote source, such as a network. </description></item>
        /// <item><term><strong>MFBYTESTREAM_IS_DIRECTORY</strong>0x00000080</term><description> The byte stream represents a file directory. </description></item>
        /// <item><term><strong>MFBYTESTREAM_HAS_SLOW_SEEK</strong>0x00000100</term><description> Seeking within this stream might be slow. For example, the byte stream might download from a network.</description></item>
        /// <item><term><strong>MFBYTESTREAM_IS_PARTIALLY_DOWNLOADED</strong>0x00000200</term><description>The byte stream is currently downloading data to a local cache. Read operations on the byte stream might take longer until the data is completely downloaded.This flag is cleared after all of the data has been downloaded.If the <strong>MFBYTESTREAM_HAS_SLOW_SEEK</strong> flag is also set, it means the byte stream must download the entire file sequentially. Otherwise, the byte stream can respond to seek requests by restarting the download from a new point in the stream. </description></item>
        /// <item><term><strong>MFBYTESTREAM_SHARE_WRITE</strong>0x00000400</term><description>Another thread or process can open this byte stream for writing. If this flag is present, the length of the byte stream could change while it is being read. This flag can affect the behavior of byte-stream handlers. For more information, see <see cref="MFAttributesClsid.MF_BYTESTREAMHANDLER_ACCEPTS_SHARE_WRITE"/>. <strong>Note</strong> Requires Windows 7 or later. </description></item>
        /// <item><term><strong>MFBYTESTREAM_DOES_NOT_USE_NETWORK</strong>0x00000800</term><description>The byte stream is not currently using the network to receive the content. Networking hardware may enter a power saving state when this bit is set.<strong>Note</strong> Requires Windows 8 or later. </description></item>
        /// </list>
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetCapabilities(
        ///   [out]  DWORD *pdwCapabilities
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/715E802B-4707-4C6D-9AE9-A4DDFA90F05E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/715E802B-4707-4C6D-9AE9-A4DDFA90F05E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetCapabilities(
            out MFByteStreamCapabilities pdwCapabilities);

        /// <summary>
        /// Retrieves the length of the stream.
        /// </summary>
        /// <param name="pqwLength">
        /// Receives the length of the stream, in bytes. If the length is unknown, this value is -1.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetLength(
        ///   [out]  QWORD *pqwLength
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/6FB817A6-5B43-4716-A997-BBD8A0B9305D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6FB817A6-5B43-4716-A997-BBD8A0B9305D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetLength(
            out long pqwLength);

        /// <summary>
        /// Sets the length of the stream.
        /// </summary>
        /// <param name="qwLength">
        /// Length of the stream in bytes.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetLength(
        ///   [in]  QWORD qwLength
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/55BEE595-0A32-4B9E-8B22-48FDB2913DFC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/55BEE595-0A32-4B9E-8B22-48FDB2913DFC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetLength(
            [In] long qwLength);

        /// <summary>
        /// Retrieves the current read or write position in the stream.
        /// </summary>
        /// <param name="pqwPosition">
        /// Receives the current position, in bytes.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetCurrentPosition(
        ///   [out]  QWORD *pqwPosition
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/DE36742A-A8A5-4F40-9FEA-AF89D9A6BF2E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DE36742A-A8A5-4F40-9FEA-AF89D9A6BF2E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetCurrentPosition(
            out long pqwPosition);

        /// <summary>
        /// Sets the current read or write position.
        /// </summary>
        /// <param name="qwPosition">
        /// New position in the stream, as a byte offset from the start of the stream.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description> Invalid argument. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetCurrentPosition(
        ///   [in]  QWORD qwPosition
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/20518FED-4083-413B-B9B1-E54C4C5630D4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/20518FED-4083-413B-B9B1-E54C4C5630D4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetCurrentPosition(
            [In] long qwPosition);

        /// <summary>
        /// Queries whether the current position has reached the end of the stream.
        /// </summary>
        /// <param name="pfEndOfStream">
        /// Receives the value <strong>TRUE</strong> if the end of the stream has been reached, or <strong>
        /// FALSE</strong> otherwise.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT IsEndOfStream(
        ///   [out]  BOOL *pfEndOfStream
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/5E5C02EA-D3FC-4D8D-AA8B-87AA033A3644(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5E5C02EA-D3FC-4D8D-AA8B-87AA033A3644(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int IsEndOfStream(
            [MarshalAs(UnmanagedType.Bool)] out bool pfEndOfStream);

        /// <summary>
        /// Reads data from the stream.
        /// </summary>
        /// <param name="pb">
        /// Pointer to a buffer that receives the data. The caller must allocate the buffer.
        /// </param>
        /// <param name="cb">
        /// Size of the buffer in bytes.
        /// </param>
        /// <param name="pcbRead">
        /// Receives the number of bytes that are copied into the buffer. This parameter cannot be <strong>NULL
        /// </strong>.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Read(
        ///   [in]   BYTE *pb,
        ///   [in]   ULONG cb,
        ///   [out]  ULONG *pcbRead
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/6E0D5363-F2C2-4334-86CA-71FAC61073D3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6E0D5363-F2C2-4334-86CA-71FAC61073D3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Read(
            IntPtr pb,
            [In] int cb,
            out int pcbRead);

        /// <summary>
        /// Begins an asynchronous read operation from the stream.
        /// </summary>
        /// <param name="pb">
        /// Pointer to a buffer that receives the data. The caller must allocate the buffer.
        /// </param>
        /// <param name="cb">
        /// Size of the buffer in bytes.
        /// </param>
        /// <param name="pCallback">
        /// Pointer to the <see cref="IMFAsyncCallback"/> interface of a callback object. The caller must
        /// implement this interface.
        /// </param>
        /// <param name="pUnkState">The p unk state.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT BeginRead(
        ///   [in]  BYTE *pb,
        ///   [in]  ULONG cb,
        ///   [in]  IMFAsyncCallback *pCallback,
        ///   [in]  IUnknown *punkState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/ED4AAF2A-270C-4518-B04D-CDAC966BF9A5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/ED4AAF2A-270C-4518-B04D-CDAC966BF9A5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int BeginRead(
            IntPtr pb,
            [In] int cb,
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnkState);

        /// <summary>
        /// Completes an asynchronous read operation.
        /// </summary>
        /// <param name="pResult">
        /// Pointer to the <see cref="IMFAsyncResult"/> interface. Pass in the same pointer that your callback
        /// object received in the <see cref="IMFAsyncCallback.Invoke"/> method.
        /// </param>
        /// <param name="pcbRead">
        /// Receives the number of bytes that were read.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT EndRead(
        ///   [in]   IMFAsyncResult *pResult,
        ///   [out]  ULONG *pcbRead
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/DD62F644-FB97-474B-8303-3086A7B51C4D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DD62F644-FB97-474B-8303-3086A7B51C4D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EndRead(
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncResult pResult,
            out int pcbRead);

        /// <summary>
        /// Writes data to the stream.
        /// </summary>
        /// <param name="pb">
        /// Pointer to a buffer that contains the data to write.
        /// </param>
        /// <param name="cb">
        /// Size of the buffer in bytes.
        /// </param>
        /// <param name="pcbWritten">
        /// Receives the number of bytes that are written.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Write(
        ///   [in]   const BYTE *pb,
        ///   [in]   ULONG cb,
        ///   [out]  ULONG *pcbWritten
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/D1F1195A-B6EE-441C-AF8B-FCE3DC163E95(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D1F1195A-B6EE-441C-AF8B-FCE3DC163E95(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Write(
            IntPtr pb,
            [In] int cb,
            out int pcbWritten);

        /// <summary>
        /// Begins an asynchronous write operation to the stream.
        /// </summary>
        /// <param name="pb">
        /// Pointer to a buffer containing the data to write.
        /// </param>
        /// <param name="cb">
        /// Size of the buffer in bytes.
        /// </param>
        /// <param name="pCallback">
        /// Pointer to the <see cref="IMFAsyncCallback"/> interface of a callback object. The caller must
        /// implement this interface.
        /// </param>
        /// <param name="pUnkState">The p unk state.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT BeginWrite(
        ///   [in]  const BYTE *pb,
        ///   [in]  ULONG cb,
        ///   [in]  IMFAsyncCallback *pCallback,
        ///   [in]  IUnknown *punkState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/078A8FFE-7B4F-487E-8655-FE5EA14BA306(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/078A8FFE-7B4F-487E-8655-FE5EA14BA306(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int BeginWrite(
            IntPtr pb,
            [In] int cb,
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnkState);

        /// <summary>
        /// Completes an asynchronous write operation.
        /// </summary>
        /// <param name="pResult">
        /// Pointer to the <see cref="IMFAsyncResult"/> interface. Pass in the same pointer that your callback
        /// object received in the <see cref="IMFAsyncCallback.Invoke"/> method.
        /// </param>
        /// <param name="pcbWritten">
        /// Receives the number of bytes that were written.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT EndWrite(
        ///   [in]   IMFAsyncResult *pResult,
        ///   [out]  ULONG *pcbWritten
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/D3E10E89-EF5D-41C5-B549-4BD632D9370D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D3E10E89-EF5D-41C5-B549-4BD632D9370D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EndWrite(
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncResult pResult,
            out int pcbWritten);

        /// <summary>
        /// Moves the current position in the stream by a specified offset.
        /// </summary>
        /// <param name="seekOrigin">
        /// Specifies the origin of the seek as a member of the <see cref="MFByteStreamSeekOrigin"/>
        /// enumeration. The offset is calculated relative to this position.
        /// </param>
        /// <param name="llSeekOffset">The ll seek offset.</param>
        /// <param name="dwSeekFlags">
        /// Specifies zero or more flags. The following flags are defined.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>MFBYTESTREAM_SEEK_FLAG_CANCEL_PENDING_IO</strong></term><description> All pending I/O requests are canceled after the seek request completes successfully. </description></item>
        /// </list>
        /// </param>
        /// <param name="pqwCurrentPosition">
        /// Receives the new position after the seek.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Seek(
        ///   [in]   MFBYTESTREAM_SEEK_ORIGIN SeekOrigin,
        ///   [in]   LONGLONG qwSeekOffset,
        ///   [in]   DWORD dwSeekFlags,
        ///   [out]  QWORD *pqwCurrentPosition
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/512C67A5-E87D-4A81-8577-E64DAC868C40(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/512C67A5-E87D-4A81-8577-E64DAC868C40(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Seek(
            [In] MFByteStreamSeekOrigin seekOrigin,
            [In] long llSeekOffset,
            [In] MFByteStreamSeekingFlags dwSeekFlags,
            out long pqwCurrentPosition);

        /// <summary>
        /// Clears any internal buffers used by the stream. If you are writing to the stream, the buffered data
        /// is written to the underlying file or device.
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Flush();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/16EA6C38-52F3-405E-8A8F-BE5D0527099C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/16EA6C38-52F3-405E-8A8F-BE5D0527099C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Flush();

        /// <summary>
        /// Closes the stream and releases any resources associated with the stream, such as sockets or file
        /// handles. This method also cancels any pending asynchronous I/O requests.
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Close();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/D5F704AB-FA3F-4A53-9B97-EB48A75E481B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D5F704AB-FA3F-4A53-9B97-EB48A75E481B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Close();
    }
}
