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

namespace MediaFoundation.Core.Interfaces
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Represents a media keys used for decrypting media data using a Digital Rights Management (DRM) key
    /// system. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/0689D938-E0BE-46D7-BFED-ADD431331A90(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0689D938-E0BE-46D7-BFED-ADD431331A90(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
        Guid("5cb31c05-61ff-418f-afda-caaf41421a38"),
        InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFMediaKeys
    {
        /// <summary>
        /// Creates a media key session object using the specified initialization data and custom data. . 
        /// </summary>
        /// <param name="mimeType">
        /// The MIME type of the media container used for the content.
        /// </param>
        /// <param name="initData">
        /// The initialization data for the key system. 
        /// </param>
        /// <param name="cb">
        /// The count in bytes of <em>initData</em>. 
        /// </param>
        /// <param name="customData">
        /// Custom data sent to the key system.
        /// </param>
        /// <param name="cbCustomData">
        /// The count in bytes of <em>cbCustomData</em>. 
        /// </param>
        /// <param name="notify">
        /// notify
        /// </param>
        /// <param name="ppSession">
        /// The media key session.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT CreateSession(
        ///   BSTR mimeType,
        ///   const BYTE *initData,
        ///   DWORD cb,
        ///   const BYTE *customData,
        ///   DWORD cbCustomData,
        ///   IMFMediaKeySessionNotify *notify,
        ///   IMFMediaKeySession **ppSession
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9F11433C-7CFF-4A59-9D4A-7F4B56BA62CF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9F11433C-7CFF-4A59-9D4A-7F4B56BA62CF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateSession(
           [MarshalAs(UnmanagedType.BStr)] string mimeType,
           IntPtr initData,
           int cb,
           IntPtr customData,
           int cbCustomData,
           IMFMediaKeySessionNotify notify,
           out IMFMediaKeySession ppSession
           );

        /// <summary>
        /// Gets the key system string the <c>IMFMediaKeys</c> object was created with. 
        /// </summary>
        /// <param name="keySystem">
        /// The string name of the key system.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT get_KeySystem(
        ///   BSTR *keySystem
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D60EE85B-B5FC-4D06-A3A2-F61FF3635D99(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D60EE85B-B5FC-4D06-A3A2-F61FF3635D99(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int get_KeySystem(
           [MarshalAs(UnmanagedType.BStr)] out string keySystem
           );

        /// <summary>
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
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
        /// <a href="http://msdn.microsoft.com/en-US/library/464B598C-5FA7-40AF-83BA-8619FBD84B04(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/464B598C-5FA7-40AF-83BA-8619FBD84B04(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Shutdown();

        /// <summary>
        /// Gets the suspend notify interface of the Content Decryption Module (CDM).
        /// </summary>
        /// <param name="notify">
        /// The suspend notify interface of the Content Decryption Module (CDM).
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetSuspendNotify(
        ///   IMFCdmSuspendNotify **notify
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/35D76CBC-04C7-49E7-9451-6B032CCD2937(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/35D76CBC-04C7-49E7-9451-6B032CCD2937(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetSuspendNotify(
           out IMFCdmSuspendNotify notify
           );
    }

#endif
}
