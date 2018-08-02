using Consensus.Contact;
using Consensus.Sales;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Web.BackOffice.crm
{
    public partial class PersonPage : BaseStandardPage<Person, String>
    {
        #region fields

        /// <summary>
        ///     The role that data will be restricted to.
        /// </summary>
        private Role _role;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the role that data will be restricted to.
        /// </summary>
        /// <remarks>
        ///     If this property returns null, data for all of the persons roles will be displayed.
        /// </remarks>
        public Role Role
        {
            get
            {
                if (_role == null && !String.IsNullOrEmpty(this.Request.QueryString["role"]))
                    _role = Role.FetchById(this.Request.QueryString["role"]);

                return _role;
            }
        }

        /// <summary>
        ///     Gets the instance of the API object that is presented within the page.
        /// </summary>
        public override Person Data
        {
            get
            {
                if (this.Role != null)
                    return this.Role.Person;
                else
                    return base.Data;
            }
        }

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Person - " + this.Data.PrincipalRole.PersonName; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "contacts"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, Person> DataLoader
        {
            get { return Person.FetchById; }
        }

        /// <summary>
        ///     Gets the delegated method for creating the API object that is presented within the page.
        /// </summary>
        public override Func<Person> DataCreator
        {
            get { return Person.Create; }
        }

        /// <summary>
        ///     Gets the REST api used for saving the object.
        /// </summary>
        public override String SaveUri
        {
            get
            {
                String typeContext = String.Join(".", typeof(Role).Namespace.Split('.').Skip(1));
                String relativeUri = String.Format("{0}/{1}", typeContext, typeof(Role).Name);
                return relativeUri;
            }
        }

        /// <summary>
        ///     Gets the id of the object being saved via the REST api.
        /// </summary>
        public override String SaveId
        {
            get { return (this.Role ?? this.Data.PrincipalRole).Id; }
        }

        #endregion

        #region methods

        protected override void OnPreRender(EventArgs eventArguments)
        {
            base.OnPreRender(eventArguments);
        }

        protected override void PopulateControls()
        {
            this.PersonDetail.DataSource = this.Role ?? this.Data.PrincipalRole;
            this.RoleDetail.DataSource = this.Role ?? this.Data.PrincipalRole;
            this.DataProtection.DataSource = this.Role ?? this.Data.PrincipalRole;

            this.RoleList.PersonId = this.Data.Id;
            this.RoleList.ExcludeRoleId = (this.Role ?? this.Data.PrincipalRole).Id;

            this.AssociatesList.AssociateParentId = this.Role == null ? this.Data.Id : this.Role.Id;
            this.AssociatesList.AssociateType = this.Role == null ? AssociateList.AssociateListMode.PersonAssociatesByPerson : AssociateList.AssociateListMode.PersonAssociatesByRole;
            this.AssociatesWith.AssociateParentId = this.Role == null ? this.Data.Id : this.Role.Id;
            this.AssociatesWith.AssociateType = this.Role == null ? AssociateList.AssociateListMode.PersonAssociatedWithByPerson : AssociateList.AssociateListMode.PersonAssociatedWithByRole;

            this.ProfileList.ProfileParentId = this.Data.Id;
            this.ProfileList.ProfileMode = ProfileList.ProfileListMode.PROF_PERSON_ID;

            this.OppList.OpportunityParentId = this.Role == null ? this.Data.Id : this.Role.Id;
            this.OppList.OpportunityMode = this.Role == null ? OpportunityList.OpportunityListMode.EndUserPerson : OpportunityList.OpportunityListMode.EndUserRole;
            this.OppList.OpportunitySyType = OpportunitySyType.Opportunity;

            this.GrantApplicationList.OpportunityParentId = this.Role == null ? this.Data.Id : this.Role.Id;
            this.GrantApplicationList.OpportunityMode = this.Role == null ? OpportunityList.OpportunityListMode.EndUserPerson : OpportunityList.OpportunityListMode.EndUserRole;
            this.GrantApplicationList.OpportunitySyType = OpportunitySyType.GrantApplication;

            this.LegacyList.OpportunityParentId = this.Role == null ? this.Data.Id : this.Role.Id;
            this.LegacyList.OpportunityMode = this.Role == null ? OpportunityList.OpportunityListMode.EndUserPerson : OpportunityList.OpportunityListMode.EndUserRole;
            this.LegacyList.OpportunitySyType = OpportunitySyType.Legacies;

            this.MajorDonorList.OpportunityParentId = this.Role == null ? this.Data.Id : this.Role.Id;
            this.MajorDonorList.OpportunityMode = this.Role == null ? OpportunityList.OpportunityListMode.EndUserPerson : OpportunityList.OpportunityListMode.EndUserRole;
            this.MajorDonorList.OpportunitySyType = OpportunitySyType.Donors;

            this.PledgeList.OpportunityParentId = this.Role == null ? this.Data.Id : this.Role.Id;
            this.PledgeList.OpportunityMode = this.Role == null ? OpportunityList.OpportunityListMode.EndUserPerson : OpportunityList.OpportunityListMode.EndUserRole;
            this.PledgeList.OpportunitySyType = OpportunitySyType.Pledges;

            this.MembershipList.DataSource = String.IsNullOrEmpty(this.Request.QueryString["role"]) ? this.Data as Proxy : this.Role as Proxy;

            this.EmailList.ActivityType = "Letter";
            this.EmailList.ActivityParentId = this.Role == null ? this.Data.Id : this.Role.Id;
            this.EmailList.ActivityMode = this.Role == null ? ActivityList.ActivityListMode.PN_ID : ActivityList.ActivityListMode.PROLE_ID;
            this.DiaryList.ActivityType = "D-";
            this.DiaryList.ActivityMode = this.Role == null ? ActivityList.ActivityListMode.PN_ID : ActivityList.ActivityListMode.PROLE_ID;
            this.DiaryList.ActivityParentId = this.Role == null ? this.Data.Id : this.Role.Id;
            this.GiftAidList.PersonId = this.Data.Id;
            this.DonationList.DonationType = learning.controls.DonationList.DonationSearchListMode.Person;
            this.DonationList.ParentId = this.Data.Id;
            this.CommunicationList.DataTable.Json = "{ roleId: \"" + (this.Role ?? this.Data.PrincipalRole).Id + "\" }";

            IEnumerable<CommunicationsRole> communicationsRoles =
                CommunicationsRole.FetchAllByRoleId((this.Role ?? this.Data.PrincipalRole).Id);

            this.CommunicationList.CommunicationsData = communicationsRoles;

            this.MailingListList.MailingListParentId = this.Data.Id;
            this.ComplaintList.PersonId = this.Data.Id;
            this.InfoRequestList.PersonId = this.Data.Id;

            Role homeRole = (this.Role ?? this.Data.PrincipalRole).HomeRole;
            if (this.TopTabControl.Pages[2].Visible = homeRole.IsPersisted)
            {
                this.HomeAddress.OrganisationId = homeRole.OrganisationId;
                this.HomeAddress.DataSource = homeRole.Address;
                this.HomeAddress.PersonId = homeRole.PersonId;
                this.HomeAddress.DisplayAltAddressButton = false;
            }

            if (this.Data.ActiveUserAccount.Id != 0 && CurrentSession.User.SysAdmin == 1)
            {
                this.PopulateSideBar("javascript:ViewAccount('" + this.Data.ActiveUserAccount.Id + "');", "User Account");

                this.ClientScript.RegisterClientScriptBlock(this.GetType(), this.UniqueID, @"
                function ViewAccount(userid) {
                    window.location.href = consensus.resolveUrl('~/security/UserAccount?id=' + userid);
                }
            ", true);
            }

            if (this.Data.ActiveUserAccount.Id == 0 && CurrentSession.User.SysAdmin == 1 && this.Data.OurPerson == 1)
            {
                this.PopulateSideBar("javascript:CreateUserAccount('" + this.Data.ActiveUserAccount.Id + "');", "Create user account");

                this.ClientScript.RegisterClientScriptBlock(this.GetType(), this.UniqueID, @"
                function CreateUserAccount(userid) {                    
                     window.location.href = consensus.resolveUrl('~/security/UserAccount?personId=" + this.Data.Id + "');}", true);
            }

            if (!String.IsNullOrEmpty(this.Data.Id))
            {
                this.PopulateSideBar("javascript:confirmAnonymise('" + this.Data.Id + "');", "Anonymise");
                this.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID, @"
                function anonymisePerson(personId, userId) {                             
                          consensus.network.send({
                            method: 'post',
                            url: 'contact/person/anonymisePerson?personId=' + personId,
                            success: function (result) {
                              swal({ title: 'Success', text: 'Record successfully anonymised', type: 'warning', showCancelButton: false, confirmButtonText: 'Ok', confirmButtonClass: 'btn btn-default', buttonsStyling: false }).then(function (success) { 
                                window.location.href = consensus.resolveUrl('~/crm/person?id=' + result.Id);
                                });
                               
                            }
                          });
                }

                function confirmAnonymise(personId, userId) {
	                    window.top.swal.call(window.top, { title: 'Warning', text: 'This will remove all identifiable data from this person. Are you sure that you want to continue?', type: 'warning', showCancelButton: true, confirmButtonText: 'Yes', cancelButtonText: 'No', confirmButtonClass: 'btn btn-danger', cancelButtonClass: 'btn btn-default', buttonsStyling: false }).then(function () {		                                            
				            anonymisePerson(personId, userId);				                                       			                    		                    
	                    },
                        function(){                            
                        }
                    );
                }
            ", true);
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