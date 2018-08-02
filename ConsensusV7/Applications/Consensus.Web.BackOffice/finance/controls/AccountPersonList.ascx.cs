using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class AccountPersonList : BaseListControl
    {

        #region fields

        /// <summary>
        ///     The ID of the account whose contacts and organisations will be displayed.
        /// </summary>
        private String _accountId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the ID of the  whose contacts and organisations will be displayed.
        /// </summary>
        public String AccountIdForPersonList
        {
            get { return _accountId; }
            set { _accountId = value; }
        }

        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Account Person List"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.AccountPersonLists; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("PROLE_PN_NAME")
                    .Select("ORG_NAME")
                    .Select("ADD_MAILSTRING")
                    .Select("ACXREF_MAIN")
                    .Select("ACXREF_INVOICE")
                    .Select("ACXREF_STATEMENT")
                    .Select("ACXREF_NO_ADD_CHANGE")
                    .Select("uri")
                    .From(QuerySources.AccountPerson)
                    .Where("ACXREF_ACC_ID", QueryConditionTypes.Equal, this.AccountIdForPersonList)
                    .OrderBy("ORG_NAME", true);
            }
        }

        #endregion

        #region page cycle       

        protected override void OnLoad(EventArgs e)
        
        {
            base.OnLoad(e);
            this.AccountPersonLists.Url += "&accountId=" + this.AccountIdForPersonList;

            this.DataTable.Json = "{ uri: \"finance/AccountXref\", accid: " + HttpUtility.JavaScriptStringEncode(this.AccountIdForPersonList, true) + " }";
        }

        #endregion

        #region pagecycle
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

