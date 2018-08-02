using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class ActivityTemplateDetails : BaseControl<BillOfMaterial, String>
    {
        private Boolean _allowDelete = true;

        public override bool AllowDelete
        {
            get { return _allowDelete; }
            set { _allowDelete = value; }
        }

        public override String DataTypeName
        {
            get { return "Activity"; }
        }
        protected override void PopulateControl()
        {

            base.PopulateControl();
            if (this.DataSource != null)
            {
                this.AllowDelete = this.DataSource.MainSession != 1;
            }


        }
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

        }
    }
}