using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="SessionXrefRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISessionXrefModel : IModel<String>
    {
        /// <summary>
        ///     Gets the The value of the "SXREF_COURSE_ID" field.
        /// </summary>
        Consensus.Learning.IEventModel Event
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SXREF_COURSE_ID" field.
        /// </summary>
        System.String EventId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "SXREF_ACT_ID" field.
        /// </summary>
        Consensus.Learning.ISessionModel Session
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SXREF_ACT_ID" field.
        /// </summary>
        System.String SessionId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_REAL" field.
        /// </summary>
        System.Nullable<System.Byte> Real
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_ELEMENT" field.
        /// </summary>
        System.Nullable<System.Byte> Element
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_MANDATORY" field.
        /// </summary>
        System.Nullable<System.Byte> Mandatory
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_INV_PRINT" field.
        /// </summary>
        System.Nullable<System.Byte> InvPrint
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_CURRENCY" field.
        /// </summary>
        System.String Currency
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_PRICE" field.
        /// </summary>
        System.Decimal Price
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_BLOCK_PRICE" field.
        /// </summary>
        System.Decimal BlockPrice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "SXREF_VATCD" field.
        /// </summary>
        Consensus.Common.ICodeModel VatCode
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SXREF_VATCD" field.
        /// </summary>
        System.String VatCodeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_SHOW_SALES" field.
        /// </summary>
        System.Nullable<System.Byte> ShowSales
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_RETAIL_PRICE" field.
        /// </summary>
        System.Decimal RetailPrice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_COST_PRICE" field.
        /// </summary>
        System.Decimal CostPrice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_DEFAULT" field.
        /// </summary>
        System.Nullable<System.Byte> Default
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_PL_ID" field.
        /// </summary>
        System.String PlId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_QTY_MIN" field.
        /// </summary>
        System.Nullable<System.Int32> QtyMin
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_QTY_MAX" field.
        /// </summary>
        System.Nullable<System.Int32> QtyMax
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_VALID_FROM" field.
        /// </summary>
        System.Nullable<System.DateTime> ValidFrom
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_VALID_UNTIL" field.
        /// </summary>
        System.Nullable<System.DateTime> ValidUntil
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_MAIN_SESSION" field.
        /// </summary>
        System.Nullable<System.Byte> MainSession
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_MAST_SESS" field.
        /// </summary>
        System.Nullable<System.Int32> MastSess
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_PL_NAME" field.
        /// </summary>
        System.String PlName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_PRS_ID" field.
        /// </summary>
        System.String PrsId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_MEMBER" field.
        /// </summary>
        System.Nullable<System.Byte> Member
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_START_DAY" field.
        /// </summary>
        System.Nullable<System.Int32> StartDay
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_END_DAY" field.
        /// </summary>
        System.Nullable<System.Int32> EndDay
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "SXREF_EP_ID" field.
        /// </summary>
        Consensus.Learning.IEventProductModel EventProduct
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SXREF_EP_ID" field.
        /// </summary>
        System.Nullable<System.Int32> EventProductId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_VALID_DATE" field.
        /// </summary>
        System.Byte ValidDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "SXREF_REGION" field.
        /// </summary>
        Consensus.Common.ICodeModel RegionCode
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SXREF_REGION" field.
        /// </summary>
        System.String RegionCodeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SXREF_CSG_ID" field.
        /// </summary>
        System.Nullable<System.Int32> CsgId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:SessionXrefModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> Elements
        {
            get;
        }
    }
}
