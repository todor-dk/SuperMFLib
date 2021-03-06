using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;
using MediaFoundation.Core.Interfaces;
using System.Runtime.InteropServices;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="AsyncResult"/> class implements a wrapper around the
    /// <see cref="IMFAsyncResult"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFAsyncResult"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFAsyncResult"/>:
    /// Provides information about the result of an asynchronous operation.
    /// </summary>
    /// <remarks>
    /// The above documentation is � Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/8C95B1DE-8974-445C-8070-41552EA83E53(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8C95B1DE-8974-445C-8070-41552EA83E53(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class AsyncResult : COM<IMFAsyncResult>
    {
        #region Construction

        private AsyncResult(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="AsyncResult"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the AsyncResult's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be considered void.
        /// </param>
        /// <returns>
        /// A new <see cref="AsyncResult"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static AsyncResult FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            AsyncResult result = new AsyncResult(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Returns the state object specified by the caller in the asynchronous <strong>Begin</strong> method.
        /// </summary>
        /// <returns>
        /// The object associated with the <strong>Begin</strong> method. If the value is not
        /// <strong>null</strong>, the caller must release the interface.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/F8ED8E71-6DF7-4C94-B400-B4651A00DB5B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F8ED8E71-6DF7-4C94-B400-B4651A00DB5B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public ComObject GetState()
        {
            IntPtr ppunkState = IntPtr.Zero;
            int hr = this.Interface.GetState(out ppunkState);
            // E_POINTER: There is no state object associated with this asynchronous result.
            if (hr == COM.E_Pointer)
            {
                if (ppunkState != IntPtr.Zero)
                    Marshal.Release(ppunkState);
                return null;
            }

            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppunkState);
            return ComObject.FromUnknown(ref ppunkState);
        }

        /// <summary>
        /// Returns the status of the asynchronous operation.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/AD99F3DD-4885-42E8-8F4E-060D522DDE7B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AD99F3DD-4885-42E8-8F4E-060D522DDE7B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int GetStatus()
        {
            return this.Interface.GetStatus();
        }

        /// <summary>
        /// Sets the status of the asynchronous operation.
        /// </summary>
        /// <param name="hrStatus">
        /// The status of the asynchronous operation.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/79DEC067-BA54-435B-8744-9A6F43DD416D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/79DEC067-BA54-435B-8744-9A6F43DD416D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetStatus(int hrStatus)
        {
            int hr = this.Interface.SetStatus(hrStatus);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Returns an object associated with the asynchronous operation. The type of object, if any, depends
        /// on the asynchronous method that was called.
        /// </summary>
        /// <returns>
        /// Returns an object associated with the asynchronous operation. If no object is associated
        /// with the operation, this parameter receives the value <strong>null</strong>. If the value is not
        /// <strong>null</strong>, the caller must release the interface.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/B4B871FF-370D-4A37-9FE4-91D1805890EB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B4B871FF-370D-4A37-9FE4-91D1805890EB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public ComObject GetObject()
        {
            IntPtr ppObject = IntPtr.Zero;
            int hr = this.Interface.GetObject(out ppObject);
            // E_POINTER: There is no object associated with this asynchronous result.
            if (hr == COM.E_Pointer)
            {
                if (ppObject != IntPtr.Zero)
                    Marshal.Release(ppObject);
                return null;
            }

            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppObject);
            return ComObject.FromUnknown(ref ppObject);
        }
    }
}
