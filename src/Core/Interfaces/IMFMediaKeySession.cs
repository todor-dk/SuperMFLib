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
    /// Represents a session with the Digital Rights Management (DRM) key system.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/07F97BC9-9DA2-4655-9AB9-5E17ABC57D6D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/07F97BC9-9DA2-4655-9AB9-5E17ABC57D6D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("24fa67d5-d1d0-4dc5-995c-c0efdc191fb5"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFMediaKeySession
    {
        /// <summary>
        /// Gets the error state associated with the media key session.
        /// </summary>
        /// <param name="code">
        /// The error code.
        /// </param>
        /// <param name="systemCode">
        /// Platform specific error information.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetError(
        ///   USHORT *code,
        ///   DWORD *systemCode
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4693B7D5-59EE-472F-83FC-1ECBCC165DAC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4693B7D5-59EE-472F-83FC-1ECBCC165DAC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetError(
           out short code,
           out int systemCode);

        /// <summary>
        /// Gets the name of the  key system name the media keys object was created with.
        /// </summary>
        /// <param name="keySystem">
        /// The name of the key system.
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
        /// <a href="http://msdn.microsoft.com/en-US/library/EAF3A411-7282-496C-8095-79A8913A0F8E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EAF3A411-7282-496C-8095-79A8913A0F8E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int get_KeySystem(
           [MarshalAs(UnmanagedType.BStr)] out string keySystem
           );

        /// <summary>
        /// Gets a unique session id created for this session.
        /// </summary>
        /// <param name="sessionId">
        /// The media key session id.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT get_SessionId(
        ///   BSTR *sessionId
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/779EBEA9-69FF-469A-8EE0-06D570EDE6CB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/779EBEA9-69FF-469A-8EE0-06D570EDE6CB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int get_SessionId(
           [MarshalAs(UnmanagedType.BStr)] out string sessionId
           );

        /// <summary>
        /// Passes in a key value with any associated data required by the Content Decryption Module for the
        /// given key system.
        /// </summary>
        /// <param name="key">
        /// </param>
        /// <param name="cb">
        /// The count in bytes of <em>key</em>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Update(
        ///   const BYTE *key,
        ///   DWORD cb
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/29E66037-5F18-4724-B6F2-D85555E6AF69(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/29E66037-5F18-4724-B6F2-D85555E6AF69(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Update(
           IntPtr key,
           int cb
           );

        /// <summary>
        /// Closes the media key session and must be called before the key session is released.
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
        /// <a href="http://msdn.microsoft.com/en-US/library/97C6B4BD-A973-4475-A325-0373AF9B54B1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/97C6B4BD-A973-4475-A325-0373AF9B54B1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Close();
    }

#endif
}
