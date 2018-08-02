using Consensus.Contact;
using Consensus.Sales;
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
    public partial class ActivityList : BaseListControl
    {
        #region enums

        /// <summary>
        ///     Enumerates the different modes that the associate list can be used for.
        /// </summary>
        public enum ActivityListMode
        {
            PN_ID = -1,
            PROLE_ID = -2,
            ORG_ID = -3,
            OPP_ID = -4,
            Campaign = 48,
            PromotionMaster = 85,
            Promotion = 49,
            Committee = 332,
            //MembershipAudit?? = 334, // needs extra logic in procedure spConsensusSearchActivityList
            Activity = 4,
            Account = 603
        }
        
        #endregion

        #region fields

        /// <summary>
        ///     The activity type to screenObjectDisplay
        /// </summary>
        private String _activityType;

        /// <summary>
        ///     The activity id type
        /// </summary>
        private ActivityListMode _activityMode;

        /// <summary>
        ///     The ID of the parent object that the activity records are linked to.
        /// </summary>
        private String _activityParentId;

        private OpportunitySyType _oppSyType;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the activity type to screenObjectDisplay
        /// </summary>
        public String ActivityType
        {
            get { return _activityType; }
            set { _activityType = value; }
        }

        /// <summary>
        ///    Gets or sets the paramter name suffix for the reference field as per spConsensusSearchActivityList, or the table that the activities are linked to via ACT_LINK_XREF
        /// </summary>
        public ActivityListMode ActivityMode
        {
            get { return _activityMode; }
            set { _activityMode = value; }
        }
        public OpportunitySyType OppSyType
        {
            get { return _oppSyType; }
            set { _oppSyType = value; }
        }
        /// <summary>
        ///     Gets or sets the ID of the parent object that the activity records are linked to. 
        /// </summary>
        public String ActivityParentId
        {
            get { return _activityParentId; }
            set { _activityParentId = value; }
        }
        

        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Activity"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.ActivityListResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                if ((int)ActivityMode < 0)
                {
                  if (this.ActivityParentId != null)
                  {
                        return Searches.Search.Create(SearchTypes.SearchActivityList)
                            .AddParameter("@PA_" + this.ActivityMode.ToString(), this.ActivityParentId)
                            .AddParameter("@PA_ACT_TYPE", this.ActivityType)
                            .AddParameter("@PA_OPP_SY_TYPE", Convert.ToInt16(this.OppSyType));
                  }
                  else
                  {
                    return Searches.Search.Create(SearchTypes.SearchActivityList)
                        .AddParameter("@PA_" + this.ActivityMode.ToString(), "0")
                        .AddParameter("@PA_ACT_TYPE", this.ActivityType)
                        .AddParameter("@PA_OPP_SY_TYPE", Convert.ToInt16(this.OppSyType));
                  }

                }
                else
                {
                  if (this.ActivityParentId != null)
                  {
                    return Searches.Search.Create(SearchTypes.SearchActivityList)
                        .AddParameter("@PA_TABLE_NUM", (int)this.ActivityMode)
                        .AddParameter("@PA_REC_ID", this.ActivityParentId)
                        .AddParameter("@PA_OPP_SY_TYPE", Convert.ToInt16(this.OppSyType));
                  }
                  else
                  {
                    return Searches.Search.Create(SearchTypes.SearchActivityList)
                        .AddParameter("@PA_TABLE_NUM", (int)this.ActivityMode)
                        .AddParameter("@PA_REC_ID", "0")
                        .AddParameter("@PA_OPP_SY_TYPE", Convert.ToInt16(this.OppSyType));
                  }
                }

            }

        }
        #endregion


        #region page cycle
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if ((int)ActivityMode >= 0) // ?? or case statement - different for differnt tables?
            {
                //this.DataTable.Columns[3].Visible = false;
                this.DataTable.Columns[4].Visible = false;
            }

            this.DataTable.Url += 
                "&refid=" + HttpUtility.UrlEncode(this.ActivityParentId) 
                + "&refmode=" + HttpUtility.UrlEncode(this.ActivityMode.ToString()) 
                + "&reftype=" + HttpUtility.UrlEncode(this.ActivityType);


            if ((int)ActivityMode < 0)
            {
                switch (ActivityMode)
                {
                    case ActivityListMode.OPP_ID:
                        this.DataTable.Json = "{ uri: \"activities/activity\", OpportunityId: " + HttpUtility.JavaScriptStringEncode(this.ActivityParentId, true) + " }";
                        break;
                    case ActivityListMode.PN_ID:
                        this.DataTable.Json = "{ uri: \"activities/activity\", EndUserPersonId: " + HttpUtility.JavaScriptStringEncode(this.ActivityParentId, true) + " }";
                        break;
                    case ActivityListMode.ORG_ID:
                        this.DataTable.Json = "{ uri: \"activities/activity\", EndUserOrganisationId: " + HttpUtility.JavaScriptStringEncode(this.ActivityParentId, true) + " }";
                        break;
                    case ActivityListMode.PROLE_ID:
                        this.DataTable.Json = "{ uri: \"activities/activity\", EndUserId: " + HttpUtility.JavaScriptStringEncode(this.ActivityParentId, true) + " }";
                        break;
                }
            }
            else
            {
                this.DataTable.Json = "{ uri: \"activities/activity\", ActivityLinkXrefs: [{ RecordId: " + HttpUtility.JavaScriptStringEncode(this.ActivityParentId, true)
                    + ", TableNum: " + ((int)this.ActivityMode).ToString()
                    + " }] }"; // ActivityId: " + ? + ", 
            }
        }
        #endregion
    }
}