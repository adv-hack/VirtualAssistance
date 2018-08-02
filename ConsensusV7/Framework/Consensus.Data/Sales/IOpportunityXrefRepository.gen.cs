using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Sales
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="OpportunityXrefRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IOpportunityXrefRepository : IRepository<OpportunityXrefRecord, String>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Sales.OpportunityXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:OpportunityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Sales.OpportunityXrefRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.OpportunityXrefRecord> FetchAllByProleId(System.String proleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Sales.OpportunityXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="oppId">
        ///     The value which identifies the <see cref="!:OpportunityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Sales.OpportunityXrefRecord" /> instances that match the specified <paramref name="oppId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.OpportunityXrefRecord> FetchAllByOppId(System.String oppId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Sales.OpportunityXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:OpportunityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Sales.OpportunityXrefRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.OpportunityXrefRecord> FetchAllByOrgId(System.String orgId);

        #endregion
    }
}
