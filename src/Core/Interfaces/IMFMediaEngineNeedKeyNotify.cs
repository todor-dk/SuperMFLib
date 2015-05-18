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
    /// Represents a callback to the media engine to notify key request data.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BBEDFBE8-9389-4B4F-8D52-111C787A6268(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BBEDFBE8-9389-4B4F-8D52-111C787A6268(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("46a30204-a696-4b18-8804-246b8f031bb1"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFMediaEngineNeedKeyNotify
    {
        /// <summary>
        /// Notifies the application that a key or keys are needed along with any initialization data.
        /// </summary>
        /// <param name="initData">
        /// The initialization data.
        /// </param>
        /// <param name="cb">
        /// The count in bytes of <em>initData</em>. 
        /// </param>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// void NeedKey(
        ///   const BYTE *initData,
        ///   DWORD cb
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2B9A64D6-1A0F-4375-973A-42734AC5658E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2B9A64D6-1A0F-4375-973A-42734AC5658E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        void NeedKey(
           IntPtr initData,
           int cb
           );
    }

#endif
}
