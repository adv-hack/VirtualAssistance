using Consensus.Learning;
using Consensus.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class ProductSelectionGroupDetail : BaseControl<ProdSelectGroup, Int32>
    {
        public override string DataTypeName
        {
            get { return "Selection Group"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<Int32, ProdSelectGroup> DataLoader
        {
            get { return ProdSelectGroup.FetchById; }
        }

        protected override void OnPreRender(EventArgs e)
        {
            if (this.DataSource == null)
            {
                //set defaults
                this.Minimum.FieldValue = "0";
                this.Maximum.FieldValue = "99";
            }
            base.OnInit(e);
        }
        protected override void PopulateControl()
        {
            base.PopulateControl();

        }

    }
}