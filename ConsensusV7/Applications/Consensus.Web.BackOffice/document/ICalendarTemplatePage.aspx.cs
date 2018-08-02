using Consensus.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.document
{
    public partial class ICalendarTemplatePage : BaseStandardPage<ICalMessage, Int32>
    {

        #region Properties

        /// <summary>
        /// Gets the text displayed within the header of the page
        /// </summary>
        public override string DefaultTitle
        {
            get
            {
                return "iCalendar template - " + this.Data.Name;
            }
        }

        /// <summary>
        /// Gets the delegated method for loading the API object that is presented within the page
        /// </summary>
        public override Func<Int32, ICalMessage> DataLoader
        {
            get
            {
               
                int id = Convert.ToInt32(this.Request.QueryString["id"]);
                return ICalMessage.FetchById;
            }
        }

        /// <summary>
        /// Gets the delegated method for creating the API object that is presented within the page
        /// </summary>
        public override Func<ICalMessage> DataCreator
        {
            get
            {
                return ICalMessage.Create;
            }
        }

        /// <summary>
        /// Gets the icon displayed within the header of the page.
        /// </summary>
        public override string DefaultIcon
        {
            get
            {
                return "calendar_plus";
            }
        }

        #endregion

        #region Methods

        protected override void PopulateControls()
        {
            this.ICalendarTemplateDetail.DataSource = this.Data;
        }

        #endregion
    }
}