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

using MediaFoundation.Misc;
using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation.Core.Interfaces
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Provides the Media Engine with a list of media resources.
    /// </summary>
    /// <remarks>
    /// The above documentation is � Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/37A3EAC0-639C-47F3-AAB9-588EBEC8E1E3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/37A3EAC0-639C-47F3-AAB9-588EBEC8E1E3(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("7a5e5354-b114-4c72-b991-3131d75032ea"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFMediaEngineSrcElements
    {
        /// <summary>
        /// Gets the number of source elements in the list.
        /// </summary>
        /// <returns>
        /// Returns the number of source elements.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// DWORD GetLength();
        /// </code>
        /// <para/>
        /// The above documentation is � Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/212883A5-5613-4BCC-8713-9CD5E6480136(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/212883A5-5613-4BCC-8713-9CD5E6480136(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetLength();

        /// <summary>
        /// Gets the URL of an element in the list.
        /// </summary>
        /// <param name="index">
        /// The zero-based index of the source element. To get the number of source elements, call 
        /// <see cref="IMFMediaEngineSrcElements.GetLength"/>. 
        /// </param>
        /// <param name="pURL">
        /// Receives a <strong>BSTR</strong> that contains the URL of the source element. The caller must free
        /// the <strong>BSTR</strong> by calling <strong>SysFreeString</strong>. If no URL is set, this
        /// parameter receives the value <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetURL(
        ///   [in]���DWORD index,
        ///   [out]��BSTR *pURL
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is � Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5935BE0D-0E5A-46A8-944C-096746C5FCA3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5935BE0D-0E5A-46A8-944C-096746C5FCA3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetURL(
            int index,
            [MarshalAs(UnmanagedType.BStr)] out string pURL
            );

        /// <summary>
        /// Gets the MIME type of an element in the list.
        /// </summary>
        /// <param name="index">
        /// The zero-based index of the source element. To get the number of source elements, call 
        /// <see cref="IMFMediaEngineSrcElements.GetLength"/>. 
        /// </param>
        /// <param name="pType">
        /// Receives a <strong>BSTR</strong> that contains the MIME type. The caller must free the <strong>BSTR
        /// </strong> by calling <strong>SysFreeString</strong>. If no MIME type is set, this parameter
        /// receives the value <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetType(
        ///   [in]���DWORD index,
        ///   [out]��BSTR *pType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is � Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7B788160-A342-48B4-A3F9-42F3BB83A24D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7B788160-A342-48B4-A3F9-42F3BB83A24D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetType(
            int index,
            [MarshalAs(UnmanagedType.BStr)] out string pType
            );

        /// <summary>
        /// Gets the intended media type of an element in the list.
        /// </summary>
        /// <param name="index">
        /// The zero-based index of the source element. To get the number of source elements, call 
        /// <see cref="IMFMediaEngineSrcElements.GetLength"/>. 
        /// </param>
        /// <param name="pMedia">
        /// Receives a <strong>BSTR</strong> that contains a media-query string. The caller must free the 
        /// <strong>BSTR</strong> by calling <strong>SysFreeString</strong>. If no media type is set, this
        /// parameter receives the value <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetMedia(
        ///   [in]���DWORD index,
        ///   [out]��BSTR *pMedia
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is � Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AC99D8D0-ACA6-4FE9-A061-1D3A7D92E596(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AC99D8D0-ACA6-4FE9-A061-1D3A7D92E596(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMedia(
            int index,
            [MarshalAs(UnmanagedType.BStr)] out string pMedia
            );

        /// <summary>
        /// Adds a source element to the end of the list.
        /// </summary>
        /// <param name="pURL">
        /// The URL of the source element, or <strong>NULL</strong>. 
        /// </param>
        /// <param name="pType">
        /// The MIME type of the source element, or <strong>NULL</strong>. 
        /// </param>
        /// <param name="pMedia">
        /// A media-query string that specifies the intended media type, or <strong>NULL</strong>. If
        /// specified, the string should conform to the W3C <em>Media Queries</em> specification. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT AddElement(
        ///   [in]��BSTR pURL,
        ///   [in]��BSTR pType,
        ///   [in]��BSTR pMedia
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is � Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2C98A70B-F6B3-4CA7-8D04-958DFCCD2A50(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2C98A70B-F6B3-4CA7-8D04-958DFCCD2A50(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int AddElement(
            [MarshalAs(UnmanagedType.BStr)] string pURL,
            [MarshalAs(UnmanagedType.BStr)] string pType,
            [MarshalAs(UnmanagedType.BStr)] string pMedia
            );

        /// <summary>
        /// Removes all of the source elements from the list.
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT RemoveAllElements();
        /// </code>
        /// <para/>
        /// The above documentation is � Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4E867439-CBBA-4D36-9E0F-9034D3803688(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4E867439-CBBA-4D36-9E0F-9034D3803688(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RemoveAllElements();
    }

#endif

}
