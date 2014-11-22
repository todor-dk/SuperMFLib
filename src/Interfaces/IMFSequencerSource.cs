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


    /// <summary>
    /// Implemented by the <c>Sequencer Source</c>. The sequencer source enables an application to create a
    /// sequence of topologies. To create the sequencer source, call 
    /// <see cref="MFExtern.MFCreateSequencerSource"/>. For step-by-step instructions about how to create a
    /// playlist, see <c>How to Create a Playlist</c>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BA5E8E7B-5B0E-4807-A459-75BD5727D1E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BA5E8E7B-5B0E-4807-A459-75BD5727D1E2(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("197CD219-19CB-4DE1-A64C-ACF2EDCBE59E"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFSequencerSource
    {
        /// <summary>
        /// Adds a topology to the end of the queue.
        /// </summary>
        /// <param name="pTopology">
        /// Pointer to the <see cref="IMFTopology"/> interface of the topology. This pointer cannot be <strong>
        /// NULL</strong>. If an application passes <strong>NULL</strong>, the call fails with an E_INVALIDARG
        /// error code. 
        /// </param>
        /// <param name="dwFlags">
        /// A combination of flags from the <see cref="MFSequencerTopologyFlags"/> enumeration. 
        /// </param>
        /// <param name="pdwId">
        /// Receives the sequencer element identifier for this topology.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>The source topology node is missing one of the following attributes:<para>* <see cref="MFAttributesClsid.MF_TOPONODE_STREAM_DESCRIPTOR"/></para><para>* <see cref="MFAttributesClsid.MF_TOPONODE_PRESENTATION_DESCRIPTOR"/></para><para>* <see cref="MFAttributesClsid.MF_TOPONODE_SOURCE"/></para></description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT AppendTopology(
        ///   [in]   IMFTopology *pTopology,
        ///   [in]   DWORD dwFlags,
        ///   [out]  MFSequencerElementId *pdwId
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4FF20D56-6095-495D-89EE-9086C61DA8AC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4FF20D56-6095-495D-89EE-9086C61DA8AC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int AppendTopology(
            [In, MarshalAs(UnmanagedType.Interface)] IMFTopology pTopology,
            [In] MFSequencerTopologyFlags dwFlags,
            out int pdwId
            );

        /// <summary>
        /// Deletes a topology from the queue.
        /// </summary>
        /// <param name="dwId">
        /// The sequencer element identifier of the topology to delete.
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
        /// HRESULT DeleteTopology(
        ///   [in]  MFSequencerElementId dwId
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6EF3512D-F953-46A3-8604-BEC3904A962F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6EF3512D-F953-46A3-8604-BEC3904A962F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int DeleteTopology(
            [In] int dwId
            );

        /// <summary>
        /// Maps a presentation descriptor to its associated sequencer element identifier and the topology it
        /// represents.
        /// </summary>
        /// <param name="pPD">
        /// Pointer to the <see cref="IMFPresentationDescriptor"/> interface of the presentation descriptor. 
        /// </param>
        /// <param name="pID">The p identifier.</param>
        /// <param name="ppTopology">
        /// Receives a pointer to the <see cref="IMFTopology"/> interface of the original topology that the
        /// application added to the sequencer source. The caller must release the interface. This parameter
        /// can receive the value <strong>NULL</strong> if the sequencer source has switched to the next
        /// presentation. This parameter is optional and can be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>The presentation descriptor is not valid.</description></item>
        /// <item><term><strong>MF_S_SEQUENCER_CONTEXT_CANCELED</strong></term><description>This segment was canceled.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetPresentationContext(
        ///   [in]   IMFPresentationDescriptor *pPD,
        ///   [out]  MFSequencerElementId *pId,
        ///   [out]  IMFTopology **ppTopology
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C444CCAD-68B8-40EB-9E87-0B4D61AC725D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C444CCAD-68B8-40EB-9E87-0B4D61AC725D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetPresentationContext(
            [In, MarshalAs(UnmanagedType.Interface)] IMFPresentationDescriptor pPD,
            out int pID,
            [MarshalAs(UnmanagedType.Interface)] out IMFTopology ppTopology
            );

        /// <summary>
        /// Updates a topology in the queue.
        /// </summary>
        /// <param name="dwId">
        /// Sequencer element identifier of the topology to update.
        /// </param>
        /// <param name="pTopology">
        /// Pointer to the <see cref="IMFTopology"/> interface of the updated topology object. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The sequencer source has been shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT UpdateTopology(
        ///   [in]  MFSequencerElementId dwId,
        ///   [in]  IMFTopology *pTopology
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4ED6BE6C-A031-4628-A3C5-7F0676CC0BAF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4ED6BE6C-A031-4628-A3C5-7F0676CC0BAF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int UpdateTopology(
            [In] int dwId,
            [In, MarshalAs(UnmanagedType.Interface)] IMFTopology pTopology
            );

        /// <summary>
        /// Updates the flags for a topology in the queue.
        /// </summary>
        /// <param name="dwId">
        /// Sequencer element identifier of the topology to update.
        /// </param>
        /// <param name="dwFlags">
        /// Bitwise <strong>OR</strong> of flags from the <see cref="MFSequencerTopologyFlags"/> enumeration. 
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
        /// HRESULT UpdateTopologyFlags(
        ///   [in]  MFSequencerElementId dwId,
        ///   [in]  DWORD dwFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EE71B574-0456-4091-BBB0-DA5C57A7506E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EE71B574-0456-4091-BBB0-DA5C57A7506E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int UpdateTopologyFlags(
            [In] int dwId,
            [In] MFSequencerTopologyFlags dwFlags
            );
    }

}
