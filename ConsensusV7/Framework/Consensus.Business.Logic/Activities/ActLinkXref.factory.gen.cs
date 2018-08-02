using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ActLinkXrefModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalActLinkXrefFactory : LocalFactory<LocalActLinkXrefModel, ActLinkXrefRecord, String>, IActLinkXrefFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ActLinkXrefModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ActLinkXrefModel' /> instance.
        /// </returns>
        public LocalActLinkXrefModel Create()
        {
            return new LocalActLinkXrefModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ActLinkXrefModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ActLinkXrefModel' /> instances.
        /// </returns>
        public IEnumerable<LocalActLinkXrefModel> FetchAll()
        {
            IEnumerable<ActLinkXrefRecord> recordCollection = this.Provider.DataProvider.Activities.ActLinkXref.FetchAll();
            foreach (ActLinkXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalActLinkXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ActLinkXrefModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ActLinkXrefModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ActLinkXrefModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalActLinkXrefModel FetchById(String id)
        {
            ActLinkXrefRecord record = this.Provider.DataProvider.Activities.ActLinkXref.FetchById(id);
            if (record == null)
                return null;
            return new LocalActLinkXrefModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ActLinkXref/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Activities.ActLinkXref.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ActLinkXrefModel' /> instances.
        /// </summary>
        /// <param name="activityId">
        ///     The value which identifies the <see cref='ActLinkXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ActLinkXrefModel' /> instances that match the specified <paramref name='activityId' />.
        /// </returns>
        public IEnumerable<LocalActLinkXrefModel> FetchAllByActivityId(String activityId)
        {
            IEnumerable<ActLinkXrefRecord> recordCollection = this.Provider.DataProvider.Activities.ActLinkXref.FetchAllByActId(activityId);
            foreach (ActLinkXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalActLinkXrefModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ActLinkXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ActLinkXrefModel" /> instance.
        /// </returns>
        Consensus.Activities.IActLinkXrefModel IActLinkXrefFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ActLinkXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ActLinkXrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActLinkXrefModel> IActLinkXrefFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ActLinkXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ActLinkXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActLinkXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Activities.IActLinkXrefModel IActLinkXrefFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IActLinkXrefFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ActLinkXrefModel" /> instances.
        /// </summary>
        /// <param name="activityId">
        ///     The value which identifies the <see cref="!:ActLinkXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ActLinkXrefModel" /> instances that match the specified <paramref name="activityId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IActLinkXrefModel> IActLinkXrefFactory.FetchAllByActivityId(System.String activityId)
        {
            return this.FetchAllByActivityId(activityId);
        }

        #endregion
    }
}
