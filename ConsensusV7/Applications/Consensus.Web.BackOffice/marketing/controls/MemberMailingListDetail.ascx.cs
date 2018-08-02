using Consensus.Marketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Security;

namespace Consensus.Web.BackOffice.marketing.controls
{
    public partial class MemberMailingListDetail : BaseControl<MailingListMember, String>
    {
        public override String DataTypeName
        {
            get { return "Member Mailing List"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, MailingListMember> DataLoader
        {
            get { return MailingListMember.FetchById; }
        }


        protected override void PopulateControl()
        {
            base.PopulateControl();
            if (this.DataSource == null)
                this.TableName.FieldValue = "PERSON";

            this.MailingList.DataSource = Marketing.MailingList.FetchAll().Where(list => list.StatusCode == "Current").OrderBy(list => list.Title);
        }
    }
}