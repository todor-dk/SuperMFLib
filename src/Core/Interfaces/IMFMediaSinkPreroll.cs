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
    /// Enables a media sink to receive samples before the presentation clock is started.
    /// <para/>
    /// To get a pointer to this interface, call <strong>QueryInterface</strong> on the media sink. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/7CC93751-4477-4649-B09E-53F519FB1ACB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7CC93751-4477-4649-B09E-53F519FB1ACB(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("5DFD4B2A-7674-4110-A4E6-8A68FD5F3688"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFMediaSinkPreroll
    {
        /// <summary>
        /// Notifies the media sink that the presentation clock is about to start. 
        /// </summary>
        /// <param name="hnsUpcomingStartTime">
        /// The upcoming start time for the presentation clock, in 100-nanosecond units. This time is the same
        /// value that will be given to the <see cref="IMFPresentationClock.Start"/> method when the
        /// presentation clock is started. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT NotifyPreroll(
        ///   [in]  MFTIME hnsUpcomingStartTime
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D0694AD9-A18A-4FEA-A9FF-B416BD4827BA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D0694AD9-A18A-4FEA-A9FF-B416BD4827BA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int NotifyPreroll(
            [In] long hnsUpcomingStartTime
            );
    }

#endif

}
