using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PayAllocationModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPayAllocationFactory : LocalFactory<LocalPayAllocationModel, PayAllocationRecord, String>, IPayAllocationFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='PayAllocationModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='PayAllocationModel' /> instance.
        /// </returns>
        public LocalPayAllocationModel Create()
        {
            return new LocalPayAllocationModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='PayAllocationModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='PayAllocationModel' /> instances.
        /// </returns>
        public IEnumerable<LocalPayAllocationModel> FetchAll()
        {
            IEnumerable<PayAllocationRecord> recordCollection = this.Provider.DataProvider.Finance.PayAllocation.FetchAll();
            foreach (PayAllocationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPayAllocationModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='PayAllocationModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='PayAllocationModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PayAllocationModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalPayAllocationModel FetchById(String id)
        {
            PayAllocationRecord record = this.Provider.DataProvider.Finance.PayAllocation.FetchById(id);
            if (record == null)
                return null;
            return new LocalPayAllocationModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='PayAllocation/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Finance.PayAllocation.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PayAllocationModel' /> instances.
        /// </summary>
        /// <param name="invIdId">
        ///     The value which identifies the <see cref='PayAllocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PayAllocationModel' /> instances that match the specified <paramref name='invIdId' />.
        /// </returns>
        public IEnumerable<LocalPayAllocationModel> FetchAllByInvIdId(String invIdId)
        {
            IEnumerable<PayAllocationRecord> recordCollection = this.Provider.DataProvider.Finance.PayAllocation.FetchAllByInvId(invIdId);
            foreach (PayAllocationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPayAllocationModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PayAllocationModel' /> instances.
        /// </summary>
        /// <param name="payIdId">
        ///     The value which identifies the <see cref='PayAllocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PayAllocationModel' /> instances that match the specified <paramref name='payIdId' />.
        /// </returns>
        public IEnumerable<LocalPayAllocationModel> FetchAllByPayIdId(String payIdId)
        {
            IEnumerable<PayAllocationRecord> recordCollection = this.Provider.DataProvider.Finance.PayAllocation.FetchAllByPayId(payIdId);
            foreach (PayAllocationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPayAllocationModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PayAllocationModel' /> instances.
        /// </summary>
        /// <param name="creditIdId">
        ///     The value which identifies the <see cref='PayAllocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PayAllocationModel' /> instances that match the specified <paramref name='creditIdId' />.
        /// </returns>
        public IEnumerable<LocalPayAllocationModel> FetchAllByCreditIdId(String creditIdId)
        {
            IEnumerable<PayAllocationRecord> recordCollection = this.Provider.DataProvider.Finance.PayAllocation.FetchAllByCreditId(creditIdId);
            foreach (PayAllocationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPayAllocationModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:PayAllocationModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PayAllocationModel" /> instance.
        /// </returns>
        Consensus.Finance.IPayAllocationModel IPayAllocationFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PayAllocationModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PayAllocationModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPayAllocationModel> IPayAllocationFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PayAllocationModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PayAllocationModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PayAllocationModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IPayAllocationModel IPayAllocationFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IPayAllocationFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PayAllocationModel" /> instances.
        /// </summary>
        /// <param name="invIdId">
        ///     The value which identifies the <see cref="!:PayAllocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PayAllocationModel" /> instances that match the specified <paramref name="invIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPayAllocationModel> IPayAllocationFactory.FetchAllByInvIdId(System.String invIdId)
        {
            return this.FetchAllByInvIdId(invIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PayAllocationModel" /> instances.
        /// </summary>
        /// <param name="payIdId">
        ///     The value which identifies the <see cref="!:PayAllocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PayAllocationModel" /> instances that match the specified <paramref name="payIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPayAllocationModel> IPayAllocationFactory.FetchAllByPayIdId(System.String payIdId)
        {
            return this.FetchAllByPayIdId(payIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PayAllocationModel" /> instances.
        /// </summary>
        /// <param name="creditIdId">
        ///     The value which identifies the <see cref="!:PayAllocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PayAllocationModel" /> instances that match the specified <paramref name="creditIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPayAllocationModel> IPayAllocationFactory.FetchAllByCreditIdId(System.String creditIdId)
        {
            return this.FetchAllByCreditIdId(creditIdId);
        }

        #endregion
    }
}
