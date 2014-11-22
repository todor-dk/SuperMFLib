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
    /// Establishes a one-way secure channel between two objects. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/063170B8-9483-4ACD-9B42-A226E9C38F0E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/063170B8-9483-4ACD-9B42-A226E9C38F0E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("D0AE555D-3B12-4D97-B060-0990BC5AEB67"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFSecureChannel
    {
        /// <summary>
        /// Retrieves the client's certificate.
        /// </summary>
        /// <param name="ppCert">
        /// Receives a pointer to a buffer allocated by the object. The buffer contains the client's
        /// certificate. The caller must release the buffer by calling <c>CoTaskMemFree</c>. 
        /// </param>
        /// <param name="pcbCert">
        /// Receives the size of the <em>ppCert</em> buffer, in bytes. 
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
        /// HRESULT GetCertificate(
        ///   [out]  BYTE **ppCert,
        ///   [out]  DWORD *pcbCert
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D5465070-1706-4420-8351-FAB5E8E8CD08(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D5465070-1706-4420-8351-FAB5E8E8CD08(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetCertificate(
            [Out] IntPtr ppCert,
            out int pcbCert
            );

        /// <summary>
        /// Passes the encrypted session key to the client.
        /// </summary>
        /// <param name="pbEncryptedSessionKey">
        /// Pointer to a buffer that contains the encrypted session key. This parameter can be <strong>NULL
        /// </strong>. 
        /// </param>
        /// <param name="cbSessionKey">
        /// Size of the <em>pbEncryptedSessionKey</em> buffer, in bytes. 
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
        /// HRESULT SetupSession(
        ///   [in]  BYTE *pbEncryptedSessionKey,
        ///   [in]  DWORD cbSessionKey
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A4D38056-EA6A-441E-8B77-39FFD316CB5A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A4D38056-EA6A-441E-8B77-39FFD316CB5A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetupSession(
            [In] ref byte pbEncryptedSessionKey,
            [In] int cbSessionKey
            );
    }

#endif

}
