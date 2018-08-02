using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class ResourceTemplateDetail : BaseControl<TemplateResource, String>
    {
        public override String DataTypeName
        {
            get { return "Resource"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, TemplateResource> DataLoader
        {
            get { return TemplateResource.FetchById; }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
        }

        protected override void RegisterJavascript()
        {
            this.Product.ClientOnChange = "$('#" + this.ProductRef.ClientID + "Field').val(this.getData() ? this.getData().prod_ref : '');";
        }
    }
}