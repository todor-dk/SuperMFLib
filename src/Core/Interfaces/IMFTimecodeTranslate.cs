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

namespace MediaFoundation.Core.Interfaces
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Converts between Society of Motion Picture and Television Engineers (SMPTE) time codes and
    /// 100-nanosecond time units.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/935EC6B3-12E6-4458-B8A1-FFEB4159D957(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/935EC6B3-12E6-4458-B8A1-FFEB4159D957(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("AB9D8661-F7E8-4EF4-9861-89F334F94E74")]
    internal interface IMFTimecodeTranslate
    {
        /// <summary>
        /// Starts an asynchronous call to convert Society of Motion Picture and Television Engineers (SMPTE)
        /// time code to 100-nanosecond units.
        /// </summary>
        /// <param name="pPropVarTimecode">
        /// Time in SMPTE time code to convert. The <strong>vt</strong> member of the <strong>PROPVARIANT
        /// </strong> structure is set to <strong>VT_I8</strong>. The <strong>hVal.QuadPart</strong> member
        /// contains the time in binary coded decimal (BCD) form. See Remarks. 
        /// </param>
        /// <param name="pCallback">
        /// Pointer to the <see cref="IMFAsyncCallback"/> interface of a callback object. The caller must
        /// implement this interface. 
        /// </param>
        /// <param name="punkState">
        /// PPointer to the <strong>IUnknown</strong> interface of a state object, defined by the caller. This
        /// parameter can be <strong>NULL</strong>. You can use this object to hold state information. The
        /// object is returned to the caller when the callback is invoked. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>E_INVALIDARG</strong></term><description><em>pPropVarTimecode</em> is not <strong>VT_I8</strong>. </description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The object's <strong>Shutdown</strong> method was called. </description></item>
        /// <item><term><strong>MF_E_BYTESTREAM_NOT_SEEKABLE</strong></term><description>The byte stream is not seekable. The time code cannot be read from the end of the byte stream.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT BeginConvertTimecodeToHNS(
        ///   [in]  const PROPVARIANT *pPropVarTimecode,
        ///   [in]  IMFAsyncCallback *pCallback,
        ///   [in]  IUnknown *punkState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4E25D5E4-B4D7-4CA4-81C9-12C6D712322D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4E25D5E4-B4D7-4CA4-81C9-12C6D712322D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int BeginConvertTimecodeToHNS(
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant pPropVarTimecode,
            IMFAsyncCallback pCallback,
            [In, MarshalAs(UnmanagedType.IUnknown)] object punkState
        );

        /// <summary>
        /// Completes an asynchronous request to convert time in Society of Motion Picture and Television
        /// Engineers (SMPTE) time code to 100-nanosecond units.
        /// </summary>
        /// <param name="pResult">
        /// Pointer to the <see cref="IMFAsyncResult"/> interface. Pass in the same pointer that your callback
        /// object received in the <see cref="IMFAsyncCallback.Invoke"/> method. 
        /// </param>
        /// <param name="phnsTime">
        /// Receives the converted time.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT EndConvertTimecodeToHNS(
        ///   [in]   IMFAsyncResult *pResult,
        ///   [out]  MFTIME *phnsTime
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D1B8B8BA-D03A-4A45-8788-38DBB2BE8C6A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D1B8B8BA-D03A-4A45-8788-38DBB2BE8C6A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EndConvertTimecodeToHNS(
            IMFAsyncResult pResult,
            out long phnsTime
        );

        /// <summary>
        /// Starts an asynchronous call to convert time in 100-nanosecond units to Society of Motion Picture
        /// and Television Engineers (SMPTE) time code.
        /// </summary>
        /// <param name="hnsTime">
        /// The time to convert, in 100-nanosecond units.
        /// </param>
        /// <param name="pCallback">
        /// Pointer to the <see cref="IMFAsyncCallback"/> interface of a callback object. The caller must
        /// implement this interface. 
        /// </param>
        /// <param name="punkState">
        /// Pointer to the <strong>IUnknown</strong> interface of a state object, defined by the caller. This
        /// parameter can be <strong>NULL</strong>. You can use this object to hold state information. The
        /// object is returned to the caller when the callback is invoked. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The object's <strong>Shutdown</strong> method was called. </description></item>
        /// <item><term><strong>MF_E_BYTESTREAM_NOT_SEEKABLE</strong></term><description>The byte stream is not seekable. The time code cannot be read from the end of the byte stream.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT BeginConvertHNSToTimecode(
        ///   [in]  MFTIME hnsTime,
        ///   [in]  IMFAsyncCallback *pCallback,
        ///   [in]  IUnknown *punkState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/42B5DE27-AAA6-4BD9-B2B0-3AEABFC28EF2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/42B5DE27-AAA6-4BD9-B2B0-3AEABFC28EF2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int BeginConvertHNSToTimecode(
            [In] long hnsTime,
            IMFAsyncCallback pCallback,
            [In, MarshalAs(UnmanagedType.IUnknown)] object punkState
        );

        /// <summary>
        /// Completes an asynchronous request to convert time in 100-nanosecond units to Society of Motion
        /// Picture and Television Engineers (SMPTE) time code.
        /// </summary>
        /// <param name="pResult">
        /// A pointer to the <see cref="IMFAsyncResult"/> interface. Pass in the same pointer that your
        /// callback object received in the <see cref="IMFAsyncCallback.Invoke"/> method. 
        /// </param>
        /// <param name="pPropVarTimecode">
        /// A pointer to a <strong>PROPVARIANT</strong> that receives the converted time. The <strong>vt
        /// </strong> member of the <strong>PROPVARIANT</strong> structure is set to VT_I8. The <strong>
        /// hVal.QuadPart</strong> member contains the converted time in binary coded decimal (BCD) form. See
        /// Remarks. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT EndConvertHNSToTimecode(
        ///   [in]   IMFAsyncResult *pResult,
        ///   [out]  PROPVARIANT *pPropVarTimecode
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9386748C-E551-49B8-89C3-65D721820736(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9386748C-E551-49B8-89C3-65D721820736(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EndConvertHNSToTimecode(
            IMFAsyncResult pResult,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PropVariantMarshaler))] PropVariant pPropVarTimecode
        );
    }

#endif

}
