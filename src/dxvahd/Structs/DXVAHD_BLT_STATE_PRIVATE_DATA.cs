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
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation.dxvahd
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Contains data for a private blit state for Microsoft DirectX Video Acceleration High Definition
    /// (DXVA-HD).
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct _DXVAHD_BLT_STATE_PRIVATE_DATA {
    ///   GUID Guid;
    ///   UINT DataSize;
    ///   void *pData;
    /// } DXVAHD_BLT_STATE_PRIVATE_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/B85D4429-9346-4C85-8C3D-EFFFE0C1E63A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B85D4429-9346-4C85-8C3D-EFFFE0C1E63A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_BLT_STATE_PRIVATE_DATA")]
    public struct DXVAHD_BLT_STATE_PRIVATE_DATA
    {
        /// <summary>
        /// A GUID that identifies the private state. The meaning of this value is defined by the device.
        /// </summary>
        public Guid Guid;
        /// <summary>
        /// The size, in bytes, of the buffer pointed to by the <strong>pData</strong> member.
        /// </summary>
        public int DataSize;
        /// <summary>
        /// A pointer to a buffer that contains the private state data. The DXVA-HD runtime passes this buffer
        /// directly to the device without validation.
        /// </summary>
        public IntPtr pData;
    }

#endif

}
