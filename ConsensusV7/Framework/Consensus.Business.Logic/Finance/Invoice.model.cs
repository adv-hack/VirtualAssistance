using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="InvheaderRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalInvoiceModel
    {
        protected internal override void Denormalise()
        {
            base.Denormalise();
            this.ArNo = this.Account == null ? null : this.Account.ARNumber;
            this.GrossTotal = this.InvoiceLines.Count == 0 ? 0 : this.InvoiceLines.Select(invLine => invLine.TotalPrice).Sum();
            this.VatTotal = this.InvoiceLines.Count == 0 ? 0 : this.InvoiceLines.Select(invLine => invLine.VatAmt).Sum();
            this.NetTotal = this.InvoiceLines.Count == 0 ? 0 : this.InvoiceLines.Select(invLine => invLine.Net).Sum();
            this.SalesPersonId = this.SalesProleId == null ? null : this.SalesProleId.PersonId;
            this.PersonId = this.ProleId == null ? null : this.ProleId.PersonId;
            this.OrgName = this.Organisation == null ? null : this.Organisation.Name;
            this.AddressMailstring = this.Add == null ? null : this.Add.MailString;
            this.OrganisationName = this.Organisation == null ? null : this.Organisation.Name;
            this.PersonName = this.ProleId == null ? null : this.ProleId.PersonName;

        }
    }
}
