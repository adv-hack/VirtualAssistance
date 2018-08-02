using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;
using Consensus.Finance;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="ElementRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IElementModel : IModel<String>
    {
        /// <summary>
        ///     Gets the The value of the "ELEM_DEL_ID" field.
        /// </summary>
        Consensus.Learning.ILearnerModel Delegate
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_DEL_ID" field.
        /// </summary>
        System.String DelegateId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel Product
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_PROD_ID" field.
        /// </summary>
        System.String ProductId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_ACT_ID" field.
        /// </summary>
        Consensus.Activities.IActivityModel Activity
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_ACT_ID" field.
        /// </summary>
        System.String ActivityId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_COURSE_ID" field.
        /// </summary>
        Consensus.Learning.IEventModel Course
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_COURSE_ID" field.
        /// </summary>
        System.String CourseId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_BOOK_ID" field.
        /// </summary>
        Consensus.Learning.IBookingModel Booking
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_BOOK_ID" field.
        /// </summary>
        System.String BookingId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CERT_NO" field.
        /// </summary>
        System.String CertNo
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_ATTENDED" field.
        /// </summary>
        System.Nullable<System.Byte> Attended
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CURRENCY_TYPE" field.
        /// </summary>
        System.String CurrencyType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_PRICE" field.
        /// </summary>
        System.Decimal Price
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_BLOCK_PRICE" field.
        /// </summary>
        System.Decimal BlockPrice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_VATCD" field.
        /// </summary>
        Consensus.Common.ICodeModel Vatcd
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_VATCD" field.
        /// </summary>
        System.String VatcdCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_COST_CODE" field.
        /// </summary>
        System.String CostCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_DO_NOT_INVCE" field.
        /// </summary>
        System.Nullable<System.Byte> DoNotInvoice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_INVOICED" field.
        /// </summary>
        System.Nullable<System.Byte> Invoiced
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_INVOICED_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> InvoicedDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_DESCRIPTION" field.
        /// </summary>
        System.String Description
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_REV_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel RevCode
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_REV_CODE" field.
        /// </summary>
        System.String RevCodeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_INVOICE_PRINT" field.
        /// </summary>
        System.Nullable<System.Byte> InvoicePrinted
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CANCELLED" field.
        /// </summary>
        System.Nullable<System.Byte> Cancelled
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_NOTES" field.
        /// </summary>
        System.String Notes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_NON_ATD_RSN" field.
        /// </summary>
        System.String NonAtdRsn
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CERT_ISE_DAT" field.
        /// </summary>
        System.Nullable<System.DateTime> CertIseDat
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_PASS" field.
        /// </summary>
        System.Nullable<System.Byte> Pass
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_SCORE" field.
        /// </summary>
        System.Nullable<System.Decimal> Score
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_STATUS" field.
        /// </summary>
        System.Nullable<System.Byte> Status
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_GRADE" field.
        /// </summary>
        Consensus.Common.ICodeModel Grade
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_GRADE" field.
        /// </summary>
        System.String GradeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_PAYMENT_METHD" field.
        /// </summary>
        Consensus.Common.ICodeModel PaymentMethod
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_PAYMENT_METHD" field.
        /// </summary>
        System.String PaymentMethodCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_QTY" field.
        /// </summary>
        System.Nullable<System.Double> Qty
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_UNT_PRICE" field.
        /// </summary>
        System.Decimal UintPrice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_SHOW_SALES" field.
        /// </summary>
        System.Nullable<System.Byte> ShowSales
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_MSTC_ID" field.
        /// </summary>
        System.String MstcId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LST_PRICE" field.
        /// </summary>
        System.Decimal ListPrice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_PL_ID" field.
        /// </summary>
        Consensus.Finance.IPriceListModel PriceList
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_PL_ID" field.
        /// </summary>
        System.String PriceListId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_RETAIL_PRICE" field.
        /// </summary>
        System.Decimal RetailPrice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_COST_PRICE" field.
        /// </summary>
        System.Decimal CostPrice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_MAIN_SESSION" field.
        /// </summary>
        System.Nullable<System.Byte> MainSession
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_SELL_MSTC_ID" field.
        /// </summary>
        System.String SellMstcId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_PREPAY_UNITS" field.
        /// </summary>
        System.Nullable<System.Double> PrepayUnits
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> StartDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> EndDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_SXREF_ID" field.
        /// </summary>
        Consensus.Learning.ISessionXrefModel SessionXrefs
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_SXREF_ID" field.
        /// </summary>
        System.String SessionXrefsId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_START_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> StartTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_END_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> EndTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_VAT_AMT" field.
        /// </summary>
        System.Decimal VatAmt
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_SUSPEND_DATA" field.
        /// </summary>
        System.String LmspSuspendData
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_SCORE" field.
        /// </summary>
        System.Nullable<System.Byte> LmspScore
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_LESSON_STATUS" field.
        /// </summary>
        System.String LmspLessonStatus
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_COMMENTS" field.
        /// </summary>
        System.String LmspComments
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CERT_PRN_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> CertPrnDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CERT_PRINT_ANYWAY" field.
        /// </summary>
        System.Nullable<System.Byte> CertPrintAnyway
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CHK_IN_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> ChkInTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_EXP_CHK_OUT_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> ExpChkOutTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_ACT_CHK_OUT_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> ActChkOutTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_PRS_ID" field.
        /// </summary>
        Consensus.Finance.IPriceModel PriceId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_PRS_ID" field.
        /// </summary>
        System.String PriceIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_GRP_ID" field.
        /// </summary>
        System.Nullable<System.Int32> GrpId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_AUTH_STATUS" field.
        /// </summary>
        System.Nullable<System.Byte> AuthStatus
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_ELEM_ID" field.
        /// </summary>
        Consensus.Learning.IElementModel ParentElement
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_ELEM_ID" field.
        /// </summary>
        System.String ParentElementId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_BKT_ID" field.
        /// </summary>
        Consensus.Finance.IBookingTermsModel BookingTerm
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_BKT_ID" field.
        /// </summary>
        System.String BookingTermId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_MANDATORY" field.
        /// </summary>
        System.Byte Mandatory
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ELEM_PSH_ID" field.
        /// </summary>
        Consensus.Finance.IPayscheduleheaderModel PaymentSchedule
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ELEM_PSH_ID" field.
        /// </summary>
        System.Nullable<System.Int32> PaymentScheduleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_SCO_END_DTE" field.
        /// </summary>
        System.Nullable<System.DateTime> ScoEndDte
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_TOTAL_TIME" field.
        /// </summary>
        System.String LmspTotalTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_LESSON_LOCATION" field.
        /// </summary>
        System.String LmspLessonLocation
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_LMSP_COMPLETES" field.
        /// </summary>
        System.Int32 LmspCompletes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_GIFT_AID" field.
        /// </summary>
        System.Byte GiftAid
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ELEM_CLAIMED" field.
        /// </summary>
        System.Byte Claimed
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:ElementModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> Elements
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:ElementModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceLineModel> InvoiceLines
        {
            get;
        }
    }
}
