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
    Guid("83015ead-b1e6-40d0-a98a-37145ffe1ad1"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaEngineEx : IMFMediaEngine
    {

        #region IMFMediaEngine methods

        [PreserveSig]
        new int GetError(
            out IMFMediaError ppError
            );

        [PreserveSig]
        new int SetErrorCode(
            MF_MEDIA_ENGINE_ERR error
            );

        [PreserveSig]
        new int SetSourceElements(
            IMFMediaEngineSrcElements pSrcElements
            );

        [PreserveSig]
        new int SetSource(
            [MarshalAs(UnmanagedType.BStr)] string pUrl
            );

        [PreserveSig]
        new int GetCurrentSource(
            [MarshalAs(UnmanagedType.BStr)] out string ppUrl
            );

        [PreserveSig]
        new MF_MEDIA_ENGINE_NETWORK GetNetworkState();

        [PreserveSig]
        new MF_MEDIA_ENGINE_PRELOAD GetPreload();

        [PreserveSig]
        new int SetPreload(
            MF_MEDIA_ENGINE_PRELOAD Preload
            );

        [PreserveSig]
        new int GetBuffered(
            out IMFMediaTimeRange ppBuffered
            );

        [PreserveSig]
        new int Load();

        [PreserveSig]
        new int CanPlayType(
            [MarshalAs(UnmanagedType.BStr)] string type,
            out MF_MEDIA_ENGINE_CANPLAY pAnswer
            );

        [PreserveSig]
        new MF_MEDIA_ENGINE_READY GetReadyState();

        [return: MarshalAs(UnmanagedType.Bool)]
        new bool IsSeeking();

        [PreserveSig]
        new double GetCurrentTime();

        [PreserveSig]
        new int SetCurrentTime(
            double seekTime
            );

        [PreserveSig]
        new double GetStartTime();

        [PreserveSig]
        new double GetDuration();

        [return: MarshalAs(UnmanagedType.Bool)]
        new bool IsPaused();

        [PreserveSig]
        new double GetDefaultPlaybackRate();

        [PreserveSig]
        new int SetDefaultPlaybackRate(
            double Rate
            );

        [PreserveSig]
        new double GetPlaybackRate();

        [PreserveSig]
        new int SetPlaybackRate(
            double Rate
            );

        [PreserveSig]
        new int GetPlayed(
            out IMFMediaTimeRange ppPlayed
            );

        [PreserveSig]
        new int GetSeekable(
            out IMFMediaTimeRange ppSeekable
            );

        [return: MarshalAs(UnmanagedType.Bool)]
        new bool IsEnded();

        [return: MarshalAs(UnmanagedType.Bool)]
        new bool GetAutoPlay();

        [PreserveSig]
        new int SetAutoPlay(
            [MarshalAs(UnmanagedType.Bool)] bool AutoPlay
            );

        [return: MarshalAs(UnmanagedType.Bool)]
        new bool GetLoop();

        [PreserveSig]
        new int SetLoop(
            [MarshalAs(UnmanagedType.Bool)] bool Loop
            );

        [PreserveSig]
        new int Play();

        [PreserveSig]
        new int Pause();

        [return: MarshalAs(UnmanagedType.Bool)]
        new bool GetMuted();

        [PreserveSig]
        new int SetMuted(
            [MarshalAs(UnmanagedType.Bool)] bool Muted
            );

        [PreserveSig]
        new double GetVolume();

        [PreserveSig]
        new int SetVolume(
            double Volume
            );

        [return: MarshalAs(UnmanagedType.Bool)]
        new bool HasVideo();

        [return: MarshalAs(UnmanagedType.Bool)]
        new bool HasAudio();

        [PreserveSig]
        new int GetNativeVideoSize(
            out int cx,
            out int cy
            );

        [PreserveSig]
        new int GetVideoAspectRatio(
            out int cx,
            out int cy
            );

        [PreserveSig]
        new int Shutdown();

        [PreserveSig]
        new int TransferVideoFrame(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pDstSurf,
            [In] MFVideoNormalizedRect pSrc,
            [In] MFRect pDst,
            [In] MFARGB pBorderClr
            );

        [PreserveSig]
        new int OnVideoStreamTick(
            out long pPts
            );

        #endregion

        [PreserveSig]
        int SetSourceFromByteStream(
            IMFByteStream pByteStream,
            [MarshalAs(UnmanagedType.BStr)] string pURL
            );

        [PreserveSig]
        int GetStatistics(
            MF_MEDIA_ENGINE_STATISTIC StatisticID,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pStatistic
            );

        [PreserveSig]
        int UpdateVideoStream(
            [In] MFVideoNormalizedRect pSrc,
            [In] MFRect pDst,
            [In] MFARGB pBorderClr
            );

        [PreserveSig]
        double GetBalance();

        [PreserveSig]
        int SetBalance(
            double balance
            );

        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsPlaybackRateSupported(
            double rate
            );

        [PreserveSig]
        int FrameStep(
            [MarshalAs(UnmanagedType.Bool)] bool Forward
            );

        [PreserveSig]
        int GetResourceCharacteristics(
            out int pCharacteristics
            );

        [PreserveSig]
        int GetPresentationAttribute(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidMFAttribute,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pvValue
            );

        [PreserveSig]
        int GetNumberOfStreams(
            out int pdwStreamCount
            );

        [PreserveSig]
        int GetStreamAttribute(
            int dwStreamIndex,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidMFAttribute,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pvValue
            );

        [PreserveSig]
        int GetStreamSelection(
            int dwStreamIndex,
            [MarshalAs(UnmanagedType.Bool)] out bool pEnabled
            );

        [PreserveSig]
        int SetStreamSelection(
            int dwStreamIndex,
            [MarshalAs(UnmanagedType.Bool)] bool Enabled
            );

        [PreserveSig]
        int ApplyStreamSelections();

        [PreserveSig]
        int IsProtected(
            [MarshalAs(UnmanagedType.Bool)] out bool pProtected
            );

        [PreserveSig]
        int InsertVideoEffect(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pEffect,
            [MarshalAs(UnmanagedType.Bool)] bool fOptional
            );

        [PreserveSig]
        int InsertAudioEffect(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pEffect,
            [MarshalAs(UnmanagedType.Bool)] bool fOptional
            );

        [PreserveSig]
        int RemoveAllEffects();

        [PreserveSig]
        int SetTimelineMarkerTimer(
            double timeToFire
            );

        [PreserveSig]
        int GetTimelineMarkerTimer(
            out double pTimeToFire
            );

        [PreserveSig]
        int CancelTimelineMarkerTimer();

        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsStereo3D();

        [PreserveSig]
        int GetStereo3DFramePackingMode(
            out MF_MEDIA_ENGINE_S3D_PACKING_MODE packMode
            );

        [PreserveSig]
        int SetStereo3DFramePackingMode(
            MF_MEDIA_ENGINE_S3D_PACKING_MODE packMode
            );

        [PreserveSig]
        int GetStereo3DRenderMode(
            out MF3DVideoOutputType outputType
            );

        [PreserveSig]
        int SetStereo3DRenderMode(
            MF3DVideoOutputType outputType
            );

        [PreserveSig]
        int EnableWindowlessSwapchainMode(
            [MarshalAs(UnmanagedType.Bool)] bool fEnable
            );

        [PreserveSig]
        int GetVideoSwapchainHandle(
            out IntPtr phSwapchain
            );

        [PreserveSig]
        int EnableHorizontalMirrorMode(
            [MarshalAs(UnmanagedType.Bool)] bool fEnable
            );

        [PreserveSig]
        int GetAudioStreamCategory(
            out int pCategory
            );

        [PreserveSig]
        int SetAudioStreamCategory(
            int category
            );

        [PreserveSig]
        int GetAudioEndpointRole(
            out int pRole
            );

        [PreserveSig]
        int SetAudioEndpointRole(
            int role
            );

        [PreserveSig]
        int GetRealTimeMode(
            [MarshalAs(UnmanagedType.Bool)] out bool pfEnabled
            );

        [PreserveSig]
        int SetRealTimeMode(
            [MarshalAs(UnmanagedType.Bool)] bool fEnable
            );

        [PreserveSig]
        int SetCurrentTimeEx(
            double seekTime,
            MF_MEDIA_ENGINE_SEEK_MODE seekMode
            );

        [PreserveSig]
        int EnableTimeUpdateTimer(
            [MarshalAs(UnmanagedType.Bool)] bool fEnableTimer
            );
    }

#endif

}
