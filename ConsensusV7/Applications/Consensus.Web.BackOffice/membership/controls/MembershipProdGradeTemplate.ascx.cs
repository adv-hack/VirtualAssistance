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
    public partial class MembershipProdGradeTemplate : BaseControl<MemberBom, String>
    {
        /// <summary>
     ///     Sets if record can be deleted
     /// </summary>
        private Boolean _allowDelete = true;

        /// <summary>
        ///     Sets if record can be deleted
        /// </summary>
        public override bool AllowDelete
        {
            get { return _allowDelete; }
            set { _allowDelete = value; }
        }
        public override String DataTypeName
        {
            get { return "Available Grade"; }
        }
        public override Func<String, MemberBom> DataLoader
        {
            get { return MemberBom.FetchById; }
        }
        private void LockField(BaseInputControl control)
        {
            control.IsReadOnly = ConfigurableBoolean.TrueEnforced;
        }
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            this.LockField(this.upgradePrice);

            this.gradeParentId.FieldValue = this.Request.QueryString["gradeParentId"];
            
        }
        protected override void PopulateControl()
        {
            base.PopulateControl();
            //this.main.DefaultValue = false;

            if (this.DataSource != null && !string.IsNullOrEmpty(this.DataSource.Id))
            {
                if (Membership.MemberBom.FetchById(this.DataSource.Id).GradeProd.Prices.Count > 0)
                {
                    var upgradePrice = Finance.Price.FetchAllByProductId(this.DataSource.GradeProdId).Min(e => e.Amount);
                    //var upgradePrice = Membership.MemberBom.FetchById(this.DataSource.Id).GradeProd.Prices.
                    this.upgradePrice.FieldValue = Convert.ToInt32(upgradePrice).ToString();
                }
                else
                    this.upgradePrice.FieldValue = "0";
                // if the editing Grade is Default, shouldn't be allowed to Toggle.
                if (this.DataSource.Main == 1) this.LockField(this.main);
            }

            int availableGrades = Membership.MemberBom.FetchAllByProdParentIdId(this.Request.QueryString["gradeParentId"]).Count();
            if (availableGrades == 0) //  if there are no grades added to Membership Product
            {
                this.main.FieldValue = true; this.LockField(this.main);
            }
        }
        protected override void RegisterJavascript()
        {
            this.gradeProduct.ClientOnChange += @"
                if (this.getData() && (this.getValue() || '') != '') {
                    var data=this.getData();
                    if(!data.prod_price)
                        data.prod_price = 0;                  
                   document.getElementById('" + this.upgradePrice.ClientID + @"Field').value=data.prod_price;
                   document.getElementById('" + this.gradeId.ClientID + @"Field').value = data.prod_id;}";
                
        }
    }
}