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
using MediaFoundation.EVR;

namespace MediaFoundation.Core.Interfaces
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Creates an instance of the capture engine.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FAFA52AD-B96E-4ADC-BE79-3BE5F1ACC92A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FAFA52AD-B96E-4ADC-BE79-3BE5F1ACC92A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("8f02d140-56fc-4302-a705-3a97c78be779"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFCaptureEngineClassFactory
    {
        /// <summary>
        /// Creates an instance of the capture engine.
        /// </summary>
        /// <param name="clsid">
        /// The CLSID of the object to create. Currently, this parameter must equal <strong>
        /// CLSID_MFCaptureEngine</strong>. 
        /// </param>
        /// <param name="riid">
        /// The IID of the requested interface. The capture engine supports the <see cref="IMFCaptureEngine"/>
        /// interface. 
        /// </param>
        /// <param name="ppvObject">
        /// Receives a pointer to the requested interface. The caller must release the interface.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT CreateInstance(
        ///   [in]   REFCLSID clsid,
        ///   [in]   REFIID riid,
        ///   [out]  LPVOID *ppvObject
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D5E7D96B-9438-4332-AD05-249D2DA2481A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D5E7D96B-9438-4332-AD05-249D2DA2481A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateInstance(
                [In, MarshalAs(UnmanagedType.LPStruct)] Guid clsid,
                [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
                [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject
                );

    }

#endif

}
