using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Web;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class TimeLogList : BaseListControl
    {
        #region fields
        /// <summary>
        ///    the Id of the Associated Id for which time is logged.
        /// </summary>
        private String _associateRoleId;

        /// <summary>
        /// The Parent Id
        /// </summary>
        private String _associateId;

        /// <summary>
        /// THe time log is for Trainer or Volunteer
        /// </summary>
        private string _timelogFor;

        #endregion

        #region properties
        /// <summary>
        ///     Gets or sets the Id of the Associated Id for which time is logged.
        /// </summary>
        public String AssociateRoleId
        {
            get { return _associateRoleId; }
            set { _associateRoleId = value; }
        }

        public string AssociateId1
        {
            get { return _associateId; }
            set { _associateId = value; }
        }

        /// <summary>
        /// THe time log is for Trainer or Volunteer
        /// </summary>
        public string TimeLogFor
        {
            get { return _timelogFor; }
            set { _timelogFor = value; }

        }

        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Associate TimeLog List"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.TimeLogListResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                   .Select("TIM_ID")
                   .Select("TIM_HOURS")
                   .Select("TIM_HOU_CHARGE")
                   .Select("TIM_TRA_HOURS")
                   .Select("TIM_TRA_CHARGE")
                   .Select("TIM_TYPE")
                   .Select("TIM_ACT_ID")
                   .Select("SXREF_ACT_ID")
                   .Select("LoggedAgainst")
                   .Select("Tim_Desc")
                   .Select("TIM_ROLE_ID")
                   .Select("uri")
                   .From(QuerySources.AssociateTimeLog)
                   .Where("TIM_ROLE_ID", QueryConditionTypes.Equal, this.AssociateRoleId).And("TIM_TRAIN_SY_TYPE", QueryConditionTypes.Equal, TimeLogFor == "Associate" ? 0 : 1);
            }

        }

        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.TimeLogListResult.Url += "&RoleId=" + this.AssociateRoleId;
            this.TimeLogListResult.Url += "&TimeLogFor=" + this.TimeLogFor;
            this.DataTable.Json = "{ uri: \"contact/timespent\", asId: " + HttpUtility.JavaScriptStringEncode(this.AssociateId1, true) + " }";
        }

        #endregion
    }
}