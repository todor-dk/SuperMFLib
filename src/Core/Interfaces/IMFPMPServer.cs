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
    /// Enables two instances of the <c>Media Session</c> to share the same protected media path (PMP)
    /// process. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BA6DC70A-D77D-41DE-AFE1-65F2EFCC4A95(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BA6DC70A-D77D-41DE-AFE1-65F2EFCC4A95(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("994E23AF-1CC2-493C-B9FA-46F1CB040FA4")]
    internal interface IMFPMPServer
    {
        /// <summary>
        /// Blocks the protected media path (PMP) process from ending.
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
        /// HRESULT LockProcess();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9A25ABFB-5038-4869-AD70-1AE52E8CF599(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9A25ABFB-5038-4869-AD70-1AE52E8CF599(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int LockProcess();

        /// <summary>
        /// Decrements the lock count on the protected media path (PMP) process. Call this method once for each
        /// call to <see cref="IMFPMPServer.LockProcess"/>. 
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
        /// HRESULT UnlockProcess();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2F64252F-C08B-4624-8DF6-DB922A630891(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2F64252F-C08B-4624-8DF6-DB922A630891(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int UnlockProcess();

        /// <summary>
        /// Creates an object in the protected media path (PMP) process.
        /// </summary>
        /// <param name="clsid">
        /// CLSID of the object to create.
        /// </param>
        /// <param name="riid">
        /// Interface identifier of the interface to retrieve.
        /// </param>
        /// <param name="ppObject">
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
        /// HRESULT CreateObjectByCLSID(
        ///   [in]   REFCLSID clsid,
        ///   [in]   REFIID riid,
        ///   [out]  void **ppObject
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/ECE956BB-EE83-42C7-9410-90F34956FDDE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/ECE956BB-EE83-42C7-9410-90F34956FDDE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateObjectByCLSID(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid clsid,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.Interface)] out object ppObject
            );
    }

#endif

}
