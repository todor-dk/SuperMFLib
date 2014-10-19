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

namespace MediaFoundation.Transform
{


    /// <summary>
    /// Contains information about an output buffer for a Media Foundation transform. This structure is
    /// used in the <see cref="Transform.IMFTransform.ProcessOutput" /> method.
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct _MFT_OUTPUT_DATA_BUFFER {
    ///   DWORD         dwStreamID;
    ///   IMFSample     *pSample;
    ///   DWORD         dwStatus;
    ///   IMFCollection *pEvents;
    /// } MFT_OUTPUT_DATA_BUFFER;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/57623C8F-F7B6-4CB3-8D54-4EE516C706C3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/57623C8F-F7B6-4CB3-8D54-4EE516C706C3(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("MFT_OUTPUT_DATA_BUFFER")]
    public struct MFTOutputDataBuffer
    {
        /// <summary>
        /// Output stream identifier. Before calling <c>ProcessOutput</c>, set this member to a valid stream
        /// identifier.
        /// <para />
        /// Exception: If the <see cref="Transform.IMFTransform.GetStreamIDs" /> method returns E_NOTIMPL, the
        /// MFT ignores this member and uses the indexes of the <em>pOutputSamples</em> array in the
        /// <c>ProcessOutput</c> method as the stream identifiers. In other words, it uses the first element in
        /// the array for stream 0, the second for stream 1, and so forth. It is recommended (but not required)
        /// that the caller set <strong>dwStreamID</strong> equal to the array index in this case.
        /// </summary>
        public int dwStreamID;
        /// <summary>
        /// Pointer to the <see cref="IMFSample" /> interface. Before calling <c>ProcessOutput</c>, set this
        /// member equal to a valid <strong>IMFSample</strong> pointer or <strong>NULL</strong>. See Remarks
        /// for more information.
        /// </summary>
        public IntPtr pSample; // Doesn't release correctly when marshaled as IMFSample
        /// <summary>
        /// Before calling <c>ProcessOutput</c>, set this member to zero. When the method returns, the MFT
        /// might set the member equal to a value from the <see cref="Transform.MFTOutputDataBufferFlags" />
        /// enumeration. Otherwise, the MFT leaves this member equal to zero.
        /// </summary>
        public MFTOutputDataBufferFlags dwStatus;
        /// <summary>
        /// Before calling <c>ProcessOutput</c>, set this member to <strong>NULL</strong>. On output, the MFT
        /// might set this member to a valid <see cref="IMFCollection" /> interface pointer. The pointer
        /// represents a collecton that contains zero or more events. To get each event, call
        /// <see cref="IMFCollection.GetElement" /> and query the returned <strong>IUnknown</strong> pointer for
        /// the <see cref="IMFMediaEvent" /> interface. When the <strong>ProcessOutput</strong> method returns,
        /// the caller is responsible for releasing the <strong>IMFCollection</strong> pointer if the pointer
        /// is not <strong>NULL</strong>.
        /// </summary>
        [MarshalAs(UnmanagedType.Interface)]
        public IMFCollection pEvents;
    }

}
