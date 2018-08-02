using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="Communications_XrefModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCommunications_XrefFactory : LocalFactory<LocalCommunications_XrefModel, CommunicationsXrefRecord, Int64>, ICommunications_XrefFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='Communications_XrefModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='Communications_XrefModel' /> instance.
        /// </returns>
        public LocalCommunications_XrefModel Create()
        {
            return new LocalCommunications_XrefModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='Communications_XrefModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='Communications_XrefModel' /> instances.
        /// </returns>
        public IEnumerable<LocalCommunications_XrefModel> FetchAll()
        {
            IEnumerable<CommunicationsXrefRecord> recordCollection = this.Provider.DataProvider.Contact.Communications_Xref.FetchAll();
            foreach (CommunicationsXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    if (record.TableName == "Person_Role")
                        yield return new LocalCommunicationsRoleModel(this.Provider, record);
                    else
                        yield return new LocalCommunications_XrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='Communications_XrefModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='Communications_XrefModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='Communications_XrefModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalCommunications_XrefModel FetchById(Int64 id)
        {
            CommunicationsXrefRecord record = this.Provider.DataProvider.Contact.Communications_Xref.FetchById(id);
            if (record == null)
                return null;
            if (record.TableName == "Person_Role")
                return new LocalCommunicationsRoleModel(this.Provider, record);
            return new LocalCommunications_XrefModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Communications_Xref/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Contact.Communications_Xref.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='Communications_XrefModel' /> instances.
        /// </summary>
        /// <param name="communicationId">
        ///     The value which identifies the <see cref='Communications_XrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='Communications_XrefModel' /> instances that match the specified <paramref name='communicationId' />.
        /// </returns>
        public IEnumerable<LocalCommunications_XrefModel> FetchAllByCommunicationId(Int64 communicationId)
        {
            IEnumerable<CommunicationsXrefRecord> recordCollection = this.Provider.DataProvider.Contact.Communications_Xref.FetchAllByCommId(communicationId);
            foreach (CommunicationsXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    if (record.TableName == "Person_Role")
                        yield return new LocalCommunicationsRoleModel(this.Provider, record);
                    else
                        yield return new LocalCommunications_XrefModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:Communications_XrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:Communications_XrefModel" /> instance.
        /// </returns>
        Consensus.Contact.ICommunications_XrefModel ICommunications_XrefFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:Communications_XrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:Communications_XrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ICommunications_XrefModel> ICommunications_XrefFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:Communications_XrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:Communications_XrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:Communications_XrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.ICommunications_XrefModel ICommunications_XrefFactory.FetchById(System.Int64 id)
        {
            return this.FetchById(id);
        }

        System.String ICommunications_XrefFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:Communications_XrefModel" /> instances.
        /// </summary>
        /// <param name="communicationId">
        ///     The value which identifies the <see cref="!:Communications_XrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:Communications_XrefModel" /> instances that match the specified <paramref name="communicationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ICommunications_XrefModel> ICommunications_XrefFactory.FetchAllByCommunicationId(System.Int64 communicationId)
        {
            return this.FetchAllByCommunicationId(communicationId);
        }

        #endregion
    }
}
