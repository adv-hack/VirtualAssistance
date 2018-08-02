using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Sales
{
    /// <summary>
    ///     Enumerates the different person types for an opportunity.
    /// </summary>
    public enum OpportunityPersonType
    {
        SalesPerson,
        MainSalesPerson,
        EndUser,
        Distributor,
        Unknown
    }
}
