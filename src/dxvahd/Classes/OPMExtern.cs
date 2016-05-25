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
using System.Runtime.InteropServices;
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation.Dxvahd.Classes
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// This class exposes Media Foundation API functions.
    /// </summary>
    public static class OPMExtern
    {
        /// <summary>
        /// Creates a Microsoft DirectX Video Acceleration High Definition (DXVA-HD) device.
        /// </summary>
        /// <param name="pD3DDevice">
        /// A pointer to the <see cref="dxvahd.IDirect3DDevice9Ex"/> interface of a Direct3D 9 device. 
        /// </param>
        /// <param name="pContentDesc">
        /// A pointer to a <see cref="dxvahd.DXVAHD_CONTENT_DESC"/> structure that describes the video content.
        /// The driver uses this information as a hint when it creates the device. 
        /// </param>
        /// <param name="Usage">
        /// A member of the <see cref="dxvahd.DXVAHD_DEVICE_USAGE"/> enumeration, describing how the device
        /// will be used. The value indicates the desired trade-off between speed and video quality. The driver
        /// uses this flag as a hint when it creates the device. 
        /// </param>
        /// <param name="pPlugin">
        /// A pointer to an initialization function for a software device. Set this pointer if you are using a
        /// software plug-in device. Otherwise, set this parameter to <strong>NULL</strong>. If the value is 
        /// <strong>NULL</strong>, the driver creates the DXVA-HD device. 
        /// <para/>
        /// The function pointer type is <see cref="dxvahd.PDXVAHDSW_Plugin"/>. 
        /// </param>
        /// <param name="ppDevice">
        /// Receives a pointer to the <see cref="dxvahd.IDXVAHD_Device"/> interface. The caller must release
        /// the interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_NOINTERFACE</strong></term><description>The Direct3D device does not support DXVA-HD.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT DXVAHD_CreateDevice(
        ///   _In_   IDirect3DDevice9Ex *pD3DDevice,
        ///   _In_   const DXVAHD_CONTENT_DESC *pContentDesc,
        ///   _In_   DXVAHD_DEVICE_USAGE Usage,
        ///   _In_   PDXVAHDSW_Plugin pPlugin,
        ///   _Out_  IDXVAHD_Device **ppDevice
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9A5411F9-2018-4A8A-922D-AB431D615583(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9A5411F9-2018-4A8A-922D-AB431D615583(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("Dxva2.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int DXVAHD_CreateDevice(
            IDirect3DDevice9Ex pD3DDevice,
            DXVAHD_CONTENT_DESC pContentDesc,
            DXVAHD_DEVICE_USAGE Usage,
            PDXVAHDSW_Plugin pPlugin,
            out IDXVAHD_Device ppDevice
        );
    }

#endif

}
