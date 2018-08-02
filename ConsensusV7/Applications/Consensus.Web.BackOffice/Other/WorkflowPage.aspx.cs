using Consensus.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.Other
{
    public partial class WorkflowPage : BaseStandardPage<Workflow, String>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Workflow - " + this.Data.Name; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "workflow"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, Workflow> DataLoader
        {
            get { return Workflow.FetchById; }
        }

        /// <summary>
        ///     Gets the delegated method for creating the API object that is presented within the page.
        /// </summary>
        public override Func<Workflow> DataCreator
        {
            get { return Workflow.Create; }
        } 

        #endregion

        #region methods

        protected override void PopulateControls()
        {
            // Get the workflow to be displayed
            Workflow workflow = this.Data;

            this.WorkflowDetails.DataSource = workflow;

        }

        //protected override void PopulateLinks()
        //{
        //    this.PopulateLink(this.BottomTabControl);
        //}

        #endregion
    }
}