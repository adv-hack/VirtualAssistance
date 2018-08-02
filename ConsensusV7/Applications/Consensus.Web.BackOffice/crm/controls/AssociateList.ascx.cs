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
    public partial class AssociateList : BaseListControl
    {
        #region enums

        /// <summary>
        ///     Enumerates the different modes that the associate list can be used for.
        /// </summary>
        public enum AssociateListMode
        {
            PersonAssociatesByPerson,
            PersonAssociatesByRole,
            PersonAssociatedWithByPerson,
            PersonAssociatedWithByRole,
            OrganisationAssociates
        }

        #endregion

        #region fields

        /// <summary>
        ///     The mode that the associate list is be used for.
        /// </summary>
        private AssociateListMode _associateType;

        /// <summary>
        ///     The ID of the parent object that the associate records are linked to.
        /// </summary>
        private String _associateParentId;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the mode that the associate list is be used for.
        /// </summary>
        public AssociateListMode AssociateType
        {
            get { return _associateType; }
            set { _associateType = value; }
        }

        /// <summary>
        ///     Gets or sets the ID of the parent object that the associate records are linked to.
        /// </summary>
        public String AssociateParentId
        {
            get { return _associateParentId; }
            set { _associateParentId = value; }
        }

        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Associate List"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.AssociateListResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                switch (this.AssociateType)
                {
                    case AssociateListMode.PersonAssociatesByPerson:
                        return Query.Create()
                            .Select("ASSO_ID")
                            .Select("ASSO_TYPE_NAME")
                            .Select("ASSO_PERSON_ID")
                            .Select("ASSO_PERSON_NAME")
                            .Select("ASSO_ORG_ID")
                            .Select("ASSO_ORG_NAME")
                            .Select("ASSO_START_DATE")
                            .Select("ASSO_END_DATE")
                            .Select("uri")
                            .From(QuerySources.Associates)
                            .Where("ASSO_RECORD_TYPE", QueryConditionTypes.Equal, "PERSON")
                            .And("ASSO_ASSOCIATE_ID", QueryConditionTypes.Equal, this.AssociateParentId)
                            .OrderBy("ASSO_TYPE_NAME", true);
                    case AssociateListMode.PersonAssociatesByRole:
                        return Query.Create()
                            .Select("ASSO_ID")
                            .Select("ASSO_TYPE_NAME")
                            .Select("ASSO_PERSON_ID")
                            .Select("ASSO_PERSON_NAME")
                            .Select("ASSO_ORG_ID")
                            .Select("ASSO_ORG_NAME")
                            .Select("ASSO_START_DATE")
                            .Select("ASSO_END_DATE")
                            .Select("uri")
                            .From(QuerySources.Associates)
                            .Where("ASSO_RECORD_TYPE", QueryConditionTypes.Equal, "PERSON")
                            .And("ASSO_PARENT_ID", QueryConditionTypes.Equal, this.AssociateParentId)
                            .OrderBy("ASSO_TYPE_NAME", true);
                    case AssociateListMode.PersonAssociatedWithByPerson:
                        return Query.Create()
                            .Select("ASSO_ID")
                            .Select("ASSO_TYPE_NAME")
                            .Select("ASSO_ASSOCIATE_ID", "ASSO_PERSON_ID")
                            .Select("ASSO_ASSOCIATE_NAME", "ASSO_PERSON_NAME")
                            .Select("ASSO_ORG_ID")
                            .Select("ASSO_ORG_NAME")
                            .Select("ASSO_START_DATE")
                            .Select("ASSO_END_DATE")
                            .Select("uri")
                            .From(QuerySources.Associates)
                            .Where("ASSO_RECORD_TYPE", QueryConditionTypes.Equal, "PERSON")
                            .And("ASSO_PERSON_ID", QueryConditionTypes.Equal, this.AssociateParentId)
                            .OrderBy("ASSO_TYPE_NAME", true);
                    case AssociateListMode.PersonAssociatedWithByRole:
                        return Query.Create()
                            .Select("ASSO_ID")
                            .Select("ASSO_TYPE_NAME")
                            .Select("ASSO_ASSOCIATE_ID", "ASSO_PERSON_ID")
                            .Select("ASSO_ASSOCIATE_NAME", "ASSO_PERSON_NAME")
                            .Select("ASSO_ORG_ID")
                            .Select("ASSO_ORG_NAME")
                            .Select("ASSO_START_DATE")
                            .Select("ASSO_END_DATE")
                            .Select("uri")
                            .From(QuerySources.Associates)
                            .Where("ASSO_RECORD_TYPE", QueryConditionTypes.Equal, "PERSON")
                            .And("ASSO_PROLE_ID", QueryConditionTypes.Equal, this.AssociateParentId)
                            .OrderBy("ASSO_TYPE_NAME", true);
                    case AssociateListMode.OrganisationAssociates:
                        return Query.Create()
                            .Select("ASSO_ID")
                            .Select("ASSO_TYPE_NAME")
                            .Select("ASSO_PERSON_ID")
                            .Select("ASSO_PERSON_NAME")
                            .Select("ASSO_ORG_ID")
                            .Select("ASSO_ORG_NAME")
                            .Select("ASSO_START_DATE")
                            .Select("ASSO_END_DATE")
                            .Select("uri")
                            .From(QuerySources.Associates)
                            .Where("ASSO_RECORD_TYPE", QueryConditionTypes.Equal, "ORGANISATION")
                            .And("ASSO_ASSOCIATE_ID", QueryConditionTypes.Equal, this.AssociateParentId)
                            .OrderBy("ASSO_TYPE_NAME", true);
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

            Person person = Person.FetchById(this.AssociateParentId);
            switch (this.AssociateType)
            {
                case AssociateListMode.PersonAssociatesByPerson:
                    this.DataTable.Url += "&associateType=associate";
                    this.DataTable.Json = "{ uri: \"contact/associate\", associatedRoleId: " + HttpUtility.JavaScriptStringEncode(person == null || person.PrincipalRole == null ? null : person.PrincipalRole.Id, true) + " }"; 
                    break;
                case AssociateListMode.PersonAssociatesByRole: 
                    this.DataTable.Url += "&associateType=associate";
                    this.DataTable.Json = "{ uri: \"contact/associate\", associatedRoleId: " + HttpUtility.JavaScriptStringEncode(this.AssociateParentId, true) + " }";
                    break;
                case AssociateListMode.PersonAssociatedWithByPerson:
                    this.DataTable.Url += "&associateType=associatedwith";
                    this.DataTable.Json = "{ uri: \"contact/associate\", roleId: " + HttpUtility.JavaScriptStringEncode(person == null || person.PrincipalRole == null ? null : person.PrincipalRole.Id, true) + " }"; 
                    break;
                case AssociateListMode.PersonAssociatedWithByRole:
                    this.DataTable.Url += "&associateType=associatedwith";
                    this.DataTable.Json = "{ uri: \"contact/associate\", roleId: " + HttpUtility.JavaScriptStringEncode(this.AssociateParentId, true) + " }";

                    break;
                case AssociateListMode.OrganisationAssociates:
                    this.DataTable.Url += "&associateType=organisation";
                    this.DataTable.Json = "{ uri: \"contact/associate\", associatedRoleId: " + HttpUtility.JavaScriptStringEncode(this.AssociateParentId, true) + " }";
                    break;
            }
        }

        #endregion
    }
}