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
    /// Creates an instance of the <see cref="IMFMediaKeys"/> object.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn449731(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn449731(v=vs.85).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("09083cef-867f-4bf6-8776-dee3a7b42fca"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaEngineClassFactory2
    {
        /// <summary>
        /// Creates a media keys object based on the specified key system.
        /// </summary>
        /// <param name="keySystem">
        /// The media key system.
        /// </param>
        /// <param name="defaultCdmStorePath">
        /// Points to the default file location for the store Content Decryption Module (CDM) data.
        /// </param>
        /// <param name="inprivateCdmStorePath">
        /// Points to a the inprivate location for the store Content Decryption Module (CDM) data. 
        /// Specifying this path allows the CDM to comply with the application’s privacy policy by 
        /// putting personal information in the file location indicated by this path.
        /// </param>
        /// <param name="ppKeys">
        /// Receives the media keys.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT</strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT CreateMediaKeys2(
        ///   [in]            BSTR keySystem,
        ///   [in]            BSTR defaultCdmStorePath,
        ///   [in, optional]  BSTR inprivateCdmStorePath,
        ///   [out]           IMFMediaKeys **ppKeys
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn449732(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn449732(v=vs.85).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateMediaKeys2(
            [MarshalAs(UnmanagedType.BStr)] string keySystem,
            [MarshalAs(UnmanagedType.BStr)] string defaultCdmStorePath,
            [MarshalAs(UnmanagedType.BStr)] string inprivateCdmStorePath,
            out IMFMediaKeys ppKeys
            );
    }

#endif
}
