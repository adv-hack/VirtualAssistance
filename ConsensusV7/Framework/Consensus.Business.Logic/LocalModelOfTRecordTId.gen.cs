using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus
{
    /// <summary>
    ///     Provides the abstraction for locally-executable business factories which support business model instantiation.
    /// </summary>
    /// <typeparam name="TRecord">
    ///     The data type of the record that is encapsulated by the business model.
    /// </typeparam>
    /// <typeparam name="TId">
    ///     The data type of the unique identifier which distinctly identifies an instance of the business model.
    /// </typeparam>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public abstract partial class LocalModel<TRecord, TId> : LocalModel<TRecord>, IModel<TId> where TRecord : Record<TId>, Cloneable<TRecord>, IEquatable<TRecord>, new() where TId : IComparable<TId>, IEquatable<TId>
    {
        #region properties

        /// <summary>
        ///     Gets the unique id distinctly identifies the instance of the data structure.
        /// </summary>
        public TId Id
        {
            get { return base.ModifiedData.Id; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalModel{TModel, TId}" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalModel{TModel, TId}" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalModel(LocalProvider provider, TRecord record) : base(provider, record)
        {
        }

        #endregion
    }
}
