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

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Creates an instance of the <c>PlayToSource</c> object. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/F8F9FEC6-836C-429A-BADD-5CD1E550AED0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F8F9FEC6-836C-429A-BADD-5CD1E550AED0(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("842B32A3-9B9B-4D1C-B3F3-49193248A554"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPlayToSourceClassFactory
    {
        /// <summary>
        /// Creates an instance of the <strong>PlayToController</strong> object. 
        /// </summary>
        /// <param name="dwFlags">
        /// A bitwise <strong>OR</strong> of flags from the <see cref="PLAYTO_SOURCE_CREATEFLAGS"/>
        /// enumeration. 
        /// </param>
        /// <param name="pControl">
        /// A pointer to the <see cref="IPlayToControl"/> interface. 
        /// </param>
        /// <param name="ppSource">The pp source.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT CreateInstance(
        ///   [in]   DWORD dwFlags,
        ///   [in]   IPlayToControl *pControl,
        ///   [out]  IInspectable **ppController
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3F7F8441-B0A2-407E-B127-C7DC66CA34DE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3F7F8441-B0A2-407E-B127-C7DC66CA34DE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateInstance(
            PLAYTO_SOURCE_CREATEFLAGS dwFlags,
            IPlayToControl pControl,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppSource
            );
    }

#endif

}
