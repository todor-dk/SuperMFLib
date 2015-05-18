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

namespace MediaFoundation.Misc.Classes
{

#if NOT_IN_USE
    /// <summary>
    /// MFGuid is a wrapper class around a System.Guid value type.
    /// </summary>
    /// <remarks>
    /// This class is necessary to enable null paramters passing.
    /// </remarks>
    [StructLayout(LayoutKind.Explicit)]
    internal class  MFGuid
    {
        [FieldOffset(0)]
        private Guid guid;

        /// <summary>
        /// A read-only instance of the <see cref="MFGuid"/> class whose contens are an empty Guid.
        /// </summary>
        public static readonly MFGuid Empty = Guid.Empty;

        /// <summary>
        /// Empty constructor. 
        /// Initialize it with System.Guid.Empty
        /// </summary>
        public MFGuid()
        {
            this.guid = Empty;
        }

        /// <summary>
        /// Constructor.
        /// Initialize this instance with a given System.Guid string representation.
        /// </summary>
        /// <param name="g">A valid System.Guid as string</param>
        public MFGuid(string g)
        {
            this.guid = new Guid(g);
        }

        /// <summary>
        /// Constructor.
        /// Initialize this instance with a given System.Guid.
        /// </summary>
        /// <param name="g">A System.Guid value type</param>
        public MFGuid(Guid g)
        {
            this.guid = g;
        }

        /// <summary>
        /// Get a string representation of this MFGuid Instance.
        /// </summary>
        /// <returns>A string representing this instance</returns>
        public override string ToString()
        {
            return this.guid.ToString();
        }

        /// <summary>
        /// Get a string representation of this MFGuid Instance with a specific format.
        /// </summary>
        /// <param name="format"><see cref="System.Guid.ToString()"/> for a description of the format parameter.</param>
        /// <returns>A string representing this instance according to the format parameter</returns>
        public string ToString(string format)
        {
            return this.guid.ToString(format);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            return this.guid.GetHashCode();
        }

        /// <summary>
        /// Define implicit cast between MFGuid and System.Guid for languages supporting this feature.
        /// VB.Net doesn't support implicit cast. <see cref="MFGuid.ToGuid"/> for similar functionality.
        /// <code>
        ///   // Define a new MFGuid instance
        ///   MFGuid mfG = new MFGuid("{33D57EBF-7C9D-435e-A15E-D300B52FBD91}");
        ///   // Do implicit cast between MFGuid and Guid
        ///   Guid g = mfG;
        ///
        ///   Console.WriteLine(g.ToString());
        /// </code>
        /// </summary>
        /// <param name="g">MFGuid to be cast</param>
        /// <returns>A casted System.Guid</returns>
        public static implicit operator Guid(MFGuid g)
        {
            return g.guid;
        }

        /// <summary>
        /// Define implicit cast between System.Guid and MFGuid for languages supporting this feature.
        /// VB.Net doesn't support implicit cast. <see cref="MFGuid.FromGuid"/> for similar functionality.
        /// <code>
        ///   // Define a new Guid instance
        ///   Guid g = new Guid("{B9364217-366E-45f8-AA2D-B0ED9E7D932D}");
        ///   // Do implicit cast between Guid and MFGuid
        ///   MFGuid mfG = g;
        ///
        ///   Console.WriteLine(mfG.ToString());
        /// </code>
        /// </summary>
        /// <param name="g">System.Guid to be cast</param>
        /// <returns>A casted MFGuid</returns>
        public static implicit operator MFGuid(Guid g)
        {
            return new MFGuid(g);
        }

        /// <summary>
        /// Get the System.Guid equivalent to this MFGuid instance.
        /// </summary>
        /// <returns>A System.Guid</returns>
        public Guid ToGuid()
        {
            return this.guid;
        }

        /// <summary>
        /// Get a new MFGuid instance for a given System.Guid
        /// </summary>
        /// <param name="g">The System.Guid to wrap into a MFGuid</param>
        /// <returns>A new instance of MFGuid</returns>
        public static MFGuid FromGuid(Guid g)
        {
            return new MFGuid(g);
        }
    }

#endif
}
