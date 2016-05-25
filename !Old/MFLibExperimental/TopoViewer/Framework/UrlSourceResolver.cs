using MediaFoundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM = MediaFoundation.COM;
using MF = MediaFoundation;

namespace TopoViewer.Framework
{
    public class UrlSourceResolver : SourceResolver
    {
        public Uri Url { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlSourceResolver"/> class.
        /// </summary>
        /// <param name="url">URL of the source file.</param>
        /// <param name="doNotMatchExtensionOrMimeType">Indicates if the source resolver will match the file extension or mime type.</param>
        public UrlSourceResolver(Uri url, bool doNotMatchExtensionOrMimeType)
        {
            

            this.Url = url;
            this.DoNotMatchExtensionOrMimeType = doNotMatchExtensionOrMimeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlSourceResolver"/> class.
        /// </summary>
        /// <param name="url">URL of the source file.</param>
        public UrlSourceResolver(Uri url)
            : this(url, true)
        {
        }

        protected override void ResolveSource(MF.SourceResolver resolver, PropertyStore properties, out MFObjectType type, out object obj)
        {
            MFResolution flags = MFResolution.MediaSource;
            if (this.DoNotMatchExtensionOrMimeType)
                flags = flags | MFResolution.ContentDoesNotHaveToMatchExtensionOrMimeType;
            // Note: For simplicity this sample uses the synchronous method to create 
            // the media source. However, creating a media source can take a noticeable
            // amount of time, especially for a network source. For a more responsive 
            // UI, use the asynchronous BeginCreateObjectFromURL method.
            obj = resolver.CreateObjectFromURL(this.Url.OriginalString, flags, properties, out type);
        }
    }
}
