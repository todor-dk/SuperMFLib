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
    /// Extension for the <see cref="IMFMediaEngineClassFactory"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D672EE59-F702-49C7-8CCF-5BA0260C9B23(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D672EE59-F702-49C7-8CCF-5BA0260C9B23(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("c56156c6-ea5b-48a5-9df8-fbe035d0929e"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaEngineClassFactoryEx : IMFMediaEngineClassFactory
    {
        #region IMFMediaEngineClassFactory methods

        /// <summary>
        /// Creates a new instance of the Media Engine.
        /// </summary>
        /// <param name="dwFlags">A bitwise <strong>OR</strong> of zero or more flags from the
        /// <see cref="MF_MEDIA_ENGINE_CREATEFLAGS" /> enumeration.</param>
        /// <param name="pAttr">A pointer to the <see cref="IMFAttributes" /> interface of an attribute store.
        /// <para />
        /// This parameter specifies configuration attributes for the Media Engine. Call
        /// <see cref="MFExtern.MFCreateAttributes" /> to create the attribute store. Then, set one or more
        /// attributes from the list of <c>Media Engine Attributes</c>. For details, see Remarks.</param>
        /// <param name="ppPlayer">Receives a pointer to the <see cref="IMFMediaEngine" /> interface. The caller must release the
        /// interface.</param>
        /// <returns>System.Int32.</returns>
        /// <remarks><strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT CreateInstance(
        /// [in]   DWORD dwFlags,
        /// [in]   IMFAttributes *pAttr,
        /// [out]  IMFMediaEngine **ppPlayer
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/EDEAD2C4-5695-4E63-9E9E-B09D75B60B7F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EDEAD2C4-5695-4E63-9E9E-B09D75B60B7F(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int CreateInstance(
            MF_MEDIA_ENGINE_CREATEFLAGS dwFlags,
            IMFAttributes pAttr,
            out IMFMediaEngine ppPlayer
            );

        /// <summary>
        /// Creates a time range object.
        /// </summary>
        /// <param name="ppTimeRange">Receives a pointer to the <see cref="IMFMediaTimeRange" /> interface. The caller must release the
        /// interface.</param>
        /// <returns>System.Int32.</returns>
        /// <remarks><strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT CreateTimeRange(
        /// [out]  IMFMediaTimeRange **ppTimeRange
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/293769E8-8C8A-40D1-AF51-1DBB773F88D5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/293769E8-8C8A-40D1-AF51-1DBB773F88D5(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int CreateTimeRange(
            out IMFMediaTimeRange ppTimeRange
            );

        /// <summary>
        /// Creates a media error object.
        /// </summary>
        /// <param name="ppError">Receives a pointer to the <see cref="IMFMediaError" /> interface. The caller must release the
        /// interface.</param>
        /// <returns>System.Int32.</returns>
        /// <remarks><strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT CreateError(
        /// [out]  IMFMediaError **ppError
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/C089473D-CD35-4F5D-8C78-EDE0FA8C13EB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C089473D-CD35-4F5D-8C78-EDE0FA8C13EB(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int CreateError(
            out IMFMediaError ppError
            );

        #endregion

        /// <summary>
        /// Creates an instance of <c>IMFMediaSourceExtension</c>. 
        /// </summary>
        /// <param name="dwFlags">
        /// </param>
        /// <param name="pAttr">
        /// </param>
        /// <param name="ppMSE">
        /// The <c>IMFMediaSourceExtension</c> which was created. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT CreateMediaSourceExtension(
        ///   [in]   DWORD dwFlags,
        ///   [in]   IMFAttributes *pAttr,
        ///   [out]  IMFMediaSourceExtension **ppMSE
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2A76BAE3-0B7E-49FE-AB5D-BFB32D029D60(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2A76BAE3-0B7E-49FE-AB5D-BFB32D029D60(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateMediaSourceExtension(
            int dwFlags,
            IMFAttributes pAttr,
            out IMFMediaSourceExtension ppMSE
            );

        /// <summary>
        /// Creates a media keys object based on the specified key system.
        /// </summary>
        /// <param name="keySystem">
        /// The media keys system.
        /// </param>
        /// <param name="cdmStorePath">
        /// Points to a location to store Content Decryption Module (CDM) data which might be locked by
        /// multiple process and so might be incompatible with store app suspension.
        /// </param>
        /// <param name="ppKeys">
        /// The media keys.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT CreateMediaKeys(
        ///   BSTR keySystem,
        ///   BSTR cdmStorePath,
        ///   IMFMediaKeys **ppKeys
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/40B2B978-F12C-4066-ACF5-E0C68B0FA928(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/40B2B978-F12C-4066-ACF5-E0C68B0FA928(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateMediaKeys(
            [MarshalAs(UnmanagedType.BStr)] string keySystem,
            [MarshalAs(UnmanagedType.BStr)] string cdmStorePath,
            out IMFMediaKeys ppKeys
            );

        /// <summary>
        /// Gets a value that indicates if the specified key system supports the specified media type.
        /// </summary>
        /// <param name="type">
        /// The MIME type to check support for.
        /// </param>
        /// <param name="keySystem">
        /// The key system to check support for.
        /// </param>
        /// <param name="isSupported">
        /// <strong>true</strong> if type is supported by <em>keySystem</em>; otherwise, <strong>false.
        /// </strong>
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT IsTypeSupported(
        ///   BSTR type,
        ///   BSTR keySystem,
        ///   BOOL *isSupported
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6F4F50DB-E491-46C2-A8B2-1B8E51033B5B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6F4F50DB-E491-46C2-A8B2-1B8E51033B5B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int IsTypeSupported(
            [MarshalAs(UnmanagedType.BStr)] string type,
            [MarshalAs(UnmanagedType.BStr)] string keySystem,
            [MarshalAs(UnmanagedType.Bool)] out bool isSupported
            );
    }

#endif
}