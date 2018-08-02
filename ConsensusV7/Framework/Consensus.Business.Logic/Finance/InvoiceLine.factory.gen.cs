using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="InvoiceLineModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalInvoiceLineFactory : LocalFactory<LocalInvoiceLineModel, InvlineRecord, String>, IInvoiceLineFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='InvoiceLineModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='InvoiceLineModel' /> instance.
        /// </returns>
        public LocalInvoiceLineModel Create()
        {
            return new LocalInvoiceLineModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='InvoiceLineModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='InvoiceLineModel' /> instances.
        /// </returns>
        public IEnumerable<LocalInvoiceLineModel> FetchAll()
        {
            IEnumerable<InvlineRecord> recordCollection = this.Provider.DataProvider.Finance.InvoiceLine.FetchAll();
            foreach (InvlineRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalInvoiceLineModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='InvoiceLineModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='InvoiceLineModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='InvoiceLineModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalInvoiceLineModel FetchById(String id)
        {
            InvlineRecord record = this.Provider.DataProvider.Finance.InvoiceLine.FetchById(id);
            if (record == null)
                return null;
            return new LocalInvoiceLineModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='InvoiceLine/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Finance.InvoiceLine.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='InvoiceLineModel' /> instances.
        /// </summary>
        /// <param name="invoiceId">
        ///     The value which identifies the <see cref='InvoiceLineModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='InvoiceLineModel' /> instances that match the specified <paramref name='invoiceId' />.
        /// </returns>
        public IEnumerable<LocalInvoiceLineModel> FetchAllByInvoiceId(String invoiceId)
        {
            IEnumerable<InvlineRecord> recordCollection = this.Provider.DataProvider.Finance.InvoiceLine.FetchAllByInvId(invoiceId);
            foreach (InvlineRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalInvoiceLineModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='InvoiceLineModel' /> instances.
        /// </summary>
        /// <param name="productIdId">
        ///     The value which identifies the <see cref='InvoiceLineModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='InvoiceLineModel' /> instances that match the specified <paramref name='productIdId' />.
        /// </returns>
        public IEnumerable<LocalInvoiceLineModel> FetchAllByProductIdId(String productIdId)
        {
            IEnumerable<InvlineRecord> recordCollection = this.Provider.DataProvider.Finance.InvoiceLine.FetchAllByProductId(productIdId);
            foreach (InvlineRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalInvoiceLineModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='InvoiceLineModel' /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref='InvoiceLineModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='InvoiceLineModel' /> instances that match the specified <paramref name='bookingId' />.
        /// </returns>
        public IEnumerable<LocalInvoiceLineModel> FetchAllByBookingId(String bookingId)
        {
            IEnumerable<InvlineRecord> recordCollection = this.Provider.DataProvider.Finance.InvoiceLine.FetchAllByBookId(bookingId);
            foreach (InvlineRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalInvoiceLineModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='InvoiceLineModel' /> instances.
        /// </summary>
        /// <param name="elementId">
        ///     The value which identifies the <see cref='InvoiceLineModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='InvoiceLineModel' /> instances that match the specified <paramref name='elementId' />.
        /// </returns>
        public IEnumerable<LocalInvoiceLineModel> FetchAllByElementId(String elementId)
        {
            IEnumerable<InvlineRecord> recordCollection = this.Provider.DataProvider.Finance.InvoiceLine.FetchAllByElemId(elementId);
            foreach (InvlineRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalInvoiceLineModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='InvoiceLineModel' /> instances.
        /// </summary>
        /// <param name="courseIdId">
        ///     The value which identifies the <see cref='InvoiceLineModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='InvoiceLineModel' /> instances that match the specified <paramref name='courseIdId' />.
        /// </returns>
        public IEnumerable<LocalInvoiceLineModel> FetchAllByCourseIdId(String courseIdId)
        {
            IEnumerable<InvlineRecord> recordCollection = this.Provider.DataProvider.Finance.InvoiceLine.FetchAllByCourseId(courseIdId);
            foreach (InvlineRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalInvoiceLineModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='InvoiceLineModel' /> instances.
        /// </summary>
        /// <param name="melIdId">
        ///     The value which identifies the <see cref='InvoiceLineModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='InvoiceLineModel' /> instances that match the specified <paramref name='melIdId' />.
        /// </returns>
        public IEnumerable<LocalInvoiceLineModel> FetchAllByMelIdId(String melIdId)
        {
            IEnumerable<InvlineRecord> recordCollection = this.Provider.DataProvider.Finance.InvoiceLine.FetchAllByMelId(melIdId);
            foreach (InvlineRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalInvoiceLineModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='InvoiceLineModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='InvoiceLineModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='InvoiceLineModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalInvoiceLineModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<InvlineRecord> recordCollection = this.Provider.DataProvider.Finance.InvoiceLine.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (InvlineRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalInvoiceLineModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:InvoiceLineModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:InvoiceLineModel" /> instance.
        /// </returns>
        Consensus.Finance.IInvoiceLineModel IInvoiceLineFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:InvoiceLineModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceLineModel> IInvoiceLineFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:InvoiceLineModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:InvoiceLineModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IInvoiceLineModel IInvoiceLineFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IInvoiceLineFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="invoiceId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="invoiceId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceLineModel> IInvoiceLineFactory.FetchAllByInvoiceId(System.String invoiceId)
        {
            return this.FetchAllByInvoiceId(invoiceId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="productIdId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="productIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceLineModel> IInvoiceLineFactory.FetchAllByProductIdId(System.String productIdId)
        {
            return this.FetchAllByProductIdId(productIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="bookingId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceLineModel> IInvoiceLineFactory.FetchAllByBookingId(System.String bookingId)
        {
            return this.FetchAllByBookingId(bookingId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="elementId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="elementId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceLineModel> IInvoiceLineFactory.FetchAllByElementId(System.String elementId)
        {
            return this.FetchAllByElementId(elementId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="courseIdId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="courseIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceLineModel> IInvoiceLineFactory.FetchAllByCourseIdId(System.String courseIdId)
        {
            return this.FetchAllByCourseIdId(courseIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="melIdId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="melIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceLineModel> IInvoiceLineFactory.FetchAllByMelIdId(System.String melIdId)
        {
            return this.FetchAllByMelIdId(melIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceLineModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceLineModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceLineModel> IInvoiceLineFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        #endregion
    }
}
