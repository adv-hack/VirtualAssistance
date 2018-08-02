using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="WorkflowRecTypeModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IWorkflowRecTypeFactory : IFactory<IWorkflowRecTypeModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:WorkflowRecTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:WorkflowRecTypeModel" /> instance.
        /// </returns>
        Consensus.Other.IWorkflowRecTypeModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:WorkflowRecTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:WorkflowRecTypeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.IWorkflowRecTypeModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:WorkflowRecTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:WorkflowRecTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:WorkflowRecTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Other.IWorkflowRecTypeModel FetchById(System.String id);

        System.String GetTableName();
    }
}
