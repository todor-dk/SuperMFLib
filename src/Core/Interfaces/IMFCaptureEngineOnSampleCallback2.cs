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

namespace MediaFoundation.Core.Interfaces
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Extensions for the <see cref="IMFCaptureEngineOnSampleCallback"/> callback interface 
    /// that is used to receive data from the capture engine.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280677(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn280677(v=vs.85).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("e37ceed7-340f-4514-9f4d-9c2ae026100b")]
    internal interface IMFCaptureEngineOnSampleCallback2 : IMFCaptureEngineOnSampleCallback
    {
        #region IMFCaptureEngineOnSampleCallback methods

        /// <summary>
        /// Called when the capture sink receives a sample.
        /// </summary>
        /// <param name="pSample">
        /// A pointer to the <see cref="IMFSample"/> interface. Use this interface to get the time stamp,
        /// duration, and stream data. For more information, see <c>Media Samples</c>. This parameter can be 
        /// <strong>NULL</strong>, so make sure to check for a <strong>NULL</strong> value before you
        /// dereference the pointer. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnSample(
        ///   [in, optional]  IMFSample pSample
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/83FEFE33-DEAD-4CE0-9EEE-B8F3801ADC1C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/83FEFE33-DEAD-4CE0-9EEE-B8F3801ADC1C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int OnSample(
            IMFSample pSample
            );

        #endregion

        /// <summary>
        /// Called by the capture sink when the format of the sample is changed.
        /// </summary>
        /// <param name="pEvent">
        ///  The new media type.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT</strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnSynchronizedEvent(
        ///   [in]  IMFMediaEvent *pEvent
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280678(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn280678(v=vs.85).aspx</a>
        /// </remarks>
        [PreserveSig]
        int OnSynchronizedEvent(
            IMFMediaEvent pEvent
            );
    }
#endif
}
