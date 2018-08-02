using Consensus.Contact;
using Consensus.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class CommitteeMemberDetail : BaseControl<CommitteeXref, String>
    {
        #region properties
        public override string DataTypeName
        {
            get { return "Committee member"; }
        }
        public override Func<String, CommitteeXref> DataLoader
        {
            get { return CommitteeXref.FetchById; }
        }
        #endregion

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            var comtid = this.Request.QueryString["id"];
            var recordId = CommitteeXref.FetchById(comtid);
            if (recordId != null)
            {
                var personid = recordId.RecordId;
                var person = Role.FetchById(personid).PersonName;
                this.Name.FieldText = person;
            }
            if (this.DataSource == null)
            {
                this.AddDate.FieldValue = DateTime.Now.Date;
                var comid = this.Request.QueryString["comid"];
                this.CommitteeId.FieldValue = comid;
                this.TableName.FieldValue = "Person_Role";
                this.Disabled.FieldValue = "0";
            }
        }

    }
}