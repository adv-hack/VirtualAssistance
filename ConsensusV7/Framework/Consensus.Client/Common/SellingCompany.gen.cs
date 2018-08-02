using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Contact;
using Consensus.Document;
using Consensus.Finance;
using Consensus.Learning;
using Consensus.Marketing;
using Consensus.Membership;
using Consensus.Other;
using Consensus.Portal;
using Consensus.Sales;
using Consensus.Security;

namespace Consensus.Common
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SellingCompany : Proxy<ISellingCompanyModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Roles" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Role, Consensus.Contact.IRoleModel> _roles;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Organisations" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Organisation, Consensus.Contact.IOrganisationModel> _organisations;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Locations" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Location, Consensus.Contact.ILocationModel> _locations;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="TrainersSellingCompany" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Trainer, Consensus.Contact.ITrainerModel> _trainersSellingCompany;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Products" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel> _products;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Events" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel> _events;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Bookings" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel> _bookings;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Elements" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Element, Consensus.Learning.IElementModel> _elements;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Opportunities" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Sales.Opportunity, Consensus.Sales.IOpportunityModel> _opportunities;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PackSellingCompany" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.Pack, Consensus.Document.IPackModel> _packSellingCompany;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="LetterTemplates" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.LetterTemplate, Consensus.Document.ILetterTemplateModel> _letterTemplates;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="iCalMessages" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.ICalMessage, Consensus.Document.IICalMessageModel> _iCalMessages;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SmsMessages" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.SmsMessage, Consensus.Document.ISmsMessageModel> _smsMessages;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Accounts" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Account, Consensus.Finance.IAccountModel> _accounts;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Payments" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Payment, Consensus.Finance.IPaymentModel> _payments;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Invoices" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Invoice, Consensus.Finance.IInvoiceModel> _invoices;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="InvoiceLines" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.InvoiceLine, Consensus.Finance.IInvoiceLineModel> _invoiceLines;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="CostSelcoId" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.CostCode, Consensus.Finance.ICostCodeModel> _costSelcoId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Currencys" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Currency, Consensus.Finance.ICurrencyModel> _currencys;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="GiftaidclaimsSellingCompany" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Giftaidclaim, Consensus.Finance.IGiftaidclaimModel> _giftaidclaimsSellingCompany;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SysConfigSellingCompany" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Common.SysConfig, Consensus.Common.ISysConfigModel> _sysConfigSellingCompany;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Activities" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.Activity, Consensus.Activities.IActivityModel> _activities;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="HelpDeskSellingCompany" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.Helpdesk, Consensus.Activities.IHelpdeskModel> _helpDeskSellingCompany;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="UserAccounts" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Security.UserAccount, Consensus.Security.IUserAccountModel> _userAccounts;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MemberPeriods" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.MemberPeriod, Consensus.Membership.IMemberPeriodModel> _memberPeriods;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="CampaignSellingCompany" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.Campaign, Consensus.Marketing.ICampaignModel> _campaignSellingCompany;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Batches" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Other.Batch, Consensus.Other.IBatchModel> _batches;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PortalUsers" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Portal.PortalUser, Consensus.Portal.IPortalUserModel> _portalUsers;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "SP_SELL_COMP_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:RoleModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
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
        ///     Gets the collection of <see cref="!:OrganisationModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        public Collection<Consensus.Contact.Organisation> Organisations
        {
            get
            {
                if (_organisations == null)
                    _organisations = new ProxyCollection<Consensus.Contact.Organisation, Consensus.Contact.IOrganisationModel>(this.Model.Organisations, model => new Consensus.Contact.Organisation(model));
                return _organisations;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LocationModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
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
        ///     Gets the collection of <see cref="!:TrainerModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Contact.Trainer> TrainersSellingCompany
        {
            get
            {
                if (_trainersSellingCompany == null)
                    _trainersSellingCompany = new ProxyCollection<Consensus.Contact.Trainer, Consensus.Contact.ITrainerModel>(this.Model.TrainersSellingCompany, model => new Consensus.Contact.Trainer(model));
                return _trainersSellingCompany;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Product> Products
        {
            get
            {
                if (_products == null)
                    _products = new ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel>(this.Model.Products, model => new Consensus.Learning.Product(model));
                return _products;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
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
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
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
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Element> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new ProxyCollection<Consensus.Learning.Element, Consensus.Learning.IElementModel>(this.Model.Elements, model => new Consensus.Learning.Element(model));
                return _elements;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        public Collection<Consensus.Sales.Opportunity> Opportunities
        {
            get
            {
                if (_opportunities == null)
                    _opportunities = new ProxyCollection<Consensus.Sales.Opportunity, Consensus.Sales.IOpportunityModel>(this.Model.Opportunities, model => new Consensus.Sales.Opportunity(model));
                return _opportunities;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        public Collection<Consensus.Document.Pack> PackSellingCompany
        {
            get
            {
                if (_packSellingCompany == null)
                    _packSellingCompany = new ProxyCollection<Consensus.Document.Pack, Consensus.Document.IPackModel>(this.Model.PackSellingCompany, model => new Consensus.Document.Pack(model));
                return _packSellingCompany;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LetterTemplateModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
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
        ///     Gets the collection of <see cref="!:ICalMessageModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        public Collection<Consensus.Document.ICalMessage> iCalMessages
        {
            get
            {
                if (_iCalMessages == null)
                    _iCalMessages = new ProxyCollection<Consensus.Document.ICalMessage, Consensus.Document.IICalMessageModel>(this.Model.iCalMessages, model => new Consensus.Document.ICalMessage(model));
                return _iCalMessages;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SmsMessageModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        public Collection<Consensus.Document.SmsMessage> SmsMessages
        {
            get
            {
                if (_smsMessages == null)
                    _smsMessages = new ProxyCollection<Consensus.Document.SmsMessage, Consensus.Document.ISmsMessageModel>(this.Model.SmsMessages, model => new Consensus.Document.SmsMessage(model));
                return _smsMessages;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
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
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
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
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
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
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        public Collection<Consensus.Finance.InvoiceLine> InvoiceLines
        {
            get
            {
                if (_invoiceLines == null)
                    _invoiceLines = new ProxyCollection<Consensus.Finance.InvoiceLine, Consensus.Finance.IInvoiceLineModel>(this.Model.InvoiceLines, model => new Consensus.Finance.InvoiceLine(model));
                return _invoiceLines;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CostCodeModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        public Collection<Consensus.Finance.CostCode> CostSelcoId
        {
            get
            {
                if (_costSelcoId == null)
                    _costSelcoId = new ProxyCollection<Consensus.Finance.CostCode, Consensus.Finance.ICostCodeModel>(this.Model.CostSelcoId, model => new Consensus.Finance.CostCode(model));
                return _costSelcoId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CurrencyModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        public Collection<Consensus.Finance.Currency> Currencys
        {
            get
            {
                if (_currencys == null)
                    _currencys = new ProxyCollection<Consensus.Finance.Currency, Consensus.Finance.ICurrencyModel>(this.Model.Currencys, model => new Consensus.Finance.Currency(model));
                return _currencys;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:GiftaidclaimModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        public Collection<Consensus.Finance.Giftaidclaim> GiftaidclaimsSellingCompany
        {
            get
            {
                if (_giftaidclaimsSellingCompany == null)
                    _giftaidclaimsSellingCompany = new ProxyCollection<Consensus.Finance.Giftaidclaim, Consensus.Finance.IGiftaidclaimModel>(this.Model.GiftaidclaimsSellingCompany, model => new Consensus.Finance.Giftaidclaim(model));
                return _giftaidclaimsSellingCompany;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SysConfigModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        public Collection<Consensus.Common.SysConfig> SysConfigSellingCompany
        {
            get
            {
                if (_sysConfigSellingCompany == null)
                    _sysConfigSellingCompany = new ProxyCollection<Consensus.Common.SysConfig, Consensus.Common.ISysConfigModel>(this.Model.SysConfigSellingCompany, model => new Consensus.Common.SysConfig(model));
                return _sysConfigSellingCompany;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        public Collection<Consensus.Activities.Activity> Activities
        {
            get
            {
                if (_activities == null)
                    _activities = new ProxyCollection<Consensus.Activities.Activity, Consensus.Activities.IActivityModel>(this.Model.Activities, model => new Consensus.Activities.Activity(model));
                return _activities;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        public Collection<Consensus.Activities.Helpdesk> HelpDeskSellingCompany
        {
            get
            {
                if (_helpDeskSellingCompany == null)
                    _helpDeskSellingCompany = new ProxyCollection<Consensus.Activities.Helpdesk, Consensus.Activities.IHelpdeskModel>(this.Model.HelpDeskSellingCompany, model => new Consensus.Activities.Helpdesk(model));
                return _helpDeskSellingCompany;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserAccountModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        public Collection<Consensus.Security.UserAccount> UserAccounts
        {
            get
            {
                if (_userAccounts == null)
                    _userAccounts = new ProxyCollection<Consensus.Security.UserAccount, Consensus.Security.IUserAccountModel>(this.Model.UserAccounts, model => new Consensus.Security.UserAccount(model));
                return _userAccounts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        public Collection<Consensus.Membership.MemberPeriod> MemberPeriods
        {
            get
            {
                if (_memberPeriods == null)
                    _memberPeriods = new ProxyCollection<Consensus.Membership.MemberPeriod, Consensus.Membership.IMemberPeriodModel>(this.Model.MemberPeriods, model => new Consensus.Membership.MemberPeriod(model));
                return _memberPeriods;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CampaignModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.Campaign> CampaignSellingCompany
        {
            get
            {
                if (_campaignSellingCompany == null)
                    _campaignSellingCompany = new ProxyCollection<Consensus.Marketing.Campaign, Consensus.Marketing.ICampaignModel>(this.Model.CampaignSellingCompany, model => new Consensus.Marketing.Campaign(model));
                return _campaignSellingCompany;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BatchModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        public Collection<Consensus.Other.Batch> Batches
        {
            get
            {
                if (_batches == null)
                    _batches = new ProxyCollection<Consensus.Other.Batch, Consensus.Other.IBatchModel>(this.Model.Batches, model => new Consensus.Other.Batch(model));
                return _batches;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PortalUserModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
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
        internal SellingCompany(ISellingCompanyModel model) : base(model)
        {
        }

        #endregion

        #region methods

        public TValue GetConfiguration<TValue>(System.String name, TValue defaultValue)
        {
            return this.Model.GetConfiguration<TValue>(name,defaultValue);
        }

        public void SetConfiguration<TValue>(System.String name, Consensus.Common.SellingCompanyConfigTypes type, TValue value)
        {
            this.Model.SetConfiguration<TValue>(name,type,value);
        }

        /// <summary>
        ///     Retrieves the default <see cref="!:SellingCompanyModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The default <see cref="!:SellingCompanyModel" /> instance; or null, if no default instance can be found.
        /// </returns>
        public static Consensus.Common.SellingCompany FetchDefault()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SellingCompany.FetchDefault(site);
        }

        /// <summary>
        ///     Retrieves the default <see cref="!:SellingCompanyModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The default <see cref="!:SellingCompanyModel" /> instance; or null, if no default instance can be found.
        /// </returns>
        public static Consensus.Common.SellingCompany FetchDefault(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.ISellingCompanyModel model = provider.Common.SellingCompany.FetchDefault();
            return model == null ? null : new Consensus.Common.SellingCompany(model);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SellingCompanyModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SellingCompanyModel" /> instance.
        /// </returns>
        public static Consensus.Common.SellingCompany Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SellingCompany.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SellingCompanyModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SellingCompanyModel" /> instance.
        /// </returns>
        public static Consensus.Common.SellingCompany Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.ISellingCompanyModel model = provider.Common.SellingCompany.Create();
            return model == null ? null : new Consensus.Common.SellingCompany(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SellingCompanyModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SellingCompanyModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.SellingCompany> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SellingCompany.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SellingCompanyModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SellingCompanyModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.SellingCompany> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.ISellingCompanyModel> collection = provider.Common.SellingCompany.FetchAll();
            return collection.Select(model => new Consensus.Common.SellingCompany(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SellingCompanyModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SellingCompanyModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SellingCompanyModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.SellingCompany FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SellingCompany.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SellingCompanyModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SellingCompanyModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SellingCompanyModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.SellingCompany FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.ISellingCompanyModel model = provider.Common.SellingCompany.FetchById(id);
            return model == null ? null : new Consensus.Common.SellingCompany(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SellingCompany.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Common.SellingCompany.GetTableName();
        }

        #endregion
    }
}
