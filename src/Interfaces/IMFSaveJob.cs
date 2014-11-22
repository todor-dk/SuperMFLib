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


    /// <summary>
    /// Persists media data from a source byte stream to an application-provided byte stream.
    /// <para/>
    /// The byte stream used for HTTP download implements this interface. To get a pointer to this
    /// interface, call <see cref="IMFGetService.GetService"/> on the byte stream, with the service
    /// identifier MFNET_SAVEJOB_SERVICE. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/0F38FA60-ED04-40C4-9BB0-B6E196CD9586(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0F38FA60-ED04-40C4-9BB0-B6E196CD9586(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("E9931663-80BF-4C6E-98AF-5DCF58747D1F")]
    public interface IMFSaveJob
    {
        /// <summary>
        /// Begins saving a Windows Media file to the application's byte stream.
        /// </summary>
        /// <param name="pStream">
        /// Pointer to the <see cref="IMFByteStream"/> interface of the application's byte stream. The data
        /// from the source byte stream is written to this byte stream. 
        /// </param>
        /// <param name="pCallback">
        /// Pointer to the <see cref="IMFAsyncCallback"/> interface of a callback object. The caller must
        /// implement this interface 
        /// </param>
        /// <param name="pState">
        /// Pointer to the <strong>IUnknown</strong> interface of a state object, defined by the caller. This
        /// parameter can be <strong>NULL</strong>. You can use this object to hold state information. The
        /// object is returned to the caller when the callback is invoked. 
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
        /// HRESULT BeginSave(
        ///   [in]  IMFByteStream *pStream,
        ///   [in]  IMFAsyncCallback *pCallback,
        ///   [in]  IUnknown *pState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FF137B76-2A05-4E58-8D4F-D12CDD89656B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FF137B76-2A05-4E58-8D4F-D12CDD89656B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int BeginSave(
            [In, MarshalAs(UnmanagedType.Interface)] IMFByteStream pStream,
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pState
            );

        /// <summary>
        /// Completes the operation started by <see cref="IMFSaveJob.BeginSave"/>. 
        /// </summary>
        /// <param name="pResult">
        /// Pointer to the <see cref="IMFAsyncResult"/> interface. Pass in the same pointer that your callback
        /// object received in the <see cref="IMFAsyncCallback.Invoke"/> method. 
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
        /// HRESULT EndSave(
        ///   [in]  IMFAsyncResult *pResult
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9D63D7B5-4454-4301-B467-EEA82BACE6FF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9D63D7B5-4454-4301-B467-EEA82BACE6FF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EndSave(
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncResult pResult
            );

        /// <summary>
        /// Cancels the operation started by <see cref="IMFSaveJob.BeginSave"/>. 
        /// </summary>
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
        /// HRESULT CancelSave();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CE3EC53A-EECA-430F-A939-3D941B9B2570(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CE3EC53A-EECA-430F-A939-3D941B9B2570(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CancelSave();

        /// <summary>
        /// Retrieves the percentage of content saved to the provided byte stream.
        /// </summary>
        /// <param name="pdwPercentComplete">
        /// Receives the percentage of completion.
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
        /// HRESULT GetProgress(
        ///   [out]  DWORD *pdwPercentComplete
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8782333C-796C-4401-9575-C78E95887015(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8782333C-796C-4401-9575-C78E95887015(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetProgress(
            out int pdwPercentComplete
            );
    }

#endif

}
