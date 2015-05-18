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

    /// <summary>
    /// Indicates whether the URL is from a trusted source.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FD008A23-71F7-4718-A51A-EE88453B6FDD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FD008A23-71F7-4718-A51A-EE88453B6FDD(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_URL_TRUST_STATUS")]
    internal enum MFURLTrustStatus
    {
        /// <summary>
        /// The validity of the URL cannot be guaranteed because it is not signed. The application should warn
        /// the user.
        /// </summary>
        Untrusted,
        /// <summary>
        /// The URL is the original one provided with the content.
        /// </summary>
        Trusted,
        /// <summary>
        /// The URL was originally signed and has been tampered with. The file should be considered corrupted,
        /// and the application should not navigate to the URL without issuing a strong warning the user.
        /// </summary>
        Tampered
    }

}
