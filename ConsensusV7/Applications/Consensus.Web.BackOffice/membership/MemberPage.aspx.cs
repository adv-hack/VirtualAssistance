using Consensus.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Finance;

namespace Consensus.Web.BackOffice.membership
{
    public partial class MemberPage : BaseStandardPage<MemberPeriod, String>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get
            {
                string title = "Member - ";
                string memberName = "";
                for (int i = 0; i < this.Data.MemberLocations.Count; i++)
                {
                    if (this.Data.MemberLocations[i].RenewLoc == 1)
                        memberName = this.Data.MemberLocations[i].Role.Person.FirstName + " " + this.Data.MemberLocations[i].Role.Person.Surname;
                }
                title += memberName;
                return title;
            }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "membership_card"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, MemberPeriod> DataLoader
        {
            get { return MemberPeriod.FetchById; }
        }

        /// <summary>
        ///     Gets the delegated method for creating the API object that is presented within the page.
        /// </summary>
        public override Func<MemberPeriod> DataCreator
        {
            get { return MemberPeriod.Create; }
        }

        #endregion

        #region methods

        protected override void PopulateControls()
        {
            this.MemberDetails.DataSource = this.Data;
            this.BillingDetails.DataSource = this.Data;
            this.MemberLocationsList.MemberPeriodId = this.Data.Id;
            this.MemberLocationsList.MembershipId = this.Data.MemIdId;
            this.MemberPeriodsList.MemberPeriodId = this.Data.Id;
            this.MemberPeriodsList.MembershipId = this.Data.MemIdId;
            this.MemberInvoiceList.MemberPeriodId = this.Data.Id;
            this.MembershipCreditNoteList.MembershipPeriodID = this.Data.Id;
            this.MembershipDirectDebitList.MemberPeriodId = this.Data.Id;
            this.MemberGradeList.MemberPeriodId = this.Data.Id;
            this.MemberDiscountList.MemberPeriodId = this.Data.Id;
            this.MemberGradeList.ProdId = this.Data.ProductId;
            this.MemberSpecialistGroupList.MemberPeriodId = this.Data.Id;
            this.MemberBranchList.MemberPeriodId = this.Data.Id;
            this.ConsultantSchemeList.MemberPeriodId = this.Data.Id;

            for (int i = 0; i < this.Data.MemberLocations.Count; i++)
            {
                if (this.Data.MemberLocations[i].RenewLoc == 1)
                    this.PersonDetail.DataSource = this.Data.MemberLocations[i];
            } 

            if (CanRollback())
            {
                this.PopulateSideBar("javascript:rollbackMembership('" + this.Data.Id + "');", "Rollback membership");
                this.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID, @"
                function rollbackMembership(memberPeriodId) {
                    consensus.web.popupFrame({
                        url: consensus.resolveUrl('~/GenericPopup.aspx?context=membership&control=rollbackMembership&Id=' + memberPeriodId),
                        open: function () {
                            var button = $(this.window.document.body).find('#Content_PopupFooter_SaveButton');
                            var state = new consensus.data.state(button, { uri: 'membership/memberperiod/' + memberPeriodId }, this.window);
                            consensus.data.setState(state);
                        },
                        result: function (data) {
                          consensus.network.send({
                            method: 'post',
                            url: 'membership/memberperiod/rollbackMembership?memberPeriodId=' + data.Id + '&status=' + data.StatusCode ,
                            success: function (result) {
                              window.location.href = consensus.resolveUrl('~/membership/member?id=' + result.Id);
                            }
                          });
                        }
                    });
                }
            ", true);
            }

            this.PopulateSideBar("javascript:createInvoice('" + this.Data.Id + "');", "Create Invoice");
            SetSendPackSidebarOption();
        }

        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }

        protected bool CanRollback()
        {
            if (this.Data.Id != null)
            {
                foreach (Invoice invoice in this.Data.InvHeader)
                {
                    if (invoice.TypeCode != "Credit")
                    {
                        if (InvoiceLine.FetchAllByInvoiceId(invoice.Id).Where(line => line.Credited == 1).Count() == 0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        #endregion
    }
}