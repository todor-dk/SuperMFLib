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

namespace MediaFoundation.EVR.Interfaces
{
#if NOT_IN_USE

    /// <summary>
    /// Sets the number of input pins on the DirectShow <c>Enhanced Video Renderer</c> (EVR) filter. To get
    /// a pointer to this interface, call <strong>QueryInterface</strong> on the DirectShow EVR filter. 
    /// </summary>
    /// <remarks>
    /// The above documentation is � Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/13086D85-3DBF-4E9F-B065-D95E16412832(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/13086D85-3DBF-4E9F-B065-D95E16412832(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("83E91E85-82C1-4ea7-801D-85DC50B75086")]
    internal interface IEVRFilterConfig
    {
        /// <summary>
        /// Sets the number of input pins on the EVR filter.
        /// </summary>
        /// <param name="dwMaxStreams">
        /// Specifies the total number of input pins on the EVR filter. This value includes the input pin for
        /// the reference stream, which is created by default. For example, to mix one substream plus the
        /// reference stream, set this parameter to 2.
        /// </param>
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
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetNumberOfStreams(
        ///   [in]��DWORD dwMaxStreams
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is � Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/72777C3D-B098-43B9-80EA-EF180B7F1A4A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/72777C3D-B098-43B9-80EA-EF180B7F1A4A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetNumberOfStreams(
            int dwMaxStreams
            );

        /// <summary>
        /// Retrieves the number of input pins on the EVR filter. The EVR filter always has at least one input
        /// pin, which corresponds to the reference stream.
        /// </summary>
        /// <param name="pdwMaxStreams">
        /// Receives the number of streams.
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
        /// HRESULT GetNumberOfStreams(
        ///   [out]��DWORD *pdwMaxStreams
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is � Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/94E15032-EFB6-4919-B018-953EEE803135(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/94E15032-EFB6-4919-B018-953EEE803135(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetNumberOfStreams(
            out int pdwMaxStreams
            );
    }

#endif
}
