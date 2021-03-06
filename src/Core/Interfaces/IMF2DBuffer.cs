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
    /// Represents a buffer that contains a two-dimensional surface, such as a video frame. 
    /// </summary>
    /// <remarks>
    /// The above documentation is � Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/80EB23DB-A7C0-4DBE-97D8-0DC07A34D8F7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/80EB23DB-A7C0-4DBE-97D8-0DC07A34D8F7(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("7DC9D5F9-9ED9-44EC-9BBF-0600BB589FBB"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMF2DBuffer
    {
        /// <summary>
        /// Gives the caller access to the memory in the buffer.
        /// </summary>
        /// <param name="pbScanline0">Receives a pointer to the first byte of the top row of pixels in the image. The top row is defined
        /// as the top row when the image is presented to the viewer, and might not be the first row in memory.</param>
        /// <param name="plPitch">Receives the surface stride, in bytes. The stride might be negative, indicating that the image is
        /// oriented from the bottom up in memory.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item><item><term><strong>D3DERR_INVALIDCALL</strong></term><description>Cannot lock the Direct3D surface.</description></item><item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The buffer cannot be locked at this time.</description></item></list></returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Lock2D(
        /// [out]��BYTE **pbScanline0,
        /// [out]��LONG *plPitch
        /// );
        /// </code>
        /// <para />
        /// The above documentation is � Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/887A7394-9FE0-473A-825B-F095B01626C4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/887A7394-9FE0-473A-825B-F095B01626C4(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        int Lock2D(
            [Out] out IntPtr pbScanline0,
            out int plPitch
            );

        /// <summary>
        /// Unlocks a buffer that was previously locked. Call this method once for each call to 
        /// <see cref="IMF2DBuffer.Lock2D"/>. 
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
        /// HRESULT Unlock2D();
        /// </code>
        /// <para/>
        /// The above documentation is � Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/535452A3-0B38-467E-B556-80A069E4C0A5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/535452A3-0B38-467E-B556-80A069E4C0A5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Unlock2D();

        /// <summary>
        /// Retrieves a pointer to the buffer memory and the surface stride.
        /// </summary>
        /// <param name="pbScanline0">
        /// Receives a pointer to the first byte of the top row of pixels in the image.
        /// </param>
        /// <param name="plPitch">
        /// Receives the stride, in bytes. For more information, see <c>Image Stride</c>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>ERROR_INVALID_FUNCTION</strong></term><description>You must lock the buffer before calling this method.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetScanline0AndPitch(
        ///   [out]��BYTE **pbScanline0,
        ///   [out]��LONG *plPitch
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is � Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/08A5F659-609D-4A86-A24E-B30BB7F9E835(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/08A5F659-609D-4A86-A24E-B30BB7F9E835(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetScanline0AndPitch(
            out IntPtr pbScanline0,
            out int plPitch
            );

        /// <summary>
        /// Queries whether the buffer is contiguous in its native format.
        /// </summary>
        /// <param name="pfIsContiguous">
        /// Receives a Boolean value. The value is <strong>TRUE</strong> if the buffer is contiguous, and 
        /// <strong>FALSE</strong> otherwise. 
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
        /// HRESULT IsContiguousFormat(
        ///   [out]��BOOL *pfIsContiguous
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is � Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A2042D1F-4D80-4DFD-B57E-33F6A6D07D6E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A2042D1F-4D80-4DFD-B57E-33F6A6D07D6E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int IsContiguousFormat(
            [MarshalAs(UnmanagedType.Bool)] out bool pfIsContiguous
            );

        /// <summary>
        /// Retrieves the number of bytes needed to store the contents of the buffer in contiguous format.
        /// </summary>
        /// <param name="pcbLength">
        /// Receives the number of bytes needed to store the contents of the buffer in contiguous format.
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
        /// HRESULT GetContiguousLength(
        ///   [out]��DWORD *pcbLength
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is � Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/413D50F6-A047-4561-985D-9D1927825617(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/413D50F6-A047-4561-985D-9D1927825617(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetContiguousLength(
            out int pcbLength
            );

        /// <summary>
        /// Copies this buffer into the caller's buffer, converting the data to contiguous format.
        /// </summary>
        /// <param name="pbDestBuffer">
        /// Pointer to the destination buffer where the data will be copied. The caller allocates the buffer.
        /// </param>
        /// <param name="cbDestBuffer">
        /// Size of the destination buffer, in bytes. To get the required size, call 
        /// <see cref="IMF2DBuffer.GetContiguousLength"/>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>Invalid size specified in <em>pbDestBuffer</em>. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT ContiguousCopyTo(
        ///   [out]��BYTE *pbDestBuffer,
        ///   [in]���DWORD cbDestBuffer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is � Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/32601F2E-AB91-4A65-BCF4-8E063E90FBB0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/32601F2E-AB91-4A65-BCF4-8E063E90FBB0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ContiguousCopyTo(
            IntPtr pbDestBuffer,
            [In] int cbDestBuffer
            );

        /// <summary>
        /// Copies data to this buffer from a buffer that has a contiguous format.
        /// </summary>
        /// <param name="pbSrcBuffer">
        /// Pointer to the source buffer. The caller allocates the buffer.
        /// </param>
        /// <param name="cbSrcBuffer">
        /// Size of the source buffer, in bytes. To get the maximum size of the buffer, call 
        /// <see cref="IMF2DBuffer.GetContiguousLength"/>. 
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
        /// HRESULT ContiguousCopyFrom(
        ///   [in]��const BYTE *pbSrcBuffer,
        ///   [in]��DWORD cbSrcBuffer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is � Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/84634782-7805-4E2B-A043-7E49ADEF5C2A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/84634782-7805-4E2B-A043-7E49ADEF5C2A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ContiguousCopyFrom(
            [In] IntPtr pbSrcBuffer,
            [In] int cbSrcBuffer
            );
    }
#endif
}
