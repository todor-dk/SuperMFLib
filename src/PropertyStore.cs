using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;
using System.Runtime.InteropServices;
using MediaFoundation.Misc.Interfaces;
using MediaFoundation.Core;
using MediaFoundation.Misc.Classes;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="PropertyStore"/> class implements a wrapper around the
    /// <see cref="IPropertyStore"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IPropertyStore"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IPropertyStore"/>:
    /// Exposes methods for enumerating, getting, and setting property values.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/E995AAA1-D4C9-475F-B1FA-B9123CD5B653(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E995AAA1-D4C9-475F-B1FA-B9123CD5B653(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class PropertyStore : COM<IPropertyStore>
    {
        #region Construction

        private PropertyStore(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="PropertyStore"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the PropertyStore's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be considered void.
        /// </param>
        /// <returns>
        /// A new <see cref="PropertyStore"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static PropertyStore FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            PropertyStore result = new PropertyStore(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Creates an in-memory property store.
        /// </summary>
        /// <returns>
        /// An in-memory property store. The caller must dispose the instance.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/6E7A2AC0-2A4A-41EC-A2A8-DDBE8AA45BC9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6E7A2AC0-2A4A-41EC-A2A8-DDBE8AA45BC9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static PropertyStore Create()
        {
            IntPtr ppvObject;
            int hr = MFExtern.PSCreateMemoryPropertyStore(typeof(IPropertyStore).GUID, out ppvObject);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppvObject);
            return PropertyStore.FromUnknown(ref ppvObject);
        }

        /// <summary>
        /// Returns a count of the number of properties that are attached to the file.
        /// </summary>
        /// <returns>
        /// Returns the property count.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/23F7B982-29DB-4960-9A1D-2F9E033EBF61(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F7B982-29DB-4960-9A1D-2F9E033EBF61(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int Count
        {
            get
            {
                int cProps;
                int hr = this.Interface.GetCount(out cProps);
                COM.ThrowIfNotOK(hr);
                return cProps;
            }
        }

        /// <summary>
        /// Gets a property key from the property array of an item.
        /// </summary>
        /// <param name="index">
        /// The index of the property key in the array of <see cref="PropertyKey"/> items. This is a zero-based index.
        /// </param>
        /// <returns>
        /// The property key at the given <paramref name="index"/>.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/4F93949A-D5D5-4FBF-8538-6171861E5884(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4F93949A-D5D5-4FBF-8538-6171861E5884(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public PropertyKey GetAt(int index)
        {
            PropertyKey pkey = new PropertyKey();
            int hr = this.Interface.GetAt(index, pkey);
            COM.ThrowIfNotOK(hr);
            return pkey;
        }

        /// <summary>
        /// This method retrieves the data for a specific property.
        /// </summary>
        /// <param name="key">The key of the property.</param>
        /// <returns>
        /// Returns a <see cref="PropVariant"/> containing the value of the property.
        /// The caller must dispose the PropVariant.
        /// <para/>
        /// If the <paramref name="key"/> is not present in the property store, this method
        /// returns a PropVariant and the <see cref="ConstPropVariant.ValueType"/> is set to
        /// <see cref="ConstPropVariant.VariantType.None"/> (VT_EMPTY).
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/11204335-0F00-4AF8-8787-93E91248E5BD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/11204335-0F00-4AF8-8787-93E91248E5BD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public PropVariant GetValue(PropertyKey key)
        {
            PropVariant pv = new PropVariant();
            int hr = this.Interface.GetValue(key, pv);
            if (COM.Failed(hr))
            {
                pv.Dispose();
                COM.ThrowIfFailed(hr);
            }

            return pv;
        }

        /// <summary>
        /// This method sets a property value or replaces or removes an existing value.
        /// </summary>
        /// <param name="key">The key of the property.</param>
        /// <param name="value">The value of the property.</param>
        /// <returns>
        /// Returns true if the property change was successful or
        /// false if property was changed but the value was set but truncated.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/BE21BCB2-6875-4559-ABD7-A496F0FCDDD6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BE21BCB2-6875-4559-ABD7-A496F0FCDDD6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public bool SetValue(PropertyKey key, ConstPropVariant value)
        {
            int hr = this.Interface.SetValue(key, value);
            // INPLACE_S_TRUNCATED: The value was set but truncated.
            if (hr == PropertyStore.INPLACE_S_TRUNCATED)
                return false;
            COM.ThrowIfNotOK(hr);
            return true;
        }

        /// <summary>
        /// Message is too long, some of it had to be truncated before displaying
        /// </summary>
        private const int INPLACE_S_TRUNCATED = 0x000401A0;

        /// <summary>
        /// After a change has been made, this method saves the changes.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/A3CC6815-A16F-45E7-A2D5-8F354F712170(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A3CC6815-A16F-45E7-A2D5-8F354F712170(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void Commit()
        {
            int hr = this.Interface.Commit();
            COM.ThrowIfNotOK(hr);
        }
    }
}
