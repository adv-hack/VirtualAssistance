using Consensus.Contact;
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
    public partial class SelectionGroupList : BaseListControl
    {

        #region enums

        /// <summary>
        ///     Enumerates the different modes that the price list can be used for.
        /// </summary>
        public enum SelectionGroupMode
        {
            Product,
            Event
        }

        #endregion
        
        #region fields

        /// <summary>
        ///     The ID of the parent object that the records are linked to.
        /// </summary>
        private String _parentid;

        /// <summary>
        ///     The type of the parent object that the records are linked to.
        /// </summary>
        private SelectionGroupMode _type;
        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the ID of the parent object that the records are linked to.
        /// </summary>
        public String ParentId
        {
            get { return _parentid; }
            set { _parentid = value; }
        }

        /// <summary>
        ///     The type of the parent object that the records are linked to.
        /// </summary>
        public SelectionGroupMode Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Selection Group"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.SelectionGroupResult; }
        }

        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                return Searches.Search.Create(SearchTypes.SearchSelectionGroups)
                        .AddParameter("@PA_PARENT_ID", this.ParentId)
                        .AddParameter("@PA_TYPE", this.Type);
            }

        }
        #endregion
        
        #region page cycle

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            switch (this.Type)
            {
                case SelectionGroupMode.Product:
                    this.DataTable.Url += "productselectiongroupdetail&id={{Id}}";
                    this.DataTable.Json = "{ uri: \"learning/prodselectgroup\", prodIdId: " + HttpUtility.JavaScriptStringEncode(this.ParentId, true) + " }";
                    break;
                default:
                    this.DataTable.Url += "eventselectiongroupdetail&id={{Id}}";
                    this.DataTable.Json = "{ uri: \"learning/courseselectgroups\", eventId: " + HttpUtility.JavaScriptStringEncode(this.ParentId, true) + " }";
                    break;
            }
        }

        #endregion
    }
}