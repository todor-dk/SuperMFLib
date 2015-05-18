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

namespace MediaFoundation.Misc.Classes
{
#if NOT_IN_USE

    /// <summary>
    /// The <strong>VIDEOINFOHEADER</strong> structure describes the bitmap and color information for a
    /// video image. 
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct tagVIDEOINFOHEADER {
    ///   RECT             rcSource;
    ///   RECT             rcTarget;
    ///   DWORD            dwBitRate;
    ///   DWORD            dwBitErrorRate;
    ///   REFERENCE_TIME   AvgTimePerFrame;
    ///   BITMAPINFOHEADER bmiHeader;
    /// } VIDEOINFOHEADER;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A175592B-0DC1-4001-B52F-785407965932(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A175592B-0DC1-4001-B52F-785407965932(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("VIDEOINFOHEADER"), StructLayout(LayoutKind.Sequential)]
    internal class  VideoInfoHeader
    {
        /// <summary>
        /// A <c>RECT</c> structure that specifies the source video window. This structure can be a clipping
        /// rectangle, to select a portion of the source video stream. 
        /// </summary>
        public MFRect SrcRect;
        /// <summary>
        /// A <c>RECT</c> structure that specifies the destination video window. 
        /// </summary>
        public MFRect TargetRect;
        /// <summary>
        /// Approximate data rate of the video stream, in bits per second.
        /// </summary>
        public int BitRate;
        /// <summary>
        /// Data error rate, in bit errors per second.
        /// </summary>
        public int BitErrorRate;
        /// <summary>
        /// The desired average display time of the video frames, in 100-nanosecond units. The actual time per
        /// frame may be longer. See Remarks.
        /// </summary>
        public long AvgTimePerFrame;
        /// <summary>
        /// <see cref="Misc.BitmapInfoHeader"/> structure that contains color and dimension information for the
        /// video image bitmap. If the format block contains a color table or color masks, they immediately
        /// follow the <strong>bmiHeader</strong> member. You can get the first color entry by casting the
        /// address of member to a <strong>BITMAPINFO</strong> pointer. 
        /// <para/>
        /// When used inside a <strong>VIDEOINFOHEADER</strong> structure, the semantics of the 
        /// <see cref="Misc.BitmapInfoHeader"/> structure differ slightly from how the structure is used in
        /// GDI. For more information, refer to the topic <c>BITMAPINFOHEADER Structure</c>. 
        /// </summary>
        public BitmapInfoHeader BmiHeader;  // Custom marshaler?
    }

#endif

}
