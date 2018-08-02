using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SaqQueryModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSaqQueryFactory : LocalFactory<LocalSaqQueryModel, SaqQueryRecord, Int64>, ISaqQueryFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='SaqQueryModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='SaqQueryModel' /> instance.
        /// </returns>
        public LocalSaqQueryModel Create()
        {
            return new LocalSaqQueryModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='SaqQueryModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='SaqQueryModel' /> instances.
        /// </returns>
        public IEnumerable<LocalSaqQueryModel> FetchAll()
        {
            IEnumerable<SaqQueryRecord> recordCollection = this.Provider.DataProvider.Marketing.SaqQuery.FetchAll();
            foreach (SaqQueryRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSaqQueryModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='SaqQueryModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='SaqQueryModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SaqQueryModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalSaqQueryModel FetchById(Int64 id)
        {
            SaqQueryRecord record = this.Provider.DataProvider.Marketing.SaqQuery.FetchById(id);
            if (record == null)
                return null;
            return new LocalSaqQueryModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='SaqQuery/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Marketing.SaqQuery.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SaqQueryModel' /> instances.
        /// </summary>
        /// <param name="sourceCodeId">
        ///     The value which identifies the <see cref='SaqQueryModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SaqQueryModel' /> instances that match the specified <paramref name='sourceCodeId' />.
        /// </returns>
        public IEnumerable<LocalSaqQueryModel> FetchAllBySourceCodeId(String sourceCodeId)
        {
            IEnumerable<SaqQueryRecord> recordCollection = this.Provider.DataProvider.Marketing.SaqQuery.FetchAllByPmId(sourceCodeId);
            foreach (SaqQueryRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSaqQueryModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SaqQueryModel' /> instances.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref='SaqQueryModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SaqQueryModel' /> instances that match the specified <paramref name='eventId' />.
        /// </returns>
        public IEnumerable<LocalSaqQueryModel> FetchAllByEventId(String eventId)
        {
            IEnumerable<SaqQueryRecord> recordCollection = this.Provider.DataProvider.Marketing.SaqQuery.FetchAllByCourseId(eventId);
            foreach (SaqQueryRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSaqQueryModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SaqQueryModel' /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref='SaqQueryModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SaqQueryModel' /> instances that match the specified <paramref name='managerId' />.
        /// </returns>
        public IEnumerable<LocalSaqQueryModel> FetchAllByManagerId(String managerId)
        {
            IEnumerable<SaqQueryRecord> recordCollection = this.Provider.DataProvider.Marketing.SaqQuery.FetchAllByMgrProleId(managerId);
            foreach (SaqQueryRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSaqQueryModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SaqQueryModel' /> instances.
        /// </summary>
        /// <param name="approverId">
        ///     The value which identifies the <see cref='SaqQueryModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SaqQueryModel' /> instances that match the specified <paramref name='approverId' />.
        /// </returns>
        public IEnumerable<LocalSaqQueryModel> FetchAllByApproverId(String approverId)
        {
            IEnumerable<SaqQueryRecord> recordCollection = this.Provider.DataProvider.Marketing.SaqQuery.FetchAllByAppByProleId(approverId);
            foreach (SaqQueryRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSaqQueryModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:SaqQueryModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqQueryModel" /> instance.
        /// </returns>
        Consensus.Marketing.ISaqQueryModel ISaqQueryFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqQueryModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqQueryModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueryModel> ISaqQueryFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqQueryModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqQueryModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Marketing.ISaqQueryModel ISaqQueryFactory.FetchById(System.Int64 id)
        {
            return this.FetchById(id);
        }

        System.String ISaqQueryFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryModel" /> instances.
        /// </summary>
        /// <param name="sourceCodeId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryModel" /> instances that match the specified <paramref name="sourceCodeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueryModel> ISaqQueryFactory.FetchAllBySourceCodeId(System.String sourceCodeId)
        {
            return this.FetchAllBySourceCodeId(sourceCodeId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryModel" /> instances.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryModel" /> instances that match the specified <paramref name="eventId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueryModel> ISaqQueryFactory.FetchAllByEventId(System.String eventId)
        {
            return this.FetchAllByEventId(eventId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryModel" /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryModel" /> instances that match the specified <paramref name="managerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueryModel> ISaqQueryFactory.FetchAllByManagerId(System.String managerId)
        {
            return this.FetchAllByManagerId(managerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryModel" /> instances.
        /// </summary>
        /// <param name="approverId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryModel" /> instances that match the specified <paramref name="approverId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueryModel> ISaqQueryFactory.FetchAllByApproverId(System.String approverId)
        {
            return this.FetchAllByApproverId(approverId);
        }

        #endregion
    }
}
