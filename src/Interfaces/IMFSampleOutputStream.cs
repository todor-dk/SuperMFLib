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
using System.Drawing;

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Writes media samples to a byte stream.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BA293BB7-9191-4123-96DB-FF6386ABB3AE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BA293BB7-9191-4123-96DB-FF6386ABB3AE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("8feed468-6f7e-440d-869a-49bdd283ad0d"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFSampleOutputStream
    {
        /// <summary>
        /// Begins an asynchronous request to write a media sample to the stream.
        /// </summary>
        /// <param name="pSample">
        /// A pointer to the <see cref="IMFSample"/> interface of the sample. 
        /// </param>
        /// <param name="pCallback">
        /// A pointer to the <see cref="IMFAsyncCallback"/> interface of a callback object. The caller must
        /// implement this interface. 
        /// </param>
        /// <param name="punkState">
        /// A pointer to the <c>IUnknown</c> interface of a state object, defined by the caller. This parameter
        /// can be <strong>NULL</strong>. You can use this object to hold state information. The object is
        /// returned to the caller when the callback is invoked. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT BeginWriteSample(
        ///   [in]  IMFSample *pSample,
        ///   [in]  IMFAsyncCallback *pCallback,
        ///   [in]  IUnknown *punkState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/41056795-3E12-448E-9341-FB4DD4E7D079(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/41056795-3E12-448E-9341-FB4DD4E7D079(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int BeginWriteSample(
            IMFSample pSample,
            IMFAsyncCallback pCallback,
            [MarshalAs(UnmanagedType.IUnknown)] object punkState
        );

        /// <summary>
        /// Completes an asynchronous request to write a media sample to the stream.
        /// </summary>
        /// <param name="pResult">
        /// A pointer to the <see cref="IMFAsyncResult"/> interface. Pass in the same pointer that your
        /// callback object received in the <see cref="IMFAsyncCallback.Invoke"/> method. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT EndWriteSample(
        ///   [in]  IMFAsyncResult *pResult
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AE65CE63-B7FF-403B-ABB8-5E6C53CAD314(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AE65CE63-B7FF-403B-ABB8-5E6C53CAD314(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EndWriteSample(
            IMFAsyncResult pResult
        );

        /// <summary>
        /// Closes.
        /// </summary>
        /// <returns>System.Int32.</returns>
        [PreserveSig]
        int Close();
    }

#endif

}
