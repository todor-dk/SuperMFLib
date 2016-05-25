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
    /// Contains parameters for the <see cref="IMFInputTrustAuthority.BindAccess" /> or
    /// <see cref="IMFInputTrustAuthority.UpdateAccess" /> method.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS {
    ///   DWORD                               dwSize;
    ///   DWORD                               dwVer;
    ///   DWORD                               cbSignatureOffset;
    ///   DWORD                               cbSignatureSize;
    ///   DWORD                               cbExtensionOffset;
    ///   DWORD                               cbExtensionSize;
    ///   DWORD                               cActions;
    ///   MFINPUTTRUSTAUTHORITY_ACCESS_ACTION rgOutputActions[1];
    /// } MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/5FF3EC3A-A7B1-4378-8E8B-D59A6F5BB28D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5FF3EC3A-A7B1-4378-8E8B-D59A6F5BB28D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 4), UnmanagedName("MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS")]
    internal struct MFInputTrustAuthorityAccessParams
    {
        /// <summary>
        /// Size of the structure, in bytes.
        /// </summary>
        public int dwSize;
        /// <summary>
        /// Version number. This value must be zero.
        /// </summary>
        public int dwVer;
        /// <summary>
        /// Offset of the signature from the start of the structure, in bytes.
        /// </summary>
        public int cbSignatureOffset;
        /// <summary>
        /// Size of the signature, in bytes.
        /// </summary>
        public int cbSignatureSize;
        /// <summary>
        /// Offset of the extension blob from the start of the structure, in bytes.
        /// </summary>
        public int cbExtensionOffset;
        /// <summary>
        /// Size of the extension blob, in bytes.
        /// </summary>
        public int cbExtensionSize;
        /// <summary>
        /// Number of elements in the <strong>rgOutputActions</strong> array.
        /// </summary>
        public int cActions;
        /// <summary>
        /// Array of <c>MFINPUTTRUSTAUTHORITY_ACCESS_ACTION</c> structures. The number of elements in the array
        /// is specified in the <strong>cActions</strong> member.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public MFInputTrustAuthorityAction[] rgOutputActions;
    }

#endif

}
