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
    /// Provides a method that allows content protection systems to perform a handshake with the protected
    /// environment. This is needed because the <strong>CreateFile</strong> and <strong>DeviceIoControl
    /// </strong> APIs are not available to Windows Store apps. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/2CD93BC9-4A42-4E16-80AA-4ECF5900F5E4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2CD93BC9-4A42-4E16-80AA-4ECF5900F5E4(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("ef5dc845-f0d9-4ec9-b00c-cb5183d38434")]
    internal interface IMFProtectedEnvironmentAccess
    {
        /// <summary>
        /// Allows content protection systems to access the protected environment.
        /// </summary>
        /// <param name="inputLength">
        /// The length in bytes of the input data.
        /// </param>
        /// <param name="input">
        /// A pointer to the input data.
        /// </param>
        /// <param name="outputLength">
        /// The length in bytes of the output data.
        /// </param>
        /// <param name="output">
        /// A pointer to the output data.
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
        /// HRESULT Call(
        ///   UINT32 inputLength,
        ///   const BYTE *input,
        ///   UINT32 outputLength,
        ///   BYTE *output
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/805473C4-A2C9-483A-9A2C-29A9C63DD58C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/805473C4-A2C9-483A-9A2C-29A9C63DD58C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Call( 
            int inputLength,
            IntPtr input,
            int outputLength,
            IntPtr output
        );


        /// <summary>
        /// Gets the Global Revocation List (GLR).
        /// </summary>
        /// <param name="outputLength">
        /// The length of the data returned in <strong>output</strong>. 
        /// </param>
        /// <param name="output">
        /// Receives the contents of the global revocation list file.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT ReadGRL(
        ///   UINT32 *outputLength,
        ///   BYTE **output
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/38B70C99-1823-498C-B3E4-D2CAD05278DE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/38B70C99-1823-498C-B3E4-D2CAD05278DE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ReadGRL(
            out int outputLength,
            out IntPtr output
            );
    }

#endif

}
