using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProductMembershipModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProductMembershipFactory : LocalFactory<LocalProductMembershipModel, ProductRecord, String>, IProductMembershipFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ProductMembershipModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ProductMembershipModel' /> instance.
        /// </returns>
        public LocalProductMembershipModel Create()
        {
            return new LocalProductMembershipModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ProductMembershipModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ProductMembershipModel' /> instances.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAll()
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAll();
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ProductMembershipModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ProductMembershipModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalProductMembershipModel FetchById(String id)
        {
            ProductRecord record = this.Provider.DataProvider.Learning.Product.FetchById(id);
            if (record == null)
                return null;
            return new LocalProductMembershipModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ProductMembership/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Learning.Product.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="prodDescripId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='prodDescripId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByProdDescripId(String prodDescripId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByDescrip(prodDescripId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="prodContentId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='prodContentId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByProdContentId(String prodContentId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByText1(prodContentId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="prodPrereqId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='prodPrereqId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByProdPrereqId(String prodPrereqId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByText2(prodPrereqId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="prodObjectiveId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='prodObjectiveId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByProdObjectiveId(String prodObjectiveId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByText3(prodObjectiveId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='proleIdId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByProleIdId(String proleIdId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByProleId(proleIdId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="productManagerId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='productManagerId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByProductManagerId(String productManagerId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByManProleId(productManagerId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="bookingTermsId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='bookingTermsId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByBookingTermsId(String bookingTermsId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByBktId(bookingTermsId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='locationId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByLocationId(String locationId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByLocId(locationId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="joiningPackId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='joiningPackId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByJoiningPackId(String joiningPackId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByMsNew(joiningPackId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="remind1PackId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='remind1PackId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByRemind1PackId(String remind1PackId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByMsRemind1(remind1PackId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="remind2PackId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='remind2PackId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByRemind2PackId(String remind2PackId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByMsRemind2(remind2PackId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="renewalPackId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='renewalPackId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByRenewalPackId(String renewalPackId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByMsRenew(renewalPackId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="lapsedPackId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='lapsedPackId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByLapsedPackId(String lapsedPackId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByMsLapsed(lapsedPackId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="cancelPackId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='cancelPackId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByCancelPackId(String cancelPackId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByMsCancel(cancelPackId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="authorPersonId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='authorPersonId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByAuthorPersonId(String authorPersonId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByAuthPnId(authorPersonId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="remind3PackId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='remind3PackId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByRemind3PackId(String remind3PackId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByMsRemind3(remind3PackId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="renewedPackId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='renewedPackId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByRenewedPackId(String renewedPackId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByMsRenewed(renewedPackId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="appPackId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='appPackId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByAppPackId(String appPackId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByMsApp(appPackId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="offerPackId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='offerPackId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByOfferPackId(String offerPackId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByMsOff(offerPackId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="venueId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='venueId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByVenueId(String venueId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByOrgId(venueId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="paymentScheduleId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='paymentScheduleId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByPaymentScheduleId(Int32? paymentScheduleId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByPshId(paymentScheduleId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMembershipModel' /> instances.
        /// </summary>
        /// <param name="productTrainingRulesId">
        ///     The value which identifies the <see cref='ProductMembershipModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMembershipModel' /> instances that match the specified <paramref name='productTrainingRulesId' />.
        /// </returns>
        public IEnumerable<LocalProductMembershipModel> FetchAllByProductTrainingRulesId(String productTrainingRulesId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByTrnRulesTxt(productTrainingRulesId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 10)
                {
                    yield return new LocalProductMembershipModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ProductMembershipModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProductMembershipModel" /> instance.
        /// </returns>
        Consensus.Learning.IProductMembershipModel IProductMembershipFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProductMembershipModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProductMembershipModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProductMembershipModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IProductMembershipModel IProductMembershipFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IProductMembershipFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="prodDescripId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="prodDescripId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByProdDescripId(System.String prodDescripId)
        {
            return this.FetchAllByProdDescripId(prodDescripId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="prodContentId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="prodContentId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByProdContentId(System.String prodContentId)
        {
            return this.FetchAllByProdContentId(prodContentId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="prodPrereqId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="prodPrereqId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByProdPrereqId(System.String prodPrereqId)
        {
            return this.FetchAllByProdPrereqId(prodPrereqId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="prodObjectiveId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="prodObjectiveId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByProdObjectiveId(System.String prodObjectiveId)
        {
            return this.FetchAllByProdObjectiveId(prodObjectiveId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="proleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByProleIdId(System.String proleIdId)
        {
            return this.FetchAllByProleIdId(proleIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="productManagerId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="productManagerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByProductManagerId(System.String productManagerId)
        {
            return this.FetchAllByProductManagerId(productManagerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="bookingTermsId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="bookingTermsId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByBookingTermsId(System.String bookingTermsId)
        {
            return this.FetchAllByBookingTermsId(bookingTermsId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="locationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByLocationId(System.String locationId)
        {
            return this.FetchAllByLocationId(locationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="joiningPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="joiningPackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByJoiningPackId(System.String joiningPackId)
        {
            return this.FetchAllByJoiningPackId(joiningPackId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="remind1PackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="remind1PackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByRemind1PackId(System.String remind1PackId)
        {
            return this.FetchAllByRemind1PackId(remind1PackId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="remind2PackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="remind2PackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByRemind2PackId(System.String remind2PackId)
        {
            return this.FetchAllByRemind2PackId(remind2PackId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="renewalPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="renewalPackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByRenewalPackId(System.String renewalPackId)
        {
            return this.FetchAllByRenewalPackId(renewalPackId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="lapsedPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="lapsedPackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByLapsedPackId(System.String lapsedPackId)
        {
            return this.FetchAllByLapsedPackId(lapsedPackId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="cancelPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="cancelPackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByCancelPackId(System.String cancelPackId)
        {
            return this.FetchAllByCancelPackId(cancelPackId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="authorPersonId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="authorPersonId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByAuthorPersonId(System.String authorPersonId)
        {
            return this.FetchAllByAuthorPersonId(authorPersonId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="remind3PackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="remind3PackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByRemind3PackId(System.String remind3PackId)
        {
            return this.FetchAllByRemind3PackId(remind3PackId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="renewedPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="renewedPackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByRenewedPackId(System.String renewedPackId)
        {
            return this.FetchAllByRenewedPackId(renewedPackId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="appPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="appPackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByAppPackId(System.String appPackId)
        {
            return this.FetchAllByAppPackId(appPackId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="offerPackId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="offerPackId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByOfferPackId(System.String offerPackId)
        {
            return this.FetchAllByOfferPackId(offerPackId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="venueId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="venueId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByVenueId(System.String venueId)
        {
            return this.FetchAllByVenueId(venueId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByPaymentScheduleId(System.Nullable<System.Int32> paymentScheduleId)
        {
            return this.FetchAllByPaymentScheduleId(paymentScheduleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMembershipModel" /> instances.
        /// </summary>
        /// <param name="productTrainingRulesId">
        ///     The value which identifies the <see cref="!:ProductMembershipModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMembershipModel" /> instances that match the specified <paramref name="productTrainingRulesId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMembershipModel> IProductMembershipFactory.FetchAllByProductTrainingRulesId(System.String productTrainingRulesId)
        {
            return this.FetchAllByProductTrainingRulesId(productTrainingRulesId);
        }

        #endregion
    }
}
