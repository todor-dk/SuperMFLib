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

namespace MediaFoundation.Core.Interfaces
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Extends the <see cref="IMFWorkQueueServices"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/12D4F0F4-9A6D-4782-B5AE-4ADD6608782A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/12D4F0F4-9A6D-4782-B5AE-4ADD6608782A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("96bf961b-40fe-42f1-ba9d-320238b49700")]
    internal interface IMFWorkQueueServicesEx : IMFWorkQueueServices
    {
        #region IMFWorkQueueServices methods

        /// <summary>
        /// Registers the topology work queues with the Multimedia Class Scheduler Service (MMCSS).
        /// </summary>
        /// <param name="pCallback">A pointer to the <see cref="IMFAsyncCallback" /> interface of a callback object. The caller must
        /// implement this interface.</param>
        /// <param name="pState">A pointer to the <strong>IUnknown</strong> interface of a state object defined by the caller. This
        /// parameter can be <strong>NULL</strong>. You can use this object to hold state information. The
        /// object is returned to the caller when the callback is invoked.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT BeginRegisterTopologyWorkQueuesWithMMCSS(
        /// [in]  IMFAsyncCallback *pCallback,
        /// [in]  IUnknown *pState
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/62256AE8-A18A-4160-9F3F-A08AB3E93D6B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/62256AE8-A18A-4160-9F3F-A08AB3E93D6B(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int BeginRegisterTopologyWorkQueuesWithMMCSS(
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [MarshalAs(UnmanagedType.IUnknown)] object pState
        );

        /// <summary>
        /// Completes an asynchronous request to register the topology work queues with the Multimedia Class
        /// Scheduler Service (MMCSS).
        /// </summary>
        /// <param name="pResult">Pointer to the <see cref="IMFAsyncResult" /> interface. Pass in the same pointer that your callback
        /// object received in the <see cref="IMFAsyncCallback.Invoke" /> method.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT EndRegisterTopologyWorkQueuesWithMMCSS(
        /// [in]  IMFAsyncResult *pResult
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/42EB1A1C-3287-4DEE-AB95-FD047A16E345(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/42EB1A1C-3287-4DEE-AB95-FD047A16E345(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int EndRegisterTopologyWorkQueuesWithMMCSS(
            IMFAsyncResult pResult
        );

        /// <summary>
        /// Unregisters the topology work queues from the Multimedia Class Scheduler Service (MMCSS).
        /// </summary>
        /// <param name="pCallback">Pointer to the <see cref="IMFAsyncCallback" /> interface of a callback object. The caller must
        /// implement this interface.</param>
        /// <param name="pState">Pointer to the <strong>IUnknown</strong> interface of a state object, defined by the caller. This
        /// parameter can be <strong>NULL</strong>. You can use this object to hold state information. The
        /// object is returned to the caller when the callback is invoked.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT BeginUnregisterTopologyWorkQueuesWithMMCSS(
        /// [in]  IMFAsyncCallback *pCallback,
        /// [in]  IUnknown *pState
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/AF68B792-6E00-4ED1-91F8-F275288DC680(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AF68B792-6E00-4ED1-91F8-F275288DC680(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int BeginUnregisterTopologyWorkQueuesWithMMCSS(
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [MarshalAs(UnmanagedType.IUnknown)] object pState
        );

        /// <summary>
        /// Completes an asynchronous request to unregister the topology work queues from the Multimedia Class
        /// Scheduler Service (MMCSS).
        /// </summary>
        /// <param name="pResult">Pointer to the <see cref="IMFAsyncResult" /> interface. Pass in the same pointer that your callback
        /// object received in the <see cref="IMFAsyncCallback.Invoke" /> method.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT EndUnregisterTopologyWorkQueuesWithMMCSS(
        /// [in]  IMFAsyncResult *pResult
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/6B767E34-172C-4845-91F9-0AF92A3347AB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6B767E34-172C-4845-91F9-0AF92A3347AB(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int EndUnregisterTopologyWorkQueuesWithMMCSS(
            IMFAsyncResult pResult
        );

        /// <summary>
        /// Retrieves the Multimedia Class Scheduler Service (MMCSS) class for a specified branch of the
        /// current topology.
        /// </summary>
        /// <param name="dwTopologyWorkQueueId">Identifies the work queue assigned to this topology branch. The application defines this value by
        /// setting the <see cref="MFAttributesClsid.MF_TOPONODE_WORKQUEUE_ID" /> attribute on the source node
        /// for the branch.</param>
        /// <param name="pwszClass">Pointer to a buffer that receives the name of the MMCSS class. This parameter can be <strong>NULL
        /// </strong>.</param>
        /// <param name="pcchClass">On input, specifies the size of the <em>pwszClass</em> buffer, in characters. On output, receives
        /// the required size of the buffer, in characters. The size includes the terminating null character.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>There is no work queue with the specified identifier.</description></item>
        /// <item><term><strong>MF_E_BUFFERTOOSMALL</strong></term><description>The <em>pwszClass</em> buffer is too small to receive the class name. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetTopologyWorkQueueMMCSSClass(
        /// [in]       DWORD dwTopologyWorkQueueId,
        /// [out]      LPWSTR pwszClass,
        /// [in, out]  DWORD *pcchClass
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/E815BDE7-E17E-4616-8A3F-688F357E8009(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E815BDE7-E17E-4616-8A3F-688F357E8009(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetTopologyWorkQueueMMCSSClass(
            [In] int dwTopologyWorkQueueId,
            [Out, MarshalAs(UnmanagedType.LPWStr)] string pwszClass,
            [In, Out] ref int pcchClass
        );

        /// <summary>
        /// Retrieves the Multimedia Class Scheduler Service (MMCSS) task identifier for a specified branch of
        /// the current topology.
        /// </summary>
        /// <param name="dwTopologyWorkQueueId">Identifies the work queue assigned to this topology branch. The application defines this value by
        /// setting the <see cref="MFAttributesClsid.MF_TOPONODE_WORKQUEUE_ID" /> attribute on the source node
        /// for the branch.</param>
        /// <param name="pdwTaskId">Receives the task identifier.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetTopologyWorkQueueMMCSSTaskId(
        /// [in]   DWORD dwTopologyWorkQueueId,
        /// [out]  DWORD *pdwTaskId
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/0D519B96-428F-4CAD-AFFC-2E94CDF28AE7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0D519B96-428F-4CAD-AFFC-2E94CDF28AE7(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetTopologyWorkQueueMMCSSTaskId(
            [In] int dwTopologyWorkQueueId,
            out int pdwTaskId
        );

        /// <summary>
        /// Associates a platform work queue with a Multimedia Class Scheduler Service (MMCSS) task. 
        /// </summary>
        /// <param name="dwPlatformWorkQueue">The platform work queue to register with MMCSS. See <c>Work Queue Identifiers</c>. To register all
        /// of the standard work queues to the same MMCSS task, set this parameter to <strong>
        /// MFASYNC_CALLBACK_QUEUE_ALL</strong>.</param>
        /// <param name="wszClass">The name of the MMCSS task to be performed.</param>
        /// <param name="dwTaskId">The unique task identifier. To obtain a new task identifier, set this value to zero.</param>
        /// <param name="pCallback">A pointer to the <see cref="IMFAsyncCallback" /> interface of a callback object. The caller must
        /// implement this interface.</param>
        /// <param name="pState">A pointer to the <strong>IUnknown</strong> interface of a state object, defined by the caller. This
        /// parameter can be <strong>NULL</strong>. You can use this object to hold state information. The
        /// object is returned to the caller when the callback is invoked.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT BeginRegisterPlatformWorkQueueWithMMCSS(
        /// [in]  DWORD dwPlatformWorkQueue,
        /// [in]  LPCWSTR wszClass,
        /// [in]  DWORD dwTaskId,
        /// [in]  IMFAsyncCallback *pCallback,
        /// [in]  IUnknown *pState
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/AEA9F946-DD59-4E51-A1DE-B086E70EA083(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AEA9F946-DD59-4E51-A1DE-B086E70EA083(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int BeginRegisterPlatformWorkQueueWithMMCSS(
            [In] int dwPlatformWorkQueue,
            [In, MarshalAs(UnmanagedType.LPWStr)] string wszClass,
            [In] int dwTaskId,
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [MarshalAs(UnmanagedType.IUnknown)] object pState
        );

        /// <summary>
        /// Completes an asynchronous request to associate a platform work queue with a Multimedia Class
        /// Scheduler Service (MMCSS) task.
        /// </summary>
        /// <param name="pResult">Pointer to the <see cref="IMFAsyncResult" /> interface. Pass in the same pointer that your callback
        /// object received in the <see cref="IMFAsyncCallback.Invoke" /> method.</param>
        /// <param name="pdwTaskId">The unique task identifier.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT EndRegisterPlatformWorkQueueWithMMCSS(
        /// [in]   IMFAsyncResult *pResult,
        /// [out]  DWORD *pdwTaskId
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/B9D65D6C-495A-4CA0-B0FD-0A4199E2A7D5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B9D65D6C-495A-4CA0-B0FD-0A4199E2A7D5(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int EndRegisterPlatformWorkQueueWithMMCSS(
            IMFAsyncResult pResult,
            out int pdwTaskId
        );

        /// <summary>
        /// Unregisters a platform work queue from a Multimedia Class Scheduler Service (MMCSS) task.
        /// </summary>
        /// <param name="dwPlatformWorkQueue">Platform work queue to register with MMCSS. See
        /// <see cref="IMFWorkQueueServices.BeginRegisterPlatformWorkQueueWithMMCSS" />.</param>
        /// <param name="pCallback">Pointer to the <see cref="IMFAsyncCallback" /> interface of a callback object. The caller must
        /// implement this interface.</param>
        /// <param name="pState">Pointer to the <strong>IUnknown</strong> interface of a state object, defined by the caller. This
        /// parameter can be <strong>NULL</strong>. You can use this object to hold state information. The
        /// object is returned to the caller when the callback is invoked.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT BeginUnregisterPlatformWorkQueueWithMMCSS(
        /// [in]  DWORD dwPlatformWorkQueue,
        /// [in]  IMFAsyncCallback *pCallback,
        /// [in]  IUnknown *pState
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/E15C6FF9-B72E-4E5D-A738-6BEF08782E1B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E15C6FF9-B72E-4E5D-A738-6BEF08782E1B(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int BeginUnregisterPlatformWorkQueueWithMMCSS(
            [In] int dwPlatformWorkQueue,
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [MarshalAs(UnmanagedType.IUnknown)] object pState
        );

        /// <summary>
        /// Completes an asynchronous request to unregister a platform work queue from a Multimedia Class
        /// Scheduler Service (MMCSS) task.
        /// </summary>
        /// <param name="pResult">Pointer to the <see cref="IMFAsyncResult" /> interface. Pass in the same pointer that your callback
        /// object received in the <see cref="IMFAsyncCallback.Invoke" /> method.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT EndUnregisterPlatformWorkQueueWithMMCSS(
        /// [in]  IMFAsyncResult *pResult
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/E6CCE9D8-7F6C-4835-96A4-A2E836C61D08(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E6CCE9D8-7F6C-4835-96A4-A2E836C61D08(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int EndUnregisterPlatformWorkQueueWithMMCSS(
            IMFAsyncResult pResult
        );

        /// <summary>
        /// Retrieves the Multimedia Class Scheduler Service (MMCSS) class for a specified platform work queue.
        /// </summary>
        /// <param name="dwPlatformWorkQueueId">Platform work queue to query. See
        /// <see cref="IMFWorkQueueServices.BeginRegisterPlatformWorkQueueWithMMCSS" />.</param>
        /// <param name="pwszClass">Pointer to a buffer that receives the name of the MMCSS class. This parameter can be <strong>NULL
        /// </strong>.</param>
        /// <param name="pcchClass">On input, specifies the size of the pwszClass buffer, in characters. On output, receives the
        /// required size of the buffer, in characters. The size includes the terminating null character.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_BUFFERTOOSMALL</strong></term><description>The <em>pwszClass</em> buffer is too small to receive the class name. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetPlaftormWorkQueueMMCSSClass(
        /// [in]       DWORD dwPlatformWorkQueueId,
        /// [out]      LPWSTR pwszClass,
        /// [in, out]  DWORD *pcchClass
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/F953A54B-2BC0-4DDC-9837-57F72E564C02(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F953A54B-2BC0-4DDC-9837-57F72E564C02(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetPlaftormWorkQueueMMCSSClass(
            [In] int dwPlatformWorkQueueId,
            [Out, MarshalAs(UnmanagedType.LPWStr)] string pwszClass,
            [In, Out] ref int pcchClass
        );

        /// <summary>
        /// Retrieves the Multimedia Class Scheduler Service (MMCSS) task identifier for a specified platform
        /// work queue.
        /// </summary>
        /// <param name="dwPlatformWorkQueueId">Platform work queue to query. See
        /// <see cref="IMFWorkQueueServices.BeginRegisterPlatformWorkQueueWithMMCSS" />.</param>
        /// <param name="pdwTaskId">Receives the task identifier.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetPlatformWorkQueueMMCSSTaskId(
        /// [in]   DWORD dwPlatformWorkQueueId,
        /// [out]  DWORD *pdwTaskId
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/897A048A-44FC-4176-ACD9-5944F184B34A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/897A048A-44FC-4176-ACD9-5944F184B34A(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetPlatformWorkQueueMMCSSTaskId(
            [In] int dwPlatformWorkQueueId,
            out int pdwTaskId
        );

        #endregion

        /// <summary>
        /// Retrieves the Multimedia Class Scheduler Service (MMCSS)  string associated with the given topology
        /// work queue.
        /// </summary>
        /// <param name="dwTopologyWorkQueueId">
        /// The id of the topology work queue. 
        /// </param>
        /// <param name="plPriority">
        /// Pointer to the buffer the work queue's MMCSS task id will be copied to.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetTopologyWorkQueueMMCSSPriority(
        ///   [in]   DWORD dwTopologyWorkQueueId,
        ///   [out]  LONG *plPriority
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D5550E53-CBE9-4956-A079-D2A825FD17EF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D5550E53-CBE9-4956-A079-D2A825FD17EF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetTopologyWorkQueueMMCSSPriority( 
            int dwTopologyWorkQueueId,
            out int plPriority
        );

        /// <summary>
        /// Registers a platform work queue with Multimedia Class Scheduler Service (MMCSS) using the specified
        /// class and task id.
        /// </summary>
        /// <param name="dwPlatformWorkQueue">
        /// The id of one of the standard platform work queues.
        /// </param>
        /// <param name="wszClass">
        /// The MMCSS class which the work queue should be registered with.
        /// </param>
        /// <param name="dwTaskId">
        /// The task id which the work queue should be registered with. If <em>dwTaskId</em> is 0, a new MMCSS
        /// bucket will be created. 
        /// </param>
        /// <param name="lPriority">
        /// The priority.
        /// </param>
        /// <param name="pCallback">
        /// Standard callback used for async operations in Media Foundation.
        /// </param>
        /// <param name="pState">
        /// Standard state used for async operations in Media Foundation.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT BeginRegisterPlatformWorkQueueWithMMCSSEx(
        ///   [in]  DWORD dwPlatformWorkQueue,
        ///   [in]  LPCWSTR wszClass,
        ///   [in]  DWORD dwTaskId,
        ///   [in]  LONG lPriority,
        ///   [in]  IMFAsyncCallback *pCallback,
        ///   [in]  IUnknown *pState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/761E0E51-06E9-4B26-B6AD-AFEAA7150E64(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/761E0E51-06E9-4B26-B6AD-AFEAA7150E64(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int BeginRegisterPlatformWorkQueueWithMMCSSEx( 
            int dwPlatformWorkQueue,
            [Out, MarshalAs(UnmanagedType.LPWStr)] string wszClass,
            int dwTaskId,
            int lPriority,
            IMFAsyncCallback pCallback,
            [MarshalAs(UnmanagedType.IUnknown)] object pState
        );

        /// <summary>
        /// Gets the priority of the Multimedia Class Scheduler Service (MMCSS) priority associated with the
        /// specified platform work queue.
        /// </summary>
        /// <param name="dwPlatformWorkQueueId">
        /// Topology work queue id for which the info will be returned.
        /// </param>
        /// <param name="plPriority">
        /// </param>
        /// <returns>
        /// Pointer to a buffer allocated by the caller that the work queue's MMCSS task id will be copied to.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetPlatformWorkQueueMMCSSPriority(
        ///   [in]   DWORD dwPlatformWorkQueueId,
        ///   [out]  LONG *plPriority
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E9271439-8785-4743-9E6F-81342AF117F8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E9271439-8785-4743-9E6F-81342AF117F8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetPlatformWorkQueueMMCSSPriority( 
            int dwPlatformWorkQueueId,
            out int plPriority
        );        
    }

#endif

}
