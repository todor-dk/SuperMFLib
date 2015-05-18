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
    /// Provides a method that allows content protection systems to get the procedure address of a function
    /// in the signed library. This method provides the same functionality as <strong>GetProcAddress
    /// </strong> which is not available to Windows Store apps. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/1170FD74-7DA4-49A8-B095-DD1572DB382D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1170FD74-7DA4-49A8-B095-DD1572DB382D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("4a724bca-ff6a-4c07-8e0d-7a358421cf06")]
    internal interface IMFSignedLibrary
    {
        /// <summary>
        /// Gets the procedure address of the specified function in the signed library.
        /// </summary>
        /// <param name="name">
        /// The entry point name in the DLL that specifies the function.
        /// </param>
        /// <param name="address">
        /// Receives the address of the entry point.
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
        /// HRESULT GetProcedureAddress(
        ///   LPCSTR name,
        ///   PVOID *address
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D32678B0-422D-4FE8-9BBC-FC203A39FDD5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D32678B0-422D-4FE8-9BBC-FC203A39FDD5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetProcedureAddress( 
            [In, MarshalAs(UnmanagedType.LPWStr)] string name,
            out IntPtr address
        );        
    }

#endif

}
