using Consensus.Learning;
using Consensus.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class EventSessionDetailSection : BaseControl<Session, String>
    {
        /// <summary>
        ///     The ID of the parent object that the records are linked to.
        /// </summary>
        private String _parentEventId;

        /// <summary>
        ///     Gets or sets the Id of the parent event that the session records are linked to.
        /// </summary>
        public String ParentEventId
        {
            get { return _parentEventId; }
            set { _parentEventId = value; }
        }

        public override String DataTypeName
        {
            get { return "Session"; }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            if (this.DataSource == null || this.DataSource.Id == null)
            {
                this.CourseName.IsReadOnly = UserInterface.ConfigurableBoolean.False;
                this.Element.FieldValue = true;
                this.ShowOnBooking.FieldValue = true;
            }
            else
            {
                this.MainSession.IsReadOnly = this.DataSource.SessionXrefMaster.MainSession == 1 ? UserInterface.ConfigurableBoolean.True : UserInterface.ConfigurableBoolean.False;
            }           
            if (this.DataSource !=null)
                this.BookedPlaces.FieldValue = (this.DataSource.MaxPlaces - this.DataSource.FreePlaces).ToString();


            this.SelectionGroup.DataSource = CourseSelectGroups.FetchAllByEventId(this.ParentEventId);

            this.CourseName.ClientOnChange = @"
                if (this.getData()){
                    $('#" + this.Name.ClientID + "Field').val(this.getData().prod_name); $('#" + this.VATCode.ClientID + "Field').val(this.getData().prod_vat_code); }";
            this.Real.FieldValue = "1";
            this.DataSource.SessionXrefMaster.Real = 1;
        }
        protected override void RegisterJavascript()
        {
            this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "EventSessionDetailSectionJs", @"
              function validateMaxPlaces(source, arguments) {
                var min = $('#" + this.MinPlaces.ClientID + @"Field').val();
                var max = $('#" + this.MaxPlaces.ClientID + @"Field').val();
                $('#" + this.MinPlaces.ClientID + @"Field').val(parseInt(min));
                $('#" + this.MaxPlaces.ClientID + @"Field').val(parseInt(max));
                arguments.IsValid = ((min.length == 0 && max.length == 0 ) || (min.length > 0 && parseInt(max) >= parseInt(min)));
              }
              function validateDates(source, arguments) {
                var start = new Date ($('#" + this.StartDate.ClientID + @"Field').val());
                var end = new Date ($('#" + this.EndDate.ClientID + @"Field').val());
                arguments.IsValid = (end >= start);
              }", true);
        }


    }
}