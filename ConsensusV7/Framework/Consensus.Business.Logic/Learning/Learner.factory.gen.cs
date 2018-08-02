using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LearnerModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalLearnerFactory : LocalFactory<LocalLearnerModel, DelegateRecord, String>, ILearnerFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='LearnerModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='LearnerModel' /> instance.
        /// </returns>
        public LocalLearnerModel Create()
        {
            return new LocalLearnerModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='LearnerModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='LearnerModel' /> instances.
        /// </returns>
        public IEnumerable<LocalLearnerModel> FetchAll()
        {
            IEnumerable<DelegateRecord> recordCollection = this.Provider.DataProvider.Learning.Learner.FetchAll();
            foreach (DelegateRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLearnerModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='LearnerModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='LearnerModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LearnerModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalLearnerModel FetchById(String id)
        {
            DelegateRecord record = this.Provider.DataProvider.Learning.Learner.FetchById(id);
            if (record == null)
                return null;
            return new LocalLearnerModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Learner/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Learning.Learner.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='LearnerModel' /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref='LearnerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LearnerModel' /> instances that match the specified <paramref name='bookingId' />.
        /// </returns>
        public IEnumerable<LocalLearnerModel> FetchAllByBookingId(String bookingId)
        {
            IEnumerable<DelegateRecord> recordCollection = this.Provider.DataProvider.Learning.Learner.FetchAllByBookId(bookingId);
            foreach (DelegateRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLearnerModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='LearnerModel' /> instances.
        /// </summary>
        /// <param name="delegateOrgId">
        ///     The value which identifies the <see cref='LearnerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LearnerModel' /> instances that match the specified <paramref name='delegateOrgId' />.
        /// </returns>
        public IEnumerable<LocalLearnerModel> FetchAllByDelegateOrgId(String delegateOrgId)
        {
            IEnumerable<DelegateRecord> recordCollection = this.Provider.DataProvider.Learning.Learner.FetchAllByOrgId(delegateOrgId);
            foreach (DelegateRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLearnerModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='LearnerModel' /> instances.
        /// </summary>
        /// <param name="delegatePersonId">
        ///     The value which identifies the <see cref='LearnerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LearnerModel' /> instances that match the specified <paramref name='delegatePersonId' />.
        /// </returns>
        public IEnumerable<LocalLearnerModel> FetchAllByDelegatePersonId(String delegatePersonId)
        {
            IEnumerable<DelegateRecord> recordCollection = this.Provider.DataProvider.Learning.Learner.FetchAllByPersonId(delegatePersonId);
            foreach (DelegateRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLearnerModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='LearnerModel' /> instances.
        /// </summary>
        /// <param name="delegateRoleId">
        ///     The value which identifies the <see cref='LearnerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LearnerModel' /> instances that match the specified <paramref name='delegateRoleId' />.
        /// </returns>
        public IEnumerable<LocalLearnerModel> FetchAllByDelegateRoleId(String delegateRoleId)
        {
            IEnumerable<DelegateRecord> recordCollection = this.Provider.DataProvider.Learning.Learner.FetchAllByProleId(delegateRoleId);
            foreach (DelegateRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLearnerModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='LearnerModel' /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref='LearnerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LearnerModel' /> instances that match the specified <paramref name='memberPeriodId' />.
        /// </returns>
        public IEnumerable<LocalLearnerModel> FetchAllByMemberPeriodId(String memberPeriodId)
        {
            IEnumerable<DelegateRecord> recordCollection = this.Provider.DataProvider.Learning.Learner.FetchAllByMepId(memberPeriodId);
            foreach (DelegateRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLearnerModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='LearnerModel' /> instances.
        /// </summary>
        /// <param name="delegateAddressId">
        ///     The value which identifies the <see cref='LearnerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LearnerModel' /> instances that match the specified <paramref name='delegateAddressId' />.
        /// </returns>
        public IEnumerable<LocalLearnerModel> FetchAllByDelegateAddressId(String delegateAddressId)
        {
            IEnumerable<DelegateRecord> recordCollection = this.Provider.DataProvider.Learning.Learner.FetchAllByAddId(delegateAddressId);
            foreach (DelegateRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLearnerModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        Consensus.Learning.ILearnerModel ILearnerFactory.DelegatesToConfirm(System.String bookId, System.String approver)
        {
            return this.DelegatesToConfirm(bookId, approver);
        }

        Consensus.Learning.ILearnerModel ILearnerFactory.CancelBooking(System.String bookId, System.String userLoginId)
        {
            return this.CancelBooking(bookId, userLoginId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:LearnerModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LearnerModel" /> instance.
        /// </returns>
        Consensus.Learning.ILearnerModel ILearnerFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LearnerModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LearnerModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ILearnerModel> ILearnerFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LearnerModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LearnerModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.ILearnerModel ILearnerFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ILearnerFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="bookingId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="bookingId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ILearnerModel> ILearnerFactory.FetchAllByBookingId(System.String bookingId)
        {
            return this.FetchAllByBookingId(bookingId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="delegateOrgId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="delegateOrgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ILearnerModel> ILearnerFactory.FetchAllByDelegateOrgId(System.String delegateOrgId)
        {
            return this.FetchAllByDelegateOrgId(delegateOrgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="delegatePersonId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="delegatePersonId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ILearnerModel> ILearnerFactory.FetchAllByDelegatePersonId(System.String delegatePersonId)
        {
            return this.FetchAllByDelegatePersonId(delegatePersonId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="delegateRoleId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="delegateRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ILearnerModel> ILearnerFactory.FetchAllByDelegateRoleId(System.String delegateRoleId)
        {
            return this.FetchAllByDelegateRoleId(delegateRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ILearnerModel> ILearnerFactory.FetchAllByMemberPeriodId(System.String memberPeriodId)
        {
            return this.FetchAllByMemberPeriodId(memberPeriodId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LearnerModel" /> instances.
        /// </summary>
        /// <param name="delegateAddressId">
        ///     The value which identifies the <see cref="!:LearnerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearnerModel" /> instances that match the specified <paramref name="delegateAddressId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ILearnerModel> ILearnerFactory.FetchAllByDelegateAddressId(System.String delegateAddressId)
        {
            return this.FetchAllByDelegateAddressId(delegateAddressId);
        }

        #endregion
    }
}
