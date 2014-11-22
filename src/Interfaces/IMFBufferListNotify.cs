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
    /// Enables <see cref="IMFSourceBufferList"/> object to notify its clients of important state changes.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280674(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn280674(v=vs.85).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("24cd47f7-81d8-4785-adb2-af697a963cd2"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFBufferListNotify
    {
        /// <summary>
        /// Indicates that a <see cref="IMFSourceBuffer"/> has been added.
        /// </summary>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// void OnAddSourceBuffer();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280675(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn280675(v=vs.85).aspx</a>
        /// </remarks>
        [PreserveSig]
        void OnAddSourceBuffer();

        /// <summary>
        /// Indicates that a <see cref="IMFSourceBuffer"/> has been removed.
        /// </summary>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// void OnRemoveSourceBuffer();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280676(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn280676(v=vs.85).aspx</a>
        /// </remarks>
        [PreserveSig]
        void OnRemoveSourceBuffer();
    }

#endif
}
