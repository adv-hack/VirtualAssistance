using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus
{
    /// <summary>
    ///     Provides the abstraction for locally-executable business factories which support business model instantiation.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public abstract partial class LocalFactory : IFactory
    {
        #region fields

        /// <summary>
        ///     The <see cref="LocalProvider" /> which exposes thiis factory.
        /// </summary>
        private LocalProvider _provider;

        #endregion

        #region properties

        /// <summary>
        ///     Gets <see cref="LocalProvider" /> which exposes thiis factory.
        /// </summary>
        protected LocalProvider Provider
        {
            get { return _provider; }
            private set { _provider = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <typeparamref name="TFactory" /> instance and stores the instance within the specified <paramref name="reference" />, unless the reference has already been initialised with a <typeparamref name="TFactory" /> instance.
        /// </summary>
        /// <typeparam name="TFactory">
        ///     The type of factory to be checked and if required, instantiated and initialised.
        /// </typeparam>
        /// <param name="provider">
        ///     The business logic provider which programmatically exposes the factory.
        /// </param>
        /// <param name="reference">
        ///     The reference to the field which persists the instance of the factory within memory.
        /// </param>
        /// <returns>
        ///     The newly initialised instance, or the pre-existing instance, of the <typeparamref name="TFactory" /> class.
        /// </returns>
        /// <remarks>
        ///     The use of an internal static instantiation method, combined with a protected constructor, allows common initialisation code to be centralised
        ///     within an abstract class without creating a requirement for constructor implementation within the derived classes.
        /// </remarks>
        internal static TFactory Create<TFactory>(LocalProvider provider, ref TFactory reference) where TFactory : LocalFactory, new()
        {
            if (reference == null)
                reference = new TFactory() { Provider = provider };
            
            return reference;
        }

        #endregion
    }
}
