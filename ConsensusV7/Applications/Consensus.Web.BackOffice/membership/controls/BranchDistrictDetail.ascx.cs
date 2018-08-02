using Consensus.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class BranchDistrictDetail : BaseControl<BranchXref, String>
    {
        #region properties
        public override string DataTypeName
        {
            get { return "Districts"; }
        }

        public override Func<String, BranchXref> DataLoader
        {
            get { return BranchXref.FetchById; }
        }
        #endregion

        #region methods
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            var BrId = this.Request.QueryString["brid"];
            this.Brid.FieldValue = BrId;
            this.TableName.FieldValue = "District";

        }
        protected override void RegisterJavascript()
        {
            this.Dis.ClientOnChange += @"
                if(this.getData() != ''){
                    var data=this.getData();
                     $('#" + this.DisId.ClientID + @"Field').val(data.id);
            }";
        }
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            var BrId = this.Request.QueryString["id"];
            var RecorId = BranchXref.FetchById(BrId);

            if (RecorId != null)
            {
                var DisId = RecorId.RecordId;
                var district = District.FetchById(DisId);
                var disname = district.Name;
                this.Dis.FieldText = disname;
            }
        }
        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.AllowDelete = true;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}