using Consensus.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.document
{
    
    public partial class SMSPage : BaseStandardPage<SmsMessage, Int32>
    {
        #region Properties

        /// <summary>
        /// Gets the text displayed within the header of the page
        /// </summary>
        public override string DefaultTitle
        {
            get
            {
                return "SMS template - " + this.Data.Name;
            }
        }

        /// <summary>
        /// Gets the delegated method for loading the API object that is presented within the page
        /// </summary>
        public override Func<int, SmsMessage> DataLoader
        {
            get
            {
                return SmsMessage.FetchById;
            }
        }

        /// <summary>
        /// Gets the delegated method for creating the API object that is presented within the page
        /// </summary>
        public override Func<SmsMessage> DataCreator
        {
            get
            {
                return SmsMessage.Create;
            }
        }

        /// <summary>
        /// Gets the icon displayed within the header of the page.
        /// </summary>
        public override string DefaultIcon
        {
            get
            {
                return "sms";
            }
        }

        #endregion

        #region methods

        protected override void PopulateControls()
        {
            this.SMSDetail.DataSource = this.Data;
        }

        #endregion

    }
}