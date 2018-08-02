using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="InvoiceModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalInvoiceFactory : LocalFactory<LocalInvoiceModel, InvheaderRecord, String>, IInvoiceFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='InvoiceModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='InvoiceModel' /> instance.
        /// </returns>
        public LocalInvoiceModel Create()
        {
            return new LocalInvoiceModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='InvoiceModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='InvoiceModel' /> instances.
        /// </returns>
        public IEnumerable<LocalInvoiceModel> FetchAll()
        {
            IEnumerable<InvheaderRecord> recordCollection = this.Provider.DataProvider.Finance.Invoice.FetchAll();
            foreach (InvheaderRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalInvoiceModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='InvoiceModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='InvoiceModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='InvoiceModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalInvoiceModel FetchById(String id)
        {
            InvheaderRecord record = this.Provider.DataProvider.Finance.Invoice.FetchById(id);
            if (record == null)
                return null;
            return new LocalInvoiceModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Invoice/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Finance.Invoice.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='InvoiceModel' /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='InvoiceModel' /> instances that match the specified <paramref name='organisationId' />.
        /// </returns>
        public IEnumerable<LocalInvoiceModel> FetchAllByOrganisationId(String organisationId)
        {
            IEnumerable<InvheaderRecord> recordCollection = this.Provider.DataProvider.Finance.Invoice.FetchAllByOrgId(organisationId);
            foreach (InvheaderRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalInvoiceModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='InvoiceModel' /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='InvoiceModel' /> instances that match the specified <paramref name='personId' />.
        /// </returns>
        public IEnumerable<LocalInvoiceModel> FetchAllByPersonId(String personId)
        {
            IEnumerable<InvheaderRecord> recordCollection = this.Provider.DataProvider.Finance.Invoice.FetchAllByPersonId(personId);
            foreach (InvheaderRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalInvoiceModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='InvoiceModel' /> instances.
        /// </summary>
        /// <param name="salesPersonId">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='InvoiceModel' /> instances that match the specified <paramref name='salesPersonId' />.
        /// </returns>
        public IEnumerable<LocalInvoiceModel> FetchAllBySalesPersonId(String salesPersonId)
        {
            IEnumerable<InvheaderRecord> recordCollection = this.Provider.DataProvider.Finance.Invoice.FetchAllBySalesmanId(salesPersonId);
            foreach (InvheaderRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalInvoiceModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='InvoiceModel' /> instances.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='InvoiceModel' /> instances that match the specified <paramref name='addId' />.
        /// </returns>
        public IEnumerable<LocalInvoiceModel> FetchAllByAddId(String addId)
        {
            IEnumerable<InvheaderRecord> recordCollection = this.Provider.DataProvider.Finance.Invoice.FetchAllByAdd(addId);
            foreach (InvheaderRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalInvoiceModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='InvoiceModel' /> instances.
        /// </summary>
        /// <param name="creditNteRefId">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='InvoiceModel' /> instances that match the specified <paramref name='creditNteRefId' />.
        /// </returns>
        public IEnumerable<LocalInvoiceModel> FetchAllByCreditNteRefId(String creditNteRefId)
        {
            IEnumerable<InvheaderRecord> recordCollection = this.Provider.DataProvider.Finance.Invoice.FetchAllByCreditNteRef(creditNteRefId);
            foreach (InvheaderRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalInvoiceModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='InvoiceModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='InvoiceModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalInvoiceModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<InvheaderRecord> recordCollection = this.Provider.DataProvider.Finance.Invoice.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (InvheaderRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalInvoiceModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='InvoiceModel' /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='InvoiceModel' /> instances that match the specified <paramref name='memberPeriodId' />.
        /// </returns>
        public IEnumerable<LocalInvoiceModel> FetchAllByMemberPeriodId(String memberPeriodId)
        {
            IEnumerable<InvheaderRecord> recordCollection = this.Provider.DataProvider.Finance.Invoice.FetchAllByMepId(memberPeriodId);
            foreach (InvheaderRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalInvoiceModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='InvoiceModel' /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='InvoiceModel' /> instances that match the specified <paramref name='packId' />.
        /// </returns>
        public IEnumerable<LocalInvoiceModel> FetchAllByPackId(String packId)
        {
            IEnumerable<InvheaderRecord> recordCollection = this.Provider.DataProvider.Finance.Invoice.FetchAllByLtId(packId);
            foreach (InvheaderRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalInvoiceModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='InvoiceModel' /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='InvoiceModel' /> instances that match the specified <paramref name='accountId' />.
        /// </returns>
        public IEnumerable<LocalInvoiceModel> FetchAllByAccountId(String accountId)
        {
            IEnumerable<InvheaderRecord> recordCollection = this.Provider.DataProvider.Finance.Invoice.FetchAllByAccId(accountId);
            foreach (InvheaderRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalInvoiceModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='InvoiceModel' /> instances.
        /// </summary>
        /// <param name="salesProleIdId">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='InvoiceModel' /> instances that match the specified <paramref name='salesProleIdId' />.
        /// </returns>
        public IEnumerable<LocalInvoiceModel> FetchAllBySalesProleIdId(String salesProleIdId)
        {
            IEnumerable<InvheaderRecord> recordCollection = this.Provider.DataProvider.Finance.Invoice.FetchAllBySalesProleId(salesProleIdId);
            foreach (InvheaderRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalInvoiceModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='InvoiceModel' /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref='InvoiceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='InvoiceModel' /> instances that match the specified <paramref name='proleIdId' />.
        /// </returns>
        public IEnumerable<LocalInvoiceModel> FetchAllByProleIdId(String proleIdId)
        {
            IEnumerable<InvheaderRecord> recordCollection = this.Provider.DataProvider.Finance.Invoice.FetchAllByProleId(proleIdId);
            foreach (InvheaderRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalInvoiceModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        System.Boolean IInvoiceFactory.CheckIfInvoiceCredited(System.String invId)
        {
            return this.CheckIfInvoiceCredited(invId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> IInvoiceFactory.CreditInvoice(System.String invId, System.String userloginId)
        {
            return this.CreditInvoice(invId, userloginId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:InvoiceModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:InvoiceModel" /> instance.
        /// </returns>
        Consensus.Finance.IInvoiceModel IInvoiceFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:InvoiceModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:InvoiceModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> IInvoiceFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:InvoiceModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:InvoiceModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IInvoiceModel IInvoiceFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IInvoiceFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> IInvoiceFactory.FetchAllByOrganisationId(System.String organisationId)
        {
            return this.FetchAllByOrganisationId(organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> IInvoiceFactory.FetchAllByPersonId(System.String personId)
        {
            return this.FetchAllByPersonId(personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="salesPersonId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="salesPersonId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> IInvoiceFactory.FetchAllBySalesPersonId(System.String salesPersonId)
        {
            return this.FetchAllBySalesPersonId(salesPersonId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="addId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> IInvoiceFactory.FetchAllByAddId(System.String addId)
        {
            return this.FetchAllByAddId(addId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="creditNteRefId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="creditNteRefId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> IInvoiceFactory.FetchAllByCreditNteRefId(System.String creditNteRefId)
        {
            return this.FetchAllByCreditNteRefId(creditNteRefId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> IInvoiceFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> IInvoiceFactory.FetchAllByMemberPeriodId(System.String memberPeriodId)
        {
            return this.FetchAllByMemberPeriodId(memberPeriodId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="packId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="packId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> IInvoiceFactory.FetchAllByPackId(System.String packId)
        {
            return this.FetchAllByPackId(packId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> IInvoiceFactory.FetchAllByAccountId(System.String accountId)
        {
            return this.FetchAllByAccountId(accountId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="salesProleIdId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="salesProleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> IInvoiceFactory.FetchAllBySalesProleIdId(System.String salesProleIdId)
        {
            return this.FetchAllBySalesProleIdId(salesProleIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:InvoiceModel" /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref="!:InvoiceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:InvoiceModel" /> instances that match the specified <paramref name="proleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IInvoiceModel> IInvoiceFactory.FetchAllByProleIdId(System.String proleIdId)
        {
            return this.FetchAllByProleIdId(proleIdId);
        }

        #endregion
    }
}
