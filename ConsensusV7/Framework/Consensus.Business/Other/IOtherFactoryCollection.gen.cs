using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
    public interface IOtherFactoryCollection : IFactoryCollection
    {
        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:WorkflowRecTypeModel" /> objects.
        /// </summary>
        Consensus.Other.IWorkflowRecTypeFactory WorkflowRecType
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:WorkflowModel" /> objects.
        /// </summary>
        Consensus.Other.IWorkflowFactory Workflow
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:BatchXrefModel" /> objects.
        /// </summary>
        Consensus.Other.IBatchXrefFactory BatchXref
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:BatchModel" /> objects.
        /// </summary>
        Consensus.Other.IBatchFactory Batch
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ExportconfigurationsModel" /> objects.
        /// </summary>
        Consensus.Other.IExportconfigurationsFactory Exportconfigurations
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:DataimportsModel" /> objects.
        /// </summary>
        Consensus.Other.IDataimportsFactory Dataimports
        {
            get;
        }
    }
}
