using Consensus.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance
{
    public partial class BatchPage : BaseStandardPage<Batch, String>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Batch - " + this.Data.Id; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "downloads"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, Batch> DataLoader
        {
            get { return Batch.FetchById; }
        }
        /// <summary>
        /// Gets the delegated method for creating the API object that is presented within the page
        /// </summary>
        //public override Func<Batch> DataCreator
        //{
        //    get
        //    {
        //        return Batch.Create;
        //    }
        //}
        #endregion
        #region Methods

        protected override void PopulateControls()
        {
            base.PopulateControls();
            this.BatchDetail.DataSource = this.Data;
            this.BatchRecordList.BatchId = this.Data.Id;

            this.PopulateSideBar("javascript:ReRunBatch('" + this.Data.Id + "');", "Re-run  batch");
            SetSendPackSidebarOption();
        }

        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}