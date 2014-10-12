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


    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("197CD219-19CB-4DE1-A64C-ACF2EDCBE59E"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFSequencerSource
    {
        [PreserveSig]
        int AppendTopology(
            [In, MarshalAs(UnmanagedType.Interface)] IMFTopology pTopology,
            [In] MFSequencerTopologyFlags dwFlags,
            out int pdwId
            );

        [PreserveSig]
        int DeleteTopology(
            [In] int dwId
            );

        [PreserveSig]
        int GetPresentationContext(
            [In, MarshalAs(UnmanagedType.Interface)] IMFPresentationDescriptor pPD,
            out int pID,
            [MarshalAs(UnmanagedType.Interface)] out IMFTopology ppTopology
            );

        [PreserveSig]
        int UpdateTopology(
            [In] int dwId,
            [In, MarshalAs(UnmanagedType.Interface)] IMFTopology pTopology
            );

        [PreserveSig]
        int UpdateTopologyFlags(
            [In] int dwId,
            [In] MFSequencerTopologyFlags dwFlags
            );
    }

}
