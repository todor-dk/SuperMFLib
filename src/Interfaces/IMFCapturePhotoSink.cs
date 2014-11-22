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
using MediaFoundation.EVR;

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Controls the photo sink. The photo sink captures still images from the video stream.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/14BB9A86-47F2-4CFE-A932-3F2C7B6AF2BA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/14BB9A86-47F2-4CFE-A932-3F2C7B6AF2BA(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("d2d43cc8-48bb-4aa7-95db-10c06977e777"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFCapturePhotoSink : IMFCaptureSink
    {
        /// <summary>
        /// Specifies the name of the output file for the still image.
        /// </summary>
        /// <param name="fileName">
        /// A null-terminated string that contains the URL of the output file. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetOutputFileName(
        ///   [in]  LPCWSTR fileName
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CAA9F7CF-A92F-4039-BEA5-07A730E82EE4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CAA9F7CF-A92F-4039-BEA5-07A730E82EE4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetOutputFileName(
            [MarshalAs(UnmanagedType.LPWStr)] string fileName
            );

        /// <summary>
        /// Sets a callback to receive the still-image data.
        /// </summary>
        /// <param name="pCallback">
        /// A pointer to the <see cref="IMFCaptureEngineOnSampleCallback"/> interface. The caller must
        /// implement this interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetSampleCallback(
        ///   [in]  IMFCaptureEngineOnSampleCallback *pCallback
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/595716F6-8059-4B56-9FB3-906846BA3CBB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/595716F6-8059-4B56-9FB3-906846BA3CBB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetSampleCallback(
            IMFCaptureEngineOnSampleCallback pCallback
            );

        /// <summary>
        /// Specifies a byte stream that will receive the still image data.
        /// </summary>
        /// <param name="pByteStream">
        /// A pointer to the <see cref="IMFByteStream"/> interface of a byte stream. The byte stream must be
        /// writable. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetOutputByteStream(
        ///   [in]  IMFByteStream *pByteStream
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D67C2D66-FC40-4AF3-9E83-29D0DBF99AD3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D67C2D66-FC40-4AF3-9E83-29D0DBF99AD3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetOutputByteStream(
            IMFByteStream pByteStream
            );
    }

#endif

}
