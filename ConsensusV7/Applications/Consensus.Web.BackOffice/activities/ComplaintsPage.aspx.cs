using Consensus.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.activities
{
    public partial class ComplaintsPage : BaseStandardPage<Complaint,String>
    {
        #region Properties

        /// <summary>
        /// Gets the text displayed within the header of the page
        /// </summary>
        public override string DefaultTitle
        {
            get
            {
                return "Complaint - " + this.Data.Id;
            }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override string DefaultIcon
        {
            get
            {
                return "strike";
            }
        }

        /// <summary>
        /// Gets the delegated method for loading the API object that is presented within the page
        /// </summary>
        public override Func<string, Complaint> DataLoader
        {
            get
            {
                return Complaint.FetchById;
            }
        }

        /// <summary>
        /// Gets the delegated method for creating the API object that is presented within the page
        /// </summary>
        public override Func<Complaint> DataCreator
        {
            get
            {
                return Complaint.Create;
            }
        }

        #endregion
        #region methods

        protected override void PopulateControls()
        {
            this.ComplaintDetails.DataSource = this.Data;
            SetSendPackSidebarOption();
        }

        #endregion
    }
}