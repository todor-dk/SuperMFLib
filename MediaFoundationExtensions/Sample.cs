using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="Sample"/> class implements a wrapper around the
    /// <see cref="IMFSample"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSample"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSample"/>: 
    /// Represents a media sample, which is a container object for media data. For video, a sample
    /// typically contains one video frame. For audio data, a sample typically contains multiple audio
    /// samples, rather than a single sample of audio.
    /// <para/>
    /// A media sample contains zero or more buffers. Each buffer manages a block of memory, and is
    /// represented by the <see cref="IMFMediaBuffer"/> interface. A sample can have multiple buffers. The
    /// buffers are kept in an ordered list and accessed by index value. It is also valid to have an empty
    /// sample with no buffers. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/B1C3758C-5133-41EE-B991-AE99D0296CCC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B1C3758C-5133-41EE-B991-AE99D0296CCC(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class Sample : Attributes<IMFSample>
    {
        #region Construction

        internal Sample(IMFSample comInterface)
            : base(comInterface)
        {
        }

        #endregion

        /// <summary>
        /// Gets or sets the presentation time of the sample.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FC4AAC9E-E7A9-43F0-AF7B-54A39666044A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FC4AAC9E-E7A9-43F0-AF7B-54A39666044A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Time SampleTime
        {
            get
            {
                Time time;
                int hr = this.Interface.GetSampleTime(out time.Value);
                COM.ThrowIfNotOK(hr);
                return time;
            }
            set
            {
                int hr = this.Interface.SetSampleTime(value.Value);
                COM.ThrowIfNotOK(hr);
            }
        }

        /// <summary>
        /// Gets or sets the duration of the sample.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C3284EDC-B9B5-489B-9166-3BB6DA50BD2A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C3284EDC-B9B5-489B-9166-3BB6DA50BD2A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Time SampleDuration
        {
            get
            {
                Time time;
                int hr = this.Interface.GetSampleDuration(out time.Value);
                COM.ThrowIfNotOK(hr);
                return time;
            }
            set
            {
                int hr = this.Interface.SetSampleDuration(value.Value);
                COM.ThrowIfNotOK(hr);
            }
        }
          

        /// <summary>
        /// Returns the number of buffers in the sample. A sample might contain zero buffers.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FE05E870-298B-44BF-90B7-70BE40D045AB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FE05E870-298B-44BF-90B7-70BE40D045AB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int BufferCount
        {
            get
            {
                int count;
                int hr = this.Interface.GetBufferCount(out count);
                COM.ThrowIfNotOK(hr);
                return count;
            }
        }

        /// <summary>
        /// Gets a buffer from the sample, by index.
        /// <para/>
        /// <strong>Note</strong> In most cases, it is safer to use the 
        /// <see cref="IMFSample.ConvertToContiguousBuffer"/> method. If the sample contains more than one
        /// buffer, the <strong>ConvertToContiguousBuffer</strong> method replaces them with a single buffer,
        /// copies the original data into that buffer, and returns the new buffer to the caller. The copy
        /// operation occurs at most once. On subsequent calls, no data is copied. 
        /// </summary>
        /// <param name="index">
        /// Index of the buffer. To find the number of buffers in the sample, call 
        /// <see cref="BufferCount"/>. Buffers are indexed from zero. 
        /// </param>
        /// <returns>
        /// The <see cref="MediaBuffer"/> for the requested index. The caller must dispose this object.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/48D3B861-96E8-4767-A8B1-65614FD48254(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/48D3B861-96E8-4767-A8B1-65614FD48254(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MediaBuffer GetBufferByIndex(int index)
        {
            IMFMediaBuffer buffer;
            int hr = this.Interface.GetBufferByIndex(index, out buffer);
            COM.ThrowIfNotOK(hr);
            return buffer.ToMediaBuffer();
        }

        /// <summary>
        /// Converts a sample with multiple buffers into a sample with a single buffer. 
        /// </summary>
        /// <returns>
        /// The <see cref="MediaBuffer"/> for the sample. The caller must dispose this object.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6EA950EB-7F2E-4549-93DC-FA62F95B7B66(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6EA950EB-7F2E-4549-93DC-FA62F95B7B66(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MediaBuffer ConvertToContiguousBuffer()
        {
            IMFMediaBuffer buffer;
            int hr = this.Interface.ConvertToContiguousBuffer(out buffer);
            COM.ThrowIfNotOK(hr);
            return buffer.ToMediaBuffer();
        }

        /// <summary>
        /// Adds a buffer to the end of the list of buffers in the sample. 
        /// </summary>
        /// <param name="buffer">The <see cref="MediaBuffer"/> to add.</param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/61C2A1DC-B9FE-4296-BF33-D54006CAD32B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/61C2A1DC-B9FE-4296-BF33-D54006CAD32B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void AddBuffer(MediaBuffer buffer)
        {
            int hr = this.Interface.AddBuffer(buffer.GetInterface());
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Removes a buffer at a specified index from the sample.
        /// </summary>
        /// <param name="index">
        /// Index of the buffer. To find the number of buffers in the sample, call 
        /// <see cref="BufferCount"/>. Buffers are indexed from zero. 
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FC7B5A46-A127-4D75-A9A5-382D9D65A426(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FC7B5A46-A127-4D75-A9A5-382D9D65A426(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void RemoveBufferByIndex(int index)
        {
            int hr = this.Interface.RemoveBufferByIndex(index);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Removes all of the buffers from the sample.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C7CE734F-64DA-4D45-905E-54A8898AA710(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C7CE734F-64DA-4D45-905E-54A8898AA710(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void RemoveAllBuffers()
        {
            int hr = this.Interface.RemoveAllBuffers();
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Returns the total length of the valid data in all of the buffers in the sample. The length is
        /// calculated as the sum of the values retrieved by the <see cref="MediaBuffer.CurrentLength"/> property. 
        /// </summary>
        /// <returns>
        /// The total length of the valid data, in bytes.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E0DFC1D2-EC78-4D1C-992D-3A876B600CA6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E0DFC1D2-EC78-4D1C-992D-3A876B600CA6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int TotalLength
        {
            get
            {
                int len;
                int hr = this.Interface.GetTotalLength(out len);
                COM.ThrowIfNotOK(hr);
                return len;
            }
        }

        /// <summary>
        /// Copies the sample data to a buffer. This method concatenates the valid data from all of the buffers
        /// of the sample, in order.
        /// </summary>
        /// <param name="buffer">
        /// The destination buffer. The buffer must be large enough to hold the valid data in the sample. 
        /// To get the size of the data in the sample, call  <see cref="TotalLength"/>. 
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C8A23E0A-ED2F-449D-B834-F60F383D0B5E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C8A23E0A-ED2F-449D-B834-F60F383D0B5E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void CopyToBuffer(MediaBuffer buffer)
        {
            int hr = this.Interface.CopyToBuffer(buffer.GetInterface());
            COM.ThrowIfNotOK(hr);
        }
    }
}
