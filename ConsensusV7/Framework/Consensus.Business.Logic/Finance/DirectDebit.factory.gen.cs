using Consensus.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="DirectDebitModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalDirectDebitFactory : LocalFactory<LocalDirectDebitModel, DirectdebitRecord, String>, IDirectDebitFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='DirectDebitModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='DirectDebitModel' /> instance.
        /// </returns>
        public LocalDirectDebitModel Create()
        {
            return new LocalDirectDebitModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='DirectDebitModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='DirectDebitModel' /> instances.
        /// </returns>
        public IEnumerable<LocalDirectDebitModel> FetchAll()
        {
            IEnumerable<DirectdebitRecord> recordCollection = this.Provider.DataProvider.Finance.DirectDebit.FetchAll();
            foreach (DirectdebitRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalDirectDebitModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='DirectDebitModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='DirectDebitModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='DirectDebitModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalDirectDebitModel FetchById(String id)
        {
            DirectdebitRecord record = this.Provider.DataProvider.Finance.DirectDebit.FetchById(id);
            if (record == null)
                return null;
            return new LocalDirectDebitModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='DirectDebit/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Finance.DirectDebit.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='DirectDebitModel' /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref='DirectDebitModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='DirectDebitModel' /> instances that match the specified <paramref name='memberPeriodId' />.
        /// </returns>
        public IEnumerable<LocalDirectDebitModel> FetchAllByMemberPeriodId(String memberPeriodId)
        {
            IEnumerable<DirectdebitRecord> recordCollection = this.Provider.DataProvider.Finance.DirectDebit.FetchAllByRecId(memberPeriodId);
            foreach (DirectdebitRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalDirectDebitModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        /// Validates account number and sort code. If valid returns bank details
        /// </summary>
        /// <param name="accountNumber">Account number</param>
        /// <param name="sortCode">Sort code</param>
        /// <returns>Returns bank details if account number and sort code is valid else returns error message</returns>
        AfdResponse IDirectDebitFactory.AfdBankFinderAccountNumberValidation(System.String accountNumber, System.String sortCode)
        {
            return this.AfdBankFinderAccountNumberValidation(accountNumber, sortCode);
        }

        /// <summary>
        ///     Creates a new <see cref="!:DirectDebitModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:DirectDebitModel" /> instance.
        /// </returns>
        Consensus.Finance.IDirectDebitModel IDirectDebitFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:DirectDebitModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:DirectDebitModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IDirectDebitModel> IDirectDebitFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:DirectDebitModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:DirectDebitModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:DirectDebitModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IDirectDebitModel IDirectDebitFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IDirectDebitFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:DirectDebitModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:DirectDebitModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:DirectDebitModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IDirectDebitModel> IDirectDebitFactory.FetchAllByMemberPeriodId(System.String memberPeriodId)
        {
            return this.FetchAllByMemberPeriodId(memberPeriodId);
        }

        #endregion
    }
}
