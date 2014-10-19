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
    /// Passes configuration information to the media sinks that are used for streaming the content. 
    /// Optionally, this interface is supported by media sinks. The built-in ASF streaming media sink and
    /// the MP3 media sink implement this interface.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/5EAEF815-9660-487A-885D-457CD270BA3D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5EAEF815-9660-487A-885D-457CD270BA3D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("9DB7AA41-3CC5-40D4-8509-555804AD34CC")]
    public interface IMFStreamingSinkConfig
    {
        /// <summary>
        /// Called by the streaming media client before the Media Session starts streaming to specify the byte
        /// offset or the time offset.
        /// </summary>
        /// <param name="fSeekOffsetIsByteOffset">
        /// A Boolean value that specifies whether <em>qwSeekOffset</em> gives a byte offset of a time offset. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>TRUE</strong></term><description>The <em>qwSeekOffset</em> parameter specifies a byte offset. </description></item>
        /// <item><term><strong>FALSE</strong></term><description>The <em>qwSeekOffset</em> parameter specifies the time position in 100-nanosecond units. </description></item>
        /// </list>
        /// </param>
        /// <param name="qwSeekOffset">
        /// A byte offset or a time offset, depending on the value passed in <em>fSeekOffsetIsByteOffset</em>.
        /// Time offsets are specified in 100-nanosecond units. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT StartStreaming(
        ///   [in]  BOOL fSeekOffsetIsByteOffset,
        ///   [in]  QWORD qwSeekOffset
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/22A75B19-9949-48FE-8844-511B11FBF20B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/22A75B19-9949-48FE-8844-511B11FBF20B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int StartStreaming(
            [MarshalAs(UnmanagedType.Bool)] bool fSeekOffsetIsByteOffset,
            [In] long qwSeekOffset
        );
    }

#endif

}
