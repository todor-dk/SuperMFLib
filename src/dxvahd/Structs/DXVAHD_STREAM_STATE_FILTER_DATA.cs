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
    /// Specifies the level for a filtering operation on a Microsoft DirectX Video Acceleration High
    /// Definition (DXVA-HD) input stream.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_STREAM_STATE_FILTER_DATA {
    ///   BOOL Enable;
    ///   INT  Level;
    /// } DXVAHD_STREAM_STATE_FILTER_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/2F70222D-F87A-49A5-8DA5-15DFA2807CD7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2F70222D-F87A-49A5-8DA5-15DFA2807CD7(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_STREAM_STATE_FILTER_DATA")]
    public struct DXVAHD_STREAM_STATE_FILTER_DATA
    {
        /// <summary>
        /// <strong>If TRUE</strong>, the filter is enabled. Otherwise, <strong>the filter is disabled</strong>. 
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool Enable;
        /// <summary>
        /// The level for the filter. The meaning of this value depends on the implementation. To get the range
        /// and default value of a particular filter, call the 
        /// <see cref="dxvahd.IDXVAHD_Device.GetVideoProcessorFilterRange"/> method. 
        /// <para/>
        /// If the <strong>Enable</strong> member is <strong>FALSE</strong>, the <strong>Level</strong> member
        /// is ignored. 
        /// </summary>
        public int Level;
    }

#endif

}
