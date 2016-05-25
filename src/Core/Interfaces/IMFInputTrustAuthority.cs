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
    /// Enables other components in the protected media path (PMP) to use the input protection system
    /// provided by an input trust authorities (ITA). An ITA is a component that implements an input
    /// protection system for media content. ITAs expose the <strong>IMFInputTrustAuthority</strong>
    /// interface. 
    /// <para/>
    /// An ITA translates policy from the content's native format into a common format that is used by
    /// other PMP components. It also provides a decrypter, if one is needed to decrypt the stream.
    /// <para/>
    /// The topology contains one ITA instance for every protected stream in the media source. The ITA is
    /// obtained from the media source by calling <see cref="IMFTrustedInput.GetInputTrustAuthority"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/637E0225-6FD8-4B83-B4FB-119E7A5EF5D2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/637E0225-6FD8-4B83-B4FB-119E7A5EF5D2(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("D19F8E98-B126-4446-890C-5DCB7AD71453"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFInputTrustAuthority
    {
        /// <summary>
        /// Retrieves a decrypter transform.
        /// </summary>
        /// <param name="riid">
        /// Interface identifier (IID) of the interface being requested. Currently this value must be
        /// IID_IMFTransform, which requests the <see cref="Transform.IMFTransform"/> interface. 
        /// </param>
        /// <param name="ppv">
        /// Receives a pointer to the interface. The caller must release the interface.
        /// </param>
        /// <returns>
        /// The method returns an HRESULT. Possible values include, but are not limited to, those in the
        /// following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_NOINTERFACE</strong></term><description>The decrypter does not support the requested interface.</description></item>
        /// <item><term><strong>MF_E_NOT_PROTECTED</strong></term><description>This input trust authority (ITA) does not provide a decrypter.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetDecrypter(
        ///   [in]   REFIID riid,
        ///   [out]  void **ppv
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3BC4E2E6-41A8-4751-A7FE-5E1F8C136983(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3BC4E2E6-41A8-4751-A7FE-5E1F8C136983(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetDecrypter(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.Interface)] out object ppv
            );

        /// <summary>
        /// Requests permission to perform a specified action on the stream.
        /// </summary>
        /// <param name="Action">
        /// The requested action, specified as a member of the <c>MFPOLICYMANAGER_ACTION</c> enumeration. 
        /// </param>
        /// <param name="ppContentEnablerActivate">
        /// Receives the value <strong>NULL</strong> or a pointer to the <see cref="IMFActivate"/> interface.
        /// The <strong>IMFActivate</strong> interface is used to create a content enabler object. The caller
        /// must release the interface. For more information, see Remarks. 
        /// </param>
        /// <returns>
        /// The method returns an HRESULT. Possible values include, but are not limited to, those in the
        /// following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The user has permission to perform this action.</description></item>
        /// <item><term><strong>NS_E_DRM_NEEDS_INDIVIDUALIZATION</strong></term><description>The user must individualize the application.</description></item>
        /// <item><term><strong>NS_E_LICENSE_REQUIRED</strong></term><description>The user must obtain a license.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT RequestAccess(
        ///   [in]   MFPOLICYMANAGER_ACTION Action,
        ///   [out]  IMFActivate **ppContentEnablerActivate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8F2F7F65-7000-4404-8678-BA36C5C97C80(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8F2F7F65-7000-4404-8678-BA36C5C97C80(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RequestAccess(
            [In] MFPolicyManagerAction Action,
            [MarshalAs(UnmanagedType.Interface)] out IMFActivate ppContentEnablerActivate
            );

        /// <summary>
        /// Retrieves the policy that defines which output protection systems are allowed for this stream, and
        /// the configuration data for each protection system.
        /// </summary>
        /// <param name="Action">
        /// The action that will be performed on this stream, specified as a member of the 
        /// <c>MFPOLICYMANAGER_ACTION</c> enumeration. 
        /// </param>
        /// <param name="ppPolicy">
        /// Receives a pointer to the <see cref="IMFOutputPolicy"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The method returns an HRESULT. Possible values include, but are not limited to, those in the
        /// following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetPolicy(
        ///   [in]   MFPOLICYMANAGER_ACTION Action,
        ///   [out]  IMFOutputPolicy **ppPolicy
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4D840B56-47E0-4C2F-B2E7-A17586DAD8D1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4D840B56-47E0-4C2F-B2E7-A17586DAD8D1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetPolicy(
            [In] MFPolicyManagerAction Action,
            [MarshalAs(UnmanagedType.Interface)] out IMFOutputPolicy ppPolicy
            );

        /// <summary>
        /// Notifies the input trust authority (ITA) that a requested action is about to be performed.
        /// </summary>
        /// <param name="pParam">
        /// Pointer to an <see cref="MFInputTrustAuthorityAccessParams"/> structure that contains parameters
        /// for the <strong>BindAccess</strong> action. 
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
        /// HRESULT BindAccess(
        ///   [in]  MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS *pParam
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/94E447AF-9311-4A2C-9EC5-BE371684F79D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/94E447AF-9311-4A2C-9EC5-BE371684F79D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int BindAccess(
            [In] ref MFInputTrustAuthorityAccessParams pParam
            );

        /// <summary>
        /// Notifies the input trust authority (ITA) when the number of output trust authorities (OTAs) that
        /// will perform a specified action has changed.
        /// </summary>
        /// <param name="pParam">
        /// Pointer to an <see cref="MFInputTrustAuthorityAccessParams"/> structure that contains parameters
        /// for the <strong>UpdateAccess</strong> action. 
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
        /// HRESULT UpdateAccess(
        ///   [in]  MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS *pParam
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4CA635FC-15EB-4A9E-8F59-7FA2E3F3E176(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4CA635FC-15EB-4A9E-8F59-7FA2E3F3E176(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int UpdateAccess(
            [In] ref MFInputTrustAuthorityAccessParams pParam
            );

        /// <summary>
        /// Resets the input trust authority (ITA) to its initial state.
        /// </summary>
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
        /// HRESULT Reset();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BEB8E598-5A35-46B0-AA13-6BEF38B9DEFB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BEB8E598-5A35-46B0-AA13-6BEF38B9DEFB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Reset();
    }

#endif

}
