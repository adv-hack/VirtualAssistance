using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Portal;
using Consensus.Contact;
using Consensus.Searches;
using Consensus.Web.Controls;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class PortalUserRoleList : BaseListControl
    {


        #region fields

        /// <summary>
        ///     The ID of the Invoice whose lines will be displayed.
        /// </summary>
        private String _portalUser;

        #endregion


        #region properties



        /// <summary>
        ///     Gets or sets the ID of the Invoice whose lines will be displayed.
        /// </summary>
        public String PortalUser
        {
            get { return _portalUser; }
            set { _portalUser = value; }
        }


        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Portals"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.SearchResult; }
        }


        /// <summary>
        ///     Gets the data source for the table.
        /// </summary>
        public override Object DataSource
        {
            get
            {
                {
                    return Searches.Search.Create(SearchTypes.SearchPortalUserRolesList)
                        .AddParameter("@PA_PU_ID", this.PortalUser);
                }

            }

        }
        #endregion
    }
}