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

// This file is a mess.  While technically part of MF, I'm in no hurry 
// to try to get this to work.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace MediaFoundation.OPM.Classes
{

#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// This class exposes Media Foundation API functions for the Output Protection Manager (OPM).
    /// </summary>
    internal class  OPMExtern
    {
        /// <summary>
        /// Creates an Output Protection Manager (OPM) object for each physical monitor that is associated with
        /// a particular <strong>HMONITOR</strong> handle. 
        /// </summary>
        /// <param name="hMonitor">
        /// The monitor handle for which to create OPM objects. There are several functions that return 
        /// <strong>HMONITOR</strong> values. For more information, see the topic 
        /// <c>Multiple Display Monitors Functions</c> in the Windows graphics device interface (GDI)
        /// documentation. 
        /// </param>
        /// <param name="vos">
        /// A member of the <see cref="OPM.OPM_VIDEO_OUTPUT_SEMANTICS"/> enumeration. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>OPM_VOS_OPM_SEMANTICS</strong></term><description>The returned <see cref="OPM.IOPMVideoOutput"/> pointers will use OPM semantics. </description></item>
        /// <item><term><strong>OPM_VOS_COPP_SEMANTICS</strong></term><description>The returned <see cref="OPM.IOPMVideoOutput"/> pointers will use Certified Output Protection Protocol (COPP) semantics. </description></item>
        /// </list>
        /// </param>
        /// <param name="pulNumVideoOutputs">
        /// Receives the number of <see cref="OPM.IOPMVideoOutput"/> pointers returned in the <em>
        /// pppOPMVideoOutputArray</em> parameter. 
        /// </param>
        /// <param name="pppOPMVideoOutputArray">
        /// Receives a pointer to an array of <see cref="OPM.IOPMVideoOutput"/> pointers. Each <strong>
        /// IOPMVideoOutput</strong> pointer is associated with a single physical monitor. The caller must
        /// release each pointer in the array, and call <c>CoTaskMemFree</c> to free the array. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OPMGetVideoOutputsFromHMONITOR(
        ///   _In_   HMONITOR hMonitor,
        ///   _In_   OPM_VIDEO_OUTPUT_SEMANTICS vos,
        ///   _Out_  ULONG *pulNumVideoOutputs,
        ///   _Out_  IOPMVideoOutput ***pppOPMVideoOutputArray
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C034AC81-43D4-482A-9DAD-234D33A15046(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C034AC81-43D4-482A-9DAD-234D33A15046(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("Dxva2.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int OPMGetVideoOutputsFromHMONITOR(
            IntPtr hMonitor,
            OPM_VIDEO_OUTPUT_SEMANTICS vos,
            out int pulNumVideoOutputs,
            IntPtr pppOPMVideoOutputArray       // ISYN: IOPMVideoOutput***
            );

        /// <summary>
        /// Creates an Output Protection Manager (OPM) object for each physical monitor that is associated with
        /// a particular Direct3D device.
        /// </summary>
        /// <param name="pDirect3DDevice9">
        /// Pointer to the <strong>IDirect3DDevice9</strong> interface of a Direct3D device. 
        /// </param>
        /// <param name="vos">
        /// A member of the <see cref="OPM.OPM_VIDEO_OUTPUT_SEMANTICS"/> enumeration. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>OPM_VOS_OPM_SEMANTICS</strong></term><description>The returned <see cref="OPM.IOPMVideoOutput"/> pointers will use OPM semantics. </description></item>
        /// <item><term><strong>OPM_VOS_COPP_SEMANTICS</strong></term><description>The returned <see cref="OPM.IOPMVideoOutput"/> pointers will use Certified Output Protection Protocol (COPP) semantics. </description></item>
        /// </list>
        /// </param>
        /// <param name="pulNumVideoOutputs">
        /// Receives the number of <see cref="OPM.IOPMVideoOutput"/> pointers returned in the <em>
        /// pppOPMVideoOutputArray</em> parameter. 
        /// </param>
        /// <param name="pppOPMVideoOutputArray">
        /// Receives a pointer to an array of <see cref="OPM.IOPMVideoOutput"/> pointers. Each <strong>
        /// IOPMVideoOutput</strong> pointer is associated with a single physical monitor. The caller must
        /// release each pointer in the array, and call <c>CoTaskMemFree</c> to free the array. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OPMGetVideoOutputsFromIDirect3DDevice9Object(
        ///   _In_   IDirect3DDevice9 *pDirect3DDevice9,
        ///   _In_   OPM_VIDEO_OUTPUT_SEMANTICS vos,
        ///   _Out_  ULONG *pulNumVideoOutputs,
        ///   _Out_  IOPMVideoOutput ***pppOPMVideoOutputArray
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9B287058-9E06-4C40-84F4-506AEFCE5B8A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9B287058-9E06-4C40-84F4-506AEFCE5B8A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("Dxva2.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int OPMGetVideoOutputsFromIDirect3DDevice9Object(
            [MarshalAs(UnmanagedType.IUnknown)] object pDirect3DDevice9, // IDirect3DDevice9
            OPM_VIDEO_OUTPUT_SEMANTICS vos,
            out int pulNumVideoOutputs,
            IntPtr pppOPMVideoOutputArray       // ISYN: IOPMVideoOutput***
            );
    }

#endif

}
