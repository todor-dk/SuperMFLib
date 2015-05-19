using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFoundation.Internals
{
    internal static class Extensions
    {
        public static TInterface AccessInterface<TInterface>(this COM<TInterface> self)
            where TInterface : class
        {
            if (self == null)
                return null;
            return self.Interface;
        }

        public static object AccessInterface(this COM self)
        {
            if (self == null)
                return null;
            return self.InternalGetInterface();
        }
    }
}
