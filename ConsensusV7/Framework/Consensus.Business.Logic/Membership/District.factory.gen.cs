using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="DistrictModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalDistrictFactory : LocalFactory<LocalDistrictModel, DistrictRecord, String>, IDistrictFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='DistrictModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='DistrictModel' /> instance.
        /// </returns>
        public LocalDistrictModel Create()
        {
            return new LocalDistrictModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='DistrictModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='DistrictModel' /> instances.
        /// </returns>
        public IEnumerable<LocalDistrictModel> FetchAll()
        {
            IEnumerable<DistrictRecord> recordCollection = this.Provider.DataProvider.Membership.District.FetchAll();
            foreach (DistrictRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalDistrictModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='DistrictModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='DistrictModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='DistrictModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalDistrictModel FetchById(String id)
        {
            DistrictRecord record = this.Provider.DataProvider.Membership.District.FetchById(id);
            if (record == null)
                return null;
            return new LocalDistrictModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='District/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Membership.District.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:DistrictModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:DistrictModel" /> instance.
        /// </returns>
        Consensus.Membership.IDistrictModel IDistrictFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:DistrictModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:DistrictModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.IDistrictModel> IDistrictFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:DistrictModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:DistrictModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:DistrictModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Membership.IDistrictModel IDistrictFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IDistrictFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
