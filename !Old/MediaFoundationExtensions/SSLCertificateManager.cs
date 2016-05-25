using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SSLCertificateManager"/> class implements a wrapper around the
    /// <see cref="IMFSSLCertificateManager"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSSLCertificateManager"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSSLCertificateManager"/>: 
    /// Implemented by a client and called by Microsoft Media Foundation to get the client Secure Sockets
    /// Layer (SSL) certificate requested by the server. 
    /// <para/>
    /// In most HTTPS connections the server provides a certificate so that the client can ensure the
    /// identity of the server. However, in certain cases the server might wants to verify the identity of
    /// the client by requesting the client to send a certificate. For this scenario, a client application
    /// must provide a mechanism for Media Foundation to retrieve the client side certificate while opening
    /// an HTTPS URL with the source resolver or the scheme handler. The application must implement 
    /// <strong>IMFSSLCertificateManager</strong>, set the <strong>IUnknown</strong> pointer of the
    /// implemented object in the <see cref="MFProperties.MFNETSOURCE_SSLCERTIFICATE_MANAGER"/> property,
    /// and pass the property store to the source resolver. While opening the URL, Media Foundation calls
    /// the <strong>IMFSSLCertificateManager</strong> methods to get the certificate information. If the
    /// application needs to connect to HTTPS URL that requires a client-side certificate, or the
    /// application wants customized control over the type of server certificates to accept, then they can
    /// implement this interface. This interface can also be used by the application to validate the server
    /// SSL certificate. 
    /// <para/>
    /// If the <strong>IUnknown</strong> pointer is not provided by the application and the HTTPS URL does
    /// not require the client to provide a certificate, Media Foundation uses the default implementation
    /// to open the URL. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/62E4227D-6BC9-4011-ACEE-6278FE388830(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/62E4227D-6BC9-4011-ACEE-6278FE388830(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SSLCertificateManager : COM<IMFSSLCertificateManager>
    {
        #region Construction

        internal SSLCertificateManager(IMFSSLCertificateManager comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
