using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="BookingTermsModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalBookingTermsFactory : LocalFactory<LocalBookingTermsModel, BookingTermsRecord, String>, IBookingTermsFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='BookingTermsModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='BookingTermsModel' /> instance.
        /// </returns>
        public LocalBookingTermsModel Create()
        {
            return new LocalBookingTermsModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='BookingTermsModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='BookingTermsModel' /> instances.
        /// </returns>
        public IEnumerable<LocalBookingTermsModel> FetchAll()
        {
            IEnumerable<BookingTermsRecord> recordCollection = this.Provider.DataProvider.Finance.BookingTerms.FetchAll();
            foreach (BookingTermsRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBookingTermsModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='BookingTermsModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='BookingTermsModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BookingTermsModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalBookingTermsModel FetchById(String id)
        {
            BookingTermsRecord record = this.Provider.DataProvider.Finance.BookingTerms.FetchById(id);
            if (record == null)
                return null;
            return new LocalBookingTermsModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='BookingTerms/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Finance.BookingTerms.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:BookingTermsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BookingTermsModel" /> instance.
        /// </returns>
        Consensus.Finance.IBookingTermsModel IBookingTermsFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BookingTermsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BookingTermsModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IBookingTermsModel> IBookingTermsFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:BookingTermsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BookingTermsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingTermsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IBookingTermsModel IBookingTermsFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IBookingTermsFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
