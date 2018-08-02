using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Consensus
{
    /// <summary>
    ///     Provides the abstraction for the repository collections that expose the repositories in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public abstract partial class SqlServerRepositoryCollection : IRepositoryCollection
    {
        #region fields

        /// <summary>
        ///     The <see cref="SqlServerProvider" /> instance which exposes this repository.
        /// </summary>
        private SqlServerProvider _provider;

        #endregion

        #region properties

        /// <summary>
        ///     Gets <see cref="SqlServerProvider" /> instance which exposes this repository.
        /// </summary>
        protected SqlServerProvider Provider
        {
            get { return _provider; }
            private set { _provider = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <typeparamref name="TRepositoryCollection" /> instance and stores the instance within the specified <paramref name="reference" />, unless the reference has already been initialised with a <typeparamref name="TRepositoryCollection" /> instance.
        /// </summary>
        /// <typeparam name="TRepositoryCollection">
        ///     The type of repository collection to be checked and if required, instantiated and initialised.
        /// </typeparam>
        /// <param name="provider">
        ///     The data provider which programmatically exposes the repository collection.
        /// </param>
        /// <param name="reference">
        ///     The reference to the field which persists the instance of the repository collection within memory.
        /// </param>
        /// <returns>
        ///     The newly initialised instance, or the pre-existing instance, of the <typeparamref name="TRepositoryCollection" /> class.
        /// </returns>
        /// <remarks>
        ///     The use of an internal static instantiation method, combined with a protected constructor, allows common initialisation code to be centralised
        ///     within an abstract class without creating a requirement for constructor implementation within the derived classes.
        /// </remarks>
        internal static TRepositoryCollection Create<TRepositoryCollection>(SqlServerProvider provider, ref TRepositoryCollection reference) where TRepositoryCollection : SqlServerRepositoryCollection, new()
        {
            if (reference == null)
                reference = new TRepositoryCollection() { Provider = provider };
            
            return reference;
        }

        #endregion
    }
}
