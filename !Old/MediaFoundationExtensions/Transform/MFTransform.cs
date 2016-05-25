using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Transform;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="Transform"/> class implements a wrapper around the
    /// <see cref="IMFTransform"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFTransform"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFTransform"/>: 
    /// Implemented by all <c>Media Foundation Transforms</c> (MFTs). 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/3CC502D8-D364-43B9-B0B6-D9474C002B20(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3CC502D8-D364-43B9-B0B6-D9474C002B20(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MFTransform : COM<IMFTransform>
    {
        #region Construction

        internal MFTransform(IMFTransform comInterface)
            : base(comInterface)
        {
        }

        #endregion

        /// <summary>
        /// There is no maximum of streams.
        /// </summary>
        public const int MFT_STREAMS_UNLIMITED = unchecked((int)0xFFFFFFFF);


    }
}
