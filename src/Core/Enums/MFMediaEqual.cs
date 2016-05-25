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

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation
{
    /// <summary>
    /// Flags used in conjunction with the <see cref="IMFMediaType.IsEqual"/> method.
    /// </summary>
    /// <remarks>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/42B5B0E8-3B13-4BDA-A53C-0428A3C9B131(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/42B5B0E8-3B13-4BDA-A53C-0428A3C9B131(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags]
    [UnmanagedName("MF_MEDIATYPE_EQUAL_* defines")]
    public enum MFMediaEqual
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,

        /// <summary>
        /// The major types are the same. The major type is specified by the <see cref="MFAttributesClsid.MF_MT_MAJOR_TYPE"/> attribute.
        /// </summary>
        MajorTypes = 0x00000001,

        /// <summary>
        /// The subtypes are the same, or neither media type has a subtype. The subtype is specified by the <see cref="MFAttributesClsid.MF_MT_SUBTYPE"/> attribute.
        /// </summary>
        FormatTypes = 0x00000002,

        /// <summary>
        /// The attributes in one of the media types are a subset of the attributes in the other,
        /// and the values of these attributes match, excluding the value of the <see cref="MFAttributesClsid.MF_MT_USER_DATA"/>
        /// attribute.
        /// <para/>
        /// Specifically, the method takes the media type with the smaller number of attributes and checks whether each
        /// attribute from that type is present in the other media type and has the same value (not including
        /// <see cref="MFAttributesClsid.MF_MT_USER_DATA"/>, <see cref="MFAttributesClsid.MF_MT_FRAME_RATE_RANGE_MIN"/>,
        /// and <see cref="MFAttributesClsid.MF_MT_FRAME_RATE_RANGE_MAX"/>).
        /// <para/>
        /// To perform other comparisons, use the <see cref="IMFAttributes.Compare"/> method.
        /// For example, the <strong>Compare</strong> method can test for identical attributes,
        /// or test the intersection of the two attribute sets. For more information,
        /// see <see cref="MFAttributesMatchType"/>.
        /// </summary>
        FormatData = 0x00000004,

        /// <summary>
        /// The user data is identical, or neither media type contains user data.
        /// User data is specified by the <see cref="MFAttributesClsid.MF_MT_USER_DATA"/> attribute.
        /// </summary>
        FormatUserData = 0x00000008
    }
}
