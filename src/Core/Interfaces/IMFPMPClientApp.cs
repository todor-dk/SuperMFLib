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
    /// Provides a mechanism for a media source to implement content protection functionality in a Windows
    /// Store apps.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/03CD9E3C-65AC-40AD-802D-E36127DBD61F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/03CD9E3C-65AC-40AD-802D-E36127DBD61F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("c004f646-be2c-48f3-93a2-a0983eba1108")]
    internal interface IMFPMPClientApp
    {
        /// <summary>
        /// Sets a pointer to the <see cref="IMFPMPHostApp"/> interface allowing a media source to create
        /// objects in the PMP process. 
        /// </summary>
        /// <param name="pPMPHost">
        /// A pointer to the <see cref="IMFPMPHostApp"/> interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetPMPHost(
        ///   [in]  IMFPMPHostApp *pPMPHost
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8809E691-F0CF-4C1F-8409-5E7FBAC46B16(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8809E691-F0CF-4C1F-8409-5E7FBAC46B16(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetPMPHost( 
            IMFPMPHostApp pPMPHost
        );        
    }

#endif

}
