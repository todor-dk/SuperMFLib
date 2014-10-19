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

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Enables the Media Engine to play protected video content.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/85B37711-DB46-4BC7-A051-79E9507791FA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/85B37711-DB46-4BC7-A051-79E9507791FA(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("9f8021e8-9c8c-487e-bb5c-79aa4779938c"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaEngineProtectedContent
    {
        /// <summary>
        /// Enables the Media Engine to access protected content while in frame-server mode.
        /// </summary>
        /// <param name="pUnkDeviceContext">
        /// A pointer to the Direct3D 11 device content. The Media Engine queries this pointer for the 
        /// <c>ID3D11VideoContext</c> interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT ShareResources(
        ///   [in]  IUnknown *pUnkDeviceContext
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7C94AEA2-1D72-4C45-9EDF-90593CC60E2C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7C94AEA2-1D72-4C45-9EDF-90593CC60E2C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ShareResources(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnkDeviceContext
            );

        /// <summary>
        /// Gets the content protections that must be applied in frame-server mode.
        /// </summary>
        /// <param name="pFrameProtectionFlags">
        /// Receives a bitwise <strong>OR</strong> of zero or more flags from the 
        /// <see cref="MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAGS"/> enumeration. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetRequiredProtections(
        ///   [out]  DWORD *pFrameProtectionFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4D67813D-F222-4EB1-B059-6DB5EC642DA2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4D67813D-F222-4EB1-B059-6DB5EC642DA2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetRequiredProtections(
            out int pFrameProtectionFlags
            );

        /// <summary>
        /// Specifies the window that should receive output link protections.
        /// </summary>
        /// <param name="hwnd">
        /// A handle to the window.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetOPMWindow(
        ///   [in]  HWND hwnd
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0102A98E-5EE0-4FBE-AF82-97C7A25038FB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0102A98E-5EE0-4FBE-AF82-97C7A25038FB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetOPMWindow(
            IntPtr hwnd
            );

        /// <summary>
        /// Copies a protected video frame to a DXGI surface.
        /// </summary>
        /// <param name="pDstSurf">
        /// A pointer to the <c>IUnknown</c> interface of the destination surface. 
        /// </param>
        /// <param name="pSrc">
        /// A pointer to an <see cref="EVR.MFVideoNormalizedRect"/> structure that specifies the source
        /// rectangle. 
        /// </param>
        /// <param name="pDst">
        /// A pointer to a <c>RECT</c> structure that specifies the destination rectangle. 
        /// </param>
        /// <param name="pBorderClr">
        /// A pointer to an <see cref="MFARGB"/> structure that specifies the border color. 
        /// </param>
        /// <param name="pFrameProtectionFlags">
        /// Receives a bitwise <strong>OR</strong> of zero or more flags from the 
        /// <see cref="MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAGS"/> enumeration. These flags indicate which
        /// content protections the application must apply before presenting the surface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT TransferVideoFrame(
        ///   [in]   IUnknown *pDstSurf,
        ///   [in]   const MFVideoNormalizedRect *pSrc,
        ///   [in]   const RECT *pDst,
        ///   [in]   const MFARGB *pBorderClr,
        ///   [out]  DWORD *pFrameProtectionFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3A5C6908-65F4-4E7A-AD71-BBD1C2A4ACE3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3A5C6908-65F4-4E7A-AD71-BBD1C2A4ACE3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int TransferVideoFrame(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pDstSurf,
            [In] MFVideoNormalizedRect pSrc,
            [In] MFRect pDst,
            [In] MFARGB pBorderClr,
            out int pFrameProtectionFlags
            );

        /// <summary>
        /// Sets the content protection manager (CPM).
        /// </summary>
        /// <param name="pCPM">
        /// A pointer to the <see cref="IMFContentProtectionManager"/> interface, implemented by the caller. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetContentProtectionManager(
        ///   [in]  IMFContentProtectionManager *pCPM
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8F150CB5-43AB-4709-A254-636440113642(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8F150CB5-43AB-4709-A254-636440113642(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetContentProtectionManager(
            IMFContentProtectionManager pCPM
            );

        /// <summary>
        /// Sets the application's certificate.
        /// </summary>
        /// <param name="pbBlob">
        /// A pointer to a buffer that contains the certificate in X.509 format, followed by the application
        /// identifier signed with a SHA-256 signature using the private key from the certificate.
        /// </param>
        /// <param name="cbBlob">
        /// The size of the <em>pbBlob</em> buffer, in bytes. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetApplicationCertificate(
        ///   [in]  const BYTE *pbBlob,
        ///   [in]  DWORD cbBlob
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2D1F31B1-9A4E-4B94-93FF-255B3006C904(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2D1F31B1-9A4E-4B94-93FF-255B3006C904(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetApplicationCertificate(
            IntPtr pbBlob,
            int cbBlob
            );
    }

#endif

}
