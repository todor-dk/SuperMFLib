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
    /// Updates the attributes of one or more nodes in the Media Session's current topology.
    /// <para/>
    /// The Media Session exposes this interface as a service. To get a pointer to the interface, call 
    /// <see cref="IMFGetService.GetService"/>. The service identifier is
    /// MF_TOPONODE_ATTRIBUTE_EDITOR_SERVICE. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/9AB384B9-0CE9-428C-A683-B09DBD4E07D9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9AB384B9-0CE9-428C-A683-B09DBD4E07D9(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("676AA6DD-238A-410D-BB99-65668D01605A"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFTopologyNodeAttributeEditor
    {
        /// <summary>
        /// Updates the attributes of one or more nodes in the current topology.
        /// </summary>
        /// <param name="TopoId">
        /// Reserved.
        /// </param>
        /// <param name="cUpdates">
        /// The number of elements in the <em>pUpdates</em> array. 
        /// </param>
        /// <param name="pUpdates">
        /// Pointer to an array of <see cref="MFTopoNodeAttributeUpdate"/> structures. Each element of the
        /// array updates one attribute on a node. 
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
        /// HRESULT UpdateNodeAttributes(
        ///   [in]  TOPOID TopoId,
        ///   [in]  DWORD cUpdates,
        ///   [in]  MFTOPONODE_ATTRIBUTE_UPDATE *pUpdates
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A769B0BD-A43F-478B-A6E4-BBEF05942616(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A769B0BD-A43F-478B-A6E4-BBEF05942616(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int UpdateNodeAttributes(
            [In] long TopoId,
            [In] int cUpdates,
            [In] ref MFTopoNodeAttributeUpdate pUpdates
            );
    }

#endif

}
