using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class CourseDetails : BaseControl<Product, String>
    {
        public override String DataTypeName
        {
            get { return "Course"; }
        }
        protected override void PopulateControl()
        {
            base.PopulateControl();
            this.GenericProduct.DataSource = this.DataSource;
            this.SyProduct.FieldValue = "1";
            if (this.DataSource != null && this.DataSource.Id != null)
            {
                this.MinAttend.FieldValue = this.DataSource.MinAttend.Value.ToString("N0");
                this.MaxAttend.FieldValue = this.DataSource.MaxAttend.Value.ToString("N0");
            }
        }

        protected override void RegisterJavascript()
        {
            this.Location.ClientOnChange += @"
                if (this.getData() && (this.getValue() || '') != '') {
                    var data=this.getData();            
                   " + this.Organisation.ClientID + @".setValue(data.organisation.id,data.organisation.name);}";            

        }
    }
}