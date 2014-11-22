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

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Enables image sharing.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A30C73DA-9BD5-4D12-A6FB-771BBD2D1191(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A30C73DA-9BD5-4D12-A6FB-771BBD2D1191(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("CFA0AE8E-7E1C-44D2-AE68-FC4C148A6354"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFImageSharingEngine
    {
        /// <summary>
        /// Sets the source stream.
        /// </summary>
        /// <param name="pStream">
        /// The source stream.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetSource(
        ///   IUnknown pStream
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/59DFAF26-B1D2-4658-B6E8-A0D14F48C734(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/59DFAF26-B1D2-4658-B6E8-A0D14F48C734(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetSource(
            [MarshalAs(UnmanagedType.IUnknown)] object pStream
            );

        /// <summary>
        /// Gets information about the image sharing device.
        /// </summary>
        /// <param name="pDevice">
        /// A pointer to a <see cref="DEVICE_INFO"/> structure. The method fills in this structure with the
        /// device information. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetDevice(
        ///   [out]  DEVICE_INFO *pDevice
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/27CAE784-2107-4380-97E4-AE0A7D69C64F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/27CAE784-2107-4380-97E4-AE0A7D69C64F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetDevice(
            out DEVICE_INFO pDevice
            );

        /// <summary>
        /// Shuts down the image sharing engine.
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Shutdown();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F394A740-8F86-4113-B6B8-57CC4127E9D0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F394A740-8F86-4113-B6B8-57CC4127E9D0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Shutdown();
    }

#endif

}
