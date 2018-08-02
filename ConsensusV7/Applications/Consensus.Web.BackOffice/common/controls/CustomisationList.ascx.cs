using Consensus.Web.BackOffice.assets.templates;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice
{
    public partial class CustomisationList : BaseListControl
    {
        public override string DataTypeName
        {
            get { return "Customisation"; }
        }

        public override DataTable DataTable
        {
            get { return this.CustomisationDataTable; }
        }

        public override Object DataSource
        {
            get { return null; }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if (Request.QueryString["bcf"] == "1")
            {
                DataTable.CanCreate = false;
                ColIsCustomField.Visible = false;
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            (this.Page.Master as Popup).CustomiseButton.Visible = false;
        }
    }
}