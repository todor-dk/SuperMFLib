using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Core.Interfaces;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="StreamDescriptor"/> class implements a wrapper around the
    /// <see cref="IMFStreamDescriptor"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFStreamDescriptor"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFStreamDescriptor"/>:
    /// Gets information about one stream in a media source.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/A076DC6E-D9CB-4F7E-8CC2-B66292DA295F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A076DC6E-D9CB-4F7E-8CC2-B66292DA295F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class StreamDescriptor : Attributes<IMFStreamDescriptor>
    {
        #region Construction

        private StreamDescriptor(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="StreamDescriptor"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the StreamDescriptor's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be concidered void.
        /// </param>
        /// <returns>
        /// A new <see cref="StreamDescriptor"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static StreamDescriptor FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            StreamDescriptor result = new StreamDescriptor(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Retrieves an identifier for the stream.
        /// </summary>
        /// <returns>
        /// Returns the stream identifier.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/D282EE48-6145-4557-8FA7-786B893327FA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D282EE48-6145-4557-8FA7-786B893327FA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int StreamIdentifier
        {
            get
            {
                int pdwStreamIdentifier;
                int hr = this.Interface.GetStreamIdentifier(out pdwStreamIdentifier);
                COM.ThrowIfNotOK(hr);
                return pdwStreamIdentifier;
            }
        }

        /// <summary>
        /// Retrieves a media type handler for the stream. The media type handler can be used to enumerate
        /// supported media types for the stream, get the current media type, and set the media type.
        /// </summary>
        /// <returns>
        /// Returns the media type handler. The caller must release the instance.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/8E991417-FE15-4749-94C4-26C621692B52(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8E991417-FE15-4749-94C4-26C621692B52(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MediaTypeHandler GetMediaTypeHandler()
        {
            IntPtr ppMediaTypeHandler = IntPtr.Zero;
            int hr = this.Interface.GetMediaTypeHandler(out ppMediaTypeHandler);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppMediaTypeHandler);
            return MediaTypeHandler.FromUnknown(ref ppMediaTypeHandler);
        }
    }
}
