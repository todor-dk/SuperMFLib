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

namespace MediaFoundation.Transform.Enums
{
#if NOT_IN_USE

    /// <summary>
    /// Defines flags for processing output samples in a Media Foundation transform (MFT).
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/846E91A5-7CD8-4B58-9484-B9CB9AF0BEBF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/846E91A5-7CD8-4B58-9484-B9CB9AF0BEBF(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("_MFT_PROCESS_OUTPUT_FLAGS")]
    internal enum MFTProcessOutputFlags
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// Do not produce output for streams in which the <strong>pSample</strong> member of the 
        /// <see cref="Transform.MFTOutputDataBuffer"/> structure is <strong>NULL</strong>. This flag is not
        /// valid unless the MFT has marked the output stream with the MFT_OUTPUT_STREAM_DISCARDABLE or
        /// MFT_OUTPUT_STREAM_LAZY_READ flag. For more information, see 
        /// <see cref="Transform.IMFTransform.GetOutputStreamInfo"/>. 
        /// </summary>
        DiscardWhenNoBuffer = 0x00000001,
        /// <summary>
        /// Regenerates the last output sample.
        /// <para/>
        /// <strong>Note</strong> Requires Windows 8. 
        /// </summary>
        RegenerateLastOutput = 0x00000002
    }

#endif
}
