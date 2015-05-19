using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using System.Diagnostics;
using MediaFoundation.Core.Interfaces;

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
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be concidered void.
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
