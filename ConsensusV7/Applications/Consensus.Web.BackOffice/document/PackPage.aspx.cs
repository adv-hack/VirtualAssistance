using Consensus.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.document
{
    public partial class PackPage : BaseStandardPage<Pack, String>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Pack - " + this.Data.Name; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "documents_folder"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, Pack> DataLoader
        {
            get { return Pack.FetchById; }
        }

        public override Func<Pack> DataCreator
        {
            get { return Pack.Create; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }
        protected override void PopulateControls()
        {
            base.PopulateControls();
            this.PackDetails.DataSource = this.Data;

            this.DocumentTemplateList.PackId = this.Data.Id;
            Packtype objPackType = Packtype.FetchAll().Where(s => s.Type == this.Data.PackType).FirstOrDefault();
            if (objPackType != null) this.DocumentTemplateList.PackType = objPackType.Type.ToString();

            this.PackEmailDetail.DataSource = this.Data;
        }
    }
}