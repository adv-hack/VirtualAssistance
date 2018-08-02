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
    public partial class RoleList : BaseListControl
    {
        #region fields

        /// <summary>
        ///     The ID of the person whose roles will be displayed.
        /// </summary>
        private String _personId;

        /// <summary>
        ///     The ID of the role which should be excluded from the list.
        /// </summary>
        private String _excludeRoleId;

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
        ///     Gets or sets the ID of the role which should be excluded from the list.
        /// </summary>
        public String ExcludeRoleId
        {
            get { return _excludeRoleId; }
            set { _excludeRoleId = value; }
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
            get { return this.PersonRoleList; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("PROLE_ID")
                    .Select("PROLE_ORG_ID")
                    .Select("PROLE_PERSON_ID")
                    .Select("PROLE_POS_TITLE", "Job Title")
                    .Select("PROLE_ORG_NAME", "Organisation")
                    .Select("ADD_MAILSTRING", "Address")
                    .Select("PROLE_PRINCIP_ROLE")
                    .Select("PROLE_DIS_FLAG_DESC")
                    .Select("PROLE_PHONE", "Telephone")
                    .Select("PROLE_MOBILE", "Mobile")
                    .Select("PROLE_EMAIL", "Email Address")
                    .Select("uri")
                    .From(QuerySources.Roles)
                    .Where("PROLE_PERSON_ID", QueryConditionTypes.Equal, this.PersonId)
                    .And("PROLE_ID", QueryConditionTypes.NotEqual, this.ExcludeRoleId)
                    .OrderBy("PROLE_ORG_NAME", true)
                    .ThenBy("PROLE_POS_TITLE", true);
            }
        }

        #endregion

        #region page cycle

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            //we need to pass this in and replaced the key which is the id to the PROLE_ID so we can get the correct role off the line. Waiting for RJ to advise
            //this.DataTable.EditUrl += "&id=" +this.PersonId;

            this.DataTable.Json = "{ uri: \"contact/role\", PersonId: " + HttpUtility.JavaScriptStringEncode(this.PersonId, true) + " }";
            this.DataTable.CreateUrl += "&personId=" + this.PersonId;
            this.DataTable.OnCreate = @"
                if (data.IsPrincipal === 1 || data.IsPrincipal === true)
                    window.location.href = consensus.resolveUrl('~/crm/person?id=' + data.PersonId);
            ";

        }

        #endregion
    }
}