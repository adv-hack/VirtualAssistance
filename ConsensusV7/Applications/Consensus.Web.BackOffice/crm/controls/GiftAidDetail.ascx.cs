using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Contact;
using Consensus.Common;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class GiftAidDetail : BaseControl<Giftaid, Int32>
    {
        public override String DataTypeName
        {
            get { return "Gift Aid declaration"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<Int32, Giftaid> DataLoader
        {
            get { return Giftaid.FetchById; }
        }

        protected override void OnInit(EventArgs e)
        {
          base.OnInit(e);
          if (this.DataSource == null)
          {
            this.StartDate.FieldValue = DateTime.Now.Date;
          }
        }
    }
}