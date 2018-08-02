using Consensus.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance
{
    public partial class GiftAidClaimPage : BaseStandardPage<Giftaidclaim, Int32>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Gift Aid Claim - " + this.Data.Id; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "downloads"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<Int32, Giftaidclaim> DataLoader
        {
            get { return Giftaidclaim.FetchById; }
        }
        /// <summary>
        /// Gets the delegated method for creating the API object that is presented within the page
        /// </summary>
        public override Func<Giftaidclaim> DataCreator
        {
            get
            {
                return Giftaidclaim.Create;
            }
        }
        #endregion

        #region Methods

        protected override void PopulateControls()
        {
            base.PopulateControls();
            this.GiftAidClaimDetails.DataSource = this.Data;
            this.GiftAidClaimBatchList.GiftAidClaimId = this.Data.Id;
        }

        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }
        #endregion

    }
}