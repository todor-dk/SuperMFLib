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
    /// This interface is a replacement for the <see cref="IMFRealTimeClient"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/EC5CDD23-B862-4DAE-AC01-4926C4FAD89A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EC5CDD23-B862-4DAE-AC01-4926C4FAD89A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("03910848-AB16-4611-B100-17B88AE2F248")]
    public interface IMFRealTimeClientEx
    {
        /// <summary>
        /// Notifies the object to register its worker threads with the Multimedia Class Scheduler Service
        /// (MMCSS).
        /// </summary>
        /// <param name="pdwTaskIndex">
        /// The MMCSS task identifier. If the value is zero on input,  the object should create a new MCCSS
        /// task group. See Remarks.
        /// </param>
        /// <param name="wszClassName">
        /// The name of the MMCSS task.
        /// </param>
        /// <param name="lBasePriority">
        /// The base priority of the thread.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT RegisterThreadsEx(
        ///   [in, out]  DWORD *pdwTaskIndex,
        ///   [in]       LPCWSTR wszClassName,
        ///   [in]       LONG lBasePriority
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/45E3121A-F6FD-49C7-B147-5317C045DE35(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/45E3121A-F6FD-49C7-B147-5317C045DE35(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RegisterThreadsEx( 
            ref int pdwTaskIndex,
            [In, MarshalAs(UnmanagedType.LPWStr)] string wszClassName,
            int lBasePriority
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
        /// <a href="http://msdn.microsoft.com/en-US/library/8ADA3DA3-9FCF-4B8B-8FED-07A6CC5DA7E1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8ADA3DA3-9FCF-4B8B-8FED-07A6CC5DA7E1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int UnregisterThreads( );

        /// <summary>
        /// Specifies the work queue that this object should use for asynchronous work items. 
        /// </summary>
        /// <param name="dwMultithreadedWorkQueueId">
        /// The work queue identifier.
        /// </param>
        /// <param name="lWorkItemBasePriority">
        /// The base priority for work items.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetWorkQueueEx(
        ///   DWORD dwMultithreadedWorkQueueId,
        ///   LONG lWorkItemBasePriority
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4F91FD8A-A8B6-4066-A0EB-F764A3BFD8A2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4F91FD8A-A8B6-4066-A0EB-F764A3BFD8A2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetWorkQueueEx( 
            int dwMultithreadedWorkQueueId,
            int lWorkItemBasePriority
        );        
    }

#endif

}
