using MediaFoundation.Core;
using MediaFoundation.Core.Interfaces;
using MediaFoundation.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MediaFoundation.Implementations
{
    /// <summary>
    /// Class that implements the <see cref="IMFAttributes"/> interface.
    /// </summary>
    public class Attributes : IMFAttributes, IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="_Attributes"/> class.
        /// </summary>
        public Attributes()
        {
            COM.VerifyAccess();
            IntPtr ppMFAttributes;
            int hr = MFExtern.MFCreateAttributes(out ppMFAttributes, 0);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppMFAttributes);
            try
            {
                this._Attributes = (IMFAttributes)Marshal.GetUniqueObjectForIUnknown(ppMFAttributes);
            }
            finally
            {
                if (ppMFAttributes != IntPtr.Zero)
                    Marshal.Release(ppMFAttributes);
            }
        }

        #region IDisposable interface

        /// <summary>
        /// Finalizes an instance of the <see cref="MFActivateBase"/> class.
        /// </summary>
        ~Attributes()
        {
            this.Dispose(false);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <exception cref="System.ObjectDisposedException">self</exception>
        public void Dispose()
        {
            COM.VerifyAccess();
            if (this._Attributes == null)
                throw new ObjectDisposedException("self");
            this.Dispose(true);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (this._Attributes != null)
                Marshal.ReleaseComObject(this._Attributes);
            this._Attributes = null;
        }

        #endregion

        #region IMFAttributes interface

        /// <summary>
        /// Innter object that contains the attributes.
        /// </summary>
        private IMFAttributes _Attributes;

        /// <summary>
        /// Compares the attributes on this object with the attributes on another object.
        /// </summary>
        /// <param name="pTheirs">Pointer to the <see cref="T:MediaFoundation.IMFAttributes" /> interface of the object to compare with this object.</param>
        /// <param name="matchType">Member of the <see cref="T:MediaFoundation.MFAttributesMatchType" /> enumeration, specifying the type of comparison to
        /// make.</param>
        /// <param name="pbResult">Receives a Boolean value. The value is <strong>TRUE</strong> if the two sets of attributes match in
        /// the way specified by the <em>MatchType</em> parameter. Otherwise, the value is <strong>FALSE
        /// </strong>.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT Compare(
        /// [in]   IMFAttributes *pTheirs,
        /// [in]   MF_ATTRIBUTES_MATCH_TYPE MatchType,
        /// [out]  BOOL *pbResult
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/1D0C9D1C-448D-4851-B183-94B04ACB2AB5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1D0C9D1C-448D-4851-B183-94B04ACB2AB5(v=VS.85,d=hv.2).aspx</a></remarks>
        public int Compare(IMFAttributes pTheirs, MFAttributesMatchType matchType, out bool pbResult)
        {
            COM.VerifyAccess();
            return this._Attributes.Compare(pTheirs, matchType, out pbResult);
        }

        /// <summary>
        /// Queries whether a stored attribute value equals to a specified <strong>PROPVARIANT</strong>.
        /// </summary>
        /// <param name="guidKey">GUID that identifies which value to query.</param>
        /// <param name="value"><strong>PROPVARIANT</strong> that contains the value to compare.</param>
        /// <param name="pbResult">Receives a Boolean value indicating whether the attribute matches the value given in <em>Value</em>
        /// . See Remarks. This parameter must not be <strong>NULL</strong>. If this parameter is <strong>NULL
        /// </strong>, an access violation occurs.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT CompareItem(
        /// [in]   REFGUID guidKey,
        /// [in]   REFPROPVARIANT Value,
        /// [out]  BOOL *pbResult
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/F0A6073B-FCE6-4A1F-B7D1-EF6543E7648F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F0A6073B-FCE6-4A1F-B7D1-EF6543E7648F(v=VS.85,d=hv.2).aspx</a></remarks>
        public int CompareItem(Guid guidKey, ConstPropVariant value, out bool pbResult)
        {
            COM.VerifyAccess();
            return this.CompareItem(guidKey, value, out pbResult);
        }

        /// <summary>
        /// Copies all of the attributes from this object into another attribute store.
        /// </summary>
        /// <param name="pDest">A pointer to the <see cref="T:MediaFoundation.IMFAttributes" /> interface of the attribute store that receives the
        /// copy.</param>
        /// <returns>If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code.</returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT CopyAllItems(
        /// [in]  IMFAttributes *pDest
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/111B55BC-FB8E-45B5-A709-703ACD23C4BE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/111B55BC-FB8E-45B5-A709-703ACD23C4BE(v=VS.85,d=hv.2).aspx</a></remarks>
        public int CopyAllItems(IMFAttributes pDest)
        {
            COM.VerifyAccess();
            return this._Attributes.CopyAllItems(pDest);
        }

        /// <summary>
        /// Removes all key/value pairs from the object's attribute list.
        /// </summary>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT DeleteAllItems();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/8D7EF03B-BB96-42BC-A1C3-49F8B0E499B8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8D7EF03B-BB96-42BC-A1C3-49F8B0E499B8(v=VS.85,d=hv.2).aspx</a></remarks>
        public int DeleteAllItems()
        {
            COM.VerifyAccess();
            return this._Attributes.DeleteAllItems();
        }

        /// <summary>
        /// Removes a key/value pair from the object's attribute list.
        /// </summary>
        /// <param name="guidKey">GUID that identifies the value to delete.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT DeleteItem(
        /// [in]  REFGUID guidKey
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/AC72E6E4-F930-4DE6-92A2-F15E5F9E5D74(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AC72E6E4-F930-4DE6-92A2-F15E5F9E5D74(v=VS.85,d=hv.2).aspx</a></remarks>
        public int DeleteItem(Guid guidKey)
        {
            COM.VerifyAccess();
            return this._Attributes.DeleteItem(guidKey);
        }

        /// <summary>
        /// Retrieves a byte array associated with a key. This method allocates the memory for the array.
        /// </summary>
        /// <param name="guidKey">GUID that identifies which value to retrieve. The attribute type must be <strong>MF_ATTRIBUTE_BLOB
        /// </strong>.</param>
        /// <param name="ip">The ip.</param>
        /// <param name="pcbSize">Receives the size of the array, in bytes.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item><item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>The specified key was not found.</description></item><item><term><strong>MF_E_INVALIDTYPE</strong></term><description>The attribute value is not a byte array.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetAllocatedBlob(
        /// [in]   REFGUID guidKey,
        /// [out]  UINT8 **ppBuf,
        /// [out]  UINT32 *pcbSize
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/380E0E3A-B5C5-4D31-8793-417262377FEF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/380E0E3A-B5C5-4D31-8793-417262377FEF(v=VS.85,d=hv.2).aspx</a></remarks>
        public int GetAllocatedBlob(Guid guidKey, out IntPtr ip, out int pcbSize)
        {
            COM.VerifyAccess();
            return this._Attributes.GetAllocatedBlob(guidKey, out ip, out pcbSize);
        }

        /// <summary>
        /// Gets a wide-character string associated with a key. This method allocates the memory for the
        /// string.
        /// </summary>
        /// <param name="guidKey">A GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_STRING</strong>.</param>
        /// <param name="ppwszValue">If the key is found and the value is a string type, this parameter receives a copy of the string.
        /// The caller must free the memory for the string by calling <c>CoTaskMemFree</c>.</param>
        /// <param name="pcchLength">Receives the number of characters in the string, excluding the terminating <strong>NULL</strong>
        /// character. This parameter must not be <strong>NULL</strong>.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item><item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description> The specified key was not found. </description></item><item><term><strong>MF_E_INVALIDTYPE</strong></term><description> The attribute value is not a string. </description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetAllocatedString(
        /// [in]   REFGUID guidKey,
        /// [out]  LPWSTR *ppwszValue,
        /// [out]  UINT32 *pcchLength
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/550A3035-EA16-4784-8F69-9522259BB338(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/550A3035-EA16-4784-8F69-9522259BB338(v=VS.85,d=hv.2).aspx</a></remarks>
        public int GetAllocatedString(Guid guidKey, out string ppwszValue, out int pcchLength)
        {
            COM.VerifyAccess();
            return this._Attributes.GetAllocatedString(guidKey, out ppwszValue, out pcchLength);
        }

        /// <summary>
        /// Retrieves a byte array associated with a key. This method copies the array into a caller-allocated
        /// buffer.
        /// </summary>
        /// <param name="guidKey">GUID that identifies which value to retrieve. The attribute type must be <strong>MF_ATTRIBUTE_BLOB
        /// </strong>.</param>
        /// <param name="pBuf">Pointer to a buffer allocated by the caller. If the key is found and the value is a byte array, the
        /// method copies the array into this buffer. To find the required size of the buffer, call
        /// <see cref="M:MediaFoundation.IMFAttributes.GetBlobSize(System.Guid,System.Int32@)" />.</param>
        /// <param name="cbBufSize">The size of the <em>pBuf</em> buffer, in bytes.</param>
        /// <param name="pcbBlobSize">Receives the size of the byte array. This parameter can be <strong>NULL</strong>.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item><item><term><strong><strong>E_NOT_SUFFICIENT_BUFFER</strong></strong></term><description>The buffer is not large enough to the array.</description></item><item><term><strong><strong>MF_E_ATTRIBUTENOTFOUND</strong></strong></term><description>The specified key was not found.</description></item><item><term><strong><strong>MF_E_INVALIDTYPE</strong></strong></term><description>The attribute value is not a byte array.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetBlob(
        /// [in]   REFGUID guidKey,
        /// [out]  UINT8 *pBuf,
        /// [in]   UINT32 cbBufSize,
        /// [out]  UINT32 *pcbBlobSize
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/68528DB7-90DF-4ABE-A957-FFB8C3F12CEF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/68528DB7-90DF-4ABE-A957-FFB8C3F12CEF(v=VS.85,d=hv.2).aspx</a></remarks>
        public int GetBlob(Guid guidKey, byte[] pBuf, int cbBufSize, out int pcbBlobSize)
        {
            COM.VerifyAccess();
            return this._Attributes.GetBlob(guidKey, pBuf, cbBufSize, out pcbBlobSize);
        }

        /// <summary>
        /// Retrieves the length of a byte array associated with a key.
        /// </summary>
        /// <param name="guidKey">GUID that identifies which value to retrieve. The attribute type must be <strong>MF_ATTRIBUTE_BLOB
        /// </strong>.</param>
        /// <param name="pcbBlobSize">If the key is found and the value is a byte array, this parameter receives the size of the array,
        /// in bytes.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item><item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>The specified key was not found.</description></item><item><term><strong>MF_E_INVALIDTYPE</strong></term><description>The attribute value is not a byte array.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetBlobSize(
        /// [in]   REFGUID guidKey,
        /// [out]  UINT32 *pcbBlobSize
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/93AB65E7-2168-4CFB-A871-B39554BA66E0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/93AB65E7-2168-4CFB-A871-B39554BA66E0(v=VS.85,d=hv.2).aspx</a></remarks>
        public int GetBlobSize(Guid guidKey, out int pcbBlobSize)
        {
            COM.VerifyAccess();
            return this._Attributes.GetBlobSize(guidKey, out pcbBlobSize);
        }

        /// <summary>
        /// Retrieves the number of attributes that are set on this object.
        /// </summary>
        /// <param name="pcItems">Receives the number of attributes. This parameter must not be <strong>NULL</strong>. If this
        /// parameter is <strong>NULL</strong>, an access violation occurs.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetCount(
        /// [out]  UINT32 *pcItems
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/5F511D5C-249C-4311-8380-A932A755EAAF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5F511D5C-249C-4311-8380-A932A755EAAF(v=VS.85,d=hv.2).aspx</a></remarks>
        public int GetCount(out int pcItems)
        {
            COM.VerifyAccess();
            return this._Attributes.GetCount(out pcItems);
        }

        /// <summary>
        /// Retrieves a <strong>double</strong> value associated with a key.
        /// </summary>
        /// <param name="guidKey">GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_DOUBLE</strong>.</param>
        /// <param name="pfValue">Receives a <strong>double</strong> value. If the key is found and the data type is <strong>double
        /// </strong>, the method copies the value into this parameter. Otherwise, the original value of this
        /// parameter is not changed.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item><item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>The specified key was not found.</description></item><item><term><strong>MF_E_INVALIDTYPE</strong></term><description>The attribute value is not a <strong>double</strong>. </description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetDouble(
        /// [in]   REFGUID guidKey,
        /// [out]  double *pfValue
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/650A5F7F-609F-477B-8834-FF66CA3A9CA3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/650A5F7F-609F-477B-8834-FF66CA3A9CA3(v=VS.85,d=hv.2).aspx</a></remarks>
        public int GetDouble(Guid guidKey, out double pfValue)
        {
            COM.VerifyAccess();
            return this._Attributes.GetDouble(guidKey, out pfValue);
        }

        /// <summary>
        /// Retrieves a GUID value associated with a key.
        /// </summary>
        /// <param name="guidKey">GUID that identifies which value to retrieve. The attribute type must be <strong>MF_ATTRIBUTE_GUID
        /// </strong>.</param>
        /// <param name="pguidValue">Receives a GUID value. If the key is found and the data type is GUID, the method copies the value
        /// into this parameter. Otherwise, the original value of this parameter is not changed.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item><item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>The specified key was not found.</description></item><item><term><strong>MF_E_INVALIDTYPE</strong></term><description>The attribute value is not a GUID.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetGUID(
        /// [in]   REFGUID guidKey,
        /// [out]  GUID *pguidValue
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/6DED35E1-2D1C-4E68-AD0F-2BD5BA469853(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6DED35E1-2D1C-4E68-AD0F-2BD5BA469853(v=VS.85,d=hv.2).aspx</a></remarks>
        public int GetGUID(Guid guidKey, out Guid pguidValue)
        {
            COM.VerifyAccess();
            return this._Attributes.GetGUID(guidKey, out pguidValue);
        }

        /// <summary>
        /// Retrieves the value associated with a key.
        /// </summary>
        /// <param name="guidKey">A GUID that identifies which value to retrieve.</param>
        /// <param name="pValue">A pointer to a <strong>PROPVARIANT</strong> that receives the value. The method fills the <strong>
        /// PROPVARIANT</strong> with a copy of the stored value, if the value is found. Call <strong>
        /// PropVariantClear</strong> to free the memory allocated by this method. This parameter can be
        /// <strong>NULL</strong>. If this parameter is <strong>NULL</strong>, the method searches for the key
        /// and returns S_OK if the key is found, but does not copy the value.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item><item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description> The specified key was not found. </description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetItem(
        /// [in]       REFGUID guidKey,
        /// [in, out]  PROPVARIANT *pValue
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/8CC4E529-D5A0-4342-82AC-AE5B28BFD61D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8CC4E529-D5A0-4342-82AC-AE5B28BFD61D(v=VS.85,d=hv.2).aspx</a></remarks>
        public int GetItem(Guid guidKey, PropVariant pValue)
        {
            COM.VerifyAccess();
            return this._Attributes.GetItem(guidKey, pValue);
        }

        /// <summary>
        /// Retrieves an attribute at the specified index.
        /// </summary>
        /// <param name="unIndex">Index of the attribute to retrieve. To get the number of attributes, call
        /// <see cref="M:MediaFoundation.IMFAttributes.GetCount(System.Int32@)" />.</param>
        /// <param name="pguidKey">Receives the GUID that identifies this attribute.</param>
        /// <param name="pValue">Pointer to a <strong>PROPVARIANT</strong> that receives the value. This parameter can be <strong>
        /// NULL</strong>. If it is not <strong>NULL</strong>, the method fills the <strong>PROPVARIANT
        /// </strong> with a copy of the attribute value. Call <strong>PropVariantClear</strong> to free the
        /// memory allocated by this method.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item><item><term><strong>E_INVALIDARG</strong></term><description>Invalid index.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetItemByIndex(
        /// [in]       UINT32 unIndex,
        /// [out]      GUID *pguidKey,
        /// [in, out]  PROPVARIANT *pValue
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/1290BC45-FCAC-4379-B26C-E67EF678F193(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1290BC45-FCAC-4379-B26C-E67EF678F193(v=VS.85,d=hv.2).aspx</a></remarks>
        public int GetItemByIndex(int unIndex, out Guid pguidKey, PropVariant pValue)
        {
            COM.VerifyAccess();
            return this._Attributes.GetItemByIndex(unIndex, out pguidKey, pValue);
        }

        /// <summary>
        /// Retrieves the data type of the value associated with a key.
        /// </summary>
        /// <param name="guidKey">GUID that identifies which value to query.</param>
        /// <param name="pType">Receives a member of the <see cref="T:MediaFoundation.MFAttributeType" /> enumeration.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item><item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>The specified key is not stored in this object.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetItemType(
        /// [in]   REFGUID guidKey,
        /// [out]  MF_ATTRIBUTE_TYPE *pType
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/2C3A3C30-DA10-4365-9F76-598A4CA7675C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2C3A3C30-DA10-4365-9F76-598A4CA7675C(v=VS.85,d=hv.2).aspx</a></remarks>
        public int GetItemType(Guid guidKey, out MFAttributeType pType)
        {
            COM.VerifyAccess();
            return this._Attributes.GetItemType(guidKey, out pType);
        }

        /// <summary>
        /// Retrieves a wide-character string associated with a key.
        /// </summary>
        /// <param name="guidKey">GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_STRING</strong>.</param>
        /// <param name="pwszValue">Pointer to a wide-character array allocated by the caller. The array must be large enough to hold
        /// the string, including the terminating <strong>NULL</strong> character. If the key is found and the
        /// value is a string type, the method copies the string into this buffer. To find the length of the
        /// string, call <see cref="M:MediaFoundation.IMFAttributes.GetStringLength(System.Guid,System.Int32@)" />.</param>
        /// <param name="cchBufSize">The size of the <em>pwszValue</em> array, in characters. This value includes the terminating NULL
        /// character.</param>
        /// <param name="pcchLength">Receives the number of characters in the string, excluding the terminating <strong>NULL</strong>
        /// character. This parameter can be <strong>NULL</strong>.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item><item><term><strong>E_OUTOFMEMORY</strong></term><description>The length of the string is too large to fit in a <strong>UINT32</strong> value. </description></item><item><term><strong>E_NOT_SUFFICIENT_BUFFER</strong></term><description>The buffer is not large enough to hold the string.</description></item><item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>The specified key was not found.</description></item><item><term><strong>MF_E_INVALIDTYPE</strong></term><description>The attribute value is not a string.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetString(
        /// [in]   REFGUID guidKey,
        /// [out]  LPWSTR pwszValue,
        /// [in]   UINT32 cchBufSize,
        /// [out]  UINT32 *pcchLength
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/756D8FBA-D372-46F9-8035-F657D7FF133F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/756D8FBA-D372-46F9-8035-F657D7FF133F(v=VS.85,d=hv.2).aspx</a></remarks>
        public int GetString(Guid guidKey, StringBuilder pwszValue, int cchBufSize, out int pcchLength)
        {
            COM.VerifyAccess();
            return this._Attributes.GetString(guidKey, pwszValue, cchBufSize, out pcchLength);
        }

        /// <summary>
        /// Retrieves the length of a string value associated with a key.
        /// </summary>
        /// <param name="guidKey">GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_STRING</strong>.</param>
        /// <param name="pcchLength">If the key is found and the value is a string type, this parameter receives the number of
        /// characters in the string, not including the terminating <strong>NULL</strong> character. To get the
        /// string value, call <see cref="M:MediaFoundation.IMFAttributes.GetString(System.Guid,System.Text.StringBuilder,System.Int32,System.Int32@)" />.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item><item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>The specified key was not found.</description></item><item><term><strong>MF_E_INVALIDTYPE</strong></term><description>The attribute value is not a string.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStringLength(
        /// [in]   REFGUID guidKey,
        /// [out]  UINT32 *pcchLength
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/6CCC753F-E147-47F4-AB95-17687729404A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6CCC753F-E147-47F4-AB95-17687729404A(v=VS.85,d=hv.2).aspx</a></remarks>
        public int GetStringLength(Guid guidKey, out int pcchLength)
        {
            COM.VerifyAccess();
            return this._Attributes.GetStringLength(guidKey, out pcchLength);
        }

        /// <summary>
        /// Retrieves a <strong>UINT32</strong> value associated with a key.
        /// </summary>
        /// <param name="guidKey">GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_UINT32</strong>.</param>
        /// <param name="punValue">Receives a <strong>UINT32</strong> value. If the key is found and the data type is <strong>UINT32
        /// </strong>, the method copies the value into this parameter. Otherwise, the original value of this
        /// parameter is not changed.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item><item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>The specified key was not found.</description></item><item><term><strong>MF_E_INVALIDTYPE</strong></term><description>The attribute value is not a <strong>UINT32</strong>. </description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetUINT32(
        /// [in]   REFGUID guidKey,
        /// [out]  UINT32 *punValue
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/E47495E0-3274-4CE2-9FD3-D2FB2AFB7578(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E47495E0-3274-4CE2-9FD3-D2FB2AFB7578(v=VS.85,d=hv.2).aspx</a></remarks>
        public int GetUINT32(Guid guidKey, out int punValue)
        {
            COM.VerifyAccess();
            return this._Attributes.GetUINT32(guidKey, out punValue);
        }

        /// <summary>
        /// Retrieves a <strong>UINT64</strong> value associated with a key.
        /// </summary>
        /// <param name="guidKey">GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_UINT64</strong>.</param>
        /// <param name="punValue">Receives a <strong>UINT64</strong> value. If the key is found and the data type is <strong>UINT64
        /// </strong>, the method copies the value into this parameter. Otherwise, the original value of this
        /// parameter is not changed.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item><item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description> The specified key was not found. </description></item><item><term><strong>MF_E_INVALIDTYPE</strong></term><description> The attribute value is not a <strong>UINT64</strong>. </description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetUINT64(
        /// [in]   REFGUID guidKey,
        /// [out]  UINT64 *punValue
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/F3240FFF-48D8-4D88-8C75-15F00BFE72ED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F3240FFF-48D8-4D88-8C75-15F00BFE72ED(v=VS.85,d=hv.2).aspx</a></remarks>
        public int GetUINT64(Guid guidKey, out long punValue)
        {
            COM.VerifyAccess();
            return this._Attributes.GetUINT64(guidKey, out punValue);
        }

        /// <summary>
        /// Retrieves an interface pointer associated with a key.
        /// </summary>
        /// <param name="guidKey">GUID that identifies which value to retrieve. The attribute type must be <strong>
        /// MF_ATTRIBUTE_IUNKNOWN</strong>.</param>
        /// <param name="riid">Interface identifier (IID) of the interface to retrieve.</param>
        /// <param name="ppv">Receives a pointer to the requested interface. The caller must release the interface.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item><item><term><strong>E_NOINTERFACE</strong></term><description>The attribute value is an <strong>IUnknown</strong> pointer but does not support requested interface. </description></item><item><term><strong>MF_E_ATTRIBUTENOTFOUND</strong></term><description>The specified key was not found.</description></item><item><term><strong>MF_E_INVALIDTYPE</strong></term><description>The attribute value is not an <strong>IUnknown</strong> pointer. </description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetUnknown(
        /// [in]   REFGUID guidKey,
        /// [in]   REFIID riid,
        /// [out]  LPVOID *ppv
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/A5F645A1-B7D2-47D3-B77E-AD94815B1C25(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A5F645A1-B7D2-47D3-B77E-AD94815B1C25(v=VS.85,d=hv.2).aspx</a></remarks>
        public int GetUnknown(Guid guidKey, Guid riid, out IntPtr ppv)
        {
            COM.VerifyAccess();
            return this._Attributes.GetUnknown(guidKey, riid, out ppv);
        }

        /// <summary>
        /// Locks the attribute store so that no other thread can access it. If the attribute store is already
        /// locked by another thread, this method blocks until the other thread unlocks the object. After
        /// calling this method, call <see cref="M:MediaFoundation.IMFAttributes.UnlockStore" /> to unlock the object.
        /// </summary>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT LockStore();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/6EC7AED3-7DBC-4AA4-92D5-646AEE757DB7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6EC7AED3-7DBC-4AA4-92D5-646AEE757DB7(v=VS.85,d=hv.2).aspx</a></remarks>
        public int LockStore()
        {
            COM.VerifyAccess();
            return this._Attributes.LockStore();
        }

        /// <summary>
        /// Associates a byte array with a key.
        /// </summary>
        /// <param name="guidKey">GUID that identifies the value to set. If this key already exists, the method overwrites the old
        /// value.</param>
        /// <param name="pBuf">Pointer to a byte array to associate with this key. The method stores a copy of the array.</param>
        /// <param name="cbBufSize">Size of the array, in bytes.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetBlob(
        /// [in]  REFGUID guidKey,
        /// [in]  const UINT8 *pBuf,
        /// [in]  UINT32 cbBufSize
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/4A2A25A9-4DEA-40C8-988C-9E3806C8F31C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4A2A25A9-4DEA-40C8-988C-9E3806C8F31C(v=VS.85,d=hv.2).aspx</a></remarks>
        public int SetBlob(Guid guidKey, byte[] pBuf, int cbBufSize)
        {
            COM.VerifyAccess();
            return this._Attributes.SetBlob(guidKey, pBuf, cbBufSize);
        }

        /// <summary>
        /// Associates a <strong>double</strong> value with a key.
        /// </summary>
        /// <param name="guidKey">GUID that identifies the value to set. If this key already exists, the method overwrites the old
        /// value.</param>
        /// <param name="fValue">New value for this key.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetDouble(
        /// [in]  REFGUID guidKey,
        /// [in]  double fValue
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/BB58F35E-0FCA-4B19-9976-DE2140E6EBC0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BB58F35E-0FCA-4B19-9976-DE2140E6EBC0(v=VS.85,d=hv.2).aspx</a></remarks>
        public int SetDouble(Guid guidKey, double fValue)
        {
            COM.VerifyAccess();
            return this._Attributes.SetDouble(guidKey, fValue);
        }

        /// <summary>
        /// Associates a GUID value with a key.
        /// </summary>
        /// <param name="guidKey">GUID that identifies the value to set. If this key already exists, the method overwrites the old
        /// value.</param>
        /// <param name="guidValue">New value for this key.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item><item><term><strong>E_OUTOFMEMORY</strong></term><description>Insufficient memory.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetGUID(
        /// [in]  REFGUID guidKey,
        /// [in]  REFGUID guidValue
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/D73B53F5-4A8F-4903-986D-FBF4277A2D45(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D73B53F5-4A8F-4903-986D-FBF4277A2D45(v=VS.85,d=hv.2).aspx</a></remarks>
        public int SetGUID(Guid guidKey, Guid guidValue)
        {
            COM.VerifyAccess();
            return this._Attributes.SetGUID(guidKey, guidValue);
        }

        /// <summary>
        /// Adds an attribute value with a specified key.
        /// </summary>
        /// <param name="guidKey">A GUID that identifies the value to set. If this key already exists, the method overwrites the old
        /// value.</param>
        /// <param name="value">A <strong>PROPVARIANT</strong> that contains the attribute value. The method copies the value. The
        /// <strong>PROPVARIANT</strong> type must be one of the types listed in the
        /// <see cref="T:MediaFoundation.MFAttributeType" /> enumeration.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item><item><term><strong>E_OUTOFMEMORY</strong></term><description> Insufficient memory. </description></item><item><term><strong>MF_E_INVALIDTYPE</strong></term><description> Invalid attribute type. </description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetItem(
        /// [in]  REFGUID guidKey,
        /// [in]  REFPROPVARIANT Value
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/1AC6E1C3-CF78-4CFF-A992-4F92F243C443(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1AC6E1C3-CF78-4CFF-A992-4F92F243C443(v=VS.85,d=hv.2).aspx</a></remarks>
        public int SetItem(Guid guidKey, ConstPropVariant value)
        {
            COM.VerifyAccess();
            return this._Attributes.SetItem(guidKey, value);
        }

        /// <summary>
        /// Associates a wide-character string with a key.
        /// </summary>
        /// <param name="guidKey">GUID that identifies the value to set. If this key already exists, the method overwrites the old
        /// value.</param>
        /// <param name="wszValue">Null-terminated wide-character string to associate with this key. The method stores a copy of the
        /// string.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetString(
        /// [in]  REFGUID guidKey,
        /// [in]  LPCWSTR wszValue
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/51D2A2A0-92CB-49E0-B4A9-7201E9D92322(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/51D2A2A0-92CB-49E0-B4A9-7201E9D92322(v=VS.85,d=hv.2).aspx</a></remarks>
        public int SetString(Guid guidKey, string wszValue)
        {
            COM.VerifyAccess();
            return this._Attributes.SetString(guidKey, wszValue);
        }

        /// <summary>
        /// Associates a <strong>UINT32</strong> value with a key.
        /// </summary>
        /// <param name="guidKey">GUID that identifies the value to set. If this key already exists, the method overwrites the old
        /// value.</param>
        /// <param name="unValue">New value for this key.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetUINT32(
        /// [in]  REFGUID guidKey,
        /// [in]  UINT32 unValue
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/9C30FD56-719F-4831-8FBF-CEFCF9D72709(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9C30FD56-719F-4831-8FBF-CEFCF9D72709(v=VS.85,d=hv.2).aspx</a></remarks>
        public int SetUINT32(Guid guidKey, int unValue)
        {
            COM.VerifyAccess();
            return this._Attributes.SetUINT32(guidKey, unValue);
        }

        /// <summary>
        /// Associates a <strong>UINT64</strong> value with a key.
        /// </summary>
        /// <param name="guidKey">GUID that identifies the value to set. If this key already exists, the method overwrites the old
        /// value.</param>
        /// <param name="unValue">New value for this key.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetUINT64(
        /// [in]  REFGUID guidKey,
        /// [in]  UINT64 unValue
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/817ED1C1-16AD-4520-A1A0-A93563936B50(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/817ED1C1-16AD-4520-A1A0-A93563936B50(v=VS.85,d=hv.2).aspx</a></remarks>
        public int SetUINT64(Guid guidKey, long unValue)
        {
            COM.VerifyAccess();
            return this._Attributes.SetUINT64(guidKey, unValue);
        }

        /// <summary>
        /// Associates an <strong>IUnknown</strong> pointer with a key.
        /// </summary>
        /// <param name="guidKey">GUID that identifies the value to set. If this key already exists, the method overwrites the old
        /// value.</param>
        /// <param name="pUnknown"><strong>IUnknown</strong> pointer to be associated with this key.</param>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetUnknown(
        /// [in]  REFGUID guidKey,
        /// [in]  IUnknown *pUnknown
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/DA0C3D59-07C4-4431-A137-8655DDBF6258(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DA0C3D59-07C4-4431-A137-8655DDBF6258(v=VS.85,d=hv.2).aspx</a></remarks>
        public int SetUnknown(Guid guidKey, object pUnknown)
        {
            COM.VerifyAccess();
            return this._Attributes.SetUnknown(guidKey, pUnknown);
        }

        /// <summary>
        /// Unlocks the attribute store after a call to the <see cref="M:MediaFoundation.IMFAttributes.LockStore" /> method. While
        /// the object is unlocked, multiple threads can access the object's attributes.
        /// </summary>
        /// <returns>The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para /><list type="table"><listheader><term>Return code</term><description>Description</description></listheader><item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item></list></returns>
        /// <remarks><code language="cpp" title="C/C++ Syntax">
        /// HRESULT UnlockStore();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/65E35864-868A-4AE9-86ED-772A2B2DAEB6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/65E35864-868A-4AE9-86ED-772A2B2DAEB6(v=VS.85,d=hv.2).aspx</a></remarks>
        public int UnlockStore()
        {
            COM.VerifyAccess();
            return this._Attributes.UnlockStore();
        }

        #endregion

    }
}
