using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="BranchModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalBranchFactory : LocalFactory<LocalBranchModel, BranchRecord, String>, IBranchFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='BranchModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='BranchModel' /> instance.
        /// </returns>
        public LocalBranchModel Create()
        {
            return new LocalBranchModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='BranchModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='BranchModel' /> instances.
        /// </returns>
        public IEnumerable<LocalBranchModel> FetchAll()
        {
            IEnumerable<BranchRecord> recordCollection = this.Provider.DataProvider.Membership.Branch.FetchAll();
            foreach (BranchRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalBranchModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='BranchModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='BranchModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='BranchModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalBranchModel FetchById(String id)
        {
            BranchRecord record = this.Provider.DataProvider.Membership.Branch.FetchById(id);
            if (record == null)
                return null;
            return new LocalBranchModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Branch/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Membership.Branch.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:BranchModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BranchModel" /> instance.
        /// </returns>
        Consensus.Membership.IBranchModel IBranchFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BranchModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BranchModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IBranchModel> IBranchFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:BranchModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BranchModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BranchModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Membership.IBranchModel IBranchFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IBranchFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
