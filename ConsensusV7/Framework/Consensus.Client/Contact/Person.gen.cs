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
    public partial class Person : Proxy<IPersonModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PrincipalRole" /> member.
        /// </summary>
        private Consensus.Contact.Role _principalRole;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ActiveGiftAid" /> member.
        /// </summary>
        private Consensus.Contact.Giftaid _activeGiftAid;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ActiveUserAccount" /> member.
        /// </summary>
        private Consensus.Security.UserAccount _activeUserAccount;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Title" /> member.
        /// </summary>
        private Consensus.Common.Code _title;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Gender" /> member.
        /// </summary>
        private Consensus.Common.Code _gender;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="DietryRequirement" /> member.
        /// </summary>
        private Consensus.Common.Code _dietryRequirement;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PersonPromoId" /> member.
        /// </summary>
        private Consensus.Marketing.Promotion _personPromoId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Ethnicity" /> member.
        /// </summary>
        private Consensus.Common.Code _ethnicity;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Nationality" /> member.
        /// </summary>
        private Consensus.Common.Code _nationality;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Roles" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Role, Consensus.Contact.IRoleModel> _roles;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="AKAPerson" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Aka, Consensus.Contact.IAkaModel> _aKAPerson;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="GiftAid" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Giftaid, Consensus.Contact.IGiftaidModel> _giftAid;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Product" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel> _product;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Events" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel> _events;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Bookings" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Booking, Consensus.Learning.IBookingModel> _bookings;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Learners" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Learner, Consensus.Learning.ILearnerModel> _learners;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="RolePrintFromRequests" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.PrintRequest, Consensus.Document.IPrintRequestModel> _rolePrintFromRequests;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="RolePrintToRequests" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.PrintRequest, Consensus.Document.IPrintRequestModel> _rolePrintToRequests;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Payments" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Payment, Consensus.Finance.IPaymentModel> _payments;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Invoices" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Invoice, Consensus.Finance.IInvoiceModel> _invoices;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SalesPersonInvoices" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.Invoice, Consensus.Finance.IInvoiceModel> _salesPersonInvoices;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ProfilePersons" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Common.ProfilePerson, Consensus.Common.IProfilePersonModel> _profilePersons;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ActivityXRefs" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Activities.ActivityXref, Consensus.Activities.IActivityXrefModel> _activityXRefs;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="UserAccounts" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Security.UserAccount, Consensus.Security.IUserAccountModel> _userAccounts;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MailingListMemberPerson" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.MailingListMember, Consensus.Marketing.IMailingListMemberModel> _mailingListMemberPerson;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the principal role for the person.
        /// </summary>
        public Consensus.Contact.Role PrincipalRole
        {
            get
            {
                if (_principalRole == null && this.Model.PrincipalRole != null)
                    _principalRole = new Consensus.Contact.Role(this.Model.PrincipalRole);
                if (_principalRole == null)
                    _principalRole = Consensus.Contact.Role.Create();
                return _principalRole;
            }
            set
            {
                _principalRole = value;
                this.Model.PrincipalRole = value.Model;
            }
        }

        /// <summary>
        ///     Gets or sets the principal role for the person.
        /// </summary>
        public Consensus.Contact.Giftaid ActiveGiftAid
        {
            get
            {
                if (_activeGiftAid == null && this.Model.ActiveGiftAid != null)
                    _activeGiftAid = new Consensus.Contact.Giftaid(this.Model.ActiveGiftAid);
                if (_activeGiftAid == null)
                    _activeGiftAid = Consensus.Contact.Giftaid.Create();
                return _activeGiftAid;
            }
        }

        /// <summary>
        ///     Gets UserAccount.
        /// </summary>
        public Consensus.Security.UserAccount ActiveUserAccount
        {
            get
            {
                if (_activeUserAccount == null && this.Model.ActiveUserAccount != null)
                    _activeUserAccount = new Consensus.Security.UserAccount(this.Model.ActiveUserAccount);
                if (_activeUserAccount == null)
                    _activeUserAccount = Consensus.Security.UserAccount.Create();
                return _activeUserAccount;
            }
        }

        /// <summary>
        ///     Gets the persons full name.
        /// </summary>
        public System.String FullName
        {
            get { return this.Model.FullName; }
        }

        /// <summary>
        ///     Gets the The value of the "PN_TITLE" field.
        /// </summary>
        public Consensus.Common.Code Title
        {
            get
            {
                if (_title == null && this.Model.Title != null)
                    _title = new Consensus.Common.Code(this.Model.Title);
                if (_title == null)
                    _title = Consensus.Common.Code.Create();
                return _title;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_TITLE" field.
        /// </summary>
        public System.String TitleCode
        {
            get { return this.Model.TitleCode; }
            set { this.Model.TitleCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_FIRST_NAME" field.
        /// </summary>
        public System.String FirstName
        {
            get { return this.Model.FirstName; }
            set { this.Model.FirstName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_SURNAME" field.
        /// </summary>
        public System.String Surname
        {
            get { return this.Model.Surname; }
            set { this.Model.Surname = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_SALUTATION" field.
        /// </summary>
        public System.String Salutation
        {
            get { return this.Model.Salutation; }
            set { this.Model.Salutation = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DONOTMAIL" field.
        /// </summary>
        public System.Nullable<System.Byte> DoNotMail
        {
            get { return this.Model.DoNotMail; }
            set { this.Model.DoNotMail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_OUR_PERSON" field.
        /// </summary>
        public System.Nullable<System.Byte> OurPerson
        {
            get { return this.Model.OurPerson; }
            set { this.Model.OurPerson = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PN_GENDER" field.
        /// </summary>
        public Consensus.Common.Code Gender
        {
            get
            {
                if (_gender == null && this.Model.Gender != null)
                    _gender = new Consensus.Common.Code(this.Model.Gender);
                if (_gender == null)
                    _gender = Consensus.Common.Code.Create();
                return _gender;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_GENDER" field.
        /// </summary>
        public System.String GenderCode
        {
            get { return this.Model.GenderCode; }
            set { this.Model.GenderCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_NI_NUMBER" field.
        /// </summary>
        public System.String NiNumber
        {
            get { return this.Model.NiNumber; }
            set { this.Model.NiNumber = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DIARY" field.
        /// </summary>
        public System.Nullable<System.Byte> Diary
        {
            get { return this.Model.Diary; }
            set { this.Model.Diary = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_AKA" field.
        /// </summary>
        public System.String Aka
        {
            get { return this.Model.Aka; }
            set { this.Model.Aka = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DONOTMAIL2" field.
        /// </summary>
        public System.Nullable<System.Byte> DoNotEmail
        {
            get { return this.Model.DoNotEmail; }
            set { this.Model.DoNotEmail = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PN_DIET_REQUIRE" field.
        /// </summary>
        public Consensus.Common.Code DietryRequirement
        {
            get
            {
                if (_dietryRequirement == null && this.Model.DietryRequirement != null)
                    _dietryRequirement = new Consensus.Common.Code(this.Model.DietryRequirement);
                if (_dietryRequirement == null)
                    _dietryRequirement = Consensus.Common.Code.Create();
                return _dietryRequirement;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_DIET_REQUIRE" field.
        /// </summary>
        public System.String DietryRequirementCode
        {
            get { return this.Model.DietryRequirementCode; }
            set { this.Model.DietryRequirementCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PN_PROMO_ID" field.
        /// </summary>
        public Consensus.Marketing.Promotion PersonPromoId
        {
            get
            {
                if (_personPromoId == null && this.Model.PersonPromoId != null)
                    _personPromoId = new Consensus.Marketing.Promotion(this.Model.PersonPromoId);
                if (_personPromoId == null)
                    _personPromoId = Consensus.Marketing.Promotion.Create();
                return _personPromoId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_PROMO_ID" field.
        /// </summary>
        public System.String PersonPromoIdId
        {
            get { return this.Model.PersonPromoIdId; }
            set { this.Model.PersonPromoIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DATE_OF_BIRTH" field.
        /// </summary>
        public System.Nullable<System.DateTime> DateOfBirth
        {
            get { return this.Model.DateOfBirth; }
            set { this.Model.DateOfBirth = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_SPECIAL_NEEDS" field.
        /// </summary>
        public System.String SpecialNeeds
        {
            get { return this.Model.SpecialNeeds; }
            set { this.Model.SpecialNeeds = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_FLAG_1" field.
        /// </summary>
        public System.Nullable<System.Byte> DoNotFax
        {
            get { return this.Model.DoNotFax; }
            set { this.Model.DoNotFax = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_FLAG_2" field.
        /// </summary>
        public System.Nullable<System.Byte> DoNotSwap
        {
            get { return this.Model.DoNotSwap; }
            set { this.Model.DoNotSwap = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_SPECIAL_TERMS" field.
        /// </summary>
        public System.String SpecialTerms
        {
            get { return this.Model.SpecialTerms; }
            set { this.Model.SpecialTerms = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PN_ETHNICITY" field.
        /// </summary>
        public Consensus.Common.Code Ethnicity
        {
            get
            {
                if (_ethnicity == null && this.Model.Ethnicity != null)
                    _ethnicity = new Consensus.Common.Code(this.Model.Ethnicity);
                if (_ethnicity == null)
                    _ethnicity = Consensus.Common.Code.Create();
                return _ethnicity;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_ETHNICITY" field.
        /// </summary>
        public System.String EthnicityCode
        {
            get { return this.Model.EthnicityCode; }
            set { this.Model.EthnicityCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DISABILITY" field.
        /// </summary>
        public System.Byte Disability
        {
            get { return this.Model.Disability; }
            set { this.Model.Disability = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PN_NATIONALITY" field.
        /// </summary>
        public Consensus.Common.Code Nationality
        {
            get
            {
                if (_nationality == null && this.Model.Nationality != null)
                    _nationality = new Consensus.Common.Code(this.Model.Nationality);
                if (_nationality == null)
                    _nationality = Consensus.Common.Code.Create();
                return _nationality;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_NATIONALITY" field.
        /// </summary>
        public System.String NationalityCode
        {
            get { return this.Model.NationalityCode; }
            set { this.Model.NationalityCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_MEDICAL_DET" field.
        /// </summary>
        public System.String MedicalDet
        {
            get { return this.Model.MedicalDet; }
            set { this.Model.MedicalDet = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DO_NOT_SPARE1" field.
        /// </summary>
        public System.Nullable<System.Byte> DoNotSpare1
        {
            get { return this.Model.DoNotSpare1; }
            set { this.Model.DoNotSpare1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DO_NOT_SPARE2" field.
        /// </summary>
        public System.Nullable<System.Byte> DoNotSpare2
        {
            get { return this.Model.DoNotSpare2; }
            set { this.Model.DoNotSpare2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DO_NOT_SPARE3" field.
        /// </summary>
        public System.Nullable<System.Byte> DoNotSpare3
        {
            get { return this.Model.DoNotSpare3; }
            set { this.Model.DoNotSpare3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DO_NOT_SPARE4" field.
        /// </summary>
        public System.Nullable<System.Byte> DoNotSpare4
        {
            get { return this.Model.DoNotSpare4; }
            set { this.Model.DoNotSpare4 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_GDPR_CONSENT_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> GdprConsentDate
        {
            get { return this.Model.GdprConsentDate; }
            set { this.Model.GdprConsentDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_RETAIN_UNTIL_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> RetainUntilDate
        {
            get { return this.Model.RetainUntilDate; }
            set { this.Model.RetainUntilDate = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:RoleModel" /> instances that reference this <see cref="!:PersonModel" />.
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
        ///     Gets the collection of <see cref="!:AkaModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        public Collection<Consensus.Contact.Aka> AKAPerson
        {
            get
            {
                if (_aKAPerson == null)
                    _aKAPerson = new ProxyCollection<Consensus.Contact.Aka, Consensus.Contact.IAkaModel>(this.Model.AKAPerson, model => new Consensus.Contact.Aka(model));
                return _aKAPerson;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:GiftaidModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        public Collection<Consensus.Contact.Giftaid> GiftAid
        {
            get
            {
                if (_giftAid == null)
                    _giftAid = new ProxyCollection<Consensus.Contact.Giftaid, Consensus.Contact.IGiftaidModel>(this.Model.GiftAid, model => new Consensus.Contact.Giftaid(model));
                return _giftAid;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:PersonModel" />.
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
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:PersonModel" />.
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
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:PersonModel" />.
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
        ///     Gets the collection of <see cref="!:LearnerModel" /> instances that reference this <see cref="!:PersonModel" />.
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
        ///     Gets the collection of <see cref="!:PrintRequestModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Document.PrintRequest> RolePrintFromRequests
        {
            get
            {
                if (_rolePrintFromRequests == null)
                    _rolePrintFromRequests = new ProxyCollection<Consensus.Document.PrintRequest, Consensus.Document.IPrintRequestModel>(this.Model.RolePrintFromRequests, model => new Consensus.Document.PrintRequest(model));
                return _rolePrintFromRequests;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrintRequestModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        public Collection<Consensus.Document.PrintRequest> RolePrintToRequests
        {
            get
            {
                if (_rolePrintToRequests == null)
                    _rolePrintToRequests = new ProxyCollection<Consensus.Document.PrintRequest, Consensus.Document.IPrintRequestModel>(this.Model.RolePrintToRequests, model => new Consensus.Document.PrintRequest(model));
                return _rolePrintToRequests;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:PersonModel" />.
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
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:PersonModel" />.
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
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        public Collection<Consensus.Finance.Invoice> SalesPersonInvoices
        {
            get
            {
                if (_salesPersonInvoices == null)
                    _salesPersonInvoices = new ProxyCollection<Consensus.Finance.Invoice, Consensus.Finance.IInvoiceModel>(this.Model.SalesPersonInvoices, model => new Consensus.Finance.Invoice(model));
                return _salesPersonInvoices;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProfilePersonModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        public Collection<Consensus.Common.ProfilePerson> ProfilePersons
        {
            get
            {
                if (_profilePersons == null)
                    _profilePersons = new ProxyCollection<Consensus.Common.ProfilePerson, Consensus.Common.IProfilePersonModel>(this.Model.ProfilePersons, model => new Consensus.Common.ProfilePerson(model));
                return _profilePersons;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityXrefModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
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
        ///     Gets the collection of <see cref="!:UserAccountModel" /> instances that reference this <see cref="!:PersonModel" />.
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
        ///     Gets the collection of <see cref="!:MailingListMemberModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.MailingListMember> MailingListMemberPerson
        {
            get
            {
                if (_mailingListMemberPerson == null)
                    _mailingListMemberPerson = new ProxyCollection<Consensus.Marketing.MailingListMember, Consensus.Marketing.IMailingListMemberModel>(this.Model.MailingListMemberPerson, model => new Consensus.Marketing.MailingListMember(model));
                return _mailingListMemberPerson;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Person(IPersonModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Performs anonymise person on a single <see cref="!:PersonModel" /> instance.
        ///                     Functionality replicated from the SQL performed in V6.5.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:PersonModel" /> instance to be modified.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PersonModel" /> instance that match the specified <paramref name="personId" />.
        /// </returns>
        public static Consensus.Contact.Person AnonymisePerson(System.String personId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Person.AnonymisePerson(site,personId);
        }

        /// <summary>
        ///     Performs anonymise person on a single <see cref="!:PersonModel" /> instance.
        ///                     Functionality replicated from the SQL performed in V6.5.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:PersonModel" /> instance to be modified.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PersonModel" /> instance that match the specified <paramref name="personId" />.
        /// </returns>
        public static Consensus.Contact.Person AnonymisePerson(ConsensusSite site, System.String personId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.IPersonModel model = provider.Contact.Person.AnonymisePerson(personId);
            return model == null ? null : new Consensus.Contact.Person(model);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PersonModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PersonModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Person Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Person.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PersonModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PersonModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Person Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.IPersonModel model = provider.Contact.Person.Create();
            return model == null ? null : new Consensus.Contact.Person(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PersonModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PersonModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Person> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Person.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PersonModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PersonModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Person> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IPersonModel> collection = provider.Contact.Person.FetchAll();
            return collection.Select(model => new Consensus.Contact.Person(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PersonModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PersonModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PersonModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Person FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Person.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PersonModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PersonModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PersonModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Person FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.IPersonModel model = provider.Contact.Person.FetchById(id);
            return model == null ? null : new Consensus.Contact.Person(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Person.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.Person.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PersonModel" /> instances.
        /// </summary>
        /// <param name="personPromoIdId">
        ///     The value which identifies the <see cref="!:PersonModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PersonModel" /> instances that match the specified <paramref name="personPromoIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Person> FetchAllByPersonPromoIdId(System.String personPromoIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Person.FetchAllByPersonPromoIdId(site,personPromoIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PersonModel" /> instances.
        /// </summary>
        /// <param name="personPromoIdId">
        ///     The value which identifies the <see cref="!:PersonModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PersonModel" /> instances that match the specified <paramref name="personPromoIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Person> FetchAllByPersonPromoIdId(ConsensusSite site, System.String personPromoIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.IPersonModel> collection = provider.Contact.Person.FetchAllByPersonPromoIdId(personPromoIdId);
            return collection.Select(model => new Consensus.Contact.Person(model));
        }

        #endregion
    }
}
