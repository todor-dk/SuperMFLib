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
    /// Provides a timer that invokes a callback at a specified time.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/152594DF-DE3D-4F6F-9277-DBA95AB3533A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/152594DF-DE3D-4F6F-9277-DBA95AB3533A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("E56E4CBD-8F70-49D8-A0F8-EDB3D6AB9BF2"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFTimer
    {
        /// <summary>
        /// Sets a timer that invokes a callback at the specified time.
        /// </summary>
        /// <param name="dwFlags">
        /// Bitwise OR of zero or more flags from the <see cref="MFTimeFlags"/> enumeration. 
        /// </param>
        /// <param name="llClockTime">
        /// The time at which the timer should fire, in units of the clock's frequency. The time is either
        /// absolute or relative to the current time, depending on the value of <em>dwFlags</em>. 
        /// </param>
        /// <param name="pCallback">
        /// Pointer to the <see cref="IMFAsyncCallback"/> interface of a callback object. The caller must
        /// implement this interface. The callback's <c>Invoke</c> method is called at the time specified in
        /// the <em>llClockTime</em> parameter. 
        /// </param>
        /// <param name="pUnkState">The p unk state.</param>
        /// <param name="ppunkKey">
        /// Receives a pointer to the <strong>IUnknown</strong> interface of a cancellation object. The caller
        /// must release the interface. To cancel the timer, pass this pointer to the 
        /// <see cref="IMFTimer.CancelTimer"/> method. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The clock was shut down.</description></item>
        /// <item><term><strong>MF_S_CLOCK_STOPPED</strong></term><description>The method succeeded, but the clock is stopped.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetTimer(
        ///   [in]   DWORD dwFlags,
        ///   [in]   LONGLONG llClockTime,
        ///   [in]   IMFAsyncCallback *pCallback,
        ///   [in]   IUnknown *punkState,
        ///   [out]  IUnknown **ppunkKey
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3B583541-6480-490D-883F-376EA95F7A98(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3B583541-6480-490D-883F-376EA95F7A98(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetTimer(
            [In] MFTimeFlags dwFlags,
            [In] long llClockTime,
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnkState,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppunkKey
            );

        /// <summary>
        /// Cancels a timer that was set using the <see cref="IMFTimer.SetTimer"/> method. 
        /// </summary>
        /// <param name="punkKey">
        /// Pointer to the <strong>IUnknown</strong> interface that was returned in the <em>ppunkKey</em>
        /// parameter of the <c>SetTimer</c> method. 
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
        /// HRESULT CancelTimer(
        ///   [in]  IUnknown *punkKey
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3FA65809-1652-4903-92AD-1034BCDF0743(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3FA65809-1652-4903-92AD-1034BCDF0743(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CancelTimer(
            [In, MarshalAs(UnmanagedType.IUnknown)] object punkKey
            );
    }

}
