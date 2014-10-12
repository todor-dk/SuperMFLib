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


    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("5BC8A76B-869A-46A3-9B03-FA218A66AEBE")]
    public interface IMFCollection
    {
        [PreserveSig]
        int GetElementCount(
            out int pcElements
            );

        [PreserveSig]
        int GetElement(
            [In] int dwElementIndex,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppUnkElement
            );

        [PreserveSig]
        int AddElement(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnkElement
            );

        [PreserveSig]
        int RemoveElement(
            [In] int dwElementIndex,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppUnkElement
            );

        [PreserveSig]
        int InsertElementAt(
            [In] int dwIndex,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnknown
            );

        [PreserveSig]
        int RemoveAllElements();
    }

}
