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

// This file is a mess.  While technically part of MF, I'm in no hurry 
// to try to get this to work.

using System;
using System.Runtime.InteropServices;
using System.Security;

using MediaFoundation.Misc;

namespace MediaFoundation.Core.Interfaces
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Initializes the Digital Living Network Alliance (DLNA) media sink. 
    /// <para/>
    /// The DLNA media sink exposes this interface. To get a pointer to this interface, call <strong>
    /// CoCreateInstance</strong>. The CLSID is <strong>CLSID_MPEG2DLNASink</strong>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FEC2933A-AA1A-41E5-B697-FDAE548B3789(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FEC2933A-AA1A-41E5-B697-FDAE548B3789(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("0C012799-1B61-4C10-BDA9-04445BE5F561")]
    internal interface IMFDLNASinkInit
    {
        /// <summary>
        /// Initializes the Digital Living Network Alliance (DLNA) media sink.
        /// </summary>
        /// <param name="pByteStream">
        /// Pointer to a byte stream. The DLNA media sink writes data to this byte stream. The byte stream must
        /// be writable.
        /// </param>
        /// <param name="fPal">
        /// If <strong>TRUE</strong>, the DLNA media sink accepts PAL video formats. Otherwise, it accepts NTSC
        /// video formats. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_ALREADY_INITIALIZED</strong></strong></term><description>The method was already called.</description></item>
        /// <item><term><strong><strong>MF_E_SHUTDOWN</strong></strong></term><description>The media sink's <see cref="IMFMediaSink.Shutdown"/> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Initialize(
        ///   [in]  IMFByteStream *pByteStream,
        ///   [in]  BOOL fPal
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/48C3842C-7D88-4232-B882-363D9310FFE8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/48C3842C-7D88-4232-B882-363D9310FFE8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Initialize(
            IMFByteStream pByteStream,
            [MarshalAs(UnmanagedType.Bool)] bool fPal
        );
    }

#endif

}
