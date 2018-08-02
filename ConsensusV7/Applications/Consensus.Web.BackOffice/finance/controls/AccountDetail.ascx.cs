using Consensus.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class AccountDetail : BaseControl<Account, String>
    {
        #region properties

        public override string DataTypeName
        {
            get { return "Account"; }
        }

        #endregion

        #region Methods

        protected override void OnPreRender(EventArgs eventArguments)
        {
            base.OnPreRender(eventArguments);
            this.SellingCompany.DataSource = Common.SellingCompany.FetchAll();
            this.From.DataSource = this.PopulatePaymentTypeList();

            //Defaults for new Account
            if (this.DataSource != null && this.DataSource.Id != null)
            {
                //Account information
                var invoiceList = Invoice.FetchAllByAccountId(this.DataSource.Id);
                var paymentList = Payment.FetchAllByAccountId(this.DataSource.Id);

                var invoiceTotal = invoiceList.Where(x => x.TypeCode == "Invoice").Sum(x => x.GrossTotal);
                var paymentSum = paymentList.Sum(x => x.Amount);
                var creditTotal = invoiceList.Where(x => x.TypeCode == "Credit").Sum(x => x.GrossTotal);
                var outstandingBalance = invoiceTotal - paymentSum + creditTotal;

                this.InvoicedValue.FieldValue = invoiceTotal.ConvertTo<String>();
                this.PaymentTotal.FieldValue = paymentSum.ConvertTo<String>();
                this.OutstandingBalance.FieldValue = outstandingBalance.ConvertTo<String>();

                var list = invoiceList.Where(x => x.DueDate < DateTime.Now).ToList();

                this.OverdueInvoices.FieldValue = invoiceList.Where(x => x.DueDate < DateTime.Now && x.TypeCode == "Invoice").Sum(x => x.UnpaidValue).ConvertTo<String>();
                this.UnallocatedPaymentValue.FieldValue = paymentList.Sum(x => x.UnusedVal).ConvertTo<String>();
                this.CreditAvailable.FieldValue = (this.DataSource.Credit - outstandingBalance).ConvertTo<String>();
            }
            else
            {
                this.From.FieldValue = "0";
                this.InvoicedValue.FieldValue = "0";
                this.PaymentTotal.FieldValue = "0";
                this.OutstandingBalance.FieldValue = "0";
                this.OverdueInvoices.FieldValue = "0";
                this.UnallocatedPaymentValue.FieldValue = "0";
                this.CreditAvailable.FieldValue = "0";
                this.Currency.FieldValue = "GBP";
            }
        }

        /// <summary>
        /// Populates Payment List
        /// </summary>
        /// <returns></returns>
        private object PopulatePaymentTypeList()
        {
            List<KeyValuePair<String, String>> paymentTypeList = new List<KeyValuePair<String, String>>();
            paymentTypeList.Add(new KeyValuePair<string, string>("0", "Use Default"));
            paymentTypeList.Add(new KeyValuePair<string, string>("1", "n days from invoice date"));
            paymentTypeList.Add(new KeyValuePair<string, string>("2", "n days prior to first element"));
            paymentTypeList.Add(new KeyValuePair<string, string>("3", "n days from end of month"));
            paymentTypeList.Add(new KeyValuePair<string, string>("4", "end of month"));
            return paymentTypeList;
        }

        #endregion
    }
}