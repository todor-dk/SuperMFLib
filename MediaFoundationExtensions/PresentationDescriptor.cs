using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="PresentationDescriptor"/> class implements a wrapper arround the
    /// <see cref="IMFPresentationDescriptor"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFPresentationDescriptor"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFPresentationDescriptor"/>: 
    /// Describes the details of a presentation. A <em>presentation</em> is a set of related media streams
    /// that share a common presentation time. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/DB03E212-7021-433E-84DC-410B2CF7AF87(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DB03E212-7021-433E-84DC-410B2CF7AF87(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class PresentationDescriptor : Attributes<IMFPresentationDescriptor>
    {
        #region Construction

        internal PresentationDescriptor(IMFPresentationDescriptor comInterface)
            : base(comInterface)
        {
        }

        #endregion


        /// <summary>
        /// Retrieves the number of stream descriptors in the presentation. Each stream descriptor contains
        /// information about one stream in the media source. To retrieve a stream descriptor, call the 
        /// <see cref="GetStreamDescriptor(int)"/> method. 
        /// </summary>
        /// <returns>
        /// The number of stream descriptors.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A01B8F91-B42A-4910-8AFB-6134F5F65759(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A01B8F91-B42A-4910-8AFB-6134F5F65759(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int StreamDescriptorCount
        {
            get
            {
                int pdwDescriptorCount;
                int hr = this.Interface.GetStreamDescriptorCount(out pdwDescriptorCount);
                COM.ThrowIfNotOK(hr);
                return pdwDescriptorCount;
            }
        }
         
        /// <summary>
        /// Retrieves a stream descriptor for a stream in the presentation. The stream descriptor contains
        /// information about the stream.
        /// </summary>
        /// <param name="index">
        /// Zero-based index of the stream. To find the number of streams in the presentation, get the 
        /// <see cref="StreamDescriptorCount"/> property. 
        /// </param>
        /// <param name="selected">
        /// Receives a Boolean value. The value is <strong>true</strong> if the stream is currently selected,
        /// or <strong>false</strong> if the stream is currently deselected. If a stream is selected, the media
        /// source generates data for that stream when <see cref="MediaSource.Start(PresentationDescriptor, Time)"/> is called. The media
        /// source will not generated data for deselected streams. To select a stream, call 
        /// <see cref="SelectStream"/>.To deselect a stream, call <see cref="DeselectStream"/>. 
        /// </param>
        /// <returns>
        /// The stream descriptor. The caller must release the interface. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1DB28049-CD62-4B1B-932B-B4D4E12FD671(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1DB28049-CD62-4B1B-932B-B4D4E12FD671(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public StreamDescriptor GetStreamDescriptor(int index, out bool selected)
        {
            IMFStreamDescriptor ppDescriptor;
            int hr = this.Interface.GetStreamDescriptorByIndex(index, out selected, out ppDescriptor);
            COM.ThrowIfNotOK(hr);
            return ppDescriptor.ToStreamDescriptor();
        }

        /// <summary>
        /// Retrieves a stream descriptor for a stream in the presentation. The stream descriptor contains
        /// information about the stream.
        /// </summary>
        /// <param name="index">
        /// Zero-based index of the stream. To find the number of streams in the presentation, get the 
        /// <see cref="StreamDescriptorCount"/> property. 
        /// </param>
        /// <returns>
        /// The stream descriptor. The caller must release the interface. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1DB28049-CD62-4B1B-932B-B4D4E12FD671(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1DB28049-CD62-4B1B-932B-B4D4E12FD671(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public StreamDescriptor GetStreamDescriptor(int index)
        {
            bool na;
            return this.GetStreamDescriptor(index, out na);
        }

        /// <summary>
        /// Determines if a presentation stream is selected.
        /// </summary>
        /// <returns>
        /// Returns a Boolean value. The value is <strong>true</strong> if the stream is currently selected,
        /// or <strong>false</strong> if the stream is currently deselected. If a stream is selected, the media
        /// source generates data for that stream when <see cref="MediaSource.Start(PresentationDescriptor, Time)"/> is called. The media
        /// source will not generated data for deselected streams. To select a stream, call 
        /// <see cref="SelectStream"/>.To deselect a stream, call <see cref="DeselectStream"/>. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1DB28049-CD62-4B1B-932B-B4D4E12FD671(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1DB28049-CD62-4B1B-932B-B4D4E12FD671(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public bool IsStreamSelected(int index)
        {
            bool selected;
            IMFStreamDescriptor ppDescriptor;
            int hr = this.Interface.GetStreamDescriptorByIndex(index, out selected, out ppDescriptor);
            COM.ThrowIfNotOK(hr);
            COM.SafeRelease(ppDescriptor);
            return selected;
        }

        /// <summary>
        /// Selects a stream in the presentation.
        /// </summary>
        /// <param name="index">
        /// The stream number to select, indexed from zero. To find the number of streams in the presentation,
        /// call <see cref="StreamDescriptorCount"/>. 
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3F0EAACE-9D85-4999-BB3F-34C268DFEA2C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3F0EAACE-9D85-4999-BB3F-34C268DFEA2C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SelectStream(int index)
        {
            int hr = this.Interface.SelectStream(index);
        }
            
        /// <summary>
        /// Deselects a stream in the presentation.
        /// </summary>
        /// <param name="index">
        /// The stream number to deselect, indexed from zero. To find the number of streams in the
        /// presentation, get the <see cref="StreamDescriptorCount"/> property. 
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3DE1F0D5-10FC-415B-898B-4643A391BA79(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3DE1F0D5-10FC-415B-898B-4643A391BA79(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void DeselectStream(int index)
        {
            int hr = this.Interface.DeselectStream(index);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Creates a copy of this presentation descriptor.
        /// </summary>
        /// <returns>
        /// Returns a <see cref="PresentationDescriptor"/> object representing the new presentation
        /// descriptor. The caller must release the instance. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/084B3ADF-092A-4869-92E1-982DB209BD5B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/084B3ADF-092A-4869-92E1-982DB209BD5B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public PresentationDescriptor Clone()
        {
            IMFPresentationDescriptor ppPresentationDescriptor;
            int hr = this.Interface.Clone(out ppPresentationDescriptor);
            COM.ThrowIfNotOK(hr);
            return ppPresentationDescriptor.ToPresentationDescriptor();
        }
    }
}
