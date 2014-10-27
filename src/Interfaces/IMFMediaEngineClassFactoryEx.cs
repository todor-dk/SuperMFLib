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

using MediaFoundation.Misc;
using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation
{
#if ALLOW_UNTESTED_INTERFACES

    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("c56156c6-ea5b-48a5-9df8-fbe035d0929e"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaEngineClassFactoryEx : IMFMediaEngineClassFactory
    {
        #region IMFMediaEngineClassFactory methods

        [PreserveSig]
        new int CreateInstance(
            MF_MEDIA_ENGINE_CREATEFLAGS dwFlags,
            IMFAttributes pAttr,
            out IMFMediaEngine ppPlayer
            );

        [PreserveSig]
        new int CreateTimeRange(
            out IMFMediaTimeRange ppTimeRange
            );

        [PreserveSig]
        new int CreateError(
            out IMFMediaError ppError
            );

        #endregion

        [PreserveSig]
        int CreateMediaSourceExtension(
            int dwFlags,
            IMFAttributes pAttr,
            out IMFMediaSourceExtension ppMSE
            );

        [PreserveSig]
        int CreateMediaKeys(
            [MarshalAs(UnmanagedType.BStr)] string keySystem,
            [MarshalAs(UnmanagedType.BStr)] string cdmStorePath,
            out IMFMediaKeys ppKeys
            );

        [PreserveSig]
        int IsTypeSupported(
            [MarshalAs(UnmanagedType.BStr)] string type,
            [MarshalAs(UnmanagedType.BStr)] string keySystem,
            [MarshalAs(UnmanagedType.Bool)] out bool isSupported
            );
    }

#endif
}