using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Sales
{
    /// <summary>
    ///     Encapsulates the <see cref="OpportunityXrefRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalOpportunityXrefModel
    {
        #region properties

        /// <summary>
        ///     Gets or sets the type of person that is linked to the opportunity.
        /// </summary>
        public OpportunityPersonType PersonType
        {
            get
            {
                if (this.ModifiedData.Salesman.ConvertTo<Int32>() == 1)
                    return OpportunityPersonType.MainSalesPerson;
                if (this.ModifiedData.Salesman.ConvertTo<Int32>() == 2)
                    return OpportunityPersonType.SalesPerson;
                if (this.ModifiedData.EndOrg.ConvertTo<Boolean>())
                    return OpportunityPersonType.EndUser;
                if (this.ModifiedData.DistOrg.ConvertTo<Boolean>())
                    return OpportunityPersonType.Distributor;
                return OpportunityPersonType.Unknown;
            }
            set
            {
                this.ModifiedData.Salesman = ((value == OpportunityPersonType.SalesPerson) ? 2 : (value == OpportunityPersonType.MainSalesPerson) ? 1 : 0).ConvertTo<String>();
                this.ModifiedData.EndOrg = (value == OpportunityPersonType.EndUser ? 1 : 0).ConvertTo<Byte>();
                this.ModifiedData.DistOrg = (value == OpportunityPersonType.Distributor ? 1 : 0).ConvertTo<Byte>();
            }
        }

        #endregion

        protected internal override void Denormalise()
        {
            base.Denormalise();
            this.OrgName = this.Organisation == null ? null : this.Organisation.Name;
            this.OrgPhone = this.Organisation == null ? null : this.Organisation.Phone;
            this.SalesPerson = this.Role == null ? null : this.Role.PersonName;
            this.PnPhone = this.Role == null ? null : this.Role.Telephone;
        }
        
        protected override void ResolveDependent()
        {
            base.ResolveDependent();
            if (this.PersonType == OpportunityPersonType.MainSalesPerson)
            {
                LocalOpportunityXrefModel[] otherXrefs = this.Opportunity.OpportunityXrefs.Where(xref => xref.Id != this.Id && xref.PersonType == OpportunityPersonType.MainSalesPerson).ToArray();
                otherXrefs.Execute(xref => xref.PersonType = OpportunityPersonType.SalesPerson).Execute(xref => xref.Save());
            }
            else if (this.PersonType == OpportunityPersonType.EndUser)
            {
                LocalOpportunityXrefModel[] otherXrefs = this.Opportunity.OpportunityXrefs.Where(xref => xref.Id != this.Id && xref.PersonType == OpportunityPersonType.EndUser).ToArray();
                otherXrefs.Execute(xref => xref.PersonType = OpportunityPersonType.Unknown).Execute(xref => xref.Save());
            }
            else if (this.PersonType == OpportunityPersonType.Distributor)
            {
                LocalOpportunityXrefModel[] otherXrefs = this.Opportunity.OpportunityXrefs.Where(xref => xref.Id != this.Id && xref.PersonType == OpportunityPersonType.Distributor).ToArray();
                otherXrefs.Execute(xref => xref.PersonType = OpportunityPersonType.Unknown).Execute(xref => xref.Save());
            }
        }
    }
}
