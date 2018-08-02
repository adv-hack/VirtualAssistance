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
    /// <summary>
    ///     Encapsulates the <see cref="PaymentRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPaymentModel : LocalModel<PaymentRecord, String>, IPaymentModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PAY_TYPE" field.
        /// </summary>
        private LocalCodeModel _type;

        /// <summary>
        ///     The value of the "PAY_STATUS" field.
        /// </summary>
        private LocalCodeModel _status;

        /// <summary>
        ///     The value of the "PAY_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     The value of the "PAY_MEP_ID" field.
        /// </summary>
        private LocalMemberPeriodModel _memberPeriod;

        /// <summary>
        ///     The value of the "PAY_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _organisation;

        /// <summary>
        ///     The value of the "PAY_PN_ID" field.
        /// </summary>
        private LocalPersonModel _person;

        /// <summary>
        ///     The value of the "PAY_BOOK_ID" field.
        /// </summary>
        private LocalBookingModel _booking;

        /// <summary>
        ///     The value of the "PAY_REFUND_PAY_ID" field.
        /// </summary>
        private LocalPaymentModel _refund;

        /// <summary>
        ///     The value of the "PAY_ADD_ID" field.
        /// </summary>
        private LocalAddressModel _address;

        /// <summary>
        ///     The value of the "PAY_ACC_ID" field.
        /// </summary>
        private LocalAccountModel _account;

        /// <summary>
        ///     The value of the "PAY_LT_ID" field.
        /// </summary>
        private LocalLetterTemplateModel _letterTemplate;

        /// <summary>
        ///     The value of the "PAY_CARDHOLDER_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _cardholderRole;

        /// <summary>
        ///     The collection of <see cref="PaymentModel" /> instances that reference this <see cref="PaymentModel" />.
        /// </summary>
        private LocalCollection<LocalPaymentModel, IPaymentModel> _refunds;

        /// <summary>
        ///     The collection of <see cref="PayAllocationModel" /> instances that reference this <see cref="PaymentModel" />.
        /// </summary>
        private LocalCollection<LocalPayAllocationModel, IPayAllocationModel> _pA_PayId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PaymentRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Finance.Payment.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PaymentRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Finance.Payment.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<PaymentRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Finance.Payment.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_NUMBER" field.
        /// </summary>
        public String AccountNo
        {
            get { return this.ModifiedData.Number; }
            set { this.ModifiedData.Number = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_APPVL_REF" field.
        /// </summary>
        public String ApprovalReference
        {
            get { return this.ModifiedData.AppvlRef; }
            set { this.ModifiedData.AppvlRef = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_CURR_TYPE" field.
        /// </summary>
        public String Currency
        {
            get { return this.ModifiedData.CurrType; }
            set { this.ModifiedData.CurrType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_RECVD" field.
        /// </summary>
        public Decimal Amount
        {
            get { return this.ModifiedData.Recvd; }
            set { this.ModifiedData.Recvd = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_RECVD_BC" field.
        /// </summary>
        public Decimal AmountBC
        {
            get { return this.ModifiedData.RecvdBc; }
            set { this.ModifiedData.RecvdBc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_DATE" field.
        /// </summary>
        public DateTime? Date
        {
            get { return this.ModifiedData.Date; }
            set { this.ModifiedData.Date = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_TYPE" field.
        /// </summary>
        public LocalCodeModel Type
        {
            get
            {
                if (_type == null && !String.IsNullOrEmpty(this.TypeCode))
                    _type = this.Provider.Common.Code.FetchByTypeAndCode("PYPAY", this.TypeCode);
                if (_type == null)
                    _type = this.Provider.Common.Code.Create("PYPAY");
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_TYPE" field.
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
        ///     Gets or sets the value of the "PAY_CUSTOMER_ACC" field.
        /// </summary>
        public String CustomerAcc
        {
            get { return this.ModifiedData.CustomerAcc; }
            set { this.ModifiedData.CustomerAcc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_UNUSED_VAL" field.
        /// </summary>
        public Decimal UnusedVal
        {
            get { return this.ModifiedData.UnusedVal; }
            set { this.ModifiedData.UnusedVal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_GL_CODE" field.
        /// </summary>
        public String GeneralLedgerCode
        {
            get { return this.ModifiedData.GlCode; }
            set { this.ModifiedData.GlCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_HIDDEN" field.
        /// </summary>
        public Byte? Hidden
        {
            get { return this.ModifiedData.Hidden; }
            set { this.ModifiedData.Hidden = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_CHEQUE_NO" field.
        /// </summary>
        public String ChequeNo
        {
            get { return this.ModifiedData.ChequeNo; }
            set { this.ModifiedData.ChequeNo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_SORT_CODE" field.
        /// </summary>
        public String SortCode
        {
            get { return this.ModifiedData.SortCode; }
            set { this.ModifiedData.SortCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_STATUS" field.
        /// </summary>
        public LocalCodeModel Status
        {
            get
            {
                if (_status == null && !String.IsNullOrEmpty(this.StatusCode))
                    _status = this.Provider.Common.Code.FetchByTypeAndCode("PAYST", this.StatusCode);
                if (_status == null)
                    _status = this.Provider.Common.Code.Create("PAYST");
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_STATUS" field.
        /// </summary>
        public String StatusCode
        {
            get { return this.ModifiedData.Status; }
            set
            {
                if (this.ModifiedData.Status != value)
                     _status = null;
                this.ModifiedData.Status = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return this.ModifiedData.Notes; }
            set { this.ModifiedData.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_CURR_RATE_BC" field.
        /// </summary>
        public Decimal ConversionRate
        {
            get { return this.ModifiedData.CurrRateBc; }
            set { this.ModifiedData.CurrRateBc = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_SELCO_SP_ID" field.
        /// </summary>
        public LocalSellingCompanyModel SellingCompany
        {
            get
            {
                if (_sellingCompany == null && this.SellingCompanyId != null)
                    _sellingCompany = this.Provider.Common.SellingCompany.FetchById(this.SellingCompanyId);
                if (_sellingCompany == null)
                    _sellingCompany = this.Provider.Common.SellingCompany.Create();
                
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_SELCO_SP_ID" field.
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
        ///     Gets the The value of the "PAY_MEP_ID" field.
        /// </summary>
        public LocalMemberPeriodModel MemberPeriod
        {
            get
            {
                if (_memberPeriod == null && this.MemberPeriodId != null)
                    _memberPeriod = this.Provider.Membership.MemberPeriod.FetchById(this.MemberPeriodId);
                if (_memberPeriod == null)
                    _memberPeriod = this.Provider.Membership.MemberPeriod.Create();
                
                return _memberPeriod;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_MEP_ID" field.
        /// </summary>
        public String MemberPeriodId
        {
            get { return this.ModifiedData.MepId; }
            set
            {
                if (this.ModifiedData.MepId != value)
                     _memberPeriod = null;
                this.ModifiedData.MepId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_ORG_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PAY_ORG_ID" field.
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
        ///     Gets the The value of the "PAY_PN_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PAY_PN_ID" field.
        /// </summary>
        public String PersonId
        {
            get { return this.ModifiedData.PnId; }
            set
            {
                if (this.ModifiedData.PnId != value)
                     _person = null;
                this.ModifiedData.PnId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_REF" field.
        /// </summary>
        public String Reference
        {
            get { return this.ModifiedData.Ref; }
            set { this.ModifiedData.Ref = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_BOOK_ID" field.
        /// </summary>
        public LocalBookingModel Booking
        {
            get
            {
                if (_booking == null && this.BookingId != null)
                    _booking = this.Provider.Learning.Booking.FetchById(this.BookingId);
                if (_booking == null)
                    _booking = this.Provider.Learning.Booking.Create();
                
                return _booking;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_BOOK_ID" field.
        /// </summary>
        public String BookingId
        {
            get { return this.ModifiedData.BookId; }
            set
            {
                if (this.ModifiedData.BookId != value)
                     _booking = null;
                this.ModifiedData.BookId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_REFUND_PAY_ID" field.
        /// </summary>
        public LocalPaymentModel Refund
        {
            get
            {
                if (_refund == null && this.RefundId != null)
                    _refund = this.Provider.Finance.Payment.FetchById(this.RefundId);
                if (_refund == null)
                    _refund = this.Provider.Finance.Payment.Create();
                
                return _refund;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_REFUND_PAY_ID" field.
        /// </summary>
        public String RefundId
        {
            get { return this.ModifiedData.RefundPayId; }
            set
            {
                if (this.ModifiedData.RefundPayId != value)
                     _refund = null;
                this.ModifiedData.RefundPayId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_REFUND_PAY_REF" field.
        /// </summary>
        public String RefundPayRef
        {
            get { return this.ModifiedData.RefundPayRef; }
            set { this.ModifiedData.RefundPayRef = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_TXN_TYPE" field.
        /// </summary>
        public Int32? TxnType
        {
            get { return this.ModifiedData.TxnType; }
            set { this.ModifiedData.TxnType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_BANKING_REF" field.
        /// </summary>
        public String BankingReference
        {
            get { return this.ModifiedData.BankingRef; }
            set { this.ModifiedData.BankingRef = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_BANK_CHG" field.
        /// </summary>
        public Decimal BankCharges
        {
            get { return this.ModifiedData.BankChg; }
            set { this.ModifiedData.BankChg = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_PURPOSE" field.
        /// </summary>
        public Byte? Purpose
        {
            get { return this.ModifiedData.Purpose; }
            set { this.ModifiedData.Purpose = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_SCHN_ID" field.
        /// </summary>
        public String SalesChannel
        {
            get { return this.ModifiedData.SchnId; }
            set { this.ModifiedData.SchnId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_ADD_ID" field.
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
        ///     Gets or sets the unique code for the value of the "PAY_ADD_ID" field.
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
        ///     Gets or sets the value of the "PAY_REVERSE_RES" field.
        /// </summary>
        public String ReverseRes
        {
            get { return this.ModifiedData.ReverseRes; }
            set { this.ModifiedData.ReverseRes = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_ACC_ID" field.
        /// </summary>
        public LocalAccountModel Account
        {
            get
            {
                if (_account == null && this.AccountId != null)
                    _account = this.Provider.Finance.Account.FetchById(this.AccountId);
                if (_account == null)
                    _account = this.Provider.Finance.Account.Create();
                
                return _account;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_ACC_ID" field.
        /// </summary>
        public String AccountId
        {
            get { return this.ModifiedData.AccId; }
            set
            {
                if (this.ModifiedData.AccId != value)
                     _account = null;
                this.ModifiedData.AccId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_LT_ID" field.
        /// </summary>
        public LocalLetterTemplateModel LetterTemplate
        {
            get
            {
                if (_letterTemplate == null && this.LetterTemplateId != null)
                    _letterTemplate = this.Provider.Document.LetterTemplate.FetchById(this.LetterTemplateId);
                if (_letterTemplate == null)
                    _letterTemplate = this.Provider.Document.LetterTemplate.Create();
                
                return _letterTemplate;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_LT_ID" field.
        /// </summary>
        public String LetterTemplateId
        {
            get { return this.ModifiedData.LtId; }
            set
            {
                if (this.ModifiedData.LtId != value)
                     _letterTemplate = null;
                this.ModifiedData.LtId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_CARDHOLDER_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel CardholderRole
        {
            get
            {
                if (_cardholderRole == null && this.CardholderRoleId != null)
                    _cardholderRole = this.Provider.Contact.Role.FetchById(this.CardholderRoleId);
                if (_cardholderRole == null)
                    _cardholderRole = this.Provider.Contact.Role.Create();
                
                return _cardholderRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_CARDHOLDER_PROLE_ID" field.
        /// </summary>
        public String CardholderRoleId
        {
            get { return this.ModifiedData.CardholderProleId; }
            set
            {
                if (this.ModifiedData.CardholderProleId != value)
                     _cardholderRole = null;
                this.ModifiedData.CardholderProleId = value;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PaymentModel" /> instances that reference this <see cref="PaymentModel" />.
        /// </summary>
        public LocalCollection<LocalPaymentModel, IPaymentModel> Refunds
        {
            get
            {
                if (_refunds == null)
                    _refunds = new LocalCollection<LocalPaymentModel, IPaymentModel>(this.Provider.Finance.Payment.FetchAllByRefundId(this.Id));
                
                return _refunds;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PayAllocationModel" /> instances that reference this <see cref="PaymentModel" />.
        /// </summary>
        public LocalCollection<LocalPayAllocationModel, IPayAllocationModel> PA_PayId
        {
            get
            {
                if (_pA_PayId == null)
                    _pA_PayId = new LocalCollection<LocalPayAllocationModel, IPayAllocationModel>(this.Provider.Finance.PayAllocation.FetchAllByPayIdId(this.Id));
                
                return _pA_PayId;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalPaymentModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalPaymentModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalPaymentModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalPaymentModel(LocalProvider provider, PaymentRecord record) : base(provider, record)
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
            if (_status != null)
            {
                _status.Save();
                this.ModifiedData.Status = _status.Value1;
            }
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.SelcoSpId = _sellingCompany.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _sellingCompany.Id;
            }
            if (_memberPeriod != null)
            {
                _memberPeriod.Save();
                this.ModifiedData.MepId = _memberPeriod.Id == null && this.ModifiedData.MepId != null ? "" : _memberPeriod.Id;
            }
            if (_organisation != null)
            {
                _organisation.Save();
                this.ModifiedData.OrgId = _organisation.Id == null && this.ModifiedData.OrgId != null ? "" : _organisation.Id;
            }
            if (_person != null)
            {
                _person.Save();
                this.ModifiedData.PnId = _person.Id == null && this.ModifiedData.PnId != null ? "" : _person.Id;
            }
            if (_booking != null)
            {
                _booking.Save();
                this.ModifiedData.BookId = _booking.Id == null && this.ModifiedData.BookId != null ? "" : _booking.Id;
            }
            if (_refund != null)
            {
                _refund.Save();
                this.ModifiedData.RefundPayId = _refund.Id == null && this.ModifiedData.RefundPayId != null ? "" : _refund.Id;
            }
            if (_address != null)
            {
                _address.Save();
                this.ModifiedData.AddId = _address.Id == null && this.ModifiedData.AddId != null ? "" : _address.Id;
            }
            if (_account != null)
            {
                _account.Save();
                this.ModifiedData.AccId = _account.Id == null && this.ModifiedData.AccId != null ? "" : _account.Id;
            }
            if (_letterTemplate != null)
            {
                _letterTemplate.Save();
                this.ModifiedData.LtId = _letterTemplate.Id == null && this.ModifiedData.LtId != null ? "" : _letterTemplate.Id;
            }
            if (_cardholderRole != null)
            {
                _cardholderRole.Save();
                this.ModifiedData.CardholderProleId = _cardholderRole.Id == null && this.ModifiedData.CardholderProleId != null ? "" : _cardholderRole.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_refunds != null)
                _refunds.Execute(obj => obj.RefundId = this.Id).Execute(obj => obj.Save());
            if (_pA_PayId != null)
                _pA_PayId.Execute(obj => obj.PayIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Sets the invoice ID to specify which invoice this payment needs to be allocated against when saved.
        /// </summary>
        System.String IPaymentModel.InvoiceId
        {
            set { this.InvoiceId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_NAME" field.
        /// </summary>
        System.String IPaymentModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_NUMBER" field.
        /// </summary>
        System.String IPaymentModel.AccountNo
        {
            get { return this.AccountNo; }
            set { this.AccountNo = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_APPVL_REF" field.
        /// </summary>
        System.String IPaymentModel.ApprovalReference
        {
            get { return this.ApprovalReference; }
            set { this.ApprovalReference = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_CURR_TYPE" field.
        /// </summary>
        System.String IPaymentModel.Currency
        {
            get { return this.Currency; }
            set { this.Currency = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_RECVD" field.
        /// </summary>
        System.Decimal IPaymentModel.Amount
        {
            get { return this.Amount; }
            set { this.Amount = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_RECVD_BC" field.
        /// </summary>
        System.Decimal IPaymentModel.AmountBC
        {
            get { return this.AmountBC; }
            set { this.AmountBC = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IPaymentModel.Date
        {
            get { return this.Date; }
            set { this.Date = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel IPaymentModel.Type
        {
            get { return this.Type; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_TYPE" field.
        /// </summary>
        System.String IPaymentModel.TypeCode
        {
            get { return this.TypeCode; }
            set { this.TypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_CUSTOMER_ACC" field.
        /// </summary>
        System.String IPaymentModel.CustomerAcc
        {
            get { return this.CustomerAcc; }
            set { this.CustomerAcc = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_UNUSED_VAL" field.
        /// </summary>
        System.Decimal IPaymentModel.UnusedVal
        {
            get { return this.UnusedVal; }
            set { this.UnusedVal = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_GL_CODE" field.
        /// </summary>
        System.String IPaymentModel.GeneralLedgerCode
        {
            get { return this.GeneralLedgerCode; }
            set { this.GeneralLedgerCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_HIDDEN" field.
        /// </summary>
        System.Nullable<System.Byte> IPaymentModel.Hidden
        {
            get { return this.Hidden; }
            set { this.Hidden = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_CHEQUE_NO" field.
        /// </summary>
        System.String IPaymentModel.ChequeNo
        {
            get { return this.ChequeNo; }
            set { this.ChequeNo = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_SORT_CODE" field.
        /// </summary>
        System.String IPaymentModel.SortCode
        {
            get { return this.SortCode; }
            set { this.SortCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel IPaymentModel.Status
        {
            get { return this.Status; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_STATUS" field.
        /// </summary>
        System.String IPaymentModel.StatusCode
        {
            get { return this.StatusCode; }
            set { this.StatusCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_NOTES" field.
        /// </summary>
        System.String IPaymentModel.Notes
        {
            get { return this.Notes; }
            set { this.Notes = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_CURR_RATE_BC" field.
        /// </summary>
        System.Decimal IPaymentModel.ConversionRate
        {
            get { return this.ConversionRate; }
            set { this.ConversionRate = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel IPaymentModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_SELCO_SP_ID" field.
        /// </summary>
        System.String IPaymentModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_MEP_ID" field.
        /// </summary>
        Consensus.Membership.IMemberPeriodModel IPaymentModel.MemberPeriod
        {
            get { return this.MemberPeriod; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_MEP_ID" field.
        /// </summary>
        System.String IPaymentModel.MemberPeriodId
        {
            get { return this.MemberPeriodId; }
            set { this.MemberPeriodId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IPaymentModel.Organisation
        {
            get { return this.Organisation; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_ORG_ID" field.
        /// </summary>
        System.String IPaymentModel.OrganisationId
        {
            get { return this.OrganisationId; }
            set { this.OrganisationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_PN_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel IPaymentModel.Person
        {
            get { return this.Person; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_PN_ID" field.
        /// </summary>
        System.String IPaymentModel.PersonId
        {
            get { return this.PersonId; }
            set { this.PersonId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_REF" field.
        /// </summary>
        System.String IPaymentModel.Reference
        {
            get { return this.Reference; }
            set { this.Reference = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_BOOK_ID" field.
        /// </summary>
        Consensus.Learning.IBookingModel IPaymentModel.Booking
        {
            get { return this.Booking; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_BOOK_ID" field.
        /// </summary>
        System.String IPaymentModel.BookingId
        {
            get { return this.BookingId; }
            set { this.BookingId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_REFUND_PAY_ID" field.
        /// </summary>
        Consensus.Finance.IPaymentModel IPaymentModel.Refund
        {
            get { return this.Refund; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_REFUND_PAY_ID" field.
        /// </summary>
        System.String IPaymentModel.RefundId
        {
            get { return this.RefundId; }
            set { this.RefundId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_REFUND_PAY_REF" field.
        /// </summary>
        System.String IPaymentModel.RefundPayRef
        {
            get { return this.RefundPayRef; }
            set { this.RefundPayRef = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_TXN_TYPE" field.
        /// </summary>
        System.Nullable<System.Int32> IPaymentModel.TxnType
        {
            get { return this.TxnType; }
            set { this.TxnType = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_BANKING_REF" field.
        /// </summary>
        System.String IPaymentModel.BankingReference
        {
            get { return this.BankingReference; }
            set { this.BankingReference = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_BANK_CHG" field.
        /// </summary>
        System.Decimal IPaymentModel.BankCharges
        {
            get { return this.BankCharges; }
            set { this.BankCharges = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_PURPOSE" field.
        /// </summary>
        System.Nullable<System.Byte> IPaymentModel.Purpose
        {
            get { return this.Purpose; }
            set { this.Purpose = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_SCHN_ID" field.
        /// </summary>
        System.String IPaymentModel.SalesChannel
        {
            get { return this.SalesChannel; }
            set { this.SalesChannel = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel IPaymentModel.Address
        {
            get { return this.Address; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_ADD_ID" field.
        /// </summary>
        System.String IPaymentModel.AddressId
        {
            get { return this.AddressId; }
            set { this.AddressId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PAY_REVERSE_RES" field.
        /// </summary>
        System.String IPaymentModel.ReverseRes
        {
            get { return this.ReverseRes; }
            set { this.ReverseRes = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_ACC_ID" field.
        /// </summary>
        Consensus.Finance.IAccountModel IPaymentModel.Account
        {
            get { return this.Account; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_ACC_ID" field.
        /// </summary>
        System.String IPaymentModel.AccountId
        {
            get { return this.AccountId; }
            set { this.AccountId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_LT_ID" field.
        /// </summary>
        Consensus.Document.ILetterTemplateModel IPaymentModel.LetterTemplate
        {
            get { return this.LetterTemplate; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_LT_ID" field.
        /// </summary>
        System.String IPaymentModel.LetterTemplateId
        {
            get { return this.LetterTemplateId; }
            set { this.LetterTemplateId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PAY_CARDHOLDER_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IPaymentModel.CardholderRole
        {
            get { return this.CardholderRole; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PAY_CARDHOLDER_PROLE_ID" field.
        /// </summary>
        System.String IPaymentModel.CardholderRoleId
        {
            get { return this.CardholderRoleId; }
            set { this.CardholderRoleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:PaymentModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPaymentModel> IPaymentModel.Refunds
        {
            get { return this.Refunds; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PayAllocationModel" /> instances that reference this <see cref="!:PaymentModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPayAllocationModel> IPaymentModel.PA_PayId
        {
            get { return this.PA_PayId; }
        }

        void IPaymentModel.Save()
        {
            this.Save();
        }

        #endregion
    }
}
