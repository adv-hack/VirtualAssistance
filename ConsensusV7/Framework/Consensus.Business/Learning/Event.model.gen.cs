using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Finance;
using Consensus.Marketing;
using Consensus.Sales;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="CourseRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IEventModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the main session.
        /// </summary>
        Consensus.Learning.ISessionModel MainSession
        {
            get;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_PERSON_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel Manager
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_PERSON_ID" field.
        /// </summary>
        System.String ManagerId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_PRODUCT_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel Product
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_PRODUCT_ID" field.
        /// </summary>
        System.String ProductId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_LOC_ID" field.
        /// </summary>
        Consensus.Contact.ILocationModel Location
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_LOC_ID" field.
        /// </summary>
        System.String LocationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel Organisation
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_ORG_ID" field.
        /// </summary>
        System.String OrganisationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_REF" field.
        /// </summary>
        System.String Ref
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel Type
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_TYPE" field.
        /// </summary>
        System.String TypeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_BLOCK_PRICD" field.
        /// </summary>
        System.Nullable<System.Byte> Pricing
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> StartDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> EndDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_START_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> StartTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_END_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> EndTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel Status
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_STATUS" field.
        /// </summary>
        System.String StatusCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_LENGTH" field.
        /// </summary>
        System.Nullable<System.Double> Length
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_MIN_PLACES" field.
        /// </summary>
        System.Nullable<System.Double> MinPlaces
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_MAX_PLACES" field.
        /// </summary>
        System.Nullable<System.Double> MaxPlaces
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_FREE_PLACES" field.
        /// </summary>
        System.Nullable<System.Double> FreePlaces
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CONF_PLACES" field.
        /// </summary>
        System.Nullable<System.Double> ConfirmedPlaces
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_PROVIS_BKGS" field.
        /// </summary>
        System.Nullable<System.Double> ProvisionalPlaces
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_RESV_PLACES" field.
        /// </summary>
        System.Nullable<System.Double> WaitlistPlaces
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CANCELS" field.
        /// </summary>
        System.Nullable<System.Double> CancelledPlaces
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_BLOCK_PRICE" field.
        /// </summary>
        System.Nullable<System.Double> BlockPrice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_STUDT_PRICE" field.
        /// </summary>
        System.Nullable<System.Double> UnitPrice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_COST_CODE" field.
        /// </summary>
        System.String CostCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_REV_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel Rev
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_REV_CODE" field.
        /// </summary>
        System.String RevCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_NOTES" field.
        /// </summary>
        Consensus.Common.INotesModel Notes
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_NOTES" field.
        /// </summary>
        System.String NotesId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_BOOK_ACTUAL" field.
        /// </summary>
        System.Nullable<System.Double> BookActual
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_ACTUAL_TOT" field.
        /// </summary>
        System.Nullable<System.Double> ActualCost
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_DO_NOT_INVC" field.
        /// </summary>
        System.Nullable<System.Byte> DoNotInvoice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CANCEL_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> CancelDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CANCEL_BY" field.
        /// </summary>
        System.String CancelBy
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_SUPPLIER_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel Commissioned
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_SUPPLIER_ID" field.
        /// </summary>
        System.String CommissionedId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_OPP_ID" field.
        /// </summary>
        Consensus.Sales.IOpportunityModel Opportunity
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_OPP_ID" field.
        /// </summary>
        System.String OpportunityId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_PRIVATE" field.
        /// </summary>
        System.Nullable<System.Byte> Private
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_WEB" field.
        /// </summary>
        System.Nullable<System.Byte> Web
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_URL" field.
        /// </summary>
        System.String Url
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel Address
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_ADD_ID" field.
        /// </summary>
        System.String AddressId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_SUP_ROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel CommissionedRole
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_SUP_ROLE_ID" field.
        /// </summary>
        System.String CommissionedRoleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CURRENCY" field.
        /// </summary>
        System.String Currency
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_BKT_ID" field.
        /// </summary>
        Consensus.Finance.IBookingTermsModel BookingTerms
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_BKT_ID" field.
        /// </summary>
        System.String BookingTermsId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_CONTPROL_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel Contact
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_CONTPROL_ID" field.
        /// </summary>
        System.String ContactId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_SUP_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel SupplierStatus
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_SUP_STATUS" field.
        /// </summary>
        System.String SupplierStatusCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_OVERBOOK" field.
        /// </summary>
        System.Nullable<System.Byte> AllowOverbook
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_PROV_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel SupplierOrg
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_PROV_ORG_ID" field.
        /// </summary>
        System.String SupplierOrgId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_PROV_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel SupplierRole
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_PROV_PROLE_ID" field.
        /// </summary>
        System.String SupplierRoleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_FUNDED" field.
        /// </summary>
        System.Nullable<System.Byte> Funded
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_FUNDED_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel FundingOrganisation
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_FUNDED_ORG_ID" field.
        /// </summary>
        System.String FundingOrganisationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_RESERVATIONS" field.
        /// </summary>
        System.Int32 ReservedPlaces
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_DEF_ELEM_ST" field.
        /// </summary>
        Consensus.Common.ICodeModel DefaultDelegateStatus
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_DEF_ELEM_ST" field.
        /// </summary>
        System.String DefaultDelegateStatusCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_LAPSED" field.
        /// </summary>
        System.Int32 LapsedPlaces
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_INT_NOTES" field.
        /// </summary>
        Consensus.Common.INotesModel IntNotes
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_INT_NOTES" field.
        /// </summary>
        System.String IntNotesId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CANCELLATION_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> CancellationDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_REASON" field.
        /// </summary>
        Consensus.Common.ICodeModel CancellationReason
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_REASON" field.
        /// </summary>
        System.String CancellationReasonCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_UNRECOVERABLE_CANC_LOSS" field.
        /// </summary>
        System.Nullable<System.Decimal> UnrecoverableCancelationLoss
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_EXT_COURSEWARE" field.
        /// </summary>
        System.Nullable<System.Byte> RequiresExternalCourseware
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CONTINGENCY" field.
        /// </summary>
        System.Nullable<System.Int32> Contingency
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_COST" field.
        /// </summary>
        System.Nullable<System.Decimal> Cost
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_DELIVERY_DAYS" field.
        /// </summary>
        System.Nullable<System.Int32> DeliveryDays
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_MTR_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel MainTrainer
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_MTR_PROLE_ID" field.
        /// </summary>
        System.String MainTrainerId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_ACADY_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel AcademicYear
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_ACADY_CODE" field.
        /// </summary>
        System.String AcademicYearCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_USERMULTI_1" field.
        /// </summary>
        System.String Usermulti1
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_PSH_ID" field.
        /// </summary>
        Consensus.Finance.IPayscheduleheaderModel PayScheduleHeader
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_PSH_ID" field.
        /// </summary>
        System.Nullable<System.Int32> PayScheduleHeaderId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_BLOCK_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> BlockType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_AVAIL" field.
        /// </summary>
        System.String Avail
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_FIRST_LIC_EVENT" field.
        /// </summary>
        System.Nullable<System.Byte> FirstLicencedEvent
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_LICENSED" field.
        /// </summary>
        System.Byte Licensed
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_PACK_BCC_EMAIL" field.
        /// </summary>
        System.String PackBccEmail
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_PACK_MDN_EMAIL" field.
        /// </summary>
        System.String PackMdnEmail
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_PACK_DSN_EMAIL" field.
        /// </summary>
        System.String PackDsnEmail
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CLIENT_REF" field.
        /// </summary>
        System.String ClientRef
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_SESSIONS_DESCRIPTION" field.
        /// </summary>
        System.String SessionsDescription
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_SESSIONS_HEADER" field.
        /// </summary>
        System.String SessionsHeader
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CUT_PRD_TIME" field.
        /// </summary>
        System.Nullable<System.Byte> CutPrdTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> Elements
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SessionXrefModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ISessionXrefModel> SessionXrefEvent
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CourseSelectGroupsModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ICourseSelectGroupsModel> SelectinGroupEvent
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventProductModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IEventProductModel> EventEP
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Sales.IOpportunityModel> OppEventId
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceLineModel> InvoiceLines
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionMasterModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.IPromotionMasterModel> PromotionMasterEvent
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueryModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueryModel> SaqQueryEvent
        {
            get;
        }
    }
}
