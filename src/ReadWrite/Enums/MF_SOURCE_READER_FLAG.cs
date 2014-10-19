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
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation.ReadWrite
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Contains flags that indicate the status of the <see cref="ReadWrite.IMFSourceReader.ReadSample"/>
    /// method. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/8981A682-3C0B-458B-910A-D1462ED73E64(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8981A682-3C0B-458B-910A-D1462ED73E64(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MF_SOURCE_READER_FLAG")]
    public enum MF_SOURCE_READER_FLAG
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// An error occurred. If you receive this flag, do not make any further calls to 
        /// <see cref="ReadWrite.IMFSourceReader"/> methods. 
        /// </summary>
        Error = 0x00000001,
        /// <summary>
        /// The source reader reached the end of the stream.
        /// </summary>
        EndOfStream = 0x00000002,
        /// <summary>
        /// One or more new streams were created. Respond to this flag by doing at least one of the following:
        /// <para/>
        /// <para>* Set the output types on the new streams.</para><para>* Update the stream selection by
        /// selecting or deselecting streams.</para>
        /// </summary>
        NewStream = 0x00000004,
        /// <summary>
        /// The <em>native format</em> has changed for one or more streams. The native format is the format
        /// delivered by the media source before any decoders are inserted. 
        /// </summary>
        NativeMediaTypeChanged = 0x00000010,
        /// <summary>
        /// The current media has type changed for one or more streams. To get the current media type, call the
        /// <see cref="ReadWrite.IMFSourceReader.GetCurrentMediaType"/> method. 
        /// </summary>
        CurrentMediaTypeChanged = 0x00000020,
        /// <summary>
        /// All transforms inserted by the application have been removed for a particular stream. This could be
        /// due to a dynamic format change from a source or decoder that prevents custom transforms from being
        /// used because they cannot handle the new media type.
        /// </summary>
        AllEffectsRemoved       = 0x00000200,
        /// <summary>
        /// There is a gap in the stream. This flag corresponds to an <c>MEStreamTick</c> event from the media
        /// source. 
        /// </summary>
        StreamTick = 0x00000100
    }

#endif

}
