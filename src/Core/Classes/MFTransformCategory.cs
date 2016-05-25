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
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

using MediaFoundation.Misc;
using MediaFoundation;
using System.Drawing;
using MediaFoundation.Transform.Enums;
using MediaFoundation.Transform.Classes;

namespace MediaFoundation.Core.Classes
{
    /// <summary>
    /// The following GUIDs define categories for Media Foundation transforms (MFTs). These categories are
    /// used to register and enumerate MFTs.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/ECA3AE3B-E40A-407D-986C-D0A85B891F52(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/ECA3AE3B-E40A-407D-986C-D0A85B891F52(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public class MFTransformCategory : GuidEnum
    {
        public MFTransformCategory(Guid serviceGuid)
            : base(serviceGuid)
        {
        }

        public MFTransformCategory(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
            : this(new Guid(a, b, c, d, e, f, g, h, i, j, k))
        {
        }

        /// <summary>
        /// Media Foundation transforms (MFTs) category for <strong>video decoders</strong>.
        /// </summary>
        public static readonly MFTransformCategory VideoDecoder = new MFTransformCategory(0xd6c02d4b, 0x6833, 0x45b4, 0x97, 0x1a, 0x05, 0xa4, 0xb0, 0x4b, 0xab, 0x91);

        // {f79eac7d-e545-4387-bdee-d647d7bde42a}   MFT_CATEGORY_VIDEO_ENCODER

        /// <summary>
        /// Media Foundation transforms (MFTs) category for <strong>video encoders</strong>.
        /// </summary>
        public static readonly MFTransformCategory VideoEncoder = new MFTransformCategory(0xf79eac7d, 0xe545, 0x4387, 0xbd, 0xee, 0xd6, 0x47, 0xd7, 0xbd, 0xe4, 0x2a);

        // {12e17c21-532c-4a6e-8a1c-40825a736397}   MFT_CATEGORY_VIDEO_EFFECT

        /// <summary>
        /// Media Foundation transforms (MFTs) category for <strong>video effects</strong>.
        /// </summary>
        public static readonly MFTransformCategory VideoEffect = new MFTransformCategory(0x12e17c21, 0x532c, 0x4a6e, 0x8a, 0x1c, 0x40, 0x82, 0x5a, 0x73, 0x63, 0x97);

        // {059c561e-05ae-4b61-b69d-55b61ee54a7b}   MFT_CATEGORY_MULTIPLEXER

        /// <summary>
        /// Media Foundation transforms (MFTs) category for <strong>multiplexers</strong>.
        /// </summary>
        /// <remarks>
        /// Note  In Windows Vista, the Media Foundation pipeline does not support
        /// MFTs with more than one input. Multiple-input MFTs are supported in Windows 7.
        /// </remarks>
        public static readonly MFTransformCategory Multiplexer = new MFTransformCategory(0x059c561e, 0x05ae, 0x4b61, 0xb6, 0x9d, 0x55, 0xb6, 0x1e, 0xe5, 0x4a, 0x7b);

        // {a8700a7a-939b-44c5-99d7-76226b23b3f1}   MFT_CATEGORY_DEMULTIPLEXER

        /// <summary>
        /// Media Foundation transforms (MFTs) category for <strong>demultiplexers</strong>.
        /// </summary>
        public static readonly MFTransformCategory Demultiplexer = new MFTransformCategory(0xa8700a7a, 0x939b, 0x44c5, 0x99, 0xd7, 0x76, 0x22, 0x6b, 0x23, 0xb3, 0xf1);

        // {9ea73fb4-ef7a-4559-8d5d-719d8f0426c7}   MFT_CATEGORY_AUDIO_DECODER

        /// <summary>
        /// Media Foundation transforms (MFTs) category for <strong>audio decoders</strong>.
        /// </summary>
        public static readonly MFTransformCategory AudioDecoder = new MFTransformCategory(0x9ea73fb4, 0xef7a, 0x4559, 0x8d, 0x5d, 0x71, 0x9d, 0x8f, 0x04, 0x26, 0xc7);

        // {91c64bd0-f91e-4d8c-9276-db248279d975}   MFT_CATEGORY_AUDIO_ENCODER

        /// <summary>
        /// Media Foundation transforms (MFTs) category for <strong>audio encoders</strong>.
        /// </summary>
        public static readonly MFTransformCategory AudioEncoder = new MFTransformCategory(0x91c64bd0, 0xf91e, 0x4d8c, 0x92, 0x76, 0xdb, 0x24, 0x82, 0x79, 0xd9, 0x75);

        // {11064c48-3648-4ed0-932e-05ce8ac811b7}   MFT_CATEGORY_AUDIO_EFFECT

        /// <summary>
        /// aMedia Foundation transforms (MFTs) category for <strong>audio effects</strong>.
        /// </summary>
        public static readonly MFTransformCategory AudioEffect = new MFTransformCategory(0x11064c48, 0x3648, 0x4ed0, 0x93, 0x2e, 0x05, 0xce, 0x8a, 0xc8, 0x11, 0xb7);

        // {302EA3FC-AA5F-47f9-9F7A-C2188BB163021}   MFT_CATEGORY_VIDEO_PROCESSOR

        /// <summary>
        /// Media Foundation transforms (MFTs) category for <strong>video processors</strong>.
        /// </summary>
        /// <remarks>
        /// Note: Introduced in Windows 7.
        /// <para/>
        /// This category is limited to MFTs that perform format conversions on uncompressed video,
        /// including color-space conversions. For video effects that modify the appearance of the image
        /// (such as a blur effect or a color-to-grayscale transform), use the MFT_CATEGORY_VIDEO_EFFECT category.
        /// </remarks>
        public static readonly MFTransformCategory VideoProcessor = new MFTransformCategory(0x302ea3fc, 0xaa5f, 0x47f9, 0x9f, 0x7a, 0xc2, 0x18, 0x8b, 0xb1, 0x63, 0x2);

        // {90175d57-b7ea-4901-aeb3-933a8747756f}   MFT_CATEGORY_OTHER

        /// <summary>
        /// Media Foundation transforms (MFTs) category for <strong>miscellaneous MFTs</strong>.
        /// </summary>
        public static readonly MFTransformCategory Other = new MFTransformCategory(0x90175d57, 0xb7ea, 0x4901, 0xae, 0xb3, 0x93, 0x3a, 0x87, 0x47, 0x75, 0x6f);

        /// <summary>
        /// The category of MFTs to enumerate.
        /// </summary>
        /// <param name="category">The category of MFTs to enumerate.</param>
        /// <param name="flags">Flags for enumeration of Media Foundation transforms (MFTs).</param>
        /// <returns>
        /// An array of <see cref="Activate"/> objects. Each object represents an activation object for an
        /// MFT that matches the search criteria. The caller must release the objects.
        /// </returns>
        public static Activate[] GetTransforms(MFTransformCategory category)
        {
            return MFTransformCategory.GetTransforms(category, MFT_EnumFlag.All);
        }

        /// <summary>
        /// The category of MFTs to enumerate.
        /// </summary>
        /// <param name="category">The category of MFTs to enumerate.</param>
        /// <param name="flags">Flags for enumeration of Media Foundation transforms (MFTs).</param>
        /// <returns>
        /// An array of <see cref="Activate"/> objects. Each object represents an activation object for an
        /// MFT that matches the search criteria. The caller must release the objects.
        /// </returns>
        public static Activate[] GetTransforms(MFTransformCategory category, MFT_EnumFlag flags)
        {
            return MFTransformCategory.GetTransforms(category, flags, null, null, null, null);
        }

        /// <summary>
        /// The category of MFTs to enumerate.
        /// </summary>
        /// <param name="category">The category of MFTs to enumerate.</param>
        /// <param name="flags">Flags for enumeration of Media Foundation transforms (MFTs).</param>
        /// <param name="inputMajorType">Optional. Specifies an input media type to match.</param>
        /// <param name="inputSubType">Optional. Specifies an input media type to match.</param>
        /// <param name="outputMajorType">Optional. Specifies an output media type to match.</param>
        /// <param name="outputSubType">Optional. Specifies an output media type to match.</param>
        /// <returns>
        /// An array of <see cref="Activate"/> objects. Each object represents an activation object for an
        /// MFT that matches the search criteria. The caller must release the objects.
        /// </returns>
        public static Activate[] GetTransforms(MFTransformCategory category, MFT_EnumFlag flags, MFMediaType.MajorType inputMajorType, MFMediaType.SubType inputSubType, MFMediaType.MajorType outputMajorType, MFMediaType.SubType outputSubType)
        {
            MFTRegisterTypeInfo pInputType = null;
            if (inputMajorType != null)
            {
                pInputType = new MFTRegisterTypeInfo();
                pInputType.guidMajorType = inputMajorType;
                pInputType.guidSubtype = inputSubType;
            }

            MFTRegisterTypeInfo pOutputType = null;
            if (outputMajorType != null)
            {
                pOutputType = new MFTRegisterTypeInfo();
                pOutputType.guidMajorType = outputMajorType;
                pOutputType.guidSubtype = outputSubType;
            }

            int cnt;
            IntPtr pppMFTActivate;
            int hr = MFExtern.MFTEnumEx(category, (int)flags, pInputType, pOutputType, out pppMFTActivate, out cnt);
            COM.ThrowIfNotOK(hr);

            try
            {
                Activate[] result = new Activate[cnt];
                for (int i = 0; i < cnt; i++)
                {
                    IntPtr pActivate = Marshal.ReadIntPtr(pppMFTActivate, i * IntPtr.Size);
                    result[i] = Activate.FromUnknown(ref pActivate);
                }

                return result;
            }
            finally
            {
                Marshal.FreeCoTaskMem(pppMFTActivate);
            }
        }
    }
}