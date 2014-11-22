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
    /// This interface is not supported.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/EA7B0DD2-2EFF-4A37-826B-6F87FBEA5785(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EA7B0DD2-2EFF-4A37-826B-6F87FBEA5785(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("d0cfe38b-93e7-4772-8957-0400c49a4485")]
    public interface IEVRVideoStreamControl
    {
        /// <summary>
        /// <strong>Note</strong> This method is not supported. 
        /// </summary>
        /// <param name="fActive">
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetStreamActiveState(
        ///   [in]  BOOL fActive
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/85F711F1-1536-4AB0-90B7-79E22C210198(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/85F711F1-1536-4AB0-90B7-79E22C210198(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetStreamActiveState(
            [MarshalAs(UnmanagedType.Bool)] bool fActive);

        /// <summary>
        /// <strong>Note</strong> This method is not supported. 
        /// </summary>
        /// <param name="lpfActive">
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStreamActiveState(
        ///   [out]  BOOL *lpfActive
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D4CA1DA7-7768-45B4-A0BE-F3EF86FED7B9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D4CA1DA7-7768-45B4-A0BE-F3EF86FED7B9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStreamActiveState(
            [MarshalAs(UnmanagedType.Bool)] out bool lpfActive);
    }

}
