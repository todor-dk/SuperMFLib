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

namespace MediaFoundation.Core.Structs
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Contains information about a media sharing device.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct DEVICE_INFO {
    ///   BSTR pFriendlyDeviceName;
    ///   BSTR pUniqueDeviceName;
    ///   BSTR pManufacturerName;
    ///   BSTR pModelName;
    ///   BSTR pIconURL;
    /// } DEVICE_INFO;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/B006298C-B733-4E76-BD31-A3D1DD4DC766(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B006298C-B733-4E76-BD31-A3D1DD4DC766(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DEVICE_INFO")]
    internal struct DEVICE_INFO
    {
        /// <summary>
        /// The friendly name of the device.
        /// </summary>
        [MarshalAs(UnmanagedType.BStr)]
        string pFriendlyDeviceName;

        /// <summary>
        /// A string that uniquely identifes the device.
        /// </summary>
        [MarshalAs(UnmanagedType.BStr)]
        string pUniqueDeviceName;

        /// <summary>
        /// The manufacturer name.
        /// </summary>
        [MarshalAs(UnmanagedType.BStr)]
        string pManufacturerName;

        /// <summary>
        /// The model name.
        /// </summary>
        [MarshalAs(UnmanagedType.BStr)]
        string pModelName;

        /// <summary>
        /// The URL of an icon for the device.
        /// </summary>
        [MarshalAs(UnmanagedType.BStr)]
        string pIconURL;
    }

#endif

}
