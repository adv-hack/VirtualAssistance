using Consensus.Common;
using Consensus.Finance;
using Consensus.Learning;
using Consensus.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class SessionPriceDetail : BaseControl<SessionXref, String>
    {
        public override string DataTypeName
        {
            get { return "Price Record"; }
        }

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

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, SessionXref> DataLoader
        {
            get { return SessionXref.FetchById; }
        }
        protected override void OnInit(EventArgs e)
        {

            IEnumerable<PriceList> listPrices = PriceList.FetchAll();
            this.PriceName.DataSource = listPrices.Where(record => record.Status == 1);
            base.OnInit(e);
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            if (this.DataSource != null)
            {
                if (Learning.SessionXref.FetchAllBySessionId(this.DataSource.SessionId).Count() == 1)
                    AllowDelete = false;

                if (this.DataSource.BlockPrice > 0)
                {
                    this.UnitPrice.FieldValue = this.DataSource.BlockPrice.ToString();
                    this.PriceType.FieldValue = "1"; //Block price
                }
                else if (this.DataSource.Member == 1)
                    this.PriceType.FieldValue = "2";//Member
                else
                    this.PriceType.FieldValue = "0"; //Standard
            }            
        }

        protected override void RegisterJavascript()
        {
            this.PriceName.ClientOnChange = this.ClientID + "PopulatePriceListDetails.Update(); $('#" + this.PlName.ClientID + @"Field').val(this.options[this.selectedIndex].innerText);";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID, "var " + this.ClientID +   "PopulatePriceListDetails = new PopulatePriceListDetails('" + this.ValidFrom.ClientID + "Group', '" + this.ValidUntil.ClientID + "Group', '" + this.CurrType.ClientID + "Field', '" + this.PriceName.ClientID + "Field', '" + VirtualPathUtility.ToAbsolute("~/rest") + "')", true);
        }
        

    }
}