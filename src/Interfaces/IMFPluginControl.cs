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

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Controls how media sources and transforms are enumerated in Microsoft Media Foundation.
    /// <para/>
    /// To get a pointer to this interface, call <see cref="MFExtern.MFGetPluginControl"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/CDC6FD4F-C544-43BB-BA99-5468EF49949D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CDC6FD4F-C544-43BB-BA99-5468EF49949D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("5C6C44BF-1DB6-435B-9249-E8CD10FDEC96")]
    public interface IMFPluginControl
    {
        [PreserveSig]
        int GetPreferredClsid(
            MFPluginType pluginType,
            [MarshalAs(UnmanagedType.LPWStr)] string selector,
            out Guid clsid
        );

        [PreserveSig]
        int GetPreferredClsidByIndex(
            MFPluginType pluginType,
            int index,
            [MarshalAs(UnmanagedType.LPWStr)] out string selector,
            out Guid clsid
        );

        [PreserveSig]
        int SetPreferredClsid(
            MFPluginType pluginType,
            [MarshalAs(UnmanagedType.LPWStr)] string selector,
            [MarshalAs(UnmanagedType.LPStruct)] MFGuid clsid
        );

        [PreserveSig]
        int IsDisabled(
            MFPluginType pluginType,
            [MarshalAs(UnmanagedType.LPStruct)] Guid clsid
        );

        [PreserveSig]
        int GetDisabledByIndex(
            MFPluginType pluginType,
            int index,
            out Guid clsid
        );

        [PreserveSig]
        int SetDisabled(
            MFPluginType pluginType,
            [MarshalAs(UnmanagedType.LPStruct)] Guid clsid,
            [MarshalAs(UnmanagedType.Bool)] bool disabled
        );
    }

#endif

}
