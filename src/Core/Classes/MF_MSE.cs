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
    /// Contains guids for media source extensions attributes.
    /// </summary>
    public static class MF_MSE
    {
        /// <summary>
        /// Contains a pointer to the application's callback interface for the <see cref="IMFMediaSourceExtensionNotify"/>.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IMFMediaSourceExtensionNotify*</strong> stored as <strong>IUnknown*</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302194(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302194(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MSE_CALLBACK = new Guid(0x9063a7c0, 0x42c5, 0x4ffd, 0xa8, 0xa8, 0x6f, 0xcf, 0x9e, 0xa3, 0xd0, 0x0c);

        /// <summary>
        /// Contains a pointer to the application's callback interface for the <see cref="IMFBufferListNotify"/> 
        /// interface for the active buffer list.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IMFBufferListNotify*</strong> stored as <strong>IUnknown*</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302192(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302192(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MSE_ACTIVELIST_CALLBACK = new Guid(0x949bda0f, 0x4549, 0x46d5, 0xad, 0x7f, 0xb8, 0x46, 0xe1, 0xab, 0x16, 0x52);

        /// <summary>
        /// Contains a pointer to the application's callback interface for the <see cref="IMFBufferListNotify"/>.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IMFBufferListNotify*</strong> stored as <strong>IUnknown*</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302193(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302193(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MSE_BUFFERLIST_CALLBACK = new Guid(0x42e669b0, 0xd60e, 0x4afb, 0xa8, 0x5b, 0xd8, 0xe5, 0xfe, 0x6b, 0xda, 0xb5);
    }
#endif
}
