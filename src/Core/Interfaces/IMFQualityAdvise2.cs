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
    /// Enables a pipeline object to adjust its own audio or video quality, in response to quality
    /// messages.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/C6114BBC-31D8-45EB-9BF8-745B3138DD50(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C6114BBC-31D8-45EB-9BF8-745B3138DD50(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("F3706F0D-8EA2-4886-8000-7155E9EC2EAE")]
    internal interface IMFQualityAdvise2 : IMFQualityAdvise
    {
        #region IMFQualityAdvise methods

        /// <summary>
        /// Sets the drop mode. In drop mode, a component drops samples, more or less aggressively depending on
        /// the level of the drop mode.
        /// </summary>
        /// <param name="eDropMode">Requested drop mode, specified as a member of the <see cref="MFQualityDropMode" /> enumeration.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_NO_MORE_DROP_MODES</strong></term><description>The component does not support the specified mode or any higher modes.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetDropMode(
        /// [in]  MF_QUALITY_DROP_MODE eDropMode
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/190DE66A-6C47-49D5-A8F6-C2FB57A7AEE2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/190DE66A-6C47-49D5-A8F6-C2FB57A7AEE2(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetDropMode(
            [In] MFQualityDropMode eDropMode
            );

        /// <summary>
        /// Sets the quality level. The quality level determines how the component consumes or produces
        /// samples.
        /// </summary>
        /// <param name="eQualityLevel">Requested quality level, specified as a member of the <see cref="MFQualityLevel" /> enumeration.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_NO_MORE_QUALITY_LEVELS</strong></term><description>The component does not support the specified quality level or any levels below it.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetQualityLevel(
        /// [in]  MF_QUALITY_LEVEL eQualityLevel
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/F788FD7D-65FC-4917-8D5D-CFAF35A013E7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F788FD7D-65FC-4917-8D5D-CFAF35A013E7(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetQualityLevel(
            [In] MFQualityLevel eQualityLevel
            );

        /// <summary>
        /// Retrieves the current drop mode.
        /// </summary>
        /// <param name="peDropMode">Receives the drop mode, specified as a member of the <see cref="MFQualityDropMode" /> enumeration.</param>
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
        /// HRESULT GetDropMode(
        /// [out]  MF_QUALITY_DROP_MODE *peDropMode
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/BB700A3E-837F-4E88-A9B7-294C41143402(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BB700A3E-837F-4E88-A9B7-294C41143402(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetDropMode(
            out MFQualityDropMode peDropMode
            );

        /// <summary>
        /// Retrieves the current quality level.
        /// </summary>
        /// <param name="peQualityLevel">Receives the quality level, specified as a member of the <see cref="MFQualityLevel" /> enumeration.</param>
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
        /// HRESULT GetQualityLevel(
        /// [out]  MF_QUALITY_LEVEL *peQualityLevel
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/9A2B501E-543D-4BA0-86A1-A55E7D136685(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9A2B501E-543D-4BA0-86A1-A55E7D136685(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetQualityLevel(
            out MFQualityLevel peQualityLevel
            );

        /// <summary>
        /// Drops samples over a specified interval of time.
        /// </summary>
        /// <param name="hnsAmountToDrop">Amount of time to drop, in 100-nanosecond units. This value is always absolute. If the method is
        /// called multiple times, do not add the times from previous calls.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_DROPTIME_NOT_SUPPORTED</strong></term><description>The object does not support this method.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT DropTime(
        /// [in]  LONGLONG hnsAmountToDrop
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/60D27190-7BED-427C-9018-2926C85815FE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/60D27190-7BED-427C-9018-2926C85815FE(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int DropTime(
            [In] long hnsAmountToDrop
            );

        #endregion

        /// <summary>
        /// Forwards an <c>MEQualityNotify</c> event from the media sink. 
        /// </summary>
        /// <param name="pEvent">
        /// A pointer to the event's <see cref="IMFMediaEvent"/> interface. 
        /// </param>
        /// <param name="pdwFlags">
        /// Receives a bitwise <strong>OR</strong> of zero or more flags from the 
        /// <see cref="MFQualityAdviseFlags"/> enumeration. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT NotifyQualityEvent(
        ///   [in]   IMFMediaEvent *pEvent,
        ///   [out]  DWORD *pdwFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7E39D421-1E7C-4B6D-BEBA-E24429271378(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7E39D421-1E7C-4B6D-BEBA-E24429271378(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int NotifyQualityEvent(
            IMFMediaEvent pEvent,
            out MFQualityAdviseFlags pdwFlags
        );
    }

#endif

}
