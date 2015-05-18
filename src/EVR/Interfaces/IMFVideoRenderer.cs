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
    /// Sets a new mixer or presenter for the <c>Enhanced Video Renderer</c> (EVR). 
    /// <para/>
    /// Both the EVR media sink and the DirectShow EVR filter implement this interface. To get a pointer to
    /// the interface, call <strong>QueryInterface</strong> on the media sink or the filter. Do not use 
    /// <see cref="IMFGetService"/> to get a pointer to this interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/70596630-5131-460F-9CB3-ADCEA201C3B2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/70596630-5131-460F-9CB3-ADCEA201C3B2(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("DFDFD197-A9CA-43D8-B341-6AF3503792CD"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFVideoRenderer
    {
        /// <summary>
        /// Sets a new mixer or presenter for the enhanced video renderer (EVR).
        /// </summary>
        /// <param name="pVideoMixer">
        /// Pointer to the <see cref="Transform.IMFTransform"/> interface of the mixer to use. This parameter
        /// can be <strong>NULL</strong>. If this parameter is <strong>NULL</strong>, the EVR uses its default
        /// mixer. 
        /// </param>
        /// <param name="pVideoPresenter">
        /// Pointer to the <see cref="EVR.IMFVideoPresenter"/> interface of the presenter to use. This
        /// parameter can be <strong>NULL</strong>. If this parameter is <strong>NULL</strong>, the EVR uses
        /// its default presenter. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>Either the mixer or the presenter is invalid.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The mixer and presenter cannot be replaced in the current state. (EVR media sink.)</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The video renderer has been shut down.</description></item>
        /// <item><term><strong>VFW_E_WRONG_STATE</strong></term><description>One or more input pins are connected. (DirectShow EVR filter.)</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT InitializeRenderer(
        ///   [in]  IMFTransform *pVideoMixer,
        ///   [in]  IMFVideoPresenter *pVideoPresenter
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E46A9596-9F3F-4430-8D45-BBC9C240BE3B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E46A9596-9F3F-4430-8D45-BBC9C240BE3B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int InitializeRenderer(
            [In, MarshalAs(UnmanagedType.Interface)] IMFTransform pVideoMixer,
            [In, MarshalAs(UnmanagedType.Interface)] IMFVideoPresenter pVideoPresenter
            );
    }

#endif
}
