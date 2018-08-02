using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Sales
{
    /// <summary>
    ///     The repository collection which pertains to the Sales namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISalesRepositoryCollection : IRepositoryCollection
    {
        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Sales.OpportunityRecord" /> data structure.
        /// </summary>
        Consensus.Sales.IOpportunityRepository Opportunity
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Sales.OpportunityXrefRecord" /> data structure.
        /// </summary>
        Consensus.Sales.IOpportunityXrefRepository OpportunityXref
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Sales.SalesChannelRecord" /> data structure.
        /// </summary>
        Consensus.Sales.ISalesChannelRepository SalesChannel
        {
            get;
        }
    }
}
