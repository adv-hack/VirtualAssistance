using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="BranchXrefModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalBranchXrefFactory : LocalFactory<LocalBranchXrefModel, BranchXrefRecord, String>, IBranchXrefFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='BranchXrefModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='BranchXrefModel' /> instance.
        /// </returns>
        public LocalBranchXrefModel Create()
        {
            return new LocalBranchXrefModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='BranchXrefModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='BranchXrefModel' /> instances.
        /// </returns>
        public IEnumerable<LocalBranchXrefModel> FetchAll()
        {
            IEnumerable<BranchXrefRecord> recordCollection = this.Provider.DataProvider.Membership.BranchXref.FetchAll();
            foreach (BranchXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBranchXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='BranchXrefModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='BranchXrefModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BranchXrefModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalBranchXrefModel FetchById(String id)
        {
            BranchXrefRecord record = this.Provider.DataProvider.Membership.BranchXref.FetchById(id);
            if (record == null)
                return null;
            return new LocalBranchXrefModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='BranchXref/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Membership.BranchXref.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='BranchXrefModel' /> instances.
        /// </summary>
        /// <param name="branchId">
        ///     The value which identifies the <see cref='BranchXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BranchXrefModel' /> instances that match the specified <paramref name='branchId' />.
        /// </returns>
        public IEnumerable<LocalBranchXrefModel> FetchAllByBranchId(String branchId)
        {
            IEnumerable<BranchXrefRecord> recordCollection = this.Provider.DataProvider.Membership.BranchXref.FetchAllByBrId(branchId);
            foreach (BranchXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBranchXrefModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Checks if district already exist for that branch in database.
        /// </summary>
        /// <param name="branchid">
        ///     BranchId.
        /// </param>
        /// <param name="districtid">
        ///     DistrictId.
        /// </param>
        /// <param name="branchxrefid">
        ///     BranchXrefId.
        /// </param>
        /// <returns>
        ///     Whether that district already exist for that branch in database.
        /// </returns>
        System.Boolean IBranchXrefFactory.CheckIfDistrictExist(System.String branchid, System.String districtid, System.String branchxrefid)
        {
            return this.CheckIfDistrictExist(branchid, districtid, branchxrefid);
        }

        /// <summary>
        ///     Creates a new <see cref="!:BranchXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BranchXrefModel" /> instance.
        /// </returns>
        Consensus.Membership.IBranchXrefModel IBranchXrefFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BranchXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BranchXrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IBranchXrefModel> IBranchXrefFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:BranchXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BranchXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BranchXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Membership.IBranchXrefModel IBranchXrefFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IBranchXrefFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BranchXrefModel" /> instances.
        /// </summary>
        /// <param name="branchId">
        ///     The value which identifies the <see cref="!:BranchXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BranchXrefModel" /> instances that match the specified <paramref name="branchId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IBranchXrefModel> IBranchXrefFactory.FetchAllByBranchId(System.String branchId)
        {
            return this.FetchAllByBranchId(branchId);
        }

        #endregion
    }
}
