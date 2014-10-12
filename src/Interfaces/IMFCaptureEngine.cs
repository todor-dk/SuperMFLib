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
using MediaFoundation.EVR;

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("a6bba433-176b-48b2-b375-53aa03473207"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFCaptureEngine
    {
        [PreserveSig]
        int Initialize(
            IMFCaptureEngineOnEventCallback pEventCallback,
            IMFAttributes pAttributes,
            [MarshalAs(UnmanagedType.IUnknown)] object pAudioSource,
            [MarshalAs(UnmanagedType.IUnknown)] object pVideoSource
            );

        [PreserveSig]
        int StartPreview();

        [PreserveSig]
        int StopPreview();

        [PreserveSig]
        int StartRecord();

        [PreserveSig]
        int StopRecord(
            bool bFinalize,
            bool bFlushUnprocessedSamples
            );

        [PreserveSig]
        int TakePhoto();

        [PreserveSig]
        int GetSink(
            MF_CAPTURE_ENGINE_SINK_TYPE mfCaptureEngineSinkType,
            out IMFCaptureSink ppSink
            );

        [PreserveSig]
        int GetSource(
            out IMFCaptureSource ppSource
            );
    }

#endif

}
