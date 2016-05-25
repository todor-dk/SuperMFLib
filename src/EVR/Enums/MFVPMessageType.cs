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
    /// Defines messages for an enhanced video renderer (EVR) presenter. This enumeration is used with the
    /// <see cref="EVR.IMFVideoPresenter.ProcessMessage"/> method.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/71B92702-79A0-4C18-BB56-5E7C9E49CAD2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/71B92702-79A0-4C18-BB56-5E7C9E49CAD2(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFVP_MESSAGE_TYPE")]
    public enum MFVPMessageType
    {
        /// <summary>
        /// The presenter should discard any pending samples. The <em>ulParam</em> parameter is not used and
        /// should be zero.
        /// </summary>
        Flush = 0,

        /// <summary>
        /// The mixer's output format has changed. The EVR will initiate format negotiation. The <em>ulParam
        /// </em> parameter is not used and should be zero.
        /// </summary>
        InvalidateMediaType,

        /// <summary>
        /// One input stream on the mixer has received a new sample. The <em>ulParam</em> parameter is not used
        /// and should be zero.
        /// </summary>
        ProcessInputNotify,

        /// <summary>
        /// The EVR switched from stopped to paused. The presenter should allocate resources. The <em>ulParam
        /// </em> parameter is not used and should be zero.
        /// </summary>
        BeginStreaming,

        /// <summary>
        /// The EVR switched from running or paused to stopped. The presenter should free resources. The <em>
        /// ulParam</em> parameter is not used and should be zero.
        /// </summary>
        EndStreaming,

        /// <summary>
        /// All streams have ended. The <em>ulParam</em> parameter is not used and should be zero.
        /// </summary>
        EndOfStream,

        /// <summary>
        /// Requests a frame step. The lower <strong>DWORD</strong> of the <em>ulParam</em> parameter contains
        /// the number of frames to step. If the value is <em>N</em>, the presenter should skip <em>N</em>–1
        /// frames and display the <em>N</em> th frame. When that frame has been displayed, the presenter
        /// should send an <strong>EC_STEP_COMPLETE</strong> event to the EVR. If the presenter is not paused
        /// when it receives this message, it should return MF_E_INVALIDREQUEST.
        /// </summary>
        Step,

        /// <summary>
        /// Cancels a frame step. The <em>ulParam</em> parameter is not used and should be zero.
        /// </summary>
        CancelStep
    }
}
