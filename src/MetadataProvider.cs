using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;
using MediaFoundation.Core.Interfaces;
using MediaFoundation.Misc.Classes;
using System.Runtime.InteropServices;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MetadataProvider"/> class implements a wrapper around the
    /// <see cref="IMFMetadataProvider"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMetadataProvider"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMetadataProvider"/>:
    /// Gets metadata from a media source or other object.
    /// <para/>
    /// If a media source supports this interface, it must expose the interface as a service. To get a
    /// pointer to this interface from a media source, call <see cref="IMFGetService.GetService"/>. The
    /// service identifier is <strong>MF_METADATA_PROVIDER_SERVICE</strong>. Other types of object can
    /// expose this interface through <strong>QueryInterface</strong>.
    /// <para/>
    /// Use this interface to get a pointer to the <see cref="IMFMetadata"/> interface.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/F32E78C9-A567-448D-947D-D7EA996BBA5E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F32E78C9-A567-448D-947D-D7EA996BBA5E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MetadataProvider : COM<IMFMetadataProvider>
    {
        #region Construction

        internal MetadataProvider(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="MetadataProvider"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the MetadataProvider's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be considered void.
        /// </param>
        /// <returns>
        /// A new <see cref="MetadataProvider"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static MetadataProvider FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            MetadataProvider result = new MetadataProvider(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Returns the <see cref="MetadataProvider"/> from the given <paramref name="service"/>
        /// (a media source).
        /// </summary>
        /// <param name="service">The service to retrieve the <see cref="MetadataProvider"/> from (a media source).</param>
        /// <returns>A <see cref="MetadataProvider"/> for the given <paramref name="service"/>.</returns>
        public static MetadataProvider FromService(GetService service)
        {
            Contract.RequiresNotNull(service, "service");
            return service.Get(MFService.MF_METADATA_PROVIDER_SERVICE, MetadataProvider.FromUnknown);
        }

        /// <summary>
        /// Returns the <see cref="MetadataProvider"/> from the given <paramref name="source"/>.
        /// </summary>
        /// <param name="source">Media Source to retrieve the <see cref="MetadataProvider"/> from.</param>
        /// <returns>A <see cref="MetadataProvider"/> for the given <paramref name="source"/>.</returns>
        public static MetadataProvider FromMediaSource(MediaSource source)
        {
            Contract.RequiresNotNull(source, "source");
            return source.GetService(MFService.MF_METADATA_PROVIDER_SERVICE, MetadataProvider.FromUnknown);
        }

        /// <summary>
        /// Gets a collection of metadata, either for an entire presentation, or for one stream in the
        /// presentation.
        /// </summary>
        /// <param name="presentationDescriptor">
        /// The media source's presentation descriptor.
        /// </param>
        /// <param name="streamIdentifier">
        /// If this parameter is zero, the method retrieves metadata that applies to the entire presentation.
        /// Otherwise, this parameter specifies a stream identifier, and the method retrieves
        /// metadata for that stream. To get the stream identifier for a stream, call
        /// <see cref="StreamDescriptor.StreamIdentifier"/>.
        /// </param>
        /// <returns>
        /// The metadata. The caller must release the instance. If no metadata is available for the requested stream or presentation,
        /// null is returned.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/0A3C1932-C301-4ECD-B640-02D7BCFC2ACA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0A3C1932-C301-4ECD-B640-02D7BCFC2ACA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Metadata GetMetadata(PresentationDescriptor presentationDescriptor, int streamIdentifier)
        {
            IntPtr ppMFMetadata = IntPtr.Zero;
            int hr = this.Interface.GetMFMetadata(presentationDescriptor.AccessInterface(), streamIdentifier, 0, out ppMFMetadata);
            // MF_E_PROPERTY_NOT_FOUND: No metadata is available for the requested stream or presentation.
            if (hr == MFError.MF_E_PROPERTY_NOT_FOUND)
            {
                if (ppMFMetadata != IntPtr.Zero)
                    Marshal.Release(ppMFMetadata);
                return null;
            }

            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppMFMetadata);
            return Metadata.FromUnknown(ref ppMFMetadata);
        }
    }
}
