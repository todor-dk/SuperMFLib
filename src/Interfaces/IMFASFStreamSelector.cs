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

namespace MediaFoundation
{


    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("d01bad4a-4fa0-4a60-9349-c27e62da9d41"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFASFStreamSelector
    {
        [PreserveSig]
        int GetStreamCount(
            out int pcStreams);

        [PreserveSig]
        int GetOutputCount(
            out int pcOutputs);

        [PreserveSig]
        int GetOutputStreamCount(
            [In] int dwOutputNum,
            out int pcStreams);

        [PreserveSig]
        int GetOutputStreamNumbers(
            [In] int dwOutputNum,
            [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)] short[] rgwStreamNumbers);

        [PreserveSig]
        int GetOutputFromStream(
            [In] short wStreamNum,
            out int pdwOutput);

        [PreserveSig]
        int GetOutputOverride(
            [In] int dwOutputNum,
            out ASFSelectionStatus pSelection);

        [PreserveSig]
        int SetOutputOverride(
            [In] int dwOutputNum,
            [In] ASFSelectionStatus Selection);

        [PreserveSig]
        int GetOutputMutexCount(
            [In] int dwOutputNum,
            out int pcMutexes);

        [PreserveSig]
        int GetOutputMutex(
            [In] int dwOutputNum,
            [In] int dwMutexNum,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppMutex);

        [PreserveSig]
        int SetOutputMutexSelection(
            [In] int dwOutputNum,
            [In] int dwMutexNum,
            [In] short wSelectedRecord);

        [PreserveSig]
        int GetBandwidthStepCount(
            out int pcStepCount);

        [PreserveSig]
        int GetBandwidthStep(
            [In] int dwStepNum,
            out int pdwBitrate,
            [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)] short[] rgwStreamNumbers,
            [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)] ASFSelectionStatus[] rgSelections);

        [PreserveSig]
        int BitrateToStepNumber(
            [In] int dwBitrate,
            out int pdwStepNum);

        [PreserveSig]
        int SetStreamSelectorFlags(
            [In] MFAsfStreamSelectorFlags dwStreamSelectorFlags);
    }

}
