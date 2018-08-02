using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ScreenObjectColumnModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalScreenObjectColumnFactory : LocalFactory<LocalScreenObjectColumnModel, ScreenObjectColumnRecord, Int32>, IScreenObjectColumnFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ScreenObjectColumnModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ScreenObjectColumnModel' /> instance.
        /// </returns>
        public LocalScreenObjectColumnModel Create()
        {
            return new LocalScreenObjectColumnModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ScreenObjectColumnModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ScreenObjectColumnModel' /> instances.
        /// </returns>
        public IEnumerable<LocalScreenObjectColumnModel> FetchAll()
        {
            IEnumerable<ScreenObjectColumnRecord> recordCollection = this.Provider.DataProvider.UserInterface.ScreenObjectColumn.FetchAll();
            foreach (ScreenObjectColumnRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalScreenObjectColumnModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ScreenObjectColumnModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ScreenObjectColumnModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ScreenObjectColumnModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalScreenObjectColumnModel FetchById(Int32 id)
        {
            ScreenObjectColumnRecord record = this.Provider.DataProvider.UserInterface.ScreenObjectColumn.FetchById(id);
            if (record == null)
                return null;
            return new LocalScreenObjectColumnModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ScreenObjectColumn/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.UserInterface.ScreenObjectColumn.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ScreenObjectColumnModel' /> instances.
        /// </summary>
        /// <param name="screenObjectId">
        ///     The value which identifies the <see cref='ScreenObjectColumnModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ScreenObjectColumnModel' /> instances that match the specified <paramref name='screenObjectId' />.
        /// </returns>
        public IEnumerable<LocalScreenObjectColumnModel> FetchAllByScreenObjectId(Int32 screenObjectId)
        {
            IEnumerable<ScreenObjectColumnRecord> recordCollection = this.Provider.DataProvider.UserInterface.ScreenObjectColumn.FetchAllByObjId(screenObjectId);
            foreach (ScreenObjectColumnRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalScreenObjectColumnModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ScreenObjectColumnModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenObjectColumnModel" /> instance.
        /// </returns>
        Consensus.UserInterface.IScreenObjectColumnModel IScreenObjectColumnFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenObjectColumnModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenObjectColumnModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenObjectColumnModel> IScreenObjectColumnFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenObjectColumnModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenObjectColumnModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectColumnModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.IScreenObjectColumnModel IScreenObjectColumnFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IScreenObjectColumnFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenObjectColumnModel" /> instances.
        /// </summary>
        /// <param name="screenObjectId">
        ///     The value which identifies the <see cref="!:ScreenObjectColumnModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectColumnModel" /> instances that match the specified <paramref name="screenObjectId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenObjectColumnModel> IScreenObjectColumnFactory.FetchAllByScreenObjectId(System.Int32 screenObjectId)
        {
            return this.FetchAllByScreenObjectId(screenObjectId);
        }

        #endregion
    }
}
