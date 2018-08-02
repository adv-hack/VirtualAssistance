using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ScreenObjectDisplayModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalScreenObjectDisplayFactory : LocalFactory<LocalScreenObjectDisplayModel, ScreenObjectDisplayRecord, Int32>, IScreenObjectDisplayFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ScreenObjectDisplayModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ScreenObjectDisplayModel' /> instance.
        /// </returns>
        public LocalScreenObjectDisplayModel Create()
        {
            return new LocalScreenObjectDisplayModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ScreenObjectDisplayModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ScreenObjectDisplayModel' /> instances.
        /// </returns>
        public IEnumerable<LocalScreenObjectDisplayModel> FetchAll()
        {
            IEnumerable<ScreenObjectDisplayRecord> recordCollection = this.Provider.DataProvider.UserInterface.ScreenObjectDisplay.FetchAll();
            foreach (ScreenObjectDisplayRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalScreenObjectDisplayModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ScreenObjectDisplayModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ScreenObjectDisplayModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ScreenObjectDisplayModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalScreenObjectDisplayModel FetchById(Int32 id)
        {
            ScreenObjectDisplayRecord record = this.Provider.DataProvider.UserInterface.ScreenObjectDisplay.FetchById(id);
            if (record == null)
                return null;
            return new LocalScreenObjectDisplayModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ScreenObjectDisplay/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.UserInterface.ScreenObjectDisplay.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ScreenObjectDisplayModel' /> instances.
        /// </summary>
        /// <param name="screenObjectId">
        ///     The value which identifies the <see cref='ScreenObjectDisplayModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ScreenObjectDisplayModel' /> instances that match the specified <paramref name='screenObjectId' />.
        /// </returns>
        public IEnumerable<LocalScreenObjectDisplayModel> FetchAllByScreenObjectId(Int32 screenObjectId)
        {
            IEnumerable<ScreenObjectDisplayRecord> recordCollection = this.Provider.DataProvider.UserInterface.ScreenObjectDisplay.FetchAllByObjId(screenObjectId);
            foreach (ScreenObjectDisplayRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalScreenObjectDisplayModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ScreenObjectDisplayModel' /> instances.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref='ScreenObjectDisplayModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ScreenObjectDisplayModel' /> instances that match the specified <paramref name='principalId' />.
        /// </returns>
        public IEnumerable<LocalScreenObjectDisplayModel> FetchAllByPrincipalId(Int32 principalId)
        {
            IEnumerable<ScreenObjectDisplayRecord> recordCollection = this.Provider.DataProvider.UserInterface.ScreenObjectDisplay.FetchAllByPrincipalId(principalId);
            foreach (ScreenObjectDisplayRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalScreenObjectDisplayModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ScreenObjectDisplayModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenObjectDisplayModel" /> instance.
        /// </returns>
        Consensus.UserInterface.IScreenObjectDisplayModel IScreenObjectDisplayFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenObjectDisplayModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenObjectDisplayModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenObjectDisplayModel> IScreenObjectDisplayFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenObjectDisplayModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenObjectDisplayModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectDisplayModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.IScreenObjectDisplayModel IScreenObjectDisplayFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IScreenObjectDisplayFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenObjectDisplayModel" /> instances.
        /// </summary>
        /// <param name="screenObjectId">
        ///     The value which identifies the <see cref="!:ScreenObjectDisplayModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectDisplayModel" /> instances that match the specified <paramref name="screenObjectId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenObjectDisplayModel> IScreenObjectDisplayFactory.FetchAllByScreenObjectId(System.Int32 screenObjectId)
        {
            return this.FetchAllByScreenObjectId(screenObjectId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenObjectDisplayModel" /> instances.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref="!:ScreenObjectDisplayModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectDisplayModel" /> instances that match the specified <paramref name="principalId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenObjectDisplayModel> IScreenObjectDisplayFactory.FetchAllByPrincipalId(System.Int32 principalId)
        {
            return this.FetchAllByPrincipalId(principalId);
        }

        #endregion
    }
}
