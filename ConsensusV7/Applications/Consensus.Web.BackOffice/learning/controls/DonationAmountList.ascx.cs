using Consensus.Learning;
using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class DonationAmountList : BaseListControl
    {
        #region fields
        /// <summary>
        ///     The ID of the parent object that the records are linked to.
        /// </summary>
        private String _booking;


        #endregion
        #region properties
        /// <summary>
        ///     Gets or sets the Id of the parent object that the session records are linked to.
        /// </summary>
        public String Booking
        {
            get { return _booking; }
            set { _booking = value; }
        }



        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Donation List"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.AmountListResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("ELEM_ID")
                    .Select("PROD_REF")
                    .Select("ELEM_DESCRIPTION")
                    .Select("ELEM_STATUS")
                    .Select("ELEM_PROD_ID")
                    .Select("ELEM_GIFT_AID")
                    .Select("ELEM_COST_CODE")
                    .Select("ELEM_PRICE")
                    .Select("uri")
                    .From(QuerySources.DonationBookingLines)
                    .Where("ELEM_BOOK_ID", QueryConditionTypes.Equal, this.Booking)
                    .OrderBy("ELEM_DEL_ID", true)
                    .ThenBy("ELEM_GRP_ID", true)
                    .ThenBy("ELEM_MAIN_SESSION", false)
                    .ThenBy("ELEM_ELEM_ID", true);
            }
        }

        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        #endregion
    }
}