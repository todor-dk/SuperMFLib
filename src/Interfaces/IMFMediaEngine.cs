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


    /// <summary>
    /// Enables an application to play audio or video files.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A0023F18-2D28-4F0D-9B00-B8FB11567034(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A0023F18-2D28-4F0D-9B00-B8FB11567034(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("98a1b0bb-03eb-4935-ae7c-93c1fa0e1c93"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaEngine
    {
        /// <summary>
        /// Gets the most recent error status.
        /// </summary>
        /// <param name="ppError">
        /// Receives either a pointer to the <see cref="IMFMediaError"/> interface, or the value <strong>NULL
        /// </strong>. If the value is <strong>non-NULL</strong>, the caller must release the interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetError(
        ///   [out]  IMFMediaError **ppError
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F8A51AF8-8D73-47BC-ADA2-7F5108587873(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F8A51AF8-8D73-47BC-ADA2-7F5108587873(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetError(
            out IMFMediaError ppError
            );

        /// <summary>
        /// Sets the current error code.
        /// </summary>
        /// <param name="error">
        /// The error code, as an <see cref="MF_MEDIA_ENGINE_ERR"/> value. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetErrorCode(
        ///   [in]  MF_MEDIA_ENGINE_ERR error
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B40AFD99-1048-44C5-A3FA-ED57720956B4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B40AFD99-1048-44C5-A3FA-ED57720956B4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetErrorCode(
            MF_MEDIA_ENGINE_ERR error
            );

        /// <summary>
        /// Sets a list of media sources.
        /// </summary>
        /// <param name="pSrcElements">
        /// A pointer to the <see cref="IMFMediaEngineSrcElements"/> interface. The caller must implement this
        /// interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetSourceElements(
        ///   [in]  IMFMediaEngineSrcElements *pSrcElements
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7B1A1C43-A9BD-4DBF-B6A7-53BF9295CDAC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7B1A1C43-A9BD-4DBF-B6A7-53BF9295CDAC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetSourceElements(
            IMFMediaEngineSrcElements pSrcElements
            );

        /// <summary>
        /// Sets the URL of a media resource.
        /// </summary>
        /// <param name="pUrl">
        /// The URL of the media resource.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetSource(
        ///   [in]  BSTR pUrl
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/80C41EAB-9B8F-4723-A4A7-A17F56FF5773(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/80C41EAB-9B8F-4723-A4A7-A17F56FF5773(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetSource(
            [MarshalAs(UnmanagedType.BStr)] string pUrl
            );

        /// <summary>
        /// Gets the URL of the current media resource, or an empty string if no media resource is present.
        /// </summary>
        /// <param name="ppUrl">
        /// Receives a <strong>BSTR</strong> that contains the URL of the current media resource. If there is
        /// no media resource, <em>ppUrl</em> receives an empty string. The caller must free the <strong>BSTR
        /// </strong> by calling <strong>SysFreeString</strong>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetCurrentSource(
        ///   [out]  BSTR *ppUrl
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/04C4281D-20ED-49B3-B00C-14ECF1E3BDE1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/04C4281D-20ED-49B3-B00C-14ECF1E3BDE1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetCurrentSource(
            [MarshalAs(UnmanagedType.BStr)] out string ppUrl
            );

        /// <summary>
        /// Gets the current network state of the media engine.
        /// </summary>
        /// <returns>
        /// Returns an <see cref="MF_MEDIA_ENGINE_NETWORK"/> enumeration value. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// USHORT GetNetworkState();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7CCA902A-51E9-4B6D-B16C-643177BE1BC9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7CCA902A-51E9-4B6D-B16C-643177BE1BC9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        MF_MEDIA_ENGINE_NETWORK GetNetworkState();

        /// <summary>
        /// Gets the preload flag.
        /// </summary>
        /// <returns>
        /// Returns an <see cref="MF_MEDIA_ENGINE_PRELOAD"/> enumeration value. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetPreload();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AA1942B2-C5BB-46F7-B163-1BCB3372D453(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AA1942B2-C5BB-46F7-B163-1BCB3372D453(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        MF_MEDIA_ENGINE_PRELOAD GetPreload();

        /// <summary>
        /// Sets the preload flag.
        /// </summary>
        /// <param name="Preload">
        /// An <see cref="MF_MEDIA_ENGINE_PRELOAD"/> value equal to the preload flag. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetPreload(
        ///   [in]  MF_MEDIA_ENGINE_PRELOAD Preload
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3480C16F-E4E4-469C-BE27-711044691A49(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3480C16F-E4E4-469C-BE27-711044691A49(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetPreload(
            MF_MEDIA_ENGINE_PRELOAD Preload
            );

        /// <summary>
        /// Queries how much resource data the media engine has buffered.
        /// </summary>
        /// <param name="ppBuffered">
        /// Receives a pointer to the <see cref="IMFMediaTimeRange"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetBuffered(
        ///   [out]  IMFMediaTimeRange **ppBuffered
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/38DABEE7-04AF-4542-AF4D-7988C824EA11(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/38DABEE7-04AF-4542-AF4D-7988C824EA11(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetBuffered(
            out IMFMediaTimeRange ppBuffered
            );

        /// <summary>
        /// Loads the current media source.
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT Load();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5ACE8143-DC14-495C-A644-A2076FB1980F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5ACE8143-DC14-495C-A644-A2076FB1980F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Load();

        /// <summary>
        /// Queries how likely it is that the Media Engine can play a specified type of media resource.
        /// </summary>
        /// <param name="type">
        /// A string that contains a MIME type with an optional codecs parameter, as defined in RFC 4281.
        /// </param>
        /// <param name="pAnswer">
        /// Receives an <see cref="MF_MEDIA_ENGINE_CANPLAY"/> enumeration value. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT CanPlayType(
        ///   [in]   BSTR type,
        ///   [out]  MF_MEDIA_ENGINE_CANPLAY *pAnswer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/313F631F-7584-4F95-9208-B087CC12010E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/313F631F-7584-4F95-9208-B087CC12010E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CanPlayType(
            [MarshalAs(UnmanagedType.BStr)] string type,
            out MF_MEDIA_ENGINE_CANPLAY pAnswer
            );

        /// <summary>
        /// Gets the ready state, which indicates whether the current media resource can be rendered.
        /// </summary>
        /// <returns>
        /// Returns an <see cref="MF_MEDIA_ENGINE_READY"/> enumeration value. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// USHORT GetReadyState();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B8C9B600-87FD-4DE6-8794-5C1E41449554(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B8C9B600-87FD-4DE6-8794-5C1E41449554(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        MF_MEDIA_ENGINE_READY GetReadyState();

        /// <summary>
        /// Queries whether the Media Engine is currently seeking to a new playback position.
        /// </summary>
        /// <returns>
        /// Returns <strong>TRUE</strong> if the Media Engine is seeking, or <strong>FALSE</strong> otherwise. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// BOOL IsSeeking();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B314D5E7-EBD4-42CF-9E86-206ABC3027A0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B314D5E7-EBD4-42CF-9E86-206ABC3027A0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsSeeking();

        /// <summary>
        /// Gets the current playback position.
        /// </summary>
        /// <returns>
        /// Returns the playback position, in seconds.
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// double GetCurrentTime();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/49FA2383-8AEC-4DDF-8998-25987EEC8223(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/49FA2383-8AEC-4DDF-8998-25987EEC8223(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        double GetCurrentTime();

        /// <summary>
        /// Seeks to a new playback position.
        /// </summary>
        /// <param name="seekTime">
        /// The new playback position, in seconds.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetCurrentTime(
        ///   [in]  double seekTime
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C64BCBA0-097E-4035-BFEE-F9EC949B109A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C64BCBA0-097E-4035-BFEE-F9EC949B109A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetCurrentTime(
            double seekTime
            );

        /// <summary>
        /// Gets the initial playback position.
        /// </summary>
        /// <returns>
        /// Returns the initial playback position, in seconds.
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// double GetStartTime();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/18793EC9-D04A-443F-8469-44CC00C4EE27(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/18793EC9-D04A-443F-8469-44CC00C4EE27(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        double GetStartTime();

        /// <summary>
        /// Gets the duration of the media resource.
        /// </summary>
        /// <returns>
        /// Returns the duration, in seconds. If no media data is available, the method returns not-a-number
        /// (NaN). If the duration is unbounded, the method returns an infinite value.
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// double GetDuration();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E5C793A2-7C6F-42D0-B8DE-17F1B62A0352(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E5C793A2-7C6F-42D0-B8DE-17F1B62A0352(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        double GetDuration();

        /// <summary>
        /// Queries whether playback is currently paused.
        /// </summary>
        /// <returns>
        /// Returns <strong>TRUE</strong> if playback is paused, or <strong>FALSE</strong> otherwise. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// BOOL IsPaused();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A2E9C498-FEEB-4506-9E69-59028A6B4EE5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A2E9C498-FEEB-4506-9E69-59028A6B4EE5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsPaused();

        /// <summary>
        /// Gets the default playback rate.
        /// </summary>
        /// <returns>
        /// Returns the default playback rate, as a multiple of normal (1×) playback. A negative value
        /// indicates reverse playback.
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// double GetDefaultPlaybackRate();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FF7E9E76-B85E-40BB-88BD-5033FCE31177(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FF7E9E76-B85E-40BB-88BD-5033FCE31177(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        double GetDefaultPlaybackRate();

        /// <summary>
        /// Sets the default playback rate.
        /// </summary>
        /// <param name="Rate">
        /// The default playback rate, as a multiple of normal (1×) playback. A negative value indicates
        /// reverse playback.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetDefaultPlaybackRate(
        ///   [in]  double Rate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D6EA6BC1-021A-432D-BBCB-BE2FD15E7BE5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D6EA6BC1-021A-432D-BBCB-BE2FD15E7BE5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetDefaultPlaybackRate(
            double Rate
            );

        /// <summary>
        /// Gets the current playback rate.
        /// </summary>
        /// <returns>
        /// Returns the playback rate, as a multiple of normal (1×) playback. A negative value indicates
        /// reverse playback.
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// double GetPlaybackRate();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E270CB86-D90B-43FA-843B-F824970BD4F3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E270CB86-D90B-43FA-843B-F824970BD4F3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        double GetPlaybackRate();

        /// <summary>
        /// Sets the current playback rate.
        /// </summary>
        /// <param name="Rate">
        /// The playback rate, as a multiple of normal (1×) playback. A negative value indicates reverse
        /// playback.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetPlaybackRate(
        ///   [in]  double Rate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/648BF1CC-BFAC-4874-808B-F8B46E3E9989(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/648BF1CC-BFAC-4874-808B-F8B46E3E9989(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetPlaybackRate(
            double Rate
            );

        /// <summary>
        /// Gets the time ranges that have been rendered.
        /// </summary>
        /// <param name="ppPlayed">
        /// Receives a pointer to the <see cref="IMFMediaTimeRange"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetPlayed(
        ///   [out]  IMFMediaTimeRange **ppPlayed
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E74D1785-E8BA-4B3A-9FF8-63FBDED5FA9E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E74D1785-E8BA-4B3A-9FF8-63FBDED5FA9E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetPlayed(
            out IMFMediaTimeRange ppPlayed
            );

        /// <summary>
        /// Gets the time ranges to which the Media Engine can currently seek.
        /// </summary>
        /// <param name="ppSeekable">The pp seekable.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetSeekable(
        ///   [out]  IMFMediaTimeRange **ppPlayed
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FB238892-B172-4E31-B4E5-68C96E135345(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FB238892-B172-4E31-B4E5-68C96E135345(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetSeekable(
            out IMFMediaTimeRange ppSeekable
            );

        /// <summary>
        /// Queries whether playback has ended.
        /// </summary>
        /// <returns>
        /// Returns <strong>TRUE</strong> if the direction of playback is forward and playback has reached the
        /// end of the media resource. Returns <strong>FALSE</strong> otherwise. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// BOOL IsEnded();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0760707C-B25E-44FF-9263-6B59BF43A98E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0760707C-B25E-44FF-9263-6B59BF43A98E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsEnded();

        /// <summary>
        /// Queries whether the Media Engine automatically begins playback.
        /// </summary>
        /// <returns>
        /// Returns <strong>TRUE</strong> if the Media Engine automatically begins playback, or <strong>FALSE
        /// </strong> otherwise. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// BOOL GetAutoPlay();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CEF50308-D4F9-435F-A81A-3746A27846F0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CEF50308-D4F9-435F-A81A-3746A27846F0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        bool GetAutoPlay();

        /// <summary>
        /// Specifies whether the Media Engine automatically begins playback.
        /// </summary>
        /// <param name="AutoPlay">
        /// If <strong>TRUE</strong>, the Media Engine automatically begins playback after it loads a media
        /// source. Otherwise, playback does not begin until the application calls 
        /// <see cref="IMFMediaEngine.Play"/>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetAutoPlay(
        ///   [in]  BOOL AutoPlay
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/867FE1D2-39AE-4A44-99DD-98A8ABD234A2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/867FE1D2-39AE-4A44-99DD-98A8ABD234A2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetAutoPlay(
            [MarshalAs(UnmanagedType.Bool)] bool AutoPlay
            );

        /// <summary>
        /// Queries whether the Media Engine will loop playback.
        /// </summary>
        /// <returns>
        /// Returns <strong>TRUE</strong> if looping is enabled, or <strong>FALSE</strong> otherwise. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// BOOL GetLoop();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EBAB4E73-164D-4AE5-87A4-0D37C10071E9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EBAB4E73-164D-4AE5-87A4-0D37C10071E9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        bool GetLoop();

        /// <summary>
        /// Specifies whether the Media Engine loops playback.
        /// </summary>
        /// <param name="Loop">
        /// Specify <strong>TRUE</strong> to enable looping, or <strong>FALSE</strong> to disable looping. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetLoop(
        ///   [in]  BOOL Loop
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0B8890EA-9207-428B-8EC2-18B51E1D8365(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0B8890EA-9207-428B-8EC2-18B51E1D8365(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetLoop(
            [MarshalAs(UnmanagedType.Bool)] bool Loop
            );

        /// <summary>
        /// Starts playback.
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT Play();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2D6083F5-734A-4350-8E54-56C79038389D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2D6083F5-734A-4350-8E54-56C79038389D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Play();

        /// <summary>
        /// Pauses playback.
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT Pause();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5C1FEBDA-18B5-4BF4-9AF4-FF6DBCDD880D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5C1FEBDA-18B5-4BF4-9AF4-FF6DBCDD880D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Pause();

        /// <summary>
        /// Queries whether the audio is muted. 
        /// </summary>
        /// <returns>
        /// Returns <strong>TRUE</strong> if the audio is muted, or <strong>FALSE</strong> otherwise. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// BOOL GetMuted();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6EDDE60A-1571-4021-B56F-4185694B0911(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6EDDE60A-1571-4021-B56F-4185694B0911(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        bool GetMuted();

        /// <summary>
        /// Mutes or unmutes the audio. 
        /// </summary>
        /// <param name="Muted">
        /// Specify <strong>TRUE</strong> to mute the audio, or <strong>FALSE</strong> to unmute the audio. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetMuted(
        ///   [in]  BOOL Muted
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/330CB3CF-F649-4964-A24D-3C16E778BFD7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/330CB3CF-F649-4964-A24D-3C16E778BFD7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetMuted(
            [MarshalAs(UnmanagedType.Bool)] bool Muted
            );

        /// <summary>
        /// Gets the audio volume level.
        /// </summary>
        /// <returns>
        /// Returns the volume level. Volume is expressed as an attenuation level, where 0.0 indicates silence
        /// and 1.0 indicates full volume (no attenuation).
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// double GetVolume();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E7890777-480E-4EA1-88BA-657182B66010(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E7890777-480E-4EA1-88BA-657182B66010(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        double GetVolume();

        /// <summary>
        /// Sets the audio volume level.
        /// </summary>
        /// <param name="Volume">
        /// The volume level. Volume is expressed as an attenuation level, where 0.0 indicates silence and 1.0
        /// indicates full volume (no attenuation). 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetVolume(
        ///   [in]  double Volume
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/010EE05C-3F81-404E-8AFB-7C57CA55A8AE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/010EE05C-3F81-404E-8AFB-7C57CA55A8AE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetVolume(
            double Volume
            );

        /// <summary>
        /// Queries whether the current media resource contains a video stream.
        /// </summary>
        /// <returns>
        /// Returns <strong>TRUE</strong> if the current media resource contains a video stream. Returns 
        /// <strong>FALSE</strong> if there is no media resource or the media resource does not contain a video
        /// stream. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// BOOL HasVideo();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/30B7F4DC-B3EB-421B-998B-E098F04D4B33(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/30B7F4DC-B3EB-421B-998B-E098F04D4B33(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        bool HasVideo();

        /// <summary>
        /// Queries whether the current media resource contains an audio stream.
        /// </summary>
        /// <returns>
        /// Returns <strong>TRUE</strong> if the current media resource contains an audio stream. Returns 
        /// <strong>FALSE</strong> if there is no media resource or the media resource does not contain an
        /// audio stream. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// BOOL HasAudio();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D06A773E-8D41-40D1-BA10-65AEFF2D7667(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D06A773E-8D41-40D1-BA10-65AEFF2D7667(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        bool HasAudio();

        /// <summary>
        /// Gets the size of the video frame, adjusted for aspect ratio.
        /// </summary>
        /// <param name="cx">
        /// Receives the width in pixels.
        /// </param>
        /// <param name="cy">
        /// Receives the height in pixels.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetNativeVideoSize(
        ///   [out]  DWORD *cx,
        ///   [out]  DWORD *cy
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/843F09F7-2E8B-4DF7-AF0C-136BB8626779(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/843F09F7-2E8B-4DF7-AF0C-136BB8626779(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetNativeVideoSize(
            out int cx,
            out int cy
            );

        /// <summary>
        /// Gets the picture aspect ratio of the video stream.
        /// </summary>
        /// <param name="cx">
        /// Receives the x component of the aspect ratio.
        /// </param>
        /// <param name="cy">
        /// Receives the y component of the aspect ratio.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetVideoAspectRatio(
        ///   [out]  DWORD *cx,
        ///   [out]  DWORD *cy
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/82B4AD4B-1A2E-4B03-8343-E4E5A43E62D2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/82B4AD4B-1A2E-4B03-8343-E4E5A43E62D2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetVideoAspectRatio(
            out int cx,
            out int cy
            );

        /// <summary>
        /// Shuts down the Media Engine and releases the resources it is using. 
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT Shutdown();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8B7BCEAC-7A30-4B60-AD0E-E8DCE404DDE9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8B7BCEAC-7A30-4B60-AD0E-E8DCE404DDE9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Shutdown();

        /// <summary>
        /// Copies the current video frame to a DXGI surface or WIC bitmap.
        /// </summary>
        /// <param name="pDstSurf">
        /// A pointer to the <c>IUnknown</c> interface of the destination surface. 
        /// </param>
        /// <param name="pSrc">
        /// A pointer to an <see cref="EVR.MFVideoNormalizedRect"/> structure that specifies the source
        /// rectangle. 
        /// </param>
        /// <param name="pDst">
        /// A pointer to a <c>RECT</c> structure that specifies the destination rectangle. 
        /// </param>
        /// <param name="pBorderClr">
        /// A pointer to an <see cref="MFARGB"/> structure that specifies the border color. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT TransferVideoFrame(
        ///   [in]  IUnknown *pDstSurf,
        ///   [in]  const MFVideoNormalizedRect *pSrc,
        ///   [in]  const RECT *pDst,
        ///   [in]  const MFARGB *pBorderClr
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/07DB29E2-9F09-46CB-B138-197D95EC37F0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/07DB29E2-9F09-46CB-B138-197D95EC37F0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int TransferVideoFrame(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pDstSurf,
            [In] MFVideoNormalizedRect pSrc,
            [In] MFRect pDst,
            [In] MFARGB pBorderClr
            );

        /// <summary>
        /// Queries the Media Engine to find out whether a new video frame is ready.
        /// </summary>
        /// <param name="pPts">
        /// If a new frame is ready, receives the presentation time of the frame.
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_FALSE</strong></term><description>The method succeeded, but the Media Engine does not have a new frame.</description></item>
        /// <item><term><strong>S_OK</strong></term><description>A new video frame is ready for display.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT OnVideoStreamTick(
        ///   [out]  LONGLONG *pPts
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EC06D3D6-F103-4932-96C1-B55A59CD5E34(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EC06D3D6-F103-4932-96C1-B55A59CD5E34(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int OnVideoStreamTick(
            out long pPts
            );
    }

#endif

}
