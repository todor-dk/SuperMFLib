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

namespace MediaFoundation.Core.Interfaces
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Callback interface for the <see cref="IMFMediaEngine"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/85D702D4-3C9B-4848-81F2-3634C2B6AE1A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/85D702D4-3C9B-4848-81F2-3634C2B6AE1A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("fee7c112-e776-42b5-9bbf-0048524e2bd5"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFMediaEngineNotify
    {
        /// <summary>
        /// Notifies the application when a playback event occurs.
        /// </summary>
        /// <param name="eventid">The eventid.</param>
        /// <param name="param1">
        /// The first event parameter. The meaning of this parameter depends on the event code.
        /// </param>
        /// <param name="param2">
        /// The second event parameter. The meaning of this parameter depends on the event code.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT EventNotify(
        ///   [in]  DWORD event,
        ///   [in]  DWORD_PTR param1,
        ///   [in]  DWORD param2
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F6B9E025-53C4-4459-9EC4-EA228065FAD3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F6B9E025-53C4-4459-9EC4-EA228065FAD3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EventNotify(
            MF_MEDIA_ENGINE_EVENT eventid,
            IntPtr param1,
            int param2
            );
    }

#endif

}
