using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Microsoft SQL Server repository collection which pertains to the Other namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerOtherRepositoryCollection : SqlServerRepositoryCollection, IOtherRepositoryCollection
    {
        #region fields

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="WorkflowRecTypeRecord" /> data structure.
        /// </summary>
        private SqlServerWorkflowRecTypeRepository _workflowRecType;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="WorkflowRecord" /> data structure.
        /// </summary>
        private SqlServerWorkflowRepository _workflow;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="BatchXrefRecord" /> data structure.
        /// </summary>
        private SqlServerBatchXrefRepository _batchXref;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="BatchRecord" /> data structure.
        /// </summary>
        private SqlServerBatchRepository _batch;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ExportconfigurationsRecord" /> data structure.
        /// </summary>
        private SqlServerExportconfigurationsRepository _exportconfigurations;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="DataimportsRecord" /> data structure.
        /// </summary>
        private SqlServerDataimportsRepository _dataimports;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="WorkflowRecTypeRecord" /> data structure.
        /// </summary>
        public SqlServerWorkflowRecTypeRepository WorkflowRecType
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerWorkflowRecTypeRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _workflowRecType);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="WorkflowRecord" /> data structure.
        /// </summary>
        public SqlServerWorkflowRepository Workflow
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerWorkflowRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _workflow);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="BatchXrefRecord" /> data structure.
        /// </summary>
        public SqlServerBatchXrefRepository BatchXref
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerBatchXrefRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _batchXref);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="BatchRecord" /> data structure.
        /// </summary>
        public SqlServerBatchRepository Batch
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerBatchRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _batch);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ExportconfigurationsRecord" /> data structure.
        /// </summary>
        public SqlServerExportconfigurationsRepository Exportconfigurations
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerExportconfigurationsRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _exportconfigurations);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="DataimportsRecord" /> data structure.
        /// </summary>
        public SqlServerDataimportsRepository Dataimports
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerDataimportsRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _dataimports);
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Partial method that can be implemented elsewhere in the partial class to allow the provider to be amended for a particular instance.
        /// </summary>
        /// <param name="SqlServerDataRepositoryType">
        ///     The type of the SqlServerDataRepository instance being created.
        /// </param>
        /// <param name="provider">
        ///     The default provider. A new provider may be assigned to this parameter in an implementation, if required.
        /// </param>
        partial void OverrideProvider(Type SqlServerDataRepositoryType, ref SqlServerProvider provider);

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Other.WorkflowRecTypeRecord" /> data structure.
        /// </summary>
        Consensus.Other.IWorkflowRecTypeRepository IOtherRepositoryCollection.WorkflowRecType
        {
            get { return this.WorkflowRecType; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Other.WorkflowRecord" /> data structure.
        /// </summary>
        Consensus.Other.IWorkflowRepository IOtherRepositoryCollection.Workflow
        {
            get { return this.Workflow; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Other.BatchXrefRecord" /> data structure.
        /// </summary>
        Consensus.Other.IBatchXrefRepository IOtherRepositoryCollection.BatchXref
        {
            get { return this.BatchXref; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Other.BatchRecord" /> data structure.
        /// </summary>
        Consensus.Other.IBatchRepository IOtherRepositoryCollection.Batch
        {
            get { return this.Batch; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Other.ExportconfigurationsRecord" /> data structure.
        /// </summary>
        Consensus.Other.IExportconfigurationsRepository IOtherRepositoryCollection.Exportconfigurations
        {
            get { return this.Exportconfigurations; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Other.DataimportsRecord" /> data structure.
        /// </summary>
        Consensus.Other.IDataimportsRepository IOtherRepositoryCollection.Dataimports
        {
            get { return this.Dataimports; }
        }

        #endregion
    }
}
