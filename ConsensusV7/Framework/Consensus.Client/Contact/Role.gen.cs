using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;
using Consensus.Document;
using Consensus.Finance;
using Consensus.Learning;
using Consensus.Marketing;
using Consensus.Membership;
using Consensus.Portal;
using Consensus.Sales;
using Consensus.Security;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents A role held by a person.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Role : Proxy<IRoleModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="HomeRole" /> member.
        /// </summary>
        private Consensus.Contact.Role _homeRole;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Person" /> member.
        /// </summary>
        private Consensus.Contact.Person _person;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Organisation" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _organisation;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="JobType" /> member.
        /// </summary>
        private Consensus.Common.Code _jobType;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Address" /> member.
        /// </summary>
        private Consensus.Contact.Address _address;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="UnionRolNo" /> member.
        /// </summary>
        private Consensus.Common.Code _unionRolNo;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Type" /> member.
        /// </summary>
        private Consensus.Common.Code _type;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="CostCode" /> member.
        /// </summary>
        private Consensus.Common.Code _costCode;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="JobLevel" /> member.
        /// </summary>
        private Consensus.Common.Code _jobLevel;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="AssociatedPeople" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Associate, Consensus.Contact.IAssociateModel> _associatedPeople;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Associates" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Associate, Consensus.Contact.IAssociateModel> _associates;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Locations" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Location, Consensus.Contact.ILocationModel> _locations;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="TrainersRole" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Trainer, Consensus.Contact.ITrainerModel> _trainersRole;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="RoleCommunication" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.CommunicationsRole, Consensus.Contact.ICommunicationsRoleModel> _roleCommunication;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ManagerProleId" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel> _managerProleId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Product" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel> _product;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Events" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel> _events;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="EventsContact" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel> _eventsContact;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SupplierEvents" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel> _supplierEvents;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="EventsMainTrainer" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel> _eventsMainTrainer;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Bookings" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel> _bookings;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="InvoiceBookings" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel> _invoiceBookings;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Learners" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Learner, Consensus.Learning.ILearnerModel> _learners;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="TemplateTrainers" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.TemplateTrainer, Consensus.Learning.ITemplateTrainerModel> _templateTrainers;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="OpportunityXrefs" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Sales.OpportunityXref, Consensus.Sales.IOpportunityXrefModel> _opportunityXrefs;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PackSender" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.Pack, Consensus.Document.IPackModel> _packSender;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="LetterTemplates" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.LetterTemplate, Consensus.Document.ILetterTemplateModel> _letterTemplates;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="OutputQueues" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.OutputQueue, Consensus.Document.IOutputQueueModel> _outputQueues;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Accounts" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Account, Consensus.Finance.IAccountModel> _accounts;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="AccountXrefs" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.AccountXref, Consensus.Finance.IAccountXrefModel> _accountXrefs;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Payments" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Payment, Consensus.Finance.IPaymentModel> _payments;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SalesPersonInvoices" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Invoice, Consensus.Finance.IInvoiceModel> _salesPersonInvoices;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Invoices" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Invoice, Consensus.Finance.IInvoiceModel> _invoices;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PrepayAccount" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.PrepayAccount, Consensus.Finance.IPrepayAccountModel> _prepayAccount;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="GiftaidclaimsSubmitter" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Giftaidclaim, Consensus.Finance.IGiftaidclaimModel> _giftaidclaimsSubmitter;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="GiftaidclaimsTrustee" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Giftaidclaim, Consensus.Finance.IGiftaidclaimModel> _giftaidclaimsTrustee;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ActivityXRefs" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.ActivityXref, Consensus.Activities.IActivityXrefModel> _activityXRefs;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="HelpdeskProleId" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.Helpdesk, Consensus.Activities.IHelpdeskModel> _helpdeskProleId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="HelpdeskGivenToId" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.Helpdesk, Consensus.Activities.IHelpdeskModel> _helpdeskGivenToId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ComplaintComplainant" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.Complaint, Consensus.Activities.IComplaintModel> _complaintComplainant;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ComplaintRegarding" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.Complaint, Consensus.Activities.IComplaintModel> _complaintRegarding;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ComplaintAssignedTo" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.Complaint, Consensus.Activities.IComplaintModel> _complaintAssignedTo;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ComplaintOwner" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.Complaint, Consensus.Activities.IComplaintModel> _complaintOwner;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Licenses" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Security.License, Consensus.Security.ILicenseModel> _licenses;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="InvoiceMemberPeriods" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.MemberPeriod, Consensus.Membership.IMemberPeriodModel> _invoiceMemberPeriods;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MemberLocations" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.MemberLocation, Consensus.Membership.IMemberLocationModel> _memberLocations;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="CampaignManager" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.Campaign, Consensus.Marketing.ICampaignModel> _campaignManager;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="CampaignApprover" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.Campaign, Consensus.Marketing.ICampaignModel> _campaignApprover;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PromotionManager" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.Promotion, Consensus.Marketing.IPromotionModel> _promotionManager;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PromotionApprover" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.Promotion, Consensus.Marketing.IPromotionModel> _promotionApprover;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PromotionMasterManager" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.PromotionMaster, Consensus.Marketing.IPromotionMasterModel> _promotionMasterManager;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PromotionMasterApprover" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.PromotionMaster, Consensus.Marketing.IPromotionMasterModel> _promotionMasterApprover;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SaqStepOwnerRole" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.SaqStep, Consensus.Marketing.ISaqStepModel> _saqStepOwnerRole;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SaqQueryManager" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.SaqQuery, Consensus.Marketing.ISaqQueryModel> _saqQueryManager;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SaqQueryApprover" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.SaqQuery, Consensus.Marketing.ISaqQueryModel> _saqQueryApprover;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MailingListOwners" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.MailingList, Consensus.Marketing.IMailingListModel> _mailingListOwners;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PortalUsers" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Portal.PortalUser, Consensus.Portal.IPortalUserModel> _portalUsers;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the persons home role.
        /// </summary>
        public Consensus.Contact.Role HomeRole
        {
            get
            {
                if (_homeRole == null && this.Model.HomeRole != null)
                    _homeRole = new Consensus.Contact.Role(this.Model.HomeRole);
                if (_homeRole == null)
                    _homeRole = Consensus.Contact.Role.Create();
                return _homeRole;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_DO_NOT_FAX" field.
        /// </summary>
        public System.Boolean DoNotFax
        {
            get { return this.Model.DoNotFax; }
            set { this.Model.DoNotFax = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_DO_NOT_EMAIL" field.
        /// </summary>
        public System.Boolean DoNotEmail
        {
            get { return this.Model.DoNotEmail; }
            set { this.Model.DoNotEmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_DO_NOT_SWAP" field.
        /// </summary>
        public System.Boolean DoNotSwap
        {
            get { return this.Model.DoNotSwap; }
            set { this.Model.DoNotSwap = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_DO_NOT_MAIL" field.
        /// </summary>
        public System.Boolean DoNotMail
        {
            get { return this.Model.DoNotMail; }
            set { this.Model.DoNotMail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_USERNUM_1" field.
        /// </summary>
        public System.Boolean DoNotTelesale
        {
            get { return this.Model.DoNotTelesale; }
            set { this.Model.DoNotTelesale = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_DIS_FLAG" field.
        /// </summary>
        public System.Boolean IsRoleDisabled
        {
            get { return this.Model.IsRoleDisabled; }
            set { this.Model.IsRoleDisabled = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_PERSON_ID" field.
        /// </summary>
        public Consensus.Contact.Person Person
        {
            get
            {
                if (_person == null && this.Model.Person != null)
                    _person = new Consensus.Contact.Person(this.Model.Person);
                if (_person == null)
                    _person = Consensus.Contact.Person.Create();
                return _person;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_PERSON_ID" field.
        /// </summary>
        public System.String PersonId
        {
            get { return this.Model.PersonId; }
            set { this.Model.PersonId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_ORG_ID" field.
        /// </summary>
        public Consensus.Contact.Organisation Organisation
        {
            get
            {
                if (_organisation == null && this.Model.Organisation != null)
                    _organisation = new Consensus.Contact.Organisation(this.Model.Organisation);
                if (_organisation == null)
                    _organisation = Consensus.Contact.Organisation.Create();
                return _organisation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_ORG_ID" field.
        /// </summary>
        public System.String OrganisationId
        {
            get { return this.Model.OrganisationId; }
            set { this.Model.OrganisationId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_POS_TITLE" field.
        /// </summary>
        public System.String JobTitle
        {
            get { return this.Model.JobTitle; }
            set { this.Model.JobTitle = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_POS_TYPE" field.
        /// </summary>
        public Consensus.Common.Code JobType
        {
            get
            {
                if (_jobType == null && this.Model.JobType != null)
                    _jobType = new Consensus.Common.Code(this.Model.JobType);
                if (_jobType == null)
                    _jobType = Consensus.Common.Code.Create();
                return _jobType;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_POS_TYPE" field.
        /// </summary>
        public System.String JobTypeCode
        {
            get { return this.Model.JobTypeCode; }
            set { this.Model.JobTypeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_PHONE" field.
        /// </summary>
        public System.String Telephone
        {
            get { return this.Model.Telephone; }
            set { this.Model.Telephone = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_FAX" field.
        /// </summary>
        public System.String Fax
        {
            get { return this.Model.Fax; }
            set { this.Model.Fax = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_MOBILE" field.
        /// </summary>
        public System.String Mobile
        {
            get { return this.Model.Mobile; }
            set { this.Model.Mobile = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_PRINCIP_ROLE" field.
        /// </summary>
        public System.Nullable<System.Byte> IsPrincipal
        {
            get { return this.Model.IsPrincipal; }
            set { this.Model.IsPrincipal = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_ADD_ID" field.
        /// </summary>
        public Consensus.Contact.Address Address
        {
            get
            {
                if (_address == null && this.Model.Address != null)
                    _address = new Consensus.Contact.Address(this.Model.Address);
                if (_address == null)
                    _address = Consensus.Contact.Address.Create();
                return _address;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_ADD_ID" field.
        /// </summary>
        public System.String AddressId
        {
            get { return this.Model.AddressId; }
            set { this.Model.AddressId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_START_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> StartDate
        {
            get { return this.Model.StartDate; }
            set { this.Model.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_END_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> EndDate
        {
            get { return this.Model.EndDate; }
            set { this.Model.EndDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_UNION_ROL_NO" field.
        /// </summary>
        public Consensus.Common.Code UnionRolNo
        {
            get
            {
                if (_unionRolNo == null && this.Model.UnionRolNo != null)
                    _unionRolNo = new Consensus.Common.Code(this.Model.UnionRolNo);
                if (_unionRolNo == null)
                    _unionRolNo = Consensus.Common.Code.Create();
                return _unionRolNo;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_UNION_ROL_NO" field.
        /// </summary>
        public System.String UnionRolNoCode
        {
            get { return this.Model.UnionRolNoCode; }
            set { this.Model.UnionRolNoCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_TYPE" field.
        /// </summary>
        public Consensus.Common.Code Type
        {
            get
            {
                if (_type == null && this.Model.Type != null)
                    _type = new Consensus.Common.Code(this.Model.Type);
                if (_type == null)
                    _type = Consensus.Common.Code.Create();
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_TYPE" field.
        /// </summary>
        public System.String TypeCode
        {
            get { return this.Model.TypeCode; }
            set { this.Model.TypeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_EMAIL" field.
        /// </summary>
        public System.String Email
        {
            get { return this.Model.Email; }
            set { this.Model.Email = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_PN_NAME" field.
        /// </summary>
        public System.String PersonName
        {
            get { return this.Model.PersonName; }
            set { this.Model.PersonName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_PAYROLL" field.
        /// </summary>
        public System.String Payroll
        {
            get { return this.Model.Payroll; }
            set { this.Model.Payroll = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_STAFF_NO" field.
        /// </summary>
        public System.String StaffNo
        {
            get { return this.Model.StaffNo; }
            set { this.Model.StaffNo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_KEY_CONTACT" field.
        /// </summary>
        public System.Nullable<System.Byte> KeyContact
        {
            get { return this.Model.KeyContact; }
            set { this.Model.KeyContact = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_COST_CODE" field.
        /// </summary>
        public Consensus.Common.Code CostCode
        {
            get
            {
                if (_costCode == null && this.Model.CostCode != null)
                    _costCode = new Consensus.Common.Code(this.Model.CostCode);
                if (_costCode == null)
                    _costCode = Consensus.Common.Code.Create();
                return _costCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_COST_CODE" field.
        /// </summary>
        public System.String CostCodeCode
        {
            get { return this.Model.CostCodeCode; }
            set { this.Model.CostCodeCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_SELCO_SP_ID" field.
        /// </summary>
        public Consensus.Common.SellingCompany SellingCompany
        {
            get
            {
                if (_sellingCompany == null && this.Model.SellingCompany != null)
                    _sellingCompany = new Consensus.Common.SellingCompany(this.Model.SellingCompany);
                if (_sellingCompany == null)
                    _sellingCompany = Consensus.Common.SellingCompany.Create();
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_HOUR_RTE" field.
        /// </summary>
        public System.Decimal HourlyRate
        {
            get { return this.Model.HourlyRate; }
            set { this.Model.HourlyRate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_JOB_LVL" field.
        /// </summary>
        public Consensus.Common.Code JobLevel
        {
            get
            {
                if (_jobLevel == null && this.Model.JobLevel != null)
                    _jobLevel = new Consensus.Common.Code(this.Model.JobLevel);
                if (_jobLevel == null)
                    _jobLevel = Consensus.Common.Code.Create();
                return _jobLevel;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_JOB_LVL" field.
        /// </summary>
        public System.String JobLevelCode
        {
            get { return this.Model.JobLevelCode; }
            set { this.Model.JobLevelCode = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AssociateModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Contact.Associate> AssociatedPeople
        {
            get
            {
                if (_associatedPeople == null)
                    _associatedPeople = new ProxyCollection<Consensus.Contact.Associate, Consensus.Contact.IAssociateModel>(this.Model.AssociatedPeople, model => new Consensus.Contact.Associate(model));
                return _associatedPeople;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AssociateModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Contact.Associate> Associates
        {
            get
            {
                if (_associates == null)
                    _associates = new ProxyCollection<Consensus.Contact.Associate, Consensus.Contact.IAssociateModel>(this.Model.Associates, model => new Consensus.Contact.Associate(model));
                return _associates;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LocationModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Contact.Location> Locations
        {
            get
            {
                if (_locations == null)
                    _locations = new ProxyCollection<Consensus.Contact.Location, Consensus.Contact.ILocationModel>(this.Model.Locations, model => new Consensus.Contact.Location(model));
                return _locations;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TrainerModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Contact.Trainer> TrainersRole
        {
            get
            {
                if (_trainersRole == null)
                    _trainersRole = new ProxyCollection<Consensus.Contact.Trainer, Consensus.Contact.ITrainerModel>(this.Model.TrainersRole, model => new Consensus.Contact.Trainer(model));
                return _trainersRole;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CommunicationsRoleModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Contact.CommunicationsRole> RoleCommunication
        {
            get
            {
                if (_roleCommunication == null)
                    _roleCommunication = new ProxyCollection<Consensus.Contact.CommunicationsRole, Consensus.Contact.ICommunicationsRoleModel>(this.Model.RoleCommunication, model => new Consensus.Contact.CommunicationsRole(model));
                return _roleCommunication;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Product> ManagerProleId
        {
            get
            {
                if (_managerProleId == null)
                    _managerProleId = new ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel>(this.Model.ManagerProleId, model => new Consensus.Learning.Product(model));
                return _managerProleId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Product> Product
        {
            get
            {
                if (_product == null)
                    _product = new ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel>(this.Model.Product, model => new Consensus.Learning.Product(model));
                return _product;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.Event> Events
        {
            get
            {
                if (_events == null)
                    _events = new ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel>(this.Model.Events, model => new Consensus.Learning.Event(model));
                return _events;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.Event> EventsContact
        {
            get
            {
                if (_eventsContact == null)
                    _eventsContact = new ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel>(this.Model.EventsContact, model => new Consensus.Learning.Event(model));
                return _eventsContact;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.Event> SupplierEvents
        {
            get
            {
                if (_supplierEvents == null)
                    _supplierEvents = new ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel>(this.Model.SupplierEvents, model => new Consensus.Learning.Event(model));
                return _supplierEvents;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.Event> EventsMainTrainer
        {
            get
            {
                if (_eventsMainTrainer == null)
                    _eventsMainTrainer = new ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel>(this.Model.EventsMainTrainer, model => new Consensus.Learning.Event(model));
                return _eventsMainTrainer;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Booking> Bookings
        {
            get
            {
                if (_bookings == null)
                    _bookings = new ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel>(this.Model.Bookings, model => new Consensus.Learning.Booking(model));
                return _bookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Booking> InvoiceBookings
        {
            get
            {
                if (_invoiceBookings == null)
                    _invoiceBookings = new ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel>(this.Model.InvoiceBookings, model => new Consensus.Learning.Booking(model));
                return _invoiceBookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LearnerModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Learner> Learners
        {
            get
            {
                if (_learners == null)
                    _learners = new ProxyCollection<Consensus.Learning.Learner, Consensus.Learning.ILearnerModel>(this.Model.Learners, model => new Consensus.Learning.Learner(model));
                return _learners;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TemplateTrainerModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Learning.TemplateTrainer> TemplateTrainers
        {
            get
            {
                if (_templateTrainers == null)
                    _templateTrainers = new ProxyCollection<Consensus.Learning.TemplateTrainer, Consensus.Learning.ITemplateTrainerModel>(this.Model.TemplateTrainers, model => new Consensus.Learning.TemplateTrainer(model));
                return _templateTrainers;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityXrefModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Sales.OpportunityXref> OpportunityXrefs
        {
            get
            {
                if (_opportunityXrefs == null)
                    _opportunityXrefs = new ProxyCollection<Consensus.Sales.OpportunityXref, Consensus.Sales.IOpportunityXrefModel>(this.Model.OpportunityXrefs, model => new Consensus.Sales.OpportunityXref(model));
                return _opportunityXrefs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Document.Pack> PackSender
        {
            get
            {
                if (_packSender == null)
                    _packSender = new ProxyCollection<Consensus.Document.Pack, Consensus.Document.IPackModel>(this.Model.PackSender, model => new Consensus.Document.Pack(model));
                return _packSender;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LetterTemplateModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Document.LetterTemplate> LetterTemplates
        {
            get
            {
                if (_letterTemplates == null)
                    _letterTemplates = new ProxyCollection<Consensus.Document.LetterTemplate, Consensus.Document.ILetterTemplateModel>(this.Model.LetterTemplates, model => new Consensus.Document.LetterTemplate(model));
                return _letterTemplates;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OutputQueueModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Document.OutputQueue> OutputQueues
        {
            get
            {
                if (_outputQueues == null)
                    _outputQueues = new ProxyCollection<Consensus.Document.OutputQueue, Consensus.Document.IOutputQueueModel>(this.Model.OutputQueues, model => new Consensus.Document.OutputQueue(model));
                return _outputQueues;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Finance.Account> Accounts
        {
            get
            {
                if (_accounts == null)
                    _accounts = new ProxyCollection<Consensus.Finance.Account, Consensus.Finance.IAccountModel>(this.Model.Accounts, model => new Consensus.Finance.Account(model));
                return _accounts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountXrefModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Finance.AccountXref> AccountXrefs
        {
            get
            {
                if (_accountXrefs == null)
                    _accountXrefs = new ProxyCollection<Consensus.Finance.AccountXref, Consensus.Finance.IAccountXrefModel>(this.Model.AccountXrefs, model => new Consensus.Finance.AccountXref(model));
                return _accountXrefs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Finance.Payment> Payments
        {
            get
            {
                if (_payments == null)
                    _payments = new ProxyCollection<Consensus.Finance.Payment, Consensus.Finance.IPaymentModel>(this.Model.Payments, model => new Consensus.Finance.Payment(model));
                return _payments;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Finance.Invoice> SalesPersonInvoices
        {
            get
            {
                if (_salesPersonInvoices == null)
                    _salesPersonInvoices = new ProxyCollection<Consensus.Finance.Invoice, Consensus.Finance.IInvoiceModel>(this.Model.SalesPersonInvoices, model => new Consensus.Finance.Invoice(model));
                return _salesPersonInvoices;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Finance.Invoice> Invoices
        {
            get
            {
                if (_invoices == null)
                    _invoices = new ProxyCollection<Consensus.Finance.Invoice, Consensus.Finance.IInvoiceModel>(this.Model.Invoices, model => new Consensus.Finance.Invoice(model));
                return _invoices;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrepayAccountModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Finance.PrepayAccount> PrepayAccount
        {
            get
            {
                if (_prepayAccount == null)
                    _prepayAccount = new ProxyCollection<Consensus.Finance.PrepayAccount, Consensus.Finance.IPrepayAccountModel>(this.Model.PrepayAccount, model => new Consensus.Finance.PrepayAccount(model));
                return _prepayAccount;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:GiftaidclaimModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Finance.Giftaidclaim> GiftaidclaimsSubmitter
        {
            get
            {
                if (_giftaidclaimsSubmitter == null)
                    _giftaidclaimsSubmitter = new ProxyCollection<Consensus.Finance.Giftaidclaim, Consensus.Finance.IGiftaidclaimModel>(this.Model.GiftaidclaimsSubmitter, model => new Consensus.Finance.Giftaidclaim(model));
                return _giftaidclaimsSubmitter;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:GiftaidclaimModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Finance.Giftaidclaim> GiftaidclaimsTrustee
        {
            get
            {
                if (_giftaidclaimsTrustee == null)
                    _giftaidclaimsTrustee = new ProxyCollection<Consensus.Finance.Giftaidclaim, Consensus.Finance.IGiftaidclaimModel>(this.Model.GiftaidclaimsTrustee, model => new Consensus.Finance.Giftaidclaim(model));
                return _giftaidclaimsTrustee;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityXrefModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Activities.ActivityXref> ActivityXRefs
        {
            get
            {
                if (_activityXRefs == null)
                    _activityXRefs = new ProxyCollection<Consensus.Activities.ActivityXref, Consensus.Activities.IActivityXrefModel>(this.Model.ActivityXRefs, model => new Consensus.Activities.ActivityXref(model));
                return _activityXRefs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Activities.Helpdesk> HelpdeskProleId
        {
            get
            {
                if (_helpdeskProleId == null)
                    _helpdeskProleId = new ProxyCollection<Consensus.Activities.Helpdesk, Consensus.Activities.IHelpdeskModel>(this.Model.HelpdeskProleId, model => new Consensus.Activities.Helpdesk(model));
                return _helpdeskProleId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Activities.Helpdesk> HelpdeskGivenToId
        {
            get
            {
                if (_helpdeskGivenToId == null)
                    _helpdeskGivenToId = new ProxyCollection<Consensus.Activities.Helpdesk, Consensus.Activities.IHelpdeskModel>(this.Model.HelpdeskGivenToId, model => new Consensus.Activities.Helpdesk(model));
                return _helpdeskGivenToId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ComplaintModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Activities.Complaint> ComplaintComplainant
        {
            get
            {
                if (_complaintComplainant == null)
                    _complaintComplainant = new ProxyCollection<Consensus.Activities.Complaint, Consensus.Activities.IComplaintModel>(this.Model.ComplaintComplainant, model => new Consensus.Activities.Complaint(model));
                return _complaintComplainant;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ComplaintModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Activities.Complaint> ComplaintRegarding
        {
            get
            {
                if (_complaintRegarding == null)
                    _complaintRegarding = new ProxyCollection<Consensus.Activities.Complaint, Consensus.Activities.IComplaintModel>(this.Model.ComplaintRegarding, model => new Consensus.Activities.Complaint(model));
                return _complaintRegarding;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ComplaintModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Activities.Complaint> ComplaintAssignedTo
        {
            get
            {
                if (_complaintAssignedTo == null)
                    _complaintAssignedTo = new ProxyCollection<Consensus.Activities.Complaint, Consensus.Activities.IComplaintModel>(this.Model.ComplaintAssignedTo, model => new Consensus.Activities.Complaint(model));
                return _complaintAssignedTo;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ComplaintModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Activities.Complaint> ComplaintOwner
        {
            get
            {
                if (_complaintOwner == null)
                    _complaintOwner = new ProxyCollection<Consensus.Activities.Complaint, Consensus.Activities.IComplaintModel>(this.Model.ComplaintOwner, model => new Consensus.Activities.Complaint(model));
                return _complaintOwner;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LicenseModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Security.License> Licenses
        {
            get
            {
                if (_licenses == null)
                    _licenses = new ProxyCollection<Consensus.Security.License, Consensus.Security.ILicenseModel>(this.Model.Licenses, model => new Consensus.Security.License(model));
                return _licenses;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Membership.MemberPeriod> InvoiceMemberPeriods
        {
            get
            {
                if (_invoiceMemberPeriods == null)
                    _invoiceMemberPeriods = new ProxyCollection<Consensus.Membership.MemberPeriod, Consensus.Membership.IMemberPeriodModel>(this.Model.InvoiceMemberPeriods, model => new Consensus.Membership.MemberPeriod(model));
                return _invoiceMemberPeriods;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Membership.MemberLocation> MemberLocations
        {
            get
            {
                if (_memberLocations == null)
                    _memberLocations = new ProxyCollection<Consensus.Membership.MemberLocation, Consensus.Membership.IMemberLocationModel>(this.Model.MemberLocations, model => new Consensus.Membership.MemberLocation(model));
                return _memberLocations;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CampaignModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.Campaign> CampaignManager
        {
            get
            {
                if (_campaignManager == null)
                    _campaignManager = new ProxyCollection<Consensus.Marketing.Campaign, Consensus.Marketing.ICampaignModel>(this.Model.CampaignManager, model => new Consensus.Marketing.Campaign(model));
                return _campaignManager;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CampaignModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.Campaign> CampaignApprover
        {
            get
            {
                if (_campaignApprover == null)
                    _campaignApprover = new ProxyCollection<Consensus.Marketing.Campaign, Consensus.Marketing.ICampaignModel>(this.Model.CampaignApprover, model => new Consensus.Marketing.Campaign(model));
                return _campaignApprover;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.Promotion> PromotionManager
        {
            get
            {
                if (_promotionManager == null)
                    _promotionManager = new ProxyCollection<Consensus.Marketing.Promotion, Consensus.Marketing.IPromotionModel>(this.Model.PromotionManager, model => new Consensus.Marketing.Promotion(model));
                return _promotionManager;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.Promotion> PromotionApprover
        {
            get
            {
                if (_promotionApprover == null)
                    _promotionApprover = new ProxyCollection<Consensus.Marketing.Promotion, Consensus.Marketing.IPromotionModel>(this.Model.PromotionApprover, model => new Consensus.Marketing.Promotion(model));
                return _promotionApprover;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionMasterModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.PromotionMaster> PromotionMasterManager
        {
            get
            {
                if (_promotionMasterManager == null)
                    _promotionMasterManager = new ProxyCollection<Consensus.Marketing.PromotionMaster, Consensus.Marketing.IPromotionMasterModel>(this.Model.PromotionMasterManager, model => new Consensus.Marketing.PromotionMaster(model));
                return _promotionMasterManager;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionMasterModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.PromotionMaster> PromotionMasterApprover
        {
            get
            {
                if (_promotionMasterApprover == null)
                    _promotionMasterApprover = new ProxyCollection<Consensus.Marketing.PromotionMaster, Consensus.Marketing.IPromotionMasterModel>(this.Model.PromotionMasterApprover, model => new Consensus.Marketing.PromotionMaster(model));
                return _promotionMasterApprover;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqStepModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.SaqStep> SaqStepOwnerRole
        {
            get
            {
                if (_saqStepOwnerRole == null)
                    _saqStepOwnerRole = new ProxyCollection<Consensus.Marketing.SaqStep, Consensus.Marketing.ISaqStepModel>(this.Model.SaqStepOwnerRole, model => new Consensus.Marketing.SaqStep(model));
                return _saqStepOwnerRole;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueryModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.SaqQuery> SaqQueryManager
        {
            get
            {
                if (_saqQueryManager == null)
                    _saqQueryManager = new ProxyCollection<Consensus.Marketing.SaqQuery, Consensus.Marketing.ISaqQueryModel>(this.Model.SaqQueryManager, model => new Consensus.Marketing.SaqQuery(model));
                return _saqQueryManager;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueryModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.SaqQuery> SaqQueryApprover
        {
            get
            {
                if (_saqQueryApprover == null)
                    _saqQueryApprover = new ProxyCollection<Consensus.Marketing.SaqQuery, Consensus.Marketing.ISaqQueryModel>(this.Model.SaqQueryApprover, model => new Consensus.Marketing.SaqQuery(model));
                return _saqQueryApprover;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MailingListModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.MailingList> MailingListOwners
        {
            get
            {
                if (_mailingListOwners == null)
                    _mailingListOwners = new ProxyCollection<Consensus.Marketing.MailingList, Consensus.Marketing.IMailingListModel>(this.Model.MailingListOwners, model => new Consensus.Marketing.MailingList(model));
                return _mailingListOwners;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PortalUserModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        public Collection<Consensus.Portal.PortalUser> PortalUsers
        {
            get
            {
                if (_portalUsers == null)
                    _portalUsers = new ProxyCollection<Consensus.Portal.PortalUser, Consensus.Portal.IPortalUserModel>(this.Model.PortalUsers, model => new Consensus.Portal.PortalUser(model));
                return _portalUsers;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Role(IRoleModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:RoleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:RoleModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Role Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Role.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:RoleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:RoleModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Role Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.IRoleModel model = provider.Contact.Role.Create();
            return model == null ? null : new Consensus.Contact.Role(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:RoleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:RoleModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Role> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Role.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:RoleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:RoleModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Role> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IRoleModel> collection = provider.Contact.Role.FetchAll();
            return collection.Select(model => new Consensus.Contact.Role(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:RoleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:RoleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RoleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Role FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Role.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:RoleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:RoleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RoleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Role FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.IRoleModel model = provider.Contact.Role.FetchById(id);
            return model == null ? null : new Consensus.Contact.Role(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Role.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.Role.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RoleModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:RoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RoleModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Role> FetchAllByPersonId(System.String personId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Role.FetchAllByPersonId(site,personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RoleModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:RoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RoleModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Role> FetchAllByPersonId(ConsensusSite site, System.String personId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IRoleModel> collection = provider.Contact.Role.FetchAllByPersonId(personId);
            return collection.Select(model => new Consensus.Contact.Role(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RoleModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:RoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RoleModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Role> FetchAllByOrganisationId(System.String organisationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Role.FetchAllByOrganisationId(site,organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RoleModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:RoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RoleModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Role> FetchAllByOrganisationId(ConsensusSite site, System.String organisationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IRoleModel> collection = provider.Contact.Role.FetchAllByOrganisationId(organisationId);
            return collection.Select(model => new Consensus.Contact.Role(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RoleModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:RoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RoleModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Role> FetchAllByAddressId(System.String addressId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Role.FetchAllByAddressId(site,addressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RoleModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:RoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RoleModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Role> FetchAllByAddressId(ConsensusSite site, System.String addressId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IRoleModel> collection = provider.Contact.Role.FetchAllByAddressId(addressId);
            return collection.Select(model => new Consensus.Contact.Role(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RoleModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:RoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RoleModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Role> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Role.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:RoleModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:RoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:RoleModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Role> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IRoleModel> collection = provider.Contact.Role.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Contact.Role(model));
        }

        #endregion
    }
}
