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

#if NOT_IN_USE

    // Class to handle Array of Guid
    internal class GMarshaler : ICustomMarshaler
    {
        protected Guid[] m_Obj;
        protected IntPtr m_ip;

        public IntPtr MarshalManagedToNative(object managedObj)
        {
            if (m_ip == IntPtr.Zero)
            {
                // If we are being called first from managed

                m_Obj = (Guid[])managedObj;
                // Freed in CleanUpManagedData
                m_ip = Marshal.AllocCoTaskMem(IntPtr.Size);
            }
            else
            {
                // Return the value to native
                Guid[] mo = (Guid[])managedObj;

                IntPtr ip = Marshal.AllocCoTaskMem(16 * mo.Length);
                Marshal.WriteIntPtr(m_ip, ip);

                for (int x = 0; (mo[x] != Guid.Empty) && (x < mo.Length); x++)
                {
                    Marshal.StructureToPtr(mo[x], ip, false);
                    ip = new IntPtr(ip.ToInt64() + 16);
                }
            }
            return m_ip;
        }

        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            if (m_Obj != null)
            {
                // Return the value to managed
                byte[] b = new byte[16];
                IntPtr pBuff = Marshal.ReadIntPtr(pNativeData);
                for (int x = 0; x < m_Obj.Length; x++)
                {
                    Marshal.Copy(pBuff, b, 0, 16);
                    m_Obj[x] = new Guid(b);

                    pBuff = new IntPtr(pBuff.ToInt64() + 16);
                }

                Marshal.FreeCoTaskMem(Marshal.ReadIntPtr(pNativeData));
            }
            else
            {
                // If we are being called first from native
                m_ip = pNativeData;
                return new Guid[30];
            }

            return null;
        }

        public void CleanUpManagedData(object ManagedObj)
        {
            m_Obj = null;
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
            return new GMarshaler();
        }
    }

#endif
}
