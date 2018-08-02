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
    /// <summary>
    ///     Encapsulates the <see cref="SysParamsRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSellingCompanyModel : LocalModel<SysParamsRecord, String>, ISellingCompanyModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="RoleModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalRoleModel, IRoleModel> _roles;

        /// <summary>
        ///     The collection of <see cref="OrganisationModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalOrganisationModel, IOrganisationModel> _organisations;

        /// <summary>
        ///     The collection of <see cref="LocationModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalLocationModel, ILocationModel> _locations;

        /// <summary>
        ///     The collection of <see cref="TrainerModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalTrainerModel, ITrainerModel> _trainersSellingCompany;

        /// <summary>
        ///     The collection of <see cref="ProductModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalProductModel, IProductModel> _products;

        /// <summary>
        ///     The collection of <see cref="EventModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalEventModel, IEventModel> _events;

        /// <summary>
        ///     The collection of <see cref="BookingModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalBookingModel, IBookingModel> _bookings;

        /// <summary>
        ///     The collection of <see cref="ElementModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalElementModel, IElementModel> _elements;

        /// <summary>
        ///     The collection of <see cref="OpportunityModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalOpportunityModel, IOpportunityModel> _opportunities;

        /// <summary>
        ///     The collection of <see cref="PackModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalPackModel, IPackModel> _packSellingCompany;

        /// <summary>
        ///     The collection of <see cref="LetterTemplateModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalLetterTemplateModel, ILetterTemplateModel> _letterTemplates;

        /// <summary>
        ///     The collection of <see cref="ICalMessageModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalICalMessageModel, IICalMessageModel> _iCalMessages;

        /// <summary>
        ///     The collection of <see cref="SmsMessageModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalSmsMessageModel, ISmsMessageModel> _smsMessages;

        /// <summary>
        ///     The collection of <see cref="AccountModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalAccountModel, IAccountModel> _accounts;

        /// <summary>
        ///     The collection of <see cref="PaymentModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalPaymentModel, IPaymentModel> _payments;

        /// <summary>
        ///     The collection of <see cref="InvoiceModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalInvoiceModel, IInvoiceModel> _invoices;

        /// <summary>
        ///     The collection of <see cref="InvoiceLineModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel> _invoiceLines;

        /// <summary>
        ///     The collection of <see cref="CostCodeModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalCostCodeModel, ICostCodeModel> _costSelcoId;

        /// <summary>
        ///     The collection of <see cref="CurrencyModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalCurrencyModel, ICurrencyModel> _currencys;

        /// <summary>
        ///     The collection of <see cref="GiftaidclaimModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalGiftaidclaimModel, IGiftaidclaimModel> _giftaidclaimsSellingCompany;

        /// <summary>
        ///     The collection of <see cref="SysConfigModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalSysConfigModel, ISysConfigModel> _sysConfigSellingCompany;

        /// <summary>
        ///     The collection of <see cref="ActivityModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalActivityModel, IActivityModel> _activities;

        /// <summary>
        ///     The collection of <see cref="HelpdeskModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalHelpdeskModel, IHelpdeskModel> _helpDeskSellingCompany;

        /// <summary>
        ///     The collection of <see cref="UserAccountModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalUserAccountModel, IUserAccountModel> _userAccounts;

        /// <summary>
        ///     The collection of <see cref="MemberPeriodModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel> _memberPeriods;

        /// <summary>
        ///     The collection of <see cref="CampaignModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalCampaignModel, ICampaignModel> _campaignSellingCompany;

        /// <summary>
        ///     The collection of <see cref="BatchModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalBatchModel, IBatchModel> _batches;

        /// <summary>
        ///     The collection of <see cref="PortalUserModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        private LocalCollection<LocalPortalUserModel, IPortalUserModel> _portalUsers;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SysParamsRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Common.SellingCompany.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<SysParamsRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Common.SellingCompany.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<SysParamsRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Common.SellingCompany.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SP_SELL_COMP_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.SellCompName; }
            set { this.ModifiedData.SellCompName = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="RoleModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalRoleModel, IRoleModel> Roles
        {
            get
            {
                if (_roles == null)
                    _roles = new LocalCollection<LocalRoleModel, IRoleModel>(this.Provider.Contact.Role.FetchAllBySellingCompanyId(this.Id));
                
                return _roles;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="OrganisationModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalOrganisationModel, IOrganisationModel> Organisations
        {
            get
            {
                if (_organisations == null)
                    _organisations = new LocalCollection<LocalOrganisationModel, IOrganisationModel>(this.Provider.Contact.Organisation.FetchAllBySellingCompanyId(this.Id));
                
                return _organisations;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="LocationModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalLocationModel, ILocationModel> Locations
        {
            get
            {
                if (_locations == null)
                    _locations = new LocalCollection<LocalLocationModel, ILocationModel>(this.Provider.Contact.Location.FetchAllBySellingCompanyId(this.Id));
                
                return _locations;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="TrainerModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalTrainerModel, ITrainerModel> TrainersSellingCompany
        {
            get
            {
                if (_trainersSellingCompany == null)
                    _trainersSellingCompany = new LocalCollection<LocalTrainerModel, ITrainerModel>(this.Provider.Contact.Trainer.FetchAllBySellingCompanyId(this.Id));
                
                return _trainersSellingCompany;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalProductModel, IProductModel> Products
        {
            get
            {
                if (_products == null)
                    _products = new LocalCollection<LocalProductModel, IProductModel>(this.Provider.Learning.Product.FetchAllBySellingCompanyId(this.Id));
                
                return _products;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalEventModel, IEventModel> Events
        {
            get
            {
                if (_events == null)
                    _events = new LocalCollection<LocalEventModel, IEventModel>(this.Provider.Learning.Event.FetchAllBySellingCompanyId(this.Id));
                
                return _events;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BookingModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalBookingModel, IBookingModel> Bookings
        {
            get
            {
                if (_bookings == null)
                    _bookings = new LocalCollection<LocalBookingModel, IBookingModel>(this.Provider.Learning.Booking.FetchAllBySellingCompanyId(this.Id));
                
                return _bookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ElementModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalElementModel, IElementModel> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new LocalCollection<LocalElementModel, IElementModel>(this.Provider.Learning.Element.FetchAllBySellingCompanyId(this.Id));
                
                return _elements;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="OpportunityModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalOpportunityModel, IOpportunityModel> Opportunities
        {
            get
            {
                if (_opportunities == null)
                    _opportunities = new LocalCollection<LocalOpportunityModel, IOpportunityModel>(this.Provider.Sales.Opportunity.FetchAllBySellingCompanyId(this.Id));
                
                return _opportunities;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PackModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalPackModel, IPackModel> PackSellingCompany
        {
            get
            {
                if (_packSellingCompany == null)
                    _packSellingCompany = new LocalCollection<LocalPackModel, IPackModel>(this.Provider.Document.Pack.FetchAllByPackSellingCompanyIdId(this.Id));
                
                return _packSellingCompany;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="LetterTemplateModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalLetterTemplateModel, ILetterTemplateModel> LetterTemplates
        {
            get
            {
                if (_letterTemplates == null)
                    _letterTemplates = new LocalCollection<LocalLetterTemplateModel, ILetterTemplateModel>(this.Provider.Document.LetterTemplate.FetchAllBySellingCompanyId(this.Id));
                
                return _letterTemplates;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ICalMessageModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalICalMessageModel, IICalMessageModel> iCalMessages
        {
            get
            {
                if (_iCalMessages == null)
                    _iCalMessages = new LocalCollection<LocalICalMessageModel, IICalMessageModel>(this.Provider.Document.ICalMessage.FetchAllBySellingCompanyId(this.Id));
                
                return _iCalMessages;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SmsMessageModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalSmsMessageModel, ISmsMessageModel> SmsMessages
        {
            get
            {
                if (_smsMessages == null)
                    _smsMessages = new LocalCollection<LocalSmsMessageModel, ISmsMessageModel>(this.Provider.Document.SmsMessage.FetchAllBySellingCompanyId(this.Id));
                
                return _smsMessages;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="AccountModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalAccountModel, IAccountModel> Accounts
        {
            get
            {
                if (_accounts == null)
                    _accounts = new LocalCollection<LocalAccountModel, IAccountModel>(this.Provider.Finance.Account.FetchAllBySellingComanpyId(this.Id));
                
                return _accounts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PaymentModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalPaymentModel, IPaymentModel> Payments
        {
            get
            {
                if (_payments == null)
                    _payments = new LocalCollection<LocalPaymentModel, IPaymentModel>(this.Provider.Finance.Payment.FetchAllBySellingCompanyId(this.Id));
                
                return _payments;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="InvoiceModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalInvoiceModel, IInvoiceModel> Invoices
        {
            get
            {
                if (_invoices == null)
                    _invoices = new LocalCollection<LocalInvoiceModel, IInvoiceModel>(this.Provider.Finance.Invoice.FetchAllBySellingCompanyId(this.Id));
                
                return _invoices;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="InvoiceLineModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel> InvoiceLines
        {
            get
            {
                if (_invoiceLines == null)
                    _invoiceLines = new LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel>(this.Provider.Finance.InvoiceLine.FetchAllBySellingCompanyId(this.Id));
                
                return _invoiceLines;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="CostCodeModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalCostCodeModel, ICostCodeModel> CostSelcoId
        {
            get
            {
                if (_costSelcoId == null)
                    _costSelcoId = new LocalCollection<LocalCostCodeModel, ICostCodeModel>(this.Provider.Finance.CostCode.FetchAllBySelcoSpIdId(this.Id));
                
                return _costSelcoId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="CurrencyModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalCurrencyModel, ICurrencyModel> Currencys
        {
            get
            {
                if (_currencys == null)
                    _currencys = new LocalCollection<LocalCurrencyModel, ICurrencyModel>(this.Provider.Finance.Currency.FetchAllBySellingCompanyId(this.Id));
                
                return _currencys;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="GiftaidclaimModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalGiftaidclaimModel, IGiftaidclaimModel> GiftaidclaimsSellingCompany
        {
            get
            {
                if (_giftaidclaimsSellingCompany == null)
                    _giftaidclaimsSellingCompany = new LocalCollection<LocalGiftaidclaimModel, IGiftaidclaimModel>(this.Provider.Finance.Giftaidclaim.FetchAllBySellingCompanyId(this.Id));
                
                return _giftaidclaimsSellingCompany;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SysConfigModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalSysConfigModel, ISysConfigModel> SysConfigSellingCompany
        {
            get
            {
                if (_sysConfigSellingCompany == null)
                    _sysConfigSellingCompany = new LocalCollection<LocalSysConfigModel, ISysConfigModel>(this.Provider.Common.SysConfig.FetchAllBySellingCompanyId(this.Id));
                
                return _sysConfigSellingCompany;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ActivityModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalActivityModel, IActivityModel> Activities
        {
            get
            {
                if (_activities == null)
                    _activities = new LocalCollection<LocalActivityModel, IActivityModel>(this.Provider.Activities.Activity.FetchAllBySellingCompanyId(this.Id));
                
                return _activities;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="HelpdeskModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalHelpdeskModel, IHelpdeskModel> HelpDeskSellingCompany
        {
            get
            {
                if (_helpDeskSellingCompany == null)
                    _helpDeskSellingCompany = new LocalCollection<LocalHelpdeskModel, IHelpdeskModel>(this.Provider.Activities.Helpdesk.FetchAllBySelcoSpIdId(this.Id));
                
                return _helpDeskSellingCompany;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="UserAccountModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalUserAccountModel, IUserAccountModel> UserAccounts
        {
            get
            {
                if (_userAccounts == null)
                    _userAccounts = new LocalCollection<LocalUserAccountModel, IUserAccountModel>(this.Provider.Security.UserAccount.FetchAllBySellingCompanyId(this.Id));
                
                return _userAccounts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MemberPeriodModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel> MemberPeriods
        {
            get
            {
                if (_memberPeriods == null)
                    _memberPeriods = new LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel>(this.Provider.Membership.MemberPeriod.FetchAllBySellingCompanyId(this.Id));
                
                return _memberPeriods;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="CampaignModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalCampaignModel, ICampaignModel> CampaignSellingCompany
        {
            get
            {
                if (_campaignSellingCompany == null)
                    _campaignSellingCompany = new LocalCollection<LocalCampaignModel, ICampaignModel>(this.Provider.Marketing.Campaign.FetchAllBySellingCompanyId(this.Id));
                
                return _campaignSellingCompany;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BatchModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalBatchModel, IBatchModel> Batches
        {
            get
            {
                if (_batches == null)
                    _batches = new LocalCollection<LocalBatchModel, IBatchModel>(this.Provider.Other.Batch.FetchAllBySellingCompanyId(this.Id));
                
                return _batches;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PortalUserModel" /> instances that reference this <see cref="SellingCompanyModel" />.
        /// </summary>
        public LocalCollection<LocalPortalUserModel, IPortalUserModel> PortalUsers
        {
            get
            {
                if (_portalUsers == null)
                    _portalUsers = new LocalCollection<LocalPortalUserModel, IPortalUserModel>(this.Provider.Portal.PortalUser.FetchAllBySellingCompanyId(this.Id));
                
                return _portalUsers;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalSellingCompanyModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalSellingCompanyModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalSellingCompanyModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalSellingCompanyModel(LocalProvider provider, SysParamsRecord record) : base(provider, record)
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
                _roles.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_organisations != null)
                _organisations.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_locations != null)
                _locations.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_trainersSellingCompany != null)
                _trainersSellingCompany.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_products != null)
                _products.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_events != null)
                _events.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_bookings != null)
                _bookings.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_elements != null)
                _elements.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_opportunities != null)
                _opportunities.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_packSellingCompany != null)
                _packSellingCompany.Execute(obj => obj.PackSellingCompanyIdId = this.Id).Execute(obj => obj.Save());
            if (_letterTemplates != null)
                _letterTemplates.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_iCalMessages != null)
                _iCalMessages.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_smsMessages != null)
                _smsMessages.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_accounts != null)
                _accounts.Execute(obj => obj.SellingComanpyId = this.Id).Execute(obj => obj.Save());
            if (_payments != null)
                _payments.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_invoices != null)
                _invoices.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_invoiceLines != null)
                _invoiceLines.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_costSelcoId != null)
                _costSelcoId.Execute(obj => obj.SelcoSpIdId = this.Id).Execute(obj => obj.Save());
            if (_currencys != null)
                _currencys.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_giftaidclaimsSellingCompany != null)
                _giftaidclaimsSellingCompany.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_sysConfigSellingCompany != null)
                _sysConfigSellingCompany.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_activities != null)
                _activities.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_helpDeskSellingCompany != null)
                _helpDeskSellingCompany.Execute(obj => obj.SelcoSpIdId = this.Id).Execute(obj => obj.Save());
            if (_userAccounts != null)
                _userAccounts.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_memberPeriods != null)
                _memberPeriods.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_campaignSellingCompany != null)
                _campaignSellingCompany.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_batches != null)
                _batches.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
            if (_portalUsers != null)
                _portalUsers.Execute(obj => obj.SellingCompanyId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "SP_SELL_COMP_NAME" field.
        /// </summary>
        System.String ISellingCompanyModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:RoleModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IRoleModel> ISellingCompanyModel.Roles
        {
            get { return this.Roles; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OrganisationModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IOrganisationModel> ISellingCompanyModel.Organisations
        {
            get { return this.Organisations; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LocationModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ILocationModel> ISellingCompanyModel.Locations
        {
            get { return this.Locations; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TrainerModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Contact.ITrainerModel> ISellingCompanyModel.TrainersSellingCompany
        {
            get { return this.TrainersSellingCompany; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> ISellingCompanyModel.Products
        {
            get { return this.Products; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> ISellingCompanyModel.Events
        {
            get { return this.Events; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> ISellingCompanyModel.Bookings
        {
            get { return this.Bookings; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> ISellingCompanyModel.Elements
        {
            get { return this.Elements; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Sales.IOpportunityModel> ISellingCompanyModel.Opportunities
        {
            get { return this.Opportunities; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPackModel> ISellingCompanyModel.PackSellingCompany
        {
            get { return this.PackSellingCompany; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LetterTemplateModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.ILetterTemplateModel> ISellingCompanyModel.LetterTemplates
        {
            get { return this.LetterTemplates; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ICalMessageModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IICalMessageModel> ISellingCompanyModel.iCalMessages
        {
            get { return this.iCalMessages; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SmsMessageModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.ISmsMessageModel> ISellingCompanyModel.SmsMessages
        {
            get { return this.SmsMessages; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IAccountModel> ISellingCompanyModel.Accounts
        {
            get { return this.Accounts; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPaymentModel> ISellingCompanyModel.Payments
        {
            get { return this.Payments; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceModel> ISellingCompanyModel.Invoices
        {
            get { return this.Invoices; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceLineModel> ISellingCompanyModel.InvoiceLines
        {
            get { return this.InvoiceLines; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CostCodeModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.ICostCodeModel> ISellingCompanyModel.CostSelcoId
        {
            get { return this.CostSelcoId; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CurrencyModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.ICurrencyModel> ISellingCompanyModel.Currencys
        {
            get { return this.Currencys; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:GiftaidclaimModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IGiftaidclaimModel> ISellingCompanyModel.GiftaidclaimsSellingCompany
        {
            get { return this.GiftaidclaimsSellingCompany; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SysConfigModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Common.ISysConfigModel> ISellingCompanyModel.SysConfigSellingCompany
        {
            get { return this.SysConfigSellingCompany; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IActivityModel> ISellingCompanyModel.Activities
        {
            get { return this.Activities; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IHelpdeskModel> ISellingCompanyModel.HelpDeskSellingCompany
        {
            get { return this.HelpDeskSellingCompany; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserAccountModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.IUserAccountModel> ISellingCompanyModel.UserAccounts
        {
            get { return this.UserAccounts; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberPeriodModel> ISellingCompanyModel.MemberPeriods
        {
            get { return this.MemberPeriods; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CampaignModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ICampaignModel> ISellingCompanyModel.CampaignSellingCompany
        {
            get { return this.CampaignSellingCompany; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BatchModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Other.IBatchModel> ISellingCompanyModel.Batches
        {
            get { return this.Batches; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PortalUserModel" /> instances that reference this <see cref="!:SellingCompanyModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Portal.IPortalUserModel> ISellingCompanyModel.PortalUsers
        {
            get { return this.PortalUsers; }
        }

        TValue ISellingCompanyModel.GetConfiguration<TValue>(System.String name, TValue defaultValue)
        {
            return this.GetConfiguration<TValue>(name, defaultValue);
        }

        void ISellingCompanyModel.SetConfiguration<TValue>(System.String name, Consensus.Common.SellingCompanyConfigTypes type, TValue value)
        {
            this.SetConfiguration<TValue>(name, type, value);
        }

        #endregion
    }
}
