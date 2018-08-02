using Consensus.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.reporting
{
    public partial class DataImportPage : BaseStandardPage<Batch, String>
    {
        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Data Import - " + this.Data.Id; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "uploads"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, Batch> DataLoader
        {
            get { return Batch.FetchById; }
        }

        public override Func<Batch> DataCreator
        {
            get { return Batch.Create; }
        }

        protected override void PopulateControls()
        {
            base.PopulateControls();
            this.DataImportDetail.DataSource = this.Data;
            this.ImportDataRecordList.BatchId = this.Data.Id;           
            SetSendPackSidebarOption();
        }

        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }
    }
}