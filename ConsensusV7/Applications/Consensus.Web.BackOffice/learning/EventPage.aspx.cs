using Consensus.Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.learning
{
    public partial class EventPage : BaseStandardPage<Event, String>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Event - " + this.Data.Name; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "conference"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, Event> DataLoader
        {
            get { return Event.FetchById; }
        }

        /// <summary>
        ///     Gets the delegated method for creating the API object that is presented within the page.
        /// </summary>
        public override Func<Event> DataCreator
        {
            get { return Event.Create; }
        }

        #endregion

        #region methods

        protected override void PopulateControls()
        {
            this.EventDetails.DataSource = this.Data;
            this.SessionList.ParentCourse = this.Data.Id;
            this.EventProductList.EventId = this.Data.Id;
            this.DelegateList.EventId = this.Data.Id;
            this.SelectionGroupList.ParentId = this.Data.Id;
            this.SelectionGroupList.Type = SelectionGroupList.SelectionGroupMode.Event;
            this.EventTeamList.EventId = this.Data.Id;
            if (this.Data.Id == null)
            {
               this.MainSessionDetails.Visible = false;
            }
            else
            {
                this.MainSessionDetails.DataSource = this.Data;
                this.PriceList.ParentSyProduct = this.Data.Product.SyProduct.ToString();
                this.PriceList.PriceParentId = this.Data.MainSession.Id;
                this.PriceList.PriceMode = ProductPriceList.PriceListMode.Session;
            }

            SetSendPackSidebarOption();
        }

        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }
        #endregion
    }
}