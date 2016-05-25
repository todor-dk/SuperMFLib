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
    /// <summary>
    /// Represents a block of memory that contains media data. Use this interface to access the data in the
    /// buffer.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/3CCC7089-D0D0-4EB1-B763-0D4E348AF685(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3CCC7089-D0D0-4EB1-B763-0D4E348AF685(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport]
    [System.Security.SuppressUnmanagedCodeSecurity]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("045FA593-8799-42B8-BC8D-8968C6453507")]
    public interface IMFMediaBuffer
    {
        /// <summary>
        /// Gives the caller access to the memory in the buffer, for reading or writing
        /// </summary>
        /// <param name="ppbBuffer">
        /// Receives a pointer to the start of the buffer.
        /// </param>
        /// <param name="pcbMaxLength">
        /// Receives the maximum amount of data that can be written to the buffer. This parameter can be
        /// <strong>NULL</strong>. The same value is returned by the <see cref="IMFMediaBuffer.GetMaxLength"/>
        /// method.
        /// </param>
        /// <param name="pcbCurrentLength">
        /// Receives the length of the valid data in the buffer, in bytes. This parameter can be <strong>NULL
        /// </strong>. The same value is returned by the <see cref="IMFMediaBuffer.GetCurrentLength"/> method.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>D3DERR_INVALIDCALL</strong></term><description>For Direct3D surface buffers, an error occurred when locking the surface.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The buffer cannot be locked at this time.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Lock(
        ///   [out]  BYTE **ppbBuffer,
        ///   [out]  DWORD *pcbMaxLength,
        ///   [out]  DWORD *pcbCurrentLength
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/28AC372A-6E73-4E66-BF69-BCC244821B71(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/28AC372A-6E73-4E66-BF69-BCC244821B71(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Lock(
            out IntPtr ppbBuffer,
            out int pcbMaxLength,
            out int pcbCurrentLength);

        /// <summary>
        /// Unlocks a buffer that was previously locked. Call this method once for every call to
        /// <see cref="IMFMediaBuffer.Lock"/>.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>D3DERR_INVALIDCALL</strong></term><description>For Direct3D surface buffers, an error occurred when unlocking the surface.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Unlock();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/3CA53321-5533-45F0-B415-6A16F780EC54(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3CA53321-5533-45F0-B415-6A16F780EC54(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Unlock();

        /// <summary>
        /// Retrieves the length of the valid data in the buffer.
        /// </summary>
        /// <param name="pcbCurrentLength">
        /// Receives the length of the valid data, in bytes. If the buffer does not contain any valid data, the
        /// value is zero.
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
        /// HRESULT GetCurrentLength(
        ///   [out]  DWORD *pcbCurrentLength
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/772E3E6C-0616-41F6-A681-D76DA97D85FB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/772E3E6C-0616-41F6-A681-D76DA97D85FB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetCurrentLength(
            out int pcbCurrentLength);

        /// <summary>
        /// Sets the length of the valid data in the buffer.
        /// </summary>
        /// <param name="cbCurrentLength">
        /// Length of the valid data, in bytes. This value cannot be greater than the allocated size of the
        /// buffer, which is returned by the <see cref="IMFMediaBuffer.GetMaxLength"/> method.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>The specified length is greater than the maximum size of the buffer.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetCurrentLength(
        ///   [in]  DWORD cbCurrentLength
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/CE48458F-EB0F-441A-A4BC-9D3FBEE0CD74(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CE48458F-EB0F-441A-A4BC-9D3FBEE0CD74(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetCurrentLength(
            [In] int cbCurrentLength);

        /// <summary>
        /// Retrieves the allocated size of the buffer.
        /// </summary>
        /// <param name="pcbMaxLength">
        /// Receives the allocated size of the buffer, in bytes.
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
        /// HRESULT GetMaxLength(
        ///   [out]  DWORD *pcbMaxLength
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/F0697F1D-18D6-4406-9F19-8CBAAC08AD47(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F0697F1D-18D6-4406-9F19-8CBAAC08AD47(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMaxLength(
            out int pcbMaxLength);
    }
}
