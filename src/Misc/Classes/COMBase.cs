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
using System.Runtime.CompilerServices;

namespace MediaFoundation.Misc
{

    /// <summary>
    /// This base class contains common functionality often used with COM.
    /// </summary>
    abstract public class COMBase
    {
        /// <summary>
        /// HRESULT status code: Operation successful.
        /// </summary>
        public const int S_Ok = 0;
        /// <summary>
        /// HRESULT status code: Operation successful, but with some possible warning.
        /// </summary>
        public const int S_False = 1;

        /// <summary>
        /// HRESULT status code: Not implemented.
        /// </summary>
        public const int E_NotImplemented = unchecked((int)0x80004001);
        /// <summary>
        /// HRESULT status code: No such interface supported.
        /// </summary>
        public const int E_NoInterface = unchecked((int)0x80004002);
        /// <summary>
        /// HRESULT status code: Pointer that is not valid.
        /// </summary>
        public const int E_Pointer = unchecked((int)0x80004003);
        /// <summary>
        /// HRESULT status code: Operation aborted.
        /// </summary>
        public const int E_Abort = unchecked((int)0x80004004);
        /// <summary>
        /// HRESULT status code: Unspecified failure.
        /// </summary>
        public const int E_Fail = unchecked((int)0x80004005);
        /// <summary>
        /// HRESULT status code: Unexpected failure.
        /// </summary>
        public const int E_Unexpected = unchecked((int)0x8000FFFF);
        /// <summary>
        /// HRESULT status code: Failed to allocate necessary memory.
        /// </summary>
        public const int E_OutOfMemory = unchecked((int)0x8007000E);
        /// <summary>
        /// HRESULT status code: One or more arguments are not valid.
        /// </summary>
        public const int E_InvalidArgument = unchecked((int)0x80070057);
        /// <summary>
        /// HRESULT status code: Indicates that one of the given parameters 
        /// does not specify a buffer large enough to store the property value. 
        /// </summary>
        public const int E_BufferTooSmall = unchecked((int)0x8007007a);

        /// <summary>
        /// Provides a generic test for success on any HRESULT status code.
        /// </summary>
        /// <param name="hr">
        /// The status code. This value can be an HRESULT or an SCODE. A non-negative number indicates success. 
        /// </param>
        /// <returns>
        /// TRUE if <paramref name="hr"/> represents a success status value; otherwise, FALSE.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Succeeded(int hr)
        {
            return hr >= 0;
        }

        /// <summary>
        /// Provides a generic test for failure on any HRESULT status code.
        /// </summary>
        /// <param name="hr">
        /// The status code. This value can be an HRESULT or an SCODE. A negative number indicates failure.
        /// </param>
        /// <returns>
        /// TRUE if <paramref name="hr"/> represents a failed status value; otherwise, FALSE. 
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Failed(int hr)
        {
            return hr < 0;
        }

        /// <summary>
        /// This function releases the give COM object or IDisposable object.
        /// </summary>
        /// <param name="o">Object to release.</param>
        public static void SafeRelease(object o)
        {
            if (o != null)
            {
                if (Marshal.IsComObject(o))
                {
                    int i = Marshal.ReleaseComObject(o);
                    Debug.Assert(i >= 0);
                }
                else
                {
                    IDisposable iDis = o as IDisposable;
                    if (iDis != null)
                    {
                        iDis.Dispose();
                    }
                    else
                    {
                        throw new Exception("What the heck was that?");
                    }
                }
            }
        }

        /// <summary>
        /// Traces information to the debugger.
        /// </summary>
        /// <param name="s">String to trace.</param>
        public static void TRACE(string s)
        {
            Debug.WriteLine(s);
        }
    }

}
