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

    /// <summary>
    /// Contains flags that define the behavior of the <see cref="MFExtern.MFCreatePMPMediaSession"/>
    /// function. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/6341AAFF-AA80-4172-8577-0B757A01EA53(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6341AAFF-AA80-4172-8577-0B757A01EA53(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MFPMPSESSION_CREATION_FLAGS")]
    public enum MFPMPSessionCreationFlags
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// If this flag is set, the Protected Media Path (PMP) Media Session is created in an unprotected
        /// process. You can use the unprotected process to play clear content but not protected content. If
        /// this flag is not set, the PMP Media Session is created in a protected process. In that case, the
        /// protected process is used for both protected content and clear content.
        /// </summary>
        UnprotectedProcess = 0x1
    }

}
