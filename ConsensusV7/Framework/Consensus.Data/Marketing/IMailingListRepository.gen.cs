using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ListRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMailingListRepository : IRepository<ListRecord, String>
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

        void Create(Consensus.Marketing.ListRecord record);

        void Modify(Consensus.Marketing.ListRecord record);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.ListRecord" /> instances from the data store.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:MailingListModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.ListRecord" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ListRecord> FetchAllByUserId(System.String userId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.ListRecord" /> instances from the data store.
        /// </summary>
        /// <param name="notesHtml">
        ///     The value which identifies the <see cref="!:MailingListModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.ListRecord" /> instances that match the specified <paramref name="notesHtml" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ListRecord> FetchAllByNotesHtml(System.String notesHtml);

        #endregion
    }
}
