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
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Represents a buffer that contains a Microsoft DirectX Graphics Infrastructure (DXGI) surface.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/796D7755-275D-4A0B-A34F-5D34DCEC8AC7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/796D7755-275D-4A0B-A34F-5D34DCEC8AC7(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("e7174cfa-1c9e-48b1-8866-626226bfc258"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFDXGIBuffer
    {
        /// <summary>
        /// Queries the Microsoft DirectX Graphics Infrastructure (DXGI) surface for an interface.
        /// </summary>
        /// <param name="riid">
        /// The interface identifer (IID) of the interface being requested.
        /// </param>
        /// <param name="ppvObject">
        /// Receives a pointer to the interface. The caller must release the interface.
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong> E_NOINTERFACE</strong></term><description>The object does not support the specified interface.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>Invalid request.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetResource(
        ///   [in]   REFIID riid,
        ///   [out]  LPVOID *ppvObject
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E8FF3346-D60A-4FF9-AF3E-673397EA6E6A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E8FF3346-D60A-4FF9-AF3E-673397EA6E6A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetResource(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject
        );

        /// <summary>
        /// Gets the index of the subresource that is associated with this media buffer.
        /// </summary>
        /// <param name="puSubresource">
        /// Receives the zero-based index of the subresource.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetSubresourceIndex(
        ///   [out]  UINT *puSubresource
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/71FA2B1C-2F11-45E7-8211-92A129F8C991(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/71FA2B1C-2F11-45E7-8211-92A129F8C991(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetSubresourceIndex(
            out int puSubresource
        );

        /// <summary>
        /// Gets an <c>IUnknown</c> pointer that was previously stored in the media buffer object. 
        /// </summary>
        /// <param name="guid">
        /// The identifier of the <c>IUnknown</c> pointer. 
        /// </param>
        /// <param name="riid">
        /// The interface identifer (IID) of the interface being requested.
        /// </param>
        /// <param name="ppvObject">
        /// Receives a pointer to the interface. The caller must release the interface.
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong> E_NOINTERFACE</strong></term><description>The object does not support the specified interface.</description></item>
        /// <item><term><strong>MF_E_NOT_FOUND</strong></term><description>The specified key was not found.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetUnknown(
        ///   [in]   REFIID guid,
        ///   [in]   REFIID riid,
        ///   [out]  LPVOID *ppvObject
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6B4A5E79-3A0A-439E-ABE1-F92C3D07FB57(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6B4A5E79-3A0A-439E-ABE1-F92C3D07FB57(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetUnknown(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guid,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject
        );

        /// <summary>
        /// Stores an arbitrary <c>IUnknown</c> pointer in the media buffer object. 
        /// </summary>
        /// <param name="guid">
        /// The identifier for the <c>IUnknown</c> pointer. This identifier is used as a key to retrieve the
        /// value. It can be any <strong>GUID</strong> value. 
        /// </param>
        /// <param name="pUnkData">
        /// A pointer to the <c>IUnknown</c> interface. Set this parameter to <strong>NULL</strong> to clear a
        /// pointer that was previously set. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>ERROR_OBJECT_ALREADY_EXISTS</strong></term><description>An item already exists with this key.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetUnknown(
        ///   [in]  REFIID guid,
        ///   [in]  IUnknown *pUnkData
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/94BA5E48-FF89-48FA-BE0D-C158A5B4D4CF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/94BA5E48-FF89-48FA-BE0D-C158A5B4D4CF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetUnknown(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guid,
            [MarshalAs(UnmanagedType.IUnknown)] object pUnkData
        );
    }

#endif

}
