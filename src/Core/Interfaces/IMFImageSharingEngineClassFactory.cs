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

namespace MediaFoundation.Core.Interfaces
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// <i>***** Documentation Missing *****</i>.
    /// </summary>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("1FC55727-A7FB-4FC8-83AE-8AF024990AF1"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFImageSharingEngineClassFactory
    {
        /// <summary>
        /// <i>***** Documentation Missing *****</i>.
        /// </summary>
        /// <param name="pUniqueDeviceName"><i>***** Documentation Missing *****</i>.</param>
        /// <param name="ppEngine"><i>***** Documentation Missing *****</i>.</param>
        /// <returns><i>***** Documentation Missing *****</i>.</returns>
        [PreserveSig]
        int CreateInstanceFromUDN(
            [MarshalAs(UnmanagedType.BStr)]
            string pUniqueDeviceName,
            out IMFImageSharingEngine ppEngine
            );
    }

#endif

}
