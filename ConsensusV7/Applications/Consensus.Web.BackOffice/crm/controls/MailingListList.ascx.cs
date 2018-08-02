using Consensus.Contact;
using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Consensus.Web.BackOffice.crm
{
    public partial class MailingListList : BaseListControl
    {
       
        #region fields

        /// <summary>
        ///     The ID of the parent object that the mailing list records are linked to.
        /// </summary>
        private String _mailingListParentId;

        #endregion


        #region properties

        /// <summary>
        ///     Gets or sets the ID of the parent object that the records are linked to.
        /// </summary>
        public String MailingListParentId
        {
            get { return _mailingListParentId; }
            set { _mailingListParentId = value; }
        }

        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Mailing Lists"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.MailingListListResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("LM_ID", "ID")
                    .Select("LIST_TITLE", "Name")
                    .Select("LM_ADD_DATE", "AddDate")
                    .Select("LIST_STATUS", "Status")
                    .Select("uri")
                    .From(QuerySources.MemberMailingLists)
                    .Where("LM_PN_ID", QueryConditionTypes.Equal, this.MailingListParentId)
                    .OrderBy("LM_ID");

            }

        }
        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.DataTable.Json = "{ uri: \"marketing/mailinglistmember\", personId: " + HttpUtility.JavaScriptStringEncode(this.MailingListParentId, true) + " }";
         }

        #endregion


        
    }
}