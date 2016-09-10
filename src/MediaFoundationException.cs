using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MediaFoundation
{
    /// <summary>
    /// he exception that is thrown when an unrecognized HRESULT is returned from a
    /// COM method call to the Media Foundation API or COM interface.
    /// </summary>
    /// <seealso cref="System.Runtime.InteropServices.COMException" />
    public class MediaFoundationException : COMException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaFoundationException"/> class.
        /// </summary>
        public MediaFoundationException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaFoundationException"/> class.
        /// </summary>
        /// <param name="message">The message that indicates the reason for the exception.</param>
        public MediaFoundationException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaFoundationException"/> class.
        /// </summary>
        /// <param name="message">The message that indicates the reason the exception occurred.</param>
        /// <param name="errorCode">The error code (HRESULT) value associated with this exception.</param>
        public MediaFoundationException(string message, int errorCode)
            : base(message, errorCode)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaFoundationException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception.</param>
        public MediaFoundationException(string message, Exception inner)
            : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaFoundationException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that holds the serialized object data.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that supplies the contextual information about the source or destination.</param>
        protected MediaFoundationException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
