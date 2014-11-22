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


    /// <summary>
    /// Provides timing information from a clock in Microsoft Media Foundation.
    /// <para/>
    /// Clocks and some media sinks expose this interface through <strong>QueryInterface</strong>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/3A60BFEC-8511-4A84-A833-E0C73C593970(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3A60BFEC-8511-4A84-A833-E0C73C593970(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("2EB1E945-18B8-4139-9B1A-D5D584818530")]
    public interface IMFClock
    {
        /// <summary>
        /// Retrieves the characteristics of the clock.
        /// </summary>
        /// <param name="pdwCharacteristics">
        /// Receives a bitwise OR of values from the <see cref="MFClockCharacteristicsFlags"/> enumeration
        /// indicating the characteristics of the clock. 
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
        /// HRESULT GetClockCharacteristics(
        ///   [out]  DWORD *pdwCharacteristics
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/50A81E8B-9AA8-484C-AFB7-950068FEEFC4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/50A81E8B-9AA8-484C-AFB7-950068FEEFC4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetClockCharacteristics(
            out MFClockCharacteristicsFlags pdwCharacteristics
            );

        /// <summary>
        /// Retrieves the last clock time that was correlated with system time. 
        /// </summary>
        /// <param name="dwReserved">
        /// Reserved, must be zero. 
        /// </param>
        /// <param name="pllClockTime">
        /// Receives the last known clock time, in units of the clock's frequency. 
        /// </param>
        /// <param name="phnsSystemTime">
        /// Receives the system time that corresponds to the clock time returned in <em>pllClockTime</em>, in
        /// 100-nanosecond units. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_CLOCK_NO_TIME_SOURCE</strong></term><description> The clock does not have a time source. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetCorrelatedTime(
        ///   [in]   DWORD dwReserved,
        ///   [out]  LONGLONG *pllClockTime,
        ///   [out]  MFTIME *phnsSystemTime
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0A897426-D994-4B27-9F13-9B0C7C9B3A9B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0A897426-D994-4B27-9F13-9B0C7C9B3A9B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetCorrelatedTime(
            [In] int dwReserved,
            out long pllClockTime,
            out long phnsSystemTime
            );

        /// <summary>
        /// Retrieves the clock's continuity key. (Not supported.)
        /// </summary>
        /// <param name="pdwContinuityKey">
        /// Receives the continuity key.
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
        /// HRESULT GetContinuityKey(
        ///   [out]  DWORD *pdwContinuityKey
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8AFDA8C7-BAB6-40FD-B20C-6BB29ED4900F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8AFDA8C7-BAB6-40FD-B20C-6BB29ED4900F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetContinuityKey(
            out int pdwContinuityKey
            );

        /// <summary>
        /// Retrieves the current state of the clock.
        /// </summary>
        /// <param name="dwReserved">
        /// Reserved, must be zero.
        /// </param>
        /// <param name="peClockState">
        /// Receives the clock state, as a member of the <see cref="MFClockState"/> enumeration. 
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
        /// HRESULT GetState(
        ///   [in]   DWORD dwReserved,
        ///   [out]  MFCLOCK_STATE *peClockState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8E2DDA03-F589-4572-B715-2BE7B29A6ACE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8E2DDA03-F589-4572-B715-2BE7B29A6ACE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetState(
            [In] int dwReserved,
            out MFClockState peClockState
            );

        /// <summary>
        /// Retrieves the properties of the clock.
        /// </summary>
        /// <param name="pClockProperties">
        /// Pointer to an <see cref="MFClockProperties"/> structure that receives the properties. 
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
        /// HRESULT GetProperties(
        ///   [out]  MFCLOCK_PROPERTIES *pClockProperties
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9DFC0EFC-D274-45A6-B1AB-30F6215FBED8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9DFC0EFC-D274-45A6-B1AB-30F6215FBED8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetProperties(
            out MFClockProperties pClockProperties
            );
    }

}
