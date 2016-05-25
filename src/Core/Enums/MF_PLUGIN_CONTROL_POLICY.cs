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
using System.Text;
using System.Runtime.InteropServices;

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation.Core.Enums
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Defines policy settings for the <see cref="IMFPluginControl2.SetPolicy"/> method. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/AEA55D69-B3F1-463E-9DEC-B6BF7B9859D6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AEA55D69-B3F1-463E-9DEC-B6BF7B9859D6(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_PLUGIN_CONTROL_POLICY")]
    internal enum MF_PLUGIN_CONTROL_POLICY
    {
        /// <summary>
        /// Enumerate all registered sources and transforms.
        /// </summary>
        UseAllPlugins = 0,
        /// <summary>
        /// Enumerate only approved sources and transforms. Third-party components are excluded unless the
        /// component is registered with a valid merit value, or the component was registered locally by the
        /// application.
        /// </summary>
        UseApprovedPlugins = 1,
        /// <summary>
        /// Restrict enumeration to components intended for use in a web browser. 
        /// </summary>
        UseWebPlugins = 2
    }

#endif

}
