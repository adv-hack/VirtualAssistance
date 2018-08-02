using Consensus.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance
{
    public partial class DirectDebitPage : BaseStandardPage<DirectDebit, String>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Direct Debit -  " + this.Data.Id; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "lifecycle"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, DirectDebit> DataLoader
        {
            get { return DirectDebit.FetchById; }
        }

        public override Func<DirectDebit> DataCreator
        {
            get { return DirectDebit.Create; }

        }
        #endregion

        #region methods

        protected override void PopulateControls()
        {
            this.DirectDebitDetail.DataSource = this.Data;

        }

        #endregion
    }
}