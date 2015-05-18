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
    /// Enables a media source to receive a pointer to the <see cref="IMFPMPHost"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/ADFBA5DD-EAE6-48F3-A155-65BD491C952C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/ADFBA5DD-EAE6-48F3-A155-65BD491C952C(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("6C4E655D-EAD8-4421-B6B9-54DCDBBDF820")]
    internal interface IMFPMPClient
    {
        /// <summary>
        /// Provides a pointer to the <see cref="IMFPMPHost"/> interface. 
        /// </summary>
        /// <param name="pPMPHost">
        /// A pointer to the <see cref="IMFPMPHost"/> interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetPMPHost(
        ///   [in]  IMFPMPHost *pPMPHost
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D6E48F36-7896-4E6D-BA10-D8C0288CCFFC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D6E48F36-7896-4E6D-BA10-D8C0288CCFFC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetPMPHost(
            [In, MarshalAs(UnmanagedType.Interface)] IMFPMPHost pPMPHost
            );
    }

#endif

}
