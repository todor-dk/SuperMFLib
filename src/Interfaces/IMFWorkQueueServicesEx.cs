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
    Guid("96bf961b-40fe-42f1-ba9d-320238b49700")]
    public interface IMFWorkQueueServicesEx : IMFWorkQueueServices
    {
        #region IMFWorkQueueServices methods

        [PreserveSig]
        new int BeginRegisterTopologyWorkQueuesWithMMCSS(
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [MarshalAs(UnmanagedType.IUnknown)] object pState
        );

        [PreserveSig]
        new int EndRegisterTopologyWorkQueuesWithMMCSS(
            IMFAsyncResult pResult
        );

        [PreserveSig]
        new int BeginUnregisterTopologyWorkQueuesWithMMCSS(
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [MarshalAs(UnmanagedType.IUnknown)] object pState
        );

        [PreserveSig]
        new int EndUnregisterTopologyWorkQueuesWithMMCSS(
            IMFAsyncResult pResult
        );

        [PreserveSig]
        new int GetTopologyWorkQueueMMCSSClass(
            [In] int dwTopologyWorkQueueId,
            [Out, MarshalAs(UnmanagedType.LPWStr)] string pwszClass,
            [In, Out] ref int pcchClass
        );

        [PreserveSig]
        new int GetTopologyWorkQueueMMCSSTaskId(
            [In] int dwTopologyWorkQueueId,
            out int pdwTaskId
        );

        [PreserveSig]
        new int BeginRegisterPlatformWorkQueueWithMMCSS(
            [In] int dwPlatformWorkQueue,
            [In, MarshalAs(UnmanagedType.LPWStr)] string wszClass,
            [In] int dwTaskId,
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [MarshalAs(UnmanagedType.IUnknown)] object pState
        );

        [PreserveSig]
        new int EndRegisterPlatformWorkQueueWithMMCSS(
            IMFAsyncResult pResult,
            out int pdwTaskId
        );

        [PreserveSig]
        new int BeginUnregisterPlatformWorkQueueWithMMCSS(
            [In] int dwPlatformWorkQueue,
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [MarshalAs(UnmanagedType.IUnknown)] object pState
        );

        [PreserveSig]
        new int EndUnregisterPlatformWorkQueueWithMMCSS(
            IMFAsyncResult pResult
        );

        [PreserveSig]
        new int GetPlaftormWorkQueueMMCSSClass(
            [In] int dwPlatformWorkQueueId,
            [Out, MarshalAs(UnmanagedType.LPWStr)] string pwszClass,
            [In, Out] ref int pcchClass
        );

        [PreserveSig]
        new int GetPlatformWorkQueueMMCSSTaskId(
            [In] int dwPlatformWorkQueueId,
            out int pdwTaskId
        );

        #endregion

        [PreserveSig]
        int GetTopologyWorkQueueMMCSSPriority( 
            int dwTopologyWorkQueueId,
            out int plPriority
        );
        
        [PreserveSig]
        int BeginRegisterPlatformWorkQueueWithMMCSSEx( 
            int dwPlatformWorkQueue,
            [Out, MarshalAs(UnmanagedType.LPWStr)] string wszClass,
            int dwTaskId,
            int lPriority,
            IMFAsyncCallback pCallback,
            [MarshalAs(UnmanagedType.IUnknown)] object pState
        );
        
        [PreserveSig]
        int GetPlatformWorkQueueMMCSSPriority( 
            int dwPlatformWorkQueueId,
            out int plPriority
        );        
    }

#endif

}
