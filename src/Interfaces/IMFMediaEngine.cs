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
    Guid("98a1b0bb-03eb-4935-ae7c-93c1fa0e1c93"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaEngine
    {
        [PreserveSig]
        int GetError(
            out IMFMediaError ppError
            );

        [PreserveSig]
        int SetErrorCode(
            MF_MEDIA_ENGINE_ERR error
            );

        [PreserveSig]
        int SetSourceElements(
            IMFMediaEngineSrcElements pSrcElements
            );

        [PreserveSig]
        int SetSource(
            [MarshalAs(UnmanagedType.BStr)] string pUrl
            );

        [PreserveSig]
        int GetCurrentSource(
            [MarshalAs(UnmanagedType.BStr)] out string ppUrl
            );

        [PreserveSig]
        MF_MEDIA_ENGINE_NETWORK GetNetworkState();

        [PreserveSig]
        MF_MEDIA_ENGINE_PRELOAD GetPreload();

        [PreserveSig]
        int SetPreload(
            MF_MEDIA_ENGINE_PRELOAD Preload
            );

        [PreserveSig]
        int GetBuffered(
            out IMFMediaTimeRange ppBuffered
            );

        [PreserveSig]
        int Load();

        [PreserveSig]
        int CanPlayType(
            [MarshalAs(UnmanagedType.BStr)] string type,
            out MF_MEDIA_ENGINE_CANPLAY pAnswer
            );

        [PreserveSig]
        MF_MEDIA_ENGINE_READY GetReadyState();

        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsSeeking();

        [PreserveSig]
        double GetCurrentTime();

        [PreserveSig]
        int SetCurrentTime(
            double seekTime
            );

        [PreserveSig]
        double GetStartTime();

        [PreserveSig]
        double GetDuration();

        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsPaused();

        [PreserveSig]
        double GetDefaultPlaybackRate();

        [PreserveSig]
        int SetDefaultPlaybackRate(
            double Rate
            );

        [PreserveSig]
        double GetPlaybackRate();

        [PreserveSig]
        int SetPlaybackRate(
            double Rate
            );

        [PreserveSig]
        int GetPlayed(
            out IMFMediaTimeRange ppPlayed
            );

        [PreserveSig]
        int GetSeekable(
            out IMFMediaTimeRange ppSeekable
            );

        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsEnded();

        [return: MarshalAs(UnmanagedType.Bool)]
        bool GetAutoPlay();

        [PreserveSig]
        int SetAutoPlay(
            [MarshalAs(UnmanagedType.Bool)] bool AutoPlay
            );

        [return: MarshalAs(UnmanagedType.Bool)]
        bool GetLoop();

        [PreserveSig]
        int SetLoop(
            [MarshalAs(UnmanagedType.Bool)] bool Loop
            );

        [PreserveSig]
        int Play();

        [PreserveSig]
        int Pause();

        [return: MarshalAs(UnmanagedType.Bool)]
        bool GetMuted();

        [PreserveSig]
        int SetMuted(
            [MarshalAs(UnmanagedType.Bool)] bool Muted
            );

        [PreserveSig]
        double GetVolume();

        [PreserveSig]
        int SetVolume(
            double Volume
            );

        [return: MarshalAs(UnmanagedType.Bool)]
        bool HasVideo();

        [return: MarshalAs(UnmanagedType.Bool)]
        bool HasAudio();

        [PreserveSig]
        int GetNativeVideoSize(
            out int cx,
            out int cy
            );

        [PreserveSig]
        int GetVideoAspectRatio(
            out int cx,
            out int cy
            );

        [PreserveSig]
        int Shutdown();

        [PreserveSig]
        int TransferVideoFrame(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pDstSurf,
            [In] MFVideoNormalizedRect pSrc,
            [In] MFRect pDst,
            [In] MFARGB pBorderClr
            );

        [PreserveSig]
        int OnVideoStreamTick(
            out long pPts
            );
    }

#endif

}
