using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;
using Consensus.Finance;
using Consensus.Learning;
using Consensus.Membership;
using Consensus.Sales;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents an organisation.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IOrganisationModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets theprincipal address for the organisation.
        /// </summary>
        Consensus.Contact.IOrganisationAddressModel PrincipalAddress
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_PHONE" field.
        /// </summary>
        System.String Phone
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_FAX" field.
        /// </summary>
        System.String Fax
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ORG_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel Type
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ORG_TYPE" field.
        /// </summary>
        System.String TypeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_HIERARCHY_LEVL" field.
        /// </summary>
        System.Nullable<System.Byte> HierarchyLevl
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_5" field.
        /// </summary>
        System.String Userchar5
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ORG_INDUSTRY" field.
        /// </summary>
        Consensus.Common.ICodeModel Industry
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ORG_INDUSTRY" field.
        /// </summary>
        System.String IndustryCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_1" field.
        /// </summary>
        System.String Userchar1
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_2" field.
        /// </summary>
        System.String Userchar2
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_3" field.
        /// </summary>
        System.String Userchar3
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_4" field.
        /// </summary>
        System.String Userchar4
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_SPECIAL_TERMS" field.
        /// </summary>
        System.String SpecialTerms
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_URL" field.
        /// </summary>
        System.String Website
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_6" field.
        /// </summary>
        System.String Userchar6
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERCHAR_7" field.
        /// </summary>
        System.String Userchar7
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_EXIST_CLIENT" field.
        /// </summary>
        System.Nullable<System.Byte> ExistClient
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_EMAIL" field.
        /// </summary>
        System.String Email
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_USERINT_1" field.
        /// </summary>
        System.Nullable<System.Int32> Userint1
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ORG_VATCD" field.
        /// </summary>
        Consensus.Common.ICodeModel Vatcd
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ORG_VATCD" field.
        /// </summary>
        System.String VatcdCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_DISABLED" field.
        /// </summary>
        System.Nullable<System.Byte> Disabled
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_OUR_ORG" field.
        /// </summary>
        System.Nullable<System.Byte> OurOrg
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ORG_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ORG_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_REF" field.
        /// </summary>
        System.String Ref
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_VAT_REG_NUM" field.
        /// </summary>
        System.String VatRegNum
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_WEB_ENABLED" field.
        /// </summary>
        System.Byte WebEnabled
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_PERSON_COUNT" field.
        /// </summary>
        System.Int32 PersonCount
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_SPEND" field.
        /// </summary>
        System.Nullable<System.Decimal> Spend
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ORG_ON_HOLD" field.
        /// </summary>
        System.Byte OnHold
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:RoleModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IRoleModel> Roles
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OrganisationAddressModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IOrganisationAddressModel> OrganisationAddresses
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CustomerPackModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ICustomerPackModel> CustomerPacks
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AssociateModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IAssociateModel> Associates
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OrganisationDepartmentModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IOrganisationDepartmentModel> Departments
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LocationModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ILocationModel> Locations
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AkaModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.IAkaModel> AKAOrganisation
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> Product
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> Events
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> EventsCommissioned
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> SupplierEvents
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> FundingEvents
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IBookingModel> Bookings
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IBookingModel> InvoiceBookings
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LearnerModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ILearnerModel> Learners
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SessionModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.ISessionModel> SessionOrganisation
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityXrefModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Sales.IOpportunityXrefModel> OpportunityXrefs
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IAccountModel> Accounts
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AccountXrefModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IAccountXrefModel> AccountXrefs
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PaymentModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IPaymentModel> Payments
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IInvoiceModel> Invoices
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrepayAccountModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IPrepayAccountModel> PrepayAccounts
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:GiftaidclaimModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IGiftaidclaimModel> GiftaidclaimsOrganisation
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProfileOrganisationModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Common.IProfileOrganisationModel> ProfileOrganisations
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityXrefModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Activities.IActivityXrefModel> ActivityXRefs
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Activities.IHelpdeskModel> HelpdeskOrganisationId
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Membership.IMemberPeriodModel> MemberPeriodInvoice
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:OrganisationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Membership.IMemberLocationModel> MemberLocations
        {
            get;
        }
    }
}
