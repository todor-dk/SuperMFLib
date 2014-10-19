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
    /// Notifies a pipeline object to register itself with the Multimedia Class Scheduler Service (MMCSS).
    /// <para/>
    /// Any pipeline object that creates worker threads should implement this interface.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/B1D1901E-DD49-421F-9212-61E32CFF411E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B1D1901E-DD49-421F-9212-61E32CFF411E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("2347D60B-3FB5-480C-8803-8DF3ADCD3EF0")]
    public interface IMFRealTimeClient
    {
        /// <summary>
        /// Notifies the object to register its worker threads with the Multimedia Class Scheduler Service
        /// (MMCSS).
        /// </summary>
        /// <param name="dwTaskIndex">
        /// The MMCSS task identifier. 
        /// </param>
        /// <param name="wszClass">
        /// The name of the MMCSS task. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT RegisterThreads(
        ///   [in]  DWORD dwTaskIndex,
        ///   [in]  LPCWSTR wszClass
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0ED3A8F6-1EA1-44AF-AC6E-8712FD59AE31(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0ED3A8F6-1EA1-44AF-AC6E-8712FD59AE31(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RegisterThreads(
            [In] int dwTaskIndex,
            [In, MarshalAs(UnmanagedType.LPWStr)] string wszClass
            );

        /// <summary>
        /// Notifies the object to unregister its worker threads from the Multimedia Class Scheduler Service
        /// (MMCSS). 
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT UnregisterThreads();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9BD65FF1-C283-47B8-8299-383B2B773C18(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9BD65FF1-C283-47B8-8299-383B2B773C18(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int UnregisterThreads();

        /// <summary>
        /// Specifies the work queue for the topology branch that contains this object.
        /// </summary>
        /// <param name="dwWorkQueueId">
        /// The identifier of the work queue, or the value <strong>MFASYNC_CALLBACK_QUEUE_UNDEFINED</strong>.
        /// See Remarks. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetWorkQueue(
        ///   [in]  DWORD dwWorkQueueId
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2744DDAF-A1AD-415A-B387-1A3D3B4821BF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2744DDAF-A1AD-415A-B387-1A3D3B4821BF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetWorkQueue(
            [In] int dwWorkQueueId
            );
    }

#endif

}
