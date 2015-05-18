using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MediaFoundation.Internals
{
    internal static class Extensions
    {
        public static TInterface GetInterface<TInterface>(this COM<TInterface> self)
            where TInterface : class
        {
            if (self == null)
                return null;
            return self.Interface;
        }

        public static object GetInterface(this COM self)
        {
            if (self == null)
                return null;
            return self.Interface;
        }

        public static TInterface GetUniqueReferenceAndRelease<TInterface>(this object self)
            where TInterface : class
        {
            if (self == null)
                return null;
            if (!Marshal.IsComObject(self))
                return (TInterface)self;

            try
            {
                IntPtr pUnk = Marshal.GetIUnknownForObject(self);
                try
                {
                    object unique = Marshal.GetUniqueObjectForIUnknown(pUnk);
                    try
                    {
                        TInterface result = (TInterface)unique;
                        if (Object.ReferenceEquals(result, unique))
                            unique = null;
                        return result;
                    }
                    finally
                    {
                        if (unique != null)
                            Marshal.ReleaseComObject(unique);
                    }
                }
                finally
                {
                    Marshal.Release(pUnk);
                }
            }
            finally
            {
                Marshal.ReleaseComObject(self);
            }
        }

        public static TInterface GetUniqueReference<TInterface>(this object self)
            where TInterface : class
        {
            if (self == null)
                return null;
            if (!Marshal.IsComObject(self))
                return (TInterface)self;
            IntPtr pUnk = Marshal.GetIUnknownForObject(self);
            try
            {
                object unique = Marshal.GetUniqueObjectForIUnknown(pUnk);
                try
                {
                    TInterface result = (TInterface)unique;
                    if (Object.ReferenceEquals(result, unique))
                        unique = null;
                    return result;
                }
                finally
                {
                    if (unique != null)
                        Marshal.ReleaseComObject(unique);
                }
            }
            finally
            {
                Marshal.Release(pUnk);
            }
        }

        public static TInterface GetUniqueReference<TInterface>(this COM self)
            where TInterface : class
        {
            if (self == null)
                return null;
            return self.Interface.GetUniqueReference<TInterface>();
        }

        public static TInterface GetUniqueReferenceOrNull<TInterface>(this object self)
            where TInterface : class
        {
            if (self == null)
                return null;
            if (!Marshal.IsComObject(self))
                return self as TInterface;
            IntPtr pUnk = Marshal.GetIUnknownForObject(self);
            try
            {
                object unique = Marshal.GetUniqueObjectForIUnknown(pUnk);
                try
                {
                    TInterface result = unique as TInterface;
                    if (Object.ReferenceEquals(result, unique))
                        unique = null;
                    return result;
                }
                finally
                {
                    if (unique != null)
                        Marshal.ReleaseComObject(unique);
                }
            }
            finally
            {
                Marshal.Release(pUnk);
            }
        }

        public static TInterface GetUniqueReferenceOrNull<TInterface>(this COM self)
            where TInterface : class
        {
            if (self == null)
                return null;
            return self.Interface.GetUniqueReferenceOrNull<TInterface>();
        }
    }
}
