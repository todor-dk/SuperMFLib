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

// This entire file only exists to work around bugs in Media Foundation.  The core problem 
// is that there are some objects in MF that don't correctly support QueryInterface.  In c++ 
// this isn't a problem, since if you tell c++ that something is a pointer to an interface, 
// it just believes you.  In fact, that's one of the places where c++ gets its performance:
// it doesn't check anything.

// In .Net, it checks.  And the way it checks is that every time it receives an interfaces
// from unmanaged code, it does a couple of QI calls on it.  First it does a QI for IUnknown.
// Second it does a QI for the specific interface it is supposed to be (ie IMFMediaSink or
// whatever).

// Since c++ *doesn't* check, oftentimes the first people to even try to call QI on some of 
// MF's objects are c# programmers.  And, not surprisingly, sometimes the first time code is 
// run, it doesn't work correctly.

// The only way you can work around it is to change the definition of the method from 
// IMFMediaSink (or whatever interface MF is trying to pass you) to IntPtr.  Of course, 
// that limits what you can do with it.  You can't call methods on an IntPtr.

// Something to keep in mind is that while the work-around involves changing the interface,
// the problem isn't in the interface, it is in the object that implements the inteface.
// This means that while the inteface may experience problems on one object, it may work
// correctly on another object.  If you are unclear on the differences between an interface
// and an object, it's time to hit the books.

// In W7, MS has fixed a few of these issues that were reported in Vista.  The problem 
// is that even if they are fixed in W7, if your program also needs to run on Vista, you 
// still have to use the work-arounds.

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Security;

using MediaFoundation.Misc;
using MediaFoundation.EVR;

namespace MediaFoundation.Alt
{
#if NOT_IN_USE
    #region Bugs in Vista and W7

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
    internal interface IMFTopologyServiceLookupAlt
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
            [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysInt)] IntPtr[] ppvObjects,
            [In, Out] ref int pnObjects
            );
    }

    #endregion
#endif
}
