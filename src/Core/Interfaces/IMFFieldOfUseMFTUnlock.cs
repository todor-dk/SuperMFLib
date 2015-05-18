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

namespace MediaFoundation.Core.Interfaces
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Enables an application to use a Media Foundation transform (MFT) that has restrictions on its use.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/B144589B-D559-4686-B617-0E3C393380E9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B144589B-D559-4686-B617-0E3C393380E9(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("508E71D3-EC66-4FC3-8775-B4B9ED6BA847")]
    internal interface IMFFieldOfUseMFTUnlock
    {
        /// <summary>
        /// Unlocks a Media Foundation transform (MFT) so that the application can use it.
        /// </summary>
        /// <param name="pUnkMFT">
        /// A pointer to the <strong>IUnknown</strong> interface of the MFT. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Unlock(
        ///   [in]  IUnknown *pUnkMFT
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/54B15E72-6551-4162-90CA-A9BED68CA62F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/54B15E72-6551-4162-90CA-A9BED68CA62F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Unlock(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnkMFT
        );
    }

#endif

}
