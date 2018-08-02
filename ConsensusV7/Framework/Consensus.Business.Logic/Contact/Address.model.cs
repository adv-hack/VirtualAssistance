using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="AddressRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalAddressModel
    {
        public String MailString
        {
            get
            {
                String[] elements = { this.Building, this.Street, this.Area, this.Town, this.County, this.Country, this.Postcode };
                return String.Join(Environment.NewLine, elements.Where(element => !String.IsNullOrEmpty(element)));
            }
        }
    }
}
