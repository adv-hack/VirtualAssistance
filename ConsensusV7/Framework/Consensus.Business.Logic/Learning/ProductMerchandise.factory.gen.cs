using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProductMerchandiseModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProductMerchandiseFactory : LocalFactory<LocalProductMerchandiseModel, ProductRecord, String>, IProductMerchandiseFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ProductMerchandiseModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ProductMerchandiseModel' /> instance.
        /// </returns>
        public LocalProductMerchandiseModel Create()
        {
            return new LocalProductMerchandiseModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ProductMerchandiseModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ProductMerchandiseModel' /> instances.
        /// </returns>
        public IEnumerable<LocalProductMerchandiseModel> FetchAll()
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAll();
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProductMerchandiseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ProductMerchandiseModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ProductMerchandiseModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMerchandiseModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalProductMerchandiseModel FetchById(String id)
        {
            ProductRecord record = this.Provider.DataProvider.Learning.Product.FetchById(id);
            if (record == null)
                return null;
            return new LocalProductMerchandiseModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ProductMerchandise/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Learning.Product.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMerchandiseModel' /> instances.
        /// </summary>
        /// <param name="prodDescripId">
        ///     The value which identifies the <see cref='ProductMerchandiseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMerchandiseModel' /> instances that match the specified <paramref name='prodDescripId' />.
        /// </returns>
        public IEnumerable<LocalProductMerchandiseModel> FetchAllByProdDescripId(String prodDescripId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByDescrip(prodDescripId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProductMerchandiseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMerchandiseModel' /> instances.
        /// </summary>
        /// <param name="prodContentId">
        ///     The value which identifies the <see cref='ProductMerchandiseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMerchandiseModel' /> instances that match the specified <paramref name='prodContentId' />.
        /// </returns>
        public IEnumerable<LocalProductMerchandiseModel> FetchAllByProdContentId(String prodContentId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByText1(prodContentId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProductMerchandiseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMerchandiseModel' /> instances.
        /// </summary>
        /// <param name="prodPrereqId">
        ///     The value which identifies the <see cref='ProductMerchandiseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMerchandiseModel' /> instances that match the specified <paramref name='prodPrereqId' />.
        /// </returns>
        public IEnumerable<LocalProductMerchandiseModel> FetchAllByProdPrereqId(String prodPrereqId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByText2(prodPrereqId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProductMerchandiseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMerchandiseModel' /> instances.
        /// </summary>
        /// <param name="prodObjectiveId">
        ///     The value which identifies the <see cref='ProductMerchandiseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMerchandiseModel' /> instances that match the specified <paramref name='prodObjectiveId' />.
        /// </returns>
        public IEnumerable<LocalProductMerchandiseModel> FetchAllByProdObjectiveId(String prodObjectiveId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByText3(prodObjectiveId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProductMerchandiseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMerchandiseModel' /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref='ProductMerchandiseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMerchandiseModel' /> instances that match the specified <paramref name='proleIdId' />.
        /// </returns>
        public IEnumerable<LocalProductMerchandiseModel> FetchAllByProleIdId(String proleIdId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByProleId(proleIdId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProductMerchandiseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMerchandiseModel' /> instances.
        /// </summary>
        /// <param name="productManagerId">
        ///     The value which identifies the <see cref='ProductMerchandiseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMerchandiseModel' /> instances that match the specified <paramref name='productManagerId' />.
        /// </returns>
        public IEnumerable<LocalProductMerchandiseModel> FetchAllByProductManagerId(String productManagerId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByManProleId(productManagerId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProductMerchandiseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMerchandiseModel' /> instances.
        /// </summary>
        /// <param name="bookingTermsId">
        ///     The value which identifies the <see cref='ProductMerchandiseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMerchandiseModel' /> instances that match the specified <paramref name='bookingTermsId' />.
        /// </returns>
        public IEnumerable<LocalProductMerchandiseModel> FetchAllByBookingTermsId(String bookingTermsId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByBktId(bookingTermsId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProductMerchandiseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMerchandiseModel' /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref='ProductMerchandiseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMerchandiseModel' /> instances that match the specified <paramref name='locationId' />.
        /// </returns>
        public IEnumerable<LocalProductMerchandiseModel> FetchAllByLocationId(String locationId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByLocId(locationId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProductMerchandiseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMerchandiseModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='ProductMerchandiseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMerchandiseModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalProductMerchandiseModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProductMerchandiseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMerchandiseModel' /> instances.
        /// </summary>
        /// <param name="authorPersonId">
        ///     The value which identifies the <see cref='ProductMerchandiseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMerchandiseModel' /> instances that match the specified <paramref name='authorPersonId' />.
        /// </returns>
        public IEnumerable<LocalProductMerchandiseModel> FetchAllByAuthorPersonId(String authorPersonId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByAuthPnId(authorPersonId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProductMerchandiseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMerchandiseModel' /> instances.
        /// </summary>
        /// <param name="venueId">
        ///     The value which identifies the <see cref='ProductMerchandiseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMerchandiseModel' /> instances that match the specified <paramref name='venueId' />.
        /// </returns>
        public IEnumerable<LocalProductMerchandiseModel> FetchAllByVenueId(String venueId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByOrgId(venueId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProductMerchandiseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMerchandiseModel' /> instances.
        /// </summary>
        /// <param name="paymentScheduleId">
        ///     The value which identifies the <see cref='ProductMerchandiseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMerchandiseModel' /> instances that match the specified <paramref name='paymentScheduleId' />.
        /// </returns>
        public IEnumerable<LocalProductMerchandiseModel> FetchAllByPaymentScheduleId(Int32? paymentScheduleId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByPshId(paymentScheduleId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProductMerchandiseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductMerchandiseModel' /> instances.
        /// </summary>
        /// <param name="productTrainingRulesId">
        ///     The value which identifies the <see cref='ProductMerchandiseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductMerchandiseModel' /> instances that match the specified <paramref name='productTrainingRulesId' />.
        /// </returns>
        public IEnumerable<LocalProductMerchandiseModel> FetchAllByProductTrainingRulesId(String productTrainingRulesId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByTrnRulesTxt(productTrainingRulesId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProductMerchandiseModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ProductMerchandiseModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProductMerchandiseModel" /> instance.
        /// </returns>
        Consensus.Learning.IProductMerchandiseModel IProductMerchandiseFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProductMerchandiseModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProductMerchandiseModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMerchandiseModel> IProductMerchandiseFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProductMerchandiseModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProductMerchandiseModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMerchandiseModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IProductMerchandiseModel IProductMerchandiseFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IProductMerchandiseFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMerchandiseModel" /> instances.
        /// </summary>
        /// <param name="prodDescripId">
        ///     The value which identifies the <see cref="!:ProductMerchandiseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMerchandiseModel" /> instances that match the specified <paramref name="prodDescripId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMerchandiseModel> IProductMerchandiseFactory.FetchAllByProdDescripId(System.String prodDescripId)
        {
            return this.FetchAllByProdDescripId(prodDescripId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMerchandiseModel" /> instances.
        /// </summary>
        /// <param name="prodContentId">
        ///     The value which identifies the <see cref="!:ProductMerchandiseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMerchandiseModel" /> instances that match the specified <paramref name="prodContentId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMerchandiseModel> IProductMerchandiseFactory.FetchAllByProdContentId(System.String prodContentId)
        {
            return this.FetchAllByProdContentId(prodContentId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMerchandiseModel" /> instances.
        /// </summary>
        /// <param name="prodPrereqId">
        ///     The value which identifies the <see cref="!:ProductMerchandiseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMerchandiseModel" /> instances that match the specified <paramref name="prodPrereqId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMerchandiseModel> IProductMerchandiseFactory.FetchAllByProdPrereqId(System.String prodPrereqId)
        {
            return this.FetchAllByProdPrereqId(prodPrereqId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMerchandiseModel" /> instances.
        /// </summary>
        /// <param name="prodObjectiveId">
        ///     The value which identifies the <see cref="!:ProductMerchandiseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMerchandiseModel" /> instances that match the specified <paramref name="prodObjectiveId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMerchandiseModel> IProductMerchandiseFactory.FetchAllByProdObjectiveId(System.String prodObjectiveId)
        {
            return this.FetchAllByProdObjectiveId(prodObjectiveId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMerchandiseModel" /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref="!:ProductMerchandiseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMerchandiseModel" /> instances that match the specified <paramref name="proleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMerchandiseModel> IProductMerchandiseFactory.FetchAllByProleIdId(System.String proleIdId)
        {
            return this.FetchAllByProleIdId(proleIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMerchandiseModel" /> instances.
        /// </summary>
        /// <param name="productManagerId">
        ///     The value which identifies the <see cref="!:ProductMerchandiseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMerchandiseModel" /> instances that match the specified <paramref name="productManagerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMerchandiseModel> IProductMerchandiseFactory.FetchAllByProductManagerId(System.String productManagerId)
        {
            return this.FetchAllByProductManagerId(productManagerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMerchandiseModel" /> instances.
        /// </summary>
        /// <param name="bookingTermsId">
        ///     The value which identifies the <see cref="!:ProductMerchandiseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMerchandiseModel" /> instances that match the specified <paramref name="bookingTermsId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMerchandiseModel> IProductMerchandiseFactory.FetchAllByBookingTermsId(System.String bookingTermsId)
        {
            return this.FetchAllByBookingTermsId(bookingTermsId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMerchandiseModel" /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref="!:ProductMerchandiseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMerchandiseModel" /> instances that match the specified <paramref name="locationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMerchandiseModel> IProductMerchandiseFactory.FetchAllByLocationId(System.String locationId)
        {
            return this.FetchAllByLocationId(locationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMerchandiseModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ProductMerchandiseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMerchandiseModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMerchandiseModel> IProductMerchandiseFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMerchandiseModel" /> instances.
        /// </summary>
        /// <param name="authorPersonId">
        ///     The value which identifies the <see cref="!:ProductMerchandiseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMerchandiseModel" /> instances that match the specified <paramref name="authorPersonId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMerchandiseModel> IProductMerchandiseFactory.FetchAllByAuthorPersonId(System.String authorPersonId)
        {
            return this.FetchAllByAuthorPersonId(authorPersonId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMerchandiseModel" /> instances.
        /// </summary>
        /// <param name="venueId">
        ///     The value which identifies the <see cref="!:ProductMerchandiseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMerchandiseModel" /> instances that match the specified <paramref name="venueId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMerchandiseModel> IProductMerchandiseFactory.FetchAllByVenueId(System.String venueId)
        {
            return this.FetchAllByVenueId(venueId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMerchandiseModel> IProductMerchandiseFactory.FetchAllByPaymentScheduleId(System.Nullable<System.Int32> paymentScheduleId)
        {
            return this.FetchAllByPaymentScheduleId(paymentScheduleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductMerchandiseModel" /> instances.
        /// </summary>
        /// <param name="productTrainingRulesId">
        ///     The value which identifies the <see cref="!:ProductMerchandiseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductMerchandiseModel" /> instances that match the specified <paramref name="productTrainingRulesId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductMerchandiseModel> IProductMerchandiseFactory.FetchAllByProductTrainingRulesId(System.String productTrainingRulesId)
        {
            return this.FetchAllByProductTrainingRulesId(productTrainingRulesId);
        }

        #endregion
    }
}
