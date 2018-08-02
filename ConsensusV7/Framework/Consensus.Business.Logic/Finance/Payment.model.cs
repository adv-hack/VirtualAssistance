using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="PaymentRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalPaymentModel
    {
        /// <summary>
        ///     The invoice ID to specify which invoice this payment needs to be allocated against when saved.
        /// </summary>
        private String _invoiceId;

        /// <summary>
        ///     Sets the invoice ID to specify which invoice this payment needs to be allocated against when saved.
        /// </summary>
        public String InvoiceId
        {
            set { _invoiceId = value; }
        }

        public override void Save()
        {
            if (this.IsPersisted || String.IsNullOrEmpty(_invoiceId))
                base.Save();
            else
                base.Save((rec) => this.Provider.DataProvider.Finance.Payment.CreateAndAllocate(rec, _invoiceId));
        }

        protected internal override void Denormalise()
        {
            base.Denormalise();
            this.Name = this.CardholderRole == null ? null : this.CardholderRole.PersonName;
            this.PersonId = this.CardholderRole == null ? null : this.CardholderRole.PersonId;
            this.CustomerAcc = this.Account == null ? null : this.Account.ARNumber;

        }
    }
}
