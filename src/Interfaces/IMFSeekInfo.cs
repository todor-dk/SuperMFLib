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
    /// For a particular seek position, gets the two nearest key frames.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/5B1AD3A1-D5ED-4F9D-A895-0312E6EB3072(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5B1AD3A1-D5ED-4F9D-A895-0312E6EB3072(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("26AFEA53-D9ED-42B5-AB80-E64F9EE34779")]
    public interface IMFSeekInfo
    {
        /// <summary>
        /// For a particular seek position, gets the two nearest key frames.
        /// </summary>
        /// <param name="pguidTimeFormat">
        /// A pointer to a GUID that specifies the time format. The time format defines the units for the other
        /// parameters of this method. If the value is <strong>GUID_NULL</strong>, the time format is
        /// 100-nanosecond units. Some media sources might support additional time format GUIDs. 
        /// </param>
        /// <param name="pvarStartPosition">
        /// The seek position. The units for this parameter are specified by <em>pguidTimeFormat</em>. 
        /// </param>
        /// <param name="pvarPreviousKeyFrame">
        /// Receives the position of the nearest key frame that appears earlier than <em>pvarStartPosition</em>
        /// . The units for this parameter are specified by <em>pguidTimeFormat</em>. 
        /// </param>
        /// <param name="pvarNextKeyFrame">
        /// Receives the position of the nearest key frame that appears earlier than <em>pvarStartPosition</em>
        /// . The units for this parameter are specified by <em>pguidTimeFormat</em>. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_UNSUPPORTED_TIME_FORMAT</strong></term><description>The time format specified in <em>pguidTimeFormat</em> is not supported. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetNearestKeyFrames(
        ///   [in]   const GUID *pguidTimeFormat,
        ///   [in]   const PROPVARIANT *pvarStartPosition,
        ///   [out]  PROPVARIANT *pvarPreviousKeyFrame,
        ///   [out]  PROPVARIANT *pvarNextKeyFrame
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/72A7161A-09CA-4582-B240-1442D70936D7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/72A7161A-09CA-4582-B240-1442D70936D7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetNearestKeyFrames( 
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid pguidTimeFormat,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant pvarStartPosition,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pvarPreviousKeyFrame,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pvarNextKeyFrame
        );        
    }

#endif

}
