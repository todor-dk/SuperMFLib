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

namespace MediaFoundation.Misc.Classes
{
#if NOT_IN_USE
    /// <summary>
    /// This base class contains common functionality often used with COM.
    /// </summary>
    abstract internal class  COMBase
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
        /// Provides a generic test for success on any HRESULT status code.
        /// </summary>
        /// <param name="hr">
        /// The status code. This value can be an HRESULT or an SCODE. A non-negative number indicates success. 
        /// </param>
        /// <returns>
        /// TRUE if <paramref name="hr"/> represents a success status value; otherwise, FALSE.
        /// </returns>
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
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

#endif
}
