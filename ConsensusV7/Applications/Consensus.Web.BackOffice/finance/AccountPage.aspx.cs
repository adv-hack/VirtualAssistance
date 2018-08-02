using Consensus.Finance;
using System;
using Consensus.Contact;
using Consensus.Web.BackOffice.learning.controls;

namespace Consensus.Web.BackOffice.finance
{
    public partial class AccountPage : BaseStandardPage<Account, String>
    {
        #region Properties

        /// <summary>
        /// Gets the text displayed within the header of the page
        /// </summary>
        public override string DefaultTitle
        {
            get
            {
                return "Account - " + Data.Title;
            }
        }

        /// <summary>
        /// Gets the delegated method for loading the API object that is presented within the page
        /// </summary>
        public override Func<string, Account> DataLoader
        {
            get
            {
                return Account.FetchById;
            }
        }

        /// <summary>
        /// Gets the delegated method for creating the API object that is presented within the page
        /// </summary>
        public override Func<Account> DataCreator
        {
            get
            {
                return Account.Create;
            }
        }

        /// <summary>
        /// Gets the icon displayed within the header of the page.
        /// </summary>
        public override string DefaultIcon
        {
            get
            {
                return "account";
            }
        }

        #endregion

        #region Methods

        protected override void PopulateControls()
        {
            base.PopulateControls();
            AccountDetail.DataSource = Data;
            AccountInvoiceRules.DataSource = Data;
            AccountInvoiceList.AccountId = Data.Id;
            BookingPaymentList.AccountId = Data.Id;
            BookingPaymentList.PaymentType = BookingPaymentList.PaymentListType.Account;
            AccountPersonList.AccountIdForPersonList = this.Data.Id;
            Account account = this.Data;
            this.AccountCreditNoteList.DataSource = account;
        }

        protected override void PopulateLinks()
        {
            PopulateLink(BottomTabControl);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.BookingPaymentList.DataTable.CreateUrl += "&parent=account&accid=" + Data.Id;
            
        }
        #endregion
    }
}
