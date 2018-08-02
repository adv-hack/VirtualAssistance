using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PrepayAccountModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPrepayAccountFactory : LocalFactory<LocalPrepayAccountModel, MasterClubRecord, String>, IPrepayAccountFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='PrepayAccountModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='PrepayAccountModel' /> instance.
        /// </returns>
        public LocalPrepayAccountModel Create()
        {
            return new LocalPrepayAccountModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='PrepayAccountModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='PrepayAccountModel' /> instances.
        /// </returns>
        public IEnumerable<LocalPrepayAccountModel> FetchAll()
        {
            IEnumerable<MasterClubRecord> recordCollection = this.Provider.DataProvider.Finance.PrepayAccount.FetchAll();
            foreach (MasterClubRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPrepayAccountModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='PrepayAccountModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='PrepayAccountModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PrepayAccountModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalPrepayAccountModel FetchById(String id)
        {
            MasterClubRecord record = this.Provider.DataProvider.Finance.PrepayAccount.FetchById(id);
            if (record == null)
                return null;
            return new LocalPrepayAccountModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='PrepayAccount/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Finance.PrepayAccount.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PrepayAccountModel' /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref='PrepayAccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PrepayAccountModel' /> instances that match the specified <paramref name='organisationId' />.
        /// </returns>
        public IEnumerable<LocalPrepayAccountModel> FetchAllByOrganisationId(String organisationId)
        {
            IEnumerable<MasterClubRecord> recordCollection = this.Provider.DataProvider.Finance.PrepayAccount.FetchAllByOrgId(organisationId);
            foreach (MasterClubRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPrepayAccountModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PrepayAccountModel' /> instances.
        /// </summary>
        /// <param name="contactId">
        ///     The value which identifies the <see cref='PrepayAccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PrepayAccountModel' /> instances that match the specified <paramref name='contactId' />.
        /// </returns>
        public IEnumerable<LocalPrepayAccountModel> FetchAllByContactId(String contactId)
        {
            IEnumerable<MasterClubRecord> recordCollection = this.Provider.DataProvider.Finance.PrepayAccount.FetchAllByContact(contactId);
            foreach (MasterClubRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPrepayAccountModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PrepayAccountModel' /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref='PrepayAccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PrepayAccountModel' /> instances that match the specified <paramref name='productId' />.
        /// </returns>
        public IEnumerable<LocalPrepayAccountModel> FetchAllByProductId(String productId)
        {
            IEnumerable<MasterClubRecord> recordCollection = this.Provider.DataProvider.Finance.PrepayAccount.FetchAllByProdId(productId);
            foreach (MasterClubRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPrepayAccountModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PrepayAccountModel' /> instances.
        /// </summary>
        /// <param name="membershipId">
        ///     The value which identifies the <see cref='PrepayAccountModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PrepayAccountModel' /> instances that match the specified <paramref name='membershipId' />.
        /// </returns>
        public IEnumerable<LocalPrepayAccountModel> FetchAllByMembershipId(String membershipId)
        {
            IEnumerable<MasterClubRecord> recordCollection = this.Provider.DataProvider.Finance.PrepayAccount.FetchAllByMepId(membershipId);
            foreach (MasterClubRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPrepayAccountModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:PrepayAccountModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PrepayAccountModel" /> instance.
        /// </returns>
        Consensus.Finance.IPrepayAccountModel IPrepayAccountFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PrepayAccountModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PrepayAccountModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPrepayAccountModel> IPrepayAccountFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PrepayAccountModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PrepayAccountModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrepayAccountModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IPrepayAccountModel IPrepayAccountFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IPrepayAccountFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrepayAccountModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:PrepayAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrepayAccountModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPrepayAccountModel> IPrepayAccountFactory.FetchAllByOrganisationId(System.String organisationId)
        {
            return this.FetchAllByOrganisationId(organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrepayAccountModel" /> instances.
        /// </summary>
        /// <param name="contactId">
        ///     The value which identifies the <see cref="!:PrepayAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrepayAccountModel" /> instances that match the specified <paramref name="contactId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPrepayAccountModel> IPrepayAccountFactory.FetchAllByContactId(System.String contactId)
        {
            return this.FetchAllByContactId(contactId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrepayAccountModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:PrepayAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrepayAccountModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPrepayAccountModel> IPrepayAccountFactory.FetchAllByProductId(System.String productId)
        {
            return this.FetchAllByProductId(productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PrepayAccountModel" /> instances.
        /// </summary>
        /// <param name="membershipId">
        ///     The value which identifies the <see cref="!:PrepayAccountModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PrepayAccountModel" /> instances that match the specified <paramref name="membershipId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPrepayAccountModel> IPrepayAccountFactory.FetchAllByMembershipId(System.String membershipId)
        {
            return this.FetchAllByMembershipId(membershipId);
        }

        #endregion
    }
}
