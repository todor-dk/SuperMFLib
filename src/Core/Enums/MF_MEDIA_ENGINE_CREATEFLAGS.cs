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
using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation.Core.Enums
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Contains flags for the <see cref="IMFMediaEngineClassFactory.CreateInstance"/> method. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/1709B08C-D4DC-4A33-9B92-1C4961208684(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1709B08C-D4DC-4A33-9B92-1C4961208684(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MF_MEDIA_ENGINE_CREATEFLAGS")]
    internal enum MF_MEDIA_ENGINE_CREATEFLAGS
    {
        /// <summary>
        /// The Media Engine will play audio only. It will not play video.
        /// </summary>
        AudioOnly = 0x0001,
        /// <summary>
        /// The Media Engine's resource loading algorithm waits for the application to signal the thread that
        /// loads the resource. For more information, see the remarks for <strong>
        /// MF_MEDIA_ENGINE_EVENT_NOTIFYSTABLESTATE</strong> in the <see cref="MF_MEDIA_ENGINE_EVENT"/>
        /// enumeration. 
        /// </summary>
        WaitForStableState = 0x0002,
        /// <summary>
        /// Always mute the audio.
        /// </summary>
        ForceMute = 0x0004,
        /// <summary>
        /// Enable low-latency mode in the rendering pipeline. This can be changed at a later time by calling 
        /// <see cref="IMFMediaEngineEx.SetRealTimeMode"/>. 
        /// </summary>
        RealTimeMode = 0x0008,
        /// <summary>
        /// Disable locally registered media plugins. If this flag is set, the Media Engine will not load
        /// decoders or other media plugins that the application registered for the local process.
        /// </summary>
        DisableLocalPlugins = 0x0010,
        /// <summary>
        /// Reserved.
        /// </summary>
        CreateFlagsMask = 0x001F
    }

#endif

}
