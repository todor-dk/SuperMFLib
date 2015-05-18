using MediaFoundation.Misc;
using MediaFoundation.Misc.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
        // [MethodImpl(MethodImplOptions.AggressiveInlining)] ... avaialble in 4.5
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
        // [MethodImpl(MethodImplOptions.AggressiveInlining)] ... avaialble in 4.5
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
        // [MethodImpl(MethodImplOptions.AggressiveInlining)] ... avaialble in 4.5
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
        // [MethodImpl(MethodImplOptions.AggressiveInlining)] ... avaialble in 4.5
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
        // [MethodImpl(MethodImplOptions.AggressiveInlining)] ... avaialble in 4.5
        public static bool IsOK(int hr)
        {
            return (hr == COM.S_OK);
        }

        /// <summary>
        /// Throw an exception if <paramref name="hr"/> is not <see cref="S_OK"/>.
        /// </summary>
        /// <param name="hr">The HRESULT to check for <see cref="S_OK"/>.</param>
        // [MethodImpl(MethodImplOptions.AggressiveInlining)] ... avaialble in 4.5
        public static void ThrowIfNotOK(int hr)
        {
            if (hr != COM.S_OK)
                throw new COMException(MFError.GetErrorText(hr), hr);
        }

#if NOT_IN_USE

        /// <summary>
        /// Throw an exception if <paramref name="hr"/> is not <see cref="S_OK"/>.
        /// </summary>
        /// <param name="hr">The HRESULT to check for <see cref="S_OK"/>.</param>
        /// <param name="value">A <see cref="PropVariant"/> to dispose if the <paramref name="hr"/> is not <see cref="S_OK"/>.</param>
        // [MethodImpl(MethodImplOptions.AggressiveInlining)] ... avaialble in 4.5
        public static void ThrowIfNotOKAndDisposePropVariant(int hr, PropVariant value)
        {
            if (hr != COM.S_OK)
            {
                if (value != null)
                    value.Dispose();
                throw new COMException(Helpers.GetMessage(hr), hr);
            }
        }

#endif

        /// <summary>
        /// Throw an exception if <paramref name="hr"/> is not <see cref="S_OK"/>.
        /// </summary>
        /// <param name="message">The message that indicates the reason the exception occurred.</param>
        /// <param name="hr">The HRESULT to check for <see cref="S_OK"/>.</param>
        // [MethodImpl(MethodImplOptions.AggressiveInlining)] ... avaialble in 4.5
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
        // [MethodImpl(MethodImplOptions.AggressiveInlining)] ... avaialble in 4.5
        public static bool IsFalse(int hr)
        {
            return (hr == COM.S_FALSE);
        }

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

        /// <summary>
        /// Returns the COM interface.
        /// </summary>
        public object Interface
        {
            get { return this.InternalGetInterface(); }
        }

        /// <summary>
        /// Returns the COM interface.
        /// </summary>
        /// <returns>Returns the COM interface.</returns>
        protected abstract object InternalGetInterface();

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

#if NOT_IN_USE
    /// <summary>
    /// Base class for implementing objects that reference a COM interface.
    /// This class adds <see cref="IDisposable"/> support to make it compatible
    /// with the <strong>using</strong> statement.
    /// </summary>
    /// <typeparam name="TInterface">Type of the COM interface.</typeparam>
    public abstract class COM<TInterface> : COM
        where TInterface : class
    {
        private TInterface _Interface;
        private bool Released;

        /// <summary>
        /// Initializes a new instance of the <see cref="COM{TInterface}"/> class.
        /// </summary>
        /// <param name="comInterface">The COM interface.</param>
        protected COM(TInterface comInterface)
        {
            Contract.RequiresNotNull(comInterface, "comInterface");
            COM.VerifyAccess();

            this._Interface = comInterface;
            this.Released = false;
        }

        /// <summary>
        /// Returns the COM interface.
        /// </summary>
        public new TInterface Interface
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
        /// Returns the COM interface.
        /// </summary>
        /// <returns>Returns the COM interface.</returns>
        protected override sealed object InternalGetInterface()
        {
            return this.Interface;
        }

        public static TResult FromComInterface<TResult>(TInterface comInterface, Func<TInterface, TResult> factory)
            where TResult : COM<TInterface>
        {
            Contract.RequiresNotNull(factory, "factory");

            if (comInterface == null)
                return null;
            return factory(comInterface);
        }


        public static TResult FromComObject<TResult>(object comObject, Func<TInterface, TResult> factory)
            where TResult : COM<TInterface>
        {
            return COM<TInterface>.FromComObject(comObject, factory, true);
        }

        public static TResult FromComObject<TResult>(object comObject, Func<TInterface, TResult> factory, bool takeOwnership)
            where TResult : COM<TInterface>
        {
            Contract.RequiresNotNull(factory, "factory");

            if (comObject == null)
                return null;
            TInterface comInterface = (TInterface)comObject;
            if (takeOwnership && !Object.ReferenceEquals(comObject, comInterface))
                COM.SafeRelease(comObject);
            return factory(comInterface);
        }

        #region IDisposable Interface

        /// <summary>
        /// Dispose resources.
        /// </summary>
        /// <param name="disposing">True if disposing, false if due to GC.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                COM.SafeRelease(ref this._Interface);
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
            if (this._Interface == null)
                return 0;
            return this.Interface.GetHashCode();
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
            if (this._Interface == null)
                return false;
            if (other._Interface == null)
                return false;
            return (this._Interface == other._Interface);

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
#endif
}

