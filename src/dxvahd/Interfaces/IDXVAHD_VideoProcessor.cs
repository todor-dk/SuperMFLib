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


    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("95f4edf4-6e03-4cd7-be1b-3075d665aa52"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXVAHD_VideoProcessor
    {
        [PreserveSig]
        int SetVideoProcessBltState(
            DXVAHD_BLT_STATE State,
            int DataSize,
            IntPtr pData
            );

        [PreserveSig]
        int GetVideoProcessBltState(
            DXVAHD_BLT_STATE State,
            int DataSize,
            IntPtr pData
            );

        [PreserveSig]
        int SetVideoProcessStreamState(
            int StreamNumber,
            DXVAHD_STREAM_STATE State,
            int DataSize,
            IntPtr pData
            );

        [PreserveSig]
        int GetVideoProcessStreamState(
            int StreamNumber,
            DXVAHD_STREAM_STATE State,
            int DataSize,
            IntPtr pData
            );

        [PreserveSig]
        int VideoProcessBltHD(
            IDirect3DSurface9 pOutputSurface,
            int OutputFrame,
            int StreamCount,
            DXVAHD_STREAM_DATA[] pStreams
            );
    }

#endif

}
