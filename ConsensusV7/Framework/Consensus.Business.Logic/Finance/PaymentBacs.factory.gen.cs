using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PaymentBacsModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPaymentBacsFactory : LocalFactory<LocalPaymentBacsModel, PaymentRecord, String>, IPaymentBacsFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='PaymentBacsModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='PaymentBacsModel' /> instance.
        /// </returns>
        public LocalPaymentBacsModel Create()
        {
            return new LocalPaymentBacsModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='PaymentBacsModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='PaymentBacsModel' /> instances.
        /// </returns>
        public IEnumerable<LocalPaymentBacsModel> FetchAll()
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAll();
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "06-BACS")
                {
                    yield return new LocalPaymentBacsModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='PaymentBacsModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='PaymentBacsModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentBacsModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalPaymentBacsModel FetchById(String id)
        {
            PaymentRecord record = this.Provider.DataProvider.Finance.Payment.FetchById(id);
            if (record == null)
                return null;
            return new LocalPaymentBacsModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='PaymentBacs/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Finance.Payment.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PaymentBacsModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='PaymentBacsModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentBacsModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalPaymentBacsModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "06-BACS")
                {
                    yield return new LocalPaymentBacsModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PaymentBacsModel' /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref='PaymentBacsModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentBacsModel' /> instances that match the specified <paramref name='memberPeriodId' />.
        /// </returns>
        public IEnumerable<LocalPaymentBacsModel> FetchAllByMemberPeriodId(String memberPeriodId)
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAllByMepId(memberPeriodId);
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "06-BACS")
                {
                    yield return new LocalPaymentBacsModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PaymentBacsModel' /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref='PaymentBacsModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentBacsModel' /> instances that match the specified <paramref name='organisationId' />.
        /// </returns>
        public IEnumerable<LocalPaymentBacsModel> FetchAllByOrganisationId(String organisationId)
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAllByOrgId(organisationId);
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "06-BACS")
                {
                    yield return new LocalPaymentBacsModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PaymentBacsModel' /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref='PaymentBacsModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentBacsModel' /> instances that match the specified <paramref name='personId' />.
        /// </returns>
        public IEnumerable<LocalPaymentBacsModel> FetchAllByPersonId(String personId)
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAllByPnId(personId);
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "06-BACS")
                {
                    yield return new LocalPaymentBacsModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PaymentBacsModel' /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref='PaymentBacsModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentBacsModel' /> instances that match the specified <paramref name='bookingId' />.
        /// </returns>
        public IEnumerable<LocalPaymentBacsModel> FetchAllByBookingId(String bookingId)
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAllByBookId(bookingId);
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "06-BACS")
                {
                    yield return new LocalPaymentBacsModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PaymentBacsModel' /> instances.
        /// </summary>
        /// <param name="refundId">
        ///     The value which identifies the <see cref='PaymentBacsModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentBacsModel' /> instances that match the specified <paramref name='refundId' />.
        /// </returns>
        public IEnumerable<LocalPaymentBacsModel> FetchAllByRefundId(String refundId)
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAllByRefundPayId(refundId);
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "06-BACS")
                {
                    yield return new LocalPaymentBacsModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PaymentBacsModel' /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref='PaymentBacsModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentBacsModel' /> instances that match the specified <paramref name='addressId' />.
        /// </returns>
        public IEnumerable<LocalPaymentBacsModel> FetchAllByAddressId(String addressId)
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAllByAddId(addressId);
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "06-BACS")
                {
                    yield return new LocalPaymentBacsModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PaymentBacsModel' /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref='PaymentBacsModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentBacsModel' /> instances that match the specified <paramref name='accountId' />.
        /// </returns>
        public IEnumerable<LocalPaymentBacsModel> FetchAllByAccountId(String accountId)
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAllByAccId(accountId);
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "06-BACS")
                {
                    yield return new LocalPaymentBacsModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PaymentBacsModel' /> instances.
        /// </summary>
        /// <param name="letterTemplateId">
        ///     The value which identifies the <see cref='PaymentBacsModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentBacsModel' /> instances that match the specified <paramref name='letterTemplateId' />.
        /// </returns>
        public IEnumerable<LocalPaymentBacsModel> FetchAllByLetterTemplateId(String letterTemplateId)
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAllByLtId(letterTemplateId);
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "06-BACS")
                {
                    yield return new LocalPaymentBacsModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PaymentBacsModel' /> instances.
        /// </summary>
        /// <param name="cardholderRoleId">
        ///     The value which identifies the <see cref='PaymentBacsModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentBacsModel' /> instances that match the specified <paramref name='cardholderRoleId' />.
        /// </returns>
        public IEnumerable<LocalPaymentBacsModel> FetchAllByCardholderRoleId(String cardholderRoleId)
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAllByCardholderProleId(cardholderRoleId);
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "06-BACS")
                {
                    yield return new LocalPaymentBacsModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:PaymentBacsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PaymentBacsModel" /> instance.
        /// </returns>
        Consensus.Finance.IPaymentBacsModel IPaymentBacsFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PaymentBacsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> IPaymentBacsFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PaymentBacsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PaymentBacsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IPaymentBacsModel IPaymentBacsFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IPaymentBacsFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:PaymentBacsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> IPaymentBacsFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:PaymentBacsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> IPaymentBacsFactory.FetchAllByMemberPeriodId(System.String memberPeriodId)
        {
            return this.FetchAllByMemberPeriodId(memberPeriodId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:PaymentBacsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> IPaymentBacsFactory.FetchAllByOrganisationId(System.String organisationId)
        {
            return this.FetchAllByOrganisationId(organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:PaymentBacsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> IPaymentBacsFactory.FetchAllByPersonId(System.String personId)
        {
            return this.FetchAllByPersonId(personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref="!:PaymentBacsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instances that match the specified <paramref name="bookingId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> IPaymentBacsFactory.FetchAllByBookingId(System.String bookingId)
        {
            return this.FetchAllByBookingId(bookingId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </summary>
        /// <param name="refundId">
        ///     The value which identifies the <see cref="!:PaymentBacsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instances that match the specified <paramref name="refundId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> IPaymentBacsFactory.FetchAllByRefundId(System.String refundId)
        {
            return this.FetchAllByRefundId(refundId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:PaymentBacsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> IPaymentBacsFactory.FetchAllByAddressId(System.String addressId)
        {
            return this.FetchAllByAddressId(addressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:PaymentBacsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> IPaymentBacsFactory.FetchAllByAccountId(System.String accountId)
        {
            return this.FetchAllByAccountId(accountId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </summary>
        /// <param name="letterTemplateId">
        ///     The value which identifies the <see cref="!:PaymentBacsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instances that match the specified <paramref name="letterTemplateId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> IPaymentBacsFactory.FetchAllByLetterTemplateId(System.String letterTemplateId)
        {
            return this.FetchAllByLetterTemplateId(letterTemplateId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentBacsModel" /> instances.
        /// </summary>
        /// <param name="cardholderRoleId">
        ///     The value which identifies the <see cref="!:PaymentBacsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentBacsModel" /> instances that match the specified <paramref name="cardholderRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentBacsModel> IPaymentBacsFactory.FetchAllByCardholderRoleId(System.String cardholderRoleId)
        {
            return this.FetchAllByCardholderRoleId(cardholderRoleId);
        }

        #endregion
    }
}
