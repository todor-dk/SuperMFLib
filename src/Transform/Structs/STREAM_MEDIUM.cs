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

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Not for application use.
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct _STREAM_MEDIUM {
    ///   GUID   gidMedium;
    ///   UINT32 unMediumInstance;
    /// } STREAM_MEDIUM, *PSTREAM_MEDIUM;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/C3E3FD40-F6E6-4E43-927F-5DFF4169A52C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C3E3FD40-F6E6-4E43-927F-5DFF4169A52C(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("STREAM_MEDIUM")]
    public struct STREAM_MEDIUM
    {
        /// <summary>
        /// Reserved.
        /// </summary>
        Guid gidMedium;
        /// <summary>
        /// Reserved.
        /// </summary>
        int unMediumInstance;
    }

#endif

}
