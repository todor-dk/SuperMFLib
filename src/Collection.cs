using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Core.Interfaces;
using System.Runtime.InteropServices;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="Collection{TItem}"/> class implements a wrapper around the
    /// <see cref="IMFCollection"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFCollection"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFCollection"/>:
    /// Represents a generic collection of <strong>IUnknown</strong> pointers.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/FEC6AA17-2770-4F53-B36D-B94236093D23(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FEC6AA17-2770-4F53-B36D-B94236093D23(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public class Collection<TItem> : COM<IMFCollection>, IEnumerable<TItem>
        where TItem : COM
    {
        private readonly COM.ComFactory<TItem> ItemFactory;

        #region Construction

        private Collection(IntPtr unknown, COM.ComFactory<TItem> itemFactory)
            : base(unknown)
        {
            Contract.RequiresNotNull(itemFactory, "itemFactory");

            this.ItemFactory = itemFactory;
        }

        /// <summary>
        /// Creates a new <see cref="Collection"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the Collection's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be concidered void.
        /// </param>
        /// <returns>
        /// A new <see cref="Collection"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static Collection<TItem> FromUnknown(ref IntPtr unknown, COM.ComFactory<TItem> itemFactory)
        {
            if (unknown == IntPtr.Zero)
                return null;
            Collection<TItem> result = new Collection<TItem>(unknown, itemFactory);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Returns the number of objects in the collection.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/4BD46F66-0542-4185-B50E-163CC3B4E2F8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4BD46F66-0542-4185-B50E-163CC3B4E2F8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int Count
        {
            get
            {
                int pcElements;
                int hr = this.Interface.GetElementCount(out pcElements);
                COM.ThrowIfNotOK(hr);
                return pcElements;
            }
        }

        /// <summary>
        /// Retrieves an object in the collection.
        /// </summary>
        /// <param name="index">
        /// Zero-based index of the object to retrieve. Objects are indexed in the order in which they were
        /// added to the collection.
        /// </param>
        /// <returns>
        /// The object at the given index. The caller must release the object. The returned value might be null.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/A45983A8-4061-40E1-A11A-67DE0867E553(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A45983A8-4061-40E1-A11A-67DE0867E553(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public TItem GetElement(int index)
        {
            IntPtr ppUnkElement;
            int hr = this.Interface.GetElement(index, out ppUnkElement);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppUnkElement);
            try
            {
                TItem item = this.ItemFactory(ref ppUnkElement);
                return item;
            }
            finally
            {
                if (ppUnkElement != IntPtr.Zero)
                    Marshal.Release(ppUnkElement);
            }
        }

        /// <summary>
        /// Adds an object to the collection.
        /// </summary>
        /// <param name="item">
        /// The element to add to the collection.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/1EF2463B-3D5E-4ED0-AB7C-68758E6CC056(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1EF2463B-3D5E-4ED0-AB7C-68758E6CC056(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void AddElement(TItem item)
        {
            object pUnkElement = item.GetInterface();
            int hr = this.Interface.AddElement(pUnkElement);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Removes an object from the collection.
        /// </summary>
        /// <param name="index">
        /// Zero-based index of the object to remove. Objects are indexed in the order in which they were added
        /// to the collection.
        /// </param>
        /// <returns>
        /// Returns the object that was removed. The caller must release the object.
        /// The returned value might be null.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/47F33235-6BB5-4103-82B4-87210B0E695C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/47F33235-6BB5-4103-82B4-87210B0E695C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public TItem RemoveElement(int index)
        {
            IntPtr ppUnkElement;
            int hr = this.Interface.RemoveElement(index, out ppUnkElement);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppUnkElement);
            try
            {
                TItem item = this.ItemFactory(ref ppUnkElement);
                return item;
            }
            finally
            {
                if (ppUnkElement != IntPtr.Zero)
                    Marshal.Release(ppUnkElement);
            }
        }

        /// <summary>
        /// Adds an object at the specified index in the collection.
        /// </summary>
        /// <param name="index">
        /// The zero-based index where the object will be added to the collection.
        /// </param>
        /// <param name="item">
        /// The object to insert.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/D8F64BF8-EB5B-4673-91BE-796F4EA8DCE0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D8F64BF8-EB5B-4673-91BE-796F4EA8DCE0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void InsertElementAt(int index, TItem item)
        {
            object pUnkElement = item.GetInterface();
            int hr = this.Interface.InsertElementAt(index, pUnkElement);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Removes all items from the collection.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/8C82D287-B73E-46DD-A319-70C5D0F536C6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8C82D287-B73E-46DD-A319-70C5D0F536C6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void RemoveAllElements()
        {
            int hr = this.Interface.RemoveAllElements();
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An IEnumerator that can be used to iterate through the collection.</returns>
        public IEnumerator<TItem> GetEnumerator()
        {
            return new Enumerator(this);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class Enumerator : IEnumerator<TItem>
        {
            private int NextIndex;

            private readonly Collection<TItem> Collection;

            public Enumerator(Collection<TItem> collection)
            {
                this.Collection = collection;
            }

            public TItem Current { get; private set; }

            public void Dispose()
            {
            }

            object System.Collections.IEnumerator.Current
            {
                get { return this.Current; }
            }

            public bool MoveNext()
            {
                if (this.Current != null)
                    this.Current.Dispose();
                if (this.NextIndex < this.Collection.Count)
                {
                    this.Current = this.Collection.GetElement(this.NextIndex);
                    this.NextIndex++;
                    return true;
                }
                else
                {
                    this.Current = default(TItem);
                    return false;
                }
            }

            public void Reset()
            {
                this.NextIndex = 0;
                if (this.Current != null)
                    this.Current.Dispose();
                this.Current = default(TItem);
            }
        }
    }

    ///// <summary>
    ///// The <see cref="Collection"/> class implements a wrapper around the
    ///// <see cref="IMFCollection"/> COM interface. This adds <see cref="IDisposable"/>
    ///// support to make it compatible with the <strong>using</strong> statement as well as
    ///// exposing <i>civilized</i> version of the <see cref="IMFCollection"/>
    ///// interface's methods.
    ///// <para/>
    ///// <see cref="IMFCollection"/>:
    ///// Represents a generic collection of <strong>IUnknown</strong> pointers.
    ///// </summary>
    ///// <remarks>
    ///// The above documentation is © Microsoft Corporation. It is reproduced here
    ///// with the sole purpose to increase usability and add IntelliSense support.
    ///// <para/>
    ///// View the original documentation topic online:
    ///// <a href="http://msdn.microsoft.com/en-US/library/FEC6AA17-2770-4F53-B36D-B94236093D23(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FEC6AA17-2770-4F53-B36D-B94236093D23(v=VS.85,d=hv.2).aspx</a>
    ///// </remarks>
    //public sealed class Collection : Collection<object>
    //{
    //    /// <summary>
    //    /// Initializes a new instance of the <see cref="Collection"/> class.
    //    /// </summary>
    //    /// <param name="comInterface">The COM interface.</param>
    //    internal Collection(IMFCollection comInterface)
    //        : base(comInterface, e => e, e => e)
    //    {
    //    }
    //}
}
