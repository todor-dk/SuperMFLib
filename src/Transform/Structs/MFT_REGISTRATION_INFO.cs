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

using MediaFoundation.Misc;

namespace MediaFoundation.Transform.Structs
{

#if ALLOW_UNTESTED_INTERFACES



    /// <summary>
    /// Contains parameters for the  <see cref="Transform.IMFLocalMFTRegistration.RegisterMFTs" />  method.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _MFT_REGISTRATION_INFO {
    ///   CLSID                  clsid;
    ///   GUID                   guidCategory;
    ///   UINT32                 uiFlags;
    ///   LPCWSTR                pszName;
    ///   DWORD                  cInTypes;
    ///   MFT_REGISTER_TYPE_INFO *pInTypes;
    ///   DWORD                  cOutTypes;
    ///   MFT_REGISTER_TYPE_INFO *pOutTypes;
    /// } MFT_REGISTRATION_INFO;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/7D610EDF-89E3-4FF3-9AD8-B92EE50DF522(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7D610EDF-89E3-4FF3-9AD8-B92EE50DF522(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("MFT_REGISTRATION_INFO")]
    internal struct MFT_REGISTRATION_INFO
    {
        /// <summary>
        /// CLSID of the Media Foundation transform (MFT) to register.
        /// </summary>
        Guid clsid;
        /// <summary>
        /// GUID that specifies the category of the MFT. For a list of MFT categories, see
        /// <c>MFT_CATEGORY</c> .
        /// </summary>
        Guid guidCategory;
        /// <summary>
        /// Bitwise <strong>OR</strong> of zero or more flags from the  <c>_MFT_ENUM_FLAG</c>  enumeration.
        /// </summary>
        int uiFlags;
        /// <summary>
        /// Wide-character string that contains the friendly name of the MFT.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        string pszName;
        /// <summary>
        /// Number of elements in the <strong>pInTypes</strong> array.
        /// </summary>
        int cInTypes;
        /// <summary>
        /// Pointer to an array of  <see cref="Transform.MFTRegisterTypeInfo" />  structures. Each member of the
        /// array specifies an input format that the MFT supports. If this member is <strong>NULL</strong>, the
        /// <strong>cInTypes</strong> member must be zero.
        /// </summary>
        MFTRegisterTypeInfo[] pInTypes;
        /// <summary>
        /// Number of elements in the <strong>pOutTypes</strong> array.
        /// </summary>
        int cOutTypes;
        /// <summary>
        /// Pointer to an array of  <see cref="Transform.MFTRegisterTypeInfo" />  structures. Each member of the
        /// array defines an output format that the MFT supports. If this member is <strong>NULL</strong>, the
        /// <strong>cOutTypes</strong> member must be zero.
        /// </summary>
        MFTRegisterTypeInfo[] pOutTypes;
    }

#endif

}
