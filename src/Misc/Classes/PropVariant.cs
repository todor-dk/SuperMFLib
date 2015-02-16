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

    /// <summary>
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
    /// 	<strong>Note</strong> The <strong>bool</strong> member in previous definitions of this structure
    /// has been renamed to <strong>boolVal</strong>, because some compilers now recognize <strong>bool
    /// </strong> as a keyword. 
    /// <para/>
    /// 	<strong>Note</strong> The <strong>PROPVARIANT</strong> structure, defined below, includes types
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
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/E86CC279-826D-4767-8D96-FC8280060EA1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E86CC279-826D-4767-8D96-FC8280060EA1(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    /// <seealso cref="ConstPropVariant"/>
    [StructLayout(LayoutKind.Explicit)]
    public class PropVariant : ConstPropVariant
    {
        #region Declarations

        /// <summary>
        /// Clears a <c>PROPVARIANT</c> structure. 
        /// </summary>
        /// <param name="pvar">
        /// Type: <strong><c>PROPVARIANT</c>* </strong>
        /// <para/>
        /// Pointer to the <c>PROPVARIANT</c> structure to clear. When this function successfully returns, the 
        /// <strong>PROPVARIANT</strong> is zeroed and the type is set to VT_EMPTY. 
        /// </param>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT PropVariantClear(
        ///   _Inout_  PROPVARIANT *pvar
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/68B00E4B-39D3-49E3-8A0D-032EDCB23B06(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/68B00E4B-39D3-49E3-8A0D-032EDCB23B06(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [DllImport("ole32.dll", ExactSpelling = true, PreserveSig = false), SuppressUnmanagedCodeSecurity]
        protected static extern void PropVariantClear(
            [In, MarshalAs(UnmanagedType.LPStruct)] PropVariant pvar
            );

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="PropVariant"/> class.
        /// </summary>
        public PropVariant() : base(VariantType.None)
        { 
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropVariant"/> class with the given string value.
        /// The <see cref="ValueType"/> of the new PropVariant will be <see cref="ConstPropVariant.VariantType.String"/>.
        /// </summary>
        /// <param name="value">The string value to initialize the PropVariant with.</param>
        public PropVariant(string value) : base(VariantType.String)
        {
            ptr = Marshal.StringToCoTaskMemUni(value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropVariant"/> class with the given array of strings.
        /// The <see cref="ValueType"/> of the new PropVariant will be <see cref="ConstPropVariant.VariantType.StringArray"/>.
        /// </summary>
        /// <param name="value">The array of string to initialize the PropVariant with.</param>
        public PropVariant(string[] value) : base(VariantType.StringArray)
        {
            calpwstrVal.cElems = value.Length;
            calpwstrVal.pElems = Marshal.AllocCoTaskMem(IntPtr.Size * value.Length);

            for (int x = 0; x < value.Length; x++)
            {
                Marshal.WriteIntPtr(calpwstrVal.pElems, x * IntPtr.Size, Marshal.StringToCoTaskMemUni(value[x]));
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropVariant"/> class with the given byte value.
        /// The <see cref="ValueType"/> of the new PropVariant will be <see cref="ConstPropVariant.VariantType.UByte"/>.
        /// </summary>
        /// <param name="value">The byte value to initialize the PropVariant with.</param>
        public PropVariant(byte value) : base(VariantType.UByte)
        {
            bVal = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropVariant"/> class with the given 2-byte signed integer value.
        /// The <see cref="ValueType"/> of the new PropVariant will be <see cref="ConstPropVariant.VariantType.Short"/>.
        /// </summary>
        /// <param name="value">The 2-byte signed integer value to initialize the PropVariant with.</param>
        public PropVariant(short value) : base(VariantType.Short)
        {
            iVal = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropVariant"/> class with the given 2-byte unsigned integer value.
        /// The <see cref="ValueType"/> of the new PropVariant will be <see cref="ConstPropVariant.VariantType.UShort"/>.
        /// </summary>
        /// <param name="value">The 2-byte unsigned integer value to initialize the PropVariant with.</param>
        [CLSCompliant(false)]
        public PropVariant(ushort value) : base(VariantType.UShort)
        {
            uiVal = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropVariant"/> class with the given 4-byte signed integer value.
        /// The <see cref="ValueType"/> of the new PropVariant will be <see cref="ConstPropVariant.VariantType.Int32"/>.
        /// </summary>
        /// <param name="value">The 4-byte signed integer value to initialize the PropVariant with.</param>
        public PropVariant(int value) : base(VariantType.Int32)
        {
            intValue = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropVariant"/> class with the given 4-byte unsigned integer value.
        /// The <see cref="ValueType"/> of the new PropVariant will be <see cref="ConstPropVariant.VariantType.UInt32"/>.
        /// </summary>
        /// <param name="value">The 4-byte unsigned integer value to initialize the PropVariant with.</param>
        [CLSCompliant(false)]
        public PropVariant(uint value) : base(VariantType.UInt32)
        {
            uintVal = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropVariant"/> class with the given 4-byte float value.
        /// The <see cref="ValueType"/> of the new PropVariant will be <see cref="ConstPropVariant.VariantType.Float"/>.
        /// </summary>
        /// <param name="value">The 4-byte float value to initialize the PropVariant with.</param>
        public PropVariant(float value) : base(VariantType.Float)
        {
            fltVal = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropVariant"/> class with the given 8-byte float value.
        /// The <see cref="ValueType"/> of the new PropVariant will be <see cref="ConstPropVariant.VariantType.Double"/>.
        /// </summary>
        /// <param name="value">The 8-byte float value to initialize the PropVariant with.</param>
        public PropVariant(double value) : base(VariantType.Double)
        {
            doubleValue = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropVariant"/> class with the given 8-byte signed integer value.
        /// The <see cref="ValueType"/> of the new PropVariant will be <see cref="ConstPropVariant.VariantType.Int64"/>.
        /// </summary>
        /// <param name="value">The 8-byte signed integer value to initialize the PropVariant with.</param>
        public PropVariant(long value) : base(VariantType.Int64)
        {
            longValue = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropVariant"/> class with the given 8-byte unsigned integer value.
        /// The <see cref="ValueType"/> of the new PropVariant will be <see cref="ConstPropVariant.VariantType.UInt64"/>.
        /// </summary>
        /// <param name="value">The 8-byte unsigned integer value to initialize the PropVariant with.</param>
        [CLSCompliant(false)]
        public PropVariant(ulong value) : base(VariantType.UInt64)
        {
            ulongValue = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropVariant"/> class with the given Guid value.
        /// The <see cref="ValueType"/> of the new PropVariant will be <see cref="ConstPropVariant.VariantType.Guid"/>.
        /// </summary>
        /// <param name="value">The Guid value to initialize the PropVariant with.</param>
        public PropVariant(Guid value) : base(VariantType.Guid)
        {
            ptr = Marshal.AllocCoTaskMem(Marshal.SizeOf(value));
            Marshal.StructureToPtr(value, ptr, false);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropVariant"/> class with the given byte array value.
        /// The <see cref="ValueType"/> of the new PropVariant will be <see cref="ConstPropVariant.VariantType.Blob"/>.
        /// </summary>
        /// <param name="value">The byte array float value to initialize the PropVariant with.</param>
        public PropVariant(byte[] value) : base(VariantType.Blob)
        {
            blobValue.cbSize = value.Length;
            blobValue.pBlobData = Marshal.AllocCoTaskMem(value.Length);
            Marshal.Copy(value, 0, blobValue.pBlobData, value.Length);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropVariant"/> class with the IUnknown COM interface of the given object.
        /// The <see cref="ValueType"/> of the new PropVariant will be <see cref="ConstPropVariant.VariantType.IUnknown"/>.
        /// </summary>
        /// <param name="value">The object to initialize the PropVariant with.</param>
        public PropVariant(object value) : base(VariantType.IUnknown)
        {
            ptr = Marshal.GetIUnknownForObject(value);
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="PropVariant"/> class 
        /// from a memory pointer to a <c>PROPVARIANT</c> structure.
        /// </summary>
        /// <param name="value">Memory pointer to a <c>PROPVARIANT</c> structure.</param>
        public PropVariant(IntPtr value)
        {
            Marshal.PtrToStructure(value, this);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropVariant"/> class by copying the contents 
        /// of the <see cref="ConstPropVariant"/> that is given in the <paramref name="value"/> parameter.
        /// </summary>
        /// <param name="value">The propvariant to be copied.</param>
        /// <exception cref="System.NullReferenceException">If <paramref name="value"/> is null.</exception>
        public PropVariant(ConstPropVariant value)
        {
            if (value != null)
            {
                PropVariantCopy(this, value);
            }
            else
            {
                throw new NullReferenceException("null passed to PropVariant constructor");
            }
        }

        /// <summary>
        /// Finalizer.
        /// </summary>
        ~PropVariant()
        {
            Clear();
        }


        /// <summary>
        /// Frees all elements that can be freed in this propvariant. 
        /// For complex elements with known element pointers, the underlying elements 
        /// are freed prior to freeing the containing element.
        /// </summary>
        public void Clear()
        {
            PropVariantClear(this);
        }

        /// <summary>
        /// Create and anitialize a new <see cref="PropVariant"/> with the given <paramref name="value"/>.
        /// The <seealso cref="ValueType"/> of the PropVariant is derived from the type of the <paramref name="value"/>.
        /// </summary>
        /// <param name="value">Value for the PropVariant.</param>
        /// <returns>A new PropVariant for the given value.</returns>
        public static PropVariant FromValue(object value)
        {
            if (value is ConstPropVariant)
            {
                PropVariant result = new PropVariant();
                ((ConstPropVariant)value).Copy(result);
                return result;
            }
            if (value == null)
                return new PropVariant();
            if (value is string)
                return new PropVariant((string)value);
            if (value is string[])
                return new PropVariant((string[])value);
            if (value is Int32)
                return new PropVariant((Int32)value);
            if (value is Int64)
                return new PropVariant((Int64)value);
            if (value is Int16)
                return new PropVariant((Int16)value);
            if (value is UInt32)
                return new PropVariant((UInt32)value);
            if (value is UInt64)
                return new PropVariant((UInt64)value);
            if (value is UInt16)
                return new PropVariant((UInt16)value);
            if (value is Byte)
                return new PropVariant((Byte)value);
            if (value is Single)
                return new PropVariant((Single)value);
            if (value is Double)
                return new PropVariant((Double)value);
            if (value is Guid)
                return new PropVariant((Guid)value);
            if (value is byte[])
                return new PropVariant((byte[])value);
            return new PropVariant(value); // VariantType.IUnknown:
        }

        #region IDisposable Members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        new public void Dispose()
        {
            Clear();
            GC.SuppressFinalize(this);
        }

        #endregion
    }

}
