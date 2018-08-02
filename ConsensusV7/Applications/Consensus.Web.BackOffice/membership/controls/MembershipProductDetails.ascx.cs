using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership.controls
{
    public partial class MembershipProductDetails : BaseControl<ProductMembership>
    {
        public override string DataTypeName
        {
            get { return "Membership Product"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.RenewalDay.DataSource = PopulateDayList();

            if (this.DataSource.Id == null)
            {
                //set defaults
                this.SyProduct.FieldValue = "10";
                this.CollectionFrequency.FieldValue = "4";
                this.Installments.FieldValue = "1";
            }
            else
            {
                this.GenericProduct.DataSource = Product.FetchById(DataSource.Id);
            }
            
        }

        private object PopulateDayList()
        {
            List<KeyValuePair<String, String>> days = new List<KeyValuePair<String, String>>();
            for(int i=1;i<=31;i++)
            {
                string day = i.ToString();
                days.Add(new KeyValuePair<string, string>(day, day));
            }
            return days;
        }
    }
}