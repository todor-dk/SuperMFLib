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

namespace MediaFoundation.Core.Interfaces
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Extends the <see cref="IMFMediaEngine"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/EE3591FD-4FE8-4F20-A4E2-52C896229571(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EE3591FD-4FE8-4F20-A4E2-52C896229571(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("83015ead-b1e6-40d0-a98a-37145ffe1ad1"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFMediaEngineEx : IMFMediaEngine
    {

        #region IMFMediaEngine methods

        /// <summary>
        /// Gets the most recent error status.
        /// </summary>
        /// <param name="ppError">Receives either a pointer to the <see cref="IMFMediaError" /> interface, or the value <strong>NULL
        /// </strong>. If the value is <strong>non-NULL</strong>, the caller must release the interface.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetError(
        /// [out]  IMFMediaError **ppError
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/F8A51AF8-8D73-47BC-ADA2-7F5108587873(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F8A51AF8-8D73-47BC-ADA2-7F5108587873(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetError(
            out IMFMediaError ppError
            );

        /// <summary>
        /// Sets the current error code.
        /// </summary>
        /// <param name="error">The error code, as an <see cref="MF_MEDIA_ENGINE_ERR" /> value.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetErrorCode(
        /// [in]  MF_MEDIA_ENGINE_ERR error
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/B40AFD99-1048-44C5-A3FA-ED57720956B4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B40AFD99-1048-44C5-A3FA-ED57720956B4(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetErrorCode(
            MF_MEDIA_ENGINE_ERR error
            );

        /// <summary>
        /// Sets a list of media sources.
        /// </summary>
        /// <param name="pSrcElements">A pointer to the <see cref="IMFMediaEngineSrcElements" /> interface. The caller must implement this
        /// interface.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetSourceElements(
        /// [in]  IMFMediaEngineSrcElements *pSrcElements
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/7B1A1C43-A9BD-4DBF-B6A7-53BF9295CDAC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7B1A1C43-A9BD-4DBF-B6A7-53BF9295CDAC(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetSourceElements(
            IMFMediaEngineSrcElements pSrcElements
            );

        /// <summary>
        /// Sets the URL of a media resource.
        /// </summary>
        /// <param name="pUrl">The URL of the media resource.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetSource(
        /// [in]  BSTR pUrl
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/80C41EAB-9B8F-4723-A4A7-A17F56FF5773(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/80C41EAB-9B8F-4723-A4A7-A17F56FF5773(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetSource(
            [MarshalAs(UnmanagedType.BStr)] string pUrl
            );

        /// <summary>
        /// Gets the URL of the current media resource, or an empty string if no media resource is present.
        /// </summary>
        /// <param name="ppUrl">Receives a <strong>BSTR</strong> that contains the URL of the current media resource. If there is
        /// no media resource, <em>ppUrl</em> receives an empty string. The caller must free the <strong>BSTR
        /// </strong> by calling <strong>SysFreeString</strong>.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetCurrentSource(
        /// [out]  BSTR *ppUrl
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/04C4281D-20ED-49B3-B00C-14ECF1E3BDE1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/04C4281D-20ED-49B3-B00C-14ECF1E3BDE1(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetCurrentSource(
            [MarshalAs(UnmanagedType.BStr)] out string ppUrl
            );

        /// <summary>
        /// Gets the current network state of the media engine.
        /// </summary>
        /// <returns>
        /// Returns an <see cref="MF_MEDIA_ENGINE_NETWORK"/> enumeration value. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// USHORT GetNetworkState();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/7CCA902A-51E9-4B6D-B16C-643177BE1BC9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7CCA902A-51E9-4B6D-B16C-643177BE1BC9(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new MF_MEDIA_ENGINE_NETWORK GetNetworkState();

        /// <summary>
        /// Gets the preload flag.
        /// </summary>
        /// <returns>
        /// Returns an <see cref="MF_MEDIA_ENGINE_PRELOAD"/> enumeration value. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetPreload();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/AA1942B2-C5BB-46F7-B163-1BCB3372D453(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AA1942B2-C5BB-46F7-B163-1BCB3372D453(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new MF_MEDIA_ENGINE_PRELOAD GetPreload();

        /// <summary>
        /// Sets the preload flag.
        /// </summary>
        /// <param name="Preload">An <see cref="MF_MEDIA_ENGINE_PRELOAD" /> value equal to the preload flag.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetPreload(
        /// [in]  MF_MEDIA_ENGINE_PRELOAD Preload
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/3480C16F-E4E4-469C-BE27-711044691A49(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3480C16F-E4E4-469C-BE27-711044691A49(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetPreload(
            MF_MEDIA_ENGINE_PRELOAD Preload
            );

        /// <summary>
        /// Queries how much resource data the media engine has buffered.
        /// </summary>
        /// <param name="ppBuffered">Receives a pointer to the <see cref="IMFMediaTimeRange" /> interface. The caller must release the
        /// interface.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetBuffered(
        /// [out]  IMFMediaTimeRange **ppBuffered
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/38DABEE7-04AF-4542-AF4D-7988C824EA11(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/38DABEE7-04AF-4542-AF4D-7988C824EA11(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetBuffered(
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
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Load();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/5ACE8143-DC14-495C-A644-A2076FB1980F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5ACE8143-DC14-495C-A644-A2076FB1980F(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int Load();

        /// <summary>
        /// Queries how likely it is that the Media Engine can play a specified type of media resource.
        /// </summary>
        /// <param name="type">A string that contains a MIME type with an optional codecs parameter, as defined in RFC 4281.</param>
        /// <param name="pAnswer">Receives an <see cref="MF_MEDIA_ENGINE_CANPLAY" /> enumeration value.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT CanPlayType(
        /// [in]   BSTR type,
        /// [out]  MF_MEDIA_ENGINE_CANPLAY *pAnswer
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/313F631F-7584-4F95-9208-B087CC12010E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/313F631F-7584-4F95-9208-B087CC12010E(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int CanPlayType(
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
        /// <code language="cpp" title="C/C++ Syntax">
        /// USHORT GetReadyState();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/B8C9B600-87FD-4DE6-8794-5C1E41449554(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B8C9B600-87FD-4DE6-8794-5C1E41449554(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new MF_MEDIA_ENGINE_READY GetReadyState();

        /// <summary>
        /// Queries whether the Media Engine is currently seeking to a new playback position.
        /// </summary>
        /// <returns>
        /// Returns <strong>TRUE</strong> if the Media Engine is seeking, or <strong>FALSE</strong> otherwise. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// BOOL IsSeeking();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/B314D5E7-EBD4-42CF-9E86-206ABC3027A0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B314D5E7-EBD4-42CF-9E86-206ABC3027A0(v=VS.85,d=hv.2).aspx</a></remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        new bool IsSeeking();

        /// <summary>
        /// Gets the current playback position.
        /// </summary>
        /// <returns>
        /// Returns the playback position, in seconds.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// double GetCurrentTime();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/49FA2383-8AEC-4DDF-8998-25987EEC8223(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/49FA2383-8AEC-4DDF-8998-25987EEC8223(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new double GetCurrentTime();

        /// <summary>
        /// Seeks to a new playback position.
        /// </summary>
        /// <param name="seekTime">The new playback position, in seconds.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetCurrentTime(
        /// [in]  double seekTime
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/C64BCBA0-097E-4035-BFEE-F9EC949B109A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C64BCBA0-097E-4035-BFEE-F9EC949B109A(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetCurrentTime(
            double seekTime
            );

        /// <summary>
        /// Gets the initial playback position.
        /// </summary>
        /// <returns>
        /// Returns the initial playback position, in seconds.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// double GetStartTime();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/18793EC9-D04A-443F-8469-44CC00C4EE27(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/18793EC9-D04A-443F-8469-44CC00C4EE27(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new double GetStartTime();

        /// <summary>
        /// Gets the duration of the media resource.
        /// </summary>
        /// <returns>
        /// Returns the duration, in seconds. If no media data is available, the method returns not-a-number
        /// (NaN). If the duration is unbounded, the method returns an infinite value.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// double GetDuration();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/E5C793A2-7C6F-42D0-B8DE-17F1B62A0352(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E5C793A2-7C6F-42D0-B8DE-17F1B62A0352(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new double GetDuration();

        /// <summary>
        /// Queries whether playback is currently paused.
        /// </summary>
        /// <returns>
        /// Returns <strong>TRUE</strong> if playback is paused, or <strong>FALSE</strong> otherwise. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// BOOL IsPaused();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/A2E9C498-FEEB-4506-9E69-59028A6B4EE5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A2E9C498-FEEB-4506-9E69-59028A6B4EE5(v=VS.85,d=hv.2).aspx</a></remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        new bool IsPaused();

        /// <summary>
        /// Gets the default playback rate.
        /// </summary>
        /// <returns>
        /// Returns the default playback rate, as a multiple of normal (1×) playback. A negative value
        /// indicates reverse playback.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// double GetDefaultPlaybackRate();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/FF7E9E76-B85E-40BB-88BD-5033FCE31177(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FF7E9E76-B85E-40BB-88BD-5033FCE31177(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new double GetDefaultPlaybackRate();

        /// <summary>
        /// Sets the default playback rate.
        /// </summary>
        /// <param name="Rate">The default playback rate, as a multiple of normal (1×) playback. A negative value indicates
        /// reverse playback.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetDefaultPlaybackRate(
        /// [in]  double Rate
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/D6EA6BC1-021A-432D-BBCB-BE2FD15E7BE5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D6EA6BC1-021A-432D-BBCB-BE2FD15E7BE5(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetDefaultPlaybackRate(
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
        /// <code language="cpp" title="C/C++ Syntax">
        /// double GetPlaybackRate();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/E270CB86-D90B-43FA-843B-F824970BD4F3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E270CB86-D90B-43FA-843B-F824970BD4F3(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new double GetPlaybackRate();

        /// <summary>
        /// Sets the current playback rate.
        /// </summary>
        /// <param name="Rate">The playback rate, as a multiple of normal (1×) playback. A negative value indicates reverse
        /// playback.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetPlaybackRate(
        /// [in]  double Rate
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/648BF1CC-BFAC-4874-808B-F8B46E3E9989(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/648BF1CC-BFAC-4874-808B-F8B46E3E9989(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetPlaybackRate(
            double Rate
            );

        /// <summary>
        /// Gets the time ranges that have been rendered.
        /// </summary>
        /// <param name="ppPlayed">Receives a pointer to the <see cref="IMFMediaTimeRange" /> interface. The caller must release the
        /// interface.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetPlayed(
        /// [out]  IMFMediaTimeRange **ppPlayed
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/E74D1785-E8BA-4B3A-9FF8-63FBDED5FA9E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E74D1785-E8BA-4B3A-9FF8-63FBDED5FA9E(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetPlayed(
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
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetSeekable(
        /// [out]  IMFMediaTimeRange **ppPlayed
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/FB238892-B172-4E31-B4E5-68C96E135345(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FB238892-B172-4E31-B4E5-68C96E135345(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetSeekable(
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
        /// <code language="cpp" title="C/C++ Syntax">
        /// BOOL IsEnded();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/0760707C-B25E-44FF-9263-6B59BF43A98E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0760707C-B25E-44FF-9263-6B59BF43A98E(v=VS.85,d=hv.2).aspx</a></remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        new bool IsEnded();

        /// <summary>
        /// Queries whether the Media Engine automatically begins playback.
        /// </summary>
        /// <returns>
        /// Returns <strong>TRUE</strong> if the Media Engine automatically begins playback, or <strong>FALSE
        /// </strong> otherwise. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// BOOL GetAutoPlay();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/CEF50308-D4F9-435F-A81A-3746A27846F0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CEF50308-D4F9-435F-A81A-3746A27846F0(v=VS.85,d=hv.2).aspx</a></remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        new bool GetAutoPlay();

        /// <summary>
        /// Specifies whether the Media Engine automatically begins playback.
        /// </summary>
        /// <param name="AutoPlay">If <strong>TRUE</strong>, the Media Engine automatically begins playback after it loads a media
        /// source. Otherwise, playback does not begin until the application calls
        /// <see cref="IMFMediaEngine.Play" />.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetAutoPlay(
        /// [in]  BOOL AutoPlay
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/867FE1D2-39AE-4A44-99DD-98A8ABD234A2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/867FE1D2-39AE-4A44-99DD-98A8ABD234A2(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetAutoPlay(
            [MarshalAs(UnmanagedType.Bool)] bool AutoPlay
            );

        /// <summary>
        /// Queries whether the Media Engine will loop playback.
        /// </summary>
        /// <returns>
        /// Returns <strong>TRUE</strong> if looping is enabled, or <strong>FALSE</strong> otherwise. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// BOOL GetLoop();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/EBAB4E73-164D-4AE5-87A4-0D37C10071E9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EBAB4E73-164D-4AE5-87A4-0D37C10071E9(v=VS.85,d=hv.2).aspx</a></remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        new bool GetLoop();

        /// <summary>
        /// Specifies whether the Media Engine loops playback.
        /// </summary>
        /// <param name="Loop">Specify <strong>TRUE</strong> to enable looping, or <strong>FALSE</strong> to disable looping.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetLoop(
        /// [in]  BOOL Loop
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/0B8890EA-9207-428B-8EC2-18B51E1D8365(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0B8890EA-9207-428B-8EC2-18B51E1D8365(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetLoop(
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
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Play();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/2D6083F5-734A-4350-8E54-56C79038389D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2D6083F5-734A-4350-8E54-56C79038389D(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int Play();

        /// <summary>
        /// Pauses playback.
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Pause();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/5C1FEBDA-18B5-4BF4-9AF4-FF6DBCDD880D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5C1FEBDA-18B5-4BF4-9AF4-FF6DBCDD880D(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int Pause();

        /// <summary>
        /// Queries whether the audio is muted. 
        /// </summary>
        /// <returns>
        /// Returns <strong>TRUE</strong> if the audio is muted, or <strong>FALSE</strong> otherwise. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// BOOL GetMuted();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/6EDDE60A-1571-4021-B56F-4185694B0911(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6EDDE60A-1571-4021-B56F-4185694B0911(v=VS.85,d=hv.2).aspx</a></remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        new bool GetMuted();

        /// <summary>
        /// Mutes or unmutes the audio. 
        /// </summary>
        /// <param name="Muted">Specify <strong>TRUE</strong> to mute the audio, or <strong>FALSE</strong> to unmute the audio.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetMuted(
        /// [in]  BOOL Muted
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/330CB3CF-F649-4964-A24D-3C16E778BFD7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/330CB3CF-F649-4964-A24D-3C16E778BFD7(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetMuted(
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
        /// <code language="cpp" title="C/C++ Syntax">
        /// double GetVolume();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/E7890777-480E-4EA1-88BA-657182B66010(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E7890777-480E-4EA1-88BA-657182B66010(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new double GetVolume();

        /// <summary>
        /// Sets the audio volume level.
        /// </summary>
        /// <param name="Volume">The volume level. Volume is expressed as an attenuation level, where 0.0 indicates silence and 1.0
        /// indicates full volume (no attenuation).</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetVolume(
        /// [in]  double Volume
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/010EE05C-3F81-404E-8AFB-7C57CA55A8AE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/010EE05C-3F81-404E-8AFB-7C57CA55A8AE(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetVolume(
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
        /// <code language="cpp" title="C/C++ Syntax">
        /// BOOL HasVideo();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/30B7F4DC-B3EB-421B-998B-E098F04D4B33(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/30B7F4DC-B3EB-421B-998B-E098F04D4B33(v=VS.85,d=hv.2).aspx</a></remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        new bool HasVideo();

        /// <summary>
        /// Queries whether the current media resource contains an audio stream.
        /// </summary>
        /// <returns>
        /// Returns <strong>TRUE</strong> if the current media resource contains an audio stream. Returns 
        /// <strong>FALSE</strong> if there is no media resource or the media resource does not contain an
        /// audio stream. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// BOOL HasAudio();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/D06A773E-8D41-40D1-BA10-65AEFF2D7667(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D06A773E-8D41-40D1-BA10-65AEFF2D7667(v=VS.85,d=hv.2).aspx</a></remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        new bool HasAudio();

        /// <summary>
        /// Gets the size of the video frame, adjusted for aspect ratio.
        /// </summary>
        /// <param name="cx">Receives the width in pixels.</param>
        /// <param name="cy">Receives the height in pixels.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetNativeVideoSize(
        /// [out]  DWORD *cx,
        /// [out]  DWORD *cy
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/843F09F7-2E8B-4DF7-AF0C-136BB8626779(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/843F09F7-2E8B-4DF7-AF0C-136BB8626779(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetNativeVideoSize(
            out int cx,
            out int cy
            );

        /// <summary>
        /// Gets the picture aspect ratio of the video stream.
        /// </summary>
        /// <param name="cx">Receives the x component of the aspect ratio.</param>
        /// <param name="cy">Receives the y component of the aspect ratio.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetVideoAspectRatio(
        /// [out]  DWORD *cx,
        /// [out]  DWORD *cy
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/82B4AD4B-1A2E-4B03-8343-E4E5A43E62D2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/82B4AD4B-1A2E-4B03-8343-E4E5A43E62D2(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetVideoAspectRatio(
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
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Shutdown();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/8B7BCEAC-7A30-4B60-AD0E-E8DCE404DDE9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8B7BCEAC-7A30-4B60-AD0E-E8DCE404DDE9(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int Shutdown();

        /// <summary>
        /// Copies the current video frame to a DXGI surface or WIC bitmap.
        /// </summary>
        /// <param name="pDstSurf">A pointer to the <c>IUnknown</c> interface of the destination surface.</param>
        /// <param name="pSrc">A pointer to an <see cref="EVR.MFVideoNormalizedRect" /> structure that specifies the source
        /// rectangle.</param>
        /// <param name="pDst">A pointer to a <c>RECT</c> structure that specifies the destination rectangle.</param>
        /// <param name="pBorderClr">A pointer to an <see cref="MFARGB" /> structure that specifies the border color.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT TransferVideoFrame(
        /// [in]  IUnknown *pDstSurf,
        /// [in]  const MFVideoNormalizedRect *pSrc,
        /// [in]  const RECT *pDst,
        /// [in]  const MFARGB *pBorderClr
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/07DB29E2-9F09-46CB-B138-197D95EC37F0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/07DB29E2-9F09-46CB-B138-197D95EC37F0(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int TransferVideoFrame(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pDstSurf,
            [In] MFVideoNormalizedRect pSrc,
            [In] MFRect pDst,
            [In] MFARGB pBorderClr
            );

        /// <summary>
        /// Queries the Media Engine to find out whether a new video frame is ready.
        /// </summary>
        /// <param name="pPts">If a new frame is ready, receives the presentation time of the frame.</param>
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
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnVideoStreamTick(
        /// [out]  LONGLONG *pPts
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/EC06D3D6-F103-4932-96C1-B55A59CD5E34(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EC06D3D6-F103-4932-96C1-B55A59CD5E34(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int OnVideoStreamTick(
            out long pPts
            );

        #endregion

        /// <summary>
        /// Opens a media resource from a byte stream.
        /// </summary>
        /// <param name="pByteStream">
        /// A pointer to the <see cref="IMFByteStream"/> interface of the byte stream. 
        /// </param>
        /// <param name="pURL">
        /// The URL of the byte stream.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetSourceFromByteStream(
        ///   [in]  IMFByteStream *pByteStream,
        ///   [in]  BSTR pURL
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F643383E-AABA-4F32-BCE9-0AA4FD635A0F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F643383E-AABA-4F32-BCE9-0AA4FD635A0F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetSourceFromByteStream(
            IMFByteStream pByteStream,
            [MarshalAs(UnmanagedType.BStr)] string pURL
            );

        /// <summary>
        /// Gets a playback statistic from the Media Engine.
        /// </summary>
        /// <param name="StatisticID">
        /// A member of the <see cref="MF_MEDIA_ENGINE_STATISTIC"/> enumeration that identifies the statistic
        /// to get. 
        /// </param>
        /// <param name="pStatistic">
        /// A pointer to a <c>PROPVARIANT</c> that receives the statistic. The data type and meaning of this
        /// value depends on the value of <em>StatisticID</em>. The caller must free the <strong>PROPVARIANT
        /// </strong> by calling <c>PropVariantClear</c>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStatistics(
        ///   [in]   MF_MEDIA_ENGINE_STATISTIC StatisticID,
        ///   [out]  PROPVARIANT *pStatistic
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3C2FDE86-2EBD-4A5C-BD02-90613DBFDE65(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3C2FDE86-2EBD-4A5C-BD02-90613DBFDE65(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStatistics(
            MF_MEDIA_ENGINE_STATISTIC StatisticID,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PropVariantMarshaler))] PropVariant pStatistic
            );

        /// <summary>
        /// Updates the source rectangle, destination rectangle, and border color for the video.
        /// </summary>
        /// <param name="pSrc">
        /// A pointer to an <see cref="EVR.MFVideoNormalizedRect"/> structure that specifies the source
        /// rectangle. The source rectangle defines the area of the video frame that is displayed. If this
        /// parameter is <strong>NULL</strong>, the entire video frame is displayed. 
        /// </param>
        /// <param name="pDst">
        /// A pointer to a <c>RECT</c> structure that specifies the destination rectangle. The destination
        /// rectangle defines the area of the window or DirectComposition visual where the video is drawn. 
        /// </param>
        /// <param name="pBorderClr">
        /// A pointer to an <see cref="MFARGB"/> structure that specifies the border color. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT UpdateVideoStream(
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
        /// <a href="http://msdn.microsoft.com/en-US/library/2A9EB449-ED76-4E2C-BC55-20E134B43B43(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2A9EB449-ED76-4E2C-BC55-20E134B43B43(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int UpdateVideoStream(
            [In] MFVideoNormalizedRect pSrc,
            [In] MFRect pDst,
            [In] MFARGB pBorderClr
            );

        /// <summary>
        /// Gets the audio balance. 
        /// </summary>
        /// <returns>
        /// Returns the balance. The value can be any number in the following range (inclusive). 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return value</term><description>Description</description></listheader>
        /// <item><term>-1</term><description>The left channel is at full volume; the right channel is silent. </description></item>
        /// <item><term>1</term><description>The right channel is at full volume; the left channel is silent. </description></item>
        /// </list>
        /// <para/>
        /// If the value is zero, the left and right channels are at equal volumes. The default value is zero. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// double GetBalance();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/57935B52-27BE-47AF-8702-9DF91E1B515D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/57935B52-27BE-47AF-8702-9DF91E1B515D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        double GetBalance();

        /// <summary>
        /// Sets the audio balance.
        /// </summary>
        /// <param name="balance">
        /// The audio balance. The value can be any number in the following range (inclusive). 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>-1</term><description>The left channel is at full volume; the right channel is silent. </description></item>
        /// <item><term>1</term><description>The right channel is at full volume; the left channel is silent. </description></item>
        /// </list>
        /// <para/>
        /// If the value is zero, the left and right channels are at equal volumes. The default value is zero. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetBalance(
        ///   [in]  double balance
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/11187826-B873-4182-A77B-FD9CCECFBAE5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/11187826-B873-4182-A77B-FD9CCECFBAE5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetBalance(
            double balance
            );

        /// <summary>
        /// Queries whether the Media Engine can play at a specified playback rate.
        /// </summary>
        /// <param name="rate">
        /// The requested playback rate.
        /// </param>
        /// <returns>
        /// Returns <strong>TRUE</strong> if the playback rate is supported, or <strong>FALSE</strong>
        /// otherwise. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// BOOL IsPlaybackRateSupported(
        ///   [in]  double rate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2BE9954A-0B67-45A8-9B79-1148DCB4DDC4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2BE9954A-0B67-45A8-9B79-1148DCB4DDC4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsPlaybackRateSupported(
            double rate
            );

        /// <summary>
        /// Steps forward or backward one frame.
        /// </summary>
        /// <param name="Forward">
        /// Specify <strong>TRUE</strong> to step forward or <strong>FALSE</strong> to step backward. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT FrameStep(
        ///   [in]  BOOL Forward
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/090B5B6F-E4D1-43D7-AD09-BA3008B48104(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/090B5B6F-E4D1-43D7-AD09-BA3008B48104(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int FrameStep(
            [MarshalAs(UnmanagedType.Bool)] bool Forward
            );

        /// <summary>
        /// Gets various flags that describe the media resource.
        /// </summary>
        /// <param name="pCharacteristics">
        /// Receives a bitwise <strong>OR</strong> of zero or more flags. The following flags are defined. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>0x00000001</term><description>The media resource represents a live data source, such as a video camera. If playback is stopped and then restarted, there will be a gap in the content. </description></item>
        /// <item><term>0x00000002</term><description>The media resource supports seeking. To get the seekable range, call <see cref="IMFMediaEngine.GetSeekable"/>. </description></item>
        /// <item><term>0x00000003</term><description>The media resource can be paused.</description></item>
        /// <item><term>0x00000004</term><description>Seeking this resource can take a long time. For example, it might download through HTTP.</description></item>
        /// </list>
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetResourceCharacteristics(
        ///   [out]  DWORD *pCharacteristics
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/534595D7-007F-450B-A1C7-FA08F3958417(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/534595D7-007F-450B-A1C7-FA08F3958417(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetResourceCharacteristics(
            out int pCharacteristics
            );

        /// <summary>
        /// Gets a presentation attribute from the media resource.
        /// </summary>
        /// <param name="guidMFAttribute">
        /// The attribute to query. For a list of presentation attributes, see 
        /// <c>Presentation Descriptor Attributes</c>. 
        /// </param>
        /// <param name="pvValue">
        /// A pointer to a <c>PROPVARIANT</c> that receives the value. The method fills the <strong>PROPVARIANT
        /// </strong> with a copy of the stored value. The caller must free the <strong>PROPVARIANT</strong> by
        /// calling <c>PropVariantClear</c>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetPresentationAttribute(
        ///   [in]   REFGUID guidMFAttribute,
        ///   [out]  PROPVARIANT *pvValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/127667EA-8ED2-428E-8F6B-C280CF42E1C5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/127667EA-8ED2-428E-8F6B-C280CF42E1C5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetPresentationAttribute(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidMFAttribute,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PropVariantMarshaler))] PropVariant pvValue
            );

        /// <summary>
        /// Gets the number of streams in the media resource.
        /// </summary>
        /// <param name="pdwStreamCount">
        /// Receives the number of streams.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetNumberOfStreams(
        ///   [out]  DWORD *pdwStreamCount
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7F3E805A-FE5C-4B75-9333-AE9819CFAFFA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7F3E805A-FE5C-4B75-9333-AE9819CFAFFA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetNumberOfStreams(
            out int pdwStreamCount
            );

        /// <summary>
        /// Gets a stream-level attribute from the media resource.
        /// </summary>
        /// <param name="dwStreamIndex">
        /// The zero-based index of the stream. To get the number of streams, call 
        /// <see cref="IMFMediaEngineEx.GetNumberOfStreams"/>. 
        /// </param>
        /// <param name="guidMFAttribute">
        /// The attribute to query. Possible values are listed in the following topics: 
        /// <para/>
        /// <para>* <c>Stream Descriptor Attributes</c></para><para>* <c>Media Type Attributes</c></para>
        /// </param>
        /// <param name="pvValue">
        /// A pointer to a <c>PROPVARIANT</c> that receives the value. The method fills the <strong>PROPVARIANT
        /// </strong> with a copy of the stored value. Call <c>PropVariantClear</c> to free the memory
        /// allocated by the method. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStreamAttribute(
        ///   [in]   DWORD dwStreamIndex,
        ///   [in]   REFGUID guidMFAttribute,
        ///   [out]  PROPVARIANT *pvValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2C64CD7B-F376-47DF-AD5A-DE5EBC665288(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2C64CD7B-F376-47DF-AD5A-DE5EBC665288(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStreamAttribute(
            int dwStreamIndex,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidMFAttribute,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PropVariantMarshaler))] PropVariant pvValue
            );

        /// <summary>
        /// Queries whether a stream is selected to play.
        /// </summary>
        /// <param name="dwStreamIndex">
        /// The zero-based index of the stream. To get the number of streams, call 
        /// <see cref="IMFMediaEngineEx.GetNumberOfStreams"/>. 
        /// </param>
        /// <param name="pEnabled">
        /// Receives a Boolean value.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong><strong>TRUE</strong></strong></term><description>The stream is selected. During playback, this stream will play.</description></item>
        /// <item><term><strong><strong>FALSE</strong></strong></term><description>The stream is not selected. During playback, this stream will not play. </description></item>
        /// </list>
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStreamSelection(
        ///   [in]   DWORD dwStreamIndex,
        ///   [out]  BOOL *pEnabled
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/93EA1E19-4333-484D-96C8-3244F7C040EF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/93EA1E19-4333-484D-96C8-3244F7C040EF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStreamSelection(
            int dwStreamIndex,
            [MarshalAs(UnmanagedType.Bool)] out bool pEnabled
            );

        /// <summary>
        /// Selects or deselects a stream for playback. 
        /// </summary>
        /// <param name="dwStreamIndex">
        /// The zero-based index of the stream. To get the number of streams, call 
        /// <see cref="IMFMediaEngineEx.GetNumberOfStreams"/>. 
        /// </param>
        /// <param name="Enabled">
        /// Specifies whether to select or deselect the stream.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong><strong>TRUE</strong></strong></term><description>The stream is selected. During playback, this stream will play.</description></item>
        /// <item><term><strong><strong>FALSE</strong></strong></term><description>The stream is not selected. During playback, this stream will not play.</description></item>
        /// </list>
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetStreamSelection(
        ///   [in]  DWORD dwStreamIndex,
        ///   [in]  BOOL Enabled
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/12F0FDD0-0D8C-496D-B5C4-3FBCBCAAC6FB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/12F0FDD0-0D8C-496D-B5C4-3FBCBCAAC6FB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetStreamSelection(
            int dwStreamIndex,
            [MarshalAs(UnmanagedType.Bool)] bool Enabled
            );

        /// <summary>
        /// Applies the stream selections from previous calls to <c>SetStreamSelection</c>. 
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT ApplyStreamSelections();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AAF8AD21-A790-4A78-B733-B6E3FFD859E1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AAF8AD21-A790-4A78-B733-B6E3FFD859E1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ApplyStreamSelections();

        /// <summary>
        /// Queries whether the media resource contains protected content. 
        /// </summary>
        /// <param name="pProtected">
        /// Receives the value <strong>TRUE</strong> if the media resource contains protected content, or 
        /// <strong>FALSE</strong> otherwise. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT IsProtected(
        ///   [out]  BOOL *pProtected
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/704C469D-C8C7-48D7-B41E-4475B4A9181D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/704C469D-C8C7-48D7-B41E-4475B4A9181D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int IsProtected(
            [MarshalAs(UnmanagedType.Bool)] out bool pProtected
            );

        /// <summary>
        /// Inserts a video effect.
        /// </summary>
        /// <param name="pEffect">
        /// One of the following: 
        /// <para/>
        /// <para>* A pointer to the <see cref="Transform.IMFTransform"/> interface of a Media Foundation
        /// transform (MFT) that implements the video effect. </para><para>* A pointer to the 
        /// <see cref="IMFActivate"/> interface of an activation object. The activation object must create an
        /// MFT for the video effect. </para>
        /// </param>
        /// <param name="fOptional">
        /// Specifies whether the effect is optional.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong><strong>TRUE</strong></strong></term><description>The effect is optional. If the Media Engine cannot add the effect, it ignores the effect and  continues playback.</description></item>
        /// <item><term><strong><strong>FALSE</strong></strong></term><description>The effect is required. If the Media Engine object cannot add the effect, a playback error occurs.</description></item>
        /// </list>
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The maximum number of video effects was reached.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT InsertVideoEffect(
        ///   [in]  IUnknown *pEffect,
        ///   [in]  BOOL fOptional
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7F59BE62-D3F1-4C5A-94FD-F864342797BF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7F59BE62-D3F1-4C5A-94FD-F864342797BF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int InsertVideoEffect(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pEffect,
            [MarshalAs(UnmanagedType.Bool)] bool fOptional
            );

        /// <summary>
        /// Inserts an audio effect.
        /// </summary>
        /// <param name="pEffect">
        /// One of the following: 
        /// <para/>
        /// <para>* A pointer to the <see cref="Transform.IMFTransform"/> interface of a Media Foundation
        /// transform (MFT) that implements the audio effect. </para><para>* A pointer to the 
        /// <see cref="IMFActivate"/> interface of an activation object. The activation object must create an
        /// MFT for the audio effect. </para>
        /// </param>
        /// <param name="fOptional">
        /// Specifies whether the effect is optional.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong><strong>TRUE</strong></strong></term><description>The effect is optional. If the Media Engine cannot add the effect, it ignores the effect and  continues playback.</description></item>
        /// <item><term><strong><strong>FALSE</strong></strong></term><description>The effect is required. If the Media Engine object cannot add the effect, a playback error occurs.</description></item>
        /// </list>
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The maximum number of audio effects was reached.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT InsertAudioEffect(
        ///   [in]  IUnknown *pEffect,
        ///   [in]  BOOL fOptional
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0D9ED497-A991-473F-A775-CA780A1E0E06(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0D9ED497-A991-473F-A775-CA780A1E0E06(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int InsertAudioEffect(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pEffect,
            [MarshalAs(UnmanagedType.Bool)] bool fOptional
            );

        /// <summary>
        /// Removes all audio and video effects.
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT RemoveAllEffects();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B9EF1440-27DA-48C6-B840-FF61DBF19E63(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B9EF1440-27DA-48C6-B840-FF61DBF19E63(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RemoveAllEffects();

        /// <summary>
        /// Specifies a presentation time when the Media Engine will send a marker event.
        /// </summary>
        /// <param name="timeToFire">
        /// The presentation time for the marker event, in seconds.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetTimelineMarkerTimer(
        ///   [in]  double timeToFire
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2FD65E4A-C70A-4CB4-9038-3A8B791E251C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2FD65E4A-C70A-4CB4-9038-3A8B791E251C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetTimelineMarkerTimer(
            double timeToFire
            );

        /// <summary>
        /// Gets the time of the next timeline marker, if any.
        /// </summary>
        /// <param name="pTimeToFire">
        /// Receives the marker time, in seconds. If no marker is set, this parameter receives the value 
        /// <strong>NaN</strong>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetTimelineMarkerTimer(
        ///   [out]  double *pTimeToFire
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8C58DBB6-A55E-4992-B4F2-EB36E15FA7A1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8C58DBB6-A55E-4992-B4F2-EB36E15FA7A1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetTimelineMarkerTimer(
            out double pTimeToFire
            );

        /// <summary>
        /// Cancels the next pending timeline marker.
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT CancelTimelineMarkerTimer();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AC295919-747B-445D-8C74-E648A612C0BF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AC295919-747B-445D-8C74-E648A612C0BF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CancelTimelineMarkerTimer();

        /// <summary>
        /// Queries whether the media resource contains stereoscopic 3D video.
        /// </summary>
        /// <returns>
        /// Returns <strong>TRUE</strong> if the media resource contains 3D video, or <strong>FALSE</strong>
        /// otherwise. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// BOOL IsStereo3D();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9E1C2E47-416F-4016-A576-7BE360A66A81(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9E1C2E47-416F-4016-A576-7BE360A66A81(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsStereo3D();

        /// <summary>
        /// For stereoscopic 3D video, gets the layout of the two views within a video frame.
        /// </summary>
        /// <param name="packMode">
        /// Receives a member of the <see cref="MF_MEDIA_ENGINE_S3D_PACKING_MODE"/> enumeration. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStereo3DFramePackingMode(
        ///   [out]  MF_MEDIA_ENGINE_S3D_PACKING_MODE *packMode
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/003204DB-DDAD-4F72-BA25-015B033BAC92(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/003204DB-DDAD-4F72-BA25-015B033BAC92(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStereo3DFramePackingMode(
            out MF_MEDIA_ENGINE_S3D_PACKING_MODE packMode
            );

        /// <summary>
        /// For stereoscopic 3D video, sets the layout of the two views within a video frame.
        /// </summary>
        /// <param name="packMode">
        /// A member of the <see cref="MF_MEDIA_ENGINE_S3D_PACKING_MODE"/> enumeration that specifies the
        /// layout. The two views can be arranged side-by-side, or top-to-bottom. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetStereo3DFramePackingMode(
        ///   [in]  MF_MEDIA_ENGINE_S3D_PACKING_MODE packMode
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E6B1EFA3-188E-495C-A38C-9CD48214BD23(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E6B1EFA3-188E-495C-A38C-9CD48214BD23(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetStereo3DFramePackingMode(
            MF_MEDIA_ENGINE_S3D_PACKING_MODE packMode
            );

        /// <summary>
        /// For stereoscopic 3D video, queries how the Media Engine renders the 3D video content.
        /// </summary>
        /// <param name="outputType">
        /// Receives a member of the <see cref="Transform.MF3DVideoOutputType"/> enumeration. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStereo3DRenderMode(
        ///   [out]  MF3DVideoOutputType *outputType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/204C9B35-860F-46FD-AF3F-7BC7E1EE12EF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/204C9B35-860F-46FD-AF3F-7BC7E1EE12EF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStereo3DRenderMode(
            out MF3DVideoOutputType outputType
            );

        /// <summary>
        /// For stereoscopic 3D video, specifies how the Media Engine renders the 3D video content.
        /// </summary>
        /// <param name="outputType">
        /// A member of the <see cref="Transform.MF3DVideoOutputType"/> enumeration that specifies the 3D video
        /// rendering mode. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetStereo3DRenderMode(
        ///   [in]  MF3DVideoOutputType outputType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/89B6B2AC-A721-4C56-BF0A-A19350FE4823(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/89B6B2AC-A721-4C56-BF0A-A19350FE4823(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetStereo3DRenderMode(
            MF3DVideoOutputType outputType
            );

        /// <summary>
        /// Enables or disables windowless swap-chain mode.
        /// </summary>
        /// <param name="fEnable">
        /// If <strong>TRUE</strong>, windowless swap-chain mode is enabled. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT EnableWindowlessSwapchainMode(
        ///   [in]  BOOL fEnable
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B93429D7-A0DF-4440-A164-C140334FC0A6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B93429D7-A0DF-4440-A164-C140334FC0A6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EnableWindowlessSwapchainMode(
            [MarshalAs(UnmanagedType.Bool)] bool fEnable
            );

        /// <summary>
        /// Gets a handle to the windowless swap chain.
        /// </summary>
        /// <param name="phSwapchain">
        /// Receives a handle to the swap chain.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetVideoSwapchainHandle(
        ///   [out]  HANDLE *phSwapchain
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23AE2296-F0BF-4060-9849-F6A0E0C13B86(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23AE2296-F0BF-4060-9849-F6A0E0C13B86(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetVideoSwapchainHandle(
            out IntPtr phSwapchain
            );

        /// <summary>
        /// Enables or disables mirroring of the video.
        /// </summary>
        /// <param name="fEnable">
        /// If <strong>TRUE</strong>, the video is mirrored horizontally. Otherwise, the video is displayed
        /// normally. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT EnableHorizontalMirrorMode(
        ///   [in]  BOOL fEnable
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1B8F2CE8-0963-472F-8C30-AE2BBA844D26(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1B8F2CE8-0963-472F-8C30-AE2BBA844D26(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EnableHorizontalMirrorMode(
            [MarshalAs(UnmanagedType.Bool)] bool fEnable
            );

        /// <summary>
        /// Gets the audio stream category used for the next call to <c>SetSource</c> or <c>Load</c>. 
        /// </summary>
        /// <param name="pCategory">
        /// Receives the audio stream category.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetAudioStreamCategory(
        ///   [out]  UINT32 *pCategory
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/587C0844-93BE-42E4-96F6-D5AA721E9CED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/587C0844-93BE-42E4-96F6-D5AA721E9CED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetAudioStreamCategory(
            out int pCategory
            );

        /// <summary>
        /// Sets the audio stream category for the next call to <c>SetSource</c> or <c>Load</c>. 
        /// </summary>
        /// <param name="category">
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetAudioStreamCategory(
        ///   [in]  UINT32 category
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/55906E89-4064-4355-AD44-7D7D973DDB2C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/55906E89-4064-4355-AD44-7D7D973DDB2C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetAudioStreamCategory(
            int category
            );

        /// <summary>
        /// Gets the audio device endpoint role used for the next call to <c>SetSource</c> or <c>Load</c>. 
        /// </summary>
        /// <param name="pRole">
        /// Receives the audio endpoint role.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetAudioEndpointRole(
        ///   [out]  UINT32 *pRole
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F63FA14E-44E6-41B9-A8C9-4B8EB66E98E0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F63FA14E-44E6-41B9-A8C9-4B8EB66E98E0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetAudioEndpointRole(
            out int pRole
            );

        /// <summary>
        /// Sets the audio device endpoint used for the next call to <c>SetSource</c> or <c>Load</c>. 
        /// </summary>
        /// <param name="role">
        /// Specifies the audio end point role.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetAudioEndpointRole(
        ///   [in]  UINT32 role
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/00FD78CE-E046-40A0-8BAD-F4A1E1F517BB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/00FD78CE-E046-40A0-8BAD-F4A1E1F517BB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetAudioEndpointRole(
            int role
            );

        /// <summary>
        /// Gets the real time mode used for the next call to <c>SetSource</c> or <c>Load</c>. 
        /// </summary>
        /// <param name="pfEnabled">
        /// Receives the real time mode.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetRealTimeMode(
        ///   [out]  BOOL *pfEnabled
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/473A2B5A-5B9D-4754-BD32-89C9C4AB8C4A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/473A2B5A-5B9D-4754-BD32-89C9C4AB8C4A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetRealTimeMode(
            [MarshalAs(UnmanagedType.Bool)] out bool pfEnabled
            );

        /// <summary>
        /// Sets the real time mode used for the next call to <c>SetSource</c> or <c>Load</c>. 
        /// </summary>
        /// <param name="fEnable">
        /// Specifies the real time mode.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetRealTimeMode(
        ///   [in]  BOOL fEnable
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/31534F69-33EC-41D3-93AA-F4C457649E48(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/31534F69-33EC-41D3-93AA-F4C457649E48(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetRealTimeMode(
            [MarshalAs(UnmanagedType.Bool)] bool fEnable
            );

        /// <summary>
        /// Seeks to a new playback position using the specified <see cref="MF_MEDIA_ENGINE_SEEK_MODE"/>. 
        /// </summary>
        /// <param name="seekTime">
        /// The new playback position, in seconds.
        /// </param>
        /// <param name="seekMode">
        /// Specifies if the seek is a normal seek or an approximate seek.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetCurrentTimeEx(
        ///   [in]  double seekTime,
        ///   [in]  MF_MEDIA_ENGINE_SEEK_MODE seekMode
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EE594F0C-AF49-44C2-8C68-16120F76C5E1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EE594F0C-AF49-44C2-8C68-16120F76C5E1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetCurrentTimeEx(
            double seekTime,
            MF_MEDIA_ENGINE_SEEK_MODE seekMode
            );

        /// <summary>
        /// Enables or disables the time update timer.
        /// </summary>
        /// <param name="fEnableTimer">
        /// If <strong>TRUE</strong>, the update timer is enabled. Otherwise, the timer is disabled. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT EnableTimeUpdateTimer(
        ///   [in]  BOOL fEnableTimer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/07128937-BB90-4ED5-85EF-E58C8A273D39(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/07128937-BB90-4ED5-85EF-E58C8A273D39(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EnableTimeUpdateTimer(
            [MarshalAs(UnmanagedType.Bool)] bool fEnableTimer
            );
    }

#endif

}
