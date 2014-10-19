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

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Defines error status codes for the Media Engine.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/CFA5C2AF-C804-47B4-B76A-907F26CF3DFC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CFA5C2AF-C804-47B4-B76A-907F26CF3DFC(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_MEDIA_ENGINE_ERR")]
    public enum MF_MEDIA_ENGINE_ERR : short
    {
        /// <summary>
        /// No error.
        /// </summary>
        NoError = 0,
        /// <summary>
        /// The process of fetching the media resource was stopped at the user's request. 
        /// </summary>
        Aborted = 1,
        /// <summary>
        /// A network error occurred while fetching the media resource. 
        /// </summary>
        Network = 2,
        /// <summary>
        /// An error occurred while decoding the media resource. 
        /// </summary>
        Decode = 3,
        /// <summary>
        /// The media resource is not supported. 
        /// </summary>
        SrcNotSupported = 4
    }

#endif

}
