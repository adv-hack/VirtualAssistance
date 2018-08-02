using Consensus.Learning;
using System;

namespace Consensus.Web.BackOffice.membership
{
    public partial class MembershipGradesPage : BaseStandardPage<Product, String>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Grade - " + this.Data.Name; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "rating"; }
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

        #region Methods
        protected override void PopulateControls()
        {
            this.MembershipGradeDetails.DataSource = this.Data;
            this.OnlineDetails.DataSource = this.Data;

            this.PricesList.PriceParentId = this.Data.Id;
            this.PricesList.ParentSyProduct = "17";
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }
        #endregion
    }
}