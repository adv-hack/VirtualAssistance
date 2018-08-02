using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="InvoiceModel" /> object.
    /// </summary>
    public partial class LocalInvoiceFactory
    {
        public bool CheckIfInvoiceCredited(String invId)
        {
            var invlist = this.FetchAll().ToList();
            var invoiced = invlist.Where(x => x.CreditNteRefId == invId).ToList();
            bool result = false;
            if (invoiced.Count > 0)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }
        public IEnumerable<LocalInvoiceModel> CreditInvoice(string invId,string userloginId)
        {
            var invoice = this.Provider.DataProvider.Finance.Invoice.FetchById(invId);
            this.Provider.DataProvider.Finance.Invoice.CreditInvoice(invoice, invId,userloginId);
            var creditedinvoice = this.Provider.Finance.Invoice.FetchAllByCreditNteRefId(invId);
            return creditedinvoice;
        }
    }
}
