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
using System.Runtime.InteropServices;

namespace MediaFoundation.Misc.Classes
{
#if NOT_IN_USE

    /// <summary>
    /// Specifies the FMTID/PID identifier that programmatically identifies a property. Replaces 
    /// <c>SHCOLUMNID</c>. 
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct {
    ///   GUID  fmtid;
    ///   DWORD pid;
    /// } PROPERTYKEY;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/3F5F31AF-F040-443B-9045-9761055381EA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3F5F31AF-F040-443B-9045-9761055381EA(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 4), UnmanagedName("PROPERTYKEY")]
    public class  PropertyKey
    {
        /// <summary>
        /// A unique GUID for the property.
        /// </summary>
        public Guid fmtid;
        /// <summary>
        /// A property identifier (PID). This parameter is not used as in SHCOLUMNID. 
        /// It is recommended that you set this value to PID_FIRST_USABLE. 
        /// Any value greater than or equal to 2 is acceptable.
        /// <para/>
        /// Note  Values of 0 and 1 are reserved and should not be used.
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/77AF6EC6-442D-4A8A-BE42-A5EFB1F3F664(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/77AF6EC6-442D-4A8A-BE42-A5EFB1F3F664(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int pID;

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyKey"/> class.
        /// </summary>
        public PropertyKey()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyKey"/> class.
        /// </summary>
        /// <param name="f">A unique GUID for the property.</param>
        /// <param name="p">A property identifier (PID).</param>
        public PropertyKey(Guid f, int p)
        {
            fmtid = f;
            pID = p;
        }
    }

#endif
}
