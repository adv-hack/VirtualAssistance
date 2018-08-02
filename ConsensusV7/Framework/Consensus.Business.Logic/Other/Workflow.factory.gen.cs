using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="WorkflowModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalWorkflowFactory : LocalFactory<LocalWorkflowModel, WorkflowRecord, String>, IWorkflowFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='WorkflowModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='WorkflowModel' /> instance.
        /// </returns>
        public LocalWorkflowModel Create()
        {
            return new LocalWorkflowModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='WorkflowModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='WorkflowModel' /> instances.
        /// </returns>
        public IEnumerable<LocalWorkflowModel> FetchAll()
        {
            IEnumerable<WorkflowRecord> recordCollection = this.Provider.DataProvider.Other.Workflow.FetchAll();
            foreach (WorkflowRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalWorkflowModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='WorkflowModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='WorkflowModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='WorkflowModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalWorkflowModel FetchById(String id)
        {
            WorkflowRecord record = this.Provider.DataProvider.Other.Workflow.FetchById(id);
            if (record == null)
                return null;
            return new LocalWorkflowModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Workflow/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Other.Workflow.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Retrieves a specific <see cref="!:WorkflowModel" /> instance.
        /// </summary>
        /// <param name="recType">
        ///     The recType value for the <see cref="!:WorkflowModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:WorkflowModel" /> instance that matches the specified <paramref name="recType" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.IWorkflowModel> IWorkflowFactory.FetchAllByRecType(System.String recType)
        {
            return this.FetchAllByRecType(recType);
        }

        /// <summary>
        ///     Creates a new <see cref="!:WorkflowModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:WorkflowModel" /> instance.
        /// </returns>
        Consensus.Other.IWorkflowModel IWorkflowFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:WorkflowModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:WorkflowModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.IWorkflowModel> IWorkflowFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:WorkflowModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:WorkflowModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:WorkflowModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Other.IWorkflowModel IWorkflowFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IWorkflowFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
