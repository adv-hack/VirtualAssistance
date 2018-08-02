using Consensus.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents An organisation.
    /// </summary>
    public partial class LocalOrganisationModel
    {
        /// <summary>
        ///     The principal address for the organisation.
        /// </summary>
        private LocalOrganisationAddressModel _principalAddress;

        /// <summary>
        ///    Gets or sets theprincipal address for the organisation.
        /// </summary>
        public LocalOrganisationAddressModel PrincipalAddress
        {
            get
            {
                if (_principalAddress == null)
                    _principalAddress = this.OrganisationAddresses.FirstOrDefault(address => address.Principal == 1);

                return _principalAddress;
            }
            set
            {
                this.OrganisationAddresses.Execute(address => address.Principal = 0);
                value.Principal = 1;

                _principalAddress = value;
            }
        }

        protected override void Initialise()
        {
            LocalSellingCompanyModel defaultSellingCompany = this.Provider.Common.SellingCompany.FetchDefault();
            if (defaultSellingCompany != null)
                this.SellingCompanyId = defaultSellingCompany.Id;
        }

        protected override void ResolveDependency()
        {
            base.ResolveDependency();
            if (_principalAddress != null)
                _principalAddress.Save();
        }

    }
}
