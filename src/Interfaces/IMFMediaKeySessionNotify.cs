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
    /// Provides a mechanism for notifying the app about information regarding the media key session. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D28C16A8-4A74-40C3-BE95-FF7E4B1CDC09(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D28C16A8-4A74-40C3-BE95-FF7E4B1CDC09(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("6a0083f9-8947-4c1d-9ce0-cdee22b23135"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaKeySessionNotify
    {
        /// <summary>
        /// Passes information to the application so it can initiate a key acquisition.
        /// </summary>
        /// <param name="destinationURL">
        /// The URL to send the message to.
        /// </param>
        /// <param name="message">
        /// The message to send to the application.
        /// </param>
        /// <param name="cb">
        /// The length in bytes of <em>message</em>. 
        /// </param>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// void KeyMessage(
        ///   BSTR destinationURL,
        ///   const BYTE *message,
        ///   DWORD cb
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/50B0EB38-A212-4C89-80E8-83472B3D45EE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/50B0EB38-A212-4C89-80E8-83472B3D45EE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        void KeyMessage(
           [MarshalAs(UnmanagedType.BStr)] string destinationURL,
           IntPtr message,
           int cb
           );

        /// <summary>
        /// Notifies the application that the key has been added. 
        /// </summary>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// void KeyAdded();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E61E2A0D-59A5-4776-BA07-D323F1C944A4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E61E2A0D-59A5-4776-BA07-D323F1C944A4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        void KeyAdded();

        /// <summary>
        /// Notifies the application that an error occurred while processing the key.
        /// </summary>
        /// <param name="code">
        /// </param>
        /// <param name="systemCode">
        /// </param>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// void KeyError(
        ///   USHORT code,
        ///   DWORD systemCode
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E437B46A-8B25-42C4-B307-B6962B60B452(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E437B46A-8B25-42C4-B307-B6962B60B452(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        void KeyError(
           short code,
           int systemCode
           );
    }

#endif
}
