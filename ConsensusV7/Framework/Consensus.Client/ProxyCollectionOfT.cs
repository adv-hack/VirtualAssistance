using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus
{
    public class ProxyCollection<TProxy, TModel> : Collection<TProxy>
        where TProxy : Proxy<TModel>
        where TModel : IModel
    {
        #region fields

        /// <summary>
        ///     The internal collection of models.
        /// </summary>
        private Collection<TModel> _modelCollection;

        /// <summary>
        ///     The internal collection of proxy models.
        /// </summary>
        private List<TProxy> _internalCollection;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the internal collection of proxied models.
        /// </summary>
        protected Collection<TModel> ModelCollection
        {
            get { return _modelCollection; }
        }

        /// <summary>
        ///    Gets the internal collection of proxy models
        /// </summary>
        protected List<TProxy> InternalCollection
        {
            get { return _internalCollection; }
        }

        #endregion

        #region constructors

        public ProxyCollection(Collection<TModel> modelCollection, Func<TModel, TProxy> proxyConstructor)
        {
            _modelCollection = modelCollection;
            _internalCollection = modelCollection.OfType<TModel>().Select(model => proxyConstructor(model)).ToList();
        }

        #endregion

        #region methods

        public int Count
        {
            get { return this.ModelCollection.Count; }
        }

        public TProxy this[int index]
        {
            get
            {
                return this.InternalCollection[index];
            }
            set
            {
                this.InternalCollection[index] = value;
                this.ModelCollection[index] = value.Model;
            }
        }

        public void Add(TProxy element)
        {
            this.InternalCollection.Add(element);
            this.ModelCollection.Add(element.Model);
        }

        public bool Contains(TProxy element)
        {
            return this.InternalCollection.Contains(element);
        }

        public void Remove(TProxy element)
        {
            this.InternalCollection.Remove(element);
            this.ModelCollection.Remove(element.Model);
        }

        /// <summary>
        ///     Adds an element to end of the collection.
        /// </summary>
        /// <param name="element">
        ///     The element to be added to the collection.
        /// </param>
        void Collection.Add(Object element)
        {
            if (element is TProxy)
                this.Add((TProxy)element);
        }

        /// <summary>
        ///     Removes all instances of the specified element from the collection.
        /// </summary>
        /// <param name="element">
        ///     The element to be removed from the collection.
        /// </param>
        void Collection.Remove(Object element)
        {
            if (element is TProxy)
                this.Remove((TProxy)element);
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
            return element is TProxy && this.Contains((TProxy)element);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.InternalCollection.GetEnumerator();
        }

        #endregion
    }
}
