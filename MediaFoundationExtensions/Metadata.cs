using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;
using System.Runtime.InteropServices;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="Metadata"/> class implements a wrapper arround the
    /// <see cref="IMFMetadata"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMetadata"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMetadata"/>: 
    /// Manages metadata for an object. Metadata is information that describes a media file, stream, or
    /// other content. Metadata consists of individual properties, where each property contains a
    /// descriptive name and a value. A property may be associated with a particular language.
    /// <para/>
    /// To get this interface from a media source, use the <see cref="IMFMetadataProvider"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/411658CA-DC5E-445B-8D61-0C0429FCFBB1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/411658CA-DC5E-445B-8D61-0C0429FCFBB1(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class Metadata : COM<IMFMetadata>
    {
        #region Construction

        internal Metadata(IMFMetadata comInterface)
            : base(comInterface)
        {
        }

        #endregion

        /// <summary>
        /// Gets or sets the RFC 1766-compliant language string for setting and retrieving metadata. 
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DA615053-DDD5-448E-905C-B060CDAEFA95(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DA615053-DDD5-448E-905C-B060CDAEFA95(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public string Language
        {
            get
            {
                string ppwszRFC1766;
                int hr = this.Interface.GetLanguage(out ppwszRFC1766);
                // MF_E_INVALIDREQUEST: No language was set (yet).
                if (hr == MFError.MF_E_INVALIDREQUEST)
                    return null;
                COM.ThrowIfNotOK(hr);
                return ppwszRFC1766;
            }
            set
            {
                int hr = this.Interface.SetLanguage(value);
                COM.ThrowIfNotOK(hr);
            }
        }


        /// <summary>
        /// Gets a list in RFC 1766-compliant language tags of the languages in which metadata is available.
        /// </summary>
        /// <returns>
        /// An array with the list of languages. Each string in the array is an RFC 1766-compliant language tag. 
        /// The array might be empty, if no language tags are present.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/69296EC5-5811-4F0F-AE9C-CABCA3E66158(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/69296EC5-5811-4F0F-AE9C-CABCA3E66158(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public string[] GetAllLanguages()
        {
            using(PropVariant variant = new PropVariant())
            {
                int hr = this.Interface.GetAllLanguages(variant);
                COM.ThrowIfNotOK(hr);
                return variant.GetStringArray();
            }
        }


        /// <summary>
        /// Sets the value of a metadata property. 
        /// </summary>
        /// <param name="name">
        /// String containing the name of the property.
        /// </param>
        /// <param name="value">
        /// The value of the property. For multivalued properties, use an array.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/416A7FBA-506C-405D-A230-7E8A1C801209(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/416A7FBA-506C-405D-A230-7E8A1C801209(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetProperty(string name, object value)
        {
            using(ConstPropVariant ppvValue = PropVariant.FromValue(value))
            {
                int hr = this.Interface.SetProperty(name, ppvValue);
                COM.ThrowIfNotOK(hr);
            }
        }

        /// <summary>
        /// Gets the value of a metadata property.
        /// </summary>
        /// <param name="name">
        /// The name of the property. To get the list of property names, call <see cref="GetAllPropertyNames"/>. 
        /// </param>
        /// <returns>
        /// The value of the property. For multivalued properties, the result is an array.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/177C8612-5C9F-4A71-9EE1-A4C67737AF2D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/177C8612-5C9F-4A71-9EE1-A4C67737AF2D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public object GetProperty(string name)
        {
            using (PropVariant value = new PropVariant())
            {
                int hr = this.Interface.GetProperty(name, value);
                // MF_E_PROPERTY_NOT_FOUND: The requested property was not found.
                if (hr == MFError.MF_E_PROPERTY_NOT_FOUND)
                    throw new COMException("The requested property was not found.", hr);
                COM.ThrowIfNotOK(hr);
                return value.GetValue();
            }
        }

        /// <summary>
        /// Deletes a metadata property.
        /// </summary>
        /// <param name="name">
        /// The name of the property.
        /// </param>
        /// <returns>
        /// True if the property was delete or false if the property was not found. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7C9A406D-6144-4E9C-B62C-1D9C691391F0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7C9A406D-6144-4E9C-B62C-1D9C691391F0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public bool DeleteProperty(string name)
        {
            int hr = this.Interface.DeleteProperty(name);
            // MF_E_PROPERTY_NOT_FOUND: The property was not found. 
            if (hr == MFError.MF_E_PROPERTY_NOT_FOUND)
                return false;
            COM.ThrowIfNotOK(hr);
            return true;
        }

        /// <summary>
        /// Gets a list of all the metadata property names on this object.
        /// </summary>
        /// <returns>
        /// An array with the property names. If no properties are available, <strong>null</strong> is returned.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E0944D42-D6E6-420D-9980-CA6C62736B3D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E0944D42-D6E6-420D-9980-CA6C62736B3D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public string[] GetAllPropertyNames()
        {
            using(PropVariant value = new PropVariant())
            {
                int hr = this.Interface.GetAllPropertyNames(value);
                COM.ThrowIfNotOK(hr);
                if (value.ValueType == ConstPropVariant.VariantType.None)
                    return null;
                return value.GetStringArray();
            }
        }
    }
}
