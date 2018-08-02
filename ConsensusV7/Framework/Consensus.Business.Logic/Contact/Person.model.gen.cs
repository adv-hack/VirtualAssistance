using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;
using Consensus.Document;
using Consensus.Finance;
using Consensus.Learning;
using Consensus.Marketing;
using Consensus.Security;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents An individual person.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPersonModel : LocalModel<PersonRecord, String>, IPersonModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PN_TITLE" field.
        /// </summary>
        private LocalCodeModel _title;

        /// <summary>
        ///     The value of the "PN_GENDER" field.
        /// </summary>
        private LocalCodeModel _gender;

        /// <summary>
        ///     The value of the "PN_DIET_REQUIRE" field.
        /// </summary>
        private LocalCodeModel _dietryRequirement;

        /// <summary>
        ///     The value of the "PN_PROMO_ID" field.
        /// </summary>
        private LocalPromotionModel _personPromoId;

        /// <summary>
        ///     The value of the "PN_ETHNICITY" field.
        /// </summary>
        private LocalCodeModel _ethnicity;

        /// <summary>
        ///     The value of the "PN_NATIONALITY" field.
        /// </summary>
        private LocalCodeModel _nationality;

        /// <summary>
        ///     The collection of <see cref="RoleModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        private LocalCollection<LocalRoleModel, IRoleModel> _roles;

        /// <summary>
        ///     The collection of <see cref="AkaModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        private LocalCollection<LocalAkaModel, IAkaModel> _aKAPerson;

        /// <summary>
        ///     The collection of <see cref="GiftaidModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        private LocalCollection<LocalGiftaidModel, IGiftaidModel> _giftAid;

        /// <summary>
        ///     The collection of <see cref="ProductModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        private LocalCollection<LocalProductModel, IProductModel> _product;

        /// <summary>
        ///     The collection of <see cref="EventModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        private LocalCollection<LocalEventModel, IEventModel> _events;

        /// <summary>
        ///     The collection of <see cref="BookingModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        private LocalCollection<LocalBookingModel, IBookingModel> _bookings;

        /// <summary>
        ///     The collection of <see cref="LearnerModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        private LocalCollection<LocalLearnerModel, ILearnerModel> _learners;

        /// <summary>
        ///     The collection of <see cref="PrintRequestModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        private LocalCollection<LocalPrintRequestModel, IPrintRequestModel> _rolePrintFromRequests;

        /// <summary>
        ///     The collection of <see cref="PrintRequestModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        private LocalCollection<LocalPrintRequestModel, IPrintRequestModel> _rolePrintToRequests;

        /// <summary>
        ///     The collection of <see cref="PaymentModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        private LocalCollection<LocalPaymentModel, IPaymentModel> _payments;

        /// <summary>
        ///     The collection of <see cref="InvoiceModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        private LocalCollection<LocalInvoiceModel, IInvoiceModel> _invoices;

        /// <summary>
        ///     The collection of <see cref="InvoiceModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        private LocalCollection<LocalInvoiceModel, IInvoiceModel> _salesPersonInvoices;

        /// <summary>
        ///     The collection of <see cref="ProfilePersonModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        private LocalCollection<LocalProfilePersonModel, IProfilePersonModel> _profilePersons;

        /// <summary>
        ///     The collection of <see cref="ActivityXrefModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        private LocalCollection<LocalActivityXrefModel, IActivityXrefModel> _activityXRefs;

        /// <summary>
        ///     The collection of <see cref="UserAccountModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        private LocalCollection<LocalUserAccountModel, IUserAccountModel> _userAccounts;

        /// <summary>
        ///     The collection of <see cref="MailingListMemberModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        private LocalCollection<LocalMailingListMemberModel, IMailingListMemberModel> _mailingListMemberPerson;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PersonRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Contact.Person.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PersonRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Contact.Person.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<PersonRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Contact.Person.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "PN_TITLE" field.
        /// </summary>
        public LocalCodeModel Title
        {
            get
            {
                if (_title == null && !String.IsNullOrEmpty(this.TitleCode))
                    _title = this.Provider.Common.Code.FetchByTypeAndCode("TITLE", this.TitleCode);
                if (_title == null)
                    _title = this.Provider.Common.Code.Create("TITLE");
                return _title;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_TITLE" field.
        /// </summary>
        public String TitleCode
        {
            get { return this.ModifiedData.Title; }
            set
            {
                if (this.ModifiedData.Title != value)
                     _title = null;
                this.ModifiedData.Title = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_FIRST_NAME" field.
        /// </summary>
        public String FirstName
        {
            get { return this.ModifiedData.FirstName; }
            set { this.ModifiedData.FirstName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_SURNAME" field.
        /// </summary>
        public String Surname
        {
            get { return this.ModifiedData.Surname; }
            set { this.ModifiedData.Surname = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_SALUTATION" field.
        /// </summary>
        public String Salutation
        {
            get { return this.ModifiedData.Salutation; }
            set { this.ModifiedData.Salutation = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DONOTMAIL" field.
        /// </summary>
        public Byte? DoNotMail
        {
            get { return this.ModifiedData.Donotmail; }
            set { this.ModifiedData.Donotmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_OUR_PERSON" field.
        /// </summary>
        public Byte? OurPerson
        {
            get { return this.ModifiedData.OurPerson; }
            set { this.ModifiedData.OurPerson = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PN_GENDER" field.
        /// </summary>
        public LocalCodeModel Gender
        {
            get
            {
                if (_gender == null && !String.IsNullOrEmpty(this.GenderCode))
                    _gender = this.Provider.Common.Code.FetchByTypeAndCode("GEND", this.GenderCode);
                if (_gender == null)
                    _gender = this.Provider.Common.Code.Create("GEND");
                return _gender;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_GENDER" field.
        /// </summary>
        public String GenderCode
        {
            get { return this.ModifiedData.Gender; }
            set
            {
                if (this.ModifiedData.Gender != value)
                     _gender = null;
                this.ModifiedData.Gender = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_NI_NUMBER" field.
        /// </summary>
        public String NiNumber
        {
            get { return this.ModifiedData.NiNumber; }
            set { this.ModifiedData.NiNumber = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DIARY" field.
        /// </summary>
        public Byte? Diary
        {
            get { return this.ModifiedData.Diary; }
            set { this.ModifiedData.Diary = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_AKA" field.
        /// </summary>
        public String Aka
        {
            get { return this.ModifiedData.Aka; }
            set { this.ModifiedData.Aka = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DONOTMAIL2" field.
        /// </summary>
        public Byte? DoNotEmail
        {
            get { return this.ModifiedData.Donotmail2; }
            set { this.ModifiedData.Donotmail2 = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PN_DIET_REQUIRE" field.
        /// </summary>
        public LocalCodeModel DietryRequirement
        {
            get
            {
                if (_dietryRequirement == null && !String.IsNullOrEmpty(this.DietryRequirementCode))
                    _dietryRequirement = this.Provider.Common.Code.FetchByTypeAndCode("PNDT", this.DietryRequirementCode);
                if (_dietryRequirement == null)
                    _dietryRequirement = this.Provider.Common.Code.Create("PNDT");
                return _dietryRequirement;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_DIET_REQUIRE" field.
        /// </summary>
        public String DietryRequirementCode
        {
            get { return this.ModifiedData.DietRequire; }
            set
            {
                if (this.ModifiedData.DietRequire != value)
                     _dietryRequirement = null;
                this.ModifiedData.DietRequire = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "PN_PROMO_ID" field.
        /// </summary>
        public LocalPromotionModel PersonPromoId
        {
            get
            {
                if (_personPromoId == null && this.PersonPromoIdId != null)
                    _personPromoId = this.Provider.Marketing.Promotion.FetchById(this.PersonPromoIdId);
                if (_personPromoId == null)
                    _personPromoId = this.Provider.Marketing.Promotion.Create();
                
                return _personPromoId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_PROMO_ID" field.
        /// </summary>
        public String PersonPromoIdId
        {
            get { return this.ModifiedData.PromoId; }
            set
            {
                if (this.ModifiedData.PromoId != value)
                     _personPromoId = null;
                this.ModifiedData.PromoId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DATE_OF_BIRTH" field.
        /// </summary>
        public DateTime? DateOfBirth
        {
            get { return this.ModifiedData.DateOfBirth; }
            set { this.ModifiedData.DateOfBirth = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_SPECIAL_NEEDS" field.
        /// </summary>
        public String SpecialNeeds
        {
            get { return this.ModifiedData.SpecialNeeds; }
            set { this.ModifiedData.SpecialNeeds = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_FLAG_1" field.
        /// </summary>
        public Byte? DoNotFax
        {
            get { return this.ModifiedData.Flag1; }
            set { this.ModifiedData.Flag1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_FLAG_2" field.
        /// </summary>
        public Byte? DoNotSwap
        {
            get { return this.ModifiedData.Flag2; }
            set { this.ModifiedData.Flag2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_SPECIAL_TERMS" field.
        /// </summary>
        public String SpecialTerms
        {
            get { return this.ModifiedData.SpecialTerms; }
            set { this.ModifiedData.SpecialTerms = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PN_ETHNICITY" field.
        /// </summary>
        public LocalCodeModel Ethnicity
        {
            get
            {
                if (_ethnicity == null && !String.IsNullOrEmpty(this.EthnicityCode))
                    _ethnicity = this.Provider.Common.Code.FetchByTypeAndCode("ETHNI", this.EthnicityCode);
                if (_ethnicity == null)
                    _ethnicity = this.Provider.Common.Code.Create("ETHNI");
                return _ethnicity;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_ETHNICITY" field.
        /// </summary>
        public String EthnicityCode
        {
            get { return this.ModifiedData.Ethnicity; }
            set
            {
                if (this.ModifiedData.Ethnicity != value)
                     _ethnicity = null;
                this.ModifiedData.Ethnicity = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DISABILITY" field.
        /// </summary>
        public Byte Disability
        {
            get { return this.ModifiedData.Disability; }
            set { this.ModifiedData.Disability = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PN_NATIONALITY" field.
        /// </summary>
        public LocalCodeModel Nationality
        {
            get
            {
                if (_nationality == null && !String.IsNullOrEmpty(this.NationalityCode))
                    _nationality = this.Provider.Common.Code.FetchByTypeAndCode("NTNLT", this.NationalityCode);
                if (_nationality == null)
                    _nationality = this.Provider.Common.Code.Create("NTNLT");
                return _nationality;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_NATIONALITY" field.
        /// </summary>
        public String NationalityCode
        {
            get { return this.ModifiedData.Nationality; }
            set
            {
                if (this.ModifiedData.Nationality != value)
                     _nationality = null;
                this.ModifiedData.Nationality = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_MEDICAL_DET" field.
        /// </summary>
        public String MedicalDet
        {
            get { return this.ModifiedData.MedicalDet; }
            set { this.ModifiedData.MedicalDet = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DO_NOT_SPARE1" field.
        /// </summary>
        public Byte? DoNotSpare1
        {
            get { return this.ModifiedData.DoNotSpare1; }
            set { this.ModifiedData.DoNotSpare1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DO_NOT_SPARE2" field.
        /// </summary>
        public Byte? DoNotSpare2
        {
            get { return this.ModifiedData.DoNotSpare2; }
            set { this.ModifiedData.DoNotSpare2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DO_NOT_SPARE3" field.
        /// </summary>
        public Byte? DoNotSpare3
        {
            get { return this.ModifiedData.DoNotSpare3; }
            set { this.ModifiedData.DoNotSpare3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DO_NOT_SPARE4" field.
        /// </summary>
        public Byte? DoNotSpare4
        {
            get { return this.ModifiedData.DoNotSpare4; }
            set { this.ModifiedData.DoNotSpare4 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_GDPR_CONSENT_DATE" field.
        /// </summary>
        public DateTime? GdprConsentDate
        {
            get { return this.ModifiedData.GdprConsentDate; }
            set { this.ModifiedData.GdprConsentDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_RETAIN_UNTIL_DATE" field.
        /// </summary>
        public DateTime? RetainUntilDate
        {
            get { return this.ModifiedData.RetainUntilDate; }
            set { this.ModifiedData.RetainUntilDate = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="RoleModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        public LocalCollection<LocalRoleModel, IRoleModel> Roles
        {
            get
            {
                if (_roles == null)
                    _roles = new LocalCollection<LocalRoleModel, IRoleModel>(this.Provider.Contact.Role.FetchAllByPersonId(this.Id));
                
                return _roles;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="AkaModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        public LocalCollection<LocalAkaModel, IAkaModel> AKAPerson
        {
            get
            {
                if (_aKAPerson == null)
                    _aKAPerson = new LocalCollection<LocalAkaModel, IAkaModel>(this.Provider.Contact.Aka.FetchAllByPnIdId(this.Id));
                
                return _aKAPerson;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="GiftaidModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        public LocalCollection<LocalGiftaidModel, IGiftaidModel> GiftAid
        {
            get
            {
                if (_giftAid == null)
                    _giftAid = new LocalCollection<LocalGiftaidModel, IGiftaidModel>(this.Provider.Contact.Giftaid.FetchAllByPnIdId(this.Id));
                
                return _giftAid;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        public LocalCollection<LocalProductModel, IProductModel> Product
        {
            get
            {
                if (_product == null)
                    _product = new LocalCollection<LocalProductModel, IProductModel>(this.Provider.Learning.Product.FetchAllByAuthorPersonId(this.Id));
                
                return _product;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalEventModel, IEventModel> Events
        {
            get
            {
                if (_events == null)
                    _events = new LocalCollection<LocalEventModel, IEventModel>(this.Provider.Learning.Event.FetchAllByManagerId(this.Id));
                
                return _events;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BookingModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        public LocalCollection<LocalBookingModel, IBookingModel> Bookings
        {
            get
            {
                if (_bookings == null)
                    _bookings = new LocalCollection<LocalBookingModel, IBookingModel>(this.Provider.Learning.Booking.FetchAllByBookerPersonId(this.Id));
                
                return _bookings;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="LearnerModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        public LocalCollection<LocalLearnerModel, ILearnerModel> Learners
        {
            get
            {
                if (_learners == null)
                    _learners = new LocalCollection<LocalLearnerModel, ILearnerModel>(this.Provider.Learning.Learner.FetchAllByDelegatePersonId(this.Id));
                
                return _learners;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PrintRequestModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalPrintRequestModel, IPrintRequestModel> RolePrintFromRequests
        {
            get
            {
                if (_rolePrintFromRequests == null)
                    _rolePrintFromRequests = new LocalCollection<LocalPrintRequestModel, IPrintRequestModel>(this.Provider.Document.PrintRequest.FetchAllBySendFromProleId(this.Id));
                
                return _rolePrintFromRequests;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PrintRequestModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        public LocalCollection<LocalPrintRequestModel, IPrintRequestModel> RolePrintToRequests
        {
            get
            {
                if (_rolePrintToRequests == null)
                    _rolePrintToRequests = new LocalCollection<LocalPrintRequestModel, IPrintRequestModel>(this.Provider.Document.PrintRequest.FetchAllBySendToProleId(this.Id));
                
                return _rolePrintToRequests;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PaymentModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        public LocalCollection<LocalPaymentModel, IPaymentModel> Payments
        {
            get
            {
                if (_payments == null)
                    _payments = new LocalCollection<LocalPaymentModel, IPaymentModel>(this.Provider.Finance.Payment.FetchAllByPersonId(this.Id));
                
                return _payments;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="InvoiceModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        public LocalCollection<LocalInvoiceModel, IInvoiceModel> Invoices
        {
            get
            {
                if (_invoices == null)
                    _invoices = new LocalCollection<LocalInvoiceModel, IInvoiceModel>(this.Provider.Finance.Invoice.FetchAllByPersonId(this.Id));
                
                return _invoices;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="InvoiceModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        public LocalCollection<LocalInvoiceModel, IInvoiceModel> SalesPersonInvoices
        {
            get
            {
                if (_salesPersonInvoices == null)
                    _salesPersonInvoices = new LocalCollection<LocalInvoiceModel, IInvoiceModel>(this.Provider.Finance.Invoice.FetchAllBySalesPersonId(this.Id));
                
                return _salesPersonInvoices;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProfilePersonModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        public LocalCollection<LocalProfilePersonModel, IProfilePersonModel> ProfilePersons
        {
            get
            {
                if (_profilePersons == null)
                    _profilePersons = new LocalCollection<LocalProfilePersonModel, IProfilePersonModel>(this.Provider.Common.ProfilePerson.FetchAllByPersonId(this.Id));
                
                return _profilePersons;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ActivityXrefModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        public LocalCollection<LocalActivityXrefModel, IActivityXrefModel> ActivityXRefs
        {
            get
            {
                if (_activityXRefs == null)
                    _activityXRefs = new LocalCollection<LocalActivityXrefModel, IActivityXrefModel>(this.Provider.Activities.ActivityXref.FetchAllByPersonId(this.Id));
                
                return _activityXRefs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="UserAccountModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        public LocalCollection<LocalUserAccountModel, IUserAccountModel> UserAccounts
        {
            get
            {
                if (_userAccounts == null)
                    _userAccounts = new LocalCollection<LocalUserAccountModel, IUserAccountModel>(this.Provider.Security.UserAccount.FetchAllByPersonId(this.Id));
                
                return _userAccounts;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MailingListMemberModel" /> instances that reference this <see cref="PersonModel" />.
        /// </summary>
        public LocalCollection<LocalMailingListMemberModel, IMailingListMemberModel> MailingListMemberPerson
        {
            get
            {
                if (_mailingListMemberPerson == null)
                    _mailingListMemberPerson = new LocalCollection<LocalMailingListMemberModel, IMailingListMemberModel>(this.Provider.Marketing.MailingListMember.FetchAllByPersonId(this.Id));
                
                return _mailingListMemberPerson;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalPersonModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalPersonModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalPersonModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalPersonModel(LocalProvider provider, PersonRecord record) : base(provider, record)
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
            if (_title != null)
            {
                _title.Save();
                this.ModifiedData.Title = _title.Value1;
            }
            if (_gender != null)
            {
                _gender.Save();
                this.ModifiedData.Gender = _gender.Value1;
            }
            if (_dietryRequirement != null)
            {
                _dietryRequirement.Save();
                this.ModifiedData.DietRequire = _dietryRequirement.Value1;
            }
            if (_ethnicity != null)
            {
                _ethnicity.Save();
                this.ModifiedData.Ethnicity = _ethnicity.Value1;
            }
            if (_nationality != null)
            {
                _nationality.Save();
                this.ModifiedData.Nationality = _nationality.Value1;
            }
            if (_personPromoId != null)
            {
                _personPromoId.Save();
                this.ModifiedData.PromoId = _personPromoId.Id == null && this.ModifiedData.PromoId != null ? "" : _personPromoId.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_roles != null)
                _roles.Execute(obj => obj.PersonId = this.Id).Execute(obj => obj.Save());
            if (_aKAPerson != null)
                _aKAPerson.Execute(obj => obj.PnIdId = this.Id).Execute(obj => obj.Save());
            if (_giftAid != null)
                _giftAid.Execute(obj => obj.PnIdId = this.Id).Execute(obj => obj.Save());
            if (_product != null)
                _product.Execute(obj => obj.AuthorPersonId = this.Id).Execute(obj => obj.Save());
            if (_events != null)
                _events.Execute(obj => obj.ManagerId = this.Id).Execute(obj => obj.Save());
            if (_bookings != null)
                _bookings.Execute(obj => obj.BookerPersonId = this.Id).Execute(obj => obj.Save());
            if (_learners != null)
                _learners.Execute(obj => obj.DelegatePersonId = this.Id).Execute(obj => obj.Save());
            if (_rolePrintFromRequests != null)
                _rolePrintFromRequests.Execute(obj => obj.SendFromProleId = this.Id).Execute(obj => obj.Save());
            if (_rolePrintToRequests != null)
                _rolePrintToRequests.Execute(obj => obj.SendToProleId = this.Id).Execute(obj => obj.Save());
            if (_payments != null)
                _payments.Execute(obj => obj.PersonId = this.Id).Execute(obj => obj.Save());
            if (_invoices != null)
                _invoices.Execute(obj => obj.PersonId = this.Id).Execute(obj => obj.Save());
            if (_salesPersonInvoices != null)
                _salesPersonInvoices.Execute(obj => obj.SalesPersonId = this.Id).Execute(obj => obj.Save());
            if (_profilePersons != null)
                _profilePersons.Execute(obj => obj.PersonId = this.Id).Execute(obj => obj.Save());
            if (_activityXRefs != null)
                _activityXRefs.Execute(obj => obj.PersonId = this.Id).Execute(obj => obj.Save());
            if (_userAccounts != null)
                _userAccounts.Execute(obj => obj.PersonId = this.Id).Execute(obj => obj.Save());
            if (_mailingListMemberPerson != null)
                _mailingListMemberPerson.Execute(obj => obj.PersonId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the principal role for the person.
        /// </summary>
        Consensus.Contact.IRoleModel IPersonModel.PrincipalRole
        {
            get { return this.PrincipalRole; }
            set { this.PrincipalRole = (Consensus.Contact.LocalRoleModel)value; }
        }

        /// <summary>
        ///     Gets or sets the principal role for the person.
        /// </summary>
        Consensus.Contact.IGiftaidModel IPersonModel.ActiveGiftAid
        {
            get { return this.ActiveGiftAid; }
        }

        /// <summary>
        ///     Gets UserAccount.
        /// </summary>
        Consensus.Security.IUserAccountModel IPersonModel.ActiveUserAccount
        {
            get { return this.ActiveUserAccount; }
        }

        /// <summary>
        ///     Gets the persons full name.
        /// </summary>
        System.String IPersonModel.FullName
        {
            get { return this.FullName; }
        }

        /// <summary>
        ///     Gets the The value of the "PN_TITLE" field.
        /// </summary>
        Consensus.Common.ICodeModel IPersonModel.Title
        {
            get { return this.Title; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_TITLE" field.
        /// </summary>
        System.String IPersonModel.TitleCode
        {
            get { return this.TitleCode; }
            set { this.TitleCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_FIRST_NAME" field.
        /// </summary>
        System.String IPersonModel.FirstName
        {
            get { return this.FirstName; }
            set { this.FirstName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_SURNAME" field.
        /// </summary>
        System.String IPersonModel.Surname
        {
            get { return this.Surname; }
            set { this.Surname = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_SALUTATION" field.
        /// </summary>
        System.String IPersonModel.Salutation
        {
            get { return this.Salutation; }
            set { this.Salutation = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DONOTMAIL" field.
        /// </summary>
        System.Nullable<System.Byte> IPersonModel.DoNotMail
        {
            get { return this.DoNotMail; }
            set { this.DoNotMail = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_OUR_PERSON" field.
        /// </summary>
        System.Nullable<System.Byte> IPersonModel.OurPerson
        {
            get { return this.OurPerson; }
            set { this.OurPerson = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PN_GENDER" field.
        /// </summary>
        Consensus.Common.ICodeModel IPersonModel.Gender
        {
            get { return this.Gender; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_GENDER" field.
        /// </summary>
        System.String IPersonModel.GenderCode
        {
            get { return this.GenderCode; }
            set { this.GenderCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_NI_NUMBER" field.
        /// </summary>
        System.String IPersonModel.NiNumber
        {
            get { return this.NiNumber; }
            set { this.NiNumber = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DIARY" field.
        /// </summary>
        System.Nullable<System.Byte> IPersonModel.Diary
        {
            get { return this.Diary; }
            set { this.Diary = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_AKA" field.
        /// </summary>
        System.String IPersonModel.Aka
        {
            get { return this.Aka; }
            set { this.Aka = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DONOTMAIL2" field.
        /// </summary>
        System.Nullable<System.Byte> IPersonModel.DoNotEmail
        {
            get { return this.DoNotEmail; }
            set { this.DoNotEmail = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PN_DIET_REQUIRE" field.
        /// </summary>
        Consensus.Common.ICodeModel IPersonModel.DietryRequirement
        {
            get { return this.DietryRequirement; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_DIET_REQUIRE" field.
        /// </summary>
        System.String IPersonModel.DietryRequirementCode
        {
            get { return this.DietryRequirementCode; }
            set { this.DietryRequirementCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PN_PROMO_ID" field.
        /// </summary>
        Consensus.Marketing.IPromotionModel IPersonModel.PersonPromoId
        {
            get { return this.PersonPromoId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_PROMO_ID" field.
        /// </summary>
        System.String IPersonModel.PersonPromoIdId
        {
            get { return this.PersonPromoIdId; }
            set { this.PersonPromoIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DATE_OF_BIRTH" field.
        /// </summary>
        System.Nullable<System.DateTime> IPersonModel.DateOfBirth
        {
            get { return this.DateOfBirth; }
            set { this.DateOfBirth = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_SPECIAL_NEEDS" field.
        /// </summary>
        System.String IPersonModel.SpecialNeeds
        {
            get { return this.SpecialNeeds; }
            set { this.SpecialNeeds = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_FLAG_1" field.
        /// </summary>
        System.Nullable<System.Byte> IPersonModel.DoNotFax
        {
            get { return this.DoNotFax; }
            set { this.DoNotFax = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_FLAG_2" field.
        /// </summary>
        System.Nullable<System.Byte> IPersonModel.DoNotSwap
        {
            get { return this.DoNotSwap; }
            set { this.DoNotSwap = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_SPECIAL_TERMS" field.
        /// </summary>
        System.String IPersonModel.SpecialTerms
        {
            get { return this.SpecialTerms; }
            set { this.SpecialTerms = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PN_ETHNICITY" field.
        /// </summary>
        Consensus.Common.ICodeModel IPersonModel.Ethnicity
        {
            get { return this.Ethnicity; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_ETHNICITY" field.
        /// </summary>
        System.String IPersonModel.EthnicityCode
        {
            get { return this.EthnicityCode; }
            set { this.EthnicityCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DISABILITY" field.
        /// </summary>
        System.Byte IPersonModel.Disability
        {
            get { return this.Disability; }
            set { this.Disability = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the The value of the "PN_NATIONALITY" field.
        /// </summary>
        Consensus.Common.ICodeModel IPersonModel.Nationality
        {
            get { return this.Nationality; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_NATIONALITY" field.
        /// </summary>
        System.String IPersonModel.NationalityCode
        {
            get { return this.NationalityCode; }
            set { this.NationalityCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_MEDICAL_DET" field.
        /// </summary>
        System.String IPersonModel.MedicalDet
        {
            get { return this.MedicalDet; }
            set { this.MedicalDet = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DO_NOT_SPARE1" field.
        /// </summary>
        System.Nullable<System.Byte> IPersonModel.DoNotSpare1
        {
            get { return this.DoNotSpare1; }
            set { this.DoNotSpare1 = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DO_NOT_SPARE2" field.
        /// </summary>
        System.Nullable<System.Byte> IPersonModel.DoNotSpare2
        {
            get { return this.DoNotSpare2; }
            set { this.DoNotSpare2 = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DO_NOT_SPARE3" field.
        /// </summary>
        System.Nullable<System.Byte> IPersonModel.DoNotSpare3
        {
            get { return this.DoNotSpare3; }
            set { this.DoNotSpare3 = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DO_NOT_SPARE4" field.
        /// </summary>
        System.Nullable<System.Byte> IPersonModel.DoNotSpare4
        {
            get { return this.DoNotSpare4; }
            set { this.DoNotSpare4 = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_GDPR_CONSENT_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IPersonModel.GdprConsentDate
        {
            get { return this.GdprConsentDate; }
            set { this.GdprConsentDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_RETAIN_UNTIL_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IPersonModel.RetainUntilDate
        {
            get { return this.RetainUntilDate; }
            set { this.RetainUntilDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:RoleModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IRoleModel> IPersonModel.Roles
        {
            get { return this.Roles; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AkaModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IAkaModel> IPersonModel.AKAPerson
        {
            get { return this.AKAPerson; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:GiftaidModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IGiftaidModel> IPersonModel.GiftAid
        {
            get { return this.GiftAid; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> IPersonModel.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> IPersonModel.Events
        {
            get { return this.Events; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> IPersonModel.Bookings
        {
            get { return this.Bookings; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LearnerModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ILearnerModel> IPersonModel.Learners
        {
            get { return this.Learners; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrintRequestModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Document.IPrintRequestModel> IPersonModel.RolePrintFromRequests
        {
            get { return this.RolePrintFromRequests; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrintRequestModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPrintRequestModel> IPersonModel.RolePrintToRequests
        {
            get { return this.RolePrintToRequests; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPaymentModel> IPersonModel.Payments
        {
            get { return this.Payments; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceModel> IPersonModel.Invoices
        {
            get { return this.Invoices; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceModel> IPersonModel.SalesPersonInvoices
        {
            get { return this.SalesPersonInvoices; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProfilePersonModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Common.IProfilePersonModel> IPersonModel.ProfilePersons
        {
            get { return this.ProfilePersons; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityXrefModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IActivityXrefModel> IPersonModel.ActivityXRefs
        {
            get { return this.ActivityXRefs; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserAccountModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.IUserAccountModel> IPersonModel.UserAccounts
        {
            get { return this.UserAccounts; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MailingListMemberModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.IMailingListMemberModel> IPersonModel.MailingListMemberPerson
        {
            get { return this.MailingListMemberPerson; }
        }

        #endregion
    }
}
