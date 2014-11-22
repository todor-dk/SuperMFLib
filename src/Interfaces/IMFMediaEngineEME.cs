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
using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Implemented by the media engine to add encrypted media extensions methods.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D03045D5-BAFE-4E65-98DA-E9EA8104C169(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D03045D5-BAFE-4E65-98DA-E9EA8104C169(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("50dc93e4-ba4f-4275-ae66-83e836e57469"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaEngineEME
    {
        /// <summary>
        /// Gets the media keys object associated with the media engine or <strong>null</strong> if there is
        /// not a media keys object. 
        /// </summary>
        /// <param name="keys">
        /// The media keys object associated with the media engine or <strong>null</strong> if there is not a
        /// media keys object. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT get_Keys(
        ///   IMFMediaKeys **keys
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E6556A02-445D-4436-80DE-E4156D6A3D63(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E6556A02-445D-4436-80DE-E4156D6A3D63(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int get_Keys(
           out IMFMediaKeys keys // check null
           );

        /// <summary>
        /// Sets the media keys object to use with the media engine.
        /// </summary>
        /// <param name="keys">
        /// The media keys.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetMediaKeys(
        ///   IMFMediaKeys *keys
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/659B566E-D488-489D-9A12-BFE9695C5F94(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/659B566E-D488-489D-9A12-BFE9695C5F94(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetMediaKeys(
           IMFMediaKeys keys
           );
    }

#endif
}
