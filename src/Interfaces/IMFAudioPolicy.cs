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
    /// Configures the audio session that is associated with the streaming audio renderer (SAR). Use this
    /// interface to change how the audio session appears in the Windows volume control.
    /// <para/>
    /// The SAR exposes this interface as a service. To get a pointer to the interface, call 
    /// <see cref="IMFGetService.GetService"/> with the service identifier MR_AUDIO_POLICY_SERVICE. You can
    /// call <strong>GetService</strong> directly on the SAR or call it on the Media Session. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FCD4DBFB-3F9F-4089-B9CC-7B41B2C2678A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FCD4DBFB-3F9F-4089-B9CC-7B41B2C2678A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("A0638C2B-6465-4395-9AE7-A321A9FD2856")]
    public interface IMFAudioPolicy
    {
        /// <summary>
        /// Assigns the audio session to a group of sessions.
        /// </summary>
        /// <param name="rguidClass">
        /// A <strong>GUID</strong> that identifies the session group. Groups are application-defined. To
        /// create a new session group, assign a new GUID. 
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
        /// HRESULT SetGroupingParam(
        ///   [in]  REFGUID rguidClass
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2C024208-F13F-4FD1-B5A8-B881AF226670(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2C024208-F13F-4FD1-B5A8-B881AF226670(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetGroupingParam(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid rguidClass
            );

        /// <summary>
        /// Retrieves the group of sessions to which this audio session belongs.
        /// </summary>
        /// <param name="pguidClass">
        /// Receives a GUID that identifies the session group.
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
        /// HRESULT GetGroupingParam(
        ///   [out]  GUID *pguidClass
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/725892FD-4AF6-483D-BB5C-87051FA45EC4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/725892FD-4AF6-483D-BB5C-87051FA45EC4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetGroupingParam(
            out Guid pguidClass
            );

        /// <summary>
        /// Sets the display name of the audio session. The Windows volume control displays this name.
        /// </summary>
        /// <param name="pszName">
        /// A null-terminated wide-character string that contains the display name.
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
        /// HRESULT SetDisplayName(
        ///   [in]  LPCWSTR pszName
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4CD48400-8D12-4A6B-95FD-BF6AE7700CB8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4CD48400-8D12-4A6B-95FD-BF6AE7700CB8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetDisplayName(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszName
            );

        /// <summary>
        /// Retrieves the display name of the audio session. The Windows volume control displays this name.
        /// </summary>
        /// <param name="pszName">The PSZ name.</param>
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
        /// HRESULT GetDisplayName(
        ///   [out]  LPWSTR *pbstrName
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7826B4A1-5887-46A5-B312-91159596CCF5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7826B4A1-5887-46A5-B312-91159596CCF5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetDisplayName(
            [MarshalAs(UnmanagedType.LPWStr)] out string pszName
            );

        /// <summary>
        /// Sets the icon resource for the audio session. The Windows volume control displays this icon. 
        /// </summary>
        /// <param name="pszPath">
        /// A wide-character string that specifies the icon. See Remarks.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetIconPath(
        ///   [in]  LPCWSTR pszPath
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/098AD6AE-B1FE-4E74-B494-572770906B14(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/098AD6AE-B1FE-4E74-B494-572770906B14(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetIconPath(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszPath
            );

        /// <summary>
        /// Retrieves the icon resource for the audio session. The Windows volume control displays this icon.
        /// </summary>
        /// <param name="pszPath">
        /// Receives a pointer to a wide-character string that specifies a shell resource. The format of the
        /// string is described in the topic <see cref="IMFAudioPolicy.SetIconPath"/>. The caller must free the
        /// memory allocated for the string by calling <c>CoTaskMemFree</c>. 
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
        /// HRESULT GetIconPath(
        ///   [out]  LPWSTR *pszPath
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F2114F15-4357-4B5A-B384-695165D887DE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F2114F15-4357-4B5A-B384-695165D887DE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetIconPath(
            [MarshalAs(UnmanagedType.LPWStr)] out string pszPath
            );
    }

#endif

}
