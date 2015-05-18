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

using MediaFoundation.Misc;
using MediaFoundation;
using System.Drawing;

namespace MediaFoundation.Core.Classes
{
    #if NOT_IN_USE
    /// <summary>
    /// Guid constants used with the <see cref="IMFMediaType.GetRepresentation"/> method.
    /// </summary>
    public static class MFRepresentation
    {
        // AM_MEDIA_TYPE_REPRESENTATION 
        /// <summary>
        /// Convert the media type to a DirectShow AM_MEDIA_TYPE structure. 
        /// The method selects the most appropriate format structure (pbFormat). 
        /// </summary>
        public static readonly Guid AMMediaType = new Guid(0xe2e42ad2, 0x132c, 0x491e, 0xa2, 0x68, 0x3c, 0x7c, 0x2d, 0xca, 0x18, 0x1f);
        
        // FORMAT_MFVideoFormat
        /// <summary>
        /// Convert the media type to a DirectShow AM_MEDIA_TYPE structure with an MFVIDEOFORMAT format structure. 
        /// </summary>
        public static readonly Guid MFVideoFormat = new Guid(0xaed4ab2d, 0x7326, 0x43cb, 0x94, 0x64, 0xc8, 0x79, 0xca, 0xb9, 0xc4, 0x3d);
        // FORMAT_VideoInfo 
        /// <summary>
        /// Convert the media type to a DirectShow AM_MEDIA_TYPE structure with a VIDEOINFOHEADER format structure. 
        /// </summary>
        public static readonly Guid VideoInfo = new Guid(0x05589f80, 0xc356, 0x11ce, 0xbf, 0x01, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a);
        // FORMAT_VideoInfo2 
        /// <summary>
        /// Convert the media type to a DirectShow AM_MEDIA_TYPE structure with a VIDEOINFOHEADER2 format structure. 
        /// </summary>
        public static readonly Guid VideoInfo2 = new Guid(0xf72a76A0, 0xeb0a, 0x11d0, 0xac, 0xe4, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba);

    }
#endif
}
