using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus
{
    public interface Collection<T> : Collection
    {
        /// <summary>
        ///     Gets or sets the element that is located at the specified index within the collection.
        /// </summary>
        /// <param name="index">
        ///     The zero-based index which determines the element to be returned or replaced.
        /// </param>
        /// <returns>
        ///     The element at the specified index within the collection.
        /// </returns>
        T this[Int32 index]
        {
            get;
            set;
        }

        /// <summary>
        ///     Adds an element to end of the collection.
        /// </summary>
        /// <param name="element">
        ///     The element to be added to the collection.
        /// </param>
        void Add(T element);

        /// <summary>
        ///     Determines whether the specified element is present within the collection.
        /// </summary>
        /// <param name="element">
        ///     The element to locate within the collection.
        /// </param>
        /// <returns>
        ///     True, if the element is present within the collection; otherwise, false.
        /// </returns>
        bool Contains(T element);

        /// <summary>
        ///     Removes all instances of the specified element from the collection.
        /// </summary>
        /// <param name="element">
        ///     The element to be removed from the collection.
        /// </param>
        void Remove(T element);
    }

    public interface Collection : IEnumerable
    {
        /// <summary>
        ///     Gets the number of elements in the collection.
        /// </summary>
        Int32 Count { get; }

        /// <summary>
        ///     Adds an element to end of the collection.
        /// </summary>
        /// <param name="element">
        ///     The element to be added to the collection.
        /// </param>
        void Add(Object element);

        /// <summary>
        ///     Determines whether the specified element is present within the collection.
        /// </summary>
        /// <param name="element">
        ///     The element to locate within the collection.
        /// </param>
        /// <returns>
        ///     True, if the element is present within the collection; otherwise, false.
        /// </returns>
        bool Contains(Object element);

        /// <summary>
        ///     Removes all instances of the specified element from the collection.
        /// </summary>
        /// <param name="element">
        ///     The element to be removed from the collection.
        /// </param>
        void Remove(Object element);
    }
}
