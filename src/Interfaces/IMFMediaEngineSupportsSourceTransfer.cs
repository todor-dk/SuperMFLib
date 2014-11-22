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

using MediaFoundation.Misc;
using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Enables the media source to be transferred between  the media engine and the sharing engine for
    /// Play To.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/8784DCC2-52F4-41D9-A0AE-3EA7A736B604(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8784DCC2-52F4-41D9-A0AE-3EA7A736B604(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("a724b056-1b2e-4642-a6f3-db9420c52908"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaEngineSupportsSourceTransfer
    {
        /// <summary>
        /// Specifies wether or not the source should be transferred.
        /// </summary>
        /// <param name="pfShouldTransfer">
        /// <strong>true</strong> if the source should be transferred; otherwise, <strong>false</strong>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT ShouldTransferSource(
        ///   [out]  BOOL *pfShouldTransfer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7409A6BE-7114-42E2-B878-C68D846106C6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7409A6BE-7114-42E2-B878-C68D846106C6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ShouldTransferSource(
          [MarshalAs(UnmanagedType.Bool)] out bool pfShouldTransfer
          );

        /// <summary>
        /// Detaches the media source.
        /// </summary>
        /// <param name="ppByteStream">
        /// Receives the byte stream.
        /// </param>
        /// <param name="ppMediaSource">
        /// Receives the media source.
        /// </param>
        /// <param name="ppMSE">
        /// Receives the media source extension.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT DetachMediaSource(
        ///   [out]  IMFByteStream **ppByteStream,
        ///   [out]  IMFMediaSource **ppMediaSource,
        ///   [out]  IMFMediaSourceExtension **ppMSE
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A085FC53-91A3-46BB-862C-DDE16FB7FA42(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A085FC53-91A3-46BB-862C-DDE16FB7FA42(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int DetachMediaSource(
            out IMFByteStream ppByteStream,
            out IMFMediaSource ppMediaSource,
            out IMFMediaSourceExtension ppMSE
            );

        /// <summary>
        /// Attaches the media source.
        /// </summary>
        /// <param name="pByteStream">
        /// Specifies the byte stream. 
        /// </param>
        /// <param name="pMediaSource">
        /// Specifies the media source.
        /// </param>
        /// <param name="pMSE">
        /// Specifies the media source extension.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT AttachMediaSource(
        ///   [in]  IMFByteStream *pByteStream,
        ///   [in]  IMFMediaSource *pMediaSource,
        ///   [in]  IMFMediaSourceExtension *pMSE
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DB7C17CF-020D-4317-801E-35539E25DF49(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DB7C17CF-020D-4317-801E-35539E25DF49(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int AttachMediaSource(
            IMFByteStream pByteStream,
            IMFMediaSource pMediaSource,
            IMFMediaSourceExtension pMSE
            );
    }

#endif
}
