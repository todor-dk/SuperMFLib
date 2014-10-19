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

namespace MediaFoundation.Misc
{


    /// <summary>
    /// Exposes methods that get and set named properties.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/5F7997BA-A5C8-42B5-90C8-5CB34AFD6092(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5F7997BA-A5C8-42B5-90C8-5CB34AFD6092(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("71604b0f-97b0-4764-8577-2f13e98a1422")]
    public interface INamedPropertyStore
    {
        /// <summary>
        /// Gets the value of a named property from the named property store.
        /// </summary>
        /// <param name="pszName">
        /// Type: <strong>LPCWSTR</strong>
        /// <para/>
        /// A pointer to the property name, as a Unicode string, of the property in the named property store.
        /// </param>
        /// <param name="pValue">The p value.</param>
        /// <returns>
        /// Type: <strong>HRESULT</strong>
        /// <para/>
        /// Returns S_OK if successful, or an error value otherwise. 
        /// <para/>
        /// If the property named in <em>pszName</em> is not found in the property store, this method returns
        /// S_OK and the <em>pv</em> member is set to VT_EMPTY. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetNamedValue(
        ///   [in]   LPCWSTR pszName,
        ///   [out]  PROPVARIANT *pv
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D62FCACD-7AF5-4618-9B76-BEBB001BB827(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D62FCACD-7AF5-4618-9B76-BEBB001BB827(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetNamedValue(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszName,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pValue
        );

        /// <summary>
        /// Sets the value of a named property.
        /// </summary>
        /// <param name="pszName">
        /// Type: <strong>LPCWSTR</strong>
        /// <para/>
        /// A pointer to the property name, as a Unicode string, in the named property store.
        /// </param>
        /// <param name="propvar">The propvar.</param>
        /// <returns>
        /// Type: <strong>HRESULT</strong>
        /// <para/>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetNamedValue(
        ///   [in]  LPCWSTR pszName,
        ///   [in]  const PROPVARIANT *pv
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E1CCF53F-3117-45C2-A0FF-94F1BB084414(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E1CCF53F-3117-45C2-A0FF-94F1BB084414(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetNamedValue(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszName,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant propvar);

        /// <summary>
        /// Gets the number of property names in the property store.
        /// </summary>
        /// <param name="pdwCount">
        /// Type: <strong>DWORD*</strong>
        /// <para/>
        /// When this method returns, contains a pointer to the count of names.
        /// </param>
        /// <returns>
        /// Type: <strong>HRESULT</strong>
        /// <para/>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetNameCount(
        ///   [out]  DWORD *pdwCount
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/74BBA1BF-E003-40BB-9118-4D647F78E409(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/74BBA1BF-E003-40BB-9118-4D647F78E409(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetNameCount(
            out int pdwCount);

        /// <summary>
        /// Gets the name of a property at a specified index in the property store.
        /// </summary>
        /// <param name="iProp">
        /// Type: <strong>DWORD</strong>
        /// <para/>
        /// The index of the property in the store.
        /// </param>
        /// <param name="pbstrName">
        /// Type: <strong><c>BSTR</c>* </strong>
        /// <para/>
        /// When this method returns, contains a pointer to the property's name. It is the calling
        /// application's responsibility to free this resource when it is no longer needed.
        /// </param>
        /// <returns>
        /// Type: <strong>HRESULT</strong>
        /// <para/>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetNameAt(
        ///   [in]   DWORD iProp,
        ///   [out]  BSTR *pbstrName
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2FD3896E-B170-49AF-811E-A1F2FACC7A84(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2FD3896E-B170-49AF-811E-A1F2FACC7A84(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetNameAt(
            int iProp,
            [MarshalAs(UnmanagedType.BStr)] out string pbstrName);
    }

}
