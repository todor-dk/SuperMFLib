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
    /// Represents a collection of <c>IMFSourceBuffer</c> objects. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/26F66C2D-5F84-485F-BC86-C8399666C9F1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/26F66C2D-5F84-485F-BC86-C8399666C9F1(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("249981f8-8325-41f3-b80c-3b9e3aad0cbe"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFSourceBufferList
    {
        /// <summary>
        /// Gets the number of <c>IMFSourceBuffer</c> objects in the list. 
        /// </summary>
        /// <returns>
        /// The number of source buffers in the list.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// DWORD GetLength();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/551D2F40-85AD-45AF-9191-9FB2B2C44913(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/551D2F40-85AD-45AF-9191-9FB2B2C44913(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetLength();

        /// <summary>
        /// Gets the <c>IMFSourceBuffer</c> at the specified index in the list. 
        /// </summary>
        /// <param name="index">
        /// The index of the source buffer to get.
        /// </param>
        /// <returns>
        /// The source buffer.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// IMFSourceBuffer GetSourceBuffer(
        ///   [in]  DWORD index
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7F756C2E-79D0-400B-A84A-BC0E268F4F5B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7F756C2E-79D0-400B-A84A-BC0E268F4F5B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        IMFSourceBuffer GetSourceBuffer(
            int index
            );
    }

#endif
}
