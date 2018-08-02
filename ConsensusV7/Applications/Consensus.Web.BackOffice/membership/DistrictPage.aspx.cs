using Consensus.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.membership
{
    public partial class DistrictPage : BaseStandardPage<District, String>
    {
        #region Properties
        /// <summary>
        /// Gets the text displayed within the header of the page
        /// </summary>
        public override string DefaultTitle
        {
            get
            {
                return "District - " + this.Data.Name;
            }
        }

        /// <summary>
        /// Gets the delegated method for loading the API object that is presented within the page
        /// </summary>
        public override Func<string, District> DataLoader
        {
            get
            {
                return District.FetchById;
            }
        }

        /// <summary>
        /// Gets the delegated method for creating the API object that is presented within the page
        /// </summary>
        public override Func<District> DataCreator
        {
            get
            {
                return District.Create;
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
            this.DistrictDetails.DataSource = this.Data;
            
        }

        //protected override void PopulateLinks()
        //{
        //    this.PopulateLink(this.BottomTabControl);
        //}
        #endregion 
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}