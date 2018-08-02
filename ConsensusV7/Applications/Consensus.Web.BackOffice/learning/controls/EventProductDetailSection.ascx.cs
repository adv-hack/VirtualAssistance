using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class EventProductDetailSection : BaseControl<EventProduct, Int32>
    {
        /// <summary>
        ///     The ID of the parent object that the records are linked to.
        /// </summary>
        private String _parentEventId;

        /// <summary>
        ///     Gets or sets the Id of the parent event that the session records are linked to.
        /// </summary>
        public String ParentEventId
        {
            get { return _parentEventId; }
            set { _parentEventId = value; }
        }

        public override String DataTypeName
        {
            get { return "Event Product"; }
        }

        public override Func<Int32, EventProduct> DataLoader
        {
            get
            {
                return EventProduct.FetchById;
            }
        }
        protected override void PopulateControl()
        {

            base.PopulateControl();
           
        }
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            if (this.Id.FieldValue == "")
            {
                this.Element.FieldValue = true;
                this.InvoicePrint.FieldValue = true;
                this.ShowSales.FieldValue = true;
            }

            this.SelectionGroup.DataSource = CourseSelectGroups.FetchAllByEventId(this.ParentEventId);

            this.ProductEvent.ClientOnChange = @"
                if (this.getData())
                    $('#" + this.VATCode.ClientID + "Field').val(this.getData().prod_vat_code); ";
        }
    }
}