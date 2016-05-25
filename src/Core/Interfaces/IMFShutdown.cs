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
using MediaFoundation.Core.Enums;

namespace MediaFoundation.Core.Interfaces
{
    /// <summary>
    /// Exposed by some Media Foundation objects that must be explicitly shut down.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/C3052658-51BB-401B-8DB9-3428868899D6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C3052658-51BB-401B-8DB9-3428868899D6(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport]
    [System.Security.SuppressUnmanagedCodeSecurity]
    [Guid("97EC2EA4-0E42-4937-97AC-9D6D328824E1")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFShutdown
    {
        /// <summary>
        /// Shuts down a Media Foundation object and releases all resources associated with the object.
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Shutdown();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/9E7824D2-0F76-4C4C-98C5-BA51CD297DE7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9E7824D2-0F76-4C4C-98C5-BA51CD297DE7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Shutdown();

        /// <summary>
        /// Queries the status of an earlier call to the <see cref="IMFShutdown.Shutdown"/> method.
        /// </summary>
        /// <param name="pStatus">
        /// Receives a member of the <see cref="MFShutdownStatus"/> enumeration.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>Invalid argument.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description> The <c>Shutdown</c> method has not been called on this object. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetShutdownStatus(
        ///   [out]  MFSHUTDOWN_STATUS *pStatus
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/8CF5F5F3-A3AD-4745-87E8-764ED118477A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8CF5F5F3-A3AD-4745-87E8-764ED118477A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetShutdownStatus(
            out MFShutdownStatus pStatus);
    }
}
