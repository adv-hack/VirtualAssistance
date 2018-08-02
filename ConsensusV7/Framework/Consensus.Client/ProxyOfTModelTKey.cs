using System;

namespace Consensus
{
    /// <summary>
    ///     Provides the abstraction for consumable client classes which provide composition of the business model and business factory instances.
    /// </summary>
    /// <typeparam name="TModel">
    ///     The type of business model which is encapsulated by this consumable client class.
    /// </typeparam>
    /// <typeparam name="TKey">
    ///     The data type of the unique identifier which distinctly identifies an instance of the business model.
    /// </typeparam>
    public abstract class Proxy<TModel, TId> : Proxy<TModel> where TModel : IModel<TId> where TId: IEquatable<TId>, IComparable<TId>
    {
        #region properties

        /// <summary>
        ///     Gets the unique id which distinctly identifies the instance of the business model.
        /// </summary>
        public TId Id
        {
            get { return base.Model.Id; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        /// <param name="model">
        ///     Sets underlying business model which is encapsulated by this consumable client class.
        /// </param>
        protected Proxy(TModel model) : base(model)
        {
        }

        #endregion
    }
}
