using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus
{
    public class LocalCollection<T, TBase> : Collection<TBase>, IEnumerable<T> where T : TBase
    {
        #region fields

        /// <summary>
        ///     The internal collection of objects.
        /// </summary>
        private List<T> _innerCollection;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the internal collection of objects.
        /// </summary>
        protected List<T> InnerCollection
        {
            get { return _innerCollection; }
        }

        /// <summary>
        ///     Gets the number of elements in the collection.
        /// </summary>
        public Int32 Count
        {
            get { return this.InnerCollection.Count; }
        }

        /// <summary>
        ///     Gets or sets the element that is located at the specified index within the collection.
        /// </summary>
        /// <param name="index">
        ///     The zero-based index which determines the element to be returned or replaced.
        /// </param>
        /// <returns>
        ///     The element at the specified index within the collection.
        /// </returns>
        public TBase this[Int32 index]
        {
            get
            {
                return this.InnerCollection[index];
            }
            set
            {
                if (value is T)
                    this.InnerCollection[index] = (T)value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Creates a new covariant collection.
        /// </summary>
        public LocalCollection()
        {
            _innerCollection = new List<T>();
        }

        /// <summary>
        ///     Creates a new covariant collection.
        /// </summary>
        public LocalCollection(IEnumerable<T> enumerable)
        {
            _innerCollection = enumerable.ToList();
        }

        #endregion

        #region methods

        /// <summary>
        ///     Adds an element to end of the collection.
        /// </summary>
        /// <param name="element">
        ///     The element to be added to the collection.
        /// </param>
        public void Add(TBase element)
        {
            if (element is T)
                this.InnerCollection.Add((T)element);
        }

        /// <summary>
        ///     Determines whether the specified element is present within the collection.
        /// </summary>
        /// <param name="element">
        ///     The element to locate within the collection.
        /// </param>
        /// <returns>
        ///     True, if the element is present within the collection; otherwise, false.
        /// </returns>
        public Boolean Contains(TBase element)
        {
            return element is T && this.InnerCollection.Contains((T)element);
        }

        /// <summary>
        ///     Removes all instances of the specified element from the collection.
        /// </summary>
        /// <param name="element">
        ///     The element to be removed from the collection.
        /// </param>
        public void Remove(TBase element)
        {
            if (element is T)
                while (this.InnerCollection.Contains((T)element))
                    this.InnerCollection.Remove((T)element);
        }

        /// <summary>
        ///     Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        ///     A <see cref="IEnumerator{T}" /> that can be used to iterate through the collection.
        /// </returns>
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this.InnerCollection.GetEnumerator();
        }

        /// <summary>
        ///     Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        ///     A <see cref="IEnumerator" /> that can be used to iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.InnerCollection.OfType<TBase>().GetEnumerator();
        }

        /// <summary>
        ///     Adds an element to end of the collection.
        /// </summary>
        /// <param name="element">
        ///     The element to be added to the collection.
        /// </param>
        void Collection.Add(Object element)
        {
            if (element is T)
                this.Add((T)element);
        }

        /// <summary>
        ///     Removes all instances of the specified element from the collection.
        /// </summary>
        /// <param name="element">
        ///     The element to be removed from the collection.
        /// </param>
        void Collection.Remove(Object element)
        {
            if (element is T)
                this.Remove((T)element);
        }

        /// <summary>
        ///     Determines whether the specified element is present within the collection.
        /// </summary>
        /// <param name="element">
        ///     The element to locate within the collection.
        /// </param>
        /// <returns>
        ///     True, if the element is present within the collection; otherwise, false.
        /// </returns>
        Boolean Collection.Contains(Object element)
        {
            return element is T && this.Contains((T)element);
        }

        #endregion
    }
}
