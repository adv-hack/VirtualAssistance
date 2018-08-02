using Consensus.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership.controls
{

    public partial class MemberLocationDetail : BaseControl<MemberLocation, String>
    {
        /// <summary>
        ///     Sets if record can be deleted
        /// </summary>
        private Boolean _allowDelete = true;

        public override String DataTypeName
        {
            get { return "Member Location"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
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


        protected override void PopulateControl()
        {
            base.PopulateControl();
            
            
            if (this.DataSource != null && this.DataSource.Id != null)
            {
                this.Address.DataSource = this.DataSource.MailAddId;
                this.Address.OrganisationId = this.DataSource.OrgIdId;
                this.Address.PersonId = this.DataSource.Role.PersonId;

                this.LapseDate.Visible = this.DataSource.CancelDate.HasValue;
                if (this.DataSource.RenewLoc == 1)
                    this.RenewLoc.IsReadOnly = UserInterface.ConfigurableBoolean.True;

                if (this.DataSource.Product.MsGroup == 30)
                    this.TotalQty.FieldValue = (this.DataSource.MemberPeriod.Qty2.Value + this.DataSource.MemberPeriod.Qty3.Value + 1).ToString();
                else
                    this.TotalQty.FieldValue = (this.DataSource.MemberPeriod.Qty1.Value).ToString();

                this.AllowDelete = this.DataSource.RenewLoc != 1;
              
            }
            else
            {

                //New Location record - prepopulate values from Member Period
                string mepId = Request.QueryString["memberPeriodId"];
                if(mepId!="")
                {
                    MemberPeriod mep = MemberPeriod.FetchById(mepId);
                    this.StartDate.FieldValue = mep.Start;
                    this.EndDate.FieldValue = mep.End;
                    this.ProductId.FieldValue = mep.ProductId;
                    this.PriceListId.FieldValue = mep.PriceListId;

                    if (mep.Product.MsGroup == 30)
                        this.TotalQty.FieldValue = (mep.Qty2.Value + mep.Qty3.Value + 1).ToString();
                    else
                        this.TotalQty.FieldValue = (mep.Qty1.Value).ToString();
                }
                this.LapseDate.Visible = false;
            }
            
            this.Address.HideAddressContactInfo = true;

        }

        protected override void RegisterJavascript()
        {
            this.Contact.ClientOnChange = @"
                if ((this.getData() && this.getData().organisation && this.getData().organisation.id && this.getData().organisation.id.length != 0) || this.getData().organisation.id == '') {
                    " + this.Organisation.ClientID + @".setValue(this.getData().organisation.id, this.getData().organisation.name);
                    " + this.Address.ClientID + @".lockFields(this.getData().organisation.id,this.getData().address.id,this.getData().address.Line1, this.getData().address.Line2, this.getData().address.Line3, this.getData().address.town, this.getData().address.county, this.getData().address.postcode, this.getData().address.country);
                }";

            this.Organisation.ClientOnChange = @"
                var data = this.getData();
                if (data)
                    " + this.Address.ClientID + @".lockFields(data.org_id,data.add_id,data.addressLine1, data.addressLine2, data.addressLine3, data.town, data.county, data.postcode, data.country);
                else
                    " + this.Address.ClientID + @".unlockFields();";
        }
    }
}