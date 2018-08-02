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
    public partial class DepartmentList : BaseListControl
    {

        public override String DataTypeName
        {
            get { return "Department List"; }
        }


        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.DepartmentSearchList; }
        }

        /// <summary>
        ///     The ID of the parent object that the associate records are linked to.
        /// </summary>
        private String _organisationID;

        /// <summary>
        ///     Gets or sets the ID of the parent object that the associate records are linked to.
        /// </summary>
        public String OrganisationID
        {
            get { return _organisationID; }
            set { _organisationID = value; }
        }


        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("DEPT_ID")
                    .Select("DEPT_NAME", "Department")
                    .Select("uri")
                    .From(QuerySources.Departments)
                    .Where("DEPT_ORG_ID", QueryConditionTypes.Equal, this.OrganisationID)
                    .OrderBy("DEPT_NAME", true);
            }
        }

         #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Organisation organisation = Organisation.FetchById(this.OrganisationID);
            this.DataTable.Json = "{ uri: \"contact/organisationdepartment\", organisationId: " + HttpUtility.JavaScriptStringEncode(this.OrganisationID, true) + " }";

        }
        #endregion 
    }
}