using MediaFoundation.Core;
using MediaFoundation.Internals;
using MediaFoundation.Misc;
using MediaFoundation.Misc.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace MediaFoundation
{
    /// <summary>
    /// This class contains common functionality often used with COM interop.
    /// </summary>
    public abstract class COM : IDisposable
    {
        /// <summary>
        /// If <paramref name="hr"/> has a "failed" status code (E_*), throw an exception.  
        /// Note that status messages (S_*) are not considered failure codes.  If MediaFoundation error text
        /// is available, it is used to build the exception, otherwise a generic com error is thrown.
        /// </summary>
        /// <param name="hr">The HRESULT to check.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfFailed(int hr)
        {
            MFError.ThrowExceptionForHR(hr);
        }

        /// <summary>
        /// If <paramref name="hr"/> has a "failed" status code (E_*), throw an exception.  
        /// Note that status messages (S_*) are not considered failure codes.  If MediaFoundation error text
        /// is available, it is used to build the exception, otherwise a generic com error is thrown.
        /// </summary>
        /// <param name="message">The message that indicates the reason the exception occurred.</param>
        /// <param name="hr">The HRESULT to check.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfFailed(string message, int hr)
        {
            if (hr < 0)
                throw new COMException(message, hr);
        }

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
            return (hr >= 0);
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
            return (hr < 0);
        }

        /// <summary>
        /// This function releases the give COM object or IDisposable object.
        /// </summary>
        /// <param name="value">Object to release.</param>
        public static void SafeRelease(object value)
        {
            COM.VerifyAccess();
            if (value == null)
                return;

            if (Marshal.IsComObject(value))
            {
                int i = Marshal.ReleaseComObject(value);
                Debug.Assert(i >= 0);
                return;
            }

            IDisposable disposable = value as IDisposable;
            if (disposable != null)
            {
                disposable.Dispose();
                return;
            }
#if DEBUG
            throw new Exception("What the heck was that?");
#endif
        }

        /// <summary>
        /// This function releases the given object and sets the reference to the given object variable to <c>null</c>.
        /// </summary>
        /// <typeparam name="TItem">The type of the object to be released.</typeparam>
        /// <param name="obj">The object to be released.</param>
        /// <exception cref="System.ArgumentException">Object must be either COM object or IDisposable.</exception>
        public static void SafeRelease<TItem>(ref TItem obj)
            where TItem : class
        {
            if (obj == null)
                return;
            COM.SafeRelease(obj);
            obj = null; // NULL the reference, so the use no longer can use it.
        }

        /// <summary>
        /// Determines if the given HRESULT is <see cref="S_OK"/>.
        /// </summary>
        /// <param name="hr">The HRESULT to check.</param>
        /// <returns>True if <paramref name="hr"/> is <see cref="S_OK"/>, otherwise false.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOK(int hr)
        {
            return (hr == COM.S_OK);
        }

        /// <summary>
        /// Throw an exception if <paramref name="hr"/> is not <see cref="S_OK"/>.
        /// </summary>
        /// <param name="hr">The HRESULT to check for <see cref="S_OK"/>.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public static void ThrowIfNotOK(int hr)
        {
            if (hr != COM.S_OK)
                throw new COMException(MFError.GetErrorText(hr), hr);
        }

        /// <summary>
        /// Throw an exception if <paramref name="hr"/> is not <see cref="S_OK"/>.
        /// </summary>
        /// <param name="hr">The HRESULT to check for <see cref="S_OK"/>.</param>
        /// <param name="value">A pointer to IUnknown to dispose if the <paramref name="hr"/> is not <see cref="S_OK"/>.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfNotOKAndReleaseInterface(int hr, ref IntPtr unknown)
        {
            if (hr != COM.S_OK)
            {
                if (unknown != IntPtr.Zero)
                {
                    Marshal.Release(unknown);
                    unknown = IntPtr.Zero;
                }
                throw new COMException(MFError.GetErrorText(hr), hr);
            }
        }

        /// <summary>
        /// Throw an exception if <paramref name="hr"/> is not <see cref="S_OK"/>.
        /// </summary>
        /// <param name="hr">The HRESULT to check for <see cref="S_OK"/>.</param>
        /// <param name="value">A <see cref="PropVariant"/> to dispose if the <paramref name="hr"/> is not <see cref="S_OK"/>.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfNotOKAndDisposePropVariant(int hr, PropVariant value)
        {
            if (hr != COM.S_OK)
            {
                if (value != null)
                    value.Dispose();
                throw new COMException(MFError.GetErrorText(hr), hr);
            }
        }

        /// <summary>
        /// Throw an exception if <paramref name="hr"/> is not <see cref="S_OK"/>.
        /// </summary>
        /// <param name="message">The message that indicates the reason the exception occurred.</param>
        /// <param name="hr">The HRESULT to check for <see cref="S_OK"/>.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfNotOK(string message, int hr)
        {
            if (hr != COM.S_OK)
                throw new COMException(message, hr);
        }

        /// <summary>
        /// Determines if the given HRESULT is <see cref="S_FALSE"/>.
        /// </summary>
        /// <param name="hr">The HRESULT to check.</param>
        /// <returns>True if <paramref name="hr"/> is <see cref="S_FALSE"/>, otherwise false.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFalse(int hr)
        {
            return (hr == COM.S_FALSE);
        }

        #region Constants

        /// <summary>
        /// HRESULT status code: Operation successful.
        /// </summary>
        public const int S_OK = 0;
        /// <summary>
        /// HRESULT status code: Operation successful, but with some possible warning.
        /// </summary>
        public const int S_FALSE = 1;

        /// <summary>
        /// A boolean constant representing the value <c>true</c>.
        /// </summary>
        public const int TRUE = 1;

        /// <summary>
        /// A boolean constant representing the value <c>false</c>.
        /// </summary>
        public const int FALSE = 0;

        internal static readonly Guid IID_IUnknown = new Guid("{00000000-0000-0000-C000-000000000046}");

        /// <summary>
        /// HRESULT status code: Not implemented.
        /// </summary>
        internal const int E_NotImplemented = unchecked((int)0x80004001);
        /// <summary>
        /// HRESULT status code: No such interface supported.
        /// </summary>
        internal const int E_NoInterface = unchecked((int)0x80004002);
        /// <summary>
        /// HRESULT status code: Pointer that is not valid.
        /// </summary>
        internal const int E_Pointer = unchecked((int)0x80004003);
        /// <summary>
        /// HRESULT status code: Operation aborted.
        /// </summary>
        internal const int E_Abort = unchecked((int)0x80004004);
        /// <summary>
        /// HRESULT status code: Unspecified failure.
        /// </summary>
        internal const int E_Fail = unchecked((int)0x80004005);
        /// <summary>
        /// HRESULT status code: Unexpected failure.
        /// </summary>
        internal const int E_Unexpected = unchecked((int)0x8000FFFF);
        /// <summary>
        /// HRESULT status code: Failed to allocate necessary memory.
        /// </summary>
        internal const int E_OutOfMemory = unchecked((int)0x8007000E);
        /// <summary>
        /// HRESULT status code: One or more arguments are not valid.
        /// </summary>
        internal const int E_InvalidArgument = unchecked((int)0x80070057);
        /// <summary>
        /// HRESULT status code: Indicates that one of the given parameters 
        /// does not specify a buffer large enough to store the property value. 
        /// </summary>
        internal const int E_BufferTooSmall = unchecked((int)0x8007007a);

        #endregion

        /// <summary>
        /// Returns the COM interface.
        /// </summary>
        /// <remarks>
        /// The returned <strong>RCW</strong> object is a unique
        /// wrapper instance around the COM interface. It should
        /// be releaseed with <see cref="Marshal.ReleaseComObject"/>
        /// when no longer needed.
        /// </remarks>
        public object GetInterface()
        {
            return this.AccessInterfacePointer(punk =>
            {
                if (punk == IntPtr.Zero)
                    return null;
                return Marshal.GetUniqueObjectForIUnknown(punk);
            });
        }

        /// <summary>
        /// Returns the COM interface converted to the given type.
        /// </summary>
        /// <remarks>
        /// The returned <strong>RCW</strong> object is a unique
        /// wrapper instance around the COM interface. It should
        /// be releaseed with <see cref="Marshal.ReleaseComObject"/>
        /// when no longer needed.
        /// </remarks>
        public TInterface GetInterface<TInterface>()
            where TInterface : class
        {
            object value = this.GetInterface();
            if (value == null)
                return null;
            TInterface converted = (TInterface)value;
            if (!Object.ReferenceEquals(converted, value))
                COM.SafeRelease(value);
            return converted;
        }

        /// <summary>
        /// Accesses the COM interface pointer.
        /// </summary>
        /// <param name="action">Action to be performed with the IUnknown pointer.</param>
        /// <returns>The result from executing the <paramref name="action"/>.</returns>
        protected abstract TResult AccessInterfacePointer<TResult>(Func<IntPtr, TResult> action);

        /// <summary>
        /// Delegate for creating COM objects from IUnknown pointers.
        /// </summary>
        /// <typeparam name="TItem">Type of the COM object.</typeparam>
        /// <param name="unknown">
        /// Pointer to the COM object's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be concidered void.
        /// </param>
        /// <returns>
        /// A new instance of <typeparam name="TObject"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public delegate TObject ComFactory<TObject>(ref IntPtr unknown);

        /// <summary>
        /// Converts this object to a COM object of type <typeparamref name="TObject"/>.
        /// </summary>
        /// <typeparam name="TObject">Type of the required COM object.</typeparam>
        /// <param name="factory">Delegate for creating COM objects from IUnknown pointers.</param>
        /// <returns>A COM object of type <typeparamref name="TObject"/>.</returns>
        public TObject GetComObject<TObject>(ComFactory<TObject> factory)
            where TObject : class
        {
            return this.AccessInterfacePointer(unknown =>
            {
                if (unknown == IntPtr.Zero)
                    return null;
                IntPtr copy = unknown;
                Marshal.AddRef(copy);
                try
                {
                    return factory(ref copy);
                }
                finally
                {
                    if (copy != IntPtr.Zero)
                        Marshal.Release(copy);
                }
            });
        }

        /// <summary>
        /// Converts this object to a COM object of type <typeparamref name="TObject"/> 
        /// or null if the requested 
        /// </summary>
        /// <typeparam name="TObject">Type of the required COM object.</typeparam>
        /// <param name="factory">Delegate for creating COM objects from IUnknown pointers.</param>
        /// <param name="iid">Id of the COM interface to query.</param>
        /// <returns>A COM object of type <typeparamref name="TObject"/>.</returns>
        public TObject GetComObjectOrNull<TObject>(ComFactory<TObject> factory)
            where TObject : COM
        {
            Contract.RequiresNotNull(factory, "factory");

            return this.AccessInterfacePointer(unknown =>
            {
                if (unknown == IntPtr.Zero)
                    return null;

                Guid iid = COM.GetIID<TObject>();
                IntPtr ppv = IntPtr.Zero;
                int hr = Marshal.QueryInterface(unknown, ref iid, out ppv);
                if (hr == COM.E_NoInterface)
                {
                    if (ppv != IntPtr.Zero)
                        Marshal.Release(ppv);
                    return null;
                }

                try
                {
                    return factory(ref ppv);
                }
                finally
                {
                    if (ppv != IntPtr.Zero)
                        Marshal.Release(ppv);
                }
            });
        }

        protected static Guid GetIID<TComWrapper>()
            where TComWrapper : COM
        {
            // Ugly hack to get the interface id.
            Type type = typeof(TComWrapper);
            while (type != null)
            {
                if (type.IsGenericType)
                {
                    Type genericType = type.GetGenericTypeDefinition();
                    if (genericType == typeof(COM<>))
                    {
                        Type interfaceType = type.GenericTypeArguments[0];
                        if (interfaceType.IsInterface)
                            return interfaceType.GUID;
                        return COM.IID_IUnknown;
                    }
                }
                type = type.BaseType;
            }
            throw new ArgumentException("TObject must be generic type deriving from COM<>.");
        }

        internal abstract object InternalGetInterface();

        #region IDisposable Interface

        /// <summary>
        /// Releases the COM interface.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
        }


        /// <summary>
        /// Dispose resources.
        /// </summary>
        /// <param name="disposing">True if disposing, false if due to GC.</param>
        protected virtual void Dispose(bool disposing)
        {
            COM.VerifyAccess();
        }

        #endregion

        #region COM Apartment Conformance

        private static volatile bool _EnforceMtaThreadUsage;

        /// <summary>
        /// When this property is set to true, the library will
        /// try to validate that callas to COM methods are only performed
        /// on an MTA thread.
        /// </summary>
        public static bool EnforceMtaThreadUsage
        {
            get { return COM._EnforceMtaThreadUsage; }
            set { COM._EnforceMtaThreadUsage = value; }
        }

        /// <summary>
        /// Verifies that the calling thread has access to the library.
        /// If <see cref="EnforceMtaThreadUsage"/> is set to true, only
        /// MTA threads may call functions on COM objects in the library.
        /// </summary>
        public static void VerifyAccess()
        {
#if DEBUG
            if (!COM._EnforceMtaThreadUsage)
                return;
            Thread thread = Thread.CurrentThread;
            if (thread.GetApartmentState() != ApartmentState.MTA)
                throw new InvalidOperationException("Calling thread must be an MTA thread.");
#endif
        }

        #endregion
       
    }


    /// <summary>
    /// Base class for implementing objects that reference a COM interface.
    /// This class adds <see cref="IDisposable"/> support to make it compatible
    /// with the <strong>using</strong> statement.
    /// </summary>
    /// <typeparam name="TInterface">Type of the COM interface.</typeparam>
    public abstract class COM<TInterface> : COM
        where TInterface : class
    {
        private IntPtr Identifier;
        private TInterface _Interface;
        private bool Released;

        /// <summary>
        /// Initializes a new instance of the <see cref="COM{TInterface}"/> class.
        /// </summary>
        /// <param name="unknown">Pointer to the COM object's IUnknown interface.</param>
        protected COM(IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                throw new ArgumentNullException("unknown");
            COM.VerifyAccess();

            Guid iid = COM.IID_IUnknown;
            IntPtr ppv = IntPtr.Zero;
            int hr = Marshal.QueryInterface(unknown,ref iid, out ppv);
            COM.ThrowIfFailed(hr);
            if (ppv == IntPtr.Zero)
                throw new InvalidComObjectException();
            this.Identifier = ppv;
            Marshal.Release(ppv);

            object comObject = Marshal.GetUniqueObjectForIUnknown(unknown);
            if (comObject == null)
                throw new InvalidComObjectException();
            Marshal.Release(unknown);

            this._Interface = (TInterface) comObject;
            this.Released = false;
            if (!Object.ReferenceEquals(comObject, this._Interface))
                Marshal.ReleaseComObject(comObject);
        }

        /// <summary>
        /// Returns the COM interface.
        /// </summary>
        protected internal TInterface Interface
        {
            get
            {
                COM.VerifyAccess();
                if (this.Released)
                    throw new ObjectDisposedException(this.GetType().Name);
                return this._Interface;
            }
        }

        /// <summary>
        /// Accesses the interface pointer.
        /// </summary>
        /// <typeparam name="TResult">The type of the t result.</typeparam>
        /// <param name="action">Action to be performed with the IUnknown pointer.</param>
        /// <returns>TResult.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        protected override TResult AccessInterfacePointer<TResult>(Func<IntPtr, TResult> action)
        {
            Contract.RequiresNotNull(action, "action");

            TInterface comInterface = Volatile.Read(ref this._Interface);
            if (comInterface != null)
            {
                // This is to prevent race condition with the Dispose() method
                lock(comInterface)
                {
                    // Check once more ... could be that the interface was released before acquiring the lock
                    if (Volatile.Read(ref this._Interface) != null)
                    {
                        return action(this.Identifier);
                    }
                }
            }

            // The interface has been released. Use NULL pointer.
            return action(IntPtr.Zero);
        }

        internal override object InternalGetInterface()
        {
            return this.Interface;
        }

        /// <summary>
        /// Retrieves a service.
        /// </summary>
        /// <param name="guidService">
        /// The service identifier (SID) of the service. For a list of service identifiers, see 
        /// <c>Service Interfaces</c>. 
        /// </param>
        /// <returns>
        /// The requested service or null if the object does not support the service.
        /// The caller must release the instance.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4287DD1F-1718-4231-BC62-B58E0E61D688(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4287DD1F-1718-4231-BC62-B58E0E61D688(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public TService GetService<TService>(MFService guidService, COM.ComFactory<TService> factory)
            where TService : COM
        {
            Contract.RequiresNotNull(factory, "factory");

            Guid iid = COM.GetIID<TService>();
            IntPtr ppvObject = IntPtr.Zero;
            int hr = MFExtern.MFGetService(this.Interface, guidService, iid, out ppvObject);
            // MF_E_UNSUPPORTED_SERVICE: The object does not support the service.
            if ((hr == MFError.MF_E_UNSUPPORTED_SERVICE) || (hr == COM.E_NoInterface))
            {
                if (ppvObject != IntPtr.Zero)
                    Marshal.Release(ppvObject);
                return null;
            }
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppvObject);
            return factory(ref ppvObject);
        }

        #region IDisposable Interface

        /// <summary>
        /// Dispose resources.
        /// </summary>
        /// <param name="disposing">True if disposing, false if due to GC.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                TInterface comInterface = Volatile.Read(ref this._Interface);
                if (comInterface != null)
                {
                    // Lock it ... this is to ensure no access to the naked IUnknown pointer.
                    lock (comInterface)
                    {
                        COM.SafeRelease(comInterface);
                        // In here, another thread can access this._Interface, but 
                        // this thread will fail with "RCW disconnected" exception.
                        // What is important is that AccessInterfacePointer() will
                        // not be able to access the naked IUnknown pointer,
                        // because from now on, this pointer is invalid (and dangerous!).
                        Volatile.Write(ref this._Interface, null);
                    }
                }
            }
            this.Released = true;
            base.Dispose(disposing);
        }

        #endregion

        #region Equality Members

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            return this.Identifier.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified COM interface reference is equal to the current COM interface reference. 
        /// </summary>
        /// <param name="other">Another COM interface reference to compare to this COM interface reference.</param>
        /// <returns><c>true</c> if this COM interface reference equals the given COM interface reference, <c>false</c> otherwise.</returns>
        public bool Equals(COM<TInterface> other)
        {
            if (other == null)
                return false;
            if (Object.ReferenceEquals(this, other))
                return true;
            if (this.GetType() != other.GetType())
                return false;
            return this.Identifier == other.Identifier;
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">Another object to compare to.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            COM<TInterface> other = obj as COM<TInterface>;
            return this.Equals(other);
        }

        /// <summary>
        /// Compares whether the left COM interface reference operand is equal to the right COM interface reference operand. 
        /// </summary>
        /// <param name="left">The left COM interface reference operand.</param>
        /// <param name="right">The right COM interface reference operand.</param>
        /// <returns>The result of the equality operator.</returns>
        public static bool operator ==(COM<TInterface> left, COM<TInterface> right)
        {
            if (Object.ReferenceEquals(left, null) && Object.ReferenceEquals(right, null))
                return true;
            if (Object.ReferenceEquals(left, null) || Object.ReferenceEquals(right, null))
                return false;
            return left.Equals(right);
        }

        /// <summary>
        /// Compares whether the left COM interface reference operand is not equal to the right COM interface reference operand. 
        /// </summary>
        /// <param name="left">The left COM interface reference operand.</param>
        /// <param name="right">The right COM interface reference operand.</param>
        /// <returns>The result of the inequality operator.</returns>
        public static bool operator !=(COM<TInterface> left, COM<TInterface> right)
        {
            if (Object.ReferenceEquals(left, null) && Object.ReferenceEquals(right, null))
                return false;
            if (Object.ReferenceEquals(left, null) || Object.ReferenceEquals(right, null))
                return true;
            return !left.Equals(right);
        }

        #endregion		
    }
}

