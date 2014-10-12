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
    Guid("CA86AA50-C46E-429E-AB27-16D6AC6844CB")]
    public interface IMFSampleGrabberSinkCallback2 : IMFSampleGrabberSinkCallback
    {
        #region IMFClockStateSink methods

        [PreserveSig]
        new int OnClockStart(
            [In] long hnsSystemTime,
            [In] long llClockStartOffset
            );

        [PreserveSig]
        new int OnClockStop(
            [In] long hnsSystemTime
            );

        [PreserveSig]
        new int OnClockPause(
            [In] long hnsSystemTime
            );

        [PreserveSig]
        new int OnClockRestart(
            [In] long hnsSystemTime
            );

        [PreserveSig]
        new int OnClockSetRate(
            [In] long hnsSystemTime,
            [In] float flRate
            );

        #endregion

        #region IMFSampleGrabberSinkCallback methods

        [PreserveSig]
        new int OnSetPresentationClock(
            [In, MarshalAs(UnmanagedType.Interface)] IMFPresentationClock pPresentationClock
            );

        [PreserveSig]
        new int OnProcessSample(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidMajorMediaType,
            [In] int dwSampleFlags, // must be zero
            [In] long llSampleTime,
            [In] long llSampleDuration,
            [In] ref byte pSampleBuffer,
            [In] int dwSampleSize
            );

        [PreserveSig]
        new int OnShutdown();

        #endregion

        [PreserveSig]
        int OnProcessSampleEx(
            [MarshalAs(UnmanagedType.LPStruct)] Guid guidMajorMediaType,
            [In] int dwSampleFlags, // No flags are defined
            [In] long llSampleTime,
            [In] long llSampleDuration,
            [In] IntPtr pSampleBuffer,
            [In] int dwSampleSize,
            IMFAttributes pAttributes
        );
    }

#endif

}
