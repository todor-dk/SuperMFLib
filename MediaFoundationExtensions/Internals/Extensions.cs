using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaFoundation.Internals
{
    internal static class Extensions
    {
        public static TInterface GetInterface<TInterface>(this COM<TInterface> self)
            where TInterface : class
        {
            if (self == null)
                return null;
            return self.Interface;
        }
    }
}
