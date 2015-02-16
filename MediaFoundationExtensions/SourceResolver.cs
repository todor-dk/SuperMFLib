using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SourceResolver"/> class implements a wrapper around the
    /// <see cref="IMFSourceResolver"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSourceResolver"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSourceResolver"/>: 
    /// Creates a media source from a URL or a byte stream. The <c>Source Resolver</c> implements this
    /// interface. To create the source resolver, call <see cref="MFExtern.MFCreateSourceResolver"/>
    /// function. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/079C61C5-7A29-4411-840E-9349190726AC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/079C61C5-7A29-4411-840E-9349190726AC(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SourceResolver : COM<IMFSourceResolver>
    {
        #region Construction

        internal SourceResolver(IMFSourceResolver comInterface)
            : base(comInterface)
        {
        }

        #endregion

        /// <summary>
        /// Creates the source resolver, which is used to create a media source from a URL or byte stream. 
        /// </summary>
        /// <returns>A new source resolve object. The caller must dispose this object.</returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/60D6B0E2-5AB2-4A20-99D9-E6B806A1F576(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/60D6B0E2-5AB2-4A20-99D9-E6B806A1F576(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static SourceResolver Create()
        {
            IMFSourceResolver resolver;
            int hr = MFExtern.MFCreateSourceResolver(out resolver);
            COM.ThrowIfNotOK(hr);
            return resolver.ToSourceResolver();
        }


        /// <summary>
        /// Creates a media source or a byte stream from a URL. This method is synchronous. 
        /// </summary>
        /// <param name="url">
        /// The URL to resolve. 
        /// </param>
        /// <param name="flags">
        /// Bitwise OR of one or more flags. <see cref="MFResolution"/>. 
        /// </param>
        /// <param name="properties">
        /// Optional <see cref="PropertyStore"/> property store. The method passes the
        /// property store to the scheme handler or byte-stream handler that creates the object. The handler
        /// can use the property store to configure the object. 
        /// </param>
        /// <param name="objectType">
        /// Returns the type of object that was created. 
        /// </param>
        /// <returns>
        /// A <see cref="MediaSource"/> or <see cref="ByteStream"/> object. The caller must dispose this object.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B8F751B1-6456-4D67-839D-ECFA388E8D71(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B8F751B1-6456-4D67-839D-ECFA388E8D71(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public object CreateObjectFromURL(string url, MFResolution flags, PropertyStore properties, out MFObjectType objectType)
        {
            object value;
            int hr = this.Interface.CreateObjectFromURL(url, flags, properties.GetInterface(), out objectType, out value);
            COM.ThrowIfNotOK(hr);
            if (objectType == MFObjectType.MediaSource)
                return ((IMFMediaSource)value).ToMediaSource();
            if (objectType == MFObjectType.ByteStream)
                return ((IMFByteStream)value).ToByteStream();
            return null; // Must be invalid!
        }

        /// <summary>
        /// Creates a media source or a byte stream from a URL. This method is synchronous. 
        /// </summary>
        /// <param name="url">
        /// The URL to resolve. 
        /// </param>
        /// <param name="flags">
        /// Bitwise OR of one or more flags. <see cref="MFResolution"/>. 
        /// </param>
        /// <param name="properties">
        /// Optional <see cref="PropertyStore"/> property store. The method passes the
        /// property store to the scheme handler or byte-stream handler that creates the object. The handler
        /// can use the property store to configure the object. 
        /// </param>
        /// <returns>
        /// A <see cref="MediaSource"/> or <see cref="ByteStream"/> object. The caller must dispose this object.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B8F751B1-6456-4D67-839D-ECFA388E8D71(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B8F751B1-6456-4D67-839D-ECFA388E8D71(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public object CreateObjectFromURL(string url, MFResolution flags, PropertyStore properties)
        {
            MFObjectType objectType;
            return this.CreateObjectFromURL(url, flags, properties, out objectType);
        }

        /// <summary>
        /// Creates a media source from a byte stream. This method is synchronous. 
        /// </summary>
        /// <param name="byteStream">
        /// The <see cref="ByteStream"/> object. 
        /// </param>
        /// <param name="url">
        /// String that contains the URL of the byte stream. The URL is optional and can be 
        /// <strong>null</strong>. See Remarks for more information. 
        /// </param>
        /// <param name="flags">
        /// Bitwise OR of one or more flags. <see cref="MFResolution"/>. 
        /// </param>
        /// <param name="properties">
        /// Optional <see cref="PropertyStore"/> property store. The method passes the
        /// property store to the scheme handler or byte-stream handler that creates the object. The handler
        /// can use the property store to configure the object. 
        /// </param>
        /// <param name="objectType">
        /// Returns the type of object that was created. 
        /// </param>
        /// <returns>
        /// A <see cref="MediaSource"/> or <see cref="ByteStream"/> object. The caller must dispose this object.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E4A4AAD5-0924-4251-B0DA-6919AE010BF0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E4A4AAD5-0924-4251-B0DA-6919AE010BF0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public object CreateObjectFromByteStream(ByteStream byteStream, string url, MFResolution flags, PropertyStore properties, out MFObjectType objectType)
        {
            object value;
            int hr = this.Interface.CreateObjectFromByteStream(byteStream.GetInterface(), url, flags, properties.GetInterface(), out objectType, out value);
            COM.ThrowIfNotOK(hr);
            if (objectType == MFObjectType.MediaSource)
                return ((IMFMediaSource)value).ToMediaSource();
            if (objectType == MFObjectType.ByteStream)
                return ((IMFByteStream)value).ToByteStream();
            return null; // Must be invalid!
        }

        /// <summary>
        /// Creates a media source from a byte stream. This method is synchronous. 
        /// </summary>
        /// <param name="byteStream">
        /// The <see cref="ByteStream"/> object. 
        /// </param>
        /// <param name="url">
        /// String that contains the URL of the byte stream. The URL is optional and can be 
        /// <strong>null</strong>. See Remarks for more information. 
        /// </param>
        /// <param name="flags">
        /// Bitwise OR of one or more flags. <see cref="MFResolution"/>. 
        /// </param>
        /// <param name="properties">
        /// Optional <see cref="PropertyStore"/> property store. The method passes the
        /// property store to the scheme handler or byte-stream handler that creates the object. The handler
        /// can use the property store to configure the object. 
        /// </param>
        /// <returns>
        /// A <see cref="MediaSource"/> or <see cref="ByteStream"/> object. The caller must dispose this object.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E4A4AAD5-0924-4251-B0DA-6919AE010BF0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E4A4AAD5-0924-4251-B0DA-6919AE010BF0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public object CreateObjectFromByteStream(ByteStream byteStream, string url, MFResolution flags, PropertyStore properties)
        {
            MFObjectType objectType;
            return this.CreateObjectFromByteStream(byteStream, url, flags, properties, out objectType);
        }

        /// <summary>
        /// Begins an asynchronous request to create a media source or a byte stream from a URL.
        /// </summary>
        /// <param name="url">
        /// String that contains the URL to resolve.
        /// </param>
        /// <param name="flags">
        /// Bitwise OR of one or more flags. <see cref="MFResolution"/>. 
        /// </param>
        /// <param name="properties">
        /// Optional <see cref="PropertyStore"/> property store. The method passes the
        /// property store to the scheme handler or byte-stream handler that creates the object. The handler
        /// can use the property store to configure the object. 
        /// </param>
        /// <param name="callback">
        /// An <see cref="AsyncCallback"/> object. The caller must implement this object. 
        /// </param>
        /// <param name="state">
        /// A state object, defined by the caller. This parameter can be <strong>null</strong>. 
        /// You can use this object to hold state information. The object is returned to the 
        /// caller when the callback is invoked. 
        /// </param>
        /// <returns>
        /// Returns an object or <strong>null</strong>. If the value is not <strong>null</strong>, 
        /// you can cancel the asynchronous operation by passing this value to the <see cref="CancelObjectCreation"/> 
        /// method. The caller must dispose this the object.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BC97C1FB-D23A-4887-B6AC-0751C254A405(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BC97C1FB-D23A-4887-B6AC-0751C254A405(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public CancelCookie BeginCreateObjectFromURL(string url, MFResolution flags, PropertyStore properties, AsyncCallback callback, object state)
        {
            object cancelCookie;
            int hr = this.Interface.BeginCreateObjectFromURL(url, flags, properties.GetInterface(), out cancelCookie, callback, state);
            COM.ThrowIfNotOK(hr);
            if (cancelCookie == null)
                return null;
            else
                return new CancelCookie(cancelCookie);
        }

        /// <summary>
        /// Represents an obbject that can be passed to <see cref="CancelObjectCreation"/>.
        /// </summary>
        public class CancelCookie : COM<object>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="CancelCookie"/> class.
            /// </summary>
            /// <param name="comInterface">The COM interface.</param>
            public CancelCookie (object comInterface)
                : base(comInterface)
	        {
	        }
        }

        /// <summary>
        /// Completes an asynchronous request to create an object from a URL. 
        /// </summary>
        /// <param name="result">
        /// The <see cref="AsyncResult"/> interface. Pass in the same object that your callback object received in the <c>Invoke</c> method. 
        /// </param>
        /// <param name="objectType">
        /// Returns the type of object that was created. 
        /// </param>
        /// <returns>
        /// A <see cref="MediaSource"/> or <see cref="ByteStream"/> object. The caller must dispose this object.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AF50A76D-B083-4815-BBFF-820B21FF8D1B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AF50A76D-B083-4815-BBFF-820B21FF8D1B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public object EndCreateObjectFromURL(AsyncResult result, out MFObjectType objectType)
        {
            object value;
            int hr = this.Interface.EndCreateObjectFromURL(result.GetInterface(), out objectType, out value);
            COM.ThrowIfNotOK(hr);
            if (objectType == MFObjectType.MediaSource)
                return ((IMFMediaSource)value).ToMediaSource();
            if (objectType == MFObjectType.ByteStream)
                return ((IMFByteStream)value).ToByteStream();
            return null; // Must be invalid!
        }

        /// <summary>
        /// Completes an asynchronous request to create an object from a URL. 
        /// </summary>
        /// <param name="result">
        /// The <see cref="AsyncResult"/> interface. Pass in the same object that your callback object received in the <c>Invoke</c> method. 
        /// </param>
        /// <returns>
        /// A <see cref="MediaSource"/> or <see cref="ByteStream"/> object. The caller must dispose this object.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AF50A76D-B083-4815-BBFF-820B21FF8D1B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AF50A76D-B083-4815-BBFF-820B21FF8D1B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public object EndCreateObjectFromURL(AsyncResult result)
        {
            MFObjectType objectType;
            return this.EndCreateObjectFromURL(result, out objectType);
        }

        /// <summary>
        /// Begins an asynchronous request to create a media source from a byte stream.
        /// </summary>
        /// <param name="byteStream">
        /// The <see cref="ByteStream"/> object. 
        /// </param>
        /// <param name="url">
        /// String that contains the URL of the byte stream. The URL is optional and can be 
        /// <strong>null</strong>. See Remarks for more information. 
        /// </param>
        /// <param name="flags">
        /// Bitwise OR of one or more flags. <see cref="MFResolution"/>. 
        /// </param>
        /// <param name="properties">
        /// Optional <see cref="PropertyStore"/> property store. The method passes the
        /// property store to the scheme handler or byte-stream handler that creates the object. The handler
        /// can use the property store to configure the object. 
        /// </param>
        /// <param name="callback">
        /// An <see cref="AsyncCallback"/> object. The caller must implement this object. 
        /// </param>
        /// <param name="state">
        /// A state object, defined by the caller. This parameter can be <strong>null</strong>. 
        /// You can use this object to hold state information. The object is returned to the 
        /// caller when the callback is invoked. 
        /// </param>
        /// <returns>
        /// Returns an object or <strong>null</strong>. If the value is not <strong>null</strong>, 
        /// you can cancel the asynchronous operation by passing this value to the <see cref="CancelObjectCreation"/> 
        /// method. The caller must dispose this the object.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6E218B93-4855-40DD-96CC-C4EE02792C14(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6E218B93-4855-40DD-96CC-C4EE02792C14(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public CancelCookie BeginCreateObjectFromByteStream(ByteStream byteStream, string url, MFResolution flags, PropertyStore properties, AsyncCallback callback, object state)
        {
            object cancelCookie;
            int hr = this.Interface.BeginCreateObjectFromByteStream(byteStream.GetInterface(), url, flags, properties.GetInterface(), out cancelCookie, callback, state);
            COM.ThrowIfNotOK(hr);
            if (cancelCookie == null)
                return null;
            else
                return new CancelCookie(cancelCookie);
        }

        /// <summary>
        /// Completes an asynchronous request to create a media source from a byte stream.
        /// </summary>
        /// <param name="result">
        /// The <see cref="AsyncResult"/> interface. Pass in the same object that your callback object received in the <c>Invoke</c> method. 
        /// </param>
        /// <param name="objectType">
        /// Returns the type of object that was created. 
        /// </param>
        /// <returns>
        /// A <see cref="MediaSource"/> or <see cref="ByteStream"/> object. The caller must dispose this object.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/54532C0E-772B-45B6-95A3-5959023B9BC8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/54532C0E-772B-45B6-95A3-5959023B9BC8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public object EndCreateObjectFromByteStream(AsyncResult result, out MFObjectType objectType)
        {
            object value;
            int hr = this.Interface.EndCreateObjectFromByteStream(result.GetInterface(), out objectType, out value);
            COM.ThrowIfNotOK(hr);
            if (objectType == MFObjectType.MediaSource)
                return ((IMFMediaSource)value).ToMediaSource();
            if (objectType == MFObjectType.ByteStream)
                return ((IMFByteStream)value).ToByteStream();
            return null; // Must be invalid!
        }

        /// <summary>
        /// Completes an asynchronous request to create a media source from a byte stream.
        /// </summary>
        /// <param name="result">
        /// The <see cref="AsyncResult"/> interface. Pass in the same object that your callback object received in the <c>Invoke</c> method. 
        /// </param>
        /// <returns>
        /// A <see cref="MediaSource"/> or <see cref="ByteStream"/> object. The caller must dispose this object.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/54532C0E-772B-45B6-95A3-5959023B9BC8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/54532C0E-772B-45B6-95A3-5959023B9BC8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public object EndCreateObjectFromByteStream(AsyncResult result)
        {
            MFObjectType objectType;
            return this.EndCreateObjectFromByteStream(result, out objectType);
        }

        /// <summary>
        /// Cancels an asynchronous request to create an object. 
        /// </summary>
        /// <param name="cancelCookie">A cancel cookie.</param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6A30AC92-A281-4293-8975-987FA25A5318(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6A30AC92-A281-4293-8975-987FA25A5318(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void CancelObjectCreation(CancelCookie cancelCookie)
        {
            int hr = this.Interface.CancelObjectCreation(cancelCookie.GetInterface());
            COM.ThrowIfNotOK(hr);
        }
    }
}
