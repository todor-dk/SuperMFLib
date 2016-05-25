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
    // These classes are used internally and there is probably no reason you will ever
    // need to use them directly.

    // Class to handle BITMAPINFO
    internal class BMMarshaler : ICustomMarshaler
    {
        protected BitmapInfoHeader m_bmi;

        public IntPtr MarshalManagedToNative(object managedObj)
        {
            this.m_bmi = managedObj as BitmapInfoHeader;

            IntPtr ip = this.m_bmi.GetPtr();

            return ip;
        }

        // Called just after invoking the COM method.  The IntPtr is the same one that just got returned
        // from MarshalManagedToNative.  The return value is unused.
        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            BitmapInfoHeader bmi = BitmapInfoHeader.PtrToBMI(pNativeData);

            // If we this call is In+Out, the return value is ignored.  If
            // this is out, then m_bmi will be null.
            if (this.m_bmi != null)
            {
                this.m_bmi.CopyFrom(bmi);
                bmi = null;
            }

            return bmi;
        }

        public void CleanUpManagedData(object ManagedObj)
        {
            this.m_bmi = null;
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
            Marshal.FreeCoTaskMem(pNativeData);
        }

        // The number of bytes to marshal out - never called
        public int GetNativeDataSize()
        {
            return -1;
        }

        // This method is called by interop to create the custom marshaler.  The (optional)
        // cookie is the value specified in MarshalCookie="asdf", or "" is none is specified.
        public static ICustomMarshaler GetInstance(string cookie)
        {
            return new BMMarshaler();
        }
    }
}
