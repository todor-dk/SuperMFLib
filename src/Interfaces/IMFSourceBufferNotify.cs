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
    /// Provides functionality for raising events associated with <c>IMFSourceBuffer</c>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/4A823D37-F55A-4810-AAED-4E04F5371D3B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4A823D37-F55A-4810-AAED-4E04F5371D3B(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("87e47623-2ceb-45d6-9b88-d8520c4dcbbc"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFSourceBufferNotify
    {
        /// <summary>
        /// Used to indicate that the source buffer has started updating.
        /// </summary>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// void OnUpdateStart();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/513EF55D-756E-4AE3-B312-6A4178BC2F42(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/513EF55D-756E-4AE3-B312-6A4178BC2F42(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        void OnUpdateStart();

        /// <summary>
        /// Used to indicate that the source buffer has been aborted.
        /// </summary>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// void OnAbort();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/65D8BBB3-E683-4A9D-ACB2-023932D3E44D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/65D8BBB3-E683-4A9D-ACB2-023932D3E44D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        void OnAbort();

        /// <summary>
        /// Used to indicate that an error has occurred with the  source buffer.
        /// </summary>
        /// <param name="hr">
        /// </param>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// void OnError(
        ///   [in]  HRESULT hr
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A7187B7A-0090-4380-82BB-A7F72D54232E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A7187B7A-0090-4380-82BB-A7F72D54232E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        void OnError(int hr);

        /// <summary>
        /// Used to indicate that the source buffer is updating.
        /// </summary>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// void OnUpdate();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3C41F50F-7F0B-4676-9522-3866AEDAB047(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3C41F50F-7F0B-4676-9522-3866AEDAB047(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        void OnUpdate();

        /// <summary>
        /// Used to indicate that the source buffer has finished updating.
        /// </summary>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// void OnUpdateEnd();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A06D5765-D91E-4CBC-AC12-09D1CE4D84F6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A06D5765-D91E-4CBC-AC12-09D1CE4D84F6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        void OnUpdateEnd();
    }

#endif
}