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

using MediaFoundation;
using MediaFoundation.Misc;
using MediaFoundation.Transform;
using System.Drawing;

namespace MediaFoundation.EVR
{


    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("6AB0000C-FECE-4d1f-A2AC-A9573530656E")]
    public interface IMFVideoProcessor
    {
        [PreserveSig]
        int GetAvailableVideoProcessorModes(
            out int lpdwNumProcessingModes,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(GMarshaler))] Guid[] ppVideoProcessingModes);

        [PreserveSig]
        int GetVideoProcessorCaps(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid lpVideoProcessorMode,
            out DXVA2VideoProcessorCaps lpVideoProcessorCaps);

        [PreserveSig]
        int GetVideoProcessorMode(
            out Guid lpMode);

        [PreserveSig]
        int SetVideoProcessorMode(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid lpMode);

        [PreserveSig]
        int GetProcAmpRange(
            DXVA2ProcAmp dwProperty,
            out DXVA2ValueRange pPropRange);

        [PreserveSig]
        int GetProcAmpValues(
            DXVA2ProcAmp dwFlags,
            [Out, MarshalAs(UnmanagedType.LPStruct)] DXVA2ProcAmpValues Values);

        [PreserveSig]
        int SetProcAmpValues(
            DXVA2ProcAmp dwFlags,
            [In] DXVA2ProcAmpValues pValues);

        [PreserveSig]
        int GetFilteringRange(
            DXVA2Filters dwProperty,
            out DXVA2ValueRange pPropRange);

        [PreserveSig]
        int GetFilteringValue(
            DXVA2Filters dwProperty,
            out int pValue);

        [PreserveSig]
        int SetFilteringValue(
            DXVA2Filters dwProperty,
            [In] ref int pValue);

        [PreserveSig]
        int GetBackgroundColor(
            out int lpClrBkg);

        [PreserveSig]
        int SetBackgroundColor(
            int ClrBkg);
    }

}
