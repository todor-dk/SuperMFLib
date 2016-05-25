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

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation.Core.Interfaces
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Controls how media sources and transforms are enumerated in Microsoft Media Foundation.
    /// <para/>
    /// This interface extends the <see cref="IMFPluginControl"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/15BD57FC-7CEF-45DC-AF94-3E54A3A9477A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/15BD57FC-7CEF-45DC-AF94-3E54A3A9477A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("C6982083-3DDC-45CB-AF5E-0F7A8CE4DE77"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFPluginControl2 : IMFPluginControl
    {
        /// <summary>
        /// Sets the policy for which media sources and transforms are enumerated.
        /// </summary>
        /// <param name="policy">
        /// A value from the <see cref="MF_PLUGIN_CONTROL_POLICY"/> enumeration that specifies the policy. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetPolicy(
        ///   [in]  MF_PLUGIN_CONTROL_POLICY policy
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1B078EB2-D87E-46A4-B2E1-A850C4E543A8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1B078EB2-D87E-46A4-B2E1-A850C4E543A8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetPolicy(
            MF_PLUGIN_CONTROL_POLICY policy
        );
    }

#endif

}
