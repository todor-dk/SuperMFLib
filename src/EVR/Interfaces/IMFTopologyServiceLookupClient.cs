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

using MediaFoundation;
using MediaFoundation.Misc;
using MediaFoundation.Transform;
using System.Drawing;

namespace MediaFoundation.EVR
{


    /// <summary>
    /// Initializes a video mixer or presenter. This interface is implemented by mixers and presenters, and
    /// enables them to query the enhanced video renderer (EVR) for interface pointers.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/C4215D08-3734-44B9-B053-0D49D89A90F6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C4215D08-3734-44B9-B053-0D49D89A90F6(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("FA99388A-4383-415A-A930-DD472A8CF6F7"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFTopologyServiceLookupClient
    {
        /// <summary>
        /// Signals the mixer or presenter to query the enhanced video renderer (EVR) for interface pointers.
        /// </summary>
        /// <param name="pLookup">
        /// Pointer to the <see cref="EVR.IMFTopologyServiceLookup"/> interface. To query the EVR for an
        /// interface, call <see cref="EVR.IMFTopologyServiceLookup.LookupService"/>. 
        /// </param>
        /// <returns>
        /// The method returns an HRESULT. Possible values include, but are not limited to, those in the
        /// following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT InitServicePointers(
        ///   [in]  IMFTopologyServiceLookup *pLookup
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B89F5A47-154C-455A-B5A2-DB55E4972B21(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B89F5A47-154C-455A-B5A2-DB55E4972B21(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int InitServicePointers(
            IMFTopologyServiceLookup pLookup
            );

        /// <summary>
        /// Signals the object to release the interface pointers obtained from the enhanced video renderer
        /// (EVR).
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
        /// HRESULT ReleaseServicePointers();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/03ED29B4-89C1-4702-A23F-D013EEEF5D44(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/03ED29B4-89C1-4702-A23F-D013EEEF5D44(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ReleaseServicePointers();
    }

}
