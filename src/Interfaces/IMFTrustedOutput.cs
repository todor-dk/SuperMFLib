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
    /// Implemented by components that provide output trust authorities (OTAs). Any Media Foundation
    /// transform (MFT) or media sink that is designed to work within the protected media path (PMP) and
    /// also sends protected content outside the Media Foundation pipeline must implement this interface.
    /// <para/>
    /// The policy engine uses this interface to negotiate what type of content protection should be
    /// applied to the content. Applications do not use this interface directly.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/14342D8B-3C76-4C13-8CBE-A60BB66084C8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/14342D8B-3C76-4C13-8CBE-A60BB66084C8(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("D19F8E95-B126-4446-890C-5DCB7AD71453"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFTrustedOutput
    {
        /// <summary>
        /// Gets the number of output trust authorities (OTAs) provided by this trusted output. Each OTA
        /// reports a single action.
        /// </summary>
        /// <param name="pcOutputTrustAuthorities">
        /// Receives the number of OTAs. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetOutputTrustAuthorityCount(
        ///   [out]  DWORD *pcOutputTrustAuthorities
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3AAE6859-0B32-4705-9045-B98D0BBF43A6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3AAE6859-0B32-4705-9045-B98D0BBF43A6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetOutputTrustAuthorityCount(
            out int pcOutputTrustAuthorities
            );

        /// <summary>
        /// Gets an output trust authority (OTA), specified by index.
        /// </summary>
        /// <param name="dwIndex">
        /// Zero-based index of the OTA to retrieve. To get the number of OTAs provided by this object, call 
        /// <see cref="IMFTrustedOutput.GetOutputTrustAuthorityCount"/>. 
        /// </param>
        /// <param name="ppauthority">
        /// Receives a pointer to the <see cref="IMFOutputTrustAuthority"/> interface of the OTA. The caller
        /// must release the interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetOutputTrustAuthorityByIndex(
        ///   [in]   DWORD dwIndex,
        ///   [out]  IMFOutputTrustAuthority **ppauthority
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4DD570E7-C6FB-4FFB-8EF5-B88A6638DBBF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4DD570E7-C6FB-4FFB-8EF5-B88A6638DBBF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetOutputTrustAuthorityByIndex(
            [In] int dwIndex,
            [MarshalAs(UnmanagedType.Interface)] out IMFOutputTrustAuthority ppauthority
            );

        /// <summary>
        /// Queries whether this output is a policy sink, meaning it handles the rights and restrictions
        /// required by the input trust authority (ITA).
        /// </summary>
        /// <param name="pfIsFinal">
        /// Receives a Boolean value. If <strong>TRUE</strong>, this object is a policy sink. If <strong>FALSE
        /// </strong>, the policy must be enforced further downstream. 
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
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT IsFinal(
        ///   [out]  BOOL *pfIsFinal
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/085CAC9C-F8C1-45B9-A8FE-C2C5CC941439(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/085CAC9C-F8C1-45B9-A8FE-C2C5CC941439(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int IsFinal(
            [MarshalAs(UnmanagedType.Bool)] out bool pfIsFinal
            );
    }

#endif

}
