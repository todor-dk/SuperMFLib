﻿#region license

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

namespace MediaFoundation
{
#if ALLOW_UNTESTED_INTERFACES

    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("AA9DD80F-C50A-4220-91C1-332287F82A34"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPlayToControlWithCapabilities : IPlayToControl
    {
        #region IPlayToControl methods

        [PreserveSig]
        new int Connect(
            IMFSharingEngineClassFactory pFactory
            );

        [PreserveSig]
        new int Disconnect();

        #endregion

        [PreserveSig]
        int GetCapabilities(
            out PLAYTO_SOURCE_CREATEFLAGS pCapabilities
            );
    }

#endif
}
