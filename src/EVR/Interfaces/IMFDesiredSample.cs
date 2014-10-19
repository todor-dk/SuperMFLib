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
using System.Runtime.InteropServices;

using MediaFoundation;
using MediaFoundation.Misc;
using MediaFoundation.Transform;
using System.Drawing;

namespace MediaFoundation.EVR
{


    /// <summary>
    /// Enables the presenter for the enhanced video renderer (EVR) to request a specific frame from the
    /// video mixer.
    /// <para/>
    /// The sample objects created by the <see cref="MFExtern.MFCreateVideoSampleFromSurface"/> function
    /// implement this interface. To retrieve a pointer to this interface, call <strong>QueryInterface
    /// </strong> on the sample. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/373C076C-6329-4332-9F07-F18A01197659(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/373C076C-6329-4332-9F07-F18A01197659(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("56C294D0-753E-4260-8D61-A3D8820B1D54"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFDesiredSample
    {
        /// <summary>
        /// Called by the mixer to get the time and duration of the sample requested by the presenter.
        /// </summary>
        /// <param name="phnsSampleTime">
        /// Receives the desired sample time that should be mixed.
        /// </param>
        /// <param name="phnsSampleDuration">
        /// Receives the sample duration that should be mixed.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_NOT_AVAILABLE</strong></term><description>No time stamp was set for this sample. See <see cref="EVR.IMFDesiredSample.Clear"/>. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetDesiredSampleTimeAndDuration(
        ///   [out]  LONGLONG *phnsSampleTime,
        ///   [out]  LONGLONG *phnsSampleDuration
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/095202ED-0272-4BDA-A268-6A407EF74A94(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/095202ED-0272-4BDA-A268-6A407EF74A94(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetDesiredSampleTimeAndDuration(
            out long phnsSampleTime,
            out long phnsSampleDuration
            );

        /// <summary>
        /// Called by the presenter to set the time and duration of the sample that it requests from the mixer.
        /// </summary>
        /// <param name="hnsSampleTime">
        /// The time of the requested sample.
        /// </param>
        /// <param name="hnsSampleDuration">
        /// The duration of the requested sample.
        /// </param>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// void SetDesiredSampleTimeAndDuration(
        ///   [in]  LONGLONG hnsSampleTime,
        ///   [in]  LONGLONG hnsSampleDuration
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/12877B24-83EC-4156-B411-F07202FDFD62(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/12877B24-83EC-4156-B411-F07202FDFD62(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        void SetDesiredSampleTimeAndDuration(
            [In] long hnsSampleTime,
            [In] long hnsSampleDuration
            );

        /// <summary>
        /// Clears the time stamps previously set by a call to 
        /// <see cref="EVR.IMFDesiredSample.SetDesiredSampleTimeAndDuration"/>. 
        /// </summary>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// void Clear();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D5C6C1C2-C122-47B6-82B3-28B54BAFC7B8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D5C6C1C2-C122-47B6-82B3-28B54BAFC7B8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        void Clear();
    }

}
