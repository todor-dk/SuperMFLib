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

// This file is a mess.  While technically part of MF, I'm in no hurry 
// to try to get this to work.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace MediaFoundation.OPM
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Contains the key selection vector (KSV) for a High-Bandwidth Digital Content Protection (HDCP)
    /// receiver.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _OPM_HDCP_KEY_SELECTION_VECTOR {
    ///   BYTE abKeySelectionVector[OPM_HDCP_KEY_SELECTION_VECTOR_SIZE];
    /// } OPM_HDCP_KEY_SELECTION_VECTOR;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/79C0E5E5-62EF-4B8A-9E3B-3A9482731B16(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/79C0E5E5-62EF-4B8A-9E3B-3A9482731B16(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public struct OPM_HDCP_KEY_SELECTION_VECTOR
    {
        /// <summary>
        /// A buffer that contains the device's KSV. (This is the value named <em>Bksv</em> in the HDCP
        /// specification.)
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public byte[] abKeySelectionVector;
    }

#endif

}
