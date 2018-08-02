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
    ///     Represents an individual person.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPersonModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the principal role for the person.
        /// </summary>
        Consensus.Contact.IRoleModel PrincipalRole
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the principal role for the person.
        /// </summary>
        Consensus.Contact.IGiftaidModel ActiveGiftAid
        {
            get;
        }

        /// <summary>
        ///     Gets UserAccount.
        /// </summary>
        Consensus.Security.IUserAccountModel ActiveUserAccount
        {
            get;
        }

        /// <summary>
        ///     Gets the persons full name.
        /// </summary>
        System.String FullName
        {
            get;
        }

        /// <summary>
        ///     Gets the The value of the "PN_TITLE" field.
        /// </summary>
        Consensus.Common.ICodeModel Title
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_TITLE" field.
        /// </summary>
        System.String TitleCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_FIRST_NAME" field.
        /// </summary>
        System.String FirstName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_SURNAME" field.
        /// </summary>
        System.String Surname
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_SALUTATION" field.
        /// </summary>
        System.String Salutation
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DONOTMAIL" field.
        /// </summary>
        System.Nullable<System.Byte> DoNotMail
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_OUR_PERSON" field.
        /// </summary>
        System.Nullable<System.Byte> OurPerson
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PN_GENDER" field.
        /// </summary>
        Consensus.Common.ICodeModel Gender
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_GENDER" field.
        /// </summary>
        System.String GenderCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_NI_NUMBER" field.
        /// </summary>
        System.String NiNumber
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DIARY" field.
        /// </summary>
        System.Nullable<System.Byte> Diary
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_AKA" field.
        /// </summary>
        System.String Aka
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DONOTMAIL2" field.
        /// </summary>
        System.Nullable<System.Byte> DoNotEmail
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PN_DIET_REQUIRE" field.
        /// </summary>
        Consensus.Common.ICodeModel DietryRequirement
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_DIET_REQUIRE" field.
        /// </summary>
        System.String DietryRequirementCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PN_PROMO_ID" field.
        /// </summary>
        Consensus.Marketing.IPromotionModel PersonPromoId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_PROMO_ID" field.
        /// </summary>
        System.String PersonPromoIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DATE_OF_BIRTH" field.
        /// </summary>
        System.Nullable<System.DateTime> DateOfBirth
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_SPECIAL_NEEDS" field.
        /// </summary>
        System.String SpecialNeeds
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_FLAG_1" field.
        /// </summary>
        System.Nullable<System.Byte> DoNotFax
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_FLAG_2" field.
        /// </summary>
        System.Nullable<System.Byte> DoNotSwap
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_SPECIAL_TERMS" field.
        /// </summary>
        System.String SpecialTerms
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PN_ETHNICITY" field.
        /// </summary>
        Consensus.Common.ICodeModel Ethnicity
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_ETHNICITY" field.
        /// </summary>
        System.String EthnicityCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DISABILITY" field.
        /// </summary>
        System.Byte Disability
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PN_NATIONALITY" field.
        /// </summary>
        Consensus.Common.ICodeModel Nationality
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PN_NATIONALITY" field.
        /// </summary>
        System.String NationalityCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_MEDICAL_DET" field.
        /// </summary>
        System.String MedicalDet
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DO_NOT_SPARE1" field.
        /// </summary>
        System.Nullable<System.Byte> DoNotSpare1
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DO_NOT_SPARE2" field.
        /// </summary>
        System.Nullable<System.Byte> DoNotSpare2
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DO_NOT_SPARE3" field.
        /// </summary>
        System.Nullable<System.Byte> DoNotSpare3
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_DO_NOT_SPARE4" field.
        /// </summary>
        System.Nullable<System.Byte> DoNotSpare4
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_GDPR_CONSENT_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> GdprConsentDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PN_RETAIN_UNTIL_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> RetainUntilDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:RoleModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IRoleModel> Roles
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AkaModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IAkaModel> AKAPerson
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:GiftaidModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IGiftaidModel> GiftAid
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> Product
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> Events
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> Bookings
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LearnerModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ILearnerModel> Learners
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrintRequestModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Document.IPrintRequestModel> RolePrintFromRequests
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrintRequestModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPrintRequestModel> RolePrintToRequests
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPaymentModel> Payments
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceModel> Invoices
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceModel> SalesPersonInvoices
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProfilePersonModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Common.IProfilePersonModel> ProfilePersons
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityXrefModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IActivityXrefModel> ActivityXRefs
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserAccountModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.IUserAccountModel> UserAccounts
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MailingListMemberModel" /> instances that reference this <see cref="!:PersonModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.IMailingListMemberModel> MailingListMemberPerson
        {
            get;
        }
    }
}
