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
    /// Sets and retrieves Synchronized Accessible Media Interchange (SAMI) styles on the 
    /// <c>SAMI Media Source</c>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/C4887C52-57AF-4783-B853-11FE6AD3510E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C4887C52-57AF-4783-B853-11FE6AD3510E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("A7E025DD-5303-4A62-89D6-E747E1EFAC73"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFSAMIStyle
    {
        /// <summary>
        /// Gets the number of styles defined in the SAMI file. 
        /// </summary>
        /// <param name="pdwCount">
        /// Receives the number of SAMI styles in the file. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetStyleCount(
        ///   [out]  DWORD *pdwCount
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/161CD457-9FAB-4EBB-B8B8-F87326D67C66(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/161CD457-9FAB-4EBB-B8B8-F87326D67C66(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStyleCount(
            out int pdwCount
            );

        /// <summary>
        /// Gets a list of the style names defined in the SAMI file. 
        /// </summary>
        /// <param name="pPropVarStyleArray">
        /// Pointer to a <strong>PROPVARIANT</strong> that receives an array of null-terminated wide-character
        /// strings. The <strong>PROPVARIANT</strong> type is VT_VECTOR | VT_LPWSTR. The caller must clear the 
        /// <strong>PROPVARIANT</strong> by calling <strong>PropVariantClear</strong>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetStyles(
        ///   [out]  PROPVARIANT *pPropVarStyleArray
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E0B183F0-8781-4FC5-97DD-E42B0E7BD5E5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E0B183F0-8781-4FC5-97DD-E42B0E7BD5E5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStyles(
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pPropVarStyleArray
            );

        /// <summary>
        /// Sets the current style on the SAMI media source.
        /// </summary>
        /// <param name="pwszStyle">
        /// Pointer to a null-terminated string containing the name of the style. To clear the current style,
        /// pass an empty string (""). To get the list of style names, call 
        /// <see cref="IMFSAMIStyle.GetStyles"/>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetSelectedStyle(
        ///   [in]  LPWSTR pwszStyle
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F7179756-517B-400B-8676-FD9AB5BBE74C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F7179756-517B-400B-8676-FD9AB5BBE74C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetSelectedStyle(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszStyle
            );

        /// <summary>
        /// Gets the current style from the SAMI media source. 
        /// </summary>
        /// <param name="ppwszStyle">
        /// Receives a pointer to a null-terminated string that contains the name of the style. If no style is
        /// currently set, the method returns an empty string. The caller must free the memory for the string
        /// by calling <c>CoTaskMemFree</c>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetSelectedStyle(
        ///   [out]  LPWSTR *ppwszStyle
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7501A4D5-EB5F-4F62-AE55-96EE999E561C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7501A4D5-EB5F-4F62-AE55-96EE999E561C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetSelectedStyle(
            [MarshalAs(UnmanagedType.LPWStr)] out string ppwszStyle
            );
    }

#endif

}
