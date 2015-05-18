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
    /// Seeks a byte stream by time position.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BD9EDFF7-46BA-4788-A44E-C69C4B0BEB50(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BD9EDFF7-46BA-4788-A44E-C69C4B0BEB50(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("64976BFA-FB61-4041-9069-8C9A5F659BEB")]
    internal interface IMFByteStreamTimeSeek
    {
        /// <summary>
        /// Queries whether the byte stream supports time-based seeking.
        /// </summary>
        /// <param name="pfTimeSeekIsSupported">
        /// Receives the value <strong>TRUE</strong> if the byte stream supports time-based seeking, or 
        /// <strong>FALSE</strong> otherwise. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT IsTimeSeekSupported(
        ///   [out]  BOOL *pfTimeSeekIsSupported
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/92FCE0EF-046C-4639-958E-731795C5A123(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/92FCE0EF-046C-4639-958E-731795C5A123(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int IsTimeSeekSupported( 
            out bool pfTimeSeekIsSupported
        );

        /// <summary>
        /// Seeks to a new position in the byte stream.
        /// </summary>
        /// <param name="qwTimePosition">
        /// The new position, in 100-nanosecond units.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT TimeSeek(
        ///   QWORD qwTimePosition
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/786F1299-A9E2-4B2C-A6AE-F88E6BF022DC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/786F1299-A9E2-4B2C-A6AE-F88E6BF022DC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int TimeSeek( 
            long qwTimePosition
        );

        /// <summary>
        /// Gets the result of a time-based seek.
        /// </summary>
        /// <param name="pqwStartTime">
        /// Receives the new position after the seek, in 100-nanosecond units.
        /// </param>
        /// <param name="pqwStopTime">
        /// Receives the stop time, in 100-nanosecond units. If the stop time is unknown, the value is zero.
        /// </param>
        /// <param name="pqwDuration">
        /// Receives the total duration of the file, in 100-nanosecond units. If the duration is unknown, the
        /// value is –1.
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The byte stream does not support time-based seeking, or no data is available.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetTimeSeekResult(
        ///   [out]  QWORD *pqwStartTime,
        ///   [out]  QWORD *pqwStopTime,
        ///   [out]  QWORD *pqwDuration
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D56E1F06-AA05-430C-BF5C-30B38831B842(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D56E1F06-AA05-430C-BF5C-30B38831B842(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetTimeSeekResult( 
            out long pqwStartTime,
            out long pqwStopTime,
            out long pqwDuration
        );        
    }

#endif

}
