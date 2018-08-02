using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Document;
using Consensus.Learning;
using Consensus.Membership;

namespace Consensus.Finance
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class PaymentCard : Proxy<IPaymentCardModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Type" /> member.
        /// </summary>
        private Consensus.Common.Code _type;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Status" /> member.
        /// </summary>
        private Consensus.Common.Code _status;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="MemberPeriod" /> member.
        /// </summary>
        private Consensus.Membership.MemberPeriod _memberPeriod;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Organisation" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _organisation;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Person" /> member.
        /// </summary>
        private Consensus.Contact.Person _person;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Booking" /> member.
        /// </summary>
        private Consensus.Learning.Booking _booking;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Refund" /> member.
        /// </summary>
        private Consensus.Finance.Payment _refund;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Address" /> member.
        /// </summary>
        private Consensus.Contact.Address _address;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Account" /> member.
        /// </summary>
        private Consensus.Finance.Account _account;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="LetterTemplate" /> member.
        /// </summary>
        private Consensus.Document.LetterTemplate _letterTemplate;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="CardholderRole" /> member.
        /// </summary>
        private Consensus.Contact.Role _cardholderRole;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Refunds" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Payment, Consensus.Finance.IPaymentModel> _refunds;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PA_PayId" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.PayAllocation, Consensus.Finance.IPayAllocationModel> _pA_PayId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "PAY_CCARD_TYPE" field.
        /// </summary>
        public System.String CardType
        {
            get { return this.Model.CardType; }
            set { this.Model.CardType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_EXPY_DTE" field.
        /// </summary>
        public System.Nullable<System.DateTime> CardExpiryDate
        {
            get { return this.Model.CardExpiryDate; }
            set { this.Model.CardExpiryDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_ISSUE_NO" field.
        /// </summary>
        public System.String CardIssueNo
        {
            get { return this.Model.CardIssueNo; }
            set { this.Model.CardIssueNo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_VALID_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> CardStartDate
        {
            get { return this.Model.CardStartDate; }
            set { this.Model.CardStartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_CARD_SEC_ID" field.
        /// </summary>
        public System.String CardSecurityNumber
        {
            get { return this.Model.CardSecurityNumber; }
            set { this.Model.CardSecurityNumber = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_GATEWAY_ACC_ID" field.
        /// </summary>
        public System.String GatewayAccount
        {
            get { return this.Model.GatewayAccount; }
            set { this.Model.GatewayAccount = value; }
        }

        /// <summary>
        ///     Sets the invoice ID to specify which invoice this payment needs to be allocated against when saved.
        /// </summary>
        public System.String InvoiceId
        {
            set { this.Model.InvoiceId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_NUMBER" field.
        /// </summary>
        public System.String AccountNo
        {
            get { return this.Model.AccountNo; }
            set { this.Model.AccountNo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_APPVL_REF" field.
        /// </summary>
        public System.String ApprovalReference
        {
            get { return this.Model.ApprovalReference; }
            set { this.Model.ApprovalReference = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_CURR_TYPE" field.
        /// </summary>
        public System.String Currency
        {
            get { return this.Model.Currency; }
            set { this.Model.Currency = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_RECVD" field.
        /// </summary>
        public System.Decimal Amount
        {
            get { return this.Model.Amount; }
            set { this.Model.Amount = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_RECVD_BC" field.
        /// </summary>
        public System.Decimal AmountBC
        {
            get { return this.Model.AmountBC; }
            set { this.Model.AmountBC = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> Date
        {
            get { return this.Model.Date; }
            set { this.Model.Date = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_TYPE" field.
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
        ///     Gets or sets the unique code for the value of the "PAY_TYPE" field.
        /// </summary>
        public System.String TypeCode
        {
            get { return this.Model.TypeCode; }
            set { this.Model.TypeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_CUSTOMER_ACC" field.
        /// </summary>
        public System.String CustomerAcc
        {
            get { return this.Model.CustomerAcc; }
            set { this.Model.CustomerAcc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_UNUSED_VAL" field.
        /// </summary>
        public System.Decimal UnusedVal
        {
            get { return this.Model.UnusedVal; }
            set { this.Model.UnusedVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_GL_CODE" field.
        /// </summary>
        public System.String GeneralLedgerCode
        {
            get { return this.Model.GeneralLedgerCode; }
            set { this.Model.GeneralLedgerCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_HIDDEN" field.
        /// </summary>
        public System.Nullable<System.Byte> Hidden
        {
            get { return this.Model.Hidden; }
            set { this.Model.Hidden = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_CHEQUE_NO" field.
        /// </summary>
        public System.String ChequeNo
        {
            get { return this.Model.ChequeNo; }
            set { this.Model.ChequeNo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_SORT_CODE" field.
        /// </summary>
        public System.String SortCode
        {
            get { return this.Model.SortCode; }
            set { this.Model.SortCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_STATUS" field.
        /// </summary>
        public Consensus.Common.Code Status
        {
            get
            {
                if (_status == null && this.Model.Status != null)
                    _status = new Consensus.Common.Code(this.Model.Status);
                if (_status == null)
                    _status = Consensus.Common.Code.Create();
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_STATUS" field.
        /// </summary>
        public System.String StatusCode
        {
            get { return this.Model.StatusCode; }
            set { this.Model.StatusCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_NOTES" field.
        /// </summary>
        public System.String Notes
        {
            get { return this.Model.Notes; }
            set { this.Model.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_CURR_RATE_BC" field.
        /// </summary>
        public System.Decimal ConversionRate
        {
            get { return this.Model.ConversionRate; }
            set { this.Model.ConversionRate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PAY_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_MEP_ID" field.
        /// </summary>
        public Consensus.Membership.MemberPeriod MemberPeriod
        {
            get
            {
                if (_memberPeriod == null && this.Model.MemberPeriod != null)
                    _memberPeriod = new Consensus.Membership.MemberPeriod(this.Model.MemberPeriod);
                if (_memberPeriod == null)
                    _memberPeriod = Consensus.Membership.MemberPeriod.Create();
                return _memberPeriod;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_MEP_ID" field.
        /// </summary>
        public System.String MemberPeriodId
        {
            get { return this.Model.MemberPeriodId; }
            set { this.Model.MemberPeriodId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_ORG_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PAY_ORG_ID" field.
        /// </summary>
        public System.String OrganisationId
        {
            get { return this.Model.OrganisationId; }
            set { this.Model.OrganisationId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_PN_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PAY_PN_ID" field.
        /// </summary>
        public System.String PersonId
        {
            get { return this.Model.PersonId; }
            set { this.Model.PersonId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_REF" field.
        /// </summary>
        public System.String Reference
        {
            get { return this.Model.Reference; }
            set { this.Model.Reference = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_BOOK_ID" field.
        /// </summary>
        public Consensus.Learning.Booking Booking
        {
            get
            {
                if (_booking == null && this.Model.Booking != null)
                    _booking = new Consensus.Learning.Booking(this.Model.Booking);
                if (_booking == null)
                    _booking = Consensus.Learning.Booking.Create();
                return _booking;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_BOOK_ID" field.
        /// </summary>
        public System.String BookingId
        {
            get { return this.Model.BookingId; }
            set { this.Model.BookingId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_REFUND_PAY_ID" field.
        /// </summary>
        public Consensus.Finance.Payment Refund
        {
            get
            {
                if (_refund == null && this.Model.Refund != null)
                    _refund = new Consensus.Finance.Payment(this.Model.Refund);
                if (_refund == null)
                    _refund = Consensus.Finance.Payment.Create();
                return _refund;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_REFUND_PAY_ID" field.
        /// </summary>
        public System.String RefundId
        {
            get { return this.Model.RefundId; }
            set { this.Model.RefundId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_REFUND_PAY_REF" field.
        /// </summary>
        public System.String RefundPayRef
        {
            get { return this.Model.RefundPayRef; }
            set { this.Model.RefundPayRef = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_TXN_TYPE" field.
        /// </summary>
        public System.Nullable<System.Int32> TxnType
        {
            get { return this.Model.TxnType; }
            set { this.Model.TxnType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_BANKING_REF" field.
        /// </summary>
        public System.String BankingReference
        {
            get { return this.Model.BankingReference; }
            set { this.Model.BankingReference = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_BANK_CHG" field.
        /// </summary>
        public System.Decimal BankCharges
        {
            get { return this.Model.BankCharges; }
            set { this.Model.BankCharges = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_PURPOSE" field.
        /// </summary>
        public System.Nullable<System.Byte> Purpose
        {
            get { return this.Model.Purpose; }
            set { this.Model.Purpose = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_SCHN_ID" field.
        /// </summary>
        public System.String SalesChannel
        {
            get { return this.Model.SalesChannel; }
            set { this.Model.SalesChannel = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_ADD_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PAY_ADD_ID" field.
        /// </summary>
        public System.String AddressId
        {
            get { return this.Model.AddressId; }
            set { this.Model.AddressId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_REVERSE_RES" field.
        /// </summary>
        public System.String ReverseRes
        {
            get { return this.Model.ReverseRes; }
            set { this.Model.ReverseRes = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_ACC_ID" field.
        /// </summary>
        public Consensus.Finance.Account Account
        {
            get
            {
                if (_account == null && this.Model.Account != null)
                    _account = new Consensus.Finance.Account(this.Model.Account);
                if (_account == null)
                    _account = Consensus.Finance.Account.Create();
                return _account;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_ACC_ID" field.
        /// </summary>
        public System.String AccountId
        {
            get { return this.Model.AccountId; }
            set { this.Model.AccountId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_LT_ID" field.
        /// </summary>
        public Consensus.Document.LetterTemplate LetterTemplate
        {
            get
            {
                if (_letterTemplate == null && this.Model.LetterTemplate != null)
                    _letterTemplate = new Consensus.Document.LetterTemplate(this.Model.LetterTemplate);
                if (_letterTemplate == null)
                    _letterTemplate = Consensus.Document.LetterTemplate.Create();
                return _letterTemplate;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_LT_ID" field.
        /// </summary>
        public System.String LetterTemplateId
        {
            get { return this.Model.LetterTemplateId; }
            set { this.Model.LetterTemplateId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_CARDHOLDER_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role CardholderRole
        {
            get
            {
                if (_cardholderRole == null && this.Model.CardholderRole != null)
                    _cardholderRole = new Consensus.Contact.Role(this.Model.CardholderRole);
                if (_cardholderRole == null)
                    _cardholderRole = Consensus.Contact.Role.Create();
                return _cardholderRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_CARDHOLDER_PROLE_ID" field.
        /// </summary>
        public System.String CardholderRoleId
        {
            get { return this.Model.CardholderRoleId; }
            set { this.Model.CardholderRoleId = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:PaymentModel" />.
        /// </summary>
        public Collection<Consensus.Finance.Payment> Refunds
        {
            get
            {
                if (_refunds == null)
                    _refunds = new ProxyCollection<Consensus.Finance.Payment, Consensus.Finance.IPaymentModel>(this.Model.Refunds, model => new Consensus.Finance.Payment(model));
                return _refunds;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PayAllocationModel" /> instances that reference this <see cref="!:PaymentModel" />.
        /// </summary>
        public Collection<Consensus.Finance.PayAllocation> PA_PayId
        {
            get
            {
                if (_pA_PayId == null)
                    _pA_PayId = new ProxyCollection<Consensus.Finance.PayAllocation, Consensus.Finance.IPayAllocationModel>(this.Model.PA_PayId, model => new Consensus.Finance.PayAllocation(model));
                return _pA_PayId;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal PaymentCard(IPaymentCardModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:PaymentCardModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PaymentCardModel" /> instance.
        /// </returns>
        public static Consensus.Finance.PaymentCard Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PaymentCard.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PaymentCardModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PaymentCardModel" /> instance.
        /// </returns>
        public static Consensus.Finance.PaymentCard Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IPaymentCardModel model = provider.Finance.PaymentCard.Create();
            return model == null ? null : new Consensus.Finance.PaymentCard(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PaymentCardModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PaymentCardModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PaymentCard.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PaymentCardModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PaymentCardModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPaymentCardModel> collection = provider.Finance.PaymentCard.FetchAll();
            return collection.Select(model => new Consensus.Finance.PaymentCard(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PaymentCardModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PaymentCardModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.PaymentCard FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PaymentCard.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PaymentCardModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PaymentCardModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.PaymentCard FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IPaymentCardModel model = provider.Finance.PaymentCard.FetchById(id);
            return model == null ? null : new Consensus.Finance.PaymentCard(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PaymentCard.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.PaymentCard.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PaymentCard.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPaymentCardModel> collection = provider.Finance.PaymentCard.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Finance.PaymentCard(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAllByMemberPeriodId(System.String memberPeriodId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PaymentCard.FetchAllByMemberPeriodId(site,memberPeriodId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAllByMemberPeriodId(ConsensusSite site, System.String memberPeriodId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPaymentCardModel> collection = provider.Finance.PaymentCard.FetchAllByMemberPeriodId(memberPeriodId);
            return collection.Select(model => new Consensus.Finance.PaymentCard(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAllByOrganisationId(System.String organisationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PaymentCard.FetchAllByOrganisationId(site,organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAllByOrganisationId(ConsensusSite site, System.String organisationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPaymentCardModel> collection = provider.Finance.PaymentCard.FetchAllByOrganisationId(organisationId);
            return collection.Select(model => new Consensus.Finance.PaymentCard(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAllByPersonId(System.String personId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PaymentCard.FetchAllByPersonId(site,personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAllByPersonId(ConsensusSite site, System.String personId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPaymentCardModel> collection = provider.Finance.PaymentCard.FetchAllByPersonId(personId);
            return collection.Select(model => new Consensus.Finance.PaymentCard(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="bookingId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAllByBookingId(System.String bookingId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PaymentCard.FetchAllByBookingId(site,bookingId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="bookingId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAllByBookingId(ConsensusSite site, System.String bookingId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPaymentCardModel> collection = provider.Finance.PaymentCard.FetchAllByBookingId(bookingId);
            return collection.Select(model => new Consensus.Finance.PaymentCard(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="refundId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="refundId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAllByRefundId(System.String refundId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PaymentCard.FetchAllByRefundId(site,refundId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="refundId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="refundId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAllByRefundId(ConsensusSite site, System.String refundId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPaymentCardModel> collection = provider.Finance.PaymentCard.FetchAllByRefundId(refundId);
            return collection.Select(model => new Consensus.Finance.PaymentCard(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAllByAddressId(System.String addressId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PaymentCard.FetchAllByAddressId(site,addressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAllByAddressId(ConsensusSite site, System.String addressId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPaymentCardModel> collection = provider.Finance.PaymentCard.FetchAllByAddressId(addressId);
            return collection.Select(model => new Consensus.Finance.PaymentCard(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAllByAccountId(System.String accountId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PaymentCard.FetchAllByAccountId(site,accountId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAllByAccountId(ConsensusSite site, System.String accountId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPaymentCardModel> collection = provider.Finance.PaymentCard.FetchAllByAccountId(accountId);
            return collection.Select(model => new Consensus.Finance.PaymentCard(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="letterTemplateId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="letterTemplateId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAllByLetterTemplateId(System.String letterTemplateId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PaymentCard.FetchAllByLetterTemplateId(site,letterTemplateId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="letterTemplateId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="letterTemplateId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAllByLetterTemplateId(ConsensusSite site, System.String letterTemplateId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPaymentCardModel> collection = provider.Finance.PaymentCard.FetchAllByLetterTemplateId(letterTemplateId);
            return collection.Select(model => new Consensus.Finance.PaymentCard(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="cardholderRoleId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="cardholderRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAllByCardholderRoleId(System.String cardholderRoleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PaymentCard.FetchAllByCardholderRoleId(site,cardholderRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="cardholderRoleId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="cardholderRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PaymentCard> FetchAllByCardholderRoleId(ConsensusSite site, System.String cardholderRoleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPaymentCardModel> collection = provider.Finance.PaymentCard.FetchAllByCardholderRoleId(cardholderRoleId);
            return collection.Select(model => new Consensus.Finance.PaymentCard(model));
        }

        #endregion
    }
}
