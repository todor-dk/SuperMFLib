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
    Guid("e467b94e-a713-4562-a802-816a42e9008a"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaSourceExtension
    {
        [PreserveSig]
        IMFSourceBufferList GetSourceBuffers();

        [PreserveSig]
        IMFSourceBufferList GetActiveSourceBuffers();

        [PreserveSig]
        MF_MSE_READY GetReadyState();

        [PreserveSig]
        double GetDuration();

        [PreserveSig]
        int SetDuration(
            double duration
            );

        [PreserveSig]
        int AddSourceBuffer(
            [MarshalAs(UnmanagedType.BStr)] string type,
            IMFSourceBufferNotify pNotify,
            out IMFSourceBuffer ppSourceBuffer
            );

        [PreserveSig]
        int RemoveSourceBuffer(
            IMFSourceBuffer pSourceBuffer
            );

        [PreserveSig]
        int SetEndOfStream(
            MF_MSE_ERROR error
            );

        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsTypeSupported(
            [MarshalAs(UnmanagedType.BStr)] string type
            );

        [PreserveSig]
        IMFSourceBuffer GetSourceBuffer(
            int dwStreamIndex
            );
    }

#endif
}