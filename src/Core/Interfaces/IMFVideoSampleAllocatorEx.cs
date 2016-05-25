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
    /// Allocates video samples that contain Microsoft Direct3D 11 texture surfaces.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/B621F413-001B-4419-8FA7-439C45F97243(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B621F413-001B-4419-8FA7-439C45F97243(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("545b3a48-3283-4f62-866f-a62d8f598f9f")]
    internal interface IMFVideoSampleAllocatorEx : IMFVideoSampleAllocator
    {
        #region IMFVideoSampleAllocator methods

        /// <summary>
        /// Specifies the Direct3D device manager for the video media sink to use.
        /// </summary>
        /// <param name="pManager">Pointer to the <strong>IUnknown</strong> interface of the Direct3D device manager. The media sink
        /// queries this pointer for the <c>IDirect3DDeviceManager9</c> interface.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetDirectXManager(
        /// [in]  IUnknown *pManager
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/BAD810C9-F5B1-42DC-9C7A-3306F3DE2846(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BAD810C9-F5B1-42DC-9C7A-3306F3DE2846(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetDirectXManager(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pManager
        );

        /// <summary>
        /// Releases all of the video samples that have been allocated.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT UninitializeSampleAllocator();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/7BCB0425-00AC-4FDC-83A8-2B2686979A1D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7BCB0425-00AC-4FDC-83A8-2B2686979A1D(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int UninitializeSampleAllocator();

        /// <summary>
        /// Specifies the number of samples to allocate and the media type for the samples. 
        /// </summary>
        /// <param name="cRequestedFrames">Number of samples to allocate.</param>
        /// <param name="pMediaType">Pointer to the <see cref="IMFMediaType" /> interface of a media type that describes the video
        /// format.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_INVALIDMEDIATYPE</strong></term><description>Invalid media type.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT InitializeSampleAllocator(
        /// [in]  DWORD cRequestedFrames,
        /// [in]  IMFMediaType *pMediaType
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/B1E4557E-990C-4239-B9EC-5C7C46072E54(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B1E4557E-990C-4239-B9EC-5C7C46072E54(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int InitializeSampleAllocator(
            [In] int cRequestedFrames,
            [In, MarshalAs(UnmanagedType.Interface)] IMFMediaType pMediaType
        );

        /// <summary>
        /// Gets a video sample from the allocator. 
        /// </summary>
        /// <param name="ppSample">Receives a pointer to the <see cref="IMFSample" /> interface. The caller must release the interface.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_NOT_INITIALIZED</strong></term><description>The allocator was not initialized. Call <see cref="IMFVideoSampleAllocator.InitializeSampleAllocator"/> or <c>InitializeSampleAllocatorEx::InitializeSampleAllocatorEx</c>. </description></item>
        /// <item><term><strong>MF_E_SAMPLEALLOCATOR_EMPTY</strong></term><description> No samples are available. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT AllocateSample(
        /// [out]  IMFSample **ppSample
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/E5347CEF-EDBD-4F6A-88C9-042E53515A32(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E5347CEF-EDBD-4F6A-88C9-042E53515A32(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int AllocateSample(
            [MarshalAs(UnmanagedType.Interface)] out IMFSample ppSample
        );

        #endregion

        /// <summary>
        /// Initializes the video sample allocator object.
        /// </summary>
        /// <param name="cInitialSamples">
        /// The initial number of samples to allocate. 
        /// </param>
        /// <param name="cMaximumSamples">
        /// The maximum number of samples to allocate.
        /// </param>
        /// <param name="pAttributes">
        /// A pointer to the <see cref="IMFAttributes"/> interface. You can use this interface to configure the
        /// allocator. Currently, the following configuration attributes are defined: 
        /// <para/>
        /// <para>* <see cref="MFAttributesClsid.MF_SA_BUFFERS_PER_SAMPLE"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_SA_D3D11_BINDFLAGS"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_SA_D3D11_USAGE"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_SA_D3D11_SHARED"/></para><para>* 
        /// <c>MF_SA_D3D11_SHARED_WITHOUT_MUTEX</c></para>
        /// </param>
        /// <param name="pMediaType">
        /// A pointer to the <see cref="IMFMediaType"/> interface of a media type that describes the video
        /// format. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT InitializeSampleAllocatorEx(
        ///   [in]  DWORD cInitialSamples,
        ///   [in]  DWORD cMaximumSamples,
        ///   [in]  IMFAttributes *pAttributes,
        ///   [in]  IMFMediaType *pMediaType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0AE0826D-058C-4A2F-94F2-A761CA885E67(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0AE0826D-058C-4A2F-94F2-A761CA885E67(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int InitializeSampleAllocatorEx( 
            int cInitialSamples,
            int cMaximumSamples,
            IMFAttributes pAttributes,
            IMFMediaType pMediaType
        );        
    }

#endif

}
