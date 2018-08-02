using Consensus.Sales;
using Consensus.Marketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Web.BackOffice.marketing;

namespace Consensus.Web.BackOffice.marketing
{
    public partial class SourcePage : BaseStandardPage<Promotion, String>
    {
        public override Func<String, Promotion> DataLoader
        {
            get { return Promotion.FetchById; }
        }

        public override Func<Promotion> DataCreator
        {
            get { return Promotion.Create; }
        }

        public override string DefaultTitle
        {
            get { return "Promotion Source - " + this.Data.Name; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override string DefaultIcon
        {
          get { return "tag"; }
        }

        protected override void PopulateControls()
        {
            // Get the promotion source to be displayed
            Promotion Source = this.Data;

            this.SourceDetail.DataSource = Source;
            this.SourceStatisticsDetail.DataSource = Source;
        }
    }
}