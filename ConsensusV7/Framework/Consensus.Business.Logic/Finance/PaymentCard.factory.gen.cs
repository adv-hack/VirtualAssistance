using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PaymentCardModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPaymentCardFactory : LocalFactory<LocalPaymentCardModel, PaymentRecord, String>, IPaymentCardFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='PaymentCardModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='PaymentCardModel' /> instance.
        /// </returns>
        public LocalPaymentCardModel Create()
        {
            return new LocalPaymentCardModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='PaymentCardModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='PaymentCardModel' /> instances.
        /// </returns>
        public IEnumerable<LocalPaymentCardModel> FetchAll()
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAll();
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "02-Credit/Debit Card")
                {
                    yield return new LocalPaymentCardModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='PaymentCardModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='PaymentCardModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentCardModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalPaymentCardModel FetchById(String id)
        {
            PaymentRecord record = this.Provider.DataProvider.Finance.Payment.FetchById(id);
            if (record == null)
                return null;
            return new LocalPaymentCardModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='PaymentCard/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Finance.Payment.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PaymentCardModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='PaymentCardModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentCardModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalPaymentCardModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "02-Credit/Debit Card")
                {
                    yield return new LocalPaymentCardModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PaymentCardModel' /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref='PaymentCardModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentCardModel' /> instances that match the specified <paramref name='memberPeriodId' />.
        /// </returns>
        public IEnumerable<LocalPaymentCardModel> FetchAllByMemberPeriodId(String memberPeriodId)
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAllByMepId(memberPeriodId);
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "02-Credit/Debit Card")
                {
                    yield return new LocalPaymentCardModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PaymentCardModel' /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref='PaymentCardModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentCardModel' /> instances that match the specified <paramref name='organisationId' />.
        /// </returns>
        public IEnumerable<LocalPaymentCardModel> FetchAllByOrganisationId(String organisationId)
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAllByOrgId(organisationId);
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "02-Credit/Debit Card")
                {
                    yield return new LocalPaymentCardModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PaymentCardModel' /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref='PaymentCardModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentCardModel' /> instances that match the specified <paramref name='personId' />.
        /// </returns>
        public IEnumerable<LocalPaymentCardModel> FetchAllByPersonId(String personId)
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAllByPnId(personId);
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "02-Credit/Debit Card")
                {
                    yield return new LocalPaymentCardModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PaymentCardModel' /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref='PaymentCardModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentCardModel' /> instances that match the specified <paramref name='bookingId' />.
        /// </returns>
        public IEnumerable<LocalPaymentCardModel> FetchAllByBookingId(String bookingId)
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAllByBookId(bookingId);
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "02-Credit/Debit Card")
                {
                    yield return new LocalPaymentCardModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PaymentCardModel' /> instances.
        /// </summary>
        /// <param name="refundId">
        ///     The value which identifies the <see cref='PaymentCardModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentCardModel' /> instances that match the specified <paramref name='refundId' />.
        /// </returns>
        public IEnumerable<LocalPaymentCardModel> FetchAllByRefundId(String refundId)
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAllByRefundPayId(refundId);
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "02-Credit/Debit Card")
                {
                    yield return new LocalPaymentCardModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PaymentCardModel' /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref='PaymentCardModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentCardModel' /> instances that match the specified <paramref name='addressId' />.
        /// </returns>
        public IEnumerable<LocalPaymentCardModel> FetchAllByAddressId(String addressId)
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAllByAddId(addressId);
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "02-Credit/Debit Card")
                {
                    yield return new LocalPaymentCardModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PaymentCardModel' /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref='PaymentCardModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentCardModel' /> instances that match the specified <paramref name='accountId' />.
        /// </returns>
        public IEnumerable<LocalPaymentCardModel> FetchAllByAccountId(String accountId)
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAllByAccId(accountId);
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "02-Credit/Debit Card")
                {
                    yield return new LocalPaymentCardModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PaymentCardModel' /> instances.
        /// </summary>
        /// <param name="letterTemplateId">
        ///     The value which identifies the <see cref='PaymentCardModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentCardModel' /> instances that match the specified <paramref name='letterTemplateId' />.
        /// </returns>
        public IEnumerable<LocalPaymentCardModel> FetchAllByLetterTemplateId(String letterTemplateId)
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAllByLtId(letterTemplateId);
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "02-Credit/Debit Card")
                {
                    yield return new LocalPaymentCardModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PaymentCardModel' /> instances.
        /// </summary>
        /// <param name="cardholderRoleId">
        ///     The value which identifies the <see cref='PaymentCardModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PaymentCardModel' /> instances that match the specified <paramref name='cardholderRoleId' />.
        /// </returns>
        public IEnumerable<LocalPaymentCardModel> FetchAllByCardholderRoleId(String cardholderRoleId)
        {
            IEnumerable<PaymentRecord> recordCollection = this.Provider.DataProvider.Finance.Payment.FetchAllByCardholderProleId(cardholderRoleId);
            foreach (PaymentRecord record in recordCollection)
            {
                if (record != null && record.Type == "02-Credit/Debit Card")
                {
                    yield return new LocalPaymentCardModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:PaymentCardModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PaymentCardModel" /> instance.
        /// </returns>
        Consensus.Finance.IPaymentCardModel IPaymentCardFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PaymentCardModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PaymentCardModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> IPaymentCardFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PaymentCardModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PaymentCardModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IPaymentCardModel IPaymentCardFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IPaymentCardFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> IPaymentCardFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> IPaymentCardFactory.FetchAllByMemberPeriodId(System.String memberPeriodId)
        {
            return this.FetchAllByMemberPeriodId(memberPeriodId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> IPaymentCardFactory.FetchAllByOrganisationId(System.String organisationId)
        {
            return this.FetchAllByOrganisationId(organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> IPaymentCardFactory.FetchAllByPersonId(System.String personId)
        {
            return this.FetchAllByPersonId(personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="bookingId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> IPaymentCardFactory.FetchAllByBookingId(System.String bookingId)
        {
            return this.FetchAllByBookingId(bookingId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="refundId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="refundId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> IPaymentCardFactory.FetchAllByRefundId(System.String refundId)
        {
            return this.FetchAllByRefundId(refundId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> IPaymentCardFactory.FetchAllByAddressId(System.String addressId)
        {
            return this.FetchAllByAddressId(addressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> IPaymentCardFactory.FetchAllByAccountId(System.String accountId)
        {
            return this.FetchAllByAccountId(accountId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="letterTemplateId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="letterTemplateId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> IPaymentCardFactory.FetchAllByLetterTemplateId(System.String letterTemplateId)
        {
            return this.FetchAllByLetterTemplateId(letterTemplateId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PaymentCardModel" /> instances.
        /// </summary>
        /// <param name="cardholderRoleId">
        ///     The value which identifies the <see cref="!:PaymentCardModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PaymentCardModel" /> instances that match the specified <paramref name="cardholderRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPaymentCardModel> IPaymentCardFactory.FetchAllByCardholderRoleId(System.String cardholderRoleId)
        {
            return this.FetchAllByCardholderRoleId(cardholderRoleId);
        }

        #endregion
    }
}
