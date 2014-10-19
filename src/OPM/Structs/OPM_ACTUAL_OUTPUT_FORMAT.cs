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

// This file is a mess.  While technically part of MF, I'm in no hurry 
// to try to get this to work.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace MediaFoundation.OPM
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Contains the result of an <see cref="OPM.MFOpmStatusRequests.OPM_GET_ACTUAL_OUTPUT_FORMAT" /> query
    /// in <c>Output Protection Manager</c> (OPM).
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct _OPM_ACTUAL_OUTPUT_FORMAT {
    ///   OPM_RANDOM_NUMBER  rnRandomNumber;
    ///   ULONG              ulStatusFlags;
    ///   ULONG              ulDisplayWidth;
    ///   ULONG              ulDisplayHeight;
    ///   DXVA2_SampleFormat dsfSampleInterleaveFormat;
    ///   D3DFORMAT          d3dFormat;
    ///   ULONG              ulFrequencyNumerator;
    ///   ULONG              ulFrequencyDenominator;
    /// } OPM_ACTUAL_OUTPUT_FORMAT;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/0B20CDCD-3D03-4DA3-B81C-B5025DCB04C3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0B20CDCD-3D03-4DA3-B81C-B5025DCB04C3(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public struct OPM_ACTUAL_OUTPUT_FORMAT
    {
        /// <summary>
        /// An <see cref="OPM.OPM_RANDOM_NUMBER" /> structure. This structure contains the same 128-bit random
        /// number that the application sent to the driver in the <see cref="OPM.OPM_GET_INFO_PARAMETERS" /> or
        /// <see cref="OPM.OPM_COPP_COMPATIBLE_GET_INFO_PARAMETERS" /> structure.
        /// </summary>
        public OPM_RANDOM_NUMBER rnRandomNumber;
        /// <summary>
        /// A bitwise <strong>OR</strong> of <c>OPM Status Flags</c>.
        /// </summary>
        public int ulStatusFlags;
        /// <summary>
        /// The width of the display mode, in pixels.
        /// </summary>
        public int ulDisplayWidth;
        /// <summary>
        /// The height of the display mode, in pixels.
        /// </summary>
        public int ulDisplayHeight;
        /// <summary>
        /// A <c>DXVA2_SampleFormat</c> value that describes the interlace mode.
        /// </summary>
        public int dsfSampleInterleaveFormat; // DXVA2_SampleFormat
        /// <summary>
        /// A <strong>D3DFORMAT</strong> value that describes the video format.
        /// </summary>
        public int d3dFormat; // D3DFORMAT
        /// <summary>
        /// The numerator of the refresh rate of the current display mode.
        /// </summary>
        public int ulFrequencyNumerator;
        /// <summary>
        /// The denominator of the refresh rate of the current display mode.
        /// </summary>
        public int ulFrequencyDenominator;
    }

#endif

}
