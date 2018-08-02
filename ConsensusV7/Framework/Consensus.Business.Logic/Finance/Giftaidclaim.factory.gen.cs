using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="GiftaidclaimModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalGiftaidclaimFactory : LocalFactory<LocalGiftaidclaimModel, GiftaidclaimRecord, Int32>, IGiftaidclaimFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='GiftaidclaimModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='GiftaidclaimModel' /> instance.
        /// </returns>
        public LocalGiftaidclaimModel Create()
        {
            return new LocalGiftaidclaimModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='GiftaidclaimModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='GiftaidclaimModel' /> instances.
        /// </returns>
        public IEnumerable<LocalGiftaidclaimModel> FetchAll()
        {
            IEnumerable<GiftaidclaimRecord> recordCollection = this.Provider.DataProvider.Finance.Giftaidclaim.FetchAll();
            foreach (GiftaidclaimRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalGiftaidclaimModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='GiftaidclaimModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='GiftaidclaimModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='GiftaidclaimModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalGiftaidclaimModel FetchById(Int32 id)
        {
            GiftaidclaimRecord record = this.Provider.DataProvider.Finance.Giftaidclaim.FetchById(id);
            if (record == null)
                return null;
            return new LocalGiftaidclaimModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Giftaidclaim/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Finance.Giftaidclaim.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='GiftaidclaimModel' /> instances.
        /// </summary>
        /// <param name="submitterId">
        ///     The value which identifies the <see cref='GiftaidclaimModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='GiftaidclaimModel' /> instances that match the specified <paramref name='submitterId' />.
        /// </returns>
        public IEnumerable<LocalGiftaidclaimModel> FetchAllBySubmitterId(String submitterId)
        {
            IEnumerable<GiftaidclaimRecord> recordCollection = this.Provider.DataProvider.Finance.Giftaidclaim.FetchAllBySubmitterProleId(submitterId);
            foreach (GiftaidclaimRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalGiftaidclaimModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='GiftaidclaimModel' /> instances.
        /// </summary>
        /// <param name="trusteeId">
        ///     The value which identifies the <see cref='GiftaidclaimModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='GiftaidclaimModel' /> instances that match the specified <paramref name='trusteeId' />.
        /// </returns>
        public IEnumerable<LocalGiftaidclaimModel> FetchAllByTrusteeId(String trusteeId)
        {
            IEnumerable<GiftaidclaimRecord> recordCollection = this.Provider.DataProvider.Finance.Giftaidclaim.FetchAllByTrusteeProleId(trusteeId);
            foreach (GiftaidclaimRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalGiftaidclaimModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='GiftaidclaimModel' /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref='GiftaidclaimModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='GiftaidclaimModel' /> instances that match the specified <paramref name='organisationId' />.
        /// </returns>
        public IEnumerable<LocalGiftaidclaimModel> FetchAllByOrganisationId(String organisationId)
        {
            IEnumerable<GiftaidclaimRecord> recordCollection = this.Provider.DataProvider.Finance.Giftaidclaim.FetchAllByOrgId(organisationId);
            foreach (GiftaidclaimRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalGiftaidclaimModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='GiftaidclaimModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='GiftaidclaimModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='GiftaidclaimModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalGiftaidclaimModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<GiftaidclaimRecord> recordCollection = this.Provider.DataProvider.Finance.Giftaidclaim.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (GiftaidclaimRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalGiftaidclaimModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:GiftaidclaimModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:GiftaidclaimModel" /> instance.
        /// </returns>
        Consensus.Finance.IGiftaidclaimModel IGiftaidclaimFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:GiftaidclaimModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:GiftaidclaimModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IGiftaidclaimModel> IGiftaidclaimFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GiftaidclaimModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:GiftaidclaimModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidclaimModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IGiftaidclaimModel IGiftaidclaimFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IGiftaidclaimFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:GiftaidclaimModel" /> instances.
        /// </summary>
        /// <param name="submitterId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidclaimModel" /> instances that match the specified <paramref name="submitterId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IGiftaidclaimModel> IGiftaidclaimFactory.FetchAllBySubmitterId(System.String submitterId)
        {
            return this.FetchAllBySubmitterId(submitterId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:GiftaidclaimModel" /> instances.
        /// </summary>
        /// <param name="trusteeId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidclaimModel" /> instances that match the specified <paramref name="trusteeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IGiftaidclaimModel> IGiftaidclaimFactory.FetchAllByTrusteeId(System.String trusteeId)
        {
            return this.FetchAllByTrusteeId(trusteeId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:GiftaidclaimModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidclaimModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IGiftaidclaimModel> IGiftaidclaimFactory.FetchAllByOrganisationId(System.String organisationId)
        {
            return this.FetchAllByOrganisationId(organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:GiftaidclaimModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:GiftaidclaimModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidclaimModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IGiftaidclaimModel> IGiftaidclaimFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        #endregion
    }
}
