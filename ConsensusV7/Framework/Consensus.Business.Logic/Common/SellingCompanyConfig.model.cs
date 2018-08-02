using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Represents A configuration value that applies to a selling company.
    /// </summary>
    public partial class LocalSellingCompanyConfigModel
    {
        #region properties

        /// <summary>
        ///     Gets or sets the configuration value.
        /// </summary>
        public Object Value
        {
            get
            {
                switch (this.ModifiedData.ValueToUse.ConvertTo<SellingCompanyConfigTypes>())
                {
                    case SellingCompanyConfigTypes.DateTime: return this.ModifiedData.DatetimeValue;
                    case SellingCompanyConfigTypes.Decimal: return this.ModifiedData.DecimalValue;
                    case SellingCompanyConfigTypes.Integer: return this.ModifiedData.IntValue;
                    case SellingCompanyConfigTypes.Record: return this.ModifiedData.RecordId;
                    default: return this.ModifiedData.CharValue;
                }
            }
            set
            {
                switch (this.ModifiedData.ValueToUse.ConvertTo<SellingCompanyConfigTypes>())
                {
                    case SellingCompanyConfigTypes.DateTime: this.ModifiedData.DatetimeValue = value.ConvertTo<DateTime?>(this.ModifiedData.DatetimeValue); break;
                    case SellingCompanyConfigTypes.Decimal: this.ModifiedData.DecimalValue = value.ConvertTo<Decimal?>(this.ModifiedData.DecimalValue); break;
                    case SellingCompanyConfigTypes.Integer: this.ModifiedData.IntValue = value.ConvertTo<Int32?>(this.ModifiedData.IntValue); break;
                    case SellingCompanyConfigTypes.Record: this.ModifiedData.RecordId = value.ConvertTo<String>(this.ModifiedData.RecordId); break;
                    default: this.ModifiedData.CharValue = value.ConvertTo<String>(this.ModifiedData.CharValue); break;
                }
            }
        }

        #endregion
    }
}
