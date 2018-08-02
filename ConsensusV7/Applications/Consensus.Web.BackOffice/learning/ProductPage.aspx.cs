using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Web.BackOffice.crm;

namespace Consensus.Web.BackOffice.learning
{
    public partial class ProductPage : BaseStandardPage<Product, String>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Product - " + this.Data.Name; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "new_product"; }
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
            
            this.ProductDetails.DataSource = this.Data;
            this.FinanceDetails.DataSource = this.Data;
            this.OnlineDetails.DataSource = this.Data;
            this.RelationshipsList.ProductParentId = this.Data.Id;
            this.PricesList.PriceParentId = this.Data.Id;
            this.PricesList.ParentSyProduct = "0";
            this.PacksList.PackParentId = this.Data.Id;
            this.PacksList.ParentSyProduct = "0";
            this.SelectionGroupList.ParentId = this.Data.Id;
            this.SelectionGroupList.Type = SelectionGroupList.SelectionGroupMode.Product;
            this.ProfileList.ProfileParentId = this.Data.Id;
            this.ProfileList.ProfileMode = ProfileList.ProfileListMode.PROF_PROD_ID;
        }
        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }
        #endregion
    }
}