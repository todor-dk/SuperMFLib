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

    /// <summary>
    /// The <strong>BITMAPINFOHEADER</strong> structure contains information about the dimensions and color
    /// format of a DIB. 
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct tagBITMAPINFOHEADER {
    ///   DWORD biSize;
    ///   LONG  biWidth;
    ///   LONG  biHeight;
    ///   WORD  biPlanes;
    ///   WORD  biBitCount;
    ///   DWORD biCompression;
    ///   DWORD biSizeImage;
    ///   LONG  biXPelsPerMeter;
    ///   LONG  biYPelsPerMeter;
    ///   DWORD biClrUsed;
    ///   DWORD biClrImportant;
    /// } BITMAPINFOHEADER, *PBITMAPINFOHEADER;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/02F8ED65-8FED-4DDA-9B94-7343A0CFA8C1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/02F8ED65-8FED-4DDA-9B94-7343A0CFA8C1(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 4), UnmanagedName("BITMAPINFOHEADER")]
    internal class  BitmapInfoHeader
    {
        /// <summary>
        /// The number of bytes required by the structure.
        /// </summary>
        public int Size;
        /// <summary>
        /// The width of the bitmap, in pixels.
        /// <para/>
        /// If <strong>Compression</strong> is BI_JPEG or BI_PNG, the <strong>biWidth</strong> member
        /// specifies the width of the decompressed JPEG or PNG image file, respectively. 
        /// </summary>
        public int Width;
        /// <summary>
        /// The height of the bitmap, in pixels. If <strong>Height</strong> is positive, the bitmap is a
        /// bottom-up DIB and its origin is the lower-left corner. If <strong>biHeight</strong> is negative,
        /// the bitmap is a top-down DIB and its origin is the upper-left corner. 
        /// <para/>
        /// If <strong>Height</strong> is negative, indicating a top-down DIB, <strong>biCompression</strong>
        /// must be either BI_RGB or BI_BITFIELDS. Top-down DIBs cannot be compressed. 
        /// <para/>
        /// If <strong>Compression</strong> is BI_JPEG or BI_PNG, the <strong>Height</strong> member
        /// specifies the height of the decompressed JPEG or PNG image file, respectively. 
        /// </summary>
        public int Height;
        /// <summary>
        /// The number of planes for the target device. This value must be set to 1.
        /// </summary>
        public short Planes;
        /// <summary>
        /// The number of bits-per-pixel. The <strong>BitCount</strong> member of the <strong>
        /// BITMAPINFOHEADER</strong> structure determines the number of bits that define each pixel and the
        /// maximum number of colors in the bitmap. This member must be one of the following values. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>0</term><description> The number of bits-per-pixel is specified or is implied by the JPEG or PNG format.</description></item>
        /// <item><term>1</term><description>The bitmap is monochrome, and the <strong>bmiColors</strong> member of <see cref="Misc.BitmapInfoHeaderWithData"/> contains two entries. Each bit in the bitmap array represents a pixel. If the bit is clear, the pixel is displayed with the color of the first entry in the <strong>bmiColors</strong> table; if the bit is set, the pixel has the color of the second entry in the table. </description></item>
        /// <item><term>4</term><description>The bitmap has a maximum of 16 colors, and the <strong>bmiColors</strong> member of <see cref="Misc.BitmapInfoHeaderWithData"/> contains up to 16 entries. Each pixel in the bitmap is represented by a 4-bit index into the color table. For example, if the first byte in the bitmap is 0x1F, the byte represents two pixels. The first pixel contains the color in the second table entry, and the second pixel contains the color in the sixteenth table entry. </description></item>
        /// <item><term>8</term><description>The bitmap has a maximum of 256 colors, and the <strong>bmiColors</strong> member of <see cref="Misc.BitmapInfoHeaderWithData"/> contains up to 256 entries. In this case, each byte in the array represents a single pixel. </description></item>
        /// <item><term>16</term><description>The bitmap has a maximum of 2^16 colors. If the <strong>Compression</strong> member of the <strong>BITMAPINFOHEADER</strong> is BI_RGB, the <strong>bmiColors</strong> member of <see cref="Misc.BitmapInfoHeaderWithData"/> is <strong>NULL</strong>. Each <strong>WORD</strong> in the bitmap array represents a single pixel. The relative intensities of red, green, and blue are represented with five bits for each color component. The value for blue is in the least significant five bits, followed by five bits each for green and red. The most significant bit is not used. The <strong>bmiColors</strong> color table is used for optimizing colors used on palette-based devices, and must contain the number of entries specified by the <strong>biClrUsed</strong> member of the <strong>BITMAPINFOHEADER</strong>. If the <strong>biCompression</strong> member of the <strong>BITMAPINFOHEADER</strong> is BI_BITFIELDS, the <strong>bmiColors</strong> member contains three <strong>DWORD</strong> color masks that specify the red, green, and blue components, respectively, of each pixel. Each <strong>WORD</strong> in the bitmap array represents a single pixel.  When the <strong>biCompression</strong> member is BI_BITFIELDS, bits set in each <strong>DWORD</strong> mask must be contiguous and should not overlap the bits of another mask. All the bits in the pixel do not have to be used. </description></item>
        /// <item><term>24</term><description>The bitmap has a maximum of 2^24 colors, and the <strong>bmiColors</strong> member of <see cref="Misc.BitmapInfoHeaderWithData"/> is <strong>NULL</strong>. Each 3-byte triplet in the bitmap array represents the relative intensities of blue, green, and red, respectively, for a pixel. The <strong>bmiColors</strong> color table is used for optimizing colors used on palette-based devices, and must contain the number of entries specified by the <strong>biClrUsed</strong> member of the <strong>BITMAPINFOHEADER</strong>. </description></item>
        /// <item><term>32</term><description>The bitmap has a maximum of 2^32 colors. If the <strong>Compression</strong> member of the <strong>BITMAPINFOHEADER</strong> is BI_RGB, the <strong>bmiColors</strong> member of <see cref="Misc.BitmapInfoHeaderWithData"/> is <strong>NULL</strong>. Each <strong>DWORD</strong> in the bitmap array represents the relative intensities of blue, green, and red for a pixel. The value for blue is in the least significant 8 bits, followed by 8 bits each for green and red. The high byte in each <strong>DWORD</strong> is not used. The <strong>bmiColors</strong> color table is used for optimizing colors used on palette-based devices, and must contain the number of entries specified by the <strong>biClrUsed</strong> member of the <strong>BITMAPINFOHEADER</strong>. If the <strong>biCompression</strong> member of the <strong>BITMAPINFOHEADER</strong> is BI_BITFIELDS, the <strong>bmiColors</strong> member contains three <strong>DWORD</strong> color masks that specify the red, green, and blue components, respectively, of each pixel. Each <strong>DWORD</strong> in the bitmap array represents a single pixel.  When the <strong>biCompression</strong> member is BI_BITFIELDS, bits set in each <strong>DWORD</strong> mask must be contiguous and should not overlap the bits of another mask. All the bits in the pixel do not need to be used. </description></item>
        /// </list>
        /// </summary>
        public short BitCount;
        /// <summary>
        /// The type of compression for a compressed bottom-up bitmap (top-down DIBs cannot be compressed).
        /// This member can be one of the following values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term>BI_RGB</term><description>An uncompressed format.</description></item>
        /// <item><term>BI_RLE8</term><description>A run-length encoded (RLE) format for bitmaps with 8 bpp. The compression format is a 2-byte format consisting of a count byte followed by a byte containing a color index. For more information, see <c>Bitmap Compression</c>. </description></item>
        /// <item><term>BI_RLE4</term><description>An RLE format for bitmaps with 4 bpp. The compression format is a 2-byte format consisting of a count byte followed by two word-length color indexes. For more information, see <c>Bitmap Compression</c>. </description></item>
        /// <item><term>BI_BITFIELDS</term><description>Specifies that the bitmap is not compressed and that the color table consists of three <strong>DWORD</strong> color masks that specify the red, green, and blue components, respectively, of each pixel. This is valid when used with 16- and 32-bpp bitmaps. </description></item>
        /// <item><term>BI_JPEG</term><description> Indicates that the image is a JPEG image.</description></item>
        /// <item><term>BI_PNG</term><description> Indicates that the image is a PNG image.</description></item>
        /// </list>
        /// </summary>
        public int Compression;
        /// <summary>
        /// The size, in bytes, of the image. This may be set to zero for BI_RGB bitmaps.
        /// <para/>
        /// If <strong>Compression</strong> is BI_JPEG or BI_PNG, <strong>ImageSize</strong> indicates the
        /// size of the JPEG or PNG image buffer, respectively. 
        /// </summary>
        public int ImageSize;
        /// <summary>
        /// The horizontal resolution, in pixels-per-meter, of the target device for the bitmap. An application
        /// can use this value to select a bitmap from a resource group that best matches the characteristics
        /// of the current device.
        /// </summary>
        public int XPelsPerMeter;
        /// <summary>
        /// The vertical resolution, in pixels-per-meter, of the target device for the bitmap.
        /// </summary>
        public int YPelsPerMeter;
        /// <summary>
        /// The number of color indexes in the color table that are actually used by the bitmap. If this value
        /// is zero, the bitmap uses the maximum number of colors corresponding to the value of the <strong>
        /// BitCount</strong> member for the compression mode specified by <strong>Compression</strong>. 
        /// <para/>
        /// If <strong>ClrUsed</strong> is nonzero and the <strong>BitCount</strong> member is less than
        /// 16, the <strong>ClrUsed</strong> member specifies the actual number of colors the graphics engine
        /// or device driver accesses. If <strong>BitCount</strong> is 16 or greater, the <strong>ClrUsed
        /// </strong> member specifies the size of the color table used to optimize performance of the system
        /// color palettes. If <strong>BitCount</strong> equals 16 or 32, the optimal color palette starts
        /// immediately following the three <strong>DWORD</strong> masks. 
        /// <para/>
        /// When the bitmap array immediately follows the <see cref="Misc.BitmapInfoHeaderWithData"/>
        /// structure, it is a packed bitmap. Packed bitmaps are referenced by a single pointer. Packed bitmaps
        /// require that the <strong>ClrUsed</strong> member must be either zero or the actual size of the
        /// color table. 
        /// </summary>
        public int ClrUsed;
        /// <summary>
        /// The number of color indexes that are required for displaying the bitmap. If this value is zero, all
        /// colors are required.
        /// </summary>
        public int ClrImportant;

        /// <summary>
        /// Gets the PTR.
        /// </summary>
        /// <returns>IntPtr.</returns>
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

        /// <summary>
        /// PTRs to bmi.
        /// </summary>
        /// <param name="pNativeData">The p native data.</param>
        /// <returns>BitmapInfoHeader.</returns>
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

        /// <summary>
        /// Copies from.
        /// </summary>
        /// <param name="bmi">The bmi.</param>
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

#endif
}
