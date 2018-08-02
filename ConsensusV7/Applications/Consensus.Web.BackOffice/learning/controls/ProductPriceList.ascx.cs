using Consensus.Learning;
using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning
{
    public partial class ProductPriceList : BaseListControl
    {
        #region enums

        /// <summary>
        ///     Enumerates the different modes that the price list can be used for.
        /// </summary>
        public enum PriceListMode
        {
            Product,
            Session
        }

        #endregion
        
        #region fields

        /// <summary>
        ///     The ID of the parent object that the price records are linked to.
        /// </summary>
        private String _priceproductId;

        /// <summary>
        ///     The product type.
        /// </summary>
        private String _ParentSyProduct;

        private PriceListMode _priceMode;

        #endregion
        #region properties

        /// <summary>
        ///     Gets the SyProduct of the parent object that the price records are linked to.
        /// </summary>
        public String ParentSyProduct
        {
            get { return _ParentSyProduct; }
            set { _ParentSyProduct = value; }
        }

        /// <summary>
        ///    Gets or sets the PL Type to screenObjectDisplay
        /// </summary>
        public PriceListMode PriceMode
        {
            get { return _priceMode; }
            set { _priceMode = value; }
        }

        /// <summary>
        ///     Gets or sets the ID of the parent object that the price records are linked to.
        /// </summary>
        public String PriceParentId
        {
            get { return _priceproductId; }
            set { _priceproductId = value; }
        }

        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get
            {
                switch (this.PriceMode)
                {
                    case PriceListMode.Session: return "Session Prices List";
                    default: return "Prices List";
                }
            }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.PriceListResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                QuerySources querySource = QuerySources.Prices;
                string idParam = "PRS_PROD_ID";

                switch (this.PriceMode)
                {
                    case PriceListMode.Session:
                        querySource = QuerySources.SessionPrices;
                        idParam = "SXREF_ACT_ID";
                        break;
                    default:
                        break;
                }

                return Query.Create()
                    .Select("PRS_ID")
                    .Select(idParam, "PARENT_ID")
                    .Select("PL_NAME")
                    .Select("PRS_VALID_FROM")
                    .Select("PRS_VALID_UNTIL")
                    .Select("PRS_REGION")
                    .Select("PRS_QTY_MIN")
                    .Select("PRS_QTY_MAX")
                    .Select("PRS_START")
                    .Select("PRS_END")
                    .Select("PRS_TYPE")
                    .Select("PRS_CURR_TYPE")
                    .Select("PRS_PRICE")
                    .Select("PRS_COST_PRICE")
                    .Select("PRS_RETAIL_PRICE")
                    .Select("PRS_VALID_DATE")
                    .Select("uri")
                    .From(querySource)
                    .Where(idParam, QueryConditionTypes.Equal, this.PriceParentId)
                    .OrderBy("PRS_VALID_UNTIL", true)
                    .ThenBy("PL_NAME", true);
                }             
            }

        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            switch (this.PriceMode)
            {
                case PriceListMode.Session:
                    this.DataTable.Url += "sessionpricedetail&id={{Id}}";
                    this.DataTable.Json = "{ uri: \"learning/sessionxref\", sessionId: " + HttpUtility.JavaScriptStringEncode(this.PriceParentId, true) + " }";
                    break;
                default:
                    this.DataTable.Url += "productpricedetail&id={{Id}}";
                    this.DataTable.Json = "{ uri: \"finance/price\", productId: " + HttpUtility.JavaScriptStringEncode(this.PriceParentId, true) + " }";
                    break;
            }
            this.DataTable.Url += "&productType=" + this.ParentSyProduct + "&listType=" + this.PriceMode;


        }

        #endregion
    }
}