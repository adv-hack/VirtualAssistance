using Consensus.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning
{
    public partial class LocationPage : BaseStandardPage<Location, String>
    {
        #region Properties

        /// <summary>
        /// Gets the text displayed within the header of the page
        /// </summary>
        public override string DefaultTitle
        {
            get
            {
                return "Location - " + this.Data.Name;
            }
        }

        /// <summary>
        /// Gets the delegated method for loading the API object that is presented within the page
        /// </summary>
        public override Func<string, Location> DataLoader
        {
            get
            {
                return Location.FetchById;
            }
        }

        /// <summary>
        /// Gets the delegated method for creating the API object that is presented within the page
        /// </summary>
        public override Func<Location> DataCreator
        {
            get
            {
                return Location.Create;
            }
        }

        /// <summary>
        /// Gets the icon displayed within the header of the page.
        /// </summary>
        public override string DefaultIcon
        {
            get
            {
                return "school_house";
            }
        }

        #endregion

        #region Methods

        protected override void PopulateControls()
        {
            this.LocationDetail.DataSource = this.Data;
        }

        #endregion
    }
}