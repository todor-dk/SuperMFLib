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
using System.Runtime.InteropServices;

using MediaFoundation.Misc;

namespace MediaFoundation.Transform
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Registers Media Foundation transforms (MFTs) in the caller's process.
    /// <para/>
    /// The Media Session exposes this interface as a service. To obtain a pointer to this interface, call
    /// the <see cref="IMFGetService.GetService"/> method on the Media Session with the service identifier 
    /// <strong>MF_LOCAL_MFT_REGISTRATION_SERVICE</strong>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/E540A93A-ECCE-4C5B-A121-B0F868A2AF41(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E540A93A-ECCE-4C5B-A121-B0F868A2AF41(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("149c4d73-b4be-4f8d-8b87-079e926b6add")]
    public interface IMFLocalMFTRegistration
    {
        /// <summary>
        /// Registers one or more Media Foundation transforms (MFTs) in the caller's process.
        /// </summary>
        /// <param name="pMFTs">
        /// A pointer to an array of <see cref="Transform.MFT_REGISTRATION_INFO"/> structures. 
        /// </param>
        /// <param name="cMFTs">
        /// The number of elements in the <em>pMFTs</em> array. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT RegisterMFTs(
        ///   [in]  MFT_REGISTRATION_INFO *pMFTs,
        ///   [in]  DWORD cMFTs
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3F77B5B9-94AF-42B1-83CA-CB3310083632(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3F77B5B9-94AF-42B1-83CA-CB3310083632(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RegisterMFTs(
            [In] MFT_REGISTRATION_INFO[] pMFTs,
            int cMFTs
        );
    }

#endif

}
