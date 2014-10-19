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

using MediaFoundation;
using MediaFoundation.Misc;
using MediaFoundation.Transform;
using System.Drawing;

namespace MediaFoundation.EVR
{


    /// <summary>
    /// Maps a position on an input video stream to the corresponding position on an output video stream.
    /// <para/>
    /// To obtain a pointer to this interface, call <see cref="IMFGetService.GetService"/> on the renderer
    /// with the service GUID MR_VIDEO_RENDER_SERVICE. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/282FA124-909F-49DC-9A86-3D962193E903(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/282FA124-909F-49DC-9A86-3D962193E903(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("1F6A9F17-E70B-4E24-8AE4-0B2C3BA7A4AE"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFVideoPositionMapper
    {
        /// <summary>
        /// Maps output image coordinates to input image coordinates. This method provides the reverse
        /// transformation for components that map coordinates on the input image to different coordinates on
        /// the output image. 
        /// </summary>
        /// <param name="xOut">
        /// X-coordinate of the output image, normalized to the range [0...1]. 
        /// </param>
        /// <param name="yOut">
        /// Y-coordinate of the output image, normalized to the range [0...1]. 
        /// </param>
        /// <param name="dwOutputStreamIndex">
        /// Output stream index for the coordinate mapping. 
        /// </param>
        /// <param name="dwInputStreamIndex">
        /// Input stream index for the coordinate mapping. 
        /// </param>
        /// <param name="pxIn">
        /// Receives the mapped x-coordinate of the input image, normalized to the range [0...1]. 
        /// </param>
        /// <param name="pyIn">
        /// Receives the mapped y-coordinate of the input image, normalized to the range [0...1]. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description> The video renderer has been shut down. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT MapOutputCoordinateToInputStream(
        ///   [in]   float xOut,
        ///   [in]   float yOut,
        ///   [in]   DWORD dwOutputStreamIndex,
        ///   [in]   DWORD dwInputStreamIndex,
        ///   [out]  float *pxIn,
        ///   [out]  float *pyIn
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D57AED5F-90CB-47E7-AF80-F3573A3B8256(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D57AED5F-90CB-47E7-AF80-F3573A3B8256(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int MapOutputCoordinateToInputStream(
            [In] float xOut,
            [In] float yOut,
            [In] int dwOutputStreamIndex,
            [In] int dwInputStreamIndex,
            out float pxIn,
            out float pyIn
            );
    }

}
