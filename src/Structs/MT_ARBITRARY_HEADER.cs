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

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Contains format data for a binary stream in an Advanced Streaming Format (ASF) file.
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct _MT_ARBITRARY_HEADER {
    ///   GUID  majortype;
    ///   GUID  subtype;
    ///   BOOL  bFixedSizeSamples;
    ///   BOOL  bTemporalCompression;
    ///   ULONG lSampleSize;
    ///   GUID  formattype;
    /// } MT_ARBITRARY_HEADER;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/EFE2CEB7-32F5-4A43-B4D9-807FE66D6EDB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EFE2CEB7-32F5-4A43-B4D9-807FE66D6EDB(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("MT_ARBITRARY_HEADER")]
    public struct MT_ARBITRARY_HEADER
    {
        /// <summary>
        /// Major media type. This value is the GUID stored in the Major Media Type field of the Type-Specific
        /// Data field of the ASF file. It might not match the major type GUID from the Media Foundation media
        /// type.
        /// </summary>
        public Guid majortype;
        /// <summary>
        /// Media subtype.
        /// </summary>
        public Guid subtype;
        /// <summary>
        /// If <strong>TRUE</strong>, samples have a fixed size in bytes. Otherwise, samples have variable
        /// size.
        /// </summary>
        public bool bFixedSizeSamples;
        /// <summary>
        /// If <strong>TRUE</strong>, the data in this stream uses temporal compression. Otherwise, samples are
        /// independent of each other.
        /// </summary>
        public bool bTemporalCompression;
        /// <summary>
        /// If <strong>bFixedSizeSamples</strong> is <strong>TRUE</strong>, this member specifies the sample
        /// size in bytes. Otherwise, the value is ignored and should be 0.
        /// </summary>
        public int lSampleSize;
        /// <summary>
        /// Format type GUID. This GUID identifies the structure of the additional format data, which is stored
        /// in the  <see cref="MFAttributesClsid.MF_MT_ARBITRARY_FORMAT" />  attribute of the media type. If no
        /// additional format data is present, <strong>formattype</strong> equals GUID_NULL.
        /// </summary>
        public Guid formattype;
    }

#endif

}
