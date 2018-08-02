using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ScreenCustomFieldRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IScreenCustomFieldRepository : IRepository<ScreenCustomFieldRecord, Int32>
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
        ///     Fetch the custom fields for a page.
        /// </summary>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ScreenCustomFieldRecord> FetchAllByPage(System.String page);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.UserInterface.ScreenCustomFieldRecord" /> instances from the data store.
        /// </summary>
        /// <param name="cftypeId">
        ///     The value which identifies the <see cref="!:ScreenCustomFieldModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.UserInterface.ScreenCustomFieldRecord" /> instances that match the specified <paramref name="cftypeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ScreenCustomFieldRecord> FetchAllByCftypeId(System.String cftypeId);

        #endregion
    }
}
