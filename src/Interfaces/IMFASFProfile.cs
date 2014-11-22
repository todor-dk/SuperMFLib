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

namespace MediaFoundation
{


    /// <summary>
    /// Manages an Advanced Systems Format (ASF) profile. A profile is a collection of information that
    /// describes the configuration of streams that will be included in an ASF file. Information about the
    /// relationships between streams is also included in the profile.
    /// <para/>
    /// An <strong>IMFASFProfile</strong> interface exists for every ASF profile object. To create an ASF
    /// profile object, call <see cref="MFExtern.MFCreateASFProfile"/> or 
    /// <see cref="MFExtern.MFCreateASFProfileFromPresentationDescriptor"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FE441C61-1BE7-4FDA-A2A3-BD79ECF4E54C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FE441C61-1BE7-4FDA-A2A3-BD79ECF4E54C(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("D267BF6A-028B-4e0d-903D-43F0EF82D0D4"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFASFProfile : IMFAttributes
    {
        #region IMFAttributes methods

        /// <summary>
        /// Retrieves the value associated with a key.
        /// </summary>
        /// <param name="guidKey">
        /// A GUID that identifies which value to retrieve. 
        /// </param>
        /// <param name="pValue">
        /// A pointer to a <strong>PROPVARIANT</strong> that receives the value. The method fills the <strong>
        /// PROPVARIANT</strong> with a copy of the stored value, if the value is found. Call <strong>
        /// PropVariantClear</strong> to free the memory allocated by this method. This parameter can be 
        /// <strong>NULL</strong>. If this parameter is <strong>NULL</strong>, the method searches for the key
        /// and returns S_OK if the key is found, but does not copy the value. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description> The specified key was not found. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetItem(
        ///   [in]       REFGUID guidKey,
        ///   [in, out]  PROPVARIANT *pValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8CC4E529-D5A0-4342-82AC-AE5B28BFD61D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8CC4E529-D5A0-4342-82AC-AE5B28BFD61D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetItem(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pValue
            );

        /// <summary>
        /// Retrieves the data type of the value associated with a key.
        /// </summary>
        /// <param name="guidKey">
        /// GUID that identifies which value to query.
        /// </param>
        /// <param name="pType">
        /// Receives a member of the <see cref="MFAttributeType"/> enumeration. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>The specified key is not stored in this object.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetItemType(
        ///   [in]   REFGUID guidKey,
        ///   [out]  MF_ATTRIBUTE_TYPE *pType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2C3A3C30-DA10-4365-9F76-598A4CA7675C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2C3A3C30-DA10-4365-9F76-598A4CA7675C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetItemType(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            out MFAttributeType pType
            );

        /// <summary>
        /// Queries whether a stored attribute value equals to a specified <strong>PROPVARIANT</strong>. 
        /// </summary>
        /// <param name="guidKey">
        /// GUID that identifies which value to query.
        /// </param>
        /// <param name="Value">
        /// <strong>PROPVARIANT</strong> that contains the value to compare. 
        /// </param>
        /// <param name="pbResult">
        /// Receives a Boolean value indicating whether the attribute matches the value given in <em>Value</em>
        /// . See Remarks. This parameter must not be <strong>NULL</strong>. If this parameter is <strong>NULL
        /// </strong>, an access violation occurs. 
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
        /// HRESULT CompareItem(
        ///   [in]   REFGUID guidKey,
        ///   [in]   REFPROPVARIANT Value,
        ///   [out]  BOOL *pbResult
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F0A6073B-FCE6-4A1F-B7D1-EF6543E7648F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F0A6073B-FCE6-4A1F-B7D1-EF6543E7648F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int CompareItem(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant Value,
            [MarshalAs(UnmanagedType.Bool)] out bool pbResult
            );

        /// <summary>
        /// Compares the attributes on this object with the attributes on another object.
        /// </summary>
        /// <param name="pTheirs">
        /// Pointer to the <see cref="IMFAttributes"/> interface of the object to compare with this object. 
        /// </param>
        /// <param name="MatchType">
        /// Member of the <see cref="MFAttributesMatchType"/> enumeration, specifying the type of comparison to
        /// make. 
        /// </param>
        /// <param name="pbResult">
        /// Receives a Boolean value. The value is <strong>TRUE</strong> if the two sets of attributes match in
        /// the way specified by the <em>MatchType</em> parameter. Otherwise, the value is <strong>FALSE
        /// </strong>. 
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
        /// HRESULT Compare(
        ///   [in]   IMFAttributes *pTheirs,
        ///   [in]   MF_ATTRIBUTES_MATCH_TYPE MatchType,
        ///   [out]  BOOL *pbResult
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1D0C9D1C-448D-4851-B183-94B04ACB2AB5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1D0C9D1C-448D-4851-B183-94B04ACB2AB5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int Compare(
            [MarshalAs(UnmanagedType.Interface)] IMFAttributes pTheirs,
            MFAttributesMatchType MatchType,
            [MarshalAs(UnmanagedType.Bool)] out bool pbResult
            );

        /// <summary>
        /// Retrieves a <strong>UINT32</strong> value associated with a key. 
        /// </summary>
        /// <param name="guidKey">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_UINT32</strong>. 
        /// </param>
        /// <param name="punValue">
        /// Receives a <strong>UINT32</strong> value. If the key is found and the data type is <strong>UINT32
        /// </strong>, the method copies the value into this parameter. Otherwise, the original value of this
        /// parameter is not changed. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>The specified key was not found.</description></item>
        /// <item><term><strong>MF_E_INVALIDTYPE</strong></term><description>The attribute value is not a <strong>UINT32</strong>. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetUINT32(
        ///   [in]   REFGUID guidKey,
        ///   [out]  UINT32 *punValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E47495E0-3274-4CE2-9FD3-D2FB2AFB7578(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E47495E0-3274-4CE2-9FD3-D2FB2AFB7578(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetUINT32(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            out int punValue
            );

        /// <summary>
        /// Retrieves a <strong>UINT64</strong> value associated with a key. 
        /// </summary>
        /// <param name="guidKey">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_UINT64</strong>. 
        /// </param>
        /// <param name="punValue">
        /// Receives a <strong>UINT64</strong> value. If the key is found and the data type is <strong>UINT64
        /// </strong>, the method copies the value into this parameter. Otherwise, the original value of this
        /// parameter is not changed. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description> The specified key was not found. </description></item>
        /// <item><term><strong>MF_E_INVALIDTYPE</strong></term><description> The attribute value is not a <strong>UINT64</strong>. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetUINT64(
        ///   [in]   REFGUID guidKey,
        ///   [out]  UINT64 *punValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F3240FFF-48D8-4D88-8C75-15F00BFE72ED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F3240FFF-48D8-4D88-8C75-15F00BFE72ED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetUINT64(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            out long punValue
            );

        /// <summary>
        /// Retrieves a <strong>double</strong> value associated with a key. 
        /// </summary>
        /// <param name="guidKey">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_DOUBLE</strong>. 
        /// </param>
        /// <param name="pfValue">
        /// Receives a <strong>double</strong> value. If the key is found and the data type is <strong>double
        /// </strong>, the method copies the value into this parameter. Otherwise, the original value of this
        /// parameter is not changed. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>The specified key was not found.</description></item>
        /// <item><term><strong>MF_E_INVALIDTYPE</strong></term><description>The attribute value is not a <strong>double</strong>. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetDouble(
        ///   [in]   REFGUID guidKey,
        ///   [out]  double *pfValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/650A5F7F-609F-477B-8834-FF66CA3A9CA3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/650A5F7F-609F-477B-8834-FF66CA3A9CA3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetDouble(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            out double pfValue
            );

        /// <summary>
        /// Retrieves a GUID value associated with a key.
        /// </summary>
        /// <param name="guidKey">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>MF_ATTRIBUTE_GUID
        /// </strong>. 
        /// </param>
        /// <param name="pguidValue">
        /// Receives a GUID value. If the key is found and the data type is GUID, the method copies the value
        /// into this parameter. Otherwise, the original value of this parameter is not changed.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>The specified key was not found.</description></item>
        /// <item><term><strong>MF_E_INVALIDTYPE</strong></term><description>The attribute value is not a GUID.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetGUID(
        ///   [in]   REFGUID guidKey,
        ///   [out]  GUID *pguidValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6DED35E1-2D1C-4E68-AD0F-2BD5BA469853(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6DED35E1-2D1C-4E68-AD0F-2BD5BA469853(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetGUID(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            out Guid pguidValue
            );

        /// <summary>
        /// Retrieves the length of a string value associated with a key.
        /// </summary>
        /// <param name="guidKey">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_STRING</strong>. 
        /// </param>
        /// <param name="pcchLength">
        /// If the key is found and the value is a string type, this parameter receives the number of
        /// characters in the string, not including the terminating <strong>NULL</strong> character. To get the
        /// string value, call <see cref="IMFAttributes.GetString"/>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>The specified key was not found.</description></item>
        /// <item><term><strong>MF_E_INVALIDTYPE</strong></term><description>The attribute value is not a string.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStringLength(
        ///   [in]   REFGUID guidKey,
        ///   [out]  UINT32 *pcchLength
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6CCC753F-E147-47F4-AB95-17687729404A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6CCC753F-E147-47F4-AB95-17687729404A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetStringLength(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            out int pcchLength
            );

        /// <summary>
        /// Retrieves a wide-character string associated with a key.
        /// </summary>
        /// <param name="guidKey">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_STRING</strong>. 
        /// </param>
        /// <param name="pwszValue">
        /// Pointer to a wide-character array allocated by the caller. The array must be large enough to hold
        /// the string, including the terminating <strong>NULL</strong> character. If the key is found and the
        /// value is a string type, the method copies the string into this buffer. To find the length of the
        /// string, call <see cref="IMFAttributes.GetStringLength"/>. 
        /// </param>
        /// <param name="cchBufSize">
        /// The size of the <em>pwszValue</em> array, in characters. This value includes the terminating NULL
        /// character. 
        /// </param>
        /// <param name="pcchLength">
        /// Receives the number of characters in the string, excluding the terminating <strong>NULL</strong>
        /// character. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_OUTOFMEMORY</strong></term><description>The length of the string is too large to fit in a <strong>UINT32</strong> value. </description></item>
        /// <item><term><strong>E_NOT_SUFFICIENT_BUFFER</strong></term><description>The buffer is not large enough to hold the string.</description></item>
        /// <item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>The specified key was not found.</description></item>
        /// <item><term><strong>MF_E_INVALIDTYPE</strong></term><description>The attribute value is not a string.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetString(
        ///   [in]   REFGUID guidKey,
        ///   [out]  LPWSTR pwszValue,
        ///   [in]   UINT32 cchBufSize,
        ///   [out]  UINT32 *pcchLength
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/756D8FBA-D372-46F9-8035-F657D7FF133F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/756D8FBA-D372-46F9-8035-F657D7FF133F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetString(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            [Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszValue,
            int cchBufSize,
            out int pcchLength
            );

        /// <summary>
        /// Gets a wide-character string associated with a key. This method allocates the memory for the
        /// string. 
        /// </summary>
        /// <param name="guidKey">
        /// A GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_STRING</strong>. 
        /// </param>
        /// <param name="ppwszValue">
        /// If the key is found and the value is a string type, this parameter receives a copy of the string.
        /// The caller must free the memory for the string by calling <c>CoTaskMemFree</c>. 
        /// </param>
        /// <param name="pcchLength">
        /// Receives the number of characters in the string, excluding the terminating <strong>NULL</strong>
        /// character. This parameter must not be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description> The specified key was not found. </description></item>
        /// <item><term><strong>MF_E_INVALIDTYPE</strong></term><description> The attribute value is not a string. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetAllocatedString(
        ///   [in]   REFGUID guidKey,
        ///   [out]  LPWSTR *ppwszValue,
        ///   [out]  UINT32 *pcchLength
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/550A3035-EA16-4784-8F69-9522259BB338(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/550A3035-EA16-4784-8F69-9522259BB338(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetAllocatedString(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            [MarshalAs(UnmanagedType.LPWStr)] out string ppwszValue,
            out int pcchLength
            );

        /// <summary>
        /// Retrieves the length of a byte array associated with a key.
        /// </summary>
        /// <param name="guidKey">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>MF_ATTRIBUTE_BLOB
        /// </strong>. 
        /// </param>
        /// <param name="pcbBlobSize">
        /// If the key is found and the value is a byte array, this parameter receives the size of the array,
        /// in bytes.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>The specified key was not found.</description></item>
        /// <item><term><strong>MF_E_INVALIDTYPE</strong></term><description>The attribute value is not a byte array.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetBlobSize(
        ///   [in]   REFGUID guidKey,
        ///   [out]  UINT32 *pcbBlobSize
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/93AB65E7-2168-4CFB-A871-B39554BA66E0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/93AB65E7-2168-4CFB-A871-B39554BA66E0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetBlobSize(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            out int pcbBlobSize
            );

        /// <summary>
        /// Retrieves a byte array associated with a key. This method copies the array into a caller-allocated
        /// buffer.
        /// </summary>
        /// <param name="guidKey">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>MF_ATTRIBUTE_BLOB
        /// </strong>. 
        /// </param>
        /// <param name="pBuf">
        /// Pointer to a buffer allocated by the caller. If the key is found and the value is a byte array, the
        /// method copies the array into this buffer. To find the required size of the buffer, call 
        /// <see cref="IMFAttributes.GetBlobSize"/>. 
        /// </param>
        /// <param name="cbBufSize">
        /// The size of the <em>pBuf</em> buffer, in bytes. 
        /// </param>
        /// <param name="pcbBlobSize">
        /// Receives the size of the byte array. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>E_NOT_SUFFICIENT_BUFFER</strong></strong></term><description>The buffer is not large enough to the array.</description></item>
        /// <item><term><strong><strong>MF_E_ATTRIBUTENOTFOUND</strong></strong></term><description>The specified key was not found.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDTYPE</strong></strong></term><description>The attribute value is not a byte array.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetBlob(
        ///   [in]   REFGUID guidKey,
        ///   [out]  UINT8 *pBuf,
        ///   [in]   UINT32 cbBufSize,
        ///   [out]  UINT32 *pcbBlobSize
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/68528DB7-90DF-4ABE-A957-FFB8C3F12CEF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/68528DB7-90DF-4ABE-A957-FFB8C3F12CEF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetBlob(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pBuf,
            int cbBufSize,
            out int pcbBlobSize
            );

        // Use GetBlob instead of this
        /// <summary>
        /// Retrieves a byte array associated with a key. This method allocates the memory for the array.
        /// </summary>
        /// <param name="guidKey">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>MF_ATTRIBUTE_BLOB
        /// </strong>. 
        /// </param>
        /// <param name="ip">The ip.</param>
        /// <param name="pcbSize">
        /// Receives the size of the array, in bytes.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>The specified key was not found.</description></item>
        /// <item><term><strong>MF_E_INVALIDTYPE</strong></term><description>The attribute value is not a byte array.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetAllocatedBlob(
        ///   [in]   REFGUID guidKey,
        ///   [out]  UINT8 **ppBuf,
        ///   [out]  UINT32 *pcbSize
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/380E0E3A-B5C5-4D31-8793-417262377FEF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/380E0E3A-B5C5-4D31-8793-417262377FEF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetAllocatedBlob(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            out IntPtr ip,  // Read w/Marshal.Copy, Free w/Marshal.FreeCoTaskMem
            out int pcbSize
            );

        /// <summary>
        /// Retrieves an interface pointer associated with a key.
        /// </summary>
        /// <param name="guidKey">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_IUNKNOWN</strong>. 
        /// </param>
        /// <param name="riid">
        /// Interface identifier (IID) of the interface to retrieve.
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
        /// <item><term><strong>E_NOINTERFACE</strong></term><description>The attribute value is an <strong>IUnknown</strong> pointer but does not support requested interface. </description></item>
        /// <item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>The specified key was not found.</description></item>
        /// <item><term><strong>MF_E_INVALIDTYPE</strong></term><description>The attribute value is not an <strong>IUnknown</strong> pointer. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetUnknown(
        ///   [in]   REFGUID guidKey,
        ///   [in]   REFIID riid,
        ///   [out]  LPVOID *ppv
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A5F645A1-B7D2-47D3-B77E-AD94815B1C25(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A5F645A1-B7D2-47D3-B77E-AD94815B1C25(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetUnknown(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppv
            );

        /// <summary>
        /// Adds an attribute value with a specified key. 
        /// </summary>
        /// <param name="guidKey">
        /// A GUID that identifies the value to set. If this key already exists, the method overwrites the old
        /// value. 
        /// </param>
        /// <param name="Value">
        /// A <strong>PROPVARIANT</strong> that contains the attribute value. The method copies the value. The 
        /// <strong>PROPVARIANT</strong> type must be one of the types listed in the 
        /// <see cref="MFAttributeType"/> enumeration. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_OUTOFMEMORY</strong></term><description> Insufficient memory. </description></item>
        /// <item><term><strong>MF_E_INVALIDTYPE</strong></term><description> Invalid attribute type. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetItem(
        ///   [in]  REFGUID guidKey,
        ///   [in]  REFPROPVARIANT Value
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1AC6E1C3-CF78-4CFF-A992-4F92F243C443(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1AC6E1C3-CF78-4CFF-A992-4F92F243C443(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int SetItem(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant Value
            );

        /// <summary>
        /// Removes a key/value pair from the object's attribute list.
        /// </summary>
        /// <param name="guidKey">
        /// GUID that identifies the value to delete.
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
        /// HRESULT DeleteItem(
        ///   [in]  REFGUID guidKey
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AC72E6E4-F930-4DE6-92A2-F15E5F9E5D74(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AC72E6E4-F930-4DE6-92A2-F15E5F9E5D74(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int DeleteItem(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey
            );

        /// <summary>
        /// Removes all key/value pairs from the object's attribute list.
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
        /// HRESULT DeleteAllItems();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8D7EF03B-BB96-42BC-A1C3-49F8B0E499B8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8D7EF03B-BB96-42BC-A1C3-49F8B0E499B8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int DeleteAllItems();

        /// <summary>
        /// Associates a <strong>UINT32</strong> value with a key. 
        /// </summary>
        /// <param name="guidKey">
        /// GUID that identifies the value to set. If this key already exists, the method overwrites the old
        /// value.
        /// </param>
        /// <param name="unValue">
        /// New value for this key.
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
        /// HRESULT SetUINT32(
        ///   [in]  REFGUID guidKey,
        ///   [in]  UINT32 unValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9C30FD56-719F-4831-8FBF-CEFCF9D72709(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9C30FD56-719F-4831-8FBF-CEFCF9D72709(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int SetUINT32(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            int unValue
            );

        /// <summary>
        /// Associates a <strong>UINT64</strong> value with a key. 
        /// </summary>
        /// <param name="guidKey">
        /// GUID that identifies the value to set. If this key already exists, the method overwrites the old
        /// value.
        /// </param>
        /// <param name="unValue">
        /// New value for this key.
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
        /// HRESULT SetUINT64(
        ///   [in]  REFGUID guidKey,
        ///   [in]  UINT64 unValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/817ED1C1-16AD-4520-A1A0-A93563936B50(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/817ED1C1-16AD-4520-A1A0-A93563936B50(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int SetUINT64(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            long unValue
            );

        /// <summary>
        /// Associates a <strong>double</strong> value with a key. 
        /// </summary>
        /// <param name="guidKey">
        /// GUID that identifies the value to set. If this key already exists, the method overwrites the old
        /// value.
        /// </param>
        /// <param name="fValue">
        /// New value for this key.
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
        /// HRESULT SetDouble(
        ///   [in]  REFGUID guidKey,
        ///   [in]  double fValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BB58F35E-0FCA-4B19-9976-DE2140E6EBC0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BB58F35E-0FCA-4B19-9976-DE2140E6EBC0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int SetDouble(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            double fValue
            );

        /// <summary>
        /// Associates a GUID value with a key.
        /// </summary>
        /// <param name="guidKey">
        /// GUID that identifies the value to set. If this key already exists, the method overwrites the old
        /// value.
        /// </param>
        /// <param name="guidValue">
        /// New value for this key.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_OUTOFMEMORY</strong></term><description>Insufficient memory.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetGUID(
        ///   [in]  REFGUID guidKey,
        ///   [in]  REFGUID guidValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D73B53F5-4A8F-4903-986D-FBF4277A2D45(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D73B53F5-4A8F-4903-986D-FBF4277A2D45(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int SetGUID(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidValue
            );

        /// <summary>
        /// Associates a wide-character string with a key.
        /// </summary>
        /// <param name="guidKey">
        /// GUID that identifies the value to set. If this key already exists, the method overwrites the old
        /// value.
        /// </param>
        /// <param name="wszValue">
        /// Null-terminated wide-character string to associate with this key. The method stores a copy of the
        /// string.
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
        /// HRESULT SetString(
        ///   [in]  REFGUID guidKey,
        ///   [in]  LPCWSTR wszValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/51D2A2A0-92CB-49E0-B4A9-7201E9D92322(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/51D2A2A0-92CB-49E0-B4A9-7201E9D92322(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int SetString(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            [In, MarshalAs(UnmanagedType.LPWStr)] string wszValue
            );

        /// <summary>
        /// Associates a byte array with a key.
        /// </summary>
        /// <param name="guidKey">
        /// GUID that identifies the value to set. If this key already exists, the method overwrites the old
        /// value.
        /// </param>
        /// <param name="pBuf">
        /// Pointer to a byte array to associate with this key. The method stores a copy of the array.
        /// </param>
        /// <param name="cbBufSize">
        /// Size of the array, in bytes.
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
        /// HRESULT SetBlob(
        ///   [in]  REFGUID guidKey,
        ///   [in]  const UINT8 *pBuf,
        ///   [in]  UINT32 cbBufSize
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4A2A25A9-4DEA-40C8-988C-9E3806C8F31C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4A2A25A9-4DEA-40C8-988C-9E3806C8F31C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int SetBlob(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            [In, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pBuf,
            int cbBufSize
            );

        /// <summary>
        /// Associates an <strong>IUnknown</strong> pointer with a key. 
        /// </summary>
        /// <param name="guidKey">
        /// GUID that identifies the value to set. If this key already exists, the method overwrites the old
        /// value.
        /// </param>
        /// <param name="pUnknown">
        /// <strong>IUnknown</strong> pointer to be associated with this key. 
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
        /// HRESULT SetUnknown(
        ///   [in]  REFGUID guidKey,
        ///   [in]  IUnknown *pUnknown
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DA0C3D59-07C4-4431-A137-8655DDBF6258(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DA0C3D59-07C4-4431-A137-8655DDBF6258(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int SetUnknown(
            [MarshalAs(UnmanagedType.LPStruct)] Guid guidKey,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnknown
            );

        /// <summary>
        /// Locks the attribute store so that no other thread can access it. If the attribute store is already
        /// locked by another thread, this method blocks until the other thread unlocks the object. After
        /// calling this method, call <see cref="IMFAttributes.UnlockStore"/> to unlock the object. 
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
        /// HRESULT LockStore();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6EC7AED3-7DBC-4AA4-92D5-646AEE757DB7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6EC7AED3-7DBC-4AA4-92D5-646AEE757DB7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int LockStore();

        /// <summary>
        /// Unlocks the attribute store after a call to the <see cref="IMFAttributes.LockStore"/> method. While
        /// the object is unlocked, multiple threads can access the object's attributes. 
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
        /// HRESULT UnlockStore();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/65E35864-868A-4AE9-86ED-772A2B2DAEB6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/65E35864-868A-4AE9-86ED-772A2B2DAEB6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int UnlockStore();

        /// <summary>
        /// Retrieves the number of attributes that are set on this object.
        /// </summary>
        /// <param name="pcItems">
        /// Receives the number of attributes. This parameter must not be <strong>NULL</strong>. If this
        /// parameter is <strong>NULL</strong>, an access violation occurs. 
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
        /// HRESULT GetCount(
        ///   [out]  UINT32 *pcItems
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5F511D5C-249C-4311-8380-A932A755EAAF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5F511D5C-249C-4311-8380-A932A755EAAF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetCount(
            out int pcItems
            );

        /// <summary>
        /// Retrieves an attribute at the specified index.
        /// </summary>
        /// <param name="unIndex">
        /// Index of the attribute to retrieve. To get the number of attributes, call 
        /// <see cref="IMFAttributes.GetCount"/>. 
        /// </param>
        /// <param name="pguidKey">
        /// Receives the GUID that identifies this attribute.
        /// </param>
        /// <param name="pValue">
        /// Pointer to a <strong>PROPVARIANT</strong> that receives the value. This parameter can be <strong>
        /// NULL</strong>. If it is not <strong>NULL</strong>, the method fills the <strong>PROPVARIANT
        /// </strong> with a copy of the attribute value. Call <strong>PropVariantClear</strong> to free the
        /// memory allocated by this method. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>Invalid index.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetItemByIndex(
        ///   [in]       UINT32 unIndex,
        ///   [out]      GUID *pguidKey,
        ///   [in, out]  PROPVARIANT *pValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1290BC45-FCAC-4379-B26C-E67EF678F193(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1290BC45-FCAC-4379-B26C-E67EF678F193(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetItemByIndex(
            int unIndex,
            out Guid pguidKey,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pValue
            );

        /// <summary>
        /// Copies all of the attributes from this object into another attribute store. 
        /// </summary>
        /// <param name="pDest">
        /// A pointer to the <see cref="IMFAttributes"/> interface of the attribute store that receives the
        /// copy. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT CopyAllItems(
        ///   [in]  IMFAttributes *pDest
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/111B55BC-FB8E-45B5-A709-703ACD23C4BE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/111B55BC-FB8E-45B5-A709-703ACD23C4BE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int CopyAllItems(
            [In, MarshalAs(UnmanagedType.Interface)] IMFAttributes pDest
            );

        #endregion

        /// <summary>
        /// Retrieves the number of streams in the profile.
        /// </summary>
        /// <param name="pcStreams">
        /// Receives the number of streams in the profile.
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
        /// HRESULT GetStreamCount(
        ///   [out]  DWORD *pcStreams
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BF8C6157-3420-4097-8AB6-F307A69D418A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BF8C6157-3420-4097-8AB6-F307A69D418A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStreamCount(
            out int pcStreams);

        /// <summary>
        /// Retrieves a stream from the profile by stream index, and/or retrieves the stream number for a
        /// stream index.
        /// </summary>
        /// <param name="dwStreamIndex">
        /// The index of the stream to retrieve. Stream indexes are sequential and zero-based. You can get the
        /// number of streams that are in the profile by calling the <see cref="IMFASFProfile.GetStreamCount"/>
        /// method. 
        /// </param>
        /// <param name="pwStreamNumber">
        /// Receives the stream number of the requested stream. Stream numbers are one-based and are not
        /// necessarily sequential. This parameter can be set to <strong>NULL</strong> if the stream number is
        /// not required. 
        /// </param>
        /// <param name="ppIStream">
        /// Receives a pointer to the <see cref="IMFASFStreamConfig"/> interface of the ASF stream
        /// configuration object. The caller must release the interface. This parameter can be <strong>NULL
        /// </strong> if you want to retrieve the stream number without accessing the stream configuration. 
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
        /// HRESULT GetStream(
        ///   [in]   DWORD dwStreamIndex,
        ///   [out]  WORD *pwStreamNumber,
        ///   [out]  IMFASFStreamConfig **ppIStream
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/918F6534-811E-42F6-9836-1C77816007FA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/918F6534-811E-42F6-9836-1C77816007FA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStream(
            [In] int dwStreamIndex,
            out short pwStreamNumber,
            out IMFASFStreamConfig ppIStream);

        /// <summary>
        /// Retrieves an Advanced Systems Format (ASF) stream configuration object for a stream in the profile.
        /// This method references the stream by stream number instead of stream index.
        /// </summary>
        /// <param name="wStreamNumber">
        /// The stream number for which to obtain the interface pointer.
        /// </param>
        /// <param name="ppIStream">
        /// Receives a pointer to the <see cref="IMFASFStreamConfig"/> interface of the ASF stream
        /// configuration object. The caller must release the interface. 
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
        /// HRESULT GetStreamByNumber(
        ///   [in]   WORD wStreamNumber,
        ///   [out]  IMFASFStreamConfig **ppIStream
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1E3FADF0-1549-4D51-B263-727B15C55023(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1E3FADF0-1549-4D51-B263-727B15C55023(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStreamByNumber(
            [In] short wStreamNumber,
            out IMFASFStreamConfig ppIStream);

        /// <summary>
        /// Adds a stream to the profile or reconfigures an existing stream.
        /// </summary>
        /// <param name="pIStream">
        /// Pointer to the <see cref="IMFASFStreamConfig"/> interface of a configured ASF stream configuration
        /// object. 
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
        /// HRESULT SetStream(
        ///   [in]  IMFASFStreamConfig *pIStream
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C2272260-74AB-42FF-BFF3-D6C6D5B322F3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C2272260-74AB-42FF-BFF3-D6C6D5B322F3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetStream(
            [In] IMFASFStreamConfig pIStream);

        /// <summary>
        /// Removes a stream from the Advanced Systems Format (ASF) profile object.
        /// </summary>
        /// <param name="wStreamNumber">
        /// Stream number of the stream to remove.
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
        /// HRESULT RemoveStream(
        ///   [in]  WORD wStreamNumber
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DFE404D3-66EA-407B-A2E0-CAA065F41AFE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DFE404D3-66EA-407B-A2E0-CAA065F41AFE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RemoveStream(
            [In] short wStreamNumber);

        /// <summary>
        /// Creates an Advanced Systems Format (ASF) stream configuration object.
        /// </summary>
        /// <param name="pIMediaType">
        /// Pointer to the <see cref="IMFMediaType"/> interface of a configured media type. 
        /// </param>
        /// <param name="ppIStream">
        /// Receives a pointer to the <see cref="IMFASFStreamConfig"/> interface of the new ASF stream
        /// configuration object. The caller must release the interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description><em>ppIStream</em> is <strong>NULL</strong>. </description></item>
        /// <item><term><strong>E_OUTOFMEMORY</strong></term><description>stream configuration object could not be created due to insufficient memory.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT CreateStream(
        ///   [in]   IMFMediaType *pIMediaType,
        ///   [out]  IMFASFStreamConfig **ppIStream
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3DA52C1A-24C0-456B-A9E8-57B5467EDA2A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3DA52C1A-24C0-456B-A9E8-57B5467EDA2A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateStream(
            [In] IMFMediaType pIMediaType,
            out IMFASFStreamConfig ppIStream);

        /// <summary>
        /// Retrieves the number of Advanced Systems Format (ASF) mutual exclusion objects that are associated
        /// with the profile.
        /// </summary>
        /// <param name="pcMutexs">
        /// Receives the number of mutual exclusion objects.
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
        /// HRESULT GetMutualExclusionCount(
        ///   [out]  DWORD *pcMutexs
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5E275B83-9E59-4730-B8E2-E45F78077891(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5E275B83-9E59-4730-B8E2-E45F78077891(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMutualExclusionCount(
            out int pcMutexs);

        /// <summary>
        /// Retrieves an Advanced Systems Format (ASF) mutual exclusion object from the profile.
        /// </summary>
        /// <param name="dwMutexIndex">
        /// Index of the mutual exclusion object in the profile.
        /// </param>
        /// <param name="ppIMutex">
        /// Receives a pointer to the <see cref="IMFASFMutualExclusion"/> interface of the ASF mutual exclusion
        /// object. The caller must release the interface. 
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
        /// HRESULT GetMutualExclusion(
        ///   [in]   DWORD dwMutexIndex,
        ///   [out]  IMFASFMutualExclusion **ppIMutex
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9B9E37FC-0BD8-4502-9E90-76330A08F68B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9B9E37FC-0BD8-4502-9E90-76330A08F68B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMutualExclusion(
            [In] int dwMutexIndex,
            out IMFASFMutualExclusion ppIMutex);

        /// <summary>
        /// Adds a configured Advanced Systems Format (ASF) mutual exclusion object to the profile.
        /// </summary>
        /// <param name="pIMutex">
        /// Pointer to the <see cref="IMFASFMutualExclusion"/> interface of a configured ASF mutual exclusion
        /// object. 
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
        /// HRESULT AddMutualExclusion(
        ///   [in]  IMFASFMutualExclusion *pIMutex
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D9069FEB-7D39-4B40-B95E-0112D959BBAE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D9069FEB-7D39-4B40-B95E-0112D959BBAE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int AddMutualExclusion(
            [In] IMFASFMutualExclusion pIMutex);

        /// <summary>
        /// Removes an Advanced Systems Format (ASF) mutual exclusion object from the profile.
        /// </summary>
        /// <param name="dwMutexIndex">
        /// The index of the mutual exclusion object to remove from the profile.
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
        /// HRESULT RemoveMutualExclusion(
        ///   [in]  DWORD dwMutexIndex
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DBCF192F-1AB4-44C4-8444-5D2ABA941FE1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DBCF192F-1AB4-44C4-8444-5D2ABA941FE1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RemoveMutualExclusion(
            [In] int dwMutexIndex);

        /// <summary>
        /// Creates a new Advanced Systems Format (ASF) mutual exclusion object. Mutual exclusion objects can
        /// be added to a profile by calling the <c>AddMutualExclusion</c> method. 
        /// </summary>
        /// <param name="ppIMutex">
        /// Receives a pointer to the <see cref="IMFASFMutualExclusion"/> interface of the new object. The
        /// caller must release the interface. 
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
        /// HRESULT CreateMutualExclusion(
        ///   [out]  IMFASFMutualExclusion **ppIMutex
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/457B7B73-34C0-48FE-882A-9CDC3516E20D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/457B7B73-34C0-48FE-882A-9CDC3516E20D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateMutualExclusion(
            out IMFASFMutualExclusion ppIMutex);

        /// <summary>
        /// <strong>Note</strong> This method is not supported. 
        /// </summary>
        /// <param name="ppIStreamPrioritization">
        /// Reserved.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStreamPrioritization(
        ///   [out]  IMFASFStreamPrioritization **ppIStreamPrioritization
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/28C542B9-A121-4002-83AE-D6DCFA6F0B6A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/28C542B9-A121-4002-83AE-D6DCFA6F0B6A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStreamPrioritization(
#if ALLOW_UNTESTED_INTERFACES
            out IMFASFStreamPrioritization ppIStreamPrioritization);
#else
            [MarshalAs(UnmanagedType.IUnknown)] out object ppIStreamPrioritization);
#endif

        /// <summary>
        /// <strong>Note</strong> This method is not supported. 
        /// </summary>
        /// <param name="pIStreamPrioritization">
        /// Reserved. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT AddStreamPrioritization(
        ///   [in]  IMFASFStreamPrioritization *pIStreamPrioritization
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/64BBE28B-C167-4734-8CEB-5A36DA4A0C70(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/64BBE28B-C167-4734-8CEB-5A36DA4A0C70(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int AddStreamPrioritization(
#if ALLOW_UNTESTED_INTERFACES
            [In] IMFASFStreamPrioritization pIStreamPrioritization);
#else
            [MarshalAs(UnmanagedType.IUnknown)] object pIStreamPrioritization);
#endif

        /// <summary>
        /// <strong>Note</strong> This method is not supported. 
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT RemoveStreamPrioritization();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A6076091-AB38-4722-BB95-FAC253E26C8A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A6076091-AB38-4722-BB95-FAC253E26C8A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RemoveStreamPrioritization();

        /// <summary>
        /// <strong>Note</strong> This method is not implemented. 
        /// </summary>
        /// <param name="ppIStreamPrioritization">
        /// Reserved. 
        /// </param>
        /// <returns>
        /// Returns <strong>E_NOTIMPL</strong>. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT CreateStreamPrioritization(
        ///   [out]  IMFASFStreamPrioritization **ppIStreamPrioritization
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1C3A5470-EBA9-4233-8744-8630002D3FA0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1C3A5470-EBA9-4233-8744-8630002D3FA0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateStreamPrioritization(
#if ALLOW_UNTESTED_INTERFACES
            out IMFASFStreamPrioritization ppIStreamPrioritization);
#else
            [MarshalAs(UnmanagedType.IUnknown)] out object ppIStreamPrioritization);
#endif

        /// <summary>
        /// Creates a copy of the Advanced Systems Format profile object.
        /// </summary>
        /// <param name="ppIProfile">
        /// Receives a pointer to the <see cref="IMFASFProfile"/> interface of the new object. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Clone(
        ///   [out]  IMFASFProfile **ppIProfile
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E91D3D2C-EF08-460E-B6F8-E8EED8DF5A67(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E91D3D2C-EF08-460E-B6F8-E8EED8DF5A67(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Clone(
            out IMFASFProfile ppIProfile);
    }

}
