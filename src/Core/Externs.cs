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
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;

using MediaFoundation.Misc;
using MediaFoundation.Transform;
using MediaFoundation.ReadWrite;
using MediaFoundation.MFPlayer;
using MediaFoundation.EVR;
using MediaFoundation.Core.Enums;
using MediaFoundation.Core.Interfaces;
using MediaFoundation.Transform.Classes;

namespace MediaFoundation.Core
{
    /// <summary>
    /// This class exposes many of the Media Foundation API functions
    /// as well as additional API functions often used in conjunction
    /// with the the Media Foundation.
    /// </summary>
    internal static class MFExtern
    {
        /// <summary>
        /// Creates an in-memory property store.
        /// </summary>
        /// <param name="riid">Type: <strong>REFIID</strong><para />
        /// Reference to the requested interface ID.</param>
        /// <param name="propStore">Type: <strong>void**</strong><para />
        /// When this function returns, contains a pointer to the desired interface, typically
        /// <see cref="Misc.IPropertyStore" /> or <c>IPersistSerializedPropStorage</c>.</param>
        /// <returns>Type: <strong>HRESULT</strong><para />
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code.</returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT PSCreateMemoryPropertyStore(
        /// _In_   REFIID riid,
        /// _Out_  void **ppv
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/6E7A2AC0-2A4A-41EC-A2A8-DDBE8AA45BC9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6E7A2AC0-2A4A-41EC-A2A8-DDBE8AA45BC9(v=VS.85,d=hv.2).aspx</a></remarks>
        [DllImport("Propsys.dll")]
        [SuppressUnmanagedCodeSecurity]
        public static extern int PSCreateMemoryPropertyStore(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            /* [MarshalAs(UnmanagedType.IUnknown)] out object */ out IntPtr propStore);

        /// <summary>
        /// Shuts down the Microsoft Media Foundation platform. Call this function once for every call to
        /// <see cref="MFStartup"/>. Do not call this function from work queue threads.
        /// </summary>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFShutdown(void);
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/10BE2361-B5B4-4C10-92A1-527CA22C74E4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/10BE2361-B5B4-4C10-92A1-527CA22C74E4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int MFShutdown();

        /// <summary>
        /// Initializes Microsoft Media Foundation.
        /// </summary>
        /// <param name="version">
        /// Version number. Use the value <strong>MF_VERSION</strong>, defined in mfapi.h.
        /// See also <see cref="MF_VERSION"/>.
        /// </param>
        /// <param name="dwFlags">
        /// This parameter is optional when using C++ but required in C. The value must be one of the following
        /// flags:
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>MFSTARTUP_NOSOCKET</term><description> Do not initialize the sockets library. </description></item>
        /// <item><term>MFSTARTUP_LITE</term><description> Equivalent to MFSTARTUP_NOSOCKET. </description></item>
        /// <item><term>MFSTARTUP_FULL</term><description> Initialize the entire Media Foundation platform. This is the default value when <em>dwFlags</em> is not specified. </description></item>
        /// </list>
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded.</description></item>
        /// <item><term><strong>MF_E_BAD_STARTUP_VERSION</strong></term><description> The <em>Version</em> parameter requires a newer version of Media Foundation than the version that is running. </description></item>
        /// <item><term><strong>MF_E_DISABLED_IN_SAFEMODE</strong></term><description> The Media Foundation platform is disabled because the system was started in "Safe Mode" (fail-safe boot). </description></item>
        /// <item><term><strong>E_NOTIMPL</strong></term><description>Media Foundation is not implemented on the system. This error can occur if the media components are not present (See <c>KB2703761</c> for more info). </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFStartup(
        ///   ULONG Version,
        ///   DWORD dwFlags = MFSTARTUP_FULL
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/B4472E40-3681-4B26-9385-4DF7BF19C2D8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B4472E40-3681-4B26-9385-4DF7BF19C2D8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int MFStartup(
            int version,
            MFStartup dwFlags);

        /// <summary>
        /// Version of the Media Foundation SDK. This is the Windows 7 or higher version.
        /// </summary>
        public const int MF_SDK_VERSION_WIN7 = 0x0002;

        /// <summary>
        /// Version of the Media Foundation SDK. This is the Windows Vista (and not Windows 7 or higher).
        /// </summary>
        public const int MF_SDK_VERSION_WINVISTA = 0x0001;

        /// <summary>
        /// This value is unused in the Win7 release and left at its Vista release value.
        /// </summary>
        public const int MF_API_VERSION = 0x0070;

        /// <summary>
        /// Version number of the Media Foundation used in conjunction with <see cref="MFStartup"/>
        /// when the operating system is Windows 7 or newer.
        /// </summary>
        public const int MF_VERSION_WIN7 = ((MF_SDK_VERSION_WIN7 << 16) | MF_API_VERSION);

        /// <summary>
        /// Version number of the Media Foundation used in conjunction with <see cref="MFStartup"/>
        /// when the operating system is Windows Vista.
        /// </summary>
        public const int MF_VERSION_WINVISTA = ((MF_SDK_VERSION_WINVISTA << 16) | MF_API_VERSION);

        /// <summary>
        /// Version number of the Media Foundation used in conjunction with <see cref="MFStartup"/>.
        /// This depends on the current operating system.
        /// </summary>
        public static readonly int MF_VERSION = ((Environment.OSVersion.Platform == PlatformID.Win32NT)
            && (Environment.OSVersion.Version.Major == 6) && (Environment.OSVersion.Version.Minor == 0))
                ? MF_VERSION_WINVISTA : MF_VERSION_WIN7; // Vista (and 2008) is version 6.0.x.x. Windows 7 is 6.1.x.x

#if NOT_IN_USE
        /// <summary>
        /// Creates a presentation time source that is based on the system time.
        /// </summary>
        /// <param name="ppSystemTimeSource">
        /// Receives a pointer to the object's <see cref="IMFPresentationTimeSource"/> interface. The caller
        /// must release the interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateSystemTimeSource(
        ///   IMFPresentationTimeSource **ppSystemTimeSource
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F3E7B8D5-FD6C-4D87-86F6-1117CA58BC6F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F3E7B8D5-FD6C-4D87-86F6-1117CA58BC6F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateSystemTimeSource(
            out IMFPresentationTimeSource ppSystemTimeSource
        );

        /// <summary>
        /// Creates an empty collection object.
        /// </summary>
        /// <param name="ppIMFCollection">
        /// Receives a pointer to the collection object's <see cref="IMFCollection"/> interface. The caller
        /// must release the interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateCollection(
        ///   _Out_  IMFCollection **ppIMFCollection
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6A7BF7B6-62F1-4EAC-9849-39021EE50F42(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6A7BF7B6-62F1-4EAC-9849-39021EE50F42(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateCollection(
            out IMFCollection ppIMFCollection
        );

        /// <summary>
        /// Creates a stream descriptor. 
        /// </summary>
        /// <param name="dwStreamIdentifier">
        /// Stream identifier. 
        /// </param>
        /// <param name="cMediaTypes">
        /// Number of elements in the <em>apMediaTypes</em> array. 
        /// </param>
        /// <param name="apMediaTypes">
        /// Pointer to an array of <see cref="IMFMediaType"/> interface pointers. These pointers are used to
        /// initialize the media type handler for the stream descriptor. 
        /// </param>
        /// <param name="ppDescriptor">
        /// Receives a pointer to the <see cref="IMFStreamDescriptor"/> interface of the new stream descriptor.
        /// The caller must release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateStreamDescriptor(
        ///   DWORD dwStreamIdentifier,
        ///   DWORD cMediaTypes,
        ///   IMFMediaType **apMediaTypes,
        ///   IMFStreamDescriptor **ppDescriptor
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/77A63D30-C03F-4339-9DB3-EDA60DB9B194(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/77A63D30-C03F-4339-9DB3-EDA60DB9B194(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateStreamDescriptor(
            int dwStreamIdentifier,
            int cMediaTypes,
            [In, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IMFMediaType[] apMediaTypes,
            out IMFStreamDescriptor ppDescriptor
        );

        /// <summary>
        /// [This API is not supported and may be altered or unavailable in the future. Instead, applications
        /// should use the <strong>PSCreateMemoryPropertyStore</strong> function to create property stores.] 
        /// <para/>
        /// Creates an empty property store object.
        /// </summary>
        /// <param name="ppStore">
        /// Receives a pointer to the <strong>IPropertyStore</strong> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT CreatePropertyStore(
        ///   _Out_  IPropertyStore **ppStore
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BB0D32EF-EC16-4341-8B66-D57EBEC785F9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BB0D32EF-EC16-4341-8B66-D57EBEC785F9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [Obsolete("Use PSCreateMemoryPropertyStore instead.")]
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int CreatePropertyStore(
            out IPropertyStore ppStore
        );
#endif

        /// <summary>
        /// Creates an empty attribute store.
        /// </summary>
        /// <param name="ppMFAttributes">
        /// Receives a pointer to the <see cref="IMFAttributes"/> interface. The caller must release the
        /// interface.
        /// </param>
        /// <param name="cInitialSize">
        /// The initial number of elements allocated for the attribute store. The attribute store grows as
        /// needed.
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateAttributes(
        ///   _Out_  IMFAttributes **ppMFAttributes,
        ///   _In_   UINT32 cInitialSize
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/A79B1EDD-5CA1-4550-A6CE-58073155AFFD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A79B1EDD-5CA1-4550-A6CE-58073155AFFD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateAttributes(
            /* out IMFAttributes */ out IntPtr ppMFAttributes,
            int cInitialSize);

#if NOT_IN_USE

        /// <summary>
        /// Converts a Media Foundation audio media type to a <strong>WAVEFORMATEX</strong> structure. 
        /// </summary>
        /// <param name="pMFType">
        /// Pointer to the <see cref="IMFMediaType"/> interface of the media type. 
        /// </param>
        /// <param name="ppWF">
        /// Receives a pointer to the <strong>WAVEFORMATEX</strong> structure. The caller must release the
        /// memory allocated for the structure by calling <c>CoTaskMemFree</c>. 
        /// </param>
        /// <param name="pcbSize">
        /// Receives the size of the <strong>WAVEFORMATEX</strong> structure. 
        /// </param>
        /// <param name="Flags">
        /// Contains a flag from the <see cref="MFWaveFormatExConvertFlags"/> enumeration. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateWaveFormatExFromMFMediaType(
        ///   IMFMediaType *pMFType,
        ///   WAVEFORMATEX **ppWF,
        ///   UINT32 *pcbSize,
        ///   UINT32 Flags = MFWaveFormatExConvertFlag_Normal
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B124BAC2-90DE-4358-A079-F509A89C3776(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B124BAC2-90DE-4358-A079-F509A89C3776(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateWaveFormatExFromMFMediaType(
            IMFMediaType pMFType,
            [Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(WEMarshaler))] out WaveFormatEx ppWF,
            out int pcbSize,
            MFWaveFormatExConvertFlags Flags
        );

        /// <summary>
        /// Creates an asynchronous result object. Use this function if you are implementing an asynchronous
        /// method.
        /// </summary>
        /// <param name="punkObject">
        /// Pointer to the object stored in the asynchronous result. This pointer is returned by the 
        /// <see cref="IMFAsyncResult.GetObject"/> method. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="pCallback">
        /// Pointer to the <see cref="IMFAsyncCallback"/> interface. This interface is implemented by the
        /// caller of the asynchronous method. 
        /// </param>
        /// <param name="punkState">
        /// Pointer to the <strong>IUnknown</strong> interface of a state object. This value is provided by the
        /// caller of the asynchronous method. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="ppAsyncResult">
        /// Receives a pointer to the <see cref="IMFAsyncResult"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateAsyncResult(
        ///   IUnknown *punkObject,
        ///   IMFAsyncCallback *pCallback,
        ///   IUnknown *punkState,
        ///   IMFAsyncResult **ppAsyncResult
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6FF773A9-961E-4A5E-AD37-46234022C575(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6FF773A9-961E-4A5E-AD37-46234022C575(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateAsyncResult(
            [MarshalAs(UnmanagedType.IUnknown)] object punkObject,
            IMFAsyncCallback pCallback,
            [MarshalAs(UnmanagedType.IUnknown)] object punkState,
            out IMFAsyncResult ppAsyncResult
        );

        /// <summary>
        /// Invokes a callback method to complete an asynchronous operation. 
        /// </summary>
        /// <param name="pAsyncResult">
        /// Pointer to the <see cref="IMFAsyncResult"/> interface. To create this object, call 
        /// <see cref="MFExtern.MFCreateAsyncResult"/>. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description> The function succeeded. </description></item>
        /// <item><term><strong><strong>MF_E_INVALID_WORKQUEUE</strong></strong></term><description>Invalid work queue. For more information, see <see cref="IMFAsyncCallback.GetParameters"/>. </description></item>
        /// <item><term><strong><strong>MF_E_SHUTDOWN</strong></strong></term><description>The <see cref="MFExtern.MFShutdown"/> function was called to shut down the Media Foundation platform. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFInvokeCallback(
        ///   IMFAsyncResult *pAsyncResult
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/28832D50-9B15-4EB0-96F9-2032D4EDCAF4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/28832D50-9B15-4EB0-96F9-2032D4EDCAF4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFInvokeCallback(
            IMFAsyncResult pAsyncResult
        );

        /// <summary>
        /// Creates a presentation descriptor.
        /// </summary>
        /// <param name="cStreamDescriptors">
        /// Number of elements in the <em>apStreamDescriptors</em> array. 
        /// </param>
        /// <param name="apStreamDescriptors">
        /// Array of <see cref="IMFStreamDescriptor"/> interface pointers. Each pointer represents a stream
        /// descriptor for one stream in the presentation. 
        /// </param>
        /// <param name="ppPresentationDescriptor">
        /// Receives a pointer to an <see cref="IMFPresentationDescriptor"/> interface of the presentation
        /// descriptor. The caller must release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreatePresentationDescriptor(
        ///   DWORD cStreamDescriptors,
        ///   IMFStreamDescriptor **apStreamDescriptors,
        ///   IMFPresentationDescriptor **ppPresentationDescriptor
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/288AB078-5490-41A2-A3B5-87A97AA57739(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/288AB078-5490-41A2-A3B5-87A97AA57739(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreatePresentationDescriptor(
            int cStreamDescriptors,
            [In, MarshalAs(UnmanagedType.LPArray)] IMFStreamDescriptor[] apStreamDescriptors,
            out IMFPresentationDescriptor ppPresentationDescriptor
        );

        /// <summary>
        /// Initializes a media type from a <strong>WAVEFORMATEX</strong> structure. 
        /// </summary>
        /// <param name="pMFType">
        /// Pointer to the <see cref="IMFMediaType"/> interface of the media type to initialize. To create the
        /// uninitialized media type object, call <see cref="MFExtern.MFCreateMediaType"/>. 
        /// </param>
        /// <param name="ppWF">
        /// Pointer to a <strong>WAVEFORMATEX</strong> structure that describes the media type. The caller must
        /// fill in the structure members before calling this function. 
        /// </param>
        /// <param name="cbBufSize">
        /// Size of the <strong>WAVEFORMATEX</strong> structure, in bytes. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFInitMediaTypeFromWaveFormatEx(
        ///   IMFMediaType *pMFType,
        ///   const WAVEFORMATEX *pWaveFormat,
        ///   UINT32 cbBufSize
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/91A201A6-06CF-4445-AD62-FDABB3848D51(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/91A201A6-06CF-4445-AD62-FDABB3848D51(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFInitMediaTypeFromWaveFormatEx(
            IMFMediaType pMFType,
            [In, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(WEMarshaler))] WaveFormatEx ppWF,
            int cbBufSize
        );

        /// <summary>
        /// Creates an event queue.
        /// </summary>
        /// <param name="ppMediaEventQueue">
        /// Receives a pointer to the <see cref="IMFMediaEventQueue"/> interface of the event queue. The caller
        /// must release the interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateEventQueue(
        ///   IMFMediaEventQueue **ppMediaEventQueue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/214CEA99-37CF-4571-AA00-7B3E220A6B84(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/214CEA99-37CF-4571-AA00-7B3E220A6B84(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateEventQueue(
            out IMFMediaEventQueue ppMediaEventQueue
        );

#endif

        /// <summary>
        /// Creates an empty media type.
        /// </summary>
        /// <param name="ppMFType">
        /// Receives a pointer to the <see cref="IMFMediaType"/> interface. The caller must release the
        /// interface.
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateMediaType(
        ///   IMFMediaType **ppMFType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/05B0941E-03CE-4CED-9022-22B65D1C4B4C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/05B0941E-03CE-4CED-9022-22B65D1C4B4C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateMediaType(
            /* out IMFMediaType */ out IntPtr ppMFType);

#if NOT_IN_USE

        /// <summary>
        /// Creates a media event object.
        /// </summary>
        /// <param name="met">
        /// The event type. See <see cref="IMFMediaEvent.GetType"/>. For a list of event types, see 
        /// <c>Media Foundation Events</c>. 
        /// </param>
        /// <param name="guidExtendedType">
        /// The extended type. See <see cref="IMFMediaEvent.GetExtendedType"/>. If the event type does not have
        /// an extended type, use the value GUID_NULL. 
        /// </param>
        /// <param name="hrStatus">
        /// The event status. See <see cref="IMFMediaEvent.GetStatus"/>
        /// </param>
        /// <param name="pvValue">
        /// The value associated with the event, if any. See <see cref="IMFMediaEvent.GetValue"/>. This
        /// parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="ppEvent">
        /// Receives a pointer to the <see cref="IMFMediaEvent"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateMediaEvent(
        ///   MediaEventType met,
        ///   REFGUID guidExtendedType,
        ///   HRESULT hrStatus,
        ///   const PROPVARIANT *pvValue,
        ///   IMFMediaEvent **ppEvent
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/64DA695E-5F56-4F23-9A06-0B0C358E3CC3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/64DA695E-5F56-4F23-9A06-0B0C358E3CC3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateMediaEvent(
            MediaEventType met,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidExtendedType,
            int hrStatus,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant pvValue,
            out IMFMediaEvent ppEvent
        );

#endif

        /// <summary>
        /// Creates an empty media sample.
        /// </summary>
        /// <param name="ppIMFSample">
        /// Receives a pointer to the <see cref="IMFSample"/> interface of the media sample. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateSample(
        ///   IMFSample **ppIMFSample
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B8BC29A5-E872-4C7B-AD1D-6C6085AA1984(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B8BC29A5-E872-4C7B-AD1D-6C6085AA1984(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateSample(
            /* out IMFSample */ out IntPtr ppIMFSample
        );
        
        /// <summary>
        /// Allocates system memory and creates a media buffer to manage it.
        /// </summary>
        /// <param name="cbMaxLength">
        /// Size of the buffer, in bytes.
        /// </param>
        /// <param name="ppBuffer">
        /// Receives a pointer to the <see cref="IMFMediaBuffer"/> interface of the media buffer. The caller
        /// must release the interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// <item><term><strong>E_OUTOFMEMORY</strong></term><description>Insufficient memory.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateMemoryBuffer(
        ///   DWORD cbMaxLength,
        ///   IMFMediaBuffer **ppBuffer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1F79D057-7EF7-4662-9F82-CEADC23276F0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1F79D057-7EF7-4662-9F82-CEADC23276F0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateMemoryBuffer(
            int cbMaxLength,
            /* out IMFMediaBuffer */ out IntPtr ppBuffer
        );

        /// <summary>
        /// Queries an object for a specified service interface.
        /// <para/>
        /// This function is a helper function that wraps the <see cref="IMFGetService.GetService"/> method.
        /// The function queries the object for the <see cref="IMFGetService"/> interface and, if successful,
        /// calls <strong>GetService</strong> on the object.
        /// </summary>
        /// <param name="punkObject">
        /// A pointer to the <strong>IUnknown</strong> interface of the object to query.
        /// </param>
        /// <param name="guidService">
        /// The service identifier (SID) of the service. For a list of service identifiers, see
        /// <c>Service Interfaces</c>.
        /// </param>
        /// <param name="riid">
        /// The interface identifier (IID) of the interface being requested.
        /// </param>
        /// <param name="ppvObject">
        /// Receives the interface pointer. The caller must release the interface.
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_UNSUPPORTED_SERVICE</strong></term><description> The service requested cannot be found in the object represented by <em>punkObject</em>. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFGetService(
        ///   IUnknown *punkObject,
        ///   REFGUID guidService,
        ///   REFIID riid,
        ///   LPVOID *ppvObject
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/119E9E2F-0E26-4DFC-9C89-156B63A63640(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/119E9E2F-0E26-4DFC-9C89-156B63A63640(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int MFGetService(
            [In, MarshalAs(UnmanagedType.Interface)] object punkObject,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidService,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            /* [Out, MarshalAs(UnmanagedType.Interface)] out object */ out IntPtr ppvObject);

        /// <summary>
        /// Creates an activation object for the enhanced video renderer (EVR) media sink.
        /// </summary>
        /// <param name="hwndVideo">
        /// Handle to the window where the video will be displayed.
        /// </param>
        /// <param name="ppActivate">
        /// Receives a pointer to the <see cref="IMFActivate"/> interface. Use this interface to create the
        /// EVR. The caller must release the interface.
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateVideoRendererActivate(
        ///   _In_   HWND hwndVideo,
        ///   _Out_  IMFActivate **ppActivate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/021887FC-36AF-42D4-AE46-2EDC1C700110(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/021887FC-36AF-42D4-AE46-2EDC1C700110(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateVideoRendererActivate(
            IntPtr hwndVideo,
            /* out IMFActivate */ out IntPtr ppActivate);

        /// <summary>
        /// Creates a topology node.
        /// </summary>
        /// <param name="nodeType">
        /// The type of node to create, specified as a member of the <see cref="MFTopologyType"/> enumeration.
        /// </param>
        /// <param name="ppNode">
        /// Receives a pointer to the node's <see cref="IMFTopologyNode"/> interface. The caller must release
        /// the interface.
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateTopologyNode(
        ///   _In_   MF_TOPOLOGY_TYPE NodeType,
        ///   _Out_  IMFTopologyNode **ppNode
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/67C32232-09CB-4098-B80B-4B93EE121190(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/67C32232-09CB-4098-B80B-4B93EE121190(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateTopologyNode(
            MFTopologyType nodeType,
            /* out IMFTopologyNode */ out IntPtr ppNode);

        /// <summary>
        /// Creates the source resolver, which is used to create a media source from a URL or byte stream.
        /// </summary>
        /// <param name="ppISourceResolver">
        /// Receives a pointer to the source resolver's <see cref="IMFSourceResolver"/> interface. The caller
        /// must release the interface.
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateSourceResolver(
        ///   _Out_  IMFSourceResolver **ppISourceResolver
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/60D6B0E2-5AB2-4A20-99D9-E6B806A1F576(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/60D6B0E2-5AB2-4A20-99D9-E6B806A1F576(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateSourceResolver(
            /* out IMFSourceResolver */ out IntPtr ppISourceResolver);

        /// <summary>
        /// Creates the <c>Media Session</c> in the application's process.
        /// </summary>
        /// <param name="pConfiguration">
        /// Pointer to the <see cref="IMFAttributes"/> interface. This parameter can be <strong>NULL</strong>.
        /// See Remarks.
        /// </param>
        /// <param name="ppMediaSession">
        /// Receives a pointer to the Media Session's <see cref="IMFMediaSession"/> interface. The caller must
        /// release the interface. Before releasing the last reference to the <strong>IMFMediaSession</strong>
        /// pointer, the application must call the <see cref="IMFMediaSession.Shutdown"/> method.
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The function succeeded. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateMediaSession(
        ///   IMFAttributes *pConfiguration,
        ///   IMFMediaSession **ppMS
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/86B2B5EC-231C-4943-9ADD-1A5A60E72268(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/86B2B5EC-231C-4943-9ADD-1A5A60E72268(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateMediaSession(
            IMFAttributes pConfiguration,
            /* out IMFMediaSession */ out IntPtr ppMediaSession);

        /// <summary>
        /// Creates a topology object.
        /// </summary>
        /// <param name="ppTopo">
        /// Receives a pointer to the <see cref="IMFTopology"/> interface of the topology object. The caller
        /// must release the interface.
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateTopology(
        ///   IMFTopology **ppTopo
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/9811ECA7-E822-4FF7-93E4-2EB6245D4490(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9811ECA7-E822-4FF7-93E4-2EB6245D4490(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateTopology(
            /* out IMFTopology */ out IntPtr ppTopo);

        /// <summary>
        /// Creates an activation object for the <c>Streaming Audio Renderer</c>.
        /// </summary>
        /// <param name="ppActivate">
        /// Receives a pointer to the <see cref="IMFActivate"/> interface. Use this interface to create the
        /// audio renderer. The caller must release the interface.
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateAudioRendererActivate(
        ///   _Out_  IMFActivate **ppActivate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/BCE55C34-D64A-4F3B-8D09-6C9363E4EB11(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BCE55C34-D64A-4F3B-8D09-6C9363E4EB11(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateAudioRendererActivate(
            /* out IMFActivate */ out IntPtr ppActivate);

#if NOT_IN_USE

        /// <summary>
        /// Creates the presentation clock. The presentation clock is used to schedule the time at which
        /// samples are rendered and to synchronize multiple streams. 
        /// </summary>
        /// <param name="ppPresentationClock">
        /// Receives a pointer to the clock's <see cref="IMFPresentationClock"/> interface. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreatePresentationClock(
        ///   IMFPresentationClock **ppPresentationClock
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B0ED3482-D127-45D3-A4DE-271B1C0A199B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B0ED3482-D127-45D3-A4DE-271B1C0A199B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreatePresentationClock(
            out IMFPresentationClock ppPresentationClock
        );

        /// <summary>
        /// Enumerates a list of audio or video capture devices.
        /// </summary>
        /// <param name="pAttributes">
        /// Pointer to an attribute store that contains search criteria. To create the attribute store, call 
        /// <see cref="MFExtern.MFCreateAttributes"/>. Set one or more of the following attributes on the
        /// attribute store: 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong><see cref="MFAttributesClsid.MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE"/></strong></term><description>Specifies whether to enumerate audio or video devices. (Required.)</description></item>
        /// <item><term><strong><see cref="MFAttributesClsid.MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_ROLE"/></strong></term><description>For audio capture devices, specifies the device role. (Optional.)</description></item>
        /// <item><term><strong><see cref="MFAttributesClsid.MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_CATEGORY"/></strong></term><description>For video capture devices, specifies the device category. (Optional.)</description></item>
        /// </list>
        /// </param>
        /// <param name="pppSourceActivate">
        /// Receives an array of <see cref="IMFActivate"/> interface pointers. Each pointer represents an
        /// activation object for a media source. The function allocates the memory for the array. The caller
        /// must release the pointers in the array and call <c>CoTaskMemFree</c> to free the memory for the
        /// array. 
        /// </param>
        /// <param name="pcSourceActivate">
        /// Receives the number of elements in the <em>pppSourceActivate</em> array. If no capture devices
        /// match the search criteria, this parameter receives the value 0. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFEnumDeviceSources(
        ///   _In_   IMFAttributes *pAttributes,
        ///   _Out_  IMFActivate ***pppSourceActivate,
        ///   _Out_  UINT32 *pcSourceActivate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DA4D96CE-E22B-4E1C-AA2E-DF46416A5F0B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DA4D96CE-E22B-4E1C-AA2E-DF46416A5F0B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFEnumDeviceSources(
            IMFAttributes pAttributes,
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out IMFActivate[] pppSourceActivate,
            out int pcSourceActivate
        );

        /// <summary>
        /// Adds information about a Media Foundation transform (MFT) to the registry. 
        /// <para/>
        /// Applications can enumerate the MFT by calling the <see cref="MFExtern.MFTEnum"/> or 
        /// <see cref="MFExtern.MFTEnumEx"/> function. 
        /// </summary>
        /// <param name="clsidMFT">
        /// The CLSID of the MFT. The MFT must also be registered as a COM object using the same CLSID.
        /// </param>
        /// <param name="guidCategory">
        /// GUID that specifies the category of the MFT. For a list of MFT categories, see <c>MFT_CATEGORY</c>.
        /// </param>
        /// <param name="pszName">
        /// Wide-character string that contains the friendly name of the MFT.
        /// </param>
        /// <param name="Flags">
        /// Bitwise <strong>OR</strong> of zero or more of the following flags from the <c>_MFT_ENUM_FLAG</c>
        /// enumeration: 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>MFT_ENUM_FLAG_ASYNCMFT</strong></term><description>The MFT performs asynchronous processing in software. See <c>Asynchronous MFTs</c>. This flag does not apply to hardware transforms. Requires Windows 7.</description></item>
        /// <item><term><strong>MFT_ENUM_FLAG_FIELDOFUSE</strong></term><description>The application must unlock the MFT in order to use it. See <see cref="IMFFieldOfUseMFTUnlock"/>. Requires Windows 7.</description></item>
        /// <item><term><strong>MFT_ENUM_FLAG_HARDWARE</strong></term><description>The MFT performs hardware-based data processing, using either the AVStream driver or a GPU-based proxy MFT. MFTs in this category always process data asynchronously. See <c>Hardware MFTs</c>. <strong>Note</strong> This flag applies to video codecs and video processors that perform their work entirely in hardware. It does not apply to software decoders that use DirectX Video Acceleration to assist decoding. Requires Windows 7.</description></item>
        /// <item><term><strong>MFT_ENUM_FLAG_SYNCMFT</strong></term><description>The MFT performs synchronous processing in software. This flag does not apply to hardware transforms.</description></item>
        /// <item><term><strong>MFT_ENUM_FLAG_TRANSCODE_ONLY</strong></term><description>The MFT is optimized for transcoding and should not be used for playback.Requires Windows 7.</description></item>
        /// </list>
        /// <para/>
        /// Setting <em>Flags</em> to zero is equivalent to setting the <strong>MFT_ENUM_FLAG_SYNCMFT</strong>
        /// flag. The default processing model for MFTs is synchronous processing. 
        /// <para/>
        /// Prior to Windows 7, the <em>Flags</em> parameter was reserved. 
        /// </param>
        /// <param name="cInputTypes">
        /// Number of elements in the <em>pInputTypes</em> array. 
        /// </param>
        /// <param name="pInputTypes">
        /// Pointer to an array of <see cref="Transform.MFTRegisterTypeInfo"/> structures. Each member of the
        /// array specifies an input format that the MFT supports. This parameter can be <strong>NULL</strong>.
        /// <para/>
        /// This parameter can be <strong>NULL</strong>. However, if the parameter is <strong>NULL</strong>,
        /// the MFT will be enumerated only when an application specifies <strong>NULL</strong> for the desired
        /// input type. 
        /// </param>
        /// <param name="cOutputTypes">
        /// Number of elements in the <em>pOutputTypes</em> array. 
        /// </param>
        /// <param name="pOutputTypes">
        /// Pointer to an array of <see cref="Transform.MFTRegisterTypeInfo"/> structures. Each member of the
        /// array defines an output format that the MFT supports. 
        /// <para/>
        /// This parameter can be <strong>NULL</strong>. However, if the parameter is <strong>NULL</strong>,
        /// the MFT will be enumerated only when an application specifies <strong>NULL</strong> for the desired
        /// output type. 
        /// </param>
        /// <param name="pAttributes">
        /// Pointer to the <see cref="IMFAttributes"/> interface of an attribute store that contains additional
        /// registry information. This parameter can be <strong>NULL</strong>. If the parameter is non- 
        /// <strong>NULL</strong>, the attributes are written to the registery as a byte array. You can use the
        /// <see cref="MFExtern.MFTGetInfo"/> function to retrieve the attributes. 
        /// <para/>
        /// The following attribute is defined for this parameter:
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong><see cref="MFAttributesClsid.MFT_CODEC_MERIT_Attribute"/></strong></term><description>Contains the merit value of a hardware codec. See <c>Codec Merit</c>. </description></item>
        /// </list>
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFTRegister(
        ///   _In_  CLSID clsidMFT,
        ///   _In_  GUID guidCategory,
        ///   _In_  LPWSTR pszName,
        ///   _In_  UINT32 Flags,
        ///   _In_  UINT32 cInputTypes,
        ///   _In_  MFT_REGISTER_TYPE_INFO *pInputTypes,
        ///   _In_  UINT32 cOutputTypes,
        ///   _In_  MFT_REGISTER_TYPE_INFO *pOutputTypes,
        ///   _In_  IMFAttributes *pAttributes
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FB3A2B67-D3E4-4D5F-960A-3979F4780904(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FB3A2B67-D3E4-4D5F-960A-3979F4780904(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", CharSet = CharSet.Unicode, ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFTRegister(
            [In, MarshalAs(UnmanagedType.Struct)] Guid clsidMFT,
            [In, MarshalAs(UnmanagedType.Struct)] Guid guidCategory,
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszName,
            [In] int Flags, // Must be zero
            [In] int cInputTypes,
            [In, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(RTAMarshaler))]
            object pInputTypes, // should be MFTRegisterTypeInfo[], but .Net bug prevents in x64
            [In] int cOutputTypes,
            [In, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(RTAMarshaler))]
            object pOutputTypes, // should be MFTRegisterTypeInfo[], but .Net bug prevents in x64
            [In] IMFAttributes pAttributes
            );

        /// <summary>
        /// Unregisters a Media Foundation transform (MFT). 
        /// </summary>
        /// <param name="clsidMFT">
        /// The CLSID of the MFT. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFTUnregister(
        ///   _In_  CLSID clsidMFT
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2E63A098-5B83-4EA9-8149-4972F8ED0944(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2E63A098-5B83-4EA9-8149-4972F8ED0944(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFTUnregister(
            [In, MarshalAs(UnmanagedType.Struct)] Guid clsidMFT
            );

        /// <summary>
        /// Gets information from the registry about a Media Foundation transform (MFT). 
        /// </summary>
        /// <param name="clsidMFT">
        /// The CLSID of the MFT. 
        /// </param>
        /// <param name="pszName">
        /// Receives a pointer to a wide-character string containing the friendly name of the MFT. The caller
        /// must free the string by calling <c>CoTaskMemFree</c>. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="ppInputTypes">
        /// Receives a pointer to an array of <see cref="Transform.MFTRegisterTypeInfo"/> structures. Each
        /// member of the array describes an input format that the MFT supports. The caller must free the array
        /// by calling <c>CoTaskMemFree</c>. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="pcInputTypes">
        /// Receives the number of elements in the <em>ppInputTypes</em> array. If <em>ppInputTypes</em> is 
        /// <strong>NULL</strong>, this parameter is ignored and can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="ppOutputTypes">
        /// Receives a pointer to an array of <see cref="Transform.MFTRegisterTypeInfo"/> structures. Each
        /// member of the array describes an output format that the MFT supports. The caller must free the
        /// array by calling <c>CoTaskMemFree</c>. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="pcOutputTypes">
        /// Receives the number of elements in the <em>ppOutputType</em> array. If <em>ppOutputTypes</em> is 
        /// <strong>NULL</strong>, this parameter is ignored and can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="ip">
        /// Receives a pointer to the <see cref="IMFAttributes"/> interface of an attribute store. The caller
        /// must release the interface. The attribute store might contain attributes that are stored in the
        /// registry for the specified MFT. (For more information, see <see cref="MFExtern.MFTRegister"/>.) If
        /// no attributes are stored in the registry for this MFT, the attribute store is empty. 
        /// <para/>
        /// This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFTGetInfo(
        ///   _In_   CLSID clsidMFT,
        ///   _Out_  LPWSTR *pszName,
        ///   _Out_  MFT_REGISTER_TYPE_INFO **ppInputTypes,
        ///   _Out_  UINT32 *pcInputTypes,
        ///   _Out_  MFT_REGISTER_TYPE_INFO **ppOutputTypes,
        ///   _Out_  UINT32 *pcOutputTypes,
        ///   _Out_  IMFAttributes **ppAttributes
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D1BAC1C7-3F9B-46B7-BDF7-C32983C648EE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D1BAC1C7-3F9B-46B7-BDF7-C32983C648EE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", CharSet = CharSet.Unicode, ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFTGetInfo(
            [In, MarshalAs(UnmanagedType.Struct)] Guid clsidMFT,
            [MarshalAs(UnmanagedType.LPWStr)] out string pszName,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalCookie = "0", MarshalTypeRef = typeof(RTIMarshaler))]
            ArrayList ppInputTypes,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalCookie = "0", MarshalTypeRef = typeof(RTIMarshaler))]
            MFInt pcInputTypes,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalCookie = "1", MarshalTypeRef = typeof(RTIMarshaler))]
            ArrayList ppOutputTypes,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalCookie = "1", MarshalTypeRef = typeof(RTIMarshaler))]
            MFInt pcOutputTypes,
            IntPtr ip // Must be IntPtr.Zero due to MF bug, but should be out IMFAttributes ppAttributes
            );

        /// <summary>
        /// [This API is not supported and may be altered or unavailable in the future. Instead, applications
        /// should use the <strong>PSCreateMemoryPropertyStore</strong> function to create named property
        /// stores.] 
        /// <para/>
        /// Creates an empty property store to hold name/value pairs.
        /// </summary>
        /// <param name="ppStore">
        /// Receives a pointer to the <strong>INamedPropertyStore</strong> interface. The caller must release
        /// the interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT CreateNamedPropertyStore(
        ///   _Out_  INamedPropertyStore **ppStore
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/21F12BC1-606A-4CE8-BC8D-608D4D7CFC46(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/21F12BC1-606A-4CE8-BC8D-608D4D7CFC46(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int CreateNamedPropertyStore(
            out INamedPropertyStore ppStore
        );

        /// <summary>
        /// Blocks the <see cref="MFExtern.MFShutdown"/> function. 
        /// </summary>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFLockPlatform(void);
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/040742DC-4BA3-4906-8257-65505B2924D5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/040742DC-4BA3-4906-8257-65505B2924D5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFLockPlatform();

        /// <summary>
        /// Unlocks the Media Foundation platform after it was locked by a call to the 
        /// <see cref="MFExtern.MFLockPlatform"/> function. 
        /// </summary>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFUnlockPlatform(void);
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D4CE5315-4BB2-4CA4-A9A0-20B638A43040(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D4CE5315-4BB2-4CA4-A9A0-20B638A43040(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFUnlockPlatform();

        /// <summary>
        /// Retrieves the timer interval for the <see cref="MFExtern.MFAddPeriodicCallback"/> function. 
        /// </summary>
        /// <param name="Periodicity">
        /// Receives the timer interval, in milliseconds.
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The function succeeded. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFGetTimerPeriodicity(
        ///   _Out_  DWORD *Periodicity
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/19D7AE7E-7AE3-474D-8111-3B60B9ADB918(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/19D7AE7E-7AE3-474D-8111-3B60B9ADB918(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFGetTimerPeriodicity(
            out int Periodicity);

        /// <summary>
        /// Creates a byte stream from a file. 
        /// </summary>
        /// <param name="AccessMode">
        /// The requested access mode, specified as a member of the <see cref="MFFileAccessMode"/> enumeration.
        /// </param>
        /// <param name="OpenMode">
        /// The behavior of the function if the file already exists or does not exist, specified as a member of
        /// the <see cref="MFFileOpenMode"/> enumeration. 
        /// </param>
        /// <param name="fFlags">
        /// Bitwise <strong>OR</strong> of values from the <see cref="MFFileFlags"/> enumeration. 
        /// </param>
        /// <param name="pwszFileURL">
        /// Pointer to a null-terminated string that contains the file name. 
        /// </param>
        /// <param name="ppIByteStream">
        /// Receives a pointer to the <see cref="IMFByteStream"/> interface of the byte stream. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateFile(
        ///   MF_FILE_ACCESSMODE AccessMode,
        ///   MF_FILE_OPENMODE OpenMode,
        ///   MF_FILE_FLAGS fFlags,
        ///   LPCWSTR pwszFileURL,
        ///   IMFByteStream **ppIByteStream
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/29269EA4-151F-4819-AE49-9F1C13A901E5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/29269EA4-151F-4819-AE49-9F1C13A901E5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", CharSet = CharSet.Unicode, ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateFile(
            MFFileAccessMode AccessMode,
            MFFileOpenMode OpenMode,
            MFFileFlags fFlags,
            [MarshalAs(UnmanagedType.LPWStr)] string pwszFileURL,
            out IMFByteStream ppIByteStream);

        /// <summary>
        /// Creates a byte stream that is backed by a temporary local file. 
        /// </summary>
        /// <param name="AccessMode">
        /// The requested access mode, specified as a member of the <see cref="MFFileAccessMode"/> enumeration.
        /// </param>
        /// <param name="OpenMode">
        /// The behavior of the function if the file already exists or does not exist, specified as a member of
        /// the <see cref="MFFileOpenMode"/> enumeration. 
        /// </param>
        /// <param name="fFlags">
        /// Bitwise <strong>OR</strong> of values from the <see cref="MFFileFlags"/> enumeration. 
        /// </param>
        /// <param name="ppIByteStream">
        /// Receives a pointer to the <see cref="IMFByteStream"/> interface of the byte stream. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateTempFile(
        ///   MF_FILE_ACCESSMODE AccessMode,
        ///   MF_FILE_OPENMODE OpenMode,
        ///   MF_FILE_FLAGS fFlags,
        ///   IMFByteStream **ppIByteStream
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1F6CE49A-D3F2-4FBE-BBB8-E4AE9BCB0678(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1F6CE49A-D3F2-4FBE-BBB8-E4AE9BCB0678(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateTempFile(
            MFFileAccessMode AccessMode,
            MFFileOpenMode OpenMode,
            MFFileFlags fFlags,
            out IMFByteStream ppIByteStream);

        /// <summary>
        /// Begins an asynchronous request to create a byte stream from a file.
        /// </summary>
        /// <param name="AccessMode">
        /// The requested access mode, specified as a member of the <see cref="MFFileAccessMode"/> enumeration.
        /// </param>
        /// <param name="OpenMode">
        /// The behavior of the function if the file already exists or does not exist, specified as a member of
        /// the <see cref="MFFileOpenMode"/> enumeration. 
        /// </param>
        /// <param name="fFlags">
        /// Bitwise <strong>OR</strong> of values from the <see cref="MFFileFlags"/> enumeration. 
        /// </param>
        /// <param name="pwszFilePath">
        /// Pointer to a null-terminated string containing the file name.
        /// </param>
        /// <param name="pCallback">
        /// Pointer to the <see cref="IMFAsyncCallback"/> interface of a callback object. The caller must
        /// implement this interface 
        /// </param>
        /// <param name="pState">
        /// Pointer to the <strong>IUnknown</strong> interface of a state object, defined by the caller. This
        /// parameter can be <strong>NULL</strong>. You can use this object to hold state information. The
        /// object is returned to the caller when the callback is invoked. 
        /// </param>
        /// <param name="ppCancelCookie">
        /// Receives an <strong>IUnknown</strong> pointer or the value <strong>NULL</strong>. If the value is
        /// not <strong>NULL</strong>, you can cancel the asynchronous operation by passing this pointer to the
        /// <see cref="MFExtern.MFCancelCreateFile"/> function. The caller must release the interface. This
        /// parameter is optional and can be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFBeginCreateFile(
        ///   _In_   MF_FILE_ACCESSMODE AccessMode,
        ///   _In_   MF_FILE_OPENMODE OpenMode,
        ///   _In_   MF_FILE_FLAGS fFlags,
        ///   _In_   LPCWSTR pwszFilePath,
        ///   _In_   IMFAsyncCallback *pCallback,
        ///   _In_   IUnknown *pState,
        ///   _Out_  IUnknown **ppCancelCookie
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/ACA304F6-CF7C-43EA-8EBE-D3BB46F8A2FD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/ACA304F6-CF7C-43EA-8EBE-D3BB46F8A2FD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", CharSet = CharSet.Unicode, ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFBeginCreateFile(
            [In] MFFileAccessMode AccessMode,
            [In] MFFileOpenMode OpenMode,
            [In] MFFileFlags fFlags,
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszFilePath,
            [In] IMFAsyncCallback pCallback,
            [In] [MarshalAs(UnmanagedType.IUnknown)] object pState,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppCancelCookie);

        /// <summary>
        /// Completes an asynchronous request to create a byte stream from a file.
        /// </summary>
        /// <param name="pResult">
        /// Pointer to the <see cref="IMFAsyncResult"/> interface. Pass in the same pointer that your callback
        /// object received in the <c>Invoke</c> method. 
        /// </param>
        /// <param name="ppFile">
        /// Receives a pointer to the <see cref="IMFByteStream"/> interface of the byte stream. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFEndCreateFile(
        ///   _In_   IMFAsyncResult *pResult,
        ///   _Out_  IMFByteStream **ppFile
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DAA92660-5D0D-4C7C-985A-AD621ECA4BFC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DAA92660-5D0D-4C7C-985A-AD621ECA4BFC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFEndCreateFile(
            [In] IMFAsyncResult pResult,
            out IMFByteStream ppFile);

        /// <summary>
        /// Cancels an asynchronous request to create a byte stream from a file.
        /// </summary>
        /// <param name="pCancelCookie">
        /// A pointer to the <strong>IUnknown</strong> interface of the cancellation object. This pointer is
        /// received in the <em>ppCancelCookie</em> parameter of the <see cref="MFExtern.MFBeginCreateFile"/>
        /// function. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCancelCreateFile(
        ///   _In_  IUnknown *pCancelCookie
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B3C0CAD8-D578-4752-A2EA-0AA5C35A181A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B3C0CAD8-D578-4752-A2EA-0AA5C35A181A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCancelCreateFile(
            [In] [MarshalAs(UnmanagedType.IUnknown)] object pCancelCookie);

#endif 

        /// <summary>
        /// Allocates system memory with a specified byte alignment and creates a media buffer to manage the
        /// memory. 
        /// </summary>
        /// <param name="cbMaxLength">
        /// Size of the buffer, in bytes.
        /// </param>
        /// <param name="cbAligment">
        /// Specifies the memory alignment for the buffer. Use one of the following constants. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>MF_1_BYTE_ALIGNMENT</strong>0x00000000</term><description> Align to 1 bytes. </description></item>
        /// <item><term><strong>MF_2_BYTE_ALIGNMENT</strong>0x00000001</term><description> Align to 2 bytes. </description></item>
        /// <item><term><strong>MF_4_BYTE_ALIGNMENT</strong>0x00000003</term><description> Align to 4 bytes. </description></item>
        /// <item><term><strong>MF_8_BYTE_ALIGNMENT</strong>0x00000007</term><description> Align to 8 bytes. </description></item>
        /// <item><term><strong>MF_16_BYTE_ALIGNMENT</strong>0x0000000F</term><description> Align to 16 bytes. </description></item>
        /// <item><term><strong>MF_32_BYTE_ALIGNMENT</strong>0x0000001F</term><description> Align to 32 bytes. </description></item>
        /// <item><term><strong>MF_64_BYTE_ALIGNMENT</strong>0x0000003F</term><description> Align to 64 bytes. </description></item>
        /// <item><term><strong>MF_128_BYTE_ALIGNMENT</strong>0x0000007F</term><description> Align to 128 bytes. </description></item>
        /// <item><term><strong>MF_256_BYTE_ALIGNMENT</strong>0x000000FF</term><description> Align to 256 bytes. </description></item>
        /// <item><term><strong>MF_512_BYTE_ALIGNMENT</strong>0x000001FF</term><description> Align to 512 bytes. </description></item>
        /// </list>
        /// </param>
        /// <param name="ppBuffer">
        /// Receives a pointer to the <see cref="IMFMediaBuffer"/> interface of the media buffer. The caller
        /// must release the interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description> The function succeeded. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateAlignedMemoryBuffer(
        ///   DWORD cbMaxLength,
        ///   DWORD fAlignmentFlags,
        ///   IMFMediaBuffer **ppBuffer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CCCC0DEA-3F1E-41E4-97F4-DE7760CECCB0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CCCC0DEA-3F1E-41E4-97F4-DE7760CECCB0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateAlignedMemoryBuffer(
            [In] int cbMaxLength,
            [In] int cbAligment,
            /* out IMFMediaBuffer */ out IntPtr ppBuffer);

        /// <summary>
        /// Returns the system time. 
        /// </summary>
        /// <returns>
        /// Returns the system time, in 100-nanosecond units. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// MFTIME MFGetSystemTime(void);
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E23617F6-248E-4E0B-866B-19B960EBF8EB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E23617F6-248E-4E0B-866B-19B960EBF8EB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern long MFGetSystemTime(
            );

#if NOT_IN_USE

        /// <summary>
        /// Retrieves the URL schemes that are registered for the source resolver.
        /// </summary>
        /// <param name="pPropVarSchemeArray">
        /// Pointer to a <strong>PROPVARIANT</strong> that receives the URL schemes. Before calling this
        /// method, call <strong>PropVariantInit</strong> to initialize the <strong>PROPVARIANT</strong>. If
        /// the method succeeds, the <strong>PROPVARIANT</strong> contains an array of wide-character strings.
        /// The <strong>PROPVARIANT</strong> data type is VT_VECTOR | VT_LPWSTR. The caller must release the 
        /// <strong>PROPVARIANT</strong> by calling <strong>PropVariantClear</strong>. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFGetSupportedSchemes(
        ///   _Out_  PROPVARIANT *pPropVarSchemeArray
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B40315FC-7E2B-4573-A98F-840B6CE31DD3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B40315FC-7E2B-4573-A98F-840B6CE31DD3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFGetSupportedSchemes(
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PropVariantMarshaler), MarshalCookie = "MFExtern.MFGetSupportedSchemes")] PropVariant pPropVarSchemeArray
        );

        /// <summary>
        /// Retrieves the MIME types that are registered for the source resolver.
        /// </summary>
        /// <param name="pPropVarSchemeArray">
        /// Pointer to a <strong>PROPVARIANT</strong> that receives the MIME types. Before calling this method,
        /// call <strong>PropVariantInit</strong> to initialize the <strong>PROPVARIANT</strong>. If the method
        /// succeeds, the <strong>PROPVARIANT</strong> contains an array of wide-character strings. The 
        /// <strong>PROPVARIANT</strong> data type is VT_VECTOR | VT_LPWSTR. The caller must release the 
        /// <strong>PROPVARIANT</strong> by calling <strong>PropVariantClear</strong>. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The function succeeded. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFGetSupportedMimeTypes(
        ///   _Out_  PROPVARIANT *pPropVarMimeTypeArray
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7E7B0E6E-98EB-4FB1-8577-E73EB9D62623(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7E7B0E6E-98EB-4FB1-8577-E73EB9D62623(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFGetSupportedMimeTypes(
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PropVariantMarshaler), MarshalCookie = "MFExtern.MFGetSupportedMimeTypes")] PropVariant pPropVarSchemeArray
        );

        /// <summary>
        /// Creates a media-type handler that supports a single media type at a time.
        /// </summary>
        /// <param name="ppHandler">
        /// Receives a pointer to the <see cref="IMFMediaTypeHandler"/> interface of the media-type handler.
        /// The caller must release the interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateSimpleTypeHandler(
        ///   _Out_  IMFMediaTypeHandler **ppHandler
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/441BD03D-B314-4F26-AD67-E6997E5EDC9D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/441BD03D-B314-4F26-AD67-E6997E5EDC9D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateSimpleTypeHandler(
            out IMFMediaTypeHandler ppHandler
        );

        /// <summary>
        /// Creates a <strong>PROPVARIANT</strong> that can be used to seek within a sequencer source
        /// presentation. 
        /// </summary>
        /// <param name="dwId">
        /// Sequencer element identifier. This value specifies the segment in which to begin playback. The
        /// element identifier is returned in the <see cref="IMFSequencerSource.AppendTopology"/> method. 
        /// </param>
        /// <param name="hnsOffset">
        /// Starting position within the segment, in 100-nanosecond units. 
        /// </param>
        /// <param name="pvarSegmentOffset">
        /// Pointer to a <strong>PROPVARIANT</strong>. The method fills in the <strong>PROPVARIANT</strong>
        /// with the information needed for performing a seek operation. The caller must free the <strong>
        /// PROPVARIANT</strong> by calling <strong>PropVariantClear</strong>. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateSequencerSegmentOffset(
        ///   _In_   MFSequencerElementId dwId,
        ///   _In_   MFTIME hnsOffset,
        ///   _Out_  PROPVARIANT *pvarSegmentOffset
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5999AF23-03A6-4FD9-8A56-23179164FF32(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5999AF23-03A6-4FD9-8A56-23179164FF32(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateSequencerSegmentOffset(
            int dwId,
            long hnsOffset,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PropVariantMarshaler), MarshalCookie = "MFExtern.MFCreateSequencerSegmentOffset")] PropVariant pvarSegmentOffset
        );

        /// <summary>
        /// Creates an instance of the enhanced video renderer (EVR) media sink.
        /// </summary>
        /// <param name="riidRenderer">
        /// Interface identifier (IID) of the requested interface on the EVR.
        /// </param>
        /// <param name="ppVideoRenderer">
        /// Receives a pointer to the requested interface. The caller must release the interface.
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateVideoRenderer(
        ///   _In_   REFIID riidRenderer,
        ///   _Out_  void **ppVideoRenderer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D0F90C42-8F08-44F4-B3DA-B9F3AE4869E6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D0F90C42-8F08-44F4-B3DA-B9F3AE4869E6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateVideoRenderer(
            [MarshalAs(UnmanagedType.LPStruct)] Guid riidRenderer,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoRenderer
            );

#endif

        /// <summary>
        /// Creates a media buffer that wraps an existing media buffer. The new media buffer points to the same
        /// memory as the original media buffer, or to an offset from the start of the memory.
        /// </summary>
        /// <param name="pBuffer">
        /// A pointer to the <see cref="IMFMediaBuffer"/> interface of the original media buffer. 
        /// </param>
        /// <param name="cbOffset">
        /// The start of the new buffer, as an offset in bytes from the start of the original buffer. 
        /// </param>
        /// <param name="dwLength">
        /// The size of the new buffer. The value of <em>cbOffset</em> + <em>dwLength</em> must be less than or
        /// equal to the size of valid data the original buffer. (The size of the valid data is returned by the
        /// <see cref="IMFMediaBuffer.GetCurrentLength"/> method.) 
        /// </param>
        /// <param name="ppBuffer">
        /// Receives a pointer to the <see cref="IMFMediaBuffer"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The function succeeded. </description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description> The requested offset or the requested length is not valid. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateMediaBufferWrapper(
        ///   _In_   IMFMediaBuffer *pBuffer,
        ///   _In_   DWORD cbOffset,
        ///   _In_   DWORD dwLength,
        ///   _Out_  IMFMediaBuffer **ppBuffer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6850E75C-4612-4514-A74D-9B36FD88A598(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6850E75C-4612-4514-A74D-9B36FD88A598(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateMediaBufferWrapper(
            [In] IMFMediaBuffer pBuffer,
            [In] int cbOffset,
            [In] int dwLength,
            /* out IMFMediaBuffer */ out IntPtr ppBuffer);

        /// <summary>
        /// Converts a Media Foundation media buffer into a buffer that is compatible with DirectX Media
        /// Objects (DMOs).
        /// </summary>
        /// <param name="pSample">
        /// Pointer to the <see cref="IMFSample"/> interface of the sample that contains the Media Foundation
        /// buffer. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="pMFMediaBuffer">
        /// Pointer to the <see cref="IMFMediaBuffer"/> interface of the Media Foundation buffer. 
        /// </param>
        /// <param name="cbOffset">
        /// Offset in bytes from the start of the Media Foundation buffer. This offset defines where the DMO
        /// buffer starts. If this parameter is zero, the DMO buffer starts at the beginning of the Media
        /// Foundation buffer.
        /// </param>
        /// <param name="ppMediaBuffer">
        /// Receives a pointer to the <strong>IMediaBuffer</strong> interface. This interface is documented in
        /// the DirectShow SDK documentation. The caller must release the interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>Invalid argument. The <em>pIMFMediaBuffer</em> parameter must not be <strong>NULL</strong>. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateLegacyMediaBufferOnMFMediaBuffer(
        ///   IMFSample *pIMFSample,
        ///   IMFMediaBuffer *pIMFMediaBuffer,
        ///   DWORD cbOffset,
        ///   IMediaBuffer **ppIMediaBuffer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/35D749D8-2BCA-4FE8-B145-175E178AE529(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/35D749D8-2BCA-4FE8-B145-175E178AE529(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        // Technically, the last param should be an IMediaBuffer.  However, that interface is
        // beyond the scope of this library.  If you are using DirectShowNet (where this *is*
        // defined), you can cast from the object to the IMediaBuffer.
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateLegacyMediaBufferOnMFMediaBuffer(
            [In] IMFSample pSample,
            [In] IMFMediaBuffer pMFMediaBuffer,
            [In] int cbOffset,
            /* [MarshalAs(UnmanagedType.IUnknown)] out object */ out IntPtr ppMediaBuffer);

#if NOT_IN_USE

        /// <summary>
        /// Initializes the contents of an attribute store from a byte array.
        /// </summary>
        /// <param name="pAttributes">
        /// Pointer to the <see cref="IMFAttributes"/> interface of the attribute store. 
        /// </param>
        /// <param name="pBuf">
        /// Pointer to the array that contains the initialization data.
        /// </param>
        /// <param name="cbBufSize">
        /// Size of the <em>pBuf</em> array, in bytes. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>The buffer is not valid.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFInitAttributesFromBlob(
        ///   _In_  IMFAttributes *pAttributes,
        ///   _In_  const UINT8 *pBuf,
        ///   _In_  UINT cbBufSize
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DA0F01A3-ED47-42A1-B4AF-5F3CBC9271A3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DA0F01A3-ED47-42A1-B4AF-5F3CBC9271A3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFInitAttributesFromBlob(
            [In] IMFAttributes pAttributes,
            IntPtr pBuf,
            [In] int cbBufSize
            );

        /// <summary>
        /// Retrieves the size of the buffer needed for the <see cref="MFExtern.MFGetAttributesAsBlob"/>
        /// function. 
        /// </summary>
        /// <param name="pAttributes">
        /// Pointer to the <see cref="IMFAttributes"/> interface of the attribute store. 
        /// </param>
        /// <param name="pcbBufSize">
        /// Receives the required size of the array, in bytes.
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFGetAttributesAsBlobSize(
        ///   _In_   IMFAttributes *pAttributes,
        ///   _Out_  UINT32 *pcbBufSize
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/52ABFE30-A18D-45F7-93DB-13F87B0647B7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/52ABFE30-A18D-45F7-93DB-13F87B0647B7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFGetAttributesAsBlobSize(
            [In] IMFAttributes pAttributes,
            out int pcbBufSize
            );

        /// <summary>
        /// Converts the contents of an attribute store to a byte array.
        /// </summary>
        /// <param name="pAttributes">
        /// Pointer to the <see cref="IMFAttributes"/> interface of the attribute store. 
        /// </param>
        /// <param name="pBuf">
        /// Pointer to an array that receives the attribute data.
        /// </param>
        /// <param name="cbBufSize">
        /// Size of the <em>pBuf</em> array, in bytes. To get the required size of the buffer, call 
        /// <see cref="MFExtern.MFGetAttributesAsBlobSize"/>. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// <item><term><strong>MF_E_BUFFERTOOSMALL</strong></term><description>The buffer given in <em>pBuf</em> is too small. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFGetAttributesAsBlob(
        ///   _In_   IMFAttributes *pAttributes,
        ///   _Out_  UINT8 *pBuf,
        ///   _In_   UINT cbBufSize
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1A3BD860-1022-481F-8615-5A73C16DD77B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1A3BD860-1022-481F-8615-5A73C16DD77B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFGetAttributesAsBlob(
            [In] IMFAttributes pAttributes,
            IntPtr pBuf,
            [In] int cbBufSize
            );

        /// <summary>
        /// Writes the contents of an attribute store to a stream.
        /// </summary>
        /// <param name="pAttr">
        /// Pointer to the <see cref="IMFAttributes"/> interface of the attribute store. 
        /// </param>
        /// <param name="dwOptions">
        /// Bitwise <strong>OR</strong> of zero or more flags from the 
        /// <see cref="MFAttributeSerializeOptions"/> enumeration. 
        /// </param>
        /// <param name="pStm">
        /// Pointer to the <strong>IStream</strong> interface of the stream where the attributes are saved. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFSerializeAttributesToStream(
        ///   IMFAttributes *pAttr,
        ///   DWORD dwOptions,
        ///   IStream *pStm
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B8BC88E5-19AE-46B3-AA78-A00AFEE1F481(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B8BC88E5-19AE-46B3-AA78-A00AFEE1F481(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFSerializeAttributesToStream(
            IMFAttributes pAttr,
            MFAttributeSerializeOptions dwOptions,
            IStream pStm);

        /// <summary>
        /// Loads attributes from a stream into an attribute store.
        /// </summary>
        /// <param name="pAttr">
        /// Pointer to the <see cref="IMFAttributes"/> interface of the attribute store. 
        /// </param>
        /// <param name="dwOptions">
        /// Bitwise <strong>OR</strong> of zero or more flags from the 
        /// <see cref="MFAttributeSerializeOptions"/> enumeration. 
        /// </param>
        /// <param name="pStm">
        /// Pointer to the <strong>IStream</strong> interface of the stream from which to read the attributes. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFDeserializeAttributesFromStream(
        ///   IMFAttributes *pAttr,
        ///   DWORD dwOptions,
        ///   IStream *pStm
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CC0BCCFD-7E67-4E55-9D3E-EBCD91B94A3A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CC0BCCFD-7E67-4E55-9D3E-EBCD91B94A3A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFDeserializeAttributesFromStream(
            IMFAttributes pAttr,
            MFAttributeSerializeOptions dwOptions,
            IStream pStm);

        /// <summary>
        /// [This API is not supported and may be altered or unavailable in the future. Applications should
        /// avoid using the <see cref="MFVideoFormat"/> structure, and use media type attributes instead. For
        /// more information, see <c>Video Media Types</c>.] 
        /// <para/>
        /// Creates an <see cref="MFVideoFormat"/> structure from a video media type. 
        /// </summary>
        /// <param name="pMFType">
        /// Pointer to the <see cref="IMFMediaType"/> interface of a video media type. 
        /// </param>
        /// <param name="ppMFVF">
        /// Receives a pointer to an <see cref="MFVideoFormat"/> structure. The caller must release the memory
        /// allocated for the structure by calling <c>CoTaskMemFree</c>. 
        /// </param>
        /// <param name="pcbSize">
        /// Receives the size of the <see cref="MFVideoFormat"/> structure. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateMFVideoFormatFromMFMediaType(
        ///   _In_   IMFMediaType *pMFType,
        ///   _Out_  MFVIDEOFORMAT **ppMFVF,
        ///   _Out_  UINT32 *pcbSize
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C83E3605-D345-4192-A6FD-26D1A78EB259(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C83E3605-D345-4192-A6FD-26D1A78EB259(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [Obsolete("Use media type attributes instead")]
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateMFVideoFormatFromMFMediaType(
            [In] IMFMediaType pMFType,
            out MFVideoFormat ppMFVF,
            out int pcbSize
            );

        /// <summary>
        /// [This API is not supported and may be altered or unavailable in the future. Applications should
        /// avoid using the <see cref="MFVideoFormat"/> structure, and use media type attributes instead. For
        /// more information, see <c>Video Media Types</c>.] 
        /// <para/>
        /// Returns the FOURCC or <strong>D3DFORMAT</strong> value for an uncompressed video format. 
        /// </summary>
        /// <param name="pVideoFormat">
        /// Pointer to an <see cref="MFVideoFormat"/> structure. 
        /// </param>
        /// <returns>
        /// Returns a FOURCC or <strong>D3DFORMAT</strong> value that identifies the video format. If the video
        /// format is compressed or not recognized, the return value is D3DFMT_UNKNOWN. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// DWORD MFGetUncompressedVideoFormat(
        ///   _In_  const MFVIDEOFORMAT *pVideoFormat
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7869025A-DACF-47E6-B129-DB5B2DAEFA3B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7869025A-DACF-47E6-B129-DB5B2DAEFA3B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [Obsolete("Use media type attributes instead.")]
        [DllImport("evr.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFGetUncompressedVideoFormat(
            [In, MarshalAs(UnmanagedType.LPStruct)] MFVideoFormat pVideoFormat
        );

        /// <summary>
        /// [This API is not supported and may be altered or unavailable in the future. Applications should
        /// avoid using the <see cref="MFVideoFormat"/> structure, and use media type attributes instead. For
        /// more information, see <c>Video Media Types</c>.] 
        /// <para/>
        /// Initializes a media type from an <see cref="MFVideoFormat"/> structure. 
        /// </summary>
        /// <param name="pMFType">
        /// Pointer to the <see cref="IMFMediaType"/> interface of the media type to initialize. To create the
        /// uninitialized media type object, call <see cref="MFExtern.MFCreateMediaType"/>. 
        /// </param>
        /// <param name="pMFVF">
        /// Pointer to an <see cref="MFVideoFormat"/> structure that describes the media type. The caller must
        /// fill in the structure members before calling this function. 
        /// </param>
        /// <param name="cbBufSize">
        /// Size of the <see cref="MFVideoFormat"/> structure, in bytes. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFInitMediaTypeFromMFVideoFormat(
        ///   IMFMediaType *pMFType,
        ///   const MFVIDEOFORMAT *pMFVF,
        ///   UINT32 cbBufSize
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/45400B67-DF81-4FAE-A24D-80020EB07151(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/45400B67-DF81-4FAE-A24D-80020EB07151(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [Obsolete("Use media type attributes instead.")]
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFInitMediaTypeFromMFVideoFormat(
            [In] IMFMediaType pMFType,
            MFVideoFormat pMFVF,
            [In] int cbBufSize
            );

        /// <summary>
        /// Initializes a DirectShow <strong>AM_MEDIA_TYPE</strong> structure from a Media Foundation media
        /// type. 
        /// </summary>
        /// <param name="pMFType">
        /// Pointer to the <see cref="IMFMediaType"/> interface of the media type to convert. 
        /// </param>
        /// <param name="guidFormatBlockType">
        /// Format type GUID. This value corresponds to the <strong>formattype</strong> member of the <strong>
        /// AM_MEDIA_TYPE</strong> structure and specifies the type of format block to allocate. If the value
        /// is GUID_NULL, the function attempts to deduce the correct format block, based on the major type and
        /// subtype. 
        /// </param>
        /// <param name="pAMType">
        /// Pointer to an <strong>AM_MEDIA_TYPE</strong> structure. The function allocates memory for the
        /// format block. The caller must release the format block by calling <c>CoTaskMemFree</c> on the 
        /// <strong>pbFormat</strong> member. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDMEDIATYPE</strong></term><description>The media type is not valid.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFInitAMMediaTypeFromMFMediaType(
        ///   IMFMediaType *pMFType,
        ///   GUID guidFormatBlockType,
        ///   AM_MEDIA_TYPE *pAMType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DBB69578-2563-476F-92F4-6B4E2BB2C77A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DBB69578-2563-476F-92F4-6B4E2BB2C77A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFInitAMMediaTypeFromMFMediaType(
            [In] IMFMediaType pMFType,
            [In, MarshalAs(UnmanagedType.Struct)] Guid guidFormatBlockType,
            [Out] AMMediaType pAMType
            );

        /// <summary>
        /// Creates a DirectShow <strong>AM_MEDIA_TYPE</strong> structure from a Media Foundation media type. 
        /// </summary>
        /// <param name="pMFType">
        /// Pointer to the <see cref="IMFMediaType"/> interface of the media type to convert. 
        /// </param>
        /// <param name="guidFormatBlockType">
        /// Format type GUID. This value corresponds to the <strong>formattype</strong> member of the <strong>
        /// AM_MEDIA_TYPE</strong> structure and specifies the type of format block to allocate. If the value
        /// is GUID_NULL, the function attempts to deduce the correct format block, based on the major type and
        /// subtype. 
        /// </param>
        /// <param name="ppAMType">
        /// Receives a pointer to an <strong>AM_MEDIA_TYPE</strong> structure. The caller must release the
        /// memory allocated for the structure by calling <c>CoTaskMemFree</c>. The function also allocates
        /// memory for the format block, which the caller must release by calling <strong>CoTaskMemFree
        /// </strong> on the <strong>pbFormat</strong> member. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateAMMediaTypeFromMFMediaType(
        ///   IMFMediaType *pMFType,
        ///   GUID guidFormatBlockType,
        ///   AM_MEDIA_TYPE **ppAMType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/53B191D4-89B3-4B16-8F89-50F256689E85(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/53B191D4-89B3-4B16-8F89-50F256689E85(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateAMMediaTypeFromMFMediaType(
            [In] IMFMediaType pMFType,
            [In, MarshalAs(UnmanagedType.Struct)] Guid guidFormatBlockType,
            out AMMediaType ppAMType // delete with DeleteMediaType
            );

        /// <summary>
        /// Initializes a media type from a DirectShow <strong>AM_MEDIA_TYPE</strong> structure. 
        /// </summary>
        /// <param name="pMFType">
        /// Pointer to the <see cref="IMFMediaType"/> interface of the media type to initialize. To create the
        /// uninitialized media type object, call <see cref="MFExtern.MFCreateMediaType"/>. 
        /// </param>
        /// <param name="pAMType">
        /// Pointer to an <strong>AM_MEDIA_TYPE</strong> structure that describes the media type. The caller
        /// must fill in the structure members before calling this function. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFInitMediaTypeFromAMMediaType(
        ///   IMFMediaType *pMFType,
        ///   const AM_MEDIA_TYPE *pAMType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DA5DCC32-C027-4B9A-B72F-A60B98885636(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DA5DCC32-C027-4B9A-B72F-A60B98885636(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFInitMediaTypeFromAMMediaType(
            [In] IMFMediaType pMFType,
            [In] AMMediaType pAMType
            );

        /// <summary>
        /// Initializes a media type from a DirectShow <strong>VIDEOINFOHEADER</strong> structure. 
        /// </summary>
        /// <param name="pMFType">
        /// Pointer to the <see cref="IMFMediaType"/> interface of the media type to initialize. To create the
        /// uninitialized media type object, call <see cref="MFExtern.MFCreateMediaType"/>. 
        /// </param>
        /// <param name="pVIH">
        /// Pointer to a <strong>VIDEOINFOHEADER</strong> structure that describes the media type. The caller
        /// must fill in the structure members before calling this function. 
        /// </param>
        /// <param name="cbBufSize">
        /// Size of the <strong>VIDEOINFOHEADER</strong> structure, in bytes. 
        /// </param>
        /// <param name="pSubtype">
        /// Pointer to a subtype GUID. This parameter can be <strong>NULL</strong>. If the subtype GUID is
        /// specified, the function uses it to set the media subtype. Otherwise, the function attempts to
        /// deduce the subtype from the <strong>biCompression</strong> field contained in the <strong>
        /// VIDEOINFOHEADER</strong> structure. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFInitMediaTypeFromVideoInfoHeader(
        ///   IMFMediaType *pMFType,
        ///   const VIDEOINFOHEADER *pVIH,
        ///   UINT32 cbBufSize,
        ///   const GUID *pSubtype = NULL
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7F88422D-C968-4EEA-83CB-45E6CFE37921(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7F88422D-C968-4EEA-83CB-45E6CFE37921(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFInitMediaTypeFromVideoInfoHeader(
            [In] IMFMediaType pMFType,
            VideoInfoHeader pVIH,
            [In] int cbBufSize,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid pSubtype
            );

        /// <summary>
        /// Initializes a media type from a DirectShow <strong>VIDEOINFOHEADER2</strong> structure. 
        /// </summary>
        /// <param name="pMFType">
        /// Pointer to the <see cref="IMFMediaType"/> interface of the media type to initialize. To create the
        /// uninitialized media type object, call <see cref="MFExtern.MFCreateMediaType"/>. 
        /// </param>
        /// <param name="pVIH2">
        /// Pointer to a <strong>VIDEOINFOHEADER2</strong> structure that describes the media type. The caller
        /// must fill in the structure members before calling this function. 
        /// </param>
        /// <param name="cbBufSize">
        /// Size of the <strong>VIDEOINFOHEADER2</strong> structure, in bytes. 
        /// </param>
        /// <param name="pSubtype">
        /// Pointer to a subtype GUID. This parameter can be <strong>NULL</strong>. If the subtype GUID is
        /// specified, the function uses it to set the media subtype. Otherwise, the function attempts to
        /// deduce the subtype from the <strong>biCompression</strong> field contained in the <strong>
        /// VIDEOINFOHEADER2</strong> structure. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFInitMediaTypeFromVideoInfoHeader2(
        ///   IMFMediaType *pMFType,
        ///   const VIDEOINFOHEADER2 *pVIH2,
        ///   UINT32 cbBufSize,
        ///   const GUID *pSubtype = NULL
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4077AE40-75B2-4C45-B62E-740E216EBF89(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4077AE40-75B2-4C45-B62E-740E216EBF89(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFInitMediaTypeFromVideoInfoHeader2(
            [In] IMFMediaType pMFType,
            VideoInfoHeader2 pVIH2,
            [In] int cbBufSize,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid pSubtype
            );

        /// <summary>
        /// [This API is not supported and may be altered or unavailable in the future. Applications should
        /// avoid using the <see cref="MFVideoFormat"/> structure, and use media type attributes instead. For
        /// more information, see <c>Video Media Types</c>.] 
        /// <para/>
        /// Creates a video media type from an <see cref="MFVideoFormat"/> structure. 
        /// </summary>
        /// <param name="pVideoFormat">
        /// Pointer to an <see cref="MFVideoFormat"/> structure that describes the video format. 
        /// </param>
        /// <param name="ppIVideoMediaType">
        /// Receives a pointer to the <see cref="IMFVideoMediaType"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateVideoMediaType(
        ///   _In_   const MFVIDEOFORMAT *pVideoFormat,
        ///   _Out_  IMFVideoMediaType **ppIVideoMediaType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/143AEDEC-D1CE-434A-8A1C-62A2C9D55E88(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/143AEDEC-D1CE-434A-8A1C-62A2C9D55E88(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [Obsolete("Use media type attributes instead.")]
        [DllImport("evr.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateVideoMediaType(
            MFVideoFormat pVideoFormat,
            out IMFVideoMediaType ppIVideoMediaType
            );

        /// <summary>
        /// Enumerates Media Foundation transforms (MFTs) in the registry. 
        /// <para/>
        /// Starting in Windows 7, applications should use the <see cref="MFExtern.MFTEnumEx"/> function
        /// instead. 
        /// </summary>
        /// <param name="guidCategory">
        /// GUID that specifies the category of MFTs to enumerate. For a list of MFT categories, see 
        /// <c>MFT_CATEGORY</c>. 
        /// </param>
        /// <param name="Flags">
        /// Reserved. Must be zero. 
        /// </param>
        /// <param name="pInputType">
        /// Pointer to an <see cref="Transform.MFTRegisterTypeInfo"/> structure that specifies an input media
        /// type to match. 
        /// <para/>
        /// This parameter can be <strong>NULL</strong>. If <strong>NULL</strong>, all input types are matched.
        /// </param>
        /// <param name="pOutputType">
        /// Pointer to an <see cref="Transform.MFTRegisterTypeInfo"/> structure that specifies an output media
        /// type to match. 
        /// <para/>
        /// This parameter can be <strong>NULL</strong>. If <strong>NULL</strong>, all output types are
        /// matched. 
        /// </param>
        /// <param name="pAttributes">
        /// Reserved. Set to <strong>NULL</strong>. 
        /// <para/>
        /// <strong>Note</strong> Windows Vista and Windows Server 2008: This parameter can specify a pointer
        /// to the <see cref="IMFAttributes"/> interface of an attribute store. The <strong>MFTEnum</strong>
        /// function matches the attributes in this object against the attributes stored in the registry.
        /// (Registry attributes are specified in the <em>pAttributes</em> parameter of the 
        /// <see cref="MFExtern.MFTRegister"/> function.) Only MFTs with matching attributes are returned in
        /// the enumeration results. 
        /// <para/>
        /// <strong>Note</strong> Windows 7 and later: This parameter is ignored. 
        /// </param>
        /// <param name="ppclsidMFT">
        /// Receives a pointer to an array of CLSIDs. To create an MFT from this list, call <strong>
        /// CoCreateInstance</strong> with one of the CLSIDs. To get information about a particular MFT from
        /// its CLSID, call <see cref="MFExtern.MFTGetInfo"/>. The caller must free the memory for the array by
        /// calling <c>CoTaskMemFree</c>. 
        /// </param>
        /// <param name="pcMFTs">
        /// Receives the number of elements in the <em>ppclsidMFT</em> array. The value can be zero. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFTEnum(
        ///   _In_   GUID guidCategory,
        ///   _In_   UINT32 Flags,
        ///   _In_   MFT_REGISTER_TYPE_INFO *pInputType,
        ///   _In_   MFT_REGISTER_TYPE_INFO *pOutputType,
        ///   _In_   IMFAttributes *pAttributes,
        ///   _Out_  CLSID **ppclsidMFT,
        ///   _Out_  UINT32 *pcMFTs
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A3BD2B3C-0B0B-4D64-99CC-6093C773F71C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A3BD2B3C-0B0B-4D64-99CC-6093C773F71C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFTEnum(
            [In, MarshalAs(UnmanagedType.Struct)] Guid guidCategory,
            [In] int Flags, // Must be zero
            [In, MarshalAs(UnmanagedType.LPStruct)] MFTRegisterTypeInfo pInputType,
            [In, MarshalAs(UnmanagedType.LPStruct)] MFTRegisterTypeInfo pOutputType,
            [In] IMFAttributes pAttributes,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalCookie = "0", MarshalTypeRef = typeof(GAMarshaler))]
            ArrayList ppclsidMFT,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalCookie = "0", MarshalTypeRef = typeof(GAMarshaler))]
            MFInt pcMFTs
            );

        /// <summary>
        /// Creates the sequencer source.
        /// </summary>
        /// <param name="pReserved">
        /// Reserved. Must be <strong>NULL</strong>. 
        /// </param>
        /// <param name="ppSequencerSource">
        /// Receives a pointer to the <see cref="IMFSequencerSource"/> interface of the sequencer source. The
        /// caller must release the interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateSequencerSource(
        ///   IUnknown *pReserved,
        ///   IMFSequencerSource **ppSequencerSource
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E4640731-F262-4CEB-8D17-908C2C6B192E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E4640731-F262-4CEB-8D17-908C2C6B192E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateSequencerSource(
            [MarshalAs(UnmanagedType.IUnknown)] object pReserved,
            out IMFSequencerSource ppSequencerSource
        );

        /// <summary>
        /// Creates a new work queue.
        /// </summary>
        /// <param name="pdwWorkQueue">
        /// Receives an identifier for the work queue.
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The function succeeded. </description></item>
        /// <item><term><strong>E_FAIL</strong></term><description> The application exceeded the maximum number of work queues. </description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description> The application did not call <see cref="MFStartup"/>, or the application has already called <see cref="MFExtern.MFShutdown"/>. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFAllocateWorkQueue(
        ///   _Out_  DWORD *pdwWorkQueue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8DEF4375-919C-4619-9484-9CE2708A3886(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8DEF4375-919C-4619-9484-9CE2708A3886(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFAllocateWorkQueue(
            out int pdwWorkQueue);

        /// <summary>
        /// Unlocks a work queue.
        /// </summary>
        /// <param name="dwWorkQueue">
        /// Identifier for the work queue to be unlocked. The identifier is returned by the 
        /// <see cref="MFExtern.MFAllocateWorkQueue"/> function. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFUnlockWorkQueue(
        ///   _In_  DWORD dwWorkQueue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BBC22FA7-B4D7-47B2-B065-099FBB2ED092(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BBC22FA7-B4D7-47B2-B065-099FBB2ED092(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFUnlockWorkQueue(
            [In] int dwWorkQueue);

        /// <summary>
        /// Puts an asynchronous operation on a work queue.
        /// </summary>
        /// <param name="dwQueue">
        /// The identifier for the work queue. This value can specify one of the standard Media Foundation work
        /// queues, or a work queue created by the application. For list of standard Media Foundation work
        /// queues, see <c>Work Queue Identifiers</c>. To create a new work queue, call 
        /// <see cref="MFExtern.MFAllocateWorkQueue"/> or <see cref="MFExtern.MFAllocateWorkQueueEx"/>. 
        /// </param>
        /// <param name="pCallback">
        /// A pointer to the <see cref="IMFAsyncCallback"/> interface. The caller must implement this
        /// interface. 
        /// </param>
        /// <param name="pState">
        /// A pointer to the <c>IUnknown</c> interface of a state object, defined by the caller. This parameter
        /// can be <strong>NULL</strong>. You can use this object to hold state information. The object is
        /// returned to the caller when the callback is invoked. 
        /// </param>
        /// <returns>
        /// Returns an <strong>HRESULT</strong> value. Possible values include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>Success.</description></item>
        /// <item><term><strong><strong>MF_E_INVALID_WORKQUEUE</strong></strong></term><description>Invalid work queue. For more information, see <see cref="IMFAsyncCallback.GetParameters"/>. </description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The <see cref="MFStartup"/> function was not called, or <see cref="MFExtern.MFShutdown"/> was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFPutWorkItem(
        ///   _In_  DWORD dwQueue,
        ///   _In_  IMFAsyncCallback *pCallback,
        ///   _In_  IUnknown *pState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B0233589-2A55-4803-9DCB-85D757734DEE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B0233589-2A55-4803-9DCB-85D757734DEE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFPutWorkItem(
            int dwQueue,
            IMFAsyncCallback pCallback,
            [MarshalAs(UnmanagedType.IUnknown)] object pState);

        /// <summary>
        /// Creates an instance of the <c>Media Session</c> inside a Protected Media Path (PMP) process. 
        /// </summary>
        /// <param name="dwCreationFlags">
        /// A member of the <see cref="MFPMPSessionCreationFlags"/> enumeration that specifies how to create
        /// the session object. 
        /// </param>
        /// <param name="pConfiguration">
        /// A pointer to the <see cref="IMFAttributes"/> interface. This parameter can be <strong>NULL</strong>
        /// . See Remarks. 
        /// </param>
        /// <param name="ppMediaSession">
        /// Receives a pointer to the PMP Media Session's <see cref="IMFMediaSession"/> interface. The caller
        /// must release the interface. Before releasing the last reference to the <strong>IMFMediaSession
        /// </strong> pointer, the application must call the <see cref="IMFMediaSession.Shutdown"/> method. 
        /// </param>
        /// <param name="ppEnablerActivate">
        /// Receives a pointer to the <see cref="IMFActivate"/> interface or the value <strong>NULL</strong>.
        /// If non- <strong>NULL</strong>, the caller must release the interface. See Remarks. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreatePMPMediaSession(
        ///   DWORD dwCreationFlags,
        ///   IMFAttributes *pConfiguration,
        ///   IMFMediaSession **ppMediaSession,
        ///   IMFActivate **ppEnablerActivate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CB492E68-3D8A-49B2-8C0B-BEE8065B53A8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CB492E68-3D8A-49B2-8C0B-BEE8065B53A8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreatePMPMediaSession(
            MFPMPSessionCreationFlags dwCreationFlags,
            IMFAttributes pConfiguration,
            out IMFMediaSession ppMediaSession,
            out IMFActivate ppEnablerActivate
        );

        /// <summary>
        /// Creates the <c>ASF Header Object</c> object. 
        /// </summary>
        /// <param name="ppIContentInfo">
        /// Receives a pointer to the <see cref="IMFASFContentInfo"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateASFContentInfo(
        ///   IMFASFContentInfo **ppIContentInfo
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/00460F79-7033-4893-88C0-B1C939441F70(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/00460F79-7033-4893-88C0-B1C939441F70(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateASFContentInfo(
            out IMFASFContentInfo ppIContentInfo);

        /// <summary>
        /// Creates the <c>ASF Splitter</c>. 
        /// </summary>
        /// <param name="ppISplitter">
        /// Receives a pointer to the <see cref="IMFASFSplitter"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateASFSplitter(
        ///   IMFASFSplitter **ppISplitter
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/05936A66-ED39-4645-ADFB-5816B9981771(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/05936A66-ED39-4645-ADFB-5816B9981771(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateASFSplitter(
            out IMFASFSplitter ppISplitter);

        /// <summary>
        /// Creates the ASF profile object.
        /// </summary>
        /// <param name="ppIProfile">
        /// Receives a pointer to the <see cref="IMFASFProfile"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateASFProfile(
        ///   IMFASFProfile **ppIProfile
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FA57FAC7-A191-4D5B-89BE-319AF7B3E09C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FA57FAC7-A191-4D5B-89BE-319AF7B3E09C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateASFProfile(
            out IMFASFProfile ppIProfile);

        /// <summary>
        /// Creates the <c>Streaming Audio Renderer</c>. 
        /// </summary>
        /// <param name="pAudioAttributes">
        /// A pointer to the <see cref="IMFAttributes"/> interface, which is used to configure the audio
        /// renderer. This parameter can be <strong>NULL</strong>. See Remarks. 
        /// </param>
        /// <param name="ppSink">
        /// Receives a pointer to the audio renderer's <see cref="IMFMediaSink"/> interface. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateAudioRenderer(
        ///   _In_   IMFAttributes *pAudioAttributes,
        ///   _Out_  IMFMediaSink **ppSink
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9554E39B-9D14-4B7F-862C-A1FFCF84543C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9554E39B-9D14-4B7F-862C-A1FFCF84543C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateAudioRenderer(
            IMFAttributes pAudioAttributes,
            out IMFMediaSink ppSink
        );

        /// <summary>
        /// Creates the ASF Indexer object.
        /// </summary>
        /// <param name="ppIIndexer">
        /// Receives a pointer to the <see cref="IMFASFIndexer"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateASFIndexer(
        ///   IMFASFIndexer **ppIIndexer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DF141F8E-10B4-4AC4-8A83-C25764B8F0C6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DF141F8E-10B4-4AC4-8A83-C25764B8F0C6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateASFIndexer(
            out IMFASFIndexer ppIIndexer);

        /// <summary>
        /// Calculates the minimum surface stride for a video format. 
        /// </summary>
        /// <param name="format">
        /// FOURCC code or <strong>D3DFORMAT</strong> value that specifies the video format. If you have a
        /// video subtype GUID, you can use the first <strong>DWORD</strong> of the subtype. 
        /// </param>
        /// <param name="dwWidth">
        /// Width of the image, in pixels.
        /// </param>
        /// <param name="pStride">
        /// Receives the minimum surface stride, in pixels.
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFGetStrideForBitmapInfoHeader(
        ///   _In_   DWORD format,
        ///   _In_   DWORD dwWidth,
        ///   _Out_  LONG *pStride
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/09612B83-8B14-4286-9562-9E3D00FE2C2B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/09612B83-8B14-4286-9562-9E3D00FE2C2B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("evr.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFGetStrideForBitmapInfoHeader(
            int format,
            int dwWidth,
            out int pStride
            );

        /// <summary>
        /// Retrieves the image size for a video format. Given a <see cref="Misc.BitmapInfoHeader"/> structure,
        /// this function calculates the correct value of the <strong>biSizeImage</strong> member. 
        /// </summary>
        /// <param name="pBMIH">
        /// Pointer to a <strong>BITMAPINFOHEADER</strong> structure that describes the format. 
        /// </param>
        /// <param name="cbBufSize">
        /// Size of the <em>pBMIH</em> buffer, in bytes. The size includes any color masks or palette entries
        /// that follow the <strong>BITMAPINFOHEADER</strong> structure. 
        /// </param>
        /// <param name="pcbImageSize">
        /// Receives the image size, in bytes. 
        /// </param>
        /// <param name="pbKnown">
        /// Receives the value <strong>TRUE</strong> if the function recognizes the video format. Otherwise,
        /// receives the value <strong>FALSE</strong>. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The function succeeded. </description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description> The <strong>BITMAPINFOHEADER</strong> structure is not valid, or the value of <em>cbBufSize</em> is too small. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCalculateBitmapImageSize(
        ///   _In_   const BITMAPINFOHEADER *pBMIH,
        ///   _In_   UINT32 cbBufSize,
        ///   _Out_  UINT32 *pcbImageSize,
        ///   _Out_  BOOL *pbKnown
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/67D80DB8-996E-4F59-82F0-EFD3D4BD8FF0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/67D80DB8-996E-4F59-82F0-EFD3D4BD8FF0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCalculateBitmapImageSize(
            [In, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BMMarshaler))] BitmapInfoHeader pBMIH,
            [In] int cbBufSize,
            out int pcbImageSize,
            out bool pbKnown
            );

        /// <summary>
        /// Creates a media sample that manages a Direct3D surface. 
        /// </summary>
        /// <param name="pUnkSurface">
        /// A pointer to the <strong>IUnknown</strong> interface of the Direct3D surface. This parameter can be
        /// <strong>NULL</strong>. 
        /// </param>
        /// <param name="ppSample">
        /// Receives a pointer to the sample's <see cref="IMFSample"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateVideoSampleFromSurface(
        ///   _In_   IUnknown *pUnkSurface,
        ///   _Out_  IMFSample **ppSample
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D34D423B-4510-44CE-AB46-51560B01F205(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D34D423B-4510-44CE-AB46-51560B01F205(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("evr.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateVideoSampleFromSurface(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnkSurface,
            out IMFSample ppSample
            );

        /// <summary>
        /// Converts a video frame rate into a frame duration.
        /// </summary>
        /// <param name="unNumerator">
        /// The numerator of the frame rate. 
        /// </param>
        /// <param name="unDenominator">
        /// The denominator of the frame rate. 
        /// </param>
        /// <param name="punAverageTimePerFrame">
        /// Receives the average duration of a video frame, in 100-nanosecond units. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFFrameRateToAverageTimePerFrame(
        ///   _In_   UINT32 unNumerator,
        ///   _In_   UINT32 unDenominator,
        ///   _Out_  UINT64 *punAverageTimePerFrame
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/750F6920-3386-4D50-9D59-73E876B406DA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/750F6920-3386-4D50-9D59-73E876B406DA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFFrameRateToAverageTimePerFrame(
            [In] int unNumerator,
            [In] int unDenominator,
            out long punAverageTimePerFrame
            );

        /// <summary>
        /// Retrieves a media type that was wrapped in another media type by the 
        /// <see cref="MFExtern.MFWrapMediaType"/> function. 
        /// </summary>
        /// <param name="pWrap">
        /// Pointer to the <see cref="IMFMediaType"/> interface of the media type that was retrieved by 
        /// <see cref="MFExtern.MFWrapMediaType"/>. 
        /// </param>
        /// <param name="ppOrig">
        /// Receives a pointer to the <see cref="IMFMediaType"/> interface of the original media type. The
        /// caller must release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFUnwrapMediaType(
        ///   IMFMediaType *pWrap,
        ///   IMFMediaType **ppOrig
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2CB6A5AE-315F-4DE2-8817-DA9D41DB14B8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2CB6A5AE-315F-4DE2-8817-DA9D41DB14B8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFUnwrapMediaType(
            [In] IMFMediaType pWrap,
            out IMFMediaType ppOrig
            );
#endif
        
        // While these methods are tested, the interfaces they use are not

        /// <summary>
        /// Creates a new instance of the topology loader.
        /// </summary>
        /// <param name="ppObj">
        /// Receives a pointer to the <see cref="IMFTopoLoader"/> interface of the topology loader. The caller
        /// must release the interface.
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateTopoLoader(
        ///   IMFTopoLoader **ppObj
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/0C0173EF-9C29-465C-B725-CE38B220F94F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0C0173EF-9C29-465C-B725-CE38B220F94F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateTopoLoader(
            /* out IMFTopoLoader */ out IntPtr ppObj);

#if ALLOW_UNTESTED_INTERFACES

        /// <summary>
        /// Creates the default implementation of the quality manager.
        /// </summary>
        /// <param name="ppQualityManager">
        /// Receives a pointer to the quality manager's <see cref="IMFQualityManager"/> interface. The caller
        /// must release the interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateStandardQualityManager(
        ///   _Out_  IMFQualityManager **ppQualityManager
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9ABAA474-8A00-4E36-897D-9DE9578333B7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9ABAA474-8A00-4E36-897D-9DE9578333B7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateStandardQualityManager(
            out IMFQualityManager ppQualityManager
        );

        /// <summary>
        /// Creates the protected media path (PMP) server object.
        /// </summary>
        /// <param name="dwCreationFlags">
        /// A member of the <see cref="MFPMPSessionCreationFlags"/> enumeration that specifies how to create
        /// the PMP session. 
        /// </param>
        /// <param name="ppPMPServer">
        /// Receives a pointer to the <see cref="IMFPMPServer"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The function succeeded. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreatePMPServer(
        ///   _In_   DWORD dwCreationFlags,
        ///   _Out_  IMFPMPServer **ppPMPServer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2BF5541E-9B7E-4E7A-A868-4956C1F70882(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2BF5541E-9B7E-4E7A-A868-4956C1F70882(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreatePMPServer(
            MFPMPSessionCreationFlags dwCreationFlags,
            out IMFPMPServer ppPMPServer
        );

        /// <summary>
        /// Creates the ASF Multiplexer.
        /// </summary>
        /// <param name="ppIMultiplexer">
        /// Receives a pointer to the <see cref="IMFASFMultiplexer"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateASFMultiplexer(
        ///   IMFASFMultiplexer **ppIMultiplexer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4C3DED7E-51EF-4141-98F2-48B318BA9453(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4C3DED7E-51EF-4141-98F2-48B318BA9453(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateASFMultiplexer(
            out IMFASFMultiplexer ppIMultiplexer);
#endif

#if ALLOW_UNTESTED_INTERFACES
        
        /// <summary>
        /// Puts an asynchronous operation on a work queue. 
        /// </summary>
        /// <param name="dwQueue">
        /// The identifier for the work queue. This value can specify one of the standard Media Foundation work
        /// queues, or a work queue created by the application. For list of standard Media Foundation work
        /// queues, see <c>Work Queue Identifiers</c>. To create a new work queue, call 
        /// <see cref="MFExtern.MFAllocateWorkQueue"/> or <see cref="MFExtern.MFAllocateWorkQueueEx"/>. 
        /// </param>
        /// <param name="pResult">
        /// A pointer to the <see cref="IMFAsyncResult"/> interface of an asynchronous result object. To create
        /// the result object, call <see cref="MFExtern.MFCreateAsyncResult"/>. 
        /// </param>
        /// <returns>
        /// Returns an <strong>HRESULT</strong> value. Possible values include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description> Success.</description></item>
        /// <item><term><strong><strong>MF_E_INVALID_WORKQUEUE</strong></strong></term><description>Invalid work queue identifier. For more information, see <see cref="IMFAsyncCallback.GetParameters"/>. </description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The <see cref="MFStartup"/> function was not called, or <see cref="MFExtern.MFShutdown"/> was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFPutWorkItemEx(
        ///   _In_  DWORD dwQueue,
        ///   _In_  IMFAsyncResult *pResult
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/67B4F7C6-0D49-4ED0-9BC3-E583451884AF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/67B4F7C6-0D49-4ED0-9BC3-E583451884AF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFPutWorkItemEx(
            int dwQueue,
            IMFAsyncResult pResult);

        /// <summary>
        /// Schedules an asynchronous operation to be completed after a specified interval.
        /// </summary>
        /// <param name="pCallback">
        /// Pointer to the <see cref="IMFAsyncCallback"/> interface. The caller must implement this interface. 
        /// </param>
        /// <param name="pState">
        /// Pointer to the <strong>IUnknown</strong> interface of a state object, defined by the caller. This
        /// parameter can be <strong>NULL</strong>. You can use this object to hold state information. The
        /// object is returned to the caller when the callback is invoked. 
        /// </param>
        /// <param name="Timeout">
        /// Time-out interval, in milliseconds. Set this parameter to a negative value. The callback is invoked
        /// after ? <em>Timeout</em> milliseconds. For example, if <em>Timeout</em> is ?5000, the callback is
        /// invoked after 5000 milliseconds. 
        /// </param>
        /// <param name="pKey">
        /// Receives a key that can be used to cancel the timer. To cancel the timer, call 
        /// <see cref="MFExtern.MFCancelWorkItem"/> and pass this key in the <em>Key</em> parameter. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFScheduleWorkItem(
        ///   _In_   IMFAsyncCallback *pCallback,
        ///   _In_   IUnknown *pState,
        ///   _In_   INT64 Timeout,
        ///   _Out_  MFWORKITEM_KEY *pKey
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C14786E4-7FBE-4748-A6BA-E9E68F78B241(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C14786E4-7FBE-4748-A6BA-E9E68F78B241(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFScheduleWorkItem(
            IMFAsyncCallback pCallback,
            [MarshalAs(UnmanagedType.IUnknown)] object pState,
            long Timeout,
            long pKey);

        /// <summary>
        /// Schedules an asynchronous operation to be completed after a specified interval.
        /// </summary>
        /// <param name="pResult">
        /// Pointer to the <see cref="IMFAsyncResult"/> interface of an asynchronous result object. To create
        /// the result object, call <see cref="MFExtern.MFCreateAsyncResult"/>. 
        /// </param>
        /// <param name="Timeout">
        /// Time-out interval, in milliseconds. Set this parameter to a negative value. The callback is invoked
        /// after ? <em>Timeout</em> milliseconds. For example, if <em>Timeout</em> is ?5000, the callback is
        /// invoked after 5000 milliseconds. 
        /// </param>
        /// <param name="pKey">
        /// Receives a key that can be used to cancel the timer. To cancel the timer, call 
        /// <see cref="MFExtern.MFCancelWorkItem"/> and pass this key in the <em>Key</em> parameter. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFScheduleWorkItemEx(
        ///   _In_   IMFAsyncResult *pResult,
        ///   _In_   INT64 Timeout,
        ///   _Out_  MFWORKITEM_KEY *pKey
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B698CAE1-4F3B-4649-B6F7-583F223EB90C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B698CAE1-4F3B-4649-B6F7-583F223EB90C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFScheduleWorkItemEx(
            IMFAsyncResult pResult,
            long Timeout,
            long pKey);

        /// <summary>
        /// Attempts to cancel an asynchronous operation that was scheduled with 
        /// <see cref="MFExtern.MFScheduleWorkItem"/> or <see cref="MFExtern.MFScheduleWorkItemEx"/>. 
        /// </summary>
        /// <param name="Key">
        /// The key that was received in the <em>pKey</em> parameter of the 
        /// <see cref="MFExtern.MFScheduleWorkItem"/> or <see cref="MFExtern.MFScheduleWorkItemEx"/> function. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCancelWorkItem(
        ///   _In_  MFWORKITEM_KEY Key
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A24FAE61-30C8-4ACA-B067-22B99F904FD8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A24FAE61-30C8-4ACA-B067-22B99F904FD8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCancelWorkItem(
            long Key);

        /// <summary>
        /// Sets a callback function to be called at a fixed interval.
        /// </summary>
        /// <param name="Callback">
        /// Pointer to the callback function, of type <c>MFPERIODICCALLBACK</c>. 
        /// </param>
        /// <param name="pContext">
        /// Pointer to a caller-provided object that implements <strong>IUnknown</strong>, or <strong>NULL
        /// </strong>. This parameter is passed to the callback function. 
        /// </param>
        /// <param name="pdwKey">
        /// Receives a key that can be used to cancel the callback. To cancel the callback, call 
        /// <see cref="MFExtern.MFRemovePeriodicCallback"/> and pass this key as the <em>dwKey</em> parameter. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFAddPeriodicCallback(
        ///   _In_   MFPERIODICCALLBACK Callback,
        ///   _In_   IUnknown *pContext,
        ///   _Out_  DWORD *pdwKey
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E5898FC8-72E9-45CC-8E85-4410ED7CC512(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E5898FC8-72E9-45CC-8E85-4410ED7CC512(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFAddPeriodicCallback(
            IntPtr Callback,
            [MarshalAs(UnmanagedType.IUnknown)] object pContext,
            out int pdwKey);

        /// <summary>
        /// Cancels a callback function that was set by the <see cref="MFExtern.MFAddPeriodicCallback"/>
        /// function. 
        /// </summary>
        /// <param name="dwKey">
        /// Key that identifies the callback. This value is retrieved by the 
        /// <see cref="MFExtern.MFAddPeriodicCallback"/> function. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFRemovePeriodicCallback(
        ///   _In_  DWORD dwKey
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E70CDAD3-C330-4368-8EF8-D616157B5E72(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E70CDAD3-C330-4368-8EF8-D616157B5E72(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFRemovePeriodicCallback(
            int dwKey);

        /// <summary>
        /// Locks a work queue.
        /// </summary>
        /// <param name="dwWorkQueue">
        /// The identifier for the work queue. The identifier is returned by the 
        /// <see cref="MFExtern.MFAllocateWorkQueue"/> function. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFLockWorkQueue(
        ///   _In_  DWORD dwWorkQueue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/307A1EC5-E54A-47F6-8ACE-3B935081FAF8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/307A1EC5-E54A-47F6-8ACE-3B935081FAF8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFLockWorkQueue(
            [In] int dwWorkQueue);

        /// <summary>
        /// Associates a work queue with a Multimedia Class Scheduler Service (MMCSS) task.
        /// </summary>
        /// <param name="dwWorkQueueId">
        /// The identifier of the work queue. For private work queues, the identifier is returned by the 
        /// <see cref="MFExtern.MFAllocateWorkQueue"/> function. For platform work queues, see 
        /// <c>Work Queue Identifiers</c>. 
        /// </param>
        /// <param name="wszClass">
        /// The name of the MMCSS task.For more information, see <c>Multimedia Class Scheduler Service</c>. 
        /// </param>
        /// <param name="dwTaskId">
        /// The unique task identifier. To obtain a new task identifier, set this value to zero. 
        /// </param>
        /// <param name="pDoneCallback">
        /// A pointer to the <see cref="IMFAsyncCallback"/> interface of a callback object. The caller must
        /// implement this interface. 
        /// </param>
        /// <param name="pDoneState">
        /// A pointer to the <strong>IUnknown</strong> interface of a state object, defined by the caller. This
        /// parameter can be <strong>NULL</strong>. You can use this object to hold state information. The
        /// object is returned to the caller when the callback is invoked. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFBeginRegisterWorkQueueWithMMCSS(
        ///   _In_  DWORD dwWorkQueueId,
        ///   _In_  LPCWSTR wszClass,
        ///   _In_  DWORD dwTaskId,
        ///   _In_  IMFAsyncCallback *pDoneCallback,
        ///   _In_  IUnknown *pDoneState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9BCC6AB3-B7DA-4B32-A868-C16F83CE20CA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9BCC6AB3-B7DA-4B32-A868-C16F83CE20CA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", CharSet = CharSet.Unicode, ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFBeginRegisterWorkQueueWithMMCSS(
            int dwWorkQueueId,
            [In, MarshalAs(UnmanagedType.LPWStr)] string wszClass,
            int dwTaskId,
            [In] IMFAsyncCallback pDoneCallback,
            [In] [MarshalAs(UnmanagedType.IUnknown)] object pDoneState);

        /// <summary>
        /// Completes an asynchronous request to associate a work queue with a Multimedia Class Scheduler
        /// Service (MMCSS) task.
        /// </summary>
        /// <param name="pResult">
        /// Pointer to the <see cref="IMFAsyncResult"/> interface. Pass in the same pointer that your callback
        /// object received in the <see cref="IMFAsyncCallback.Invoke"/> method. 
        /// </param>
        /// <param name="pdwTaskId">
        /// The unique task identifier.
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFEndRegisterWorkQueueWithMMCSS(
        ///   _In_  IMFAsyncResult *pResult,
        ///   _In_  DWORD *pdwTaskId
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/42D71E1A-A538-45D3-BBF4-1835DB15BFF9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/42D71E1A-A538-45D3-BBF4-1835DB15BFF9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFEndRegisterWorkQueueWithMMCSS(
            [In] IMFAsyncResult pResult,
            out int pdwTaskId);

        /// <summary>
        /// Unregisters a work queue from a Multimedia Class Scheduler Service (MMCSS) task.
        /// </summary>
        /// <param name="dwWorkQueueId">
        /// The identifier of the work queue. For private work queues, the identifier is returned by the 
        /// <see cref="MFExtern.MFAllocateWorkQueue"/> function. For platform work queues, see 
        /// <c>Work Queue Identifiers</c>. 
        /// </param>
        /// <param name="pDoneCallback">
        /// Pointer to the <see cref="IMFAsyncCallback"/> interface of a callback object. The caller must
        /// implement this interface. 
        /// </param>
        /// <param name="pDoneState">
        /// Pointer to the <strong>IUnknown</strong> interface of a state object, defined by the caller. This
        /// parameter can be <strong>NULL</strong>. You can use this object to hold state information. The
        /// object is returned to the caller when the callback is invoked. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFBeginUnregisterWorkQueueWithMMCSS(
        ///   _In_  DWORD dwWorkQueueId,
        ///   _In_  IMFAsyncCallback *pDoneCallback,
        ///   _In_  IUnknown *pDoneState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E164785F-9899-45F0-805F-B091508E35AA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E164785F-9899-45F0-805F-B091508E35AA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFBeginUnregisterWorkQueueWithMMCSS(
            int dwWorkQueueId,
            [In] IMFAsyncCallback pDoneCallback,
            [In] [MarshalAs(UnmanagedType.IUnknown)] object pDoneState);

        /// <summary>
        /// Completes an asynchronous request to unregister a work queue from a Multimedia Class Scheduler
        /// Service (MMCSS) task.
        /// </summary>
        /// <param name="pResult">
        /// Pointer to the <see cref="IMFAsyncResult"/> interface. Pass in the same pointer that your callback
        /// object received in the <see cref="IMFAsyncCallback.Invoke"/> method. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFEndUnregisterWorkQueueWithMMCSS(
        ///   _In_  IMFAsyncResult *pResult
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/ECA38D5D-9CA3-442E-80CA-96D8927178A1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/ECA38D5D-9CA3-442E-80CA-96D8927178A1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFEndUnregisterWorkQueueWithMMCSS(
            [In] IMFAsyncResult pResult);


        /// <summary>
        /// <i>***** Documentation Missing *****</i>.
        /// </summary>
        /// <param name="dwWorkQueueId"><i>***** Documentation Missing *****</i>.</param>
        /// <param name="szClass"><i>***** Documentation Missing *****</i>.</param>
        /// <returns><i>***** Documentation Missing *****</i>.</returns>
        // BUG-BUG: Nowhere does this method appear in the header files !!!!
        [Obsolete("Don't use !!!! Nowhere does this method appear in the header files !!!!")]
        [DllImport("mf.dll", CharSet = CharSet.Unicode, ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFSetWorkQueueClass(
            int dwWorkQueueId,
            [MarshalAs(UnmanagedType.LPWStr)] string szClass);

        /// <summary>
        /// Retrieves the Multimedia Class Scheduler Service (MMCSS) class currently associated with this work
        /// queue.
        /// </summary>
        /// <param name="dwWorkQueueId">
        /// Identifier for the work queue. The identifier is retrieved by the 
        /// <see cref="MFExtern.MFAllocateWorkQueue"/> function. 
        /// </param>
        /// <param name="pwszClass">
        /// Pointer to a buffer that receives the name of the MMCSS class. This parameter can be <strong>NULL
        /// </strong>. 
        /// </param>
        /// <param name="pcchClass">
        /// On input, specifies the size of the <em>pwszClass</em> buffer, in characters. On output, receives
        /// the required size of the buffer, in characters. The size includes the terminating null character. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// <item><term><strong>MF_E_BUFFERTOOSMALL</strong></term><description>The <em>pwszClass</em> buffer is too small to receive the task name. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFGetWorkQueueMMCSSClass(
        ///   _In_     DWORD dwWorkQueueId,
        ///   _Out_    LPWSTR pwszClass,
        ///   _Inout_  DWORD *pcchClass
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/97B48D18-3844-4B97-9BAB-C5FC38EB927E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/97B48D18-3844-4B97-9BAB-C5FC38EB927E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", CharSet = CharSet.Unicode, ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFGetWorkQueueMMCSSClass(
            int dwWorkQueueId,
            [MarshalAs(UnmanagedType.LPWStr)] out string pwszClass,
            out int pcchClass);

        /// <summary>
        /// Retrieves the Multimedia Class Scheduler Service (MMCSS) task identifier currently associated with
        /// this work queue.
        /// </summary>
        /// <param name="dwWorkQueueId">
        /// Identifier for the work queue. The identifier is retrieved by the 
        /// <see cref="MFExtern.MFAllocateWorkQueue"/> function. 
        /// </param>
        /// <param name="pdwTaskId">
        /// Receives the task identifier.
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFGetWorkQueueMMCSSTaskId(
        ///   _In_   DWORD dwWorkQueueId,
        ///   _Out_  LPDWORD pdwTaskId
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E9B2EEA8-2ED3-4B08-AD2A-C8EE2E09F3E4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E9B2EEA8-2ED3-4B08-AD2A-C8EE2E09F3E4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFGetWorkQueueMMCSSTaskId(
            int dwWorkQueueId,
            out int pdwTaskId);
        
        /// <summary>
        /// Creates an instance of the AC-3 media sink.
        /// </summary>
        /// <param name="pTargetByteStream">
        /// A pointer to the <see cref="IMFByteStream"/> interface of a byte stream. The media sink writes the
        /// AC-3 file to this byte stream. The byte stream must be writable. 
        /// </param>
        /// <param name="pAudioMediaType">
        /// A pointer to the <see cref="IMFMediaType"/> interface. This parameter specifies the media type for
        /// the AC-3 audio stream. The media type must contain the following attributes. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Attribute</term><description>Value</description></listheader>
        /// <item><term><see cref="MFAttributesClsid.MF_MT_MAJOR_TYPE"/></term><description><strong>MFMediaType_Audio</strong></description></item>
        /// <item><term><see cref="MFAttributesClsid.MF_MT_SUBTYPE"/></term><description><strong>MFAudioFormat_Dolby_AC3</strong> or <strong>MFAudioFormat_Dolby_DDPlus</strong></description></item>
        /// </list>
        /// </param>
        /// <param name="ppMediaSink">
        /// Receives a pointer to the <see cref="IMFMediaSink"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateAC3MediaSink(
        ///   _In_   IMFByteStream *pTargetByteStream,
        ///   _In_   IMFMediaType *pAudioMediaType,
        ///   _Out_  IMFMediaSink **ppMediaSink
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/49203EBF-24F3-4D9D-85EC-77BD8780BB41(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/49203EBF-24F3-4D9D-85EC-77BD8780BB41(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateAC3MediaSink(
            IMFByteStream pTargetByteStream,
            IMFMediaType pAudioMediaType,
            out IMFMediaSink ppMediaSink
        );

        /// <summary>
        /// Creates an instance of the audio data transport stream (ADTS) media sink.
        /// </summary>
        /// <param name="pTargetByteStream">
        /// A pointer to the <see cref="IMFByteStream"/> interface of a byte stream. The media sink writes the
        /// ADTS stream to this byte stream. The byte stream must be writable. 
        /// </param>
        /// <param name="pAudioMediaType">
        /// A pointer to the <see cref="IMFMediaType"/> interface. This parameter specifies the media type for
        /// the ADTS stream. The media type must contain the following attributes. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Attribute</term><description>Value</description></listheader>
        /// <item><term><see cref="MFAttributesClsid.MF_MT_MAJOR_TYPE"/></term><description><strong>MFMediaType_Audio</strong></description></item>
        /// <item><term><see cref="MFAttributesClsid.MF_MT_SUBTYPE"/></term><description><strong>MFAudioFormat_AAC</strong></description></item>
        /// <item><term><see cref="MFAttributesClsid.MF_MT_AAC_PAYLOAD_TYPE"/></term><description>0 (raw AAC) or 1 (ADTS)</description></item>
        /// </list>
        /// </param>
        /// <param name="ppMediaSink">
        /// Receives a pointer to the <see cref="IMFMediaSink"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateADTSMediaSink(
        ///   _In_   IMFByteStream *pTargetByteStream,
        ///   _In_   IMFMediaType *pAudioMediaType,
        ///   _Out_  IMFMediaSink **ppMediaSink
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/18B2F5C7-61A6-447B-9BC8-2394A68BA777(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/18B2F5C7-61A6-447B-9BC8-2394A68BA777(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateADTSMediaSink(
            IMFByteStream pTargetByteStream,
            IMFMediaType pAudioMediaType,
            out IMFMediaSink ppMediaSink
        );

        /// <summary>
        /// Creates a generic media sink that wraps a multiplexer Microsoft Media Foundation transform (MFT).
        /// </summary>
        /// <param name="guidOutputSubType">
        /// The subtype GUID of the output type for the MFT.
        /// </param>
        /// <param name="pOutputAttributes">
        /// A list of format attributes for the MFT output type. This parameter is optional and can be <strong>
        /// NULL</strong>. 
        /// </param>
        /// <param name="pOutputByteStream">
        /// A pointer to the <see cref="IMFByteStream"/> interface of a byte stream. The output from the MFT is
        /// written to this byte stream. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="ppMuxSink">
        /// Receives a pointer to the <see cref="IMFMediaSink"/> interface of the media sink. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateMuxSink(
        ///   _In_   GUID guidOutputSubType,
        ///   _In_   IMFAttributes *pOutputAttributes,
        ///   _In_   IMFByteStream *pOutputByteStream,
        ///   _Out_  IMFMediaSink **ppMuxSink
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/31A8790B-4C71-4D0D-B686-27B345745872(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/31A8790B-4C71-4D0D-B686-27B345745872(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateMuxSink(
        [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidOutputSubType,
            IMFAttributes pOutputAttributes,
            IMFByteStream pOutputByteStream,
            out IMFMediaSink ppMuxSink
        );

        /// <summary>
        /// Creates a media sink for authoring fragmented MP4 files.
        /// </summary>
        /// <param name="pIByteStream">
        /// A pointer to the <see cref="IMFByteStream"/> interface of a byte stream. The media sink writes the
        /// MP4 file to this byte stream. The byte stream must be writable and support seeking. 
        /// </param>
        /// <param name="pVideoMediaType">
        /// A pointer to the <see cref="IMFMediaType"/> interface of a video media type. This type specifies
        /// the format of the video stream. 
        /// <para/>
        /// This parameter can be <strong>NULL</strong>, but not if <em>pAudioMediaType</em> is <strong>NULL
        /// </strong>. 
        /// </param>
        /// <param name="pAudioMediaType">
        /// A pointer to the <see cref="IMFMediaType"/> interface of an audio media type. This type specifies
        /// the format of the audio stream. 
        /// <para/>
        /// This parameter can be <strong>NULL</strong>, but not if <em>pVideoMediaType</em> is <strong>NULL
        /// </strong>. 
        /// </param>
        /// <param name="ppIMediaSink">
        /// Receives a pointer to the MP4 media sink's <see cref="IMFMediaSink"/> interface. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT WINAPI MFCreateFMPEG4MediaSink(
        ///   _In_   IMFByteStream *pIByteStream,
        ///   _In_   IMFMediaType *pVideoMediaType,
        ///   _In_   IMFMediaType *pAudioMediaType,
        ///   _Out_  IMFMediaSink **ppIMediaSink
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/31FDA8BD-C837-4CA4-8635-D4A7B53AC7AC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/31FDA8BD-C837-4CA4-8635-D4A7B53AC7AC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateFMPEG4MediaSink(
            IMFByteStream pIByteStream,
            IMFMediaType pVideoMediaType,
            IMFMediaType pAudioMediaType,
            out IMFMediaSink ppIMediaSink
        );

        /// <summary>
        /// Creates a topology for transcoding to a byte stream.
        /// </summary>
        /// <param name="pSrc">
        /// A pointer to the <see cref="IMFMediaSource"/> interface of a media source. The media source
        /// provides that source content for transcoding. 
        /// </param>
        /// <param name="pOutputStream">
        /// A pointer to the <see cref="IMFByteStream"/> interface of a byte stream. The transcoded output will
        /// be written to this byte stream. 
        /// </param>
        /// <param name="pProfile">
        /// A pointer to the <see cref="IMFTranscodeProfile"/> interface of a transcoding profile. 
        /// </param>
        /// <param name="ppTranscodeTopo">
        /// Receives a pointer to the <see cref="IMFTopology"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateTranscodeTopologyFromByteStream(
        ///   _In_   IMFMediaSource *pSrc,
        ///   _In_   IMFByteStream *pOutputStream,
        ///   _In_   IMFTranscodeProfile *pProfile,
        ///   _Out_  IMFTopology **ppTranscodeTopo
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FBA9E0A1-7763-4566-8245-D626C82D0355(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FBA9E0A1-7763-4566-8245-D626C82D0355(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateTranscodeTopologyFromByteStream(
            IMFMediaSource pSrc,
            IMFByteStream pOutputStream,
            IMFTranscodeProfile pProfile,
            out IMFTopology ppTranscodeTopo
        );

        /// <summary>
        /// Creates an <see cref="EVR.IMFTrackedSample"/> object that tracks the reference counts on a video
        /// media sample. 
        /// </summary>
        /// <param name="ppMFSample">
        /// Receives a pointer to the <see cref="EVR.IMFTrackedSample"/> interface. 
        /// </param>
        /// <returns>System.Int32.</returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// STDAPI MFCreateTrackedSample(
        ///   _Out_  IMFTrackedSample **ppMFSample
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/05FB8F94-94B2-46A5-A890-E37E501233E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/05FB8F94-94B2-46A5-A890-E37E501233E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateTrackedSample(
            out IMFTrackedSample ppMFSample
        );

        /// <summary>
        /// Returns an <c>IStream</c> pointer that wraps a Microsoft Media Foundation byte stream. 
        /// </summary>
        /// <param name="pByteStream">
        /// A pointer to the <see cref="IMFByteStream"/> interface of the Media Foundation byte stream. 
        /// </param>
        /// <param name="ppStream">
        /// Receives a pointer to the <c>IStream</c> interface. The caller must release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateStreamOnMFByteStream(
        ///   _In_   IMFByteStream *pByteStream,
        ///   _Out_  IStream **ppStream
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/97C72B89-2E57-494E-AEB8-41125B3D740E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/97C72B89-2E57-494E-AEB8-41125B3D740E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateStreamOnMFByteStream(
            IMFByteStream pByteStream,
            out IStream ppStream
        );

        /// <summary>
        /// Creates a Microsoft Media Foundation byte stream that wraps an <c>IRandomAccessStream</c> object. 
        /// </summary>
        /// <param name="punkStream">
        /// A pointer to the <c>IRandomAccessStream</c> interface. 
        /// </param>
        /// <param name="ppByteStream">
        /// Receives a pointer to the <see cref="IMFByteStream"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateMFByteStreamOnStreamEx(
        ///   _In_   IUnknown punkStream,
        ///   _Out_  IMFByteStream **ppByteStream
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C16C2A5D-7373-4EA9-A02C-3AF97EA47D34(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C16C2A5D-7373-4EA9-A02C-3AF97EA47D34(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateMFByteStreamOnStreamEx(
            [MarshalAs(UnmanagedType.IUnknown)] object punkStream,
            out IMFByteStream ppByteStream
        );

        /// <summary>
        /// Creates an <c>IRandomAccessStream</c> object that wraps a Microsoft Media Foundation byte stream. 
        /// </summary>
        /// <param name="pByteStream">
        /// A pointer to the <see cref="IMFByteStream"/> interface of the Media Foundation byte stream. 
        /// </param>
        /// <param name="riid">
        /// The interface identifier (IID) of the interface being requested. 
        /// </param>
        /// <param name="ppv">
        /// Receives a pointer to the requested interface. The caller must release the interface.
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateStreamOnMFByteStreamEx(
        ///   _In_   IMFByteStream *pByteStream,
        ///   _In_   REFIID riid,
        ///   _Out_  void **ppv
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5D43889B-6430-4057-87E8-B8501B52E4A5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5D43889B-6430-4057-87E8-B8501B52E4A5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateStreamOnMFByteStreamEx(
            IMFByteStream pByteStream,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppv
        );

        /// <summary>
        /// Create an <see cref="IMFMediaType"/> from properties. 
        /// </summary>
        /// <param name="punkStream">
        /// A pointer to properties.
        /// </param>
        /// <param name="ppMediaType">
        /// Receives a pointer to the <see cref="IMFMediaType"/>. The caller must release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT WINAPI MFCreateMediaTypeFromProperties(
        ///   _In_   IUnknown *punkStream,
        ///   _Out_  IMFMediaType **ppMediaType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F34F5C7F-880B-40A8-85EF-537CD36759CB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F34F5C7F-880B-40A8-85EF-537CD36759CB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateMediaTypeFromProperties(
        [MarshalAs(UnmanagedType.IUnknown)] object punkStream,
            out IMFMediaType ppMediaType
        );

        /// <summary>
        /// Creates properties from a <see cref="IMFMediaType"/>. 
        /// </summary>
        /// <param name="pMediaType">
        /// A pointer to the <see cref="IMFMediaType"/> interface. 
        /// </param>
        /// <param name="riid">
        /// The interface identifier (IID) of the interface being requested. 
        /// </param>
        /// <param name="ppv">
        /// Receives a pointer to the requested interface. The caller must release the interface.
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT WINAPI MFCreatePropertiesFromMediaType(
        ///   _In_   IMFMediaType *pMediaType,
        ///   _In_   REFIID riid,
        ///   _Out_  void **ppv
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D9B639BB-285C-40BF-B111-2C5501E41CE1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D9B639BB-285C-40BF-B111-2C5501E41CE1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreatePropertiesFromMediaType(
            IMFMediaType pMediaType,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppv
        );

        /// <summary>
        /// Creates an <see cref="IMFProtectedEnvironmentAccess"/> object that allows content protection
        /// systems to perform a handshake with the protected environment. 
        /// </summary>
        /// <param name="ppAccess">
        /// Receives a pointer to the <see cref="IMFProtectedEnvironmentAccess"/> interface. 
        /// </param>
        /// <returns>System.Int32.</returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// STDAPI MFCreateProtectedEnvironmentAccess(
        ///   _Out_  IMFProtectedEnvironmentAccess **ppAccess
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B16BEFFD-26CF-4598-96A4-098C3E3AA51C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B16BEFFD-26CF-4598-96A4-098C3E3AA51C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateProtectedEnvironmentAccess(
            out IMFProtectedEnvironmentAccess ppAccess
        );

        /// <summary>
        /// Loads a dynamic link library that is signed for the protected environment.
        /// </summary>
        /// <param name="pszName">
        /// The name of the dynamic link library to load.  This dynamic link library must be signed for the
        /// protected environment.
        /// </param>
        /// <param name="ppLib">
        /// Receives a pointer to the <see cref="IMFSignedLibrary"/> interface for the library. 
        /// </param>
        /// <returns>System.Int32.</returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// STDAPI MFLoadSignedLibrary(
        ///   _In_   LPCWSTR pszName,
        ///   _Out_  IMFSignedLibrary **ppLib
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/979A5FE5-0DED-4C5A-A27D-CDD10A4A8D5C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/979A5FE5-0DED-4C5A-A27D-CDD10A4A8D5C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFLoadSignedLibrary(
        [In, MarshalAs(UnmanagedType.LPWStr)] string pszName,
            out IMFSignedLibrary ppLib
        );

        /// <summary>
        /// Returns an <see cref="IMFSystemId"/> object for retrieving system id data. 
        /// </summary>
        /// <param name="ppId">
        /// Receives a pointer to the <see cref="IMFSystemId"/> interface. 
        /// </param>
        /// <returns>System.Int32.</returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// STDAPI MFGetSystemId(
        ///   _Out_  IMFSystemId **ppId
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E68B4DFF-EBB1-410E-9B6F-C9933A171E27(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E68B4DFF-EBB1-410E-9B6F-C9933A171E27(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFGetSystemId(
            out IMFSystemId ppId
        );

        /// <summary>
        /// Puts an asynchronous operation on a work queue, with a specified priority.
        /// </summary>
        /// <param name="dwQueue">
        /// The identifier for the work queue. This value can specify one of the standard Media Foundation work
        /// queues, or a work queue created by the application. For list of standard Media Foundation work
        /// queues, see <c>Work Queue Identifiers</c>. To create a new work queue, call 
        /// <see cref="MFExtern.MFAllocateWorkQueue"/> or MFAllocateWorkQueueEx. 
        /// </param>
        /// <param name="Priority">
        /// The priority of the work item. Work items are performed in order of priority.
        /// </param>
        /// <param name="pCallback">
        /// A pointer to the <see cref="IMFAsyncCallback"/> interface. The caller must implement this
        /// interface. 
        /// </param>
        /// <param name="pState">
        /// A pointer to the <c>IUnknown</c> interface of a state object, defined by the caller. This parameter
        /// can be <strong>NULL</strong>. You can use this object to hold state information. The object is
        /// returned to the caller when the callback is invoked. 
        /// </param>
        /// <returns>
        /// Returns an <strong>HRESULT</strong> value. Possible values include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>Success.</description></item>
        /// <item><term><strong><strong>MF_E_INVALID_WORKQUEUE</strong></strong></term><description>Invalid work queue identifier.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The <see cref="MFStartup"/> function was not called, or <see cref="MFExtern.MFShutdown"/> was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFPutWorkItem2(
        ///   _In_  DWORD dwQueue,
        ///   _In_  LONG Priority,
        ///   _In_  IMFAsyncCallback *pCallback,
        ///   _In_  IUnknown *pState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C49818B3-83FF-40CE-B68A-F60F3277F7B8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C49818B3-83FF-40CE-B68A-F60F3277F7B8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFPutWorkItem2(
            int dwQueue,
            int Priority,
            IMFAsyncCallback pCallback,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pState
        );

        /// <summary>
        /// Puts an asynchronous operation on a work queue, with a specified priority.
        /// </summary>
        /// <param name="dwQueue">
        /// The identifier for the work queue. This value can specify one of the standard Media Foundation work
        /// queues, or a work queue created by the application. For list of standard Media Foundation work
        /// queues, see <c>Work Queue Identifiers</c>. To create a new work queue, call 
        /// <see cref="MFExtern.MFAllocateWorkQueue"/> or <see cref="MFExtern.MFAllocateWorkQueueEx"/>. 
        /// </param>
        /// <param name="Priority">
        /// The priority of the work item. Work items are performed in order of priority.
        /// </param>
        /// <param name="pResult">
        /// A pointer to the <see cref="IMFAsyncResult"/> interface of an asynchronous result object. To create
        /// the result object, call <see cref="MFExtern.MFCreateAsyncResult"/>. 
        /// </param>
        /// <returns>
        /// Returns an <strong>HRESULT</strong> value. Possible values include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description> Success.</description></item>
        /// <item><term><strong><strong>MF_E_INVALID_WORKQUEUE</strong></strong></term><description>Invalid work queue identifier.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The <see cref="MFStartup"/> function was not called, or <see cref="MFExtern.MFShutdown"/> was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFPutWorkItemEx2(
        ///   _In_  DWORD dwQueue,
        ///   _In_  LONG Priority,
        ///   _In_  IMFAsyncResult *pResult
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A29DC852-AF0F-4269-97FB-DA1F725E7C09(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A29DC852-AF0F-4269-97FB-DA1F725E7C09(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFPutWorkItemEx2(
            int dwQueue,
            int Priority,
            IMFAsyncResult pResult
        );

        /// <summary>
        /// Queues a work item that waits for an event to be signaled.
        /// </summary>
        /// <param name="hEvent">
        /// A handle to an event object. To create an event object, call <c>CreateEvent</c> or 
        /// <c>CreateEventEx</c>. 
        /// </param>
        /// <param name="Priority">
        /// The priority of the work item. Work items are performed in order of priority.
        /// </param>
        /// <param name="pResult">
        /// A pointer to the <see cref="IMFAsyncResult"/> interface of an asynchronous result object. To create
        /// the result object, call <see cref="MFExtern.MFCreateAsyncResult"/>. 
        /// </param>
        /// <param name="pKey">
        /// Receives a key that can be used to cancel the wait. To cancel the wait, call 
        /// <see cref="MFExtern.MFCancelWorkItem"/> and pass this key in the <em>Key</em> parameter. This
        /// parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFPutWaitingWorkItem(
        ///   _In_   HANDLE hEvent,
        ///   _In_   LONG Priority,
        ///   _In_   IMFAsyncResult *pResult,
        ///   _Out_  MFWORKITEM_KEY *pKey
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BBD80C60-E42F-4B3B-96E3-E01058A27DB8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BBD80C60-E42F-4B3B-96E3-E01058A27DB8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFPutWaitingWorkItem(
            IntPtr hEvent,
            int Priority,
            IMFAsyncResult pResult,
            out long pKey
        );

        /// <summary>
        /// Creates a work queue that is guaranteed to serialize work items. The serial work queue wraps an
        /// existing multithreaded work queue. The serial work queue enforces a first-in, first-out (FIFO)
        /// execution order.
        /// </summary>
        /// <param name="dwWorkQueue">
        /// The identifier of an existing work queue. This must be either a multithreaded queue or another
        /// serial work queue. Any of the following can be used:
        /// <para/>
        /// <para>* The default work queue ( <strong>MFASYNC_CALLBACK_QUEUE_STANDARD</strong>) </para><para>* 
        /// The platform multithreaded queue ( <strong>MFASYNC_CALLBACK_QUEUE_MULTITHREADED</strong>) </para>
        /// <para>* A multithreaded queue returned by the <see cref="MFExtern.MFLockSharedWorkQueue"/>
        /// function. </para><para>* A serial queue created by the <strong>MFAllocateSerialWorkQueue</strong>
        /// function. </para>
        /// </param>
        /// <param name="pdwWorkQueue">
        /// Receives an identifier for the new serial work queue. Use this identifier when queuing work items.
        /// </param>
        /// <returns>
        /// This function can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The function succeeded. </description></item>
        /// <item><term><strong>E_FAIL</strong></term><description> The application exceeded the maximum number of work queues. </description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description> The application did not call <see cref="MFStartup"/>, or the application has already called <see cref="MFExtern.MFShutdown"/>. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFAllocateSerialWorkQueue(
        ///   _In_   DWORD dwWorkQueue,
        ///   _Out_  DWORD *pdwWorkQueue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/45198662-C861-49A5-8962-DC256A671350(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/45198662-C861-49A5-8962-DC256A671350(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFAllocateSerialWorkQueue(
            int dwWorkQueue,
            out int pdwWorkQueue
        );

        /// <summary>
        /// Associates a work queue with a Multimedia Class Scheduler Service (MMCSS) task.
        /// </summary>
        /// <param name="dwWorkQueueId">
        /// The identifier of the work queue. For private work queues, the identifier is returned by the 
        /// <see cref="MFExtern.MFAllocateWorkQueue"/> function. For platform work queues, see 
        /// <c>Work Queue Identifiers</c>. 
        /// </param>
        /// <param name="wszClass">
        /// The name of the MMCSS task. For more information, see <c>Multimedia Class Scheduler Service</c>. 
        /// </param>
        /// <param name="dwTaskId">
        /// The unique task identifier. To obtain a new task identifier, set this value to zero. 
        /// </param>
        /// <param name="lPriority">
        /// The base relative priority for the work-queue threads. For more information, see 
        /// <c>AvSetMmThreadPriority</c>. 
        /// </param>
        /// <param name="pDoneCallback">
        /// A pointer to the <see cref="IMFAsyncCallback"/> interface of a callback object. The caller must
        /// implement this interface. 
        /// </param>
        /// <param name="pDoneState">
        /// A pointer to the <strong>IUnknown</strong> interface of a state object, defined by the caller. This
        /// parameter can be <strong>NULL</strong>. You can use this object to hold state information. The
        /// object is returned to the caller when the callback is invoked. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFBeginRegisterWorkQueueWithMMCSSEx(
        ///   _In_  DWORD dwWorkQueueId,
        ///   _In_  LPCWSTR wszClass,
        ///   _In_  DWORD dwTaskId,
        ///   _In_  LONG lPriority,
        ///   _In_  IMFAsyncCallback *pDoneCallback,
        ///   _In_  IUnknown *pDoneState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D27E2B51-857D-48E5-8D25-A26917FCF959(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D27E2B51-857D-48E5-8D25-A26917FCF959(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFBeginRegisterWorkQueueWithMMCSSEx(
            int dwWorkQueueId,
            [In, MarshalAs(UnmanagedType.LPWStr)] string wszClass,
            int dwTaskId,
            int lPriority,
            IMFAsyncCallback pDoneCallback,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pDoneState
        );

        /// <summary>
        /// Registers the standard Microsoft Media Foundation platform work queues with the Multimedia Class
        /// Scheduler Service (MMCSS). 
        /// </summary>
        /// <param name="wszClass">
        /// The name of the MMCSS task. 
        /// </param>
        /// <param name="pdwTaskId">
        /// The MMCSS task identifier. On input, specify an existing  MCCSS task group ID, or use the value
        /// zero to create a new task group. On output, receives the actual task group ID.
        /// </param>
        /// <param name="lPriority">
        /// The base priority of the work-queue threads. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFRegisterPlatformWithMMCSS(
        ///   _In_     PCWSTR wszClass,
        ///   _Inout_  DWORD *pdwTaskId,
        ///   _In_     LONG lPriority
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8F99849B-5363-4EEF-BCB8-C69A5309AF34(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8F99849B-5363-4EEF-BCB8-C69A5309AF34(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFRegisterPlatformWithMMCSS(
            [In, MarshalAs(UnmanagedType.LPWStr)] string wszClass,
            ref int pdwTaskId,
            int lPriority
        );

        /// <summary>
        /// Unregisters the Microsoft Media Foundation platform work queues from a Multimedia Class Scheduler
        /// Service (MMCSS) task.
        /// </summary>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFUnregisterPlatformFromMMCSS(void);
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B080E515-AD0E-492D-A9EF-8391DCEC3891(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B080E515-AD0E-492D-A9EF-8391DCEC3891(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFUnregisterPlatformFromMMCSS();

        /// <summary>
        /// Obtains and locks a shared work queue.
        /// </summary>
        /// <param name="wszClass">
        /// The name of the MMCSS task. 
        /// </param>
        /// <param name="BasePriority">
        /// The base priority of the work-queue threads. If the regular-priority queue is being used ( <em>
        /// wszClass</em>=""), then the value 0 must be passed in. 
        /// </param>
        /// <param name="pdwTaskId">
        /// The MMCSS task identifier. On input, specify an existing MCCSS task group ID , or use the value
        /// zero to create a new task group. If the regular priority queue is being used ( <em>wszClass</em>
        /// =""), then <strong>NULL</strong> must be passed in. On output, receives the actual task group ID. 
        /// </param>
        /// <param name="pID">
        /// Receives an identifier for the new work queue. Use this identifier when queuing work items.
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFLockSharedWorkQueue(
        ///   _In_     PCWSTR wszClass,
        ///   _In_     LONG BasePriority,
        ///   _Inout_  DWORD *pdwTaskId,
        ///   _Out_    DWORD *pID
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1E3AA1EE-83A4-42DE-961E-D93A34CE80CF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1E3AA1EE-83A4-42DE-961E-D93A34CE80CF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFLockSharedWorkQueue(
            [In, MarshalAs(UnmanagedType.LPWStr)] string wszClass,
            int BasePriority,
            ref int pdwTaskId,
            out int pID
        );

        /// <summary>
        /// Gets the relative thread priority of a work queue.
        /// </summary>
        /// <param name="dwWorkQueueId">
        /// The identifier of the work queue. For private work queues, the identifier is returned by the 
        /// <see cref="MFExtern.MFAllocateWorkQueue"/> function. For platform work queues, see 
        /// <c>Work Queue Identifiers</c>. 
        /// </param>
        /// <param name="lPriority">
        /// Receives the relative thread priority.
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFGetWorkQueueMMCSSPriority(
        ///   _In_   DWORD dwWorkQueueId,
        ///   _Out_  LONG *lPriority
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8ADF4751-3BC5-4353-9927-C7E0079D0B83(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8ADF4751-3BC5-4353-9927-C7E0079D0B83(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFGetWorkQueueMMCSSPriority(
            int dwWorkQueueId,
            out int lPriority
        );

        /// <summary>
        /// Converts a Microsoft Direct3D 9 format identifier to a Microsoft DirectX Graphics Infrastructure
        /// (DXGI) format identifier.
        /// </summary>
        /// <param name="dx9">
        /// The <c>D3DFORMAT</c> value or FOURCC code to convert. 
        /// </param>
        /// <returns>
        /// Returns a <c>DXGI_FORMAT</c> value. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// DXGI_FORMAT STDAPI MFMapDX9FormatToDXGIFormat(
        ///   _In_  DWORD dx9
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/66B6A512-0371-4984-88B3-CB37BE52AEC5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/66B6A512-0371-4984-88B3-CB37BE52AEC5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFMapDX9FormatToDXGIFormat(
            int dx9
        );

        /// <summary>
        /// Converts a Microsoft DirectX Graphics Infrastructure (DXGI) format identifier to a Microsoft
        /// Direct3D 9 format identifier.
        /// </summary>
        /// <param name="dx11">
        /// The <c>DXGI_FORMAT</c> value to convert. 
        /// </param>
        /// <returns>
        /// Returns a <c>D3DFORMAT</c> value or FOURCC code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// DWORD STDAPI MFMapDXGIFormatToDX9Format(
        ///   _In_  DXGI_FORMAT dx11
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D3DF4739-31CC-4D0E-9EF2-6FCCAB8969EF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D3DF4739-31CC-4D0E-9EF2-6FCCAB8969EF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFMapDXGIFormatToDX9Format(
            int dx11
        );

        /// <summary>
        /// Locks the shared Microsoft DirectX Graphics Infrastructure (DXGI) Device Manager.
        /// </summary>
        /// <param name="pResetToken">
        /// Receives a token that identifies this instance of the DXGI Device Manager. Use this token when
        /// calling <see cref="IMFDXGIDeviceManager.ResetDevice"/>. This parameter can be <strong>NULL</strong>
        /// . 
        /// </param>
        /// <param name="ppManager">
        /// Receives a pointer to the <see cref="IMFDXGIDeviceManager"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFLockDXGIDeviceManager(
        ///   _Out_  UINT *pResetToken,
        ///   _Out_  IMFDXGIDeviceManager **ppManager
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/01A789BA-C1DE-4EF8-81C4-261F59D5843B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/01A789BA-C1DE-4EF8-81C4-261F59D5843B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFLockDXGIDeviceManager(
            out int pResetToken,
            out IMFDXGIDeviceManager ppManager
        );

        /// <summary>
        /// Unlocks the shared Microsoft DirectX Graphics Infrastructure (DXGI) Device Manager.
        /// </summary>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFUnlockDXGIDeviceManager(void);
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/89121716-4F30-4ACD-AA48-F563550B94A1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/89121716-4F30-4ACD-AA48-F563550B94A1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFUnlockDXGIDeviceManager();

        /// <summary>
        /// Creates a media buffer object that manages a Windows Imaging Component (WIC) bitmap.
        /// </summary>
        /// <param name="riid">
        /// Set this parameter to <c>__uuidof(IWICBitmap)</c>. 
        /// </param>
        /// <param name="punkSurface">
        /// A pointer to the <c>IUnknown</c> interface of the bitmap surface. The bitmap surface must be a WIC
        /// bitmap that exposes the <c>IWICBitmap</c> interface. 
        /// </param>
        /// <param name="ppBuffer">
        /// Receives a pointer to the <see cref="IMFMediaBuffer"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateWICBitmapBuffer(
        ///   _In_   REFIID riid,
        ///   _In_   IUnknown *punkSurface,
        ///   _Out_  IMFMediaBuffer **ppBuffer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/029B7CC6-5B12-4A19-B6CD-B0D7E3F314B6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/029B7CC6-5B12-4A19-B6CD-B0D7E3F314B6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateWICBitmapBuffer(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.Interface)] object punkSurface,
            out IMFMediaBuffer ppBuffer
        );

        /// <summary>
        /// Creates a media buffer to manage a Microsoft DirectX Graphics Infrastructure (DXGI) surface.
        /// </summary>
        /// <param name="riid">
        /// Identifies the type of DXGI surface. This value must be <strong>IID_ID3D11Texture2D</strong>. 
        /// </param>
        /// <param name="punkSurface">
        /// A pointer to the <c>IUnknown</c> interface of the DXGI surface. 
        /// </param>
        /// <param name="uSubresourceIndex">
        /// The zero-based index of a subresource of the surface. The media buffer object is associated with
        /// this subresource.
        /// </param>
        /// <param name="fBottomUpWhenLinear">
        /// If <strong>TRUE</strong>, the buffer's <see cref="IMF2DBuffer.ContiguousCopyTo"/> method copies the
        /// buffer into a bottom-up format. The bottom-up format is compatible with GDI for uncompressed RGB
        /// images. If this parameter is <strong>FALSE</strong>, the <strong>ContiguousCopyTo</strong> method
        /// copies the buffer into a top-down format, which is compatible with Direct3D. 
        /// <para/>
        /// For more information about top-down versus bottom-up images, see <c>Image Stride</c>. 
        /// </param>
        /// <param name="ppBuffer">
        /// Receives a pointer to the <see cref="IMFMediaBuffer"/> interface. The caller must release the
        /// buffer. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateDXGISurfaceBuffer(
        ///   _In_   REFIID riid,
        ///   _In_   IUnknown *punkSurface,
        ///   _In_   UINT uSubresourceIndex,
        ///   _In_   BOOL fBottomUpWhenLinear,
        ///   _Out_  IMFMediaBuffer **ppBuffer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5D859F36-A82B-488B-A2F6-C697A1AA86BC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5D859F36-A82B-488B-A2F6-C697A1AA86BC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int
        MFCreateDXGISurfaceBuffer(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.Interface)] object punkSurface,
            int uSubresourceIndex,
            bool fBottomUpWhenLinear,
            out IMFMediaBuffer ppBuffer
        );

        /// <summary>
        /// Creates an object that allocates video samples that are compatible with Microsoft DirectX Graphics
        /// Infrastructure (DXGI).
        /// </summary>
        /// <param name="riid">
        /// The identifier of the interface to retrieve. Specify one of the following values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong><strong>IID_IUnknown</strong></strong></term><description>Retrieve an <c>IUnknown</c> pointer. </description></item>
        /// <item><term><strong><strong>IID_IMFVideoSampleAllocator</strong></strong></term><description>Retrieve an <see cref="IMFVideoSampleAllocator"/> pointer. </description></item>
        /// <item><term><strong><strong>IID_IMFVideoSampleAllocatorEx</strong></strong></term><description>Retrieve an <see cref="IMFVideoSampleAllocatorEx"/> pointer. </description></item>
        /// <item><term><strong><strong>IID_IMFVideoSampleAllocatorCallback</strong></strong></term><description>Retrieve an <see cref="IMFVideoSampleAllocatorCallback"/> pointer. </description></item>
        /// </list>
        /// </param>
        /// <param name="ppSampleAllocator">
        /// Receives a pointer to the requested interface. The caller must release the interface.
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateVideoSampleAllocatorEx(
        ///   _In_   REFIID riid,
        ///   _Out_  void** ppSampleAllocator
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AB2A4D0B-CDE0-462C-BF52-3F78D0093526(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AB2A4D0B-CDE0-462C-BF52-3F78D0093526(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateVideoSampleAllocatorEx(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.Interface)] out object ppSampleAllocator
        );

        /// <summary>
        /// Creates an instance of the Microsoft DirectX Graphics Infrastructure (DXGI) Device Manager.
        /// </summary>
        /// <param name="resetToken">
        /// Receives a token that identifies this instance of the DXGI Device Manager. Use this token when
        /// calling <see cref="IMFDXGIDeviceManager.ResetDevice"/>. 
        /// </param>
        /// <param name="ppDeviceManager">
        /// Receives a pointer to the <see cref="IMFDXGIDeviceManager"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateDXGIDeviceManager(
        ///   _Out_  UINT *pResetToken,
        ///   _Out_  IMFDXGIDeviceManager **ppDXVAManager
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5398B6D7-1E7D-4987-A163-3360C805EE9C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5398B6D7-1E7D-4987-A163-3360C805EE9C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateDXGIDeviceManager(
            out int resetToken,
            out IMFDXGIDeviceManager ppDeviceManager
        );

        /// <summary>
        /// Registers a scheme handler in the caller's process.
        /// </summary>
        /// <param name="szScheme">
        /// A string that contains the scheme. The scheme includes the trailing ':' character; for example,
        /// "http:".
        /// </param>
        /// <param name="pActivate">
        /// A pointer to the <see cref="IMFActivate"/> interface of an activation object. The caller implements
        /// this interface. The <see cref="IMFActivate.ActivateObject"/> method of the activation object must
        /// create a scheme handler object. The scheme handler exposes the <see cref="IMFSchemeHandler"/>
        /// interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFRegisterLocalSchemeHandler(
        ///   _In_  PCWSTR szScheme,
        ///   _In_  IMFActivate *pActivate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B0F14D11-D896-4CFC-8914-087611347BEB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B0F14D11-D896-4CFC-8914-087611347BEB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFRegisterLocalSchemeHandler(
            [In, MarshalAs(UnmanagedType.LPWStr)] string szScheme,
            IMFActivate pActivate
        );

        /// <summary>
        /// Registers a byte-stream handler in the caller's process.
        /// </summary>
        /// <param name="szFileExtension">
        /// A string that contains the file name extension for this handler.
        /// </param>
        /// <param name="szMimeType">
        /// A string that contains the MIME type for this handler.
        /// </param>
        /// <param name="pActivate">
        /// A pointer to the <see cref="IMFActivate"/> interface of an activation object. The caller implements
        /// this interface. The <see cref="IMFActivate.ActivateObject"/> method of the activation object must
        /// create a byte-stream handler. The byte-stream handler exposes the 
        /// <see cref="IMFByteStreamHandler"/> interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFRegisterLocalByteStreamHandler(
        ///   _In_  PCWSTR szFileExtension,
        ///   _In_  PCWSTR szMimeType,
        ///   _In_  IMFActivate *pActivate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B41FAA50-9CF7-4DD0-8571-1817C7C49276(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B41FAA50-9CF7-4DD0-8571-1817C7C49276(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFRegisterLocalByteStreamHandler(
            [In, MarshalAs(UnmanagedType.LPWStr)] string szFileExtension,
            [In, MarshalAs(UnmanagedType.LPWStr)] string szMimeType,
            IMFActivate pActivate
        );

        /// <summary>
        /// Creates a wrapper for a byte stream.
        /// </summary>
        /// <param name="pStream">
        /// A pointer to the <see cref="IMFByteStream"/> interface of the original byte stream. 
        /// </param>
        /// <param name="ppStreamWrapper">
        /// Receives a pointer to the <see cref="IMFByteStream"/> interface of the wrapper. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateMFByteStreamWrapper(
        ///   _In_  IMFByteStream *pStream,
        ///   _In_  IMFByteStream **ppStreamWrapper
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F6A9603D-39C8-4039-BAA0-81557CE29078(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F6A9603D-39C8-4039-BAA0-81557CE29078(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateMFByteStreamWrapper(
            IMFByteStream pStream,
            out IMFByteStream ppStreamWrapper
        );

        /// <summary>
        /// Creates an activation object for a Windows Runtime class.
        /// </summary>
        /// <param name="szActivatableClassId">
        /// The class identifier that is associated with the activatable runtime class.
        /// </param>
        /// <param name="pConfiguration">
        /// A pointer to an optional <c>IPropertySet</c> object, which is used to configure the Windows Runtime
        /// class. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="riid">
        /// The interface identifier (IID) of the interface being requested. The activation object created  by
        /// this function supports the following interfaces:
        /// <para/>
        /// <para>* <c>IClassFactory</c></para><para>* <see cref="IMFActivate"/></para><para>* 
        /// <c>IPersistStream</c></para>
        /// </param>
        /// <param name="ppvObject">
        /// Receives a pointer to the requested interface. The caller must release the interface.
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateMediaExtensionActivate(
        ///   _In_   PCWSTR szActivatableClassId,
        ///   _In_   IUnknown *pConfiguration,
        ///   _In_   REFIID riid,
        ///   _Out_  LPVOID *ppvObject
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3F9538F2-DB7A-4841-B61D-C59BC02718B1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3F9538F2-DB7A-4841-B61D-C59BC02718B1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateMediaExtensionActivate(
            [In, MarshalAs(UnmanagedType.LPWStr)] string szActivatableClassId,
            [MarshalAs(UnmanagedType.Interface)] object pConfiguration,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.Interface)] out object ppvObject
        );

#endif

        /// <summary>
        /// Creates a system-memory buffer object to hold 2D image data.
        /// </summary>
        /// <param name="dwWidth">
        /// Width of the image, in pixels. 
        /// </param>
        /// <param name="dwHeight">
        /// Height of the image, in pixels.
        /// </param>
        /// <param name="dwFourCC">
        /// A <strong>FOURCC</strong> code or <c>D3DFORMAT</c> value that specifies the video format. If you
        /// have a video subtype GUID, you can use the first <strong>DWORD</strong> of the subtype. 
        /// </param>
        /// <param name="fBottomUp">
        /// If <strong>TRUE,</strong> the buffer's <see cref="IMF2DBuffer.ContiguousCopyTo"/> method copies the
        /// buffer into a bottom-up format. The bottom-up format is compatible with GDI for uncompressed RGB
        /// images. If this parameter is <strong>FALSE</strong>, the <strong>ContiguousCopyTo</strong> method
        /// copies the buffer into a top-down format, which is compatible with DirectX. 
        /// <para/>
        /// For more information about top-down versus bottom-up images, see <c>Image Stride</c>. 
        /// </param>
        /// <param name="ppBuffer">
        /// Receives a pointer to the <see cref="IMFMediaBuffer"/> interface. 
        /// </param>
        /// <returns>
        /// This function can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_INVALIDMEDIATYPE</strong></term><description>Unrecognized video format.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreate2DMediaBuffer(
        ///   _In_   DWORD dwWidth,
        ///   _In_   DWORD dwHeight,
        ///   _In_   DWORD dwFourCC,
        ///   _In_   BOOL fBottomUp,
        ///   _Out_  IMFMediaBuffer **ppBuffer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7D999070-87BD-46AF-A4F0-C0A23DC1C876(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7D999070-87BD-46AF-A4F0-C0A23DC1C876(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreate2DMediaBuffer(
            int dwWidth,
            int dwHeight,
            int dwFourCC,
            bool fBottomUp,
            out IMFMediaBuffer ppBuffer
        );

        /// <summary>
        /// Allocates a system-memory buffer that is optimal for a specified media type.
        /// </summary>
        /// <param name="pMediaType">
        /// A pointer to the <see cref="IMFMediaType"/> interface of the media type. 
        /// </param>
        /// <param name="llDuration">
        /// The sample duration. This value is required for audio formats.
        /// </param>
        /// <param name="dwMinLength">
        /// The minimum size of the buffer, in bytes. The actual buffer size might be larger. Specify zero to
        /// allocate the default buffer size for the media type.
        /// </param>
        /// <param name="dwMinAlignment">
        /// The minimum memory alignment for the buffer. Specify zero to use the default memory alignment.
        /// </param>
        /// <param name="ppBuffer">
        /// Receives a pointer to the <see cref="IMFMediaBuffer"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateMediaBufferFromMediaType(
        ///   _In_   IMFMediaType *pMediaType,
        ///   _In_   LONGLONG llDuration,
        ///   _In_   DWORD dwMinLength,
        ///   _In_   DWORD dwMinAlignment,
        ///   _Out_  IMFMediaBuffer **ppBuffer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1EBDB616-6FA9-4E4E-9BC6-CA1E382A08D9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1EBDB616-6FA9-4E4E-9BC6-CA1E382A08D9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateMediaBufferFromMediaType(
            IMFMediaType pMediaType,
            long llDuration,
            int dwMinLength,
            int dwMinAlignment,
            /* out IMFMediaBuffer */ out IntPtr ppBuffer
        );

#if NOT_IN_USE

        /// <summary>
        /// Gets the class identifier for a content protection system.
        /// </summary>
        /// <param name="guidProtectionSystemID">
        /// The GUID that identifies the content protection system.
        /// </param>
        /// <param name="pclsid">
        /// Receives the class identifier to the content protection system.
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFGetContentProtectionSystemCLSID(
        ///   _In_   REFGUID guidProtectionSystemID,
        ///   _Out_  CLSID *pclsid
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/03E1AF8D-69C7-4988-A699-0BD71ED635AF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/03E1AF8D-69C7-4988-A699-0BD71ED635AF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFGetContentProtectionSystemCLSID(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidProtectionSystemID,
            out Guid pclsid
        );
        
        /// <summary>
        /// Creates an instance of the capture engine.
        /// </summary>
        /// <param name="ppCaptureEngine">
        /// Receives a pointer to the <see cref="IMFCaptureEngine"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If the function succeeds, it returns S_OK. Otherwise, it returns an <strong>HRESULT</strong> error
        /// code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateCaptureEngine(
        ///   _Out_  IMFCaptureEngine **ppCaptureEngine
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4B0C9DD6-135D-4412-A585-7E98A84101B5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4B0C9DD6-135D-4412-A585-7E98A84101B5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("MFCaptureEngine.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateCaptureEngine(
            out IMFCaptureEngine ppCaptureEngine
        );

#endif

        /// <summary>
        /// Creates the sink writer from a URL or byte stream.
        /// </summary>
        /// <param name="pwszOutputURL">
        /// A null-terminated string that contains the URL of the output file. This parameter can be <strong>
        /// NULL</strong>. 
        /// </param>
        /// <param name="pByteStream">
        /// Pointer to the <see cref="IMFByteStream"/> interface of a byte stream. This parameter can be 
        /// <strong>NULL</strong>. 
        /// <para/>
        /// If this parameter is a valid pointer, the sink writer writes to the provided byte stream. (The byte
        /// stream must be writable.) Otherwise, if <em>pByteStream</em> is <strong>NULL</strong>, the sink
        /// writer creates a new file named <em>pwszOutputURL</em>. 
        /// </param>
        /// <param name="pAttributes">
        /// Pointer to the <see cref="IMFAttributes"/> interface. You can use this parameter to configure the
        /// sink writer. For more information, see <c>Sink Writer Attributes</c>. This parameter can be 
        /// <strong>NULL</strong>. 
        /// </param>
        /// <param name="ppSinkWriter">
        /// Receives a pointer to the <see cref="ReadWrite.IMFSinkWriter"/> interface. The caller must release
        /// the interface. 
        /// </param>
        /// <returns>
        /// This function can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_NOT_FOUND</strong></term><description>The specified URL was not found.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateSinkWriterFromURL(
        ///   _In_   LPCWSTR pwszOutputURL,
        ///   _In_   IMFByteStream *pByteStream,
        ///   _In_   IMFAttributes *pAttributes,
        ///   _Out_  IMFSinkWriter **ppSinkWriter
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AC6A30C7-5E44-453A-8114-8D7D65332024(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AC6A30C7-5E44-453A-8114-8D7D65332024(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("Mfreadwrite.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateSinkWriterFromURL(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszOutputURL,
            IMFByteStream pByteStream,
            IMFAttributes pAttributes,
            /* out IMFSinkWriter */ out IntPtr ppSinkWriter
        );

#if NOT_IN_USE

        /// <summary>
        /// Creates the sink writer from a media sink.
        /// </summary>
        /// <param name="pMediaSink">
        /// Pointer to the <see cref="IMFMediaSink"/> interface of a media sink. 
        /// </param>
        /// <param name="pAttributes">
        /// Pointer to the <see cref="IMFAttributes"/> interface. You can use this parameter to configure the
        /// sink writer. For more information, see <c>Sink Writer Attributes</c>. This parameter can be 
        /// <strong>NULL</strong>. 
        /// </param>
        /// <param name="ppSinkWriter">
        /// Receives a pointer to the <see cref="ReadWrite.IMFSinkWriter"/> interface. The caller must release
        /// the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateSinkWriterFromMediaSink(
        ///   _In_   IMFMediaSink *pMediaSink,
        ///   _In_   IMFAttributes *pAttributes,
        ///   _Out_  IMFSinkWriter **ppSinkWriter
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/77BD81FE-BCBD-4BCD-9D3A-DD9FE6154337(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/77BD81FE-BCBD-4BCD-9D3A-DD9FE6154337(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("Mfreadwrite.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateSinkWriterFromMediaSink(
            IMFMediaSink pMediaSink,
            IMFAttributes pAttributes,
            out IMFSinkWriter ppSinkWriter
        );

        /// <summary>
        /// Creates the source reader from a URL.
        /// </summary>
        /// <param name="pwszURL">
        /// The URL  of a media file to open.
        /// </param>
        /// <param name="pAttributes">
        /// Pointer to the <see cref="IMFAttributes"/> interface. You can use this parameter to configure the
        /// source reader. For more information, see <c>Source Reader Attributes</c>. This parameter can be 
        /// <strong>NULL</strong>. 
        /// </param>
        /// <param name="ppSourceReader">
        /// Receives a pointer to the <see cref="ReadWrite.IMFSourceReader"/> interface. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateSourceReaderFromURL(
        ///   _In_   LPCWSTR pwszURL,
        ///   _In_   IMFAttributes *pAttributes,
        ///   _Out_  IMFSourceReader **ppSourceReader
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/060B4AB3-9A9F-4C90-A8C5-9C6D81877E2F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/060B4AB3-9A9F-4C90-A8C5-9C6D81877E2F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("Mfreadwrite.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateSourceReaderFromURL(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszURL,
            IMFAttributes pAttributes,
            out IMFSourceReader ppSourceReader
        );

        /// <summary>
        /// Creates the source reader from a byte stream.
        /// </summary>
        /// <param name="pByteStream">
        /// A pointer to the <see cref="IMFByteStream"/> interface of a byte stream. This byte stream will
        /// provide the source data for the source reader. 
        /// </param>
        /// <param name="pAttributes">
        /// Pointer to the <see cref="IMFAttributes"/> interface. You can use this parameter to configure the
        /// source reader. For more information, see <c>Source Reader Attributes</c>. This parameter can be 
        /// <strong>NULL</strong>. 
        /// </param>
        /// <param name="ppSourceReader">
        /// Receives a pointer to the <see cref="ReadWrite.IMFSourceReader"/> interface. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateSourceReaderFromByteStream(
        ///   _In_   IMFByteStream *pByteStream,
        ///   _In_   IMFAttributes *pAttributes,
        ///   _Out_  IMFSourceReader **ppSourceReader
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E167159D-902C-4C34-B5F0-EB764FE2DE1C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E167159D-902C-4C34-B5F0-EB764FE2DE1C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("Mfreadwrite.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateSourceReaderFromByteStream(
            IMFByteStream pByteStream,
            IMFAttributes pAttributes,
            out IMFSourceReader ppSourceReader
        );
#endif

        /// <summary>
        /// Creates the source reader from a media source.
        /// </summary>
        /// <param name="pMediaSource">
        /// A pointer to the <see cref="IMFMediaSource"/> interface of a media source.
        /// </param>
        /// <param name="pAttributes">
        /// Pointer to the <see cref="IMFAttributes"/> interface. You can use this parameter to configure the
        /// source reader. For more information, see <c>Source Reader Attributes</c>. This parameter can be
        /// <strong>NULL</strong>.
        /// </param>
        /// <param name="ppSourceReader">
        /// Receives a pointer to the <see cref="ReadWrite.IMFSourceReader"/> interface. The caller must
        /// release the interface.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_DRM_UNSUPPORTED</strong></strong></term><description>The source contains protected content.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateSourceReaderFromMediaSource(
        ///   _In_   IMFMediaSource *pMediaSource,
        ///   _In_   IMFAttributes *pAttributes,
        ///   _Out_  IMFSourceReader **ppSourceReader
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/924E1813-B025-435B-9770-52503A9EB619(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/924E1813-B025-435B-9770-52503A9EB619(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("Mfreadwrite.dll", ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateSourceReaderFromMediaSource(
            IMFMediaSource pMediaSource,
            IMFAttributes pAttributes,
            /* out IMFSourceReader */ out IntPtr ppSourceReader);

#if ALLOW_UNTESTED_INTERFACES
        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Creates a new instance of the MFPlay player object.
        /// </summary>
        /// <param name="pwszURL">
        /// Null-terminated string that contains the URL of a media file to open. This parameter can be 
        /// <strong>NULL</strong>. If the parameter is <strong>NULL</strong>, <em>fStartPlayback</em> must be 
        /// <strong>FALSE</strong>. 
        /// <para/>
        /// If this parameter is <strong>NULL</strong>, you can open a URL later by calling 
        /// <see cref="MFPlayer.IMFPMediaPlayer.CreateMediaItemFromURL"/>. 
        /// </param>
        /// <param name="fStartPlayback">
        /// If <strong>TRUE</strong>, playback starts automatically. If <strong>FALSE</strong>, playback does
        /// not start until the application calls <c>IMFMediaPlayer::Play</c>. 
        /// <para/>
        /// If <em>pwszURL</em> is <strong>NULL</strong>, this parameter is ignored. 
        /// </param>
        /// <param name="creationOptions">
        /// Bitwise <strong>OR</strong> of zero of more flags from the <c>_MFP_CREATION_OPTIONS</c>
        /// enumeration. 
        /// </param>
        /// <param name="pCallback">
        /// Pointer to the <see cref="MFPlayer.IMFPMediaPlayerCallback"/> interface of a callback object,
        /// implemented by the application. Use this interface to get event notifications from the MFPlay
        /// player object. This parameter can be <strong>NULL</strong>. If the parameter is <strong>NULL
        /// </strong>, the application will not receive event notifications from the player object. 
        /// </param>
        /// <param name="hWnd">
        /// A handle to a window where the video will appear. For audio-only playback, this parameter can be 
        /// <strong>NULL</strong>. 
        /// <para/>
        /// The window specified by <em>hWnd</em> is used for the first selected video stream in the source. If
        /// the source has multiple video streams, you must call 
        /// <see cref="MFPlayer.IMFPMediaItem.SetStreamSink"/> to render any of the video streams after the
        /// first. 
        /// <para/>
        /// If <em>hWnd</em> is <strong>NULL</strong>, MFPlay will not display any video unless the application
        /// calls <see cref="MFPlayer.IMFPMediaItem.SetStreamSink"/> to specify a media sink for the video
        /// stream. 
        /// </param>
        /// <param name="ppMediaPlayer">
        /// Receives a pointer to the <see cref="MFPlayer.IMFPMediaPlayer"/> interface. The caller must release
        /// the interface. This parameter can be <strong>NULL</strong>. If this parameter is <strong>NULL
        /// </strong>, <em>fStartPlayback</em> must be <strong>TRUE</strong> and <em>pwszURL</em> cannot be 
        /// <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFPCreateMediaPlayer(
        ///   _In_   LPCWSTR pwszURL,
        ///   _In_   BOOL fStartPlayback,
        ///   _In_   MFP_CREATION_OPTIONS creationOptions,
        ///   _In_   IMFPMediaPlayerCallback *pCallback,
        ///   _In_   HWND hWnd,
        ///   _Out_  IMFPMediaPlayer **ppMediaPlayer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/80C668E2-5E93-4AF2-871C-646228E18717(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/80C668E2-5E93-4AF2-871C-646228E18717(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [Obsolete("Applications should use the Media Session for playback.")]
        [DllImport("mfplay.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFPCreateMediaPlayer(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszURL,
            [MarshalAs(UnmanagedType.Bool)] bool fStartPlayback,
            MFP_CREATION_OPTIONS creationOptions,
            IMFPMediaPlayerCallback pCallback,
            IntPtr hWnd,
            out IMFPMediaPlayer ppMediaPlayer);

        /// <summary>
        /// Creates the remote desktop plug-in object. Use this object if the application is running in a
        /// Terminal Services client session.
        /// </summary>
        /// <param name="ppPlugin">
        /// Receives a pointer to the <see cref="IMFRemoteDesktopPlugin"/> interface of the plug-in object. The
        /// caller must release the interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The function succeeded.</description></item>
        /// <item><term><strong>E_ACCESSDENIED</strong></term><description>Remote desktop connections are not allowed by the current session policy.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateRemoteDesktopPlugin(
        ///   IMFRemoteDesktopPlugin **ppPlugin
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C986C80B-B583-47BE-91E7-5881DB0018C2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C986C80B-B583-47BE-91E7-5881DB0018C2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateRemoteDesktopPlugin(
            out IMFRemoteDesktopPlugin ppPlugin
        );

        /// <summary>
        /// Creates a media buffer object that manages a Direct3D 9 surface. 
        /// </summary>
        /// <param name="riid">
        /// Identifies the type of Direct3D 9 surface. Currently this value must be <strong>
        /// IID_IDirect3DSurface9</strong>. 
        /// </param>
        /// <param name="punkSurface">
        /// A pointer to the <c>IUnknown</c> interface of the DirectX surface. 
        /// </param>
        /// <param name="fBottomUpWhenLinear">
        /// If <strong>TRUE</strong>, the buffer's <see cref="IMF2DBuffer.ContiguousCopyTo"/> method copies the
        /// buffer into a bottom-up format. The bottom-up format is compatible with GDI for uncompressed RGB
        /// images. If this parameter is <strong>FALSE</strong>, the <strong>ContiguousCopyTo</strong> method
        /// copies the buffer into a top-down format, which is compatible with DirectX. 
        /// <para/>
        /// For more information about top-down versus bottom-up images, see <c>Image Stride</c>. 
        /// </param>
        /// <param name="ppBuffer">
        /// Receives a pointer to the <see cref="IMFMediaBuffer"/> interface. The caller must release the
        /// buffer. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>Invalid argument.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateDXSurfaceBuffer(
        ///   _In_   REFIID riid,
        ///   _In_   IUnknown *punkSurface,
        ///   _In_   BOOL fBottomUpWhenLinear,
        ///   _Out_  IMFMediaBuffer **ppBuffer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D1EE158E-5D70-41A4-B746-2ECAEA2DB92C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D1EE158E-5D70-41A4-B746-2ECAEA2DB92C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("evr.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateDXSurfaceBuffer(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [In] [MarshalAs(UnmanagedType.IUnknown)] object punkSurface,
            [In] bool fBottomUpWhenLinear,
            out IMFMediaBuffer ppBuffer);

        // --------------------------------------------------

        /// <summary>
        /// Validates the size of a buffer for a video format block. 
        /// </summary>
        /// <param name="FormatType">The format type.</param>
        /// <param name="pBlock">The p block.</param>
        /// <param name="cbSize">The cb size.</param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The buffer that contains the format block is large enough. </description></item>
        /// <item><term><strong>MF_E_INVALIDMEDIATYPE</strong></term><description> The buffer that contains the format block is too small, or the format block is not valid. </description></item>
        /// <item><term><strong>MF_E_UNSUPPORTED_FORMAT</strong></term><description> This function does not support the specified format type. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFValidateMediaTypeSize(
        ///   _In_  GUID FormatType,
        ///   _In_  UINT8 *pBlock,
        ///   _In_  UINT32 cbSize
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/782B59CA-BFA8-4217-9B72-50A78937775A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/782B59CA-BFA8-4217-9B72-50A78937775A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFValidateMediaTypeSize(
            [In, MarshalAs(UnmanagedType.Struct)] Guid FormatType,
            IntPtr pBlock,
            [In] int cbSize
            );

        /// <summary>
        /// Initializes a media type from a DirectShow <strong>MPEG1VIDEOINFO</strong> structure. 
        /// </summary>
        /// <param name="pMFType">
        /// Pointer to the <see cref="IMFMediaType"/> interface of the media type to initialize. To create the
        /// uninitialized media type object, call <see cref="MFExtern.MFCreateMediaType"/>. 
        /// </param>
        /// <param name="pMP1VI">
        /// Pointer to a <strong>MPEG1VIDEOINFO</strong> structure that describes the media type. The caller
        /// must fill in the structure members before calling this function. 
        /// </param>
        /// <param name="cbBufSize">
        /// Size of the <strong>MPEG1VIDEOINFO</strong> structure, in bytes. 
        /// </param>
        /// <param name="pSubtype">
        /// Pointer to a subtype GUID. This parameter can be <strong>NULL</strong>. If the subtype GUID is
        /// specified, the function uses it to set the media subtype. Otherwise, the function attempts to
        /// deduce the subtype from the <strong>biCompression</strong> field contained in the <strong>
        /// MPEG1VIDEOINFO</strong> structure. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFInitMediaTypeFromMPEG1VideoInfo(
        ///   IMFMediaType *pMFType,
        ///   const MPEG1VIDEOINFO *pMP1VI,
        ///   UINT32 cbBufSize,
        ///   const GUID *pSubtype = NULL
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2506AE6E-A3BB-4D36-8C70-837A42CFB272(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2506AE6E-A3BB-4D36-8C70-837A42CFB272(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFInitMediaTypeFromMPEG1VideoInfo(
            [In] IMFMediaType pMFType,
            MPEG1VideoInfo pMP1VI,
            [In] int cbBufSize,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid pSubtype
            );

        /// <summary>
        /// Initializes a media type from a DirectShow <strong>MPEG2VIDEOINFO</strong> structure. 
        /// </summary>
        /// <param name="pMFType">
        /// Pointer to the <see cref="IMFMediaType"/> interface of the media type to initialize. To create the
        /// uninitialized media type object, call <see cref="MFExtern.MFCreateMediaType"/>. 
        /// </param>
        /// <param name="pMP2VI">
        /// Pointer to a <strong>MPEG2VIDEOINFO</strong> structure that describes the media type. The caller
        /// must fill in the structure members before calling this function. 
        /// </param>
        /// <param name="cbBufSize">
        /// Size of the <strong>MPEG2VIDEOINFO</strong> structure, in bytes. 
        /// </param>
        /// <param name="pSubtype">
        /// Pointer to a subtype GUID. This parameter can be <strong>NULL</strong>. If the subtype GUID is
        /// specified, the function uses it to set the media subtype. Otherwise, the function attempts to
        /// deduce the subtype from the <strong>biCompression</strong> field contained in the <strong>
        /// MPEG2VIDEOINFO</strong> structure. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFInitMediaTypeFromMPEG2VideoInfo(
        ///   IMFMediaType *pMFType,
        ///   const MPEG2VIDEOINFO *pMP2VI,
        ///   UINT32 cbBufSize,
        ///   const GUID *pSubtype = NULL
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/44AD976E-2B15-454C-9422-26FC960E03AA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/44AD976E-2B15-454C-9422-26FC960E03AA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFInitMediaTypeFromMPEG2VideoInfo(
            [In] IMFMediaType pMFType,
            Mpeg2VideoInfo pMP2VI,
            [In] int cbBufSize,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid pSubtype
            );

        /// <summary>
        /// Retrieves the image size, in bytes, for an uncompressed video format.
        /// </summary>
        /// <param name="guidSubtype">
        /// Media subtype for the video format. For a list of subtypes, see <c>Media Type GUIDs</c>. 
        /// </param>
        /// <param name="unWidth">
        /// Width of the image, in pixels.
        /// </param>
        /// <param name="unHeight">
        /// Height of the image, in pixels.
        /// </param>
        /// <param name="pcbImageSize">
        /// Receives the size of each frame, in bytes. If the format is compressed or is not recognized, the
        /// value is zero.
        /// </param>
        /// <returns>
        /// The function returns an HRESULT. Possible values include, but are not limited to, those in the
        /// following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCalculateImageSize(
        ///   _In_   REFGUID guidSubtype,
        ///   _In_   UINT32 unWidth,
        ///   _In_   UINT32 unHeight,
        ///   _Out_  UINT32 *pcbImageSize
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/039EE3CD-2221-4405-BA7F-233A93A0271B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/039EE3CD-2221-4405-BA7F-233A93A0271B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCalculateImageSize(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidSubtype,
            [In] int unWidth,
            [In] int unHeight,
            out int pcbImageSize
            );

        /// <summary>
        /// Calculates the frame rate, in frames per second, from the average duration of a video frame.
        /// </summary>
        /// <param name="unAverageTimePerFrame">
        /// The average duration of a video frame, in 100-nanosecond units.
        /// </param>
        /// <param name="punNumerator">
        /// Receives the numerator of the frame rate.
        /// </param>
        /// <param name="punDenominator">
        /// Receives the denominator of the frame rate.
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFAverageTimePerFrameToFrameRate(
        ///   _In_   UINT64 unAverageTimePerFrame,
        ///   _Out_  UINT32 *punNumerator,
        ///   _Out_  UINT32 *punDenominator
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9D2AB27F-80CB-4CD9-BD7A-8F56A810BB29(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9D2AB27F-80CB-4CD9-BD7A-8F56A810BB29(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFAverageTimePerFrameToFrameRate(
            [In] long unAverageTimePerFrame,
            out int punNumerator,
            out int punDenominator
            );

        /// <summary>
        /// Compares a full media type to a partial media type.
        /// </summary>
        /// <param name="pMFTypeFull">
        /// Pointer to the <see cref="IMFMediaType"/> interface of the full media type. 
        /// </param>
        /// <param name="pMFTypePartial">
        /// Pointer to the <see cref="IMFMediaType"/> interface of the partial media type. 
        /// </param>
        /// <returns>
        /// If the full media type is compatible with the partial media type, the function returns <strong>TRUE
        /// </strong>. Otherwise, the function returns <strong>FALSE</strong>. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// BOOL MFCompareFullToPartialMediaType(
        ///   IMFMediaType *pMFTypeFull,
        ///   IMFMediaType *pMFTypePartial
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5659CC69-46DC-4B08-96C4-E9EC787A310A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5659CC69-46DC-4B08-96C4-E9EC787A310A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCompareFullToPartialMediaType(
            [In] IMFMediaType pMFTypeFull,
            [In] IMFMediaType pMFTypePartial
            );

        /// <summary>
        /// Creates a media type that wraps another media type. 
        /// </summary>
        /// <param name="pOrig">
        /// A pointer to the <see cref="IMFMediaType"/> interface of the media type to wrap in a new media
        /// type. 
        /// </param>
        /// <param name="MajorType">
        /// A GUID that specifies the major type for the new media type. For a list of possible values, see 
        /// <c>Major Media Types</c>. 
        /// </param>
        /// <param name="SubType">
        /// A GUID that specifies the subtype for the new media type. For possible values, see:
        /// <para/>
        /// <para>* <c>Audio Subtypes</c></para><para>* <c>Video Subtypes</c></para>
        /// <para/>
        /// Applications can define custom subtype GUIDs.
        /// </param>
        /// <param name="ppWrap">
        /// Receives a pointer to the <see cref="IMFMediaType"/> interface of the new media type that wraps the
        /// original media type. The caller must release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFWrapMediaType(
        ///   IMFMediaType *pOrig,
        ///   REFGUID MajorType,
        ///   REFGUID SubType,
        ///   IMFMediaType **ppWrap
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A3DD74BC-1F1C-40B9-A43E-D45FF621248F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A3DD74BC-1F1C-40B9-A43E-D45FF621248F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFWrapMediaType(
            [In] IMFMediaType pOrig,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid MajorType,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid SubType,
            out IMFMediaType ppWrap
            );

        /// <summary>
        /// Creates a partial video media type with a specified subtype. 
        /// </summary>
        /// <param name="pAMSubtype">
        /// Pointer to a GUID that specifies the subtype. See <c>Video Subtype GUIDs</c>. 
        /// </param>
        /// <param name="ppIVideoMediaType">
        /// Receives a pointer to the <see cref="IMFVideoMediaType"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateVideoMediaTypeFromSubtype(
        ///   _In_   const GUID *pAMSubtype,
        ///   _Out_  IMFVideoMediaType **ppIVideoMediaType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3AE58096-FE11-4CC8-9887-2E13F56A958D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3AE58096-FE11-4CC8-9887-2E13F56A958D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("evr.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateVideoMediaTypeFromSubtype(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid pAMSubtype,
            out IMFVideoMediaType ppIVideoMediaType
            );

        /// <summary>
        /// Queries whether a FOURCC code or <strong>D3DFORMAT</strong> value is a YUV format. 
        /// </summary>
        /// <param name="Format">
        /// FOURCC code or <strong>D3DFORMAT</strong> value. 
        /// </param>
        /// <returns>
        /// The function returns one of the following values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>TRUE</strong></term><description>The value specifies a YUV format.</description></item>
        /// <item><term><strong>FALSE</strong></term><description>The value does not specify a recognized YUV format.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// BOOL MFIsFormatYUV(
        ///   _In_  DWORD Format
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DBF6ACD3-79C6-4EC2-A867-F2B2D8B41F53(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DBF6ACD3-79C6-4EC2-A867-F2B2D8B41F53(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("evr.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern bool MFIsFormatYUV(
            int Format
            );

        /// <summary>
        /// Retrieves the image size, in bytes, for an uncompressed video format.
        /// </summary>
        /// <param name="format">
        /// FOURCC code or <strong>D3DFORMAT</strong> value that specifies the video format. 
        /// </param>
        /// <param name="dwWidth">
        /// Width of the image, in pixels.
        /// </param>
        /// <param name="dwHeight">
        /// Height of the image, in pixels.
        /// </param>
        /// <param name="pdwPlaneSize">
        /// Receives the size of one frame, in bytes. If the format is compressed or is not recognized, this
        /// value is zero.
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The function succeeded. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFGetPlaneSize(
        ///   _In_   DWORD format,
        ///   _In_   DWORD dwWidth,
        ///   _In_   DWORD dwHeight,
        ///   _Out_  DWORD *pdwPlaneSize
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/53CE83F3-B06E-4C91-A3E2-6369963E7810(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/53CE83F3-B06E-4C91-A3E2-6369963E7810(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("evr.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFGetPlaneSize(
            int format,
            int dwWidth,
            int dwHeight,
            out int pdwPlaneSize
            );

        /// <summary>
        /// [This API is not supported and may be altered or unavailable in the future. Applications should
        /// avoid using the <see cref="MFVideoFormat"/> structure, and use media type attributes instead. For
        /// more information, see <c>Video Media Types</c>.] 
        /// <para/>
        /// Initializes an <see cref="MFVideoFormat"/> structure for a standard video format such as DVD,
        /// analog television, or ATSC digital television. 
        /// </summary>
        /// <param name="pVideoFormat">
        /// A pointer to an <see cref="MFVideoFormat"/> structure. The function fills in the structure members
        /// based on the video format specified in the type parameter. 
        /// </param>
        /// <param name="type">
        /// The video format, specified as a member of the <see cref="MFStandardVideoFormat"/> enumeration. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFInitVideoFormat(
        ///   _Out_  MFVIDEOFORMAT *pVideoFormat,
        ///   _In_   MFStandardVideoFormat type
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1CB47F95-CDB6-4998-9980-2F22E282DF11(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1CB47F95-CDB6-4998-9980-2F22E282DF11(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [Obsolete("Use media type attributes instead.")]
        [DllImport("evr.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFInitVideoFormat(
            [In] MFVideoFormat pVideoFormat,
            [In] MFStandardVideoFormat type
            );

        /// <summary>
        /// [This API is not supported and may be altered or unavailable in the future. Applications should
        /// avoid using the <see cref="MFVideoFormat"/> structure, and use media type attributes instead. For
        /// more information, see <c>Video Media Types</c>.] 
        /// <para/>
        /// Initializes an <see cref="MFVideoFormat"/> structure for an uncompressed RGB video format. 
        /// </summary>
        /// <param name="pVideoFormat">
        /// A pointer to an <see cref="MFVideoFormat"/> structure. The functions fills in the structure members
        /// with the format information. 
        /// </param>
        /// <param name="dwWidth">
        /// The width of the video, in pixels. 
        /// </param>
        /// <param name="dwHeight">
        /// The height of the video, in pixels. 
        /// </param>
        /// <param name="D3Dfmt">
        /// A <strong>D3DFORMAT</strong> value that specifies the RGB format. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFInitVideoFormat_RGB(
        ///   _In_  MFVIDEOFORMAT *pVideoFormat,
        ///   _In_  DWORD dwWidth,
        ///   _In_  DWORD dwHeight,
        ///   _In_  DWORD D3Dfmt
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4C437F26-6FE1-477D-9955-BC900215AA59(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4C437F26-6FE1-477D-9955-BC900215AA59(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [Obsolete("Use media type attributes instead.")]
        [DllImport("evr.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFInitVideoFormat_RGB(
            [In] MFVideoFormat pVideoFormat,
            [In] int dwWidth,
            [In] int dwHeight,
            [In] int D3Dfmt
            );

        /// <summary>
        /// [This API is not supported and may be altered or unavailable in the future. Applications should
        /// avoid using the <see cref="MFVideoFormat"/> structure, and use media type attributes instead. For
        /// more information, see <c>Extended Color Information</c>.] 
        /// <para/>
        /// Converts the extended color information from an <see cref="MFVideoFormat"/> to the equivalent
        /// DirectX Video Acceleration (DXVA) color information. 
        /// </summary>
        /// <param name="pdwToDXVA">
        /// Receives the DXVA extended color information. The bitfields in the <strong>DWORD</strong> are
        /// defined in the <c>DXVA2_ExtendedFormat</c> structure. 
        /// </param>
        /// <param name="pFromFormat">
        /// Pointer to an <see cref="MFVideoFormat"/> structure that describes the video format. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFConvertColorInfoToDXVA(
        ///   _Out_  DWORD *pdwToDXVA,
        ///   _In_   const MFVIDEOFORMAT *pFromFormat
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/52A3BE2B-F715-4E12-9F69-6A832153FF5E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/52A3BE2B-F715-4E12-9F69-6A832153FF5E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [Obsolete("Use media type attributes instead.")]
        [DllImport("evr.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFConvertColorInfoToDXVA(
            out int pdwToDXVA,
            MFVideoFormat pFromFormat
            );

        /// <summary>
        /// [This API is not supported and may be altered or unavailable in the future. Applications should
        /// avoid using the <see cref="MFVideoFormat"/> structure, and use media type attributes instead. For
        /// more information, see <c>Extended Color Information</c>.] 
        /// <para/>
        /// Sets the extended color information in a <see cref="MFVideoFormat"/> structure. 
        /// </summary>
        /// <param name="pToFormat">
        /// Pointer to an <see cref="MFVideoFormat"/> structure. The function fills in the structure members
        /// that correspond to the DXVA color information in the <em>dwFromDXVA</em> parameter. The function
        /// does not modify the other structure members. 
        /// </param>
        /// <param name="dwFromDXVA">
        /// <strong>DWORD</strong> that contains extended color information. The bitfields in the <strong>DWORD
        /// </strong> are defined in the <c>DXVA2_ExtendedFormat</c> structure. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFConvertColorInfoFromDXVA(
        ///   _Inout_  MFVIDEOFORMAT *pToFormat,
        ///   _In_     DWORD dwFromDXVA
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B16874CC-1EB3-43DD-BD4C-3EA77BE10BD2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B16874CC-1EB3-43DD-BD4C-3EA77BE10BD2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [Obsolete("Use media type attributes instead.")]
        [DllImport("evr.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFConvertColorInfoFromDXVA(
            MFVideoFormat pToFormat,
            int dwFromDXVA
            );

        /// <summary>
        /// Copies an image or image plane from one buffer to another. 
        /// </summary>
        /// <param name="pDest">
        /// Pointer to the start of the first row of pixels in the destination buffer. 
        /// </param>
        /// <param name="lDestStride">
        /// Stride of the destination buffer, in bytes. 
        /// </param>
        /// <param name="pSrc">
        /// Pointer to the start of the first row of pixels in the source image. 
        /// </param>
        /// <param name="lSrcStride">
        /// Stride of the source image, in bytes. 
        /// </param>
        /// <param name="dwWidthInBytes">
        /// Width of the image, in bytes. 
        /// </param>
        /// <param name="dwLines">
        /// Number of rows of pixels to copy. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCopyImage(
        ///   _In_  BYTE *pDest,
        ///   _In_  LONG lDestStride,
        ///   _In_  const BYTE *pSrc,
        ///   _In_  LONG lSrcStride,
        ///   _In_  DWORD dwWidthInBytes,
        ///   _In_  DWORD dwLines
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E6BC2777-D33C-4D44-84C6-E7B35D308D33(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E6BC2777-D33C-4D44-84C6-E7B35D308D33(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("evr.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCopyImage(
            IntPtr pDest,
            int lDestStride,
            IntPtr pSrc,
            int lSrcStride,
            int dwWidthInBytes,
            int dwLines
            );

        /// <summary>
        /// Converts an array of 16-bit floating-point numbers into an array of 32-bit floating-point numbers. 
        /// </summary>
        /// <param name="pDest">
        /// Pointer to an array of <strong>float</strong> values. The array must contain at least <em>dwCount
        /// </em> elements. 
        /// </param>
        /// <param name="pSrc">
        /// Pointer to an array of 16-bit floating-point values, typed as <strong>WORD</strong> values. The
        /// array must contain at least <em>dwCount</em> elements. 
        /// </param>
        /// <param name="dwCount">
        /// Number of elements in the <em>pSrc</em> array to convert. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFConvertFromFP16Array(
        ///   _In_  float *pDest,
        ///   _In_  const WORD *pSrc,
        ///   _In_  DWORD dwCount
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5CC11D32-8DCD-491D-B3DF-C0B061233038(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5CC11D32-8DCD-491D-B3DF-C0B061233038(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("evr.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFConvertFromFP16Array(
            float[] pDest,
            short[] pSrc,
            int dwCount
            );

        /// <summary>
        /// Converts an array of 32-bit floating-point numbers into an array of 16-bit floating-point numbers. 
        /// </summary>
        /// <param name="pDest">
        /// Pointer to an array of 16-bit floating-point values, typed as <strong>WORD</strong> values. The
        /// array must contain at least <em>dwCount</em> elements. 
        /// </param>
        /// <param name="pSrc">
        /// Pointer to an array of <strong>float</strong> values. The array must contain at least <em>dwCount
        /// </em> elements. 
        /// </param>
        /// <param name="dwCount">
        /// Number of elements in the <em>pSrc</em> array to convert. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFConvertToFP16Array(
        ///   _In_  WORD *pDest,
        ///   _In_  const float *pSrc,
        ///   _In_  DWORD dwCount
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B2149336-F1B2-4244-BF50-4E79638786E0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B2149336-F1B2-4244-BF50-4E79638786E0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("evr.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFConvertToFP16Array(
            short[] pDest,
            float[] pSrc,
            int dwCount
            );

        /// <summary>
        /// Creates a Media Foundation media type from another format representation.
        /// </summary>
        /// <param name="guidRepresentation">
        /// GUID that specifies which format representation to convert. The following value is defined.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>GUID</term><description>Description</description></listheader>
        /// <item><term>AM_MEDIA_TYPE_REPRESENTATION</term><description>Convert a DirectShow <strong>AM_MEDIA_TYPE</strong> structure. </description></item>
        /// </list>
        /// </param>
        /// <param name="pvRepresentation">
        /// Pointer to a buffer that contains the format representation to convert. The layout of the buffer
        /// depends on the value of <em>guidRepresentation</em>. 
        /// </param>
        /// <param name="ppIMediaType">
        /// Receives a pointer to the <see cref="IMFMediaType"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// <item><term><strong>MF_E_UNSUPPORTED_REPRESENTATION</strong></term><description>The GUID specified in <em>guidRepresentation</em> is not supported. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateMediaTypeFromRepresentation(
        ///   _In_   GUID guidRepresentation,
        ///   _In_   LPVOID pvRepresentation,
        ///   _Out_  IMFMediaType **ppIMediaType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5D85C47E-2E40-45F2-8F17-52F642652112(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5D85C47E-2E40-45F2-8F17-52F642652112(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateMediaTypeFromRepresentation(
            [MarshalAs(UnmanagedType.Struct)] Guid guidRepresentation,
            IntPtr pvRepresentation,
            out IMFMediaType ppIMediaType
            );

        /// <summary>
        /// Queries whether a media presentation requires the Protected Media Path (PMP).
        /// </summary>
        /// <param name="pPresentationDescriptor">
        /// Pointer to the <see cref="IMFPresentationDescriptor"/> interface of a presentation descriptor. The
        /// presentation descriptor is created by the media source, and describes the presentation. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>This presentation requires a protected environment.</description></item>
        /// <item><term><strong><strong>S_FALSE</strong></strong></term><description>This presentation does not require a protected environment.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFRequireProtectedEnvironment(
        ///   _In_  IMFPresentationDescriptor *pPresentationDescriptor
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5129D8C0-4049-4B90-ADE8-B4CD32277664(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5129D8C0-4049-4B90-ADE8-B4CD32277664(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFRequireProtectedEnvironment(
            IMFPresentationDescriptor pPresentationDescriptor
        );

        /// <summary>
        /// Serializes a presentation descriptor to a byte array.
        /// </summary>
        /// <param name="pPD">
        /// Pointer to the <see cref="IMFPresentationDescriptor"/> interface of the presentation descriptor to
        /// serialize. 
        /// </param>
        /// <param name="pcbData">
        /// Receives the size of the <em>ppbData</em> array, in bytes. 
        /// </param>
        /// <param name="ppbData">
        /// Receives a pointer to an array of bytes containing the serialized presentation descriptor. The
        /// caller must free the memory for the array by calling <c>CoTaskMemFree</c>. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFSerializePresentationDescriptor(
        ///   IMFPresentationDescriptor *pPD,
        ///   DWORD *pcbData,
        ///   BYTE **ppbData
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F39A0DC8-438E-4723-94E4-A194A0A460E3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F39A0DC8-438E-4723-94E4-A194A0A460E3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFSerializePresentationDescriptor(
            IMFPresentationDescriptor pPD,
            out int pcbData,
            IntPtr ppbData
        );

        /// <summary>
        /// Deserializes a presentation descriptor from a byte array.
        /// </summary>
        /// <param name="cbData">
        /// Size of the <em>pbData</em> array, in bytes. 
        /// </param>
        /// <param name="pbData">
        /// Pointer to an array of bytes that contains the serialized presentation descriptor.
        /// </param>
        /// <param name="ppPD">
        /// Receives a pointer to the <see cref="IMFPresentationDescriptor"/> interface of the presentation
        /// descriptor. The caller must release the interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFDeserializePresentationDescriptor(
        ///   DWORD cbData,
        ///   BYTE *pbData,
        ///   IMFPresentationDescriptor **ppPD
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4F567B86-BCE2-49FE-9D43-D1DFA57A86CB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4F567B86-BCE2-49FE-9D43-D1DFA57A86CB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFDeserializePresentationDescriptor(
            int cbData,
            IntPtr pbData,
            out IMFPresentationDescriptor ppPD
        );

        /// <summary>
        /// Shuts down a Media Foundation object and releases all resources associated with the object.
        /// <para/>
        /// This function is a helper function that wraps the <see cref="IMFShutdown.Shutdown"/> method. The
        /// function queries the object for the <see cref="IMFShutdown"/> interface and, if successful, calls 
        /// <strong>Shutdown</strong> on the object. 
        /// </summary>
        /// <param name="pUnk">
        /// Pointer to the <strong>IUnknown</strong> interface of the object. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The function succeeded. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFShutdownObject(
        ///   IUnknown *pUnk
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A7DC3D4A-F21E-4AF8-BEE0-2D5F2CF28587(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A7DC3D4A-F21E-4AF8-BEE0-2D5F2CF28587(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFShutdownObject(
            object pUnk
        );

        /// <summary>
        /// Creates an activation object for the sample grabber media sink.
        /// </summary>
        /// <param name="pIMFMediaType">
        /// Pointer to the <see cref="IMFMediaType"/> interface, defining the media type for the sample
        /// grabber's input stream. 
        /// </param>
        /// <param name="pIMFSampleGrabberSinkCallback">
        /// Pointer to the <see cref="IMFSampleGrabberSinkCallback"/> interface of a callback object. The
        /// caller must implement this interface. 
        /// </param>
        /// <param name="ppIActivate">
        /// Receives a pointer to the <see cref="IMFActivate"/> interface. Use this interface to complete the
        /// creation of the sample grabber. The caller must release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateSampleGrabberSinkActivate(
        ///   IMFMediaType *pIMFMediaType,
        ///   IMFSampleGrabberSinkCallback *pIMFSampleGrabberSinkCallback,
        ///   IMFActivate **ppIActivate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AC8E415E-5DF8-4FDB-ADF6-C3C717C3D625(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AC8E415E-5DF8-4FDB-ADF6-C3C717C3D625(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateSampleGrabberSinkActivate(
            IMFMediaType pIMFMediaType,
            IMFSampleGrabberSinkCallback pIMFSampleGrabberSinkCallback,
            out IMFActivate ppIActivate
        );

        /// <summary>
        /// Creates a default proxy locator.
        /// </summary>
        /// <param name="pszProtocol">
        /// The name of the protocol.
        /// <para/>
        /// <strong>Note</strong> In this release of Media Foundation, the default proxy locator does not
        /// support RTSP. 
        /// </param>
        /// <param name="pProxyConfig">
        /// Pointer to the <strong>IPropertyStore</strong> interface of a property store that contains the
        /// proxy configuration in the <see cref="MFProperties.MFNETSOURCE_PROXYSETTINGS"/> property. 
        /// </param>
        /// <param name="ppProxyLocator">
        /// Receives a pointer to the <see cref="IMFNetProxyLocator"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The function succeeded. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateProxyLocator(
        ///   _In_   LPCWSTR pszProtocol,
        ///   _In_   IPropertyStore *pProxyConfig,
        ///   _Out_  IMFNetProxyLocator **ppProxyLocator
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9AD707DF-533A-407B-A611-49BFB019AFFC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9AD707DF-533A-407B-A611-49BFB019AFFC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", CharSet = CharSet.Unicode, ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateProxyLocator(
            [MarshalAs(UnmanagedType.LPWStr)] string pszProtocol,
            IPropertyStore pProxyConfig,
            out IMFNetProxyLocator ppProxyLocator
        );

        /// <summary>
        /// Creates the scheme handler for the network source.
        /// </summary>
        /// <param name="riid">
        /// Interface identifier (IID) of the interface to retrieve.
        /// </param>
        /// <param name="ppvHandler">
        /// Receives a pointer to the requested interface. The caller must release the interface. The scheme
        /// handler exposes the <see cref="IMFSchemeHandler"/> interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateNetSchemePlugin(
        ///   _In_   REFIID riid,
        ///   _Out_  LPVOID *ppvHandler
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F08DE332-2B05-4FEE-BE45-D4928F5F4EF2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F08DE332-2B05-4FEE-BE45-D4928F5F4EF2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateNetSchemePlugin(
            [MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] object ppvHandler
        );

        /// <summary>
        /// Creates an ASF profile object from a presentation descriptor.
        /// </summary>
        /// <param name="pIPD">
        /// Pointer to the <see cref="IMFPresentationDescriptor"/> interface of the presentation descriptor
        /// that contains the profile information. 
        /// </param>
        /// <param name="ppIProfile">
        /// Receives a pointer to the <see cref="IMFASFProfile"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateASFProfileFromPresentationDescriptor(
        ///   IMFPresentationDescriptor *pIPD,
        ///   IMFASFProfile **ppIProfile
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1163D958-FBEA-48F3-9AC3-1595C0CC2D32(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1163D958-FBEA-48F3-9AC3-1595C0CC2D32(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateASFProfileFromPresentationDescriptor(
            [In] IMFPresentationDescriptor pIPD,
            out IMFASFProfile ppIProfile);

        /// <summary>
        /// Creates a byte stream to access the index in an ASF stream.
        /// </summary>
        /// <param name="pIContentByteStream">
        /// Pointer to the <see cref="IMFByteStream"/> interface of a byte stream that contains the ASF stream.
        /// </param>
        /// <param name="cbIndexStartOffset">
        /// Byte offset of the index within the ASF stream. To get this value, call 
        /// <see cref="IMFASFIndexer.GetIndexPosition"/>. 
        /// </param>
        /// <param name="pIIndexByteStream">
        /// Receives a pointer to the <see cref="IMFByteStream"/> interface. Use this interface to read from
        /// the index or write to the index. The caller must release the interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table: 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The call succeeded.</description></item>
        /// <item><term><strong>MF_E_UNEXPECTED</strong></term><description>The offset specified in <em>cbIndexStartOffset</em> is invalid. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateASFIndexerByteStream(
        ///   _In_   IMFByteStream *pIContentByteStream,
        ///   _In_   QWORD cbIndexStartOffset,
        ///   _Out_  IMFByteStream **pIIndexByteStream
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EDCCE9D4-9296-4B39-8E58-58AE602C250F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EDCCE9D4-9296-4B39-8E58-58AE602C250F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateASFIndexerByteStream(
            [In] IMFByteStream pIContentByteStream,
            [In] long cbIndexStartOffset,
            out IMFByteStream pIIndexByteStream);

        /// <summary>
        /// Creates the ASF stream selector.
        /// </summary>
        /// <param name="pIASFProfile">
        /// Pointer to the <see cref="IMFASFProfile"/> interface. 
        /// </param>
        /// <param name="ppSelector">
        /// Receives a pointer to the <see cref="IMFASFStreamSelector"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The function succeeded. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateASFStreamSelector(
        ///   IMFASFProfile *pIASFProfile,
        ///   IMFASFStreamSelector **ppSelector
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/71B1AF5B-F127-463F-9720-72E789BB2CD1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/71B1AF5B-F127-463F-9720-72E789BB2CD1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateASFStreamSelector(
            [In] IMFASFProfile pIASFProfile,
            out IMFASFStreamSelector ppSelector);

        /// <summary>
        /// Creates the ASF media sink.
        /// </summary>
        /// <param name="pIByteStream">
        /// Pointer to a byte stream that will be used to write the ASF stream.
        /// </param>
        /// <param name="ppIMediaSink">
        /// Receives a pointer to the <see cref="IMFMediaSink"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateASFMediaSink(
        ///   IMFByteStream *pIByteStream,
        ///   IMFMediaSink **ppIMediaSink
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D800AC91-F6CC-4F57-9080-4BBAFB42D7ED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D800AC91-F6CC-4F57-9080-4BBAFB42D7ED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateASFMediaSink(
            IMFByteStream pIByteStream,
            out IMFMediaSink ppIMediaSink
            );

        /// <summary>
        /// Creates an activation object that can be used to create the ASF media sink.
        /// </summary>
        /// <param name="pwszFileName">
        /// Null-terminated wide-character string that contains the output file name.
        /// </param>
        /// <param name="pContentInfo">
        /// A pointer to the <see cref="IMFASFContentInfo"/> interface of an initialized 
        /// <c>ASF Header Object</c> object. Use this interface to configure the ASF media sink. 
        /// </param>
        /// <param name="ppIActivate">
        /// Receives a pointer to the <see cref="IMFActivate"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateASFMediaSinkActivate(
        ///   LPCWSTR pwszFileName,
        ///   IMFASFContentInfo *pContentInfo,
        ///   IMFActivate **ppIActivate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/513D0A33-1504-4B88-9629-9E3E0DDE3617(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/513D0A33-1504-4B88-9629-9E3E0DDE3617(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", CharSet = CharSet.Unicode, ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateASFMediaSinkActivate(
            [MarshalAs(UnmanagedType.LPWStr)] string pwszFileName,
            IMFASFContentInfo pContentInfo,
            out IMFActivate ppIActivate
            );

        /// <summary>
        /// Creates an activation object that can be used to create a Windows Media Video (WMV) encoder. 
        /// </summary>
        /// <param name="pMediaType">
        /// A pointer to the <see cref="IMFMediaType"/> interface. This parameter specifies the encoded output
        /// format. 
        /// </param>
        /// <param name="pEncodingConfigurationProperties">
        /// A pointer to the <strong>IPropertyStore</strong> interface of a property store that contains
        /// encoding parameters. Encoding parameters for the WMV encoder are defined in the header file
        /// wmcodecdsp.h. If you have an ASF ContentInfo object that contains an ASF profile object with all
        /// the streams for the output file, you can get the property store by calling 
        /// <see cref="IMFASFContentInfo.GetEncodingConfigurationPropertyStore"/>. 
        /// </param>
        /// <param name="ppActivate">
        /// Receives a pointer to the <see cref="IMFActivate"/> interface. Use this interface to create the
        /// encoder. The caller must release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateWMVEncoderActivate(
        ///   IMFMediaType *pMediaType,
        ///   IPropertyStore *pEncodingConfigurationProperties,
        ///   IMFActivate **ppActivate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F818DBA1-E28F-4FD4-813D-33F638D979D7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F818DBA1-E28F-4FD4-813D-33F638D979D7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateWMVEncoderActivate(
            IMFMediaType pMediaType,
            IPropertyStore pEncodingConfigurationProperties,
            out IMFActivate ppActivate
            );

        /// <summary>
        /// Creates an activation object that can be used to create a Windows Media Audio (WMA) encoder. 
        /// </summary>
        /// <param name="pMediaType">
        /// A pointer to the <see cref="IMFMediaType"/> interface. This parameter specifies the encoded output
        /// format. 
        /// </param>
        /// <param name="pEncodingConfigurationProperties">
        /// A pointer to the <strong>IPropertyStore</strong> interface of a property store that contains
        /// encoding parameters. Encoding parameters for the WMV encoder are defined in the header file
        /// wmcodecdsp.h. If you have an ASF ContentInfo object that contains an ASF profile object with all
        /// the streams for the output file, you can get the property store by calling 
        /// <see cref="IMFASFContentInfo.GetEncodingConfigurationPropertyStore"/>. 
        /// </param>
        /// <param name="ppActivate">
        /// Receives a pointer to the <see cref="IMFActivate"/> interface. Use this interface to create the
        /// encoder. The caller must release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateWMAEncoderActivate(
        ///   IMFMediaType *pMediaType,
        ///   IPropertyStore *pEncodingConfigurationProperties,
        ///   IMFActivate **ppActivate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B322A6A2-EDF6-428E-8477-2FCD08E70AA2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B322A6A2-EDF6-428E-8477-2FCD08E70AA2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateWMAEncoderActivate(
            IMFMediaType pMediaType,
            IPropertyStore pEncodingConfigurationProperties,
            out IMFActivate ppActivate
            );

        /// <summary>
        /// Creates a presentation descriptor from an ASF profile object.
        /// </summary>
        /// <param name="pIProfile">
        /// Pointer to the <see cref="IMFASFProfile"/> interface of the ASF profile object. 
        /// </param>
        /// <param name="ppIPD">
        /// Receives a pointer to the <see cref="IMFPresentationDescriptor"/> interface. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The function succeeded. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreatePresentationDescriptorFromASFProfile(
        ///   IMFASFProfile *pIProfile,
        ///   IMFPresentationDescriptor **ppIPD
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E36AC685-4EBE-4FC6-A17A-F36B9D667ADD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E36AC685-4EBE-4FC6-A17A-F36B9D667ADD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreatePresentationDescriptorFromASFProfile(
            [In] IMFASFProfile pIProfile,
            out IMFPresentationDescriptor ppIPD);

        /// <summary>
        /// Creates the default video presenter for the enhanced video renderer (EVR).
        /// </summary>
        /// <param name="pOwner">
        /// Pointer to the owner of the object. If the object is aggregated, pass a pointer to the aggregating
        /// object's <strong>IUnknown</strong> interface. Otherwise, set this parameter to <strong>NULL
        /// </strong>. 
        /// </param>
        /// <param name="riidDevice">
        /// Interface identifier (IID) of the video device interface that will be used for processing the
        /// video. Currently the only supported value is IID_IDirect3DDevice9.
        /// </param>
        /// <param name="riid">
        /// IID of the requested interface on the video presenter. The video presenter exposes the 
        /// <see cref="EVR.IMFVideoPresenter"/> interface. 
        /// </param>
        /// <param name="ppVideoPresenter">
        /// Receives a pointer to the requested interface on the video presenter. The caller must release the
        /// interface.
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateVideoPresenter(
        ///   _In_   IUnknown *pOwner,
        ///   _In_   REFIID riidDevice,
        ///   _In_   REFIID riid,
        ///   _Out_  void **ppvVideoPresenter
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/04A1CE0D-F1ED-4B8A-827C-600297660442(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/04A1CE0D-F1ED-4B8A-827C-600297660442(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("evr.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateVideoPresenter(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pOwner,
            [MarshalAs(UnmanagedType.LPStruct)] Guid riidDevice,
            [MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            out IntPtr ppVideoPresenter
            );

        /// <summary>
        /// Creates the default video mixer for the enhanced video renderer (EVR).
        /// </summary>
        /// <param name="pOwner">
        /// Pointer to the owner of this object. If the object is aggregated, pass a pointer to the aggregating
        /// object's <strong>IUnknown</strong> interface. Otherwise, set this parameter to <strong>NULL
        /// </strong>. 
        /// </param>
        /// <param name="riidDevice">
        /// Interface identifier (IID) of the video device interface that will be used for processing the
        /// video. Currently the only supported value is IID_IDirect3DDevice9.
        /// </param>
        /// <param name="riid">
        /// IID of the requested interface on the video mixer. The video mixer exposes the 
        /// <see cref="Transform.IMFTransform"/> interface. 
        /// </param>
        /// <param name="ppVideoMixer">
        /// Receives a pointer to the requested interface. The caller must release the interface.
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateVideoMixer(
        ///   IUnknown *pOwner,
        ///   REFIID riidDevice,
        ///   REFIID riid,
        ///   void **ppVideoMixer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FD817E1B-6F11-4CDC-AA21-E4ECDA16BF1E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FD817E1B-6F11-4CDC-AA21-E4ECDA16BF1E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("evr.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateVideoMixer(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pOwner,
            [MarshalAs(UnmanagedType.LPStruct)] Guid riidDevice,
            [MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoMixer
            );

        /// <summary>
        /// Creates the default video mixer and video presenter for the enhanced video renderer (EVR).
        /// </summary>
        /// <param name="pMixerOwner">
        /// Pointer to the owner of the video mixer. If the mixer is aggregated, pass a pointer to the
        /// aggregating object's <strong>IUnknown</strong> interface. Otherwise, set this parameter to <strong>
        /// NULL</strong>. 
        /// </param>
        /// <param name="pPresenterOwner">
        /// Pointer to the owner of the video presenter. If the presenter is aggregated, pass a pointer to the
        /// aggregating object's <strong>IUnknown</strong> interface. Otherwise, set this parameter to <strong>
        /// NULL</strong>. 
        /// </param>
        /// <param name="riidMixer">
        /// Interface identifier (IID) of the requested interface on the video mixer. The video mixer exposes
        /// the <see cref="Transform.IMFTransform"/> interface. 
        /// </param>
        /// <param name="ppvVideoMixer">
        /// Receives a pointer to the requested interface on the video mixer. The caller must release the
        /// interface.
        /// </param>
        /// <param name="riidPresenter">
        /// IID of the requested interface on the video presenter. The video presenter exposes the 
        /// <see cref="EVR.IMFVideoPresenter"/> interface. 
        /// </param>
        /// <param name="ppvVideoPresenter">
        /// Receives a pointer to the requested interface on the video presenter. The caller must release the
        /// interface.
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateVideoMixerAndPresenter(
        ///   _In_   IUnknown *pMixerOwner,
        ///   _In_   IUnknown *pPresenterOwner,
        ///   _In_   REFIID riidMixer,
        ///   _Out_  void **ppvVideoMixer,
        ///   _In_   REFIID riidPresenter,
        ///   _Out_  void **ppvVideoPresenter
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1777027A-85BB-47D2-BAF8-6F420282B01A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1777027A-85BB-47D2-BAF8-6F420282B01A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("evr.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateVideoMixerAndPresenter(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pMixerOwner,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pPresenterOwner,
            [MarshalAs(UnmanagedType.LPStruct)] Guid riidMixer,
            out IntPtr ppvVideoMixer,
            [MarshalAs(UnmanagedType.LPStruct)] Guid riidPresenter,
            out IntPtr ppvVideoPresenter
            );

        /// <summary>
        /// Creates an activation object for the ASF streaming sink.
        /// <para/>
        /// The ASF streaming sink enables an application to write streaming Advanced Systems Format (ASF)
        /// packets to an HTTP byte stream. 
        /// </summary>
        /// <param name="pIByteStream">
        /// A pointer to a byte stream object in which the ASF media sink writes the streamed content.
        /// </param>
        /// <param name="ppIMediaSink">
        /// Receives a pointer to the <see cref="IMFMediaSink"/> interface of the ASF streaming-media sink
        /// object. To create the media sink, the application must call 
        /// <see cref="IMFActivate.ActivateObject"/> on the received pointer. The caller must release the
        /// interface pointer. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateASFStreamingMediaSink(
        ///   IMFByteStream *pIByteStream,
        ///   IMFMediaSink **ppIMediaSink
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BFA34529-E1F9-462B-9C99-B65CD526D364(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BFA34529-E1F9-462B-9C99-B65CD526D364(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateASFStreamingMediaSink(
            IMFByteStream pIByteStream,
            out IMFMediaSink ppIMediaSink
        );

        /// <summary>
        /// Creates an activation object for the ASF streaming sink.
        /// <para/>
        /// The ASF streaming sink enables an application to write streaming Advanced Systems Format (ASF)
        /// packets to an HTTP byte stream. The activation object can be used to create the ASF streaming sink
        /// in another process.
        /// </summary>
        /// <param name="pByteStreamActivate">
        /// A pointer to the <see cref="IMFActivate"/> interface of an activation object. The caller implements
        /// this interface. The <see cref="IMFActivate.ActivateObject"/> method of the activation object must
        /// create a byte-stream object. The byte stream exposes the <see cref="IMFByteStream"/> interface. The
        /// ASF streaming sink will write data to this byte stream. 
        /// </param>
        /// <param name="pContentInfo">
        /// A pointer to an <c>ASF ContentInfo Object</c> that contains the properties that describe the ASF
        /// content. These settings can contain stream settings, encoding properties, and metadata. For more
        /// information about these properties, see <c>Setting Properties in the ContentInfo Object</c>. 
        /// </param>
        /// <param name="ppIActivate">
        /// Receives a pointer to the <see cref="IMFActivate"/> interface of the activation object that is used
        /// to create the ASF streaming-media sink. To create the media sink, the application must call 
        /// <see cref="IMFActivate.ActivateObject"/> by using the received pointer. The <strong>ActivateObject
        /// </strong> method also calls <strong>IMFActivate::Activate</strong> on the byte stream activate
        /// object specified by <em>pByteStreamActivate</em>, to create it so that the media sink can write
        /// streamed content in the byte stream. The caller must release the <strong>IMFActivate</strong>
        /// interface pointer of the media sink activation object received in <em>ppIActivate</em>. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateASFStreamingMediaSinkActivate(
        ///   IMFActivate *pByteStreamActivate,
        ///   IMFASFContentInfo *pContentInfo,
        ///   IMFActivate **ppIActivate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FFCAB5EE-400A-424F-AB98-3C9E36EF40CE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FFCAB5EE-400A-424F-AB98-3C9E36EF40CE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateASFStreamingMediaSinkActivate(
            IMFActivate pByteStreamActivate,
            IMFASFContentInfo pContentInfo,
            out IMFActivate ppIActivate
        );

        /// <summary>
        /// Creates a generic activation object for Media Foundation transforms (MFTs).
        /// </summary>
        /// <param name="ppActivate">
        /// Receives a pointer to the <see cref="IMFActivate"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateTransformActivate(
        ///   _Out_  IMFActivate **ppActivate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/845C7114-756B-4D0F-A92E-9C6E2EBA7C94(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/845C7114-756B-4D0F-A92E-9C6E2EBA7C94(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateTransformActivate(
            out IMFActivate ppActivate
        );

        /// <summary>
        /// Creates a media source for a hardware capture device.
        /// </summary>
        /// <param name="pAttributes">
        /// Pointer to the <see cref="IMFAttributes"/> interface of an attribute store, which is used to select
        /// the device. See Remarks. 
        /// </param>
        /// <param name="ppSource">
        /// Receives a pointer to the media source's <see cref="IMFMediaSource"/> interface. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateDeviceSource(
        ///   _In_   IMFAttributes *pAttributes,
        ///   _Out_  IMFMediaSource **ppSource
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9F80B604-1CC2-4D0D-B94E-A2B9DAB1FDDE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9F80B604-1CC2-4D0D-B94E-A2B9DAB1FDDE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateDeviceSource(
            IMFAttributes pAttributes,
            out IMFMediaSource ppSource
        );

        /// <summary>
        /// Creates an activation object that represents a hardware capture device.
        /// </summary>
        /// <param name="pAttributes">
        /// Pointer to the <see cref="IMFAttributes"/> interface of an attribute store, which is used to select
        /// the device. See Remarks. 
        /// </param>
        /// <param name="ppActivate">
        /// Receives a pointer to the <see cref="IMFActivate"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>System.Int32.</returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// STDAPI MFCreateDeviceSourceActivate(
        ///   _In_   IMFAttributes *pAttributes,
        ///   _Out_  IMFActivate **ppActivate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C52CB35A-8F5B-479E-9C08-3185C9A561F2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C52CB35A-8F5B-479E-9C08-3185C9A561F2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateDeviceSourceActivate(
            IMFAttributes pAttributes,
            out IMFActivate ppActivate
        );

        /// <summary>
        /// Creates an instance of the sample copier transform.
        /// </summary>
        /// <param name="ppCopierMFT">
        /// Receives a pointer to the <see cref="Transform.IMFTransform"/> interface. The caller must release
        /// the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateSampleCopierMFT(
        ///   _Out_  IMFTransform **ppCopierMFT
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4270C45E-4F20-4FCD-AD60-B205E334F692(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4270C45E-4F20-4FCD-AD60-B205E334F692(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateSampleCopierMFT(out IMFTransform ppCopierMFT);

#endif

        /// <summary>
        /// Creates an empty transcode profile object.
        /// <para/>
        /// The transcode profile stores configuration settings for the output file. These configuration
        /// settings are specified by the caller, and include audio and video stream properties, encoder
        /// settings, and container settings. To set these properties, the caller must call the appropriate
        /// <see cref="IMFTranscodeProfile"/> methods.
        /// <para/>
        /// The configured transcode profile is passed to the <see cref="MFExtern.MFCreateTranscodeTopology"/>
        /// function. The underlying topology builder uses these settings to build the transcode topology.
        /// </summary>
        /// <param name="ppTranscodeProfile">
        /// Receives a pointer to the <see cref="IMFTranscodeProfile"/> interface of the transcode profile
        /// object. Caller must release the interface.
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateTranscodeProfile(
        ///   _Out_  IMFTranscodeProfile **ppTranscodeProfile
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/2A482C6F-6E20-419A-A7EB-085C41CC8186(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2A482C6F-6E20-419A-A7EB-085C41CC8186(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateTranscodeProfile(
            /* out IMFTranscodeProfile ppTranscodeProfile */ out IntPtr ppTranscodeProfile);

        /// <summary>
        /// Creates a partial transcode topology.
        /// <para/>
        /// The underlying topology builder creates a partial topology by connecting the required pipeline
        /// objects: source, encoder, and sink. The encoder and the sink are configured according to the
        /// settings specified by the caller in the transcode profile.
        /// <para/>
        /// To create the transcode profile object, call the <see cref="MFExtern.MFCreateTranscodeProfile"/>
        /// function and set the required attributes by calling the appropriate the
        /// <see cref="IMFTranscodeProfile"/> methods.
        /// <para/>
        /// The configured transcode profile is passed to the <strong>MFCreateTranscodeTopology</strong>
        /// function, which creates the transcode topology with the appropriate settings. The caller can then
        /// set this topology on the Media Session and start the session to begin the encoding process. When
        /// the Media Session ends, the transcoded file is generated.
        /// </summary>
        /// <param name="pSrc">
        /// A pointer to a media source that encapsulates the source file to be transcoded. The media source
        /// object exposes the <see cref="IMFMediaSource"/> interface and can be created by using the source
        /// resolver. For more information, see <c>Using the Source Resolver</c>.
        /// </param>
        /// <param name="pwszOutputFilePath">
        /// A pointer to a null-terminated string that contains the name and path of the output file to be
        /// generated.
        /// </param>
        /// <param name="pProfile">
        /// A pointer to the transcode profile that contains the configuration settings for the audio stream,
        /// the video stream, and the container to which the file is written. The transcode profile object
        /// exposes the <see cref="IMFTranscodeProfile"/> interface and must be created by calling the
        /// <see cref="MFExtern.MFCreateTranscodeProfile"/> function. After the object has been created the
        /// caller must provide the configuration settings by calling appropriate the <strong>
        /// IMFTranscodeProfile</strong> methods.
        /// </param>
        /// <param name="ppTranscodeTopo">
        /// Receives a pointer to the <see cref="IMFTopology"/> interface of the transcode topology object. The
        /// caller must release the interface.
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function call succeeded, and <em>ppTranscodeTopo</em> receives a pointer to the transcode topology. </description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description><em>pwszOutputFilePath</em> contains invalid characters. </description></item>
        /// <item><term><strong>MF_E_MEDIA_SOURCE_NO_STREAMS_SELECTED</strong></term><description>No streams are selected in the media source.</description></item>
        /// <item><term><strong>MF_E_TRANSCODE_NO_CONTAINERTYPE</strong></term><description>The profile does not contain the <see cref="MFAttributesClsid.MF_TRANSCODE_CONTAINERTYPE"/> attribute. </description></item>
        /// <item><term><strong>MF_E_TRANSCODE_NO_MATCHING_ENCODER</strong></term><description>For one or more streams, cannot find an encoder that accepts the media type given in the profile.</description></item>
        /// <item><term><strong>MF_E_TRANSCODE_PROFILE_NO_MATCHING_STREAMS</strong></term><description>The profile does not specify a media type for any of the selected streams on the media source.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// STDAPI MFCreateTranscodeTopology(
        ///   _In_   IMFMediaSource *pSrc,
        ///   _In_   LPCWSTR pwszOutputFilePath,
        ///   _In_   IMFTranscodeProfile *pProfile,
        ///   _Out_  IMFTopology **ppTranscodeTopo
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/EF3F19BF-1DB9-459D-9617-D6CCA9D6ABA7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EF3F19BF-1DB9-459D-9617-D6CCA9D6ABA7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateTranscodeTopology(
            IMFMediaSource pSrc,
            [MarshalAs(UnmanagedType.LPWStr)] string pwszOutputFilePath,
            IMFTranscodeProfile pProfile,
            /* out IMFTopology ppTranscodeTopo */ out IntPtr ppTranscodeTopo);

#if ALLOW_UNTESTED_INTERFACES

        /// <summary>
        /// Gets a list of output formats from an audio encoder.
        /// </summary>
        /// <param name="guidSubType">
        /// Specifies the subtype of the output media. The encoder uses this value as a filter when it is
        /// enumerating the available output types. For information about the audio subtypes, see 
        /// <c>Audio Subtype GUIDs</c>. 
        /// </param>
        /// <param name="dwMFTFlags">
        /// Bitwise <strong>OR</strong> of zero or more flags from the <c>_MFT_ENUM_FLAG</c> enumeration. 
        /// </param>
        /// <param name="pCodecConfig">
        /// A pointer to the <see cref="IMFAttributes"/> interface of an attribute store. The attribute store
        /// specifies the encoder configuration settings. This parameter can be <strong>NULL</strong>. The
        /// attribute store can hold any of the following attributes. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong><see cref="MFAttributesClsid.MFT_FIELDOFUSE_UNLOCK_Attribute"/></strong></term><description>Set this attribute to unlock an encoder that has field-of-use descriptions.</description></item>
        /// <item><term><strong><see cref="MFAttributesClsid.MF_TRANSCODE_ENCODINGPROFILE"/></strong></term><description>Specifies a device conformance profile for a Windows Media encoder.</description></item>
        /// <item><term><strong><see cref="MFAttributesClsid.MF_TRANSCODE_QUALITYVSSPEED"/></strong></term><description>Sets the tradeoff between encoding quality and encoding speed.</description></item>
        /// </list>
        /// </param>
        /// <param name="ppAvailableTypes">
        /// Receives a pointer to the <see cref="IMFCollection"/> interface of a collection object that
        /// contains a list of preferred audio media types. The collection contains <see cref="IMFMediaType"/>
        /// pointers. The caller must release the interface pointer. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function call succeeded. </description></item>
        /// <item><term><strong>MF_E_TRANSCODE_NO_MATCHING_ENCODER</strong></term><description>Failed to find an encoder that matches the specified configuration settings.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFTranscodeGetAudioOutputAvailableTypes(
        ///   _In_   REFGUID guidSubType,
        ///   _In_   DWORD dwMFTFlags,
        ///   _In_   IMFAttributes *pCodecConfig,
        ///   _Out_  IMFCollection **ppAvailableTypes
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8750EACB-7E6F-4C17-987B-F4BAA4EEA847(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8750EACB-7E6F-4C17-987B-F4BAA4EEA847(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFTranscodeGetAudioOutputAvailableTypes(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidSubType,
            int dwMFTFlags,
            IMFAttributes pCodecConfig,
            out IMFCollection ppAvailableTypes
        );

        /// <summary>
        /// Creates the transcode sink activation object.
        /// <para/>
        /// The transcode sink activation object can be used to create any of the following file sinks:
        /// <para/>
        /// The transcode sink activation object exposes the <see cref="IMFTranscodeSinkInfoProvider"/>
        /// interface. 
        /// </summary>
        /// <param name="ppActivate">
        /// Receives a pointer to the <see cref="IMFActivate"/> interface. This interface is used to create the
        /// file sink instance from the activation object. Before doing so, query the returned pointer for the 
        /// <see cref="IMFTranscodeSinkInfoProvider"/> interface and use that interface to initialize the
        /// object. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateTranscodeSinkActivate(
        ///   _Out_   **ppActivate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CC9C604D-7F5A-4AFB-A2DF-B270EF883E68(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CC9C604D-7F5A-4AFB-A2DF-B270EF883E68(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateTranscodeSinkActivate(
            out IMFActivate ppActivate
        );

        /// <summary>
        /// Creates a Microsoft Media Foundation byte stream that wraps an <strong>IStream</strong> pointer. 
        /// </summary>
        /// <param name="pStream">
        /// A pointer to the <strong>IStream</strong> interface. 
        /// </param>
        /// <param name="ppByteStream">
        /// Receives a pointer to the <see cref="IMFByteStream"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// Returns an <strong>HRESULT</strong> value. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateMFByteStreamOnStream(
        ///   _In_   IStream *pStream,
        ///   _Out_  IMFByteStream **ppByteStream
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5FFD370A-CCC5-4229-B214-E07847287415(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5FFD370A-CCC5-4229-B214-E07847287415(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateMFByteStreamOnStream(
            IStream pStream,
            out IMFByteStream ppByteStream
        );

        /// <summary>
        /// Creates a media source that aggregates a collection of media sources. 
        /// </summary>
        /// <param name="pSourceCollection">
        /// A pointer to the <see cref="IMFCollection"/> interface of the collection object that contains a
        /// list of media sources. 
        /// </param>
        /// <param name="ppAggSource">
        /// Receives a pointer to the <see cref="IMFMediaSource"/> interface of the aggregated media source.
        /// The caller must release the interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description> The <em>pSourceCollection</em> collection does not contain any elements. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateAggregateSource(
        ///   _In_   IMFCollection *pSourceCollection,
        ///   _Out_  IMFMediaSource **ppAggSource
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7288BD4B-6A74-4528-854D-D82783630422(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7288BD4B-6A74-4528-854D-D82783630422(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateAggregateSource(
            IMFCollection pSourceCollection,
            out IMFMediaSource ppAggSource
            );

        /// <summary>
        /// Gets the media type for a stream associated with a topology node.
        /// </summary>
        /// <param name="pNode">
        /// A pointer to the <see cref="IMFTopologyNode"/> interface. 
        /// </param>
        /// <param name="dwStreamIndex">
        /// The identifier of the stream to query. This parameter is interpreted as follows:
        /// <para/>
        /// <para>* Transform nodes: The value is the zero-based index of the input or output stream.</para>
        /// <para>* All other node types: The value must be zero.</para>
        /// </param>
        /// <param name="fOutput">
        /// <strong>If TRUE</strong>, the function gets an output type <strong>. If FALSE</strong>, the
        /// function gets an input type. This parameter is interpreted as follows: 
        /// <para/>
        /// <para>* Output nodes: The value must be <strong>TRUE</strong>. </para><para>* Source nodes: The
        /// value must be <strong>FALSE</strong>. </para><para>* Tee nodes: The value is ignored.</para><para>*
        /// Transform nodes: If the value is <strong>TRUE</strong>, the <em>dwStreamIndex</em> parameter is the
        /// index for an output stream. Otherwise, <em>dwStreamIndex</em> is the index for an input stream. 
        /// </para>
        /// </param>
        /// <param name="ppType">
        /// Receives a pointer to the <see cref="IMFMediaType"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description>The stream index is invalid.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFGetTopoNodeCurrentType(
        ///   IMFTopologyNode *pNode,
        ///   DWORD dwStreamIndex,
        ///   BOOL fOutput,
        ///   _Out_  IMFMediaType **ppType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2405C6F6-1A3C-42D1-8EC9-4728F522CE42(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2405C6F6-1A3C-42D1-8EC9-4728F522CE42(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFGetTopoNodeCurrentType(
            IMFTopologyNode pNode,
            int dwStreamIndex,
            [MarshalAs(UnmanagedType.Bool)] bool fOutput,
            out IMFMediaType ppType);

        /// <summary>
        /// Creates a media sink for authoring MP4 files.
        /// </summary>
        /// <param name="pIByteStream">
        /// A pointer to the <see cref="IMFByteStream"/> interface of a byte stream. The media sink writes the
        /// MP4 file to this byte stream. The byte stream must be writable and support seeking. 
        /// </param>
        /// <param name="pVideoMediaType">
        /// A pointer to the <see cref="IMFMediaType"/> interface of a video media type. This type specifies
        /// the format of the video stream. 
        /// <para/>
        /// This parameter can be <strong>NULL</strong>, but not if <em>pAudioMediaType</em> is <strong>NULL
        /// </strong>. 
        /// </param>
        /// <param name="pAudioMediaType">
        /// A pointer to the <see cref="IMFMediaType"/> interface of an audio media type. This type specifies
        /// the format of the audio stream. 
        /// <para/>
        /// This parameter can be <strong>NULL</strong>, but not if <em>pVideoMediaType</em> is <strong>NULL
        /// </strong>. 
        /// </param>
        /// <param name="ppIMediaSink">
        /// Receives a pointer to the MP4 media sink's <see cref="IMFMediaSink"/> interface. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateMPEG4MediaSink(
        ///   _In_   IMFByteStream *pIByteStream,
        ///   _In_   IMFMediaType *pVideoMediaType,
        ///   _In_   IMFMediaType *pAudioMediaType,
        ///   _Out_  IMFMediaSink **ppIMediaSink
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E2A7C596-98B1-4C36-BA83-534459B22690(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E2A7C596-98B1-4C36-BA83-534459B22690(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateMPEG4MediaSink(
            IMFByteStream pIByteStream,
            IMFMediaType pVideoMediaType,
            IMFMediaType pAudioMediaType,
            out IMFMediaSink ppIMediaSink
            );

        /// <summary>
        /// Creates a media sink for authoring 3GP files.
        /// </summary>
        /// <param name="pIByteStream">
        /// A pointer to the <see cref="IMFByteStream"/> interface of a byte stream. The media sink writes the
        /// 3GP file to this byte stream. The byte stream must be writable and support seeking. 
        /// </param>
        /// <param name="pVideoMediaType">
        /// A pointer to the <see cref="IMFMediaType"/> interface of a video media type. This type specifies
        /// the format of the video stream. 
        /// <para/>
        /// This parameter can be <strong>NULL</strong>, but not if <em>pAudioMediaType</em> is <strong>NULL
        /// </strong>. 
        /// </param>
        /// <param name="pAudioMediaType">
        /// A pointer to the <see cref="IMFMediaType"/> interface of an audio media type. This type specifies
        /// the format of the audio stream. 
        /// <para/>
        /// This parameter can be <strong>NULL</strong>, but not if <em>pVideoMediaType</em> is <strong>NULL
        /// </strong>. 
        /// </param>
        /// <param name="ppIMediaSink">
        /// Receives a pointer to the 3GP media sink's <see cref="IMFMediaSink"/> interface. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreate3GPMediaSink(
        ///   _In_   IMFByteStream *pIByteStream,
        ///   _In_   IMFMediaType *pVideoMediaType,
        ///   _In_   IMFMediaType *pAudioMediaType,
        ///   _Out_  IMFMediaSink **ppIMediaSink
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A0A1F6AF-5D73-4347-ABD7-9B2BDE61FDF2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A0A1F6AF-5D73-4347-ABD7-9B2BDE61FDF2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreate3GPMediaSink(
            IMFByteStream pIByteStream,
            IMFMediaType pVideoMediaType,
            IMFMediaType pAudioMediaType,
            out IMFMediaSink ppIMediaSink
            );

        /// <summary>
        /// Creates the MP3 media sink.
        /// </summary>
        /// <param name="pTargetByteStream">
        /// A pointer to the <see cref="IMFByteStream"/> interface of a byte stream. The media sink writes the
        /// MP3 file to this byte stream. The byte stream must be writable. 
        /// </param>
        /// <param name="ppMediaSink">
        /// Receives a pointer to the <see cref="IMFMediaSink"/> interface of the MP3 media sink.. The caller
        /// must release the interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateMP3MediaSink(
        ///   _In_   IMFByteStream *pTargetByteStream,
        ///   _Out_  IMFMediaSink **ppMediaSink
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B555E9C8-5A2A-452D-8EDF-C41C0E24296B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B555E9C8-5A2A-452D-8EDF-C41C0E24296B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateMP3MediaSink(
            IMFByteStream pTargetByteStream,
            out IMFMediaSink ppMediaSink
        );

        /// <summary>
        /// Creates a video media type from a <see cref="Misc.BitmapInfoHeader"/> structure. 
        /// </summary>
        /// <param name="pbmihBitMapInfoHeader">
        /// A pointer to the <see cref="Misc.BitmapInfoHeader"/> structure to convert. 
        /// </param>
        /// <param name="cbBitMapInfoHeader">
        /// The size of the <see cref="Misc.BitmapInfoHeader"/> structure in bytes, including the size of any
        /// palette entries or color masks that follow the structure. 
        /// </param>
        /// <param name="dwPixelAspectRatioX">
        /// The X dimension of the pixel aspect ratio.
        /// </param>
        /// <param name="dwPixelAspectRatioY">
        /// The Y dimension of the pixel aspect ratio.
        /// </param>
        /// <param name="InterlaceMode">
        /// A member of the <see cref="MFVideoInterlaceMode"/> enumeration, specifying how the video is
        /// interlaced. 
        /// </param>
        /// <param name="VideoFlags">
        /// A bitwise <strong>OR</strong> of flags from the <see cref="MFVideoFlags"/> enumeration. 
        /// </param>
        /// <param name="dwFramesPerSecondNumerator">
        /// The numerator of the frame rate in frames per second.
        /// </param>
        /// <param name="dwFramesPerSecondDenominator">
        /// The denominator of the frame rate in frames per second
        /// </param>
        /// <param name="dwMaxBitRate">
        /// The approximate data rate of the video stream, in bits per second. If the rate is unknown, set this
        /// parameter to zero. 
        /// </param>
        /// <param name="ppIVideoMediaType">
        /// Receives a pointer to the <see cref="IMFVideoMediaType"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If the function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateVideoMediaTypeFromBitMapInfoHeaderEx(
        ///   _In_   const BITMAPINFOHEADER *pbmihBitMapInfoHeader,
        ///   _In_   UINT32 cbBitMapInfoHeader,
        ///   DWORD dwPixelAspectRatioX,
        ///   DWORD dwPixelAspectRatioY,
        ///   MFVideoInterlaceMode InterlaceMode,
        ///   QWORD VideoFlags,
        ///   DWORD dwFramesPerSecondNumerator,
        ///   DWORD dwFramesPerSecondDenominator,
        ///   DWORD dwMaxBitRate,
        ///   _Out_  IMFVideoMediaType **ppIVideoMediaType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/27160995-E934-4050-A231-D69D4F75DFCE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/27160995-E934-4050-A231-D69D4F75DFCE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateVideoMediaTypeFromBitMapInfoHeaderEx(
            BitmapInfoHeader[] pbmihBitMapInfoHeader,
            int cbBitMapInfoHeader,
            int dwPixelAspectRatioX,
            int dwPixelAspectRatioY,
            MFVideoInterlaceMode InterlaceMode,
            long VideoFlags,
            int dwFramesPerSecondNumerator,
            int dwFramesPerSecondDenominator,
            int dwMaxBitRate,
            out IMFVideoMediaType ppIVideoMediaType
        );

        /// <summary>
        /// Gets a pointer to the Microsoft Media Foundation plug-in manager.
        /// </summary>
        /// <param name="ppPluginControl">
        /// Receives a pointer to the <see cref="IMFPluginControl"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFGetPluginControl(
        ///   _Out_  IMFPluginControl **ppPluginControl
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/68B25C68-806D-46C3-98F8-8F29D7C21471(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/68B25C68-806D-46C3-98F8-8F29D7C21471(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFGetPluginControl(
            out IMFPluginControl ppPluginControl
        );

        /// <summary>
        /// Gets the merit value of a hardware codec.
        /// </summary>
        /// <param name="pMFT">
        /// A pointer to the <strong>IUnknown</strong> interface of the Media Foundation transform (MFT) that
        /// represents the codec. 
        /// </param>
        /// <param name="cbVerifier">
        /// The size, in bytes, of the <em>verifier</em> array. 
        /// </param>
        /// <param name="verifier">
        /// The address of a buffer that contains one of the following:
        /// <para/>
        /// <para>* The class identifier (CLSID) of the MFT.</para><para>* A null-terminated wide-character
        /// string that contains the symbol link for the underlying hardware device. Include the size of the
        /// terminating null in the value of <em>cbVerifier</em>. </para>
        /// </param>
        /// <param name="merit">
        /// Receives the merit value.
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT STDAPI MFGetMFTMerit(
        ///   _Inout_  IUnknown *pMFT,
        ///   _In_     UINT32 cbVerifier,
        ///   _In_     const BYTE *verifier,
        ///   _Out_    DWORD *merit
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/69029CF3-7F34-4BB1-8DFD-FA9A8D1A63C9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/69029CF3-7F34-4BB1-8DFD-FA9A8D1A63C9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFGetMFTMerit(
            [MarshalAs(UnmanagedType.IUnknown)] object pMFT,
            int cbVerifier,
            IntPtr verifier,
            out int merit
        );

#endif

        /// <summary>
        /// Gets a list of Microsoft Media Foundation transforms (MFTs) that match specified search criteria.
        /// This function extends the <see cref="MFExtern.MFTEnum"/> function.
        /// </summary>
        /// <param name="guidCategory">
        /// A GUID that specifies the category of MFTs to enumerate. For a list of MFT categories, see
        /// <c>MFT_CATEGORY</c>.
        /// </param>
        /// <param name="Flags">
        /// The bitwise <strong>OR</strong> of zero or more flags from the <c>_MFT_ENUM_FLAG</c> enumeration.
        /// </param>
        /// <param name="pInputType">
        /// A pointer to an <see cref="Transform.MFTRegisterTypeInfo"/> structure that specifies an input media
        /// type to match.
        /// <para/>
        /// This parameter can be <strong>NULL</strong>. If <strong>NULL</strong>, all input types are matched.
        /// </param>
        /// <param name="pOutputType">
        /// A pointer to an <see cref="Transform.MFTRegisterTypeInfo"/> structure that specifies an output
        /// media type to match.
        /// <para/>
        /// This parameter can be <strong>NULL</strong>. If <strong>NULL</strong>, all output types are
        /// matched.
        /// </param>
        /// <param name="pppMFTActivate">
        /// Receives an array of <see cref="IMFActivate"/> interface pointers. Each pointer represents an
        /// activation object for an MFT that matches the search criteria. The function allocates the memory
        /// for the array. The caller must release the pointers and call the <c>CoTaskMemFree</c> function to
        /// free the memory for the array.
        /// </param>
        /// <param name="pnumMFTActivate">
        /// Receives the number of elements in the <em>pppMFTActivate</em> array. If no MFTs match the search
        /// criteria, this parameter receives the value zero.
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFTEnumEx(
        ///   _In_   GUID guidCategory,
        ///   _In_   UINT32 Flags,
        ///   _In_   const MFT_REGISTER_TYPE_INFO *pInputType,
        ///   _In_   const MFT_REGISTER_TYPE_INFO *pOutputType,
        ///   _Out_  IMFActivate ***pppMFTActivate,
        ///   _Out_  UINT32 *pcMFTActivate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/E065AE51-85DD-48EF-9322-DE4ADE62C0FE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E065AE51-85DD-48EF-9322-DE4ADE62C0FE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true)]
        [SuppressUnmanagedCodeSecurity]
        public static extern int MFTEnumEx(
            [In] Guid guidCategory,
            int flags,
            MFTRegisterTypeInfo pInputType,
            MFTRegisterTypeInfo pOutputType,
            /* out IMFActivate[] */out IntPtr pppMFTActivate,
            out int pnumMFTActivate);

#if ALLOW_UNTESTED_INTERFACES

        /// <summary>
        /// Creates a new work queue. This function extends the capabilities of the 
        /// <see cref="MFExtern.MFAllocateWorkQueue"/> function by making it possible to create a work queue
        /// that has a message loop. 
        /// </summary>
        /// <param name="WorkQueueType">
        /// A member of the <see cref="MFASYNC_WORKQUEUE_TYPE"/> enumeration, specifying the type of work queue
        /// to create. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>MF_MULTITHREADED_WORKQUEUE</strong></term><description>Create a multithreaded work queue. Generally, applications should not create private multithreaded queues. Use the platform multithreaded queues instead. For more information, see <c>Work Queue and Threading Improvements</c>. </description></item>
        /// <item><term><strong>MF_STANDARD_WORKQUEUE</strong></term><description>Create a work queue without a message loop. Using this flag is equivalent to calling <see cref="MFExtern.MFAllocateWorkQueue"/>. </description></item>
        /// <item><term><strong>MF_WINDOW_WORKQUEUE</strong></term><description>Create a work queue with a message loop. The thread that dispatches the work items for this queue will also call <c>PeekMessage</c> and <c>DispatchMessage</c>. Use this option if your callback performs any actions that require a message loop. </description></item>
        /// </list>
        /// </param>
        /// <param name="pdwWorkQueue">
        /// Receives an identifier for the work queue that was created.
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The function succeeded.</description></item>
        /// <item><term><strong>E_FAIL</strong></term><description>The application exceeded the maximum number of work queues.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>Invalid argument.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The application did not call <see cref="MFStartup"/>, or the application has already called <see cref="MFExtern.MFShutdown"/>. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFAllocateWorkQueueEx(
        ///   _In_   MFASYNC_WORKQUEUE_TYPE WorkQueueType,
        ///   _Out_  DWORD *pdwWorkQueue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/422B8BC2-0616-4F7F-9908-775940F8C1AB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/422B8BC2-0616-4F7F-9908-775940F8C1AB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFAllocateWorkQueueEx(
            MFASYNC_WORKQUEUE_TYPE WorkQueueType,
            out int pdwWorkQueue
        );

        /// <summary>
        /// Registers a Media Foundation transform (MFT) in the caller's process.
        /// </summary>
        /// <param name="pClassFactory">
        /// A pointer to the <strong>IClassFactory</strong> interface of a class factory object. The class
        /// factory creates the MFT. 
        /// </param>
        /// <param name="guidCategory">
        /// A GUID that specifies the category of the MFT. For a list of MFT categories, see 
        /// <c>MFT_CATEGORY</c>. 
        /// </param>
        /// <param name="pszName">
        /// A wide-character null-terminated string that contains the friendly name of the MFT.
        /// </param>
        /// <param name="Flags">
        /// A bitwise <strong>OR</strong> of zero or more flags from the <c>_MFT_ENUM_FLAG</c> enumeration. 
        /// </param>
        /// <param name="cInputTypes">
        /// The number of elements in the <em>pInputTypes</em> array. 
        /// </param>
        /// <param name="pInputTypes">
        /// A pointer to an array of <see cref="Transform.MFTRegisterTypeInfo"/> structures. Each member of the
        /// array specifies an input format that the MFT supports. This parameter can be <strong>NULL</strong>
        /// if <em>cInputTypes</em> is zero. 
        /// </param>
        /// <param name="cOutputTypes">
        /// The number of elements in the <em>pOutputTypes</em> array. 
        /// </param>
        /// <param name="pOutputTypes">
        /// A pointer to an array of <see cref="Transform.MFTRegisterTypeInfo"/> structures. Each member of the
        /// array defines an output format that the MFT supports. This parameter can be <strong>NULL</strong>
        /// if <em>cOutputTypes</em> is zero. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFTRegisterLocal(
        ///   _In_  IClassFactory *pClassFactory,
        ///   _In_  REFGUID guidCategory,
        ///   _In_  LPCWSTR pszName,
        ///   _In_  UINT32 Flags,
        ///   _In_  UINT32 cInputTypes,
        ///   _In_  const MFT_REGISTER_TYPE_INFO *pInputTypes,
        ///   _In_  UINT32 cOutputTypes,
        ///   _In_  const MFT_REGISTER_TYPE_INFO *pOutputTypes
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/802F7083-E224-4E5C-8A35-3E93DA0CBD91(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/802F7083-E224-4E5C-8A35-3E93DA0CBD91(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFTRegisterLocal(
            [MarshalAs(UnmanagedType.IUnknown)] object pClassFactory,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidCategory,
            [MarshalAs(UnmanagedType.LPWStr)] string pszName,
            int Flags,
            int cInputTypes,
            MFTRegisterTypeInfo[] pInputTypes,
            int cOutputTypes,
            MFTRegisterTypeInfo[] pOutputTypes
        );

        /// <summary>
        /// Unregisters one or more Media Foundation transforms (MFTs) from the caller's process.
        /// </summary>
        /// <param name="pClassFactory">
        /// A pointer to the <strong>IClassFactory</strong> interface of a class factory object. This parameter
        /// can be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>HRESULT_FROM_WIN32( <strong>ERROR_NOT_FOUND</strong>) </strong></term><description>The MFT specified by the <em>pClassFactory</em> parameter was not registered in this process. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFTUnregisterLocal(
        ///   _In_  IClassFactory *pClassFactory
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E77EDCE7-0ABB-41A3-A65E-FD159173E135(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E77EDCE7-0ABB-41A3-A65E-FD159173E135(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFTUnregisterLocal(
            [MarshalAs(UnmanagedType.IUnknown)] object pClassFactory
        );

        /// <summary>
        /// Registers a Media Foundation transform (MFT) in the caller's process.
        /// </summary>
        /// <param name="clisdMFT">
        /// The class identifier (CLSID) of the MFT.
        /// </param>
        /// <param name="guidCategory">
        /// A GUID that specifies the category of the MFT. For a list of MFT categories, see 
        /// <c>MFT_CATEGORY</c>. 
        /// </param>
        /// <param name="pszName">
        /// A wide-character null-terminated string that contains the friendly name of the MFT.
        /// </param>
        /// <param name="Flags">
        /// A bitwise <strong>OR</strong> of zero or more flags from the <c>_MFT_ENUM_FLAG</c> enumeration. 
        /// </param>
        /// <param name="cInputTypes">
        /// The number of elements in the <em>pInputTypes</em> array. 
        /// </param>
        /// <param name="pInputTypes">
        /// A pointer to an array of <see cref="Transform.MFTRegisterTypeInfo"/> structures. Each member of the
        /// array specifies an input format that the MFT supports. This parameter can be <strong>NULL</strong>
        /// if <em>cInputTypes</em> is zero. 
        /// </param>
        /// <param name="cOutputTypes">
        /// The number of elements in the <em>pOutputTypes</em> array. 
        /// </param>
        /// <param name="pOutputTypes">
        /// A pointer to an array of <see cref="Transform.MFTRegisterTypeInfo"/> structures. Each member of the
        /// array defines an output format that the MFT supports. This parameter can be <strong>NULL</strong>
        /// if <em>cOutputTypes</em> is zero. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFTRegisterLocalByCLSID(
        ///   _In_  REFCLSID clisdMFT,
        ///   _In_  REFGUID guidCategory,
        ///   _In_  LPCWSTR pszName,
        ///   _In_  UINT32 Flags,
        ///   _In_  UINT32 cInputTypes,
        ///   _In_  const MFT_REGISTER_TYPE_INFO *pInputTypes,
        ///   _In_  UINT32 cOutputTypes,
        ///   _In_  const MFT_REGISTER_TYPE_INFO *pOutputTypes
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/80C45AC3-4487-41BF-A5F5-F459DB3CD700(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/80C45AC3-4487-41BF-A5F5-F459DB3CD700(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFTRegisterLocalByCLSID(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid clisdMFT,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidCategory,
            [MarshalAs(UnmanagedType.LPWStr)] string pszName,
            MFT_EnumFlag Flags,
            int cInputTypes,
            MFTRegisterTypeInfo[] pInputTypes,
            int cOutputTypes,
            MFTRegisterTypeInfo[] pOutputTypes
        );

        /// <summary>
        /// Unregisters a Media Foundation transform (MFT) from the caller's process.
        /// </summary>
        /// <param name="clsidMFT">
        /// The class identifier (CLSID) of the MFT.
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>HRESULT_FROM_WIN32( <strong>ERROR_NOT_FOUND</strong>) </strong></term><description>The MFT specified by the <em>clsidMFT</em> parameter was not registered in this process. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFTUnregisterLocalByCLSID(
        ///   _In_  CLSID clsidMFT
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EBDF50AD-99CB-4EBF-9050-DA0B2D9F26DF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EBDF50AD-99CB-4EBF-9050-DA0B2D9F26DF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFTUnregisterLocalByCLSID(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid clsidMFT
        );















        /// <summary>
        /// Creates an Audio-Video Interleaved (AVI) Sink.
        /// </summary>
        /// <param name="pIByteStream">
        /// Pointer to the byte stream that will be used to write the AVI file.
        /// </param>
        /// <param name="pVideoMediaType">
        /// Pointer to the media type of the video input stream.
        /// </param>
        /// <param name="pAudioMediaType">
        /// Pointer to the media type of the audio input stream.
        /// </param>
        /// <param name="ppIMediaSink">
        /// Receives a pointer to the <see cref="IMFMediaSink"/> Interface. The caller must release this interface.
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT</strong> error code.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT WINAPI MFCreateAVIMediaSink(
        ///   _In_      IMFByteStream *pIByteStream,
        ///   _In_      IMFMediaType *pVideoMediaType,
        ///   _In_opt_  IMFMediaType *pAudioMediaType,
        ///   _Out_     IMFMediaSink **ppIMediaSink 
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302108(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302108(v=vs.85).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateAVIMediaSink(
            [In] IMFByteStream pIByteStream,
            [In] IMFMediaType pVideoMediaType,
            [In] IMFMediaType pAudioMediaType,
            out IMFMediaSink ppIMediaSink
        );

        /// <summary>
        /// Creates an WAVE archive sink. The WAVE archive sink takes audio and writes it to an .wav file. 
        /// </summary>
        /// <param name="pTargetByteStream">
        /// Pointer to the byte stream that will be used to write the .wav file.
        /// </param>
        /// <param name="pAudioMediaType">
        /// Pointer to the audio media type.
        /// </param>
        /// <param name="ppMediaSink">
        /// Receives a pointer to the <see cref="IMFMediaSink"/> interface. The caller must release this interface.
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT WINAPI MFCreateWAVEMediaSink(
        ///   _In_   IMFByteStream *pTargetByteStream,
        ///   _In_   IMFMediaType *pAudioMediaType,
        ///   _Out_  IMFMediaSink **ppMediaSink 
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302112(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302112(v=vs.85).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateWAVEMediaSink(
            [In] IMFByteStream pTargetByteStream,
            [In] IMFMediaType pAudioMediaType,
            out IMFMediaSink ppMediaSink
        );

        /// <summary>
        /// Gets the local system ID.
        /// </summary>
        /// <param name="verifier">
        /// Application-specific verifier value.
        /// </param>
        /// <param name="size">
        /// Length in bytes of verifier.
        /// </param>
        /// <param name="id">
        /// Returned ID string. This value must be freed by the caller by calling <c>CoTaskMemFree</c>. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT WINAPI MFGetLocalId(
        ///   _In_  const BYTE *verifier,
        ///   UINT32 size,
        ///   _In_  LPWSTR *id
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/24EA8907-9EBF-42FF-8823-05D48E27F9EA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/24EA8907-9EBF-42FF-8823-05D48E27F9EA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        public static extern int MFGetLocalId(
            [In] IntPtr verifier,
            [In] int size,
            out IntPtr id
        );
        
        /// <summary>
        /// [This API is not supported and may be altered or unavailable in the future.]
        /// <para/>
        /// Creates an audio media type from a <strong>WAVEFORMATEX</strong> structure. 
        /// </summary>
        /// <param name="pAudioFormat">
        /// Pointer to a <strong>WAVEFORMATEX</strong> structure that describes the audio format. 
        /// </param>
        /// <param name="ppIAudioMediaType">
        /// Receives a pointer to the <see cref="IMFAudioMediaType"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateAudioMediaType(
        ///   _In_   const WAVEFORMATEX *pAudioFormat,
        ///   _Out_  IMFAudioMediaType **ppIAudioMediaType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8857E150-1746-4F3F-AAA8-DB0F44787621(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8857E150-1746-4F3F-AAA8-DB0F44787621(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mfplat.dll", ExactSpelling = true), Obsolete("This function is deprecated"), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateAudioMediaType(
            [In] WaveFormatEx pAudioFormat,
            out IMFAudioMediaType ppIAudioMediaType
            );

        /// <summary>
        /// Creates a credential cache object. An application can use this object to implement a custom
        /// credential manager.
        /// </summary>
        /// <param name="ppCache">
        /// Receives a pointer to the <see cref="IMFNetCredentialCache"/> interface of the new credential cache
        /// object. The caller must release the interface. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The function succeeded. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateCredentialCache(
        ///   IMFNetCredentialCache **ppCache
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EC27F54A-4534-4342-856B-F6F55C5A7FDB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EC27F54A-4534-4342-856B-F6F55C5A7FDB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("mf.dll", ExactSpelling = true), Obsolete("The returned object doesn't support QI"), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateCredentialCache(
            out IMFNetCredentialCache ppCache
        );

        /// <summary>
        /// This function is not implemented.
        /// </summary>
        /// <param name="pbmihBitMapInfoHeader">
        /// Reserved.
        /// </param>
        /// <param name="dwPixelAspectRatioX">
        /// Reserved.
        /// </param>
        /// <param name="dwPixelAspectRatioY">
        /// Reserved.
        /// </param>
        /// <param name="InterlaceMode">
        /// Reserved.
        /// </param>
        /// <param name="VideoFlags">
        /// Reserved.
        /// </param>
        /// <param name="qwFramesPerSecondNumerator">
        /// Reserved.
        /// </param>
        /// <param name="qwFramesPerSecondDenominator">
        /// Reserved.
        /// </param>
        /// <param name="dwMaxBitRate">
        /// Reserved.
        /// </param>
        /// <param name="ppIVideoMediaType">
        /// Reserved.
        /// </param>
        /// <returns>
        /// Returns <strong>E_FAIL</strong>. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateVideoMediaTypeFromBitMapInfoHeader(
        ///   const BITMAPINFOHEADER *pbmihBitMapInfoHeader,
        ///   DWORD dwPixelAspectRatioX,
        ///   DWORD dwPixelAspectRatioY,
        ///   MFVideoInterlaceMode InterlaceMode,
        ///   QWORD VideoFlags,
        ///   QWORD qwFramesPerSecondNumerator,
        ///   QWORD qwFramesPerSecondDenominator,
        ///   DWORD dwMaxBitRate,
        ///   IMFVideoMediaType **ppIVideoMediaType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5C0F4915-2E8F-4B1E-BD49-39F1854D2640(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5C0F4915-2E8F-4B1E-BD49-39F1854D2640(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("evr.dll", ExactSpelling = true), Obsolete("Not implemented"), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateVideoMediaTypeFromBitMapInfoHeader(
            [In, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(BMMarshaler))] BitmapInfoHeader pbmihBitMapInfoHeader,
            int dwPixelAspectRatioX,
            int dwPixelAspectRatioY,
            MFVideoInterlaceMode InterlaceMode,
            long VideoFlags,
            long qwFramesPerSecondNumerator,
            long qwFramesPerSecondDenominator,
            int dwMaxBitRate,
            out IMFVideoMediaType ppIVideoMediaType
            );


        /// <summary>
        /// <i>***** Documentation Missing *****</i>.
        /// </summary>
        /// <param name="ppQualityManager"><i>***** Documentation Missing *****</i>.</param>
        /// <returns><i>***** Documentation Missing *****</i>.</returns>
        // BUG-BUG: Nowhere does this method appear in the header files !!!!
        [DllImport("mf.dll", ExactSpelling = true), Obsolete("Interface doesn't exist"), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateQualityManager(
            out IMFQualityManager ppQualityManager
        );

        /// <summary>
        /// Creates a media type from a <strong>KS_VIDEOINFOHEADER</strong> structure. 
        /// </summary>
        /// <param name="pVideoInfoHeader">
        /// Pointer to the <strong>KS_VIDEOINFOHEADER</strong> structure to convert. (This structure is
        /// identical to the DirectShow <strong>VIDEOINFOHEADER</strong> structure.) 
        /// </param>
        /// <param name="cbVideoInfoHeader">
        /// Size of the <strong>KS_VIDEOINFOHEADER</strong> structure in bytes. 
        /// </param>
        /// <param name="dwPixelAspectRatioX">
        /// The X dimension of the pixel aspect ratio. The pixel aspect ratio is <em>dwPixelAspectRatioX</em>: 
        /// <em>dwPixelAspectRatioY</em>. 
        /// </param>
        /// <param name="dwPixelAspectRatioY">
        /// The Y dimension of the pixel aspect ratio.
        /// </param>
        /// <param name="InterlaceMode">
        /// Member of the <see cref="MFVideoInterlaceMode"/> enumeration that specifies how the video is
        /// interlaced. 
        /// </param>
        /// <param name="VideoFlags">
        /// Bitwise <strong>OR</strong> of flags from the <see cref="MFVideoFlags"/> enumeration. 
        /// </param>
        /// <param name="pSubtype">
        /// Pointer to a subtype GUID. This parameter can be <strong>NULL</strong>. If the subtype GUID is
        /// specified, the function uses it to set the media subtype. Otherwise, the function attempts to
        /// deduce the subtype from the <strong>biCompression</strong> field contained in the <strong>
        /// KS_VIDEOINFOHEADER</strong> structure. 
        /// </param>
        /// <param name="ppIVideoMediaType">
        /// Receives a pointer to the <see cref="IMFVideoMediaType"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateVideoMediaTypeFromVideoInfoHeader(
        ///   const KS_VIDEOINFOHEADER *pVideoInfoHeader,
        ///   DWORD cbVideoInfoHeader,
        ///   DWORD dwPixelAspectRatioX,
        ///   DWORD dwPixelAspectRatioY,
        ///   MFVideoInterlaceMode InterlaceMode,
        ///   QWORD VideoFlags,
        ///   const GUID *pSubtype,
        ///   IMFVideoMediaType **ppIVideoMediaType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/922AB0B5-2363-4073-9252-A71B79E03573(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/922AB0B5-2363-4073-9252-A71B79E03573(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("evr.dll", ExactSpelling = true), Obsolete("Undoc'ed"), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateVideoMediaTypeFromVideoInfoHeader(
            VideoInfoHeader pVideoInfoHeader,
            int cbVideoInfoHeader,
            int dwPixelAspectRatioX,
            int dwPixelAspectRatioY,
            MFVideoInterlaceMode InterlaceMode,
            long VideoFlags,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid pSubtype,
            out IMFVideoMediaType ppIVideoMediaType
            );

        /// <summary>
        /// Creates a media type from a <strong>KS_VIDEOINFOHEADER2</strong> structure. 
        /// </summary>
        /// <param name="pVideoInfoHeader">
        /// Pointer to the <strong>KS_VIDEOINFOHEADER2</strong> structure to convert. (This structure is
        /// identical to the DirectShow <strong>VIDEOINFOHEADER2</strong> structure.) 
        /// </param>
        /// <param name="cbVideoInfoHeader">
        /// Size of the <strong>KS_VIDEOINFOHEADER2</strong> structure in bytes. 
        /// </param>
        /// <param name="AdditionalVideoFlags">
        /// Bitwise <strong>OR</strong> of flags from the <see cref="MFVideoFlags"/> enumeration. Use this
        /// parameter for format information that is not contained in the <strong>KS_VIDEOINFOHEADER2</strong>
        /// structure. 
        /// </param>
        /// <param name="pSubtype">
        /// Pointer to a subtype GUID. This parameter can be <strong>NULL</strong>. If the subtype GUID is
        /// specified, the function uses it to set the media subtype. Otherwise, the function attempts to
        /// deduce the subtype from the <strong>biCompression</strong> field contained in the <strong>
        /// KS_VIDEOINFOHEADER2</strong> structure. 
        /// </param>
        /// <param name="ppIVideoMediaType">
        /// Receives a pointer to the <see cref="IMFVideoMediaType"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this function succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>
        /// HRESULT</strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT MFCreateVideoMediaTypeFromVideoInfoHeader2(
        ///   const KS_VIDEOINFOHEADER2 *pVideoInfoHeader,
        ///   DWORD cbVideoInfoHeader,
        ///   QWORD AdditionalVideoFlags,
        ///   const GUID *pSubtype,
        ///   IMFVideoMediaType **ppIVideoMediaType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2C0F4C47-7018-42F3-AE63-5209DAA44158(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2C0F4C47-7018-42F3-AE63-5209DAA44158(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("evr.dll", ExactSpelling = true), Obsolete("Undoc'ed"), SuppressUnmanagedCodeSecurity]
        public static extern int MFCreateVideoMediaTypeFromVideoInfoHeader2(
            VideoInfoHeader2 pVideoInfoHeader,
            int cbVideoInfoHeader,
            long AdditionalVideoFlags,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid pSubtype,
            out IMFVideoMediaType ppIVideoMediaType
            );

#endif
    }
}
