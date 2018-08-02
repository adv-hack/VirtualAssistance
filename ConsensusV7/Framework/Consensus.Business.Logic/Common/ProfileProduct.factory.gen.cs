using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProfileProductModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProfileProductFactory : LocalFactory<LocalProfileProductModel, ProfileRecord, String>, IProfileProductFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ProfileProductModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ProfileProductModel' /> instance.
        /// </returns>
        public LocalProfileProductModel Create()
        {
            return new LocalProfileProductModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ProfileProductModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ProfileProductModel' /> instances.
        /// </returns>
        public IEnumerable<LocalProfileProductModel> FetchAll()
        {
            IEnumerable<ProfileRecord> recordCollection = this.Provider.DataProvider.Common.Profile.FetchAll();
            foreach (ProfileRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProfileProductModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ProfileProductModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ProfileProductModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProfileProductModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalProfileProductModel FetchById(String id)
        {
            ProfileRecord record = this.Provider.DataProvider.Common.Profile.FetchById(id);
            if (record == null)
                return null;
            return new LocalProfileProductModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ProfileProduct/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Common.Profile.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ProfileProductModel' /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref='ProfileProductModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProfileProductModel' /> instances that match the specified <paramref name='productId' />.
        /// </returns>
        public IEnumerable<LocalProfileProductModel> FetchAllByProductId(String productId)
        {
            IEnumerable<ProfileRecord> recordCollection = this.Provider.DataProvider.Common.Profile.FetchAllByProdId(productId);
            foreach (ProfileRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProfileProductModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ProfileProductModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileProductModel" /> instance.
        /// </returns>
        Consensus.Common.IProfileProductModel IProfileProductFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileProductModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileProductModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileProductModel> IProfileProductFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileProductModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileProductModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileProductModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IProfileProductModel IProfileProductFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IProfileProductFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfileProductModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:ProfileProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileProductModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileProductModel> IProfileProductFactory.FetchAllByProductId(System.String productId)
        {
            return this.FetchAllByProductId(productId);
        }

        #endregion
    }
}
