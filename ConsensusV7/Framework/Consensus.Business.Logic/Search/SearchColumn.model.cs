using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Represents Defines the columns that are displayed when performing a search within the application.
    /// </summary>
    public partial class LocalSearchColumnModel
    {
        /// <summary>
        ///     Gets or sets the value of the "SYSSC_OUTPUT_TYPE" field.
        /// </summary>
        public SearchColumnOutputTypes OutputType
        {
            get { return this.ModifiedData.OutputType.ConvertTo<SearchColumnOutputTypes>(); }
            set { this.ModifiedData.OutputType = value.ConvertTo<Byte>(); }
        }
    }
}
