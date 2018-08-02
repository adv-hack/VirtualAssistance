using Consensus.Contact;
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
    public partial class RelatedProductList : BaseListControl
    {
  
        #region fields


        /// <summary>
        ///     The ID of the parent object that the associate records are linked to.
        /// </summary>
        private String _productParentId;

        #endregion

        #region properties


        /// <summary>
        ///     Gets or sets the ID of the parent object that the associate records are linked to.
        /// </summary>
        public String ProductParentId
        {
            get { return _productParentId; }
            set { _productParentId = value; }
        }

        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Related Product List"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.RelatedProductListResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {

                return Query.Create()
                    .Select("PPX_ID") 
                    .Select("REL_PROD_ID")
                    .Select("REL_PROD_NAME")
                    .Select("REL_PROD_REF")
                    .Select("REL_SY_PRODUCT")
                    .Select("REL_PROD_TYPE")
                    .Select("PPX_NOTES")
                    .Select("PPX_PREREQ")
                    .Select("REL_TYPE")
                    .Select("uri")
                    .From(QuerySources.RelatedProducts)
                    .Where("PARENT_PROD_ID", QueryConditionTypes.Equal, this.ProductParentId)
                    .OrderBy("REL_TYPE", true).ThenBy("REL_PROD_NAME", true);
            }
        }

        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.DataTable.Json = "{ uri: \"learning/relatedproduct\", mastProdId: " + HttpUtility.JavaScriptStringEncode(this.ProductParentId, true) + " }";
        }

        #endregion

    }
}