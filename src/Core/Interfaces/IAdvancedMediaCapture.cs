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

using MediaFoundation.Misc;

namespace MediaFoundation.Core.Interfaces
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Enables advanced media capture.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/932B0CBF-C264-4C3B-B143-023DD7F809F1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/932B0CBF-C264-4C3B-B143-023DD7F809F1(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("D0751585-D216-4344-B5BF-463B68F977BB"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IAdvancedMediaCapture
    {
        /// <summary>
        /// Gets the advanced media capture settings.
        /// </summary>
        /// <param name="value">
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetAdvancedMediaCaptureSettings(
        ///   [out]  IAdvancedMediaCaptureSettings **value
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/88C65141-9CC3-4DA3-ADEE-06727152BA8B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/88C65141-9CC3-4DA3-ADEE-06727152BA8B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetAdvancedMediaCaptureSettings(
            out IAdvancedMediaCaptureSettings value
            );
    }

#endif

}
