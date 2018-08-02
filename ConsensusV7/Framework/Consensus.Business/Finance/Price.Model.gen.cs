using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Learning;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="PricesRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPriceModel : IModel<String>
    {
        /// <summary>
        ///     Gets the The value of the "PRS_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel TypeModel
        {
            get;
        }

        /// <summary>
        ///     Gets the The value of the "PRS_PL_ID" field.
        /// </summary>
        Consensus.Finance.IPriceListModel PriceList
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PRS_PL_ID" field.
        /// </summary>
        System.String PriceListId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PRS_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel Product
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PRS_PROD_ID" field.
        /// </summary>
        System.String ProductId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_PRICE" field.
        /// </summary>
        System.Decimal Amount
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_COST_PRICE" field.
        /// </summary>
        System.Decimal CostPrice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PRS_VAT_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel VatCode
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PRS_VAT_CODE" field.
        /// </summary>
        System.String VatCodeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_RETAIL_PRICE" field.
        /// </summary>
        System.Decimal RetailPrice
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_PRICE_A" field.
        /// </summary>
        System.Decimal PriceA
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_QTY_MIN" field.
        /// </summary>
        System.Nullable<System.Int32> QtyMin
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_QTY_MAX" field.
        /// </summary>
        System.Nullable<System.Int32> QtyMax
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_VALID_FROM" field.
        /// </summary>
        System.Nullable<System.DateTime> ValidFrom
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_VALID_UNTIL" field.
        /// </summary>
        System.Nullable<System.DateTime> ValidUntil
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_VAT_CODE2" field.
        /// </summary>
        System.String VatCode2
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_CURR_TYPE" field.
        /// </summary>
        System.String CurrType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_START" field.
        /// </summary>
        System.Nullable<System.Int32> Start
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_END" field.
        /// </summary>
        System.Nullable<System.Int32> End
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_VALID_DATE" field.
        /// </summary>
        System.Byte ValidDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PRS_REGION" field.
        /// </summary>
        Consensus.Common.ICodeModel Region
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PRS_REGION" field.
        /// </summary>
        System.String RegionCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PRS_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:PriceModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> Elements
        {
            get;
        }
    }
}
