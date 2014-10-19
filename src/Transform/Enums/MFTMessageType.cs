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

namespace MediaFoundation.Transform
{


    /// <summary>
    /// Defines messages for a Media Foundation transform (MFT). To send a message to an MFT, call 
    /// <see cref="Transform.IMFTransform.ProcessMessage"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/55B0AA32-53AF-4F19-9D99-9885C1E28588(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/55B0AA32-53AF-4F19-9D99-9885C1E28588(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFT_MESSAGE_TYPE")]
    public enum MFTMessageType
    {
        /// <summary>
        /// Requests the MFT to drain any stored data.
        /// <para/>
        /// See <c>MFT_MESSAGE_COMMAND_DRAIN</c>. 
        /// </summary>
        CommandDrain = 1,
        /// <summary>
        /// Requests the MFT to flush all stored data. 
        /// <para/>
        /// See <c>MFT_MESSAGE_COMMAND_FLUSH</c>. 
        /// </summary>
        CommandFlush = 0,
        /// <summary>
        /// Notifies the MFT that streaming is about to begin. 
        /// <para/>
        /// See <c>MFT_MESSAGE_NOTIFY_BEGIN_STREAMING</c>. 
        /// </summary>
        NotifyBeginStreaming = 0x10000000,
        /// <summary>
        /// Notifies the MFT that an input stream has ended. 
        /// <para/>
        /// See <c>MFT_MESSAGE_NOTIFY_END_OF_STREAM</c>. 
        /// </summary>
        NotifyEndOfStream = 0x10000002,
        /// <summary>
        /// Notifies the MFT that streaming is about to end. 
        /// <para/>
        /// See <c>MFT_MESSAGE_NOTIFY_END_STREAMING</c>. 
        /// </summary>
        NotifyEndStreaming = 0x10000001,
        /// <summary>
        /// Notifies the MFT that the first sample is about to be processed. 
        /// <para/>
        /// See <c>MFT_MESSAGE_NOTIFY_START_OF_STREAM</c>. 
        /// </summary>
        NotifyStartOfStream = 0x10000003,
        /// <summary>
        /// Sets or clears the <c>Direct3D Device Manager</c> for DirectX Video Accereration (DXVA). 
        /// <para/>
        /// See <c>MFT_MESSAGE_SET_D3D_MANAGER</c>. 
        /// </summary>
        SetD3DManager = 2,
        /// <summary>
        /// <strong>Note</strong> Requires Windows 7. 
        /// </summary>
        DropSamples = 0x00000003,
        /// <summary>
        /// <strong>Note</strong> Requires Windows 8. 
        /// </summary>
        CommandTick = 0x00000004,
        /// <summary>
        /// Marks a point in the stream. This message applies only to asynchronous MFTs. 
        /// <para/>
        /// See <c>MFT_MESSAGE_COMMAND_MARKER</c>. 
        /// <para/>
        /// <strong>Note</strong> Requires Windows 7 
        /// </summary>
        CommandMarker = 0x20000000
    }

}
