using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SaqQueryStepsRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISaqQueryStepRepository : IRepository<SaqQueryStepsRecord, Int32>
    {
        #region properties

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String TableName
        {
            get;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryStepsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="qryId">
        ///     The value which identifies the <see cref="!:SaqQueryStepModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryStepsRecord" /> instances that match the specified <paramref name="qryId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryStepsRecord> FetchAllByQryId(System.Int64 qryId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryStepsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="stepId">
        ///     The value which identifies the <see cref="!:SaqQueryStepModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryStepsRecord" /> instances that match the specified <paramref name="stepId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryStepsRecord> FetchAllByStepId(System.Int64 stepId);

        #endregion
    }
}
