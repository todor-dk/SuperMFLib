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
    /// Provides functionality for raising events associated with <c>IMFMediaSourceExtension</c>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/44EED02D-CF92-41E5-8748-1CE11AB4AAC0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/44EED02D-CF92-41E5-8748-1CE11AB4AAC0(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("a7901327-05dd-4469-a7b7-0e01979e361d"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaSourceExtensionNotify
    {
        /// <summary>
        /// Used to indicate that the  media source has opened.
        /// </summary>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// void OnSourceOpen();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/45120ACF-48E1-4B4A-AF50-F6052ACDB533(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/45120ACF-48E1-4B4A-AF50-F6052ACDB533(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        void OnSourceOpen();

        /// <summary>
        /// Used to indicate that the media source has ended.
        /// </summary>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// void OnSourceEnded();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2CE65194-FB52-41E7-9CA4-D1E65FBBBEB0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2CE65194-FB52-41E7-9CA4-D1E65FBBBEB0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        void OnSourceEnded();

        /// <summary>
        /// Used to indicate that the media source has closed.
        /// </summary>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// void OnSourceClose();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D4199B4E-320F-47EC-8434-862FB1C1DB8D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D4199B4E-320F-47EC-8434-862FB1C1DB8D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        void OnSourceClose();
    }

#endif
}