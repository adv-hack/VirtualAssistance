using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ScreenObjectEntryModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalScreenObjectEntryFactory : LocalFactory<LocalScreenObjectEntryModel, ScreenObjectEntryRecord, Int32>, IScreenObjectEntryFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ScreenObjectEntryModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ScreenObjectEntryModel' /> instance.
        /// </returns>
        public LocalScreenObjectEntryModel Create()
        {
            return new LocalScreenObjectEntryModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ScreenObjectEntryModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ScreenObjectEntryModel' /> instances.
        /// </returns>
        public IEnumerable<LocalScreenObjectEntryModel> FetchAll()
        {
            IEnumerable<ScreenObjectEntryRecord> recordCollection = this.Provider.DataProvider.UserInterface.ScreenObjectEntry.FetchAll();
            foreach (ScreenObjectEntryRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalScreenObjectEntryModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ScreenObjectEntryModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ScreenObjectEntryModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ScreenObjectEntryModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalScreenObjectEntryModel FetchById(Int32 id)
        {
            ScreenObjectEntryRecord record = this.Provider.DataProvider.UserInterface.ScreenObjectEntry.FetchById(id);
            if (record == null)
                return null;
            return new LocalScreenObjectEntryModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ScreenObjectEntry/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.UserInterface.ScreenObjectEntry.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ScreenObjectEntryModel' /> instances.
        /// </summary>
        /// <param name="screenObjectId">
        ///     The value which identifies the <see cref='ScreenObjectEntryModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ScreenObjectEntryModel' /> instances that match the specified <paramref name='screenObjectId' />.
        /// </returns>
        public IEnumerable<LocalScreenObjectEntryModel> FetchAllByScreenObjectId(Int32 screenObjectId)
        {
            IEnumerable<ScreenObjectEntryRecord> recordCollection = this.Provider.DataProvider.UserInterface.ScreenObjectEntry.FetchAllByObjId(screenObjectId);
            foreach (ScreenObjectEntryRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalScreenObjectEntryModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ScreenObjectEntryModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenObjectEntryModel" /> instance.
        /// </returns>
        Consensus.UserInterface.IScreenObjectEntryModel IScreenObjectEntryFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenObjectEntryModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenObjectEntryModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenObjectEntryModel> IScreenObjectEntryFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenObjectEntryModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenObjectEntryModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectEntryModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.IScreenObjectEntryModel IScreenObjectEntryFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IScreenObjectEntryFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenObjectEntryModel" /> instances.
        /// </summary>
        /// <param name="screenObjectId">
        ///     The value which identifies the <see cref="!:ScreenObjectEntryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectEntryModel" /> instances that match the specified <paramref name="screenObjectId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenObjectEntryModel> IScreenObjectEntryFactory.FetchAllByScreenObjectId(System.Int32 screenObjectId)
        {
            return this.FetchAllByScreenObjectId(screenObjectId);
        }

        #endregion
    }
}
