using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;
using MediaFoundation.Core.Interfaces;
using MediaFoundation.Core.Enums;
using System.Runtime.InteropServices;

namespace MediaFoundation
{
    /// <summary>
    /// This class implements the <see cref="IMFAsyncCallback"/> COM interface.
    /// </summary>
    /// <remarks>
    /// The above documentation is � Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/7EDFF985-DA59-4CC0-96DE-1A92E03A7D41(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7EDFF985-DA59-4CC0-96DE-1A92E03A7D41(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public abstract class AsyncCallback : IMFAsyncCallback
    {
        /// <summary>
        /// Provides configuration information to the dispatching thread for a callback.
        /// </summary>
        /// <param name="pdwFlags">
        /// Receives a flag indicating the behavior of the callback object's
        /// <see cref="IMFAsyncCallback.Invoke"/> method. The following values are defined. The default value
        /// is zero.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>Zero</strong></term><description>The callback does not take a long time to complete, but has no specific restrictions on what system calls it makes. The callback generally takes less than 30 milliseconds to complete.</description></item>
        /// <item><term><strong><strong>MFASYNC_FAST_IO_PROCESSING_CALLBACK</strong></strong></term><description>The callback does very minimal processing. It takes less than 1 millisecond to complete.The callback must be invoked from one of the following work queues:<para>* <strong>MFASYNC_CALLBACK_QUEUE_IO</strong></para><para>* <strong>MFASYNC_CALLBACK_QUEUE_TIMER</strong></para></description></item>
        /// <item><term><strong><strong>MFASYNC_SIGNAL_CALLBACK</strong></strong></term><description>Implies <strong>MFASYNC_FAST_IO_PROCESSING_CALLBACK</strong>, with the additional restriction that the callback does no processing (less than 50 microseconds), and the only system call it makes is <strong>SetEvent</strong>. The callback must be invoked from one of the following work queues:<para>* <strong>MFASYNC_CALLBACK_QUEUE_IO</strong></para><para>* <strong>MFASYNC_CALLBACK_QUEUE_TIMER</strong></para></description></item>
        /// <item><term><strong><strong>MFASYNC_BLOCKING_CALLBACK</strong></strong></term><description>Blocking callback.</description></item>
        /// <item><term><strong><strong>MFASYNC_REPLY_CALLBACK</strong></strong></term><description>Reply callback.</description></item>
        /// </list>
        /// </param>
        /// <param name="pdwQueue">
        /// Receives the identifier of the work queue on which the callback is dispatched.
        /// <para/>
        /// This value can specify one of the standard Media Foundation work queues, or a work queue created by
        /// the application. For list of standard Media Foundation work queues, see
        /// <c>Work Queue Identifiers</c>. To create a new work queue, call
        /// <see cref="MFExtern.MFAllocateWorkQueue"/>. The default value is <strong>
        /// MFASYNC_CALLBACK_QUEUE_STANDARD</strong>.
        /// <para/>
        /// If the work queue is not compatible with the value returned in <em>pdwFlags</em>, the Media
        /// Foundation platform returns <strong>MF_E_INVALID_WORKQUEUE</strong> when it tries to dispatch the
        /// callback. (See <see cref="MFExtern.MFPutWorkItem"/>.)
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong><strong>E_NOTIMPL</strong></strong></term><description> Not implemented. Assume the default behavior. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetParameters(
        ///   [out]��DWORD *pdwFlags,
        ///   [out]��DWORD *pdwQueue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is � Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/374DD139-D3E7-45D0-A7D3-1187B928EF57(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/374DD139-D3E7-45D0-A7D3-1187B928EF57(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        int IMFAsyncCallback.GetParameters(out MFASync pdwFlags, out MFAsyncCallbackQueue pdwQueue)
        {
            return this.GetParameters(out pdwFlags, out pdwQueue);
        }

        /// <summary>
        /// Provides configuration information to the dispatching thread for a callback.
        /// </summary>
        /// <param name="flags">Receives a flag indicating the behavior of the callback object's <see cref="IMFAsyncCallback.Invoke"/> method.</param>
        /// <param name="queue">Receives the identifier of the work queue on which the callback is dispatched.</param>
        /// <returns></returns>
        protected int GetParameters(out MFASync flags, out MFAsyncCallbackQueue queue)
        {
            // Not implemented. Assume the default behavior.
            flags = MFASync.None;
            queue = MFAsyncCallbackQueue.Undefined;
            return COM.E_NotImplemented;
        }

        /// <summary>
        /// Called when an asynchronous operation is completed.
        /// </summary>
        /// <param name="pAsyncResult">
        /// Pointer to the <see cref="IMFAsyncResult"/> interface. Pass this pointer to the asynchronous
        /// <strong>End...</strong> method to complete the asynchronous call.
        /// </param>
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
        /// HRESULT Invoke(
        ///   [in]��IMFAsyncResult *pAsyncResult
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is � Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/22473605-637E-4783-A8CB-98248B0A0327(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/22473605-637E-4783-A8CB-98248B0A0327(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        int IMFAsyncCallback.Invoke(IntPtr pAsyncResult)
        {
            if (pAsyncResult == IntPtr.Zero)
                return COM.E_Pointer;

            Marshal.AddRef(pAsyncResult);
            using (AsyncResult asyncResult = AsyncResult.FromUnknown(ref pAsyncResult))
            {
                return this.Invoke(asyncResult);
            }
        }

        /// <summary>
        /// Called when an asynchronous operation is completed.
        /// </summary>
        /// <param name="asyncResult">
        /// Pass this object to the asynchronous <strong>End...</strong> method to complete the asynchronous call.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>.
        /// </returns>
        protected abstract int Invoke(AsyncResult asyncResult);
    }
}
