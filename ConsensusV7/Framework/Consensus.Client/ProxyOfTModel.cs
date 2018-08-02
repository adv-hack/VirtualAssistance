using System;

namespace Consensus
{
    /// <summary>
    ///     Provides the abstraction for consumable client classes which provide composition of the business model and business factory instances.
    /// </summary>
    /// <typeparam name="TModel">
    ///     The type of business model which is encapsulated by this consumable client class.
    /// </typeparam>
    public abstract class Proxy<TModel> : Proxy where TModel : IModel
    {
        #region fields

        /// <summary>
        ///     The business model which is encapsulated by this consumable client class.
        /// </summary>
        private TModel _model;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the underlying business model which is encapsulated by this consumable client class.
        /// </summary>
        internal TModel Model
        {
            get { return _model; }
        }

        public override Boolean IsPersisted
        {
            get { return this.Model.IsPersisted; }
        }

        public override Boolean IsModified
        {
            get { return this.Model.IsModified; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        /// <param name="model">
        ///     Sets underlying business model which is encapsulated by this consumable client class.
        /// </param>
        protected Proxy(TModel model)
        {
            _model = model;
        }

        #endregion

        #region methods

        public override void Delete()
        {
            this.Model.Delete();
        }

        public override void Save()
        {
            this.Model.Save();
        }

        #endregion
    }
}
