using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;
using Consensus.Finance;
using Consensus.Learning;
using Consensus.Membership;
using Consensus.Sales;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents An organisation.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalOrganisationModel : LocalModel<OrganisationRecord, String>, IOrganisationModel
    {
        #region fields

        /// <summary>
        ///     The value of the "ORG_TYPE" field.
        /// </summary>
        private LocalCodeModel _type;

        /// <summary>
        ///     The value of the "ORG_INDUSTRY" field.
        /// </summary>
        private LocalCodeModel _industry;

        /// <summary>
        ///     The value of the "ORG_VATCD" field.
        /// </summary>
        private LocalCodeModel _vatcd;

        /// <summary>
        ///     The value of the "ORG_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     The collection of <see cref="RoleModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalRoleModel, IRoleModel> _roles;

        /// <summary>
        ///     The collection of <see cref="OrganisationAddressModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalOrganisationAddressModel, IOrganisationAddressModel> _organisationAddresses;

        /// <summary>
        ///     The collection of <see cref="CustomerPackModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalCustomerPackModel, ICustomerPackModel> _customerPacks;

        /// <summary>
        ///     The collection of <see cref="AssociateModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalAssociateModel, IAssociateModel> _associates;

        /// <summary>
        ///     The collection of <see cref="OrganisationDepartmentModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalOrganisationDepartmentModel, IOrganisationDepartmentModel> _departments;

        /// <summary>
        ///     The collection of <see cref="LocationModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalLocationModel, ILocationModel> _locations;

        /// <summary>
        ///     The collection of <see cref="AkaModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalAkaModel, IAkaModel> _aKAOrganisation;

        /// <summary>
        ///     The collection of <see cref="ProductModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalProductModel, IProductModel> _product;

        /// <summary>
        ///     The collection of <see cref="EventModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalEventModel, IEventModel> _events;

        /// <summary>
        ///     The collection of <see cref="EventModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalEventModel, IEventModel> _eventsCommissioned;

        /// <summary>
        ///     The collection of <see cref="EventModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalEventModel, IEventModel> _supplierEvents;

        /// <summary>
        ///     The collection of <see cref="EventModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalEventModel, IEventModel> _fundingEvents;

        /// <summary>
        ///     The collection of <see cref="BookingModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalBookingModel, IBookingModel> _bookings;

        /// <summary>
        ///     The collection of <see cref="BookingModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalBookingModel, IBookingModel> _invoiceBookings;

        /// <summary>
        ///     The collection of <see cref="LearnerModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalLearnerModel, ILearnerModel> _learners;

        /// <summary>
        ///     The collection of <see cref="SessionModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalSessionModel, ISessionModel> _sessionOrganisation;

        /// <summary>
        ///     The collection of <see cref="OpportunityXrefModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalOpportunityXrefModel, IOpportunityXrefModel> _opportunityXrefs;

        /// <summary>
        ///     The collection of <see cref="AccountModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalAccountModel, IAccountModel> _accounts;

        /// <summary>
        ///     The collection of <see cref="AccountXrefModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalAccountXrefModel, IAccountXrefModel> _accountXrefs;

        /// <summary>
        ///     The collection of <see cref="PaymentModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalPaymentModel, IPaymentModel> _payments;

        /// <summary>
        ///     The collection of <see cref="InvoiceModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalInvoiceModel, IInvoiceModel> _invoices;

        /// <summary>
        ///     The collection of <see cref="PrepayAccountModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalPrepayAccountModel, IPrepayAccountModel> _prepayAccounts;

        /// <summary>
        ///     The collection of <see cref="GiftaidclaimModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalGiftaidclaimModel, IGiftaidclaimModel> _giftaidclaimsOrganisation;

        /// <summary>
        ///     The collection of <see cref="ProfileOrganisationModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalProfileOrganisationModel, IProfileOrganisationModel> _profileOrganisations;

        /// <summary>
        ///     The collection of <see cref="ActivityXrefModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalActivityXrefModel, IActivityXrefModel> _activityXRefs;

        /// <summary>
        ///     The collection of <see cref="HelpdeskModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalHelpdeskModel, IHelpdeskModel> _helpdeskOrganisationId;

        /// <summary>
        ///     The collection of <see cref="MemberPeriodModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel> _memberPeriodInvoice;

        /// <summary>
        ///     The collection of <see cref="MemberLocationModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        private LocalCollection<LocalMemberLocationModel, IMemberLocationModel> _memberLocations;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<OrganisationRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Contact.Organisation.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<OrganisationRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Contact.Organisation.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<OrganisationRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Contact.Organisation.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_PHONE" field.
        /// </summary>
        public String Phone
        {
            get { return this.ModifiedData.Phone; }
            set { this.ModifiedData.Phone = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_FAX" field.
        /// </summary>
        public String Fax
        {
            get { return this.ModifiedData.Fax; }
            set { this.ModifiedData.Fax = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ORG_TYPE" field.
        /// </summary>
        public LocalCodeModel Type
        {
            get
            {
                if (_type == null && !String.IsNullOrEmpty(this.TypeCode))
                    _type = this.Provider.Common.Code.FetchByTypeAndCode("ORGT", this.TypeCode);
                if (_type == null)
                    _type = this.Provider.Common.Code.Create("ORGT");
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ORG_TYPE" field.
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
        ///     Gets or sets the value of the "ORG_HIERARCHY_LEVL" field.
        /// </summary>
        public Byte? HierarchyLevl
        {
            get { return this.ModifiedData.HierarchyLevl; }
            set { this.ModifiedData.HierarchyLevl = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_5" field.
        /// </summary>
        public String Userchar5
        {
            get { return this.ModifiedData.Userchar5; }
            set { this.ModifiedData.Userchar5 = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ORG_INDUSTRY" field.
        /// </summary>
        public LocalCodeModel Industry
        {
            get
            {
                if (_industry == null && !String.IsNullOrEmpty(this.IndustryCode))
                    _industry = this.Provider.Common.Code.FetchByTypeAndCode("IND", this.IndustryCode);
                if (_industry == null)
                    _industry = this.Provider.Common.Code.Create("IND");
                return _industry;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ORG_INDUSTRY" field.
        /// </summary>
        public String IndustryCode
        {
            get { return this.ModifiedData.Industry; }
            set
            {
                if (this.ModifiedData.Industry != value)
                     _industry = null;
                this.ModifiedData.Industry = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_1" field.
        /// </summary>
        public String Userchar1
        {
            get { return this.ModifiedData.Userchar1; }
            set { this.ModifiedData.Userchar1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_2" field.
        /// </summary>
        public String Userchar2
        {
            get { return this.ModifiedData.Userchar2; }
            set { this.ModifiedData.Userchar2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_3" field.
        /// </summary>
        public String Userchar3
        {
            get { return this.ModifiedData.Userchar3; }
            set { this.ModifiedData.Userchar3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_4" field.
        /// </summary>
        public String Userchar4
        {
            get { return this.ModifiedData.Userchar4; }
            set { this.ModifiedData.Userchar4 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_SPECIAL_TERMS" field.
        /// </summary>
        public String SpecialTerms
        {
            get { return this.ModifiedData.SpecialTerms; }
            set { this.ModifiedData.SpecialTerms = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_URL" field.
        /// </summary>
        public String Website
        {
            get { return this.ModifiedData.Url; }
            set { this.ModifiedData.Url = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_6" field.
        /// </summary>
        public String Userchar6
        {
            get { return this.ModifiedData.Userchar6; }
            set { this.ModifiedData.Userchar6 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_7" field.
        /// </summary>
        public String Userchar7
        {
            get { return this.ModifiedData.Userchar7; }
            set { this.ModifiedData.Userchar7 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_EXIST_CLIENT" field.
        /// </summary>
        public Byte? ExistClient
        {
            get { return this.ModifiedData.ExistClient; }
            set { this.ModifiedData.ExistClient = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_EMAIL" field.
        /// </summary>
        public String Email
        {
            get { return this.ModifiedData.Email; }
            set { this.ModifiedData.Email = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERINT_1" field.
        /// </summary>
        public Int32? Userint1
        {
            get { return this.ModifiedData.Userint1; }
            set { this.ModifiedData.Userint1 = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ORG_VATCD" field.
        /// </summary>
        public LocalCodeModel Vatcd
        {
            get
            {
                if (_vatcd == null && !String.IsNullOrEmpty(this.VatcdCode))
                    _vatcd = this.Provider.Common.Code.FetchByTypeAndCode("VATCD", this.VatcdCode);
                if (_vatcd == null)
                    _vatcd = this.Provider.Common.Code.Create("VATCD");
                return _vatcd;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ORG_VATCD" field.
        /// </summary>
        public String VatcdCode
        {
            get { return this.ModifiedData.Vatcd; }
            set
            {
                if (this.ModifiedData.Vatcd != value)
                     _vatcd = null;
                this.ModifiedData.Vatcd = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_DISABLED" field.
        /// </summary>
        public Byte? Disabled
        {
            get { return this.ModifiedData.Disabled; }
            set { this.ModifiedData.Disabled = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_OUR_ORG" field.
        /// </summary>
        public Byte? OurOrg
        {
            get { return this.ModifiedData.OurOrg; }
            set { this.ModifiedData.OurOrg = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ORG_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "ORG_SELCO_SP_ID" field.
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
        ///     Gets or sets the value of the "ORG_REF" field.
        /// </summary>
        public String Ref
        {
            get { return this.ModifiedData.Ref; }
            set { this.ModifiedData.Ref = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_VAT_REG_NUM" field.
        /// </summary>
        public String VatRegNum
        {
            get { return this.ModifiedData.VatRegNum; }
            set { this.ModifiedData.VatRegNum = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_WEB_ENABLED" field.
        /// </summary>
        public Byte WebEnabled
        {
            get { return this.ModifiedData.WebEnabled; }
            set { this.ModifiedData.WebEnabled = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_PERSON_COUNT" field.
        /// </summary>
        public Int32 PersonCount
        {
            get { return this.ModifiedData.PersonCount; }
            set { this.ModifiedData.PersonCount = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_SPEND" field.
        /// </summary>
        public Decimal? Spend
        {
            get { return this.ModifiedData.Spend; }
            set { this.ModifiedData.Spend = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_ON_HOLD" field.
        /// </summary>
        public Byte OnHold
        {
            get { return this.ModifiedData.OnHold; }
            set { this.ModifiedData.OnHold = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="RoleModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        public LocalCollection<LocalRoleModel, IRoleModel> Roles
        {
            get
            {
                if (_roles == null)
                    _roles = new LocalCollection<LocalRoleModel, IRoleModel>(this.Provider.Contact.Role.FetchAllByOrganisationId(this.Id));
                
                return _roles;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="OrganisationAddressModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        public LocalCollection<LocalOrganisationAddressModel, IOrganisationAddressModel> OrganisationAddresses
        {
            get
            {
                if (_organisationAddresses == null)
                    _organisationAddresses = new LocalCollection<LocalOrganisationAddressModel, IOrganisationAddressModel>(this.Provider.Contact.OrganisationAddress.FetchAllByOrganisationId(this.Id));
                
                return _organisationAddresses;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="CustomerPackModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        public LocalCollection<LocalCustomerPackModel, ICustomerPackModel> CustomerPacks
        {
            get
            {
                if (_customerPacks == null)
                    _customerPacks = new LocalCollection<LocalCustomerPackModel, ICustomerPackModel>(this.Provider.Contact.CustomerPack.FetchAllByOrganisationId(this.Id));
                
                return _customerPacks;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="AssociateModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        public LocalCollection<LocalAssociateModel, IAssociateModel> Associates
        {
            get
            {
                if (_associates == null)
                    _associates = new LocalCollection<LocalAssociateModel, IAssociateModel>(this.Provider.Contact.Associate.FetchAllByOrganisationId(this.Id));
                
                return _associates;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="OrganisationDepartmentModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        public LocalCollection<LocalOrganisationDepartmentModel, IOrganisationDepartmentModel> Departments
        {
            get
            {
                if (_departments == null)
                    _departments = new LocalCollection<LocalOrganisationDepartmentModel, IOrganisationDepartmentModel>(this.Provider.Contact.OrganisationDepartment.FetchAllByOrganisationId(this.Id));
                
                return _departments;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="LocationModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        public LocalCollection<LocalLocationModel, ILocationModel> Locations
        {
            get
            {
                if (_locations == null)
                    _locations = new LocalCollection<LocalLocationModel, ILocationModel>(this.Provider.Contact.Location.FetchAllByOrganisationId(this.Id));
                
                return _locations;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="AkaModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        public LocalCollection<LocalAkaModel, IAkaModel> AKAOrganisation
        {
            get
            {
                if (_aKAOrganisation == null)
                    _aKAOrganisation = new LocalCollection<LocalAkaModel, IAkaModel>(this.Provider.Contact.Aka.FetchAllByOrgIdId(this.Id));
                
                return _aKAOrganisation;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        public LocalCollection<LocalProductModel, IProductModel> Product
        {
            get
            {
                if (_product == null)
                    _product = new LocalCollection<LocalProductModel, IProductModel>(this.Provider.Learning.Product.FetchAllByVenueId(this.Id));
                
                return _product;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalEventModel, IEventModel> Events
        {
            get
            {
                if (_events == null)
                    _events = new LocalCollection<LocalEventModel, IEventModel>(this.Provider.Learning.Event.FetchAllByOrganisationId(this.Id));
                
                return _events;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalEventModel, IEventModel> EventsCommissioned
        {
            get
            {
                if (_eventsCommissioned == null)
                    _eventsCommissioned = new LocalCollection<LocalEventModel, IEventModel>(this.Provider.Learning.Event.FetchAllByCommissionedId(this.Id));
                
                return _eventsCommissioned;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalEventModel, IEventModel> SupplierEvents
        {
            get
            {
                if (_supplierEvents == null)
                    _supplierEvents = new LocalCollection<LocalEventModel, IEventModel>(this.Provider.Learning.Event.FetchAllBySupplierOrgId(this.Id));
                
                return _supplierEvents;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalEventModel, IEventModel> FundingEvents
        {
            get
            {
                if (_fundingEvents == null)
                    _fundingEvents = new LocalCollection<LocalEventModel, IEventModel>(this.Provider.Learning.Event.FetchAllByFundingOrganisationId(this.Id));
                
                return _fundingEvents;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BookingModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalBookingModel, IBookingModel> Bookings
        {
            get
            {
                if (_bookings == null)
                    _bookings = new LocalCollection<LocalBookingModel, IBookingModel>(this.Provider.Learning.Booking.FetchAllByBookerOrgId(this.Id));
                
                return _bookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BookingModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalBookingModel, IBookingModel> InvoiceBookings
        {
            get
            {
                if (_invoiceBookings == null)
                    _invoiceBookings = new LocalCollection<LocalBookingModel, IBookingModel>(this.Provider.Learning.Booking.FetchAllByInvoiceOrgId(this.Id));
                
                return _invoiceBookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="LearnerModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        public LocalCollection<LocalLearnerModel, ILearnerModel> Learners
        {
            get
            {
                if (_learners == null)
                    _learners = new LocalCollection<LocalLearnerModel, ILearnerModel>(this.Provider.Learning.Learner.FetchAllByDelegateOrgId(this.Id));
                
                return _learners;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SessionModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalSessionModel, ISessionModel> SessionOrganisation
        {
            get
            {
                if (_sessionOrganisation == null)
                    _sessionOrganisation = new LocalCollection<LocalSessionModel, ISessionModel>(this.Provider.Learning.Session.FetchAllByOrganisationId(this.Id));
                
                return _sessionOrganisation;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="OpportunityXrefModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalOpportunityXrefModel, IOpportunityXrefModel> OpportunityXrefs
        {
            get
            {
                if (_opportunityXrefs == null)
                    _opportunityXrefs = new LocalCollection<LocalOpportunityXrefModel, IOpportunityXrefModel>(this.Provider.Sales.OpportunityXref.FetchAllByOrganisationId(this.Id));
                
                return _opportunityXrefs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="AccountModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalAccountModel, IAccountModel> Accounts
        {
            get
            {
                if (_accounts == null)
                    _accounts = new LocalCollection<LocalAccountModel, IAccountModel>(this.Provider.Finance.Account.FetchAllByOrganisationId(this.Id));
                
                return _accounts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="AccountXrefModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalAccountXrefModel, IAccountXrefModel> AccountXrefs
        {
            get
            {
                if (_accountXrefs == null)
                    _accountXrefs = new LocalCollection<LocalAccountXrefModel, IAccountXrefModel>(this.Provider.Finance.AccountXref.FetchAllByOrganisationId(this.Id));
                
                return _accountXrefs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PaymentModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalPaymentModel, IPaymentModel> Payments
        {
            get
            {
                if (_payments == null)
                    _payments = new LocalCollection<LocalPaymentModel, IPaymentModel>(this.Provider.Finance.Payment.FetchAllByOrganisationId(this.Id));
                
                return _payments;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="InvoiceModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalInvoiceModel, IInvoiceModel> Invoices
        {
            get
            {
                if (_invoices == null)
                    _invoices = new LocalCollection<LocalInvoiceModel, IInvoiceModel>(this.Provider.Finance.Invoice.FetchAllByOrganisationId(this.Id));
                
                return _invoices;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PrepayAccountModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalPrepayAccountModel, IPrepayAccountModel> PrepayAccounts
        {
            get
            {
                if (_prepayAccounts == null)
                    _prepayAccounts = new LocalCollection<LocalPrepayAccountModel, IPrepayAccountModel>(this.Provider.Finance.PrepayAccount.FetchAllByOrganisationId(this.Id));
                
                return _prepayAccounts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="GiftaidclaimModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        public LocalCollection<LocalGiftaidclaimModel, IGiftaidclaimModel> GiftaidclaimsOrganisation
        {
            get
            {
                if (_giftaidclaimsOrganisation == null)
                    _giftaidclaimsOrganisation = new LocalCollection<LocalGiftaidclaimModel, IGiftaidclaimModel>(this.Provider.Finance.Giftaidclaim.FetchAllByOrganisationId(this.Id));
                
                return _giftaidclaimsOrganisation;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProfileOrganisationModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        public LocalCollection<LocalProfileOrganisationModel, IProfileOrganisationModel> ProfileOrganisations
        {
            get
            {
                if (_profileOrganisations == null)
                    _profileOrganisations = new LocalCollection<LocalProfileOrganisationModel, IProfileOrganisationModel>(this.Provider.Common.ProfileOrganisation.FetchAllByOrganisationId(this.Id));
                
                return _profileOrganisations;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ActivityXrefModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalActivityXrefModel, IActivityXrefModel> ActivityXRefs
        {
            get
            {
                if (_activityXRefs == null)
                    _activityXRefs = new LocalCollection<LocalActivityXrefModel, IActivityXrefModel>(this.Provider.Activities.ActivityXref.FetchAllByOrganisationId(this.Id));
                
                return _activityXRefs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="HelpdeskModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalHelpdeskModel, IHelpdeskModel> HelpdeskOrganisationId
        {
            get
            {
                if (_helpdeskOrganisationId == null)
                    _helpdeskOrganisationId = new LocalCollection<LocalHelpdeskModel, IHelpdeskModel>(this.Provider.Activities.Helpdesk.FetchAllByOrgIdId(this.Id));
                
                return _helpdeskOrganisationId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MemberPeriodModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel> MemberPeriodInvoice
        {
            get
            {
                if (_memberPeriodInvoice == null)
                    _memberPeriodInvoice = new LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel>(this.Provider.Membership.MemberPeriod.FetchAllByInvOrganisationId(this.Id));
                
                return _memberPeriodInvoice;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MemberLocationModel" /> instances that reference this <see cref="OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalMemberLocationModel, IMemberLocationModel> MemberLocations
        {
            get
            {
                if (_memberLocations == null)
                    _memberLocations = new LocalCollection<LocalMemberLocationModel, IMemberLocationModel>(this.Provider.Membership.MemberLocation.FetchAllByOrgIdId(this.Id));
                
                return _memberLocations;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalOrganisationModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalOrganisationModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalOrganisationModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalOrganisationModel(LocalProvider provider, OrganisationRecord record) : base(provider, record)
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
            if (_type != null)
            {
                _type.Save();
                this.ModifiedData.Type = _type.Value1;
            }
            if (_industry != null)
            {
                _industry.Save();
                this.ModifiedData.Industry = _industry.Value1;
            }
            if (_vatcd != null)
            {
                _vatcd.Save();
                this.ModifiedData.Vatcd = _vatcd.Value1;
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
            if (_roles != null)
                _roles.Execute(obj => obj.OrganisationId = this.Id).Execute(obj => obj.Save());
            if (_organisationAddresses != null)
                _organisationAddresses.Execute(obj => obj.OrganisationId = this.Id).Execute(obj => obj.Save());
            if (_customerPacks != null)
                _customerPacks.Execute(obj => obj.OrganisationId = this.Id).Execute(obj => obj.Save());
            if (_associates != null)
                _associates.Execute(obj => obj.OrganisationId = this.Id).Execute(obj => obj.Save());
            if (_departments != null)
                _departments.Execute(obj => obj.OrganisationId = this.Id).Execute(obj => obj.Save());
            if (_locations != null)
                _locations.Execute(obj => obj.OrganisationId = this.Id).Execute(obj => obj.Save());
            if (_aKAOrganisation != null)
                _aKAOrganisation.Execute(obj => obj.OrgIdId = this.Id).Execute(obj => obj.Save());
            if (_product != null)
                _product.Execute(obj => obj.VenueId = this.Id).Execute(obj => obj.Save());
            if (_events != null)
                _events.Execute(obj => obj.OrganisationId = this.Id).Execute(obj => obj.Save());
            if (_eventsCommissioned != null)
                _eventsCommissioned.Execute(obj => obj.CommissionedId = this.Id).Execute(obj => obj.Save());
            if (_supplierEvents != null)
                _supplierEvents.Execute(obj => obj.SupplierOrgId = this.Id).Execute(obj => obj.Save());
            if (_fundingEvents != null)
                _fundingEvents.Execute(obj => obj.FundingOrganisationId = this.Id).Execute(obj => obj.Save());
            if (_bookings != null)
                _bookings.Execute(obj => obj.BookerOrgId = this.Id).Execute(obj => obj.Save());
            if (_invoiceBookings != null)
                _invoiceBookings.Execute(obj => obj.InvoiceOrgId = this.Id).Execute(obj => obj.Save());
            if (_learners != null)
                _learners.Execute(obj => obj.DelegateOrgId = this.Id).Execute(obj => obj.Save());
            if (_sessionOrganisation != null)
                _sessionOrganisation.Execute(obj => obj.OrganisationId = this.Id).Execute(obj => obj.Save());
            if (_opportunityXrefs != null)
                _opportunityXrefs.Execute(obj => obj.OrganisationId = this.Id).Execute(obj => obj.Save());
            if (_accounts != null)
                _accounts.Execute(obj => obj.OrganisationId = this.Id).Execute(obj => obj.Save());
            if (_accountXrefs != null)
                _accountXrefs.Execute(obj => obj.OrganisationId = this.Id).Execute(obj => obj.Save());
            if (_payments != null)
                _payments.Execute(obj => obj.OrganisationId = this.Id).Execute(obj => obj.Save());
            if (_invoices != null)
                _invoices.Execute(obj => obj.OrganisationId = this.Id).Execute(obj => obj.Save());
            if (_prepayAccounts != null)
                _prepayAccounts.Execute(obj => obj.OrganisationId = this.Id).Execute(obj => obj.Save());
            if (_giftaidclaimsOrganisation != null)
                _giftaidclaimsOrganisation.Execute(obj => obj.OrganisationId = this.Id).Execute(obj => obj.Save());
            if (_profileOrganisations != null)
                _profileOrganisations.Execute(obj => obj.OrganisationId = this.Id).Execute(obj => obj.Save());
            if (_activityXRefs != null)
                _activityXRefs.Execute(obj => obj.OrganisationId = this.Id).Execute(obj => obj.Save());
            if (_helpdeskOrganisationId != null)
                _helpdeskOrganisationId.Execute(obj => obj.OrgIdId = this.Id).Execute(obj => obj.Save());
            if (_memberPeriodInvoice != null)
                _memberPeriodInvoice.Execute(obj => obj.InvOrganisationId = this.Id).Execute(obj => obj.Save());
            if (_memberLocations != null)
                _memberLocations.Execute(obj => obj.OrgIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets theprincipal address for the organisation.
        /// </summary>
        Consensus.Contact.IOrganisationAddressModel IOrganisationModel.PrincipalAddress
        {
            get { return this.PrincipalAddress; }
            set { this.PrincipalAddress = (Consensus.Contact.LocalOrganisationAddressModel)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_NAME" field.
        /// </summary>
        System.String IOrganisationModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_PHONE" field.
        /// </summary>
        System.String IOrganisationModel.Phone
        {
            get { return this.Phone; }
            set { this.Phone = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_FAX" field.
        /// </summary>
        System.String IOrganisationModel.Fax
        {
            get { return this.Fax; }
            set { this.Fax = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ORG_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel IOrganisationModel.Type
        {
            get { return this.Type; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ORG_TYPE" field.
        /// </summary>
        System.String IOrganisationModel.TypeCode
        {
            get { return this.TypeCode; }
            set { this.TypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_HIERARCHY_LEVL" field.
        /// </summary>
        System.Nullable<System.Byte> IOrganisationModel.HierarchyLevl
        {
            get { return this.HierarchyLevl; }
            set { this.HierarchyLevl = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_5" field.
        /// </summary>
        System.String IOrganisationModel.Userchar5
        {
            get { return this.Userchar5; }
            set { this.Userchar5 = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ORG_INDUSTRY" field.
        /// </summary>
        Consensus.Common.ICodeModel IOrganisationModel.Industry
        {
            get { return this.Industry; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ORG_INDUSTRY" field.
        /// </summary>
        System.String IOrganisationModel.IndustryCode
        {
            get { return this.IndustryCode; }
            set { this.IndustryCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_1" field.
        /// </summary>
        System.String IOrganisationModel.Userchar1
        {
            get { return this.Userchar1; }
            set { this.Userchar1 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_2" field.
        /// </summary>
        System.String IOrganisationModel.Userchar2
        {
            get { return this.Userchar2; }
            set { this.Userchar2 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_3" field.
        /// </summary>
        System.String IOrganisationModel.Userchar3
        {
            get { return this.Userchar3; }
            set { this.Userchar3 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_4" field.
        /// </summary>
        System.String IOrganisationModel.Userchar4
        {
            get { return this.Userchar4; }
            set { this.Userchar4 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_SPECIAL_TERMS" field.
        /// </summary>
        System.String IOrganisationModel.SpecialTerms
        {
            get { return this.SpecialTerms; }
            set { this.SpecialTerms = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_URL" field.
        /// </summary>
        System.String IOrganisationModel.Website
        {
            get { return this.Website; }
            set { this.Website = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_6" field.
        /// </summary>
        System.String IOrganisationModel.Userchar6
        {
            get { return this.Userchar6; }
            set { this.Userchar6 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_7" field.
        /// </summary>
        System.String IOrganisationModel.Userchar7
        {
            get { return this.Userchar7; }
            set { this.Userchar7 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_EXIST_CLIENT" field.
        /// </summary>
        System.Nullable<System.Byte> IOrganisationModel.ExistClient
        {
            get { return this.ExistClient; }
            set { this.ExistClient = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_EMAIL" field.
        /// </summary>
        System.String IOrganisationModel.Email
        {
            get { return this.Email; }
            set { this.Email = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERINT_1" field.
        /// </summary>
        System.Nullable<System.Int32> IOrganisationModel.Userint1
        {
            get { return this.Userint1; }
            set { this.Userint1 = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ORG_VATCD" field.
        /// </summary>
        Consensus.Common.ICodeModel IOrganisationModel.Vatcd
        {
            get { return this.Vatcd; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ORG_VATCD" field.
        /// </summary>
        System.String IOrganisationModel.VatcdCode
        {
            get { return this.VatcdCode; }
            set { this.VatcdCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_DISABLED" field.
        /// </summary>
        System.Nullable<System.Byte> IOrganisationModel.Disabled
        {
            get { return this.Disabled; }
            set { this.Disabled = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_OUR_ORG" field.
        /// </summary>
        System.Nullable<System.Byte> IOrganisationModel.OurOrg
        {
            get { return this.OurOrg; }
            set { this.OurOrg = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ORG_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel IOrganisationModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ORG_SELCO_SP_ID" field.
        /// </summary>
        System.String IOrganisationModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_REF" field.
        /// </summary>
        System.String IOrganisationModel.Ref
        {
            get { return this.Ref; }
            set { this.Ref = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_VAT_REG_NUM" field.
        /// </summary>
        System.String IOrganisationModel.VatRegNum
        {
            get { return this.VatRegNum; }
            set { this.VatRegNum = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_WEB_ENABLED" field.
        /// </summary>
        System.Byte IOrganisationModel.WebEnabled
        {
            get { return this.WebEnabled; }
            set { this.WebEnabled = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_PERSON_COUNT" field.
        /// </summary>
        System.Int32 IOrganisationModel.PersonCount
        {
            get { return this.PersonCount; }
            set { this.PersonCount = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_SPEND" field.
        /// </summary>
        System.Nullable<System.Decimal> IOrganisationModel.Spend
        {
            get { return this.Spend; }
            set { this.Spend = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_ON_HOLD" field.
        /// </summary>
        System.Byte IOrganisationModel.OnHold
        {
            get { return this.OnHold; }
            set { this.OnHold = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:RoleModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IRoleModel> IOrganisationModel.Roles
        {
            get { return this.Roles; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OrganisationAddressModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IOrganisationAddressModel> IOrganisationModel.OrganisationAddresses
        {
            get { return this.OrganisationAddresses; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CustomerPackModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ICustomerPackModel> IOrganisationModel.CustomerPacks
        {
            get { return this.CustomerPacks; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AssociateModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IAssociateModel> IOrganisationModel.Associates
        {
            get { return this.Associates; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OrganisationDepartmentModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IOrganisationDepartmentModel> IOrganisationModel.Departments
        {
            get { return this.Departments; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LocationModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ILocationModel> IOrganisationModel.Locations
        {
            get { return this.Locations; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AkaModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IAkaModel> IOrganisationModel.AKAOrganisation
        {
            get { return this.AKAOrganisation; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> IOrganisationModel.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> IOrganisationModel.Events
        {
            get { return this.Events; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> IOrganisationModel.EventsCommissioned
        {
            get { return this.EventsCommissioned; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> IOrganisationModel.SupplierEvents
        {
            get { return this.SupplierEvents; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> IOrganisationModel.FundingEvents
        {
            get { return this.FundingEvents; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IBookingModel> IOrganisationModel.Bookings
        {
            get { return this.Bookings; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IBookingModel> IOrganisationModel.InvoiceBookings
        {
            get { return this.InvoiceBookings; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LearnerModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ILearnerModel> IOrganisationModel.Learners
        {
            get { return this.Learners; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SessionModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.ISessionModel> IOrganisationModel.SessionOrganisation
        {
            get { return this.SessionOrganisation; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityXrefModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Sales.IOpportunityXrefModel> IOrganisationModel.OpportunityXrefs
        {
            get { return this.OpportunityXrefs; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IAccountModel> IOrganisationModel.Accounts
        {
            get { return this.Accounts; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountXrefModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IAccountXrefModel> IOrganisationModel.AccountXrefs
        {
            get { return this.AccountXrefs; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IPaymentModel> IOrganisationModel.Payments
        {
            get { return this.Payments; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IInvoiceModel> IOrganisationModel.Invoices
        {
            get { return this.Invoices; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrepayAccountModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IPrepayAccountModel> IOrganisationModel.PrepayAccounts
        {
            get { return this.PrepayAccounts; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:GiftaidclaimModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IGiftaidclaimModel> IOrganisationModel.GiftaidclaimsOrganisation
        {
            get { return this.GiftaidclaimsOrganisation; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProfileOrganisationModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Common.IProfileOrganisationModel> IOrganisationModel.ProfileOrganisations
        {
            get { return this.ProfileOrganisations; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityXrefModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Activities.IActivityXrefModel> IOrganisationModel.ActivityXRefs
        {
            get { return this.ActivityXRefs; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Activities.IHelpdeskModel> IOrganisationModel.HelpdeskOrganisationId
        {
            get { return this.HelpdeskOrganisationId; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Membership.IMemberPeriodModel> IOrganisationModel.MemberPeriodInvoice
        {
            get { return this.MemberPeriodInvoice; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Membership.IMemberLocationModel> IOrganisationModel.MemberLocations
        {
            get { return this.MemberLocations; }
        }

        #endregion
    }
}
