using System;
using System.Collections.Generic;
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
    public partial class LocalSalesFactoryCollection : LocalFactoryCollection, ISalesFactoryCollection
    {
        #region fields

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="OpportunityModel" /> objects.
        /// </summary>
        private LocalOpportunityFactory _opportunity;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="OpportunityXrefModel" /> objects.
        /// </summary>
        private LocalOpportunityXrefFactory _opportunityXref;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="SalesChannelModel" /> objects.
        /// </summary>
        private LocalSalesChannelFactory _salesChannel;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="OpportunityModel" /> objects.
        /// </summary>
        public LocalOpportunityFactory Opportunity
        {
            get { return LocalFactory.Create(this.Provider, ref _opportunity); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="OpportunityXrefModel" /> objects.
        /// </summary>
        public LocalOpportunityXrefFactory OpportunityXref
        {
            get { return LocalFactory.Create(this.Provider, ref _opportunityXref); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="SalesChannelModel" /> objects.
        /// </summary>
        public LocalSalesChannelFactory SalesChannel
        {
            get { return LocalFactory.Create(this.Provider, ref _salesChannel); }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:OpportunityModel" /> objects.
        /// </summary>
        Consensus.Sales.IOpportunityFactory ISalesFactoryCollection.Opportunity
        {
            get { return this.Opportunity; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:OpportunityXrefModel" /> objects.
        /// </summary>
        Consensus.Sales.IOpportunityXrefFactory ISalesFactoryCollection.OpportunityXref
        {
            get { return this.OpportunityXref; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SalesChannelModel" /> objects.
        /// </summary>
        Consensus.Sales.ISalesChannelFactory ISalesFactoryCollection.SalesChannel
        {
            get { return this.SalesChannel; }
        }

        #endregion
    }
}
