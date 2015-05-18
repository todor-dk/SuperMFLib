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
    /// Returns the device identifier supported by a video renderer component. This interface is
    /// implemented by mixers and presenters for the enhanced video renderer (EVR). If you replace either
    /// of these components, the mixer and presenter must report the same device identifier.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/C42B75F9-6B72-4AAB-92F2-3361AB475CE9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C42B75F9-6B72-4AAB-92F2-3361AB475CE9(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("A38D9567-5A9C-4F3C-B293-8EB415B279BA")]
    internal interface IMFVideoDeviceID
    {
        /// <summary>
        /// Returns the identifier of the video device supported by an EVR mixer or presenter.
        /// </summary>
        /// <param name="pDeviceID">
        /// Receives the device identifier. Generally, the value is IID_IDirect3DDevice9.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The video renderer has been shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetDeviceID(
        ///   [out]  IID *pDeviceID
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E23EBCE0-BE58-413A-AB71-D94811C96029(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E23EBCE0-BE58-413A-AB71-D94811C96029(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetDeviceID(
            out Guid pDeviceID
            );
    }

#endif
}
