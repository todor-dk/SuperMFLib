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
    Guid("12558295-E399-11D5-BC2A-00B0D0F3F4AB"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFASFSplitter
    {
        [PreserveSig]
        int Initialize(
            [In] IMFASFContentInfo pIContentInfo);

        [PreserveSig]
        int SetFlags(
            [In] MFASFSplitterFlags dwFlags);

        [PreserveSig]
        int GetFlags(
            out MFASFSplitterFlags pdwFlags);

        [PreserveSig]
        int SelectStreams(
            [In] short[] pwStreamNumbers,
            [In] short wNumStreams);

        [PreserveSig]
        int GetSelectedStreams(
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)] short[] pwStreamNumbers,
            ref short pwNumStreams);

        [PreserveSig]
        int ParseData(
            [In] IMFMediaBuffer pIBuffer,
            [In] int cbBufferOffset,
            [In] int cbLength);

        [PreserveSig]
        int GetNextSample(
            out ASFStatusFlags pdwStatusFlags,
            out short pwStreamNumber,
            out IMFSample ppISample);

        [PreserveSig]
        int Flush();

        [PreserveSig]
        int GetLastSendTime(
            out int pdwLastSendTime);
    }

}
