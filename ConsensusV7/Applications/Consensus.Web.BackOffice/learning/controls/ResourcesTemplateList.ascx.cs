using Consensus.Learning;
using Consensus.Searches;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning.controls
{
    public partial class ResourcesTemplateList : BaseListControl
    {
        #region fields

        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Resources"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.ResourcesListResult; }
        }



        /// <summary>
        ///     Gets the data source for the table
        /// </summary>
        public override Object DataSource
        {
            get { return this.DataBoundValue; }
        }

        /// <summary>
        ///     Gets or sets the name of the property that the communication list is bound to.
        /// </summary>
        public String DataBoundValue
        {
            get;
            set;
        }

        #endregion
    }
}