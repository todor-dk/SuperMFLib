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
#if NOT_IN_USE

    /// <summary>
    /// Gets or sets the playback rate. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/54303C32-B260-4364-9130-A592694F2816(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/54303C32-B260-4364-9130-A592694F2816(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("88DDCD21-03C3-4275-91ED-55EE3929328F"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFRateControl
    {
        /// <summary>
        /// Sets the playback rate. 
        /// </summary>
        /// <param name="fThin">
        /// If <strong>TRUE</strong>, the media streams are thinned. Otherwise, the stream is not thinned. For
        /// media sources and demultiplexers, the object must thin the streams when this parameter is <strong>
        /// TRUE</strong>. For downstream transforms, such as decoders and multiplexers, this parameter is
        /// informative; it notifies the object that the input streams are thinned. For information, see 
        /// <c>About Rate Control</c>. 
        /// </param>
        /// <param name="flRate">
        /// The requested playback rate. Postive values indicate forward playback, negative values indicate
        /// reverse playback, and zero indicates scrubbing (the source delivers a single frame). 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_REVERSE_UNSUPPORTED</strong></term><description> The object does not support reverse playback. </description></item>
        /// <item><term><strong>MF_E_THINNING_UNSUPPORTED</strong></term><description> The object does not support thinning. </description></item>
        /// <item><term><strong>MF_E_UNSUPPORTED_RATE</strong></term><description> The object does not support the requested playback rate. </description></item>
        /// <item><term><strong>MF_E_UNSUPPORTED_RATE_TRANSITION</strong></term><description> The object cannot change to the new rate while in the running state. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetRate(
        ///   [in]  BOOL fThin,
        ///   [in]  float flRate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/428D73FA-F284-4861-A41E-04EA7709DB0F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/428D73FA-F284-4861-A41E-04EA7709DB0F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetRate(
            [In, MarshalAs(UnmanagedType.Bool)] bool fThin,
            [In] float flRate
            );

        /// <summary>
        /// Gets the current playback rate.
        /// </summary>
        /// <param name="pfThin">
        /// Receives the value <strong>TRUE</strong> if the stream is currently being thinned. If the object
        /// does not support thinning, this parameter always receives the value <strong>FALSE</strong>. This
        /// parameter can be <strong>NULL</strong>. For more information, see <c>About Rate Control</c>. 
        /// </param>
        /// <param name="pflRate">
        /// Receives the current playback rate.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetRate(
        ///   [in, out]  BOOL *pfThin,
        ///   [in, out]  float *pflRate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FB970D06-0F82-4E35-8E03-68044C7F12CD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FB970D06-0F82-4E35-8E03-68044C7F12CD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetRate(
            [In, Out, MarshalAs(UnmanagedType.Bool)] ref bool pfThin,
            out float pflRate
            );
    }
#endif
}
