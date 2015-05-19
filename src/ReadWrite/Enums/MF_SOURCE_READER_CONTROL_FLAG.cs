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
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation.ReadWrite
{
    /// <summary>
    /// Contains flags for the <see cref="ReadWrite.IMFSourceReader.ReadSample"/> method. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A6367FEA-CEBA-4CE4-9A1B-88A40AFC3055(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A6367FEA-CEBA-4CE4-9A1B-88A40AFC3055(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_SOURCE_READER_CONTROL_FLAG")]
    public enum MF_SOURCE_READER_CONTROL_FLAG
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// Retrieve any pending samples, but do not request any more samples from the media source. To get all
        /// of the pending samples, call <c>ReadSample</c> with this flag until the method returns a <strong>
        /// NULL</strong> media sample pointer. 
        /// </summary>
        Drain = 0x00000001
    }
}
