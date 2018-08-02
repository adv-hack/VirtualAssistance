using Consensus.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership
{
    public partial class CommitteePage : BaseStandardPage<Committee, String>
    {
        #region Properties

        /// <summary>
        /// Gets the text displayed within the header of the page
        /// </summary>
        public override string DefaultTitle
        {
            get
            {
                return "Committee - " + this.Data.Name;
            }
        }

        /// <summary>
        /// Gets the delegated method for loading the API object that is presented within the page
        /// </summary>
        public override Func<string, Committee> DataLoader
        {
            get
            {
                return Committee.FetchById;
            }
        }

        /// <summary>
        /// Gets the delegated method for creating the API object that is presented within the page
        /// </summary>
        public override Func<Committee> DataCreator
        {
            get
            {
                return Committee.Create;
            }
        }

        /// <summary>
        /// Gets the icon displayed within the header of the page.
        /// </summary>
        public override string DefaultIcon
        {
            get
            {
                return "queue";
            }
        }

        #endregion

        #region Methods

        protected override void PopulateControls()
        {
            base.PopulateControls();
            this.CommitteeDetail.DataSource = this.Data;
            this.CommitteeMemberList.CommitteeId = this.Data.Id;  
        }
        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }

        #endregion
    }
}
