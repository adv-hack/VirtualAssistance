using Consensus.Learning;
using System;

namespace Consensus.Web.BackOffice.membership
{
    public partial class SpecialistGroupPage : BaseStandardPage<Product, String>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Specialist Group - " + this.Data.Name; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "user_group_woman_woman"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, Product> DataLoader
        {
            get { return Product.FetchById; }
        }

        /// <summary>
        ///     Gets the delegated method for creating the API object that is presented within the page.
        /// </summary>
        public override Func<Product> DataCreator
        {
            get { return Product.Create; }
        }

        #endregion

        #region methods

        protected override void PopulateControls()
        {
            this.SpecialistGroupDetails.DataSource = this.Data;
            this.OnlineDetails.DataSource = Data;
            this.PricesList.PriceParentId = this.Data.Id;
            this.PricesList.ParentSyProduct = "16";
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