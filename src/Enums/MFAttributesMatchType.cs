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
using System.Drawing;

namespace MediaFoundation
{


    /// <summary>
    /// Specifies how to compare the attributes on two objects.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/CFA534C4-88C3-4170-B977-C24EA5593F6C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CFA534C4-88C3-4170-B977-C24EA5593F6C(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_ATTRIBUTES_MATCH_TYPE")]
    public enum MFAttributesMatchType
    {
        /// <summary>
        /// Check whether all the attributes in <em>pThis</em> exist in <em>pTheirs</em> and have the same
        /// data, where <em>pThis</em> is the object whose <c>Compare</c> method is being called and <em>
        /// pTheirs</em> is the object given in the <em>pTheirs</em> parameter. 
        /// </summary>
        OurItems,
        /// <summary>
        /// Check whether all the attributes in <em>pTheirs</em> exist in <em>pThis</em> and have the same
        /// data, where <em>pThis</em> is the object whose <c>Compare</c> method is being called and <em>
        /// pTheirs</em> is the object given in the <em>pTheirs</em> parameter. 
        /// </summary>
        TheirItems,
        /// <summary>
        /// Check whether both objects have identical attributes with the same data.
        /// </summary>
        AllItems,
        /// <summary>
        /// Check whether the attributes that exist in both objects have the same data.
        /// </summary>
        InterSection,
        /// <summary>
        /// Find the object with the fewest number of attributes, and check if those attributes exist in the
        /// other object and have the same data.
        /// </summary>
        Smaller
    }

}
