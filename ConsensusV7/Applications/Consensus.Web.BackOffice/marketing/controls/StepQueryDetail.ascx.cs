using Consensus.Marketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Security;

namespace Consensus.Web.BackOffice.marketing.controls
{
    public partial class StepQueryDetail : BaseControl<SaqQueryStep, int>
    {        
        public override string DataTypeName
        {
            get { return "Query Step"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<int, SaqQueryStep> DataLoader
        {
            get { return SaqQueryStep.FetchById; }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            List<object> lst = new List<object>();
            lst.Add("Partition");
            lst.Add("Include");
            lst.Add("Exclude");
            lst.Add("Match");

            this.Link.DataSource = lst;
        }

        protected override void RegisterJavascript()
        {
            this.Step.ClientOnChange = @"
                if (this.getData() && (this.getValue() || '') != '') {
                    if (this.getData().link_default && this.getData().link_default.length != 0) {
                        var sDefault = this.getData().link_default;
                        $('#" + this.Link.ClientID + @"Field').val(sDefault);
                    } else {
                        $('#" + this.Link.ClientID + @"Field').val(null);
                    }
                }";
        }
    }
}