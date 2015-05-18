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
    /// Modifies a topology for use in a Terminal Services environment. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/75BB9BF8-12A7-430F-9943-18623AFF9903(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/75BB9BF8-12A7-430F-9943-18623AFF9903(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("1CDE6309-CAE0-4940-907E-C1EC9C3D1D4A"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFRemoteDesktopPlugin
    {
        /// <summary>
        /// Modifies a topology for use in a Terminal Services environment.
        /// </summary>
        /// <param name="pTopology">
        /// Pointer to the <see cref="IMFTopology"/> interface of the topology. 
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
        /// HRESULT UpdateTopology(
        ///   [in, out]  IMFTopology *pTopology
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/799BA0B4-B015-4899-9496-D8C23D033B24(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/799BA0B4-B015-4899-9496-D8C23D033B24(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int UpdateTopology(
            [In, Out, MarshalAs(UnmanagedType.Interface)] IMFTopology pTopology
            );
    }

#endif

}
