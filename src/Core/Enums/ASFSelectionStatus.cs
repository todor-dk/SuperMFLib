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

namespace MediaFoundation.Core.Enums
{


    /// <summary>
    /// Defines the selection options for an ASF stream.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/1571650B-4D5C-49AE-9E6D-77EF4AE7AE59(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1571650B-4D5C-49AE-9E6D-77EF4AE7AE59(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("ASF_SELECTION_STATUS")]
    internal enum ASFSelectionStatus
    {
        /// <summary>
        /// No samples from the stream are delivered.
        /// </summary>
        NotSelected = 0,
        /// <summary>
        /// Only samples from the stream that are clean points are delivered.
        /// </summary>
        CleanPointsOnly = 1,
        /// <summary>
        /// All samples from the stream are delivered.
        /// </summary>
        AllDataUnits = 2
    }

}
