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
using System.Runtime.InteropServices;

using MediaFoundation.Misc;

namespace MediaFoundation.Transform
{


    /// <summary>
    /// Contains media type information for registering a Media Foundation transform (MFT). 
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct _MFT_REGISTER_TYPE_INFO {
    ///   GUID guidMajorType;
    ///   GUID guidSubtype;
    /// } MFT_REGISTER_TYPE_INFO;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/1D26B9EE-545A-4E47-9A68-B9E567F0DEC4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1D26B9EE-545A-4E47-9A68-B9E567F0DEC4(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("MFT_REGISTER_TYPE_INFO")]
    public class MFTRegisterTypeInfo
    {
        /// <summary>
        /// The major media type. For a list of possible values, see <c>Major Media Types</c>. 
        /// </summary>
        public Guid guidMajorType;
        /// <summary>
        /// The media subtype. For a list of possible values, see the following topics:
        /// <para/>
        /// <para>* <c>Audio Subtype GUIDs</c></para><para>* <c>Video Subtype GUIDs</c></para>
        /// </summary>
        public Guid guidSubtype;
    }

}
