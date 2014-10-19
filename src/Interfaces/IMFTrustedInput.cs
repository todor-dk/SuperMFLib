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
using MediaFoundation;
using System.Drawing;

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Implemented by components that provide input trust authorities (ITAs). This interface is used to
    /// get the ITA for each of the component's streams. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/59A9DEF7-69A6-4F80-BB5E-1CB372FF6EAB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/59A9DEF7-69A6-4F80-BB5E-1CB372FF6EAB(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("542612C4-A1B8-4632-B521-DE11EA64A0B0")]
    public interface IMFTrustedInput
    {
        /// <summary>
        /// Retrieves the input trust authority (ITA) for a specified stream.
        /// </summary>
        /// <param name="dwStreamID">
        /// The stream identifier for which the ITA is being requested.
        /// </param>
        /// <param name="riid">
        /// The interface identifier (IID) of the interface being requested. Currently the only supported value
        /// is IID_IMFInputTrustAuthority.
        /// </param>
        /// <param name="ppunkObject">
        /// Receives a pointer to the ITA's <strong>IUnknown</strong> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_NOINTERFACE</strong></term><description>The ITA does not expose the requested interface.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetInputTrustAuthority(
        ///   [in]   DWORD dwStreamID,
        ///   [in]   REFIID riid,
        ///   [out]  IUnknown **ppunkObject
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B4EBF02E-554A-4E7E-93D3-6F37D8B689BF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B4EBF02E-554A-4E7E-93D3-6F37D8B689BF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetInputTrustAuthority(
            [In] int dwStreamID,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppunkObject
            );
    }

#endif

}
