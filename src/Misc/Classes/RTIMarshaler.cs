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
#if NOT_IN_USE
    // These classes are used internally and there is probably no reason you will ever
    // need to use them directly.

    // Used by MFTGetInfo
    internal class RTIMarshaler : ICustomMarshaler
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
                            int iSize = Marshal.SizeOf(typeof(MFTRegisterTypeInfo));

                            // Size the array
                            m_array.Capacity = count;

                            // Copy in the values
                            for (int x = 0; x < count; x++)
                            {
                                MFTRegisterTypeInfo rti = new MFTRegisterTypeInfo();
                                Marshal.PtrToStructure(new IntPtr(ip2.ToInt64() + (x * iSize)), rti);
                                m_array.Add(rti);
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

                m_int = null;
                m_array = null;
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

        // When used with MFTGetInfo, there are 2 parameter pairs (ppInputTypes + pcInputTypes,
        // ppOutputTypes + pcOutputTypes).  Each need their own instance
        static RTIMarshaler[] s_rti = new RTIMarshaler[2];

        // This method is called by interop to create the custom marshaler.  The (optional)
        // cookie is the value specified in MarshalCookie="asdf", or "" is none is specified.
        public static ICustomMarshaler GetInstance(string cookie)
        {
            // Probably not an issue, but just to be safe
            lock (s_rti)
            {
                if (s_rti[0] == null)
                {
                    s_rti[0] = new RTIMarshaler();
                    s_rti[1] = new RTIMarshaler();
                }
            }

            int i = Convert.ToInt32(cookie);
            return s_rti[i];
        }
    }

#endif
}
