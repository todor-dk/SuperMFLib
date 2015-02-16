using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using System.Diagnostics;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaType"/> class implements a wrapper arround the
    /// <see cref="IMFMediaType"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaType"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaType"/>: 
    /// Represents a description of a media format. 
    /// </summary>
    /// <remarks>
    /// The above documentation is � Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/F1D60BEC-71E4-4FCC-A020-92754B6F3C02(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F1D60BEC-71E4-4FCC-A020-92754B6F3C02(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaType : Attributes<IMFMediaType>
    {
        #region Construction

        internal MediaType(IMFMediaType comInterface)
            : base(comInterface)
        {
        }

        #endregion

        /// <summary>
        /// Creates an empty media type.
        /// </summary>
        /// <returns>A new <see cref="MediaType"/> object. The caller must dispose this object.</returns>
        public static MediaType Create()
        {
            IMFMediaType type = null;
            int hr = MFExtern.MFCreateMediaType(out type);
            COM.ThrowIfNotOK(hr);
            Debug.Assert(type != null);
            return type.ToMediaType();
        }

        /// <summary>
        /// Gets the major type of the format. 
        /// <para/>
        /// The major type describes the broad category of the format, such as audio or video. 
        /// For a list of possible values, see <c>Major Media Types</c>. 
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/98F0A9CA-4766-4D2B-89B8-D6E30B75F47D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/98F0A9CA-4766-4D2B-89B8-D6E30B75F47D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Guid MajorType
        {
            get
            {
                Guid type; 
                int hr = this.Interface.GetMajorType(out type);
                COM.ThrowIfNotOK(hr);
                return type;
            }
        }

        /// <summary>
        /// Returns the name of the major type of the format. 
        /// <para/>
        /// <strong>IMPORTANT:</strong> This name is not stable and is intended only for debug purposes.
        /// </summary>
        /// <seealso cref="MajorType"/>
        public string MajorTypeName
        {
            get
            {
                return GuidMapper.Current.GetName(this.MajorType) ?? this.MajorType.ToString();
            }
        }

        /// <summary>
        /// Queries whether the media type is a temporally compressed format. Temporal compression uses
        /// information from previously decoded samples when decompressing the current sample.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D15D683B-F2CE-40AC-9724-A0785F5D335C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D15D683B-F2CE-40AC-9724-A0785F5D335C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public bool IsCompressedFormat
        {
            get
            {
                bool value;
                int hr = this.Interface.IsCompressedFormat(out value);
                COM.ThrowIfNotOK(hr);
                return value;
            }
        }

        /// <summary>
        /// Compares two media types and determines whether they are identical. If they are not identical, the
        /// method indicates how the two formats differ. 
        /// </summary>
        /// <param name="mediaType">The <see cref="MediaType"/> to compare.</param>
        /// <returns>
        /// True if the types are equal. False if the types are not equal.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/42B5B0E8-3B13-4BDA-A53C-0428A3C9B131(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/42B5B0E8-3B13-4BDA-A53C-0428A3C9B131(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public bool IsEqual(MediaType mediaType)
        {
            MFMediaEqual flags;
            return this.IsEqual(mediaType, out flags);
        }

        /// <summary>
        /// Compares two media types and determines whether they are identical. If they are not identical, the
        /// method indicates how the two formats differ. 
        /// </summary>
        /// <param name="mediaType">
        /// The <see cref="MediaType"/> to compare. 
        /// </param>
        /// <param name="flags">
        /// Returns a bitwise <strong>OR</strong> of zero or more flags, indicating the degree of similarity
        /// between the two media types.
        /// </param>
        /// <returns>
        /// True if the types are equal. False if the types are not equal; Examine the <paramref name="flags"/> parameter 
        /// to determine how the types differ. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/42B5B0E8-3B13-4BDA-A53C-0428A3C9B131(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/42B5B0E8-3B13-4BDA-A53C-0428A3C9B131(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public bool IsEqual(MediaType mediaType, out MFMediaEqual flags)
        {
            int hr = this.Interface.IsEqual(mediaType.GetInterface(), out flags);
            if (hr == COM.S_FALSE)
                return false;
            COM.ThrowIfNotOK(hr);
            return true;
        }

        /// <summary>
        /// Subtype GUID for a media type. 
        /// <para/>
        /// The subtype GUID defines a specific media format type within a major type. For example, within
        /// video, the subtypes include RGB-24, RGB-32, UYVY, AYUV, and so forth. Within audio, the subtypes
        /// include PCM audio, Windows Media Audio 9, and so forth.
        /// </summary>
        /// <seealso cref="MFAttributesClsid.MF_MT_SUBTYPE"/>
        public Guid Subtype
        {
            get
            {
                return this.GetGuid(MFAttributesClsid.MF_MT_SUBTYPE);
            }
        }

        /// <summary>
        /// Returns the name of the sub-type of the format. 
        /// <para/>
        /// <strong>IMPORTANT:</strong> This name is not stable and is intended only for debug purposes.
        /// </summary>
        /// <seealso cref="Subtype"/>
        public string SubtypeName
        {
            get
            {
                return GuidMapper.Current.GetName(this.Subtype) ?? this.Subtype.ToString();
            }
        }
    }
}
