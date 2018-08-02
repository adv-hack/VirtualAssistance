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
    public partial class MemberConsultantSchemeDetail : BaseControl<MemberLocation, String>
    {
        #region properties

        /// <summary>
        ///     Sets if record can be deleted
        /// </summary>
        private Boolean _allowDelete = true;

        public override string DataTypeName
        {
            get
            {
                return "Consultant schemes";
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
            this.Status.DataSource = PopulateStatus();
            this.SyType.FieldValue = "5";
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            if (this.DataSource != null)
            {
                if (Convert.ToString(this.DataSource.Invoiced) == "1")
                {
                    this.LockField(this.Product);
                    this.LockField(this.StartDate);
                    this.LockField(this.EndDate);
                    this.LockField(this.Fee);
                    this.LockField(this.Vatcode);
                    this.AllowDelete = false;
                }
            }
            else
            {
                this.StartDate.FieldValue = DateTime.Now;
                this.Status.FieldValue = "0";
                string mepId = Request.QueryString["mepid"];
                if (mepId != "")
                {
                    MemberPeriod mep = MemberPeriod.FetchById(mepId);                   
                    this.EndDate.FieldValue = mep.End;
                }
            }
        }

        /// <summary>
        /// Populates Priority List
        /// </summary>
        /// <returns></returns>
        private object PopulateStatus()
        {
            List<KeyValuePair<String, String>> statusList = new List<KeyValuePair<String, String>>();
            statusList.Add(new KeyValuePair<string, string>("0", "Current and active"));
            statusList.Add(new KeyValuePair<string, string>("1", "Cancelled and credited"));
            statusList.Add(new KeyValuePair<string, string>("2", "Changed and inactive"));
            return statusList;
        }

        protected override void RegisterJavascript()
        {
            this.Product.ClientOnChange += @"
                if (this.getData() && (this.getValue() || '') != '') {
                    var data=this.getData();
                    if(!data.prod_price)
                        data.prod_price = 0;                  
                   document.getElementById('" + this.Fee.ClientID + @"Field').value=data.prod_price;
                   document.getElementById('" + this.Vatcode.ClientID + @"Field').value = data.prod_vat_code;}";

        }
    }
}