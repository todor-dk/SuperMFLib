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
    /// Specifies a custom rate for frame-rate conversion or inverse telecine (IVTC).
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_CUSTOM_RATE_DATA {
    ///   DXVAHD_RATIONAL CustomRate;
    ///   UINT            OutputFrames;
    ///   BOOL            InputInterlaced;
    ///   UINT            InputFramesOrFields;
    /// } DXVAHD_CUSTOM_RATE_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/12CAC4A8-CFDF-484C-8443-EF47DD3A152B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/12CAC4A8-CFDF-484C-8443-EF47DD3A152B(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_CUSTOM_RATE_DATA")]
    internal struct DXVAHD_CUSTOM_RATE_DATA
    {
        /// <summary>
        /// The ratio of the output frame rate to the input frame rate, expressed as a
        /// <see cref="dxvahd.DXVAHD_RATIONAL" /> structure that holds a rational number.
        /// </summary>
        public DXVAHD_RATIONAL CustomRate;
        /// <summary>
        /// The number of output frames that will be generated for every <em>N</em> input samples, where <em>N
        /// </em> = <strong>InputFramesOrFields</strong>.
        /// </summary>
        public int OutputFrames;
        /// <summary>
        /// If <strong>TRUE</strong>, the input stream must be interlaced <strong></strong>. Otherwise, the
        /// input stream must be progressive.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool InputInterlaced;
        /// <summary>
        /// The number of input fields or frames for every <em>N</em> output frames that will be generated,
        /// where <em>N</em> = <strong>OutputFrames</strong>.
        /// </summary>
        public int InputFramesOrFields;
    }

#endif

}
