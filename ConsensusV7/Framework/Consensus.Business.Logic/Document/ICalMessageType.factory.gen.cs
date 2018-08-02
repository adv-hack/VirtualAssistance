using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ICalMessageTypeModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalICalMessageTypeFactory : LocalFactory<LocalICalMessageTypeModel, IcalmessagetypeRecord, Int32>, IICalMessageTypeFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ICalMessageTypeModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ICalMessageTypeModel' /> instance.
        /// </returns>
        public LocalICalMessageTypeModel Create()
        {
            return new LocalICalMessageTypeModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ICalMessageTypeModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ICalMessageTypeModel' /> instances.
        /// </returns>
        public IEnumerable<LocalICalMessageTypeModel> FetchAll()
        {
            IEnumerable<IcalmessagetypeRecord> recordCollection = this.Provider.DataProvider.Document.ICalMessageType.FetchAll();
            foreach (IcalmessagetypeRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalICalMessageTypeModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ICalMessageTypeModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ICalMessageTypeModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ICalMessageTypeModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalICalMessageTypeModel FetchById(Int32 id)
        {
            IcalmessagetypeRecord record = this.Provider.DataProvider.Document.ICalMessageType.FetchById(id);
            if (record == null)
                return null;
            return new LocalICalMessageTypeModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ICalMessageType/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Document.ICalMessageType.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ICalMessageTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ICalMessageTypeModel" /> instance.
        /// </returns>
        Consensus.Document.IICalMessageTypeModel IICalMessageTypeFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ICalMessageTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ICalMessageTypeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IICalMessageTypeModel> IICalMessageTypeFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ICalMessageTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ICalMessageTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ICalMessageTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.IICalMessageTypeModel IICalMessageTypeFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IICalMessageTypeFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
