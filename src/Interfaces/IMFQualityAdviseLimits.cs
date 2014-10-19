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
    /// Queries an object for the number of <em>quality modes</em> it supports. Quality modes are used to
    /// adjust the trade-off between quality and speed when rendering audio or video. 
    /// <para/>
    /// The default presenter for the <em>enhanced video renderer</em> (EVR) implements this interface. The
    /// EVR uses the interface to respond to quality messages from the quality manager. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/8EF7088C-2F49-4BE9-B719-481616E1737D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8EF7088C-2F49-4BE9-B719-481616E1737D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("DFCD8E4D-30B5-4567-ACAA-8EB5B7853DC9")]
    public interface IMFQualityAdviseLimits
    {
        /// <summary>
        /// Gets the maximum <em>drop mode</em>. A higher drop mode means that the object will, if needed, drop
        /// samples more aggressively to match the presentation clock. 
        /// </summary>
        /// <param name="peDropMode">
        /// Receives the maximum drop mode, specified as a member of the <see cref="MFQualityDropMode"/>
        /// enumeration. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetMaximumDropMode(
        ///   [out]  MF_QUALITY_DROP_MODE *peDropMode
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AF3D968B-7BAF-41D8-AFD9-DBF673C1BB71(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AF3D968B-7BAF-41D8-AFD9-DBF673C1BB71(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMaximumDropMode(
            out MFQualityDropMode peDropMode
        );

        /// <summary>
        /// Gets the minimum quality level that is supported by the component.
        /// </summary>
        /// <param name="peQualityLevel">
        /// Receives the minimum quality level, specified as a member of the <see cref="MFQualityLevel"/>
        /// enumeration. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetMinimumQualityLevel(
        ///   [out]  MF_QUALITY_LEVEL *peQualityLevel
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AEA08AE5-4252-4703-964B-AFC6BBC01A51(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AEA08AE5-4252-4703-964B-AFC6BBC01A51(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMinimumQualityLevel(
            out MFQualityLevel peQualityLevel
        );
    }

#endif

}
