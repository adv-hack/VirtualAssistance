using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ElementModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalElementFactory : LocalFactory<LocalElementModel, ElementRecord, String>, IElementFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ElementModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ElementModel' /> instance.
        /// </returns>
        public LocalElementModel Create()
        {
            return new LocalElementModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ElementModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ElementModel' /> instances.
        /// </returns>
        public IEnumerable<LocalElementModel> FetchAll()
        {
            IEnumerable<ElementRecord> recordCollection = this.Provider.DataProvider.Learning.Element.FetchAll();
            foreach (ElementRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalElementModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ElementModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ElementModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ElementModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalElementModel FetchById(String id)
        {
            ElementRecord record = this.Provider.DataProvider.Learning.Element.FetchById(id);
            if (record == null)
                return null;
            return new LocalElementModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Element/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Learning.Element.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ElementModel' /> instances.
        /// </summary>
        /// <param name="delegateId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ElementModel' /> instances that match the specified <paramref name='delegateId' />.
        /// </returns>
        public IEnumerable<LocalElementModel> FetchAllByDelegateId(String delegateId)
        {
            IEnumerable<ElementRecord> recordCollection = this.Provider.DataProvider.Learning.Element.FetchAllByDelId(delegateId);
            foreach (ElementRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalElementModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ElementModel' /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ElementModel' /> instances that match the specified <paramref name='productId' />.
        /// </returns>
        public IEnumerable<LocalElementModel> FetchAllByProductId(String productId)
        {
            IEnumerable<ElementRecord> recordCollection = this.Provider.DataProvider.Learning.Element.FetchAllByProdId(productId);
            foreach (ElementRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalElementModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ElementModel' /> instances.
        /// </summary>
        /// <param name="activityId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ElementModel' /> instances that match the specified <paramref name='activityId' />.
        /// </returns>
        public IEnumerable<LocalElementModel> FetchAllByActivityId(String activityId)
        {
            IEnumerable<ElementRecord> recordCollection = this.Provider.DataProvider.Learning.Element.FetchAllByActId(activityId);
            foreach (ElementRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalElementModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ElementModel' /> instances.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ElementModel' /> instances that match the specified <paramref name='courseId' />.
        /// </returns>
        public IEnumerable<LocalElementModel> FetchAllByCourseId(String courseId)
        {
            IEnumerable<ElementRecord> recordCollection = this.Provider.DataProvider.Learning.Element.FetchAllByCourseId(courseId);
            foreach (ElementRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalElementModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ElementModel' /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ElementModel' /> instances that match the specified <paramref name='bookingId' />.
        /// </returns>
        public IEnumerable<LocalElementModel> FetchAllByBookingId(String bookingId)
        {
            IEnumerable<ElementRecord> recordCollection = this.Provider.DataProvider.Learning.Element.FetchAllByBookId(bookingId);
            foreach (ElementRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalElementModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ElementModel' /> instances.
        /// </summary>
        /// <param name="priceListId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ElementModel' /> instances that match the specified <paramref name='priceListId' />.
        /// </returns>
        public IEnumerable<LocalElementModel> FetchAllByPriceListId(String priceListId)
        {
            IEnumerable<ElementRecord> recordCollection = this.Provider.DataProvider.Learning.Element.FetchAllByPlId(priceListId);
            foreach (ElementRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalElementModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ElementModel' /> instances.
        /// </summary>
        /// <param name="sessionXrefsId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ElementModel' /> instances that match the specified <paramref name='sessionXrefsId' />.
        /// </returns>
        public IEnumerable<LocalElementModel> FetchAllBySessionXrefsId(String sessionXrefsId)
        {
            IEnumerable<ElementRecord> recordCollection = this.Provider.DataProvider.Learning.Element.FetchAllBySxrefId(sessionXrefsId);
            foreach (ElementRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalElementModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ElementModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ElementModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalElementModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<ElementRecord> recordCollection = this.Provider.DataProvider.Learning.Element.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (ElementRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalElementModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ElementModel' /> instances.
        /// </summary>
        /// <param name="priceIdId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ElementModel' /> instances that match the specified <paramref name='priceIdId' />.
        /// </returns>
        public IEnumerable<LocalElementModel> FetchAllByPriceIdId(String priceIdId)
        {
            IEnumerable<ElementRecord> recordCollection = this.Provider.DataProvider.Learning.Element.FetchAllByPrsId(priceIdId);
            foreach (ElementRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalElementModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ElementModel' /> instances.
        /// </summary>
        /// <param name="parentElementId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ElementModel' /> instances that match the specified <paramref name='parentElementId' />.
        /// </returns>
        public IEnumerable<LocalElementModel> FetchAllByParentElementId(String parentElementId)
        {
            IEnumerable<ElementRecord> recordCollection = this.Provider.DataProvider.Learning.Element.FetchAllByElemId(parentElementId);
            foreach (ElementRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalElementModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ElementModel' /> instances.
        /// </summary>
        /// <param name="bookingTermId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ElementModel' /> instances that match the specified <paramref name='bookingTermId' />.
        /// </returns>
        public IEnumerable<LocalElementModel> FetchAllByBookingTermId(String bookingTermId)
        {
            IEnumerable<ElementRecord> recordCollection = this.Provider.DataProvider.Learning.Element.FetchAllByBktId(bookingTermId);
            foreach (ElementRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalElementModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ElementModel' /> instances.
        /// </summary>
        /// <param name="paymentScheduleId">
        ///     The value which identifies the <see cref='ElementModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ElementModel' /> instances that match the specified <paramref name='paymentScheduleId' />.
        /// </returns>
        public IEnumerable<LocalElementModel> FetchAllByPaymentScheduleId(Int32? paymentScheduleId)
        {
            IEnumerable<ElementRecord> recordCollection = this.Provider.DataProvider.Learning.Element.FetchAllByPshId(paymentScheduleId);
            foreach (ElementRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalElementModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ElementModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ElementModel" /> instance.
        /// </returns>
        Consensus.Learning.IElementModel IElementFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ElementModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ElementModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> IElementFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ElementModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ElementModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IElementModel IElementFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IElementFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="delegateId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="delegateId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> IElementFactory.FetchAllByDelegateId(System.String delegateId)
        {
            return this.FetchAllByDelegateId(delegateId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> IElementFactory.FetchAllByProductId(System.String productId)
        {
            return this.FetchAllByProductId(productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="activityId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="activityId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> IElementFactory.FetchAllByActivityId(System.String activityId)
        {
            return this.FetchAllByActivityId(activityId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="courseId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> IElementFactory.FetchAllByCourseId(System.String courseId)
        {
            return this.FetchAllByCourseId(courseId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="bookingId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> IElementFactory.FetchAllByBookingId(System.String bookingId)
        {
            return this.FetchAllByBookingId(bookingId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="priceListId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="priceListId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> IElementFactory.FetchAllByPriceListId(System.String priceListId)
        {
            return this.FetchAllByPriceListId(priceListId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="sessionXrefsId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="sessionXrefsId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> IElementFactory.FetchAllBySessionXrefsId(System.String sessionXrefsId)
        {
            return this.FetchAllBySessionXrefsId(sessionXrefsId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> IElementFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="priceIdId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="priceIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> IElementFactory.FetchAllByPriceIdId(System.String priceIdId)
        {
            return this.FetchAllByPriceIdId(priceIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="parentElementId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="parentElementId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> IElementFactory.FetchAllByParentElementId(System.String parentElementId)
        {
            return this.FetchAllByParentElementId(parentElementId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ElementModel" /> instances.
        /// </summary>
        /// <param name="bookingTermId">
        ///     The value which identifies the <see cref="!:ElementModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ElementModel" /> instances that match the specified <paramref name="bookingTermId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> IElementFactory.FetchAllByBookingTermId(System.String bookingTermId)
        {
            return this.FetchAllByBookingTermId(bookingTermId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Learning.IElementModel> IElementFactory.FetchAllByPaymentScheduleId(System.Nullable<System.Int32> paymentScheduleId)
        {
            return this.FetchAllByPaymentScheduleId(paymentScheduleId);
        }

        #endregion
    }
}
