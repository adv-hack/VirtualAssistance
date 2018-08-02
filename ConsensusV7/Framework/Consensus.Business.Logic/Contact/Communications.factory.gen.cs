using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CommunicationsModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCommunicationsFactory : LocalFactory<LocalCommunicationsModel, CommunicationsRecord, Int64>, ICommunicationsFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='CommunicationsModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='CommunicationsModel' /> instance.
        /// </returns>
        public LocalCommunicationsModel Create()
        {
            return new LocalCommunicationsModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='CommunicationsModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='CommunicationsModel' /> instances.
        /// </returns>
        public IEnumerable<LocalCommunicationsModel> FetchAll()
        {
            IEnumerable<CommunicationsRecord> recordCollection = this.Provider.DataProvider.Contact.Communications.FetchAll();
            foreach (CommunicationsRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalCommunicationsModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='CommunicationsModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='CommunicationsModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CommunicationsModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalCommunicationsModel FetchById(Int64 id)
        {
            CommunicationsRecord record = this.Provider.DataProvider.Contact.Communications.FetchById(id);
            if (record == null)
                return null;
            return new LocalCommunicationsModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Communications/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Contact.Communications.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:CommunicationsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CommunicationsModel" /> instance.
        /// </returns>
        Consensus.Contact.ICommunicationsModel ICommunicationsFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CommunicationsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CommunicationsModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ICommunicationsModel> ICommunicationsFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CommunicationsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CommunicationsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommunicationsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.ICommunicationsModel ICommunicationsFactory.FetchById(System.Int64 id)
        {
            return this.FetchById(id);
        }

        System.String ICommunicationsFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
