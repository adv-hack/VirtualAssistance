using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents An organisation address.
    /// </summary>
    public partial class LocalOrganisationAddressModel
    {
        protected override void ResolveDependent()
        {
            if (this.Principal.ConvertTo<Boolean>())
            {
                LocalOrganisationAddressModel[] addresses = this.Organisation.OrganisationAddresses.Where(xref => xref.Id != this.Id).ToArray();
                addresses.Execute(xref => xref.Principal = 0);
                addresses.Execute(xref => xref.Save());
            }
        }
        protected internal override void Denormalise()
        {
            this.ModifiedData.AddPostcode = this.Address.Postcode;
            this.ModifiedData.OrgName = this.Organisation.Name;
        }
    }
}
