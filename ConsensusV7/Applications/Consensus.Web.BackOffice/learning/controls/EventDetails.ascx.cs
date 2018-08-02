using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class EventDetails : BaseControl<Event, String>
    {
        public override String DataTypeName
        {
            get { return "Event"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();

            this.SellingCompanyName.DataSource = Common.SellingCompany.FetchAll();

            //this.PaymentSchedule.FieldValue = this.DataSource.PayScheduleHeader.Id.ToString();
            //this.PaymentSchedule.FieldText = this.DataSource.PayScheduleHeader.Description;

            //this.BookingTerms.FieldValue = this.DataSource.BookingTerms.Id;
            //this.BookingTerms.FieldText = this.DataSource.BookingTerms.Description;

            double availablePlaces = Convert.ToDouble((this.DataSource.FreePlaces * 100) / this.DataSource.MaxPlaces);
            this.Availability.FieldValue = Math.Round(availablePlaces, 0).ToString() + "%";

            //Can't select cancelled statuses - 90+
            //If event is cancelled, cant edit the status
            if (this.DataSource.StatusCode != null && Convert.ToInt32(this.DataSource.StatusCode.Substring(0, 2)) >= 90)
            {
                this.EventStatus.IsReadOnly = UserInterface.ConfigurableBoolean.True;
            }
            else
            {
                this.EventStatus.DataSource = Common.Code.FetchAllByType("COUST").Where(x => Convert.ToInt32(x.Value1.Substring(0, 2)) < 90);
            }

            this.CancellationDate.Visible = this.DataSource.CancellationDate.HasValue;
            this.CancellationReason.Visible = this.DataSource.CancellationDate.HasValue;
            this.UnrecoverableCancelationLoss.Visible = this.DataSource.CancellationDate.HasValue;

            // Set the cost codes to those applicable to the currently selected selling company
            this.CostCode.DataSource = Finance.CostCode.FetchAll().Where(costCode => String.IsNullOrEmpty(this.DataSource.SellingCompanyId) || String.Equals(costCode.SelcoSpIdId, this.DataSource.SellingCompanyId, StringComparison.OrdinalIgnoreCase));
            this.CostCode.DataBind();

            if (DataSource.Id != null)
            {
                //reformat places fields as integers
                this.MaxPlaces.FieldValue = this.DataSource.MaxPlaces.Value.ToString("N0");
                this.MinPlaces.FieldValue = this.DataSource.MinPlaces.Value.ToString("N0");
                this.FreePlaces.FieldValue = this.DataSource.FreePlaces.Value.ToString("N0");
                this.ConfirmedPlaces.FieldValue = this.DataSource.ConfirmedPlaces.Value.ToString("N0");
                this.ProvisionalPlaces.FieldValue = this.DataSource.ProvisionalPlaces.Value.ToString("N0");
                this.WaitlistPlaces.FieldValue = this.DataSource.WaitlistPlaces.Value.ToString("N0");
                this.CancelledPlaces.FieldValue = this.DataSource.CancelledPlaces.Value.ToString("N0");
            }

        }

        protected override void RegisterJavascript()
        {
            this.CourseName.ClientOnChange = this.ClientID + "RefreshProductDetails.Update(); ";

            this.SellingCompanyName.ClientOnChange = "updateCostCode('" + this.SellingCompanyName.ClientID + "', '" + this.CostCode.ClientID + "');";
            this.CommissionedRole.ClientOnChange = @"
                if (this.getData() && this.getData().organisation && this.getData().organisation.id && this.getData().organisation.id.length != 0) {
                    " + this.Commissioned.ClientID + @".setValue(this.getData().organisation.id, this.getData().organisation.name);
                }";

            this.Organisation.ClientOnChange = @"
                if (this.getData())
                    " + this.Address.ClientID + @".lockFields(this.getData().org_id,this.getData().add_id,this.getData().addressLine1, this.getData().addressLine2, this.getData().addressLine3, this.getData().town, this.getData().county, this.getData().postcode, this.getData().country);
                else
                    " + this.Address.ClientID + @".unlockFields();";

            if (this.DataSource.Id != null)
            {
                this.CourseName.IsReadOnly = UserInterface.ConfigurableBoolean.True;
                this.StartDate.IsReadOnly = UserInterface.ConfigurableBoolean.True;
                this.StartTime.IsReadOnly = UserInterface.ConfigurableBoolean.True;
                this.EndDate.IsReadOnly = UserInterface.ConfigurableBoolean.True;
                this.EndTime.IsReadOnly = UserInterface.ConfigurableBoolean.True;
            }

            this.Page.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID, "var " + this.ClientID + "RefreshProductDetails = new RefreshProductDetails( '" + VirtualPathUtility.ToAbsolute("~/rest") + "');", true);
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID + "Js", String.Format("var {0} = addressField();", this.Address.ClientID), true);

            this.Organisation.ClientOnChange = @"
                if (this.getData()) {
                    $('#" + this.Address.ClientID + @"Field').val(this.getData().add_mailstring);
                    $('#" + this.AddressId.ClientID + @"Field').val(this.getData().add_id);
                    }
                else    {
                    $('#" + this.Address.ClientID + @"Field').val('');
                    $('#" + this.AddressId.ClientID + @"Field').val('');
                    }";

            this.Location.ClientOnChange += @"
                if (this.getData() && (this.getValue() || '') != '') {
                    var data=this.getData();        
                    " + this.Organisation.ClientID + @".setValue(data.organisation.id,data.organisation.name);            
                    $('#" + this.Address.ClientID + @"Field').val(data.address.add_mailstring);
                    $('#" + this.AddressId.ClientID + @"Field').val(data.address.add_id);
                    " + this.Contact.ClientID + @".setValue(data.contact.prole_id,data.contact.prole_name);                     
                    }";

            this.Manager.ClientOnChange += @"
               if (this.getData() && (this.getValue() || '') != '') {
                    var data=this.getData();     
                    " + this.Manager.ClientID + @".setValue(data.pnId,this.getText());
                }
            ";
        }

    }
}