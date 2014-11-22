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

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Implemented by the transcode sink activation object.
    /// <para/>
    /// The transcode sink activation object can be used to create any of the following file sinks:
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/C5EB0C30-559A-44DD-80D4-4B11933DC7CE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C5EB0C30-559A-44DD-80D4-4B11933DC7CE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("8CFFCD2E-5A03-4A3A-AFF7-EDCD107C620E")]
    public interface IMFTranscodeSinkInfoProvider
    {
        /// <summary>
        /// Sets the name of the encoded output file.
        /// </summary>
        /// <param name="pwszFileName">
        /// Pointer to a null-terminated string that contains the name of the output file.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetOutputFile(
        ///   [in]  LPCWSTR pwszFileName
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/048D1822-9349-4D49-A468-C89BC9C51583(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/048D1822-9349-4D49-A468-C89BC9C51583(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetOutputFile(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszFileName
        );

        /// <summary>
        /// Sets an output byte stream for the transcode media sink.
        /// </summary>
        /// <param name="pByteStreamActivate">
        /// A pointer to the <see cref="IMFActivate"/> interface of a byte-stream activation object. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetOutputByteStream(
        ///   [in]  IMFActivate *pByteStreamActivate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/234BED82-A148-4313-A8CB-EEFE2061B7ED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/234BED82-A148-4313-A8CB-EEFE2061B7ED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetOutputByteStream(
            IMFActivate pByteStreamActivate
        );

        /// <summary>
        /// Sets the transcoding profile on the transcode sink activation object.
        /// </summary>
        /// <param name="pProfile">
        /// A pointer to the <see cref="IMFTranscodeProfile"/> interface. To get a pointer to this interface,
        /// call <see cref="MFExtern.MFCreateTranscodeProfile"/>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetProfile(
        ///   [in]  IMFTranscodeProfile *pProfile
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/81137D8C-70B2-4A0A-A1B4-16A2F50F134B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/81137D8C-70B2-4A0A-A1B4-16A2F50F134B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetProfile(
            IMFTranscodeProfile pProfile
        );

        /// <summary>
        /// Gets the media types for the audio and video streams specified in the transcode profile.
        /// </summary>
        /// <param name="pSinkInfo">
        /// A pointer to an <see cref="MFTranscodeSinkInfo"/> structure. 
        /// <para/>
        /// If the method succeeds, the method assigns <see cref="IMFMediaType"/> pointers to the <strong>
        /// pAudioMediaType</strong> and <strong>pVideoMediaType</strong> members of this structure. The method
        /// might set either member to <strong>NULL</strong>. If either member is non-NULL after the method
        /// returns, the caller must release the <strong>IMFMediaType</strong> pointers. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetSinkInfo(
        ///   [out]  MF_TRANSCODE_SINK_INFO *pSinkInfo
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D880E13A-879E-4882-A69D-F1920225E478(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D880E13A-879E-4882-A69D-F1920225E478(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetSinkInfo(
            out MFTranscodeSinkInfo pSinkInfo
        );
    }

#endif

}
