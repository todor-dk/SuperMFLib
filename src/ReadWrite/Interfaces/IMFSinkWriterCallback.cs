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
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation.ReadWrite
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Callback interface for the Microsoft Media Foundation sink writer. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FA0295E6-473D-4304-9A7B-24584CADE0A0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FA0295E6-473D-4304-9A7B-24584CADE0A0(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("666f76de-33d2-41b9-a458-29ed0a972c58")]
    public interface IMFSinkWriterCallback
    {
        /// <summary>
        /// Called when the <c>IMFSinkWriter::Finalize</c> method completes. 
        /// </summary>
        /// <param name="hrStatus">
        /// The status code for the <c>Finalize</c> operation. If the value is an error code, the output file
        /// might be invalid. 
        /// </param>
        /// <returns>
        /// Returns an <strong>HRESULT</strong> value. Currently, the sink writer ignores the return value. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnFinalize(
        ///   [in]  HRESULT hrStatus
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9DA7BB55-BF9F-4579-AE8E-B33CE5461950(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9DA7BB55-BF9F-4579-AE8E-B33CE5461950(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int OnFinalize(
            int hrStatus
        );

        /// <summary>
        /// Called when the <see cref="ReadWrite.IMFSinkWriter.PlaceMarker"/> method completes. 
        /// </summary>
        /// <param name="dwStreamIndex">
        /// The zero-based index of the stream. This parameter equals the value of the <em>dwStreamIndex</em>
        /// parameter in the <c>PlaceMarker</c> method. 
        /// </param>
        /// <param name="pvContext">
        /// The application-defined value that was given in the <em>pvContext</em> parameter in the 
        /// <c>PlaceMarker</c> method. 
        /// </param>
        /// <returns>
        /// Returns an <strong>HRESULT</strong> value. Currently, the sink writer ignores the return value. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnMarker(
        ///   [in]  DWORD dwStreamIndex,
        ///   [in]  LPVOID pvContext
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5B1CA6A7-C2BC-4B30-AA86-05BD4CCC052C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5B1CA6A7-C2BC-4B30-AA86-05BD4CCC052C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int OnMarker(
            int dwStreamIndex,
            IntPtr pvContext
        );
    }

#endif

}
