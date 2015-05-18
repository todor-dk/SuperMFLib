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

namespace MediaFoundation.dxvahd.Structs
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Contains data for a private stream state, for  a Microsoft DirectX Video Acceleration High
    /// Definition (DXVA-HD) input stream. 
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_STREAM_STATE_PRIVATE_DATA {
    ///   GUID Guid;
    ///   UINT DataSize;
    ///   void *pData;
    /// } DXVAHD_STREAM_STATE_PRIVATE_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/3B7CE487-EDEC-4FF2-B971-72DDCC28162C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3B7CE487-EDEC-4FF2-B971-72DDCC28162C(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_STREAM_STATE_PRIVATE_DATA")]
    internal struct DXVAHD_STREAM_STATE_PRIVATE_DATA
    {
        /// <summary>
        /// A GUID that identifies the private stream state. The following GUID is defined.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>DXVAHD_STREAM_STATE_PRIVATE_IVTC</strong></term><description>Retrieves statistics about inverse telecine. The state data ( <strong>pData</strong>) is a <see cref="dxvahd.DXVAHD_STREAM_STATE_PRIVATE_IVTC_DATA"/> structure. </description></item>
        /// </list>
        /// <para/>
        /// A device can define additional GUIDs for use with custom stream states. The interpretation of the
        /// data is then defined by the device.
        /// </summary>
        public Guid Guid;
        /// <summary>
        /// The size, in bytes, of the buffer pointed to by the <strong>pData</strong> member. 
        /// </summary>
        public int DataSize;
        /// <summary>
        /// A pointer to a buffer that contains the private state data. The DXVA-HD runtime passes this buffer
        /// directly to the device, without validation.
        /// </summary>
        public IntPtr pData;
    }

#endif

}
