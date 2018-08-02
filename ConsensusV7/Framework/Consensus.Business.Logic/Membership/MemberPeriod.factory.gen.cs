using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="MemberPeriodModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalMemberPeriodFactory : LocalFactory<LocalMemberPeriodModel, MemberPeriodRecord, String>, IMemberPeriodFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='MemberPeriodModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='MemberPeriodModel' /> instance.
        /// </returns>
        public LocalMemberPeriodModel Create()
        {
            return new LocalMemberPeriodModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='MemberPeriodModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='MemberPeriodModel' /> instances.
        /// </returns>
        public IEnumerable<LocalMemberPeriodModel> FetchAll()
        {
            IEnumerable<MemberPeriodRecord> recordCollection = this.Provider.DataProvider.Membership.MemberPeriod.FetchAll();
            foreach (MemberPeriodRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberPeriodModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='MemberPeriodModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='MemberPeriodModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberPeriodModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalMemberPeriodModel FetchById(String id)
        {
            MemberPeriodRecord record = this.Provider.DataProvider.Membership.MemberPeriod.FetchById(id);
            if (record == null)
                return null;
            return new LocalMemberPeriodModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='MemberPeriod/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Membership.MemberPeriod.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MemberPeriodModel' /> instances.
        /// </summary>
        /// <param name="memIdId">
        ///     The value which identifies the <see cref='MemberPeriodModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberPeriodModel' /> instances that match the specified <paramref name='memIdId' />.
        /// </returns>
        public IEnumerable<LocalMemberPeriodModel> FetchAllByMemIdId(String memIdId)
        {
            IEnumerable<MemberPeriodRecord> recordCollection = this.Provider.DataProvider.Membership.MemberPeriod.FetchAllByMemId(memIdId);
            foreach (MemberPeriodRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberPeriodModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MemberPeriodModel' /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref='MemberPeriodModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberPeriodModel' /> instances that match the specified <paramref name='productId' />.
        /// </returns>
        public IEnumerable<LocalMemberPeriodModel> FetchAllByProductId(String productId)
        {
            IEnumerable<MemberPeriodRecord> recordCollection = this.Provider.DataProvider.Membership.MemberPeriod.FetchAllByProdId(productId);
            foreach (MemberPeriodRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberPeriodModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MemberPeriodModel' /> instances.
        /// </summary>
        /// <param name="invOrganisationId">
        ///     The value which identifies the <see cref='MemberPeriodModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberPeriodModel' /> instances that match the specified <paramref name='invOrganisationId' />.
        /// </returns>
        public IEnumerable<LocalMemberPeriodModel> FetchAllByInvOrganisationId(String invOrganisationId)
        {
            IEnumerable<MemberPeriodRecord> recordCollection = this.Provider.DataProvider.Membership.MemberPeriod.FetchAllByInvOrgId(invOrganisationId);
            foreach (MemberPeriodRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberPeriodModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MemberPeriodModel' /> instances.
        /// </summary>
        /// <param name="invoiceRoleId">
        ///     The value which identifies the <see cref='MemberPeriodModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberPeriodModel' /> instances that match the specified <paramref name='invoiceRoleId' />.
        /// </returns>
        public IEnumerable<LocalMemberPeriodModel> FetchAllByInvoiceRoleId(String invoiceRoleId)
        {
            IEnumerable<MemberPeriodRecord> recordCollection = this.Provider.DataProvider.Membership.MemberPeriod.FetchAllByInvProleId(invoiceRoleId);
            foreach (MemberPeriodRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberPeriodModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MemberPeriodModel' /> instances.
        /// </summary>
        /// <param name="invAddressId">
        ///     The value which identifies the <see cref='MemberPeriodModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberPeriodModel' /> instances that match the specified <paramref name='invAddressId' />.
        /// </returns>
        public IEnumerable<LocalMemberPeriodModel> FetchAllByInvAddressId(String invAddressId)
        {
            IEnumerable<MemberPeriodRecord> recordCollection = this.Provider.DataProvider.Membership.MemberPeriod.FetchAllByInvAddId(invAddressId);
            foreach (MemberPeriodRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberPeriodModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MemberPeriodModel' /> instances.
        /// </summary>
        /// <param name="sourceCodeId">
        ///     The value which identifies the <see cref='MemberPeriodModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberPeriodModel' /> instances that match the specified <paramref name='sourceCodeId' />.
        /// </returns>
        public IEnumerable<LocalMemberPeriodModel> FetchAllBySourceCodeId(String sourceCodeId)
        {
            IEnumerable<MemberPeriodRecord> recordCollection = this.Provider.DataProvider.Membership.MemberPeriod.FetchAllByPmId(sourceCodeId);
            foreach (MemberPeriodRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberPeriodModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MemberPeriodModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='MemberPeriodModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberPeriodModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalMemberPeriodModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<MemberPeriodRecord> recordCollection = this.Provider.DataProvider.Membership.MemberPeriod.FetchAllBySelcoSpId(sellingCompanyId);
            foreach (MemberPeriodRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberPeriodModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MemberPeriodModel' /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref='MemberPeriodModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberPeriodModel' /> instances that match the specified <paramref name='accountId' />.
        /// </returns>
        public IEnumerable<LocalMemberPeriodModel> FetchAllByAccountId(String accountId)
        {
            IEnumerable<MemberPeriodRecord> recordCollection = this.Provider.DataProvider.Membership.MemberPeriod.FetchAllByAccId(accountId);
            foreach (MemberPeriodRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberPeriodModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Performs rollback membership on a single <see cref="!:MemberPeriodModel" /> instance.
        ///                     Functionality replicated from the SQL performed in V6.5.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instance to be modified.
        /// </param>
        /// <param name="status">
        ///     The status value which should be set.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instance that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        Consensus.Membership.IMemberPeriodModel IMemberPeriodFactory.RollbackMembership(System.String memberPeriodId, System.String status)
        {
            return this.RollbackMembership(memberPeriodId, status);
        }

        /// <summary>
        ///     Cancels existing DDs on <see cref="!:MemberPeriodModel" /> instance.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instance to be modified.
        /// </param>
        /// <param name="directDebitId">
        ///     The new Direct Debit Id which identifies the instance which should not be modified.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instance that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        Consensus.Membership.IMemberPeriodModel IMemberPeriodFactory.CancelExistingDirectDebits(System.String memberPeriodId, System.String directDebitId)
        {
            return this.CancelExistingDirectDebits(memberPeriodId, directDebitId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:MemberPeriodModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MemberPeriodModel" /> instance.
        /// </returns>
        Consensus.Membership.IMemberPeriodModel IMemberPeriodFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MemberPeriodModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberPeriodModel> IMemberPeriodFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:MemberPeriodModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MemberPeriodModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Membership.IMemberPeriodModel IMemberPeriodFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IMemberPeriodFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="memIdId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="memIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberPeriodModel> IMemberPeriodFactory.FetchAllByMemIdId(System.String memIdId)
        {
            return this.FetchAllByMemIdId(memIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberPeriodModel> IMemberPeriodFactory.FetchAllByProductId(System.String productId)
        {
            return this.FetchAllByProductId(productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="invOrganisationId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="invOrganisationId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberPeriodModel> IMemberPeriodFactory.FetchAllByInvOrganisationId(System.String invOrganisationId)
        {
            return this.FetchAllByInvOrganisationId(invOrganisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="invoiceRoleId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="invoiceRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberPeriodModel> IMemberPeriodFactory.FetchAllByInvoiceRoleId(System.String invoiceRoleId)
        {
            return this.FetchAllByInvoiceRoleId(invoiceRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="invAddressId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="invAddressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberPeriodModel> IMemberPeriodFactory.FetchAllByInvAddressId(System.String invAddressId)
        {
            return this.FetchAllByInvAddressId(invAddressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="sourceCodeId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="sourceCodeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberPeriodModel> IMemberPeriodFactory.FetchAllBySourceCodeId(System.String sourceCodeId)
        {
            return this.FetchAllBySourceCodeId(sourceCodeId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberPeriodModel> IMemberPeriodFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberPeriodModel" /> instances.
        /// </summary>
        /// <param name="accountId">
        ///     The value which identifies the <see cref="!:MemberPeriodModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberPeriodModel" /> instances that match the specified <paramref name="accountId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberPeriodModel> IMemberPeriodFactory.FetchAllByAccountId(System.String accountId)
        {
            return this.FetchAllByAccountId(accountId);
        }

        #endregion
    }
}
