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
    /// This class contains predefined GUIDs that indicate a specific family of output connectors 
    /// that is represented by the output trust authority (OTA).
    /// </summary>
    /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
    public static class MFConnector
    {
        /// <summary>
        /// AGP bus. 
        /// <para/>
        /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFCONNECTOR_AGP = new Guid(0xac3aef60, 0xce43, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);
        /// <summary>
        /// Component video. 
        /// <para/>
        /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFCONNECTOR_COMPONENT = new Guid(0x57cd596b, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);
        /// <summary>
        /// Composite video. 
        /// <para/>
        /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFCONNECTOR_COMPOSITE = new Guid(0x57cd596a, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);
        /// <summary>
        /// Japanese D connector. (Connector conforming to the EIAJ RC-5237 standard.) 
        /// <para/>
        /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFCONNECTOR_D_JPN = new Guid(0x57cd5970, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);
        /// <summary>
        /// Embedded DisplayPort connector. 
        /// <para/>
        /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFCONNECTOR_DISPLAYPORT_EMBEDDED = new Guid(0x57cd5973, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);
        /// <summary>
        /// External DisplayPort connector. 
        /// <para/>
        /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFCONNECTOR_DISPLAYPORT_EXTERNAL = new Guid(0x57cd5972, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);
        /// <summary>
        /// Digital video interface (DVI) connector. 
        /// <para/>
        /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFCONNECTOR_DVI = new Guid(0x57cd596c, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);
        /// <summary>
        /// High-definition multimedia interface (HDMI) connector. 
        /// <para/>
        /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFCONNECTOR_HDMI = new Guid(0x57cd596d, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);
        /// <summary>
        /// Low voltage differential signaling (LVDS) connector.
        /// <para/>
        /// A connector using the LVDS interface to connect internally to a display device. 
        /// The connection between the graphics adapter and the display device is permanent 
        /// and not accessible to the user. Applications should not enable High-Bandwidth 
        /// Digital Content Protection (HDCP) for this connector.
        /// <para/>
        /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFCONNECTOR_LVDS = new Guid(0x57cd596e, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);
        /// <summary>
        /// PCI bus. 
        /// <para/>
        /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFCONNECTOR_PCI = new Guid(0xac3aef5d, 0xce43, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);
        /// <summary>
        /// PCI Express bus. 
        /// <para/>
        /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFCONNECTOR_PCI_Express = new Guid(0xac3aef5f, 0xce43, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);
        /// <summary>
        /// PCI-X bus. 
        /// <para/>
        /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFCONNECTOR_PCIX = new Guid(0xac3aef5e, 0xce43, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);
        /// <summary>
        /// Serial digital interface connector. 
        /// <para/>
        /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFCONNECTOR_SPDIF = new Guid(0xb94a712, 0xad3e, 0x4cee, 0x83, 0xce, 0xce, 0x32, 0xe3, 0xdb, 0x65, 0x22);
        /// <summary>
        /// S-Video connector. 
        /// <para/>
        /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFCONNECTOR_SVIDEO = new Guid(0x57cd5969, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);
        /// <summary>
        /// Embedded Unified Display Interface (UDI). 
        /// <para/>
        /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFCONNECTOR_UDI_EMBEDDED = new Guid(0x57cd5975, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        /// <summary>
        /// Miracast wireless connector. 
        /// <para/>
        /// Supported in Windows 8.1 and later.
        /// <para/>
        /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFCONNECTOR_MIRACAST = new Guid(0x57cd5977, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        /// <summary>
        /// External UDI. 
        /// <para/>
        /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFCONNECTOR_UDI_EXTERNAL = new Guid(0x57cd5974, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);
        /// <summary>
        /// Unknown connector type. See Remarks. 
        /// <para/>
        /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFCONNECTOR_UNKNOWN = new Guid(0xac3aef5c, 0xce43, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);
        /// <summary>
        /// VGA connector. 
        /// <para/>
        /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFCONNECTOR_VGA = new Guid(0x57cd5968, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);
    }

#endif

}
