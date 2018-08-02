using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="WorkflowRecTypeModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalWorkflowRecTypeFactory : LocalFactory<LocalWorkflowRecTypeModel, WorkflowRecTypeRecord, String>, IWorkflowRecTypeFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='WorkflowRecTypeModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='WorkflowRecTypeModel' /> instance.
        /// </returns>
        public LocalWorkflowRecTypeModel Create()
        {
            return new LocalWorkflowRecTypeModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='WorkflowRecTypeModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='WorkflowRecTypeModel' /> instances.
        /// </returns>
        public IEnumerable<LocalWorkflowRecTypeModel> FetchAll()
        {
            IEnumerable<WorkflowRecTypeRecord> recordCollection = this.Provider.DataProvider.Other.WorkflowRecType.FetchAll();
            foreach (WorkflowRecTypeRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalWorkflowRecTypeModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='WorkflowRecTypeModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='WorkflowRecTypeModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='WorkflowRecTypeModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalWorkflowRecTypeModel FetchById(String id)
        {
            WorkflowRecTypeRecord record = this.Provider.DataProvider.Other.WorkflowRecType.FetchById(id);
            if (record == null)
                return null;
            return new LocalWorkflowRecTypeModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='WorkflowRecType/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Other.WorkflowRecType.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:WorkflowRecTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:WorkflowRecTypeModel" /> instance.
        /// </returns>
        Consensus.Other.IWorkflowRecTypeModel IWorkflowRecTypeFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:WorkflowRecTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:WorkflowRecTypeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.IWorkflowRecTypeModel> IWorkflowRecTypeFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:WorkflowRecTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:WorkflowRecTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:WorkflowRecTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Other.IWorkflowRecTypeModel IWorkflowRecTypeFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IWorkflowRecTypeFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
