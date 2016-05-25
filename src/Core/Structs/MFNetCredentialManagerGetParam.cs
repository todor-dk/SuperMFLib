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

namespace MediaFoundation.Core.Structs
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Contains the authentication information for the credential manager.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _MFNetCredentialManagerGetParam {
    ///   HRESULT hrOp;
    ///   BOOL    fAllowLoggedOnUser;
    ///   BOOL    fClearTextPackage;
    ///   LPCWSTR pszUrl;
    ///   LPCWSTR pszSite;
    ///   LPCWSTR pszRealm;
    ///   LPCWSTR pszPackage;
    ///   LONG    nRetries;
    /// } MFNetCredentialManagerGetParam;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/951D74DF-11F8-4623-A81B-63E632F80D0E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/951D74DF-11F8-4623-A81B-63E632F80D0E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("MFNetCredentialManagerGetParam")]
    internal struct MFNetCredentialManagerGetParam
    {
        /// <summary>
        /// The response code of the authentication challenge. For example, NS_E_PROXY_ACCESSDENIED.
        /// </summary>
        [MarshalAs(UnmanagedType.Error)]
        public int hrOp;
        /// <summary>
        /// Set this flag to <strong>TRUE</strong> if the currently logged on user's credentials should be used
        /// as the default credentials.
        /// </summary>
        public int fAllowLoggedOnUser;
        /// <summary>
        /// If <strong>TRUE</strong>, the authentication package will send unencrypted credentials over the
        /// network. Otherwise, the authentication package encrypts the credentials.
        /// </summary>
        public int fClearTextPackage;
        /// <summary>
        /// The original URL that requires authentication.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszUrl;
        /// <summary>
        /// The name of the site or proxy that requires authentication.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszSite;
        /// <summary>
        /// The name of the realm for this authentication.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszRealm;
        /// <summary>
        /// The name of the authentication package. For example, "Digest" or "MBS_BASIC".
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pszPackage;
        /// <summary>
        /// The number of times that the credential manager should retry after authentication fails.
        /// </summary>
        public int nRetries;
    }

#endif

}
