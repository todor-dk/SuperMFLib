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

namespace MediaFoundation.Core.Enums
{

#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Specifies the type of work queue for the <see cref="MFExtern.MFAllocateWorkQueueEx"/> function to
    /// create. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A3627DBC-1794-4E2E-B7ED-869ED50CA893(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A3627DBC-1794-4E2E-B7ED-869ED50CA893(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFASYNC_WORKQUEUE_TYPE")]
    internal enum MFASYNC_WORKQUEUE_TYPE
    {
        /// <summary>
        /// Create a work queue without a message loop.
        /// </summary>
        StandardWorkqueue = 0,
        /// <summary>
        /// Create a work queue with a message loop.
        /// </summary>
        WindowWorkqueue = 1,
        /// <summary>
        /// Create a multithreaded work queue. This type of work queue uses a thread pool to dispatch work
        /// items. The caller is responsible for serializing the work items.
        /// </summary>
        MultiThreadedWorkqueue = 2
    }

#endif

}
