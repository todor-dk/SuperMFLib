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
    /// Enables a media source in the application process to create objects in the protected media path
    /// (PMP) process.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FAB1FB42-07C5-4A74-B6F5-0950B2C3BA46(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FAB1FB42-07C5-4A74-B6F5-0950B2C3BA46(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("F70CA1A9-FDC7-4782-B994-ADFFB1C98606"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFPMPHost
    {
        /// <summary>
        /// Blocks the protected media path (PMP) process from ending. 
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT LockProcess();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/45C533CA-D8CA-43F9-91D2-011A0B0D63A6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/45C533CA-D8CA-43F9-91D2-011A0B0D63A6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int LockProcess();

        /// <summary>
        /// Decrements the lock count on the protected media path (PMP) process. Call this method once for each
        /// call to <see cref="IMFPMPHost.LockProcess"/>. 
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT UnlockProcess();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/768F4579-5109-4D2B-A93D-F17F6B850C63(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/768F4579-5109-4D2B-A93D-F17F6B850C63(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int UnlockProcess();

        /// <summary>
        /// Creates an object in the protect media path (PMP) process, from a CLSID. 
        /// </summary>
        /// <param name="clsid">
        /// The CLSID of the object to create. 
        /// </param>
        /// <param name="pStream">
        /// A pointer to the <strong>IStream</strong> interface. This parameter can be <strong>NULL</strong>.
        /// If this parameter is not <strong>NULL</strong>, the PMP host queries the created object for the 
        /// <c>IPersistStream</c> interface and calls <strong>IPersistStream::Load</strong>, passing in the 
        /// <em>pStream</em> pointer. 
        /// </param>
        /// <param name="riid">
        /// The interface identifier (IID) of the interface to retrieve. 
        /// </param>
        /// <param name="ppv">
        /// Receives a pointer to the requested interface. The caller must release the interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT CreateObjectByCLSID(
        ///   [in]   REFCLSID clsid,
        ///   [in]   IStream *pStream,
        ///   [in]   REFIID riid,
        ///   [out]  void **ppv
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/787FC392-1858-41F4-A1CE-2DA02A5E789F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/787FC392-1858-41F4-A1CE-2DA02A5E789F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateObjectByCLSID(
            [MarshalAs(UnmanagedType.LPStruct)] Guid clsid,
            IStream pStream,
            [MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.Interface)] object ppv
            );
    }

#endif

}
