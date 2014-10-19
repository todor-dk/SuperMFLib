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
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation.ReadWrite
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Creates an instance of either the sink writer or the source reader.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/83EF0F0A-AE60-474D-A9E7-7C83A73F6255(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/83EF0F0A-AE60-474D-A9E7-7C83A73F6255(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("E7FE2E12-661C-40DA-92F9-4F002AB67627")]
    public interface IMFReadWriteClassFactory
    {
        /// <summary>
        /// Creates an instance of the sink writer or source reader, given a URL.
        /// </summary>
        /// <param name="clsid">
        /// The CLSID of the object to create.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong><strong>CLSID_MFSinkWriter</strong></strong></term><description>Create the sink writer. The <em>ppvObject</em> parameter receives an <see cref="ReadWrite.IMFSinkWriter"/> interface pointer. </description></item>
        /// <item><term><strong><strong>CLSID_MFSourceReader</strong></strong></term><description>Create the source reader. The <em>ppvObject</em> parameter receives an <see cref="ReadWrite.IMFSourceReader"/> interface pointer. </description></item>
        /// </list>
        /// </param>
        /// <param name="pwszURL">
        /// A null-terminated string that contains a URL. If <em>clsid</em> is CLSID_ <strong>MFSinkWriter
        /// </strong>, the URL specifies the name of the output file. The sink writer creates a new file with
        /// this name. If <em>clsid</em> is <strong>CLSID_MFSourceReader</strong>, the URL specifies the input
        /// file for the source reader. 
        /// </param>
        /// <param name="pAttributes">
        /// A pointer to the <see cref="IMFAttributes"/> interface. You can use this parameter to configure the
        /// sink writer or source reader. For more information, see the following topics: 
        /// <para/>
        /// <para>* <c>Sink Writer Attributes</c></para><para>* <c>Source Reader Attributes</c></para>
        /// <para/>
        /// This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="riid">
        /// The IID of the requested interface.
        /// </param>
        /// <param name="ppvObject">
        /// Receives a pointer to the requested interface. The caller must release the interface.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT CreateInstanceFromURL(
        ///   [in]   REFCLSID clsid,
        ///   [in]   LPCWSTR *pwszURL,
        ///   [in]   IMFAttributes pAttributes,
        ///   [in]   REFIID riid,
        ///   [out]  LPVOID *ppvObject
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2769FAA2-E381-4908-95F8-122AE4CD7EC5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2769FAA2-E381-4908-95F8-122AE4CD7EC5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateInstanceFromURL(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid clsid,
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszURL,
            IMFAttributes pAttributes,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject
        );

        /// <summary>
        /// Creates an instance of the sink writer or source reader, given an <strong>IUnknown</strong>
        /// pointer. 
        /// </summary>
        /// <param name="clsid">
        /// The CLSID of the object to create.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong><strong>CLSID_MFSinkWriter</strong></strong></term><description>Create the sink writer. The <em>ppvObject</em> parameter receives an <see cref="ReadWrite.IMFSinkWriter"/> interface pointer. </description></item>
        /// <item><term><strong><strong>CLSID_MFSourceReader</strong></strong></term><description>Create the source reader. The <em>ppvObject</em> parameter receives an <see cref="ReadWrite.IMFSourceReader"/> interface pointer. </description></item>
        /// </list>
        /// </param>
        /// <param name="punkObject">
        /// A pointer to the <strong>IUnknown</strong> interface of an object that is used to initialize the
        /// source reader or sink writer. The method queries this pointer for one of the following interfaces. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong><see cref="IMFByteStream"/></strong></term><description>Pointer to a byte stream. If <em>clsid</em> is <strong>CLSID_MFSinkWriter</strong>, the sink writer writes data to this byte stream. If <em>clsid</em> is <strong>CLSID_MFSourceReader</strong>, this byte stream provides the source data for the source reader. </description></item>
        /// <item><term><strong><see cref="IMFMediaSink"/></strong></term><description>Pointer to a media sink. Applies only when <em>clsid</em> is <strong>CLSID_MFSinkWriter</strong>. </description></item>
        /// <item><term><strong><see cref="IMFMediaSource"/></strong></term><description>Pointer to a media source. Applies only when <em>clsid</em> is <strong>CLSID_MFSourceReader</strong>. </description></item>
        /// </list>
        /// </param>
        /// <param name="pAttributes">
        /// A pointer to the <see cref="IMFAttributes"/> interface. You can use this parameter to configure the
        /// sink writer or source reader. For more information, see the following topics: 
        /// <para/>
        /// <para>* <c>Sink Writer Attributes</c></para><para>* <c>Source Reader Attributes</c></para>
        /// <para/>
        /// This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="riid">
        /// The IID of the requested interface.
        /// </param>
        /// <param name="ppvObject">
        /// Receives a pointer to the requested interface. The caller must release the interface.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT CreateInstanceFromObject(
        ///   [in]   REFCLSID clsid,
        ///   [in]   IUnknown *punkObject,
        ///   [in]   IMFAttributes pAttributes,
        ///   [in]   REFIID riid,
        ///   [out]  LPVOID *ppvObject
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5DA582C2-37F9-47EE-B8EA-D21F1323F1DF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5DA582C2-37F9-47EE-B8EA-D21F1323F1DF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateInstanceFromObject(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid clsid,
            [MarshalAs(UnmanagedType.IUnknown)] object punkObject,
            IMFAttributes pAttributes,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject
        );
    }

#endif

}
