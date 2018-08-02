using Consensus.Web.Controls;
using Consensus.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class EventTeamList : BaseListControl
    {
        #region Fields
        private string _eventid;

        #endregion

        #region Properties

        public string EventId
        {
            get { return _eventid; }
            set { _eventid = value; }
        }
        #endregion

        public override object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("ACTXREF_ID")
                    .Select("ACTXREF_PERSON_ID")
                    .Select("ACTXREF_PROLE_ID")
                    .Select("ACTXREF_ACT_ID")
                    .Select("ACTXREF_PN_NAME")
                    .Select("ACT_ACTION_DATE")
                    .Select("ACT_TIME")
                    .Select("TotalHours")
                    .Select("Total_Session")
                    .Select("Associate_Status")
                    .Select("Volunteer_Status")
                    .Select("uri")
                    .From(QuerySources.EventTeam);             
            }
        }

        public override DataTable DataTable
        {
            get { return this.EventTeamListResult; }
        }

        public override string DataTypeName
        {
            get
            {
                return "EventTeam List";
            }
        }
    }

}