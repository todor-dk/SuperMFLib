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

namespace MediaFoundation.Misc
{


    abstract public class COMBase
    {
        public const int S_Ok = 0;
        public const int S_False = 1;

        public const int E_NotImplemented = unchecked((int)0x80004001);
        public const int E_NoInterface = unchecked((int)0x80004002);
        public const int E_Pointer = unchecked((int)0x80004003);
        public const int E_Abort = unchecked((int)0x80004004);
        public const int E_Fail = unchecked((int)0x80004005);
        public const int E_Unexpected = unchecked((int)0x8000FFFF);
        public const int E_OutOfMemory = unchecked((int)0x8007000E);
        public const int E_InvalidArgument = unchecked((int)0x80070057);
        public const int E_BufferTooSmall = unchecked((int)0x8007007a);

        public static bool Succeeded(int hr)
        {
            return hr >= 0;
        }

        public static bool Failed(int hr)
        {
            return hr < 0;
        }

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

        public static void TRACE(string s)
        {
            Debug.WriteLine(s);
        }
    }

}
