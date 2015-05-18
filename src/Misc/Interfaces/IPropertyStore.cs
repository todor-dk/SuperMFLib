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

namespace MediaFoundation.Misc.Interfaces
{
#if NOT_IN_USE

    /// <summary>
    /// Exposes methods for enumerating, getting, and setting property values.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/E995AAA1-D4C9-475F-B1FA-B9123CD5B653(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E995AAA1-D4C9-475F-B1FA-B9123CD5B653(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("886D8EEB-8CF2-4446-8D02-CDBA1DBDCF99")]
    internal interface IPropertyStore
    {
        /// <summary>
        /// This method returns a count of the number of properties that are attached to the file.
        /// </summary>
        /// <param name="cProps">
        /// A pointer to a value that indicates the property count.
        /// </param>
        /// <returns>
        /// The <c>IpropertyStore::GetCount</c> method returns a value of S_OK when the call is
        /// successful, even if the file has no properties attached. Any other code returned is an error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetCount(
        ///   DWORD *cProps
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F7B982-29DB-4960-9A1D-2F9E033EBF61(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F7B982-29DB-4960-9A1D-2F9E033EBF61(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetCount(
            out int cProps
            );

        /// <summary>
        /// Gets a property key from the property array of an item.
        /// </summary>
        /// <param name="iProp">
        /// The index of the property key in the array of PROPERTYKEY structures. This is a zero-based index.
        /// </param>
        /// <param name="pkey">The pkey.</param>
        /// <returns>
        /// The <c>IPropertyStore::GetAt</c> method returns a value of S_OK if successful. Otherwise, any
        /// other code it returns must be considered to be an error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetAt(
        ///   DWORD iProp,
        ///   PROPERTYKEY *pKey
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4F93949A-D5D5-4FBF-8538-6171861E5884(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4F93949A-D5D5-4FBF-8538-6171861E5884(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetAt(
            [In] int iProp,
            [Out] PropertyKey pkey
            );

        /// <summary>
        /// This method retrieves the data for a specific property.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="pv">
        /// After the <c>IPropertyStore::GetValue</c> method returns successfully, this parameter points
        /// to a <c>PROPVARIANT </c> structure that contains data about the property. 
        /// </param>
        /// <returns>
        /// Returns S_OK or INPLACE_S_TRUNCATED if successful, or an error value otherwise. 
        /// <para/>
        /// INPLACE_S_TRUNCATED is returned to indicate that the returned PROPVARIANT was converted into a more
        /// canonical form. For example, this would be done to trim leading or trailing spaces from a string
        /// value. You must use the SUCCEEDED macro to check the return value, which treats INPLACE_S_TRUNCATED
        /// as a success code. The SUCCEEDED macro is defined in the Winerror.h file.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetValue(
        ///   REFPROPERTYKEY Key,
        ///   PROPVARIANT *pv
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/11204335-0F00-4AF8-8787-93E91248E5BD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/11204335-0F00-4AF8-8787-93E91248E5BD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetValue(
            [In, MarshalAs(UnmanagedType.LPStruct)] PropertyKey key,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pv
            );

        /// <summary>
        /// This method sets a property value or replaces or removes an existing value.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="propvar">The propvar.</param>
        /// <returns>
        /// The <c>IPropertyStore::SetValue</c> method can return any one of the following: 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The property change was successful.</description></item>
        /// <item><term><strong>INPLACE_S_TRUNCATED</strong></term><description>The value was set but truncated.</description></item>
        /// <item><term><strong>STG_E_ACCESSDENIED</strong></term><description>This is an error code. The property store was read-only so the method was not able to set the value.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetValue(
        ///   REFPROPERTYKEY Key,
        ///   Const PROPVARIANT *pv
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BE21BCB2-6875-4559-ABD7-A496F0FCDDD6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BE21BCB2-6875-4559-ABD7-A496F0FCDDD6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetValue(
            [In, MarshalAs(UnmanagedType.LPStruct)] PropertyKey key,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant propvar
            );

        /// <summary>
        /// After a change has been made, this method saves the changes.
        /// </summary>
        /// <returns>
        /// The <c>IPropertyStore::Commit</c> method returns any one of the following: 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>All of the property changes were successfully written to the stream or path. This includes the case where no changes were pending when the method was called and nothing was written.</description></item>
        /// <item><term><strong>STG_E_ACCESSDENIED</strong></term><description>The stream or file is read-only; the method was not able to set the value.</description></item>
        /// <item><term><strong>E_FAIL</strong></term><description>Some or all of the changes could not be written to the file. Another, more explanatory error can be used in place of E_FAIL.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Commit(
        ///    VOID
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A3CC6815-A16F-45E7-A2D5-8F354F712170(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A3CC6815-A16F-45E7-A2D5-8F354F712170(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Commit();
    }

#endif
}
