using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Searches;
using Consensus.Web.BackOffice.learning.controls;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class GiftAidClaimBatchList : BaseListControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region fields

        private int _giftaidclaimId;

        #endregion

        #region Properties

        public int GiftAidClaimId
        {
            get { return _giftaidclaimId; }
            set { _giftaidclaimId = value; }
        }

        public override Controls.DataTable DataTable
        {
            get { return this.GiftAidClaimBatchListResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("BAT_ID")
                    .Select("BAT_ADD_DATE")
                    .Select("BAT_STATUS")
                    .Select("BAT_RUN_D_T")
                    .Select("DatePortion")
                    .Select("TimePortion")
                    .Select("uri")
                    .From(QuerySources.GiftAidClaimBatches)
                    .Where("BATXR_RECORD_ID", QueryConditionTypes.Equal, GiftAidClaimId)
                    .OrderBy("BAT_ADD_DATE", true);
            }
        }

        public override string DataTypeName
        {
            get { return "Batch List"; }
        }
        #endregion
    }
}