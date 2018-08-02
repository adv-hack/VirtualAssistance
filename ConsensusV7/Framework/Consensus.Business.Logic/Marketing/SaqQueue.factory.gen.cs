using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SaqQueueModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSaqQueueFactory : LocalFactory<LocalSaqQueueModel, SaqQueryQueueRecord, Int64>, ISaqQueueFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='SaqQueueModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='SaqQueueModel' /> instance.
        /// </returns>
        public LocalSaqQueueModel Create()
        {
            return new LocalSaqQueueModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='SaqQueueModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='SaqQueueModel' /> instances.
        /// </returns>
        public IEnumerable<LocalSaqQueueModel> FetchAll()
        {
            IEnumerable<SaqQueryQueueRecord> recordCollection = this.Provider.DataProvider.Marketing.SaqQueue.FetchAll();
            foreach (SaqQueryQueueRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSaqQueueModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='SaqQueueModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='SaqQueueModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SaqQueueModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalSaqQueueModel FetchById(Int64 id)
        {
            SaqQueryQueueRecord record = this.Provider.DataProvider.Marketing.SaqQueue.FetchById(id);
            if (record == null)
                return null;
            return new LocalSaqQueueModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='SaqQueue/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Marketing.SaqQueue.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SaqQueueModel' /> instances.
        /// </summary>
        /// <param name="queryId">
        ///     The value which identifies the <see cref='SaqQueueModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SaqQueueModel' /> instances that match the specified <paramref name='queryId' />.
        /// </returns>
        public IEnumerable<LocalSaqQueueModel> FetchAllByQueryId(Int64 queryId)
        {
            IEnumerable<SaqQueryQueueRecord> recordCollection = this.Provider.DataProvider.Marketing.SaqQueue.FetchAllByQryId(queryId);
            foreach (SaqQueryQueueRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSaqQueueModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SaqQueueModel' /> instances.
        /// </summary>
        /// <param name="mailingListId">
        ///     The value which identifies the <see cref='SaqQueueModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SaqQueueModel' /> instances that match the specified <paramref name='mailingListId' />.
        /// </returns>
        public IEnumerable<LocalSaqQueueModel> FetchAllByMailingListId(String mailingListId)
        {
            IEnumerable<SaqQueryQueueRecord> recordCollection = this.Provider.DataProvider.Marketing.SaqQueue.FetchAllByListId(mailingListId);
            foreach (SaqQueryQueueRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSaqQueueModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SaqQueueModel' /> instances.
        /// </summary>
        /// <param name="profilePersonId">
        ///     The value which identifies the <see cref='SaqQueueModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SaqQueueModel' /> instances that match the specified <paramref name='profilePersonId' />.
        /// </returns>
        public IEnumerable<LocalSaqQueueModel> FetchAllByProfilePersonId(String profilePersonId)
        {
            IEnumerable<SaqQueryQueueRecord> recordCollection = this.Provider.DataProvider.Marketing.SaqQueue.FetchAllByProfKey(profilePersonId);
            foreach (SaqQueryQueueRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSaqQueueModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SaqQueueModel' /> instances.
        /// </summary>
        /// <param name="profileOrgId">
        ///     The value which identifies the <see cref='SaqQueueModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SaqQueueModel' /> instances that match the specified <paramref name='profileOrgId' />.
        /// </returns>
        public IEnumerable<LocalSaqQueueModel> FetchAllByProfileOrgId(String profileOrgId)
        {
            IEnumerable<SaqQueryQueueRecord> recordCollection = this.Provider.DataProvider.Marketing.SaqQueue.FetchAllByProfKeyOrg(profileOrgId);
            foreach (SaqQueryQueueRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSaqQueueModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SaqQueueModel' /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref='SaqQueueModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SaqQueueModel' /> instances that match the specified <paramref name='packId' />.
        /// </returns>
        public IEnumerable<LocalSaqQueueModel> FetchAllByPackId(String packId)
        {
            IEnumerable<SaqQueryQueueRecord> recordCollection = this.Provider.DataProvider.Marketing.SaqQueue.FetchAllByPackId(packId);
            foreach (SaqQueryQueueRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSaqQueueModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:SaqQueueModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqQueueModel" /> instance.
        /// </returns>
        Consensus.Marketing.ISaqQueueModel ISaqQueueFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqQueueModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqQueueModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueueModel> ISaqQueueFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqQueueModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqQueueModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Marketing.ISaqQueueModel ISaqQueueFactory.FetchById(System.Int64 id)
        {
            return this.FetchById(id);
        }

        System.String ISaqQueueFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueueModel" /> instances.
        /// </summary>
        /// <param name="queryId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instances that match the specified <paramref name="queryId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueueModel> ISaqQueueFactory.FetchAllByQueryId(System.Int64 queryId)
        {
            return this.FetchAllByQueryId(queryId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueueModel" /> instances.
        /// </summary>
        /// <param name="mailingListId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instances that match the specified <paramref name="mailingListId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueueModel> ISaqQueueFactory.FetchAllByMailingListId(System.String mailingListId)
        {
            return this.FetchAllByMailingListId(mailingListId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueueModel" /> instances.
        /// </summary>
        /// <param name="profilePersonId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instances that match the specified <paramref name="profilePersonId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueueModel> ISaqQueueFactory.FetchAllByProfilePersonId(System.String profilePersonId)
        {
            return this.FetchAllByProfilePersonId(profilePersonId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueueModel" /> instances.
        /// </summary>
        /// <param name="profileOrgId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instances that match the specified <paramref name="profileOrgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueueModel> ISaqQueueFactory.FetchAllByProfileOrgId(System.String profileOrgId)
        {
            return this.FetchAllByProfileOrgId(profileOrgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueueModel" /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:SaqQueueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueueModel" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueueModel> ISaqQueueFactory.FetchAllByPackId(System.String packId)
        {
            return this.FetchAllByPackId(packId);
        }

        #endregion
    }
}
