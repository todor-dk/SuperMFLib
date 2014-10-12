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

using MediaFoundation;
using MediaFoundation.Misc;
using MediaFoundation.Transform;
using System.Drawing;

namespace MediaFoundation.EVR
{

#if ALLOW_UNTESTED_INTERFACES


    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("8459616D-966E-4930-B658-54FA7E5A16D3")]
    public interface IMFVideoMixerControl2 : IMFVideoMixerControl
    {
        #region IMFVideoMixerControl methods

        [PreserveSig]
        new int SetStreamZOrder(
            [In] int dwStreamID,
            [In] int dwZ
            );

        [PreserveSig]
        new int GetStreamZOrder(
            [In] int dwStreamID,
            out int pdwZ
            );

        [PreserveSig]
        new int SetStreamOutputRect(
            [In] int dwStreamID,
            [In] MFVideoNormalizedRect pnrcOutput
            );

        [PreserveSig]
        new int GetStreamOutputRect(
            [In] int dwStreamID,
            [Out, MarshalAs(UnmanagedType.LPStruct)] MFVideoNormalizedRect pnrcOutput
            );

        #endregion

        [PreserveSig]
        int SetMixingPrefs(
            [In] MFVideoMixPrefs dwMixFlags
        );

        [PreserveSig]
        int GetMixingPrefs(
            out MFVideoMixPrefs pdwMixFlags
        );
    }

#endif

}
