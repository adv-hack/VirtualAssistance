using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="WorkflowModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IWorkflowFactory : IFactory<IWorkflowModel, String>
    {
        /// <summary>
        ///     Retrieves a specific <see cref="!:WorkflowModel" /> instance.
        /// </summary>
        /// <param name="recType">
        ///     The recType value for the <see cref="!:WorkflowModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:WorkflowModel" /> instance that matches the specified <paramref name="recType" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.IWorkflowModel> FetchAllByRecType(System.String recType);

        /// <summary>
        ///     Creates a new <see cref="!:WorkflowModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:WorkflowModel" /> instance.
        /// </returns>
        Consensus.Other.IWorkflowModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:WorkflowModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:WorkflowModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.IWorkflowModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:WorkflowModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:WorkflowModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:WorkflowModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Other.IWorkflowModel FetchById(System.String id);

        System.String GetTableName();
    }
}
