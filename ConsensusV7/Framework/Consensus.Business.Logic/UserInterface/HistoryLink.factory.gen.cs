using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="HistoryLinkModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalHistoryLinkFactory : LocalFactory<LocalHistoryLinkModel, HistorylinkRecord, Int32>, IHistoryLinkFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='HistoryLinkModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='HistoryLinkModel' /> instance.
        /// </returns>
        public LocalHistoryLinkModel Create()
        {
            return new LocalHistoryLinkModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='HistoryLinkModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='HistoryLinkModel' /> instances.
        /// </returns>
        public IEnumerable<LocalHistoryLinkModel> FetchAll()
        {
            IEnumerable<HistorylinkRecord> recordCollection = this.Provider.DataProvider.UserInterface.HistoryLink.FetchAll();
            foreach (HistorylinkRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalHistoryLinkModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='HistoryLinkModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='HistoryLinkModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='HistoryLinkModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalHistoryLinkModel FetchById(Int32 id)
        {
            HistorylinkRecord record = this.Provider.DataProvider.UserInterface.HistoryLink.FetchById(id);
            if (record == null)
                return null;
            return new LocalHistoryLinkModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='HistoryLink/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.UserInterface.HistoryLink.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='HistoryLinkModel' /> instances.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref='HistoryLinkModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='HistoryLinkModel' /> instances that match the specified <paramref name='userId' />.
        /// </returns>
        public IEnumerable<LocalHistoryLinkModel> FetchAllByUserId(Int32 userId)
        {
            IEnumerable<HistorylinkRecord> recordCollection = this.Provider.DataProvider.UserInterface.HistoryLink.FetchAllByUserId(userId);
            foreach (HistorylinkRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalHistoryLinkModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.IHistoryLinkModel IHistoryLinkFactory.FetchByUserIDAndURL(System.Int32 userId, System.String URL)
        {
            return this.FetchByUserIDAndURL(userId, URL);
        }

        /// <summary>
        ///     Creates a new <see cref="!:HistoryLinkModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:HistoryLinkModel" /> instance.
        /// </returns>
        Consensus.UserInterface.IHistoryLinkModel IHistoryLinkFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:HistoryLinkModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:HistoryLinkModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IHistoryLinkModel> IHistoryLinkFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:HistoryLinkModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:HistoryLinkModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HistoryLinkModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.IHistoryLinkModel IHistoryLinkFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IHistoryLinkFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HistoryLinkModel" /> instances.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:HistoryLinkModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HistoryLinkModel" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IHistoryLinkModel> IHistoryLinkFactory.FetchAllByUserId(System.Int32 userId)
        {
            return this.FetchAllByUserId(userId);
        }

        #endregion
    }
}
