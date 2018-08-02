using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ScreenCustomFieldListitemModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalScreenCustomFieldListitemFactory : LocalFactory<LocalScreenCustomFieldListitemModel, ScreenCustomFieldListitemRecord, Int32>, IScreenCustomFieldListitemFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ScreenCustomFieldListitemModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ScreenCustomFieldListitemModel' /> instance.
        /// </returns>
        public LocalScreenCustomFieldListitemModel Create()
        {
            return new LocalScreenCustomFieldListitemModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ScreenCustomFieldListitemModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ScreenCustomFieldListitemModel' /> instances.
        /// </returns>
        public IEnumerable<LocalScreenCustomFieldListitemModel> FetchAll()
        {
            IEnumerable<ScreenCustomFieldListitemRecord> recordCollection = this.Provider.DataProvider.UserInterface.ScreenCustomFieldListitem.FetchAll();
            foreach (ScreenCustomFieldListitemRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalScreenCustomFieldListitemModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ScreenCustomFieldListitemModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ScreenCustomFieldListitemModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ScreenCustomFieldListitemModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalScreenCustomFieldListitemModel FetchById(Int32 id)
        {
            ScreenCustomFieldListitemRecord record = this.Provider.DataProvider.UserInterface.ScreenCustomFieldListitem.FetchById(id);
            if (record == null)
                return null;
            return new LocalScreenCustomFieldListitemModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ScreenCustomFieldListitem/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.UserInterface.ScreenCustomFieldListitem.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ScreenCustomFieldListitemModel' /> instances.
        /// </summary>
        /// <param name="cfieldId">
        ///     The value which identifies the <see cref='ScreenCustomFieldListitemModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ScreenCustomFieldListitemModel' /> instances that match the specified <paramref name='cfieldId' />.
        /// </returns>
        public IEnumerable<LocalScreenCustomFieldListitemModel> FetchAllByCfieldId(Int32 cfieldId)
        {
            IEnumerable<ScreenCustomFieldListitemRecord> recordCollection = this.Provider.DataProvider.UserInterface.ScreenCustomFieldListitem.FetchAllByCfieldId(cfieldId);
            foreach (ScreenCustomFieldListitemRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalScreenCustomFieldListitemModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ScreenCustomFieldListitemModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenCustomFieldListitemModel" /> instance.
        /// </returns>
        Consensus.UserInterface.IScreenCustomFieldListitemModel IScreenCustomFieldListitemFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenCustomFieldListitemModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenCustomFieldListitemModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenCustomFieldListitemModel> IScreenCustomFieldListitemFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenCustomFieldListitemModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenCustomFieldListitemModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldListitemModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.IScreenCustomFieldListitemModel IScreenCustomFieldListitemFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IScreenCustomFieldListitemFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenCustomFieldListitemModel" /> instances.
        /// </summary>
        /// <param name="cfieldId">
        ///     The value which identifies the <see cref="!:ScreenCustomFieldListitemModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldListitemModel" /> instances that match the specified <paramref name="cfieldId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenCustomFieldListitemModel> IScreenCustomFieldListitemFactory.FetchAllByCfieldId(System.Int32 cfieldId)
        {
            return this.FetchAllByCfieldId(cfieldId);
        }

        #endregion
    }
}
