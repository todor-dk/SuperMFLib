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

namespace MediaFoundation.EVR
{

    /// <summary>
    /// To get a pointer to <see cref="IMFVideoPresenter"/> interface that implements the EVT tearless presents, 
    /// instantiate this class. The CLSID is <c>CLSID_EVRTearlessWindowPresenter9</c>.
    /// </summary>
    /// <remarks>
    /// From: https://social.msdn.microsoft.com/Forums/windowsdesktop/en-US/fb03e918-4cf1-4220-8479-96a95108f0d7/cannot-get-the-iidimfvideopresenter-interface-from-tearless-window-presenter-evr?forum=mediafoundationdevelopment
    /// <para/>
    /// Contrary to what the poorly named CLSID would lead you to believe, CLSID_EVRTerarlessWindowPresenter9 is 
    /// not actually a full presenter object but a helper object that the full video presenter uses to render frames.  
    /// This helper object is used by the default video presenter.
    /// <para/>
    /// The EVR was designed to minimize video tearing, and is supposed to be significantly better than the VMR in this respect. 
    /// </remarks>
    [UnmanagedName("CLSID_EVRTearlessWindowPresenter9"),
    ComImport,
    Guid("a0a7a57b-59b2-4919-a694-add0a526c373")]
    public class EVRTearlessWindowPresenter9
    {
    }

}
