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
    /// Controls how a network byte stream transfers data to a local cache. Optionally, this interface is
    /// exposed by byte streams that read data from a network, for example, through HTTP. 
    /// <para/>
    /// To get a pointer to this interface, call <strong>QueryInterface</strong> on the byte stream object.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/E12A532A-4624-4E06-8E19-6E9DAEC550AC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E12A532A-4624-4E06-8E19-6E9DAEC550AC(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("F5042EA4-7A96-4A75-AA7B-2BE1EF7F88D5")]
    internal interface IMFByteStreamCacheControl
    {
        /// <summary>
        /// Stops the background transfer of data to the local cache.
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT StopBackgroundTransfer();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9F0F7102-C839-4E92-A798-5EA31CEBA013(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9F0F7102-C839-4E92-A798-5EA31CEBA013(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int StopBackgroundTransfer();
    }

#endif

}
