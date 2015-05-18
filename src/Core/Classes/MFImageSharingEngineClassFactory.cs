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
using System.Runtime.InteropServices.ComTypes;

using MediaFoundation.Misc;
using MediaFoundation;
using System.Drawing;

namespace MediaFoundation.Core.Classes
{
    #if NOT_IN_USE
    /// <summary>
    /// Class for creating the Image Sharing Engine.
    /// </summary>
    /// <seealso cref="IMFImageSharingEngineClassFactory"/>
    [UnmanagedName("CLSID_MFImageSharingEngineClassFactory"),
        ComImport, Guid("B22C3339-87F3-4059-A0C5-037AA9707EAF")]
    internal class  MFImageSharingEngineClassFactory
    {
    }
#endif
}
