using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFCollection"/> interface.
    /// </summary>
    public static class IMFCollectionExtensions
    {
        ///// <summary>
        ///// Encapsulates an instance of an <see cref="IMFCollection"/>
        ///// interface into a <see cref="Collection"/> COM wrapper object.
        ///// The <see cref="Collection"/> implements the <see cref="IDisposable"/>
        ///// interface to allow the object to be used with the C# <strong>using</strong>
        ///// statement. The wrapper also exposes <i>civilized</i> version of the
        ///// <see cref="IMFCollection"/> interface's methods.
        ///// </summary>
        ///// <param name="self">
        ///// Instance of an <see cref="IMFCollection"/> COM interface.
        ///// </param>
        ///// <returns>
        ///// COM wrapper over the given interface <paramref name="self"/>,
        ///// or <stong>null</stong> if <paramref name="self"/> is null.
        ///// </returns>
        //public static Collection ToCollection(this IMFCollection self)
        //{
        //    if (self == null)
        //        return null;
        //    return new Collection(self);
        //}

        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFCollection"/>
        /// interface into a <see cref="Collection{TItem}"/> COM wrapper object.
        /// The <see cref="Collection{TItem}"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFCollection"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFCollection"/> COM interface.
        /// </param>
        /// <param name="itemFactory">Factory to convert an object to a <typeparamref name="TItem"/>.</param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static Collection<TItem> ToCollection<TItem>(this IMFCollection self, Func<object, TItem> itemFactory)
            where TItem : COM
        {
            if (self == null)
                return null;
            return new Collection<TItem>(self, itemFactory);
        }
    }
}
