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

namespace MediaFoundation.Core.Interfaces
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Represents a buffer which contains media data for a <c>IMFMediaSourceExtension</c>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/F241E232-9013-46D0-BE97-2D6B5246CFF3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F241E232-9013-46D0-BE97-2D6B5246CFF3(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("e2cd3a4b-af25-4d3d-9110-da0e6f8ee877"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFSourceBuffer
    {
        /// <summary>
        /// Gets a value that indicates if <c>Append</c>, <c>AppendByteStream</c>, or <c>Remove</c> is in
        /// process. 
        /// </summary>
        /// <returns>
        /// <strong>true</strong> if <c>Append</c>, <c>AppendByteStream</c>, or <c>Remove</c>; otherwise, 
        /// <strong>false</strong>. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// BOOL GetUpdating();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F1C810D1-05DD-4931-B063-FB86C6BEDAE3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F1C810D1-05DD-4931-B063-FB86C6BEDAE3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        bool GetUpdating();

        /// <summary>
        /// Gets the buffered time range.
        /// </summary>
        /// <param name="ppBuffered">
        /// The buffered time range.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetBuffered(
        ///   [out]  IMFMediaTimeRange **ppBuffered
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CBED0E90-8950-46F6-ACAA-5E6DAF814DD0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CBED0E90-8950-46F6-ACAA-5E6DAF814DD0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetBuffered(
            out IMFMediaTimeRange ppBuffered
            );

        /// <summary>
        /// Gets the timestamp offset for media segments appended to the <c>IMFSourceBuffer</c>. 
        /// </summary>
        /// <returns>
        /// The timestamp offset.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// double GetTimeStampOffset();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BB8A237B-2602-40AD-921E-3B76FBAC3EA8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BB8A237B-2602-40AD-921E-3B76FBAC3EA8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        double GetTimeStampOffset();

        /// <summary>
        /// Sets the timestamp offset for media segments appended to the <c>IMFSourceBuffer</c>. 
        /// </summary>
        /// <param name="offset">
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetTimeStampOffset(
        ///   [in]  double offset
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DB905149-F6F2-445E-87BB-6705A1A078EB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DB905149-F6F2-445E-87BB-6705A1A078EB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetTimeStampOffset(
            double offset
            );

        /// <summary>
        /// Gets the timestamp for the start of the append window.
        /// </summary>
        /// <returns>
        /// The timestamp for the start of the append window.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// double GetAppendWindowStart();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E5FEB451-5BF9-475C-B501-599E2188A3F5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E5FEB451-5BF9-475C-B501-599E2188A3F5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        double GetAppendWindowStart();

        /// <summary>
        /// Sets the timestamp for the start of the append window.
        /// </summary>
        /// <param name="time">
        /// The timestamp for the start of the append window.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetAppendWindowStart(
        ///   [in]  double time
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5F78E53C-EA2B-4849-9D01-6C31539D8EF5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5F78E53C-EA2B-4849-9D01-6C31539D8EF5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetAppendWindowStart(
            double time
            );

        /// <summary>
        /// Gets the timestamp for the end of the append window.
        /// </summary>
        /// <returns>
        /// The timestamp for the end of the append window.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// double GetAppendWindowEnd();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AC9806CA-8529-48BE-8B5A-AE0126D8554D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AC9806CA-8529-48BE-8B5A-AE0126D8554D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        double GetAppendWindowEnd();

        /// <summary>
        /// Sets the timestamp for the end of the append window.
        /// </summary>
        /// <param name="time">
        /// </param>
        /// <returns>
        /// The timestamp for the end of the append window.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetAppendWindowEnd(
        ///   [in]  double time
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/80CAE375-B3F4-4947-98DD-26338D4A0486(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/80CAE375-B3F4-4947-98DD-26338D4A0486(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetAppendWindowEnd(
            double time
            );

        /// <summary>
        /// Appends the specified media segment to the <c>IMFSourceBuffer</c>. 
        /// </summary>
        /// <param name="pData">
        /// The media data to append.
        /// </param>
        /// <param name="len">
        /// The length of the media data stored in <em>pData</em>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Append(
        ///   [in]  const BYTE *pData,
        ///   [in]  DWORD len
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/824FA23D-57D9-411A-AF8A-FB65DCA124B2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/824FA23D-57D9-411A-AF8A-FB65DCA124B2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Append(
            IntPtr pData,
            int len
            );

        /// <summary>
        /// Appends the media segment from the specified byte stream to the <c>IMFSourceBuffer</c>. 
        /// </summary>
        /// <param name="pStream">
        /// The media segment data.
        /// </param>
        /// <param name="pMaxLen">
        /// The maximum length of the media segment data.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT AppendByteStream(
        ///   [in]  IMFByteStream *pStream,
        ///   [in]  DWORDLONG *pMaxLen
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1A4FC611-4923-48AD-BC92-C3686D855C13(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1A4FC611-4923-48AD-BC92-C3686D855C13(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int AppendByteStream(
            IMFByteStream pStream,
            long pMaxLen
            );

        /// <summary>
        /// Aborts the processing of the current media segment. 
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Abort();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/31253D0D-C53F-47BD-823A-FC564CB63B78(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/31253D0D-C53F-47BD-823A-FC564CB63B78(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Abort();

        /// <summary>
        /// Removes the media segments defined by the specified time range from the <c>IMFSourceBuffer</c>. 
        /// </summary>
        /// <param name="start">
        /// The start of the time range.
        /// </param>
        /// <param name="end">
        /// The end of the time range.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Remove(
        ///   [in]  double start,
        ///   [in]  double end
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/86536D73-18C0-4ACC-81EC-72F1DFE400C5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/86536D73-18C0-4ACC-81EC-72F1DFE400C5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Remove(
            double start,
            double end
            );
    }

#endif
}
