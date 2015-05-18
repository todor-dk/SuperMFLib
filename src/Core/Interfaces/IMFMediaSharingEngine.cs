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

namespace MediaFoundation.Core.Interfaces
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Enables media sharing.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D56612FC-840A-41EE-B162-7AF16ED3D975(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D56612FC-840A-41EE-B162-7AF16ED3D975(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("8D3CE1BF-2367-40E0-9EEE-40D377CC1B46"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFMediaSharingEngine : IMFMediaEngine
    {
        /// <summary>
        /// Gets information about the media sharing device.
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
        /// <a href="http://msdn.microsoft.com/en-US/library/29E536F3-E886-4DB6-8863-B4C0144FB693(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/29E536F3-E886-4DB6-8863-B4C0144FB693(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetDevice(
            out DEVICE_INFO pDevice
            );
    }

#endif

}
