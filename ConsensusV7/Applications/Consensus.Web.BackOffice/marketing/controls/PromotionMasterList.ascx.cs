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
    public partial class PromotionMasterList : BaseListControl
    {
        #region fields
        
        /// <summary>
        ///     The ID of the parent object that the associate records are linked to.
        /// </summary>
        private String _promotionMasterParentId;

        #endregion  
      
        #region properties
        
        /// <summary>
        ///     Gets or sets the ID of the parent object that the opportunity records are linked to.
        /// </summary>
        public String PromotionMasterParentId
        {
            get { return _promotionMasterParentId; }
            set { _promotionMasterParentId = value; }
        }

        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Promotion Master"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.PromotionMasterResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("PM_MST_ID")
                    .Select("PM_MST_NAME")
                    .Select("PM_MST_START_DATE")
                    .Select("PM_MST_END_DATE")
                    .Select("PM_MST_REGION")
                    .Select("PM_MST_TYPE_DESC")
                    .Select("PM_MST_COURSE_ID")
                    .Select("COURSE_NAME", "Event")
                    .Select("uri")
                    .From(QuerySources.PromotionMasters)
                    .Where("PM_MST_CMP_ID", QueryConditionTypes.Equal, this._promotionMasterParentId)
                    .OrderBy("PM_MST_START_DATE", true)
                    .ThenBy("PM_MST_NAME", true);
            }
        }

        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.DataTable.Json = "{ uri: \"marketing/promotionmaster\", CmpIdId: " + HttpUtility.JavaScriptStringEncode(this._promotionMasterParentId, true) + " }";
        }

        #endregion
    }
}