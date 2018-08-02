using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="MemberBomRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMemberBomRepository : IRepository<MemberBomRecord, String>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberBomRecord" /> instances from the data store.
        /// </summary>
        /// <param name="parentId">
        ///     The value which identifies the <see cref="!:MemberBomModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberBomRecord" /> instances that match the specified <paramref name="parentId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberBomRecord> FetchAllByParentId(System.String parentId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberBomRecord" /> instances from the data store.
        /// </summary>
        /// <param name="gradeId">
        ///     The value which identifies the <see cref="!:MemberBomModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberBomRecord" /> instances that match the specified <paramref name="gradeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberBomRecord> FetchAllByGradeId(System.String gradeId);

        #endregion
    }
}
