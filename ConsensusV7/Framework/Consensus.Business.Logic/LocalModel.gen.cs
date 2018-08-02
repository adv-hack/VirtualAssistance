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
    public abstract partial class LocalModel : IModel
    {
        #region fields

        /// <summary>
        ///     The <see cref="LocalProvider" /> which supports this model.
        /// </summary>
        private LocalProvider _provider;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the <see cref="LocalProvider" /> which supports this model.
        /// </summary>
        protected LocalProvider Provider
        {
            get { return _provider; }
            private set { _provider = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalModel(LocalProvider provider)
        {
            this.Provider = provider;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Stores the underlying data within the persistence mechanism.
        /// </summary>
        public abstract void Save();

        /// <summary>
        ///     Removes the underlying data from the persistence mechanism.
        /// </summary>
        public abstract void Delete();

        #endregion

        #region implementations

        /// <summary>
        ///     Gets whether the underlying data structure has been persisted within the the persistence mechanism.
        /// </summary>
        System.Boolean IModel.IsPersisted
        {
            get { return this.IsPersisted; }
        }

        /// <summary>
        ///     Gets whether the underlying data has been modified since instantiation.
        /// </summary>
        System.Boolean IModel.IsModified
        {
            get { return this.IsModified; }
        }

        /// <summary>
        ///     Stores the underlying data within the persistence mechanism.
        /// </summary>
        void IModel.Save()
        {
            this.Save();
        }

        /// <summary>
        ///     Removes the underlying data from the persistence mechanism.
        /// </summary>
        void IModel.Delete()
        {
            this.Delete();
        }

        #endregion
    }
}
