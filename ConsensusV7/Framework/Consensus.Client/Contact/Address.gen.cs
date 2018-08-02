using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Finance;
using Consensus.Learning;
using Consensus.Membership;

namespace Consensus.Contact
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Address : Proxy<IAddressModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Roles" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Role, Consensus.Contact.IRoleModel> _roles;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="OrganisationAddresses" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.OrganisationAddress, Consensus.Contact.IOrganisationAddressModel> _organisationAddresses;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Locations" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Location, Consensus.Contact.ILocationModel> _locations;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Events" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel> _events;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="InvoiceBookings" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel> _invoiceBookings;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="DeliveryBookings" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel> _deliveryBookings;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Bookings" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel> _bookings;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Learners" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Learner, Consensus.Learning.ILearnerModel> _learners;

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
        ///     The client-consumable proxy collection for the <see cref="MerberPeriodInvoice" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.MemberPeriod, Consensus.Membership.IMemberPeriodModel> _merberPeriodInvoice;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MemberLocations" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.MemberLocation, Consensus.Membership.IMemberLocationModel> _memberLocations;

        #endregion

        #region properties

        public System.String MailString
        {
            get { return this.Model.MailString; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_BUILDING" field.
        /// </summary>
        public System.String Building
        {
            get { return this.Model.Building; }
            set { this.Model.Building = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_STREET" field.
        /// </summary>
        public System.String Street
        {
            get { return this.Model.Street; }
            set { this.Model.Street = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_TOWN" field.
        /// </summary>
        public System.String Town
        {
            get { return this.Model.Town; }
            set { this.Model.Town = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_AREA" field.
        /// </summary>
        public System.String Area
        {
            get { return this.Model.Area; }
            set { this.Model.Area = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_COUNTY" field.
        /// </summary>
        public System.String County
        {
            get { return this.Model.County; }
            set { this.Model.County = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_POSTCODE" field.
        /// </summary>
        public System.String Postcode
        {
            get { return this.Model.Postcode; }
            set { this.Model.Postcode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_COUNTRY" field.
        /// </summary>
        public System.String Country
        {
            get { return this.Model.Country; }
            set { this.Model.Country = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_PHONE" field.
        /// </summary>
        public System.String Phone
        {
            get { return this.Model.Phone; }
            set { this.Model.Phone = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_FAX" field.
        /// </summary>
        public System.String Fax
        {
            get { return this.Model.Fax; }
            set { this.Model.Fax = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_EMAIL" field.
        /// </summary>
        public System.String Email
        {
            get { return this.Model.Email; }
            set { this.Model.Email = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_LAT" field.
        /// </summary>
        public System.Nullable<System.Decimal> Lat
        {
            get { return this.Model.Lat; }
            set { this.Model.Lat = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_LONG" field.
        /// </summary>
        public System.Nullable<System.Decimal> Long
        {
            get { return this.Model.Long; }
            set { this.Model.Long = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_GRID_EAST" field.
        /// </summary>
        public System.String GridEast
        {
            get { return this.Model.GridEast; }
            set { this.Model.GridEast = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_GRID_NORTH" field.
        /// </summary>
        public System.String GridNorth
        {
            get { return this.Model.GridNorth; }
            set { this.Model.GridNorth = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ADD_MAILSORT_CODE" field.
        /// </summary>
        public System.String MailsortCode
        {
            get { return this.Model.MailsortCode; }
            set { this.Model.MailsortCode = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:RoleModel" /> instances that reference this <see cref="!:AddressModel" />.
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
        ///     Gets the collection of <see cref="!:OrganisationAddressModel" /> instances that reference this <see cref="!:AddressModel" />.
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
        ///     Gets the collection of <see cref="!:LocationModel" /> instances that reference this <see cref="!:AddressModel" />.
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
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:AddressModel" />.
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
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:AddressModel" />.
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
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Booking> DeliveryBookings
        {
            get
            {
                if (_deliveryBookings == null)
                    _deliveryBookings = new ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel>(this.Model.DeliveryBookings, model => new Consensus.Learning.Booking(model));
                return _deliveryBookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:AddressModel" />.
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
        ///     Gets the collection of <see cref="!:LearnerModel" /> instances that reference this <see cref="!:AddressModel" />.
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
        ///     Gets the collection of <see cref="!:AccountModel" /> instances that reference this <see cref="!:AddressModel" />.
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
        ///     Gets the collection of <see cref="!:AccountXrefModel" /> instances that reference this <see cref="!:AddressModel" />.
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
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:AddressModel" />.
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
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:AddressModel" />.
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
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:AddressModel" />.
        /// </summary>
        public Collection<Consensus.Membership.MemberPeriod> MerberPeriodInvoice
        {
            get
            {
                if (_merberPeriodInvoice == null)
                    _merberPeriodInvoice = new ProxyCollection<Consensus.Membership.MemberPeriod, Consensus.Membership.IMemberPeriodModel>(this.Model.MerberPeriodInvoice, model => new Consensus.Membership.MemberPeriod(model));
                return _merberPeriodInvoice;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:AddressModel" />.
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

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Address(IAddressModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:AddressModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AddressModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Address Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Address.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:AddressModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AddressModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Address Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.IAddressModel model = provider.Contact.Address.Create();
            return model == null ? null : new Consensus.Contact.Address(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AddressModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AddressModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Address> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Address.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AddressModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AddressModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Address> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IAddressModel> collection = provider.Contact.Address.FetchAll();
            return collection.Select(model => new Consensus.Contact.Address(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AddressModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AddressModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AddressModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Address FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Address.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AddressModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AddressModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AddressModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Address FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.IAddressModel model = provider.Contact.Address.FetchById(id);
            return model == null ? null : new Consensus.Contact.Address(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Address.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.Address.GetTableName();
        }

        #endregion
    }
}
