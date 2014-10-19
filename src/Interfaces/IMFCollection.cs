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


    /// <summary>
    /// Represents a generic collection of <strong>IUnknown</strong> pointers. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FEC6AA17-2770-4F53-B36D-B94236093D23(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FEC6AA17-2770-4F53-B36D-B94236093D23(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("5BC8A76B-869A-46A3-9B03-FA218A66AEBE")]
    public interface IMFCollection
    {
        /// <summary>
        /// Retrieves the number of objects in the collection.
        /// </summary>
        /// <param name="pcElements">
        /// Receives the number of objects in the collection.
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
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetElementCount(
        ///   [out]  DWORD *pcElements
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4BD46F66-0542-4185-B50E-163CC3B4E2F8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4BD46F66-0542-4185-B50E-163CC3B4E2F8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetElementCount(
            out int pcElements
            );

        /// <summary>
        /// Retrieves an object in the collection.
        /// </summary>
        /// <param name="dwElementIndex">
        /// Zero-based index of the object to retrieve. Objects are indexed in the order in which they were
        /// added to the collection. 
        /// </param>
        /// <param name="ppUnkElement">
        /// Receives a pointer to the object's <strong>IUnknown</strong> interface. The caller must release the
        /// interface. The retrieved pointer value might be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetElement(
        ///   [in]   DWORD dwElementIndex,
        ///   [out]  IUnknown **ppUnkElement
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A45983A8-4061-40E1-A11A-67DE0867E553(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A45983A8-4061-40E1-A11A-67DE0867E553(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetElement(
            [In] int dwElementIndex,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppUnkElement
            );

        /// <summary>
        /// Adds an object to the collection.
        /// </summary>
        /// <param name="pUnkElement">
        /// Pointer to the object's <strong>IUnknown</strong> interface. 
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
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT AddElement(
        ///   [in]  IUnknown *pUnkElement
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1EF2463B-3D5E-4ED0-AB7C-68758E6CC056(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1EF2463B-3D5E-4ED0-AB7C-68758E6CC056(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int AddElement(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnkElement
            );

        /// <summary>
        /// Removes an object from the collection.
        /// </summary>
        /// <param name="dwElementIndex">
        /// Zero-based index of the object to remove. Objects are indexed in the order in which they were added
        /// to the collection.
        /// </param>
        /// <param name="ppUnkElement">
        /// Receives a pointer to the <strong>IUnknown</strong> interface of the object. The caller must
        /// release the interface. This parameter cannot be <strong>NULL</strong>, but the retrieved pointer
        /// value might be <strong>NULL</strong>. 
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
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT RemoveElement(
        ///   [in]   DWORD dwElementIndex,
        ///   [out]  IUnknown **ppUnkElement
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/47F33235-6BB5-4103-82B4-87210B0E695C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/47F33235-6BB5-4103-82B4-87210B0E695C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RemoveElement(
            [In] int dwElementIndex,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppUnkElement
            );

        /// <summary>
        /// Adds an object at the specified index in the collection.
        /// </summary>
        /// <param name="dwIndex">
        /// The zero-based index where the object will be added to the collection.
        /// </param>
        /// <param name="pUnknown">
        /// The object to insert.
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
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT InsertElementAt(
        ///   [in]  DWORD dwIndex,
        ///   [in]  IUnknown *pUnknown
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D8F64BF8-EB5B-4673-91BE-796F4EA8DCE0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D8F64BF8-EB5B-4673-91BE-796F4EA8DCE0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int InsertElementAt(
            [In] int dwIndex,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnknown
            );

        /// <summary>
        /// Removes all items from the collection.
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
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT RemoveAllElements();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8C82D287-B73E-46DD-A319-70C5D0F536C6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8C82D287-B73E-46DD-A319-70C5D0F536C6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RemoveAllElements();
    }

}
