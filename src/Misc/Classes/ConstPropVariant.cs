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
using MediaFoundation.Core.Enums;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// <see cref="ConstPropVariant"/> is used for [In] parameters.  This is important since
    /// for [In] parameters, you must *not* clear the <see cref="PropVariant"/>.  The caller
    /// will need to do that himself.
    /// <para/>
    /// Likewise, if you want to store a copy of a <see cref="ConstPropVariant"/>, you should
    /// store it to a <see cref="PropVariant"/> using the <see cref="PropVariant"/> constructor that takes a
    /// <see cref="ConstPropVariant"/>.  If you try to store the <see cref="ConstPropVariant"/>, when the
    /// caller frees his copy, yours will no longer be valid.
    /// <para/>
    /// The <strong>PROPVARIANT</strong> structure is used in the <c>ReadMultiple</c> and
    /// <c>WriteMultiple</c> methods of <c>IPropertyStorage</c> to define the type tag and the value of a
    /// property in a property set.
    /// <para/>
    /// The <strong>PROPVARIANT</strong> structure is also used by the <c>GetValue</c> and <c>SetValue</c>
    /// methods of <see cref="Misc.IPropertyStore"/>, which replaces <c>IPropertySetStorage</c> as the
    /// primary way to program item properties in Windows Vista. For more information, see
    /// <c>Property Handlers</c>.
    /// <para/>
    /// There are five members. The first member, the value-type tag, and the last member, the value of the
    /// property, are significant. The middle three members are reserved for future use.
    /// <para/>
    ///     <strong>Note</strong> The <strong>bool</strong> member in previous definitions of this structure
    /// has been renamed to <strong>boolVal</strong>, because some compilers now recognize <strong>bool
    /// </strong> as a keyword.
    /// <para/>
    ///     <strong>Note</strong> The <strong>PROPVARIANT</strong> structure, defined below, includes types
    /// that can be serialized in the version 1 property set serialization format. The version 1 format
    /// supports all types allowed in the version 0 format plus some additional types. The added types
    /// include "Version 1" in the comment field below. Use these types only if a version 1 property set is
    /// intended. For more information, see <c>Property Set Serialization</c>.
    /// <para/>
    /// The <strong>PROPVARIANT</strong> structure is defined as follows:
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct PROPVARIANT {
    ///   VARTYPE vt;
    ///   WORD    wReserved1;
    ///   WORD    wReserved2;
    ///   WORD    wReserved3;
    ///   union {
    ///     CHAR              cVal;
    ///     UCHAR             bVal;
    ///     SHORT             iVal;
    ///     USHORT            uiVal;
    ///     LONG              lVal;
    ///     ULONG             ulVal;
    ///     INT               intVal;
    ///     UINT              uintVal;
    ///     LARGE_INTEGER     hVal;
    ///     ULARGE_INTEGER    uhVal;
    ///     FLOAT             fltVal;
    ///     DOUBLE            dblVal;
    ///     VARIANT_BOOL      boolVal;
    ///     SCODE             scode;
    ///     CY                cyVal;
    ///     DATE              date;
    ///     FILETIME          filetime;
    ///     CLSID             *puuid;
    ///     CLIPDATA          *pclipdata;
    ///     BSTR              bstrVal;
    ///     BSTRBLOB          bstrblobVal;
    ///     BLOB              blob;
    ///     LPSTR             pszVal;
    ///     LPWSTR            pwszVal;
    ///     IUnknown          *punkVal;
    ///     IDispatch         *pdispVal;
    ///     IStream           *pStream;
    ///     IStorage          *pStorage;
    ///     LPVERSIONEDSTREAM pVersionedStream;
    ///     LPSAFEARRAY       parray;
    ///     CAC               cac;
    ///     CAUB              caub;
    ///     CAI               cai;
    ///     CAUI              caui;
    ///     CAL               cal;
    ///     CAUL              caul;
    ///     CAH               cah;
    ///     CAUH              cauh;
    ///     CAFLT             caflt;
    ///     CADBL             cadbl;
    ///     CABOOL            cabool;
    ///     CASCODE           cascode;
    ///     CACY              cacy;
    ///     CADATE            cadate;
    ///     CAFILETIME        cafiletime;
    ///     CACLSID           cauuid;
    ///     CACLIPDATA        caclipdata;
    ///     CABSTR            cabstr;
    ///     CABSTRBLOB        cabstrblob;
    ///     CALPSTR           calpstr;
    ///     CALPWSTR          calpwstr;
    ///     CAPROPVARIANT     capropvar;
    ///     CHAR              *pcVal;
    ///     UCHAR             *pbVal;
    ///     SHORT             *piVal;
    ///     USHORT            *puiVal;
    ///     LONG              *plVal;
    ///     ULONG             *pulVal;
    ///     INT               *pintVal;
    ///     UINT              *puintVal;
    ///     FLOAT             *pfltVal;
    ///     DOUBLE            *pdblVal;
    ///     VARIANT_BOOL      *pboolVal;
    ///     DECIMAL           *pdecVal;
    ///     SCODE             *pscode;
    ///     CY                *pcyVal;
    ///     DATE              *pdate;
    ///     BSTR              *pbstrVal;
    ///     IUnknown          **ppunkVal;
    ///     IDispatch         **ppdispVal;
    ///     LPSAFEARRAY       *pparray;
    ///     PROPVARIANT       *pvarVal;
    ///   };
    /// } PROPVARIANT;
    /// </code>
    ///     <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/E86CC279-826D-4767-8D96-FC8280060EA1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E86CC279-826D-4767-8D96-FC8280060EA1(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    /// <seealso cref="PropVariant"/>
    [StructLayout(LayoutKind.Explicit)]
    public class ConstPropVariant : IDisposable
    {
        /// <summary>
        /// Creates a copy of a <c>PROPVARIANT</c> structure.
        /// </summary>
        /// <param name="pvarDest">
        /// Type: <strong><c>PROPVARIANT</c>* </strong>
        /// <para/>
        /// Pointer to the destination <c>PROPVARIANT</c> structure that receives the copy.
        /// </param>
        /// <param name="pvarSource">
        /// Type: <strong>const <c>PROPVARIANT</c>* </strong>
        /// <para/>
        /// Pointer to the source <c>PROPVARIANT</c> structure.
        /// </param>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT PropVariantCopy(
        ///   _Out_  PROPVARIANT *pvarDest,
        ///   _In_   const PROPVARIANT *pvarSrc
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/F17F1722-F041-414C-B838-F1F83427FF0C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F17F1722-F041-414C-B838-F1F83427FF0C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("ole32.dll", ExactSpelling = true, PreserveSig = false)]
        [SuppressUnmanagedCodeSecurity]
        protected static extern void PropVariantCopy(
            [Out, MarshalAs(UnmanagedType.LPStruct)] PropVariant pvarDest,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant pvarSource);

        /// <summary>
        /// Specifies the variant type of the value contained in the <see cref="ConstPropVariant"/>.
        /// </summary>
        [UnmanagedName("VARTYPE")]
        public enum VariantType : short
        {
            /// <summary>
            /// <strong>VT_EMPTY</strong>. Valid member: None.
            /// <para/>
            /// A property with a type indicator of VT_EMPTY has no data associated with it;
            /// that is, the size of the value is zero.
            /// </summary>
            None = 0,

            /// <summary>
            /// <strong>VT_I2</strong>. Valid Propvariant Member: <see cref="ConstPropVariant.iVal"/>.
            /// <para/>
            /// Two bytes representing a 2-byte signed integer value.
            /// </summary>
            Short = 2,

            /// <summary>
            /// <strong>VT_I4</strong>. Valid Propvariant Member: <see cref="ConstPropVariant.intValue"/>.
            /// <para/>
            /// 4-byte signed integer value.
            /// </summary>
            Int32 = 3,

            /// <summary>
            /// <strong>VT_R4</strong>. Valid Propvariant Member: <see cref="ConstPropVariant.fltVal"/>.
            /// <para/>
            /// 32-bit IEEE floating point value.
            /// </summary>
            Float = 4,

            /// <summary>
            /// <strong>VT_R8</strong>. Valid Propvariant Member: <see cref="ConstPropVariant.doubleValue"/>.
            /// <para/>
            /// 64-bit IEEE floating point value.
            /// </summary>
            Double = 5,

            /// <summary>
            /// <strong>VT_UNKNOWN</strong>. Valid Propvariant Member: <see cref="ConstPropVariant.ptr"/>.
            /// <para/>
            /// Pointer to an IUnknown interface.
            /// </summary>
            IUnknown = 13,

            /// <summary>
            /// <strong>VT_UI1</strong>. Valid Propvariant Member: <see cref="ConstPropVariant.bVal"/>.
            /// <para/>
            /// 1-byte unsigned integer.
            /// </summary>
            UByte = 17,

            /// <summary>
            /// <strong>VT_UI2</strong>. Valid Propvariant Member: <see cref="ConstPropVariant.uiVal"/>.
            /// <para/>
            /// 2-byte unsigned integer.
            /// </summary>
            UShort = 18,

            /// <summary>
            /// <strong>VT_UI4</strong>. Valid Propvariant Member: <see cref="ConstPropVariant.uintVal"/>.
            /// <para/>
            /// 4-byte unsigned integer.
            /// </summary>
            UInt32 = 19,

            /// <summary>
            /// <strong>VT_I8</strong>. Valid Propvariant Member: <see cref="ConstPropVariant.longValue"/>.
            /// <para/>
            /// 8-byte signed integer.
            /// </summary>
            Int64 = 20,

            /// <summary>
            /// <strong>VT_UI8</strong>. Valid Propvariant Member: <see cref="ConstPropVariant.ulongValue"/>.
            /// <para/>
            /// 8-byte unsigned integer.
            /// </summary>
            UInt64 = 21,

            /// <summary>
            /// <strong>VT_LPWSTR</strong>. Valid Propvariant Member: <see cref="ConstPropVariant.ptr"/>.
            /// <para/>
            /// A pointer to a null-terminated Unicode string in the user default locale.
            /// </summary>
            String = 31,

            /// <summary>
            /// <strong>VT_CLSID</strong>. Valid Propvariant Member: <see cref="ConstPropVariant.ptr"/>.
            /// <para/>
            /// Pointer to a class identifier (CLSID) (or other globally unique identifier (GUID)).
            /// </summary>
            Guid = 72,

            /// <summary>
            /// <strong>VT_VECTOR | VT_UI1</strong>. Valid Propvariant Member: <see cref="ConstPropVariant.blobValue"/>.
            /// <para/>
            /// Array of bytes.
            /// </summary>
            Blob = 0x1000 + 17,

            /// <summary>
            /// <strong>VT_VECTOR | VT_LPWSTR</strong>. Valid Propvariant Member: <see cref="ConstPropVariant.calpwstrVal"/>.
            /// <para/>
            /// Array of strings.
            /// </summary>
            StringArray = 0x1000 + 31
        }

        /// <summary>
        /// Represents a counted array of unsigned bytes.
        /// This is used when the <see cref="ConstPropVariant.ValueType"/> is <see cref="VariantType.Blob"/>.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        [UnmanagedName("BLOB")] // UnmanagedName("CAUB")
        protected struct Blob
        {
            /// <summary>
            /// Element count of the array.
            /// </summary>
            public int cbSize;

            /// <summary>
            /// Pointer to the first value of the array.
            /// </summary>
            public IntPtr pBlobData;
        }

        /// <summary>
        /// Represents a counted array of strings.
        /// This is used when the <see cref="ConstPropVariant.ValueType"/> is <see cref="VariantType.StringArray"/>.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        [UnmanagedName("CALPWSTR")]
        protected struct CALPWstr
        {
            /// <summary>
            /// Element count of the array.
            /// </summary>
            public int cElems;

            /// <summary>
            /// Pointer to the first string in the array.
            /// </summary>
            public IntPtr pElems;
        }

        #region Member variables

        /// <summary>
        /// Value type tag.
        /// </summary>
        [FieldOffset(0)]
        protected VariantType type;

        /// <summary>
        /// Reserved for future use.
        /// </summary>
        [FieldOffset(2)]
        protected short reserved1;

        /// <summary>
        /// Reserved for future use.
        /// </summary>
        [FieldOffset(4)]
        protected short reserved2;

        /// <summary>
        /// Reserved for future use.
        /// </summary>
        [FieldOffset(6)]
        protected short reserved3;

        /// <summary>
        /// Valid when <see cref="type"/> is VT_I2.
        /// </summary>
        [FieldOffset(8)]
        protected short iVal;

        /// <summary>
        /// Valid when <see cref="type"/> is VT_UI2.
        /// </summary>
        [FieldOffset(8)]
        [CLSCompliant(false)]
        protected ushort uiVal;

        /// <summary>
        /// Valid when <see cref="type"/> is VT_UI1.
        /// </summary>
        [FieldOffset(8)]
        [CLSCompliant(false)]
        protected byte bVal;

        /// <summary>
        /// Valid when <see cref="type"/> is VT_INT.
        /// </summary>
        [FieldOffset(8)]
        protected int intValue;

        /// <summary>
        /// Valid when <see cref="type"/> is VT_UINT.
        /// </summary>
        [FieldOffset(8)]
        [CLSCompliant(false)]
        protected uint uintVal;

        /// <summary>
        /// Valid when <see cref="type"/> is VT_R4.
        /// </summary>
        [FieldOffset(8)]
        protected float fltVal;

        /// <summary>
        /// Valid when <see cref="type"/> is VT_I8.
        /// </summary>
        [FieldOffset(8)]
        protected long longValue;

        /// <summary>
        /// Valid when <see cref="type"/> is VT_UI8.
        /// </summary>
        [FieldOffset(8)]
        [CLSCompliant(false)]
        protected ulong ulongValue;

        /// <summary>
        /// Valid when <see cref="type"/> is VT_R8.
        /// </summary>
        [FieldOffset(8)]
        protected double doubleValue;

        /// <summary>
        /// Valid when <see cref="type"/> is ***.
        /// </summary>
        [FieldOffset(8)]
        protected Blob blobValue;

        /// <summary>
        /// Valid when <see cref="type"/> is pointer to a value.
        /// </summary>
        [FieldOffset(8)]
        protected IntPtr ptr;

        /// <summary>
        /// Valid when <see cref="type"/> is VT_VECTOR | VT_LPWSTR.
        /// </summary>
        [FieldOffset(8)]
        protected CALPWstr calpwstrVal;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstPropVariant"/> class.
        /// </summary>
        public ConstPropVariant()
        {
            this.type = VariantType.None;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstPropVariant"/> class.
        /// </summary>
        /// <param name="v">The type of the value.</param>
        protected ConstPropVariant(VariantType v)
        {
            this.type = v;
        }

        /// <summary>
        /// Converts this propvariant to a string by returning its value.
        /// </summary>
        /// <param name="f">Propvariant to convert to string.</param>
        /// <returns>A strings that is the value of the propvariant.</returns>
        /// <exception cref="ArgumentException">
        /// If the <see cref="ValueType"/> is not <see cref="VariantType.String"/>.
        /// </exception>
        public static explicit operator string(ConstPropVariant f)
        {
            return f.GetString();
        }

        /// <summary>
        /// Converts this propvariant to a string array by returning its value.
        /// </summary>
        /// <param name="f">Propvariant to convert to string array.</param>
        /// <returns>An array of strings that is the value of the propvariant.</returns>
        /// <exception cref="ArgumentException">
        /// If the <see cref="ValueType"/> is not <see cref="VariantType.StringArray"/>.
        /// </exception>
        public static explicit operator string[](ConstPropVariant f)
        {
            return f.GetStringArray();
        }

        /// <summary>
        /// Converts this propvariant to an unsigned byte by returning its value.
        /// </summary>
        /// <param name="f">Propvariant to convert to byte.</param>
        /// <returns>An unsigned byte that is the value of the propvariant.</returns>
        /// <exception cref="ArgumentException">
        /// If the <see cref="ValueType"/> is not <see cref="VariantType.UByte"/>.
        /// </exception>
        public static explicit operator byte(ConstPropVariant f)
        {
            return f.GetUByte();
        }

        /// <summary>
        /// Converts this propvariant to a signed 2-byte integer by returning its value.
        /// </summary>
        /// <param name="f">Propvariant to convert to signed 2-byte integer.</param>
        /// <returns>A signed 2-byte integer that is the value of the propvariant.</returns>
        /// <exception cref="ArgumentException">
        /// If the <see cref="ValueType"/> is not <see cref="VariantType.Short"/>.
        /// </exception>
        public static explicit operator short(ConstPropVariant f)
        {
            return f.GetShort();
        }

        /// <summary>
        /// Converts this propvariant to an unsigned 2-byte integer by returning its value.
        /// </summary>
        /// <param name="f">Propvariant to convert to unsigned 2-byte integer.</param>
        /// <returns>An unsigned 2-byte integer that is the value of the propvariant.</returns>
        /// <exception cref="ArgumentException">
        /// If the <see cref="ValueType"/> is not <see cref="VariantType.UShort"/>.
        /// </exception>
        [CLSCompliant(false)]
        public static explicit operator ushort(ConstPropVariant f)
        {
            return f.GetUShort();
        }

        /// <summary>
        /// Converts this propvariant to a signed 4-byte integer by returning its value.
        /// </summary>
        /// <param name="f">Propvariant to convert to signed 4-byte integer.</param>
        /// <returns>A signed 4-byte integer that is the value of the propvariant.</returns>
        /// <exception cref="ArgumentException">
        /// If the <see cref="ValueType"/> is not <see cref="VariantType.Int32"/>.
        /// </exception>
        public static explicit operator int(ConstPropVariant f)
        {
            return f.GetInt();
        }

        /// <summary>
        /// Converts this propvariant to an unsigned 4-byte integer by returning its value.
        /// </summary>
        /// <param name="f">Propvariant to convert to unsigned 4-byte integer.</param>
        /// <returns>An unsigned 4-byte integer that is the value of the propvariant.</returns>
        /// <exception cref="ArgumentException">
        /// If the <see cref="ValueType"/> is not <see cref="VariantType.UInt32"/>.
        /// </exception>
        [CLSCompliant(false)]
        public static explicit operator uint(ConstPropVariant f)
        {
            return f.GetUInt();
        }

        /// <summary>
        /// Converts this propvariant to a 4-byte float by returning its value.
        /// </summary>
        /// <param name="f">Propvariant to convert to 4-byte float.</param>
        /// <returns>A 4-byte float that is the value of the propvariant.</returns>
        /// <exception cref="ArgumentException">
        /// If the <see cref="ValueType"/> is not <see cref="VariantType.Float"/>.
        /// </exception>
        public static explicit operator float(ConstPropVariant f)
        {
            return f.GetFloat();
        }

        /// <summary>
        /// Converts this propvariant to a 8-byte float by returning its value.
        /// </summary>
        /// <param name="f">Propvariant to convert to 8-byte float.</param>
        /// <returns>A 8-byte float that is the value of the propvariant.</returns>
        /// <exception cref="ArgumentException">
        /// If the <see cref="ValueType"/> is not <see cref="VariantType.Double"/>.
        /// </exception>
        public static explicit operator double(ConstPropVariant f)
        {
            return f.GetDouble();
        }

        /// <summary>
        /// Converts this propvariant to a signed 8-byte integer by returning its value.
        /// </summary>
        /// <param name="f">Propvariant to convert to signed 8-byte integer.</param>
        /// <returns>A signed 8-byte integer that is the value of the propvariant.</returns>
        /// <exception cref="ArgumentException">
        /// If the <see cref="ValueType"/> is not <see cref="VariantType.Int64"/>.
        /// </exception>
        public static explicit operator long(ConstPropVariant f)
        {
            return f.GetLong();
        }

        /// <summary>
        /// Converts this propvariant to an unsigned 8-byte integer by returning its value.
        /// </summary>
        /// <param name="f">Propvariant to convert to unsigned 8-byte integer.</param>
        /// <returns>An unsigned 8-byte integer that is the value of the propvariant.</returns>
        /// <exception cref="ArgumentException">
        /// If the <see cref="ValueType"/> is not <see cref="VariantType.UInt64"/>.
        /// </exception>
        [CLSCompliant(false)]
        public static explicit operator ulong(ConstPropVariant f)
        {
            return f.GetULong();
        }

        /// <summary>
        /// Converts this propvariant to a Guid by returning its value.
        /// </summary>
        /// <param name="f">Propvariant to convert to Guid.</param>
        /// <returns>A Guid that is the value of the propvariant.</returns>
        /// <exception cref="ArgumentException">
        /// If the <see cref="ValueType"/> is not <see cref="VariantType.Guid"/>.
        /// </exception>
        public static explicit operator Guid(ConstPropVariant f)
        {
            return f.GetGuid();
        }

        /// <summary>
        /// Converts this propvariant to an array of unsigned bytes (byte array) by returning its value.
        /// </summary>
        /// <param name="f">Propvariant to convert to array of unsigned bytes (byte array).</param>
        /// <returns>A array of unsigned bytes (byte array) that is the value of the propvariant.</returns>
        /// <exception cref="ArgumentException">
        /// If the <see cref="ValueType"/> is not <see cref="VariantType.Blob"/>.
        /// </exception>
        public static explicit operator byte[](ConstPropVariant f)
        {
            return f.GetBlob();
        }

        /// <summary>
        /// Converts, if possible, the <see cref="ValueType" /> of this propvariant
        /// to the corresponding <see cref="MFAttributeType" />.
        /// </summary>
        /// <returns>
        /// The <see cref="MFAttributeType"/> that corresponds to the <see cref="ValueType"/> of this propvariant.
        /// </returns>
        /// <exception cref="System.Exception">
        /// If the <see cref="ValueType"/> cannot be converted to <see cref="MFAttributeType"/>.
        /// </exception>
        public MFAttributeType GetMFAttributeType()
        {
            // I decided not to do implicits since perf is likely to be
            // better recycling the PropVariant, and the only way I can
            // see to support Implicit is to create a new PropVariant.
            // Also, since I can't free the previous instance, IUnknowns
            // will linger until the GC cleans up.  Not what I think I
            // want.
            switch (this.type)
            {
                case VariantType.None:
                case VariantType.UInt32:
                case VariantType.UInt64:
                case VariantType.Double:
                case VariantType.Guid:
                case VariantType.String:
                case VariantType.Blob:
                case VariantType.IUnknown:
                    {
                        return (MFAttributeType)this.type;
                    }

                default:
                    {
                        throw new Exception("Type is not a MFAttributeType");
                    }
            }
        }

        /// <summary>
        /// Value type tag. This is the same as <see cref="ValueType"/>.
        /// </summary>
        /// <returns>The value type tag of this propvariant.</returns>
        public VariantType GetVariantType()
        {
            return this.type;
        }

        /// <summary>
        /// Value type tag. This is the same as <see cref="GetVariantType"/>.
        /// </summary>
        public VariantType ValueType
        {
            get { return this.type; }
        }

        /// <summary>
        /// Returns the value of the propvariant when <see cref="ValueType"/> is <see cref="VariantType.StringArray"/>.
        /// </summary>
        /// <returns>An array of strings that is the value of the propvariant.</returns>
        public string[] GetStringArray()
        {
            if (this.type == VariantType.StringArray)
            {
                string[] sa;

                int iCount = this.calpwstrVal.cElems;
                sa = new string[iCount];

                for (int x = 0; x < iCount; x++)
                {
                    sa[x] = Marshal.PtrToStringUni(Marshal.ReadIntPtr(this.calpwstrVal.pElems, x * IntPtr.Size));
                }

                return sa;
            }

            throw new ArgumentException("PropVariant contents not a string array");
        }

        /// <summary>
        /// Returns the value of the propvariant when <see cref="ValueType"/> is <see cref="VariantType.String"/>.
        /// </summary>
        /// <returns>A strings that is the value of the propvariant.</returns>
        public string GetString()
        {
            if (this.type == VariantType.String)
            {
                return Marshal.PtrToStringUni(this.ptr);
            }

            throw new ArgumentException("PropVariant contents not a string");
        }

        /// <summary>
        /// Returns the value of the propvariant when <see cref="ValueType"/> is <see cref="VariantType.UByte"/>.
        /// </summary>
        /// <returns>An unsigned byte that is the value of the propvariant.</returns>
        public byte GetUByte()
        {
            if (this.type == VariantType.UByte)
            {
                return this.bVal;
            }

            throw new ArgumentException("PropVariant contents not a byte");
        }

        /// <summary>
        /// Returns the value of the propvariant when <see cref="ValueType"/> is <see cref="VariantType.Short"/>.
        /// </summary>
        /// <returns>A signed 2-byte integer that is the value of the propvariant.</returns>
        public short GetShort()
        {
            if (this.type == VariantType.Short)
            {
                return this.iVal;
            }

            throw new ArgumentException("PropVariant contents not an Short");
        }

        /// <summary>
        /// Returns the value of the propvariant when <see cref="ValueType"/> is <see cref="VariantType.UShort"/>.
        /// </summary>
        /// <returns>An unsigned 2-byte integer that is the value of the propvariant.</returns>
        [CLSCompliant(false)]
        public ushort GetUShort()
        {
            if (this.type == VariantType.UShort)
            {
                return this.uiVal;
            }

            throw new ArgumentException("PropVariant contents not an UShort");
        }

        /// <summary>
        /// Returns the value of the propvariant when <see cref="ValueType"/> is <see cref="VariantType.Int32"/>.
        /// </summary>
        /// <returns>A signed 4-byte integer that is the value of the propvariant.</returns>
        public int GetInt()
        {
            if (this.type == VariantType.Int32)
            {
                return this.intValue;
            }

            throw new ArgumentException("PropVariant contents not an int32");
        }

        /// <summary>
        /// Returns the value of the propvariant when <see cref="ValueType"/> is <see cref="VariantType.UInt32"/>.
        /// </summary>
        /// <returns>An unsigned 4-byte integer that is the value of the propvariant.</returns>
        [CLSCompliant(false)]
        public uint GetUInt()
        {
            if (this.type == VariantType.UInt32)
            {
                return this.uintVal;
            }

            throw new ArgumentException("PropVariant contents not an uint32");
        }

        /// <summary>
        /// Returns the value of the propvariant when <see cref="ValueType"/> is <see cref="VariantType.Int64"/>.
        /// </summary>
        /// <returns>A signed 8-byte integer that is the value of the propvariant.</returns>
        public long GetLong()
        {
            if (this.type == VariantType.Int64)
            {
                return this.longValue;
            }

            throw new ArgumentException("PropVariant contents not an int64");
        }

        /// <summary>
        /// Returns the value of the propvariant when <see cref="ValueType"/> is <see cref="VariantType.UInt64"/>.
        /// </summary>
        /// <returns>An unsigned 8-byte integer that is the value of the propvariant.</returns>
        [CLSCompliant(false)]
        public ulong GetULong()
        {
            if (this.type == VariantType.UInt64)
            {
                return this.ulongValue;
            }

            throw new ArgumentException("PropVariant contents not an uint64");
        }

        /// <summary>
        /// Returns the value of the propvariant when <see cref="ValueType"/> is <see cref="VariantType.Float"/>.
        /// </summary>
        /// <returns>A 4-byte floating point that is the value of the propvariant.</returns>
        public float GetFloat()
        {
            if (this.type == VariantType.Float)
            {
                return this.fltVal;
            }

            throw new ArgumentException("PropVariant contents not a Float");
        }

        /// <summary>
        /// Returns the value of the propvariant when <see cref="ValueType"/> is <see cref="VariantType.Double"/>.
        /// </summary>
        /// <returns>A 8-byte floating point that is the value of the propvariant.</returns>
        public double GetDouble()
        {
            if (this.type == VariantType.Double)
            {
                return this.doubleValue;
            }

            throw new ArgumentException("PropVariant contents not a double");
        }

        /// <summary>
        /// Returns the value of the propvariant when <see cref="ValueType"/> is <see cref="VariantType.Guid"/>.
        /// </summary>
        /// <returns>A Guid that is the value of the propvariant.</returns>
        public Guid GetGuid()
        {
            if (this.type == VariantType.Guid)
            {
                return (Guid)Marshal.PtrToStructure(this.ptr, typeof(Guid));
            }

            throw new ArgumentException("PropVariant contents not a Guid");
        }

        /// <summary>
        /// Returns the value of the propvariant when <see cref="ValueType"/> is <see cref="VariantType.Blob"/>.
        /// </summary>
        /// <returns>An array of unsigned bytes (binary array) that is the value of the propvariant.</returns>
        public byte[] GetBlob()
        {
            if (this.type == VariantType.Blob)
            {
                byte[] b = new byte[this.blobValue.cbSize];

                Marshal.Copy(this.blobValue.pBlobData, b, 0, this.blobValue.cbSize);

                return b;
            }

            throw new ArgumentException("PropVariant contents are not a Blob");
        }

        /// <summary>
        /// Returns the value of the propvariant when <see cref="ValueType"/> is <see cref="VariantType.IUnknown"/>.
        /// </summary>
        /// <returns>A COM object that is the value of the propvariant.</returns>
        public object GetIUnknown()
        {
            if (this.type == VariantType.IUnknown)
            {
                return Marshal.GetUniqueObjectForIUnknown(this.ptr);
            }

            throw new ArgumentException("PropVariant contents not an IUnknown");
        }

        /// <summary>
        /// Returns the value of the propvariant as a COM object of type <typeparamref name="TObject"/>
        /// when <see cref="ValueType"/> is <see cref="VariantType.IUnknown"/>.
        /// </summary>
        /// <typeparam name="TObject">Type of the required COM object.</typeparam>
        /// <param name="factory">Delegate for creating COM objects from IUnknown pointers.</param>
        /// <returns>A COM object of type <typeparamref name="TObject"/>.</returns>
        public TObject GetComObject<TObject>(COM.ComFactory<TObject> factory)
            where TObject : class
        {
            Contract.RequiresNotNull(factory, "factory");
            if (this.type == VariantType.IUnknown)
            {
                IntPtr copy = this.ptr;
                if (copy == IntPtr.Zero)
                    return null;

                Marshal.AddRef(copy);
                try
                {
                    return factory(ref copy);
                }
                finally
                {
                    if (copy != IntPtr.Zero)
                        Marshal.Release(copy);
                }
            }

            throw new ArgumentException("PropVariant contents not an IUnknown");
        }

        /// <summary>
        /// Returns the current value of the PROPVARIANT structure.
        /// </summary>
        /// <returns>The current value of this PROPVARIANT structure.</returns>
        public object GetValue()
        {
            switch (this.type)
            {
                case VariantType.None:
                    return null;
                case VariantType.Short:
                    return this.GetShort();
                case VariantType.Int32:
                    return this.GetUInt();
                case VariantType.Float:
                    return this.GetFloat();
                case VariantType.Double:
                    return this.GetDouble();
                case VariantType.IUnknown:
                    return this.GetIUnknown();
                case VariantType.UByte:
                    return this.GetUByte();
                case VariantType.UShort:
                    return this.GetUShort();
                case VariantType.UInt32:
                    return this.GetUInt();
                case VariantType.Int64:
                    return this.GetLong();
                case VariantType.UInt64:
                    return this.GetULong();
                case VariantType.String:
                    return this.GetString();
                case VariantType.Guid:
                    return this.GetGuid();
                case VariantType.Blob:
                    return this.GetBlob();
                case VariantType.StringArray:
                    return this.GetStringArray();
                default:
                    throw new ArgumentException(String.Format("PropVariant contents an unrecognized type: {0}", this.type));
            }
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            // This method is primarily intended for debugging so that a readable string will show
            // up in the output window
            string sRet;

            switch (this.type)
            {
                case VariantType.None:
                    {
                        sRet = "<Empty>";
                        break;
                    }

                case VariantType.Blob:
                    {
                        const string FormatString = "x2"; // Hex 2 digit format
                        const int MaxEntries = 16;

                        byte[] blob = this.GetBlob();

                        // Number of bytes we're going to format
                        int n = Math.Min(MaxEntries, blob.Length);

                        if (n == 0)
                        {
                            sRet = "<Empty Array>";
                        }
                        else
                        {
                            // Only format the first MaxEntries bytes
                            sRet = blob[0].ToString(FormatString);
                            for (int i = 1; i < n; i++)
                            {
                                sRet += ',' + blob[i].ToString(FormatString);
                            }

                            // If the string is longer, add an indicator
                            if (blob.Length > n)
                            {
                                sRet += "...";
                            }
                        }

                        break;
                    }

                case VariantType.Float:
                    {
                        sRet = this.GetFloat().ToString();
                        break;
                    }

                case VariantType.Double:
                    {
                        sRet = this.GetDouble().ToString();
                        break;
                    }

                case VariantType.Guid:
                    {
                        sRet = this.GetGuid().ToString();
                        break;
                    }

                case VariantType.IUnknown:
                    {
                        sRet = this.GetIUnknown().ToString();
                        break;
                    }

                case VariantType.String:
                    {
                        sRet = this.GetString();
                        break;
                    }

                case VariantType.Short:
                    {
                        sRet = this.GetShort().ToString();
                        break;
                    }

                case VariantType.UByte:
                    {
                        sRet = this.GetUByte().ToString();
                        break;
                    }

                case VariantType.UShort:
                    {
                        sRet = this.GetUShort().ToString();
                        break;
                    }

                case VariantType.Int32:
                    {
                        sRet = this.GetInt().ToString();
                        break;
                    }

                case VariantType.UInt32:
                    {
                        sRet = this.GetUInt().ToString();
                        break;
                    }

                case VariantType.Int64:
                    {
                        sRet = this.GetLong().ToString();
                        break;
                    }

                case VariantType.UInt64:
                    {
                        sRet = this.GetULong().ToString();
                        break;
                    }

                case VariantType.StringArray:
                    {
                        sRet = "";
                        foreach (string entry in this.GetStringArray())
                        {
                            sRet += (sRet.Length == 0 ? "\"" : ",\"") + entry + '\"';
                        }

                        break;
                    }

                default:
                    {
                        sRet = base.ToString();
                        break;
                    }
            }

            return sRet;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            // Give a (slightly) better hash value in case someone uses PropVariants
            // in a hash table.
            int iRet;

            switch (this.type)
            {
                case VariantType.None:
                    {
                        iRet = base.GetHashCode();
                        break;
                    }

                case VariantType.Blob:
                    {
                        iRet = this.GetBlob().GetHashCode();
                        break;
                    }

                case VariantType.Float:
                    {
                        iRet = this.GetFloat().GetHashCode();
                        break;
                    }

                case VariantType.Double:
                    {
                        iRet = this.GetDouble().GetHashCode();
                        break;
                    }

                case VariantType.Guid:
                    {
                        iRet = this.GetGuid().GetHashCode();
                        break;
                    }

                case VariantType.IUnknown:
                    {
                        iRet = this.GetIUnknown().GetHashCode();
                        break;
                    }

                case VariantType.String:
                    {
                        iRet = this.GetString().GetHashCode();
                        break;
                    }

                case VariantType.UByte:
                    {
                        iRet = this.GetUByte().GetHashCode();
                        break;
                    }

                case VariantType.Short:
                    {
                        iRet = this.GetShort().GetHashCode();
                        break;
                    }

                case VariantType.UShort:
                    {
                        iRet = this.GetUShort().GetHashCode();
                        break;
                    }

                case VariantType.Int32:
                    {
                        iRet = this.GetInt().GetHashCode();
                        break;
                    }

                case VariantType.UInt32:
                    {
                        iRet = this.GetUInt().GetHashCode();
                        break;
                    }

                case VariantType.Int64:
                    {
                        iRet = this.GetLong().GetHashCode();
                        break;
                    }

                case VariantType.UInt64:
                    {
                        iRet = this.GetULong().GetHashCode();
                        break;
                    }

                case VariantType.StringArray:
                    {
                        iRet = this.GetStringArray().GetHashCode();
                        break;
                    }

                default:
                    {
                        iRet = base.GetHashCode();
                        break;
                    }
            }

            return iRet;
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            bool bRet;
            PropVariant p = obj as PropVariant;

            if ((((object)p) == null) || (p.type != this.type))
            {
                bRet = false;
            }
            else
            {
                switch (this.type)
                {
                    case VariantType.None:
                        {
                            bRet = true;
                            break;
                        }

                    case VariantType.Blob:
                        {
                            byte[] b1;
                            byte[] b2;

                            b1 = this.GetBlob();
                            b2 = p.GetBlob();

                            if (b1.Length == b2.Length)
                            {
                                bRet = true;
                                for (int x = 0; x < b1.Length; x++)
                                {
                                    if (b1[x] != b2[x])
                                    {
                                        bRet = false;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                bRet = false;
                            }

                            break;
                        }

                    case VariantType.Float:
                        {
                            bRet = this.GetFloat() == p.GetFloat();
                            break;
                        }

                    case VariantType.Double:
                        {
                            bRet = this.GetDouble() == p.GetDouble();
                            break;
                        }

                    case VariantType.Guid:
                        {
                            bRet = this.GetGuid() == p.GetGuid();
                            break;
                        }

                    case VariantType.IUnknown:
                        {
                            bRet = this.GetIUnknown() == p.GetIUnknown();
                            break;
                        }

                    case VariantType.String:
                        {
                            bRet = this.GetString() == p.GetString();
                            break;
                        }

                    case VariantType.UByte:
                        {
                            bRet = this.GetUByte() == p.GetUByte();
                            break;
                        }

                    case VariantType.Short:
                        {
                            bRet = this.GetShort() == p.GetShort();
                            break;
                        }

                    case VariantType.UShort:
                        {
                            bRet = this.GetUShort() == p.GetUShort();
                            break;
                        }

                    case VariantType.Int32:
                        {
                            bRet = this.GetInt() == p.GetInt();
                            break;
                        }

                    case VariantType.UInt32:
                        {
                            bRet = this.GetUInt() == p.GetUInt();
                            break;
                        }

                    case VariantType.Int64:
                        {
                            bRet = this.GetLong() == p.GetLong();
                            break;
                        }

                    case VariantType.UInt64:
                        {
                            bRet = this.GetULong() == p.GetULong();
                            break;
                        }

                    case VariantType.StringArray:
                        {
                            string[] sa1;
                            string[] sa2;

                            sa1 = this.GetStringArray();
                            sa2 = p.GetStringArray();

                            if (sa1.Length == sa2.Length)
                            {
                                bRet = true;
                                for (int x = 0; x < sa1.Length; x++)
                                {
                                    if (sa1[x] != sa2[x])
                                    {
                                        bRet = false;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                bRet = false;
                            }

                            break;
                        }

                    default:
                        {
                            bRet = base.Equals(obj);
                            break;
                        }
                }
            }

            return bRet;
        }

        /// <summary>
        /// Implements the equality operator.
        /// </summary>
        /// <param name="a">The left operand to compare for equality.</param>
        /// <param name="b">The right operand to compare for equality.</param>
        /// <returns>The result of the equality comparison operator.</returns>
        public static bool operator ==(ConstPropVariant a, ConstPropVariant b)
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

            return a.Equals(b);
        }

        /// <summary>
        /// Implements the inequality operator.
        /// </summary>
        /// <param name="a">The left operand to compare for inequality.</param>
        /// <param name="b">The right operand to compare for inequality.</param>
        /// <returns>The result of the inequality comparison operator.</returns>
        public static bool operator !=(ConstPropVariant a, ConstPropVariant b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Copies the contents of this propvariant into the <see cref="PropVariant" /> given in
        /// the <paramref name="copyDestination" /> parameter.
        /// </summary>
        /// <param name="copyDestination">A propvariant that receives the copy.</param>
        /// <exception cref="System.ArgumentNullException">IF <paramref name="copyDestination"/> is null.</exception>
        public void Copy(PropVariant copyDestination)
        {
            if (copyDestination == null)
                throw new ArgumentNullException("pval");

            copyDestination.Clear();

            ConstPropVariant.PropVariantCopy(copyDestination, this);
        }

        #region IDisposable Members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            // If we are a ConstPropVariant, we must *not* call PropVariantClear.  That
            // would release the *caller's* copy of the data, which would probably make
            // him cranky.  If we are a PropVariant, the PropVariant.Dispose gets called
            // as well, which *does* do a PropVariantClear.
            this.type = VariantType.None;
#if DEBUG
            this.longValue = 0;
#endif
        }

        #endregion
    }
}
