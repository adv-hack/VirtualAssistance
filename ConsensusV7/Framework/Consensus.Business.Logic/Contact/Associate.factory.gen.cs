using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="AssociateModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalAssociateFactory : LocalFactory<LocalAssociateModel, AssociatesRecord, Int32>, IAssociateFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='AssociateModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='AssociateModel' /> instance.
        /// </returns>
        public LocalAssociateModel Create()
        {
            return new LocalAssociateModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='AssociateModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='AssociateModel' /> instances.
        /// </returns>
        public IEnumerable<LocalAssociateModel> FetchAll()
        {
            IEnumerable<AssociatesRecord> recordCollection = this.Provider.DataProvider.Contact.Associate.FetchAll();
            foreach (AssociatesRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAssociateModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='AssociateModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='AssociateModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AssociateModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalAssociateModel FetchById(Int32 id)
        {
            AssociatesRecord record = this.Provider.DataProvider.Contact.Associate.FetchById(id);
            if (record == null)
                return null;
            return new LocalAssociateModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Associate/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Contact.Associate.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='AssociateModel' /> instances.
        /// </summary>
        /// <param name="associatedRoleId">
        ///     The value which identifies the <see cref='AssociateModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AssociateModel' /> instances that match the specified <paramref name='associatedRoleId' />.
        /// </returns>
        public IEnumerable<LocalAssociateModel> FetchAllByAssociatedRoleId(String associatedRoleId)
        {
            IEnumerable<AssociatesRecord> recordCollection = this.Provider.DataProvider.Contact.Associate.FetchAllByAssociateId(associatedRoleId);
            foreach (AssociatesRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAssociateModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='AssociateModel' /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref='AssociateModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AssociateModel' /> instances that match the specified <paramref name='roleId' />.
        /// </returns>
        public IEnumerable<LocalAssociateModel> FetchAllByRoleId(String roleId)
        {
            IEnumerable<AssociatesRecord> recordCollection = this.Provider.DataProvider.Contact.Associate.FetchAllByProleId(roleId);
            foreach (AssociatesRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAssociateModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='AssociateModel' /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref='AssociateModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AssociateModel' /> instances that match the specified <paramref name='organisationId' />.
        /// </returns>
        public IEnumerable<LocalAssociateModel> FetchAllByOrganisationId(String organisationId)
        {
            IEnumerable<AssociatesRecord> recordCollection = this.Provider.DataProvider.Contact.Associate.FetchAllByOrgId(organisationId);
            foreach (AssociatesRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAssociateModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:AssociateModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AssociateModel" /> instance.
        /// </returns>
        Consensus.Contact.IAssociateModel IAssociateFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AssociateModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AssociateModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IAssociateModel> IAssociateFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AssociateModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AssociateModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AssociateModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.IAssociateModel IAssociateFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IAssociateFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AssociateModel" /> instances.
        /// </summary>
        /// <param name="associatedRoleId">
        ///     The value which identifies the <see cref="!:AssociateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AssociateModel" /> instances that match the specified <paramref name="associatedRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IAssociateModel> IAssociateFactory.FetchAllByAssociatedRoleId(System.String associatedRoleId)
        {
            return this.FetchAllByAssociatedRoleId(associatedRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AssociateModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:AssociateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AssociateModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IAssociateModel> IAssociateFactory.FetchAllByRoleId(System.String roleId)
        {
            return this.FetchAllByRoleId(roleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AssociateModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:AssociateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AssociateModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IAssociateModel> IAssociateFactory.FetchAllByOrganisationId(System.String organisationId)
        {
            return this.FetchAllByOrganisationId(organisationId);
        }

        #endregion
    }
}
