using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopoViewer
{
    internal class Contract
    {
        public static void RequiresNotNull<TValue>(TValue value, string name)
        {
#if DEBUG
            if (value == null)
                throw new ArgumentNullException(name);
#endif
        }
    }
}
