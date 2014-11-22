#region license

/*
MediaFoundationLib - Provide access to MediaFoundation interfaces via .NET
Copyright (C) 2007
http://mfnet.sourceforge.net

This library is free software; you can redistribute it and/or
modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation; either
version 2.1 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public
License along with this library; if not, write to the Free Software
Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/

#endregion

using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

using MediaFoundation.Misc;
using MediaFoundation;
using System.Drawing;

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Provides notifications to the sequencer source. This interface is exposed by the sequencer source.
    /// Applications do not use this interface.
    /// <para/>
    /// To get a pointer to this interface, call <see cref="IMFGetService.GetService"/> with the service
    /// identifier MF_SOURCE_PRESENTATION_PROVIDER_SERVICE. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/B6B36324-A315-42A0-BDBF-8D2CEC6CDE3F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B6B36324-A315-42A0-BDBF-8D2CEC6CDE3F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("0E1D600A-C9F3-442D-8C51-A42D2D49452F"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaSourcePresentationProvider
    {
        /// <summary>
        /// Notifies the source when playback has reached the end of a segment. For timelines, this corresponds
        /// to reaching a mark-out point.
        /// </summary>
        /// <param name="pPresentationDescriptor">
        /// Pointer to the <see cref="IMFPresentationDescriptor"/> interface of the presentation descriptor for
        /// the segment that has ended. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT ForceEndOfPresentation(
        ///   [in]  IMFPresentationDescriptor *pPresentationDescriptor
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FB2896F9-C397-4A0D-B8FE-B03FF4F08DDA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FB2896F9-C397-4A0D-B8FE-B03FF4F08DDA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ForceEndOfPresentation(
            [In, MarshalAs(UnmanagedType.Interface)] IMFPresentationDescriptor pPresentationDescriptor
            );
    }

#endif

}
