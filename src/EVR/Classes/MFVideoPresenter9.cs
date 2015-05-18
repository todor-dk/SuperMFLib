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

using MediaFoundation;
using MediaFoundation.Misc;
using MediaFoundation.Transform;
using System.Drawing;

namespace MediaFoundation.EVR.Classes
{
#if NOT_IN_USE

    /// <summary>
    /// Represents the default video presenter for the enhanced video renderer (EVR). 
    /// The CLSID is <c>CLSID_MFVideoPresenter9</c>.
    /// </summary>
    [UnmanagedName("CLSID_MFVideoPresenter9"),
    ComImport,
    Guid("98455561-5136-4d28-AB08-4CEE40EA2781")]
    internal class  MFVideoPresenter9
    {
    }

#endif
}
