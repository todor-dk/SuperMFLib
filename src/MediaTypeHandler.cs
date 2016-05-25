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
    /// The <see cref="MediaTypeHandler"/> class implements a wrapper around the
    /// <see cref="IMFMediaTypeHandler"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaTypeHandler"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaTypeHandler"/>:
    /// Gets and sets media types on an object, such as a media source or media sink.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/5B937BF7-4F86-4DC1-A4D5-7E724DCF5B36(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5B937BF7-4F86-4DC1-A4D5-7E724DCF5B36(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaTypeHandler : COM<IMFMediaTypeHandler>
    {
        #region Construction

        private MediaTypeHandler(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="MediaTypeHandler"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the MediaTypeHandler's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be concidered void.
        /// </param>
        /// <returns>
        /// A new <see cref="MediaTypeHandler"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static MediaTypeHandler FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            MediaTypeHandler result = new MediaTypeHandler(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Queries whether the object supports a specified media type.
        /// </summary>
        /// <param name="mediaType">
        /// The media type to check.
        /// </param>
        /// <param name="supportedMediaType">
        /// Receives a <see cref="MediaType"/> that is the closest matching media type, or <strong>null</strong>.
        /// If non-<strong>null</strong>, the caller must release the instance.
        /// </param>
        /// <returns>
        /// True if the media type is supported, otherwise false.
        /// </returns>
        /// <remarks>
        /// If the object supports the media type given in <paramref name="mediaType"/>, the method returns true.
        /// For a media source, it means the source can generate data that conforms to that media type.
        /// For a media sink, it means the sink can receive data that conforms to that media type.
        /// If the object does not support the media type, the method returns false.
        /// <para/>
        /// If the method returns false, the object might use <paramref name="supportedMediaType"/> to return a media
        /// type that the object does support, and which closely matches the one given in <paramref name="mediaType"/>.
        /// The method is not guaranteed to return a media type in <paramref name="supportedMediaType"/>.
        /// If no type is returned, this parameter receives null. If the method returns true, this parameter receives null.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/EA52DEFA-8B78-4F40-97AE-ED6A5EE4849E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EA52DEFA-8B78-4F40-97AE-ED6A5EE4849E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public bool IsMediaTypeSupported(MediaType mediaType, out MediaType supportedMediaType)
        {
            IntPtr ppMediaType = IntPtr.Zero;
            int hr = this.Interface.IsMediaTypeSupported(mediaType.AccessInterface(), out ppMediaType);
            // MF_E_INVALIDMEDIATYPE: The object does not support this media type.
            if (hr == MFError.MF_E_INVALIDMEDIATYPE)
            {
                supportedMediaType = MediaType.FromUnknown(ref ppMediaType);
                return false;
            }

            if (ppMediaType != IntPtr.Zero)
                Marshal.Release(ppMediaType);
            COM.ThrowIfNotOK(hr);
            supportedMediaType = null;
            return true;
        }

        /// <summary>
        /// Queries whether the object supports a specified media type.
        /// </summary>
        /// <param name="mediaType">
        /// The media type to check.
        /// </param>
        /// <returns>
        /// True if the media type is supported, otherwise false.
        /// </returns>
        /// <remarks>
        /// If the object supports the media type given in <paramref name="mediaType"/>, the method returns true.
        /// For a media source, it means the source can generate data that conforms to that media type.
        /// For a media sink, it means the sink can receive data that conforms to that media type.
        /// If the object does not support the media type, the method returns false.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/EA52DEFA-8B78-4F40-97AE-ED6A5EE4849E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EA52DEFA-8B78-4F40-97AE-ED6A5EE4849E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public bool IsMediaTypeSupported(MediaType mediaType)
        {
            MediaType supportedMediaType;
            bool supported = this.IsMediaTypeSupported(mediaType, out supportedMediaType);
            COM.SafeRelease(supportedMediaType);
            return supported;
        }

        /// <summary>
        /// Retrieves the number of media types in the object's list of supported media types.
        /// </summary>
        /// <returns>
        /// The number of media types in the list.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/C5EE41BC-EE8B-4990-AE9D-92EF54597F31(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C5EE41BC-EE8B-4990-AE9D-92EF54597F31(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int MediaTypeCount
        {
            get
            {
                int pdwTypeCount;
                int hr = this.Interface.GetMediaTypeCount(out pdwTypeCount);
                COM.ThrowIfNotOK(hr);
                return pdwTypeCount;
            }
        }

        /// <summary>
        /// Retrieves a media type from the object's list of supported media types.
        /// </summary>
        /// <param name="index">
        /// Zero-based index of the media type to retrieve. To get the number of media types in the list, call
        /// <see cref="MediaTypeCount"/>.
        /// </param>
        /// <returns>
        /// Returns the media type. The caller must release the instance.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/A1827675-BBC4-45D8-8C6E-644B0D2ADDD4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A1827675-BBC4-45D8-8C6E-644B0D2ADDD4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MediaType GetMediaType(int index)
        {
            IntPtr ppType = IntPtr.Zero;
            int hr = this.Interface.GetMediaTypeByIndex(index, out ppType);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppType);
            return MediaType.FromUnknown(ref ppType);
        }

        /// <summary>
        /// The object's media type.
        /// </summary>
        /// <param name="mediaType">
        /// The new media type.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/77FF397E-4FA8-4849-98B8-6BDD035C0E89(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/77FF397E-4FA8-4849-98B8-6BDD035C0E89(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetCurrentMediaType(MediaType mediaType)
        {
            int hr = this.Interface.SetCurrentMediaType(mediaType.AccessInterface());
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Retrieves the current media type of the object.
        /// </summary>
        /// <returns>
        /// Returns the current media type or null if the media type is not set. The caller must release the instance.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/B1676E40-81A2-4311-BBA6-528BFA45A708(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B1676E40-81A2-4311-BBA6-528BFA45A708(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MediaType GetCurrentMediaType()
        {
            IntPtr ppMediaType = IntPtr.Zero;
            int hr = this.Interface.GetCurrentMediaType(out ppMediaType);
            // MF_E_NOT_INITIALIZED: No media type is set.
            if (hr == MFError.MF_E_NOT_INITIALIZED)
            {
                if (ppMediaType != IntPtr.Zero)
                    Marshal.Release(ppMediaType);
                return null;
            }

            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppMediaType);
            return MediaType.FromUnknown(ref ppMediaType);
        }

        /// <summary>
        /// Gets the major media type of the object.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/1560D113-80A9-48BB-9F3D-6E3A288DB962(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1560D113-80A9-48BB-9F3D-6E3A288DB962(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Guid MajorType
        {
            get
            {
                Guid pguidMajorType;
                int hr = this.Interface.GetMajorType(out pguidMajorType);
                COM.ThrowIfNotOK(hr);
                return pguidMajorType;
            }
        }

        /// <summary>
        /// Returns the name of the major type of the object.
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
    }
}
