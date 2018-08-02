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
    public partial class MemberGradeDetail : BaseControl<MemberLocation, String>
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
                return "Member Grade";
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
        #endregion
        private void LockField(BaseInputControl control)
        {
            control.IsReadOnly = ConfigurableBoolean.TrueEnforced;
        }
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            this.LockField(this.Ref);
            this.LockField(this.Name);
            this.LockField(this.Startdate);
            this.LockField(this.Fee);
            this.LockField(this.Vat);
            this.LockField(this.Vatcode);
            this.LockField(this.Invoiced);
            this.LockField(this.Modified);
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            if (this.DataSource != null)
            {
                if (Convert.ToString(this.DataSource.Invoiced) == "2")
                {
                    this.Invoiced.Visible = false;
                }
                else if (Convert.ToString(this.DataSource.Invoiced) == "1")
                {
                    this.Invoiced.Enabled = true;
                }
                else
                {
                    this.Invoiced.Enabled = false;
                }
                
                this.Startdate.FieldValue = this.DataSource.CurrentDate!=null ? this.DataSource.CurrentDate : this.DataSource.Start;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}