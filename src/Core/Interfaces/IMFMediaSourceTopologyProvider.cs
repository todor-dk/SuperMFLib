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

namespace MediaFoundation.Core.Interfaces
{
    #if NOT_IN_USE

    /// <summary>
    /// Enables an application to get a topology from the sequencer source. This interface is exposed by
    /// the sequencer source object.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/7C08FB54-6A78-4B6D-AAE7-4B3A823EB880(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7C08FB54-6A78-4B6D-AAE7-4B3A823EB880(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("0E1D6009-C9F3-442D-8C51-A42D2D49452F")]
    internal interface IMFMediaSourceTopologyProvider
    {
        /// <summary>
        /// Returns a topology for a media source that builds an internal topology.
        /// </summary>
        /// <param name="pPresentationDescriptor">
        /// A pointer to the <see cref="IMFPresentationDescriptor"/> interface of the media source's
        /// presentation descriptor. To get this pointer, either call 
        /// <see cref="IMFMediaSource.CreatePresentationDescriptor"/> on the media source, or get the pointer
        /// from the <c>MENewPresentation</c> event. 
        /// </param>
        /// <param name="ppTopology">
        /// Receives a pointer to the topology's <see cref="IMFTopology"/> interface. The caller must release
        /// the interface. 
        /// </param>
        /// <returns>
        /// The method returns an HRESULT. Possible values include, but are not limited to, those in the
        /// following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>Invalid argument. For example, a <strong>NULL</strong> input parameter, or the presentation descriptor is not valid. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetMediaSourceTopology(
        ///   [in]   IMFPresentationDescriptor *pPresentationDescriptor,
        ///   [out]  IMFTopology **ppTopology
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3889768A-27BB-422E-912B-80546B6017FB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3889768A-27BB-422E-912B-80546B6017FB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMediaSourceTopology(
            [In, MarshalAs(UnmanagedType.Interface)] IMFPresentationDescriptor pPresentationDescriptor,
            [MarshalAs(UnmanagedType.Interface)] out IMFTopology ppTopology
            );
    }

#endif
}
