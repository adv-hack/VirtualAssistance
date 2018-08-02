using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="EventProductModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalEventProductFactory : LocalFactory<LocalEventProductModel, EventProductRecord, Int32>, IEventProductFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='EventProductModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='EventProductModel' /> instance.
        /// </returns>
        public LocalEventProductModel Create()
        {
            return new LocalEventProductModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='EventProductModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='EventProductModel' /> instances.
        /// </returns>
        public IEnumerable<LocalEventProductModel> FetchAll()
        {
            IEnumerable<EventProductRecord> recordCollection = this.Provider.DataProvider.Learning.EventProduct.FetchAll();
            foreach (EventProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='EventProductModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='EventProductModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventProductModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalEventProductModel FetchById(Int32 id)
        {
            EventProductRecord record = this.Provider.DataProvider.Learning.EventProduct.FetchById(id);
            if (record == null)
                return null;
            return new LocalEventProductModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='EventProduct/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Learning.EventProduct.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventProductModel' /> instances.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref='EventProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventProductModel' /> instances that match the specified <paramref name='eventId' />.
        /// </returns>
        public IEnumerable<LocalEventProductModel> FetchAllByEventId(String eventId)
        {
            IEnumerable<EventProductRecord> recordCollection = this.Provider.DataProvider.Learning.EventProduct.FetchAllByEventId(eventId);
            foreach (EventProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventProductModel' /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref='EventProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventProductModel' /> instances that match the specified <paramref name='productId' />.
        /// </returns>
        public IEnumerable<LocalEventProductModel> FetchAllByProductId(String productId)
        {
            IEnumerable<EventProductRecord> recordCollection = this.Provider.DataProvider.Learning.EventProduct.FetchAllByProdId(productId);
            foreach (EventProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='EventProductModel' /> instances.
        /// </summary>
        /// <param name="notesId">
        ///     The value which identifies the <see cref='EventProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='EventProductModel' /> instances that match the specified <paramref name='notesId' />.
        /// </returns>
        public IEnumerable<LocalEventProductModel> FetchAllByNotesId(String notesId)
        {
            IEnumerable<EventProductRecord> recordCollection = this.Provider.DataProvider.Learning.EventProduct.FetchAllByNotes(notesId);
            foreach (EventProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalEventProductModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:EventProductModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:EventProductModel" /> instance.
        /// </returns>
        Consensus.Learning.IEventProductModel IEventProductFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:EventProductModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:EventProductModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventProductModel> IEventProductFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:EventProductModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:EventProductModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventProductModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IEventProductModel IEventProductFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IEventProductFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventProductModel" /> instances.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref="!:EventProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventProductModel" /> instances that match the specified <paramref name="eventId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventProductModel> IEventProductFactory.FetchAllByEventId(System.String eventId)
        {
            return this.FetchAllByEventId(eventId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventProductModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:EventProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventProductModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventProductModel> IEventProductFactory.FetchAllByProductId(System.String productId)
        {
            return this.FetchAllByProductId(productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventProductModel" /> instances.
        /// </summary>
        /// <param name="notesId">
        ///     The value which identifies the <see cref="!:EventProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventProductModel" /> instances that match the specified <paramref name="notesId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IEventProductModel> IEventProductFactory.FetchAllByNotesId(System.String notesId)
        {
            return this.FetchAllByNotesId(notesId);
        }

        #endregion
    }
}
