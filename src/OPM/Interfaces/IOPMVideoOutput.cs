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

// This file is a mess.  While technically part of MF, I'm in no hurry 
// to try to get this to work.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace MediaFoundation.OPM
{

#if ALLOW_UNTESTED_INTERFACES


    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("0A15159D-41C7-4456-93E1-284CD61D4E8D"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IOPMVideoOutput
    {
        [PreserveSig]
        int StartInitialization(
            out OPM_RANDOM_NUMBER prnRandomNumber,
            out IntPtr ppbCertificate,
            out  int pulCertificateLength);

        [PreserveSig]
        int FinishInitialization(
            OPM_ENCRYPTED_INITIALIZATION_PARAMETERS pParameters);

        [PreserveSig]
        int GetInformation(
            OPM_GET_INFO_PARAMETERS pParameters,
            out OPM_REQUESTED_INFORMATION pRequestedInformation);

        [PreserveSig]
        int COPPCompatibleGetInformation(
            OPM_COPP_COMPATIBLE_GET_INFO_PARAMETERS pParameters,
            out OPM_REQUESTED_INFORMATION pRequestedInformation);

        [PreserveSig]
        int Configure(
            OPM_CONFIGURE_PARAMETERS pParameters,
            int ulAdditionalParametersSize,
            IntPtr pbAdditionalParameters);
    }

#endif

}
