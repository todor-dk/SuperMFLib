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
    /// Provides encryption for media data inside the protected media path (PMP). 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BEBE24CD-657B-4C6C-9FE9-5D6DD58827A3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BEBE24CD-657B-4C6C-9FE9-5D6DD58827A3(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("8E36395F-C7B9-43C4-A54D-512B4AF63C95")]
    internal interface IMFSampleProtection
    {
        /// <summary>
        /// Retrieves the version of sample protection that the component implements on input.
        /// </summary>
        /// <param name="pdwVersion">
        /// Receives a member of the <c>SAMPLE_PROTECTION_VERSION</c> enumeration. 
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
        /// HRESULT GetInputProtectionVersion(
        ///   [out]  DWORD *pdwVersion
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/26F92775-F8A0-4B85-8CFC-353349325706(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/26F92775-F8A0-4B85-8CFC-353349325706(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetInputProtectionVersion(
            out int pdwVersion
            );

        /// <summary>
        /// Retrieves the version of sample protection that the component implements on output.
        /// </summary>
        /// <param name="pdwVersion">
        /// Receives a member of the <c>SAMPLE_PROTECTION_VERSION</c> enumeration. 
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
        /// HRESULT GetOutputProtectionVersion(
        ///   [out]  DWORD *pdwVersion
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/607E6123-0CFA-4946-B390-1C44E502B2DB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/607E6123-0CFA-4946-B390-1C44E502B2DB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetOutputProtectionVersion(
            out int pdwVersion
            );

        /// <summary>
        /// Retrieves the sample protection certificate.
        /// </summary>
        /// <param name="dwVersion">
        /// Specifies the version number of the sample protection scheme for which to receive a certificate.
        /// The version number is specified as a <c>SAMPLE_PROTECTION_VERSION</c> enumeration value. 
        /// </param>
        /// <param name="ppCert">
        /// Receives a pointer to a buffer containing the certificate. The caller must free the memory for the
        /// buffer by calling <c>CoTaskMemFree</c>. 
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
        /// <item><term><strong>E_NOTIMPL</strong></term><description>Not implemented.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetProtectionCertificate(
        ///   [in]   DWORD dwVersion,
        ///   [out]  BYTE **ppCert,
        ///   [out]  DWORD *pcbCert
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B93ECC4E-40F6-4AE1-9A1A-9767E6C8C4AF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B93ECC4E-40F6-4AE1-9A1A-9767E6C8C4AF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetProtectionCertificate(
            [In] int dwVersion,
            [Out] IntPtr ppCert,
            out int pcbCert
            );

        /// <summary>
        /// Retrieves initialization information for sample protection from the upstream component.
        /// </summary>
        /// <param name="dwVersion">
        /// Specifies the version number of the sample protection scheme. The version number is specified as a 
        /// <c>SAMPLE_PROTECTION_VERSION</c> enumeration value. 
        /// </param>
        /// <param name="dwOutputId">
        /// Identifier of the output stream. The identifier corresponds to the output stream identifier
        /// returned by the <see cref="Transform.IMFTransform"/> interface. 
        /// </param>
        /// <param name="pbCert">
        /// Pointer to a certificate provided by the downstream component.
        /// </param>
        /// <param name="cbCert">
        /// Size of the certificate, in bytes.
        /// </param>
        /// <param name="ppbSeed">
        /// Receives a pointer to a buffer that contains the initialization information for downstream
        /// component. The caller must free the memory for the buffer by calling <c>CoTaskMemFree</c>. 
        /// </param>
        /// <param name="pcbSeed">
        /// Receives the size of the <em>ppbSeed</em> buffer, in bytes. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_NOTIMPL</strong></term><description>Not implemented.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT InitOutputProtection(
        ///   [in]   DWORD dwVersion,
        ///   [in]   DWORD dwOutputId,
        ///   [in]   BYTE *pbCert,
        ///   [in]   DWORD cbCert,
        ///   [out]  BYTE **ppbSeed,
        ///   [out]  DWORD *pcbSeed
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/03BEE13D-1C51-4B26-98BB-BAC15264AA54(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/03BEE13D-1C51-4B26-98BB-BAC15264AA54(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int InitOutputProtection(
            [In] int dwVersion,
            [In] int dwOutputId,
            [In] ref byte pbCert,
            [In] int cbCert,
            [Out] IntPtr ppbSeed,
            out int pcbSeed
            );

        /// <summary>
        /// Initializes sample protection on the downstream component.
        /// </summary>
        /// <param name="dwVersion">
        /// Specifies the version number of the sample protection scheme. The version number is specified as a 
        /// <c>SAMPLE_PROTECTION_VERSION</c> enumeration value. 
        /// </param>
        /// <param name="dwInputId">
        /// Identifier of the input stream. The identifier corresponds to the output stream identifier returned
        /// by the <see cref="Transform.IMFTransform"/> interface. 
        /// </param>
        /// <param name="pbSeed">
        /// Pointer to a buffer that contains the initialization data provided by the upstream component. To
        /// retrieve this buffer, call <see cref="IMFSampleProtection.InitOutputProtection"/>. 
        /// </param>
        /// <param name="cbSeed">
        /// Size of the <em>pbSeed</em> buffer, in bytes. 
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
        /// HRESULT InitInputProtection(
        ///   [in]  DWORD dwVersion,
        ///   [in]  DWORD dwInputId,
        ///   [in]  BYTE *pbSeed,
        ///   [in]  DWORD cbSeed
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2BD43F33-8528-4E78-97D5-2AF39A2AC06B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2BD43F33-8528-4E78-97D5-2AF39A2AC06B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int InitInputProtection(
            [In] int dwVersion,
            [In] int dwInputId,
            [In] ref byte pbSeed,
            [In] int cbSeed
            );
    }

#endif

}
