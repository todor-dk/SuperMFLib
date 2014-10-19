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

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Configures the DirectShow <c>Enhanced Video Renderer</c> (EVR) filter. To get a pointer to this
    /// interface, call <strong>QueryInterface</strong> on the EVR filter. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BBE85DC1-AF9C-4BE7-9064-D61BBA160942(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BBE85DC1-AF9C-4BE7-9064-D61BBA160942(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("AEA36028-796D-454F-BEEE-B48071E24304")]
    public interface IEVRFilterConfigEx : IEVRFilterConfig
    {
        #region IEVRFilterConfig methods

        /// <summary>
        /// Sets the number of input pins on the EVR filter.
        /// </summary>
        /// <param name="dwMaxStreams">Specifies the total number of input pins on the EVR filter. This value includes the input pin for
        /// the reference stream, which is created by default. For example, to mix one substream plus the
        /// reference stream, set this parameter to 2.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>Invalid number of streams. The minimum is one, and the maximum is 16.</description></item>
        /// <item><term><strong>VFW_E_WRONG_STATE</strong></term><description>This method has already been called, or at least one pin is already connected.</description></item>
        /// </list>
        /// </returns>
        /// <remarks><strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetNumberOfStreams(
        /// [in]  DWORD dwMaxStreams
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/72777C3D-B098-43B9-80EA-EF180B7F1A4A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/72777C3D-B098-43B9-80EA-EF180B7F1A4A(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetNumberOfStreams(
            [In] int dwMaxStreams
        );

        /// <summary>
        /// Retrieves the number of input pins on the EVR filter. The EVR filter always has at least one input
        /// pin, which corresponds to the reference stream.
        /// </summary>
        /// <param name="pdwMaxStreams">Receives the number of streams.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks><strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetNumberOfStreams(
        /// [out]  DWORD *pdwMaxStreams
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/94E15032-EFB6-4919-B018-953EEE803135(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/94E15032-EFB6-4919-B018-953EEE803135(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetNumberOfStreams(
            out int pdwMaxStreams
        );

        #endregion

        /// <summary>
        /// Sets the configuration parameters for the Microsoft DirectShow 
        /// <c>Enhanced Video Renderer Filter</c> (EVR). 
        /// </summary>
        /// <param name="dwConfigFlags">
        /// Bitwise <strong>OR</strong> of zero or more flags from the <see cref="EVR.EVRFilterConfigPrefs"/>
        /// enumeration. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>Invalid argument.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetConfigPrefs(
        ///   [in]  DWORD dwConfigFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6A565C7A-A8D7-433B-B454-262661C2C084(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6A565C7A-A8D7-433B-B454-262661C2C084(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetConfigPrefs(
            [In] EVRFilterConfigPrefs dwConfigFlags
        );

        /// <summary>
        /// Gets the configuration parameters for the Microsoft DirectShow 
        /// <c>Enhanced Video Renderer Filter</c> filter. 
        /// </summary>
        /// <param name="pdwConfigFlags">
        /// Receives a bitwise <strong>OR</strong> of flags from the <see cref="EVR.EVRFilterConfigPrefs"/>
        /// enumeration. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetConfigPrefs(
        ///   [out]  DWORD *pdwConfigFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8B286B77-DE5F-44CE-82F4-D11A76FE2C4D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8B286B77-DE5F-44CE-82F4-D11A76FE2C4D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetConfigPrefs(
            out EVRFilterConfigPrefs pdwConfigFlags
        );
    }

#endif

}
