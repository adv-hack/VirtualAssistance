using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="WorkflowModel" /> object.
    /// </summary>
    public partial class LocalWorkflowFactory
    {
        /// <summary>
        ///     Retrieves a specific <see cref='WorkflowModel' /> instance.
        /// </summary>
        /// <param name="recType">
        ///     The recType value for the <see cref='WorkflowModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='WorkflowModel' /> instance that matches the specified <paramref name='recType' />; or null, if no matching instance can be found.
        /// </returns>
        public IEnumerable<LocalWorkflowModel> FetchAllByRecType(String recType)
        {
            IEnumerable<WorkflowRecord> recordCollection = this.Provider.DataProvider.Other.Workflow.FetchByRecType(recType);
            IEnumerable<LocalWorkflowModel> modelCollection = recordCollection.Select(record => new LocalWorkflowModel(this.Provider, record));
            return modelCollection;
        }
    }
}
