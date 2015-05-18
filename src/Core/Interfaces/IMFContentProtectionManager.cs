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
#if NOT_IN_USE

    /// <summary>
    /// Enables playback of protected content by providing the application with a pointer to a content
    /// enabler object.
    /// <para/>
    /// Applications that play protected content should implement this interface.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/0DBA0384-EAC7-456A-AF9F-86EB944CDB2E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0DBA0384-EAC7-456A-AF9F-86EB944CDB2E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("ACF92459-6A61-42BD-B57C-B43E51203CB0"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFContentProtectionManager
    {
        /// <summary>
        /// Begins an asynchronous request to perform a content enabling action.
        /// <para/>
        /// This method requests the application to perform a specific step needed to acquire rights to the
        /// content, using a content enabler object.
        /// </summary>
        /// <param name="pEnablerActivate">
        /// Pointer to the <see cref="IMFActivate"/> interface of a content enabler object. To create the
        /// content enabler, call <see cref="IMFActivate.ActivateObject"/> and request the 
        /// <see cref="IMFContentEnabler"/> interface. The application should use the methods in <strong>
        /// IMFContentEnabler</strong> to complete the content enabling action. 
        /// </param>
        /// <param name="pTopo">
        /// Pointer to the <see cref="IMFTopology"/> interface of the pending topology. 
        /// </param>
        /// <param name="pCallback">
        /// Pointer to the <see cref="IMFAsyncCallback"/> interface of a callback object. When the operation is
        /// complete, the application should call <see cref="IMFAsyncCallback.Invoke"/> on the callback. 
        /// </param>
        /// <param name="punkState">
        /// Reserved. Currently this parameter is always <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description> The method succeeded. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT BeginEnableContent(
        ///   [in]  IMFActivate *pEnablerActivate,
        ///   [in]  IMFTopology *pTopo,
        ///   [in]  IMFAsyncCallback *pCallback,
        ///   [in]  IUnknown *punkState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2F422135-8E5F-41FB-A709-77636D1B451B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2F422135-8E5F-41FB-A709-77636D1B451B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int BeginEnableContent(
            IMFActivate pEnablerActivate,
            IMFTopology pTopo,
            IMFAsyncCallback pCallback,
            [MarshalAs(UnmanagedType.Interface)] object punkState
            );

        /// <summary>
        /// Ends an asynchronous request to perform a content enabling action. This method is called by the
        /// protected media path (PMP) to complete an asynchronous call to 
        /// <see cref="IMFContentProtectionManager.BeginEnableContent"/>. 
        /// </summary>
        /// <param name="pResult">
        /// Pointer to the <see cref="IMFAsyncResult"/> interface. This pointer is the same value that the
        /// application passed to the caller's <see cref="IMFAsyncCallback.Invoke"/> method. 
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
        /// HRESULT EndEnableContent(
        ///   [in]  IMFAsyncResult *pResult
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/10893A0C-5476-4B7D-AAD7-845A4BA70335(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/10893A0C-5476-4B7D-AAD7-845A4BA70335(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EndEnableContent(
            IMFAsyncResult pResult
            );
    }

#endif
}
