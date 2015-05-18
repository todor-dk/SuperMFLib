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
    /// Converts a partial topology into a full topology. The topology loader exposes this interface.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/5EBF117C-E60A-40F2-A24B-C4F9DBDAE942(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5EBF117C-E60A-40F2-A24B-C4F9DBDAE942(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("DE9A6157-F660-4643-B56A-DF9F7998C7CD")]
    internal interface IMFTopoLoader
    {
        /// <summary>
        /// Creates a fully loaded topology from the input partial topology. 
        /// </summary>
        /// <param name="pInputTopo">
        /// A pointer to the <see cref="IMFTopology"/> interface of the partial topology to be resolved. 
        /// </param>
        /// <param name="ppOutputTopo">
        /// Receives a pointer to the <see cref="IMFTopology"/> interface of the completed topology. The caller
        /// must release the interface. 
        /// </param>
        /// <param name="pCurrentTopo">
        /// A pointer to the <see cref="IMFTopology"/> interface of the previous full topology. The topology
        /// loader can re-use objects from this topology in the new topology. This parameter can be <strong>
        /// NULL</strong>. See Remarks. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_TOPO_SINK_ACTIVATES_UNSUPPORTED</strong></term><description>One or more output nodes contain <see cref="IMFActivate"/> pointers. The caller must bind the output nodes to media sinks. See <c>Binding Output Nodes to Media Sinks</c>. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Load(
        ///   [in]   IMFTopology *pInputTopo,
        ///   [out]  IMFTopology **ppOutputTopo,
        ///   [in]   IMFTopology *pCurrentTopo
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/02CE47DB-54A1-456A-A763-C62039AEA2C9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/02CE47DB-54A1-456A-A763-C62039AEA2C9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Load(
            [In, MarshalAs(UnmanagedType.Interface)] IMFTopology pInputTopo,
            [MarshalAs(UnmanagedType.Interface)] out IMFTopology ppOutputTopo,
            [In, MarshalAs(UnmanagedType.Interface)] IMFTopology pCurrentTopo
            );
    }

#endif

}
