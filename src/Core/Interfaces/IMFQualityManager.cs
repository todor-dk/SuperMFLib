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

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Adjusts playback quality. This interface is exposed by the quality manager. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/66781A1F-7469-4222-9E99-6B1415830F4C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/66781A1F-7469-4222-9E99-6B1415830F4C(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("8D009D86-5B9F-4115-B1FC-9F80D52AB8AB")]
    internal interface IMFQualityManager
    {
        /// <summary>
        /// Called when the Media Session is about to start playing a new topology.
        /// </summary>
        /// <param name="pTopology">
        /// Pointer to the <see cref="IMFTopology"/> interface of the new topology. If this parameter is 
        /// <strong>NULL</strong>, the quality manager should release any references to the previous topology. 
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
        /// HRESULT NotifyTopology(
        ///   [in]  IMFTopology *pTopology
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5FF6D923-4A83-401A-A0DE-0B1A732C31A5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5FF6D923-4A83-401A-A0DE-0B1A732C31A5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int NotifyTopology(
            [In, MarshalAs(UnmanagedType.Interface)] IMFTopology pTopology
            );

        /// <summary>
        /// Called when the Media Session selects a presentation clock.
        /// </summary>
        /// <param name="pClock">
        /// Pointer to the <see cref="IMFPresentationClock"/> interface of the presentation clock. If this
        /// parameter is <strong>NULL</strong>, the quality manager should release any references to the
        /// presentation clock. 
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
        /// HRESULT NotifyPresentationClock(
        ///   [in]  IMFPresentationClock *pClock
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B358D98E-7B02-4C58-B556-CFA15436E435(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B358D98E-7B02-4C58-B556-CFA15436E435(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int NotifyPresentationClock(
            [In, MarshalAs(UnmanagedType.Interface)] IMFPresentationClock pClock
            );

        /// <summary>
        /// Called when the media processor is about to deliver an input sample to a pipeline component.
        /// </summary>
        /// <param name="pNode">
        /// Pointer to the <see cref="IMFTopologyNode"/> interface of the topology node that represents the
        /// pipeline component. 
        /// </param>
        /// <param name="lInputIndex">
        /// Index of the input stream on the topology node.
        /// </param>
        /// <param name="pSample">
        /// Pointer to the <see cref="IMFSample"/> interface of the input sample. 
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
        /// HRESULT NotifyProcessInput(
        ///   [in]  IMFTopologyNode *pNode,
        ///   [in]  long lInputIndex,
        ///   [in]  IMFSample *pSample
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C6E35D03-CA83-4078-BCC1-B9C1D988DE01(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C6E35D03-CA83-4078-BCC1-B9C1D988DE01(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int NotifyProcessInput(
            [In, MarshalAs(UnmanagedType.Interface)] IMFTopologyNode pNode,
            [In] int lInputIndex,
            [In, MarshalAs(UnmanagedType.Interface)] IMFSample pSample
            );

        /// <summary>
        /// Called after the media processor gets an output sample from a pipeline component.
        /// </summary>
        /// <param name="pNode">
        /// Pointer to the <see cref="IMFTopologyNode"/> interface of the topology node that represents the
        /// pipeline component. 
        /// </param>
        /// <param name="lOutputIndex">
        /// Index of the output stream on the topology node.
        /// </param>
        /// <param name="pSample">
        /// Pointer to the <see cref="IMFSample"/> interface of the output sample. 
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
        /// HRESULT NotifyProcessOutput(
        ///   [in]  IMFTopologyNode *pNode,
        ///   [in]  long lOutputIndex,
        ///   [in]  IMFSample *pSample
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/90596111-6FBC-4249-A696-BD575CB66830(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/90596111-6FBC-4249-A696-BD575CB66830(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int NotifyProcessOutput(
            [In, MarshalAs(UnmanagedType.Interface)] IMFTopologyNode pNode,
            [In] int lOutputIndex,
            [In, MarshalAs(UnmanagedType.Interface)] IMFSample pSample
            );

        /// <summary>
        /// Called when a pipeline component sends an <c>MEQualityNotify</c> event. 
        /// </summary>
        /// <param name="pObject">
        /// Pointer to the <strong>IUnknown</strong> interface of the object that sent the event. The object is
        /// either a Media Foundation transform (MFT) or a stream sink. 
        /// </param>
        /// <param name="pEvent">
        /// Pointer to the <see cref="IMFMediaEvent"/> interface of the event. 
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
        /// HRESULT NotifyQualityEvent(
        ///   [in]  IUnknown *pObject,
        ///   [in]  IMFMediaEvent *pEvent
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E88A5672-7AFD-4D7E-AFA9-E92F9803ACA7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E88A5672-7AFD-4D7E-AFA9-E92F9803ACA7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int NotifyQualityEvent(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pObject,
            [In, MarshalAs(UnmanagedType.Interface)] IMFMediaEvent pEvent
            );

        /// <summary>
        /// Called when the Media Session is shutting down.
        /// </summary>
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
        /// HRESULT Shutdown();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C71BEC12-33AA-4156-A052-CF75C80DF263(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C71BEC12-33AA-4156-A052-CF75C80DF263(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Shutdown();
    }

#endif

}
