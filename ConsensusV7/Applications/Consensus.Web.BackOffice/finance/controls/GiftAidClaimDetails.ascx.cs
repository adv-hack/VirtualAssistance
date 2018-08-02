using Consensus.Contact;
using Consensus.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class GiftAidClaimDetails : BaseControl<Giftaidclaim, String>
    {
        #region Properties
        public override String DataTypeName
        {
            get { return "GiftAidClaim"; }
        }
        #endregion
        #region Methods
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            //set defaults
            
            this.SellingCompany.DataSource = Common.SellingCompany.FetchAll();
            if (this.DataSource == null || this.DataSource.Id == 0)
            {
                this.SellingCompany.FieldValue = this.CurrentSession.User.SellingCompanyId;
                this.org.FieldValue = Role.FetchAllByPersonId(this.CurrentSession.User.PersonId).FirstOrDefault().OrganisationId;
                this.org.FieldText = Role.FetchAllByPersonId(this.CurrentSession.User.PersonId).FirstOrDefault().Organisation.Name;
                this.claimDate.FieldValue = DateTime.Now;
            }
        }

        protected override void PopulateControl()
        {
            base.PopulateControl();

            if (this.DataSource.Id == 0) // if the first record is added
            {
                this.claimDate.FieldValue = DateTime.Now;
            }
            else if(!string.IsNullOrEmpty(this.claimId.FieldValue))
            {
                this.donationsFrom.FieldValue = this.DataSource.DonationsFrom;
                this.donationsTo.FieldValue = this.DataSource.DonationsTo;
                this.AccountingPeriodEnd.FieldValue = this.DataSource.AccountingPeriodEnd;

                if (this.DataSource.Process == 1)
                    ChangeMode();
            }
        }

        private void ChangeMode()
        {
            this.claimDate.IsReadOnly           = UserInterface.ConfigurableBoolean.True;
            this.donationsFrom.IsReadOnly       = UserInterface.ConfigurableBoolean.True;
            this.donationsTo.IsReadOnly         = UserInterface.ConfigurableBoolean.True;

            this.submitter.IsReadOnly           = UserInterface.ConfigurableBoolean.True;
            this.trustee.IsReadOnly             = UserInterface.ConfigurableBoolean.True;
            this.AccountingPeriodEnd.IsReadOnly = UserInterface.ConfigurableBoolean.True;

            this.org.IsReadOnly                 = UserInterface.ConfigurableBoolean.True;
            this.hmrcRef.IsReadOnly             = UserInterface.ConfigurableBoolean.True;
            this.regulatorName.IsReadOnly       = UserInterface.ConfigurableBoolean.True;
            this.regulatorNum.IsReadOnly        = UserInterface.ConfigurableBoolean.True;
            this.adjustment.IsReadOnly          = UserInterface.ConfigurableBoolean.True;
            this.process.IsReadOnly             = UserInterface.ConfigurableBoolean.True;
            this.SellingCompany.IsReadOnly      = UserInterface.ConfigurableBoolean.True;
        }
        #endregion
    }
}