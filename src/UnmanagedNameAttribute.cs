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

namespace MediaFoundation
{
    /// <summary>
    /// Attribute that is used to decorate the types in the Media Foundation Library
    /// to indicate which unmanaged type they represent.
    /// <para/>
    /// Example: <see cref="WaveFormatEx"/> represents the <c>WAVEFORMATEX</c> native structure.
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Class)]
    internal class UnmanagedNameAttribute : System.Attribute
    {
        private string Name;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnmanagedNameAttribute"/> class.
        /// </summary>
        /// <param name="s">The name of the unmanaged type.</param>
        public UnmanagedNameAttribute(string s)
        {
            this.Name = s;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return this.Name;
        }
    }
}
