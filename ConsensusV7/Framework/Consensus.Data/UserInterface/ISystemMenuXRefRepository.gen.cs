using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SystemmenusxrefRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISystemMenuXRefRepository : IRepository<SystemmenusxrefRecord, Int32>
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
        ///     Retrieves a collection of <see cref="T:Consensus.UserInterface.SystemmenusxrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="smenuId">
        ///     The value which identifies the <see cref="!:SystemMenuXRefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.UserInterface.SystemmenusxrefRecord" /> instances that match the specified <paramref name="smenuId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.SystemmenusxrefRecord> FetchAllBySmenuId(System.Int32 smenuId);

        #endregion
    }
}
