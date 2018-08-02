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
    public partial class ProfileList : BaseListControl
    {
        #region enums

        /// <summary>
        ///     Enumerates the different modes that the profile list can be used for.
        /// </summary>
        public enum ProfileListMode
        {
            PROF_PERSON_ID,
            PROF_ORG_ID,
            PROF_COURSE_ID,
            PROF_PROD_ID,
            PROF_TRAIN_ID,
            PROF_VOL_ID
        }

        #endregion

        #region fields

        /// <summary>
        ///     The profile id to screenObjectDisplay
        /// </summary>
        private ProfileListMode _profileMode;

        /// <summary>
        ///     The ID of the parent object that the profile records are linked to.
        /// </summary>
        private String _profileParentId;

        private String _trainerSyType;

        #endregion


        #region properties

        /// <summary>
        ///    Gets or sets the activity type to screenObjectDisplay
        /// </summary>
        public ProfileListMode ProfileMode
        {
            get { return _profileMode; }
            set { _profileMode = value; }
        }

        /// <summary>
        ///     Gets or sets the ID of the parent object that the opportunity records are linked to.
        /// </summary>
        public String ProfileParentId
        {
            get { return _profileParentId; }
            set { _profileParentId = value; }
        }

        public String TrainerSyType
        {
            get { return _trainerSyType; }
            set { _trainerSyType = value; }
        }

        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Profile List"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.ProfileListResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                IQueryConditionableAnd query = Query.Create()
                    .Select("PROF_ID")
                    .Select("PROF_KEY", "Key")
                    .Select("PROF_VALUE", "Value")
                    .Select("PROF_VALUE2", "Value 2")
                    .Select("PROF_STATUS", "Status")
                    .Select("PROF_NOTES", "Notes")
                    .Select("uri")
                    .From(QuerySources.Profiles)
                    .Where(this.ProfileMode.ToString(), QueryConditionTypes.Equal, this.ProfileParentId);

                if (this.ProfileMode.ToString() == "PROF_ORG_ID")
                    query = query.AndRaw("isNull(PROF_PERSON_ID, '') = ''", null);

                return query.OrderBy("PROF_KEY", true);
            }

        }
        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {


            base.OnLoad(e);


            switch (this.ProfileMode)
            {
                case ProfileListMode.PROF_PERSON_ID:
                    this.DataTable.Url += "&profileType=person";
                    this.DataTable.Json = "{ uri: \"common/profileperson\", personId: " + HttpUtility.JavaScriptStringEncode(this.ProfileParentId, true) + " }";
                    break;
                case ProfileListMode.PROF_ORG_ID:
                    this.DataTable.Url += "&profileType=organisation";
                    this.DataTable.Json = "{ uri: \"common/profileorganisation\", organisationId: " + HttpUtility.JavaScriptStringEncode(this.ProfileParentId, true) + " }";
                    break;
                case ProfileListMode.PROF_COURSE_ID:
                    this.DataTable.Url += "&profileType=course";
                    this.DataTable.Json = "{ uri: \"common/profilecourses\", coursesId: " + HttpUtility.JavaScriptStringEncode(this.ProfileParentId, true) + " }";
                    break;
                case ProfileListMode.PROF_PROD_ID:
                    this.DataTable.Url += "&profileType=product";
                    this.DataTable.Json = "{ uri: \"common/profileproduct\", productId: " + HttpUtility.JavaScriptStringEncode(this.ProfileParentId, true) + " }";
                    break;
                case ProfileListMode.PROF_VOL_ID:                  
                    this.DataTable.Url += "&profileType=volunteer";
                    this.DataTable.Json = "{ uri: \"common/profilevolunteer\", volunteerId: " + HttpUtility.JavaScriptStringEncode(this.ProfileParentId, true) + " }";
                    break;
                case ProfileListMode.PROF_TRAIN_ID:     
                    this.DataTable.Url += "&profileType=trainer"; 
                    this.DataTable.Json = "{ uri: \"common/profiletrainer\", trainerId: " + HttpUtility.JavaScriptStringEncode(this.ProfileParentId, true) + " }";
                    break;
                //case ProfileListMode.PROF_VOLNTR_ID:
                //    this.DataTable.Url += "&profileType=volunteer";
                //    this.DataTable.Json = "{ uri: \"common/profiletrainer\", volunteerId: " + HttpUtility.JavaScriptStringEncode(this.ProfileParentId, true) + " }";
                //    break;
                    
            }
        }

        #endregion


        
    }
}