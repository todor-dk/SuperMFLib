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
    /// Specifies how the credential manager should obtain user credentials. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/9257D1D7-7CCB-4172-82F0-3694EBB9D487(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9257D1D7-7CCB-4172-82F0-3694EBB9D487(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFNetCredentialRequirements")]
    internal enum MFNetCredentialRequirements
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// The credential manager should prompt the user to provide the credentials. 
        /// </summary>
        RequirePrompt = 0x00000001,
        /// <summary>
        /// <strong>Note</strong> Requires Windows 7 or later. 
        /// <para/>
        /// The credentials are saved to persistent storage. This flag acts as a hint for the application's UI.
        /// If the application prompts the user for credentials, the UI can indicate that the credentials have
        /// already been saved.
        /// </summary>
        RequireSaveSelected = 0x00000002
    }

#endif

}
