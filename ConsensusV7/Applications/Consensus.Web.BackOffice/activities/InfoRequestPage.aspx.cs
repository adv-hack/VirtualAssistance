using Consensus.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.activities
{
    public partial class InfoRequestPage : BaseStandardPage<Helpdesk, String>
    {
        #region Properties

        /// <summary>
        /// Gets the text displayed within the header of the page
        /// </summary>
        public override string DefaultTitle
        {
            get
            {
                return "Info request - " + this.Data.Id;
            }
        }

        /// <summary>
        /// Gets the delegated method for loading the API object that is presented within the page
        /// </summary>
        public override Func<string, Helpdesk> DataLoader
        {
            get
            {
                return Helpdesk.FetchById;
            }
        }

        /// <summary>
        /// Gets the delegated method for creating the API object that is presented within the page
        /// </summary>
        public override Func<Helpdesk> DataCreator
        {
            get
            {
                return Helpdesk.Create;
            }
        }

        /// <summary>
        /// Gets the icon displayed within the header of the page.
        /// </summary>
        public override string DefaultIcon
        {
            get
            {
                return "ask_question";
            }
        }

        #endregion

        #region Methods

        protected override void PopulateControls()
        {
            this.InfoRequestDetail.DataSource = this.Data;
            SetSendPackSidebarOption();
        }

        #endregion
    }
}