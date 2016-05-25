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
    /// Allows a media source to create a <c>Windows Runtime</c> object in the <c>Protected Media Path</c>
    /// (PMP) process. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/CA24930D-BD1E-4C12-8246-1E505A98944A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CA24930D-BD1E-4C12-8246-1E505A98944A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("84d2054a-3aa1-4728-a3b0-440a418cf49c")]
    internal interface IMFPMPHostApp
    {
        /// <summary>
        /// Blocks the protected media path (PMP) process from ending. 
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT LockProcess();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EE3DA924-A90A-4736-812E-F392631177C2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EE3DA924-A90A-4736-812E-F392631177C2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int LockProcess();

        /// <summary>
        /// Decrements the lock count on the protected media path (PMP) process. Call this method once for each
        /// call to <see cref="IMFPMPHostApp.LockProcess"/>. 
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT UnlockProcess();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4CB26F53-7D2A-417B-9BB8-0268920CF2A7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4CB26F53-7D2A-417B-9BB8-0268920CF2A7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int UnlockProcess();

        /// <summary>
        /// Creates a Windows Runtime object in the protected media path (PMP) process. 
        /// </summary>
        /// <param name="id">
        /// Id of object to create.
        /// </param>
        /// <param name="pStream">
        /// Data to be passed to the object by way of a <c>IPersistStream</c>. 
        /// </param>
        /// <param name="riid">
        /// The interface identifier (IID) of the interface to retrieve. 
        /// </param>
        /// <param name="ppv">
        /// Receives a pointer to the created object. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT ActivateClassById(
        ///   [in]          LPCWSTR id,
        ///   [in, unique]  IStream *pStream,
        ///   [in]          REFIID riid,
        ///   [out]         void **ppv
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E0E14171-FCC9-418A-A93D-3CDBAE254A3F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E0E14171-FCC9-418A-A93D-3CDBAE254A3F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ActivateClassById( 
            [In, MarshalAs(UnmanagedType.LPWStr)] string id,
            IStream pStream,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppv
        );        
    }

#endif

}
