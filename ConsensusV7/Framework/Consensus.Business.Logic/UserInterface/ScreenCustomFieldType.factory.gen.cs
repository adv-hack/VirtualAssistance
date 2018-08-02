using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ScreenCustomFieldTypeModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalScreenCustomFieldTypeFactory : LocalFactory<LocalScreenCustomFieldTypeModel, ScreenCustomFieldTypeRecord, String>, IScreenCustomFieldTypeFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ScreenCustomFieldTypeModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ScreenCustomFieldTypeModel' /> instance.
        /// </returns>
        public LocalScreenCustomFieldTypeModel Create()
        {
            return new LocalScreenCustomFieldTypeModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ScreenCustomFieldTypeModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ScreenCustomFieldTypeModel' /> instances.
        /// </returns>
        public IEnumerable<LocalScreenCustomFieldTypeModel> FetchAll()
        {
            IEnumerable<ScreenCustomFieldTypeRecord> recordCollection = this.Provider.DataProvider.UserInterface.ScreenCustomFieldType.FetchAll();
            foreach (ScreenCustomFieldTypeRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalScreenCustomFieldTypeModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ScreenCustomFieldTypeModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ScreenCustomFieldTypeModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ScreenCustomFieldTypeModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalScreenCustomFieldTypeModel FetchById(String id)
        {
            ScreenCustomFieldTypeRecord record = this.Provider.DataProvider.UserInterface.ScreenCustomFieldType.FetchById(id);
            if (record == null)
                return null;
            return new LocalScreenCustomFieldTypeModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ScreenCustomFieldType/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.UserInterface.ScreenCustomFieldType.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ScreenCustomFieldTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenCustomFieldTypeModel" /> instance.
        /// </returns>
        Consensus.UserInterface.IScreenCustomFieldTypeModel IScreenCustomFieldTypeFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenCustomFieldTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenCustomFieldTypeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenCustomFieldTypeModel> IScreenCustomFieldTypeFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenCustomFieldTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenCustomFieldTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.IScreenCustomFieldTypeModel IScreenCustomFieldTypeFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IScreenCustomFieldTypeFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
