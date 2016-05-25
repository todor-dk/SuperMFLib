using MediaFoundation.Core;
using MediaFoundation.Core.Interfaces;
using MediaFoundation.Internals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="TranscodeProfile"/> class implements a wrapper around the
    /// <see cref="IMFTranscodeProfile"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFTranscodeProfile"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFTranscodeProfile"/>:
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
    public sealed class TranscodeProfile : COM<IMFTranscodeProfile>
    {
        #region Construction

        private TranscodeProfile(IntPtr comInterface)
            : base(comInterface)
        {
        }

        /// <summary>
        /// Creates a new <see cref="TranscodeProfile"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the TranscodeProfile's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be concidered void.
        /// </param>
        /// <returns>
        /// A new <see cref="TranscodeProfile"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static TranscodeProfile FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            TranscodeProfile result = new TranscodeProfile(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        /// <summary>
        /// Gets or sets audio stream configuration settings  in the transcode profile.
        /// <para/>
        /// To get a list of compatible audio media types supported by the Media Foundation transform (MFT)
        /// encoder , call <see cref="MFExtern.MFTranscodeGetAudioOutputAvailableTypes"/>. You can get the
        /// attributes that are set on the required media type and set them on the transcode profile. To set
        /// the audio attributes properly, create a new attribute store and copy the attribute store from the
        /// required media media type by calling <see cref="IMFAttributes.CopyAllItems"/>. This makes sure that
        /// the caller does not hold the references to the media type retrieved from the encoder. For example
        /// code, see <see cref="MFExtern.MFCreateTranscodeProfile"/>.
        /// </summary>
        /// <remarks>
        /// The following audio attributes can be set:
        /// <para/>
        /// <para>* <c>Audio Media Types</c></para><para>*
        /// <see cref="MFAttributesClsid.MF_TRANSCODE_DONOT_INSERT_ENCODER"/></para><para>*
        /// <see cref="MFAttributesClsid.MF_TRANSCODE_ENCODINGPROFILE"/></para><para>*
        /// <see cref="MFAttributesClsid.MF_TRANSCODE_QUALITYVSSPEED"/></para>
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/4118BB2B-8373-434A-896B-DE5A1BA8C793(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4118BB2B-8373-434A-896B-DE5A1BA8C793(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Attributes AudioAttributes
        {
            get
            {
                IntPtr ppAttrs;
                int hr = this.Interface.GetAudioAttributes(out ppAttrs);
                COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppAttrs);
                return Attributes.FromUnknown(ref ppAttrs);
            }

            set
            {
                int hr = this.Interface.SetAudioAttributes(value.AccessInterface());
                COM.ThrowIfNotOK(hr);
            }
        }

        /// <summary>
        /// Gets or sets video stream configuration settings  in the transcode profile.
        /// </summary>
        /// <remarks>
        /// The following video attributes can be set:
        /// <para/>
        /// <para>* <c>Video Media Types</c></para><para>*
        /// <see cref="MFAttributesClsid.MF_TRANSCODE_DONOT_INSERT_ENCODER"/></para><para>*
        /// <see cref="MFAttributesClsid.MF_TRANSCODE_ENCODINGPROFILE"/></para><para>*
        /// <see cref="MFAttributesClsid.MF_TRANSCODE_QUALITYVSSPEED"/></para>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/E68653C5-5663-4839-A482-2244E147F4B9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E68653C5-5663-4839-A482-2244E147F4B9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Attributes VideoAttributes
        {
            get
            {
                IntPtr ppAttrs;
                int hr = this.Interface.GetVideoAttributes(out ppAttrs);
                COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppAttrs);
                return Attributes.FromUnknown(ref ppAttrs);
            }

            set
            {
                int hr = this.Interface.SetVideoAttributes(value.AccessInterface());
                COM.ThrowIfNotOK(hr);
            }
        }

        /// <summary>
        /// Gets or sets container configuration settings  in the transcode profile.
        /// </summary>
        /// <remarks>
        /// The following list shows the container attributes that can be set:
        /// <para/>
        /// <para>* <see cref="MFAttributesClsid.MF_TRANSCODE_ADJUST_PROFILE"/></para><para>*
        /// <see cref="MFAttributesClsid.MF_TRANSCODE_CONTAINERTYPE"/></para><para>*
        /// <see cref="MFAttributesClsid.MF_TRANSCODE_SKIP_METADATA_TRANSFER"/></para><para>*
        /// <see cref="MFAttributesClsid.MF_TRANSCODE_TOPOLOGYMODE"/></para><para>*
        /// <c>MFT_FIELDOFUSE_UNLOCK</c></para>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/C62021CF-85F1-4A85-9263-B7883464F5F8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C62021CF-85F1-4A85-9263-B7883464F5F8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Attributes ContainerAttributes
        {
            get
            {
                IntPtr ppAttrs;
                int hr = this.Interface.GetContainerAttributes(out ppAttrs);
                COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppAttrs);
                return Attributes.FromUnknown(ref ppAttrs);
            }

            set
            {
                int hr = this.Interface.SetContainerAttributes(value.AccessInterface());
                COM.ThrowIfNotOK(hr);
            }
        }

        /// <summary>
        /// Creates an empty transcode profile object.
        /// <para/>
        /// The transcode profile stores configuration settings for the output file. These configuration
        /// settings are specified by the caller, and include audio and video stream properties, encoder
        /// settings, and container settings. To set these properties, the caller must call the appropriate
        /// <see cref="IMFTranscodeProfile"/> methods.
        /// <para/>
        /// The configured transcode profile is passed to the <see cref="MFExtern.MFCreateTranscodeTopology"/>
        /// function. The underlying topology builder uses these settings to build the transcode topology.
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/2A482C6F-6E20-419A-A7EB-085C41CC8186(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2A482C6F-6E20-419A-A7EB-085C41CC8186(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static TranscodeProfile Create()
        {
            IntPtr ppTranscodeProfile;
            int hr = MFExtern.MFCreateTranscodeProfile(out ppTranscodeProfile);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppTranscodeProfile);
            return TranscodeProfile.FromUnknown(ref ppTranscodeProfile);
        }

        /// <summary>
        /// Creates a partial transcode topology.
        /// <para/>
        /// The underlying topology builder creates a partial topology by connecting the required pipeline
        /// objects: source, encoder, and sink. The encoder and the sink are configured according to the
        /// settings specified by the caller in the transcode profile.
        /// <para/>
        /// The configured transcode profile is passed to the <strong>MFCreateTranscodeTopology</strong>
        /// function, which creates the transcode topology with the appropriate settings. The caller can then
        /// set this topology on the Media Session and start the session to begin the encoding process. When
        /// the Media Session ends, the transcoded file is generated.
        /// </summary>
        /// <param name="source">
        /// A media source that encapsulates the source file to be transcoded.
        /// </param>
        /// <param name="outputFilePath">
        /// String that contains the name and path of the output file to be generated.
        /// </param>
        /// <returns>
        /// The transcode topology object. The caller must release the interface.
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/EF3F19BF-1DB9-459D-9617-D6CCA9D6ABA7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EF3F19BF-1DB9-459D-9617-D6CCA9D6ABA7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Topology CreateTranscodeTopology(MediaSource source, string outputFilePath)
        {
            IntPtr ppTranscodeTopo;
            int hr = MFExtern.MFCreateTranscodeTopology(source.AccessInterface(), outputFilePath, this.AccessInterface(), out ppTranscodeTopo);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppTranscodeTopo);
            return Topology.FromUnknown(ref ppTranscodeTopo);
        }

        #endregion
    }
}
