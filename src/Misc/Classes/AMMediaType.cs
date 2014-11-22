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

namespace MediaFoundation.Misc
{



    /// <summary>
    /// The <strong>AM_MEDIA_TYPE</strong> structure describes the format of a media sample. 
    /// <para/>
    /// <strong>IMPORTANT:</strong> When you are done with an instance of this class,
    /// it should be released with FreeAMMediaType() to avoid leaking
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _MediaType {
    ///   GUID     majortype;
    ///   GUID     subtype;
    ///   BOOL     bFixedSizeSamples;
    ///   BOOL     bTemporalCompression;
    ///   ULONG    lSampleSize;
    ///   GUID     formattype;
    ///   IUnknown *pUnk;
    ///   ULONG    cbFormat;
    ///   BYTE     *pbFormat;
    /// } AM_MEDIA_TYPE;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/973697D0-2897-48B5-88CA-A88A9650EB02(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/973697D0-2897-48B5-88CA-A88A9650EB02(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("AM_MEDIA_TYPE"), StructLayout(LayoutKind.Sequential)]
    public class AMMediaType
    {
        /// <summary>
        /// Globally unique identifier (GUID) that specifies the major type of the media sample. For a list of
        /// possible major types, see <c>Media Types</c>. 
        /// </summary>
        public Guid majorType;
        /// <summary>
        /// GUID that specifies the subtype of the media sample. For a list of possible subtypes, see 
        /// <c>Media Types</c>. For some formats, the value might be MEDIASUBTYPE_None, which means the format
        /// does not require a subtype. 
        /// </summary>
        public Guid subType;
        /// <summary>
        /// ********* DOCUMENTATION NOT FOUND *********
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool fixedSizeSamples;
        /// <summary>
        /// ********* DOCUMENTATION NOT FOUND *********
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool temporalCompression;
        /// <summary>
        /// ********* DOCUMENTATION NOT FOUND *********
        /// </summary>
        public int sampleSize;
        /// <summary>
        /// GUID that specifies the structure used for the format block. The <strong>pbFormat</strong> member
        /// points to the corresponding format structure. Format types include the following: 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Format type</term><description>Format structure</description></listheader>
        /// <item><term><strong>FORMAT_DvInfo</strong></term><description><c>DVINFO</c></description></item>
        /// <item><term><strong>FORMAT_MPEG2Video</strong></term><description><see cref="Mpeg2VideoInfo"/></description></item>
        /// <item><term><strong>FORMAT_MPEGStreams</strong></term><description><c>AM_MPEGSYSTEMTYPE</c></description></item>
        /// <item><term><strong>FORMAT_MPEGVideo</strong></term><description><see cref="Misc.MPEG1VideoInfo"/></description></item>
        /// <item><term><strong>FORMAT_None</strong></term><description>None.</description></item>
        /// <item><term><strong>FORMAT_VideoInfo</strong></term><description><see cref="Misc.VideoInfoHeader"/></description></item>
        /// <item><term><strong>FORMAT_VideoInfo2</strong></term><description><see cref="Misc.VideoInfoHeader2"/></description></item>
        /// <item><term><strong>FORMAT_WaveFormatEx</strong></term><description><see cref="Misc.WaveFormatEx"/></description></item>
        /// <item><term><strong>GUID_NULL</strong></term><description>None</description></item>
        /// </list>
        /// </summary>
        public Guid formatType;
        /// <summary>
        /// ********* DOCUMENTATION NOT FOUND *********
        /// </summary>
        public IntPtr unkPtr; // IUnknown Pointer
        /// <summary>
        /// ********* DOCUMENTATION NOT FOUND *********
        /// </summary>
        public int formatSize;
        /// <summary>
        /// ********* DOCUMENTATION NOT FOUND *********
        /// </summary>
        public IntPtr formatPtr; // Pointer to a buff determined by formatType
    }

}
