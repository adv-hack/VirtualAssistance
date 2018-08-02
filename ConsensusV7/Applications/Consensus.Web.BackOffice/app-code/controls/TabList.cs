using Consensus.Web.BackOffice;
using Consensus.Web.Customisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.Controls
{
    /// <summary>
    ///      A tab page which is used purely for rendering a list control
    /// </summary>
    public class TabList : TabPage, IHaveColumns, IHaveNoChildren
    {
        #region fields

        /// <summary>
        ///     Specifies whether the tab includes a create button.
        /// </summary>
        private Boolean _enableCreation;

        /// <summary>
        ///     Specifies whether the tab includes a delete selected button.
        /// </summary>
        private Boolean _enableDeletion;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the list control that is rendered in the tab.
        /// </summary>
        public BaseListControl Control
        {
            get { return this.Content.Controls.OfType<BaseListControl>().FirstOrDefault(); }
        }

        /// <summary>
        ///    Gets or sets whether the tab includes a create button. 
        /// </summary>
        public Boolean EnableCreation
        {
            get { return _enableCreation; }
            set { _enableCreation = value; }
        }

        /// <summary>
        ///    Gets or sets whether the tab includes a delete selected button. 
        /// </summary>
        public Boolean EnableDeletion
        {
            get { return _enableDeletion; }
            set { _enableDeletion = value; }
        }

        /// <summary>
        ///     Gets the list of columns for the table
        /// </summary>
        List<DataTableColumn> IHaveColumns.Columns
        {
            get { return this.Control == null || this.Control.DataTable == null ? null : this.Control.DataTable.Columns; }
        }

        protected override void OnInit(EventArgs e)
        {
            //this.BlockCustomFields = true;
            base.OnInit(e);
        }

        #endregion
    }
}