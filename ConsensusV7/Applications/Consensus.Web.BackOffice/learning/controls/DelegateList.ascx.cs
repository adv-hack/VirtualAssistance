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
    public partial class DelegateList : BaseListControl
    {
        #region fields


        /// <summary>
        ///     The ID of the parent object that the associate records are linked to.
        /// </summary>
        private String _eventId;

        #endregion

        #region properties


        /// <summary>
        ///     Gets or sets the ID of the parent object that the associate records are linked to.
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
            get { return "Delegate List"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.DelegateListResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {

                return Query.Create()
                    .Select("DEL_ID")
                    .Select("COURSE_ID")
                    .Select("DEL_PERSON_ID")
                    .Select("PROLE_PN_NAME")
                    .Select("PN_SURNAME")
                    .Select("STATUS")
                    .Select("PROLE_POS_TITLE")
                    .Select("ORG_ID")
                    .Select("ORG_NAME")
                    .Select("PROLE_PHONE")
                    .Select("BOOK_ORG_ID")
                    .Select("BOOK_ORG_NAME")
                    .Select("PROLE_EMAIL")
                    .Select("DEL_BOOK_ID")
                    .From(QuerySources.Delegates)
                    .Where("COURSE_ID", QueryConditionTypes.Equal, this.EventId)
                    .And("ELEM_TYPE", QueryConditionTypes.Equal, 0)
                    .And("ELEM_MAIN_SESSION", QueryConditionTypes.Equal, 1)
                    .OrderBy("PN_SURNAME", true);
            }
        }

        #endregion

    }
}