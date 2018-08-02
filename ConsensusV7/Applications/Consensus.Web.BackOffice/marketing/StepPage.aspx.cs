using Consensus.Sales;
using Consensus.Marketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Web.BackOffice.marketing;

namespace Consensus.Web.BackOffice.marketing
{
    public partial class StepPage : BaseStandardPage<SaqStep, long>
    {
        public override Func<long, SaqStep> DataLoader
        {
            get { return SaqStep.FetchById; }
        }
        //private SaqQueryStep FetchByStringId(string id)
        //{
        //    return string.IsNullOrEmpty(id) ? SaqQueryStep.FetchById(Convert.ToInt32(id)) : null;
        //}

        public override Func<SaqStep> DataCreator
        {
            get { return SaqStep.Create; }
        }

        public override string DefaultTitle
        {
            get { return "Step - "+ this.Data.Name; }
        }
        public override string DefaultIcon
        {
            get
            {
                return "stack";
            }
        }

        protected override void PopulateControls()
        {
            base.PopulateControls();
            // Get the role to be displayed
            SaqStep step = this.Data;

            this.StepDetail.DataSource = step;

            this.StepParameterList.StepId = step.Id;
        }

        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }
    }
}