using Consensus.Membership;
using Consensus.UserInterface;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class MemberSpecialistGroupDetail : BaseControl<MemberLocation, String>
    {
        public override string DataTypeName
        {
            get
            {
                return "Member Specialist Group";
            }
        }

        public override Func<String, MemberLocation> DataLoader
        {
            get { return MemberLocation.FetchById; }
        }
        private void LockField(BaseInputControl control)
        {
            control.IsReadOnly = ConfigurableBoolean.TrueEnforced;
        }
        protected override void PopulateControl()
        {
            base.PopulateControl();
            if (this.DataSource != null)
            {
                if (Convert.ToString(this.DataSource.Invoiced) == "1")
                {
                    this.LockField(this.Name);
                    this.LockField(this.StartDate);
                    this.LockField(this.EndDate);
                    this.LockField(this.Fee);
                    this.LockField(this.Vat);
                    this.AllowDelete = false;
                }
                else
                {
                    this.AllowDelete = true;
                }
                this.StartDate.FieldValue = this.DataSource.Start;
                this.EndDate.FieldValue = this.DataSource.End;
            }
            else
            {
                this.StartDate.FieldValue = DateTime.Now.Date;
                var a = this.Request.QueryString["mepid"];
                this.EndDate.FieldValue = MemberLocation.FetchAllByMemberPeriodId(a).FirstOrDefault().End;
                this.Mepid.FieldValue = a;
            }
        }
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.Status.FieldValue = "0";
            this.SyType.FieldValue = "1";
            this.Mepid.FieldValue = this.Request.QueryString["mepid"];

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected override void RegisterJavascript()
        {
            this.Name.ClientOnChange = @"
                var data=this.getData();
                $('#" + this.Fee.ClientID + @"Field').val(data.prod_price);
                $('#" + this.Vat.ClientID + @"Field').val(data.prod_vat_code);
                if(data.prod_price==''){
                    $('#" + this.Fee.ClientID + @"Field').val('0');
                }
            ";
        }
    }
}