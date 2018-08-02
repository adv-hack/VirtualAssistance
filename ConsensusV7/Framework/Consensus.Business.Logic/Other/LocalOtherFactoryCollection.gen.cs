using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Represents a collection of factory instances which are responsible for the instantiation of the business models in the Other namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalOtherFactoryCollection : LocalFactoryCollection, IOtherFactoryCollection
    {
        #region fields

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="WorkflowRecTypeModel" /> objects.
        /// </summary>
        private LocalWorkflowRecTypeFactory _workflowRecType;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="WorkflowModel" /> objects.
        /// </summary>
        private LocalWorkflowFactory _workflow;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="BatchXrefModel" /> objects.
        /// </summary>
        private LocalBatchXrefFactory _batchXref;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="BatchModel" /> objects.
        /// </summary>
        private LocalBatchFactory _batch;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ExportconfigurationsModel" /> objects.
        /// </summary>
        private LocalExportconfigurationsFactory _exportconfigurations;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="DataimportsModel" /> objects.
        /// </summary>
        private LocalDataimportsFactory _dataimports;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="WorkflowRecTypeModel" /> objects.
        /// </summary>
        public LocalWorkflowRecTypeFactory WorkflowRecType
        {
            get { return LocalFactory.Create(this.Provider, ref _workflowRecType); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="WorkflowModel" /> objects.
        /// </summary>
        public LocalWorkflowFactory Workflow
        {
            get { return LocalFactory.Create(this.Provider, ref _workflow); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="BatchXrefModel" /> objects.
        /// </summary>
        public LocalBatchXrefFactory BatchXref
        {
            get { return LocalFactory.Create(this.Provider, ref _batchXref); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="BatchModel" /> objects.
        /// </summary>
        public LocalBatchFactory Batch
        {
            get { return LocalFactory.Create(this.Provider, ref _batch); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ExportconfigurationsModel" /> objects.
        /// </summary>
        public LocalExportconfigurationsFactory Exportconfigurations
        {
            get { return LocalFactory.Create(this.Provider, ref _exportconfigurations); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="DataimportsModel" /> objects.
        /// </summary>
        public LocalDataimportsFactory Dataimports
        {
            get { return LocalFactory.Create(this.Provider, ref _dataimports); }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:WorkflowRecTypeModel" /> objects.
        /// </summary>
        Consensus.Other.IWorkflowRecTypeFactory IOtherFactoryCollection.WorkflowRecType
        {
            get { return this.WorkflowRecType; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:WorkflowModel" /> objects.
        /// </summary>
        Consensus.Other.IWorkflowFactory IOtherFactoryCollection.Workflow
        {
            get { return this.Workflow; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:BatchXrefModel" /> objects.
        /// </summary>
        Consensus.Other.IBatchXrefFactory IOtherFactoryCollection.BatchXref
        {
            get { return this.BatchXref; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:BatchModel" /> objects.
        /// </summary>
        Consensus.Other.IBatchFactory IOtherFactoryCollection.Batch
        {
            get { return this.Batch; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ExportconfigurationsModel" /> objects.
        /// </summary>
        Consensus.Other.IExportconfigurationsFactory IOtherFactoryCollection.Exportconfigurations
        {
            get { return this.Exportconfigurations; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:DataimportsModel" /> objects.
        /// </summary>
        Consensus.Other.IDataimportsFactory IOtherFactoryCollection.Dataimports
        {
            get { return this.Dataimports; }
        }

        #endregion
    }
}
