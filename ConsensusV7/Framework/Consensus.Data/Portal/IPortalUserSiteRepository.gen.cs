using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PuSiteRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPortalUserSiteRepository : IRepository<PuSiteRecord, Int32>
    {
        #region properties

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String TableName
        {
            get;
        }

        #endregion

        #region methods

        System.Collections.Generic.IEnumerable<Consensus.Portal.PuSiteRecord> FetchAllByPuId(System.Nullable<System.Int32> puId);

        System.Collections.Generic.IEnumerable<Consensus.Portal.PuSiteRecord> FetchAllByPsId(System.Nullable<System.Int32> psId);

        #endregion
    }
}
