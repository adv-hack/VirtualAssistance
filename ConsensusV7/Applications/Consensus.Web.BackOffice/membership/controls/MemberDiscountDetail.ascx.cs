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
    public partial class MemberDiscountDetail : BaseControl<MemberLocation, String>
    {
        #region properties
        /// <summary>
        ///     Sets if record can be deleted
        /// </summary>
        private Boolean _allowDelete = false;
        public override string DataTypeName
        {
            get
            {
                return "Member Discount";
            }
        }

        public override Func<String, MemberLocation> DataLoader
        {
            get { return MemberLocation.FetchById; }
        }
        /// <summary>
        ///     Sets if record can be deleted
        /// </summary>
        public override bool AllowDelete
        {
            get { return _allowDelete; }
            set { _allowDelete = value; }
        }

        private void LockField(BaseInputControl control)
        {
            control.IsReadOnly = ConfigurableBoolean.TrueEnforced;
        }
        #endregion

        protected override void PopulateControl()
        {
            base.PopulateControl();
            if (this.DataSource != null)
            {
                if (Convert.ToString(this.DataSource.Invoiced) == "1")
                {
                    this.LockField(this.DisReason);
                    this.LockField(this.AppliesUntil);
                    this.LockField(this.DisValue);
                    this.LockField(this.DisPercent);
                    this.LockField(this.Vatcode);
                    this.AllowDelete = false;
                }
                else
                {
                    this.AllowDelete = true;
                }
            }
        }
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

        }
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.Mepid.FieldValue = this.Request.QueryString["mepid"];
            var mep = this.Request.QueryString["mepid"];
            var feevalue = MemberLocation.FetchAllByMemberPeriodId(mep).Where(b => b.SyType == 0 && b.OrgIdId != null && b.RenewLoc==1).FirstOrDefault().Fee;
            this.FeeValue.FieldValue = Convert.ToString(feevalue);
            this.Status.FieldValue = "0";
            this.SyType.FieldValue = "3";
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}