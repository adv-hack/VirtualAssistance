using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class SessionDetails : BaseControl<BillOfMaterial, String>
    {
        /// <summary>
        ///     The ID of the parent object that the records are linked to.
        /// </summary>
        private String _parentProductId;

        /// <summary>
        ///     Gets or sets the Id of the parent event that the session records are linked to.
        /// </summary>
        public String ParentProductId
        {
            get { return _parentProductId; }
            set { _parentProductId = value; }
        }

        public override String DataTypeName
        {
            get { return "Session"; }
        }


        public override Func<String, BillOfMaterial> DataLoader
        {
            get
            {
                return Learning.BillOfMaterial.FetchById;
            }
        }
        protected override void PopulateControl()
        {

            base.PopulateControl();


        }
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            this.SelectGroup.DataSource = Learning.ProdSelectGroup.FetchAllByProdIdId(this.ParentProductId);
            
            if (this.Id.FieldValue == "")
            {
                this.Chargeable.FieldValue = true;
                this.ShowAttLog.FieldValue = true;
                this.ShowSales.FieldValue = true;
                // NFPCCB-18478 Field 'Free places' is not updated as per 'Max Places'
                this.Real.FieldValue = "1";
                this.Element.FieldValue = "1";
                this.Session.FieldValue = "1";
            }
        }
    }
}