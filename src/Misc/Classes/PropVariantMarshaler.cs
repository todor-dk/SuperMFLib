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
    // Class to release PropVariants on parameters that output PropVariants.  There
    // should be no reason for code to call this class directly.  It is invoked
    // automatically when the appropriate methods are called.
    internal class PropVariantMarshaler : ICustomMarshaler
    {
        public static readonly System.Collections.Generic.List<DebugInfo> DebugInfos = new System.Collections.Generic.List<DebugInfo>();

        public static void AddDebug(PropVariantMarshaler self, object obj, string op, IntPtr info)
        {
            lock (SyncLock)
            {
                DebugInfos.Add(new DebugInfo()
                {
                    ObjectId = (obj == null) ? 0 : obj.GetHashCode(),
                    MarshlerId = self.GetHashCode(),
                    Operation = op,
                    ThreadId = System.Threading.Thread.CurrentThread.ManagedThreadId,
                    Info = info
                });
            }
        }

        private static readonly object SyncLock = new object();

        public struct DebugInfo
        {
            public int ObjectId;
            public int MarshlerId;
            public string Operation;
            public int ThreadId;
            public IntPtr Info;
        }

        // The managed object passed in to MarshalManagedToNative
        protected PropVariant m_prop;

        public IntPtr MarshalManagedToNative(object managedObj)
        {
            IntPtr p;

            AddDebug(this, this.m_prop, "MarshalManagedToNative", (IntPtr)((managedObj == null) ? 0 : managedObj.GetHashCode()));

            // Cast the object back to a PropVariant
            this.m_prop = managedObj as PropVariant;

            if (this.m_prop != null)
            {
                // Release any memory currently allocated
                this.m_prop.Clear();

                // Create an appropriately sized buffer, blank it, and send it to
                // the marshaler to make the COM call with.
                int iSize = this.GetNativeDataSize();
                p = Marshal.AllocCoTaskMem(iSize);

                if (IntPtr.Size == 4)
                {
                    Marshal.WriteInt64(p, 0);
                    Marshal.WriteInt64(p, 8, 0);
                }
                else
                {
                    Marshal.WriteInt64(p, 0);
                    Marshal.WriteInt64(p, 8, 0);
                    Marshal.WriteInt64(p, 16, 0);
                }
            }
            else
            {
                p = IntPtr.Zero;
            }

            return p;
        }

        // Called just after invoking the COM method.  The IntPtr is the same one that just got returned
        // from MarshalManagedToNative.  The return value is unused.
        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            AddDebug(this, this.m_prop, "MarshalNativeToManaged", pNativeData);

            Marshal.PtrToStructure(pNativeData, this.m_prop);
            this.m_prop = null;

            return this.m_prop;
        }

        public void CleanUpManagedData(object managedObj)
        {
            AddDebug(this, this.m_prop, "CleanUpManagedData", (IntPtr)((managedObj == null) ? 0 : managedObj.GetHashCode()));
            this.m_prop = null;
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
            AddDebug(this, this.m_prop, "CleanUpNativeData", pNativeData);
            Marshal.FreeCoTaskMem(pNativeData);
        }

        // The number of bytes to marshal out
        public int GetNativeDataSize()
        {
            AddDebug(this, this.m_prop, "GetNativeDataSize", IntPtr.Zero);
            return Marshal.SizeOf(typeof(PropVariant));
        }

        // This method is called by interop to create the custom marshaler.  The (optional)
        // cookie is the value specified in MarshalCookie="asdf", or "" is none is specified.
        public static ICustomMarshaler GetInstance(string cookie)
        {
            return new PropVariantMarshaler();
        }
    }
}
