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


    /// <summary>
    /// Implemented by the transcode profile object.
    /// <para/>
    /// The transcode profile stores configuration settings that the topology builder uses to generate the
    /// transcode topology for the output file. These configuration settings are specified by the caller
    /// and include audio and video stream properties, encoder settings, and  container settings that are
    /// specified by the caller.
    /// <para/>
    /// To create the transcode profile object, call <see cref="MFExtern.MFCreateTranscodeProfile"/>. The
    /// configured transcode profile is passed to <see cref="MFExtern.MFCreateTranscodeTopology"/>, which
    /// creates the transcode topology with the appropriate settings. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/82E012E0-84D8-4791-8B6F-BDA58B498A90(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/82E012E0-84D8-4791-8B6F-BDA58B498A90(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("4ADFDBA3-7AB0-4953-A62B-461E7FF3DA1E")]
    public interface IMFTranscodeProfile
    {
        /// <summary>
        /// Sets audio stream configuration settings  in the transcode profile.
        /// <para/>
        /// To get a list of compatible audio media types supported by the Media Foundation transform (MFT)
        /// encoder , call <see cref="MFExtern.MFTranscodeGetAudioOutputAvailableTypes"/>. You can get the
        /// attributes that are set on the required media type and set them on the transcode profile. To set
        /// the audio attributes properly, create a new attribute store and copy the attribute store from the
        /// required media media type by calling <see cref="IMFAttributes.CopyAllItems"/>. This makes sure that
        /// the caller does not hold the references to the media type retrieved from the encoder. For example
        /// code, see <see cref="MFExtern.MFCreateTranscodeProfile"/>. 
        /// </summary>
        /// <param name="pAttrs">
        /// Pointer to the <see cref="IMFAttributes"/> interface of an attribute store that contains the
        /// configuration settings for the audio stream. The specified attribute values overwrite any existing
        /// values stored in the transcode profile. 
        /// <para/>
        /// The following audio attributes can be set:
        /// <para/>
        /// <para>* <c>Audio Media Types</c></para><para>* 
        /// <see cref="MFAttributesClsid.MF_TRANSCODE_DONOT_INSERT_ENCODER"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_TRANSCODE_ENCODINGPROFILE"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_TRANSCODE_QUALITYVSSPEED"/></para>
        /// <para/>
        /// To create the attribute store, call <see cref="MFExtern.MFCreateAttributes"/>. To set a specific
        /// attribute value in the attribute store, the caller must call the appropriate 
        /// <see cref="IMFAttributes"/> methods depending on the data type of the attribute. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetAudioAttributes(
        ///   [in]  IMFAttributes *pAttrs
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4118BB2B-8373-434A-896B-DE5A1BA8C793(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4118BB2B-8373-434A-896B-DE5A1BA8C793(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetAudioAttributes(
            IMFAttributes pAttrs
        );

        /// <summary>
        /// Gets the audio stream settings that are currently set in the transcode profile. 
        /// </summary>
        /// <param name="ppAttrs">
        /// Receives a pointer to the <see cref="IMFAttributes"/> interface of the attribute store containing
        /// the current audio stream settings. Caller must release the interface pointer. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetAudioAttributes(
        ///   [out]  IMFAttributes **ppAttrs
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C02DABFE-33EF-4835-A707-D1350B18629F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C02DABFE-33EF-4835-A707-D1350B18629F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetAudioAttributes(
            out IMFAttributes ppAttrs
        );

        /// <summary>
        /// Sets video stream configuration settings  in the transcode profile.
        /// <para/>
        /// For example code, see <see cref="MFExtern.MFCreateTranscodeProfile"/>. 
        /// </summary>
        /// <param name="pAttrs">
        /// Pointer to the <see cref="IMFAttributes"/> interface of an attribute store that contains contains
        /// the configuration settings for the video stream. The specified attribute values overwrites any
        /// existing values stored in the transcode profile. 
        /// <para/>
        /// The following video attributes can be set:
        /// <para/>
        /// <para>* <c>Video Media Types</c></para><para>* 
        /// <see cref="MFAttributesClsid.MF_TRANSCODE_DONOT_INSERT_ENCODER"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_TRANSCODE_ENCODINGPROFILE"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_TRANSCODE_QUALITYVSSPEED"/></para>
        /// <para/>
        /// To create the attribute store, call <see cref="MFExtern.MFCreateAttributes"/>. To set a specific
        /// attribute value in the attribute store, the caller must call the appropriate 
        /// <see cref="IMFAttributes"/> methods depending on the data type of the attribute. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetVideoAttributes(
        ///   [in]  IMFAttributes *pAttrs
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E68653C5-5663-4839-A482-2244E147F4B9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E68653C5-5663-4839-A482-2244E147F4B9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetVideoAttributes(
            IMFAttributes pAttrs
        );

        /// <summary>
        /// Gets the video stream settings that are currently set in the transcode profile.
        /// </summary>
        /// <param name="ppAttrs">
        /// Receives a pointer to the <see cref="IMFAttributes"/> interface of the attribute store containing
        /// the current video stream settings. Caller must release the interface pointer. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetVideoAttributes(
        ///   [out]  IMFAttributes **ppAttrs
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/734CB4D0-7017-4A30-9D0C-A6B5CE42FEC6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/734CB4D0-7017-4A30-9D0C-A6B5CE42FEC6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetVideoAttributes(
            out IMFAttributes ppAttrs
        );

        /// <summary>
        /// Sets container configuration settings  in the transcode profile.
        /// <para/>
        /// For example code, see <see cref="MFExtern.MFCreateTranscodeProfile"/>. 
        /// </summary>
        /// <param name="pAttrs">
        /// Pointer to the <see cref="IMFAttributes"/> interface of an attribute store that contains the
        /// configuration settings for the container in which the transcoded file will be stored. The specified
        /// attribute values overwrite any existing values stored in the transcode profile. 
        /// <para/>
        /// The following list shows the container attributes that can be set:
        /// <para/>
        /// <para>* <see cref="MFAttributesClsid.MF_TRANSCODE_ADJUST_PROFILE"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_TRANSCODE_CONTAINERTYPE"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_TRANSCODE_SKIP_METADATA_TRANSFER"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_TRANSCODE_TOPOLOGYMODE"/></para><para>* 
        /// <c>MFT_FIELDOFUSE_UNLOCK</c></para>
        /// <para/>
        /// To create the attribute store, call <see cref="MFExtern.MFCreateAttributes"/>. To set a specific
        /// attribute value in the attribute store, the caller must call the appropriate 
        /// <see cref="IMFAttributes"/> methods depending on the data type of the attribute. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetContainerAttributes(
        ///   [in]  IMFAttributes *pAttrs
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C62021CF-85F1-4A85-9263-B7883464F5F8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C62021CF-85F1-4A85-9263-B7883464F5F8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetContainerAttributes(
            IMFAttributes pAttrs
        );

        /// <summary>
        /// Gets the container settings that are currently set in the transcode profile.
        /// </summary>
        /// <param name="ppAttrs">
        /// Receives a pointer to the <see cref="IMFAttributes"/> interface of the attribute store containing
        /// the current container type for the output file. Caller must release the interface pointer. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetContainerAttributes(
        ///   [out]  IMFAttributes **ppAttrs
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/29BF5834-78AF-4521-95B1-DFD5764E96FC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/29BF5834-78AF-4521-95B1-DFD5764E96FC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetContainerAttributes(
            out IMFAttributes ppAttrs
        );
    }

#endif

}
