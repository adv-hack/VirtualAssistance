using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Encapsulates the <see cref="ExportconfigurationsRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalExportconfigurationsModel : LocalModel<ExportconfigurationsRecord, Int32>, IExportconfigurationsModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="BatchModel" /> instances that reference this <see cref="ExportconfigurationsModel" />.
        /// </summary>
        private LocalCollection<LocalBatchModel, IBatchModel> _batchesExportConfigID;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ExportconfigurationsRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Other.Exportconfigurations.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ExportconfigurationsRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Other.Exportconfigurations.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ExportconfigurationsRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Other.Exportconfigurations.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "EC_TITLE" field.
        /// </summary>
        public String Title
        {
            get { return this.ModifiedData.Title; }
            set { this.ModifiedData.Title = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BatchModel" /> instances that reference this <see cref="ExportconfigurationsModel" />.
        /// </summary>
        public LocalCollection<LocalBatchModel, IBatchModel> BatchesExportConfigID
        {
            get
            {
                if (_batchesExportConfigID == null)
                    _batchesExportConfigID = new LocalCollection<LocalBatchModel, IBatchModel>(this.Provider.Other.Batch.FetchAllByBatchEcIdId(this.Id));
                
                return _batchesExportConfigID;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalExportconfigurationsModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalExportconfigurationsModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalExportconfigurationsModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalExportconfigurationsModel(LocalProvider provider, ExportconfigurationsRecord record) : base(provider, record)
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
            if (_batchesExportConfigID != null)
                _batchesExportConfigID.Execute(obj => obj.BatchEcIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "EC_TITLE" field.
        /// </summary>
        System.String IExportconfigurationsModel.Title
        {
            get { return this.Title; }
            set { this.Title = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BatchModel" /> instances that reference this <see cref="!:ExportconfigurationsModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Other.IBatchModel> IExportconfigurationsModel.BatchesExportConfigID
        {
            get { return this.BatchesExportConfigID; }
        }

        #endregion
    }
}
