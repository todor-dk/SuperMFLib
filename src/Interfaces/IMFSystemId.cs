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
    /// Provides a method that retireves system id data.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/45C80FC5-5EA7-4D4E-9C9C-5A38F62B2D28(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/45C80FC5-5EA7-4D4E-9C9C-5A38F62B2D28(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("fff4af3a-1fc1-4ef9-a29b-d26c49e2f31a")]
    public interface IMFSystemId
    {
        /// <summary>
        /// Retrieves system id data.
        /// </summary>
        /// <param name="size">
        /// The size in bytes of the returned data.
        /// </param>
        /// <param name="data">
        /// Receives the returned data. The caller must free this buffer by calling <c>CoTaskMemFree</c>. 
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
        /// HRESULT GetData(
        ///   UINT32 *size,
        ///   BYTE **data
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5B345A8D-65D1-4780-A7B9-B1025F9FA773(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5B345A8D-65D1-4780-A7B9-B1025F9FA773(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetData( 
            out int size,
            out IntPtr data
        );

        /// <summary>
        /// Sets up the <see cref="IMFSystemId"/>. 
        /// </summary>
        /// <param name="stage">
        /// Stage in the setup process. 0 or 1.
        /// </param>
        /// <param name="cbIn">
        /// Size of the input buffer.
        /// </param>
        /// <param name="pbIn">
        /// The input buffer.
        /// </param>
        /// <param name="pcbOut">
        /// Size of output buffer.
        /// </param>
        /// <param name="ppbOut">
        /// The output buffer.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT Setup(
        ///   UNIT32 stage,
        ///   UINT32 cbIn,
        ///   const BYTE *pbIn,
        ///   UINT32 *pcbOut,
        ///   BYTE **ppbOut
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6A779581-326A-4666-8E11-D7CDCB02FAA2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6A779581-326A-4666-8E11-D7CDCB02FAA2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Setup( 
            int stage,
            int cbIn,
            IntPtr pbIn,
            out int pcbOut,
            out IntPtr ppbOut
        );        
    }

#endif

}
