using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ScreenCustomFieldValueModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalScreenCustomFieldValueFactory : LocalFactory<LocalScreenCustomFieldValueModel, ScreenCustomFieldValueRecord, Int32>, IScreenCustomFieldValueFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ScreenCustomFieldValueModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ScreenCustomFieldValueModel' /> instance.
        /// </returns>
        public LocalScreenCustomFieldValueModel Create()
        {
            return new LocalScreenCustomFieldValueModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ScreenCustomFieldValueModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ScreenCustomFieldValueModel' /> instances.
        /// </returns>
        public IEnumerable<LocalScreenCustomFieldValueModel> FetchAll()
        {
            IEnumerable<ScreenCustomFieldValueRecord> recordCollection = this.Provider.DataProvider.UserInterface.ScreenCustomFieldValue.FetchAll();
            foreach (ScreenCustomFieldValueRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalScreenCustomFieldValueModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ScreenCustomFieldValueModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ScreenCustomFieldValueModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ScreenCustomFieldValueModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalScreenCustomFieldValueModel FetchById(Int32 id)
        {
            ScreenCustomFieldValueRecord record = this.Provider.DataProvider.UserInterface.ScreenCustomFieldValue.FetchById(id);
            if (record == null)
                return null;
            return new LocalScreenCustomFieldValueModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ScreenCustomFieldValue/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.UserInterface.ScreenCustomFieldValue.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ScreenCustomFieldValueModel' /> instances.
        /// </summary>
        /// <param name="cfieldId">
        ///     The value which identifies the <see cref='ScreenCustomFieldValueModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ScreenCustomFieldValueModel' /> instances that match the specified <paramref name='cfieldId' />.
        /// </returns>
        public IEnumerable<LocalScreenCustomFieldValueModel> FetchAllByCfieldId(Int32 cfieldId)
        {
            IEnumerable<ScreenCustomFieldValueRecord> recordCollection = this.Provider.DataProvider.UserInterface.ScreenCustomFieldValue.FetchAllByCfieldId(cfieldId);
            foreach (ScreenCustomFieldValueRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalScreenCustomFieldValueModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        Consensus.UserInterface.IScreenCustomFieldValueModel IScreenCustomFieldValueFactory.FetchByFieldIdAndRecordId(System.Int32 fieldId, System.String recordId)
        {
            return this.FetchByFieldIdAndRecordId(fieldId, recordId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ScreenCustomFieldValueModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenCustomFieldValueModel" /> instance.
        /// </returns>
        Consensus.UserInterface.IScreenCustomFieldValueModel IScreenCustomFieldValueFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenCustomFieldValueModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenCustomFieldValueModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenCustomFieldValueModel> IScreenCustomFieldValueFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenCustomFieldValueModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenCustomFieldValueModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldValueModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.IScreenCustomFieldValueModel IScreenCustomFieldValueFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IScreenCustomFieldValueFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenCustomFieldValueModel" /> instances.
        /// </summary>
        /// <param name="cfieldId">
        ///     The value which identifies the <see cref="!:ScreenCustomFieldValueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldValueModel" /> instances that match the specified <paramref name="cfieldId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenCustomFieldValueModel> IScreenCustomFieldValueFactory.FetchAllByCfieldId(System.Int32 cfieldId)
        {
            return this.FetchAllByCfieldId(cfieldId);
        }

        #endregion
    }
}
