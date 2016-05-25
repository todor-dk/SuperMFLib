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
    /// Represents a list of time ranges, where each range is defined by a start and end time.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/E39646E6-66F4-4413-A84B-43039689AEE7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E39646E6-66F4-4413-A84B-43039689AEE7(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("db71a2fc-078a-414e-9df9-8c2531b0aa6c"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFMediaTimeRange
    {
        /// <summary>
        /// Gets the number of time ranges contained in the object.
        /// </summary>
        /// <returns>
        /// Returns the number of time ranges.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// DWORD GetLength();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0865A667-A09E-4F42-A420-4A155AD34394(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0865A667-A09E-4F42-A420-4A155AD34394(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetLength();

        /// <summary>
        /// Gets the start time for a specified time range.
        /// </summary>
        /// <param name="index">
        /// The zero-based index of the time range to query. To get the number of time ranges, call 
        /// <see cref="IMFMediaTimeRange.GetLength"/>. 
        /// </param>
        /// <param name="pStart">
        /// Receives the start time, in seconds.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStart(
        ///   [in]   DWORD index,
        ///   [out]  double *pStart
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E02CFE99-78B8-4923-8922-467A55442802(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E02CFE99-78B8-4923-8922-467A55442802(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStart(
            int index,
            out double pStart
            );

        /// <summary>
        /// Gets the end time for a specified time range.
        /// </summary>
        /// <param name="index">
        /// The zero-based index of the time range to query. To get the number of time ranges, call 
        /// <see cref="IMFMediaTimeRange.GetLength"/>. 
        /// </param>
        /// <param name="pEnd">
        /// Receives the end time, in seconds.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetEnd(
        ///   [in]   DWORD index,
        ///   [out]  double *pEnd
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/864C0DEE-A1F7-488C-9A9D-366602667DE9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/864C0DEE-A1F7-488C-9A9D-366602667DE9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetEnd(
            int index,
            out  double pEnd
            );

        /// <summary>
        /// Queries whether a specified time falls within any of the time ranges.
        /// </summary>
        /// <param name="time">
        /// The time, in seconds.
        /// </param>
        /// <returns>
        /// Returns <strong>TRUE</strong> if any time range contained in this object spans the value of the 
        /// <em>time</em> parameter. Otherwise, returns <strong>FALSE</strong>. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// BOOL ContainsTime(
        ///   [in]  double time
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/67BA2464-D8F0-4A5C-9C12-DBD9AD0238A7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/67BA2464-D8F0-4A5C-9C12-DBD9AD0238A7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        bool ContainsTime(
            double time
            );

        /// <summary>
        /// Adds a new range to the list of time ranges.
        /// </summary>
        /// <param name="startTime">
        /// The start time, in seconds.
        /// </param>
        /// <param name="endTime">
        /// The end time, in seconds.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT AddRange(
        ///   [in]  double startTime,
        ///   [in]  double endTime
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6BA36A44-78AC-4868-9E6A-601C0740E67A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6BA36A44-78AC-4868-9E6A-601C0740E67A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int AddRange(
            double startTime,
            double endTime
            );

        /// <summary>
        /// Clears the list of time ranges.
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Clear();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F7CDC73E-CF14-48E2-9C8A-E1944099861A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F7CDC73E-CF14-48E2-9C8A-E1944099861A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Clear();
    }

#endif

}
