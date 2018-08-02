using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Finance;
using Consensus.Learning;
using Consensus.Membership;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="AddressRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalAddressModel : LocalModel<AddressRecord, String>, IAddressModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="RoleModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        private LocalCollection<LocalRoleModel, IRoleModel> _roles;

        /// <summary>
        ///     The collection of <see cref="OrganisationAddressModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        private LocalCollection<LocalOrganisationAddressModel, IOrganisationAddressModel> _organisationAddresses;

        /// <summary>
        ///     The collection of <see cref="LocationModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        private LocalCollection<LocalLocationModel, ILocationModel> _locations;

        /// <summary>
        ///     The collection of <see cref="EventModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        private LocalCollection<LocalEventModel, IEventModel> _events;

        /// <summary>
        ///     The collection of <see cref="BookingModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        private LocalCollection<LocalBookingModel, IBookingModel> _invoiceBookings;

        /// <summary>
        ///     The collection of <see cref="BookingModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        private LocalCollection<LocalBookingModel, IBookingModel> _deliveryBookings;

        /// <summary>
        ///     The collection of <see cref="BookingModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        private LocalCollection<LocalBookingModel, IBookingModel> _bookings;

        /// <summary>
        ///     The collection of <see cref="LearnerModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        private LocalCollection<LocalLearnerModel, ILearnerModel> _learners;

        /// <summary>
        ///     The collection of <see cref="AccountModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        private LocalCollection<LocalAccountModel, IAccountModel> _accounts;

        /// <summary>
        ///     The collection of <see cref="AccountXrefModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        private LocalCollection<LocalAccountXrefModel, IAccountXrefModel> _accountXrefs;

        /// <summary>
        ///     The collection of <see cref="PaymentModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        private LocalCollection<LocalPaymentModel, IPaymentModel> _payments;

        /// <summary>
        ///     The collection of <see cref="InvoiceModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        private LocalCollection<LocalInvoiceModel, IInvoiceModel> _invoices;

        /// <summary>
        ///     The collection of <see cref="MemberPeriodModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        private LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel> _merberPeriodInvoice;

        /// <summary>
        ///     The collection of <see cref="MemberLocationModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        private LocalCollection<LocalMemberLocationModel, IMemberLocationModel> _memberLocations;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<AddressRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Contact.Address.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<AddressRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Contact.Address.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<AddressRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Contact.Address.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_BUILDING" field.
        /// </summary>
        public String Building
        {
            get { return this.ModifiedData.Building; }
            set { this.ModifiedData.Building = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_STREET" field.
        /// </summary>
        public String Street
        {
            get { return this.ModifiedData.Street; }
            set { this.ModifiedData.Street = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_TOWN" field.
        /// </summary>
        public String Town
        {
            get { return this.ModifiedData.Town; }
            set { this.ModifiedData.Town = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_AREA" field.
        /// </summary>
        public String Area
        {
            get { return this.ModifiedData.Area; }
            set { this.ModifiedData.Area = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_COUNTY" field.
        /// </summary>
        public String County
        {
            get { return this.ModifiedData.County; }
            set { this.ModifiedData.County = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_POSTCODE" field.
        /// </summary>
        public String Postcode
        {
            get { return this.ModifiedData.Postcode; }
            set { this.ModifiedData.Postcode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_COUNTRY" field.
        /// </summary>
        public String Country
        {
            get { return this.ModifiedData.Country; }
            set { this.ModifiedData.Country = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_PHONE" field.
        /// </summary>
        public String Phone
        {
            get { return this.ModifiedData.Phone; }
            set { this.ModifiedData.Phone = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_FAX" field.
        /// </summary>
        public String Fax
        {
            get { return this.ModifiedData.Fax; }
            set { this.ModifiedData.Fax = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_EMAIL" field.
        /// </summary>
        public String Email
        {
            get { return this.ModifiedData.Email; }
            set { this.ModifiedData.Email = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_LAT" field.
        /// </summary>
        public Decimal? Lat
        {
            get { return this.ModifiedData.Lat; }
            set { this.ModifiedData.Lat = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_LONG" field.
        /// </summary>
        public Decimal? Long
        {
            get { return this.ModifiedData.Long; }
            set { this.ModifiedData.Long = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_GRID_EAST" field.
        /// </summary>
        public String GridEast
        {
            get { return this.ModifiedData.GridEast; }
            set { this.ModifiedData.GridEast = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_GRID_NORTH" field.
        /// </summary>
        public String GridNorth
        {
            get { return this.ModifiedData.GridNorth; }
            set { this.ModifiedData.GridNorth = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_MAILSORT_CODE" field.
        /// </summary>
        public String MailsortCode
        {
            get { return this.ModifiedData.MailsortCode; }
            set { this.ModifiedData.MailsortCode = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="RoleModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        public LocalCollection<LocalRoleModel, IRoleModel> Roles
        {
            get
            {
                if (_roles == null)
                    _roles = new LocalCollection<LocalRoleModel, IRoleModel>(this.Provider.Contact.Role.FetchAllByAddressId(this.Id));
                
                return _roles;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="OrganisationAddressModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        public LocalCollection<LocalOrganisationAddressModel, IOrganisationAddressModel> OrganisationAddresses
        {
            get
            {
                if (_organisationAddresses == null)
                    _organisationAddresses = new LocalCollection<LocalOrganisationAddressModel, IOrganisationAddressModel>(this.Provider.Contact.OrganisationAddress.FetchAllByAddressId(this.Id));
                
                return _organisationAddresses;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="LocationModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        public LocalCollection<LocalLocationModel, ILocationModel> Locations
        {
            get
            {
                if (_locations == null)
                    _locations = new LocalCollection<LocalLocationModel, ILocationModel>(this.Provider.Contact.Location.FetchAllByAddressId(this.Id));
                
                return _locations;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalEventModel, IEventModel> Events
        {
            get
            {
                if (_events == null)
                    _events = new LocalCollection<LocalEventModel, IEventModel>(this.Provider.Learning.Event.FetchAllByAddressId(this.Id));
                
                return _events;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BookingModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        public LocalCollection<LocalBookingModel, IBookingModel> InvoiceBookings
        {
            get
            {
                if (_invoiceBookings == null)
                    _invoiceBookings = new LocalCollection<LocalBookingModel, IBookingModel>(this.Provider.Learning.Booking.FetchAllByInvoiceAddressId(this.Id));
                
                return _invoiceBookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BookingModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        public LocalCollection<LocalBookingModel, IBookingModel> DeliveryBookings
        {
            get
            {
                if (_deliveryBookings == null)
                    _deliveryBookings = new LocalCollection<LocalBookingModel, IBookingModel>(this.Provider.Learning.Booking.FetchAllByDelivAddId(this.Id));
                
                return _deliveryBookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BookingModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        public LocalCollection<LocalBookingModel, IBookingModel> Bookings
        {
            get
            {
                if (_bookings == null)
                    _bookings = new LocalCollection<LocalBookingModel, IBookingModel>(this.Provider.Learning.Booking.FetchAllByBookerAddressId(this.Id));
                
                return _bookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="LearnerModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        public LocalCollection<LocalLearnerModel, ILearnerModel> Learners
        {
            get
            {
                if (_learners == null)
                    _learners = new LocalCollection<LocalLearnerModel, ILearnerModel>(this.Provider.Learning.Learner.FetchAllByDelegateAddressId(this.Id));
                
                return _learners;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="AccountModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalAccountModel, IAccountModel> Accounts
        {
            get
            {
                if (_accounts == null)
                    _accounts = new LocalCollection<LocalAccountModel, IAccountModel>(this.Provider.Finance.Account.FetchAllByAddressId(this.Id));
                
                return _accounts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="AccountXrefModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalAccountXrefModel, IAccountXrefModel> AccountXrefs
        {
            get
            {
                if (_accountXrefs == null)
                    _accountXrefs = new LocalCollection<LocalAccountXrefModel, IAccountXrefModel>(this.Provider.Finance.AccountXref.FetchAllByAddressId(this.Id));
                
                return _accountXrefs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PaymentModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        public LocalCollection<LocalPaymentModel, IPaymentModel> Payments
        {
            get
            {
                if (_payments == null)
                    _payments = new LocalCollection<LocalPaymentModel, IPaymentModel>(this.Provider.Finance.Payment.FetchAllByAddressId(this.Id));
                
                return _payments;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="InvoiceModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        public LocalCollection<LocalInvoiceModel, IInvoiceModel> Invoices
        {
            get
            {
                if (_invoices == null)
                    _invoices = new LocalCollection<LocalInvoiceModel, IInvoiceModel>(this.Provider.Finance.Invoice.FetchAllByAddId(this.Id));
                
                return _invoices;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MemberPeriodModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        public LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel> MerberPeriodInvoice
        {
            get
            {
                if (_merberPeriodInvoice == null)
                    _merberPeriodInvoice = new LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel>(this.Provider.Membership.MemberPeriod.FetchAllByInvAddressId(this.Id));
                
                return _merberPeriodInvoice;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MemberLocationModel" /> instances that reference this <see cref="AddressModel" />.
        /// </summary>
        public LocalCollection<LocalMemberLocationModel, IMemberLocationModel> MemberLocations
        {
            get
            {
                if (_memberLocations == null)
                    _memberLocations = new LocalCollection<LocalMemberLocationModel, IMemberLocationModel>(this.Provider.Membership.MemberLocation.FetchAllByMailAddIdId(this.Id));
                
                return _memberLocations;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalAddressModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalAddressModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalAddressModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalAddressModel(LocalProvider provider, AddressRecord record) : base(provider, record)
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
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_roles != null)
                _roles.Execute(obj => obj.AddressId = this.Id).Execute(obj => obj.Save());
            if (_organisationAddresses != null)
                _organisationAddresses.Execute(obj => obj.AddressId = this.Id).Execute(obj => obj.Save());
            if (_locations != null)
                _locations.Execute(obj => obj.AddressId = this.Id).Execute(obj => obj.Save());
            if (_events != null)
                _events.Execute(obj => obj.AddressId = this.Id).Execute(obj => obj.Save());
            if (_invoiceBookings != null)
                _invoiceBookings.Execute(obj => obj.InvoiceAddressId = this.Id).Execute(obj => obj.Save());
            if (_deliveryBookings != null)
                _deliveryBookings.Execute(obj => obj.DelivAddId = this.Id).Execute(obj => obj.Save());
            if (_bookings != null)
                _bookings.Execute(obj => obj.BookerAddressId = this.Id).Execute(obj => obj.Save());
            if (_learners != null)
                _learners.Execute(obj => obj.DelegateAddressId = this.Id).Execute(obj => obj.Save());
            if (_accounts != null)
                _accounts.Execute(obj => obj.AddressId = this.Id).Execute(obj => obj.Save());
            if (_accountXrefs != null)
                _accountXrefs.Execute(obj => obj.AddressId = this.Id).Execute(obj => obj.Save());
            if (_payments != null)
                _payments.Execute(obj => obj.AddressId = this.Id).Execute(obj => obj.Save());
            if (_invoices != null)
                _invoices.Execute(obj => obj.AddId = this.Id).Execute(obj => obj.Save());
            if (_merberPeriodInvoice != null)
                _merberPeriodInvoice.Execute(obj => obj.InvAddressId = this.Id).Execute(obj => obj.Save());
            if (_memberLocations != null)
                _memberLocations.Execute(obj => obj.MailAddIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        System.String IAddressModel.MailString
        {
            get { return this.MailString; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_BUILDING" field.
        /// </summary>
        System.String IAddressModel.Building
        {
            get { return this.Building; }
            set { this.Building = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_STREET" field.
        /// </summary>
        System.String IAddressModel.Street
        {
            get { return this.Street; }
            set { this.Street = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_TOWN" field.
        /// </summary>
        System.String IAddressModel.Town
        {
            get { return this.Town; }
            set { this.Town = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_AREA" field.
        /// </summary>
        System.String IAddressModel.Area
        {
            get { return this.Area; }
            set { this.Area = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_COUNTY" field.
        /// </summary>
        System.String IAddressModel.County
        {
            get { return this.County; }
            set { this.County = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_POSTCODE" field.
        /// </summary>
        System.String IAddressModel.Postcode
        {
            get { return this.Postcode; }
            set { this.Postcode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_COUNTRY" field.
        /// </summary>
        System.String IAddressModel.Country
        {
            get { return this.Country; }
            set { this.Country = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_PHONE" field.
        /// </summary>
        System.String IAddressModel.Phone
        {
            get { return this.Phone; }
            set { this.Phone = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_FAX" field.
        /// </summary>
        System.String IAddressModel.Fax
        {
            get { return this.Fax; }
            set { this.Fax = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_EMAIL" field.
        /// </summary>
        System.String IAddressModel.Email
        {
            get { return this.Email; }
            set { this.Email = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_LAT" field.
        /// </summary>
        System.Nullable<System.Decimal> IAddressModel.Lat
        {
            get { return this.Lat; }
            set { this.Lat = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_LONG" field.
        /// </summary>
        System.Nullable<System.Decimal> IAddressModel.Long
        {
            get { return this.Long; }
            set { this.Long = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_GRID_EAST" field.
        /// </summary>
        System.String IAddressModel.GridEast
        {
            get { return this.GridEast; }
            set { this.GridEast = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_GRID_NORTH" field.
        /// </summary>
        System.String IAddressModel.GridNorth
        {
            get { return this.GridNorth; }
            set { this.GridNorth = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_MAILSORT_CODE" field.
        /// </summary>
        System.String IAddressModel.MailsortCode
        {
            get { return this.MailsortCode; }
            set { this.MailsortCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:RoleModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IRoleModel> IAddressModel.Roles
        {
            get { return this.Roles; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OrganisationAddressModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IOrganisationAddressModel> IAddressModel.OrganisationAddresses
        {
            get { return this.OrganisationAddresses; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LocationModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ILocationModel> IAddressModel.Locations
        {
            get { return this.Locations; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> IAddressModel.Events
        {
            get { return this.Events; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> IAddressModel.InvoiceBookings
        {
            get { return this.InvoiceBookings; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> IAddressModel.DeliveryBookings
        {
            get { return this.DeliveryBookings; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> IAddressModel.Bookings
        {
            get { return this.Bookings; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LearnerModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ILearnerModel> IAddressModel.Learners
        {
            get { return this.Learners; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IAccountModel> IAddressModel.Accounts
        {
            get { return this.Accounts; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountXrefModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IAccountXrefModel> IAddressModel.AccountXrefs
        {
            get { return this.AccountXrefs; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPaymentModel> IAddressModel.Payments
        {
            get { return this.Payments; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceModel> IAddressModel.Invoices
        {
            get { return this.Invoices; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberPeriodModel> IAddressModel.MerberPeriodInvoice
        {
            get { return this.MerberPeriodInvoice; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberLocationModel> IAddressModel.MemberLocations
        {
            get { return this.MemberLocations; }
        }

        #endregion
    }
}
