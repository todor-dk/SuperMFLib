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

namespace MediaFoundation.Core.Interfaces
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Provides functionality for getting the <see cref="IMFDXGIDeviceManager"/> from 
    /// the Microsoft Media Foundation video rendering sink.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280687(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn280687(v=vs.85).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("20bc074b-7a8d-4609-8c3b-64a0a3b5d7ce")]
    internal interface IMFDXGIDeviceManagerSource
    {
        /// <summary>
        /// Gets the <see cref="IMFDXGIDeviceManager"/> from the Microsoft Media Foundation video rendering sink.
        /// </summary>
        /// <param name="ppManager">
        /// The <see cref="IMFDXGIDeviceManager"/> object.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT</strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetManager(
        ///   [out]  IMFDXGIDeviceManager **ppManager
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280688(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn280688(v=vs.85).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetManager(
            out IMFDXGIDeviceManager ppManager
            );
    }

#endif
}
