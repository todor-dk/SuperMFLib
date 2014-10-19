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
using System.Runtime.InteropServices.ComTypes;
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

using MediaFoundation.EVR;

namespace MediaFoundation.MFPlayer
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
    /// Applications should use the <c>Media Session</c> for playback. 
    /// <para/>
    /// Callback interface for the <see cref="MFPlayer.IMFPMediaPlayer"/> interface. 
    /// <para/>
    /// To set the callback, pass an <strong>IMFPMediaPlayerCallback</strong> pointer to the 
    /// <see cref="MFExtern.MFPCreateMediaPlayer"/> function in the <em>pCallback</em> parameter. The
    /// application implements the <strong>IMFPMediaPlayerCallback</strong> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/7D9D01BF-861A-4C35-93B1-DBF85CBF0A32(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7D9D01BF-861A-4C35-93B1-DBF85CBF0A32(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("766C8FFB-5FDB-4fea-A28D-B912996F51BD")]
    public interface IMFPMediaPlayerCallback
    {
        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Called by the MFPlay player object to notify the application of a playback event.
        /// </summary>
        /// <param name="pEventHeader">
        /// Pointer to an <see cref="MFPlayer.MFP_EVENT_HEADER"/> structure that contains information about the
        /// event. 
        /// </param>
        /// <returns>
        /// This method does not return a value.
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// void OnMediaPlayerEvent(
        ///   [in]  MFP_EVENT_HEADER *pEventHeader
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2A80A9D0-83EE-4BB0-AB2C-0F68367F3BF8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2A80A9D0-83EE-4BB0-AB2C-0F68367F3BF8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int OnMediaPlayerEvent(
            [In, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(EHMarshaler))] MFP_EVENT_HEADER pEventHeader
            );
    }

#endif

}
