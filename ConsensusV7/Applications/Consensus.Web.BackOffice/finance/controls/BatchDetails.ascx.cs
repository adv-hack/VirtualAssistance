using Consensus.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class BatchDetails : BaseControl<Batch, String>
    {
        #region Properties
        public override String DataTypeName
        {
            get { return "Batch"; }
        }
        #endregion


        #region Methods
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            this.SellingCompany.DataSource = Common.SellingCompany.FetchAll();
            //set defaults
            if (this.DataSource != null || !string.IsNullOrEmpty(this.DataSource.Id))
            {
                this.Description.FieldValue = this.DataSource.BatchEcId.Title ?? this.DataSource.BatchDiId.Title ?? this.DataSource.Procedure;
                this.SellingCompany.FieldValue = this.DataSource.SellingCompanyId;
                this.BatchStart.FieldValue = String.Format("{0:G}", this.DataSource.BatchStartedDate);
                this.BatchFinish.FieldValue = String.Format("{0:G}", this.DataSource.BatchFinishedDate);
            }
        }
        #endregion
    }
}