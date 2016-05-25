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
    /// <summary>
    /// Gets metadata from a media source or other object.
    /// <para/>
    /// If a media source supports this interface, it must expose the interface as a service. To get a
    /// pointer to this interface from a media source, call <see cref="IMFGetService.GetService"/>. The
    /// service identifier is <strong>MF_METADATA_PROVIDER_SERVICE</strong>. Other types of object can
    /// expose this interface through <strong>QueryInterface</strong>.
    /// <para/>
    /// Use this interface to get a pointer to the <see cref="IMFMetadata"/> interface.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/F32E78C9-A567-448D-947D-D7EA996BBA5E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F32E78C9-A567-448D-947D-D7EA996BBA5E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport]
    [System.Security.SuppressUnmanagedCodeSecurity]
    [Guid("56181D2D-E221-4ADB-B1C8-3CEE6A53F76F")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMetadataProvider
    {
        /// <summary>
        /// Gets a collection of metadata, either for an entire presentation, or for one stream in the
        /// presentation.
        /// </summary>
        /// <param name="pPresentationDescriptor">
        /// Pointer to the <see cref="IMFPresentationDescriptor"/> interface of the media source's presentation
        /// descriptor.
        /// </param>
        /// <param name="dwStreamIdentifier">
        /// If this parameter is zero, the method retrieves metadata that applies to the entire presentation.
        /// Otherwise, this <em></em> parameter specifies a stream identifier, and the method retrieves
        /// metadata for that stream. To get the stream identifier for a stream, call
        /// <see cref="IMFStreamDescriptor.GetStreamIdentifier"/>.
        /// </param>
        /// <param name="dwFlags">
        /// Reserved. Must be zero.
        /// </param>
        /// <param name="ppMFMetadata">
        /// Receives a pointer to the <see cref="IMFMetadata"/> interface. Use this interface to access the
        /// metadata. The caller must release the interface.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_PROPERTY_NOT_FOUND</strong></term><description>No metadata is available for the requested stream or presentation.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetMFMetadata(
        ///   [in]   IMFPresentationDescriptor *pPresentationDescriptor,
        ///   [in]   DWORD dwStreamIdentifier,
        ///   [in]   DWORD dwFlags,
        ///   [out]  IMFMetadata **ppMFMetadata
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/0A3C1932-C301-4ECD-B640-02D7BCFC2ACA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0A3C1932-C301-4ECD-B640-02D7BCFC2ACA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMFMetadata(
            [In, MarshalAs(UnmanagedType.Interface)]
            IMFPresentationDescriptor pPresentationDescriptor,
            [In] int dwStreamIdentifier,
            [In] int dwFlags, // must be zero
            /* [MarshalAs(UnmanagedType.Interface)] out IMFMetadata */ out IntPtr ppMFMetadata);
    }
}
