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

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Controls how a byte stream buffers data from a network. 
    /// <para/>
    /// To get a pointer to this interface, call <strong>QueryInterface</strong> on the byte stream object.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BBF9CDB1-5EC7-498A-AA59-85C24779547E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BBF9CDB1-5EC7-498A-AA59-85C24779547E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("6D66D782-1D4F-4DB7-8C63-CB8C77F1EF5E"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFByteStreamBuffering
    {
        /// <summary>
        /// Sets the buffering parameters.
        /// </summary>
        /// <param name="pParams">
        /// Pointer to an <see cref="MFByteStreamBufferingParams"/> structure that contains the buffering
        /// parameters. The byte stream uses this information to calculate how much data to buffer from the
        /// network. 
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
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetBufferingParams(
        ///   [in]  MFBYTESTREAM_BUFFERING_PARAMS *pParams
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/033EA7D4-D669-497B-BE37-A8C9A6584209(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/033EA7D4-D669-497B-BE37-A8C9A6584209(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetBufferingParams(
            [In] ref MFByteStreamBufferingParams pParams
            );

        /// <summary>
        /// Enables or disables buffering.
        /// </summary>
        /// <param name="fEnable">
        /// Specifies whether the byte stream buffers data. If <strong>TRUE</strong>, buffering is enabled. If 
        /// <strong>FALSE</strong>, buffering is disabled. 
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
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT EnableBuffering(
        ///   [in]  BOOL fEnable
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5F7418FF-32E5-49B3-B7B3-6686E6562D51(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5F7418FF-32E5-49B3-B7B3-6686E6562D51(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EnableBuffering(
            [In] int fEnable
            );

        /// <summary>
        /// Stops any buffering that is in progress.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The byte stream successfully stopped buffering.</description></item>
        /// <item><term><strong>S_FALSE</strong></term><description>No buffering was in progress.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT StopBuffering();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DA342AC4-BB61-40D6-9B67-0480AC2A780F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DA342AC4-BB61-40D6-9B67-0480AC2A780F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int StopBuffering();
    }

#endif

}
