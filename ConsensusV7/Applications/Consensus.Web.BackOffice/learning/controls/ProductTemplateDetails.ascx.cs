using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class ProductTemplateDetails : BaseControl<BillOfMaterial, String>
    {
        /// <summary>
        ///     Sets if record can be deleted
        /// </summary>
        private Boolean _allowDelete = true;

        /// <summary>
        ///     Sets if record can be deleted
        /// </summary>
        public override bool AllowDelete
        {
            get { return _allowDelete; }
            set { _allowDelete = value; }
        }

        public override String DataTypeName
        {
            get { return "Product"; }
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

            this.SelectGroup.DataSource = Learning.ProdSelectGroup.FetchAllByProdIdId(this.Request.QueryString["masterproductId"]);

            if (this.Id.FieldValue == "")
            {
                this.Chargeable.FieldValue = true;
                this.ShowSales.FieldValue = true;
            }
        }

        public override Func<String, BillOfMaterial> DataLoader
        {
            get { return BillOfMaterial.FetchById; }
        }
    }
}