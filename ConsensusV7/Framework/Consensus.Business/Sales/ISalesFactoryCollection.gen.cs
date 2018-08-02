using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Sales
{
    /// <summary>
    ///     Represents a collection of factory instances which are responsible for the instantiation of the business models in the Sales namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISalesFactoryCollection : IFactoryCollection
    {
        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:OpportunityModel" /> objects.
        /// </summary>
        Consensus.Sales.IOpportunityFactory Opportunity
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:OpportunityXrefModel" /> objects.
        /// </summary>
        Consensus.Sales.IOpportunityXrefFactory OpportunityXref
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SalesChannelModel" /> objects.
        /// </summary>
        Consensus.Sales.ISalesChannelFactory SalesChannel
        {
            get;
        }
    }
}
