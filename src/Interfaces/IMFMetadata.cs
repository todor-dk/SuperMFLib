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


    /// <summary>
    /// Manages metadata for an object. Metadata is information that describes a media file, stream, or
    /// other content. Metadata consists of individual properties, where each property contains a
    /// descriptive name and a value. A property may be associated with a particular language.
    /// <para/>
    /// To get this interface from a media source, use the <see cref="IMFMetadataProvider"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/411658CA-DC5E-445B-8D61-0C0429FCFBB1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/411658CA-DC5E-445B-8D61-0C0429FCFBB1(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("F88CFB8C-EF16-4991-B450-CB8C69E51704"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMetadata
    {
        /// <summary>
        /// Sets the language for setting and retrieving metadata. 
        /// </summary>
        /// <param name="pwszRFC1766">
        /// Pointer to a null-terminated string containing an RFC 1766-compliant language tag.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetLanguage(
        ///   [in]  LPCWSTR pwszRFC1766
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DA615053-DDD5-448E-905C-B060CDAEFA95(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DA615053-DDD5-448E-905C-B060CDAEFA95(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetLanguage(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszRFC1766
            );

        /// <summary>
        /// Gets the current language setting.
        /// </summary>
        /// <param name="ppwszRFC1766">
        /// Receives a pointer to a null-terminated string containing an RFC 1766-compliant language tag. The
        /// caller must release the string by calling <c>CoTaskMemFree</c>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_NOTIMPL</strong></term><description>The metadata provider does not support multiple languages.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description> No language was set. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetLanguage(
        ///   [out]  LPWSTR *ppwszRFC1766
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/75295C93-A389-42C4-AA56-DEBC36A5F532(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/75295C93-A389-42C4-AA56-DEBC36A5F532(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetLanguage(
            [MarshalAs(UnmanagedType.LPWStr)] out string ppwszRFC1766
            );

        /// <summary>
        /// Gets a list of the languages in which metadata is available.
        /// </summary>
        /// <param name="ppvLanguages">
        /// A pointer to a <strong>PROPVARIANT</strong> that receives the list of languages. The list is
        /// returned as an array of null-terminated wide-character strings. Each string in the array is an RFC
        /// 1766-compliant language tag. 
        /// <para/>
        /// The returned <strong>PROPVARIANT</strong> type is VT_VECTOR | VT_LPWSTR. The list might be empty,
        /// if no language tags are present. The caller must free the <strong>PROPVARIANT</strong> by calling 
        /// <c>PropVariantClear</c>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetAllLanguages(
        ///   [out]  PROPVARIANT *ppvLanguages
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/69296EC5-5811-4F0F-AE9C-CABCA3E66158(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/69296EC5-5811-4F0F-AE9C-CABCA3E66158(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetAllLanguages(
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant ppvLanguages
            );

        /// <summary>
        /// Sets the value of a metadata property. 
        /// </summary>
        /// <param name="pwszName">
        /// Pointer to a null-terminated string containing the name of the property.
        /// </param>
        /// <param name="ppvValue">
        /// Pointer to a <strong>PROPVARIANT</strong> that contains the value of the property. For multivalued
        /// properties, use a <strong>PROPVARIANT</strong> with a VT_VECTOR type. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetProperty(
        ///   [in]  LPCWSTR pwszName,
        ///   [in]  const PROPVARIANT *ppvValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/416A7FBA-506C-405D-A230-7E8A1C801209(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/416A7FBA-506C-405D-A230-7E8A1C801209(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetProperty(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszName,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant ppvValue
            );

        /// <summary>
        /// Gets the value of a metadata property.
        /// </summary>
        /// <param name="pwszName">
        /// A pointer to a null-terminated string that containings the name of the property. To get the list of
        /// property names, call <see cref="IMFMetadata.GetAllPropertyNames"/>. 
        /// </param>
        /// <param name="ppvValue">
        /// Pointer to a <strong>PROPVARIANT</strong> that receives the value of the property. The <strong>
        /// PROPVARIANT</strong> type depends on the property. For multivalued properties, the <strong>
        /// PROPVARIANT</strong> is a <strong>VT_VECTOR</strong> type. The caller must free the <strong>
        /// PROPVARIANT</strong> by calling <c>PropVariantClear</c>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_PROPERTY_NOT_FOUND</strong></term><description> The requested property was not found. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetProperty(
        ///   [in]   LPCWSTR pwszName,
        ///   [out]  PROPVARIANT *ppvValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/177C8612-5C9F-4A71-9EE1-A4C67737AF2D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/177C8612-5C9F-4A71-9EE1-A4C67737AF2D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetProperty(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszName,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant ppvValue
            );

        /// <summary>
        /// Deletes a metadata property.
        /// </summary>
        /// <param name="pwszName">
        /// Pointer to a null-terminated string containing the name of the property.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_PROPERTY_NOT_FOUND</strong></term><description> The property was not found. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT DeleteProperty(
        ///   [in]  LPCWSTR pwszName
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7C9A406D-6144-4E9C-B62C-1D9C691391F0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7C9A406D-6144-4E9C-B62C-1D9C691391F0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int DeleteProperty(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszName
            );

        /// <summary>
        /// Gets a list of all the metadata property names on this object.
        /// </summary>
        /// <param name="ppvNames">
        /// Pointer to a <strong>PROPVARIANT</strong> that receives an array of null-terminated wide-character
        /// strings. If no properties are available, the <strong>PROPVARIANT</strong> type is VT_EMPTY.
        /// Otherwise, the <strong>PROPVARIANT</strong> type is VT_VECTOR | VT_LPWSTR. The caller must free the
        /// <strong>PROPVARIANT</strong> by calling <c>PropVariantClear</c>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetAllPropertyNames(
        ///   [out]  PROPVARIANT *ppvNames
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E0944D42-D6E6-420D-9980-CA6C62736B3D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E0944D42-D6E6-420D-9980-CA6C62736B3D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetAllPropertyNames(
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant ppvNames
            );
    }

}
