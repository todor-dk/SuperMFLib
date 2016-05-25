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
    /// Controls how media sources and transforms are enumerated in Microsoft Media Foundation.
    /// <para/>
    /// To get a pointer to this interface, call <see cref="MFExtern.MFGetPluginControl"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/CDC6FD4F-C544-43BB-BA99-5468EF49949D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CDC6FD4F-C544-43BB-BA99-5468EF49949D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("5C6C44BF-1DB6-435B-9249-E8CD10FDEC96")]
    internal interface IMFPluginControl
    {
        /// <summary>
        /// Searches the preferred list for a class identifier (CLSID) that matches a specified key name.
        /// </summary>
        /// <param name="pluginType">
        /// Member of the <see cref="MFPluginType"/> enumeration, specifying the type of object. 
        /// </param>
        /// <param name="selector">
        /// The key name to match. For more information about the format of key names, see the Remarks section
        /// of <see cref="IMFPluginControl"/>. 
        /// </param>
        /// <param name="clsid">
        /// Receives a CLSID from the preferred list.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>E_INVALIDARG</strong></strong></term><description>Invalid argument.</description></item>
        /// <item><term><strong><strong>HRESULT_FROM_WIN32(ERROR_NOT_FOUND)</strong></strong></term><description>No CLSID matching this key was found.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetPreferredClsid(
        ///   [in]   DWORD pluginType,
        ///   [in]   LPCWSTR selector,
        ///   [out]  CLSID *clsid
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C78843ED-B666-4B81-A7ED-66E514D0D342(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C78843ED-B666-4B81-A7ED-66E514D0D342(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetPreferredClsid(
            MFPluginType pluginType,
            [MarshalAs(UnmanagedType.LPWStr)] string selector,
            out Guid clsid
        );

        /// <summary>
        /// Gets a class identifier (CLSID) from the preferred list, specified by index value.
        /// </summary>
        /// <param name="pluginType">
        /// Member of the <see cref="MFPluginType"/> enumeration, specifying the type of object to enumerate. 
        /// </param>
        /// <param name="index">
        /// The zero-based index of the CLSID to retrieve.
        /// </param>
        /// <param name="selector">
        /// Receives the key name associated with the CLSID. The caller must free the memory for the returned
        /// string by calling the <c>CoTaskMemFree</c> function. For more information about the format of key
        /// names, see the Remarks section of <see cref="IMFPluginControl"/>. 
        /// </param>
        /// <param name="clsid">
        /// Receives the CLSID at the specified index.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>E_INVALIDARG</strong></strong></term><description>Invalid argument.</description></item>
        /// <item><term><strong><strong>HRESULT_FROM_WIN32(ERROR_NO_MORE_ITEMS)</strong></strong></term><description>The <em>index</em> parameter is out of range. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetPreferredClsidByIndex(
        ///   [in]   DWORD pluginType,
        ///   [in]   DWORD index,
        ///   [out]  LPWSTR *selector,
        ///   [out]  CLSID *clsid
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D99511EC-AC22-4166-B944-B0136FFCF01A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D99511EC-AC22-4166-B944-B0136FFCF01A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetPreferredClsidByIndex(
            MFPluginType pluginType,
            int index,
            [MarshalAs(UnmanagedType.LPWStr)] out string selector,
            out Guid clsid
        );

        /// <summary>
        /// Adds a class identifier (CLSID) to the preferred list or removes a CLSID from the list.
        /// </summary>
        /// <param name="pluginType">
        /// Member of the <see cref="MFPluginType"/> enumeration, specifying the type of object. 
        /// </param>
        /// <param name="selector">
        /// The key name for the CLSID. For more information about the format of key names, see the Remarks
        /// section of <see cref="IMFPluginControl"/>. 
        /// </param>
        /// <param name="clsid">
        /// The CLSID to add to the list. If this parameter is <strong>NULL</strong>, the key/value entry
        /// specified by the <em>selector</em> parameter is removed from the list. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetPreferredClsid(
        ///   [in]  DWORD pluginType,
        ///   [in]  LPCWSTR selector,
        ///   [in]  const CLSID *clsid
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C2362150-BB99-43D4-A6E6-7DC240E9826E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C2362150-BB99-43D4-A6E6-7DC240E9826E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetPreferredClsid(
            MFPluginType pluginType,
            [MarshalAs(UnmanagedType.LPWStr)] string selector,
            [MarshalAs(UnmanagedType.LPStruct)] MFGuid clsid
        );

        /// <summary>
        /// Queries whether a class identifier (CLSID) appears in the blocked list.
        /// </summary>
        /// <param name="pluginType">
        /// Member of the <see cref="MFPluginType"/> enumeration, specifying the type of object for the query. 
        /// </param>
        /// <param name="clsid">
        /// The CLSID to search for.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The specified CLSID appears in the blocked list.</description></item>
        /// <item><term><strong><strong>E_INVALIDARG</strong></strong></term><description>Invalid argument.</description></item>
        /// <item><term><strong><strong>HRESULT_FROM_WIN32(ERROR_NOT_FOUND)</strong></strong></term><description>The specified CLSID is not in the blocked list.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT IsDisabled(
        ///   [in]  DWORD pluginType,
        ///   [in]  REFCLSID clsid
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/75F4F3A2-198D-41C0-B0FA-4A1FBEFAD7B6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/75F4F3A2-198D-41C0-B0FA-4A1FBEFAD7B6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int IsDisabled(
            MFPluginType pluginType,
            [MarshalAs(UnmanagedType.LPStruct)] Guid clsid
        );

        /// <summary>
        /// Gets a class identifier (CLSID) from the blocked list.
        /// </summary>
        /// <param name="pluginType">
        /// Member of the <see cref="MFPluginType"/> enumeration, specifying the type of object to enumerate. 
        /// </param>
        /// <param name="index">
        /// The zero-based index of the CLSID to retrieve.
        /// </param>
        /// <param name="clsid">
        /// Receives the CLSID at the specified index.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>E_INVALIDARG</strong></strong></term><description>Invalid argument.</description></item>
        /// <item><term><strong><strong>HRESULT_FROM_WIN32(ERROR_NO_MORE_ITEMS)</strong></strong></term><description>The <em>index</em> parameter is out of range. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetDisabledByIndex(
        ///   [in]   DWORD pluginType,
        ///   [in]   DWORD index,
        ///   [out]  CLSID *clsid
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FAE7CA09-3E37-444B-A4BC-BFD522917E3F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FAE7CA09-3E37-444B-A4BC-BFD522917E3F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetDisabledByIndex(
            MFPluginType pluginType,
            int index,
            out Guid clsid
        );

        /// <summary>
        /// Adds a class identifier (CLSID) to the blocked list, or removes a CLSID from the list.
        /// </summary>
        /// <param name="pluginType">
        /// Member of the <see cref="MFPluginType"/> enumeration, specifying the type of object. 
        /// </param>
        /// <param name="clsid">
        /// The CLSID to add or remove.
        /// </param>
        /// <param name="disabled">
        /// Specifies whether to add or remove the CSLID. If the value is <strong>TRUE</strong>, the method
        /// adds the CLSID to the blocked list. Otherwise, the method removes it from the list. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>E_INVALIDARG</strong></strong></term><description>Invalid argument.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetDisabled(
        ///   [in]  DWORD pluginType,
        ///   [in]  REFCLSID clsid,
        ///   [in]  BOOL disabled
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FF50E746-42F5-4FBE-A904-F83B3C691D32(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FF50E746-42F5-4FBE-A904-F83B3C691D32(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetDisabled(
            MFPluginType pluginType,
            [MarshalAs(UnmanagedType.LPStruct)] Guid clsid,
            [MarshalAs(UnmanagedType.Bool)] bool disabled
        );
    }

#endif

}
