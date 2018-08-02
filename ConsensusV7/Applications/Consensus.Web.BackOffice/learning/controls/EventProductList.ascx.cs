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
    public partial class EventProductList : BaseListControl
    {

        #region fields

        /// <summary>
        ///     The ID of the parent event that the product records are linked to.
        /// </summary>
        private String _eventId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the ID of the parent object that the records are linked to.
        /// </summary>
        public String EventId
        {
            get { return _eventId; }
            set { _eventId = value; }
        }

        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { 
                   return "Product List";
                }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.ProductListResults; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("EP_ID")
                    .Select("PROD_NAME")
                    .Select("PROD_REF")
                    .Select("PROD_ID")
                    .Select("EP_DELEGATE_QTY")
                    .Select("EP_QTY")
                    .Select("SXREF_MANDATORY")
                    .Select("EP_COURSE_ID")
                    .Select("CSG_NAME")
                    .Select("uri")
                    .From(QuerySources.EventProducts)
                    .Where("EP_COURSE_ID", QueryConditionTypes.Equal, this.EventId)
                    .And("PROD_SY_PRODUCT", QueryConditionTypes.NotEqual, ProductTypes.Exam)
                    .OrderBy("PROD_NAME", true);
            }
        }

        #endregion
        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.DataTable.Url += "&eventId=" + HttpUtility.UrlEncode(this.EventId);
            this.DataTable.Json = "{ uri: \"learning/eventproduct\", eventId: " + HttpUtility.JavaScriptStringEncode(this.EventId, true) + " , EPSessionXref: []}"; ;
        }

        #endregion
    }
}