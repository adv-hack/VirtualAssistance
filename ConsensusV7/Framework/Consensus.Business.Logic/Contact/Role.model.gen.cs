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
    public partial class LocalRoleModel : LocalModel<PersonRoleRecord, String>, IRoleModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PROLE_PERSON_ID" field.
        /// </summary>
        private LocalPersonModel _person;

        /// <summary>
        ///     The value of the "PROLE_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _organisation;

        /// <summary>
        ///     The value of the "PROLE_POS_TYPE" field.
        /// </summary>
        private LocalCodeModel _jobType;

        /// <summary>
        ///     The value of the "PROLE_ADD_ID" field.
        /// </summary>
        private LocalAddressModel _address;

        /// <summary>
        ///     The value of the "PROLE_UNION_ROL_NO" field.
        /// </summary>
        private LocalCodeModel _unionRolNo;

        /// <summary>
        ///     The value of the "PROLE_TYPE" field.
        /// </summary>
        private LocalCodeModel _type;

        /// <summary>
        ///     The value of the "PROLE_COST_CODE" field.
        /// </summary>
        private LocalCodeModel _costCode;

        /// <summary>
        ///     The value of the "PROLE_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     The value of the "PROLE_JOB_LVL" field.
        /// </summary>
        private LocalCodeModel _jobLevel;

        /// <summary>
        ///     The collection of <see cref="AssociateModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalAssociateModel, IAssociateModel> _associatedPeople;

        /// <summary>
        ///     The collection of <see cref="AssociateModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalAssociateModel, IAssociateModel> _associates;

        /// <summary>
        ///     The collection of <see cref="LocationModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalLocationModel, ILocationModel> _locations;

        /// <summary>
        ///     The collection of <see cref="TrainerModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalTrainerModel, ITrainerModel> _trainersRole;

        /// <summary>
        ///     The collection of <see cref="CommunicationsRoleModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalCommunicationsRoleModel, ICommunicationsRoleModel> _roleCommunication;

        /// <summary>
        ///     The collection of <see cref="ProductModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalProductModel, IProductModel> _managerProleId;

        /// <summary>
        ///     The collection of <see cref="ProductModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalProductModel, IProductModel> _product;

        /// <summary>
        ///     The collection of <see cref="EventModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalEventModel, IEventModel> _events;

        /// <summary>
        ///     The collection of <see cref="EventModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalEventModel, IEventModel> _eventsContact;

        /// <summary>
        ///     The collection of <see cref="EventModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalEventModel, IEventModel> _supplierEvents;

        /// <summary>
        ///     The collection of <see cref="EventModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalEventModel, IEventModel> _eventsMainTrainer;

        /// <summary>
        ///     The collection of <see cref="BookingModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalBookingModel, IBookingModel> _bookings;

        /// <summary>
        ///     The collection of <see cref="BookingModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalBookingModel, IBookingModel> _invoiceBookings;

        /// <summary>
        ///     The collection of <see cref="LearnerModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalLearnerModel, ILearnerModel> _learners;

        /// <summary>
        ///     The collection of <see cref="TemplateTrainerModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalTemplateTrainerModel, ITemplateTrainerModel> _templateTrainers;

        /// <summary>
        ///     The collection of <see cref="OpportunityXrefModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalOpportunityXrefModel, IOpportunityXrefModel> _opportunityXrefs;

        /// <summary>
        ///     The collection of <see cref="PackModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalPackModel, IPackModel> _packSender;

        /// <summary>
        ///     The collection of <see cref="LetterTemplateModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalLetterTemplateModel, ILetterTemplateModel> _letterTemplates;

        /// <summary>
        ///     The collection of <see cref="OutputQueueModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalOutputQueueModel, IOutputQueueModel> _outputQueues;

        /// <summary>
        ///     The collection of <see cref="AccountModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalAccountModel, IAccountModel> _accounts;

        /// <summary>
        ///     The collection of <see cref="AccountXrefModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalAccountXrefModel, IAccountXrefModel> _accountXrefs;

        /// <summary>
        ///     The collection of <see cref="PaymentModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalPaymentModel, IPaymentModel> _payments;

        /// <summary>
        ///     The collection of <see cref="InvoiceModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalInvoiceModel, IInvoiceModel> _salesPersonInvoices;

        /// <summary>
        ///     The collection of <see cref="InvoiceModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalInvoiceModel, IInvoiceModel> _invoices;

        /// <summary>
        ///     The collection of <see cref="PrepayAccountModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalPrepayAccountModel, IPrepayAccountModel> _prepayAccount;

        /// <summary>
        ///     The collection of <see cref="GiftaidclaimModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalGiftaidclaimModel, IGiftaidclaimModel> _giftaidclaimsSubmitter;

        /// <summary>
        ///     The collection of <see cref="GiftaidclaimModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalGiftaidclaimModel, IGiftaidclaimModel> _giftaidclaimsTrustee;

        /// <summary>
        ///     The collection of <see cref="ActivityXrefModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalActivityXrefModel, IActivityXrefModel> _activityXRefs;

        /// <summary>
        ///     The collection of <see cref="HelpdeskModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalHelpdeskModel, IHelpdeskModel> _helpdeskProleId;

        /// <summary>
        ///     The collection of <see cref="HelpdeskModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalHelpdeskModel, IHelpdeskModel> _helpdeskGivenToId;

        /// <summary>
        ///     The collection of <see cref="ComplaintModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalComplaintModel, IComplaintModel> _complaintComplainant;

        /// <summary>
        ///     The collection of <see cref="ComplaintModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalComplaintModel, IComplaintModel> _complaintRegarding;

        /// <summary>
        ///     The collection of <see cref="ComplaintModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalComplaintModel, IComplaintModel> _complaintAssignedTo;

        /// <summary>
        ///     The collection of <see cref="ComplaintModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalComplaintModel, IComplaintModel> _complaintOwner;

        /// <summary>
        ///     The collection of <see cref="LicenseModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalLicenseModel, ILicenseModel> _licenses;

        /// <summary>
        ///     The collection of <see cref="MemberPeriodModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel> _invoiceMemberPeriods;

        /// <summary>
        ///     The collection of <see cref="MemberLocationModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalMemberLocationModel, IMemberLocationModel> _memberLocations;

        /// <summary>
        ///     The collection of <see cref="CampaignModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalCampaignModel, ICampaignModel> _campaignManager;

        /// <summary>
        ///     The collection of <see cref="CampaignModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalCampaignModel, ICampaignModel> _campaignApprover;

        /// <summary>
        ///     The collection of <see cref="PromotionModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalPromotionModel, IPromotionModel> _promotionManager;

        /// <summary>
        ///     The collection of <see cref="PromotionModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalPromotionModel, IPromotionModel> _promotionApprover;

        /// <summary>
        ///     The collection of <see cref="PromotionMasterModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalPromotionMasterModel, IPromotionMasterModel> _promotionMasterManager;

        /// <summary>
        ///     The collection of <see cref="PromotionMasterModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalPromotionMasterModel, IPromotionMasterModel> _promotionMasterApprover;

        /// <summary>
        ///     The collection of <see cref="SaqStepModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalSaqStepModel, ISaqStepModel> _saqStepOwnerRole;

        /// <summary>
        ///     The collection of <see cref="SaqQueryModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalSaqQueryModel, ISaqQueryModel> _saqQueryManager;

        /// <summary>
        ///     The collection of <see cref="SaqQueryModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalSaqQueryModel, ISaqQueryModel> _saqQueryApprover;

        /// <summary>
        ///     The collection of <see cref="MailingListModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalMailingListModel, IMailingListModel> _mailingListOwners;

        /// <summary>
        ///     The collection of <see cref="PortalUserModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        private LocalCollection<LocalPortalUserModel, IPortalUserModel> _portalUsers;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PersonRoleRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Contact.Role.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PersonRoleRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Contact.Role.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<PersonRoleRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Contact.Role.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_PERSON_ID" field.
        /// </summary>
        public LocalPersonModel Person
        {
            get
            {
                if (_person == null && this.PersonId != null)
                    _person = this.Provider.Contact.Person.FetchById(this.PersonId);
                if (_person == null)
                    _person = this.Provider.Contact.Person.Create();
                
                return _person;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_PERSON_ID" field.
        /// </summary>
        public String PersonId
        {
            get { return this.ModifiedData.PersonId; }
            set
            {
                if (this.ModifiedData.PersonId != value)
                     _person = null;
                this.ModifiedData.PersonId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_ORG_ID" field.
        /// </summary>
        public LocalOrganisationModel Organisation
        {
            get
            {
                if (_organisation == null && this.OrganisationId != null)
                    _organisation = this.Provider.Contact.Organisation.FetchById(this.OrganisationId);
                if (_organisation == null)
                    _organisation = this.Provider.Contact.Organisation.Create();
                
                return _organisation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_ORG_ID" field.
        /// </summary>
        public String OrganisationId
        {
            get { return this.ModifiedData.OrgId; }
            set
            {
                if (this.ModifiedData.OrgId != value)
                     _organisation = null;
                this.ModifiedData.OrgId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_POS_TITLE" field.
        /// </summary>
        public String JobTitle
        {
            get { return this.ModifiedData.PosTitle; }
            set { this.ModifiedData.PosTitle = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_POS_TYPE" field.
        /// </summary>
        public LocalCodeModel JobType
        {
            get
            {
                if (_jobType == null && !String.IsNullOrEmpty(this.JobTypeCode))
                    _jobType = this.Provider.Common.Code.FetchByTypeAndCode("ROLET", this.JobTypeCode);
                if (_jobType == null)
                    _jobType = this.Provider.Common.Code.Create("ROLET");
                return _jobType;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_POS_TYPE" field.
        /// </summary>
        public String JobTypeCode
        {
            get { return this.ModifiedData.PosType; }
            set
            {
                if (this.ModifiedData.PosType != value)
                     _jobType = null;
                this.ModifiedData.PosType = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_PHONE" field.
        /// </summary>
        public String Telephone
        {
            get { return this.ModifiedData.Phone; }
            set { this.ModifiedData.Phone = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_FAX" field.
        /// </summary>
        public String Fax
        {
            get { return this.ModifiedData.Fax; }
            set { this.ModifiedData.Fax = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_MOBILE" field.
        /// </summary>
        public String Mobile
        {
            get { return this.ModifiedData.Mobile; }
            set { this.ModifiedData.Mobile = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_PRINCIP_ROLE" field.
        /// </summary>
        public Byte? IsPrincipal
        {
            get { return this.ModifiedData.PrincipRole; }
            set { this.ModifiedData.PrincipRole = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_ADD_ID" field.
        /// </summary>
        public LocalAddressModel Address
        {
            get
            {
                if (_address == null && this.AddressId != null)
                    _address = this.Provider.Contact.Address.FetchById(this.AddressId);
                if (_address == null)
                    _address = this.Provider.Contact.Address.Create();
                
                return _address;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_ADD_ID" field.
        /// </summary>
        public String AddressId
        {
            get { return this.ModifiedData.AddId; }
            set
            {
                if (this.ModifiedData.AddId != value)
                     _address = null;
                this.ModifiedData.AddId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return this.ModifiedData.StartDate; }
            set { this.ModifiedData.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return this.ModifiedData.EndDate; }
            set { this.ModifiedData.EndDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_UNION_ROL_NO" field.
        /// </summary>
        public LocalCodeModel UnionRolNo
        {
            get
            {
                if (_unionRolNo == null && !String.IsNullOrEmpty(this.UnionRolNoCode))
                    _unionRolNo = this.Provider.Common.Code.FetchByTypeAndCode("EXPCD", this.UnionRolNoCode);
                if (_unionRolNo == null)
                    _unionRolNo = this.Provider.Common.Code.Create("EXPCD");
                return _unionRolNo;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_UNION_ROL_NO" field.
        /// </summary>
        public String UnionRolNoCode
        {
            get { return this.ModifiedData.UnionRolNo; }
            set
            {
                if (this.ModifiedData.UnionRolNo != value)
                     _unionRolNo = null;
                this.ModifiedData.UnionRolNo = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_TYPE" field.
        /// </summary>
        public LocalCodeModel Type
        {
            get
            {
                if (_type == null && !String.IsNullOrEmpty(this.TypeCode))
                    _type = this.Provider.Common.Code.FetchByTypeAndCode("ROLE", this.TypeCode);
                if (_type == null)
                    _type = this.Provider.Common.Code.Create("ROLE");
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_TYPE" field.
        /// </summary>
        public String TypeCode
        {
            get { return this.ModifiedData.Type; }
            set
            {
                if (this.ModifiedData.Type != value)
                     _type = null;
                this.ModifiedData.Type = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_EMAIL" field.
        /// </summary>
        public String Email
        {
            get { return this.ModifiedData.Email; }
            set { this.ModifiedData.Email = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_PN_NAME" field.
        /// </summary>
        public String PersonName
        {
            get { return this.ModifiedData.PnName; }
            set { this.ModifiedData.PnName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_PAYROLL" field.
        /// </summary>
        public String Payroll
        {
            get { return this.ModifiedData.Payroll; }
            set { this.ModifiedData.Payroll = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_STAFF_NO" field.
        /// </summary>
        public String StaffNo
        {
            get { return this.ModifiedData.StaffNo; }
            set { this.ModifiedData.StaffNo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_KEY_CONTACT" field.
        /// </summary>
        public Byte? KeyContact
        {
            get { return this.ModifiedData.KeyContact; }
            set { this.ModifiedData.KeyContact = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_COST_CODE" field.
        /// </summary>
        public LocalCodeModel CostCode
        {
            get
            {
                if (_costCode == null && !String.IsNullOrEmpty(this.CostCodeCode))
                    _costCode = this.Provider.Common.Code.FetchByTypeAndCode("COST", this.CostCodeCode);
                if (_costCode == null)
                    _costCode = this.Provider.Common.Code.Create("COST");
                return _costCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_COST_CODE" field.
        /// </summary>
        public String CostCodeCode
        {
            get { return this.ModifiedData.CostCode; }
            set
            {
                if (this.ModifiedData.CostCode != value)
                     _costCode = null;
                this.ModifiedData.CostCode = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_SELCO_SP_ID" field.
        /// </summary>
        public LocalSellingCompanyModel SellingCompany
        {
            get
            {
                if (_sellingCompany == null)
                    _sellingCompany = this.Provider.Common.SellingCompany.FetchById(this.SellingCompanyId);
                if (_sellingCompany == null)
                    _sellingCompany = this.Provider.Common.SellingCompany.Create();
                
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_SELCO_SP_ID" field.
        /// </summary>
        public String SellingCompanyId
        {
            get { return this.ModifiedData.SelcoSpId; }
            set
            {
                if (this.ModifiedData.SelcoSpId != value)
                     _sellingCompany = null;
                this.ModifiedData.SelcoSpId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_HOUR_RTE" field.
        /// </summary>
        public Decimal HourlyRate
        {
            get { return this.ModifiedData.HourRte; }
            set { this.ModifiedData.HourRte = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_JOB_LVL" field.
        /// </summary>
        public LocalCodeModel JobLevel
        {
            get
            {
                if (_jobLevel == null && !String.IsNullOrEmpty(this.JobLevelCode))
                    _jobLevel = this.Provider.Common.Code.FetchByTypeAndCode("ATRJL", this.JobLevelCode);
                if (_jobLevel == null)
                    _jobLevel = this.Provider.Common.Code.Create("ATRJL");
                return _jobLevel;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_JOB_LVL" field.
        /// </summary>
        public String JobLevelCode
        {
            get { return this.ModifiedData.JobLvl; }
            set
            {
                if (this.ModifiedData.JobLvl != value)
                     _jobLevel = null;
                this.ModifiedData.JobLvl = value;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="AssociateModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalAssociateModel, IAssociateModel> AssociatedPeople
        {
            get
            {
                if (_associatedPeople == null)
                    _associatedPeople = new LocalCollection<LocalAssociateModel, IAssociateModel>(this.Provider.Contact.Associate.FetchAllByAssociatedRoleId(this.Id));
                
                return _associatedPeople;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="AssociateModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalAssociateModel, IAssociateModel> Associates
        {
            get
            {
                if (_associates == null)
                    _associates = new LocalCollection<LocalAssociateModel, IAssociateModel>(this.Provider.Contact.Associate.FetchAllByRoleId(this.Id));
                
                return _associates;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="LocationModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalLocationModel, ILocationModel> Locations
        {
            get
            {
                if (_locations == null)
                    _locations = new LocalCollection<LocalLocationModel, ILocationModel>(this.Provider.Contact.Location.FetchAllByLocationRoleId(this.Id));
                
                return _locations;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="TrainerModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalTrainerModel, ITrainerModel> TrainersRole
        {
            get
            {
                if (_trainersRole == null)
                    _trainersRole = new LocalCollection<LocalTrainerModel, ITrainerModel>(this.Provider.Contact.Trainer.FetchAllByRoleId(this.Id));
                
                return _trainersRole;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="CommunicationsRoleModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalCommunicationsRoleModel, ICommunicationsRoleModel> RoleCommunication
        {
            get
            {
                if (_roleCommunication == null)
                    _roleCommunication = new LocalCollection<LocalCommunicationsRoleModel, ICommunicationsRoleModel>(this.Provider.Contact.CommunicationsRole.FetchAllByRoleId(this.Id));
                
                return _roleCommunication;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalProductModel, IProductModel> ManagerProleId
        {
            get
            {
                if (_managerProleId == null)
                    _managerProleId = new LocalCollection<LocalProductModel, IProductModel>(this.Provider.Learning.Product.FetchAllByProleIdId(this.Id));
                
                return _managerProleId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalProductModel, IProductModel> Product
        {
            get
            {
                if (_product == null)
                    _product = new LocalCollection<LocalProductModel, IProductModel>(this.Provider.Learning.Product.FetchAllByProductManagerId(this.Id));
                
                return _product;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalEventModel, IEventModel> Events
        {
            get
            {
                if (_events == null)
                    _events = new LocalCollection<LocalEventModel, IEventModel>(this.Provider.Learning.Event.FetchAllByCommissionedRoleId(this.Id));
                
                return _events;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalEventModel, IEventModel> EventsContact
        {
            get
            {
                if (_eventsContact == null)
                    _eventsContact = new LocalCollection<LocalEventModel, IEventModel>(this.Provider.Learning.Event.FetchAllByContactId(this.Id));
                
                return _eventsContact;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalEventModel, IEventModel> SupplierEvents
        {
            get
            {
                if (_supplierEvents == null)
                    _supplierEvents = new LocalCollection<LocalEventModel, IEventModel>(this.Provider.Learning.Event.FetchAllBySupplierRoleId(this.Id));
                
                return _supplierEvents;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalEventModel, IEventModel> EventsMainTrainer
        {
            get
            {
                if (_eventsMainTrainer == null)
                    _eventsMainTrainer = new LocalCollection<LocalEventModel, IEventModel>(this.Provider.Learning.Event.FetchAllByMainTrainerId(this.Id));
                
                return _eventsMainTrainer;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BookingModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalBookingModel, IBookingModel> Bookings
        {
            get
            {
                if (_bookings == null)
                    _bookings = new LocalCollection<LocalBookingModel, IBookingModel>(this.Provider.Learning.Booking.FetchAllByBookerRoleId(this.Id));
                
                return _bookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BookingModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalBookingModel, IBookingModel> InvoiceBookings
        {
            get
            {
                if (_invoiceBookings == null)
                    _invoiceBookings = new LocalCollection<LocalBookingModel, IBookingModel>(this.Provider.Learning.Booking.FetchAllByInvoiceRoleId(this.Id));
                
                return _invoiceBookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="LearnerModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalLearnerModel, ILearnerModel> Learners
        {
            get
            {
                if (_learners == null)
                    _learners = new LocalCollection<LocalLearnerModel, ILearnerModel>(this.Provider.Learning.Learner.FetchAllByDelegateRoleId(this.Id));
                
                return _learners;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="TemplateTrainerModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalTemplateTrainerModel, ITemplateTrainerModel> TemplateTrainers
        {
            get
            {
                if (_templateTrainers == null)
                    _templateTrainers = new LocalCollection<LocalTemplateTrainerModel, ITemplateTrainerModel>(this.Provider.Learning.TemplateTrainer.FetchAllByTrainerRoleId(this.Id));
                
                return _templateTrainers;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="OpportunityXrefModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalOpportunityXrefModel, IOpportunityXrefModel> OpportunityXrefs
        {
            get
            {
                if (_opportunityXrefs == null)
                    _opportunityXrefs = new LocalCollection<LocalOpportunityXrefModel, IOpportunityXrefModel>(this.Provider.Sales.OpportunityXref.FetchAllByRoleId(this.Id));
                
                return _opportunityXrefs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PackModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalPackModel, IPackModel> PackSender
        {
            get
            {
                if (_packSender == null)
                    _packSender = new LocalCollection<LocalPackModel, IPackModel>(this.Provider.Document.Pack.FetchAllByPackSenderIdId(this.Id));
                
                return _packSender;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="LetterTemplateModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalLetterTemplateModel, ILetterTemplateModel> LetterTemplates
        {
            get
            {
                if (_letterTemplates == null)
                    _letterTemplates = new LocalCollection<LocalLetterTemplateModel, ILetterTemplateModel>(this.Provider.Document.LetterTemplate.FetchAllBySendFromId(this.Id));
                
                return _letterTemplates;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="OutputQueueModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalOutputQueueModel, IOutputQueueModel> OutputQueues
        {
            get
            {
                if (_outputQueues == null)
                    _outputQueues = new LocalCollection<LocalOutputQueueModel, IOutputQueueModel>(this.Provider.Document.OutputQueue.FetchAllByAdminProleId(this.Id));
                
                return _outputQueues;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="AccountModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalAccountModel, IAccountModel> Accounts
        {
            get
            {
                if (_accounts == null)
                    _accounts = new LocalCollection<LocalAccountModel, IAccountModel>(this.Provider.Finance.Account.FetchAllByRoleId(this.Id));
                
                return _accounts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="AccountXrefModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalAccountXrefModel, IAccountXrefModel> AccountXrefs
        {
            get
            {
                if (_accountXrefs == null)
                    _accountXrefs = new LocalCollection<LocalAccountXrefModel, IAccountXrefModel>(this.Provider.Finance.AccountXref.FetchAllByRoleId(this.Id));
                
                return _accountXrefs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PaymentModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalPaymentModel, IPaymentModel> Payments
        {
            get
            {
                if (_payments == null)
                    _payments = new LocalCollection<LocalPaymentModel, IPaymentModel>(this.Provider.Finance.Payment.FetchAllByCardholderRoleId(this.Id));
                
                return _payments;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="InvoiceModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalInvoiceModel, IInvoiceModel> SalesPersonInvoices
        {
            get
            {
                if (_salesPersonInvoices == null)
                    _salesPersonInvoices = new LocalCollection<LocalInvoiceModel, IInvoiceModel>(this.Provider.Finance.Invoice.FetchAllBySalesProleIdId(this.Id));
                
                return _salesPersonInvoices;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="InvoiceModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalInvoiceModel, IInvoiceModel> Invoices
        {
            get
            {
                if (_invoices == null)
                    _invoices = new LocalCollection<LocalInvoiceModel, IInvoiceModel>(this.Provider.Finance.Invoice.FetchAllByProleIdId(this.Id));
                
                return _invoices;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PrepayAccountModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalPrepayAccountModel, IPrepayAccountModel> PrepayAccount
        {
            get
            {
                if (_prepayAccount == null)
                    _prepayAccount = new LocalCollection<LocalPrepayAccountModel, IPrepayAccountModel>(this.Provider.Finance.PrepayAccount.FetchAllByContactId(this.Id));
                
                return _prepayAccount;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="GiftaidclaimModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalGiftaidclaimModel, IGiftaidclaimModel> GiftaidclaimsSubmitter
        {
            get
            {
                if (_giftaidclaimsSubmitter == null)
                    _giftaidclaimsSubmitter = new LocalCollection<LocalGiftaidclaimModel, IGiftaidclaimModel>(this.Provider.Finance.Giftaidclaim.FetchAllBySubmitterId(this.Id));
                
                return _giftaidclaimsSubmitter;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="GiftaidclaimModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalGiftaidclaimModel, IGiftaidclaimModel> GiftaidclaimsTrustee
        {
            get
            {
                if (_giftaidclaimsTrustee == null)
                    _giftaidclaimsTrustee = new LocalCollection<LocalGiftaidclaimModel, IGiftaidclaimModel>(this.Provider.Finance.Giftaidclaim.FetchAllByTrusteeId(this.Id));
                
                return _giftaidclaimsTrustee;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ActivityXrefModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalActivityXrefModel, IActivityXrefModel> ActivityXRefs
        {
            get
            {
                if (_activityXRefs == null)
                    _activityXRefs = new LocalCollection<LocalActivityXrefModel, IActivityXrefModel>(this.Provider.Activities.ActivityXref.FetchAllByPersonRoleId(this.Id));
                
                return _activityXRefs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="HelpdeskModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalHelpdeskModel, IHelpdeskModel> HelpdeskProleId
        {
            get
            {
                if (_helpdeskProleId == null)
                    _helpdeskProleId = new LocalCollection<LocalHelpdeskModel, IHelpdeskModel>(this.Provider.Activities.Helpdesk.FetchAllByProleIdId(this.Id));
                
                return _helpdeskProleId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="HelpdeskModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalHelpdeskModel, IHelpdeskModel> HelpdeskGivenToId
        {
            get
            {
                if (_helpdeskGivenToId == null)
                    _helpdeskGivenToId = new LocalCollection<LocalHelpdeskModel, IHelpdeskModel>(this.Provider.Activities.Helpdesk.FetchAllByGivenToIdId(this.Id));
                
                return _helpdeskGivenToId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ComplaintModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalComplaintModel, IComplaintModel> ComplaintComplainant
        {
            get
            {
                if (_complaintComplainant == null)
                    _complaintComplainant = new LocalCollection<LocalComplaintModel, IComplaintModel>(this.Provider.Activities.Complaint.FetchAllByFromProleIdId(this.Id));
                
                return _complaintComplainant;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ComplaintModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalComplaintModel, IComplaintModel> ComplaintRegarding
        {
            get
            {
                if (_complaintRegarding == null)
                    _complaintRegarding = new LocalCollection<LocalComplaintModel, IComplaintModel>(this.Provider.Activities.Complaint.FetchAllByReProleIdId(this.Id));
                
                return _complaintRegarding;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ComplaintModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalComplaintModel, IComplaintModel> ComplaintAssignedTo
        {
            get
            {
                if (_complaintAssignedTo == null)
                    _complaintAssignedTo = new LocalCollection<LocalComplaintModel, IComplaintModel>(this.Provider.Activities.Complaint.FetchAllByMgrProleIdId(this.Id));
                
                return _complaintAssignedTo;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ComplaintModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalComplaintModel, IComplaintModel> ComplaintOwner
        {
            get
            {
                if (_complaintOwner == null)
                    _complaintOwner = new LocalCollection<LocalComplaintModel, IComplaintModel>(this.Provider.Activities.Complaint.FetchAllByMedtrProleIdId(this.Id));
                
                return _complaintOwner;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="LicenseModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalLicenseModel, ILicenseModel> Licenses
        {
            get
            {
                if (_licenses == null)
                    _licenses = new LocalCollection<LocalLicenseModel, ILicenseModel>(this.Provider.Security.License.FetchAllByOwnerId(this.Id));
                
                return _licenses;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MemberPeriodModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel> InvoiceMemberPeriods
        {
            get
            {
                if (_invoiceMemberPeriods == null)
                    _invoiceMemberPeriods = new LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel>(this.Provider.Membership.MemberPeriod.FetchAllByInvoiceRoleId(this.Id));
                
                return _invoiceMemberPeriods;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MemberLocationModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalMemberLocationModel, IMemberLocationModel> MemberLocations
        {
            get
            {
                if (_memberLocations == null)
                    _memberLocations = new LocalCollection<LocalMemberLocationModel, IMemberLocationModel>(this.Provider.Membership.MemberLocation.FetchAllByRoleId(this.Id));
                
                return _memberLocations;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="CampaignModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalCampaignModel, ICampaignModel> CampaignManager
        {
            get
            {
                if (_campaignManager == null)
                    _campaignManager = new LocalCollection<LocalCampaignModel, ICampaignModel>(this.Provider.Marketing.Campaign.FetchAllByManagerId(this.Id));
                
                return _campaignManager;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="CampaignModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalCampaignModel, ICampaignModel> CampaignApprover
        {
            get
            {
                if (_campaignApprover == null)
                    _campaignApprover = new LocalCollection<LocalCampaignModel, ICampaignModel>(this.Provider.Marketing.Campaign.FetchAllByApproverId(this.Id));
                
                return _campaignApprover;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PromotionModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalPromotionModel, IPromotionModel> PromotionManager
        {
            get
            {
                if (_promotionManager == null)
                    _promotionManager = new LocalCollection<LocalPromotionModel, IPromotionModel>(this.Provider.Marketing.Promotion.FetchAllByManagerId(this.Id));
                
                return _promotionManager;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PromotionModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalPromotionModel, IPromotionModel> PromotionApprover
        {
            get
            {
                if (_promotionApprover == null)
                    _promotionApprover = new LocalCollection<LocalPromotionModel, IPromotionModel>(this.Provider.Marketing.Promotion.FetchAllByApproverId(this.Id));
                
                return _promotionApprover;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PromotionMasterModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalPromotionMasterModel, IPromotionMasterModel> PromotionMasterManager
        {
            get
            {
                if (_promotionMasterManager == null)
                    _promotionMasterManager = new LocalCollection<LocalPromotionMasterModel, IPromotionMasterModel>(this.Provider.Marketing.PromotionMaster.FetchAllByManagerId(this.Id));
                
                return _promotionMasterManager;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PromotionMasterModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalPromotionMasterModel, IPromotionMasterModel> PromotionMasterApprover
        {
            get
            {
                if (_promotionMasterApprover == null)
                    _promotionMasterApprover = new LocalCollection<LocalPromotionMasterModel, IPromotionMasterModel>(this.Provider.Marketing.PromotionMaster.FetchAllByApproverId(this.Id));
                
                return _promotionMasterApprover;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SaqStepModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalSaqStepModel, ISaqStepModel> SaqStepOwnerRole
        {
            get
            {
                if (_saqStepOwnerRole == null)
                    _saqStepOwnerRole = new LocalCollection<LocalSaqStepModel, ISaqStepModel>(this.Provider.Marketing.SaqStep.FetchAllByOwnerRoleId(this.Id));
                
                return _saqStepOwnerRole;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SaqQueryModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalSaqQueryModel, ISaqQueryModel> SaqQueryManager
        {
            get
            {
                if (_saqQueryManager == null)
                    _saqQueryManager = new LocalCollection<LocalSaqQueryModel, ISaqQueryModel>(this.Provider.Marketing.SaqQuery.FetchAllByManagerId(this.Id));
                
                return _saqQueryManager;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SaqQueryModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalSaqQueryModel, ISaqQueryModel> SaqQueryApprover
        {
            get
            {
                if (_saqQueryApprover == null)
                    _saqQueryApprover = new LocalCollection<LocalSaqQueryModel, ISaqQueryModel>(this.Provider.Marketing.SaqQuery.FetchAllByApproverId(this.Id));
                
                return _saqQueryApprover;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MailingListModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalMailingListModel, IMailingListModel> MailingListOwners
        {
            get
            {
                if (_mailingListOwners == null)
                    _mailingListOwners = new LocalCollection<LocalMailingListModel, IMailingListModel>(this.Provider.Marketing.MailingList.FetchAllByOwnerId(this.Id));
                
                return _mailingListOwners;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PortalUserModel" /> instances that reference this <see cref="RoleModel" />.
        /// </summary>
        public LocalCollection<LocalPortalUserModel, IPortalUserModel> PortalUsers
        {
            get
            {
                if (_portalUsers == null)
                    _portalUsers = new LocalCollection<LocalPortalUserModel, IPortalUserModel>(this.Provider.Portal.PortalUser.FetchAllByPersonRoleId(this.Id));
                
                return _portalUsers;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalRoleModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalRoleModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalRoleModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalRoleModel(LocalProvider provider, PersonRoleRecord record) : base(provider, record)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected override void ResolveGeneratedDependency()
        {
            base.ResolveGeneratedDependency();
            if (_jobType != null)
            {
                _jobType.Save();
                this.ModifiedData.PosType = _jobType.Value1;
            }
            if (_unionRolNo != null)
            {
                _unionRolNo.Save();
                this.ModifiedData.UnionRolNo = _unionRolNo.Value1;
            }
            if (_type != null)
            {
                _type.Save();
                this.ModifiedData.Type = _type.Value1;
            }
            if (_costCode != null)
            {
                _costCode.Save();
                this.ModifiedData.CostCode = _costCode.Value1;
            }
            if (_jobLevel != null)
            {
                _jobLevel.Save();
                this.ModifiedData.JobLvl = _jobLevel.Value1;
            }
            if (_person != null)
            {
                _person.Save();
                this.ModifiedData.PersonId = _person.Id == null && this.ModifiedData.PersonId != null ? "" : _person.Id;
            }
            if (_organisation != null)
            {
                _organisation.Save();
                this.ModifiedData.OrgId = _organisation.Id == null && this.ModifiedData.OrgId != null ? "" : _organisation.Id;
            }
            if (_address != null)
            {
                _address.Save();
                this.ModifiedData.AddId = _address.Id == null && this.ModifiedData.AddId != null ? "" : _address.Id;
            }
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.SelcoSpId = _sellingCompany.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _sellingCompany.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_associatedPeople != null)
                _associatedPeople.Execute(obj => obj.AssociatedRoleId = this.Id).Execute(obj => obj.Save());
            if (_associates != null)
                _associates.Execute(obj => obj.RoleId = this.Id).Execute(obj => obj.Save());
            if (_locations != null)
                _locations.Execute(obj => obj.LocationRoleId = this.Id).Execute(obj => obj.Save());
            if (_trainersRole != null)
                _trainersRole.Execute(obj => obj.RoleId = this.Id).Execute(obj => obj.Save());
            if (_roleCommunication != null)
                _roleCommunication.Execute(obj => obj.RoleId = this.Id).Execute(obj => obj.Save());
            if (_managerProleId != null)
                _managerProleId.Execute(obj => obj.ProleIdId = this.Id).Execute(obj => obj.Save());
            if (_product != null)
                _product.Execute(obj => obj.ProductManagerId = this.Id).Execute(obj => obj.Save());
            if (_events != null)
                _events.Execute(obj => obj.CommissionedRoleId = this.Id).Execute(obj => obj.Save());
            if (_eventsContact != null)
                _eventsContact.Execute(obj => obj.ContactId = this.Id).Execute(obj => obj.Save());
            if (_supplierEvents != null)
                _supplierEvents.Execute(obj => obj.SupplierRoleId = this.Id).Execute(obj => obj.Save());
            if (_eventsMainTrainer != null)
                _eventsMainTrainer.Execute(obj => obj.MainTrainerId = this.Id).Execute(obj => obj.Save());
            if (_bookings != null)
                _bookings.Execute(obj => obj.BookerRoleId = this.Id).Execute(obj => obj.Save());
            if (_invoiceBookings != null)
                _invoiceBookings.Execute(obj => obj.InvoiceRoleId = this.Id).Execute(obj => obj.Save());
            if (_learners != null)
                _learners.Execute(obj => obj.DelegateRoleId = this.Id).Execute(obj => obj.Save());
            if (_templateTrainers != null)
                _templateTrainers.Execute(obj => obj.TrainerRoleId = this.Id).Execute(obj => obj.Save());
            if (_opportunityXrefs != null)
                _opportunityXrefs.Execute(obj => obj.RoleId = this.Id).Execute(obj => obj.Save());
            if (_packSender != null)
                _packSender.Execute(obj => obj.PackSenderIdId = this.Id).Execute(obj => obj.Save());
            if (_letterTemplates != null)
                _letterTemplates.Execute(obj => obj.SendFromId = this.Id).Execute(obj => obj.Save());
            if (_outputQueues != null)
                _outputQueues.Execute(obj => obj.AdminProleId = this.Id).Execute(obj => obj.Save());
            if (_accounts != null)
                _accounts.Execute(obj => obj.RoleId = this.Id).Execute(obj => obj.Save());
            if (_accountXrefs != null)
                _accountXrefs.Execute(obj => obj.RoleId = this.Id).Execute(obj => obj.Save());
            if (_payments != null)
                _payments.Execute(obj => obj.CardholderRoleId = this.Id).Execute(obj => obj.Save());
            if (_salesPersonInvoices != null)
                _salesPersonInvoices.Execute(obj => obj.SalesProleIdId = this.Id).Execute(obj => obj.Save());
            if (_invoices != null)
                _invoices.Execute(obj => obj.ProleIdId = this.Id).Execute(obj => obj.Save());
            if (_prepayAccount != null)
                _prepayAccount.Execute(obj => obj.ContactId = this.Id).Execute(obj => obj.Save());
            if (_giftaidclaimsSubmitter != null)
                _giftaidclaimsSubmitter.Execute(obj => obj.SubmitterId = this.Id).Execute(obj => obj.Save());
            if (_giftaidclaimsTrustee != null)
                _giftaidclaimsTrustee.Execute(obj => obj.TrusteeId = this.Id).Execute(obj => obj.Save());
            if (_activityXRefs != null)
                _activityXRefs.Execute(obj => obj.PersonRoleId = this.Id).Execute(obj => obj.Save());
            if (_helpdeskProleId != null)
                _helpdeskProleId.Execute(obj => obj.ProleIdId = this.Id).Execute(obj => obj.Save());
            if (_helpdeskGivenToId != null)
                _helpdeskGivenToId.Execute(obj => obj.GivenToIdId = this.Id).Execute(obj => obj.Save());
            if (_complaintComplainant != null)
                _complaintComplainant.Execute(obj => obj.FromProleIdId = this.Id).Execute(obj => obj.Save());
            if (_complaintRegarding != null)
                _complaintRegarding.Execute(obj => obj.ReProleIdId = this.Id).Execute(obj => obj.Save());
            if (_complaintAssignedTo != null)
                _complaintAssignedTo.Execute(obj => obj.MgrProleIdId = this.Id).Execute(obj => obj.Save());
            if (_complaintOwner != null)
                _complaintOwner.Execute(obj => obj.MedtrProleIdId = this.Id).Execute(obj => obj.Save());
            if (_licenses != null)
                _licenses.Execute(obj => obj.OwnerId = this.Id).Execute(obj => obj.Save());
            if (_invoiceMemberPeriods != null)
                _invoiceMemberPeriods.Execute(obj => obj.InvoiceRoleId = this.Id).Execute(obj => obj.Save());
            if (_memberLocations != null)
                _memberLocations.Execute(obj => obj.RoleId = this.Id).Execute(obj => obj.Save());
            if (_campaignManager != null)
                _campaignManager.Execute(obj => obj.ManagerId = this.Id).Execute(obj => obj.Save());
            if (_campaignApprover != null)
                _campaignApprover.Execute(obj => obj.ApproverId = this.Id).Execute(obj => obj.Save());
            if (_promotionManager != null)
                _promotionManager.Execute(obj => obj.ManagerId = this.Id).Execute(obj => obj.Save());
            if (_promotionApprover != null)
                _promotionApprover.Execute(obj => obj.ApproverId = this.Id).Execute(obj => obj.Save());
            if (_promotionMasterManager != null)
                _promotionMasterManager.Execute(obj => obj.ManagerId = this.Id).Execute(obj => obj.Save());
            if (_promotionMasterApprover != null)
                _promotionMasterApprover.Execute(obj => obj.ApproverId = this.Id).Execute(obj => obj.Save());
            if (_saqStepOwnerRole != null)
                _saqStepOwnerRole.Execute(obj => obj.OwnerRoleId = this.Id).Execute(obj => obj.Save());
            if (_saqQueryManager != null)
                _saqQueryManager.Execute(obj => obj.ManagerId = this.Id).Execute(obj => obj.Save());
            if (_saqQueryApprover != null)
                _saqQueryApprover.Execute(obj => obj.ApproverId = this.Id).Execute(obj => obj.Save());
            if (_mailingListOwners != null)
                _mailingListOwners.Execute(obj => obj.OwnerId = this.Id).Execute(obj => obj.Save());
            if (_portalUsers != null)
                _portalUsers.Execute(obj => obj.PersonRoleId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the persons home role.
        /// </summary>
        Consensus.Contact.IRoleModel IRoleModel.HomeRole
        {
            get { return this.HomeRole; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_DO_NOT_FAX" field.
        /// </summary>
        System.Boolean IRoleModel.DoNotFax
        {
            get { return this.DoNotFax; }
            set { this.DoNotFax = (System.Boolean)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_DO_NOT_EMAIL" field.
        /// </summary>
        System.Boolean IRoleModel.DoNotEmail
        {
            get { return this.DoNotEmail; }
            set { this.DoNotEmail = (System.Boolean)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_DO_NOT_SWAP" field.
        /// </summary>
        System.Boolean IRoleModel.DoNotSwap
        {
            get { return this.DoNotSwap; }
            set { this.DoNotSwap = (System.Boolean)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_DO_NOT_MAIL" field.
        /// </summary>
        System.Boolean IRoleModel.DoNotMail
        {
            get { return this.DoNotMail; }
            set { this.DoNotMail = (System.Boolean)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_USERNUM_1" field.
        /// </summary>
        System.Boolean IRoleModel.DoNotTelesale
        {
            get { return this.DoNotTelesale; }
            set { this.DoNotTelesale = (System.Boolean)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_DIS_FLAG" field.
        /// </summary>
        System.Boolean IRoleModel.IsRoleDisabled
        {
            get { return this.IsRoleDisabled; }
            set { this.IsRoleDisabled = (System.Boolean)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_PERSON_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel IRoleModel.Person
        {
            get { return this.Person; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_PERSON_ID" field.
        /// </summary>
        System.String IRoleModel.PersonId
        {
            get { return this.PersonId; }
            set { this.PersonId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IRoleModel.Organisation
        {
            get { return this.Organisation; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_ORG_ID" field.
        /// </summary>
        System.String IRoleModel.OrganisationId
        {
            get { return this.OrganisationId; }
            set { this.OrganisationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_POS_TITLE" field.
        /// </summary>
        System.String IRoleModel.JobTitle
        {
            get { return this.JobTitle; }
            set { this.JobTitle = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_POS_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel IRoleModel.JobType
        {
            get { return this.JobType; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_POS_TYPE" field.
        /// </summary>
        System.String IRoleModel.JobTypeCode
        {
            get { return this.JobTypeCode; }
            set { this.JobTypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_PHONE" field.
        /// </summary>
        System.String IRoleModel.Telephone
        {
            get { return this.Telephone; }
            set { this.Telephone = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_FAX" field.
        /// </summary>
        System.String IRoleModel.Fax
        {
            get { return this.Fax; }
            set { this.Fax = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_MOBILE" field.
        /// </summary>
        System.String IRoleModel.Mobile
        {
            get { return this.Mobile; }
            set { this.Mobile = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_PRINCIP_ROLE" field.
        /// </summary>
        System.Nullable<System.Byte> IRoleModel.IsPrincipal
        {
            get { return this.IsPrincipal; }
            set { this.IsPrincipal = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel IRoleModel.Address
        {
            get { return this.Address; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_ADD_ID" field.
        /// </summary>
        System.String IRoleModel.AddressId
        {
            get { return this.AddressId; }
            set { this.AddressId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IRoleModel.StartDate
        {
            get { return this.StartDate; }
            set { this.StartDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IRoleModel.EndDate
        {
            get { return this.EndDate; }
            set { this.EndDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_UNION_ROL_NO" field.
        /// </summary>
        Consensus.Common.ICodeModel IRoleModel.UnionRolNo
        {
            get { return this.UnionRolNo; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_UNION_ROL_NO" field.
        /// </summary>
        System.String IRoleModel.UnionRolNoCode
        {
            get { return this.UnionRolNoCode; }
            set { this.UnionRolNoCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel IRoleModel.Type
        {
            get { return this.Type; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_TYPE" field.
        /// </summary>
        System.String IRoleModel.TypeCode
        {
            get { return this.TypeCode; }
            set { this.TypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_EMAIL" field.
        /// </summary>
        System.String IRoleModel.Email
        {
            get { return this.Email; }
            set { this.Email = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_PN_NAME" field.
        /// </summary>
        System.String IRoleModel.PersonName
        {
            get { return this.PersonName; }
            set { this.PersonName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_PAYROLL" field.
        /// </summary>
        System.String IRoleModel.Payroll
        {
            get { return this.Payroll; }
            set { this.Payroll = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_STAFF_NO" field.
        /// </summary>
        System.String IRoleModel.StaffNo
        {
            get { return this.StaffNo; }
            set { this.StaffNo = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_KEY_CONTACT" field.
        /// </summary>
        System.Nullable<System.Byte> IRoleModel.KeyContact
        {
            get { return this.KeyContact; }
            set { this.KeyContact = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_COST_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel IRoleModel.CostCode
        {
            get { return this.CostCode; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_COST_CODE" field.
        /// </summary>
        System.String IRoleModel.CostCodeCode
        {
            get { return this.CostCodeCode; }
            set { this.CostCodeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel IRoleModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_SELCO_SP_ID" field.
        /// </summary>
        System.String IRoleModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_HOUR_RTE" field.
        /// </summary>
        System.Decimal IRoleModel.HourlyRate
        {
            get { return this.HourlyRate; }
            set { this.HourlyRate = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_JOB_LVL" field.
        /// </summary>
        Consensus.Common.ICodeModel IRoleModel.JobLevel
        {
            get { return this.JobLevel; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_JOB_LVL" field.
        /// </summary>
        System.String IRoleModel.JobLevelCode
        {
            get { return this.JobLevelCode; }
            set { this.JobLevelCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AssociateModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IAssociateModel> IRoleModel.AssociatedPeople
        {
            get { return this.AssociatedPeople; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AssociateModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IAssociateModel> IRoleModel.Associates
        {
            get { return this.Associates; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LocationModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ILocationModel> IRoleModel.Locations
        {
            get { return this.Locations; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TrainerModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ITrainerModel> IRoleModel.TrainersRole
        {
            get { return this.TrainersRole; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CommunicationsRoleModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ICommunicationsRoleModel> IRoleModel.RoleCommunication
        {
            get { return this.RoleCommunication; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> IRoleModel.ManagerProleId
        {
            get { return this.ManagerProleId; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> IRoleModel.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> IRoleModel.Events
        {
            get { return this.Events; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> IRoleModel.EventsContact
        {
            get { return this.EventsContact; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> IRoleModel.SupplierEvents
        {
            get { return this.SupplierEvents; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> IRoleModel.EventsMainTrainer
        {
            get { return this.EventsMainTrainer; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> IRoleModel.Bookings
        {
            get { return this.Bookings; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> IRoleModel.InvoiceBookings
        {
            get { return this.InvoiceBookings; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LearnerModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ILearnerModel> IRoleModel.Learners
        {
            get { return this.Learners; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TemplateTrainerModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ITemplateTrainerModel> IRoleModel.TemplateTrainers
        {
            get { return this.TemplateTrainers; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityXrefModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Sales.IOpportunityXrefModel> IRoleModel.OpportunityXrefs
        {
            get { return this.OpportunityXrefs; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPackModel> IRoleModel.PackSender
        {
            get { return this.PackSender; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LetterTemplateModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.ILetterTemplateModel> IRoleModel.LetterTemplates
        {
            get { return this.LetterTemplates; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OutputQueueModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IOutputQueueModel> IRoleModel.OutputQueues
        {
            get { return this.OutputQueues; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IAccountModel> IRoleModel.Accounts
        {
            get { return this.Accounts; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountXrefModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IAccountXrefModel> IRoleModel.AccountXrefs
        {
            get { return this.AccountXrefs; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPaymentModel> IRoleModel.Payments
        {
            get { return this.Payments; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceModel> IRoleModel.SalesPersonInvoices
        {
            get { return this.SalesPersonInvoices; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceModel> IRoleModel.Invoices
        {
            get { return this.Invoices; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrepayAccountModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IPrepayAccountModel> IRoleModel.PrepayAccount
        {
            get { return this.PrepayAccount; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:GiftaidclaimModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IGiftaidclaimModel> IRoleModel.GiftaidclaimsSubmitter
        {
            get { return this.GiftaidclaimsSubmitter; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:GiftaidclaimModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IGiftaidclaimModel> IRoleModel.GiftaidclaimsTrustee
        {
            get { return this.GiftaidclaimsTrustee; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityXrefModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IActivityXrefModel> IRoleModel.ActivityXRefs
        {
            get { return this.ActivityXRefs; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IHelpdeskModel> IRoleModel.HelpdeskProleId
        {
            get { return this.HelpdeskProleId; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IHelpdeskModel> IRoleModel.HelpdeskGivenToId
        {
            get { return this.HelpdeskGivenToId; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ComplaintModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IComplaintModel> IRoleModel.ComplaintComplainant
        {
            get { return this.ComplaintComplainant; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ComplaintModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IComplaintModel> IRoleModel.ComplaintRegarding
        {
            get { return this.ComplaintRegarding; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ComplaintModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IComplaintModel> IRoleModel.ComplaintAssignedTo
        {
            get { return this.ComplaintAssignedTo; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ComplaintModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IComplaintModel> IRoleModel.ComplaintOwner
        {
            get { return this.ComplaintOwner; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LicenseModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.ILicenseModel> IRoleModel.Licenses
        {
            get { return this.Licenses; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberPeriodModel> IRoleModel.InvoiceMemberPeriods
        {
            get { return this.InvoiceMemberPeriods; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberLocationModel> IRoleModel.MemberLocations
        {
            get { return this.MemberLocations; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CampaignModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ICampaignModel> IRoleModel.CampaignManager
        {
            get { return this.CampaignManager; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CampaignModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ICampaignModel> IRoleModel.CampaignApprover
        {
            get { return this.CampaignApprover; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.IPromotionModel> IRoleModel.PromotionManager
        {
            get { return this.PromotionManager; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.IPromotionModel> IRoleModel.PromotionApprover
        {
            get { return this.PromotionApprover; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionMasterModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.IPromotionMasterModel> IRoleModel.PromotionMasterManager
        {
            get { return this.PromotionMasterManager; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionMasterModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.IPromotionMasterModel> IRoleModel.PromotionMasterApprover
        {
            get { return this.PromotionMasterApprover; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqStepModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqStepModel> IRoleModel.SaqStepOwnerRole
        {
            get { return this.SaqStepOwnerRole; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueryModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueryModel> IRoleModel.SaqQueryManager
        {
            get { return this.SaqQueryManager; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueryModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueryModel> IRoleModel.SaqQueryApprover
        {
            get { return this.SaqQueryApprover; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MailingListModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.IMailingListModel> IRoleModel.MailingListOwners
        {
            get { return this.MailingListOwners; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PortalUserModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Portal.IPortalUserModel> IRoleModel.PortalUsers
        {
            get { return this.PortalUsers; }
        }

        #endregion
    }
}
