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

namespace MediaFoundation
{
    /// <summary>
    /// Flags used in conjunction with the <see cref="IMFAsyncCallback.GetParameters"/> method.
    /// </summary>
    /// <remarks>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/374DD139-D3E7-45D0-A7D3-1187B928EF57(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/374DD139-D3E7-45D0-A7D3-1187B928EF57(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags]
    [UnmanagedName("MFASYNC_* defines")]
    public enum MFASync
    {
        /// <summary>
        /// The callback does not take a long time to complete, but has no specific restrictions
        /// on what system calls it makes. The callback generally takes less than 30 milliseconds to complete.
        /// </summary>
        None = 0,

        /// <summary>
        /// The callback does very minimal processing. It takes less than 1 millisecond to complete.
        /// The callback must be invoked from one of the following work queues:
        /// <para>* <strong>MFASYNC_CALLBACK_QUEUE_IO</strong></para>
        /// <para>* <strong>MFASYNC_CALLBACK_QUEUE_TIMER</strong></para>
        /// </summary>
        FastIOProcessingCallback = 0x00000001,

        /// <summary>
        /// Implies <strong>MFASYNC_FAST_IO_PROCESSING_CALLBACK</strong>, with the additional restriction
        /// that the callback does no processing (less than 50 microseconds), and the only system call it
        /// makes is <strong>SetEvent</strong>.
        /// <para/>
        /// The callback must be invoked from one of the following work queues:
        /// <para>* <strong>MFASYNC_CALLBACK_QUEUE_IO</strong></para>
        /// <para>* <strong>MFASYNC_CALLBACK_QUEUE_TIMER</strong></para>
        /// </summary>
        SignalCallback = 0x00000002,

        /// <summary>
        /// Blocking callback.
        /// </summary>
        BlockingCallback = 0x00000004,

        /// <summary>
        /// Reply callback.
        /// </summary>
        ReplyCallback = 0x00000008,

        /// <summary>
        /// The callback object is not apartment-agile and the callback pointer must be localized after an RPC.
        /// </summary>
        LocalizeRemoteCallback = 0x00000010,
    }
}
