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
    /// Enables two threads to share the same Microsoft Direct3D 11 device.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/4A0DC266-FCF0-4ECD-AC78-CF429839486D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4A0DC266-FCF0-4ECD-AC78-CF429839486D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("eb533d5d-2db6-40f8-97a9-494692014f07"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFDXGIDeviceManager
    {
        /// <summary>
        /// Closes a Microsoft Direct3D device handle.
        /// </summary>
        /// <param name="hDevice">
        /// A handle to the Direct3D device. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>E_HANDLE</strong></term><description>The specified handle is not a Direct3D device handle.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT CloseDeviceHandle(
        ///   [in]  HANDLE hDevice
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D5C74D6C-F066-4905-9D02-886FA503F58E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D5C74D6C-F066-4905-9D02-886FA503F58E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CloseDeviceHandle(
            IntPtr hDevice
        );

        /// <summary>
        /// Queries the Microsoft Direct3D device for an interface.
        /// </summary>
        /// <param name="hDevice">
        /// A handle to the Direct3D device. To get the device handle, call 
        /// <see cref="IMFDXGIDeviceManager.OpenDeviceHandle"/>. 
        /// </param>
        /// <param name="riid">
        /// The interface identifier (IID) of the requested interface. The Direct3D device supports the
        /// following interfaces:
        /// <para/>
        /// <para>* <c>ID3D11VideoContext</c></para><para>* <c>ID3D11VideoDevice</c></para>
        /// </param>
        /// <param name="ppService">
        /// Receives a pointer to the requested interface. The caller must release the interface.
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>E_HANDLE</strong></term><description>The specified handle is not a Direct3D device handle.</description></item>
        /// <item><term><strong>MF_E_DXGI_DEVICE_NOT_INITIALIZED</strong></term><description>The DXGI Device Manager was not initialized. The owner of the device must call <see cref="IMFDXGIDeviceManager.ResetDevice"/>. </description></item>
        /// <item><term><strong>MF_E_DXGI_NEW_VIDEO_DEVICE</strong></term><description>The device handle is invalid. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetVideoService(
        ///   [in]   HANDLE hDevice,
        ///   [in]   REFIID riid,
        ///   [out]  void **ppService
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B0C7C31B-39AF-48B6-8D86-F4DFCC546CDE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B0C7C31B-39AF-48B6-8D86-F4DFCC546CDE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetVideoService(
            IntPtr hDevice,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppService
        );

        /// <summary>
        /// Gives the caller exclusive access to the Microsoft Direct3D device.
        /// </summary>
        /// <param name="hDevice">
        /// A handle to the Direct3D device. To get the device handle, call 
        /// <see cref="IMFDXGIDeviceManager.OpenDeviceHandle"/>. 
        /// </param>
        /// <param name="riid">
        /// The interface identifier (IID) of the requested interface. The Direct3D device will support the
        /// following interfaces:
        /// <para/>
        /// <para>* <c>ID3D11Device</c></para><para>* <c>ID3D11VideoContext</c></para><para>* 
        /// <c>ID3D11VideoDevice</c></para>
        /// </param>
        /// <param name="ppUnkDevice">
        /// Receives a pointer to the requested interface. The caller must release the interface.
        /// </param>
        /// <param name="fBlock">
        /// Specifies whether to wait for the device lock. If the device is already locked and this parameter
        /// is <strong>TRUE</strong>, the method blocks until the device is unlocked. Otherwise, if the device
        /// is locked and this parameter is <strong>FALSE</strong>, the method returns immediately with the
        /// error code <strong>DXVA2_E_VIDEO_DEVICE_LOCKED</strong>. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>E_HANDLE</strong></term><description>The specified handle is not a Direct3D device handle.</description></item>
        /// <item><term><strong>MF_E_DXGI_DEVICE_NOT_INITIALIZED</strong></term><description>The DXGI Device Manager was not initialized. The owner of the device must call <see cref="IMFDXGIDeviceManager.ResetDevice"/>. </description></item>
        /// <item><term><strong>MF_E_DXGI_NEW_VIDEO_DEVICE</strong></term><description>The device handle is invalid. </description></item>
        /// <item><term><strong>MF_E_DXGI_VIDEO_DEVICE_LOCKED</strong></term><description>The device is locked and <em>fBlock</em> is <strong>FALSE</strong>. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT LockDevice(
        ///   [in]   HANDLE hDevice,
        ///   [in]   REFIID riid,
        ///   [out]  void **ppUnkDevice,
        ///   [in]   BOOL fBlock
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EFB458D5-40A9-4729-9C22-B66FE76D5680(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EFB458D5-40A9-4729-9C22-B66FE76D5680(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int LockDevice(
            IntPtr hDevice,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppUnkDevice,
            [MarshalAs(UnmanagedType.Bool)] bool fBlock
        );

        /// <summary>
        /// Gets a handle to the Microsoft Direct3D device. 
        /// </summary>
        /// <param name="phDevice">
        /// Receives the device handle.
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_DXGI_DEVICE_NOT_INITIALIZED</strong></term><description>The DXGI Device Manager was not initialized. The owner of the device must call <see cref="IMFDXGIDeviceManager.ResetDevice"/>. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OpenDeviceHandle(
        ///   [out]  HANDLE *phDevice
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B025DF73-1F85-46F3-9AD4-2385BD515DDD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B025DF73-1F85-46F3-9AD4-2385BD515DDD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int OpenDeviceHandle(
            out IntPtr phDevice
        );

        /// <summary>
        /// Sets the Microsoft Direct3D device or notifies the device manager that the Direct3D device was
        /// reset.
        /// </summary>
        /// <param name="pUnkDevice">
        /// A pointer to the <c>IUnknown</c> interface of the DXGI device. 
        /// </param>
        /// <param name="resetToken">
        /// The token that was received in the <em>pResetToken</em> parameter of the 
        /// <see cref="MFExtern.MFCreateDXGIDeviceManager"/> function. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT ResetDevice(
        ///   [in]  IUnknown *pUnkDevice,
        ///   [in]  UINT resetToken
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D8A2291A-792B-4D24-997A-9C152FFE5426(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D8A2291A-792B-4D24-997A-9C152FFE5426(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ResetDevice(
            [MarshalAs(UnmanagedType.IUnknown)] object pUnkDevice,
            int resetToken
        );

        /// <summary>
        /// Tests whether a Microsoft Direct3D device handle is valid.
        /// </summary>
        /// <param name="hDevice">
        /// A handle to the Direct3D device. To get the device handle, call 
        /// <see cref="IMFDXGIDeviceManager.OpenDeviceHandle"/>. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>E_HANDLE</strong></term><description>The specified handle is not a Direct3D device handle.</description></item>
        /// <item><term><strong>MF_E_DXGI_NEW_VIDEO_DEVICE</strong></term><description>The device handle is invalid. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT TestDevice(
        ///   [in]  HANDLE hDevice
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DBBECFE0-110D-4A77-88D4-7D6AB8B2A67C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DBBECFE0-110D-4A77-88D4-7D6AB8B2A67C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int TestDevice(
            IntPtr hDevice
        );

        /// <summary>
        /// Unlocks the Microsoft Direct3D device.
        /// </summary>
        /// <param name="hDevice">
        /// A handle to the Direct3D device. To get the device handle, call 
        /// <see cref="IMFDXGIDeviceManager.OpenDeviceHandle"/>. 
        /// </param>
        /// <param name="fSaveState">
        /// Reserved.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT UnlockDevice(
        ///   [in]  HANDLE hDevice,
        ///   [in]  BOOL fSaveState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DE6A8E16-BC25-4B7C-B95D-A46D7C0870E3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DE6A8E16-BC25-4B7C-B95D-A46D7C0870E3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int UnlockDevice(
            IntPtr hDevice,
            [MarshalAs(UnmanagedType.Bool)]  bool fSaveState
        );
    }

#endif

}
