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
using System.Runtime.InteropServices;

using MediaFoundation.Misc;
using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Provides methods for getting information about the <c>Output Protection Manager</c> (OPM). 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/399F81AC-38F8-4AAA-8B34-F5FD13B71402(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/399F81AC-38F8-4AAA-8B34-F5FD13B71402(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("765763e6-6c01-4b01-bb0f-b829f60ed28c"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaEngineOPMInfo
    {
        /// <summary>
        /// Gets status information about the <c>Output Protection Manager</c> (OPM). 
        /// </summary>
        /// <param name="pStatus">
        /// A pointer to a <c>MF_MEDIA_ENGINE_OPM_STATUS</c> enum type that indicates the OPM status. 
        /// </param>
        /// <param name="pConstricted">
        /// A pointer to a <strong>BOOL</strong> type that indicates the constriction status. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded</description></item>
        /// <item><term><strong>INVALIDARG</strong></term><description>If any of the parameters are <strong>NULL</strong>. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetOPMInfo(
        ///   [out]  MF_MEDIA_ENGINE_OPM_STATUS *pStatus,
        ///   [out]  BOOL *pConstricted
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5E4A6E8F-5042-4DE1-8CEA-64B8E6CC928A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5E4A6E8F-5042-4DE1-8CEA-64B8E6CC928A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetOPMInfo(
            out MF_MEDIA_ENGINE_OPM_STATUS pStatus,
            [MarshalAs(UnmanagedType.Bool)] out bool pConstricted
            );
    }

#endif
}
