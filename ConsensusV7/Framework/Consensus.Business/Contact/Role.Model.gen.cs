using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;
using Consensus.Document;
using Consensus.Finance;
using Consensus.Learning;
using Consensus.Marketing;
using Consensus.Membership;
using Consensus.Portal;
using Consensus.Sales;
using Consensus.Security;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents a role held by a person.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IRoleModel : IModel<String>
    {
        /// <summary>
        ///     Gets the persons home role.
        /// </summary>
        Consensus.Contact.IRoleModel HomeRole
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_DO_NOT_FAX" field.
        /// </summary>
        System.Boolean DoNotFax
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_DO_NOT_EMAIL" field.
        /// </summary>
        System.Boolean DoNotEmail
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_DO_NOT_SWAP" field.
        /// </summary>
        System.Boolean DoNotSwap
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_DO_NOT_MAIL" field.
        /// </summary>
        System.Boolean DoNotMail
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_USERNUM_1" field.
        /// </summary>
        System.Boolean DoNotTelesale
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_DIS_FLAG" field.
        /// </summary>
        System.Boolean IsRoleDisabled
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_PERSON_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel Person
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_PERSON_ID" field.
        /// </summary>
        System.String PersonId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel Organisation
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_ORG_ID" field.
        /// </summary>
        System.String OrganisationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_POS_TITLE" field.
        /// </summary>
        System.String JobTitle
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_POS_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel JobType
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_POS_TYPE" field.
        /// </summary>
        System.String JobTypeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_PHONE" field.
        /// </summary>
        System.String Telephone
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_FAX" field.
        /// </summary>
        System.String Fax
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_MOBILE" field.
        /// </summary>
        System.String Mobile
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_PRINCIP_ROLE" field.
        /// </summary>
        System.Nullable<System.Byte> IsPrincipal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel Address
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_ADD_ID" field.
        /// </summary>
        System.String AddressId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> StartDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> EndDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_UNION_ROL_NO" field.
        /// </summary>
        Consensus.Common.ICodeModel UnionRolNo
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_UNION_ROL_NO" field.
        /// </summary>
        System.String UnionRolNoCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel Type
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_TYPE" field.
        /// </summary>
        System.String TypeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_EMAIL" field.
        /// </summary>
        System.String Email
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_PN_NAME" field.
        /// </summary>
        System.String PersonName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_PAYROLL" field.
        /// </summary>
        System.String Payroll
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_STAFF_NO" field.
        /// </summary>
        System.String StaffNo
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_KEY_CONTACT" field.
        /// </summary>
        System.Nullable<System.Byte> KeyContact
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_COST_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel CostCode
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_COST_CODE" field.
        /// </summary>
        System.String CostCodeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROLE_HOUR_RTE" field.
        /// </summary>
        System.Decimal HourlyRate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROLE_JOB_LVL" field.
        /// </summary>
        Consensus.Common.ICodeModel JobLevel
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROLE_JOB_LVL" field.
        /// </summary>
        System.String JobLevelCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AssociateModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IAssociateModel> AssociatedPeople
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AssociateModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IAssociateModel> Associates
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LocationModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ILocationModel> Locations
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TrainerModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ITrainerModel> TrainersRole
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CommunicationsRoleModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ICommunicationsRoleModel> RoleCommunication
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> ManagerProleId
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> Product
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> Events
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> EventsContact
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> SupplierEvents
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> EventsMainTrainer
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> Bookings
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> InvoiceBookings
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LearnerModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ILearnerModel> Learners
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TemplateTrainerModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ITemplateTrainerModel> TemplateTrainers
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityXrefModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Sales.IOpportunityXrefModel> OpportunityXrefs
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPackModel> PackSender
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LetterTemplateModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.ILetterTemplateModel> LetterTemplates
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OutputQueueModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IOutputQueueModel> OutputQueues
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IAccountModel> Accounts
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountXrefModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IAccountXrefModel> AccountXrefs
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPaymentModel> Payments
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceModel> SalesPersonInvoices
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceModel> Invoices
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrepayAccountModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IPrepayAccountModel> PrepayAccount
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:GiftaidclaimModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IGiftaidclaimModel> GiftaidclaimsSubmitter
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:GiftaidclaimModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IGiftaidclaimModel> GiftaidclaimsTrustee
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityXrefModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IActivityXrefModel> ActivityXRefs
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IHelpdeskModel> HelpdeskProleId
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IHelpdeskModel> HelpdeskGivenToId
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ComplaintModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IComplaintModel> ComplaintComplainant
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ComplaintModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IComplaintModel> ComplaintRegarding
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ComplaintModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IComplaintModel> ComplaintAssignedTo
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ComplaintModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IComplaintModel> ComplaintOwner
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LicenseModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.ILicenseModel> Licenses
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberPeriodModel> InvoiceMemberPeriods
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberLocationModel> MemberLocations
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CampaignModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ICampaignModel> CampaignManager
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CampaignModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ICampaignModel> CampaignApprover
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.IPromotionModel> PromotionManager
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.IPromotionModel> PromotionApprover
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionMasterModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.IPromotionMasterModel> PromotionMasterManager
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionMasterModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.IPromotionMasterModel> PromotionMasterApprover
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqStepModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqStepModel> SaqStepOwnerRole
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueryModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueryModel> SaqQueryManager
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueryModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueryModel> SaqQueryApprover
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MailingListModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.IMailingListModel> MailingListOwners
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PortalUserModel" /> instances that reference this <see cref="!:RoleModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Portal.IPortalUserModel> PortalUsers
        {
            get;
        }
    }
}
