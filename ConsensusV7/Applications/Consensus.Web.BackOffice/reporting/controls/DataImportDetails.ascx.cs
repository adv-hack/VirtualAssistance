using System;
using Consensus.Other;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.reporting.controls
{
    public partial class DataImportDetails : BaseControl<Batch, String>
    {
        public override String DataTypeName
        {
            get { return "Data Import"; }
        }
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            this.ImportTypeList.DataSource = Dataimports.FetchAll().Where(di => di.Active == 2);
            //set defaults
            if (this.DataSource != null)
            {
                this.ImportTypeList.FieldValue = Convert.ToString(this.DataSource.BatchDiIdId);
                this.BatchStart.FieldValue = String.Format("{0:G}", this.DataSource.BatchStartedDate);
                this.BatchFinish.FieldValue = String.Format("{0:G}", this.DataSource.BatchFinishedDate);
                if (!string.IsNullOrEmpty(this.DataSource.Id))
                {
                    this.ImportTypeList.IsReadOnly = Consensus.UserInterface.ConfigurableBoolean.TrueEnforced;
                }
                else
                {
                    this.ImportTypeList.IsReadOnly = Consensus.UserInterface.ConfigurableBoolean.FalseEnforced;
                }
            }

        }
    }
}