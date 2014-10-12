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
    Guid("B1DCA5CD-D5DA-4451-8E9E-DB5C59914EAD"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFASFContentInfo
    {
        [PreserveSig]
        int GetHeaderSize(
            [In] IMFMediaBuffer pIStartOfContent,
            out long cbHeaderSize);

        [PreserveSig]
        int ParseHeader(
            [In] IMFMediaBuffer pIHeaderBuffer,
            [In] long cbOffsetWithinHeader);

        [PreserveSig]
        int GenerateHeader(
            [In] IMFMediaBuffer pIHeader,
            out int pcbHeader);

        [PreserveSig]
        int GetProfile(
            out IMFASFProfile ppIProfile);

        [PreserveSig]
        int SetProfile(
            [In] IMFASFProfile pIProfile);

        [PreserveSig]
        int GeneratePresentationDescriptor(
            out IMFPresentationDescriptor ppIPresentationDescriptor);

        [PreserveSig]
        int GetEncodingConfigurationPropertyStore(
            [In] short wStreamNumber,
            out IPropertyStore ppIStore);
    }

}
