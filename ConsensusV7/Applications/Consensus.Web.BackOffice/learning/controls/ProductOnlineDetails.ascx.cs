using Consensus.Learning;
using System;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class ProductOnlineDetails : BaseControl<Product, String>
    {
        public override String DataTypeName
        {
            get { return "Online"; }
        }
        protected override void PopulateControl()
        {
            base.PopulateControl();
            if (DataSource == null)
            {
                if (DataId != null)
                    DataSource = Product.FetchById(DataId);
            }

        }

    }
}