using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="MembershipModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalMembershipFactory : LocalFactory<LocalMembershipModel, MembershipRecord, String>, IMembershipFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='MembershipModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='MembershipModel' /> instance.
        /// </returns>
        public LocalMembershipModel Create()
        {
            return new LocalMembershipModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='MembershipModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='MembershipModel' /> instances.
        /// </returns>
        public IEnumerable<LocalMembershipModel> FetchAll()
        {
            IEnumerable<MembershipRecord> recordCollection = this.Provider.DataProvider.Membership.Membership.FetchAll();
            foreach (MembershipRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMembershipModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='MembershipModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='MembershipModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MembershipModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalMembershipModel FetchById(String id)
        {
            MembershipRecord record = this.Provider.DataProvider.Membership.Membership.FetchById(id);
            if (record == null)
                return null;
            return new LocalMembershipModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Membership/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Membership.Membership.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:MembershipModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MembershipModel" /> instance.
        /// </returns>
        Consensus.Membership.IMembershipModel IMembershipFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MembershipModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MembershipModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMembershipModel> IMembershipFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:MembershipModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MembershipModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MembershipModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Membership.IMembershipModel IMembershipFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IMembershipFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
