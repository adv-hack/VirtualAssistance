using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="AssociatesRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IAssociateRepository : IRepository<AssociatesRecord, Int32>
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
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.AssociatesRecord" /> instances from the data store.
        /// </summary>
        /// <param name="associateId">
        ///     The value which identifies the <see cref="!:AssociateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.AssociatesRecord" /> instances that match the specified <paramref name="associateId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.AssociatesRecord> FetchAllByAssociateId(System.String associateId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.AssociatesRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:AssociateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.AssociatesRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.AssociatesRecord> FetchAllByProleId(System.String proleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.AssociatesRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:AssociateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.AssociatesRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.AssociatesRecord> FetchAllByOrgId(System.String orgId);

        #endregion
    }
}
