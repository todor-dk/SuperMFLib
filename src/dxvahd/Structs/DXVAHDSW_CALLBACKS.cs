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
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation.dxvahd
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Contains pointers to functions implemented by a software plug-in for Microsoft DirectX Video
    /// Acceleration High Definition (DXVA-HD).
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHDSW_CALLBACKS {
    ///   PDXVAHDSW_CreateDevice                      CreateDevice;
    ///   PDXVAHDSW_ProposeVideoPrivateFormat         ProposeVideoPrivateFormat;
    ///   PDXVAHDSW_GetVideoProcessorDeviceCaps       GetVideoProcessorDeviceCaps;
    ///   PDXVAHDSW_GetVideoProcessorOutputFormats    GetVideoProcessorOutputFormats;
    ///   PDXVAHDSW_GetVideoProcessorInputFormats     GetVideoProcessorInputFormats;
    ///   PDXVAHDSW_GetVideoProcessorCaps             GetVideoProcessorCaps;
    ///   PDXVAHDSW_GetVideoProcessorCustomRates      GetVideoProcessorCustomRates;
    ///   PDXVAHDSW_GetVideoProcessorFilterRange      GetVideoProcessorFilterRange;
    ///   PDXVAHDSW_DestroyDevice                     DestroyDevice;
    ///   PDXVAHDSW_CreateVideoProcessor              CreateVideoProcessor;
    ///   PDXVAHDSW_SetVideoProcessBltState           SetVideoProcessBltState;
    ///   PDXVAHDSW_GetVideoProcessBltStatePrivate    GetVideoProcessBltStatePrivate;
    ///   PDXVAHDSW_SetVideoProcessStreamState        SetVideoProcessStreamState;
    ///   PDXVAHDSW_GetVideoProcessStreamStatePrivate GetVideoProcessStreamStatePrivate;
    ///   PDXVAHDSW_VideoProcessBltHD                 VideoProcessBltHD;
    ///   PDXVAHDSW_DestroyVideoProcessor             DestroyVideoProcessor;
    /// } DXVAHDSW_CALLBACKS;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/74C329CC-AF54-4CF8-8CB6-EED9E96DB4C5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/74C329CC-AF54-4CF8-8CB6-EED9E96DB4C5(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHDSW_CALLBACKS")]
    public struct DXVAHDSW_CALLBACKS
    {
        /// <summary>
        /// Function pointer of type <see cref="dxvahd.PDXVAHDSW_CreateDevice" />.
        /// </summary>
        public PDXVAHDSW_CreateDevice CreateDevice;
        /// <summary>
        /// Function pointer of type <see cref="dxvahd.PDXVAHDSW_ProposeVideoPrivateFormat" />.
        /// </summary>
        public PDXVAHDSW_ProposeVideoPrivateFormat ProposeVideoPrivateFormat;
        /// <summary>
        /// Function pointer of type <see cref="dxvahd.PDXVAHDSW_GetVideoProcessorDeviceCaps" />.
        /// </summary>
        public PDXVAHDSW_GetVideoProcessorDeviceCaps GetVideoProcessorDeviceCaps;
        /// <summary>
        /// Function pointer of type <see cref="dxvahd.PDXVAHDSW_GetVideoProcessorOutputFormats" />.
        /// </summary>
        public PDXVAHDSW_GetVideoProcessorOutputFormats GetVideoProcessorOutputFormats;
        /// <summary>
        /// Function pointer of type <see cref="dxvahd.PDXVAHDSW_GetVideoProcessorInputFormats" />.
        /// </summary>
        public PDXVAHDSW_GetVideoProcessorInputFormats GetVideoProcessorInputFormats;
        /// <summary>
        /// Function pointer of type <see cref="dxvahd.PDXVAHDSW_GetVideoProcessorCaps" />.
        /// </summary>
        public PDXVAHDSW_GetVideoProcessorCaps GetVideoProcessorCaps;
        /// <summary>
        /// Function pointer of type <see cref="dxvahd.PDXVAHDSW_GetVideoProcessorCustomRates" />.
        /// </summary>
        public PDXVAHDSW_GetVideoProcessorCustomRates GetVideoProcessorCustomRates;
        /// <summary>
        /// Function pointer of type <see cref="dxvahd.PDXVAHDSW_GetVideoProcessorFilterRange" />.
        /// </summary>
        public PDXVAHDSW_GetVideoProcessorFilterRange GetVideoProcessorFilterRange;
        /// <summary>
        /// Function pointer of type <see cref="dxvahd.PDXVAHDSW_DestroyDevice" />.
        /// </summary>
        public PDXVAHDSW_DestroyDevice DestroyDevice;
        /// <summary>
        /// Function pointer of type <see cref="dxvahd.PDXVAHDSW_CreateVideoProcessor" />.
        /// </summary>
        public PDXVAHDSW_CreateVideoProcessor CreateVideoProcessor;
        /// <summary>
        /// Function pointer of type <see cref="dxvahd.PDXVAHDSW_SetVideoProcessBltState" />.
        /// </summary>
        public PDXVAHDSW_SetVideoProcessBltState SetVideoProcessBltState;
        /// <summary>
        /// Function pointer of type <see cref="dxvahd.PDXVAHDSW_GetVideoProcessBltStatePrivate" />.
        /// </summary>
        public PDXVAHDSW_GetVideoProcessBltStatePrivate GetVideoProcessBltStatePrivate;
        /// <summary>
        /// Function pointer of type <see cref="dxvahd.PDXVAHDSW_SetVideoProcessStreamState" />.
        /// </summary>
        public PDXVAHDSW_SetVideoProcessStreamState SetVideoProcessStreamState;
        /// <summary>
        /// Function pointer of type <see cref="dxvahd.PDXVAHDSW_GetVideoProcessStreamStatePrivate" />.
        /// </summary>
        public PDXVAHDSW_GetVideoProcessStreamStatePrivate GetVideoProcessStreamStatePrivate;
        /// <summary>
        /// Function pointer of type <see cref="dxvahd.PDXVAHDSW_VideoProcessBltHD" />.
        /// </summary>
        public PDXVAHDSW_VideoProcessBltHD VideoProcessBltHD;
        /// <summary>
        /// Function pointer of type <see cref="dxvahd.PDXVAHDSW_DestroyVideoProcessor" />.
        /// </summary>
        public PDXVAHDSW_DestroyVideoProcessor DestroyVideoProcessor;
    }

#endif

}
