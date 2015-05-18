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

namespace MediaFoundation.ReadWrite.Interfaces
{

#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Provides additional functionality on the sink writer for dynamically changing the media type and
    /// encoder configuration. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/3A0D090D-9EB1-4624-989B-C5DA27B988AA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3A0D090D-9EB1-4624-989B-C5DA27B988AA(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("17C3779E-3CDE-4EDE-8C60-3899F5F53AD6")]
    internal interface IMFSinkWriterEncoderConfig
    {
        /// <summary>
        /// Dynamically changes the target media type that Sink Writer is encoding to. 
        /// </summary>
        /// <param name="dwStreamIndex">
        /// Specifies the stream index.
        /// </param>
        /// <param name="pTargetMediaType">
        /// The new media format to encode to.
        /// </param>
        /// <param name="pEncodingParameters">
        /// The new set of encoding parameters to configure the encoder with. If not specified, previously
        /// provided parameters will be used. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetTargetMediaType(
        ///   [in]  DWORD dwStreamIndex,
        ///   [in]  IMFMediaType *pTargetMediaType,
        ///   [in]  IMFAttributes *pEncodingParameters
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/26D6EE83-5899-40E7-8B71-CA47F5B0D1C1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/26D6EE83-5899-40E7-8B71-CA47F5B0D1C1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetTargetMediaType(
            int dwStreamIndex,
            IMFMediaType pTargetMediaType,
            IMFAttributes pEncodingParameters
            );

        /// <summary>
        /// Dynamically updates the encoder configuration with a collection of new encoder settings.
        /// </summary>
        /// <param name="dwStreamIndex">
        /// Specifies the stream index.
        /// </param>
        /// <param name="pEncodingParameters">
        /// A set of encoding parameters to configure the encoder with. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT PlaceEncodingParameters(
        ///   [in]  DWORD dwStreamIndex,
        ///   [in]  IMFAttributes *pEncodingParameters
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EA09D806-C869-4A62-8F9D-C35DB4E406FF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EA09D806-C869-4A62-8F9D-C35DB4E406FF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int PlaceEncodingParameters(
            int dwStreamIndex,
            IMFAttributes pEncodingParameters
            );
    }

#endif
}
