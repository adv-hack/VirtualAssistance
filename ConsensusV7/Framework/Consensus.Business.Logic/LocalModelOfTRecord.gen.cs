using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace Consensus
{
    /// <summary>
    ///     Provides the abstraction for locally-executable business factories which support business model instantiation.
    /// </summary>
    /// <typeparam name="TRecord">
    ///     The data type of the record that is encapsulated by the business model.
    /// </typeparam>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public abstract partial class LocalModel<TRecord> : LocalModel where TRecord : Record, Cloneable<TRecord>, IEquatable<TRecord>, new()
    {
        #region fields

        /// <summary>
        ///     Specifies whether the underlying data structure has been persisted within the the persistence mechanism.
        /// </summary>
        private Boolean _isPersisted;

        /// <summary>
        ///     The data structure that was originally loaded from the persistence mechanism or originally instantiated.
        /// </summary>
        private TRecord _originalData;

        /// <summary>
        ///     The data structure that is exposed for in-memory modification.
        /// </summary>
        private TRecord _modifiedData;

        #endregion

        #region properties

        /// <summary>
        ///     Gets whether the underlying data structure has been persisted within the the persistence mechanism.
        /// </summary>
        public override Boolean IsPersisted
        {
            get { return _isPersisted; }
        }

        /// <summary>
        ///     Gets whether the underlying data has been modified since instantiation.
        /// </summary>
        public override Boolean IsModified
        {
            get { return !this.OriginalData.Equals(this.ModifiedData); }
        }

        /// <summary>
        ///     Gets the data structure that was originally loaded from the persistence mechanism or originally instantiated.
        /// </summary>
        protected TRecord OriginalData
        {
            get { return _originalData; }
            private set { _originalData = value; }
        }

        /// <summary>
        ///     Gets data structure that is exposed for in-memory modification.
        /// </summary>
        protected TRecord ModifiedData
        {
            get { return _modifiedData; }
            private set { _modifiedData = value; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected virtual Action<TRecord> DataCreator
        {
            get { return null; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected virtual Action<TRecord> DataModifier
        {
            get { return null; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected virtual Action<TRecord> DataRemover
        {
            get { return null; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalModel{TModel}" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalModel(LocalProvider provider) : base(provider)
        {
            this.ModifiedData = new TRecord();
            this.Initialise();
            this.OriginalData = this.ModifiedData.Clone();
            _isPersisted = false;
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalModel{TModel}" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalModel(LocalProvider provider, TRecord record) : base(provider)
        {
            this.ModifiedData = record.Clone();
            this.OriginalData = record.Clone();
            _isPersisted = true;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Validates that the underlying data is compliant with the standardised business rules and is therefore eligible for persistence.
        /// </summary>
        protected virtual void Validate()
        {
        }

        /// <summary>
        ///     Provides denormalisation upon the underlying data structure prior to persistence.
        /// </summary>
        protected internal virtual void Denormalise()
        {
        }

        /// <summary>
        ///     Provides initialisation for a new instance of the model.
        /// </summary>
        protected virtual void Initialise()
        {
        }

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected virtual void ResolveDependency()
        {
        }

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected virtual void ResolveGeneratedDependency()
        {
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected virtual void ResolveDependent()
        {
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected virtual void ResolveGeneratedDependent()
        {
        }

        /// <summary>
        ///     Stores the underlying data within the persistence mechanism.
        /// </summary>
        public override void Save()
        {
            this.Save(this.IsPersisted ? this.DataModifier : this.DataCreator);
        }

        /// <summary>
        ///     Stores the underlying data within the persistence mechanism.
        /// </summary>
        /// <param name="dataFunction">
        ///     The delegated data-provider function for saving the record.
        /// </param>
        protected void Save(Action<TRecord> dataFunction)
        {
            // Create a new transaction, or reuse the existing ambient transaction where one already exists.
            using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required))
            {
                this.ResolveDependency();
                this.ResolveGeneratedDependency();
                if (this.IsModified)
                {
                    // Denormalise and validate the encapsulated data record.
                    this.Denormalise();
                    this.Validate();
            
                    // Save the data record to the underlying persistence mechanism.
                    if (dataFunction != null)
                        dataFunction.Invoke(this.ModifiedData);
            
                    this.Set(true);
                }
            
                // Save the business models which reference this object.
                this.ResolveDependent();
                this.ResolveGeneratedDependent();
                transaction.Complete();
            }
        }

        /// <summary>
        ///     Validates that the object can be removed from the system.
        /// </summary>
        protected virtual void ValidateRemoval()
        {
        }

        /// <summary>
        ///     Resolves the dependent models by means of deleting all models that are direct descendents of this model.
        /// </summary>
        protected virtual void ResolveDeleteDependent()
        {
        }

        /// <summary>
        ///     Removes the underlying data from the persistence mechanism.
        /// </summary>
        public override void Delete()
        {
            // Create a new transaction, or reuse the existing ambient transaction where one already exists.
            using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Required))
            {
                if (this.IsPersisted)
                {
                    // Validate that the data is removable.
                    this.ValidateRemoval();
                    this.ResolveDeleteDependent();
                    if (this.DataRemover != null)
                        this.DataRemover.Invoke(this.ModifiedData);
            
                    // Update the state of the object.
                    this.Set(false);
                    transaction.Complete();
                }
            }
        }

        /// <summary>
        ///     Sets the internal object state.
        /// </summary>
        /// <param name="isPersisted">
        ///     Specifies whether the object is stored within the underlying persistence mechanism.
        /// </param>
        internal void Set(Boolean isPersisted)
        {
            this.OriginalData = this.ModifiedData.Clone();
            _isPersisted = isPersisted;
        }

        #endregion
    }
}
