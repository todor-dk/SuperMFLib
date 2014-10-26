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

namespace MediaFoundation.Misc
{

    /// <summary>
    /// This enumeration contains options for the <see cref="VideoInfoHeader2.InterlaceFlags"/> field.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/5E3D5BF0-435F-45DA-8409-A1463B56A7AE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5E3D5BF0-435F-45DA-8409-A1463B56A7AE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("AMINTERLACE_*"), Flags]
    public enum AMInterlace
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// The stream is interlaced. If this flag is absent, the video is progressive and the other bits are irrelevant.
        /// </summary>
        IsInterlaced = 0x00000001,
        /// <summary>
        /// Each media sample contains one field. If this flag is absent, each media sample contains two fields.
        /// </summary>
        OneFieldPerSample = 0x00000002,
        /// <summary>
        /// Field 1 is first. If this flag is absent, field 2 is first. 
        /// (The top field in PAL is field 1, and the top field in NTSC is field 2.)
        /// </summary>
        Field1First = 0x00000004,
        /// <summary>
        /// Not Used.
        /// </summary>
        Unused = 0x00000008,
        /// <summary>
        /// Mask for the <see cref="FieldPatField1Only"/>, <see cref="FieldPatField2Only"/>,
        /// <see cref="FieldPatBothRegular"/> and <see cref="FieldPatBothIrregular"/> flags.
        /// </summary>
        FieldPatternMask = 0x00000030,
        /// <summary>
        /// The stream never contains a field 2.
        /// </summary>
        FieldPatField1Only = 0x00000000,
        /// <summary>
        /// The stream never contains a field 1.
        /// </summary>
        FieldPatField2Only = 0x00000010,
        /// <summary>
        /// There is one field 2 for every field 1.
        /// </summary>
        FieldPatBothRegular = 0x00000020,
        /// <summary>
        /// The stream contains an irregular pattern of field 1 and field 2.
        /// </summary>
        FieldPatBothIrregular = 0x00000030,
        /// <summary>
        /// Mask for the <see cref="DisplayModeBobOnly"/>, <see cref="DisplayModeWeaveOnly"/> 
        /// and <see cref="DisplayModeBobOrWeave"/> flags.
        /// </summary>
        DisplayModeMask = 0x000000c0,
        /// <summary>
        /// Bob display mode only.
        /// </summary>
        DisplayModeBobOnly = 0x00000000,
        /// <summary>
        /// Weave display mode only.
        /// </summary>
        DisplayModeWeaveOnly = 0x00000040,
        /// <summary>
        /// Either bob or weave mode.
        /// </summary>
        DisplayModeBobOrWeave = 0x00000080,
    }

}
