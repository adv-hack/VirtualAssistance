using Consensus.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Sales
{
    /// <summary>
    ///     Encapsulates the <see cref="OpportunityRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalOpportunityModel
    {
        /// <summary>
        ///     The end user (client) for the opp.
        /// </summary>
        private LocalOpportunityXrefModel _clientOppXref;

        /// <summary>
        ///     The main sales person for the opp.
        /// </summary>
        private LocalOpportunityXrefModel _salesPersonOppXref;

        

        /// <summary>
        ///    Gets or sets the client for the opp.
        /// </summary>
        public LocalOpportunityXrefModel ClientOppXref
        {
            get
            {
                if (_clientOppXref == null)
                    _clientOppXref = this.OpportunityXrefs.FirstOrDefault(client => client.PersonType == OpportunityPersonType.EndUser);
                
                if (_clientOppXref == null)
                {
                    _clientOppXref = this.Provider.Sales.OpportunityXref.Create();
                    _clientOppXref.PersonType = OpportunityPersonType.EndUser;
                }

                return _clientOppXref;
            }
            set
            {
                value.PersonType = OpportunityPersonType.EndUser;
                _clientOppXref = value;
            }
        }
        /// <summary>
        ///    Gets or sets the main sales person for the opp.
        /// </summary>
        public LocalOpportunityXrefModel SalesOppXref
        {
            get
            {
                if (_salesPersonOppXref == null)
                    _salesPersonOppXref = this.OpportunityXrefs.FirstOrDefault(salesperson => salesperson.PersonType == OpportunityPersonType.MainSalesPerson);

                if (_salesPersonOppXref == null)
                {
                    _salesPersonOppXref = this.Provider.Sales.OpportunityXref.Create();
                    _salesPersonOppXref.PersonType = OpportunityPersonType.MainSalesPerson;
                }

                return _salesPersonOppXref;
            }
            set
            {
                value.PersonType = OpportunityPersonType.MainSalesPerson;
                _salesPersonOppXref = value;
            }
        }

        protected override void Initialise()
        {
            LocalSellingCompanyModel defaultSellingCompany = this.Provider.Common.SellingCompany.FetchDefault();
            if (defaultSellingCompany != null)
                this.SellingCompanyId = defaultSellingCompany.Id;
        }

        protected override void ResolveDependent()
        {
            if (this.ClientOppXref.IsModified)
            {
                this.ClientOppXref.OpportunityId = this.Id;
                this.ClientOppXref.Save();
            }
            if (this.SalesOppXref.IsModified)
            {
                this.SalesOppXref.OpportunityId = this.Id;
                this.SalesOppXref.Save();
            }
        }
    }
}
