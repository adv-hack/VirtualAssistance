using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SellingCompanyModel" /> object.
    /// </summary>
    public partial class LocalSellingCompanyFactory
    {


        /// <summary>
        ///     Retrieves the default <see cref='SellingCompanyModel' /> instance.
        /// </summary>
        /// <returns>
        ///     The default <see cref='SellingCompanyModel' /> instance; or null, if no default instance can be found.
        /// </returns>
        public LocalSellingCompanyModel FetchDefault()
        {
            return FetchById("1");
        }

    }
}
