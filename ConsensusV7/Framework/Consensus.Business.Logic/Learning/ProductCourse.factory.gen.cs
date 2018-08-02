using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProductCourseModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProductCourseFactory : LocalFactory<LocalProductCourseModel, ProductRecord, String>, IProductCourseFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ProductCourseModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ProductCourseModel' /> instance.
        /// </returns>
        public LocalProductCourseModel Create()
        {
            return new LocalProductCourseModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ProductCourseModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ProductCourseModel' /> instances.
        /// </returns>
        public IEnumerable<LocalProductCourseModel> FetchAll()
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAll();
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 1)
                {
                    yield return new LocalProductCourseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ProductCourseModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ProductCourseModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductCourseModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalProductCourseModel FetchById(String id)
        {
            ProductRecord record = this.Provider.DataProvider.Learning.Product.FetchById(id);
            if (record == null)
                return null;
            return new LocalProductCourseModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ProductCourse/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Learning.Product.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductCourseModel' /> instances.
        /// </summary>
        /// <param name="prodDescripId">
        ///     The value which identifies the <see cref='ProductCourseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductCourseModel' /> instances that match the specified <paramref name='prodDescripId' />.
        /// </returns>
        public IEnumerable<LocalProductCourseModel> FetchAllByProdDescripId(String prodDescripId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByDescrip(prodDescripId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 1)
                {
                    yield return new LocalProductCourseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductCourseModel' /> instances.
        /// </summary>
        /// <param name="prodContentId">
        ///     The value which identifies the <see cref='ProductCourseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductCourseModel' /> instances that match the specified <paramref name='prodContentId' />.
        /// </returns>
        public IEnumerable<LocalProductCourseModel> FetchAllByProdContentId(String prodContentId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByText1(prodContentId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 1)
                {
                    yield return new LocalProductCourseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductCourseModel' /> instances.
        /// </summary>
        /// <param name="prodPrereqId">
        ///     The value which identifies the <see cref='ProductCourseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductCourseModel' /> instances that match the specified <paramref name='prodPrereqId' />.
        /// </returns>
        public IEnumerable<LocalProductCourseModel> FetchAllByProdPrereqId(String prodPrereqId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByText2(prodPrereqId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 1)
                {
                    yield return new LocalProductCourseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductCourseModel' /> instances.
        /// </summary>
        /// <param name="prodObjectiveId">
        ///     The value which identifies the <see cref='ProductCourseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductCourseModel' /> instances that match the specified <paramref name='prodObjectiveId' />.
        /// </returns>
        public IEnumerable<LocalProductCourseModel> FetchAllByProdObjectiveId(String prodObjectiveId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByText3(prodObjectiveId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 1)
                {
                    yield return new LocalProductCourseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductCourseModel' /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref='ProductCourseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductCourseModel' /> instances that match the specified <paramref name='proleIdId' />.
        /// </returns>
        public IEnumerable<LocalProductCourseModel> FetchAllByProleIdId(String proleIdId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByProleId(proleIdId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 1)
                {
                    yield return new LocalProductCourseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductCourseModel' /> instances.
        /// </summary>
        /// <param name="productManagerId">
        ///     The value which identifies the <see cref='ProductCourseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductCourseModel' /> instances that match the specified <paramref name='productManagerId' />.
        /// </returns>
        public IEnumerable<LocalProductCourseModel> FetchAllByProductManagerId(String productManagerId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByManProleId(productManagerId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 1)
                {
                    yield return new LocalProductCourseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductCourseModel' /> instances.
        /// </summary>
        /// <param name="bookingTermsId">
        ///     The value which identifies the <see cref='ProductCourseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductCourseModel' /> instances that match the specified <paramref name='bookingTermsId' />.
        /// </returns>
        public IEnumerable<LocalProductCourseModel> FetchAllByBookingTermsId(String bookingTermsId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByBktId(bookingTermsId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 1)
                {
                    yield return new LocalProductCourseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductCourseModel' /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref='ProductCourseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductCourseModel' /> instances that match the specified <paramref name='locationId' />.
        /// </returns>
        public IEnumerable<LocalProductCourseModel> FetchAllByLocationId(String locationId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByLocId(locationId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 1)
                {
                    yield return new LocalProductCourseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductCourseModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='ProductCourseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductCourseModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalProductCourseModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 1)
                {
                    yield return new LocalProductCourseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductCourseModel' /> instances.
        /// </summary>
        /// <param name="authorPersonId">
        ///     The value which identifies the <see cref='ProductCourseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductCourseModel' /> instances that match the specified <paramref name='authorPersonId' />.
        /// </returns>
        public IEnumerable<LocalProductCourseModel> FetchAllByAuthorPersonId(String authorPersonId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByAuthPnId(authorPersonId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 1)
                {
                    yield return new LocalProductCourseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductCourseModel' /> instances.
        /// </summary>
        /// <param name="venueId">
        ///     The value which identifies the <see cref='ProductCourseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductCourseModel' /> instances that match the specified <paramref name='venueId' />.
        /// </returns>
        public IEnumerable<LocalProductCourseModel> FetchAllByVenueId(String venueId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByOrgId(venueId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 1)
                {
                    yield return new LocalProductCourseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductCourseModel' /> instances.
        /// </summary>
        /// <param name="paymentScheduleId">
        ///     The value which identifies the <see cref='ProductCourseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductCourseModel' /> instances that match the specified <paramref name='paymentScheduleId' />.
        /// </returns>
        public IEnumerable<LocalProductCourseModel> FetchAllByPaymentScheduleId(Int32? paymentScheduleId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByPshId(paymentScheduleId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 1)
                {
                    yield return new LocalProductCourseModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductCourseModel' /> instances.
        /// </summary>
        /// <param name="productTrainingRulesId">
        ///     The value which identifies the <see cref='ProductCourseModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductCourseModel' /> instances that match the specified <paramref name='productTrainingRulesId' />.
        /// </returns>
        public IEnumerable<LocalProductCourseModel> FetchAllByProductTrainingRulesId(String productTrainingRulesId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByTrnRulesTxt(productTrainingRulesId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null && record.SyProduct == 1)
                {
                    yield return new LocalProductCourseModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ProductCourseModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProductCourseModel" /> instance.
        /// </returns>
        Consensus.Learning.IProductCourseModel IProductCourseFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProductCourseModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProductCourseModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> IProductCourseFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProductCourseModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProductCourseModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IProductCourseModel IProductCourseFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IProductCourseFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="prodDescripId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="prodDescripId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> IProductCourseFactory.FetchAllByProdDescripId(System.String prodDescripId)
        {
            return this.FetchAllByProdDescripId(prodDescripId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="prodContentId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="prodContentId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> IProductCourseFactory.FetchAllByProdContentId(System.String prodContentId)
        {
            return this.FetchAllByProdContentId(prodContentId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="prodPrereqId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="prodPrereqId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> IProductCourseFactory.FetchAllByProdPrereqId(System.String prodPrereqId)
        {
            return this.FetchAllByProdPrereqId(prodPrereqId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="prodObjectiveId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="prodObjectiveId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> IProductCourseFactory.FetchAllByProdObjectiveId(System.String prodObjectiveId)
        {
            return this.FetchAllByProdObjectiveId(prodObjectiveId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="proleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> IProductCourseFactory.FetchAllByProleIdId(System.String proleIdId)
        {
            return this.FetchAllByProleIdId(proleIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="productManagerId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="productManagerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> IProductCourseFactory.FetchAllByProductManagerId(System.String productManagerId)
        {
            return this.FetchAllByProductManagerId(productManagerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="bookingTermsId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="bookingTermsId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> IProductCourseFactory.FetchAllByBookingTermsId(System.String bookingTermsId)
        {
            return this.FetchAllByBookingTermsId(bookingTermsId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="locationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> IProductCourseFactory.FetchAllByLocationId(System.String locationId)
        {
            return this.FetchAllByLocationId(locationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> IProductCourseFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="authorPersonId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="authorPersonId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> IProductCourseFactory.FetchAllByAuthorPersonId(System.String authorPersonId)
        {
            return this.FetchAllByAuthorPersonId(authorPersonId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="venueId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="venueId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> IProductCourseFactory.FetchAllByVenueId(System.String venueId)
        {
            return this.FetchAllByVenueId(venueId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> IProductCourseFactory.FetchAllByPaymentScheduleId(System.Nullable<System.Int32> paymentScheduleId)
        {
            return this.FetchAllByPaymentScheduleId(paymentScheduleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductCourseModel" /> instances.
        /// </summary>
        /// <param name="productTrainingRulesId">
        ///     The value which identifies the <see cref="!:ProductCourseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductCourseModel" /> instances that match the specified <paramref name="productTrainingRulesId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductCourseModel> IProductCourseFactory.FetchAllByProductTrainingRulesId(System.String productTrainingRulesId)
        {
            return this.FetchAllByProductTrainingRulesId(productTrainingRulesId);
        }

        #endregion
    }
}
