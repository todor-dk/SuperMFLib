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
    /// Encapsulates the functionality of one or more output protection systems that a trusted output
    /// supports. This interface is exposed by output trust authority (OTA) objects. Each OTA represents a
    /// single action that the trusted output can perform, such as play, copy, or transcode. An OTA can
    /// represent more than one physical output if each output performs the same action.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/21594AC0-7E3C-44A3-BBEE-64316DD51824(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/21594AC0-7E3C-44A3-BBEE-64316DD51824(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("D19F8E94-B126-4446-890C-5DCB7AD71453"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFOutputTrustAuthority
    {
        /// <summary>
        /// Retrieves the action that is performed by this output trust authority (OTA).
        /// </summary>
        /// <param name="pAction">
        /// Receives a member of the <c>MFPOLICYMANAGER_ACTION</c> enumeration. 
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
        /// HRESULT GetAction(
        ///   [out]  MFPOLICYMANAGER_ACTION *pAction
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5A109E18-A6E2-4F8C-A656-B27112935452(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5A109E18-A6E2-4F8C-A656-B27112935452(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetAction(
            out MFPolicyManagerAction pAction
            );

        /// <summary>
        /// Sets one or more policy objects on the output trust authority (OTA). 
        /// </summary>
        /// <param name="ppPolicy">
        /// The address of an array of <see cref="IMFOutputPolicy"/> pointers. 
        /// </param>
        /// <param name="nPolicy">
        /// The number of elements in the <em>ppPolicy</em> array. 
        /// </param>
        /// <param name="ppbTicket">
        /// Receives either a pointer to a buffer allocated by the OTA, or the value <strong>NULL</strong>. If
        /// this parameter receives a non- <strong>NULL</strong> value, the caller must release the buffer by
        /// calling <c>CoTaskMemFree</c>. 
        /// <para/>
        /// <strong>Note</strong> Currently this parameter is reserved. An OTA should set the pointer to 
        /// <strong>NULL</strong>. 
        /// </param>
        /// <param name="pcbTicket">
        /// Receives the size of the <em>ppbTicket</em> buffer, in bytes. If <em>ppbTicket</em> receives the
        /// value <strong>NULL</strong>, <em>pcbTicket</em> receives the value zero. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_S_WAIT_FOR_POLICY_SET</strong></term><description> The policy was negotiated successfully, but the OTA will enforce it asynchronously. </description></item>
        /// <item><term><strong>MF_E_POLICY_UNSUPPORTED</strong></term><description> The OTA does not support the requirements of this policy. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetPolicy(
        ///   [in]   IMFOutputPolicy **ppPolicy,
        ///   [in]   DWORD nPolicy,
        ///   [out]  BYTE **ppbTicket,
        ///   [out]  DWORD *pcbTicket
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F5102EF3-472F-4A38-889C-E1C25DD46765(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F5102EF3-472F-4A38-889C-E1C25DD46765(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetPolicy(
            [In, MarshalAs(UnmanagedType.Interface)] ref IMFOutputPolicy ppPolicy,
            [In] int nPolicy,
            [Out] IntPtr ppbTicket,
            out int pcbTicket
            );
    }

#endif

}
