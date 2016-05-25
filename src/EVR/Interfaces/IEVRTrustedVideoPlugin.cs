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
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Enables a plug-in component for the enhanced video renderer (EVR) to work with protected media.
    /// <para/>
    /// To work in the protected media path (PMP), a custom EVR mixer or presenter must implement this
    /// interface. The EVR obtains a pointer to this interface by calling <strong>QueryInterface</strong>
    /// on the plug-in component. 
    /// <para/>
    /// This interface is required only if the plug-in is a trusted component, designed to work in the PMP.
    /// It is not required for playing clear content in an unprotected process.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/1DCAA01C-2596-4A22-9E2A-7F0E26D58FFE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1DCAA01C-2596-4A22-9E2A-7F0E26D58FFE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("83A4CE40-7710-494b-A893-A472049AF630")]
    internal interface IEVRTrustedVideoPlugin
    {
        /// <summary>
        /// Queries whether the plug-in has any transient vulnerabilities at this time. 
        /// </summary>
        /// <param name="pYes">
        /// Receives a Boolean value. If <strong>TRUE</strong>, the plug-in has no transient vulnerabilities at
        /// the moment and can receive protected content. If <strong>FALSE</strong>, the plug-in has a
        /// transient vulnerability. If the method fails, the EVR treats the value as <strong>FALSE</strong>
        /// (untrusted). 
        /// </param>
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
        /// HRESULT IsInTrustedVideoMode(
        ///   [out]  BOOL *pYes
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/43242898-4812-4FAA-8E0A-6E60455C9F3B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/43242898-4812-4FAA-8E0A-6E60455C9F3B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int IsInTrustedVideoMode(
            [MarshalAs(UnmanagedType.Bool)] out bool pYes
            );

        /// <summary>
        /// Queries whether the plug-in can limit the effective video resolution. 
        /// </summary>
        /// <param name="pYes">
        /// Receives a Boolean value. If <strong>TRUE</strong>, the plug-in can limit the effective video
        /// resolution. Otherwise, the plug-in cannot limit the video resolution. If the method fails, the EVR
        /// treats the value as <strong>FALSE</strong> (not supported). 
        /// </param>
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
        /// HRESULT CanConstrict(
        ///   [out]  BOOL *pYes
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/16BB31C3-51F7-4D9B-946C-F366FB6E5DEE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/16BB31C3-51F7-4D9B-946C-F366FB6E5DEE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CanConstrict(
            [MarshalAs(UnmanagedType.Bool)] out bool pYes
            );

        /// <summary>
        /// Limits the effective video resolution. 
        /// </summary>
        /// <param name="dwKPix">
        /// Maximum number of source pixels that may appear in the final video image, in thousands of pixels.
        /// If the value is zero, the video is disabled. If the value is MAXDWORD (0xFFFFFFFF), video
        /// constriction is removed and the video may be rendered at full resolution.
        /// </param>
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
        /// HRESULT SetConstriction(
        ///   [in]  DWORD dwKPix
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F2E9B199-969F-453C-8714-FA85C89A191A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F2E9B199-969F-453C-8714-FA85C89A191A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetConstriction(
            int dwKPix
            );

        /// <summary>
        /// Enables or disables the ability of the plug-in to export the video image. 
        /// </summary>
        /// <param name="bDisable">
        /// Boolean value. Specify <strong>TRUE</strong> to disable image exporting, or <strong>FALSE</strong>
        /// to enable it. 
        /// </param>
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
        /// HRESULT DisableImageExport(
        ///   [in]  BOOL bDisable
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DD9811F7-7A9F-4B7E-8425-CB25EFE0A71D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DD9811F7-7A9F-4B7E-8425-CB25EFE0A71D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int DisableImageExport(
            [MarshalAs(UnmanagedType.Bool)] bool bDisable
            );
    }

#endif

}
