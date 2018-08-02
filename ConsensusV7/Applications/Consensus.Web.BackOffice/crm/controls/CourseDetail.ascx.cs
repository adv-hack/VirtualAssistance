using Consensus.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class CourseDetail : BaseControl<TrainProdXref, string>
    {
        #region Properties

        public override string DataTypeName
        {
            get
            {
                return "Course";
            }
        }
        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, TrainProdXref> DataLoader
        {
            get { return TrainProdXref.FetchById; }
        }
        #endregion

        #region Methods

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            
            if(this.DataSource == null)
            {
                this.TrainerId.FieldValue = this.DataId;
            }
           
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
        }
        protected override void RegisterJavascript()
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID, @"  
                function validateDates(source,arguments){
                var start = $('#" + this.StartDate.ClientID + @"Field').val();
                var end = $('#" + this.EndDate.ClientID + @"Field').val();
                if(start != '' && end != '')
                {
                    arguments.IsValid = ((new Date(end)) >= (new Date(start)));
                }
            }", true);

        }
    }

    #endregion
}
