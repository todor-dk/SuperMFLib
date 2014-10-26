#region license

/*
MediaFoundationLib - Provide access to MediaFoundation interfaces via .NET
Copyright (C) 2007
http://mfnet.sourceforge.net

This library is free software; you can redistribute it and/or
modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation; either
version 2.1 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public
License along with this library; if not, write to the Free Software
Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/

#endregion

using System;
using System.Collections;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

using MediaFoundation.Misc;
using MediaFoundation.Transform;

namespace MediaFoundation.Misc
{
    /// <summary>
    /// The <c>MfFloat</c> class wraps a <see cref="System.Single"/> value. 
    /// This is useful when an external API needs a pointer to a float value.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class MfFloat
    {
        /// <summary>
        /// Float value being wrapped.
        /// </summary>
        private float Value;

        /// <summary>
        /// Initializes a new instance of the <see cref="MfFloat"/> class.
        /// </summary>
        /// <param name="v">Initial value.</param>
        public MfFloat(float v)
        {
            Value = v;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return Value.ToString();
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        /// <summary>
        /// Returns the current float value being wrapped by the given instance.
        /// </summary>
        /// <param name="l"><c>MfFloat</c> instance to get the value of.</param>
        /// <returns>The current float value contained in the given instance.</returns>
        public static implicit operator float(MfFloat l)
        {
            return l.Value;
        }

        // While I *could* enable this code, it almost certainly won't do what you
        // think it will.  Generally you don't want to create a *new* instance of
        // MFInt and assign a value to it.  You want to assign a value to an
        // existing instance.  In order to do this automatically, .Net would have
        // to support overloading operator =.  But since it doesn't, use Assign()

        //public static implicit operator MfFloat(float l)
        //{
        //    return new MfFloat(l);
        //}
    }

}
