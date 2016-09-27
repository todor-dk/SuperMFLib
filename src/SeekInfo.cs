using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;
using MediaFoundation.Core.Interfaces;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SeekInfo"/> class implements a wrapper around the
    /// <see cref="IMFSeekInfo"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSeekInfo"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSeekInfo"/>:
    /// For a particular seek position, gets the two nearest key frames.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/5B1AD3A1-D5ED-4F9D-A895-0312E6EB3072(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5B1AD3A1-D5ED-4F9D-A895-0312E6EB3072(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SeekInfo : COM<IMFSeekInfo>
    {
        #region Construction

        internal SeekInfo(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="SeekInfo"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the SeekInfo's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be considered void.
        /// </param>
        /// <returns>
        /// A new <see cref="SeekInfo"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static SeekInfo FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            SeekInfo result = new SeekInfo(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Returns the <see cref="SeekInfo"/> from the given <paramref name="service"/> (a media source).
        /// </summary>
        /// <param name="service">The service to retrieve the <see cref="SeekInfo"/> from (a media source).</param>
        /// <returns>A <see cref="SeekInfo"/> for the given <paramref name="service"/>.</returns>
        public static SeekInfo FromService(GetService service)
        {
            Contract.RequiresNotNull(service, "service");
            //return service.Get<IMFSeekInfo>(MFServices.MF_SCRUBBING_SERVICE).ToMetadataProvider();
            throw new NotImplementedException(); // How is MF_SCRUBBING_SERVICE defined?
        }

        /// <summary>
        /// Returns the <see cref="SeekInfo"/> from the given <paramref name="source"/>.
        /// </summary>
        /// <param name="source">Media Source to retrieve the <see cref="SeekInfo"/> from.</param>
        /// <returns>A <see cref="SeekInfo"/> for the given <paramref name="source"/>.</returns>
        public static SeekInfo FromMediaSource(MediaSource source)
        {
            Contract.RequiresNotNull(source, "source");
            throw new NotImplementedException(); // How is MF_SCRUBBING_SERVICE defined?
        }

        /// <summary>
        /// For a particular seek position, gets the two nearest key frames.
        /// </summary>
        /// <param name="position">
        /// The seek position.
        /// </param>
        /// <param name="previousKeyFrame">
        /// Receives the position of the nearest key frame that appears earlier than <paramref name="position"/>.
        /// </param>
        /// <param name="nextKeyFrame">
        /// Receives the position of the nearest key frame that appears later than <paramref name="position"/>.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/72A7161A-09CA-4582-B240-1442D70936D7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/72A7161A-09CA-4582-B240-1442D70936D7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void GetNearestKeyFrames(Time position, out Time previousKeyFrame, out Time nextKeyFrame)
        {
            using (PropVariant vPosition = new PropVariant(position.Value))
            {
                using (PropVariant vPrev = new PropVariant(0L))
                {
                    using (PropVariant vNext = new PropVariant(0L))
                    {
                        int hr = this.Interface.GetNearestKeyFrames(Guid.Empty, vPosition, vPrev, vNext);
                        COM.ThrowIfNotOK(hr);
                        previousKeyFrame = new Time(vPrev.GetLong());
                        nextKeyFrame = new Time(vNext.GetLong());
                    }
                }
            }
        }
    }
}
