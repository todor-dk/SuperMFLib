﻿#region license

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
using System.Collections;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

using MediaFoundation.Misc;
using MediaFoundation.Transform;

namespace MediaFoundation.Misc.Classes
{
#if NOT_IN_USE

    // These classes are used internally and there is probably no reason you will ever
    // need to use them directly.

    // Used by MFTRegister
    internal class RTAMarshaler : ICustomMarshaler
    {
        public IntPtr MarshalManagedToNative(object managedObj)
        {
            IntPtr p;

            int iSize = Marshal.SizeOf(typeof(MFTRegisterTypeInfo));

            // Save off the object.  We'll be calling methods on this in
            // MarshalNativeToManaged.
            MFTRegisterTypeInfo[] array = managedObj as MFTRegisterTypeInfo[];

            // All we need is room for the pointer
            p = Marshal.AllocCoTaskMem(array.Length * iSize);

            for (int x = 0; x < array.Length; x++)
            {
                Marshal.StructureToPtr(array[x], new IntPtr(p.ToInt64() + (x * iSize)), false);
            }

            return p;
        }

        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            // This value isn't actually used
            return null;
        }

        public void CleanUpManagedData(object ManagedObj)
        {
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
            Marshal.FreeCoTaskMem(pNativeData);
        }

        // The number of bytes to marshal out
        public int GetNativeDataSize()
        {
            return -1;
        }

        // This method is called by interop to create the custom marshaler.  The (optional)
        // cookie is the value specified in MarshalCookie="asdf", or "" is none is specified.
        public static ICustomMarshaler GetInstance(string cookie)
        {
            return new RTAMarshaler();
        }
    }

#endif
}
