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

namespace MediaFoundation.Core.Interfaces
{
    #if NOT_IN_USE

    /// <summary>
    /// Provides information about the result of an asynchronous operation. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/8C95B1DE-8974-445C-8070-41552EA83E53(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8C95B1DE-8974-445C-8070-41552EA83E53(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("AC6B7889-0740-4D51-8619-905994A55CC6")]
    internal interface IMFAsyncResult
    {
        /// <summary>
        /// Returns the state object specified by the caller in the asynchronous <strong>Begin</strong> method.
        /// </summary>
        /// <param name="ppunkState">
        /// Receives a pointer to the state object's <strong>IUnknown</strong> interface. If the value is not 
        /// <strong>NULL</strong>, the caller must release the interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_POINTER</strong></term><description>There is no state object associated with this asynchronous result.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetState(
        ///   [out]  IUnknown **ppunkState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F8ED8E71-6DF7-4C94-B400-B4651A00DB5B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F8ED8E71-6DF7-4C94-B400-B4651A00DB5B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetState(
            [MarshalAs(UnmanagedType.IUnknown)] out object ppunkState
            );

        /// <summary>
        /// Returns the status of the asynchronous operation.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The operation completed successfully.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStatus();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AD99F3DD-4885-42E8-8F4E-060D522DDE7B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AD99F3DD-4885-42E8-8F4E-060D522DDE7B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStatus();

        /// <summary>
        /// Sets the status of the asynchronous operation.
        /// </summary>
        /// <param name="hrStatus">
        /// The status of the asynchronous operation.
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
        /// HRESULT SetStatus(
        ///   [in]  HRESULT hrStatus
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/79DEC067-BA54-435B-8744-9A6F43DD416D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/79DEC067-BA54-435B-8744-9A6F43DD416D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetStatus(
            [In, MarshalAs(UnmanagedType.Error)] int hrStatus
            );

        /// <summary>
        /// Returns an object associated with the asynchronous operation. The type of object, if any, depends
        /// on the asynchronous method that was called.
        /// </summary>
        /// <param name="ppObject">
        /// Receives a pointer to the object's <strong>IUnknown</strong> interface. If no object is associated
        /// with the operation, this parameter receives the value <strong>NULL</strong>. If the value is not 
        /// <strong>NULL</strong>, the caller must release the interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_POINTER</strong></term><description>There is no object associated with this asynchronous result.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetObject(
        ///   [out]  IUnknown **ppObject
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B4B871FF-370D-4A37-9FE4-91D1805890EB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B4B871FF-370D-4A37-9FE4-91D1805890EB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetObject(
            [MarshalAs(UnmanagedType.Interface)] out object ppObject
            );

        /// <summary>
        /// Returns the state object specified by the caller in the asynchronous <strong>Begin</strong> method,
        /// without incrementing the object's reference count. 
        /// </summary>
        /// <returns>
        /// Returns a pointer to the state object's <strong>IUnknown</strong> interface, or <strong>NULL
        /// </strong> if no object was set. This pointer does not have an outstanding reference count. If you
        /// store this pointer, you must call <strong>AddRef</strong> on the pointer. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// IUnknown* GetStateNoAddRef();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/37BA820C-5253-48DE-A960-C546E50E8672(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/37BA820C-5253-48DE-A960-C546E50E8672(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        IntPtr GetStateNoAddRef();
    }
#endif
}
