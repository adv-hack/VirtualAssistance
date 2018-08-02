using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Document;
using Consensus.Finance;
using Consensus.Membership;
using Consensus.Sales;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="ProductRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProductModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the academic code.
        /// </summary>
        Consensus.Learning.IProductEventModel ActiveProductEvent
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the main session.
        /// </summary>
        Consensus.Learning.IBillOfMaterialModel MainSession
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_REF" field.
        /// </summary>
        System.String Ref
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_DESCRIP" field.
        /// </summary>
        Consensus.Activities.IC4textModel ProdDescrip
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_DESCRIP" field.
        /// </summary>
        System.String ProdDescripId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_TEXT1" field.
        /// </summary>
        Consensus.Activities.IC4textModel ProdContent
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_TEXT1" field.
        /// </summary>
        System.String ProdContentId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_TEXT2" field.
        /// </summary>
        Consensus.Activities.IC4textModel ProdPrereq
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_TEXT2" field.
        /// </summary>
        System.String ProdPrereqId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_TEXT3" field.
        /// </summary>
        Consensus.Activities.IC4textModel ProdObjective
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_TEXT3" field.
        /// </summary>
        System.String ProdObjectiveId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SY_PRODUCT" field.
        /// </summary>
        System.Nullable<System.Byte> SyProduct
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel Type
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_TYPE" field.
        /// </summary>
        System.String TypeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_CATEGORY" field.
        /// </summary>
        Consensus.Common.ICodeModel Category
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_CATEGORY" field.
        /// </summary>
        System.String CategoryCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_GROUP" field.
        /// </summary>
        Consensus.Common.ICodeModel Group
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_GROUP" field.
        /// </summary>
        System.String GroupCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_PRICE" field.
        /// </summary>
        System.Nullable<System.Double> Price
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_BLOCK_PRICE" field.
        /// </summary>
        System.Nullable<System.Double> BlockPrice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SPARE_PRICE" field.
        /// </summary>
        System.Nullable<System.Double> SparePrice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_COST_PRICE" field.
        /// </summary>
        System.Nullable<System.Double> CostPrice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_COST_CODE" field.
        /// </summary>
        System.String CostCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_REV_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel RevCode
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_REV_CODE" field.
        /// </summary>
        System.String RevCodeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_VAT_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel VatCode
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_VAT_CODE" field.
        /// </summary>
        System.String VatCodeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MIN_ATTEND" field.
        /// </summary>
        System.Nullable<System.Double> MinAttend
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_MAX_ATTEND" field.
        /// </summary>
        System.Nullable<System.Double> MaxAttend
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_COURSE_LEN" field.
        /// </summary>
        System.Nullable<System.Double> CourseLen
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SPARE_FLAG1" field.
        /// </summary>
        System.Nullable<System.Byte> CanChangeCostCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_ENTRY_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> EntryDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_CODE" field.
        /// </summary>
        System.String SchemeNo
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SELL_HINT" field.
        /// </summary>
        System.String ProdSellHint
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_TOP_LEVEL" field.
        /// </summary>
        System.Nullable<System.Byte> TopLevel
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_STATE" field.
        /// </summary>
        System.Nullable<System.Byte> State
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_STOCKED" field.
        /// </summary>
        System.Nullable<System.Byte> Stocked
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_QTY_AV" field.
        /// </summary>
        System.Nullable<System.Double> QtyAv
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_QTY_AC" field.
        /// </summary>
        System.Nullable<System.Double> QtyAc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_TRN_TXT_ID" field.
        /// </summary>
        System.String TrnTxtId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel ProleId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_PROLE_ID" field.
        /// </summary>
        System.String ProleIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_MAN_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel ProductManager
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_MAN_PROLE_ID" field.
        /// </summary>
        System.String ProductManagerId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_BKT_ID" field.
        /// </summary>
        Consensus.Finance.IBookingTermsModel BookingTerms
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_BKT_ID" field.
        /// </summary>
        System.String BookingTermsId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_LOC_ID" field.
        /// </summary>
        Consensus.Contact.ILocationModel Location
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_LOC_ID" field.
        /// </summary>
        System.String LocationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_WEB" field.
        /// </summary>
        System.Nullable<System.Byte> Web
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "prod_quantity" field.
        /// </summary>
        System.Nullable<System.Double> ProdQuantity
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_AUTH_PN_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel AuthorPerson
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_AUTH_PN_ID" field.
        /// </summary>
        System.String AuthorPersonId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_ISBN" field.
        /// </summary>
        System.String Isbn
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_PAGE_COUNT" field.
        /// </summary>
        System.Nullable<System.Int32> PageCount
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_FREQ" field.
        /// </summary>
        System.Nullable<System.Int32> Freq
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_REG_BODY_ID_1" field.
        /// </summary>
        Consensus.Common.ICodeModel RegBody
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_REG_BODY_ID_1" field.
        /// </summary>
        System.String RegBodyCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_REG_BODY_ID_2" field.
        /// </summary>
        System.String RegBodyRef
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_KEYWORDS" field.
        /// </summary>
        System.String Keywords
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_CUT_PRD" field.
        /// </summary>
        System.Nullable<System.Int32> CutOffPeriod
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_FUNDED" field.
        /// </summary>
        System.Nullable<System.Byte> Funded
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_FUNDED_ORG_ID" field.
        /// </summary>
        System.String FundingBody
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_QUAL_DEL" field.
        /// </summary>
        System.Nullable<System.Byte> QualDel
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel Venue
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_ORG_ID" field.
        /// </summary>
        System.String VenueId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_CALC_COMMISSION" field.
        /// </summary>
        System.Nullable<System.Byte> CalcCommission
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DEF_TRAINEE_DAYS" field.
        /// </summary>
        System.Nullable<System.Decimal> DefTraineeDays
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_GRANT_ELIGIBLE" field.
        /// </summary>
        System.Nullable<System.Byte> GrantEligible
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_GRANT_VALUE_AVAILABLE" field.
        /// </summary>
        System.Nullable<System.Decimal> GrantValueAvailable
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_BREAKEVEN_1" field.
        /// </summary>
        System.Nullable<System.Decimal> Breakeven1
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_BREAKEVEN_2" field.
        /// </summary>
        System.Nullable<System.Decimal> Breakeven2
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_EXT_COURSEWARE" field.
        /// </summary>
        System.Nullable<System.Byte> ExtCourseware
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_CONTINGENCY" field.
        /// </summary>
        System.Nullable<System.Int32> Contingency
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_COST" field.
        /// </summary>
        System.Nullable<System.Decimal> Cost
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DELIVERY_DAY" field.
        /// </summary>
        System.Nullable<System.Int32> DeliveryDay
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_EXT_URL" field.
        /// </summary>
        System.String ExtUrl
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_NONE_CHARGEABLE" field.
        /// </summary>
        System.Byte NoneChargeable
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DESIG_LETTERS" field.
        /// </summary>
        System.String DesigLetters
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_EXPIRY_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ExpiryDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_INV_ZERO_VAL" field.
        /// </summary>
        System.Int32 InvZeroVal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_EXCLUDE_TRAIN_HISTORY" field.
        /// </summary>
        System.Byte ExcludeTrainHistory
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_START_DATE_TYPE" field.
        /// </summary>
        System.Byte StartDateType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_START_DATE_FIXED" field.
        /// </summary>
        System.Nullable<System.DateTime> StartDateFixed
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_START_DATE_OFFSET" field.
        /// </summary>
        System.Int32 StartDateOffset
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_START_DATE_OFFSET_TYPE" field.
        /// </summary>
        System.String StartDateOffsetType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_END_DATE_TYPE" field.
        /// </summary>
        System.Byte EndDateType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_END_DATE_FIXED" field.
        /// </summary>
        System.Nullable<System.DateTime> EndDateFixed
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_END_DATE_OFFSET" field.
        /// </summary>
        System.Int32 EndDateOffset
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_END_DATE_OFFSET_TYPE" field.
        /// </summary>
        System.String EndDateOffsetType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DESC_EDITABLE" field.
        /// </summary>
        System.Byte DescEditable
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_AUTHOR_NAME" field.
        /// </summary>
        System.String AuthorName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_PREPAY_UNITS" field.
        /// </summary>
        System.Nullable<System.Int32> PrepayUnits
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DELIV_METHOD" field.
        /// </summary>
        System.String DelivMethod
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_SEARCH_GROUP" field.
        /// </summary>
        Consensus.Common.ICodeModel SearchGroup
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_SEARCH_GROUP" field.
        /// </summary>
        System.String SearchGroupCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_DEF_ELEM_ST" field.
        /// </summary>
        Consensus.Common.ICodeModel DefDelStat
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_DEF_ELEM_ST" field.
        /// </summary>
        System.String DefDelStatCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SHORT_DESC" field.
        /// </summary>
        System.String ProductSummary
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_ONECLICK_CHECKOUT" field.
        /// </summary>
        System.Byte OneclickCheckout
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_BOOKER_ONLY" field.
        /// </summary>
        System.Byte BookerOnly
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DEPT" field.
        /// </summary>
        System.String Dept
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_SKU" field.
        /// </summary>
        System.String Sku
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_JOB_CODE" field.
        /// </summary>
        System.String JobCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_JOB_ANALY_CODE" field.
        /// </summary>
        System.String JobAnalyCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_JOB_TYPE" field.
        /// </summary>
        System.String JobType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_JOB_PARENT" field.
        /// </summary>
        System.String JobParent
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_PSH_ID" field.
        /// </summary>
        Consensus.Finance.IPayscheduleheaderModel PaymentSchedule
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_PSH_ID" field.
        /// </summary>
        System.Nullable<System.Int32> PaymentScheduleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_IMAGE" field.
        /// </summary>
        System.String Image
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_ONLINE_SCHE" field.
        /// </summary>
        System.String OnlineSchedule
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_URL_NAME" field.
        /// </summary>
        System.String UrlName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_TRAIN_PROV" field.
        /// </summary>
        System.Nullable<System.Byte> TrainProv
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_LICENSED" field.
        /// </summary>
        System.Byte Licensed
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_DEL_CLOSE_DAYS" field.
        /// </summary>
        System.Int32 DelCloseDays
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_TRN_RULES_TXT" field.
        /// </summary>
        Consensus.Activities.IC4textModel ProductTrainingRules
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_TRN_RULES_TXT" field.
        /// </summary>
        System.String ProductTrainingRulesId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_DEF_METH_DEL" field.
        /// </summary>
        Consensus.Common.ICodeModel DefMethDel
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_DEF_METH_DEL" field.
        /// </summary>
        System.String DefMethDelCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_CODE_IMAGE" field.
        /// </summary>
        Consensus.Common.ICodeModel Classification
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_CODE_IMAGE" field.
        /// </summary>
        System.String ClassificationCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_GATEWAY_ACC_ID" field.
        /// </summary>
        Consensus.Common.ICodeModel GatewayAccId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_GATEWAY_ACC_ID" field.
        /// </summary>
        System.String GatewayAccIdCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROD_ROYALTY_MODEL" field.
        /// </summary>
        Consensus.Common.ICodeModel RoyaltyModel
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROD_ROYALTY_MODEL" field.
        /// </summary>
        System.String RoyaltyModelCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_CUT_PRD_TIME" field.
        /// </summary>
        System.Nullable<System.Byte> CutOffTime
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROD_GIFTAID" field.
        /// </summary>
        System.Nullable<System.Byte> Giftaid
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TrainProdXrefModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ITrainProdXrefModel> TrainProductXref
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BillOfMaterialModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBillOfMaterialModel> BillOfMaterials
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BillOfMaterialModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBillOfMaterialModel> BOMs
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BillOfMaterialModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBillOfMaterialModel> AccomBOMs
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IEventModel> Events
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:RelatedProductModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IRelatedProductModel> RelatedProduct
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductEventModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductEventModel> ProductEvents
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> Elements
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventProductModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IEventProductModel> ProductEP
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProdSelectGroupModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProdSelectGroupModel> SelectGroupProduct
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TemplateResourceModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ITemplateResourceModel> TemplateResources
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SessionModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ISessionModel> SessionCourse
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Sales.IOpportunityModel> OppProdId
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackProductModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPackProductModel> PackProducts
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PriceModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IPriceModel> Prices
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceLineModel> InvoiceLines
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PrepayAccountModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Finance.IPrepayAccountModel> PrepayAccounts
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProfileProductModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Common.IProfileProductModel> ProfileProducts
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ActivityXrefModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IActivityXrefModel> ActivityXRefs
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberBomModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberBomModel> ParentProduct
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberBomModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberBomModel> GradeProduct
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CommitteeModel" /> instances that reference this <see cref="!:ProductModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.ICommitteeModel> CommiteeProduct
        {
            get;
        }
    }
}
