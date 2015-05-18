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

namespace MediaFoundation.Core.Interfaces
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Creates an instance of the Media Engine.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/8E4E84A0-BCFC-4CBF-813B-4FEE2B42A83E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8E4E84A0-BCFC-4CBF-813B-4FEE2B42A83E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("4D645ACE-26AA-4688-9BE1-DF3516990B93"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFMediaEngineClassFactory
    {
        /// <summary>
        /// Creates a new instance of the Media Engine.
        /// </summary>
        /// <param name="dwFlags">
        /// A bitwise <strong>OR</strong> of zero or more flags from the 
        /// <see cref="MF_MEDIA_ENGINE_CREATEFLAGS"/> enumeration. 
        /// </param>
        /// <param name="pAttr">
        /// A pointer to the <see cref="IMFAttributes"/> interface of an attribute store. 
        /// <para/>
        /// This parameter specifies configuration attributes for the Media Engine. Call 
        /// <see cref="MFExtern.MFCreateAttributes"/> to create the attribute store. Then, set one or more
        /// attributes from the list of <c>Media Engine Attributes</c>. For details, see Remarks. 
        /// </param>
        /// <param name="ppPlayer">
        /// Receives a pointer to the <see cref="IMFMediaEngine"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>A required attribute was missing from <em>pAttr</em>, or an invalid combination of attributes was used. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT CreateInstance(
        ///   [in]   DWORD dwFlags,
        ///   [in]   IMFAttributes *pAttr,
        ///   [out]  IMFMediaEngine **ppPlayer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EDEAD2C4-5695-4E63-9E9E-B09D75B60B7F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EDEAD2C4-5695-4E63-9E9E-B09D75B60B7F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateInstance(
            MF_MEDIA_ENGINE_CREATEFLAGS dwFlags,
            IMFAttributes pAttr,
            out IMFMediaEngine ppPlayer
            );

        /// <summary>
        /// Creates a time range object.
        /// </summary>
        /// <param name="ppTimeRange">
        /// Receives a pointer to the <see cref="IMFMediaTimeRange"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT CreateTimeRange(
        ///   [out]  IMFMediaTimeRange **ppTimeRange
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/293769E8-8C8A-40D1-AF51-1DBB773F88D5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/293769E8-8C8A-40D1-AF51-1DBB773F88D5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateTimeRange(
            out IMFMediaTimeRange ppTimeRange
            );

        /// <summary>
        /// Creates a media error object.
        /// </summary>
        /// <param name="ppError">
        /// Receives a pointer to the <see cref="IMFMediaError"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT CreateError(
        ///   [out]  IMFMediaError **ppError
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C089473D-CD35-4F5D-8C78-EDE0FA8C13EB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C089473D-CD35-4F5D-8C78-EDE0FA8C13EB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateError(
            out IMFMediaError ppError
            );
    }

#endif

}
