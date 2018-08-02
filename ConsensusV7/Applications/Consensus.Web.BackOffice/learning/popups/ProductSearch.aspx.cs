using Consensus.Learning;
using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.popups
{
    public partial class ProductSearch : BasePopupSearchPage
    {
        #region fields

        /// <summary>
        ///     The list of product types that can be searched for.
        /// </summary>
        private ProductTypes[] _productTypes;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the list of product types that can be searched for.
        /// </summary>
        public ProductTypes[] ProductSyTypes
        {
            get
            {
                if (_productTypes == null && !String.IsNullOrEmpty(this.Request.QueryString["syProduct"]))
                    _productTypes = this.GetProductTypesFromQueryString().OrderBy(enumeration => enumeration.ToString()).ToArray();
                if (_productTypes == null || _productTypes.Length == 0)
                    _productTypes = Enum.GetValues(typeof(ProductTypes)).OfType<ProductTypes>().OrderBy(enumeration => enumeration.ToString()).ToArray();

                return _productTypes;
            }
        }

        /// <summary>
        ///     Gets the title of the popup page
        /// </summary>
        public override String DialogTitle
        {
            get { return "Product Search"; }
        }

        /// <summary>
        ///     Gets the width of the popup page
        /// </summary>
        public override UInt32 DialogWidth
        {
            get { return 800; }
        }

        /// <summary>
        ///     Gets the table which displays the search result.
        /// </summary>
        protected override DataTable SearchResultTable
        {
            get { return this.SearchResult; }
        }


        #endregion

        #region page cycle

        protected override void OnInit(EventArgs eventArguments)
        {
            base.OnInit(eventArguments);
            
            // Get the list of product types that can be searched for.
            this.ProductType.DataSource = this.ProductSyTypes.Select(e => new { Text = e.ToString(), Value = (Int32)e }).ToList();
        }

        #endregion

        #region methods

        /// <summary>
        ///     Gets the parameterised search procedure.
        /// </summary>
        protected override ISearchesRunnable GetSearch()
        {
            return Searches.Search.Create(SearchTypes.SearchProduct)
                .AddParameter("@PA_PROD_ID", null)
                .AddParameter("@PA_PROD_NAME", this.Name.FieldValue)
                .AddParameter("@PA_PROD_REF", this.Ref.FieldValue)
                .AddParameter("@PA_PROD_TYPE", this.Type.FieldValue)
                .AddParameter("@PA_PROD_CATEGORY", this.Category.FieldValue)
                .AddParameter("@PA_PROD_GROUP", this.Group.FieldValue)
                .AddParameter("@PA_PROD_SY_PRODUCT", this.ProductType.FieldValue.TrimOrNullify() ?? String.Join("|", this.ProductSyTypes.Select(e => (Int32)e)))
                .AddParameter("@PA_PROD_STATE", 1);
        }

        /// <summary>
        ///     Pre-populates the search fields.
        /// </summary>
        protected override void SetSearch(String value)
        {
            this.Name.FieldValue = value;
        }

        protected IEnumerable<ProductTypes> GetProductTypesFromQueryString()
        {
            String[] queryStringValues = this.Request.QueryString["syProduct"].Split(',');
            foreach (String queryStringValue in queryStringValues)
            {
                ProductTypes productType;
                if (Enum.TryParse<ProductTypes>(queryStringValue, true, out productType))
                    yield return productType;
            }
        }

        private object PopulateSyProductList()
        {
            List<KeyValuePair<String, String>> syProducts = new List<KeyValuePair<String, String>>();

            syProducts.Add(new KeyValuePair<string, string>("Product", "0"));
            syProducts.Add(new KeyValuePair<string, string>("Course", "1"));
            syProducts.Add(new KeyValuePair<string, string>("Training Room", "2"));
            syProducts.Add(new KeyValuePair<string, string>("Accomodation", "3"));
            syProducts.Add(new KeyValuePair<string, string>("Resource", "4"));
            syProducts.Add(new KeyValuePair<string, string>("Prepay", "5"));
            //syProducts.Add(new KeyValuePair<string, string>("Unknown", "6"));
            syProducts.Add(new KeyValuePair<string, string>("Conference", "7"));
            syProducts.Add(new KeyValuePair<string, string>("E-Learning", "8"));
            syProducts.Add(new KeyValuePair<string, string>("Publication", "9"));
            syProducts.Add(new KeyValuePair<string, string>("Membership", "10"));
            syProducts.Add(new KeyValuePair<string, string>("Hire Product", "11"));
            //syProducts.Add(new KeyValuePair<string, string>("Function", "12"));
            syProducts.Add(new KeyValuePair<string, string>("Meal", "13"));
            //syProducts.Add(new KeyValuePair<string, string>("Pitch Type Sales Band", "14"));
            //syProducts.Add(new KeyValuePair<string, string>("Voucher", "15"));
            syProducts.Add(new KeyValuePair<string, string>("Specialist Group", "16"));
            syProducts.Add(new KeyValuePair<string, string>("Membership Grade", "17"));
            //syProducts.Add(new KeyValuePair<string, string>("Unknown", "18"));
            syProducts.Add(new KeyValuePair<string, string>("Scheme", "19"));
            syProducts.Add(new KeyValuePair<string, string>("Appointment", "20"));
            syProducts.Add(new KeyValuePair<string, string>("Exam", "21"));
            syProducts.Add(new KeyValuePair<string, string>("Delivery", "22"));
            syProducts.Add(new KeyValuePair<string, string>("3rd party products", "23"));
            syProducts.Add(new KeyValuePair<string, string>("Discount", "24"));
            syProducts.Add(new KeyValuePair<string, string>("CBA", "25"));
            syProducts.Add(new KeyValuePair<string, string>("Assessments", "27"));
            syProducts.Add(new KeyValuePair<string, string>("Donation", "29"));

            return syProducts;
        }

        #endregion
    }
}