using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="MemberLocationModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalMemberLocationFactory : LocalFactory<LocalMemberLocationModel, MemberLocationRecord, String>, IMemberLocationFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='MemberLocationModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='MemberLocationModel' /> instance.
        /// </returns>
        public LocalMemberLocationModel Create()
        {
            return new LocalMemberLocationModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='MemberLocationModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='MemberLocationModel' /> instances.
        /// </returns>
        public IEnumerable<LocalMemberLocationModel> FetchAll()
        {
            IEnumerable<MemberLocationRecord> recordCollection = this.Provider.DataProvider.Membership.MemberLocation.FetchAll();
            foreach (MemberLocationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberLocationModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='MemberLocationModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='MemberLocationModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberLocationModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalMemberLocationModel FetchById(String id)
        {
            MemberLocationRecord record = this.Provider.DataProvider.Membership.MemberLocation.FetchById(id);
            if (record == null)
                return null;
            return new LocalMemberLocationModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='MemberLocation/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Membership.MemberLocation.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MemberLocationModel' /> instances.
        /// </summary>
        /// <param name="membershipId">
        ///     The value which identifies the <see cref='MemberLocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberLocationModel' /> instances that match the specified <paramref name='membershipId' />.
        /// </returns>
        public IEnumerable<LocalMemberLocationModel> FetchAllByMembershipId(String membershipId)
        {
            IEnumerable<MemberLocationRecord> recordCollection = this.Provider.DataProvider.Membership.MemberLocation.FetchAllByMemId(membershipId);
            foreach (MemberLocationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberLocationModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MemberLocationModel' /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref='MemberLocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberLocationModel' /> instances that match the specified <paramref name='memberPeriodId' />.
        /// </returns>
        public IEnumerable<LocalMemberLocationModel> FetchAllByMemberPeriodId(String memberPeriodId)
        {
            IEnumerable<MemberLocationRecord> recordCollection = this.Provider.DataProvider.Membership.MemberLocation.FetchAllByMepId(memberPeriodId);
            foreach (MemberLocationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberLocationModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MemberLocationModel' /> instances.
        /// </summary>
        /// <param name="orgIdId">
        ///     The value which identifies the <see cref='MemberLocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberLocationModel' /> instances that match the specified <paramref name='orgIdId' />.
        /// </returns>
        public IEnumerable<LocalMemberLocationModel> FetchAllByOrgIdId(String orgIdId)
        {
            IEnumerable<MemberLocationRecord> recordCollection = this.Provider.DataProvider.Membership.MemberLocation.FetchAllByOrgId(orgIdId);
            foreach (MemberLocationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberLocationModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MemberLocationModel' /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref='MemberLocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberLocationModel' /> instances that match the specified <paramref name='roleId' />.
        /// </returns>
        public IEnumerable<LocalMemberLocationModel> FetchAllByRoleId(String roleId)
        {
            IEnumerable<MemberLocationRecord> recordCollection = this.Provider.DataProvider.Membership.MemberLocation.FetchAllByProleId(roleId);
            foreach (MemberLocationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberLocationModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MemberLocationModel' /> instances.
        /// </summary>
        /// <param name="mailAddIdId">
        ///     The value which identifies the <see cref='MemberLocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberLocationModel' /> instances that match the specified <paramref name='mailAddIdId' />.
        /// </returns>
        public IEnumerable<LocalMemberLocationModel> FetchAllByMailAddIdId(String mailAddIdId)
        {
            IEnumerable<MemberLocationRecord> recordCollection = this.Provider.DataProvider.Membership.MemberLocation.FetchAllByMailAddId(mailAddIdId);
            foreach (MemberLocationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberLocationModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MemberLocationModel' /> instances.
        /// </summary>
        /// <param name="mailInvIdId">
        ///     The value which identifies the <see cref='MemberLocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberLocationModel' /> instances that match the specified <paramref name='mailInvIdId' />.
        /// </returns>
        public IEnumerable<LocalMemberLocationModel> FetchAllByMailInvIdId(String mailInvIdId)
        {
            IEnumerable<MemberLocationRecord> recordCollection = this.Provider.DataProvider.Membership.MemberLocation.FetchAllByMailInvId(mailInvIdId);
            foreach (MemberLocationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberLocationModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MemberLocationModel' /> instances.
        /// </summary>
        /// <param name="invlnIdId">
        ///     The value which identifies the <see cref='MemberLocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberLocationModel' /> instances that match the specified <paramref name='invlnIdId' />.
        /// </returns>
        public IEnumerable<LocalMemberLocationModel> FetchAllByInvlnIdId(String invlnIdId)
        {
            IEnumerable<MemberLocationRecord> recordCollection = this.Provider.DataProvider.Membership.MemberLocation.FetchAllByInvlnId(invlnIdId);
            foreach (MemberLocationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberLocationModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MemberLocationModel' /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref='MemberLocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberLocationModel' /> instances that match the specified <paramref name='productId' />.
        /// </returns>
        public IEnumerable<LocalMemberLocationModel> FetchAllByProductId(String productId)
        {
            IEnumerable<MemberLocationRecord> recordCollection = this.Provider.DataProvider.Membership.MemberLocation.FetchAllByProdId(productId);
            foreach (MemberLocationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberLocationModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MemberLocationModel' /> instances.
        /// </summary>
        /// <param name="plIdId">
        ///     The value which identifies the <see cref='MemberLocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberLocationModel' /> instances that match the specified <paramref name='plIdId' />.
        /// </returns>
        public IEnumerable<LocalMemberLocationModel> FetchAllByPlIdId(String plIdId)
        {
            IEnumerable<MemberLocationRecord> recordCollection = this.Provider.DataProvider.Membership.MemberLocation.FetchAllByPlId(plIdId);
            foreach (MemberLocationRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberLocationModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> IMemberLocationFactory.CheckMemLocLinesToInvoice(System.String memberPeriodId, System.String userLoginId)
        {
            return this.CheckMemLocLinesToInvoice(memberPeriodId, userLoginId);
        }

        /// <summary>
        ///     Checks if Consultant scheme product already exist in database.
        /// </summary>
        /// <param name="productId">
        ///     Id of the Product.
        /// </param>
        /// <param name="memberLocationId">
        ///     Id of the Member Location.
        /// </param>
        /// <param name="memberPeriodId">
        ///     Id of the Member Period.
        /// </param>
        /// <returns>
        ///     Whether Consultant scheme product already exist in database.
        /// </returns>
        System.Boolean IMemberLocationFactory.CheckIfProductExist(System.String productId, System.String memberLocationId, System.String memberPeriodId)
        {
            return this.CheckIfProductExist(productId, memberLocationId, memberPeriodId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:MemberLocationModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MemberLocationModel" /> instance.
        /// </returns>
        Consensus.Membership.IMemberLocationModel IMemberLocationFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MemberLocationModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MemberLocationModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> IMemberLocationFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:MemberLocationModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MemberLocationModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Membership.IMemberLocationModel IMemberLocationFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IMemberLocationFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="membershipId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="membershipId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> IMemberLocationFactory.FetchAllByMembershipId(System.String membershipId)
        {
            return this.FetchAllByMembershipId(membershipId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> IMemberLocationFactory.FetchAllByMemberPeriodId(System.String memberPeriodId)
        {
            return this.FetchAllByMemberPeriodId(memberPeriodId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="orgIdId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="orgIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> IMemberLocationFactory.FetchAllByOrgIdId(System.String orgIdId)
        {
            return this.FetchAllByOrgIdId(orgIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> IMemberLocationFactory.FetchAllByRoleId(System.String roleId)
        {
            return this.FetchAllByRoleId(roleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="mailAddIdId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="mailAddIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> IMemberLocationFactory.FetchAllByMailAddIdId(System.String mailAddIdId)
        {
            return this.FetchAllByMailAddIdId(mailAddIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="mailInvIdId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="mailInvIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> IMemberLocationFactory.FetchAllByMailInvIdId(System.String mailInvIdId)
        {
            return this.FetchAllByMailInvIdId(mailInvIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="invlnIdId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="invlnIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> IMemberLocationFactory.FetchAllByInvlnIdId(System.String invlnIdId)
        {
            return this.FetchAllByInvlnIdId(invlnIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> IMemberLocationFactory.FetchAllByProductId(System.String productId)
        {
            return this.FetchAllByProductId(productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberLocationModel" /> instances.
        /// </summary>
        /// <param name="plIdId">
        ///     The value which identifies the <see cref="!:MemberLocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberLocationModel" /> instances that match the specified <paramref name="plIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberLocationModel> IMemberLocationFactory.FetchAllByPlIdId(System.String plIdId)
        {
            return this.FetchAllByPlIdId(plIdId);
        }

        #endregion
    }
}
