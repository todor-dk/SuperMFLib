using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace MediaFoundation.Internals
{
    internal static class Contract
    {
        /// <summary>
        /// Validate that the given value is not null.
        /// </summary>
        /// <typeparam name="TValue">Type of the value to be validated.</typeparam>
        /// <param name="value">Value to validate for null.</param>
        /// <param name="name">Name of the argument (value) being validated.</param>
        /// <exception cref="ArgumentNullException"> is thrown if the given value is null.</exception>
        // [MethodImpl(MethodImplOptions.AggressiveInlining)] ... avaialble in 4.5
        public static void RequiresNotNull<TValue>(TValue value, string name)
        {
#if DEBUG
            if (value == null)
                throw new ArgumentNullException(name);
#endif
        }
    }
}
