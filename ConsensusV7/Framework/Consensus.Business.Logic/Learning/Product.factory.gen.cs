using Consensus.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProductModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProductFactory : LocalFactory<LocalProductModel, ProductRecord, String>, IProductFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ProductModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ProductModel' /> instance.
        /// </returns>
        public LocalProductModel Create()
        {
            return new LocalProductModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ProductModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ProductModel' /> instances.
        /// </returns>
        public IEnumerable<LocalProductModel> FetchAll()
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAll();
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    if (record.SyProduct == 1)
                        yield return new LocalProductCourseModel(this.Provider, record);
                    else if (record.SyProduct == 10)
                        yield return new LocalProductMembershipModel(this.Provider, record);
                    else
                        yield return new LocalProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ProductModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ProductModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalProductModel FetchById(String id)
        {
            ProductRecord record = this.Provider.DataProvider.Learning.Product.FetchById(id);
            if (record == null)
                return null;
            if (record.SyProduct == 1)
                return new LocalProductCourseModel(this.Provider, record);
            if (record.SyProduct == 10)
                return new LocalProductMembershipModel(this.Provider, record);
            return new LocalProductModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Product/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Learning.Product.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductModel' /> instances.
        /// </summary>
        /// <param name="prodDescripId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductModel' /> instances that match the specified <paramref name='prodDescripId' />.
        /// </returns>
        public IEnumerable<LocalProductModel> FetchAllByProdDescripId(String prodDescripId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByDescrip(prodDescripId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    if (record.SyProduct == 1)
                        yield return new LocalProductCourseModel(this.Provider, record);
                    else if (record.SyProduct == 10)
                        yield return new LocalProductMembershipModel(this.Provider, record);
                    else
                        yield return new LocalProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductModel' /> instances.
        /// </summary>
        /// <param name="prodContentId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductModel' /> instances that match the specified <paramref name='prodContentId' />.
        /// </returns>
        public IEnumerable<LocalProductModel> FetchAllByProdContentId(String prodContentId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByText1(prodContentId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    if (record.SyProduct == 1)
                        yield return new LocalProductCourseModel(this.Provider, record);
                    else if (record.SyProduct == 10)
                        yield return new LocalProductMembershipModel(this.Provider, record);
                    else
                        yield return new LocalProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductModel' /> instances.
        /// </summary>
        /// <param name="prodPrereqId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductModel' /> instances that match the specified <paramref name='prodPrereqId' />.
        /// </returns>
        public IEnumerable<LocalProductModel> FetchAllByProdPrereqId(String prodPrereqId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByText2(prodPrereqId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    if (record.SyProduct == 1)
                        yield return new LocalProductCourseModel(this.Provider, record);
                    else if (record.SyProduct == 10)
                        yield return new LocalProductMembershipModel(this.Provider, record);
                    else
                        yield return new LocalProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductModel' /> instances.
        /// </summary>
        /// <param name="prodObjectiveId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductModel' /> instances that match the specified <paramref name='prodObjectiveId' />.
        /// </returns>
        public IEnumerable<LocalProductModel> FetchAllByProdObjectiveId(String prodObjectiveId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByText3(prodObjectiveId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    if (record.SyProduct == 1)
                        yield return new LocalProductCourseModel(this.Provider, record);
                    else if (record.SyProduct == 10)
                        yield return new LocalProductMembershipModel(this.Provider, record);
                    else
                        yield return new LocalProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductModel' /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductModel' /> instances that match the specified <paramref name='proleIdId' />.
        /// </returns>
        public IEnumerable<LocalProductModel> FetchAllByProleIdId(String proleIdId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByProleId(proleIdId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    if (record.SyProduct == 1)
                        yield return new LocalProductCourseModel(this.Provider, record);
                    else if (record.SyProduct == 10)
                        yield return new LocalProductMembershipModel(this.Provider, record);
                    else
                        yield return new LocalProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductModel' /> instances.
        /// </summary>
        /// <param name="productManagerId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductModel' /> instances that match the specified <paramref name='productManagerId' />.
        /// </returns>
        public IEnumerable<LocalProductModel> FetchAllByProductManagerId(String productManagerId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByManProleId(productManagerId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    if (record.SyProduct == 1)
                        yield return new LocalProductCourseModel(this.Provider, record);
                    else if (record.SyProduct == 10)
                        yield return new LocalProductMembershipModel(this.Provider, record);
                    else
                        yield return new LocalProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductModel' /> instances.
        /// </summary>
        /// <param name="bookingTermsId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductModel' /> instances that match the specified <paramref name='bookingTermsId' />.
        /// </returns>
        public IEnumerable<LocalProductModel> FetchAllByBookingTermsId(String bookingTermsId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByBktId(bookingTermsId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    if (record.SyProduct == 1)
                        yield return new LocalProductCourseModel(this.Provider, record);
                    else if (record.SyProduct == 10)
                        yield return new LocalProductMembershipModel(this.Provider, record);
                    else
                        yield return new LocalProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductModel' /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductModel' /> instances that match the specified <paramref name='locationId' />.
        /// </returns>
        public IEnumerable<LocalProductModel> FetchAllByLocationId(String locationId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByLocId(locationId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    if (record.SyProduct == 1)
                        yield return new LocalProductCourseModel(this.Provider, record);
                    else if (record.SyProduct == 10)
                        yield return new LocalProductMembershipModel(this.Provider, record);
                    else
                        yield return new LocalProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalProductModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    if (record.SyProduct == 1)
                        yield return new LocalProductCourseModel(this.Provider, record);
                    else if (record.SyProduct == 10)
                        yield return new LocalProductMembershipModel(this.Provider, record);
                    else
                        yield return new LocalProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductModel' /> instances.
        /// </summary>
        /// <param name="authorPersonId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductModel' /> instances that match the specified <paramref name='authorPersonId' />.
        /// </returns>
        public IEnumerable<LocalProductModel> FetchAllByAuthorPersonId(String authorPersonId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByAuthPnId(authorPersonId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    if (record.SyProduct == 1)
                        yield return new LocalProductCourseModel(this.Provider, record);
                    else if (record.SyProduct == 10)
                        yield return new LocalProductMembershipModel(this.Provider, record);
                    else
                        yield return new LocalProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductModel' /> instances.
        /// </summary>
        /// <param name="venueId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductModel' /> instances that match the specified <paramref name='venueId' />.
        /// </returns>
        public IEnumerable<LocalProductModel> FetchAllByVenueId(String venueId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByOrgId(venueId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    if (record.SyProduct == 1)
                        yield return new LocalProductCourseModel(this.Provider, record);
                    else if (record.SyProduct == 10)
                        yield return new LocalProductMembershipModel(this.Provider, record);
                    else
                        yield return new LocalProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductModel' /> instances.
        /// </summary>
        /// <param name="paymentScheduleId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductModel' /> instances that match the specified <paramref name='paymentScheduleId' />.
        /// </returns>
        public IEnumerable<LocalProductModel> FetchAllByPaymentScheduleId(Int32? paymentScheduleId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByPshId(paymentScheduleId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    if (record.SyProduct == 1)
                        yield return new LocalProductCourseModel(this.Provider, record);
                    else if (record.SyProduct == 10)
                        yield return new LocalProductMembershipModel(this.Provider, record);
                    else
                        yield return new LocalProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProductModel' /> instances.
        /// </summary>
        /// <param name="productTrainingRulesId">
        ///     The value which identifies the <see cref='ProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProductModel' /> instances that match the specified <paramref name='productTrainingRulesId' />.
        /// </returns>
        public IEnumerable<LocalProductModel> FetchAllByProductTrainingRulesId(String productTrainingRulesId)
        {
            IEnumerable<ProductRecord> recordCollection = this.Provider.DataProvider.Learning.Product.FetchAllByTrnRulesTxt(productTrainingRulesId);
            foreach (ProductRecord record in recordCollection)
            {
                if (record != null)
                {
                    if (record.SyProduct == 1)
                        yield return new LocalProductCourseModel(this.Provider, record);
                    else if (record.SyProduct == 10)
                        yield return new LocalProductMembershipModel(this.Provider, record);
                    else
                        yield return new LocalProductModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Retrieves a single <see cref="T:Consensus.Learning.LocalProductModel" /> instance.
        /// </summary>
        /// <param name="reference">
        ///     The value which identifies the <see cref="T:Consensus.Learning.LocalProductModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="T:Consensus.Learning.LocalProductModel" /> instance that match the specified <paramref name="reference" />.
        /// </returns>
        System.String IProductFactory.FetchAllByReference(System.String reference)
        {
            return this.FetchAllByReference(reference);
        }

        IEnumerable<DonationProduct> IProductFactory.FetchDonationProduct()
        {
            return this.FetchDonationProduct();
        }

        string IProductFactory.CreateDonationProduct(string personName, string surname, string email, string phone, string price, string productId)
        {
            return this.CreateDonationProduct(personName, surname, email, phone, price, productId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ProductModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProductModel" /> instance.
        /// </returns>
        Consensus.Learning.IProductModel IProductFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProductModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProductModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> IProductFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProductModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProductModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IProductModel IProductFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IProductFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="prodDescripId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="prodDescripId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> IProductFactory.FetchAllByProdDescripId(System.String prodDescripId)
        {
            return this.FetchAllByProdDescripId(prodDescripId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="prodContentId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="prodContentId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> IProductFactory.FetchAllByProdContentId(System.String prodContentId)
        {
            return this.FetchAllByProdContentId(prodContentId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="prodPrereqId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="prodPrereqId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> IProductFactory.FetchAllByProdPrereqId(System.String prodPrereqId)
        {
            return this.FetchAllByProdPrereqId(prodPrereqId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="prodObjectiveId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="prodObjectiveId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> IProductFactory.FetchAllByProdObjectiveId(System.String prodObjectiveId)
        {
            return this.FetchAllByProdObjectiveId(prodObjectiveId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="proleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> IProductFactory.FetchAllByProleIdId(System.String proleIdId)
        {
            return this.FetchAllByProleIdId(proleIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="productManagerId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="productManagerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> IProductFactory.FetchAllByProductManagerId(System.String productManagerId)
        {
            return this.FetchAllByProductManagerId(productManagerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="bookingTermsId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="bookingTermsId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> IProductFactory.FetchAllByBookingTermsId(System.String bookingTermsId)
        {
            return this.FetchAllByBookingTermsId(bookingTermsId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="locationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> IProductFactory.FetchAllByLocationId(System.String locationId)
        {
            return this.FetchAllByLocationId(locationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> IProductFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="authorPersonId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="authorPersonId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> IProductFactory.FetchAllByAuthorPersonId(System.String authorPersonId)
        {
            return this.FetchAllByAuthorPersonId(authorPersonId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="venueId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="venueId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> IProductFactory.FetchAllByVenueId(System.String venueId)
        {
            return this.FetchAllByVenueId(venueId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> IProductFactory.FetchAllByPaymentScheduleId(System.Nullable<System.Int32> paymentScheduleId)
        {
            return this.FetchAllByPaymentScheduleId(paymentScheduleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProductModel" /> instances.
        /// </summary>
        /// <param name="productTrainingRulesId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProductModel" /> instances that match the specified <paramref name="productTrainingRulesId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IProductModel> IProductFactory.FetchAllByProductTrainingRulesId(System.String productTrainingRulesId)
        {
            return this.FetchAllByProductTrainingRulesId(productTrainingRulesId);
        }

        IEnumerable<CourseProduct> IProductFactory.FetchCourseProduct()
        {
            return this.FetchCourseProduct();
        }

        #endregion
    }
}
