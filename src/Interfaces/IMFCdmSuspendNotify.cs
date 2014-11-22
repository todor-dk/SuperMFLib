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
    /// Used to enable the client to notify the Content Decryption Module (CDM) 
    /// when global resources should be brought into a consistent state prior to suspending. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280681(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn280681(v=vs.85).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("7a5645d2-43bd-47fd-87b7-dcd24cc7d692"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFCdmSuspendNotify
    {
        /// <summary>
        /// Indicates that the suspend process is starting and resources should be brought into a consistent state. 
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT</strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Begin();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280682(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn280682(v=vs.85).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Begin();

        /// <summary>
        /// The actual suspend is about to occur and no more calls will be made into the Content Decryption Module (CDM).
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT</strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT End();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280683(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn280683(v=vs.85).aspx</a>
        /// </remarks>
        [PreserveSig]
        int End();
    }

#endif
}
