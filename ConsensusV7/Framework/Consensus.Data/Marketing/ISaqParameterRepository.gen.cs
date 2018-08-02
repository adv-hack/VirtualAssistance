using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SaqStepParamsRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISaqParameterRepository : IRepository<SaqStepParamsRecord, Int64>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqStepParamsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="stepId">
        ///     The value which identifies the <see cref="!:SaqParameterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqStepParamsRecord" /> instances that match the specified <paramref name="stepId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqStepParamsRecord> FetchAllByStepId(System.Int64 stepId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqStepParamsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="fId">
        ///     The value which identifies the <see cref="!:SaqParameterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqStepParamsRecord" /> instances that match the specified <paramref name="fId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqStepParamsRecord> FetchAllByFId(System.Int64 fId);

        #endregion
    }
}
