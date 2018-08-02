using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="C4currencyRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICurrencyModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "CURR_CODE" field.
        /// </summary>
        System.String Code
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CURR_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> StartDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CURR_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> EndDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CURR_CONV_FACTOR" field.
        /// </summary>
        System.Decimal ConversionFactor
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CURR_CONV_FACT2" field.
        /// </summary>
        System.Decimal ConversionFactor2
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "CURR_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CURR_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }
    }
}
