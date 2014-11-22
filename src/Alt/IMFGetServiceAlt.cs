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
    #region "Limitation of .Net"

    // When I originally added IMFGetService to this file, it was my intent that p3 should be
    //
    //    [MarshalAs(UnmanagedType.Interface)] out object ppvObject
    //
    // However, that isn't possible due to limitations in .Net.  If the MarshalAs is Interface (aka IUnknown)
    // the pointer that the caller gets *isn't* a pointer to the interface requested in the riid, it's a pointer to an
    // IUnknown, which is a different value.  While (in theory) the caller could QI the returned pointer for the desired
    // interface, why should they?  They already called a function specifying what interface they wanted.  It is not
    // unreasonable for them to expect that that's what they got.
    //
    // Were I starting from scratch, I would name this interface IMFGetServiceImpl, indicating that you should use this 
    // interface (with the IntPtr) if you are implementing IMFGetService, while still having IMFGetService (with 
    // UnmanagedType.IUnknown) for the people who just want to call it.

    /// <summary>
    /// Queries an object for a specified service interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/102A1DFF-8419-4F86-A145-53CE3D0123F5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/102A1DFF-8419-4F86-A145-53CE3D0123F5(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("FA993888-4383-415A-A930-DD472A8CF6F7")]
    public interface IMFGetServiceAlt
    {
        /// <summary>
        /// Retrieves a service interface.
        /// </summary>
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
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_UNSUPPORTED_SERVICE</strong></term><description>The object does not support the service.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetService(
        ///   [in]   REFGUID guidService,
        ///   [in]   REFIID riid,
        ///   [out]  LPVOID *ppvObject
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4287DD1F-1718-4231-BC62-B58E0E61D688(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4287DD1F-1718-4231-BC62-B58E0E61D688(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetService(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidService,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            out IntPtr ppvObject
            );
    }

    #endregion
}
