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

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation.Core.Enums
{

    /// <summary>
    /// Flags used in conjunction with the <see cref="IMFAsyncCallback.GetParameters"/> method.
    /// </summary>
    /// <remarks>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/374DD139-D3E7-45D0-A7D3-1187B928EF57(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/374DD139-D3E7-45D0-A7D3-1187B928EF57(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFASYNC_CALLBACK_QUEUE_ defines")]
    internal enum MFAsyncCallbackQueue
    {
        /// <summary>
        /// Undefined work queue.
        /// </summary>
        Undefined = 0x00000000,
        /// <summary>
        /// In most cases, applications should use <see cref="QueueMultiThreaded"/>.
        /// <para/>
        /// This work queue is used for synchronous operations. Using the standard work 
        /// queue may run the risk of deadlocking. Applications can create a private synchronous 
        /// queue on top of the multithreaded queue by using <c>MFAllocateSerialWorkQueue</c>.
        /// </summary>
        Standard = 0x00000001,
        /// <summary>
        /// Not for general application use.
        /// </summary>
        RT = 0x00000002,
        /// <summary>
        /// Not for general application use.
        /// <para/>
        /// This work queue is used internally for I/O operations such as reading files and 
        /// reading from the network.
        /// </summary>
        IO = 0x00000003,
        /// <summary>
        /// Not for general application use.
        /// <para/>
        /// This work queue is used for periodic callbacks and scheduled work items. 
        /// The following functions put work items in this queue:
        /// <para>* MFAddPeriodicCallback</para>
        /// <para>* MFScheduleWorkItem</para>
        /// <para>* MFScheduleWorkItemEx</para>
        /// </summary>
        Timer = 0x00000004,
        /// <summary>
        /// This multithreaded work queue should be used in most cases. 
        /// <para/>
        /// This work queue is used for asynchronous operations throughout Media Foundation.
        /// </summary>
        QueueMultiThreaded = 0x00000005,
        /// <summary>
        /// Not for general application use. Applications should instead use <see cref="QueueMultiThreaded"/>.
        /// </summary>
        LongFunction = 0x00000007,
        /// <summary>
        /// Bit mask to distinguish platform work queues from those created by calling <c>MFAllocateWorkQueue</c>.
        /// For a work queue created by MFAllocateWorkQueue, the following value is nonzero:
        /// <c>(identifier &amp; MFAsyncCallbackQueue.PrivateMask)</c>
        /// </summary>
        PrivateMask = unchecked((int)0xFFFF0000),
        /// <summary>
        /// All platform work queues.
        /// </summary>
        All = unchecked((int)0xFFFFFFFF)
    }

}
