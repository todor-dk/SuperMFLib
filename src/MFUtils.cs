#region license

/*
MediaFoundationLib - Provide access to MediaFoundation interfaces via .NET
Copyright (C) 2007
http://sourceforge.net/projects/directshownet/

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
using System.Diagnostics;
using System.Runtime.InteropServices;

using MediaFoundation.Misc;

namespace MediaFoundation.Misc
{
    #region Wrapper classes

    [StructLayout(LayoutKind.Explicit)]
    public class PropVariant : IDisposable
    {
        public enum VariantType
        {
            None = 0x0,
            Blob = 0x1011,
            Double = 0x5,
            Guid = 0x48,
            IUnknown = 13,
            String = 0x1f,
            Uint32 = 0x13,
            Uint64 = 0x15,
            StringArray = 0x1000 + 0x1f
        }

        [DllImport("ole32.dll", PreserveSig=false)]
        private static extern int PropVariantClear(
            [In, MarshalAs(UnmanagedType.LPStruct)] PropVariant pvar
            );

        #region Member variables

        [FieldOffset(0)]
        protected VariantType type;

        [FieldOffset(2)]
        protected short reserved1;

        [FieldOffset(4)]
        protected short reserved2;

        [FieldOffset(6)]
        protected short reserved3;

        [FieldOffset(8)]
        protected int intValue;

        [FieldOffset(8)]
        protected long longValue;

        [FieldOffset(8)]
        protected double doubleValue;

        [FieldOffset(8)]
        protected Blob blobValue;

        [FieldOffset(8)]
        protected IntPtr ptr;

        [FieldOffset(8)]
        protected CALPWstr calpwstr;

        #endregion

        public PropVariant()
        {
            type = VariantType.None;
        }

        public PropVariant(string value)
        {
            type = VariantType.String;
            ptr = Marshal.StringToCoTaskMemUni(value);
        }

        public PropVariant(string[] value)
        {
            type = VariantType.StringArray;

            calpwstr.cElems = value.Length;
            calpwstr.pElems = Marshal.AllocCoTaskMem(IntPtr.Size * value.Length);

            for (int x = 0; x < value.Length; x++)
            {
                Marshal.WriteIntPtr(calpwstr.pElems, x * IntPtr.Size, Marshal.StringToCoTaskMemUni(value[x]));
            }
        }

        public PropVariant(int value)
        {
            type = VariantType.Uint32;
            intValue = value;
        }

        public PropVariant(double value)
        {
            type = VariantType.Double;
            doubleValue = value;
        }

        public PropVariant(long value)
        {
            type = VariantType.Uint64;
            longValue = value;
        }

        public PropVariant(Guid value)
        {
            type = VariantType.Guid;
            ptr = Marshal.AllocCoTaskMem(Marshal.SizeOf(value));
            Marshal.StructureToPtr(value, ptr, false);
        }

        public PropVariant(byte[] value)
        {
            type = VariantType.Blob;

            blobValue.cbSize = value.Length;
            blobValue.pBlobData = Marshal.AllocCoTaskMem(value.Length);
            Marshal.Copy(value, 0, blobValue.pBlobData, value.Length);
        }

        public PropVariant(object value)
        {
            type = VariantType.IUnknown;
            ptr = Marshal.GetIUnknownForObject(value);
        }

        public PropVariant(IntPtr value)
        {
            Marshal.PtrToStructure(value, this);
        }

        ~PropVariant()
        {
            Clear();
        }

        public static explicit operator string(PropVariant f)
        {
            return f.GetString();
        }

        public static explicit operator string[](PropVariant f)
        {
            return f.GetStringArray();
        }

        public static explicit operator int(PropVariant f)
        {
            return f.GetInt();
        }

        public static explicit operator double(PropVariant f)
        {
            return f.GetDouble();
        }

        public static explicit operator long(PropVariant f)
        {
            return f.GetLong();
        }

        public static explicit operator Guid(PropVariant f)
        {
            return f.GetGuid();
        }

        public static explicit operator byte[](PropVariant f)
        {
            return f.GetBlob();
        }

        // I decided not to do implicits since perf is likely to be
        // better recycling the PropVariant, and the only way I can
        // see to support Implicit is to create a new PropVariant.
        // Also, since I can't free the previous instance, IUnknowns
        // will linger until the GC cleans up.  Not what I think I
        // want.

        public MFAttributeType GetMFAttributeType()
        {
            if (type != VariantType.StringArray)
            {
                return (MFAttributeType)type;
            }
            throw new Exception("Type is not a MFAttributeType");
        }

        public VariantType GetAttributeType()
        {
            if (type != VariantType.StringArray)
            {
                return type;
            }
            throw new Exception("Type is not a MFAttributeType");
        }

        public void Clear()
        {
            PropVariantClear(this);
        }

        public string[] GetStringArray()
        {
            if (type == VariantType.StringArray)
            {
                string[] sa;

                int iCount = calpwstr.cElems;
                sa = new string[iCount];

                for (int x = 0; x < iCount; x++)
                {
                    sa[x] = Marshal.PtrToStringUni(Marshal.ReadIntPtr(calpwstr.pElems, x * IntPtr.Size));
                }

                return sa;
            }
            throw new ArgumentException("PropVariant contents not a string array");
        }

        public string GetString()
        {
            if (type == VariantType.String)
            {
                return Marshal.PtrToStringUni(ptr);
            }
            throw new ArgumentException("PropVariant contents not a string");
        }

        public int GetInt()
        {
            if (type == VariantType.Uint32)
            {
                return intValue;
            }
            throw new ArgumentException("PropVariant contents not an int32");
        }

        public long GetLong()
        {
            if (type == VariantType.Uint64)
            {
                return longValue;
            }
            throw new ArgumentException("PropVariant contents not an int64");
        }

        public double GetDouble()
        {
            if (type == VariantType.Double)
            {
                return doubleValue;
            }
            throw new ArgumentException("PropVariant contents not a double");
        }

        public Guid GetGuid()
        {
            if (type == VariantType.Guid)
            {
                return (Guid)Marshal.PtrToStructure(ptr, typeof(Guid));
            }
            throw new ArgumentException("PropVariant contents not a Guid");
        }

        public byte[] GetBlob()
        {
            if (type == VariantType.Blob)
            {
                byte[] b = new byte[blobValue.cbSize];

                Marshal.Copy(blobValue.pBlobData, b, 0, blobValue.cbSize);

                return b;
            }
            throw new ArgumentException("PropVariant contents are not a Blob");
        }

        public object GetIUnknown()
        {
            if (type == VariantType.IUnknown)
            {
                return Marshal.GetObjectForIUnknown(ptr);
            }
            throw new ArgumentException("PropVariant contents not an IUnknown");
        }

        #region IDisposable Members

        public void Dispose()
        {
            Clear();
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public class FourCC
    {
        private int m_fourCC = 0;

        public FourCC(string fcc)
        {
            if (fcc.Length != 4)
            {
                throw new ArgumentException(fcc + " is not a valid FourCC");
            }

            byte[] asc = Encoding.ASCII.GetBytes(fcc);

            this.m_fourCC = asc[0];
            this.m_fourCC |= asc[1] << 8;
            this.m_fourCC |= asc[2] << 16;
            this.m_fourCC |= asc[3] << 24;
        }

        public FourCC(char a, char b, char c, char d)
            : this(new string(new char[] { a, b, c, d }))
        { }

        public FourCC(int fcc)
        {
            this.m_fourCC = fcc;
        }

        public FourCC(Guid g)
        {
            byte[] asc;
            asc = g.ToByteArray();

            this.m_fourCC = asc[0];
            this.m_fourCC |= asc[1] << 8;
            this.m_fourCC |= asc[2] << 16;
            this.m_fourCC |= asc[3] << 24;
        }

        public int ToInt32()
        {
            return this.m_fourCC;
        }

        public static explicit operator int(FourCC f)
        {
            return f.ToInt32();
        }

        public Guid ToMediaSubtype()
        {
            return new Guid(this.m_fourCC.ToString("X") + "-0000-0010-8000-00AA00389B71");
        }

        public static bool operator ==(FourCC fcc1, FourCC fcc2)
        {
            return fcc1.m_fourCC == fcc2.m_fourCC;
        }

        public static bool operator !=(FourCC fcc1, FourCC fcc2)
        {
            return fcc1.m_fourCC != fcc2.m_fourCC;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is FourCC))
                return false;

            return (obj as FourCC).m_fourCC == this.m_fourCC;
        }

        public override int GetHashCode()
        {
            return this.m_fourCC.GetHashCode();
        }

        public override string ToString()
        {
            char[] ca = new char[] {
                Convert.ToChar((m_fourCC & 255)),
                Convert.ToChar((m_fourCC >> 8) & 255),
                Convert.ToChar((m_fourCC >> 16) & 255),
                Convert.ToChar((m_fourCC >> 24) & 255)
            };

            string s = new string(ca);

            return s;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1), UnmanagedName("WAVEFORMATEX")]
    public class WaveFormatEx
    {
        public short wFormatTag;
        public short nChannels;
        public int nSamplesPerSec;
        public int nAvgBytesPerSec;
        public short nBlockAlign;
        public short wBitsPerSample;
        public short cbSize;

        public IntPtr GetPtr()
        {
            IntPtr ip;

            // See what kind of WaveFormat object we've got
            if (this is WaveFormatExtensibleWithData)
            {
                int iExtensibleSize = Marshal.SizeOf(typeof(WaveFormatExtensible));
                int iWaveFormatExSize = Marshal.SizeOf(typeof(WaveFormatEx));

                // WaveFormatExtensibleWithData - Have to copy the byte array too
                WaveFormatExtensibleWithData pData = this as WaveFormatExtensibleWithData;

                int iExtraBytes = pData.cbSize - (iExtensibleSize - iWaveFormatExSize);

                // Account for copying the array.  This may result in us allocating more bytes than we 
                // need (if cbSize < IntPtr.Size), but it prevents us from overrunning the buffer.
                int iUseSize = Math.Max(iExtraBytes, IntPtr.Size);

                // Remember, cbSize include the length of WaveFormatExtensible
                ip = Marshal.AllocCoTaskMem(iExtensibleSize + iUseSize);

                // Copies the waveformatex + waveformatextensible
                Marshal.StructureToPtr(pData, ip, false);

                // Get a pointer to the byte after the copy
                IntPtr ip2 = new IntPtr(ip.ToInt64() + iExtensibleSize);

                // Copy the extra bytes
                Marshal.Copy(pData.byteData, 0, ip2, pData.cbSize - (iExtensibleSize - iWaveFormatExSize));
            }
            else if (this is WaveFormatExtensible)
            {
                int iWaveFormatExtensibleSize = Marshal.SizeOf(typeof(WaveFormatExtensible));

                // WaveFormatExtensible - Just do a simple copy
                WaveFormatExtensible pExt = this as WaveFormatExtensible;

                ip = Marshal.AllocCoTaskMem(iWaveFormatExtensibleSize);

                Marshal.StructureToPtr(this as WaveFormatExtensible, ip, false);
            }
            else if (this is WaveFormatExWithData)
            {
                int iWaveFormatExSize = Marshal.SizeOf(typeof(WaveFormatEx));

                // WaveFormatExWithData - Have to copy the byte array too
                WaveFormatExWithData pData = this as WaveFormatExWithData;

                // Account for copying the array.  This may result in us allocating more bytes than we 
                // need (if cbSize < IntPtr.Size), but it prevents us from overrunning the buffer.
                int iUseSize = Math.Max(pData.cbSize, IntPtr.Size);

                ip = Marshal.AllocCoTaskMem(iWaveFormatExSize + iUseSize);

                Marshal.StructureToPtr(pData, ip, false);

                IntPtr ip2 = new IntPtr(ip.ToInt64() + iWaveFormatExSize);
                Marshal.Copy(pData.byteData, 0, ip2, pData.cbSize);
            }
            else if (this is WaveFormatEx)
            {
                int iWaveFormatExSize = Marshal.SizeOf(typeof(WaveFormatEx));

                // WaveFormatEx - just do a copy
                ip = Marshal.AllocCoTaskMem(iWaveFormatExSize);
                Marshal.StructureToPtr(this as WaveFormatEx, ip, false);
            }
            else
            {
                // Someone added our custom marshaler to something they shouldn't have
                Debug.Assert(false, "Shouldn't ever get here");
                ip = IntPtr.Zero;
            }

            return ip;
        }

        public static WaveFormatEx PtrToWave(IntPtr pNativeData)
        {
            short wFormatTag = Marshal.ReadInt16(pNativeData);
            WaveFormatEx wfe;

            // WAVE_FORMAT_EXTENSIBLE == -2
            if (wFormatTag != -2)
            {
                short cbSize;

                // By spec, PCM has no cbSize element
                if (wFormatTag != 1)
                {
                    cbSize = Marshal.ReadInt16(pNativeData, 16);
                }
                else
                {
                    cbSize = 0;
                }

                // Does the structure contain extra data?
                if (cbSize == 0)
                {
                    // Create a simple WaveFormatEx struct
                    wfe = new WaveFormatEx();
                    Marshal.PtrToStructure(pNativeData, wfe);

                    // It probably already has the right value, but there is a special case
                    // where it might not, so, just to be safe...
                    wfe.cbSize = 0;
                }
                else
                {
                    WaveFormatExWithData dat = new WaveFormatExWithData();

                    // Manually parse the data into the structure
                    dat.wFormatTag = wFormatTag;
                    dat.nChannels = Marshal.ReadInt16(pNativeData, 2);
                    dat.nSamplesPerSec = Marshal.ReadInt32(pNativeData, 4);
                    dat.nAvgBytesPerSec = Marshal.ReadInt32(pNativeData, 8);
                    dat.nBlockAlign = Marshal.ReadInt16(pNativeData, 12);
                    dat.wBitsPerSample = Marshal.ReadInt16(pNativeData, 14);
                    dat.cbSize = cbSize;

                    dat.byteData = new byte[dat.cbSize];
                    IntPtr ip2 = new IntPtr(pNativeData.ToInt64() + 18);
                    Marshal.Copy(ip2, dat.byteData, 0, dat.cbSize);

                    wfe = dat as WaveFormatEx;
                }
            }
            else
            {
                short cbSize;
                int extrasize = Marshal.SizeOf(typeof(WaveFormatExtensible)) - Marshal.SizeOf(typeof(WaveFormatEx));

                cbSize = Marshal.ReadInt16(pNativeData, 16);
                if (cbSize == extrasize)
                {
                    WaveFormatExtensible ext = new WaveFormatExtensible();
                    Marshal.PtrToStructure(pNativeData, ext);
                    wfe = ext as WaveFormatEx;
                }
                else
                {
                    WaveFormatExtensibleWithData ext = new WaveFormatExtensibleWithData();
                    int iExtraBytes = cbSize - extrasize;

                    ext.wFormatTag = wFormatTag;
                    ext.nChannels = Marshal.ReadInt16(pNativeData, 2);
                    ext.nSamplesPerSec = Marshal.ReadInt32(pNativeData, 4);
                    ext.nAvgBytesPerSec = Marshal.ReadInt32(pNativeData, 8);
                    ext.nBlockAlign = Marshal.ReadInt16(pNativeData, 12);
                    ext.wBitsPerSample = Marshal.ReadInt16(pNativeData, 14);
                    ext.cbSize = cbSize;

                    ext.wValidBitsPerSample = Marshal.ReadInt16(pNativeData, 18);
                    ext.dwChannelMask = (WaveMask)Marshal.ReadInt16(pNativeData, 20);

                    // Read the Guid
                    byte[] byteGuid = new byte[16];
                    Marshal.Copy(new IntPtr(pNativeData.ToInt64() + 24), byteGuid, 0, 16);
                    ext.SubFormat = new Guid(byteGuid);

                    ext.byteData = new byte[iExtraBytes];
                    IntPtr ip2 = new IntPtr(pNativeData.ToInt64() + Marshal.SizeOf(typeof(WaveFormatExtensible)));
                    Marshal.Copy(ip2, ext.byteData, 0, iExtraBytes);

                    wfe = ext as WaveFormatEx;
                }
            }

            return wfe;
        }

        public bool IsEqual(WaveFormatEx b)
        {
            bool bRet = false;

            if (b == null)
            {
                bRet = false;
            }
            else
            {
                if (wFormatTag == b.wFormatTag &&
                    nChannels == b.nChannels &&
                    nSamplesPerSec == b.nSamplesPerSec &&
                    nAvgBytesPerSec == b.nAvgBytesPerSec &&
                    nBlockAlign == b.nBlockAlign &&
                    wBitsPerSample == b.wBitsPerSample &&
                    cbSize == b.cbSize)
                {
                    bRet = true;
                }
            }

            return bRet;
        }

    }

    [StructLayout(LayoutKind.Sequential, Pack = 1), UnmanagedName("WAVEFORMATEX")]
    public class WaveFormatExWithData : WaveFormatEx
    {
        public byte[] byteData;

        public bool IsEqual(WaveFormatExWithData b)
        {
            bool bRet = base.IsEqual(b);

            if (bRet)
            {
                if (b.byteData == null || byteData == null || b.byteData.Length != byteData.Length)
                {
                    bRet = false;
                }
                else
                {
                    for (int x = 0; x < b.byteData.Length; x++)
                    {
                        if (b.byteData[x] != byteData[x])
                        {
                            bRet = false;
                            break;
                        }
                    }
                }
            }

            return bRet;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1), UnmanagedName("WAVEFORMATEX")]
    public class WaveFormatExtensibleWithData : WaveFormatExtensible
    {
        public byte[] byteData;

        public bool IsEqual(WaveFormatExWithData b)
        {
            bool bRet = base.IsEqual(b);

            if (bRet)
            {
                if (b.byteData == null || byteData == null || b.byteData.Length != byteData.Length)
                {
                    bRet = false;
                }
                else
                {
                    for (int x = 0; x < b.byteData.Length; x++)
                    {
                        if (b.byteData[x] != byteData[x])
                        {
                            bRet = false;
                            break;
                        }
                    }
                }
            }

            return bRet;
        }
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1), UnmanagedName("WAVEFORMATEX")]
    public class WaveFormatExtensible : WaveFormatEx
    {
        [FieldOffset(0)]
        public short wValidBitsPerSample;
        [FieldOffset(0)]
        public short wSamplesPerBlock;
        [FieldOffset(0)]
        public short wReserved;
        [FieldOffset(2)]
        public WaveMask dwChannelMask;
        [FieldOffset(6)]
        public Guid SubFormat;

        public bool IsEqual(WaveFormatExtensible b)
        {
            bool bRet = base.IsEqual(b);

            if (bRet)
            {
                bRet = (wValidBitsPerSample == b.wValidBitsPerSample &&
                    dwChannelMask == b.dwChannelMask &&
                    SubFormat == b.SubFormat);
            }

            return bRet;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4), UnmanagedName("BITMAPINFOHEADER")]
    public class BitmapInfoHeader
    {
        public int biSize;
        public int biWidth;
        public int biHeight;
        public short biPlanes;
        public short biBitCount;
        public int biCompression;
        public int biSizeImage;
        public int biXPelsPerMeter;
        public int biYPelsPerMeter;
        public int biClrUsed;
        public int biClrImportant;

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

                // WaveFormatEx - just do a copy
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

                ext.biSize = Marshal.ReadInt32(pNativeData, 0);
                ext.biWidth = Marshal.ReadInt32(pNativeData, 4);
                ext.biHeight = Marshal.ReadInt32(pNativeData, 8);
                ext.biPlanes = Marshal.ReadInt16(pNativeData, 12);
                ext.biBitCount = Marshal.ReadInt16(pNativeData, 14);
                ext.biCompression = Marshal.ReadInt32(pNativeData, 16);
                ext.biSizeImage = Marshal.ReadInt32(pNativeData, 20);
                ext.biXPelsPerMeter = Marshal.ReadInt32(pNativeData, 24);
                ext.biYPelsPerMeter = Marshal.ReadInt32(pNativeData, 28);
                ext.biClrUsed = Marshal.ReadInt32(pNativeData, 32);
                ext.biClrImportant = Marshal.ReadInt32(pNativeData, 36);

                bmi = ext as BitmapInfoHeader;

                ext.bmiColors = new int[iEntries];
                IntPtr ip2 = new IntPtr(pNativeData.ToInt64() + Marshal.SizeOf(typeof(BitmapInfoHeader)));
                Marshal.Copy(ip2, ext.bmiColors, 0, iEntries);
            }

            return bmi;
        }

        public void CopyFrom(BitmapInfoHeader bmi)
        {
            biSize = bmi.biSize;
            biWidth = bmi.biWidth;
            biHeight = bmi.biHeight;
            biPlanes = bmi.biPlanes;
            biBitCount = bmi.biBitCount;
            biCompression = bmi.biCompression;
            biSizeImage = bmi.biSizeImage;
            biSizeImage = bmi.biSizeImage;
            biYPelsPerMeter = bmi.biYPelsPerMeter;
            biClrUsed = bmi.biClrUsed;
            biClrImportant = bmi.biClrImportant;

            if (bmi is BitmapInfoHeaderWithData)
            {
                BitmapInfoHeaderWithData ext = this as BitmapInfoHeaderWithData;
                BitmapInfoHeaderWithData ext2 = bmi as BitmapInfoHeaderWithData;

                ext.bmiColors = new int[ext2.bmiColors.Length];
                ext2.bmiColors.CopyTo(ext.bmiColors, 0);
            }
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4), UnmanagedName("BITMAPINFO")]
    public class BitmapInfoHeaderWithData : BitmapInfoHeader
    {
        public int[] bmiColors;
    }

    #endregion

    #region Utility Classes

    sealed public class MFError
    {
        #region Errors

        public const int MF_E_PLATFORM_NOT_INITIALIZED = unchecked((int)0xC00D36B0);
        public const int MF_E_BUFFERTOOSMALL = unchecked((int)0xC00D36B1);
        public const int MF_E_INVALIDREQUEST = unchecked((int)0xC00D36B2);
        public const int MF_E_INVALIDSTREAMNUMBER = unchecked((int)0xC00D36B3);
        public const int MF_E_INVALIDMEDIATYPE = unchecked((int)0xC00D36B4);
        public const int MF_E_NOTACCEPTING = unchecked((int)0xC00D36B5);
        public const int MF_E_NOT_INITIALIZED = unchecked((int)0xC00D36B6);
        public const int MF_E_UNSUPPORTED_REPRESENTATION = unchecked((int)0xC00D36B7);
        public const int MF_E_NO_MORE_TYPES = unchecked((int)0xC00D36B9);
        public const int MF_E_UNSUPPORTED_SERVICE = unchecked((int)0xC00D36BA);
        public const int MF_E_UNEXPECTED = unchecked((int)0xC00D36BB);
        public const int MF_E_INVALIDNAME = unchecked((int)0xC00D36BC);
        public const int MF_E_INVALIDTYPE = unchecked((int)0xC00D36BD);
        public const int MF_E_INVALID_FILE_FORMAT = unchecked((int)0xC00D36BE);
        public const int MF_E_INVALIDINDEX = unchecked((int)0xC00D36BF);
        public const int MF_E_INVALID_TIMESTAMP = unchecked((int)0xC00D36C0);
        public const int MF_E_UNSUPPORTED_SCHEME = unchecked((int)0xC00D36C3);
        public const int MF_E_UNSUPPORTED_BYTESTREAM_TYPE = unchecked((int)0xC00D36C4);
        public const int MF_E_UNSUPPORTED_TIME_FORMAT = unchecked((int)0xC00D36C5);
        public const int MF_E_NO_SAMPLE_TIMESTAMP = unchecked((int)0xC00D36C8);
        public const int MF_E_NO_SAMPLE_DURATION = unchecked((int)0xC00D36C9);
        public const int MF_E_INVALID_STREAM_DATA = unchecked((int)0xC00D36CB);
        public const int MF_E_RT_UNAVAILABLE = unchecked((int)0xC00D36CF);
        public const int MF_E_UNSUPPORTED_RATE = unchecked((int)0xC00D36D0);
        public const int MF_E_THINNING_UNSUPPORTED = unchecked((int)0xC00D36D1);
        public const int MF_E_REVERSE_UNSUPPORTED = unchecked((int)0xC00D36D2);
        public const int MF_E_UNSUPPORTED_RATE_TRANSITION = unchecked((int)0xC00D36D3);
        public const int MF_E_RATE_CHANGE_PREEMPTED = unchecked((int)0xC00D36D4);
        public const int MF_E_NOT_FOUND = unchecked((int)0xC00D36D5);
        public const int MF_E_NOT_AVAILABLE = unchecked((int)0xC00D36D6);
        public const int MF_E_NO_CLOCK = unchecked((int)0xC00D36D7);
        public const int MF_S_MULTIPLE_BEGIN = unchecked((int)0x000D36D8);
        public const int MF_E_MULTIPLE_BEGIN = unchecked((int)0xC00D36D9);
        public const int MF_E_MULTIPLE_SUBSCRIBERS = unchecked((int)0xC00D36DA);
        public const int MF_E_TIMER_ORPHANED = unchecked((int)0xC00D36DB);
        public const int MF_E_STATE_TRANSITION_PENDING = unchecked((int)0xC00D36DC);
        public const int MF_E_UNSUPPORTED_STATE_TRANSITION = unchecked((int)0xC00D36DD);
        public const int MF_E_UNRECOVERABLE_ERROR_OCCURRED = unchecked((int)0xC00D36DE);
        public const int MF_E_SAMPLE_HAS_TOO_MANY_BUFFERS = unchecked((int)0xC00D36DF);
        public const int MF_E_SAMPLE_NOT_WRITABLE = unchecked((int)0xC00D36E0);
        public const int MF_E_INVALID_KEY = unchecked((int)0xC00D36E2);
        public const int MF_E_BAD_STARTUP_VERSION = unchecked((int)0xC00D36E3);
        public const int MF_E_UNSUPPORTED_CAPTION = unchecked((int)0xC00D36E4);
        public const int MF_E_INVALID_POSITION = unchecked((int)0xC00D36E5);
        public const int MF_E_ATTRIBUTENOTFOUND = unchecked((int)0xC00D36E6);
        public const int MF_E_PROPERTY_TYPE_NOT_ALLOWED = unchecked((int)0xC00D36E7);
        public const int MF_E_PROPERTY_TYPE_NOT_SUPPORTED = unchecked((int)0xC00D36E8);
        public const int MF_E_PROPERTY_EMPTY = unchecked((int)0xC00D36E9);
        public const int MF_E_PROPERTY_NOT_EMPTY = unchecked((int)0xC00D36EA);
        public const int MF_E_PROPERTY_VECTOR_NOT_ALLOWED = unchecked((int)0xC00D36EB);
        public const int MF_E_PROPERTY_VECTOR_REQUIRED = unchecked((int)0xC00D36EC);
        public const int MF_E_OPERATION_CANCELLED = unchecked((int)0xC00D36ED);
        public const int MF_E_BYTESTREAM_NOT_SEEKABLE = unchecked((int)0xC00D36EE);
        public const int MF_E_DISABLED_IN_SAFEMODE = unchecked((int)0xC00D36EF);
        public const int MF_E_CANNOT_PARSE_BYTESTREAM = unchecked((int)0xC00D36F0);
        public const int MF_E_SOURCERESOLVER_MUTUALLY_EXCLUSIVE_FLAGS = unchecked((int)0xC00D36F1);
        public const int MF_E_MEDIAPROC_WRONGSTATE = unchecked((int)0xC00D36F2);
        public const int MF_E_RT_THROUGHPUT_NOT_AVAILABLE = unchecked((int)0xC00D36F3);
        public const int MF_E_RT_TOO_MANY_CLASSES = unchecked((int)0xC00D36F4);
        public const int MF_E_RT_WOULDBLOCK = unchecked((int)0xC00D36F5);
        public const int MF_E_NO_BITPUMP = unchecked((int)0xC00D36F6);
        public const int MF_E_RT_OUTOFMEMORY = unchecked((int)0xC00D36F7);
        public const int MF_E_RT_WORKQUEUE_CLASS_NOT_SPECIFIED = unchecked((int)0xC00D36F8);
        public const int MF_E_INSUFFICIENT_BUFFER = unchecked((int)0xC00D7170);
        public const int MF_E_CANNOT_CREATE_SINK = unchecked((int)0xC00D36FA);
        public const int MF_E_BYTESTREAM_UNKNOWN_LENGTH = unchecked((int)0xC00D36FB);
        public const int MF_E_SESSION_PAUSEWHILESTOPPED = unchecked((int)0xC00D36FC);
        public const int MF_S_ACTIVATE_REPLACED = unchecked((int)0x000D36FD);
        public const int MF_E_FORMAT_CHANGE_NOT_SUPPORTED = unchecked((int)0xC00D36FE);
        public const int MF_S_ASF_PARSEINPROGRESS = unchecked((int)0x400D3A98);
        public const int MF_E_ASF_PARSINGINCOMPLETE = unchecked((int)0xC00D3A98);
        public const int MF_E_ASF_MISSINGDATA = unchecked((int)0xC00D3A99);
        public const int MF_E_ASF_INVALIDDATA = unchecked((int)0xC00D3A9A);
        public const int MF_E_ASF_OPAQUEPACKET = unchecked((int)0xC00D3A9B);
        public const int MF_E_ASF_NOINDEX = unchecked((int)0xC00D3A9C);
        public const int MF_E_ASF_OUTOFRANGE = unchecked((int)0xC00D3A9D);
        public const int MF_E_ASF_INDEXNOTLOADED = unchecked((int)0xC00D3A9E);
        public const int MF_E_ASF_TOO_MANY_PAYLOADS = unchecked((int)0xC00D3A9F);
        public const int MF_E_ASF_UNSUPPORTED_STREAM_TYPE = unchecked((int)0xC00D3AA0);
        public const int MF_E_NO_EVENTS_AVAILABLE = unchecked((int)0xC00D3E80);
        public const int MF_E_INVALID_STATE_TRANSITION = unchecked((int)0xC00D3E82);
        public const int MF_E_END_OF_STREAM = unchecked((int)0xC00D3E84);
        public const int MF_E_SHUTDOWN = unchecked((int)0xC00D3E85);
        public const int MF_E_MP3_NOTFOUND = unchecked((int)0xC00D3E86);
        public const int MF_E_MP3_OUTOFDATA = unchecked((int)0xC00D3E87);
        public const int MF_E_MP3_NOTMP3 = unchecked((int)0xC00D3E88);
        public const int MF_E_MP3_NOTSUPPORTED = unchecked((int)0xC00D3E89);
        public const int MF_E_NO_DURATION = unchecked((int)0xC00D3E8A);
        public const int MF_E_INVALID_FORMAT = unchecked((int)0xC00D3E8C);
        public const int MF_E_PROPERTY_NOT_FOUND = unchecked((int)0xC00D3E8D);
        public const int MF_E_PROPERTY_READ_ONLY = unchecked((int)0xC00D3E8E);
        public const int MF_E_PROPERTY_NOT_ALLOWED = unchecked((int)0xC00D3E8F);
        public const int MF_E_MEDIA_SOURCE_NOT_STARTED = unchecked((int)0xC00D3E91);
        public const int MF_E_UNSUPPORTED_FORMAT = unchecked((int)0xC00D3E98);
        public const int MF_E_MP3_BAD_CRC = unchecked((int)0xC00D3E99);
        public const int MF_E_NOT_PROTECTED = unchecked((int)0xC00D3E9A);
        public const int MF_E_MEDIA_SOURCE_WRONGSTATE = unchecked((int)0xC00D3E9B);
        public const int MF_E_NETWORK_RESOURCE_FAILURE = unchecked((int)0xC00D4268);
        public const int MF_E_NET_WRITE = unchecked((int)0xC00D4269);
        public const int MF_E_NET_READ = unchecked((int)0xC00D426A);
        public const int MF_E_NET_REQUIRE_NETWORK = unchecked((int)0xC00D426B);
        public const int MF_E_NET_REQUIRE_ASYNC = unchecked((int)0xC00D426C);
        public const int MF_E_NET_BWLEVEL_NOT_SUPPORTED = unchecked((int)0xC00D426D);
        public const int MF_E_NET_STREAMGROUPS_NOT_SUPPORTED = unchecked((int)0xC00D426E);
        public const int MF_E_NET_MANUALSS_NOT_SUPPORTED = unchecked((int)0xC00D426F);
        public const int MF_E_NET_INVALID_PRESENTATION_DESCRIPTOR = unchecked((int)0xC00D4270);
        public const int MF_E_NET_CACHESTREAM_NOT_FOUND = unchecked((int)0xC00D4271);
        public const int MF_I_MANUAL_PROXY = unchecked((int)0x400D4272);
        public const int MF_E_NET_REQUIRE_INPUT = unchecked((int)0xC00D4274);
        public const int MF_E_NET_REDIRECT = unchecked((int)0xC00D4275);
        public const int MF_E_NET_REDIRECT_TO_PROXY = unchecked((int)0xC00D4276);
        public const int MF_E_NET_TOO_MANY_REDIRECTS = unchecked((int)0xC00D4277);
        public const int MF_E_NET_TIMEOUT = unchecked((int)0xC00D4278);
        public const int MF_E_NET_CLIENT_CLOSE = unchecked((int)0xC00D4279);
        public const int MF_E_NET_BAD_CONTROL_DATA = unchecked((int)0xC00D427A);
        public const int MF_E_NET_INCOMPATIBLE_SERVER = unchecked((int)0xC00D427B);
        public const int MF_E_NET_UNSAFE_URL = unchecked((int)0xC00D427C);
        public const int MF_E_NET_CACHE_NO_DATA = unchecked((int)0xC00D427D);
        public const int MF_E_NET_EOL = unchecked((int)0xC00D427E);
        public const int MF_E_NET_BAD_REQUEST = unchecked((int)0xC00D427F);
        public const int MF_E_NET_INTERNAL_SERVER_ERROR = unchecked((int)0xC00D4280);
        public const int MF_E_NET_SESSION_NOT_FOUND = unchecked((int)0xC00D4281);
        public const int MF_E_NET_NOCONNECTION = unchecked((int)0xC00D4282);
        public const int MF_E_NET_CONNECTION_FAILURE = unchecked((int)0xC00D4283);
        public const int MF_E_NET_INCOMPATIBLE_PUSHSERVER = unchecked((int)0xC00D4284);
        public const int MF_E_NET_SERVER_ACCESSDENIED = unchecked((int)0xC00D4285);
        public const int MF_E_NET_PROXY_ACCESSDENIED = unchecked((int)0xC00D4286);
        public const int MF_E_NET_CANNOTCONNECT = unchecked((int)0xC00D4287);
        public const int MF_E_NET_INVALID_PUSH_TEMPLATE = unchecked((int)0xC00D4288);
        public const int MF_E_NET_INVALID_PUSH_PUBLISHING_POINT = unchecked((int)0xC00D4289);
        public const int MF_E_NET_BUSY = unchecked((int)0xC00D428A);
        public const int MF_E_NET_RESOURCE_GONE = unchecked((int)0xC00D428B);
        public const int MF_E_NET_ERROR_FROM_PROXY = unchecked((int)0xC00D428C);
        public const int MF_E_NET_PROXY_TIMEOUT = unchecked((int)0xC00D428D);
        public const int MF_E_NET_SERVER_UNAVAILABLE = unchecked((int)0xC00D428E);
        public const int MF_E_NET_TOO_MUCH_DATA = unchecked((int)0xC00D428F);
        public const int MF_E_NET_SESSION_INVALID = unchecked((int)0xC00D4290);
        public const int MF_E_OFFLINE_MODE = unchecked((int)0xC00D4291);
        public const int MF_E_NET_UDP_BLOCKED = unchecked((int)0xC00D4292);
        public const int MF_E_NET_UNSUPPORTED_CONFIGURATION = unchecked((int)0xC00D4293);
        public const int MF_E_NET_PROTOCOL_DISABLED = unchecked((int)0xC00D4294);
        public const int MF_E_ALREADY_INITIALIZED = unchecked((int)0xC00D4650);
        public const int MF_E_BANDWIDTH_OVERRUN = unchecked((int)0xC00D4651);
        public const int MF_E_LATE_SAMPLE = unchecked((int)0xC00D4652);
        public const int MF_E_FLUSH_NEEDED = unchecked((int)0xC00D4653);
        public const int MF_E_INVALID_PROFILE = unchecked((int)0xC00D4654);
        public const int MF_E_INDEX_NOT_COMMITTED = unchecked((int)0xC00D4655);
        public const int MF_E_NO_INDEX = unchecked((int)0xC00D4656);
        public const int MF_E_CANNOT_INDEX_IN_PLACE = unchecked((int)0xC00D4657);
        public const int MF_E_MISSING_ASF_LEAKYBUCKET = unchecked((int)0xC00D4658);
        public const int MF_E_INVALID_ASF_STREAMID = unchecked((int)0xC00D4659);
        public const int MF_E_STREAMSINK_REMOVED = unchecked((int)0xC00D4A38);
        public const int MF_E_STREAMSINKS_OUT_OF_SYNC = unchecked((int)0xC00D4A3A);
        public const int MF_E_STREAMSINKS_FIXED = unchecked((int)0xC00D4A3B);
        public const int MF_E_STREAMSINK_EXISTS = unchecked((int)0xC00D4A3C);
        public const int MF_E_SAMPLEALLOCATOR_CANCELED = unchecked((int)0xC00D4A3D);
        public const int MF_E_SAMPLEALLOCATOR_EMPTY = unchecked((int)0xC00D4A3E);
        public const int MF_E_SINK_ALREADYSTOPPED = unchecked((int)0xC00D4A3F);
        public const int MF_E_ASF_FILESINK_BITRATE_UNKNOWN = unchecked((int)0xC00D4A40);
        public const int MF_E_SINK_NO_STREAMS = unchecked((int)0xC00D4A41);
        public const int MF_S_SINK_NOT_FINALIZED = unchecked((int)0x000D4A42);
        public const int MF_E_VIDEO_REN_NO_PROCAMP_HW = unchecked((int)0xC00D4E20);
        public const int MF_E_VIDEO_REN_NO_DEINTERLACE_HW = unchecked((int)0xC00D4E21);
        public const int MF_E_VIDEO_REN_COPYPROT_FAILED = unchecked((int)0xC00D4E22);
        public const int MF_E_VIDEO_REN_SURFACE_NOT_SHARED = unchecked((int)0xC00D4E23);
        public const int MF_E_VIDEO_DEVICE_LOCKED = unchecked((int)0xC00D4E24);
        public const int MF_E_NEW_VIDEO_DEVICE = unchecked((int)0xC00D4E25);
        public const int MF_E_NO_VIDEO_SAMPLE_AVAILABLE = unchecked((int)0xC00D4E26);
        public const int MF_E_NO_AUDIO_PLAYBACK_DEVICE = unchecked((int)0xC00D4E84);
        public const int MF_E_AUDIO_PLAYBACK_DEVICE_IN_USE = unchecked((int)0xC00D4E85);
        public const int MF_E_AUDIO_PLAYBACK_DEVICE_INVALIDATED = unchecked((int)0xC00D4E86);
        public const int MF_E_AUDIO_SERVICE_NOT_RUNNING = unchecked((int)0xC00D4E87);
        public const int MF_E_TOPO_INVALID_OPTIONAL_NODE = unchecked((int)0xC00D520E);
        public const int MF_E_TOPO_CANNOT_FIND_DECRYPTOR = unchecked((int)0xC00D5211);
        public const int MF_E_TOPO_CODEC_NOT_FOUND = unchecked((int)0xC00D5212);
        public const int MF_E_TOPO_CANNOT_CONNECT = unchecked((int)0xC00D5213);
        public const int MF_E_TOPO_UNSUPPORTED = unchecked((int)0xC00D5214);
        public const int MF_E_TOPO_INVALID_TIME_ATTRIBUTES = unchecked((int)0xC00D5215);
        public const int MF_E_SEQUENCER_UNKNOWN_SEGMENT_ID = unchecked((int)0xC00D61AC);
        public const int MF_S_SEQUENCER_CONTEXT_CANCELED = unchecked((int)0x000D61AD);
        public const int MF_E_NO_SOURCE_IN_CACHE = unchecked((int)0xC00D61AE);
        public const int MF_S_SEQUENCER_SEGMENT_AT_END_OF_STREAM = unchecked((int)0x000D61AF);
        public const int MF_E_TRANSFORM_TYPE_NOT_SET = unchecked((int)0xC00D6D60);
        public const int MF_E_TRANSFORM_STREAM_CHANGE = unchecked((int)0xC00D6D61);
        public const int MF_E_TRANSFORM_INPUT_REMAINING = unchecked((int)0xC00D6D62);
        public const int MF_E_TRANSFORM_PROFILE_MISSING = unchecked((int)0xC00D6D63);
        public const int MF_E_TRANSFORM_PROFILE_INVALID_OR_CORRUPT = unchecked((int)0xC00D6D64);
        public const int MF_E_TRANSFORM_PROFILE_TRUNCATED = unchecked((int)0xC00D6D65);
        public const int MF_E_TRANSFORM_PROPERTY_PID_NOT_RECOGNIZED = unchecked((int)0xC00D6D66);
        public const int MF_E_TRANSFORM_PROPERTY_VARIANT_TYPE_WRONG = unchecked((int)0xC00D6D67);
        public const int MF_E_TRANSFORM_PROPERTY_NOT_WRITEABLE = unchecked((int)0xC00D6D68);
        public const int MF_E_TRANSFORM_PROPERTY_ARRAY_VALUE_WRONG_NUM_DIM = unchecked((int)0xC00D6D69);
        public const int MF_E_TRANSFORM_PROPERTY_VALUE_SIZE_WRONG = unchecked((int)0xC00D6D6A);
        public const int MF_E_TRANSFORM_PROPERTY_VALUE_OUT_OF_RANGE = unchecked((int)0xC00D6D6B);
        public const int MF_E_TRANSFORM_PROPERTY_VALUE_INCOMPATIBLE = unchecked((int)0xC00D6D6C);
        public const int MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_OUTPUT_MEDIATYPE = unchecked((int)0xC00D6D6D);
        public const int MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_INPUT_MEDIATYPE = unchecked((int)0xC00D6D6E);
        public const int MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_MEDIATYPE_COMBINATION = unchecked((int)0xC00D6D6F);
        public const int MF_E_TRANSFORM_CONFLICTS_WITH_OTHER_CURRENTLY_ENABLED_FEATURES = unchecked((int)0xC00D6D70);
        public const int MF_E_TRANSFORM_NEED_MORE_INPUT = unchecked((int)0xC00D6D72);
        public const int MF_E_TRANSFORM_NOT_POSSIBLE_FOR_CURRENT_SPKR_CONFIG = unchecked((int)0xC00D6D73);
        public const int MF_E_TRANSFORM_CANNOT_CHANGE_MEDIATYPE_WHILE_PROCESSING = unchecked((int)0xC00D6D74);
        public const int MF_S_TRANSFORM_DO_NOT_PROPAGATE_EVENT = unchecked((int)0x000D6D75);
        public const int MF_E_UNSUPPORTED_D3D_TYPE = unchecked((int)0xC00D6D76);
        public const int MF_E_LICENSE_INCORRECT_RIGHTS = unchecked((int)0xC00D7148);
        public const int MF_E_LICENSE_OUTOFDATE = unchecked((int)0xC00D7149);
        public const int MF_E_LICENSE_REQUIRED = unchecked((int)0xC00D714A);
        public const int MF_E_DRM_HARDWARE_INCONSISTENT = unchecked((int)0xC00D714B);
        public const int MF_E_NO_CONTENT_PROTECTION_MANAGER = unchecked((int)0xC00D714C);
        public const int MF_E_LICENSE_RESTORE_NO_RIGHTS = unchecked((int)0xC00D714D);
        public const int MF_E_BACKUP_RESTRICTED_LICENSE = unchecked((int)0xC00D714E);
        public const int MF_E_LICENSE_RESTORE_NEEDS_INDIVIDUALIZATION = unchecked((int)0xC00D714F);
        public const int MF_S_PROTECTION_NOT_REQUIRED = unchecked((int)0x000D7150);
        public const int MF_E_COMPONENT_REVOKED = unchecked((int)0xC00D7151);
        public const int MF_E_TRUST_DISABLED = unchecked((int)0xC00D7152);
        public const int MF_E_WMDRMOTA_NO_ACTION = unchecked((int)0xC00D7153);
        public const int MF_E_WMDRMOTA_ACTION_ALREADY_SET = unchecked((int)0xC00D7154);
        public const int MF_E_WMDRMOTA_DRM_HEADER_NOT_AVAILABLE = unchecked((int)0xC00D7155);
        public const int MF_E_WMDRMOTA_DRM_ENCRYPTION_SCHEME_NOT_SUPPORTED = unchecked((int)0xC00D7156);
        public const int MF_E_WMDRMOTA_ACTION_MISMATCH = unchecked((int)0xC00D7157);
        public const int MF_E_WMDRMOTA_INVALID_POLICY = unchecked((int)0xC00D7158);
        public const int MF_E_POLICY_UNSUPPORTED = unchecked((int)0xC00D7159);
        public const int MF_E_OPL_NOT_SUPPORTED = unchecked((int)0xC00D715A);
        public const int MF_E_TOPOLOGY_VERIFICATION_FAILED = unchecked((int)0xC00D715B);
        public const int MF_E_SIGNATURE_VERIFICATION_FAILED = unchecked((int)0xC00D715C);
        public const int MF_E_DEBUGGING_NOT_ALLOWED = unchecked((int)0xC00D715D);
        public const int MF_E_CODE_EXPIRED = unchecked((int)0xC00D715E);
        public const int MF_E_GRL_VERSION_TOO_LOW = unchecked((int)0xC00D715F);
        public const int MF_E_GRL_RENEWAL_NOT_FOUND = unchecked((int)0xC00D7160);
        public const int MF_E_GRL_EXTENSIBLE_ENTRY_NOT_FOUND = unchecked((int)0xC00D7161);
        public const int MF_E_KERNEL_UNTRUSTED = unchecked((int)0xC00D7162);
        public const int MF_E_PEAUTH_UNTRUSTED = unchecked((int)0xC00D7163);
        public const int MF_E_NON_PE_PROCESS = unchecked((int)0xC00D7165);
        public const int MF_E_REBOOT_REQUIRED = unchecked((int)0xC00D7167);
        public const int MF_S_WAIT_FOR_POLICY_SET = unchecked((int)0x000D7168);
        public const int MF_S_VIDEO_DISABLED_WITH_UNKNOWN_SOFTWARE_OUTPUT = unchecked((int)0x000D7169);
        public const int MF_E_GRL_INVALID_FORMAT = unchecked((int)0xC00D716A);
        public const int MF_E_GRL_UNRECOGNIZED_FORMAT = unchecked((int)0xC00D716B);
        public const int MF_E_ALL_PROCESS_RESTART_REQUIRED = unchecked((int)0xC00D716C);
        public const int MF_E_PROCESS_RESTART_REQUIRED = unchecked((int)0xC00D716D);
        public const int MF_E_USERMODE_UNTRUSTED = unchecked((int)0xC00D716E);
        public const int MF_E_PEAUTH_SESSION_NOT_STARTED = unchecked((int)0xC00D716F);
        public const int MF_E_PEAUTH_PUBLICKEY_REVOKED = unchecked((int)0xC00D7171);
        public const int MF_E_GRL_ABSENT = unchecked((int)0xC00D7172);
        public const int MF_S_PE_TRUSTED = unchecked((int)0x000D7173);
        public const int MF_E_PE_UNTRUSTED = unchecked((int)0xC00D7174);
        public const int MF_E_PEAUTH_NOT_STARTED = unchecked((int)0xC00D7175);
        public const int MF_E_INCOMPATIBLE_SAMPLE_PROTECTION = unchecked((int)0xC00D7176);
        public const int MF_E_PE_SESSIONS_MAXED = unchecked((int)0xC00D7177);
        public const int MF_E_HIGH_SECURITY_LEVEL_CONTENT_NOT_ALLOWED = unchecked((int)0xC00D7178);
        public const int MF_E_TEST_SIGNED_COMPONENTS_NOT_ALLOWED = unchecked((int)0xC00D7179);
        public const int MF_E_ITA_UNSUPPORTED_ACTION = unchecked((int)0xC00D717A);
        public const int MF_E_ITA_ERROR_PARSING_SAP_PARAMETERS = unchecked((int)0xC00D717B);
        public const int MF_E_POLICY_MGR_ACTION_OUTOFBOUNDS = unchecked((int)0xC00D717C);
        public const int MF_E_BAD_OPL_STRUCTURE_FORMAT = unchecked((int)0xC00D717D);
        public const int MF_E_ITA_UNRECOGNIZED_ANALOG_VIDEO_PROTECTION_GUID = unchecked((int)0xC00D717E);
        public const int MF_E_NO_PMP_HOST = unchecked((int)0xC00D717F);
        public const int MF_E_ITA_OPL_DATA_NOT_INITIALIZED = unchecked((int)0xC00D7180);
        public const int MF_E_ITA_UNRECOGNIZED_ANALOG_VIDEO_OUTPUT = unchecked((int)0xC00D7181);
        public const int MF_E_ITA_UNRECOGNIZED_DIGITAL_VIDEO_OUTPUT = unchecked((int)0xC00D7182);
        public const int MF_E_CLOCK_INVALID_CONTINUITY_KEY = unchecked((int)0xC00D9C40);
        public const int MF_E_CLOCK_NO_TIME_SOURCE = unchecked((int)0xC00D9C41);
        public const int MF_E_CLOCK_STATE_ALREADY_SET = unchecked((int)0xC00D9C42);
        public const int MF_E_CLOCK_NOT_SIMPLE = unchecked((int)0xC00D9C43);
        public const int MF_S_CLOCK_STOPPED = unchecked((int)0x000D9C44);
        public const int MF_E_NO_MORE_DROP_MODES = unchecked((int)0xC00DA028);
        public const int MF_E_NO_MORE_QUALITY_LEVELS = unchecked((int)0xC00DA029);
        public const int MF_E_DROPTIME_NOT_SUPPORTED = unchecked((int)0xC00DA02A);
        public const int MF_E_QUALITYKNOB_WAIT_LONGER = unchecked((int)0xC00DA02B);
        public const int MF_E_QM_INVALIDSTATE = unchecked((int)0xC00DA02C);

        #endregion

        #region externs

        [DllImport("kernel32.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
        private static extern int FormatMessage(FormatMessageFlags dwFlags, IntPtr lpSource,
            int dwMessageId, int dwLanguageId, ref IntPtr lpBuffer, int nSize, IntPtr Arguments);

        [DllImport("kernel32.dll")]
        private static extern IntPtr LoadLibraryEx(string lpFileName, IntPtr hFile, LoadLibraryExFlags dwFlags);

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeLibrary(IntPtr hFile);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr LocalFree(IntPtr hMem);

        #endregion

        #region Declarations

        [Flags, UnmanagedName("#defines in WinBase.h")]
        private enum LoadLibraryExFlags
        {
            DontResolveDllReferences = 0x00000001,
            LoadLibraryAsDataFile = 0x00000002,
            LoadWithAlteredSearchPath = 0x00000008,
            LoadIgnoreCodeAuthzLevel = 0x00000010
        }

        [Flags, UnmanagedName("FORMAT_MESSAGE_* defines")]
        private enum FormatMessageFlags
        {
            AllocateBuffer = 0x00000100,
            IgnoreInserts = 0x00000200,
            FromString = 0x00000400,
            FromHmodule = 0x00000800,
            FromSystem = 0x00001000,
            ArgumentArray = 0x00002000,
            MaxWidthMask = 0x000000FF
        }

        #endregion

        private static IntPtr s_hModule = IntPtr.Zero;
        private const string MESSAGEFILE = "mferror.dll";

        /// <summary>
        /// Prevent people from trying to instantiate this class
        /// </summary>
        private MFError()
        {
            // Prevent people from trying to instantiate this class
        }

        /// <summary>
        /// Returns a string describing a MF error.  Works for both error codes
        /// (values < 0) and Status codes (values >= 0)
        /// </summary>
        /// <param name="hr">HRESULT for which to get description</param>
        /// <returns>The string, or null if no error text can be found</returns>
        public static string GetErrorText(int hr)
        {
            string sRet = null;
            int dwBufferLength;
            IntPtr ip = IntPtr.Zero;

            FormatMessageFlags dwFormatFlags =
                FormatMessageFlags.AllocateBuffer |
                FormatMessageFlags.IgnoreInserts |
                FormatMessageFlags.FromSystem |
                FormatMessageFlags.MaxWidthMask;

            // Scan both the Windows Media library, and the system library looking for the message
            dwBufferLength = FormatMessage(
                dwFormatFlags,
                s_hModule, // module to get message from (NULL == system)
                hr, // error number to get message for
                0, // default language
                ref ip,
                0,
                IntPtr.Zero
                );

            // Not a system message.  In theory, you should be able to get both with one call.  In practice (at
            // least on my 64bit box), you need to make 2 calls.
            if (dwBufferLength == 0)
            {
                if (s_hModule == IntPtr.Zero)
                {
                    // Load the Media Foundation error message dll
                    s_hModule = LoadLibraryEx(MESSAGEFILE, IntPtr.Zero, LoadLibraryExFlags.LoadLibraryAsDataFile);
                }

                if (s_hModule != IntPtr.Zero)
                {
                    // If the load succeeds, make sure we look in it
                    dwFormatFlags |= FormatMessageFlags.FromHmodule;

                    // Scan both the Windows Media library, and the system library looking for the message
                    dwBufferLength = FormatMessage(
                        dwFormatFlags,
                        s_hModule, // module to get message from (NULL == system)
                        hr, // error number to get message for
                        0, // default language
                        ref ip,
                        0,
                        IntPtr.Zero
                        );
                }
            }

            try
            {
                // Convert the returned buffer to a string.  If ip is null (due to not finding
                // the message), no exception is thrown.  sRet just stays null.  The
                // try/finally is for the (remote) possibility that we run out of memory
                // creating the string.
                sRet = Marshal.PtrToStringUni(ip);
            }
            finally
            {
                // Cleanup
                if (ip != IntPtr.Zero)
                {
                    LocalFree(ip);
                }
            }

            return sRet;
        }

        /// <summary>
        /// If hr has a "failed" status code (E_*), throw an exception.  Note that status
        /// messages (S_*) are not considered failure codes.  If MediaFoundation error text
        /// is available, it is used to build the exception, otherwise a generic com error
        /// is thrown.
        /// </summary>
        /// <param name="hr">The HRESULT to check</param>
        public static void ThrowExceptionForHR(int hr)
        {
            // If a severe error has occurred
            if (hr < 0)
            {
                string s = GetErrorText(hr);

                // If a string is returned, build a com error from it
                if (s != null)
                {
                    throw new COMException(s, hr);
                }
                else
                {
                    // No string, just use standard com error
                    Marshal.ThrowExceptionForHR(hr);
                }
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public class MFInt
    {
        protected int m_value;

        public MFInt(int v)
        {
            m_value = v;
        }

        public int GetValue()
        {
            return m_value;
        }

        // While I *could* enable this code, it almost certainly won't do what you 
        // think it will.  Generally you don't want to create a *new* instance of
        // MFInt and assign a value to it.  You want to assign a value to an
        // existing instance.  In order to do this automatically, .Net would have
        // to support overloading operator =.  But since it doesn't, use Assign()

        //public static implicit operator MFInt(int f)
        //{
        //    return new MFInt(f);
        //}

        public static implicit operator int(MFInt f)
        {
            return f.m_value;
        }

        public int ToInt32()
        {
            return m_value;
        }

        public void Assign(int f)
        {
            m_value = f;
        }

        public override string ToString()
        {
            return m_value.ToString();
        }

        public override int GetHashCode()
        {
            return m_value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is MFInt)
            {
                return ((MFInt)obj).m_value == m_value;
            }

            return Convert.ToInt32(obj) == m_value;
        }
    }

    abstract public class COMBase
    {
        public const int S_Ok = 0;
        public const int S_False = 0;

        public const int E_NotImplemented = unchecked((int)0x80004001);
        public const int E_NoInterface = unchecked((int)0x80004002);
        public const int E_Pointer = unchecked((int)0x80004003);
        public const int E_Abort = unchecked((int)0x80004004);
        public const int E_Fail = unchecked((int)0x80004005);
        public const int E_Unexpected = unchecked((int)0x8000FFFF);
        public const int E_OutOfMemory = unchecked((int)0x8007000E);
        public const int E_InvalidArgument = unchecked((int)0x80070057);
        public const int E_BufferTooSmall = unchecked((int)0x8007007a);

        public static bool Succeeded(int hr)
        {
            return hr >= 0;
        }

        public static bool Failed(int hr)
        {
            return hr < 0;
        }

        public static void SafeRelease(object o)
        {
            if (o != null)
            {
                IDisposable id = o as IDisposable;
                if (id != null)
                {
                    id.Dispose();
                }
                else
                {
                    try
                    {
                        // While this code will make any c++ COM programmer shudder,
                        // it actually is appropriate for c#.
                        while (Marshal.ReleaseComObject(o) > 0)
                            ;
                    }
                    catch { }
                }
            }
        }
    }

    #endregion

    #region Internal classes

    // These classes are used internally and there is probably no reason you will ever
    // need to use them directly.

    // Class to release PropVariants on parameters that output PropVariants.  There
    // should be no reason for code to call this class directly.  It is invoked
    // automatically when the appropriate methods are called.
    internal class PVMarshaler : ICustomMarshaler
    {
        // The managed object passed in to MarshalManagedToNative
        protected PropVariant m_prop;

        public PVMarshaler()
        {
        }

        public IntPtr MarshalManagedToNative(object managedObj)
        {
            IntPtr p;

            // Cast the object back to a PropVariant
            m_prop = managedObj as PropVariant;

            if (m_prop != null)
            {
                // Release any memory currently allocated
                m_prop.Clear();

                // Create an appropriately sized buffer, blank it, and send it to 
                // the marshaler to make the COM call with.
                int iSize = GetNativeDataSize();
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
            Marshal.PtrToStructure(pNativeData, m_prop);
            m_prop = null;

            return m_prop;
        }

        // It appears this routine is never called
        public void CleanUpManagedData(object ManagedObj)
        {
            m_prop = null;
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
            Marshal.FreeCoTaskMem(pNativeData);
        }

        // The number of bytes to marshal out
        public int GetNativeDataSize()
        {
            return Marshal.SizeOf(typeof(PropVariant));
        }

        // This method is called by interop to create the custom marshaler.  The (optional)
        // cookie is the value specified in MarshalCookie="asdf", or "" is none is specified.
        public static ICustomMarshaler GetInstance(string cookie)
        {
            return new PVMarshaler();
        }
    }

    // Class to handle WAVEFORMATEXTENSIBLE
    internal class WEMarshaler : ICustomMarshaler
    {
        public WEMarshaler()
        {
        }

        public IntPtr MarshalManagedToNative(object managedObj)
        {
            WaveFormatEx wfe = managedObj as WaveFormatEx;

            IntPtr ip = wfe.GetPtr();

            return ip;
        }

        // Called just after invoking the COM method.  The IntPtr is the same one that just got returned
        // from MarshalManagedToNative.  The return value is unused.
        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            WaveFormatEx wfe = WaveFormatEx.PtrToWave(pNativeData);

            return wfe;
        }

        // It appears this routine is never called
        public void CleanUpManagedData(object ManagedObj)
        {
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
            return new WEMarshaler();
        }
    }

    // Class to handle BITMAPINFO
    internal class BMMarshaler : ICustomMarshaler
    {
        protected BitmapInfoHeader m_bmi;

        public BMMarshaler()
        {
        }

        public IntPtr MarshalManagedToNative(object managedObj)
        {
            m_bmi = managedObj as BitmapInfoHeader;

            IntPtr ip = m_bmi.GetPtr();

            return ip;
        }

        // Called just after invoking the COM method.  The IntPtr is the same one that just got returned
        // from MarshalManagedToNative.  The return value is unused.
        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            BitmapInfoHeader bmi = BitmapInfoHeader.PtrToBMI(pNativeData);

            // If we this call is In+Out, the return value is ignored.  If
            // this is out, then m_bmi will be null.
            if (m_bmi != null)
            {
                m_bmi.CopyFrom(bmi);
                bmi = null;
            }

            return bmi;
        }

        // It appears this routine is never called
        public void CleanUpManagedData(object ManagedObj)
        {
            m_bmi = null;
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

    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Class)]
    public class UnmanagedNameAttribute : System.Attribute
    {
        private string m_Name;

        public UnmanagedNameAttribute(string s)
        {
            m_Name = s;
        }

        public override string ToString()
        {
            return m_Name;
        }
    }

    #endregion
}
