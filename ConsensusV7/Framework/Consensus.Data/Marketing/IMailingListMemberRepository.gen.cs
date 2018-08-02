using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ListMemberRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMailingListMemberRepository : IRepository<ListMemberRecord, String>
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

        void Create(Consensus.Marketing.ListMemberRecord record);

        void Modify(Consensus.Marketing.ListMemberRecord record);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.ListMemberRecord" /> instances from the data store.
        /// </summary>
        /// <param name="listId">
        ///     The value which identifies the <see cref="!:MailingListMemberModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.ListMemberRecord" /> instances that match the specified <paramref name="listId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ListMemberRecord> FetchAllByListId(System.String listId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.ListMemberRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pnId">
        ///     The value which identifies the <see cref="!:MailingListMemberModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.ListMemberRecord" /> instances that match the specified <paramref name="pnId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ListMemberRecord> FetchAllByPnId(System.String pnId);

        #endregion
    }
}
