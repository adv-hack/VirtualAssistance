using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ScreenCustomFieldValueRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IScreenCustomFieldValueRepository : IRepository<ScreenCustomFieldValueRecord, Int32>
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
        ///     Gets the value for a custom field for a given record.
        /// </summary>
        /// <param name="fieldId">
        ///     The custom field ID (which is associated with a page).
        /// </param>
        /// <param name="recordId">
        ///     The ID value of the record displayed on the page, converted to a string if required.
        /// </param>
        Consensus.UserInterface.ScreenCustomFieldValueRecord FetchByFieldIdAndRecordId(System.Int32 fieldId, System.String recordId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.UserInterface.ScreenCustomFieldValueRecord" /> instances from the data store.
        /// </summary>
        /// <param name="cfieldId">
        ///     The value which identifies the <see cref="!:ScreenCustomFieldValueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.UserInterface.ScreenCustomFieldValueRecord" /> instances that match the specified <paramref name="cfieldId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ScreenCustomFieldValueRecord> FetchAllByCfieldId(System.Int32 cfieldId);

        #endregion
    }
}
