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

// This file is a mess.  While technically part of MF, I'm in no hurry 
// to try to get this to work.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace MediaFoundation.OPM.Structs
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Contains information for the <see cref="OPM.MFOpmStatusRequests.OPM_GET_CODEC_INFO" /> command.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _OPM_GET_CODEC_INFO_PARAMETERS {
    ///   DWORD cbVerifier;
    ///   BYTE  Verifier[OPM_GET_INFORMATION_PARAMETERS_SIZE - 4];
    /// } OPM_GET_CODEC_INFO_PARAMETERS;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/9FB130E5-FD87-4A11-9C9E-7A106A091B35(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9FB130E5-FD87-4A11-9C9E-7A106A091B35(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    internal struct OPM_GET_CODEC_INFO_PARAMETERS
    {
        /// <summary>
        /// The amount of valid data in the <strong>Verifier</strong> array, in bytes.
        /// </summary>
        public int cbVerifier;
        /// <summary>
        /// A byte array that contains one of the following:
        /// <para /><para>* The CLSID of the Media Foundation transform (MFT) that represents the hardware codec.
        /// </para><para>* A null-terminated, wide-character string that contains the symbolic link for the
        /// hardware codec. Include the size of the terminating null in the value of the <strong>cbVerifier
        /// </strong> member. </para>
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4052)]
        public byte[] Verifier;
    }

#endif

}
