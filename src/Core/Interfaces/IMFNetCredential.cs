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

namespace MediaFoundation.Core.Interfaces
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Sets and retrieves user-name and password information for authentication purposes. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D202E7BC-9CE0-4861-8552-5A4D599B1661(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D202E7BC-9CE0-4861-8552-5A4D599B1661(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("5B87EF6A-7ED8-434F-BA0E-184FAC1628D1")]
    internal interface IMFNetCredential
    {
        /// <summary>
        /// Sets the user name.
        /// </summary>
        /// <param name="pbData">
        /// Pointer to a buffer that contains the user name. If <em>fDataIsEncrypted</em> is <strong>FALSE
        /// </strong>, the buffer is a wide-character string. Otherwise, the buffer contains encrypted data. 
        /// </param>
        /// <param name="cbData">
        /// Size of <em>pbData</em>, in bytes. If <em>fDataIsEncrypted</em> is <strong>FALSE</strong>, the size
        /// includes the terminating null character. 
        /// </param>
        /// <param name="fDataIsEncrypted">
        /// If <strong>TRUE</strong>, the user name is encrypted. Otherwise, the user name is not encrypted. 
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
        /// HRESULT SetUser(
        ///   [in]  BYTE *pbData,
        ///   [in]  DWORD cbData,
        ///   [in]  BOOL fDataIsEncrypted
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/026A822A-4E48-4FC8-9781-5E427528A4D2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/026A822A-4E48-4FC8-9781-5E427528A4D2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetUser(
            [In] ref byte pbData,
            [In] int cbData,
            [In] int fDataIsEncrypted
            );

        /// <summary>
        /// Sets the password.
        /// </summary>
        /// <param name="pbData">
        /// Pointer to a buffer that contains the password. If <em>fDataIsEncrypted</em> is <strong>FALSE
        /// </strong>, the buffer is a wide-character string. Otherwise, the buffer contains encrypted data. 
        /// </param>
        /// <param name="cbData">
        /// Size of <em>pbData</em>, in bytes. If <em>fDataIsEncrypted</em> is <strong>FALSE</strong>, the size
        /// includes the terminating null character. 
        /// </param>
        /// <param name="fDataIsEncrypted">
        /// If <strong>TRUE</strong>, the password is encrypted. Otherwise, the password is not encrypted. 
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
        /// HRESULT SetPassword(
        ///   [in]  BYTE *pbData,
        ///   [in]  DWORD cbData,
        ///   [in]  BOOL fDataIsEncrypted
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7DE58B57-83FE-4C3A-9029-E9BE556C84C9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7DE58B57-83FE-4C3A-9029-E9BE556C84C9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetPassword(
            [In] ref byte pbData,
            [In] int cbData,
            [In] int fDataIsEncrypted
            );

        /// <summary>
        /// Retrieves the user name.
        /// </summary>
        /// <param name="pbData">
        /// Pointer to a buffer that receives the user name. To find the required buffer size, set this
        /// parameter to <strong>NULL</strong>. If <em>fEncryptData</em> is <strong>FALSE</strong>, the buffer
        /// contains a wide-character string. Otherwise, the buffer contains encrypted data. 
        /// </param>
        /// <param name="pcbData">
        /// On input, specifies the size of the <em>pbData</em> buffer, in bytes. On output, receives the
        /// required buffer size. If <em>fEncryptData</em> is <strong>FALSE</strong>, the size includes the
        /// terminating null character. 
        /// </param>
        /// <param name="fEncryptData">
        /// If <strong>TRUE</strong>, the method returns an encrypted string. Otherwise, the method returns an
        /// unencrypted string. 
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
        /// HRESULT GetUser(
        ///   [out]      BYTE *pbData,
        ///   [in, out]  DWORD *pcbData,
        ///   [in]       BOOL fEncryptData
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/11E10B9F-FD98-44F2-A829-D9ED3A5BE189(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/11E10B9F-FD98-44F2-A829-D9ED3A5BE189(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetUser(
            out byte pbData,
            [In, Out] ref int pcbData,
            [In] int fEncryptData
            );

        /// <summary>
        /// Retrieves the password.
        /// </summary>
        /// <param name="pbData">
        /// Pointer to a buffer that receives the password. To find the required buffer size, set this
        /// parameter to <strong>NULL</strong>. If <em>fEncryptData</em> is <strong>FALSE</strong>, the buffer
        /// contains a wide-character string. Otherwise, the buffer contains encrypted data. 
        /// </param>
        /// <param name="pcbData">
        /// On input, specifies the size of the <em>pbData</em> buffer, in bytes. On output, receives the
        /// required buffer size. If <em>fEncryptData</em> is <strong>FALSE</strong>, the size includes the
        /// terminating null character. 
        /// </param>
        /// <param name="fEncryptData">
        /// If <strong>TRUE</strong>, the method returns an encrypted string. Otherwise, the method returns an
        /// unencrypted string. 
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
        /// HRESULT GetPassword(
        ///   [out]      BYTE *pbData,
        ///   [in, out]  DWORD *pcbData,
        ///   [in]       BOOL fEncryptData
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AB7A4999-4A08-472C-BB7E-7068F2E2AC34(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AB7A4999-4A08-472C-BB7E-7068F2E2AC34(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetPassword(
            out byte pbData,
            [In, Out] ref int pcbData,
            [In, MarshalAs(UnmanagedType.Bool)] bool fEncryptData
            );

        /// <summary>
        /// Queries whether logged-on credentials should be used.
        /// </summary>
        /// <param name="pfLoggedOnUser">
        /// Receives a Boolean value. If logged-on credentials should be used, the value is <strong>TRUE
        /// </strong>. Otherwise, the value is <strong>FALSE</strong>. 
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
        /// HRESULT LoggedOnUser(
        ///   [in]  BOOL *pfLoggedOnUser
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/70F3DC70-ED6B-417C-93CB-E00EFCDB43EC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/70F3DC70-ED6B-417C-93CB-E00EFCDB43EC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int LoggedOnUser(
            [MarshalAs(UnmanagedType.Bool)] out bool pfLoggedOnUser
            );
    }

#endif

}
