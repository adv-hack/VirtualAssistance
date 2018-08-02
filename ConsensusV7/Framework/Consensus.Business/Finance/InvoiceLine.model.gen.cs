using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Learning;
using Consensus.Membership;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="InvlineRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IInvoiceLineModel : IModel<String>
    {
        #region properties

        /// <summary>
        ///     Gets the The value of the "INVLN_INV_ID" field.
        /// </summary>
        Consensus.Finance.IInvoiceModel Invoice
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_INV_ID" field.
        /// </summary>
        System.String InvoiceId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_PRODUCT_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel ProductId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_PRODUCT_ID" field.
        /// </summary>
        System.String ProductIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_QTY" field.
        /// </summary>
        System.Nullable<System.Double> Qty
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_UNIT_PRICE" field.
        /// </summary>
        System.Decimal UnitPrice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_DISCOUNT" field.
        /// </summary>
        System.Decimal Discount
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_NET" field.
        /// </summary>
        System.Decimal Net
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_VAT_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel VatCode
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_VAT_CODE" field.
        /// </summary>
        System.String VatCodeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_VAT_RATE" field.
        /// </summary>
        System.Decimal VatRate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_VAT_AMT" field.
        /// </summary>
        System.Decimal VatAmt
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_TOTAL_PRICE" field.
        /// </summary>
        System.Decimal TotalPrice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_DESCRIPTION" field.
        /// </summary>
        System.String Description
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_BOOK_ID" field.
        /// </summary>
        Consensus.Learning.IBookingModel Booking
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_BOOK_ID" field.
        /// </summary>
        System.String BookingId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_ELEM_ID" field.
        /// </summary>
        Consensus.Learning.IElementModel Element
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_ELEM_ID" field.
        /// </summary>
        System.String ElementId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_COURSE_ID" field.
        /// </summary>
        Consensus.Learning.IEventModel CourseId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_COURSE_ID" field.
        /// </summary>
        System.String CourseIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_PROD_NAME" field.
        /// </summary>
        System.String ProdName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_PRD_REV_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel RevCode
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_PRD_REV_CODE" field.
        /// </summary>
        System.String RevCodeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_PROJ_ID" field.
        /// </summary>
        System.String ProjId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_MEL_ID" field.
        /// </summary>
        Consensus.Membership.IMemberLocationModel MelId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_MEL_ID" field.
        /// </summary>
        System.String MelIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_COST_CODE" field.
        /// </summary>
        System.String CostCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_CREDITED" field.
        /// </summary>
        System.Nullable<System.Byte> Credited
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "INVLN_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "INVLN_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_DEPT" field.
        /// </summary>
        System.String Dept
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_SKU" field.
        /// </summary>
        System.String Sku
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_JOB_CODE" field.
        /// </summary>
        System.String JobCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_JOB_ANAL_CODE" field.
        /// </summary>
        System.String JobAnalCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_JOB_TYPE" field.
        /// </summary>
        System.String JobType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_JOB_PARENT" field.
        /// </summary>
        System.String JobParent
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "INVLN_PRS_TYPE" field.
        /// </summary>
        System.Byte PrsType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:InvoiceLineModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberLocationModel> MemberLocations
        {
            get;
        }

        #endregion

        #region methods

        void Delete();

        void Save();

        #endregion
    }
}
