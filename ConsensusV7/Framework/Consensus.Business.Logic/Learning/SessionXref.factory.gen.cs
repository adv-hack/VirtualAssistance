using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SessionXrefModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSessionXrefFactory : LocalFactory<LocalSessionXrefModel, SessionXrefRecord, String>, ISessionXrefFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='SessionXrefModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='SessionXrefModel' /> instance.
        /// </returns>
        public LocalSessionXrefModel Create()
        {
            return new LocalSessionXrefModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='SessionXrefModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='SessionXrefModel' /> instances.
        /// </returns>
        public IEnumerable<LocalSessionXrefModel> FetchAll()
        {
            IEnumerable<SessionXrefRecord> recordCollection = this.Provider.DataProvider.Learning.SessionXref.FetchAll();
            foreach (SessionXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSessionXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='SessionXrefModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='SessionXrefModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SessionXrefModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalSessionXrefModel FetchById(String id)
        {
            SessionXrefRecord record = this.Provider.DataProvider.Learning.SessionXref.FetchById(id);
            if (record == null)
                return null;
            return new LocalSessionXrefModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='SessionXref/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Learning.SessionXref.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SessionXrefModel' /> instances.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref='SessionXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SessionXrefModel' /> instances that match the specified <paramref name='eventId' />.
        /// </returns>
        public IEnumerable<LocalSessionXrefModel> FetchAllByEventId(String eventId)
        {
            IEnumerable<SessionXrefRecord> recordCollection = this.Provider.DataProvider.Learning.SessionXref.FetchAllByCourseId(eventId);
            foreach (SessionXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSessionXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SessionXrefModel' /> instances.
        /// </summary>
        /// <param name="sessionId">
        ///     The value which identifies the <see cref='SessionXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SessionXrefModel' /> instances that match the specified <paramref name='sessionId' />.
        /// </returns>
        public IEnumerable<LocalSessionXrefModel> FetchAllBySessionId(String sessionId)
        {
            IEnumerable<SessionXrefRecord> recordCollection = this.Provider.DataProvider.Learning.SessionXref.FetchAllByActId(sessionId);
            foreach (SessionXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSessionXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='SessionXrefModel' /> instances.
        /// </summary>
        /// <param name="eventProductId">
        ///     The value which identifies the <see cref='SessionXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SessionXrefModel' /> instances that match the specified <paramref name='eventProductId' />.
        /// </returns>
        public IEnumerable<LocalSessionXrefModel> FetchAllByEventProductId(Int32? eventProductId)
        {
            IEnumerable<SessionXrefRecord> recordCollection = this.Provider.DataProvider.Learning.SessionXref.FetchAllByEpId(eventProductId);
            foreach (SessionXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSessionXrefModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:SessionXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SessionXrefModel" /> instance.
        /// </returns>
        Consensus.Learning.ISessionXrefModel ISessionXrefFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SessionXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SessionXrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionXrefModel> ISessionXrefFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SessionXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SessionXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.ISessionXrefModel ISessionXrefFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ISessionXrefFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionXrefModel" /> instances.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref="!:SessionXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionXrefModel" /> instances that match the specified <paramref name="eventId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionXrefModel> ISessionXrefFactory.FetchAllByEventId(System.String eventId)
        {
            return this.FetchAllByEventId(eventId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SessionXrefModel" /> instances.
        /// </summary>
        /// <param name="sessionId">
        ///     The value which identifies the <see cref="!:SessionXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SessionXrefModel" /> instances that match the specified <paramref name="sessionId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionXrefModel> ISessionXrefFactory.FetchAllBySessionId(System.String sessionId)
        {
            return this.FetchAllBySessionId(sessionId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Learning.ISessionXrefModel> ISessionXrefFactory.FetchAllByEventProductId(System.Nullable<System.Int32> eventProductId)
        {
            return this.FetchAllByEventProductId(eventProductId);
        }

        #endregion
    }
}
