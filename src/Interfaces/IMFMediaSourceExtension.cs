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
    /// Provides functionality for the Media Source Extension (MSE).
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/2ACABCC2-242D-4B3D-B5B4-680C7973201F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2ACABCC2-242D-4B3D-B5B4-680C7973201F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("e467b94e-a713-4562-a802-816a42e9008a"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaSourceExtension
    {
        /// <summary>
        /// Gets the collection of source buffers associated with this media source.
        /// </summary>
        /// <returns>
        /// The collection of source buffers.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// IMFSourceBufferList GetSourceBuffers();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/553B2711-1098-4E07-824D-42D5B2D57C16(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/553B2711-1098-4E07-824D-42D5B2D57C16(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        IMFSourceBufferList GetSourceBuffers();

        /// <summary>
        /// Gets the source buffers that are actively supplying media data to the media source.
        /// </summary>
        /// <returns>
        /// The list of active source buffers.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// IMFSourceBufferList GetActiveSourceBuffers();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9D4A70CF-7436-4F4A-9A7C-9127E3829BA8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9D4A70CF-7436-4F4A-9A7C-9127E3829BA8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        IMFSourceBufferList GetActiveSourceBuffers();

        /// <summary>
        /// Gets the ready state of the media source.
        /// </summary>
        /// <returns>
        /// The ready state of the media source.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// MF_MSE_READY GetReadyState();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/155D9202-5598-467C-B4D0-D22424B13B9D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/155D9202-5598-467C-B4D0-D22424B13B9D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        MF_MSE_READY GetReadyState();

        /// <summary>
        /// Gets the duration of the media source in 100-nanosecond units.
        /// </summary>
        /// <returns>
        /// The duration of the media source in 100-nanosecond units. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// double GetDuration();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D0C644A0-9784-40B0-9D1F-7D9E8334D705(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D0C644A0-9784-40B0-9D1F-7D9E8334D705(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        double GetDuration();

        /// <summary>
        /// Sets the duration of the media source in 100-nanosecond units.
        /// </summary>
        /// <param name="duration">
        /// The duration of the media source in 100-nanosecond units.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetDuration(
        ///   [in]  double duration
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DC3DC600-CA81-40DA-9EDB-0AF283BA9221(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DC3DC600-CA81-40DA-9EDB-0AF283BA9221(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetDuration(
            double duration
            );

        /// <summary>
        /// Adds a <c>IMFSourceBuffer</c> to the collection of buffers associated with the 
        /// <c>IMFMediaSourceExtension</c>. 
        /// </summary>
        /// <param name="type">
        /// </param>
        /// <param name="pNotify">
        /// </param>
        /// <param name="ppSourceBuffer">
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT AddSourceBuffer(
        ///   [in]   BSTR type,
        ///   [in]   IMFSourceBufferNotify *pNotify,
        ///   [out]  IMFSourceBuffer **ppSourceBuffer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1ECB7047-4DC9-4657-8A19-12108DE299C0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1ECB7047-4DC9-4657-8A19-12108DE299C0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int AddSourceBuffer(
            [MarshalAs(UnmanagedType.BStr)] string type,
            IMFSourceBufferNotify pNotify,
            out IMFSourceBuffer ppSourceBuffer
            );

        /// <summary>
        /// Removes the specified source buffer from the collection of source buffers managed by the 
        /// <c>IMFMediaSourceExtension</c> object. 
        /// </summary>
        /// <param name="pSourceBuffer">
        /// The buffer to remove.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT RemoveSourceBuffer(
        ///   [in]  IMFSourceBuffer *pSourceBuffer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2F29CBAC-4261-41EE-84C8-CB73686AEEE5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2F29CBAC-4261-41EE-84C8-CB73686AEEE5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RemoveSourceBuffer(
            IMFSourceBuffer pSourceBuffer
            );

        /// <summary>
        /// Indicate that the end of the media stream has been reached. 
        /// </summary>
        /// <param name="error">
        /// Used to pass error information.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetEndOfStream(
        ///   [in]  MF_MSE_ERROR error
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6D6BFFCC-AA3C-4825-9268-00DCD2A347E6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6D6BFFCC-AA3C-4825-9268-00DCD2A347E6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetEndOfStream(
            MF_MSE_ERROR error
            );

        /// <summary>
        /// Gets a value that indicates if the specified MIME type is supported by the media source.
        /// </summary>
        /// <param name="type">
        /// The media type to check support for.
        /// </param>
        /// <returns>
        /// <strong>true</strong> if the media type is supported; otherwise, <strong>false</strong>. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// BOOL IsTypeSupported(
        ///   [in]  BSTR type
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/894EF7D2-D008-42E1-8A61-26F35A8877BE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/894EF7D2-D008-42E1-8A61-26F35A8877BE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsTypeSupported(
            [MarshalAs(UnmanagedType.BStr)] string type
            );

        /// <summary>
        /// Gets the <c>IMFSourceBuffer</c> at the specified index in the collection of buffers. 
        /// </summary>
        /// <param name="dwStreamIndex">
        /// The location of the buffer in the colloection.
        /// </param>
        /// <returns>
        /// The source buffer.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// IMFSourceBuffer GetSourceBuffer(
        ///   [in]  DWORD dwStreamIndex
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/ADA32819-0EC3-4083-97A3-B8AE257D751B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/ADA32819-0EC3-4083-97A3-B8AE257D751B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        IMFSourceBuffer GetSourceBuffer(
            int dwStreamIndex
            );
    }

#endif
}
