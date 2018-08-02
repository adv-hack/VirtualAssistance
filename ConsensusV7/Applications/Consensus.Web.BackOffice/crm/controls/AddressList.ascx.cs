using Consensus.Contact;
using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class AddressList : BaseListControl
    {

        #region fields

        /// <summary>
        ///     The ID of the organisation whose addresses will be displayed.
        /// </summary>
        private String _orgId;

        #endregion


        #region properties



        /// <summary>
        ///     Gets or sets the ID of the Org whose addresses will be displayed.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }


        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Address"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.AddressSearchList; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                if (this.OrgId != null)
                {
                    return Query.Create()
                    .Select("ADD_ID")
                    .Select("ADD_BUILDING")
                    .Select("ADD_STREET")
                    .Select("ADD_AREA")
                    .Select("ADD_TOWN")
                    .Select("ADD_COUNTY")
                    .Select("ADD_POSTCODE")
                    .Select("ADD_COUNTRY")
                    .Select("ADDXREF_ID")
                    .Select("ADDXREF_TYPE", "Type")
                    .Select("ADD_MAILSTRING", "Address")
                    .Select("ALT_ADD_MAILSTRING","AltAddress")
                    .Select("uri")
                    .From(QuerySources.OrganisationAddresses)
                    .Where("ADDXREF_ORG_ID", QueryConditionTypes.Equal, this.OrgId)
                    .And("ADDXREF_PRINCIPAL", QueryConditionTypes.NotEqual, 1)
                    .OrderBy("ADD_TOWN", true);
                }
                else
                { 
                    return Query.Create()
                    .Select("ADD_ID")
                    .Select("ADD_BUILDING")
                    .Select("ADD_STREET")
                    .Select("ADD_AREA")
                    .Select("ADD_TOWN")
                    .Select("ADD_COUNTY")
                    .Select("ADD_POSTCODE")
                    .Select("ADD_COUNTRY")
                    .Select("ADDXREF_ID")
                    .Select("ADDXREF_TYPE", "Type")
                    .Select("ADD_MAILSTRING", "Address")
                    .Select("ALT_ADD_MAILSTRING", "AltAddress")
                    .Select("uri")
                    .From(QuerySources.OrganisationAddresses)
                    .Where("ADDXREF_ORG_ID", QueryConditionTypes.Equal, this.Request.QueryString["orgId"])
                    .OrderBy("ADD_TOWN", true);
                }
            }
        }

        protected override void OnInit(EventArgs e)
        {
            this.Select.Visible = false;
            
            switch (this.Request.QueryString["type"])
            {
                case "altbutton":
                    this.Select.Visible = true;
                    break;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (this.OrgId != null)
                this.DataTable.Json = "{ uri: \"contact/organisationaddress\", OrganisationId: " + HttpUtility.JavaScriptStringEncode(this.OrgId, true) + " }";
            else if (!String.IsNullOrEmpty(this.Request.QueryString["orgId"]))
                this.DataTable.Json = "{ uri: \"contact/organisationaddress\", OrganisationId: " + HttpUtility.JavaScriptStringEncode(this.Request.QueryString["orgId"], true) + " }";
        }

        #endregion


    }
}