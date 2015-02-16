using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using System.Diagnostics;
using MediaFoundation.Misc;
using System.Runtime.InteropServices;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="Attributes{T}"/> class implements a wrapper around the
    /// <see cref="IMFAttributes"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFAttributes"/>
    /// interface's methods.
    /// </summary>
    public abstract class Attributes<TInterface> : COM<TInterface>
        where TInterface : class, IMFAttributes
    {
        #region Construction

        internal Attributes(TInterface comInterface)
            : base(comInterface)
        {
        }

        #endregion

        /// <summary>
        /// Retrieves the value associated with a key.
        /// </summary>
        /// <param name="key">
        /// A GUID that identifies which value to retrieve. 
        /// </param>
        /// <returns>
        /// A <see cref="PropVariant"/> that receives the value or null if the value is not found. Release the PropVariant. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8CC4E529-D5A0-4342-82AC-AE5B28BFD61D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8CC4E529-D5A0-4342-82AC-AE5B28BFD61D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public PropVariant GetItem(Guid key)
        {
            PropVariant pValue = new PropVariant();
            int hr = this.Interface.GetItem(key, pValue);
            if (hr == MFError.MF_E_ATTRIBUTENOTFOUND)
            {
                pValue.Dispose();
                return null;
            }
            COM.ThrowIfNotOKAndDisposePropVariant(hr, pValue);
            return pValue;
        }

        /// <summary>
        /// Retrieves the data type of the value associated with a key.
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to query.
        /// </param>
        /// <returns>
        /// Returns a member of the <see cref="MFAttributeType"/> enumeration. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2C3A3C30-DA10-4365-9F76-598A4CA7675C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2C3A3C30-DA10-4365-9F76-598A4CA7675C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MFAttributeType GetItemType(Guid key)
        {
            MFAttributeType pType;
            int hr = this.Interface.GetItemType(key, out pType);
            if (hr == MFError.MF_E_ATTRIBUTENOTFOUND)
                return MFAttributeType.None;
            COM.ThrowIfNotOK(hr);
            return pType;
        }

        /// <summary>
        /// Queries whether a stored attribute value equals to a specified <see cref="ConstPropVariant"/>. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to query.
        /// </param>
        /// <param name="value">
        /// <see cref="ConstPropVariant"/> that contains the value to compare. 
        /// </param>
        /// <returns>
        /// Returns a boolean value indicating whether the attribute matches the value given in <paramref name="value"/>.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F0A6073B-FCE6-4A1F-B7D1-EF6543E7648F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F0A6073B-FCE6-4A1F-B7D1-EF6543E7648F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public bool CompareItem(Guid key, ConstPropVariant value)
        {
            bool pResult;
            int hr = this.Interface.CompareItem(key, value, out pResult);
            COM.ThrowIfNotOK(hr);
            return pResult;
        }

        /// <summary>
        /// Compares the attributes on this object with the attributes on another object.
        /// </summary>
        /// <param name="theirs">
        /// The <see cref="Attributes"/> object to compare with this object. 
        /// </param>
        /// <param name="matchType">
        /// Member of the <see cref="MFAttributesMatchType"/> enumeration, specifying the type of comparison to make. 
        /// </param>
        /// <returns>
        /// Returns true if the two sets of attributes match in the way specified by the <paramref name="matchType"/> parameter, 
        /// otherwise false.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1D0C9D1C-448D-4851-B183-94B04ACB2AB5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1D0C9D1C-448D-4851-B183-94B04ACB2AB5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public bool Compare(Attributes theirs, MFAttributesMatchType matchType)
        {
            bool pbResult;
            int hr = this.Interface.Compare(theirs.GetInterface(), matchType, out pbResult);
            COM.ThrowIfNotOK(hr);
            return pbResult;
        }

        /// <summary>
        /// Retrieves an <see cref="Int32"/> value associated with a key. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_UINT32</strong>. 
        /// </param>
        /// <returns>
        /// Returns an <see cref="Int32"/> value. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E47495E0-3274-4CE2-9FD3-D2FB2AFB7578(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E47495E0-3274-4CE2-9FD3-D2FB2AFB7578(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Int32 GetInt32(Guid key)
        {
            Int32 value;
            int hr = this.Interface.GetUINT32(key, out value);
            COM.ThrowIfNotOK(hr);
            return value;
        }

        /// <summary>
        /// Retrieves an <see cref="Int32"/> converted to <see cref="Boolean"/> value associated with a key. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_UINT32</strong>. 
        /// </param>
        /// <returns>
        /// Returns false if the value of the <strong>Int32</strong> attribute is 0 (zero), otherwise true.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E47495E0-3274-4CE2-9FD3-D2FB2AFB7578(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E47495E0-3274-4CE2-9FD3-D2FB2AFB7578(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Boolean GetBoolean(Guid key)
        {
            return (this.GetInt32(key) != COM.FALSE);
        }

        /// <summary>
        /// Retrieves an <see cref="Int64"/> value associated with a key and returns it as an <see cref="Int32Int32"/> value.
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_UINT64</strong>. 
        /// </param>
        /// <returns>
        /// Returns an <see cref="Int32Int32"/> value. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F3240FFF-48D8-4D88-8C75-15F00BFE72ED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F3240FFF-48D8-4D88-8C75-15F00BFE72ED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Int32Int32 GetUpperLowerInt32(Guid key)
        {
            Int32Int32 value = Int32Int32.Zero;
            int hr = this.Interface.GetUINT64(key, out value.Value);
            COM.ThrowIfNotOK(hr);
            return value;
        }

        /// <summary>
        /// Retrieves an <see cref="Int64"/> value associated with a key and returns it as an <see cref="Time"/> value.
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_UINT64</strong>. 
        /// </param>
        /// <returns>
        /// Returns an <see cref="Time"/> value. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F3240FFF-48D8-4D88-8C75-15F00BFE72ED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F3240FFF-48D8-4D88-8C75-15F00BFE72ED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Time GetTime(Guid key)
        {
            Time value = Time.Zero;
            int hr = this.Interface.GetUINT64(key, out value.Value);
            COM.ThrowIfNotOK(hr);
            return value;
        }

        /// <summary>
        /// Retrieves an <see cref="Int64"/> value associated with a key. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_UINT64</strong>. 
        /// </param>
        /// <returns>
        /// Returns an <see cref="Int64"/> value. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F3240FFF-48D8-4D88-8C75-15F00BFE72ED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F3240FFF-48D8-4D88-8C75-15F00BFE72ED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Int64 GetInt64(Guid key)
        {
            Int64 value;
            int hr = this.Interface.GetUINT64(key, out value);
            COM.ThrowIfNotOK(hr);
            return value;
        }

        /// <summary>
        /// Retrieves an <see cref="Double"/> value associated with a key. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_DOUBLE</strong>. 
        /// </param>
        /// <returns>
        /// Returns an <see cref="Double"/> value. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/650A5F7F-609F-477B-8834-FF66CA3A9CA3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/650A5F7F-609F-477B-8834-FF66CA3A9CA3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public double GetDouble(Guid key)
        {
            double value;
            int hr = this.Interface.GetDouble(key, out value);
            COM.ThrowIfNotOK(hr);
            return value;
        }

        /// <summary>
        /// Retrieves an <see cref="Guid"/> value associated with a key. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_GUID</strong>. 
        /// </param>
        /// <returns>
        /// Returns an <see cref="Guid"/> value. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6DED35E1-2D1C-4E68-AD0F-2BD5BA469853(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6DED35E1-2D1C-4E68-AD0F-2BD5BA469853(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Guid GetGuid(Guid key)
        {
            Guid value;
            int hr = this.Interface.GetGUID(key, out value);
            COM.ThrowIfNotOK(hr);
            return value;
        }

        /// <summary>
        /// Retrieves the length of a string value associated with a key.
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_STRING</strong>. 
        /// </param>
        /// <returns>
        /// Returns the number of characters in the string, not including the terminating <strong>NULL</strong> character. 
        /// To get the string value, call <see cref="GetString"/>. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6CCC753F-E147-47F4-AB95-17687729404A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6CCC753F-E147-47F4-AB95-17687729404A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int GetStringLength(Guid key)
        {
            int value;
            int hr = this.Interface.GetStringLength(key, out value);
            COM.ThrowIfNotOK(hr);
            return value;
        }

        /// <summary>
        /// Returns a string associated with a key. 
        /// </summary>
        /// <param name="key">
        /// A GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_STRING</strong>. 
        /// </param>
        /// <returns>
        /// Returns a copy of the string value.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/550A3035-EA16-4784-8F69-9522259BB338(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/550A3035-EA16-4784-8F69-9522259BB338(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public string GetString(Guid key)
        {
            string value;
            int length;
            int hr = this.Interface.GetAllocatedString(key, out value, out length);
            COM.ThrowIfNotOK(hr);
            return value;
        }

        /// <summary>
        /// Retrieves the length of a byte array associated with a key.
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>MF_ATTRIBUTE_BLOB
        /// </strong>. 
        /// </param>
        /// <returns>
        /// Returns the size of the array in bytes.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/93AB65E7-2168-4CFB-A871-B39554BA66E0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/93AB65E7-2168-4CFB-A871-B39554BA66E0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int GetBlobSize(Guid key)
        {
            int size;
            int hr = this.Interface.GetBlobSize(key, out size);
            COM.ThrowIfNotOK(hr);
            return size;
        }

        /// <summary>
        /// Retrieves a byte array associated with a key.
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>MF_ATTRIBUTE_BLOB</strong>. 
        /// </param>
        /// <returns>
        /// Returns a copy of the byte array.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/380E0E3A-B5C5-4D31-8793-417262377FEF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/380E0E3A-B5C5-4D31-8793-417262377FEF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public byte[] GetBlob(Guid key)
        {
            IntPtr pBytes = IntPtr.Zero;
            int length = 0;
            int hr = this.Interface.GetAllocatedBlob(key, out pBytes, out length);
            COM.ThrowIfNotOK(hr);

            Debug.Assert(pBytes != IntPtr.Zero);

            byte[] bytes = new byte[length];
            Marshal.Copy(pBytes, bytes, 0, length);
            Marshal.FreeCoTaskMem(pBytes);
            return bytes;
        }

        /// <summary>
        /// Retrieves an interface associated with a key.
        /// </summary>
        /// <typeparam name="TObject">The type of the of the interface to retrieve.</typeparam>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>MF_ATTRIBUTE_IUNKNOWN</strong>. 
        /// </param>
        /// <returns>
        /// Returns the requested interface. The caller must release the interface.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A5F645A1-B7D2-47D3-B77E-AD94815B1C25(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A5F645A1-B7D2-47D3-B77E-AD94815B1C25(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public TObject GetObject<TObject>(Guid key)
            where TObject : class
        {
            Guid iid = typeof(TObject).GUID;
            object value;
            int hr = this.Interface.GetUnknown(key, iid, out value);
            COM.ThrowIfNotOK(hr);
            return (TObject)value;
        }

        /// <summary>
        /// Retrieves an <see cref="Int32"/> value associated with a key. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_UINT32</strong>. 
        /// </param>
        /// <returns>
        /// Returns an <see cref="Int32"/> value or null if the value is not found.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E47495E0-3274-4CE2-9FD3-D2FB2AFB7578(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E47495E0-3274-4CE2-9FD3-D2FB2AFB7578(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Int32? GetInt32OrNull(Guid key)
        {
            Int32 value;
            int hr = this.Interface.GetUINT32(key, out value);
            if (hr == MFError.MF_E_ATTRIBUTENOTFOUND)
                return null;
            COM.ThrowIfNotOK(hr);
            return value;
        }

        /// <summary>
        /// Retrieves an <see cref="Int32"/> converted to <see cref="Boolean"/> value associated with a key. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_UINT32</strong>. 
        /// </param>
        /// <returns>
        /// Returns false if the value of the <strong>Int32</strong> attribute is 0 (zero), otherwise true,
        /// or null if the value is not found.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E47495E0-3274-4CE2-9FD3-D2FB2AFB7578(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E47495E0-3274-4CE2-9FD3-D2FB2AFB7578(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Boolean? GetBooleanOrNull(Guid key)
        {
            Int32? value = this.GetInt32OrNull(key);
            if (!value.HasValue)
                return null;
            return (value.Value != COM.FALSE);
        }

        /// <summary>
        /// Retrieves an <see cref="Int64"/> value associated with a key and returns it as an <see cref="Int32Int32"/> value.
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_UINT64</strong>. 
        /// </param>
        /// <returns>
        /// Returns an <see cref="Int32Int32"/> value or null if the value is not found.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F3240FFF-48D8-4D88-8C75-15F00BFE72ED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F3240FFF-48D8-4D88-8C75-15F00BFE72ED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Int32Int32? GetUpperLowerInt32OrNull(Guid key)
        {
            Int32Int32 value = Int32Int32.Zero;
            int hr = this.Interface.GetUINT64(key, out value.Value);
            if (hr == MFError.MF_E_ATTRIBUTENOTFOUND)
                return null;
            COM.ThrowIfNotOK(hr);
            return value;
        }

        /// <summary>
        /// Retrieves an <see cref="Int64"/> value associated with a key and returns it as an <see cref="Time"/> value.
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_UINT64</strong>. 
        /// </param>
        /// <returns>
        /// Returns an <see cref="Time"/> value or null if the value is not found.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F3240FFF-48D8-4D88-8C75-15F00BFE72ED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F3240FFF-48D8-4D88-8C75-15F00BFE72ED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Time? GetTimeOrNull(Guid key)
        {
            Time value = Time.Zero;
            int hr = this.Interface.GetUINT64(key, out value.Value);
            if (hr == MFError.MF_E_ATTRIBUTENOTFOUND)
                return null;
            COM.ThrowIfNotOK(hr);
            return value;
        }

        /// <summary>
        /// Retrieves an <see cref="Int64"/> value associated with a key. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_UINT64</strong>. 
        /// </param>
        /// <returns>
        /// Returns an <see cref="Int64"/> value or null if the value is not found.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F3240FFF-48D8-4D88-8C75-15F00BFE72ED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F3240FFF-48D8-4D88-8C75-15F00BFE72ED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Int64? GetInt64OrNull(Guid key)
        {
            Int64 value;
            int hr = this.Interface.GetUINT64(key, out value);
            if (hr == MFError.MF_E_ATTRIBUTENOTFOUND)
                return null;
            COM.ThrowIfNotOK(hr);
            return value;
        }

        /// <summary>
        /// Retrieves an <see cref="Double"/> value associated with a key. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_DOUBLE</strong>. 
        /// </param>
        /// <returns>
        /// Returns an <see cref="Double"/> value or null if the value is not found.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/650A5F7F-609F-477B-8834-FF66CA3A9CA3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/650A5F7F-609F-477B-8834-FF66CA3A9CA3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public double? GetDoubleOrNull(Guid key)
        {
            double value;
            int hr = this.Interface.GetDouble(key, out value);
            if (hr == MFError.MF_E_ATTRIBUTENOTFOUND)
                return null;
            COM.ThrowIfNotOK(hr);
            return value;
        }

        /// <summary>
        /// Retrieves an <see cref="Guid"/> value associated with a key. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_GUID</strong>. 
        /// </param>
        /// <returns>
        /// Returns an <see cref="Guid"/> value or null if the value is not found.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6DED35E1-2D1C-4E68-AD0F-2BD5BA469853(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6DED35E1-2D1C-4E68-AD0F-2BD5BA469853(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Guid? GetGuidOrNull(Guid key)
        {
            Guid value;
            int hr = this.Interface.GetGUID(key, out value);
            if (hr == MFError.MF_E_ATTRIBUTENOTFOUND)
                return null;
            COM.ThrowIfNotOK(hr);
            return value;
        }

        /// <summary>
        /// Retrieves the length of a string value associated with a key.
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_STRING</strong>. 
        /// </param>
        /// <returns>
        /// Returns the number of characters in the string, not including the terminating <strong>NULL</strong> character. 
        /// To get the string value, call <see cref="GetString"/>. 
        /// Returns null if the value is not found.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6CCC753F-E147-47F4-AB95-17687729404A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6CCC753F-E147-47F4-AB95-17687729404A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int? GetStringLengthOrNull(Guid key)
        {
            int value;
            int hr = this.Interface.GetStringLength(key, out value);
            if (hr == MFError.MF_E_ATTRIBUTENOTFOUND)
                return null;
            COM.ThrowIfNotOK(hr);
            return value;
        }

        /// <summary>
        /// Returns a string associated with a key. 
        /// </summary>
        /// <param name="key">
        /// A GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_STRING</strong>. 
        /// </param>
        /// <returns>
        /// Returns a copy of the string value or null if the value is not found.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/550A3035-EA16-4784-8F69-9522259BB338(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/550A3035-EA16-4784-8F69-9522259BB338(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public string GetStringOrNull(Guid key)
        {
            string value;
            int length;
            int hr = this.Interface.GetAllocatedString(key, out value, out length);
            if (hr == MFError.MF_E_ATTRIBUTENOTFOUND)
                return null;
            COM.ThrowIfNotOK(hr);
            return value;
        }

        /// <summary>
        /// Retrieves the length of a byte array associated with a key.
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>MF_ATTRIBUTE_BLOB
        /// </strong>. 
        /// </param>
        /// <returns>
        /// Returns the size of the array in bytes or null if the value is not found.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/93AB65E7-2168-4CFB-A871-B39554BA66E0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/93AB65E7-2168-4CFB-A871-B39554BA66E0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int? GetBlobSizeOrNull(Guid key)
        {
            int size;
            int hr = this.Interface.GetBlobSize(key, out size);
            if (hr == MFError.MF_E_ATTRIBUTENOTFOUND)
                return null;
            COM.ThrowIfNotOK(hr);
            return size;
        }

        /// <summary>
        /// Retrieves a byte array associated with a key.
        /// </summary>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>MF_ATTRIBUTE_BLOB</strong>. 
        /// </param>
        /// <returns>
        /// Returns a copy of the byte array or null if the value is not found.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/380E0E3A-B5C5-4D31-8793-417262377FEF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/380E0E3A-B5C5-4D31-8793-417262377FEF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public byte[] GetBlobOrNull(Guid key)
        {
            IntPtr pBytes = IntPtr.Zero;
            int length = 0;
            int hr = this.Interface.GetAllocatedBlob(key, out pBytes, out length);
            if (hr == MFError.MF_E_ATTRIBUTENOTFOUND)
                return null;
            COM.ThrowIfNotOK(hr);

            Debug.Assert(pBytes != IntPtr.Zero);

            byte[] bytes = new byte[length];
            Marshal.Copy(pBytes, bytes, 0, length);
            Marshal.FreeCoTaskMem(pBytes);
            return bytes;
        }

        /// <summary>
        /// Retrieves an interface associated with a key.
        /// </summary>
        /// <typeparam name="TObject">The type of the of the interface to retrieve.</typeparam>
        /// <param name="key">
        /// GUID that identifies which value to retrieve. The attribute type must be <strong>MF_ATTRIBUTE_IUNKNOWN</strong>. 
        /// </param>
        /// <returns>
        /// Returns the requested interface or null if the value is not found.. The caller must release the interface.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A5F645A1-B7D2-47D3-B77E-AD94815B1C25(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A5F645A1-B7D2-47D3-B77E-AD94815B1C25(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public TObject GetObjectOrNull<TObject>(Guid key)
            where TObject : class
        {
            Guid iid = typeof(TObject).GUID;
            object value;
            int hr = this.Interface.GetUnknown(key, iid, out value);
            if (hr == MFError.MF_E_ATTRIBUTENOTFOUND)
                return null;
            COM.ThrowIfNotOK(hr);
            return (TObject)value;
        }

        /// <summary>
        /// Adds an attribute value with a specified key. 
        /// </summary>
        /// <param name="key">
        /// A GUID that identifies the value to set. If this key already exists, the method overwrites the old value. 
        /// </param>
        /// <param name="value">
        /// A <see cref="ConstPropVariant"/> that contains the attribute value. The method copies the value. 
        /// The <see cref="ConstPropVariant"/> type must be one of the types listed in the 
        /// <see cref="MFAttributeType"/> enumeration. 
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1AC6E1C3-CF78-4CFF-A992-4F92F243C443(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1AC6E1C3-CF78-4CFF-A992-4F92F243C443(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetItem(Guid key, ConstPropVariant value)
        {
            int hr = this.Interface.SetItem(key, value);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Removes a key/value pair from the object's attribute list.
        /// </summary>
        /// <param name="key">
        /// GUID that identifies the value to delete.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AC72E6E4-F930-4DE6-92A2-F15E5F9E5D74(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AC72E6E4-F930-4DE6-92A2-F15E5F9E5D74(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void DeleteItem(Guid key)
        {
            int hr = this.Interface.DeleteItem(key);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Removes all key/value pairs from the object's attribute list.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8D7EF03B-BB96-42BC-A1C3-49F8B0E499B8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8D7EF03B-BB96-42BC-A1C3-49F8B0E499B8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void DeleteAllItems()
        {
            int hr = this.Interface.DeleteAllItems();
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Associates an <see cref="Int32"/> value with a key. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies the value to set. If this key already exists, the method overwrites the old value.
        /// </param>
        /// <param name="value">
        /// New value for this key.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9C30FD56-719F-4831-8FBF-CEFCF9D72709(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9C30FD56-719F-4831-8FBF-CEFCF9D72709(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetInt32(Guid key, Int32 value)
        {
            int hr = this.Interface.SetUINT32(key, value);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Associates an <see cref="Boolean"/> value with a key that is defined as Int32. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies the value to set. If this key already exists, the method overwrites the old value.
        /// </param>
        /// <param name="value">
        /// New value for this key.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9C30FD56-719F-4831-8FBF-CEFCF9D72709(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9C30FD56-719F-4831-8FBF-CEFCF9D72709(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetBoolean(Guid key, bool value)
        {
            int hr = this.Interface.SetUINT32(key, value ? COM.TRUE : COM.FALSE);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Associates an <see cref="Int64"/> value with a key. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies the value to set. If this key already exists, the method overwrites the old value.
        /// </param>
        /// <param name="value">
        /// New value for this key.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/817ED1C1-16AD-4520-A1A0-A93563936B50(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/817ED1C1-16AD-4520-A1A0-A93563936B50(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetInt64(Guid key, Int64 value)
        {
            int hr = this.Interface.SetUINT64(key, value);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Associates an <see cref="Int32Int32"/> value with a key that is defined as Int64. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies the value to set. If this key already exists, the method overwrites the old value.
        /// </param>
        /// <param name="value">
        /// New value for this key.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/817ED1C1-16AD-4520-A1A0-A93563936B50(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/817ED1C1-16AD-4520-A1A0-A93563936B50(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetUpperLowerInt32(Guid key, Int32Int32 value)
        {
            int hr = this.Interface.SetUINT64(key, value.Value);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Associates an <see cref="Time"/> value with a key that is defined as Int64. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies the value to set. If this key already exists, the method overwrites the old value.
        /// </param>
        /// <param name="value">
        /// New value for this key.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/817ED1C1-16AD-4520-A1A0-A93563936B50(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/817ED1C1-16AD-4520-A1A0-A93563936B50(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetTime(Guid key, Time value)
        {
            int hr = this.Interface.SetUINT64(key, value.Value);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Associates a <see cref="Double"/> value with a key. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies the value to set. If this key already exists, the method overwrites the old value.
        /// </param>
        /// <param name="value">
        /// New value for this key.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BB58F35E-0FCA-4B19-9976-DE2140E6EBC0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BB58F35E-0FCA-4B19-9976-DE2140E6EBC0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetDouble(Guid key, Double value)
        {
            int hr = this.Interface.SetDouble(key, value);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Associates a <see cref="Guid"/> value with a key. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies the value to set. If this key already exists, the method overwrites the old value.
        /// </param>
        /// <param name="value">
        /// New value for this key.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D73B53F5-4A8F-4903-986D-FBF4277A2D45(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D73B53F5-4A8F-4903-986D-FBF4277A2D45(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetGuid(Guid key, Guid value)
        {
            int hr = this.Interface.SetGUID(key, value);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Associates a <see cref="String"/> value with a key. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies the value to set. If this key already exists, the method overwrites the old value.
        /// </param>
        /// <param name="value">
        /// New value for this key.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/51D2A2A0-92CB-49E0-B4A9-7201E9D92322(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/51D2A2A0-92CB-49E0-B4A9-7201E9D92322(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetString(Guid key, string value)
        {
            int hr = this.Interface.SetString(key, value);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Associates a byte array with a key.
        /// </summary>
        /// <param name="key">
        /// GUID that identifies the value to set. If this key already exists, the method overwrites the old value.
        /// </param>
        /// <param name="value">
        /// A byte array to associate with this key. The method stores a copy of the array.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4A2A25A9-4DEA-40C8-988C-9E3806C8F31C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4A2A25A9-4DEA-40C8-988C-9E3806C8F31C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetBlob(Guid key, byte[] value)
        {
            Contract.RequiresNotNull(value, "value");
            int hr = this.Interface.SetBlob(key, value, value.Length);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Associates a COM interface with a key. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies the value to set. If this key already exists, the method overwrites the old value.
        /// </param>
        /// <param name="value">
        /// COM interface to be associated with this key. 
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DA0C3D59-07C4-4431-A137-8655DDBF6258(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DA0C3D59-07C4-4431-A137-8655DDBF6258(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetObject(Guid key, object value)
        {
            int hr = this.Interface.SetUnknown(key, value);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Associates a COM interface with a key. 
        /// </summary>
        /// <param name="key">
        /// GUID that identifies the value to set. If this key already exists, the method overwrites the old value.
        /// </param>
        /// <param name="value">
        /// COM interface to be associated with this key. 
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DA0C3D59-07C4-4431-A137-8655DDBF6258(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DA0C3D59-07C4-4431-A137-8655DDBF6258(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetObject(Guid key, COM value)
        {
            int hr = this.Interface.SetUnknown(key, (value != null) ? value.Interface : null);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Locks the attribute store so that no other thread can access it. If the attribute store is already
        /// locked by another thread, this method blocks until the other thread unlocks the object. After
        /// calling this method, call <see cref="IMFAttributes.UnlockStore"/> to unlock the object. 
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6EC7AED3-7DBC-4AA4-92D5-646AEE757DB7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6EC7AED3-7DBC-4AA4-92D5-646AEE757DB7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void LockStore()
        {
            int hr = this.Interface.LockStore();
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Unlocks the attribute store after a call to the <see cref="IMFAttributes.LockStore"/> method. While
        /// the object is unlocked, multiple threads can access the object's attributes. 
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/65E35864-868A-4AE9-86ED-772A2B2DAEB6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/65E35864-868A-4AE9-86ED-772A2B2DAEB6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void UnlockStore()
        {
            int hr = this.Interface.UnlockStore();
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Retrieves the number of attributes that are set on this object.
        /// </summary>
        /// <returns>The number of attributes.</returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5F511D5C-249C-4311-8380-A932A755EAAF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5F511D5C-249C-4311-8380-A932A755EAAF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int Count
        {
            get
            {
                int count;
                int hr = this.Interface.GetCount(out count);
                COM.ThrowIfNotOK(hr);
                return count;
            }
        }

        /// <summary>
        /// Retrieves an attribute at the specified index.
        /// </summary>
        /// <param name="index">
        /// Index of the attribute to retrieve. To get the number of attributes, call <see cref="Count"/>. 
        /// </param>
        /// <param name="key">
        /// Receives the GUID that identifies this attribute.
        /// </param>
        /// <returns>
        /// A <see cref="PropVariant"/> that contains the value. The PropVariant must be disposed.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1290BC45-FCAC-4379-B26C-E67EF678F193(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1290BC45-FCAC-4379-B26C-E67EF678F193(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public PropVariant GetItemByIndex(int index, out Guid key)
        {
            PropVariant value = new PropVariant();
            int hr = this.Interface.GetItemByIndex(index, out key, value);
            COM.ThrowIfNotOKAndDisposePropVariant(hr, value);
            return value;
        }

        /// <summary>
        /// Retrieves an attribute at the specified index.
        /// </summary>
        /// <param name="index">
        /// Index of the attribute to retrieve. To get the number of attributes, call <see cref="Count"/>. 
        /// </param>
        /// <returns>
        /// A <see cref="PropVariant"/> that contains the value. The PropVariant must be disposed.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1290BC45-FCAC-4379-B26C-E67EF678F193(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1290BC45-FCAC-4379-B26C-E67EF678F193(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public PropVariant GetItemByIndex(int index)
        {
            Guid na;
            return this.GetItemByIndex(index, out na);
        }

        /// <summary>
        /// Retrieves the attribute key at the specified index.
        /// </summary>
        /// <param name="index">
        /// Index of the attribute to retrieve. To get the number of attributes, call <see cref="Count"/>. 
        /// </param>
        /// <returns>
        /// The GUID that identifies this attribute.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1290BC45-FCAC-4379-B26C-E67EF678F193(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1290BC45-FCAC-4379-B26C-E67EF678F193(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Guid GetKeyByIndex(int index)
        {
            Guid key;
            int hr = this.Interface.GetItemByIndex(index, out key, null);
            COM.ThrowIfNotOK(hr);
            return key;
        }

        /// <summary>
        /// Retrieves the attribute value at the specified index.
        /// </summary>
        /// <param name="index">
        /// Index of the attribute to retrieve. To get the number of attributes, call <see cref="Count"/>. 
        /// </param>
        /// <returns>
        /// The value of the attribute.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1290BC45-FCAC-4379-B26C-E67EF678F193(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1290BC45-FCAC-4379-B26C-E67EF678F193(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public object GetValueByIndex(int index)
        {
            Guid na;
            using (PropVariant value = this.GetItemByIndex(index, out na))
            {
                return value.GetValue();
            }
        }

        /// <summary>
        /// Copies all of the attributes from this object into another attribute store. 
        /// </summary>
        /// <param name="destination">
        /// A <see cref="Attributes"/> object that receives the copy. 
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/111B55BC-FB8E-45B5-A709-703ACD23C4BE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/111B55BC-FB8E-45B5-A709-703ACD23C4BE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void CopyAllItems(Attributes destination)
        {
            int hr = this.Interface.CopyAllItems(destination.GetInterface());
            COM.ThrowIfNotOK(hr);
        }
    }

    /// <summary>
    /// The <see cref="Attributes"/> class implements a wrapper around the
    /// <see cref="IMFAttributes"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFAttributes"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFAttributes"/>: 
    /// Provides a generic way to store key/value pairs on an object. The keys are <strong>GUID</strong>s,
    /// and the values can be any of the following data types: <strong>UINT32</strong>, <strong>UINT64
    /// </strong>, <strong>double</strong>, <strong>GUID</strong>, wide-character string, byte array, or 
    /// <strong>IUnknown</strong> pointer. The standard implementation of this interface holds a thread
    /// lock while values are added, deleted, or retrieved. 
    /// <para/>
    /// For a list of predefined attribute <strong>GUID</strong>s, see <c>Media Foundation Attributes</c>.
    /// Each attribute <strong>GUID</strong> has an expected data type. The various "set" methods in 
    /// <strong>IMFAttributes</strong> do not validate the type against the attribute <strong>GUID</strong>
    /// . It is the application's responsibility to set the correct type for the attribute. 
    /// <para/>
    /// To create an empty attribute store, call <see cref="MFExtern.MFCreateAttributes"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/E12259F4-B631-4D4A-A296-C1CC6334B962(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E12259F4-B631-4D4A-A296-C1CC6334B962(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public class Attributes : Attributes<IMFAttributes>
    {
        #region Construction

        internal Attributes(IMFAttributes comInterface)
            : base(comInterface)
        {
        }

        #endregion

        /// <summary>
        /// Creates an empty attribute store. 
        /// </summary>
        /// <param name="initialSize">
        /// The initial number of elements allocated for the attribute store. The attribute store grows as needed. 
        /// </param>
        /// <returns>
        /// The <see cref="Attributes"/> object. The caller must dispose the object. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A79B1EDD-5CA1-4550-A6CE-58073155AFFD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A79B1EDD-5CA1-4550-A6CE-58073155AFFD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static Attributes Create(int initialSize)
        {
            IMFAttributes attribs = null;
            int hr = MFExtern.MFCreateAttributes(out attribs, initialSize);
            COM.ThrowIfNotOK(hr);
            Debug.Assert(attribs != null);
            return attribs.ToAttributes();
        }
    }

    /// <summary>
    /// Represents a two 32-bit integer pair of upper and lower part.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct Int32Int32
    {
        /// <summary>
        /// 64-bit integer value.
        /// </summary>
        [FieldOffset(0)]
        public long Value;

        /// <summary>
        /// Lower 32-bit integer value.
        /// </summary>
        [FieldOffset(0)]
        public int Lower;

        /// <summary>
        /// Upper 32-bit integer value.
        /// </summary>
        [FieldOffset(4)]
        public int Upper;

        /// <summary>
        /// Represents a zero (empty) value.
        /// </summary>
        public static readonly Int32Int32 Zero = new Int32Int32();
    }
}