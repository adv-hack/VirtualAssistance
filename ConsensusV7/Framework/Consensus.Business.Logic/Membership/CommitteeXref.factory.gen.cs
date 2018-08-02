using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CommitteeXrefModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCommitteeXrefFactory : LocalFactory<LocalCommitteeXrefModel, CommitteeXrefRecord, String>, ICommitteeXrefFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='CommitteeXrefModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='CommitteeXrefModel' /> instance.
        /// </returns>
        public LocalCommitteeXrefModel Create()
        {
            return new LocalCommitteeXrefModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='CommitteeXrefModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='CommitteeXrefModel' /> instances.
        /// </returns>
        public IEnumerable<LocalCommitteeXrefModel> FetchAll()
        {
            IEnumerable<CommitteeXrefRecord> recordCollection = this.Provider.DataProvider.Membership.CommitteeXref.FetchAll();
            foreach (CommitteeXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCommitteeXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='CommitteeXrefModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='CommitteeXrefModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CommitteeXrefModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalCommitteeXrefModel FetchById(String id)
        {
            CommitteeXrefRecord record = this.Provider.DataProvider.Membership.CommitteeXref.FetchById(id);
            if (record == null)
                return null;
            return new LocalCommitteeXrefModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='CommitteeXref/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Membership.CommitteeXref.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='CommitteeXrefModel' /> instances.
        /// </summary>
        /// <param name="committeeId">
        ///     The value which identifies the <see cref='CommitteeXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CommitteeXrefModel' /> instances that match the specified <paramref name='committeeId' />.
        /// </returns>
        public IEnumerable<LocalCommitteeXrefModel> FetchAllByCommitteeId(String committeeId)
        {
            IEnumerable<CommitteeXrefRecord> recordCollection = this.Provider.DataProvider.Membership.CommitteeXref.FetchAllByComId(committeeId);
            foreach (CommitteeXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCommitteeXrefModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        System.Boolean ICommitteeXrefFactory.CheckIfPersonExist(System.String committeeid, System.String personid, System.String committeexrefid)
        {
            return this.CheckIfPersonExist(committeeid, personid, committeexrefid);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CommitteeXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CommitteeXrefModel" /> instance.
        /// </returns>
        Consensus.Membership.ICommitteeXrefModel ICommitteeXrefFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CommitteeXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CommitteeXrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.ICommitteeXrefModel> ICommitteeXrefFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CommitteeXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CommitteeXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Membership.ICommitteeXrefModel ICommitteeXrefFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ICommitteeXrefFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommitteeXrefModel" /> instances.
        /// </summary>
        /// <param name="committeeId">
        ///     The value which identifies the <see cref="!:CommitteeXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeXrefModel" /> instances that match the specified <paramref name="committeeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.ICommitteeXrefModel> ICommitteeXrefFactory.FetchAllByCommitteeId(System.String committeeId)
        {
            return this.FetchAllByCommitteeId(committeeId);
        }

        #endregion
    }
}
