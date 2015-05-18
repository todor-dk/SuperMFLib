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
    /// Enables the <strong>PlayToConnection</strong> object to connect to a media element. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/53355EEA-559B-4803-89F6-D454E15F9254(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/53355EEA-559B-4803-89F6-D454E15F9254(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("607574EB-F4B6-45C1-B08C-CB715122901D"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IPlayToControl
    {
        /// <summary>
        /// Connects the media element to the media sharing engine.
        /// </summary>
        /// <param name="pFactory">
        /// A pointer to the <see cref="IMFSharingEngineClassFactory"/> interface. The media element uses this
        /// interface to create the Sharing Engine. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Connect(
        ///   [in]  IMFSharingEngineClassFactory *pFactory
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5252DC51-E1EF-4A61-A2BD-682F51DC219B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5252DC51-E1EF-4A61-A2BD-682F51DC219B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Connect(
            IMFSharingEngineClassFactory pFactory
            );

        /// <summary>
        /// Disconnects the media element from the media sharing engine.
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Disconnect();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/59EA778D-25DA-4EEA-8601-F6D72486410B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/59EA778D-25DA-4EEA-8601-F6D72486410B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Disconnect();
    }

#endif

}
