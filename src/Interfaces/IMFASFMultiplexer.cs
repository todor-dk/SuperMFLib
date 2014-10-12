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

#if ALLOW_UNTESTED_INTERFACES


    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("57BDD80A-9B38-4838-B737-C58F670D7D4F"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFASFMultiplexer
    {
        [PreserveSig]
        int Initialize(
            [In] IMFASFContentInfo pIContentInfo);

        [PreserveSig]
        int SetFlags(
            [In] MFASFMultiplexerFlags dwFlags);

        [PreserveSig]
        int GetFlags(
            out MFASFMultiplexerFlags pdwFlags);

        [PreserveSig]
        int ProcessSample(
            [In] short wStreamNumber,
            [In] IMFSample pISample,
            [In] long hnsTimestampAdjust);

        [PreserveSig]
        int GetNextPacket(
            out ASFStatusFlags pdwStatusFlags,
            out IMFSample ppIPacket);

        [PreserveSig]
        int Flush();

        [PreserveSig]
        int End(
            [In] IMFASFContentInfo pIContentInfo);

        [PreserveSig]
        int GetStatistics(
            [In] short wStreamNumber,
            out ASFMuxStatistics pMuxStats);

        [PreserveSig]
        int SetSyncTolerance(
            [In] int msSyncTolerance);
    }

#endif

}
