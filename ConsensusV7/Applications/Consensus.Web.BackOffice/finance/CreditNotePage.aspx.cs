using Consensus.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance
{
    public partial class CreditNotePage : BaseStandardPage<Invoice, String>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Credit - " + this.Data.Reference; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "invoice"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, Invoice> DataLoader
        {
            get { return Invoice.FetchById; }
        }

        #endregion

        #region methods

        protected override void PopulateControls()
        {
            this.CreditNoteDetails.DataSource = this.Data;
            this.CreditNoteAllocation.InvId = this.Data.Id;
            SetSendPackSidebarOption();
        }

        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }

        #endregion
    }
}