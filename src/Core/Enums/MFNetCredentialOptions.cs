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

namespace MediaFoundation.Core.Enums
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Describes options for the caching network credentials.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/5EE4F46C-762C-4ACF-86FF-DA7A93B5DE05(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5EE4F46C-762C-4ACF-86FF-DA7A93B5DE05(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MFNetCredentialOptions")]
    internal enum MFNetCredentialOptions
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// Allow the credential cache object to save  credentials in persistant storage.
        /// </summary>
        Save = 0x00000001,
        /// <summary>
        /// Do not allow the credential cache object to cache the credentials in memory. This flag cannot be
        /// combined with the MFNET_CREDENTIAL_SAVE flag.
        /// </summary>
        DontCache = 0x00000002,
        /// <summary>
        /// The user allows credentials to be sent over the network in clear text.
        /// <para/>
        /// By default, <see cref="IMFNetCredentialCache.GetCredential"/> always returns the REQUIRE_PROMPT
        /// flag when the authentication flags include MFNET_AUTHENTICATION_CLEAR_TEXT, even if cached
        /// credentials are available. If you set the MFNET_CREDENTIAL_ALLOW_CLEAR_TEXT option, the <strong>
        /// GetCredential</strong> method will not return REQUIRE_PROMPT for clear text, if cached credentials
        /// are available. 
        /// <para/>
        /// Do not set this flag without notifying the user that credentials might be sent in clear text.
        /// </summary>
        AllowClearText = 0x00000004,
    }

#endif

}
