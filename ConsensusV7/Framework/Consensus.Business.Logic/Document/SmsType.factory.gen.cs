using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SmsTypeModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSmsTypeFactory : LocalFactory<LocalSmsTypeModel, SmsTypeRecord, Int32>, ISmsTypeFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='SmsTypeModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='SmsTypeModel' /> instance.
        /// </returns>
        public LocalSmsTypeModel Create()
        {
            return new LocalSmsTypeModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='SmsTypeModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='SmsTypeModel' /> instances.
        /// </returns>
        public IEnumerable<LocalSmsTypeModel> FetchAll()
        {
            IEnumerable<SmsTypeRecord> recordCollection = this.Provider.DataProvider.Document.SmsType.FetchAll();
            foreach (SmsTypeRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalSmsTypeModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='SmsTypeModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='SmsTypeModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='SmsTypeModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalSmsTypeModel FetchById(Int32 id)
        {
            SmsTypeRecord record = this.Provider.DataProvider.Document.SmsType.FetchById(id);
            if (record == null)
                return null;
            return new LocalSmsTypeModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='SmsType/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Document.SmsType.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:SmsTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SmsTypeModel" /> instance.
        /// </returns>
        Consensus.Document.ISmsTypeModel ISmsTypeFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SmsTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SmsTypeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ISmsTypeModel> ISmsTypeFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SmsTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SmsTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SmsTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.ISmsTypeModel ISmsTypeFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String ISmsTypeFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
