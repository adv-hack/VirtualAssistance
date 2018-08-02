using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Encapsulates the <see cref="DataimportsRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalDataimportsModel : LocalModel<DataimportsRecord, Int32>, IDataimportsModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="BatchModel" /> instances that reference this <see cref="DataimportsModel" />.
        /// </summary>
        private LocalCollection<LocalBatchModel, IBatchModel> _batchesDataImportID;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<DataimportsRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Other.Dataimports.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<DataimportsRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Other.Dataimports.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<DataimportsRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Other.Dataimports.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DI_TITLE" field.
        /// </summary>
        public String Title
        {
            get { return this.ModifiedData.Title; }
            set { this.ModifiedData.Title = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DI_ACTIVE" field.
        /// </summary>
        public Byte? Active
        {
            get { return this.ModifiedData.Active; }
            set { this.ModifiedData.Active = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BatchModel" /> instances that reference this <see cref="DataimportsModel" />.
        /// </summary>
        public LocalCollection<LocalBatchModel, IBatchModel> BatchesDataImportID
        {
            get
            {
                if (_batchesDataImportID == null)
                    _batchesDataImportID = new LocalCollection<LocalBatchModel, IBatchModel>(this.Provider.Other.Batch.FetchAllByBatchDiIdId(this.Id));
                
                return _batchesDataImportID;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalDataimportsModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalDataimportsModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalDataimportsModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalDataimportsModel(LocalProvider provider, DataimportsRecord record) : base(provider, record)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected override void ResolveGeneratedDependency()
        {
            base.ResolveGeneratedDependency();
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_batchesDataImportID != null)
                _batchesDataImportID.Execute(obj => obj.BatchDiIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "DI_TITLE" field.
        /// </summary>
        System.String IDataimportsModel.Title
        {
            get { return this.Title; }
            set { this.Title = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DI_ACTIVE" field.
        /// </summary>
        System.Nullable<System.Byte> IDataimportsModel.Active
        {
            get { return this.Active; }
            set { this.Active = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BatchModel" /> instances that reference this <see cref="!:DataimportsModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Other.IBatchModel> IDataimportsModel.BatchesDataImportID
        {
            get { return this.BatchesDataImportID; }
        }

        #endregion
    }
}
