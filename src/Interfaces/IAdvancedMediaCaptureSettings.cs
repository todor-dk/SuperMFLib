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

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Provides settings for advanced media capture.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/F99669A1-5E6E-4E3B-8907-5FB537ECADFE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F99669A1-5E6E-4E3B-8907-5FB537ECADFE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("24E0485F-A33E-4aa1-B564-6019B1D14F65"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAdvancedMediaCaptureSettings
    {
        /// <summary>
        /// Gets the DirectX device manager.
        /// </summary>
        /// <param name="value">
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetDirectxDeviceManager(
        ///   [out]  IMFDXGIDeviceManager **value
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3FD6EAD4-BC37-4AC9-BBDD-E7E2FBBCBCDE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3FD6EAD4-BC37-4AC9-BBDD-E7E2FBBCBCDE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetDirectxDeviceManager(
            out IMFDXGIDeviceManager value
            );


        /// <summary>
        /// <i>***** Documentation Missing *****</i>.
        /// </summary>
        /// <param name="value"><i>***** Documentation Missing *****</i>.</param>
        /// <returns><i>***** Documentation Missing *****</i>.</returns>
        // BUG-BUG: Nowhere does this method appear in the header files !!!!
        [Obsolete("Don't use !!!! Nowhere does this method appear in the header files !!!!")]
        [PreserveSig]
        int SetDirectCompositionVisual(
            [MarshalAs(UnmanagedType.IUnknown)] object value
            );

        /// <summary>
        /// <i>***** Documentation Missing *****</i>.
        /// </summary>
        /// <param name="pSrcNormalizedTop"><i>***** Documentation Missing *****</i>.</param>
        /// <param name="pSrcNormalizedBottom"><i>***** Documentation Missing *****</i>.</param>
        /// <param name="pSrcNormalizedRight"><i>***** Documentation Missing *****</i>.</param>
        /// <param name="pSrcNormalizedLeft"><i>***** Documentation Missing *****</i>.</param>
        /// <param name="pDstSize"><i>***** Documentation Missing *****</i>.</param>
        /// <param name="pBorderClr"><i>***** Documentation Missing *****</i>.</param>
        /// <returns><i>***** Documentation Missing *****</i>.</returns>
        // BUG-BUG: Nowhere does this method appear in the header files !!!!
        [Obsolete("Don't use !!!! Nowhere does this method appear in the header files !!!!")]
        [PreserveSig]
        int UpdateVideo(
             [In] MfFloat pSrcNormalizedTop,
             [In] MfFloat pSrcNormalizedBottom,
             [In] MfFloat pSrcNormalizedRight,
             [In] MfFloat pSrcNormalizedLeft,
             [In] MFRect pDstSize,
             [In] MFInt pBorderClr
            );
    }

#endif

}
