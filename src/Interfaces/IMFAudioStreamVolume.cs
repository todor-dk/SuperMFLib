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

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("76B1BBDB-4EC8-4F36-B106-70A9316DF593")]
    public interface IMFAudioStreamVolume
    {
        [PreserveSig]
        int GetChannelCount(
            out int pdwCount
            );

        [PreserveSig]
        int SetChannelVolume(
            [In] int dwIndex,
            [In] float fLevel
            );

        [PreserveSig]
        int GetChannelVolume(
            [In] int dwIndex,
            out float pfLevel
            );

        [PreserveSig]
        int SetAllVolumes(
            [In] int dwCount,
            [In] ref float pfVolumes
            );

        [PreserveSig]
        int GetAllVolumes(
            [In] int dwCount,
            out float pfVolumes
            );
    }

#endif

}
