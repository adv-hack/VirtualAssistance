using Consensus.Searches;
using Consensus.Document;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.document
{
    public partial class ProductPackList : BaseListControl
    {
        #region fields

        /// <summary>
        ///     The ID of the parent object that the profile records are linked to.
        /// </summary>
        private String _packParentId;
        /// <summary>
        ///     The product type.
        /// </summary>
        private String _ParentSyProduct;


        #endregion


        #region properties


        /// <summary>
        ///     Gets or sets the ID of the parent object that the opportunity records are linked to.
        /// </summary>
        public String PackParentId
        {
            get { return _packParentId; }
            set { _packParentId = value; }
        }


        /// <summary>
        ///     Gets the SyProduct of the parent object that the price records are linked to.
        /// </summary>
        public String ParentSyProduct
        {
            get { return _ParentSyProduct; }
            set { _ParentSyProduct = value; }
        }


        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Pack list"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.ProductPackListResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                IQueryConditionableAnd query = Query.Create()
                    .Select("PPA_ID")
                    .Select("PPA_PROD_ID")
                    .Select("PACK_NAME", "Pack")
                    .Select("PPA_TYPE", "Type")
                    .Select("PPA_SUPPRESS", "Suppress")
                    .Select("uri")
                    .From(QuerySources.ProductPacks)
                    .Where("PPA_PROD_ID", QueryConditionTypes.Equal, this.PackParentId);
         
                return query.OrderBy("PACK_NAME", true);
            }

        }
        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {


            base.OnLoad(e);
            this.DataTable.Url += "&productType=" + this.ParentSyProduct;
            this.DataTable.Json = "{ uri: \"document/packproduct\", productId: " + HttpUtility.JavaScriptStringEncode(this.PackParentId, true) + " }";
            }
        }

        #endregion

 }