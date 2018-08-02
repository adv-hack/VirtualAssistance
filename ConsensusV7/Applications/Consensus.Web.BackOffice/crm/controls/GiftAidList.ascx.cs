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
    public partial class GiftAidList : BaseListControl
    {
        #region fields

        /// <summary>
        ///     The ID of the person whose gift aids will be displayed.
        /// </summary>
        private String _personId;

        #endregion

        #region properties



        /// <summary>
        ///     Gets or sets the ID of the person whose roles will be displayed.
        /// </summary>
        public String PersonId
        {
            get { return _personId; }
            set { _personId = value; }
        }

        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Role"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.GiftAidListResults; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("GIF_ID")
                    .Select("GIF_START_DATE")
                    .Select("GIF_END_DATE")
                    .Select("GIF_TYPE")
                    .Select("GIF_ACTIVE")
                    .Select("GIF_COMMUNICATION")
                    .Select("uri")
                    .From(QuerySources.GiftAid)
                    .Where("GIF_PN_ID", QueryConditionTypes.Equal, this.PersonId)
                    .OrderBy("GIF_ACTIVE", true)
                    .ThenBy("GIF_START_DATE", false);
            }
        }

        #endregion

        #region page cycle

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            this.DataTable.Json = "{ uri: \"contact/giftaid\", pnIdId: " + HttpUtility.JavaScriptStringEncode(this.PersonId, true) + " }";
        }

        #endregion
    }
}