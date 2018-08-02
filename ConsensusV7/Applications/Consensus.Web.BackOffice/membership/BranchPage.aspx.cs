using Consensus.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership
{
    public partial class BranchPage : BaseStandardPage<Branch, String>
    {
        #region Properties

        /// <summary>
        /// Gets the text displayed within the header of the page
        /// </summary>
        public override string DefaultTitle
        {
            get
            {
                return "Branch - " + this.Data.Name;
            }
        }

        /// <summary>
        /// Gets the delegated method for loading the API object that is presented within the page
        /// </summary>
        public override Func<string, Branch> DataLoader
        {
            get
            {
                return Branch.FetchById;
            }
        }

        /// <summary>
        /// Gets the delegated method for creating the API object that is presented within the page
        /// </summary>
        public override Func<Branch> DataCreator
        {
            get
            {
                return Branch.Create;
            }
        }

        /// <summary>
        /// Gets the icon displayed within the header of the page.
        /// </summary>
        public override string DefaultIcon
        {
            get
            {
                return "apartment";
            }
        }

        #endregion

        #region Methods

        protected override void PopulateControls()
        {
            base.PopulateControls();
            this.BranchDetail.DataSource = this.Data;
            this.BranchDistrictList.BranchId = this.Data.Id;
            this.CommitteeList.BranchId = this.Data.Id;
        }

        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }
        #endregion
    }
}