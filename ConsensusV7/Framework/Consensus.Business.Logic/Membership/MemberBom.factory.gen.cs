using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="MemberBomModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalMemberBomFactory : LocalFactory<LocalMemberBomModel, MemberBomRecord, String>, IMemberBomFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='MemberBomModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='MemberBomModel' /> instance.
        /// </returns>
        public LocalMemberBomModel Create()
        {
            return new LocalMemberBomModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='MemberBomModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='MemberBomModel' /> instances.
        /// </returns>
        public IEnumerable<LocalMemberBomModel> FetchAll()
        {
            IEnumerable<MemberBomRecord> recordCollection = this.Provider.DataProvider.Membership.MemberBom.FetchAll();
            foreach (MemberBomRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberBomModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='MemberBomModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='MemberBomModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberBomModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalMemberBomModel FetchById(String id)
        {
            MemberBomRecord record = this.Provider.DataProvider.Membership.MemberBom.FetchById(id);
            if (record == null)
                return null;
            return new LocalMemberBomModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='MemberBom/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Membership.MemberBom.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MemberBomModel' /> instances.
        /// </summary>
        /// <param name="prodParentIdId">
        ///     The value which identifies the <see cref='MemberBomModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberBomModel' /> instances that match the specified <paramref name='prodParentIdId' />.
        /// </returns>
        public IEnumerable<LocalMemberBomModel> FetchAllByProdParentIdId(String prodParentIdId)
        {
            IEnumerable<MemberBomRecord> recordCollection = this.Provider.DataProvider.Membership.MemberBom.FetchAllByParentId(prodParentIdId);
            foreach (MemberBomRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberBomModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='MemberBomModel' /> instances.
        /// </summary>
        /// <param name="gradeProdId">
        ///     The value which identifies the <see cref='MemberBomModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberBomModel' /> instances that match the specified <paramref name='gradeProdId' />.
        /// </returns>
        public IEnumerable<LocalMemberBomModel> FetchAllByGradeProdId(String gradeProdId)
        {
            IEnumerable<MemberBomRecord> recordCollection = this.Provider.DataProvider.Membership.MemberBom.FetchAllByGradeId(gradeProdId);
            foreach (MemberBomRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalMemberBomModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Check if same grade already exist.
        /// </summary>
        /// <param name="parentProdId">
        ///     Parent product Id.
        /// </param>
        /// <param name="gradeId">
        ///     Existing Grade Id.
        /// </param>
        /// <param name="MBomId">
        ///     available Grade Id.
        /// </param>
        /// <returns>
        ///     returns true if same grade alraedy exists for memebershipProduct - parentProdId.
        /// </returns>
        System.Boolean IMemberBomFactory.CheckIfGradeExist(System.String parentProdId, System.String gradeId, System.String MBomId)
        {
            return this.CheckIfGradeExist(parentProdId, gradeId, MBomId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:MemberBomModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MemberBomModel" /> instance.
        /// </returns>
        Consensus.Membership.IMemberBomModel IMemberBomFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MemberBomModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MemberBomModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberBomModel> IMemberBomFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:MemberBomModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MemberBomModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberBomModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Membership.IMemberBomModel IMemberBomFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IMemberBomFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberBomModel" /> instances.
        /// </summary>
        /// <param name="prodParentIdId">
        ///     The value which identifies the <see cref="!:MemberBomModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberBomModel" /> instances that match the specified <paramref name="prodParentIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberBomModel> IMemberBomFactory.FetchAllByProdParentIdId(System.String prodParentIdId)
        {
            return this.FetchAllByProdParentIdId(prodParentIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:MemberBomModel" /> instances.
        /// </summary>
        /// <param name="gradeProdId">
        ///     The value which identifies the <see cref="!:MemberBomModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MemberBomModel" /> instances that match the specified <paramref name="gradeProdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IMemberBomModel> IMemberBomFactory.FetchAllByGradeProdId(System.String gradeProdId)
        {
            return this.FetchAllByGradeProdId(gradeProdId);
        }

        #endregion
    }
}
