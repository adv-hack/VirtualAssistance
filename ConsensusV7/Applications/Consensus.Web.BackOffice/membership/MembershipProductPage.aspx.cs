using Consensus.Learning;
using System;

namespace Consensus.Web.BackOffice.membership
{
    public partial class MembershipProductPage : BaseStandardPage<ProductMembership, String>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Membership Product - " + Data.Name; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "renew_subscription"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, ProductMembership> DataLoader
        {
            get { return ProductMembership.FetchById; }
        }

        /// <summary>
        ///     Gets the delegated method for creating the API object that is presented within the page.
        /// </summary>
        public override Func<ProductMembership> DataCreator
        {
            get { return ProductMembership.Create; }
        }

        #endregion

        #region methods

        protected override void PopulateControls()
        {
            ProductDetails.DataSource = Data;
            PackDetails.DataSource = Data;
            PricesList.PriceParentId = Data.Id;
            PricesList.ParentSyProduct = "10";
            GradesList.GradeParentId = Data.Id;
            OnlineDetails.DataSource = Data.ConvertTo<Product>();
            OnlineDetails.ID = Data.Id;
        }

        protected override void PopulateLinks()
        {
            PopulateLink(BottomTabControl);
        }

        #endregion
    }
}