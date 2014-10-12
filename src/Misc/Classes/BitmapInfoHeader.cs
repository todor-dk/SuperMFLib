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


    [StructLayout(LayoutKind.Sequential, Pack = 4), UnmanagedName("BITMAPINFOHEADER")]
    public class BitmapInfoHeader
    {
        public int Size;
        public int Width;
        public int Height;
        public short Planes;
        public short BitCount;
        public int Compression;
        public int ImageSize;
        public int XPelsPerMeter;
        public int YPelsPerMeter;
        public int ClrUsed;
        public int ClrImportant;

        public IntPtr GetPtr()
        {
            IntPtr ip;

            // See what kind of BitmapInfoHeader object we've got
            if (this is BitmapInfoHeaderWithData)
            {
                int iBitmapInfoHeaderSize = Marshal.SizeOf(typeof(BitmapInfoHeader));

                // BitmapInfoHeaderWithData - Have to copy the array too
                BitmapInfoHeaderWithData pData = this as BitmapInfoHeaderWithData;

                // Account for copying the array.  This may result in us allocating more bytes than we
                // need (if cbSize < IntPtr.Size), but it prevents us from overrunning the buffer.
                int iUseSize = Math.Max(pData.bmiColors.Length * 4, IntPtr.Size);

                ip = Marshal.AllocCoTaskMem(iBitmapInfoHeaderSize + iUseSize);

                Marshal.StructureToPtr(pData, ip, false);

                IntPtr ip2 = new IntPtr(ip.ToInt64() + iBitmapInfoHeaderSize);
                Marshal.Copy(pData.bmiColors, 0, ip2, pData.bmiColors.Length);
            }
            else if (this is BitmapInfoHeader)
            {
                int iBitmapInfoHeaderSize = Marshal.SizeOf(typeof(BitmapInfoHeader));

                // BitmapInfoHeader - just do a copy
                ip = Marshal.AllocCoTaskMem(iBitmapInfoHeaderSize);
                Marshal.StructureToPtr(this as BitmapInfoHeader, ip, false);
            }
            else
            {
                Debug.Assert(false, "Shouldn't ever get here");
                ip = IntPtr.Zero;
            }

            return ip;
        }

        public static BitmapInfoHeader PtrToBMI(IntPtr pNativeData)
        {
            int iEntries;
            int biCompression;
            int biClrUsed;
            int biBitCount;

            biBitCount = Marshal.ReadInt16(pNativeData, 14);
            biCompression = Marshal.ReadInt32(pNativeData, 16);
            biClrUsed = Marshal.ReadInt32(pNativeData, 32);

            if (biCompression == 3) // BI_BITFIELDS
            {
                iEntries = 3;
            }
            else if (biClrUsed > 0)
            {
                iEntries = biClrUsed;
            }
            else if (biBitCount <= 8)
            {
                iEntries = 1 << biBitCount;
            }
            else
            {
                iEntries = 0;
            }

            BitmapInfoHeader bmi;

            if (iEntries == 0)
            {
                // Create a simple BitmapInfoHeader struct
                bmi = new BitmapInfoHeader();
                Marshal.PtrToStructure(pNativeData, bmi);
            }
            else
            {
                BitmapInfoHeaderWithData ext = new BitmapInfoHeaderWithData();

                ext.Size = Marshal.ReadInt32(pNativeData, 0);
                ext.Width = Marshal.ReadInt32(pNativeData, 4);
                ext.Height = Marshal.ReadInt32(pNativeData, 8);
                ext.Planes = Marshal.ReadInt16(pNativeData, 12);
                ext.BitCount = Marshal.ReadInt16(pNativeData, 14);
                ext.Compression = Marshal.ReadInt32(pNativeData, 16);
                ext.ImageSize = Marshal.ReadInt32(pNativeData, 20);
                ext.XPelsPerMeter = Marshal.ReadInt32(pNativeData, 24);
                ext.YPelsPerMeter = Marshal.ReadInt32(pNativeData, 28);
                ext.ClrUsed = Marshal.ReadInt32(pNativeData, 32);
                ext.ClrImportant = Marshal.ReadInt32(pNativeData, 36);

                bmi = ext as BitmapInfoHeader;

                ext.bmiColors = new int[iEntries];
                IntPtr ip2 = new IntPtr(pNativeData.ToInt64() + Marshal.SizeOf(typeof(BitmapInfoHeader)));
                Marshal.Copy(ip2, ext.bmiColors, 0, iEntries);
            }

            return bmi;
        }

        public void CopyFrom(BitmapInfoHeader bmi)
        {
            Size = bmi.Size;
            Width = bmi.Width;
            Height = bmi.Height;
            Planes = bmi.Planes;
            BitCount = bmi.BitCount;
            Compression = bmi.Compression;
            ImageSize = bmi.ImageSize;
            YPelsPerMeter = bmi.YPelsPerMeter;
            ClrUsed = bmi.ClrUsed;
            ClrImportant = bmi.ClrImportant;

            if (bmi is BitmapInfoHeaderWithData)
            {
                BitmapInfoHeaderWithData ext = this as BitmapInfoHeaderWithData;
                BitmapInfoHeaderWithData ext2 = bmi as BitmapInfoHeaderWithData;

                ext.bmiColors = new int[ext2.bmiColors.Length];
                ext2.bmiColors.CopyTo(ext.bmiColors, 0);
            }
        }
    }

}
