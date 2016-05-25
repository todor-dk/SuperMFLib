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
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Configures a network scheme plug-in. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/91BDCDBD-D621-42E3-8E0F-F8EEAB489D35(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/91BDCDBD-D621-42E3-8E0F-F8EEAB489D35(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("7BE19E73-C9BF-468A-AC5A-A5E8653BEC87")]
    internal interface IMFNetSchemeHandlerConfig
    {
        /// <summary>
        /// Retrieves the number of protocols supported by the network scheme plug-in.
        /// </summary>
        /// <param name="pcProtocols">
        /// Receives the number of protocols.
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
        /// HRESULT GetNumberOfSupportedProtocols(
        ///   [out]  ULONG *pcProtocols
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A0CBB01C-C86C-4186-81CA-6055AAB5D361(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A0CBB01C-C86C-4186-81CA-6055AAB5D361(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetNumberOfSupportedProtocols(
            out int pcProtocols
            );

        /// <summary>
        /// Retrieves a supported protocol by index
        /// </summary>
        /// <param name="nProtocolIndex">
        /// Zero-based index of the protocol to retrieve. To get the number of supported protocols, call 
        /// <see cref="IMFNetSchemeHandlerConfig.GetNumberOfSupportedProtocols"/>. 
        /// </param>
        /// <param name="pnProtocolType">
        /// Receives a member of the <see cref="MFNetSourceProtocolType"/> enumeration. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>The value passed in the <em>nProtocolIndex</em> parameter was greater than the total number of supported protocols, returned by <c>GetNumberOfSupportedProtocols</c>. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetSupportedProtocolType(
        ///   [in]   ULONG nProtocolIndex,
        ///   [out]  MFNETSOURCE_PROTOCOL_TYPE *pnProtocolType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/51CD90CF-A3AE-45DD-BC27-C91D44CAB9F5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/51CD90CF-A3AE-45DD-BC27-C91D44CAB9F5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetSupportedProtocolType(
            [In] int nProtocolIndex,
            out MFNetSourceProtocolType pnProtocolType
            );

        /// <summary>
        /// Not implemented in this release.
        /// </summary>
        /// <returns>
        /// This method returns S_OK.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT ResetProtocolRolloverSettings();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F2F792A4-811B-4EEC-849B-BDD22774C4A8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F2F792A4-811B-4EEC-849B-BDD22774C4A8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ResetProtocolRolloverSettings();
    }

#endif

}
