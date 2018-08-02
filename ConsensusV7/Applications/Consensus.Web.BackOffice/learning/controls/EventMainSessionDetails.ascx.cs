using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class EventMainSessionDetails : BaseControl<Event, String>
    {
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

        }

        protected override void RegisterJavascript()
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID, @"
                function validateMaxPlaces(source, arguments) {
                var min = $('#" + this.MinPlaces.ClientID + @"Field').val();
                var max = $('#" + this.MaxPlaces.ClientID + @"Field').val();
                $('#" + this.MinPlaces.ClientID + @"Field').val(parseInt(min));
                $('#" + this.MaxPlaces.ClientID + @"Field').val(parseInt(max));
                arguments.IsValid = ((min.length == 0 && max.length == 0 ) || (min.length > 0 && parseInt(max) >= parseInt(min)));
              }

                function validateDates(source,arguments){
                var start = new Date ($('#" + this.StartDate.ClientID + @"Field').val());
                var end = new Date ($('#" + this.EndDate.ClientID + @"Field').val());
                arguments.IsValid = (end >= start);
            }", true);

        }
    }
}