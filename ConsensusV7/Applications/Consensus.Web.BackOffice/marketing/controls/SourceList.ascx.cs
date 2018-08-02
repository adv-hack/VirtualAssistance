using Consensus.Contact;
using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.marketing
{
    public partial class SourceList : BaseListControl
    {
      
        #region properties
        
        /// <summary>
        ///     Gets or sets the ID of the parent object that the opportunity records are linked to.
        /// </summary>
        public String PromotionParentId { get; set; }

        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Source Code"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.SourceResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("PM_ID")
                    .Select("PM_MST_ID") // Note, this field is PM_CMP_ID in the database, but it points at Promotion_Master.PM_MST_ID, not Campaign.CMP_ID, so it is renamed in the view.
                    .Select("PM_NAME")
                    .Select("PM_START_DATE")
                    .Select("PM_CHANNEL")
                    .Select("PM_MEDIA_NAME")
                    .Select("PM_CURRENT")
                    .Select("uri")
                    .From(QuerySources.Promotions)
                    .Where("PM_MST_ID", QueryConditionTypes.Equal, this.PromotionParentId)
                    .OrderBy("PM_START_DATE", true)
                    .ThenBy("PM_NAME", true);
            }
        }

        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.DataTable.Json = "{ uri: \"marketing/promotion\", PromotionMasterId: " + HttpUtility.JavaScriptStringEncode(this.PromotionParentId, true) + " }";
        }

        #endregion
    }
}