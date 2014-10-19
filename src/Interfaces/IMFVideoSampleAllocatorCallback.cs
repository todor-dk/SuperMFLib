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
    /// Enables an application to track video samples allocated by the enhanced video renderer (EVR).
    /// <para/>
    /// The stream sinks on the EVR expose this interface as a service. To get a pointer to the interface,
    /// call the <see cref="IMFGetService.GetService"/> method, using the <strong>
    /// MR_VIDEO_ACCELERATION_SERVICE</strong> service identifier. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/7DBF8B3A-24B3-41D9-BB1E-9C57B88A77AC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7DBF8B3A-24B3-41D9-BB1E-9C57B88A77AC(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("992388B4-3372-4F67-8B6F-C84C071F4751")]
    public interface IMFVideoSampleAllocatorCallback
    {
        /// <summary>
        /// Sets the callback object that receives notification whenever a video sample is returned to the
        /// allocator.
        /// </summary>
        /// <param name="pNotify">
        /// A pointer to the <see cref="IMFVideoSampleAllocatorNotify"/> interface that receives notification,
        /// or <strong>NULL</strong> to remove the callback. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetCallback(
        ///   [in]  IMFVideoSampleAllocatorNotify *pNotify
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EDCF1EF2-D71F-4CA1-94DB-EBF358E80E57(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EDCF1EF2-D71F-4CA1-94DB-EBF358E80E57(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetCallback(
            IMFVideoSampleAllocatorNotify pNotify
        );

        /// <summary>
        /// Gets the number of video samples that are currently available for use.
        /// </summary>
        /// <param name="plSamples">
        /// Receives the number of available samples.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetFreeSampleCount(
        ///   [out]  LONG *plSamples
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0025067B-1C8F-4F1A-91F2-EDF6A274523B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0025067B-1C8F-4F1A-91F2-EDF6A274523B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetFreeSampleCount(
            out int plSamples
        );
    }

#endif

}
