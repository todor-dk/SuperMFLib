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

namespace MediaFoundation.Core.Interfaces
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Creates an instance of the media sharing engine.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/191CB50C-8CBB-470F-B558-F3A9EE554DA3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/191CB50C-8CBB-470F-B558-F3A9EE554DA3(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("2BA61F92-8305-413B-9733-FAF15F259384"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFSharingEngineClassFactory
    {
        /// <summary>
        /// Creates an instance of the media sharing engine.
        /// </summary>
        /// <param name="dwFlags">
        /// A bitwise <strong>OR</strong> of zero or more flags from the 
        /// <see cref="MF_MEDIA_ENGINE_CREATEFLAGS"/> enumeration. 
        /// </param>
        /// <param name="pAttr">
        /// A pointer to the <see cref="IMFAttributes"/> interface. This parameter specifies configuration
        /// attributes; see <c>Media Engine Attributes</c>. 
        /// </param>
        /// <param name="ppEngine">
        /// Receives a pointer to the <c>IUnknown</c> interface of the media sharing engine. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT CreateInstance(
        ///   [in]   DWORD dwFlags,
        ///   [in]   IMFAttributes *pAttr,
        ///   [out]  IUnknown **ppEngine
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8410FA9C-22C1-412D-90ED-55F19F21B8BD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8410FA9C-22C1-412D-90ED-55F19F21B8BD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateInstance(
            MF_MEDIA_ENGINE_CREATEFLAGS dwFlags,
            IMFAttributes pAttr,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppEngine
            );
    }

#endif

}
