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


    public class OPMExtern
    {
        [DllImport("Dxva2.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int OPMGetVideoOutputsFromHMONITOR(
            IntPtr hMonitor,
            OPM_VIDEO_OUTPUT_SEMANTICS vos,
            out int pulNumVideoOutputs,
            IntPtr pppOPMVideoOutputArray       // ISYN: IOPMVideoOutput***
            );

        [DllImport("Dxva2.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int OPMGetVideoOutputsFromIDirect3DDevice9Object(
            [MarshalAs(UnmanagedType.IUnknown)] object pDirect3DDevice9, // IDirect3DDevice9
            OPM_VIDEO_OUTPUT_SEMANTICS vos,
            out int pulNumVideoOutputs,
            IntPtr pppOPMVideoOutputArray       /// ISYN: IOPMVideoOutput***
            );
    }

#endif

}
