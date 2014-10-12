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
using System.Runtime.InteropServices.ComTypes;
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

using MediaFoundation.EVR;

namespace MediaFoundation.MFPlayer
{

#if ALLOW_UNTESTED_INTERFACES


    [StructLayout(LayoutKind.Sequential), UnmanagedName("MFP_ACQUIRE_USER_CREDENTIAL_EVENT")]
    public class MFP_ACQUIRE_USER_CREDENTIAL_EVENT : MFP_EVENT_HEADER
    {
        public IntPtr dwUserData;
        [MarshalAs(UnmanagedType.Bool)]
        public bool fProceedWithAuthentication;
        public int hrAuthenticationStatus;
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszURL;
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszSite;
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszRealm;
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszPackage;
        public int nRetries;
        public MFP_CREDENTIAL_FLAGS flags;
        public IMFNetCredential pCredential;
    }

#endif

}
