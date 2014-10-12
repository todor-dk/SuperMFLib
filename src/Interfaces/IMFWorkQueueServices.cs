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
    Guid("35FE1BB8-A3A9-40FE-BBEC-EB569C9CCCA3"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFWorkQueueServices
    {
        [PreserveSig]
        int BeginRegisterTopologyWorkQueuesWithMMCSS(
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [MarshalAs(UnmanagedType.IUnknown)] object pState
            );

        [PreserveSig]
        int EndRegisterTopologyWorkQueuesWithMMCSS(
            IMFAsyncResult pResult
            );

        [PreserveSig]
        int BeginUnregisterTopologyWorkQueuesWithMMCSS(
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [MarshalAs(UnmanagedType.IUnknown)] object pState
            );

        [PreserveSig]
        int EndUnregisterTopologyWorkQueuesWithMMCSS(
            IMFAsyncResult pResult
            );

        [PreserveSig]
        int GetTopologyWorkQueueMMCSSClass(
            [In] int dwTopologyWorkQueueId,
            [Out, MarshalAs(UnmanagedType.LPWStr)] string pwszClass,
            [In, Out] ref int pcchClass
            );

        [PreserveSig]
        int GetTopologyWorkQueueMMCSSTaskId(
            [In] int dwTopologyWorkQueueId,
            out int pdwTaskId
            );

        [PreserveSig]
        int BeginRegisterPlatformWorkQueueWithMMCSS(
            [In] int dwPlatformWorkQueue,
            [In, MarshalAs(UnmanagedType.LPWStr)] string wszClass,
            [In] int dwTaskId,
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [MarshalAs(UnmanagedType.IUnknown)] object pState
            );

        [PreserveSig]
        int EndRegisterPlatformWorkQueueWithMMCSS(
            IMFAsyncResult pResult,
            out int pdwTaskId
            );

        [PreserveSig]
        int BeginUnregisterPlatformWorkQueueWithMMCSS(
            [In] int dwPlatformWorkQueue,
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [MarshalAs(UnmanagedType.IUnknown)] object pState
            );

        [PreserveSig]
        int EndUnregisterPlatformWorkQueueWithMMCSS(
            IMFAsyncResult pResult
            );

        [PreserveSig]
        int GetPlaftormWorkQueueMMCSSClass(
            [In] int dwPlatformWorkQueueId,
            [Out, MarshalAs(UnmanagedType.LPWStr)] string pwszClass,
            [In, Out] ref int pcchClass);

        [PreserveSig]
        int GetPlatformWorkQueueMMCSSTaskId(
            [In] int dwPlatformWorkQueueId,
            out int pdwTaskId
            );
    }

#endif

}
