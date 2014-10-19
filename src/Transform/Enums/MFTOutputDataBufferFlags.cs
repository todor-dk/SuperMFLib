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
    /// Defines flags for the <see cref="Transform.IMFTransform.ProcessOutput"/> method. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/B975A1A9-2CD1-4187-9934-C6877F10CEC6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B975A1A9-2CD1-4187-9934-C6877F10CEC6(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("_MFT_OUTPUT_DATA_BUFFER_FLAGS")]
    public enum MFTOutputDataBufferFlags
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// The MFT can still generate output from this stream without receiving any more input. Call 
        /// <c>ProcessOutput</c> again to process the next batch of input data. 
        /// </summary>
        Incomplete = 0x01000000,
        /// <summary>
        /// The format has changed on this output stream, or there is a new preferred format for this stream.
        /// When this flag is set, the MFT clears the media type for the stream. The <c>ProcessOutput</c>
        /// method returns MF_E_TRANSFORM_STREAM_CHANGE and generates no output for any stream. Further calls
        /// to <see cref="Transform.IMFTransform.ProcessInput"/> or <strong>ProcessOutput</strong> will fail
        /// until the client sets a new media type. 
        /// </summary>
        FormatChange = 0x00000100,
        /// <summary>
        /// The MFT has removed this output stream. The output stream must have the MFT_OUTPUT_STREAM_REMOVABLE
        /// flag. (See <see cref="Transform.IMFTransform.GetOutputStreamInfo"/>.) 
        /// <para/>
        /// When the MFT removes an output stream, the MFT returns this status code on the next call to 
        /// <c>ProcessOutput</c> after the last output sample has been produced. When the MFT returns this
        /// status code, it does not modify any sample contained in the <strong>pSample</strong> member of the 
        /// <see cref="Transform.MFTOutputDataBuffer"/> structure, nor does it allocate a new sample if 
        /// <strong>pSample</strong> is <strong>NULL</strong>. 
        /// <para/>
        /// After this status code is returned, the stream identifier for this output stream is no longer
        /// valid. The client should no longer provide an <see cref="Transform.MFTOutputDataBuffer"/> structure
        /// for that stream when it calls <c>ProcessOutput</c>. 
        /// <para/>
        /// The <c>ProcessOutput</c> method does not return <strong>MF_E_TRANSFORM_STREAM_CHANGE</strong> when
        /// a stream ends, unless there is a change in another stream that requires this return code. 
        /// </summary>
        StreamEnd = 0x00000200,
        /// <summary>
        /// There is no sample ready for this stream. This flag might be set if the MFT has multiple output
        /// streams that produce data at different times. It sets this flag for each stream that is not ready
        /// to produce data. It does not modify the output sample contained in the <strong>pSample</strong>
        /// member of the <see cref="Transform.MFTOutputDataBuffer"/> structure, nor does it allocate a new
        /// sample is <strong>pSample</strong> is <strong>NULL</strong>. 
        /// <para/>
        /// If no streams are ready to produce output, the MFT does not set this flag. Instead, the 
        /// <c>ProcessOutput</c> method returns MF_E_TRANSFORM_NEED_MORE_INPUT. 
        /// </summary>
        NoSample = 0x00000300
    }

}
