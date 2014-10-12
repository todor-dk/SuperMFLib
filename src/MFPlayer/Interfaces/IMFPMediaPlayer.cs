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
    Guid("A714590A-58AF-430a-85BF-44F5EC838D85")]
    public interface IMFPMediaPlayer
    {
        [PreserveSig]
        int Play();

        [PreserveSig]
        int Pause();

        [PreserveSig]
        int Stop();

        [PreserveSig]
        int FrameStep();

        [PreserveSig]
        int SetPosition(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidPositionType,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant pvPositionValue
        );

        [PreserveSig]
        int GetPosition(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidPositionType,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pvPositionValue
        );

        [PreserveSig]
        int GetDuration(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidPositionType,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pvPositionValue
        );

        [PreserveSig]
        int SetRate(
            float flRate
        );

        [PreserveSig]
        int GetRate(
            out float pflRate
        );

        [PreserveSig]
        int GetSupportedRates(
            [MarshalAs(UnmanagedType.Bool)] bool fForwardDirection,
            out float pflSlowestRate,
            out float pflFastestRate
        );

        [PreserveSig]
        int GetState(
            out MFP_MEDIAPLAYER_STATE peState
        );

        [PreserveSig]
        int CreateMediaItemFromURL(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszURL,
            [MarshalAs(UnmanagedType.Bool)] bool fSync,
            IntPtr dwUserData,
            out IMFPMediaItem ppMediaItem
        );

        [PreserveSig]
        int CreateMediaItemFromObject(
            [MarshalAs(UnmanagedType.IUnknown)] object pIUnknownObj,
            [MarshalAs(UnmanagedType.Bool)] bool fSync,
            IntPtr dwUserData,
            out IMFPMediaItem ppMediaItem
        );

        [PreserveSig]
        int SetMediaItem(
            IMFPMediaItem pIMFPMediaItem
        );

        [PreserveSig]
        int ClearMediaItem();

        [PreserveSig]
        int GetMediaItem(
            out IMFPMediaItem ppIMFPMediaItem
        );

        [PreserveSig]
        int GetVolume(
            out float pflVolume
        );

        [PreserveSig]
        int SetVolume(
            float flVolume
        );

        [PreserveSig]
        int GetBalance(
            out float pflBalance
        );

        [PreserveSig]
        int SetBalance(
            float flBalance
        );

        [PreserveSig]
        int GetMute(
            [MarshalAs(UnmanagedType.Bool)] out bool pfMute
        );

        [PreserveSig]
        int SetMute(
            [MarshalAs(UnmanagedType.Bool)] bool fMute
        );

        [PreserveSig]
        int GetNativeVideoSize(
            out MFSize pszVideo,
            out MFSize pszARVideo
        );

        [PreserveSig]
        int GetIdealVideoSize(
            out MFSize pszMin,
            out MFSize pszMax
        );

        [PreserveSig]
        int SetVideoSourceRect(
            [In] MFVideoNormalizedRect pnrcSource
        );

        [PreserveSig]
        int GetVideoSourceRect(
            out MFVideoNormalizedRect pnrcSource
        );

        [PreserveSig]
        int SetAspectRatioMode(
            MFVideoAspectRatioMode dwAspectRatioMode
        );

        [PreserveSig]
        int GetAspectRatioMode(
            out MFVideoAspectRatioMode pdwAspectRatioMode
        );

        [PreserveSig]
        int GetVideoWindow(
            out IntPtr phwndVideo
        );

        [PreserveSig]
        int UpdateVideo();

        [PreserveSig]
        int SetBorderColor(
            Color Clr
        );

        [PreserveSig]
        int GetBorderColor(
            out Color pClr
        );

        [PreserveSig]
        int InsertEffect(
            [MarshalAs(UnmanagedType.IUnknown)] object pEffect,
            [MarshalAs(UnmanagedType.Bool)] bool fOptional
        );

        [PreserveSig]
        int RemoveEffect(
            [MarshalAs(UnmanagedType.IUnknown)] object pEffect
        );

        [PreserveSig]
        int RemoveAllEffects();

        [PreserveSig]
        int Shutdown();
    }

#endif

}
