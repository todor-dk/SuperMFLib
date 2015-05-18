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
    /// The <strong>WAVEFORMATEX</strong> structure defines the format of waveform-audio data. Only format
    /// information common to all waveform-audio data formats is included in this structure. For formats
    /// that require additional information, this structure is included as the first member in another
    /// structure, along with the additional information. 
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct {
    ///   WORD  wFormatTag;
    ///   WORD  nChannels;
    ///   DWORD nSamplesPerSec;
    ///   DWORD nAvgBytesPerSec;
    ///   WORD  nBlockAlign;
    ///   WORD  wBitsPerSample;
    ///   WORD  cbSize;
    /// } WAVEFORMATEX;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/4F3BF6FB-B15F-43B3-82F1-E7A8A3007057(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4F3BF6FB-B15F-43B3-82F1-E7A8A3007057(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 1), UnmanagedName("WAVEFORMATEX")]
    internal class  WaveFormatEx
    {
        /// <summary>
        /// Waveform-audio format type. Format tags are registered with Microsoft Corporation for many
        /// compression algorithms. A complete list of format tags can be found in the Mmreg.h header file. For
        /// one- or two-channel Pulse Code Modulation (PCM) data, this value should be WAVE_FORMAT_PCM.
        /// <para/>
        /// <para>* If <strong>wFormatTag</strong> equals WAVE_FORMAT_EXTENSIBLE, the structure is interpreted
        /// as a <see cref="Misc.WaveFormatExtensible"/> structure. </para><para>* If <strong>wFormatTag
        /// </strong> equals WAVE_FORMAT_MPEG, the structure is interpreted as an <c>MPEG1WAVEFORMAT</c>
        /// structure. </para><para>* If <strong>wFormatTag</strong> equals WAVE_FORMAT_MPEGLAYER3, the
        /// structure is interpreted as an <c>MPEGLAYER3WAVEFORMAT</c> structure. </para>
        /// <para/>
        /// Before reinterpreting a <strong>WAVEFORMATEX</strong> structure as one of these extended
        /// structures, verify that the actual structure size is sufficiently large and that the <strong>cbSize
        /// </strong> member indicates a valid size. 
        /// </summary>
        public short wFormatTag;
        /// <summary>
        /// Number of channels in the waveform-audio data. Monaural data uses one channel and stereo data uses
        /// two channels.
        /// </summary>
        public short nChannels;
        /// <summary>
        /// Sample rate, in samples per second (hertz). If <strong>wFormatTag</strong> is WAVE_FORMAT_PCM, then
        /// common values for <strong>nSamplesPerSec</strong> are 8.0 kHz, 11.025 kHz, 22.05 kHz, and 44.1 kHz.
        /// For non-PCM formats, this member must be computed according to the manufacturer's specification of
        /// the format tag. 
        /// </summary>
        public int nSamplesPerSec;
        /// <summary>
        /// Required average data-transfer rate, in bytes per second, for the format tag. If <strong>wFormatTag
        /// </strong> is WAVE_FORMAT_PCM, <strong>nAvgBytesPerSec</strong> must equal <strong>nSamplesPerSec
        /// </strong> × <strong>nBlockAlign</strong>. For non-PCM formats, this member must be computed
        /// according to the manufacturer's specification of the format tag. 
        /// </summary>
        public int nAvgBytesPerSec;
        /// <summary>
        /// Block alignment, in bytes. The block alignment is the minimum atomic unit of data for the <strong>
        /// wFormatTag</strong> format type. If <strong>wFormatTag</strong> is WAVE_FORMAT_PCM, <strong>
        /// nBlockAlign</strong> must equal ( <strong>nChannels</strong> × <strong>wBitsPerSample</strong>) /
        /// 8. For non-PCM formats, this member must be computed according to the manufacturer's specification
        /// of the format tag. 
        /// <para/>
        /// Software must process a multiple of <strong>nBlockAlign</strong> bytes of data at a time. Data
        /// written to and read from a device must always start at the beginning of a block. For example, it is
        /// illegal to start playback of PCM data in the middle of a sample (that is, on a non-block-aligned
        /// boundary). 
        /// </summary>
        public short nBlockAlign;
        /// <summary>
        /// Bits per sample for the <strong>wFormatTag</strong> format type. If <strong>wFormatTag</strong> is 
        /// <strong>WAVE_FORMAT_PCM</strong>, then <strong>wBitsPerSample</strong> should be equal to 8 or 16.
        /// For non-PCM formats, this member must be set according to the manufacturer's specification of the
        /// format tag. If <strong>wFormatTag</strong> is <strong>WAVE_FORMAT_EXTENSIBLE</strong>, this value
        /// can be any integer multiple of 8. 
        /// <para/>
        /// Some compression schemes do not define a value for <strong>wBitsPerSample</strong>, so this member
        /// can be zero. 
        /// </summary>
        public short wBitsPerSample;
        /// <summary>
        /// Size, in bytes, of extra format information appended to the end of the <strong>WAVEFORMATEX
        /// </strong> structure. This information can be used by non-PCM formats to store extra attributes for
        /// the <strong>wFormatTag</strong>. If no extra information is required by the <strong>wFormatTag
        /// </strong>, this member must be set to zero. For <strong>WAVE_FORMAT_PCM</strong> formats (and only 
        /// <strong>WAVE_FORMAT_PCM</strong> formats), this member is ignored. However it is still recommended
        /// to set the value. 
        /// </summary>
        public short cbSize;

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", wFormatTag, nChannels, nSamplesPerSec, wBitsPerSample);
        }

        /// <summary>
        /// Marshals this instance to unmanaged memory and returns the pointer to that memory location.
        /// </summary>
        /// <returns>
        /// An integer representing the address of the block of memory allocated. 
        /// This memory must be released with <see cref="Marshal.FreeCoTaskMem"/>.
        /// </returns>
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

        /// <summary>
        /// Marshals the unmanaged memory location given in the memory pointer <paramref name="pNativeData"/>
        /// to <see cref="WaveFormatEx"/> object.
        /// </summary>
        /// <param name="pNativeData">Memory location pointing to a <c>WAVEFORMATEX</c> structure.</param>
        /// <returns>A WaveFormatEx object from the given memory location.</returns>
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

        /// <summary>
        /// Implements the equality operator.
        /// </summary>
        /// <param name="a">The left operand to compare for equality.</param>
        /// <param name="b">The right operand to compare for equality.</param>
        /// <returns>The result of the equality comparison operator.</returns>
        public static bool operator ==(WaveFormatEx a, WaveFormatEx b)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            bool bRet;
            Type t1 = a.GetType();
            Type t2 = b.GetType();

            if (t1 == t2 &&
                a.wFormatTag == b.wFormatTag &&
                a.nChannels == b.nChannels &&
                a.nSamplesPerSec == b.nSamplesPerSec &&
                a.nAvgBytesPerSec == b.nAvgBytesPerSec &&
                a.nBlockAlign == b.nBlockAlign &&
                a.wBitsPerSample == b.wBitsPerSample &&
                a.cbSize == b.cbSize)
            {
                bRet = true;
            }
            else
            {
                bRet = false;
            }

            return bRet;
        }

        /// <summary>
        /// Implements the inequality operator.
        /// </summary>
        /// <param name="a">The left operand to compare for inequality.</param>
        /// <param name="b">The right operand to compare for inequality.</param>
        /// <returns>The result of the inequality comparison operator.</returns>
        public static bool operator !=(WaveFormatEx a, WaveFormatEx b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return this == (obj as WaveFormatEx);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            return nAvgBytesPerSec + wFormatTag;
        }
    }

#endif
}
