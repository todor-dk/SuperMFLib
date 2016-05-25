using MediaFoundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MF = MediaFoundation;

namespace TopoViewer.Framework
{
    public abstract class SourceResolver
    {
        /// <summary>
        /// Gets or sets a value indicating if the source resolver will match the file extension or mime type.
        /// </summary>
        /// <remarks>
        /// If source resolution fails using the byte-stream handler that is 
        /// registered for the MIME type or file name extension, the source resolver 
        /// enumerates through all of the registered byte-stream handlers.
        /// <para/>
        /// Byte-stream handlers are registered by file name extension or MIME type. 
        /// Initially, the source resolver attempts to use a handler that matches the 
        /// file name extension or the MIME type. If that fails, then by default the 
        /// entire source resolution fails and the source resolver returns an error 
        /// code to the application. If this flag is specified, however, the source resolver 
        /// continues to enumerates through all of the registered byte-stream handlers. 
        /// Possibly a mis-matched handler can successfully create the media source.
        /// </remarks>
        public bool DoNotMatchExtensionOrMimeType { get; set; }

        public MediaSource ResolveSource()
        {
            // Create the source resolver.
            using (MF.SourceResolver resolver = MF.SourceResolver.Create())
            {
                // Use the source resolver to create the media source.
                using (PropertyStore properties = PropertyStore.Create())   // Optional property store.
                {

                    //using (PropVariant value = new PropVariant(false))
                    //{
                    //    properties.SetValue(MFPKEY.ASFMediaSource_ApproxSeek, value);
                    //}
                    //using (PropVariant value = new PropVariant(true))
                    //{
                    //    properties.SetValue(MFPKEY.ASFMediaSource_IterativeSeekIfNoIndex, value);
                    //}
                    //using (PropVariant value = new PropVariant(50))
                    //{
                    //    properties.SetValue(MFPKEY.ASFMediaSource_IterativeSeek_Tolerance_In_MilliSecond, value);
                    //}
                    //using (PropVariant value = new PropVariant(10))
                    //{
                    //    properties.SetValue(MFPKEY.ASFMediaSource_IterativeSeek_Max_Count, value);
                    //}

                    MFObjectType type;
                    object obj;
                    this.ResolveSource(resolver, properties, out type, out obj);
                    // Get the IMFMediaSource interface from the media source.
                    if (type == MFObjectType.MediaSource)
                        return obj as MediaSource;
                    COM.SafeRelease(ref obj);
                    return null;
                }
            }
        }

        protected abstract void ResolveSource(MF.SourceResolver resolver, PropertyStore properties, out MFObjectType type, out object obj);
    }
}
