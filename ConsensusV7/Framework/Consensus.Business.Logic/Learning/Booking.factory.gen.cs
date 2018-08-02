using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="BookingModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalBookingFactory : LocalFactory<LocalBookingModel, BookingRecord, String>, IBookingFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='BookingModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='BookingModel' /> instance.
        /// </returns>
        public LocalBookingModel Create()
        {
            return new LocalBookingModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='BookingModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='BookingModel' /> instances.
        /// </returns>
        public IEnumerable<LocalBookingModel> FetchAll()
        {
            IEnumerable<BookingRecord> recordCollection = this.Provider.DataProvider.Learning.Booking.FetchAll();
            foreach (BookingRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBookingModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='BookingModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='BookingModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BookingModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalBookingModel FetchById(String id)
        {
            BookingRecord record = this.Provider.DataProvider.Learning.Booking.FetchById(id);
            if (record == null)
                return null;
            return new LocalBookingModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Booking/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Learning.Booking.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BookingModel' /> instances.
        /// </summary>
        /// <param name="bookerOrgId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BookingModel' /> instances that match the specified <paramref name='bookerOrgId' />.
        /// </returns>
        public IEnumerable<LocalBookingModel> FetchAllByBookerOrgId(String bookerOrgId)
        {
            IEnumerable<BookingRecord> recordCollection = this.Provider.DataProvider.Learning.Booking.FetchAllByOrgId(bookerOrgId);
            foreach (BookingRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBookingModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BookingModel' /> instances.
        /// </summary>
        /// <param name="bookerPersonId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BookingModel' /> instances that match the specified <paramref name='bookerPersonId' />.
        /// </returns>
        public IEnumerable<LocalBookingModel> FetchAllByBookerPersonId(String bookerPersonId)
        {
            IEnumerable<BookingRecord> recordCollection = this.Provider.DataProvider.Learning.Booking.FetchAllByPersonId(bookerPersonId);
            foreach (BookingRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBookingModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BookingModel' /> instances.
        /// </summary>
        /// <param name="invoiceAddressId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BookingModel' /> instances that match the specified <paramref name='invoiceAddressId' />.
        /// </returns>
        public IEnumerable<LocalBookingModel> FetchAllByInvoiceAddressId(String invoiceAddressId)
        {
            IEnumerable<BookingRecord> recordCollection = this.Provider.DataProvider.Learning.Booking.FetchAllByInvAdd(invoiceAddressId);
            foreach (BookingRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBookingModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BookingModel' /> instances.
        /// </summary>
        /// <param name="notesId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BookingModel' /> instances that match the specified <paramref name='notesId' />.
        /// </returns>
        public IEnumerable<LocalBookingModel> FetchAllByNotesId(String notesId)
        {
            IEnumerable<BookingRecord> recordCollection = this.Provider.DataProvider.Learning.Booking.FetchAllByNotes(notesId);
            foreach (BookingRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBookingModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BookingModel' /> instances.
        /// </summary>
        /// <param name="sourceCodeId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BookingModel' /> instances that match the specified <paramref name='sourceCodeId' />.
        /// </returns>
        public IEnumerable<LocalBookingModel> FetchAllBySourceCodeId(String sourceCodeId)
        {
            IEnumerable<BookingRecord> recordCollection = this.Provider.DataProvider.Learning.Booking.FetchAllBySourceCode(sourceCodeId);
            foreach (BookingRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBookingModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BookingModel' /> instances.
        /// </summary>
        /// <param name="invoiceOrgId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BookingModel' /> instances that match the specified <paramref name='invoiceOrgId' />.
        /// </returns>
        public IEnumerable<LocalBookingModel> FetchAllByInvoiceOrgId(String invoiceOrgId)
        {
            IEnumerable<BookingRecord> recordCollection = this.Provider.DataProvider.Learning.Booking.FetchAllByInvOrgId(invoiceOrgId);
            foreach (BookingRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBookingModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BookingModel' /> instances.
        /// </summary>
        /// <param name="invExtNotesId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BookingModel' /> instances that match the specified <paramref name='invExtNotesId' />.
        /// </returns>
        public IEnumerable<LocalBookingModel> FetchAllByInvExtNotesId(String invExtNotesId)
        {
            IEnumerable<BookingRecord> recordCollection = this.Provider.DataProvider.Learning.Booking.FetchAllByInvExtNotes(invExtNotesId);
            foreach (BookingRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBookingModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BookingModel' /> instances.
        /// </summary>
        /// <param name="priceListId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BookingModel' /> instances that match the specified <paramref name='priceListId' />.
        /// </returns>
        public IEnumerable<LocalBookingModel> FetchAllByPriceListId(String priceListId)
        {
            IEnumerable<BookingRecord> recordCollection = this.Provider.DataProvider.Learning.Booking.FetchAllByPlId(priceListId);
            foreach (BookingRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBookingModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BookingModel' /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BookingModel' /> instances that match the specified <paramref name='opportunityId' />.
        /// </returns>
        public IEnumerable<LocalBookingModel> FetchAllByOpportunityId(String opportunityId)
        {
            IEnumerable<BookingRecord> recordCollection = this.Provider.DataProvider.Learning.Booking.FetchAllByOppId(opportunityId);
            foreach (BookingRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBookingModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BookingModel' /> instances.
        /// </summary>
        /// <param name="delivAddId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BookingModel' /> instances that match the specified <paramref name='delivAddId' />.
        /// </returns>
        public IEnumerable<LocalBookingModel> FetchAllByDelivAddId(String delivAddId)
        {
            IEnumerable<BookingRecord> recordCollection = this.Provider.DataProvider.Learning.Booking.FetchAllByDelivAdd(delivAddId);
            foreach (BookingRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBookingModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BookingModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BookingModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalBookingModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<BookingRecord> recordCollection = this.Provider.DataProvider.Learning.Booking.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (BookingRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBookingModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BookingModel' /> instances.
        /// </summary>
        /// <param name="bookerAddressId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BookingModel' /> instances that match the specified <paramref name='bookerAddressId' />.
        /// </returns>
        public IEnumerable<LocalBookingModel> FetchAllByBookerAddressId(String bookerAddressId)
        {
            IEnumerable<BookingRecord> recordCollection = this.Provider.DataProvider.Learning.Booking.FetchAllByAddId(bookerAddressId);
            foreach (BookingRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBookingModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BookingModel' /> instances.
        /// </summary>
        /// <param name="bookerRoleId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BookingModel' /> instances that match the specified <paramref name='bookerRoleId' />.
        /// </returns>
        public IEnumerable<LocalBookingModel> FetchAllByBookerRoleId(String bookerRoleId)
        {
            IEnumerable<BookingRecord> recordCollection = this.Provider.DataProvider.Learning.Booking.FetchAllByProleId(bookerRoleId);
            foreach (BookingRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBookingModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BookingModel' /> instances.
        /// </summary>
        /// <param name="invoiceRoleId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BookingModel' /> instances that match the specified <paramref name='invoiceRoleId' />.
        /// </returns>
        public IEnumerable<LocalBookingModel> FetchAllByInvoiceRoleId(String invoiceRoleId)
        {
            IEnumerable<BookingRecord> recordCollection = this.Provider.DataProvider.Learning.Booking.FetchAllByInvProleId(invoiceRoleId);
            foreach (BookingRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBookingModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BookingModel' /> instances.
        /// </summary>
        /// <param name="salesChannelId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BookingModel' /> instances that match the specified <paramref name='salesChannelId' />.
        /// </returns>
        public IEnumerable<LocalBookingModel> FetchAllBySalesChannelId(String salesChannelId)
        {
            IEnumerable<BookingRecord> recordCollection = this.Provider.DataProvider.Learning.Booking.FetchAllBySchnId(salesChannelId);
            foreach (BookingRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBookingModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BookingModel' /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref='BookingModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BookingModel' /> instances that match the specified <paramref name='accountId' />.
        /// </returns>
        public IEnumerable<LocalBookingModel> FetchAllByAccountId(String accountId)
        {
            IEnumerable<BookingRecord> recordCollection = this.Provider.DataProvider.Learning.Booking.FetchAllByAccId(accountId);
            foreach (BookingRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBookingModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        Consensus.Learning.IBookingModel IBookingFactory.GetConfirmedEvents(System.String bookId)
        {
            return this.GetConfirmedEvents(bookId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> IBookingFactory.BookingGenerateGrpId(System.String bookId)
        {
            return this.BookingGenerateGrpId(bookId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> IBookingFactory.GetBookingLines(System.String bookId, System.String userLoginId, System.String sellingCompany)
        {
            return this.GetBookingLines(bookId, userLoginId, sellingCompany);
        }

        System.Boolean IBookingFactory.CheckIfBookingAlreadyCancelled(System.String bookId)
        {
            return this.CheckIfBookingAlreadyCancelled(bookId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:BookingModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BookingModel" /> instance.
        /// </returns>
        Consensus.Learning.IBookingModel IBookingFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BookingModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BookingModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> IBookingFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:BookingModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BookingModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IBookingModel IBookingFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IBookingFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="bookerOrgId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="bookerOrgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> IBookingFactory.FetchAllByBookerOrgId(System.String bookerOrgId)
        {
            return this.FetchAllByBookerOrgId(bookerOrgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="bookerPersonId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="bookerPersonId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> IBookingFactory.FetchAllByBookerPersonId(System.String bookerPersonId)
        {
            return this.FetchAllByBookerPersonId(bookerPersonId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="invoiceAddressId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="invoiceAddressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> IBookingFactory.FetchAllByInvoiceAddressId(System.String invoiceAddressId)
        {
            return this.FetchAllByInvoiceAddressId(invoiceAddressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="notesId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="notesId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> IBookingFactory.FetchAllByNotesId(System.String notesId)
        {
            return this.FetchAllByNotesId(notesId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="sourceCodeId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="sourceCodeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> IBookingFactory.FetchAllBySourceCodeId(System.String sourceCodeId)
        {
            return this.FetchAllBySourceCodeId(sourceCodeId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="invoiceOrgId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="invoiceOrgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> IBookingFactory.FetchAllByInvoiceOrgId(System.String invoiceOrgId)
        {
            return this.FetchAllByInvoiceOrgId(invoiceOrgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="invExtNotesId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="invExtNotesId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> IBookingFactory.FetchAllByInvExtNotesId(System.String invExtNotesId)
        {
            return this.FetchAllByInvExtNotesId(invExtNotesId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="priceListId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="priceListId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> IBookingFactory.FetchAllByPriceListId(System.String priceListId)
        {
            return this.FetchAllByPriceListId(priceListId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="opportunityId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> IBookingFactory.FetchAllByOpportunityId(System.String opportunityId)
        {
            return this.FetchAllByOpportunityId(opportunityId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="delivAddId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="delivAddId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> IBookingFactory.FetchAllByDelivAddId(System.String delivAddId)
        {
            return this.FetchAllByDelivAddId(delivAddId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> IBookingFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="bookerAddressId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="bookerAddressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> IBookingFactory.FetchAllByBookerAddressId(System.String bookerAddressId)
        {
            return this.FetchAllByBookerAddressId(bookerAddressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="bookerRoleId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="bookerRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> IBookingFactory.FetchAllByBookerRoleId(System.String bookerRoleId)
        {
            return this.FetchAllByBookerRoleId(bookerRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="invoiceRoleId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="invoiceRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> IBookingFactory.FetchAllByInvoiceRoleId(System.String invoiceRoleId)
        {
            return this.FetchAllByInvoiceRoleId(invoiceRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="salesChannelId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="salesChannelId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> IBookingFactory.FetchAllBySalesChannelId(System.String salesChannelId)
        {
            return this.FetchAllBySalesChannelId(salesChannelId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BookingModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:BookingModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBookingModel> IBookingFactory.FetchAllByAccountId(System.String accountId)
        {
            return this.FetchAllByAccountId(accountId);
        }

        #endregion
    }
}
