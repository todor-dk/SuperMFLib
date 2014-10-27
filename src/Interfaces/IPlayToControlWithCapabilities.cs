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
    /// Provides functionality for the <c>IPlayToSource</c> to determine the capabilities of the content. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D670F320-30B5-4712-9192-D0976B65DD65(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D670F320-30B5-4712-9192-D0976B65DD65(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("AA9DD80F-C50A-4220-91C1-332287F82A34"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPlayToControlWithCapabilities : IPlayToControl
    {
        #region IPlayToControl methods

        /// <summary>
        /// Connects.
        /// </summary>
        /// <param name="pFactory">A pointer to the <see cref="IMFSharingEngineClassFactory" /> interface. The media element uses this
        /// interface to create the Sharing Engine.</param>
        /// <returns>System.Int32.</returns>
        /// <remarks><strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT Connect(
        /// [in]  IMFSharingEngineClassFactory *pFactory
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/5252DC51-E1EF-4A61-A2BD-682F51DC219B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5252DC51-E1EF-4A61-A2BD-682F51DC219B(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int Connect(
            IMFSharingEngineClassFactory pFactory
            );

        /// <summary>
        /// Disconnects.
        /// </summary>
        /// <returns>System.Int32.</returns>
        /// <remarks><strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT Disconnect();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/59EA778D-25DA-4EEA-8601-F6D72486410B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/59EA778D-25DA-4EEA-8601-F6D72486410B(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int Disconnect();

        #endregion

        /// <summary>
        /// Gets the capabilities information for the content.
        /// </summary>
        /// <param name="pCapabilities">
        /// The capabilities information for the content.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetCapabilities(
        ///   [out]  PLAYTO_SOURCE_CREATEFLAGS *pCapabilities
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/04D35AC6-AF8C-4E95-865B-54BBC7E36059(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/04D35AC6-AF8C-4E95-865B-54BBC7E36059(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetCapabilities(
            out PLAYTO_SOURCE_CREATEFLAGS pCapabilities
            );
    }

#endif
}
