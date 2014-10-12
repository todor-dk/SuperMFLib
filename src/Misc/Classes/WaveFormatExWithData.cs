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


    [StructLayout(LayoutKind.Sequential, Pack = 1), UnmanagedName("WAVEFORMATEX")]
    public class WaveFormatExWithData : WaveFormatEx
    {
        public byte[] byteData;

        public static bool operator ==(WaveFormatExWithData a, WaveFormatExWithData b)
        {
            bool bRet = ((WaveFormatEx)a) == ((WaveFormatEx)b);

            if (bRet)
            {
                if (b.byteData == null)
                {
                    bRet = a.byteData == null;
                }
                else
                {
                    if (b.byteData.Length == a.byteData.Length)
                    {
                        for (int x = 0; x < b.byteData.Length; x++)
                        {
                            if (b.byteData[x] != a.byteData[x])
                            {
                                bRet = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        bRet = false;
                    }
                }
            }

            return bRet;
        }

        public static bool operator !=(WaveFormatExWithData a, WaveFormatExWithData b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            return this == (obj as WaveFormatExWithData);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}
