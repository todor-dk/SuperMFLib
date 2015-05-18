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

namespace MediaFoundation.dxvahd.Enums
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Specifies how the output alpha values are calculated for Microsoft DirectX Video Acceleration High
    /// Definition (DXVA-HD) blit operations.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/F5E9F37E-5600-4139-86B2-7F63C2981B69(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F5E9F37E-5600-4139-86B2-7F63C2981B69(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("DXVAHD_ALPHA_FILL_MODE")]
    internal enum DXVAHD_ALPHA_FILL_MODE
    {
        /// <summary>
        /// Alpha values inside the target rectangle are set to opaque.
        /// </summary>
        Opaque = 0,
        /// <summary>
        /// Alpha values inside the target rectangle are set to the alpha value specified in the background
        /// color. See <see cref="dxvahd.DXVAHD_BLT_STATE.BackgroundColor"/>. 
        /// </summary>
        Background = 1,
        /// <summary>
        /// Existing alpha values remain unchanged in the output surface.
        /// </summary>
        Destination = 2,
        /// <summary>
        /// Alpha values from the input stream  are scaled and copied to the corresponding destination
        /// rectangle for that stream. If the input stream does not have alpha data, the DXVA-HD device sets
        /// the alpha values in the target rectangle to an opaque value. If the input stream is disabled or the
        /// source rectangle is empty, the alpha values in the target rectangle are not modified.
        /// </summary>
        SourceStream = 3
    }

#endif

}
