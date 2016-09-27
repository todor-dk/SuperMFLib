using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using System.Diagnostics;
using MediaFoundation.Core.Interfaces;
using MediaFoundation.Core;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaBuffer"/> class implements a wrapper around the
    /// <see cref="IMFMediaBuffer"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaBuffer"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaBuffer"/>:
    /// Represents a block of memory that contains media data. Use this interface to access the data in the
    /// buffer.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/3CCC7089-D0D0-4EB1-B763-0D4E348AF685(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3CCC7089-D0D0-4EB1-B763-0D4E348AF685(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaBuffer : COM<IMFMediaBuffer>
    {
        #region Construction

        private MediaBuffer(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="MediaBuffer"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the MediaBuffer's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be considered void.
        /// </param>
        /// <returns>
        /// A new <see cref="MediaBuffer"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static MediaBuffer FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            MediaBuffer result = new MediaBuffer(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Allocates system memory and creates a media buffer to manage it.
        /// </summary>
        /// <param name="maxLength">Size of the buffer, in bytes.</param>
        /// <returns>The media buffer. The caller must release the interface.</returns>
        public static MediaBuffer CreateMemoryBuffer(int maxLength)
        {
            IntPtr buffer = IntPtr.Zero;
            int hr = MFExtern.MFCreateMemoryBuffer(maxLength, out buffer);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref buffer);
            Debug.Assert(buffer != IntPtr.Zero);
            return MediaBuffer.FromUnknown(ref buffer);
        }

        /// <summary>
        /// Specifies the memory alignment for the buffer.
        /// </summary>
        public enum ByteAlignment : int
        {
            /// <summary>
            /// Align to 1 byte.
            /// </summary>
            Align1Byte = 0x00000000,

            /// <summary>
            /// Align to 2 bytes. 
            /// </summary>
            Align2Byte = 0x00000001,

            /// <summary>
            /// Align to 4 bytes. 
            /// </summary>
            Align4Byte = 0x00000003,

            /// <summary>
            /// Align to 8 bytes. 
            /// </summary>
            Align8Byte = 0x00000007,

            /// <summary>
            /// Align to 18 bytes. 
            /// </summary>
            Align16Byte = 0x0000000f,

            /// <summary>
            /// Align to 32 bytes. 
            /// </summary>
            Align32Byte = 0x0000001f,

            /// <summary>
            /// Align to 64 bytes. 
            /// </summary>
            Align64Byte = 0x0000003f,

            /// <summary>
            /// Align to 128 bytes. 
            /// </summary>
            Align128Byte = 0x0000007f,

            /// <summary>
            /// Align to 256 bytes. 
            /// </summary>
            Align256Byte = 0x000000ff,

            /// <summary>
            /// Align to 512 bytes. 
            /// </summary>
            Align512Byte = 0x000001ff,

            /// <summary>
            /// Align to 1024 bytes. 
            /// </summary>
            Align1024Byte = 0x000003ff,

            /// <summary>
            /// Align to 2048 bytes. 
            /// </summary>
            Align2048Byte = 0x000007ff,

            /// <summary>
            /// Align to 4096 bytes. 
            /// </summary>
            Align4096Byte = 0x00000fff,

            /// <summary>
            /// Align to 8192 bytes. 
            /// </summary>
            Align8192Byte = 0x00001fff
        }

        /// <summary>
        /// Allocates system memory with a specified byte alignment and creates a media buffer to manage the memory. 
        /// </summary>
        /// <param name="maxLength">Size of the buffer, in bytes.</param>
        /// <param name="alignment">Specifies the memory alignment for the buffer.</param>
        /// <returns>The media buffer. The caller must release the interface.</returns>
        public static MediaBuffer CreateAlignedMemoryBuffer(int maxLength, ByteAlignment alignment)
        {
            IntPtr buffer = IntPtr.Zero;
            int hr = MFExtern.MFCreateAlignedMemoryBuffer(maxLength, (int)alignment, out buffer);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref buffer);
            Debug.Assert(buffer != IntPtr.Zero);
            return MediaBuffer.FromUnknown(ref buffer);
        }

        ///// <summary>
        ///// Converts a Media Foundation media buffer into a buffer that is compatible with DirectX Media Objects (DMOs).
        ///// </summary>
        ///// <param name="sample">The sample.</param>
        ///// <param name="mediaBuffer">The media buffer.</param>
        ///// <param name="offset">The offset.</param>
        ///// <returns>MediaBuffer.</returns>
        //public static MediaBuffer CreateDmoCompatible(Sample sample, MediaBuffer mediaBuffer, int offset)
        //{
        //    IntPtr buffer = IntPtr.Zero;
        //    int hr = MFExtern.MFCreateLegacyMediaBufferOnMFMediaBuffer(sample.AccessInterface(), mediaBuffer.AccessInterface(), offset, out buffer);
        //    COM.ThrowIfNotOKAndReleaseInterface(hr, ref buffer);
        //    Debug.Assert(buffer != IntPtr.Zero);
        //    return MediaBuffer.FromUnknown(ref buffer);
        //}

        /// <summary>
        /// Creates a media buffer that wraps an existing media buffer. 
        /// The new media buffer points to the same memory as the original media buffer, 
        /// or to an offset from the start of the memory.
        /// </summary>
        /// <param name="mediaBuffer">The original media buffer.</param>
        /// <param name="offset">The start of the new buffer, as an offset in bytes from the start of the original buffer.</param>
        /// <param name="length">
        /// The size of the new buffer. The value of cbOffset + dwLength 
        /// must be less than or equal to the size of valid data the original buffer.
        /// </param>
        /// <returns>The media buffer. The caller must release the interface.</returns>
        public static MediaBuffer CreateWrapper(MediaBuffer mediaBuffer, int offset, int length)
        {
            IntPtr buffer = IntPtr.Zero;
            int hr = MFExtern.MFCreateMediaBufferWrapper(mediaBuffer.AccessInterface(), offset, length, out buffer);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref buffer);
            Debug.Assert(buffer != IntPtr.Zero);
            return MediaBuffer.FromUnknown(ref buffer);
        }

        /// <summary>
        /// Allocates a system-memory buffer that is optimal for a specified media type.
        /// </summary>
        /// <param name="mediaType">The desired media type.</param>
        /// <returns>The media buffer. The caller must release the interface.</returns>
        private static MediaBuffer FromMediaType(MediaType mediaType)
        {
            return MediaBuffer.FromMediaType(mediaType, Time.Zero, 0, 0);
        }

        /// <summary>
        /// Allocates a system-memory buffer that is optimal for a specified media type.
        /// </summary>
        /// <param name="mediaType">The desired media type.</param>
        /// <param name="duration">The sample duration. This value is required for audio formats.</param>
        /// <returns>The media buffer. The caller must release the interface.</returns>
        private static MediaBuffer FromMediaType(MediaType mediaType, Time duration)
        {
            return MediaBuffer.FromMediaType(mediaType, duration, 0, 0);
        }

        /// <summary>
        /// Allocates a system-memory buffer that is optimal for a specified media type.
        /// </summary>
        /// <param name="mediaType">The desired media type.</param>
        /// <param name="minLength">The minimum size of the buffer, in bytes. The actual buffer size might be larger.
        /// Specify zero to allocate the default buffer size for the media type.</param>
        /// <param name="minAlignment">The minimum memory alignment for the buffer. Specify zero to use the default memory alignment.</param>
        /// <returns>The media buffer. The caller must release the interface.</returns>
        private static MediaBuffer FromMediaType(MediaType mediaType, int minLength, int minAlignment)
        {
            return MediaBuffer.FromMediaType(mediaType, Time.Zero, minLength, minAlignment);
        }

        /// <summary>
        /// Allocates a system-memory buffer that is optimal for a specified media type.
        /// </summary>
        /// <param name="mediaType">The desired media type.</param>
        /// <param name="duration">The sample duration. This value is required for audio formats.</param>
        /// <param name="minLength">The minimum size of the buffer, in bytes. The actual buffer size might be larger.
        /// Specify zero to allocate the default buffer size for the media type.</param>
        /// <param name="minAlignment">The minimum memory alignment for the buffer. Specify zero to use the default memory alignment.</param>
        /// <returns>The media buffer. The caller must release the interface.</returns>
        private static MediaBuffer FromMediaType(MediaType mediaType, Time duration, int minLength, int minAlignment)
        {
            IntPtr buffer = IntPtr.Zero;
            int hr = MFExtern.MFCreateMediaBufferFromMediaType(mediaType.AccessInterface(), duration.Value, minLength, minAlignment, out buffer);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref buffer);
            Debug.Assert(buffer != IntPtr.Zero);
            return MediaBuffer.FromUnknown(ref buffer);
        }

        /// <summary>
        /// Gives the caller access to the memory in the buffer, for reading or writing
        /// </summary>
        /// <returns>
        /// A pointer to the start of the buffer.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/28AC372A-6E73-4E66-BF69-BCC244821B71(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/28AC372A-6E73-4E66-BF69-BCC244821B71(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public IntPtr Lock()
        {
            int maxLength;
            int currentLength;
            return this.Lock(out maxLength, out currentLength);
        }

        /// <summary>
        /// Gives the caller access to the memory in the buffer, for reading or writing
        /// </summary>
        /// <param name="maxLength">
        /// Returns the maximum amount of data that can be written to the buffer.
        /// The same value is returned by the <see cref="MaxLength"/> property.
        /// </param>
        /// <param name="currentLength">
        /// Returns the length of the valid data in the buffer, in bytes.
        /// The same value is returned by the <see cref="CurrentLength"/> property.
        /// </param>
        /// <returns>
        /// A pointer to the start of the buffer.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/28AC372A-6E73-4E66-BF69-BCC244821B71(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/28AC372A-6E73-4E66-BF69-BCC244821B71(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public IntPtr Lock(out int maxLength, out int currentLength)
        {
            IntPtr pBuffer = IntPtr.Zero;
            int hr = this.Interface.Lock(out pBuffer, out maxLength, out currentLength);
            COM.ThrowIfNotOK(hr);
            Debug.Assert(pBuffer != IntPtr.Zero);
            return pBuffer;
        }

        /// <summary>
        /// Unlocks a buffer that was previously locked. Call this method once for every call to <see cref="Lock()"/>.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/3CA53321-5533-45F0-B415-6A16F780EC54(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3CA53321-5533-45F0-B415-6A16F780EC54(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void Unlock()
        {
            int hr = this.Interface.Unlock();
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Gets or sets the length of the valid data in the buffer in bytes.
        /// If the buffer does not contain any valid data, the value is zero.
        /// <para/>
        /// This value cannot be greater than the allocated size of the
        /// buffer, which is returned by the <see cref="MaxLength"/> property.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/772E3E6C-0616-41F6-A681-D76DA97D85FB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/772E3E6C-0616-41F6-A681-D76DA97D85FB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int CurrentLength
        {
            get
            {
                int len;
                int hr = this.Interface.GetCurrentLength(out len);
                COM.ThrowIfNotOK(len);
                return len;
            }

            set
            {
                int hr = this.Interface.SetCurrentLength(value);
                COM.ThrowIfNotOK(hr);
            }
        }

        /// <summary>
        /// Gets the allocated size of the buffer in bytes.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/F0697F1D-18D6-4406-9F19-8CBAAC08AD47(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F0697F1D-18D6-4406-9F19-8CBAAC08AD47(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int MaxLength
        {
            get
            {
                int len;
                int hr = this.Interface.GetMaxLength(out len);
                COM.ThrowIfNotOK(hr);
                return len;
            }
        }
    }
}
