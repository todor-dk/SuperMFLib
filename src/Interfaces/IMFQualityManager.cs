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

#if ALLOW_UNTESTED_INTERFACES


    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("8D009D86-5B9F-4115-B1FC-9F80D52AB8AB")]
    public interface IMFQualityManager
    {
        [PreserveSig]
        int NotifyTopology(
            [In, MarshalAs(UnmanagedType.Interface)] IMFTopology pTopology
            );

        [PreserveSig]
        int NotifyPresentationClock(
            [In, MarshalAs(UnmanagedType.Interface)] IMFPresentationClock pClock
            );

        [PreserveSig]
        int NotifyProcessInput(
            [In, MarshalAs(UnmanagedType.Interface)] IMFTopologyNode pNode,
            [In] int lInputIndex,
            [In, MarshalAs(UnmanagedType.Interface)] IMFSample pSample
            );

        [PreserveSig]
        int NotifyProcessOutput(
            [In, MarshalAs(UnmanagedType.Interface)] IMFTopologyNode pNode,
            [In] int lOutputIndex,
            [In, MarshalAs(UnmanagedType.Interface)] IMFSample pSample
            );

        [PreserveSig]
        int NotifyQualityEvent(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pObject,
            [In, MarshalAs(UnmanagedType.Interface)] IMFMediaEvent pEvent
            );

        [PreserveSig]
        int Shutdown();
    }

#endif

}
