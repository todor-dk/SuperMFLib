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
    /// Creates a proxy to a byte stream.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/DF29B5FC-864F-4400-8EDB-3A2CD797E37A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DF29B5FC-864F-4400-8EDB-3A2CD797E37A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("a6b43f84-5c0a-42e8-a44d-b1857a76992f"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFByteStreamProxyClassFactory
    {
        /// <summary>
        /// Creates a proxy to a byte stream. The proxy enables a media source to read from a byte stream in
        /// another process.
        /// </summary>
        /// <param name="pByteStream">
        /// A pointer to the <see cref="IMFByteStream"/> interface of the byte stream to proxy. 
        /// </param>
        /// <param name="pAttributes">
        /// Reserved. Set to <strong>NULL</strong>. 
        /// </param>
        /// <param name="riid">
        /// The interface identifer (IID) of the interface being requested.
        /// </param>
        /// <param name="ppvObject">
        /// Receives a pointer to the interface. The caller must release the interface.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT CreateByteStreamProxy(
        ///   [in]   IMFByteStream *pByteStream,
        ///   [in]   IMFAttributes *pAttributes,
        ///   [in]   REFIID riid,
        ///   [out]  LPVOID *ppvObject
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5A7E6218-615F-43E3-BB96-0D39138A4E28(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5A7E6218-615F-43E3-BB96-0D39138A4E28(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateByteStreamProxy(
            IMFByteStream pByteStream,
            IMFAttributes pAttributes,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject
        );
    }

#endif

}
