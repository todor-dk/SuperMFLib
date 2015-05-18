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

namespace MediaFoundation.EVR.Interfaces
{
#if NOT_IN_USE

    /// <summary>
    /// Enables a custom video mixer or video presenter to get interface pointers from the 
    /// <c>Enhanced Video Renderer</c> (EVR). The mixer can also use this interface to get interface
    /// pointers from the presenter, and the presenter can use it to get interface pointers from the mixer.
    /// <para/>
    /// To use this interface, implement the <see cref="EVR.IMFTopologyServiceLookupClient"/> interface on
    /// your custom mixer or presenter. The EVR calls 
    /// <see cref="EVR.IMFTopologyServiceLookupClient.InitServicePointers"/> with a pointer to the EVR's 
    /// <strong>IMFTopologyServiceLookup</strong> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A912C17A-40EF-441C-BFC9-7EF49D22070F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A912C17A-40EF-441C-BFC9-7EF49D22070F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("FA993889-4383-415A-A930-DD472A8CF6F7"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFTopologyServiceLookup
    {
        /// <summary>
        /// Retrieves an interface from the enhanced video renderer (EVR), or from the video mixer or video
        /// presenter.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="dwIndex">
        /// Reserved, must be zero.
        /// </param>
        /// <param name="guidService">
        /// Service GUID of the requested interface.
        /// </param>
        /// <param name="riid">
        /// Interface identifier of the requested interface.
        /// </param>
        /// <param name="ppvObjects">
        /// Array of interface pointers. If the method succeeds, each member of the array contains either a
        /// valid interface pointer or <strong>NULL</strong>. The caller must release the interface pointers
        /// when the EVR calls <see cref="EVR.IMFTopologyServiceLookupClient.ReleaseServicePointers"/> (or
        /// earlier). If the method fails, every member of the array is <strong>NULL</strong>. 
        /// </param>
        /// <param name="pnObjects">
        /// Pointer to a value that specifies the size of the <em>ppvObjects</em> array. The value must be at
        /// least 1. In the current implementation, there is no reason to specify an array size larger than one
        /// element. The value is not changed on output. 
        /// </param>
        /// <returns>
        /// The method returns an HRESULT. Possible values include, but are not limited to, those in the
        /// following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>Invalid argument.</description></item>
        /// <item><term><strong>E_NOINTERFACE</strong></term><description>The requested interface is not available.</description></item>
        /// <item><term><strong>MF_E_NOTACCEPTING</strong></term><description>The method was not called from inside the <see cref="EVR.IMFTopologyServiceLookupClient.InitServicePointers"/> method. See Remarks. </description></item>
        /// <item><term><strong>MF_E_UNSUPPORTED_SERVICE</strong></term><description>The object does not support the specified service GUID.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT LookupService(
        ///   [in]       MF_SERVICE_LOOKUP_TYPE Type,
        ///   [in]       DWORD dwIndex,
        ///   [in]       REFGUID guidService,
        ///   [in]       REFIID riid,
        ///   [out]      LPVOID *ppvObjects,
        ///   [in, out]  DWORD *pnObjects
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BA0DBFDF-1BAB-42BA-910F-04A3F37BE955(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BA0DBFDF-1BAB-42BA-910F-04A3F37BE955(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int LookupService(
            [In] MFServiceLookupType type,
            [In] int dwIndex,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidService,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface), Out] object[] ppvObjects,
            [In, Out] ref int pnObjects
            );
    }

#endif
}
