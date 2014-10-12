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
    Guid("53590F48-DC3B-4297-813F-787761AD7B3E"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFASFIndexer
    {
        [PreserveSig]
        int SetFlags(
            [In] MFAsfIndexerFlags dwFlags);

        [PreserveSig]
        int GetFlags(
            out MFAsfIndexerFlags pdwFlags);

        [PreserveSig]
        int Initialize(
            [In] IMFASFContentInfo pIContentInfo);

        [PreserveSig]
        int GetIndexPosition(
            [In] IMFASFContentInfo pIContentInfo,
            out long pcbIndexOffset);

        [PreserveSig]
        int SetIndexByteStreams(
            [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.IUnknown)] IMFByteStream[] ppIByteStreams,
            [In] int cByteStreams);

        [PreserveSig]
        int GetIndexByteStreamCount(
            out int pcByteStreams);

        [PreserveSig]
        int GetIndexStatus(
            [In, MarshalAs(UnmanagedType.LPStruct)] ASFIndexIdentifier pIndexIdentifier,
            out bool pfIsIndexed,
            IntPtr pbIndexDescriptor,
            ref int pcbIndexDescriptor);

        [PreserveSig]
        int SetIndexStatus(
            [In] IntPtr pbIndexDescriptor,
            [In] int cbIndexDescriptor,
            [In] bool fGenerateIndex);

        [PreserveSig]
        int GetSeekPositionForValue(
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant pvarValue,
            [In, MarshalAs(UnmanagedType.LPStruct)] ASFIndexIdentifier pIndexIdentifier,
            out long pcbOffsetWithinData,
            IntPtr phnsApproxTime,
            out int pdwPayloadNumberOfStreamWithinPacket);

        [PreserveSig]
        int GenerateIndexEntries(
            [In] IMFSample pIASFPacketSample);

        [PreserveSig]
        int CommitIndex(
            [In] IMFASFContentInfo pIContentInfo);

        [PreserveSig]
        int GetIndexWriteSpace(
            out long pcbIndexWriteSpace);

        [PreserveSig]
        int GetCompletedIndex(
            [In] IMFMediaBuffer pIIndexBuffer,
            [In] long cbOffsetWithinIndex);
    }

}
