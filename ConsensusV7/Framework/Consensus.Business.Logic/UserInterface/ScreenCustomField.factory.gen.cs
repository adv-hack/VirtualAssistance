using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ScreenCustomFieldModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalScreenCustomFieldFactory : LocalFactory<LocalScreenCustomFieldModel, ScreenCustomFieldRecord, Int32>, IScreenCustomFieldFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ScreenCustomFieldModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ScreenCustomFieldModel' /> instance.
        /// </returns>
        public LocalScreenCustomFieldModel Create()
        {
            return new LocalScreenCustomFieldModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ScreenCustomFieldModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ScreenCustomFieldModel' /> instances.
        /// </returns>
        public IEnumerable<LocalScreenCustomFieldModel> FetchAll()
        {
            IEnumerable<ScreenCustomFieldRecord> recordCollection = this.Provider.DataProvider.UserInterface.ScreenCustomField.FetchAll();
            foreach (ScreenCustomFieldRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalScreenCustomFieldModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ScreenCustomFieldModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ScreenCustomFieldModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ScreenCustomFieldModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalScreenCustomFieldModel FetchById(Int32 id)
        {
            ScreenCustomFieldRecord record = this.Provider.DataProvider.UserInterface.ScreenCustomField.FetchById(id);
            if (record == null)
                return null;
            return new LocalScreenCustomFieldModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ScreenCustomField/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.UserInterface.ScreenCustomField.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ScreenCustomFieldModel' /> instances.
        /// </summary>
        /// <param name="cftypeId">
        ///     The value which identifies the <see cref='ScreenCustomFieldModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ScreenCustomFieldModel' /> instances that match the specified <paramref name='cftypeId' />.
        /// </returns>
        public IEnumerable<LocalScreenCustomFieldModel> FetchAllByCftypeId(String cftypeId)
        {
            IEnumerable<ScreenCustomFieldRecord> recordCollection = this.Provider.DataProvider.UserInterface.ScreenCustomField.FetchAllByCftypeId(cftypeId);
            foreach (ScreenCustomFieldRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalScreenCustomFieldModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Fetch the custom fields for a page.
        /// </summary>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenCustomFieldModel> IScreenCustomFieldFactory.FetchAllByPage(System.String page)
        {
            return this.FetchAllByPage(page);
        }

        /// <summary>
        ///     Updates the page configuration.
        /// </summary>
        void IScreenCustomFieldFactory.Update(System.Collections.ArrayList customFields)
        {
            this.Update(customFields);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ScreenCustomFieldModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenCustomFieldModel" /> instance.
        /// </returns>
        Consensus.UserInterface.IScreenCustomFieldModel IScreenCustomFieldFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenCustomFieldModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenCustomFieldModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenCustomFieldModel> IScreenCustomFieldFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenCustomFieldModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenCustomFieldModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.IScreenCustomFieldModel IScreenCustomFieldFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IScreenCustomFieldFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenCustomFieldModel" /> instances.
        /// </summary>
        /// <param name="cftypeId">
        ///     The value which identifies the <see cref="!:ScreenCustomFieldModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldModel" /> instances that match the specified <paramref name="cftypeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenCustomFieldModel> IScreenCustomFieldFactory.FetchAllByCftypeId(System.String cftypeId)
        {
            return this.FetchAllByCftypeId(cftypeId);
        }

        #endregion
    }
}
