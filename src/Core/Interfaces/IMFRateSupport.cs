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
    /// Queries the range of playback rates that are supported, including reverse playback.
    /// <para/>
    /// To get a pointer to this interface, call <see cref="IMFGetService.GetService"/> with the service
    /// identifier MF_RATE_CONTROL_SERVICE. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A6C495FA-0F6A-4E4C-8FBA-996B22D55053(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A6C495FA-0F6A-4E4C-8FBA-996B22D55053(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("0A9CCDBC-D797-4563-9667-94EC5D79292D"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFRateSupport
    {
        /// <summary>
        /// Retrieves the slowest playback rate supported by the object.
        /// </summary>
        /// <param name="eDirection">
        /// Specifies whether to query to the slowest forward playback rate or reverse playback rate. The value
        /// is a member of the <see cref="MFRateDirection"/> enumeration. 
        /// </param>
        /// <param name="fThin">
        /// If <strong>TRUE</strong>, the method retrieves the slowest thinned playback rate. Otherwise, the
        /// method retrieves the slowest non-thinned playback rate. For information about thinning, see 
        /// <c>About Rate Control</c>. 
        /// </param>
        /// <param name="pflRate">
        /// Receives the slowest playback rate that the object supports.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_REVERSE_UNSUPPORTED</strong></term><description>The object does not support reverse playback.</description></item>
        /// <item><term><strong>MF_E_THINNING_UNSUPPORTED</strong></term><description>The object does not support thinning.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetSlowestRate(
        ///   [in]   MFRATE_DIRECTION eDirection,
        ///   [in]   BOOL fThin,
        ///   [out]  float *pflRate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E10125E9-8BC7-4FB6-8A10-BA5717F1596F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E10125E9-8BC7-4FB6-8A10-BA5717F1596F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetSlowestRate(
            [In] MFRateDirection eDirection,
            [In, MarshalAs(UnmanagedType.Bool)] bool fThin,
            out float pflRate
            );

        /// <summary>
        /// Gets the fastest playback rate supported by the object.
        /// </summary>
        /// <param name="eDirection">
        /// Specifies whether to query to the fastest forward playback rate or reverse playback rate. The value
        /// is a member of the <see cref="MFRateDirection"/> enumeration. 
        /// </param>
        /// <param name="fThin">
        /// If <strong>TRUE</strong>, the method retrieves the fastest thinned playback rate. Otherwise, the
        /// method retrieves the fastest non-thinned playback rate. For information about thinning, see 
        /// <c>About Rate Control</c>. 
        /// </param>
        /// <param name="pflRate">
        /// Receives the fastest playback rate that the object supports.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_REVERSE_UNSUPPORTED</strong></term><description>The object does not support reverse playback.</description></item>
        /// <item><term><strong>MF_E_THINNING_UNSUPPORTED</strong></term><description>The object does not support thinning.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetFastestRate(
        ///   [in]   MFRATE_DIRECTION eDirection,
        ///   [in]   BOOL fThin,
        ///   [out]  float *pflRate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/00413771-21CB-48A7-9080-2C3D195C366B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/00413771-21CB-48A7-9080-2C3D195C366B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetFastestRate(
            [In] MFRateDirection eDirection,
            [In, MarshalAs(UnmanagedType.Bool)] bool fThin,
            out float pflRate
            );

        /// <summary>
        /// Queries whether the object supports a specified playback rate.
        /// </summary>
        /// <param name="fThin">
        /// If <strong>TRUE</strong>, the method queries whether the object supports the playback rate with
        /// thinning. Otherwise, the method queries whether the object supports the playback rate without
        /// thinning. For information about thinning, see <c>About Rate Control</c>. 
        /// </param>
        /// <param name="flRate">
        /// The playback rate to query.
        /// </param>
        /// <param name="pflNearestSupportedRate">
        /// If the object does not support the playback rate given in <em>flRate</em>, this parameter receives
        /// the closest supported playback rate. If the method returns S_OK, this parameter receives the value
        /// given in <em>flRate</em>. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The object supports the specified rate.</description></item>
        /// <item><term><strong>MF_E_REVERSE_UNSUPPORTED</strong></term><description>The object does not support reverse playback.</description></item>
        /// <item><term><strong>MF_E_THINNING_UNSUPPORTED</strong></term><description>The object does not support thinning.</description></item>
        /// <item><term><strong>MF_E_UNSUPPORTED_RATE</strong></term><description>The object does not support the specified rate.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT IsRateSupported(
        ///   [in]       BOOL fThin,
        ///   [in]       float flRate,
        ///   [in, out]  float *pflNearestSupportedRate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3AC04683-17D3-4D87-B260-39B04EAB9E59(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3AC04683-17D3-4D87-B260-39B04EAB9E59(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int IsRateSupported(
            [In, MarshalAs(UnmanagedType.Bool)] bool fThin,
            [In] float flRate,
            [In, Out] MfFloat pflNearestSupportedRate
            );
    }

#endif
}
