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
    /// Specifies the buffering requirements of a file.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _MF_LEAKY_BUCKET_PAIR {
    ///   DWORD dwBitrate;
    ///   DWORD msBufferWindow;
    /// } MF_LEAKY_BUCKET_PAIR;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/AA95A8F0-2F4C-4D7E-81C3-8A14A6FFA54E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AA95A8F0-2F4C-4D7E-81C3-8A14A6FFA54E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 4), UnmanagedName("MF_LEAKY_BUCKET_PAIR")]
    internal struct MF_LeakyBucketPair
    {
        /// <summary>
        /// Bit rate, in bits per second.
        /// </summary>
        public int dwBitrate;
        /// <summary>
        /// Size of the buffer window, in milliseconds.
        /// </summary>
        public int msBufferWindow;
    }

#endif

}
