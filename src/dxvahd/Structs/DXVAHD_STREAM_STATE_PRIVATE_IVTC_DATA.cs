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
    /// Contains inverse telecine (IVTC) statistics from a Microsoft DirectX Video Acceleration High
    /// Definition (DXVA-HD) device.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_STREAM_STATE_PRIVATE_IVTC_DATA {
    ///   BOOL Enable;
    ///   UINT ITelecineFlags;
    ///   UINT Frames;
    ///   UINT InputField;
    /// } DXVAHD_STREAM_STATE_PRIVATE_IVTC_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/166FC57E-3B49-44C1-8C6C-691950E7B675(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/166FC57E-3B49-44C1-8C6C-691950E7B675(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_STREAM_STATE_PRIVATE_IVTC_DATA")]
    public struct DXVAHD_STREAM_STATE_PRIVATE_IVTC_DATA
    {
        /// <summary>
        /// Specifies whether IVTC statistics are enabled. The default state value is <strong>FALSE</strong>.
        /// Setting the value to <strong>TRUE</strong> enables IVTC statistics, and resets all of the IVTC
        /// statistical data to zero. 
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool Enable;
        /// <summary>
        /// If the driver detects that the frames are telecined, and is able to perform inverse telecine, this
        /// field contains a member of the <see cref="dxvahd.DXVAHD_ITELECINE_CAPS"/> enumeration. Otherwise,
        /// the value is 0. 
        /// </summary>
        public int ITelecineFlags;
        /// <summary>
        /// The number of consecutive telecined frames that the device has detected.
        /// </summary>
        public int Frames;
        /// <summary>
        /// The index of the most recent input field. The value of this member equals the most recent value of
        /// the <strong>InputFrameOrField</strong> member of the <see cref="dxvahd.DXVAHD_STREAM_DATA"/>
        /// structure. 
        /// </summary>
        public int InputField;
    }

#endif

}
