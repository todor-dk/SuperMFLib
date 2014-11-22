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

using MediaFoundation.Misc;
using MediaFoundation;
using System.Drawing;

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Controls how a network byte stream transfers data to a local cache. This interface extends the 
    /// <see cref="IMFByteStreamCacheControl"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A901F679-B6F2-4DB7-8EFC-EA61249B64FB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A901F679-B6F2-4DB7-8EFC-EA61249B64FB(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("71CE469C-F34B-49EA-A56B-2D2A10E51149")]
    public interface IMFByteStreamCacheControl2 : IMFByteStreamCacheControl
    {
        #region IMFByteStreamCacheControl methods

        /// <summary>
        /// Stops the background transfer of data to the local cache.
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT StopBackgroundTransfer();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/9F0F7102-C839-4E92-A798-5EA31CEBA013(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9F0F7102-C839-4E92-A798-5EA31CEBA013(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int StopBackgroundTransfer();

        #endregion

        /// <summary>
        /// Gets the ranges of bytes that are currently stored in the cache.
        /// </summary>
        /// <param name="pcRanges">
        /// Receives the number of ranges returned in the <em>ppRanges</em> array. 
        /// </param>
        /// <param name="ppRanges">
        /// Receives an array of <see cref="MF_BYTE_STREAM_CACHE_RANGE"/> structures. Each structure specifies
        /// a range of bytes stored in the cache. The caller must free the array by calling 
        /// <c>CoTaskMemFree</c>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetByteRanges(
        ///   [out]  DWORD *pcRanges,
        ///   [out]  MF_BYTE_STREAM_CACHE_RANGE **ppRanges
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FC91FCB5-CD22-494F-85B7-38571C38A44E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FC91FCB5-CD22-494F-85B7-38571C38A44E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetByteRanges( 
            out int pcRanges,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] MF_BYTE_STREAM_CACHE_RANGE[] ppRanges
        );

        /// <summary>
        /// Limits the cache size.
        /// </summary>
        /// <param name="qwBytes">
        /// The maximum number of bytes to store in the cache, or <strong>ULONGLONG_MAX </strong> for no limit.
        /// The default value is no limit. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetCacheLimit(
        ///   [in]  QWORD qwBytes
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1DDC3D76-E28B-4B8C-B2CD-FE77E840D949(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1DDC3D76-E28B-4B8C-B2CD-FE77E840D949(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetCacheLimit( 
            long qwBytes
        );

        /// <summary>
        /// Queries whether background transfer is active.
        /// </summary>
        /// <param name="pfActive">
        /// Receives the value <strong>TRUE</strong> if background transfer is currently active, or <strong>
        /// FALSE</strong> otherwise. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT IsBackgroundTransferActive(
        ///   [out]  BOOL *pfActive
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FC08E5E8-A7E0-461C-B70C-B1273FCDD1A0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FC08E5E8-A7E0-461C-B70C-B1273FCDD1A0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int IsBackgroundTransferActive( 
            out bool pfActive
        );
    }

#endif

}
