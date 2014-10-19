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
    /// Configures the <c>Video Processor MFT</c>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/6803B69E-CF84-45D5-804C-BD961BD5E13D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6803B69E-CF84-45D5-804C-BD961BD5E13D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("A3F675D5-6119-4f7f-A100-1D8B280F0EFB")]
    public interface IMFVideoProcessorControl
    {
        /// <summary>
        /// Sets the border color.
        /// </summary>
        /// <param name="pBorderColor">
        /// A pointer to an <see cref="MFARGB"/> structure that specifies the border color as an ARGB (alpha,
        /// red, green, blue) value. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetBorderColor(
        ///   [in]  MFARGB *pBorderColor
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DA6165C9-24E9-473C-A4F7-4C94399AF346(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DA6165C9-24E9-473C-A4F7-4C94399AF346(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetBorderColor( 
            MFARGB pBorderColor
        );

        /// <summary>
        /// Sets the source rectangle. The source rectangle is the portion of the input frame that is blitted
        /// to the destination surface.
        /// </summary>
        /// <param name="pSrcRect">
        /// A pointer to a <c>RECT</c> structure that specifies the source rectangle. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetSourceRectangle(
        ///   RECT pSrcRect
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0A4E74BB-6F98-4610-9F47-5BD1E58B8589(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0A4E74BB-6F98-4610-9F47-5BD1E58B8589(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetSourceRectangle( 
            Rectangle pSrcRect
        );

        /// <summary>
        /// Sets the destination rectangle. The destination rectangle is the portion of the output surface
        /// where the source rectangle is blitted.
        /// </summary>
        /// <param name="pDstRect">
        /// A pointer to a <c>RECT</c> structure that specifies the destination rectangle. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetDestinationRectangle(
        ///   RECT pDstRect
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8AD1BDF4-2508-4A99-85A1-9DBC969D511B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8AD1BDF4-2508-4A99-85A1-9DBC969D511B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetDestinationRectangle( 
            Rectangle pDstRect
        );

        /// <summary>
        /// Specifies whether to flip the video image.
        /// </summary>
        /// <param name="eMirror">
        /// An <see cref="MF_VIDEO_PROCESSOR_MIRROR"/> value that specifies whether to flip the video image,
        /// either horizontally or vertically. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetMirror(
        ///   MF_VIDEO_PROCESSOR_MIRROR eMirror
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4529FEE5-7FDF-4EFF-93C1-E20A63186496(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4529FEE5-7FDF-4EFF-93C1-E20A63186496(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetMirror( 
            MF_VIDEO_PROCESSOR_MIRROR eMirror
        );

        /// <summary>
        /// Specifies whether to rotate the video to the correct orientation.
        /// </summary>
        /// <param name="eRotation">
        /// A <see cref="MF_VIDEO_PROCESSOR_ROTATION"/> value that specifies whether to rotate the image. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetRotation(
        ///   MF_VIDEO_PROCESSOR_ROTATION eRotation
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/452FE057-EC1A-430E-A5C8-C9B84A4B1B17(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/452FE057-EC1A-430E-A5C8-C9B84A4B1B17(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetRotation( 
            MF_VIDEO_PROCESSOR_ROTATION eRotation
        );

        /// <summary>
        /// Specifies the amount of downsampling to perform on the output.
        /// </summary>
        /// <param name="pConstrictionSize">
        /// The sampling size. To disable constriction, set this parameter to <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetConstrictionSize(
        ///   [in]  SIZE *pConstrictionSize
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/876F8BA0-9F05-48C6-ADE9-D65E7682C545(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/876F8BA0-9F05-48C6-ADE9-D65E7682C545(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetConstrictionSize(
            MFSize pConstrictionSize
        );
    }

#endif

}
