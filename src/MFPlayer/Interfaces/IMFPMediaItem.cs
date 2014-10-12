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


    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("90EB3E6B-ECBF-45cc-B1DA-C6FE3EA70D57")]
    public interface IMFPMediaItem
    {
        [PreserveSig]
        int GetMediaPlayer(
            out IMFPMediaPlayer ppMediaPlayer
        );

        [PreserveSig]
        int GetURL(
            [MarshalAs(UnmanagedType.LPWStr)] out string ppwszURL
        );

        [PreserveSig]
        int GetObject(
            [MarshalAs(UnmanagedType.IUnknown)] out object ppIUnknown
        );

        [PreserveSig]
        int GetUserData(
            out IntPtr pdwUserData
        );

        [PreserveSig]
        int SetUserData(
            IntPtr dwUserData
        );

        [PreserveSig]
        int GetStartStopPosition(
            out Guid pguidStartPositionType,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pvStartValue,
            out Guid pguidStopPositionType,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pvStopValue
        );

        [PreserveSig]
        int SetStartStopPosition(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid pguidStartPositionType,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant pvStartValue,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid pguidStopPositionType,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant pvStopValue
        );

        [PreserveSig]
        int HasVideo(
            [MarshalAs(UnmanagedType.Bool)] out bool pfHasVideo,
            [MarshalAs(UnmanagedType.Bool)] out bool pfSelected
        );

        [PreserveSig]
        int HasAudio(
            [MarshalAs(UnmanagedType.Bool)] out bool pfHasAudio,
            [MarshalAs(UnmanagedType.Bool)] out bool pfSelected
        );

        [PreserveSig]
        int IsProtected(
            [MarshalAs(UnmanagedType.Bool)] out bool pfProtected
        );

        [PreserveSig]
        int GetDuration(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidPositionType,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pvDurationValue
        );

        [PreserveSig]
        int GetNumberOfStreams(
            out int pdwStreamCount
        );

        [PreserveSig]
        int GetStreamSelection(
            int dwStreamIndex,
            [MarshalAs(UnmanagedType.Bool)] out bool pfEnabled
        );

        [PreserveSig]
        int SetStreamSelection(
            int dwStreamIndex,
            [MarshalAs(UnmanagedType.Bool)] bool fEnabled
        );

        [PreserveSig]
        int GetStreamAttribute(
            int dwStreamIndex,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidMFAttribute,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pvValue
        );

        [PreserveSig]
        int GetPresentationAttribute(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidMFAttribute,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pvValue
        );

        [PreserveSig]
        int GetCharacteristics(
            out MFP_MEDIAITEM_CHARACTERISTICS pCharacteristics
        );

        [PreserveSig]
        int SetStreamSink(
            int dwStreamIndex,
            [MarshalAs(UnmanagedType.IUnknown)] object pMediaSink
        );

        [PreserveSig]
        int GetMetadata(
            out IPropertyStore ppMetadataStore
        );
    }

#endif

}
