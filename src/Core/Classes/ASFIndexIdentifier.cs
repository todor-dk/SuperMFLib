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

using MediaFoundation.Misc;

namespace MediaFoundation.Core.Classes
{
#if NOT_IN_USE

    /// <summary>
    /// Specifies an index for the ASF indexer object. 
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _ASF_INDEX_IDENTIFIER {
    ///   GUID guidIndexType;
    ///   WORD wStreamNumber;
    /// } ASF_INDEX_IDENTIFIER;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/8103A62E-6D1A-4DCD-AF91-CEDB30523004(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8103A62E-6D1A-4DCD-AF91-CEDB30523004(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("ASF_INDEX_IDENTIFIER")]
    internal class  ASFIndexIdentifier
    {
        /// <summary>
        /// The type of index. Currently this value must be GUID_NULL, which specifies time-based indexing. 
        /// </summary>
        public Guid guidIndexType;
        /// <summary>
        /// The stream number to which this structure applies. 
        /// </summary>
        public short wStreamNumber;
    }
#endif
}
