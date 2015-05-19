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
    /// <summary>
    /// Gets and sets media types on an object, such as a media source or media sink. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/5B937BF7-4F86-4DC1-A4D5-7E724DCF5B36(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5B937BF7-4F86-4DC1-A4D5-7E724DCF5B36(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("E93DCF6C-4B07-4E1E-8123-AA16ED6EADF5"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaTypeHandler
    {
        /// <summary>
        /// Queries whether the object supports a specified media type.
        /// </summary>
        /// <param name="pMediaType">
        /// Pointer to the <see cref="IMFMediaType"/> interface of the media type to check. 
        /// </param>
        /// <param name="ppMediaType">
        /// Receives a pointer to the <see cref="IMFMediaType"/> interface of the closest matching media type,
        /// or receives the value <strong>NULL</strong>. If non- <strong>NULL</strong>, the caller must release
        /// the interface. This parameter can be <strong>NULL</strong>. See Remarks. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_INVALIDMEDIATYPE</strong></term><description> The object does not support this media type. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT IsMediaTypeSupported(
        ///   [in]   IMFMediaType *pMediaType,
        ///   [out]  IMFMediaType **ppMediaType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EA52DEFA-8B78-4F40-97AE-ED6A5EE4849E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EA52DEFA-8B78-4F40-97AE-ED6A5EE4849E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int IsMediaTypeSupported(
            [In, MarshalAs(UnmanagedType.Interface)] IMFMediaType pMediaType,
            /* [MarshalAs(UnmanagedType.Interface)] out IMFMediaType */ out IntPtr ppMediaType);

        /// <summary>
        /// Retrieves the number of media types in the object's list of supported media types.
        /// </summary>
        /// <param name="pdwTypeCount">
        /// Receives the number of media types in the list.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetMediaTypeCount(
        ///   [out]  DWORD *pdwTypeCount
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C5EE41BC-EE8B-4990-AE9D-92EF54597F31(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C5EE41BC-EE8B-4990-AE9D-92EF54597F31(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMediaTypeCount(
            out int pdwTypeCount);

        /// <summary>
        /// Retrieves a media type from the object's list of supported media types.
        /// </summary>
        /// <param name="dwIndex">
        /// Zero-based index of the media type to retrieve. To get the number of media types in the list, call 
        /// <see cref="IMFMediaTypeHandler.GetMediaTypeCount"/>. 
        /// </param>
        /// <param name="ppType">
        /// Receives a pointer to the <see cref="IMFMediaType"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_NO_MORE_TYPES</strong></term><description> The <em>dwIndex</em> parameter is out of range. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetMediaTypeByIndex(
        ///   [in]   DWORD dwIndex,
        ///   [out]  IMFMediaType **ppType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A1827675-BBC4-45D8-8C6E-644B0D2ADDD4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A1827675-BBC4-45D8-8C6E-644B0D2ADDD4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMediaTypeByIndex(
            [In] int dwIndex,
            /* [MarshalAs(UnmanagedType.Interface)] out IMFMediaType */ out IntPtr ppType);

        /// <summary>
        /// Sets the object's media type.
        /// </summary>
        /// <param name="pMediaType">
        /// Pointer to the <see cref="IMFMediaType"/> interface of the new media type. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description> Invalid request. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetCurrentMediaType(
        ///   [in]  IMFMediaType *pMediaType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/77FF397E-4FA8-4849-98B8-6BDD035C0E89(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/77FF397E-4FA8-4849-98B8-6BDD035C0E89(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetCurrentMediaType(
            [In, MarshalAs(UnmanagedType.Interface)] IMFMediaType pMediaType);

        /// <summary>
        /// Retrieves the current media type of the object.
        /// </summary>
        /// <param name="ppMediaType">
        /// Receives a pointer to the <see cref="IMFMediaType"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_NOT_INITIALIZED</strong></term><description> No media type is set. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetCurrentMediaType(
        ///   [out]  IMFMediaType **ppMediaType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B1676E40-81A2-4311-BBA6-528BFA45A708(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B1676E40-81A2-4311-BBA6-528BFA45A708(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetCurrentMediaType(
            /* [MarshalAs(UnmanagedType.Interface)] out IMFMediaType */ out IntPtr ppMediaType);

        /// <summary>
        /// Gets the major media type of the object. 
        /// </summary>
        /// <param name="pguidMajorType">
        /// Receives a GUID that identifies the major type. For a list of possible values, see 
        /// <c>Major Media Types</c>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetMajorType(
        ///   [out]  GUID *pguidMajorType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1560D113-80A9-48BB-9F3D-6E3A288DB962(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1560D113-80A9-48BB-9F3D-6E3A288DB962(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMajorType(out Guid pguidMajorType);
    }
}
