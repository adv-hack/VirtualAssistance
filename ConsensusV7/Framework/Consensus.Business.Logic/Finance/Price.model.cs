using Consensus.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="PricesRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalPriceModel
    {
        private LocalCodeModel _typeModel;

        /// <summary>
        ///     Gets the The value of the "PRS_TYPE" field.
        /// </summary>
        public LocalCodeModel TypeModel
        {
            get
            {
                if (_typeModel == null && this.Type != null)
                    _typeModel = this.Provider.Common.Code.FetchByTypeAndCodeValue3("PRSTY", this.Type.ConvertTo<String>());
                if (_typeModel == null)
                    _typeModel = this.Provider.Common.Code.Create("PRSTY");
                return _typeModel;
            }
        }

    }
}
