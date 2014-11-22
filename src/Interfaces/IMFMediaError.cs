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
using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Provides the current error status for the Media Engine.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/08F161FE-C0E5-44EE-923E-646ADA534C42(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/08F161FE-C0E5-44EE-923E-646ADA534C42(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("fc0e10d2-ab2a-4501-a951-06bb1075184c"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaError
    {
        /// <summary>
        /// Gets the error code.
        /// </summary>
        /// <returns>
        /// Returns a value from the <see cref="MF_MEDIA_ENGINE_ERR"/> enumeration. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// USHORT GetErrorCode();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6E4C4559-F59C-488C-A790-D95831BC9D29(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6E4C4559-F59C-488C-A790-D95831BC9D29(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        MF_MEDIA_ENGINE_ERR GetErrorCode();

        /// <summary>
        /// Gets the extended error code.
        /// </summary>
        /// <returns>
        /// Returns an <strong>HRESULT</strong> value that gives additional information about the last error. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetExtendedErrorCode();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/73B414F2-F17E-418E-9F8B-A7C378F80090(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/73B414F2-F17E-418E-9F8B-A7C378F80090(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetExtendedErrorCode();

        /// <summary>
        /// Sets the error code.
        /// </summary>
        /// <param name="error">
        /// The error code, specified as an <see cref="MF_MEDIA_ENGINE_ERR"/> value. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetErrorCode(
        ///   [in]  MF_MEDIA_ENGINE_ERR error
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0CEFC8A5-CCEA-43CF-80AB-C9862B0DAEDA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0CEFC8A5-CCEA-43CF-80AB-C9862B0DAEDA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetErrorCode(
            MF_MEDIA_ENGINE_ERR error
            );

        /// <summary>
        /// Sets the extended error code.
        /// </summary>
        /// <param name="error">
        /// An <strong>HRESULT</strong> value that gives additional information about the last error. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetExtendedErrorCode(
        ///   [in]  HRESULT error
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F3B52C1A-E235-492D-93C2-393FF2321B7E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F3B52C1A-E235-492D-93C2-393FF2321B7E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetExtendedErrorCode(
            int error
            );
    }

#endif

}
