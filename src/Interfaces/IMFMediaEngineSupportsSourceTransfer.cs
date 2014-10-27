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
    Guid("a724b056-1b2e-4642-a6f3-db9420c52908"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaEngineSupportsSourceTransfer
    {
        [PreserveSig]
        int ShouldTransferSource(
          [MarshalAs(UnmanagedType.Bool)] out bool pfShouldTransfer
          );

        [PreserveSig]
        int DetachMediaSource(
            out IMFByteStream ppByteStream,
            out IMFMediaSource ppMediaSource,
            out IMFMediaSourceExtension ppMSE
            );

        [PreserveSig]
        int AttachMediaSource(
            IMFByteStream pByteStream,
            IMFMediaSource pMediaSource,
            IMFMediaSourceExtension pMSE
            );
    }

#endif
}