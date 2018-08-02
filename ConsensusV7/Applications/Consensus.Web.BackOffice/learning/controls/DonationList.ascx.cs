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
    public partial class DonationList : BaseListControl
    {
        #region enums

        /// <summary>
        ///     Enumerates the different modes that the donation list can be used for.
        /// </summary>
        public enum DonationSearchListMode
        {
            Opportunity,
            Person
        }

        #endregion

        #region fields
        /// <summary>
        ///     The ID of the parent object that the records are linked to.
        /// </summary>
        private String _parentid;

        /// <summary>
        ///     The mode that the associate list is be used for.
        /// </summary>
        private DonationSearchListMode _donationType;
        #endregion

        #region properties



        /// <summary>
        ///    Gets or sets the mode that the associate list is be used for.
        /// </summary>
        public DonationSearchListMode DonationType
        {
            get { return _donationType; }
            set { _donationType = value; }
        }

        /// <summary>
        ///     Gets or sets the Id of the parent object that the session records are linked to.
        /// </summary>
        public String ParentId
        {
            get { return _parentid; }
            set { _parentid = value; }
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
            get { return this.DonationListResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                switch (this.DonationType)
                {
                    case DonationSearchListMode.Person:
                        return Query.Create()
                            .Select("BOOK_ID")
                            .Select("ELEM_PROD_ID")
                            .Select("PROD_NAME")
                            .Select("PROD_REF")
                            .Select("BOOK_ADD_DATE")
                            .Select("ELEM_STATUS")
                            .Select("BOOKER_PN_ID")
                            .Select("INVOICE_PN_ID")
                            .Select("BOOKER_PROLE_PN_NAME")
                            .Select("INVOICE_PROLE_PN_NAME")
                            .Select("ELEM_COST_CODE")
                            .Select("ELEM_PRICE")
                            .Select("ELEM_GIFT_AID")
                            .Select("uri")
                            .From(QuerySources.Donations)
                            .WhereRaw("(BOOKER_PN_ID = '" + this.ParentId + "' or INVOICE_PN_ID = '" + this.ParentId +"')", null)
                            .OrderBy("BOOK_ADD_DATE", false);
                    case DonationSearchListMode.Opportunity:
                        return Query.Create()
                            .Select("BOOK_ID")
                            .Select("ELEM_PROD_ID")
                            .Select("PROD_NAME")
                            .Select("PROD_REF")
                            .Select("BOOK_ADD_DATE")
                            .Select("ELEM_STATUS")
                            .Select("BOOKER_PN_ID")
                            .Select("INVOICE_PN_ID")
                            .Select("BOOKER_PROLE_PN_NAME")
                            .Select("INVOICE_PROLE_PN_NAME")
                            .Select("ELEM_COST_CODE")
                            .Select("ELEM_PRICE")
                            .Select("ELEM_GIFT_AID")
                            .Select("uri")
                            .From(QuerySources.Donations)
                            .Where("BOOK_OPP_ID", QueryConditionTypes.Equal, this.ParentId)
                            .OrderBy("BOOK_ADD_DATE", false);
                    default:
                        return null;
                }
            }
        }

        #endregion
        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            switch (this.DonationType)
            {
              case DonationSearchListMode.Person:
                this.DataTable.CreateUrl = "javascript:consensus.web.popupFrame({url:consensus.resolveUrl('~/GenericPopup.aspx?context=learning&control=newdonationdetails&personId=" + HttpUtility.UrlEncode(this.ParentId) + "')});";
                break;
              case DonationSearchListMode.Opportunity:
                this.DataTable.CreateUrl = "javascript:consensus.web.popupFrame({url:consensus.resolveUrl('~/GenericPopup.aspx?context=learning&control=newdonationdetails&oppId=" + HttpUtility.UrlEncode(this.ParentId) + "')});";

                break;
              default:
                break;
            }
        }

        #endregion
    }
}