using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Sales
{
    /// <summary>
    ///     Microsoft SQL Server repository collection which pertains to the Sales namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerSalesRepositoryCollection : SqlServerRepositoryCollection, ISalesRepositoryCollection
    {
        #region fields

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="OpportunityRecord" /> data structure.
        /// </summary>
        private SqlServerOpportunityRepository _opportunity;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="OpportunityXrefRecord" /> data structure.
        /// </summary>
        private SqlServerOpportunityXrefRepository _opportunityXref;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SalesChannelRecord" /> data structure.
        /// </summary>
        private SqlServerSalesChannelRepository _salesChannel;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="OpportunityRecord" /> data structure.
        /// </summary>
        public SqlServerOpportunityRepository Opportunity
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerOpportunityRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _opportunity);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="OpportunityXrefRecord" /> data structure.
        /// </summary>
        public SqlServerOpportunityXrefRepository OpportunityXref
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerOpportunityXrefRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _opportunityXref);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SalesChannelRecord" /> data structure.
        /// </summary>
        public SqlServerSalesChannelRepository SalesChannel
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerSalesChannelRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _salesChannel);
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Partial method that can be implemented elsewhere in the partial class to allow the provider to be amended for a particular instance.
        /// </summary>
        /// <param name="SqlServerDataRepositoryType">
        ///     The type of the SqlServerDataRepository instance being created.
        /// </param>
        /// <param name="provider">
        ///     The default provider. A new provider may be assigned to this parameter in an implementation, if required.
        /// </param>
        partial void OverrideProvider(Type SqlServerDataRepositoryType, ref SqlServerProvider provider);

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Sales.OpportunityRecord" /> data structure.
        /// </summary>
        Consensus.Sales.IOpportunityRepository ISalesRepositoryCollection.Opportunity
        {
            get { return this.Opportunity; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Sales.OpportunityXrefRecord" /> data structure.
        /// </summary>
        Consensus.Sales.IOpportunityXrefRepository ISalesRepositoryCollection.OpportunityXref
        {
            get { return this.OpportunityXref; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Sales.SalesChannelRecord" /> data structure.
        /// </summary>
        Consensus.Sales.ISalesChannelRepository ISalesRepositoryCollection.SalesChannel
        {
            get { return this.SalesChannel; }
        }

        #endregion
    }
}
