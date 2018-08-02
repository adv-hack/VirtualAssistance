using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Consensus
{
    /// <summary>
    ///     Represents a collection of locally-executed factory instances which instantiate business models.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public abstract partial class LocalFactoryCollection : IFactoryCollection
    {
        #region fields

        /// <summary>
        ///     The <see cref="LocalProvider" /> instance which exposes this factory collection.
        /// </summary>
        private LocalProvider _provider;

        #endregion

        #region properties

        /// <summary>
        ///     Gets <see cref="LocalProvider" /> instance which exposes this factory collection.
        /// </summary>
        protected LocalProvider Provider
        {
            get { return _provider; }
            private set { _provider = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <typeparamref name="TFactoryCollection" /> instance and stores the instance within the specified <paramref name="reference" />, unless the reference has already been initialised with a <typeparamref name="TFactoryCollection" /> instance.
        /// </summary>
        /// <typeparam name="TFactoryCollection">
        ///     The type of factory collection to be checked and if required, instantiated and initialised.
        /// </typeparam>
        /// <param name="provider">
        ///     The business logic provider which programmatically exposes the factory collection.
        /// </param>
        /// <param name="reference">
        ///     The reference to the field which persists the instance of the factory collection within memory.
        /// </param>
        /// <returns>
        ///     The newly initialised instance, or the pre-existing instance, of the <typeparamref name="TFactoryCollection" /> class.
        /// </returns>
        /// <remarks>
        ///     The use of an internal static instantiation method, combined with a protected constructor, allows common initialisation code to be centralised
        ///     within an abstract class without creating a requirement for constructor implementation within the derived classes.
        /// </remarks>
        internal static TFactoryCollection Create<TFactoryCollection>(LocalProvider provider, ref TFactoryCollection reference) where TFactoryCollection : LocalFactoryCollection, new()
        {
            if (reference == null)
                reference = new TFactoryCollection() { Provider = provider };
            
            return reference;
        }

        #endregion
    }
}
