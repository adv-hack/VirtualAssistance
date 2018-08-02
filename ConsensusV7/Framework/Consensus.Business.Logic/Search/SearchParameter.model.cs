using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Represents Defines the parameters that are displayed and used to perform a search within the application.
    /// </summary>
    public partial class LocalSearchParameterModel
    {
        /// <summary>
        ///     Gets the type of search parameter.
        /// </summary>
        public SearchParameterTypes Type
        {
            get { return this.ModifiedData.DisplayOptionType.ConvertTo<SearchParameterTypes>(); }
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_VISIBLE" field.
        /// </summary>
        public Boolean Visible
        {
            get { return this.ModifiedData.Visible.ConvertTo<Boolean>(); }
            set { this.ModifiedData.Visible = value.ConvertTo<Byte>(); }
        }
    }
}
