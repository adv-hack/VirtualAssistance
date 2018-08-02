using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CommunicationsRoleModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCommunicationsRoleFactory : LocalFactory<LocalCommunicationsRoleModel, CommunicationsXrefRecord, Int64>, ICommunicationsRoleFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='CommunicationsRoleModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='CommunicationsRoleModel' /> instance.
        /// </returns>
        public LocalCommunicationsRoleModel Create()
        {
            return new LocalCommunicationsRoleModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='CommunicationsRoleModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='CommunicationsRoleModel' /> instances.
        /// </returns>
        public IEnumerable<LocalCommunicationsRoleModel> FetchAll()
        {
            IEnumerable<CommunicationsXrefRecord> recordCollection = this.Provider.DataProvider.Contact.Communications_Xref.FetchAll();
            foreach (CommunicationsXrefRecord record in recordCollection)
            {
                if (record != null && record.TableName == "Person_Role")
                {
                    yield return new LocalCommunicationsRoleModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='CommunicationsRoleModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='CommunicationsRoleModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CommunicationsRoleModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalCommunicationsRoleModel FetchById(Int64 id)
        {
            CommunicationsXrefRecord record = this.Provider.DataProvider.Contact.Communications_Xref.FetchById(id);
            if (record == null)
                return null;
            return new LocalCommunicationsRoleModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='CommunicationsRole/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Contact.Communications_Xref.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='CommunicationsRoleModel' /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref='CommunicationsRoleModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CommunicationsRoleModel' /> instances that match the specified <paramref name='roleId' />.
        /// </returns>
        public IEnumerable<LocalCommunicationsRoleModel> FetchAllByRoleId(String roleId)
        {
            IEnumerable<CommunicationsXrefRecord> recordCollection = this.Provider.DataProvider.Contact.Communications_Xref.FetchAllByRecordId(roleId);
            foreach (CommunicationsXrefRecord record in recordCollection)
            {
                if (record != null && record.TableName == "Person_Role")
                {
                    yield return new LocalCommunicationsRoleModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='CommunicationsRoleModel' /> instances.
        /// </summary>
        /// <param name="communicationId">
        ///     The value which identifies the <see cref='CommunicationsRoleModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='CommunicationsRoleModel' /> instances that match the specified <paramref name='communicationId' />.
        /// </returns>
        public IEnumerable<LocalCommunicationsRoleModel> FetchAllByCommunicationId(Int64 communicationId)
        {
            IEnumerable<CommunicationsXrefRecord> recordCollection = this.Provider.DataProvider.Contact.Communications_Xref.FetchAllByCommId(communicationId);
            foreach (CommunicationsXrefRecord record in recordCollection)
            {
                if (record != null && record.TableName == "Person_Role")
                {
                    yield return new LocalCommunicationsRoleModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:CommunicationsRoleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CommunicationsRoleModel" /> instance.
        /// </returns>
        Consensus.Contact.ICommunicationsRoleModel ICommunicationsRoleFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CommunicationsRoleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CommunicationsRoleModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ICommunicationsRoleModel> ICommunicationsRoleFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CommunicationsRoleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CommunicationsRoleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommunicationsRoleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.ICommunicationsRoleModel ICommunicationsRoleFactory.FetchById(System.Int64 id)
        {
            return this.FetchById(id);
        }

        System.String ICommunicationsRoleFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommunicationsRoleModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:CommunicationsRoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommunicationsRoleModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ICommunicationsRoleModel> ICommunicationsRoleFactory.FetchAllByRoleId(System.String roleId)
        {
            return this.FetchAllByRoleId(roleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CommunicationsRoleModel" /> instances.
        /// </summary>
        /// <param name="communicationId">
        ///     The value which identifies the <see cref="!:CommunicationsRoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommunicationsRoleModel" /> instances that match the specified <paramref name="communicationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ICommunicationsRoleModel> ICommunicationsRoleFactory.FetchAllByCommunicationId(System.Int64 communicationId)
        {
            return this.FetchAllByCommunicationId(communicationId);
        }

        #endregion
    }
}
