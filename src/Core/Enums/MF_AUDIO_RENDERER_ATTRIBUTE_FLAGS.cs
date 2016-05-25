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
    /// Attributes for use with <see cref="MFExtern.MFCreateAudioRenderer"/> and the
    /// <see cref="MFAttributesClsid.MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS"/> attribute.
    /// </summary>
    [Flags, UnmanagedName("MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS")]
    internal enum MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0x00000000,
        /// <summary>
        /// If this attribute bit is set, the audio renderer will treat a <see cref="MFAttributesClsid.MF_AUDIO_RENDERER_ATTRIBUTE_SESSION_ID"/>
        /// set on it as a cross-process session, allowing audio renderers in multiple processes to share the 
        /// audio session and associated volume and policy control. Otherwise, audio sessions will always stay 
        /// local to audio renderers in the current process.
        /// </summary>
        CrossProcess = 0x00000001,
        /// <summary>
        /// If this attribute bit is set, audio engine is not going to persist properties for audio session.
        /// </summary>
        NoPersist = 0x00000002,
        /// <summary>
        /// In order to handle dynamic audio device changes without requiring the application to listen for device 
        /// change events and swap renderers dynamically (and deal with any clocking issues that stem from that) 
        /// the audio renderer sink was enhanced to support format changes when generated by an audio device change 
        /// (in-band formats changes are handled by the MF pipeline, which can dynamically insert a resampler). 
        /// <para/>
        /// This attribute can be used to disable these enhancements and prevent the SAR from allowing its media type 
        /// to be changed in this situations. In those cases it will send the necessary events on dynamic device 
        /// changes to allow the app to handle the device changes itself.
        /// </summary>
        DontAllowFormatChanges = 0x00000004
    }

#endif

}
