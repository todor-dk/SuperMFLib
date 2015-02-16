using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="OutputSchema"/> class implements a wrapper arround the
    /// <see cref="IMFOutputSchema"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFOutputSchema"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFOutputSchema"/>: 
    /// Encapsulates information about an output protection system and its corresponding configuration
    /// data.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D0786628-DDE9-43A9-8E81-0B0C396AD426(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D0786628-DDE9-43A9-8E81-0B0C396AD426(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class OutputSchema : COM<IMFOutputSchema>
    {
        #region Construction

        internal OutputSchema(IMFOutputSchema comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
