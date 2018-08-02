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
    public partial class Organisation : Proxy<IOrganisationModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PrincipalAddress" /> member.
        /// </summary>
        private Consensus.Contact.OrganisationAddress _principalAddress;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Type" /> member.
        /// </summary>
        private Consensus.Common.Code _type;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Industry" /> member.
        /// </summary>
        private Consensus.Common.Code _industry;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Vatcd" /> member.
        /// </summary>
        private Consensus.Common.Code _vatcd;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Roles" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Role, Consensus.Contact.IRoleModel> _roles;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="OrganisationAddresses" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.OrganisationAddress, Consensus.Contact.IOrganisationAddressModel> _organisationAddresses;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="CustomerPacks" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.CustomerPack, Consensus.Contact.ICustomerPackModel> _customerPacks;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Associates" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Associate, Consensus.Contact.IAssociateModel> _associates;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Departments" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.OrganisationDepartment, Consensus.Contact.IOrganisationDepartmentModel> _departments;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Locations" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Location, Consensus.Contact.ILocationModel> _locations;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="AKAOrganisation" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Aka, Consensus.Contact.IAkaModel> _aKAOrganisation;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Product" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel> _product;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Events" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel> _events;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="EventsCommissioned" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel> _eventsCommissioned;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SupplierEvents" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel> _supplierEvents;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="FundingEvents" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel> _fundingEvents;

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
        ///     The client-consumable proxy collection for the <see cref="SessionOrganisation" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Session, Consensus.Learning.ISessionModel> _sessionOrganisation;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="OpportunityXrefs" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Sales.OpportunityXref, Consensus.Sales.IOpportunityXrefModel> _opportunityXrefs;

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
        ///     The client-consumable proxy collection for the <see cref="Invoices" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Invoice, Consensus.Finance.IInvoiceModel> _invoices;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PrepayAccounts" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.PrepayAccount, Consensus.Finance.IPrepayAccountModel> _prepayAccounts;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="GiftaidclaimsOrganisation" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Giftaidclaim, Consensus.Finance.IGiftaidclaimModel> _giftaidclaimsOrganisation;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ProfileOrganisations" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Common.ProfileOrganisation, Consensus.Common.IProfileOrganisationModel> _profileOrganisations;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ActivityXRefs" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.ActivityXref, Consensus.Activities.IActivityXrefModel> _activityXRefs;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="HelpdeskOrganisationId" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.Helpdesk, Consensus.Activities.IHelpdeskModel> _helpdeskOrganisationId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MemberPeriodInvoice" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.MemberPeriod, Consensus.Membership.IMemberPeriodModel> _memberPeriodInvoice;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MemberLocations" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.MemberLocation, Consensus.Membership.IMemberLocationModel> _memberLocations;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets theprincipal address for the organisation.
        /// </summary>
        public Consensus.Contact.OrganisationAddress PrincipalAddress
        {
            get
            {
                if (_principalAddress == null && this.Model.PrincipalAddress != null)
                    _principalAddress = new Consensus.Contact.OrganisationAddress(this.Model.PrincipalAddress);
                if (_principalAddress == null)
                    _principalAddress = Consensus.Contact.OrganisationAddress.Create();
                return _principalAddress;
            }
            set
            {
                _principalAddress = value;
                this.Model.PrincipalAddress = value.Model;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_PHONE" field.
        /// </summary>
        public System.String Phone
        {
            get { return this.Model.Phone; }
            set { this.Model.Phone = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_FAX" field.
        /// </summary>
        public System.String Fax
        {
            get { return this.Model.Fax; }
            set { this.Model.Fax = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ORG_TYPE" field.
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
        ///     Gets or sets the unique code for the value of the "ORG_TYPE" field.
        /// </summary>
        public System.String TypeCode
        {
            get { return this.Model.TypeCode; }
            set { this.Model.TypeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_HIERARCHY_LEVL" field.
        /// </summary>
        public System.Nullable<System.Byte> HierarchyLevl
        {
            get { return this.Model.HierarchyLevl; }
            set { this.Model.HierarchyLevl = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_5" field.
        /// </summary>
        public System.String Userchar5
        {
            get { return this.Model.Userchar5; }
            set { this.Model.Userchar5 = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ORG_INDUSTRY" field.
        /// </summary>
        public Consensus.Common.Code Industry
        {
            get
            {
                if (_industry == null && this.Model.Industry != null)
                    _industry = new Consensus.Common.Code(this.Model.Industry);
                if (_industry == null)
                    _industry = Consensus.Common.Code.Create();
                return _industry;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ORG_INDUSTRY" field.
        /// </summary>
        public System.String IndustryCode
        {
            get { return this.Model.IndustryCode; }
            set { this.Model.IndustryCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_1" field.
        /// </summary>
        public System.String Userchar1
        {
            get { return this.Model.Userchar1; }
            set { this.Model.Userchar1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_2" field.
        /// </summary>
        public System.String Userchar2
        {
            get { return this.Model.Userchar2; }
            set { this.Model.Userchar2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_3" field.
        /// </summary>
        public System.String Userchar3
        {
            get { return this.Model.Userchar3; }
            set { this.Model.Userchar3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_4" field.
        /// </summary>
        public System.String Userchar4
        {
            get { return this.Model.Userchar4; }
            set { this.Model.Userchar4 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_SPECIAL_TERMS" field.
        /// </summary>
        public System.String SpecialTerms
        {
            get { return this.Model.SpecialTerms; }
            set { this.Model.SpecialTerms = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_URL" field.
        /// </summary>
        public System.String Website
        {
            get { return this.Model.Website; }
            set { this.Model.Website = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_6" field.
        /// </summary>
        public System.String Userchar6
        {
            get { return this.Model.Userchar6; }
            set { this.Model.Userchar6 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_7" field.
        /// </summary>
        public System.String Userchar7
        {
            get { return this.Model.Userchar7; }
            set { this.Model.Userchar7 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_EXIST_CLIENT" field.
        /// </summary>
        public System.Nullable<System.Byte> ExistClient
        {
            get { return this.Model.ExistClient; }
            set { this.Model.ExistClient = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_EMAIL" field.
        /// </summary>
        public System.String Email
        {
            get { return this.Model.Email; }
            set { this.Model.Email = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERINT_1" field.
        /// </summary>
        public System.Nullable<System.Int32> Userint1
        {
            get { return this.Model.Userint1; }
            set { this.Model.Userint1 = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ORG_VATCD" field.
        /// </summary>
        public Consensus.Common.Code Vatcd
        {
            get
            {
                if (_vatcd == null && this.Model.Vatcd != null)
                    _vatcd = new Consensus.Common.Code(this.Model.Vatcd);
                if (_vatcd == null)
                    _vatcd = Consensus.Common.Code.Create();
                return _vatcd;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ORG_VATCD" field.
        /// </summary>
        public System.String VatcdCode
        {
            get { return this.Model.VatcdCode; }
            set { this.Model.VatcdCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_DISABLED" field.
        /// </summary>
        public System.Nullable<System.Byte> Disabled
        {
            get { return this.Model.Disabled; }
            set { this.Model.Disabled = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_OUR_ORG" field.
        /// </summary>
        public System.Nullable<System.Byte> OurOrg
        {
            get { return this.Model.OurOrg; }
            set { this.Model.OurOrg = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ORG_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "ORG_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_REF" field.
        /// </summary>
        public System.String Ref
        {
            get { return this.Model.Ref; }
            set { this.Model.Ref = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_VAT_REG_NUM" field.
        /// </summary>
        public System.String VatRegNum
        {
            get { return this.Model.VatRegNum; }
            set { this.Model.VatRegNum = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_WEB_ENABLED" field.
        /// </summary>
        public System.Byte WebEnabled
        {
            get { return this.Model.WebEnabled; }
            set { this.Model.WebEnabled = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_PERSON_COUNT" field.
        /// </summary>
        public System.Int32 PersonCount
        {
            get { return this.Model.PersonCount; }
            set { this.Model.PersonCount = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_SPEND" field.
        /// </summary>
        public System.Nullable<System.Decimal> Spend
        {
            get { return this.Model.Spend; }
            set { this.Model.Spend = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_ON_HOLD" field.
        /// </summary>
        public System.Byte OnHold
        {
            get { return this.Model.OnHold; }
            set { this.Model.OnHold = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:RoleModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        public Collection<Consensus.Contact.Role> Roles
        {
            get
            {
                if (_roles == null)
                    _roles = new ProxyCollection<Consensus.Contact.Role, Consensus.Contact.IRoleModel>(this.Model.Roles, model => new Consensus.Contact.Role(model));
                return _roles;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OrganisationAddressModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        public Collection<Consensus.Contact.OrganisationAddress> OrganisationAddresses
        {
            get
            {
                if (_organisationAddresses == null)
                    _organisationAddresses = new ProxyCollection<Consensus.Contact.OrganisationAddress, Consensus.Contact.IOrganisationAddressModel>(this.Model.OrganisationAddresses, model => new Consensus.Contact.OrganisationAddress(model));
                return _organisationAddresses;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CustomerPackModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        public Collection<Consensus.Contact.CustomerPack> CustomerPacks
        {
            get
            {
                if (_customerPacks == null)
                    _customerPacks = new ProxyCollection<Consensus.Contact.CustomerPack, Consensus.Contact.ICustomerPackModel>(this.Model.CustomerPacks, model => new Consensus.Contact.CustomerPack(model));
                return _customerPacks;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AssociateModel" /> instances that reference this <see cref="!:OrganisationModel" />.
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
        ///     Gets the collection of <see cref="!:OrganisationDepartmentModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        public Collection<Consensus.Contact.OrganisationDepartment> Departments
        {
            get
            {
                if (_departments == null)
                    _departments = new ProxyCollection<Consensus.Contact.OrganisationDepartment, Consensus.Contact.IOrganisationDepartmentModel>(this.Model.Departments, model => new Consensus.Contact.OrganisationDepartment(model));
                return _departments;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LocationModel" /> instances that reference this <see cref="!:OrganisationModel" />.
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
        ///     Gets the collection of <see cref="!:AkaModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        public Collection<Consensus.Contact.Aka> AKAOrganisation
        {
            get
            {
                if (_aKAOrganisation == null)
                    _aKAOrganisation = new ProxyCollection<Consensus.Contact.Aka, Consensus.Contact.IAkaModel>(this.Model.AKAOrganisation, model => new Consensus.Contact.Aka(model));
                return _aKAOrganisation;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:OrganisationModel" />.
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
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:OrganisationModel" />.
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
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.Event> EventsCommissioned
        {
            get
            {
                if (_eventsCommissioned == null)
                    _eventsCommissioned = new ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel>(this.Model.EventsCommissioned, model => new Consensus.Learning.Event(model));
                return _eventsCommissioned;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:OrganisationModel" />.
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
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.Event> FundingEvents
        {
            get
            {
                if (_fundingEvents == null)
                    _fundingEvents = new ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel>(this.Model.FundingEvents, model => new Consensus.Learning.Event(model));
                return _fundingEvents;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
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
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
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
        ///     Gets the collection of <see cref="!:LearnerModel" /> instances that reference this <see cref="!:OrganisationModel" />.
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
        ///     Gets the collection of <see cref="!:SessionModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.Session> SessionOrganisation
        {
            get
            {
                if (_sessionOrganisation == null)
                    _sessionOrganisation = new ProxyCollection<Consensus.Learning.Session, Consensus.Learning.ISessionModel>(this.Model.SessionOrganisation, model => new Consensus.Learning.Session(model));
                return _sessionOrganisation;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityXrefModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
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
        ///     Gets the collection of <see cref="!:AccountModel" /> instances that reference this <see cref="!:OrganisationModel" />.
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
        ///     Gets the collection of <see cref="!:AccountXrefModel" /> instances that reference this <see cref="!:OrganisationModel" />.
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
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
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
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
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
        ///     Gets the collection of <see cref="!:PrepayAccountModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Finance.PrepayAccount> PrepayAccounts
        {
            get
            {
                if (_prepayAccounts == null)
                    _prepayAccounts = new ProxyCollection<Consensus.Finance.PrepayAccount, Consensus.Finance.IPrepayAccountModel>(this.Model.PrepayAccounts, model => new Consensus.Finance.PrepayAccount(model));
                return _prepayAccounts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:GiftaidclaimModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        public Collection<Consensus.Finance.Giftaidclaim> GiftaidclaimsOrganisation
        {
            get
            {
                if (_giftaidclaimsOrganisation == null)
                    _giftaidclaimsOrganisation = new ProxyCollection<Consensus.Finance.Giftaidclaim, Consensus.Finance.IGiftaidclaimModel>(this.Model.GiftaidclaimsOrganisation, model => new Consensus.Finance.Giftaidclaim(model));
                return _giftaidclaimsOrganisation;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProfileOrganisationModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        public Collection<Consensus.Common.ProfileOrganisation> ProfileOrganisations
        {
            get
            {
                if (_profileOrganisations == null)
                    _profileOrganisations = new ProxyCollection<Consensus.Common.ProfileOrganisation, Consensus.Common.IProfileOrganisationModel>(this.Model.ProfileOrganisations, model => new Consensus.Common.ProfileOrganisation(model));
                return _profileOrganisations;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityXrefModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
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
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Activities.Helpdesk> HelpdeskOrganisationId
        {
            get
            {
                if (_helpdeskOrganisationId == null)
                    _helpdeskOrganisationId = new ProxyCollection<Consensus.Activities.Helpdesk, Consensus.Activities.IHelpdeskModel>(this.Model.HelpdeskOrganisationId, model => new Consensus.Activities.Helpdesk(model));
                return _helpdeskOrganisationId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Membership.MemberPeriod> MemberPeriodInvoice
        {
            get
            {
                if (_memberPeriodInvoice == null)
                    _memberPeriodInvoice = new ProxyCollection<Consensus.Membership.MemberPeriod, Consensus.Membership.IMemberPeriodModel>(this.Model.MemberPeriodInvoice, model => new Consensus.Membership.MemberPeriod(model));
                return _memberPeriodInvoice;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Membership.MemberLocation> MemberLocations
        {
            get
            {
                if (_memberLocations == null)
                    _memberLocations = new ProxyCollection<Consensus.Membership.MemberLocation, Consensus.Membership.IMemberLocationModel>(this.Model.MemberLocations, model => new Consensus.Membership.MemberLocation(model));
                return _memberLocations;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Organisation(IOrganisationModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:OrganisationModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OrganisationModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Organisation Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Organisation.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:OrganisationModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:OrganisationModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Organisation Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.IOrganisationModel model = provider.Contact.Organisation.Create();
            return model == null ? null : new Consensus.Contact.Organisation(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OrganisationModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OrganisationModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Organisation> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Organisation.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:OrganisationModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:OrganisationModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Organisation> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IOrganisationModel> collection = provider.Contact.Organisation.FetchAll();
            return collection.Select(model => new Consensus.Contact.Organisation(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:OrganisationModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OrganisationModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Organisation FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Organisation.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:OrganisationModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:OrganisationModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Organisation FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.IOrganisationModel model = provider.Contact.Organisation.FetchById(id);
            return model == null ? null : new Consensus.Contact.Organisation(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Organisation.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.Organisation.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OrganisationModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:OrganisationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Organisation> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Organisation.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:OrganisationModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:OrganisationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:OrganisationModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Organisation> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IOrganisationModel> collection = provider.Contact.Organisation.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Contact.Organisation(model));
        }

        #endregion
    }
}
