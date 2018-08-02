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
    public partial class CourseList : BaseListControl
    {
        private String _parentid;

        #region properties


        /// <summary>
        ///     Gets or sets the Id of the parent object that the session records are linked to.
        /// </summary>
        public String ParentId
        {
            get { return _parentid; }
            set { _parentid = value; }
        }



        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Course List"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.CourseListResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Query.Create()
                             .Select("TPXREF_TRAIN_ID")
                             .Select("TPXREF_ID")
                             .Select("TPXREF_START_DATE")
                             .Select("TPXREF_END_DATE")
                             .Select("TPXREF_STATUS")
                             .Select("TPXREF_GRADE")
                             .Select("TPXREF_COST")
                             .Select("PROD_SY_PRODUCT")
                             .Select("PROD_ID")
                             .Select("PROD_NAME")
                             .Select("uri")
                             .From(QuerySources.AssociateCourseList)
                             .Where("TPXREF_TRAIN_ID", QueryConditionTypes.Equal, this.ParentId)
                             .OrderBy("PROD_NAME", false);
            }
        }

        #endregion
        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);            
            this.DataTable.Json = "{ uri: \"contact/trainprodxref\", Id: " + HttpUtility.JavaScriptStringEncode(this.ParentId, true) + "}";
        }

        #endregion
    }
}