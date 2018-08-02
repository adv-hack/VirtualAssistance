using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="GenericmodeltableRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IGenericModelRepository : IRepository<GenericmodeltableRecord, String>
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

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericmodeltableModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericmodeltableModel" /> instance that matches the specified <paramref name="accid" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.GenericmodeltableRecord> FetchAllByAccIdAccountXref(System.String accid, System.String proleid);

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericmodeltableModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericmodeltableModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.GenericmodeltableRecord> FetchAllByCourseIdSessions(System.String courseid);

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericmodeltableModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericmodeltableModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.GenericmodeltableRecord> FetchAllByCourseIdPrices(System.String courseid, System.Int32 delcount);

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericmodeltableModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericmodeltableModel" /> instance that matches the specified <paramref name="prodid" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.GenericmodeltableRecord> FetchAllByProdIdPrices(System.String prodid, System.Int32 quantity);

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericmodeltableModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericmodeltableModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.GenericmodeltableRecord> ValidateDelegate(System.String courseid, System.String proleid, System.String qualid, System.Int16 ignorefreeplaces, System.Int16 delquantity);

        #endregion
    }
}
