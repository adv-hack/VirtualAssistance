using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CommitteeModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCommitteeFactory : LocalFactory<LocalCommitteeModel, CommitteeRecord, String>, ICommitteeFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='CommitteeModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='CommitteeModel' /> instance.
        /// </returns>
        public LocalCommitteeModel Create()
        {
            return new LocalCommitteeModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='CommitteeModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='CommitteeModel' /> instances.
        /// </returns>
        public IEnumerable<LocalCommitteeModel> FetchAll()
        {
            IEnumerable<CommitteeRecord> recordCollection = this.Provider.DataProvider.Membership.Committee.FetchAll();
            foreach (CommitteeRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCommitteeModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='CommitteeModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='CommitteeModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CommitteeModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalCommitteeModel FetchById(String id)
        {
            CommitteeRecord record = this.Provider.DataProvider.Membership.Committee.FetchById(id);
            if (record == null)
                return null;
            return new LocalCommitteeModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Committee/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Membership.Committee.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='CommitteeModel' /> instances.
        /// </summary>
        /// <param name="disIdId">
        ///     The value which identifies the <see cref='CommitteeModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CommitteeModel' /> instances that match the specified <paramref name='disIdId' />.
        /// </returns>
        public IEnumerable<LocalCommitteeModel> FetchAllByDisIdId(String disIdId)
        {
            IEnumerable<CommitteeRecord> recordCollection = this.Provider.DataProvider.Membership.Committee.FetchAllByDisId(disIdId);
            foreach (CommitteeRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCommitteeModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='CommitteeModel' /> instances.
        /// </summary>
        /// <param name="prodIdId">
        ///     The value which identifies the <see cref='CommitteeModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CommitteeModel' /> instances that match the specified <paramref name='prodIdId' />.
        /// </returns>
        public IEnumerable<LocalCommitteeModel> FetchAllByProdIdId(String prodIdId)
        {
            IEnumerable<CommitteeRecord> recordCollection = this.Provider.DataProvider.Membership.Committee.FetchAllByProdId(prodIdId);
            foreach (CommitteeRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCommitteeModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='CommitteeModel' /> instances.
        /// </summary>
        /// <param name="brIdId">
        ///     The value which identifies the <see cref='CommitteeModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CommitteeModel' /> instances that match the specified <paramref name='brIdId' />.
        /// </returns>
        public IEnumerable<LocalCommitteeModel> FetchAllByBrIdId(String brIdId)
        {
            IEnumerable<CommitteeRecord> recordCollection = this.Provider.DataProvider.Membership.Committee.FetchAllByBrId(brIdId);
            foreach (CommitteeRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCommitteeModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:CommitteeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CommitteeModel" /> instance.
        /// </returns>
        Consensus.Membership.ICommitteeModel ICommitteeFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CommitteeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CommitteeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.ICommitteeModel> ICommitteeFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CommitteeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CommitteeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Membership.ICommitteeModel ICommitteeFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ICommitteeFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommitteeModel" /> instances.
        /// </summary>
        /// <param name="disIdId">
        ///     The value which identifies the <see cref="!:CommitteeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeModel" /> instances that match the specified <paramref name="disIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.ICommitteeModel> ICommitteeFactory.FetchAllByDisIdId(System.String disIdId)
        {
            return this.FetchAllByDisIdId(disIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommitteeModel" /> instances.
        /// </summary>
        /// <param name="prodIdId">
        ///     The value which identifies the <see cref="!:CommitteeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeModel" /> instances that match the specified <paramref name="prodIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.ICommitteeModel> ICommitteeFactory.FetchAllByProdIdId(System.String prodIdId)
        {
            return this.FetchAllByProdIdId(prodIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommitteeModel" /> instances.
        /// </summary>
        /// <param name="brIdId">
        ///     The value which identifies the <see cref="!:CommitteeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommitteeModel" /> instances that match the specified <paramref name="brIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.ICommitteeModel> ICommitteeFactory.FetchAllByBrIdId(System.String brIdId)
        {
            return this.FetchAllByBrIdId(brIdId);
        }

        #endregion
    }
}
