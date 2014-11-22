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
    /// Marshals an interface pointer to and from a stream.
    /// <para/>
    /// Stream objects that support <strong>IStream</strong> can expose this interface to provide custom
    /// marshaling for interface pointers. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/9D29BEFD-B0AE-4610-A0B7-17FACE03C45E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9D29BEFD-B0AE-4610-A0B7-17FACE03C45E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("09EF5BE3-C8A7-469E-8B70-73BF25BB193F"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFObjectReferenceStream
    {
        /// <summary>
        /// Stores the data needed to marshal an interface across a process boundary.
        /// </summary>
        /// <param name="riid">
        /// Interface identifier of the interface to marshal.
        /// </param>
        /// <param name="pUnk">
        /// Pointer to the <strong>IUnknown</strong> interface. 
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
        /// HRESULT SaveReference(
        ///   [in]  REFIID riid,
        ///   [in]  IUnknown *pUnk
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/776F94C4-D0E9-4FB7-A39C-32C83428BBE3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/776F94C4-D0E9-4FB7-A39C-32C83428BBE3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SaveReference(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnk
            );

        /// <summary>
        /// Marshals an interface from data stored in the stream.
        /// </summary>
        /// <param name="riid">
        /// Interface identifier of the interface to marshal.
        /// </param>
        /// <param name="ppv">
        /// Receives a pointer to the requested interface. The caller must release the interface.
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
        /// HRESULT LoadReference(
        ///   [in]   REFIID riid,
        ///   [out]  void **ppv
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FABF7DE2-8433-43BA-9DED-001569614054(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FABF7DE2-8433-43BA-9DED-001569614054(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int LoadReference(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.Interface)] out object ppv
            );
    }

#endif

}
