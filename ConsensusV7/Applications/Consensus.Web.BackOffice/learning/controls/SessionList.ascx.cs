using Consensus.Learning;
using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning
{
    public partial class SessionList : BaseListControl
    {
        #region fields
        /// <summary>
        ///     The ID of the parent object that the records are linked to.
        /// </summary>
        private String _parentCourse;


        #endregion
        #region properties
        /// <summary>
        ///     Gets or sets the Id of the parent object that the session records are linked to.
        /// </summary>
        public String ParentCourse
        {
            get { return _parentCourse; }
            set { _parentCourse = value; }
        }



        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Session List"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.SessionListResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                    .Select("ACT_ID")
                    .Select("ACT_SESSION_NAME")
                    .Select("ACT_ACTION_DATE")
                    .Select("ACT_START_TIME")
                    .Select("ACT_END_DATE")
                    .Select("ACT_END_TIME")
                    .Select("MANDATORY")
                    .Select("SHARED")
                    .Select("ACT_MAX_PLACES")
                    .Select("ACT_FREE_PLACES")
                    .Select("CSG_NAME")
                    .Select("LOC_NAME")
                    .Select("uri")
                    .From(QuerySources.Sessions)
                    .Where("SXREF_COURSE_ID", QueryConditionTypes.Equal, this.ParentCourse)
                    .OrderBy("SXREF_MAIN_SESSION", false)
                    .ThenBy("ACT_ACTION_DATE", true)
                    .ThenBy("ACT_START_TIME", true);
            }
        }

        #endregion

        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.DataTable.Url +=
                "&eventId=" + HttpUtility.UrlEncode(this.ParentCourse);
            this.DataTable.Json = "{ uri: \"learning/session\", eventId: " + HttpUtility.JavaScriptStringEncode(this.ParentCourse, true) + " , SessionXrefActivity: []}";
        }

        #endregion
    }
}