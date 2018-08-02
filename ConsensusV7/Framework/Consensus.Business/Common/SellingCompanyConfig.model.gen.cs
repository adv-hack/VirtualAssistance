using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Represents a configuration value that applies to a selling company.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISellingCompanyConfigModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the configuration value.
        /// </summary>
        System.Object Value
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_KEY_NAME" field.
        /// </summary>
        System.String KeyName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_VALUE_TO_USE" field.
        /// </summary>
        System.Nullable<System.Byte> ValueToUse
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_LABEL_NAME" field.
        /// </summary>
        System.String LabelName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_CHAR_VALUE" field.
        /// </summary>
        System.String CharValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_RECORD_ID" field.
        /// </summary>
        System.String RecordId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_INT_VALUE" field.
        /// </summary>
        System.Nullable<System.Int32> IntValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_DATETIME_VALUE" field.
        /// </summary>
        System.Nullable<System.DateTime> DatetimeValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_DECIMAL_VALUE" field.
        /// </summary>
        System.Nullable<System.Decimal> DecimalValue
        {
            get;
            set;
        }
    }
}
