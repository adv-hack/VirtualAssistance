using Consensus.Sales;
using Consensus.Marketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Web.BackOffice.marketing;

namespace Consensus.Web.BackOffice.marketing
{
    public partial class MailingListPage : BaseStandardPage<MailingList, string>
    {
        public override Func<string, MailingList> DataLoader
        {
            get { return MailingList.FetchById; }
        }
        public override Func<MailingList> DataCreator
        {
            get { return MailingList.Create; }
        }

        public override string DefaultTitle
        {
            get { return "Mailing List - " + this.Data.Title; }
        }

        public override string DefaultIcon
        {
            get
            {
                return "submit_resume";
            }
        }
        
        protected override void PopulateControls()
        {
            // Get the data to be displayed
            MailingList list = this.Data;

            this.MailingListDetail.DataSource = list;
        }

    }
}