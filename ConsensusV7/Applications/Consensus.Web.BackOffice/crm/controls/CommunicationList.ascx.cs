using Consensus.Contact;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;

namespace Consensus.Web.BackOffice.crm
{
    public partial class CommunicationList : BaseListControl
    {
        #region properties

        public IEnumerable<CommunicationsRole> CommunicationsData { get; set; }

        /// <summary>
        ///     Gets the name of the data type.
        /// </summary>
        public override String DataTypeName
        {
            get { return "Communication"; }
        }

        /// <summary>
        ///     Gets the data table control that is used to render the list.
        /// </summary>
        public override DataTable DataTable
        {
            get { return this.CommunicationListResult; }
        }
       
        /// <summary>
        ///     Gets the data source for the table
        /// </summary>
        public override Object DataSource
        {
            get { return this.CommunicationsData; }
        }

        /// <summary>
        ///     Gets or sets the name of the property that the communication list is bound to.
        /// </summary>
        public override String DataBoundValue
        {
            get { return "RoleCommunication"; }
        }

        #endregion       

    }
}