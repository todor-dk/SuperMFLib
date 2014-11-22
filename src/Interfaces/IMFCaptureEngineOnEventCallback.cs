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
using MediaFoundation.EVR;

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Callback interface for receiving events from the capture engine.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/6F04F843-160C-4F49-9841-ECC1450F4A58(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6F04F843-160C-4F49-9841-ECC1450F4A58(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("aeda51c0-9025-4983-9012-de597b88b089"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFCaptureEngineOnEventCallback
    {
        /// <summary>
        /// Called by the capture engine to notify the application of a capture event.
        /// </summary>
        /// <param name="pEvent">
        /// A pointer to the <see cref="IMFMediaEvent"/> interface. Use this interface to get information about
        /// the event, as described in Remarks. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnEvent(
        ///   [in]  IMFMediaEvent *pEvent
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/26C5B2E5-0543-49FC-915A-DCE097FF66BA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/26C5B2E5-0543-49FC-915A-DCE097FF66BA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int OnEvent(
            IMFMediaEvent pEvent
            );
    }

#endif

}
