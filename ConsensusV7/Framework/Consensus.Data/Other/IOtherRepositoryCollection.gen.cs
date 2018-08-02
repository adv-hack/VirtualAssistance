using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     The repository collection which pertains to the Other namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IOtherRepositoryCollection : IRepositoryCollection
    {
        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Other.WorkflowRecTypeRecord" /> data structure.
        /// </summary>
        Consensus.Other.IWorkflowRecTypeRepository WorkflowRecType
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Other.WorkflowRecord" /> data structure.
        /// </summary>
        Consensus.Other.IWorkflowRepository Workflow
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Other.BatchXrefRecord" /> data structure.
        /// </summary>
        Consensus.Other.IBatchXrefRepository BatchXref
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Other.BatchRecord" /> data structure.
        /// </summary>
        Consensus.Other.IBatchRepository Batch
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Other.ExportconfigurationsRecord" /> data structure.
        /// </summary>
        Consensus.Other.IExportconfigurationsRepository Exportconfigurations
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Other.DataimportsRecord" /> data structure.
        /// </summary>
        Consensus.Other.IDataimportsRepository Dataimports
        {
            get;
        }
    }
}
