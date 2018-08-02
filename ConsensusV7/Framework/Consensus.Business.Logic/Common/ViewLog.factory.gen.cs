using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ViewLogModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalViewLogFactory : LocalFactory<LocalViewLogModel, ViewLogRecord, Int32>, IViewLogFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ViewLogModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ViewLogModel' /> instance.
        /// </returns>
        public LocalViewLogModel Create()
        {
            return new LocalViewLogModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ViewLogModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ViewLogModel' /> instances.
        /// </returns>
        public IEnumerable<LocalViewLogModel> FetchAll()
        {
            IEnumerable<ViewLogRecord> recordCollection = this.Provider.DataProvider.Common.ViewLog.FetchAll();
            foreach (ViewLogRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalViewLogModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ViewLogModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ViewLogModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ViewLogModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalViewLogModel FetchById(Int32 id)
        {
            ViewLogRecord record = this.Provider.DataProvider.Common.ViewLog.FetchById(id);
            if (record == null)
                return null;
            return new LocalViewLogModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ViewLog/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Common.ViewLog.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ViewLogModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ViewLogModel" /> instance.
        /// </returns>
        Consensus.Common.IViewLogModel IViewLogFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ViewLogModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ViewLogModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IViewLogModel> IViewLogFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ViewLogModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ViewLogModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ViewLogModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IViewLogModel IViewLogFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IViewLogFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
