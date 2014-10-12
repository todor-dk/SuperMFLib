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

namespace MediaFoundation.Misc
{
    // These classes are used internally and there is probably no reason you will ever
    // need to use them directly.

    // Used by MFTEnum
    internal class GAMarshaler : ICustomMarshaler
    {
        private ArrayList m_array;
        private MFInt m_int;
        private IntPtr m_MFIntPtr;
        private IntPtr m_ArrayPtr;

        public IntPtr MarshalManagedToNative(object managedObj)
        {
            IntPtr p;

            // We get called twice: Once for the MFInt, and once for the array.
            // Figure out which call this is.
            if (managedObj is MFInt)
            {
                // Save off the object.  We'll need to use Assign() on this later.
                m_int = managedObj as MFInt;

                // Allocate room for the int
                p = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(MFInt)));
                m_MFIntPtr = p;
            }
            else
            {
                // Save off the object.  We'll be calling methods on this in
                // MarshalNativeToManaged.
                m_array = managedObj as ArrayList;

                if (m_array != null)
                {
                    m_array.Clear();
                }

                // All we need is room for the pointer
                p = Marshal.AllocCoTaskMem(IntPtr.Size);

                // Belt-and-suspenders.  Set this to null.
                Marshal.WriteIntPtr(p, IntPtr.Zero);
                m_ArrayPtr = p;
            }

            return p;
        }

        // Called just after invoking the COM method.  The IntPtr is the same one that just got returned
        // from MarshalManagedToNative.  The return value is unused.
        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            // When we are called with pNativeData == m_ArrayPtr, do nothing.  All the
            // work is done when:
            if (pNativeData == m_MFIntPtr)
            {
                // Read the count
                int count = Marshal.ReadInt32(pNativeData);

                // If we have an array to return things in (ie MFTGetInfo wasn't passed
                // nulls)
                if (m_array != null)
                {
                    IntPtr ip2 = Marshal.ReadIntPtr(m_ArrayPtr);

                    // I don't know why this might happen, but it seems worth the check
                    if (ip2 != IntPtr.Zero)
                    {
                        try
                        {
                            int iSize = Marshal.SizeOf(typeof(Guid));
                            // Size the array
                            m_array.Capacity = count;
                            byte[] b = new byte[iSize];

                            // Copy in the values
                            for (int x = 0; x < count; x++)
                            {
                                Marshal.Copy(new IntPtr(ip2.ToInt64() + (x * iSize)), b, 0, iSize);
                                m_array.Add(new Guid(b));
                            }
                        }
                        finally
                        {
                            // Free the array we got back
                            Marshal.FreeCoTaskMem(ip2);
                        }
                    }
                }

                // Don't forget to assign the value
                m_int.Assign(count);

                m_array = null;
                m_int = null;
            }

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
            return new GAMarshaler();
        }
    }
}
