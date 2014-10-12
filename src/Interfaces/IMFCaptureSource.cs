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
    Guid("439a42a8-0d2c-4505-be83-f79b2a05d5c4"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFCaptureSource
    {
        [PreserveSig]
        int GetCaptureDeviceSource(
            MF_CAPTURE_ENGINE_DEVICE_TYPE mfCaptureEngineDeviceType,
            out IMFMediaSource ppMediaSource
            );

        [PreserveSig]
        int GetCaptureDeviceActivate(
            MF_CAPTURE_ENGINE_DEVICE_TYPE mfCaptureEngineDeviceType,
            out IMFActivate ppActivate
            );

        [PreserveSig]
        int GetService(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid rguidService,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppUnknown
            );

        [PreserveSig]
        int AddEffect(
            int dwSourceStreamIndex,
            [MarshalAs(UnmanagedType.IUnknown)] out object pUnknown
            );

        [PreserveSig]
        int RemoveEffect(
            int dwSourceStreamIndex,
            [MarshalAs(UnmanagedType.IUnknown)] object pUnknown
            );

        [PreserveSig]
        int RemoveAllEffects(
            int dwSourceStreamIndex
            );

        [PreserveSig]
        int GetAvailableDeviceMediaType(
            int dwSourceStreamIndex,
            int dwMediaTypeIndex,
            out IMFMediaType ppMediaType
            );

        [PreserveSig]
        int SetCurrentDeviceMediaType(
            int dwSourceStreamIndex,
            IMFMediaType pMediaType
            );

        [PreserveSig]
        int GetCurrentDeviceMediaType(
            int dwSourceStreamIndex,
            out IMFMediaType ppMediaType
            );

        [PreserveSig]
        int GetDeviceStreamCount(
            out int pdwStreamCount
            );

        [PreserveSig]
        int GetDeviceStreamCategory(
            int dwSourceStreamIndex,
            out MF_CAPTURE_ENGINE_STREAM_CATEGORY pStreamCategory
            );

        [PreserveSig]
        int GetMirrorState(
            int dwStreamIndex,
            [MarshalAs(UnmanagedType.Bool)] out bool pfMirrorState
            );

        [PreserveSig]
        int SetMirrorState(
            int dwStreamIndex,
            bool fMirrorState
            );

        [PreserveSig]
        int GetStreamIndexFromFriendlyName(
            int uifriendlyName,
            out int pdwActualStreamIndex
            );
    }

#endif

}
